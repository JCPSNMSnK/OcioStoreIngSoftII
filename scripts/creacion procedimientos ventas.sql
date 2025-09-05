--0. ALTER TABLE VENTAS
ALTER TABLE Ventas
ADD 
    id_cliente INT NULL;

ALTER TABLE Ventas
    ADD CONSTRAINT FK_Ventas_Clientes
    FOREIGN KEY (id_cliente)
    REFERENCES Clientes (id_cliente);

--1. Procedimiento para registrar ventas

CREATE OR ALTER PROCEDURE PROC_REGISTRAR_VENTA
    @total DECIMAL(10,2),
    @id_medio INT,
    @id_user INT,
    @id_cliente INT,
	@fecha_venta DATE,

    @id_venta_registrada int output,
    @mensaje varchar(500) output
AS
BEGIN
    INSERT INTO ventas (total, id_medio, id_user, id_cliente, fecha_venta)
    VALUES (@total, @id_medio, @id_user, @id_cliente, @fecha_venta);

    SET @id_venta_registrada =  SCOPE_IDENTITY();
    SET @mensaje = 'Venta registrada exitosamente';
END;

--2. Procedimiento para registrar los detalles de venta asociados

CREATE OR ALTER PROCEDURE PROC_REGISTRAR_DETALLE
    @id_venta_registrada INT,
    @id_producto INT,
    @cantidad INT,
    @subtotal DECIMAL(10,2),

    @mensaje varchar(500) output
AS
BEGIN
    INSERT INTO detalleVentas (id_venta, id_producto, cantidad, subtotal)
    VALUES (@id_venta_registrada, @id_producto, @cantidad, @subtotal);

    UPDATE productos
    SET stock = stock - @cantidad
    WHERE id_producto = @id_producto;

    SET @mensaje = 'Detalle de Venta registrado exitosamente';
END;   

--3. OBtener Venta Completa

CREATE OR ALTER PROCEDURE PROC_OBTENER_VENTA_COMPLETA
    @id_venta INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Seleccionar los detalles de la venta y los datos del producto
    SELECT 
        dv.id_producto,
        dv.cantidad,
        dv.subtotal,
        p.cod_producto,
        p.nombre_producto,
        p.precioVenta
    FROM 
        DetalleVentas dv
    INNER JOIN 
        Productos p ON dv.id_producto = p.id_producto
    WHERE 
        dv.id_venta = @id_venta;

    -- Seleccionar los datos de la venta y el cliente
    SELECT 
        v.id_venta,
        v.total,
        v.fecha_venta,
        v.id_medio,
        v.id_user,
        c.id_cliente,
        c.dni_cliente,
        c.nombre_cliente,
        c.apellido_cliente
    FROM 
        Ventas v
    INNER JOIN 
        Clientes c ON v.id_cliente = c.id_cliente
    WHERE 
        v.id_venta = @id_venta;
END;
GO

