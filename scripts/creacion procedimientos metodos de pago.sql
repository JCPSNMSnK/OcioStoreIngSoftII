--1. Procedimiento para registrar medio de pago
CREATE PROCEDURE PROC_REGISTRAR_METODO
    @comision DECIMAL(5,2),
	@nombre_medio VARCHAR(50),

    @id_medio_registrado int output,
    @mensaje varchar(500) output
AS
BEGIN

    -- Verificar si el medio de pago ya existe
    IF EXISTS (SELECT * FROM MetodosPago WHERE nombre_medio = @nombre_medio)
    BEGIN
        SET @mensaje = 'Este Metodo de Pago ya está registrado'
        RETURN
    END

    INSERT INTO MetodosPago (comision, nombre_medio)
    VALUES (@comision, @nombre_medio);

    SET @mensaje = 'Metodo de Pago registrado exitosamente';
    SET @id_medio_registrado =  SCOPE_IDENTITY()
END;