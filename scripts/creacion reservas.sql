CREATE TABLE Reservas (
    id_reserva INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT,
    fecha_emision_reserva DATE,
    fecha_retiro_reserva DATE,
    total_reserva DECIMAL,
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente)
);

EXEC sp_rename 'Reservas.fecha_vencimiento_reserva', 'fecha_retiro_reserva', 'COLUMN';

CREATE TABLE DetallesReservas (
    id_detalle_reserva INT IDENTITY(1,1) PRIMARY KEY,
    id_reserva INT,
    id_producto INT,
    cantidad INT,
    precio_unitario DECIMAL,
    FOREIGN KEY (id_reserva) REFERENCES Reservas(id_reserva),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

EXEC sp_rename 'DetallesReservas.subtotal', 'precio_unitario', 'COLUMN';


--1.REGISTRAR RESERVAS Y DETALLES
CREATE TYPE TIPO_DETALLE_RESERVA AS TABLE
(
    id_producto INT,
    cantidad INT,
    precio_unitario DECIMAL(10, 2)
);
GO

CREATE OR ALTER PROCEDURE PROC_REGISTRAR_RESERVA_TRANSACCION
    @id_cliente INT,
    @fecha_emision_reserva DATE,
    @fecha_retiro_reserva DATE,
    @total_reserva DECIMAL(10, 2),

    @detalles_reserva AS TIPO_DETALLE_RESERVA READONLY,
    
    @id_reserva_generada INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @id_reserva_generada = 0;
    SET @mensaje = '';

    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Insertar la reserva principal
        INSERT INTO Reservas (id_cliente, fecha_emision_reserva, fecha_retiro_reserva, total_reserva)
        VALUES (@id_cliente, @fecha_emision_reserva, @fecha_retiro_reserva, @total_reserva);

        SET @id_reserva_generada = SCOPE_IDENTITY();

        -- 2. Insertar los detalles de la reserva
        INSERT INTO DetallesReservas (id_reserva, id_producto, cantidad, precio_unitario)
        SELECT @id_reserva_generada, id_producto, cantidad, precio_unitario
        FROM @detalles_reserva;
        
        -- 3. Actualizar el stock de los productos
        UPDATE P
        SET P.stock = P.stock - DR.cantidad
        FROM Productos P
        INNER JOIN @detalles_reserva DR ON P.id_producto = DR.id_producto;

        -- Confirmar la transacción si todas las operaciones son exitosas
        COMMIT TRANSACTION;
        SET @mensaje = 'Reserva registrada y stock reservado exitosamente.';

    END TRY
    BEGIN CATCH
        -- Si ocurre un error, revertir la transacción para mantener la consistencia
        ROLLBACK TRANSACTION;
        SET @id_reserva_generada = 0;
        SET @mensaje = 'Error al registrar la reserva. Se ha cancelado la operación. ' + ERROR_MESSAGE();
    END CATCH;
END;
GO


--2. BUSCAR RESERVAS

CREATE OR ALTER PROCEDURE PROC_BUSCAR_RESERVAS
    @id_cliente INT = NULL,
    @fecha_emision_inicio DATE = NULL,
    @fecha_emision_fin DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        r.id_reserva,
        r.fecha_emision_reserva,
        r.fecha_retiro_reserva,
        r.total_reserva,
        c.nombre_cliente,
        c.apellido_cliente
    FROM
        Reservas r
    INNER JOIN
        Clientes c ON r.id_cliente = c.id_cliente
    WHERE
        (@id_cliente IS NULL OR r.id_cliente = @id_cliente)
        AND (@fecha_emision_inicio IS NULL OR r.fecha_emision_reserva >= @fecha_emision_inicio)
        AND (@fecha_emision_fin IS NULL OR r.fecha_emision_reserva <= @fecha_emision_fin)
    ORDER BY
        r.fecha_emision_reserva DESC;
END
GO

--3. procedimiento para dar por retirada una reserva

CREATE OR ALTER PROCEDURE PROC_FINALIZAR_RESERVA
    @id_reserva INT,
    @fecha_retiro_reserva DATE,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @mensaje = '';

    -- Comienza la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @cliente_id INT;

        -- 1. Revisa si la reserva existe
        SELECT @cliente_id = id_cliente
        FROM Reservas
        WHERE id_reserva = @id_reserva;

        IF @cliente_id IS NULL
        BEGIN
            SET @mensaje = 'La reserva con el ID especificado no existe.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Actualiza la reserva en su retiro
        UPDATE R
        SET fecha_retiro_reserva = @fecha_retiro_reserva
		FROM Reservas R
            -- tomamos fecha de retiro != NULL como reserva completada
            -- total_reserva = total_reserva --el total de la reserva podríamos recalcularlo en base a algun interes diario
        WHERE id_reserva = @id_reserva;

        -- 3. Si todo va bien, confirma la transacción
        COMMIT TRANSACTION;
        SET @mensaje = 'Reserva finalizada y stock actualizado exitosamente.';
    END TRY
    BEGIN CATCH
        -- 4. Si ocurre un error, hacemos rollback
        ROLLBACK TRANSACTION;
        SET @mensaje = 'Error al finalizar la reserva. La operación ha sido cancelada. ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--4 Deshacer Reserva

CREATE OR ALTER PROCEDURE PROC_CANCELAR_RESERVA_TRANSACCION
    @id_reserva INT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @mensaje = '';

    -- Iniciar la transacción para asegurar la atomicidad
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Verificar si la reserva existe antes de continuar
        IF NOT EXISTS (SELECT 1 FROM Reservas WHERE id_reserva = @id_reserva)
        BEGIN
            SET @mensaje = 'La reserva con el ID especificado no existe.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Restaurar el stock de los productos de la reserva
        -- Sumamos la cantidad de los detalles de la reserva de vuelta al stock de los productos.
        UPDATE P
        SET P.stock = P.stock + DR.cantidad
        FROM Productos P
        INNER JOIN DetallesReservas DR ON P.id_producto = DR.id_producto
        WHERE DR.id_reserva = @id_reserva;

        -- 3. Eliminar los detalles de la reserva
        -- Es necesario eliminar primero los detalles debido a la relación de clave foránea.
        DELETE FROM DetallesReservas WHERE id_reserva = @id_reserva;

        -- 4. Eliminar la reserva principal
        DELETE FROM Reservas WHERE id_reserva = @id_reserva;
        
        -- Si todas las operaciones son exitosas, confirmar la transacción
        COMMIT TRANSACTION;
        SET @mensaje = 'Reserva cancelada y stock restaurado exitosamente.';

    END TRY
    BEGIN CATCH
        -- Si ocurre un error, revertir la transacción para mantener la consistencia
        ROLLBACK TRANSACTION;
        SET @mensaje = 'Error al cancelar la reserva. Se ha cancelado la operación. ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

--5. Transformar Reserva en Venta

CREATE OR ALTER PROCEDURE PROC_FINALIZAR_RESERVA_A_VENTA
    @id_reserva INT,
    @total_venta DECIMAL(12, 2),
    @id_medio INT,
    @id_user INT,
    @id_cliente INT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @mensaje = '';

    -- Iniciar la transacción para asegurar la atomicidad
    BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @id_venta_generada INT;

        -- 1. Insertar la nueva venta
        INSERT INTO Ventas (total, id_medio, id_user, id_cliente, fecha_venta)
        VALUES (@total_venta, @id_medio, @id_user, @id_cliente, GETDATE());

        SET @id_venta_generada = SCOPE_IDENTITY();

        -- 2. Copiar los detalles de la reserva a los detalles de la venta
        -- La clave es que el subtotal en DetalleVentas se basará en el precio unitario
        INSERT INTO DetalleVentas (id_venta, id_producto, cantidad, subtotal)
        SELECT @id_venta_generada, id_producto, cantidad, (precio_unitario * cantidad)
        FROM DetallesReservas
        WHERE id_reserva = @id_reserva;

        -- 3. Actualizar la reserva para finalizarla (asignar fecha de retiro)
        UPDATE R
        SET fecha_retiro_reserva = GETDATE()
		FROM Reservas R
        WHERE id_reserva = @id_reserva;

        -- Si todo es exitoso, confirmar la transacción
        COMMIT TRANSACTION;
        SET @mensaje = 'Reserva transformada en venta y finalizada exitosamente.';

    END TRY
    BEGIN CATCH
        -- Si algo falla, revertir la transacción
        ROLLBACK TRANSACTION;
        SET @mensaje = 'Error al transformar la reserva en venta. La operación ha sido cancelada. ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

ALTER TABLE Ventas
ADD 
    id_cliente INT
	FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente);