--1. Procedimiento para Insertar elementos
CREATE PROCEDURE PROC_CREAR_PRODUCTO
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
CREATE PROCEDURE PROC_BAJA_PRODUCTO
    @cod_producto_producto VARCHAR(100) 
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE productos
    SET baja_producto = 1
    WHERE cod_producto = @cod_producto;

    PRINT 'Producto dado de baja exitosamente';
END;

--3.MODIFICAR PRODUCTO

CREATE PROCEDURE [dbo].[PROC_EDITAR_PRODUCTO]
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


-----------------------
--PRUEBAS
SELECT * FROM Productos
--1. INSERTAR PRODUCTOS

-- Lote 1: Catan
EXEC PROC_CREAR_PRODUCTO 
    @nombre_producto = 'Catan',
    @id_categoria = 1,  -- Ej: Estrategia
    @fechaIngreso = '2025-04-01',
    @precioLista = 45.00,
    @precioVenta = 59.99,
    @stock = 25,
    @stock_min = 5,
    @eliminado = 0,
    @descripcion = 'Juego de estrategia de comercio y expansi�n en una isla. Para 3-4 jugadores.';

-- Lote 2: Carcassonne
EXEC PROC_CREAR_PRODUCTO 
    @nombre_producto = 'Carcassonne',
    @id_categoria = 1,  -- Ej: Estrategia
    @fechaIngreso = '2025-04-03',
    @precioLista = 30.00,
    @precioVenta = 39.99,
    @stock = 40,
    @stock_min = 10,
    @eliminado = 0,
    @descripcion = 'Juego de colocaci�n de losetas con construcci�n de caminos, ciudades y campos.';

-- Lote 3: Dixit
EXEC PROC_CREAR_PRODUCTO 
    @nombre_producto = 'Dixit',
    @id_categoria = 2,  -- Ej: Creatividad / Familiar
    @fechaIngreso = '2025-04-05',
    @precioLista = 32.00,
    @precioVenta = 44.99,
    @stock = 35,
    @stock_min = 8,
    @eliminado = 0,
    @descripcion = 'Juego de cartas ilustradas donde se gana interpretando pistas creativas. Ideal para familias.';

-- Lote 4: Azul
EXEC PROC_CREAR_PRODUCTO 
    @nombre_producto = 'Azul',
    @id_categoria = 3,  -- Ej: Abstracto
    @fechaIngreso = '2025-04-07',
    @precioLista = 35.00,
    @precioVenta = 49.99,
    @stock = 20,
    @stock_min = 5,
    @eliminado = 0,
    @descripcion = 'Juego de colocaci�n de fichas basado en patrones de mosaicos portugueses.';

--2. BAJA PRODUCTO

-- Dar de baja 'Dixit'
EXEC PROC_BAJA_PRODUCTO @nombre_producto = 'Dixit';

-- Dar de baja 'Azul'
EXEC PROC_BAJA_PRODUCTO @nombre_producto = 'Azul';





