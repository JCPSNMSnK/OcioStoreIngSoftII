USE [ocio_store]
GO
CREATE OR ALTER PROCEDURE [dbo].[PROC_INFORME_VENDEDOR_VENTAS]
    @id_user INT,
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        v.id_venta AS [Nro Venta],
        v.fecha_venta AS [Fecha],
        u.nombre + ' ' + u.apellido AS [Vendedor],
        c.nombre_cliente + ' ' + c.apellido_cliente AS [Cliente],
        mp.nombre_medio AS [Medio Pago],
        v.total AS [Total]
    FROM 
        Ventas v
    INNER JOIN 
        Users u ON v.id_user = u.id_user
    INNER JOIN 
        Clientes c ON v.id_cliente = c.id_cliente
    INNER JOIN
        MetodosPago mp ON v.id_medio = mp.id_medioPago
    WHERE 
        v.id_user = @id_user
        AND CONVERT(DATE, v.fecha_venta) >= @fecha_inicio 
        AND CONVERT(DATE, v.fecha_venta) <= @fecha_fin
    ORDER BY 
        v.fecha_venta DESC;
END