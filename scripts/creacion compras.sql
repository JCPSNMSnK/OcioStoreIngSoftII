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
    subtotal DECIMAL(10, 2),
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

CREATE PROCEDURE PROC_REGISTRAR_COMPRA
    @id_proveedor INT,
    @total DECIMAL(10, 2),
    @fecha_compra DATE,
    @xml_detalles XML, -- Recibe los detalles de la compra como XML
    @id_compra_generada INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    -- No es necesario el SET NOCOUNT ON; en este caso.

    -- Definir variables
    DECLARE @id_compra_nueva INT;
    DECLARE @ErrorState INT;
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorMessage NVARCHAR(4000);

    -- Iniciar la transacción
    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Insertar la compra en la tabla de Compras
        INSERT INTO Compras (id_proveedor, fecha_compra, total)
        VALUES (@id_proveedor, @fecha_compra, @total);

        -- Obtener el ID de la compra recién insertada
        SET @id_compra_nueva = SCOPE_IDENTITY();
        SET @id_compra_generada = @id_compra_nueva;

        -- 2. Insertar los detalles de la compra desde el XML
        INSERT INTO DetallesCompras (id_compra, id_producto, cantidad, subtotal)
        SELECT
            @id_compra_nueva AS id_compra,
            T.Item.value('id_producto[1]', 'INT') AS id_producto,
            T.Item.value('cantidad[1]', 'INT') AS cantidad,
            T.Item.value('subtotal[1]', 'DECIMAL(10,2)') AS subtotal
        FROM
            @xml_detalles.nodes('/Detalles/Detalle') AS T(Item);

        -- 3. Confirmar la transacción si todo fue exitoso
        COMMIT TRANSACTION;
        SET @mensaje = 'Compra registrada exitosamente.';

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

        SET @mensaje = 'Error al registrar la compra: ' + @ErrorMessage;
        SET @id_compra_generada = 0; -- Establecer el ID en 0 para indicar que no se generó
    
        -- Opcional: Relanzar el error para un manejo más detallado si es necesario
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

