USE [ocio_store]
GO
CREATE OR ALTER PROCEDURE [dbo].[PROC_BUSCAR_INFORMES_HISTORIAL]
    @fecha_inicio DATE = NULL,
    @fecha_fin DATE = NULL,
    @tipo_informe NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        i.id_informe,
        i.fechaGeneracion,
        i.tipo_informe,
        i.titulo,
        u.nombre + ' ' + u.apellido AS usuario_generador,
        i.descripcion
    FROM 
        Informe i
    INNER JOIN 
        Users u ON i.id_user = u.id_user
    WHERE 
        (@fecha_inicio IS NULL OR CONVERT(DATE, i.fechaGeneracion) >= @fecha_inicio)
        AND (@fecha_fin IS NULL OR CONVERT(DATE, i.fechaGeneracion) <= @fecha_fin)
        AND (@tipo_informe IS NULL OR @tipo_informe = '' OR i.tipo_informe = @tipo_informe)
    ORDER BY 
        i.fechaGeneracion DESC;
END