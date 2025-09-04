CREATE TABLE Compras (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_proveedor INT,
    fecha_compra DATE,
    total DECIMAL(10, 2),
    FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor)
);

CREATE TABLE DetallesCompras (
    id_detalle_compra INT IDENTITY(1,1) PRIMARY KEY,
    id_compra INT,
    id_producto INT,
    precio_unitario DECIMAL(10, 2),
    cantidad INT,
    FOREIGN KEY (id_compra) REFERENCES Compras(id_compra),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

--1.. PROCEDIMIENTO BUSCAR COMPRAS

CREATE PROCEDURE PROC_BUSCAR_COMPRAS
    @id_proveedor INT = NULL,
    @fecha_inicio DATE = NULL,
    @fecha_fin DATE = NULL,
    @total_min DECIMAL(10, 2) = NULL,
    @total_max DECIMAL(10, 2) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_compra,
        c.fecha_compra,
        c.total,
        p.nombre_proveedor
    FROM
        Compras c
    INNER JOIN
        Proveedores p ON c.id_proveedor = p.id_proveedor
    WHERE
        (@id_proveedor IS NULL OR c.id_proveedor = @id_proveedor)
        AND (@fecha_inicio IS NULL OR c.fecha_compra >= @fecha_inicio)
        AND (@fecha_fin IS NULL OR c.fecha_compra <= @fecha_fin)
        AND (@total_min IS NULL OR c.total >= @total_min)
        AND (@total_max IS NULL OR c.total <= @total_max)
    ORDER BY
        c.fecha_compra DESC;
END
GO

--2. REGISTRAR COMPRA

CREATE TYPE TIPO_DETALLE_COMPRA AS TABLE
(
    id_producto INT,
    cantidad INT,
    precio_unitario DECIMAL(10, 2)
);
GO

CREATE OR ALTER PROCEDURE PROC_REGISTRAR_COMPRA_TRANSACCION
    @id_proveedor INT,
    @total_compra DECIMAL(10, 2),

    @detalles_compra AS TIPO_DETALLE_COMPRA READONLY,

    @id_compra_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @id_compra_generado = 0;
    SET @mensaje = '';

    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Insertar la compra principal en la tabla Compras
        INSERT INTO Compras (id_proveedor, total_compra, fecha_compra)
        VALUES (@id_proveedor, @total_compra, GETDATE());

        SET @id_compra_generado = SCOPE_IDENTITY();

        -- 2. Insertar los detalles de la compra en la tabla DetallesCompras
        INSERT INTO DetallesCompras (id_compra, id_producto, precio_unitario, cantidad)
        SELECT @id_compra_generado, id_producto, precio_unitario, cantidad
        FROM @detalles_compra;
        
        -- 3. Actualizar el stock de los productos comprados
        UPDATE P
        SET P.stock = P.stock + DC.cantidad
        FROM Productos P
        INNER JOIN @detalles_compra DC ON P.id_producto = DC.id_producto;

        -- Confirmar la transacción si todas las operaciones son exitosas
        COMMIT TRANSACTION;
        SET @mensaje = 'Compra registrada y stock actualizado exitosamente.';

    END TRY
    BEGIN CATCH
        -- Si ocurre un error, revertir la transacción para mantener la consistencia
        ROLLBACK TRANSACTION;
        SET @id_compra_generado = 0;
        SET @mensaje = 'Error al registrar la compra. Se ha cancelado la operación. ' + ERROR_MESSAGE();
    END CATCH;
END;
GO

