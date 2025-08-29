CREATE TABLE Reservas (
    id_reserva INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT,
    fecha_emision_reserva DATE,
    fecha_vencimiento_reserva DATE,
    total_reserva DECIMAL,
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente)
);

CREATE TABLE DetallesReservas (
    id_detalle_reserva INT IDENTITY(1,1) PRIMARY KEY,
    id_reserva INT,
    id_producto INT,
    cantidad INT,
    subtotal DECIMAL,
    FOREIGN KEY (id_reserva) REFERENCES Reservas(id_reserva),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

--1.REGISTRAR RESERVAS Y DETALLES

CREATE PROCEDURE PROC_REGISTRAR_RESERVA
    @id_cliente INT,
    @fecha_emision_reserva DATE,
    @fecha_vencimiento_reserva DATE,
    @total_reserva FLOAT,
    @xml_detalles XML, -- Recibe los detalles como XML
    @id_reserva_generada INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorState INT;
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorMessage NVARCHAR(4000);
    
    -- Inicializar variables de salida
    SET @id_reserva_generada = 0;
    SET @mensaje = '';

    -- Iniciar la transacción
    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Insertar la reserva principal
        INSERT INTO Reservas (id_cliente, fecha_emision_reserva, fecha_vencimiento_reserva, total_reserva)
        VALUES (@id_cliente, @fecha_emision_reserva, @fecha_vencimiento_reserva, @total_reserva);

        -- Obtener el ID de la reserva recién insertada
        SET @id_reserva_generada = SCOPE_IDENTITY();

        -- 2. Insertar los detalles de la reserva desde el XML
        INSERT INTO DetallesReservas (id_reserva, id_producto, cantidad)
        SELECT
            @id_reserva_generada AS id_reserva,
            T.Item.value('id_producto[1]', 'INT') AS id_producto,
            T.Item.value('cantidad[1]', 'INT') AS cantidad
        FROM
            @xml_detalles.nodes('/Detalles/Detalle') AS T(Item);
        
        -- 3. Confirmar la transacción
        COMMIT TRANSACTION;
        SET @mensaje = 'Reserva registrada exitosamente.';
    END TRY
    BEGIN CATCH
        -- 4. Revertir la transacción en caso de error
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Capturar el error y guardar el mensaje
        SELECT
            @ErrorState = ERROR_STATE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorMessage = ERROR_MESSAGE();

        SET @mensaje = 'Error al registrar la reserva: ' + @ErrorMessage;
        SET @id_reserva_generada = 0;
        
        -- Opcional: Relanzar el error para un manejo más detallado
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

--2. BUSCAR RESERVAS

CREATE PROCEDURE PROC_BUSCAR_RESERVAS
    @id_cliente INT = NULL,
    @fecha_emision_inicio DATE = NULL,
    @fecha_emision_fin DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        r.id_reserva,
        r.fecha_emision_reserva,
        r.fecha_vencimiento_reserva,
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

--3. procedimiento para dar por buena/vencida una reserva? alter table?