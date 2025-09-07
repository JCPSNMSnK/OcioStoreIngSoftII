--1. Procedimiento para Insertar elementos DEPRECADO, VER ULTIMO AÑADIDO
CREATE OR ALTER PROCEDURE PROC_CREAR_PRODUCTO
    @nombre_producto VARCHAR(100),
    @id_categoria INT,
	@fechaIngreso DATE,
    @precioLista DECIMAL(10,2),
    @precioVenta DECIMAL(10,2),
    @stock INT,
    @stock_min INT,
    @eliminado BIT,
    @descripcion VARCHAR(MAX) = NULL,
    @cod_producto INT,
    @id_proveedor INT
AS
BEGIN
    -- Check if a product with the same code already exists
    IF EXISTS (SELECT 1 FROM productos WHERE cod_producto = @cod_producto)
    BEGIN
        -- If it exists, print an error message and do not insert
        PRINT 'Error: No se pudo insertar el producto. El código de producto ya existe.';
        RETURN; -- Exit the procedure
    END

    -- If the code is unique, proceed with the insertion
    INSERT INTO productos (nombre_producto, fechaIngreso, precioLista, precioVenta, stock, stock_min, descripcion, cod_producto, id_proveedor)
    VALUES (@nombre_producto, @fechaIngreso, @precioLista, @precioVenta, @stock, @stock_min, @descripcion, @cod_producto, @id_proveedor);

    -- Print a success message
    PRINT 'Producto insertado exitosamente.';
END;

--2. Procedimiento para Delete elemento por codigo
CREATE OR ALTER PROCEDURE PROC_BAJA_PRODUCTO
    @cod_producto VARCHAR(100) 
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE productos
    SET baja_producto = 1
    WHERE cod_producto = @cod_producto;

    PRINT 'Producto dado de baja exitosamente';
END;

--3.MODIFICAR PRODUCTO

