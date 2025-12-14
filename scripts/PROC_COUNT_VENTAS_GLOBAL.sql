USE [ocio_store]
GO
CREATE OR ALTER PROCEDURE [dbo].[PROC_COUNT_VENTAS_GLOBAL]
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(id_venta) AS cantidad 
    FROM Ventas 
    WHERE fecha_venta >= @fecha_inicio AND fecha_venta <= @fecha_fin;
END