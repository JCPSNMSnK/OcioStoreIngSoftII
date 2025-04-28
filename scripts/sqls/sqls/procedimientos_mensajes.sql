use db_piazza_giovanni;

--select * from mensajes

alter PROC PROC_REGISTRAR_RESPUESTA(
    @id_mensaje int,
	@respuesta varchar(250),
	@resultado int output,
	@mensaje varchar(500) output
)
as
begin 
	-- Establecemos valores iniciales
    SET @resultado = 1;
    SET @mensaje = 'Respuesta registrada exitosamente.';

    -- Verificar si el mensaje ya tiene una respuesta
    IF EXISTS (SELECT 1 FROM mensajes WHERE id = @id_mensaje AND respuesta IS NULL)
    BEGIN
        -- Actualizar la respuesta si aún no ha sido respondido
        UPDATE mensajes
        SET respuesta = @respuesta,
			updated_at = GETDATE()
        WHERE id = @id_mensaje;
    END
    ELSE
    BEGIN
        -- El mensaje ya fue respondido, devolver mensaje de error
        SET @resultado = 0;
        SET @mensaje = 'El mensaje ya ha sido respondido.';
    END
end

--UPDATE consultas
--        SET respuesta = null