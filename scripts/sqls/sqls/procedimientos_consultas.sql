use db_piazza_giovanni;

alter PROC PROC_REGISTRAR_RESPUESTA_CONSULTA(
    @id_consulta int,
	@respuesta varchar(250),
	@resultado int output,
	@mensaje varchar(500) output
)
as
begin 
	-- Establecemos valores iniciales
    SET @resultado = 1;
    SET @mensaje = 'Respuesta registrada exitosamente.';

    -- Verificar si la consulta ya tiene una respuesta
    IF EXISTS (SELECT 1 FROM consultas c WHERE c.id = @id_consulta AND c.respuesta IS NULL)
    BEGIN
        -- Actualizar la respuesta si aún no ha sido respondido
        UPDATE consultas
        SET respuesta = @respuesta,
			updated_at = GETDATE()
        WHERE id = @id_consulta;
    END
    ELSE
    BEGIN
        -- La consulta ya fue respondida, devolver mensaje de error
        SET @resultado = 0;
        SET @mensaje = 'El mensaje ya ha sido respondido.';
    END
end

--select * from consultas