CREATE OR ALTER PROCEDURE [dbo].[PROC_EDITAR_PRODUCTO]
(
    @id_producto INT,
    @nombre_producto VARCHAR(100),
    @precioLista DECIMAL(10,2),
    @precioVenta DECIMAL(10,2),
    @baja_producto BIT,
    @stock INT,
    @stock_min INT,
    @descripcion TEXT,
    @id_categoria INT,
	@cod_producto INT,
	@id_proveedor INT,

    @respuesta BIT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET @respuesta = 0;
    SET @mensaje = '';

    BEGIN TRY
        -- Validar nombre repetido en otro producto activo
        IF EXISTS (
            SELECT 1 FROM Productos 
            WHERE nombre_producto = @nombre_producto 
              AND id_producto != @id_producto 
              AND baja_producto = 0
        )
        BEGIN
            SET @mensaje = 'Ya existe otro producto activo con ese nombre.';
            RETURN;
        END

		-- Validar codigo repetido en otro producto activo
        IF EXISTS (
            SELECT 1 FROM Productos 
            WHERE cod_producto = @cod_producto 
              AND id_producto != @id_producto 
              AND baja_producto = 0
        )
        BEGIN
            SET @mensaje = 'Ya existe otro producto activo con ese nombre.';
            RETURN;
        END

        -- Validar existencia de categoría
        IF NOT EXISTS (SELECT 1 FROM Categorias WHERE id_categoria = @id_categoria)
        BEGIN
            SET @mensaje = 'La categoría indicada no existe.';
            RETURN;
        END

        -- Actualizar producto
        UPDATE Productos SET
            nombre_producto = @nombre_producto,
            precioLista = @precioLista,
            precioVenta = @precioVenta,
            baja_producto = @baja_producto,
            stock = @stock,
            stock_min = @stock_min,
            descripcion = @descripcion,
			cod_producto = @cod_producto,
			id_proveedor = @id_proveedor

        WHERE id_producto = @id_producto;

        -- Actualizar relación de categoría (si ya existe, actualizarla; si no, insertarla)
        IF EXISTS (
            SELECT 1 FROM ProductosCategorias 
            WHERE id_producto = @id_producto
        )
        BEGIN
            UPDATE ProductosCategorias
            SET id_categoria = @id_categoria
            WHERE id_producto = @id_producto;
        END
        ELSE
        BEGIN
            INSERT INTO ProductosCategorias (id_producto, id_categoria)
            VALUES (@id_producto, @id_categoria);
        END

        SET @respuesta = 1;
        SET @mensaje = 'Producto actualizado correctamente.';
    END TRY
    BEGIN CATCH
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END
GO

--4 OBTENER PRODUCTO POR ID
CREATE OR ALTER PROCEDURE PROC_OBTENER_PRODUCTO_COMPLETO
    @id_producto INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Primer SELECT: Obtener los datos del producto
    SELECT
        id_producto,
        nombre_producto,
        fechaIngreso,
        precioLista,
        precioVenta,
        baja_producto,
        stock,
        stock_min,
        descripcion,
        cod_producto,
        id_proveedor
    FROM
        Productos
    WHERE
        id_producto = @id_producto;

    -- Segundo SELECT: Obtener la lista de categorías asociadas
    SELECT
        c.id_categoria,
        c.nombre_categoria
    FROM
        ProductosCategorias pc
    INNER JOIN
        Categorias c ON pc.id_categoria = c.id_categoria
    WHERE
        pc.id_producto = @id_producto;
END;
GO


--5. CREAR PRODUCTO CON VARIAS CATEGORIAS
CREATE TYPE TipoIds AS TABLE
(
    id INT
);

CREATE OR ALTER PROCEDURE PROC_CREAR_PRODUCTO
    @nombre_producto VARCHAR(100),
    @id_categorias TipoIds READONLY, -- Nuevo parámetro de tabla
    @fechaIngreso DATE,
    @precioLista DECIMAL(10,2),
    @precioVenta DECIMAL(10,2),
    @stock INT,
    @stock_min INT,
    @eliminado BIT,
    @descripcion VARCHAR(MAX) = NULL,
    @cod_producto INT,
    @id_proveedor INT,
    @id_producto_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @id_producto_generado = 0;
    SET @mensaje = '';

    -- Iniciar una transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Validar si el código de producto ya existe
        IF EXISTS (SELECT 1 FROM Productos WHERE cod_producto = @cod_producto)
        BEGIN
            SET @mensaje = 'Error: El código de producto ya existe.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Insertar el nuevo producto
        INSERT INTO Productos (nombre_producto, fechaIngreso, precioLista, precioVenta, baja_producto, stock, stock_min, descripcion, cod_producto, id_proveedor)
        VALUES (@nombre_producto, @fechaIngreso, @precioLista, @precioVenta, @eliminado, @stock, @stock_min, @descripcion, @cod_producto, @id_proveedor);

        -- Obtener el ID del producto recién insertado
        SET @id_producto_generado = SCOPE_IDENTITY();

        -- 3. Insertar las categorías en la tabla intermedia ProductosCategorias
        INSERT INTO ProductosCategorias (id_producto, id_categoria)
        SELECT @id_producto_generado, id
        FROM @id_categorias;
        
        -- Confirmar la transacción
        COMMIT TRANSACTION;
        SET @mensaje = 'Producto y categorías registrados exitosamente.';
        
    END TRY
    BEGIN CATCH
        -- En caso de error, revertir la transacción
        SET @id_producto_generado = 0;
        SET @mensaje = 'Error al registrar el producto. Detalles: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;
GO

--6. BUSCAR PRODUCTOS

USE [ocio_store]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[PROC_BUSCAR_PRODUCTO]
    @id_producto INT = NULL,
    @nombre_producto VARCHAR(100) = NULL,
    @fechaIngreso DATE = NULL,
    @precioLista DECIMAL(10,2) = NULL,
    @precioVenta DECIMAL(10,2) = NULL,
    @baja_producto BIT = NULL,
    @stock INT = NULL,
    @stock_min INT = NULL,
    @descripcion VARCHAR(250) = NULL,
    @id_categoria INT = NULL,
    @nombre_categoria VARCHAR(100) = NULL,
    @cod_producto INT = NULL,
    @id_proveedor INT = NULL,
    @nombre_proveedor VARCHAR(100) = NULL,
    @busqueda_general VARCHAR(100) = NULL -- NUEVO PARÁMETRO PARA BÚSQUEDA GENERAL
AS
BEGIN
    SELECT 
        p.id_producto,
        p.nombre_producto,
        p.fechaIngreso,
        p.precioLista,
        p.precioVenta,
        p.baja_producto,
        p.stock,
        p.stock_min,
        p.descripcion,
        p.cod_producto, -- Nuevo campo
        p.id_proveedor, -- Nuevo campo
        pr.nombre_proveedor, -- Nombre del proveedor
        c.id_categoria,
        c.nombre_categoria
    FROM Productos p
    LEFT JOIN ProductosCategorias pc ON p.id_producto = pc.id_producto
    LEFT JOIN Categorias c ON pc.id_categoria = c.id_categoria
    LEFT JOIN Proveedores pr ON p.id_proveedor = pr.id_proveedor -- Nuevo JOIN a Proveedores
    WHERE
        -- Lógica de búsqueda general
        (@busqueda_general IS NULL OR
            p.nombre_producto LIKE '%' + @busqueda_general + '%' OR
            p.descripcion LIKE '%' + @busqueda_general + '%' OR
            p.cod_producto LIKE '%' + @busqueda_general + '%' OR -- Búsqueda por código de producto
            c.nombre_categoria LIKE '%' + @busqueda_general + '%' OR
            pr.nombre_proveedor LIKE '%' + @busqueda_general + '%') -- Búsqueda por nombre de proveedor
        AND
        (@id_producto IS NULL OR p.id_producto = @id_producto) AND
        (@nombre_producto IS NULL OR p.nombre_producto COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_producto + '%' COLLATE Latin1_General_CI_AI) AND
        (@fechaIngreso IS NULL OR p.fechaIngreso = @fechaIngreso) AND
        (@precioLista IS NULL OR p.precioLista = @precioLista) AND
        (@precioVenta IS NULL OR p.precioVenta = @precioVenta) AND
        (@baja_producto IS NULL OR p.baja_producto = @baja_producto) AND
        (@stock IS NULL OR p.stock = @stock) AND
        (@stock_min IS NULL OR p.stock_min = @stock_min) AND
        (@descripcion IS NULL OR p.descripcion COLLATE Latin1_General_CI_AI LIKE '%' + @descripcion + '%' COLLATE Latin1_General_CI_AI) AND
        (@id_categoria IS NULL OR c.id_categoria = @id_categoria) AND
        (@nombre_categoria IS NULL OR c.nombre_categoria COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_categoria + '%' COLLATE Latin1_General_CI_AI) AND
        (@cod_producto IS NULL OR p.cod_producto = @cod_producto) AND
        (@id_proveedor IS NULL OR p.id_proveedor = @id_proveedor) AND
        (@nombre_proveedor IS NULL OR pr.nombre_proveedor COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_proveedor + '%' COLLATE Latin1_General_CI_AI)
END
GO

	--7 LISTAR PRODUCTOS CON STOCK BAJO

USE [ocio_store]
GO

CREATE PROCEDURE PROC_LISTAR_PRODUCTOS_STOCK_BAJO
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        nombre_producto,
        stock,
        stock_min
    FROM 
        dbo.Productos
    WHERE 
        stock <= stock_min
    ORDER BY
        stock ASC;
END
GO


	-- 8 ACTUALIZAR CATEGORIAS DE PRODUCTOS

CREATE TYPE dbo.ListaDeIds AS TABLE (
    ID INT
);
GO

CREATE PROCEDURE PROC_ACTUALIZAR_CATEGORIAS_PRODUCTO
    @id_producto INT,
    @nuevas_categorias dbo.ListaDeIds READONLY -- Recibe la nueva lista de IDs
AS
BEGIN
    SET NOCOUNT ON;
    
    -- 1. Borramos las categorías viejas para este producto
    DELETE FROM dbo.ProductosCategorias WHERE id_producto = @id_producto;

    -- 2. Insertamos las nuevas categorías desde la tabla que recibimos
    INSERT INTO dbo.ProductosCategorias (id_producto, id_categoria)
    SELECT @id_producto, ID FROM @nuevas_categorias;
END
GO
