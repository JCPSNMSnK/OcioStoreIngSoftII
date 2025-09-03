CREATE TABLE Facturas (
    id_factura INT IDENTITY(1,1) PRIMARY KEY,
    id_venta INT,
    id_tipo_factura INT,
    fecha_emision DATE,
    FOREIGN KEY (id_venta) REFERENCES Ventas(id_venta),
    FOREIGN KEY (id_tipo_factura) REFERENCES TiposFactura(id_tipo_factura)
);

CREATE TABLE TiposFactura (
    id_tipo_factura INT IDENTITY(1,1) PRIMARY KEY,
    nombre_tipo_factura VARCHAR(100) UNIQUE,
    descripcion VARCHAR(100)
);

--1. REGISTRAR FACTURA

CREATE PROCEDURE PROC_REGISTRAR_FACTURA
    @id_venta INT,
    @id_tipo_factura INT,
    @fecha_emision DATE,
    @id_factura_generada INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variables de salida
    SET @id_factura_generada = 0;
    SET @mensaje = '';

    -- Validar si las claves foráneas existen
    IF NOT EXISTS (SELECT 1 FROM Ventas WHERE id_venta = @id_venta)
    BEGIN
        SET @mensaje = 'Error: La venta con el ID especificado no existe.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM TiposFactura WHERE id_tipo_factura = @id_tipo_factura)
    BEGIN
        SET @mensaje = 'Error: El tipo de factura con el ID especificado no existe.';
        RETURN;
    END

    -- Intentar insertar la factura
    BEGIN TRY
        INSERT INTO Facturas (id_venta, id_tipo_factura, fecha_emision)
        VALUES (@id_venta, @id_tipo_factura, @fecha_emision);

        -- Obtener el ID de la factura recién insertada
        SET @id_factura_generada = SCOPE_IDENTITY();
        SET @mensaje = 'Factura registrada exitosamente.';
    END TRY
    BEGIN CATCH
        -- En caso de error, capturar el mensaje
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al registrar la factura: ' + @ErrorMensaje;
        SET @id_factura_generada = 0;
    END CATCH
END;
GO

--2.REGISTRAR TIPO DE FACTURA

CREATE PROCEDURE PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura VARCHAR(50),
    @id_tipo_factura_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variables de salida
    SET @id_tipo_factura_generado = 0;
    SET @mensaje = '';

    -- Validar si el nombre del tipo de factura ya existe para evitar duplicados
    IF EXISTS (SELECT 1 FROM TiposFactura WHERE nombre_tipo_factura = @nombre_tipo_factura)
    BEGIN
        SET @mensaje = 'Error: El tipo de factura con este nombre ya existe.';
        RETURN;
    END

    -- Intentar insertar el nuevo tipo de factura
    BEGIN TRY
        INSERT INTO TiposFactura (nombre_tipo_factura)
        VALUES (@nombre_tipo_factura);

        -- Obtener el ID del tipo de factura recién insertado
        SET @id_tipo_factura_generado = SCOPE_IDENTITY();
        SET @mensaje = 'Tipo de factura registrado exitosamente.';
    END TRY
    BEGIN CATCH
        -- En caso de error, capturar el mensaje
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al registrar el tipo de factura: ' + @ErrorMensaje;
        SET @id_tipo_factura_generado = 0;
    END CATCH
END;
GO

--3. BUSCAR FACTURAS POR FECHAS, CLIENTES, TIPO

CREATE PROCEDURE PROC_BUSCAR_FACTURAS
    @id_cliente INT = NULL,
    @fecha_inicio DATE = NULL,
    @fecha_fin DATE = NULL,
    @id_tipo_factura INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- SELECT de las columnas a mostrar
    SELECT
        f.id_factura,
        f.fecha_emision,
        c.nombre_cliente,
        c.apellido_cliente,
        v.total AS total_venta,
        tf.nombre_tipo_factura
    FROM
        Facturas f
    -- El INNER JOIN a Clientes se movió y ahora pasa a través de Ventas.
    INNER JOIN
        Ventas v ON f.id_venta = v.id_venta -- Conecta Facturas con Ventas
    INNER JOIN
        Clientes c ON v.id_cliente = c.id_cliente -- Conecta Ventas con Clientes
    INNER JOIN
        TiposFactura tf ON f.id_tipo_factura = tf.id_tipo_factura
    WHERE
        -- El filtro por cliente ahora usa la tabla Ventas
        (@id_cliente IS NULL OR v.id_cliente = @id_cliente)
        AND (@fecha_inicio IS NULL OR f.fecha_emision >= @fecha_inicio)
        AND (@fecha_fin IS NULL OR f.fecha_emision <= @fecha_fin)
        AND (@id_tipo_factura IS NULL OR f.id_tipo_factura = @id_tipo_factura)
    ORDER BY
        f.fecha_emision DESC;
END
GO
