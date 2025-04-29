Procedimiento1. -- para Insertar elementos
CREATE PROCEDURE PROC_CREAR_PRODUCTO
    @nombre_producto VARCHAR(100),
    @id_categoria INT,
	@fechaIngreso DATE,
    @precioLista DECIMAL(10,2),
    @precioVenta DECIMAL(10,2),
    @stock INT,
    @stock_min INT,
    @eliminado BIT,
    @descripcion VARCHAR(MAX) = NULL
AS
BEGIN
    INSERT INTO productos (nombre_producto, fechaIngreso, precioLista, precioVenta, stock, stock_min, descripcion)
    VALUES (@nombre_producto, @fechaIngreso, @precioLista, @precioVenta, @stock, @stock_min, @descripcion);

    PRINT 'Producto insertado exitosamente';
END;

--2. Procedimiento para Delete elemento por nombre
CREATE PROCEDURE PROC_BAJA_PRODUCTO
    @nombre_producto VARCHAR(100) 
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE productos
    SET baja_producto = 1
    WHERE nombre_producto = @nombre_producto;

    PRINT 'Producto dado de baja exitosamente';
END;


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
    @descripcion = 'Juego de estrategia de comercio y expansión en una isla. Para 3-4 jugadores.';

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
    @descripcion = 'Juego de colocación de losetas con construcción de caminos, ciudades y campos.';

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
    @descripcion = 'Juego de colocación de fichas basado en patrones de mosaicos portugueses.';

--2. BAJA PRODUCTO

-- Dar de baja 'Dixit'
EXEC PROC_BAJA_PRODUCTO @nombre_producto = 'Dixit';

-- Dar de baja 'Azul'
EXEC PROC_BAJA_PRODUCTO @nombre_producto = 'Azul';





