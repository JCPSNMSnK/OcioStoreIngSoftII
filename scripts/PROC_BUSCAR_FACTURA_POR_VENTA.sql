USE [ocio_store]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[PROC_BUSCAR_FACTURA_POR_VENTA]
    @id_venta INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        f.id_factura,
        f.fecha_emision,
        tf.id_tipo_factura,
        tf.nombre_tipo_factura
    FROM 
        Facturas f
    INNER JOIN 
        TiposFactura tf ON f.id_tipo_factura = tf.id_tipo_factura
    WHERE 
        f.id_venta = @id_venta;
END
GO