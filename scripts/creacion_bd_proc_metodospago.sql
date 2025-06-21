--1. Procedimiento para registrar medio de pago
CREATE PROCEDURE PROC_REGISTRAR_METODO
    @comision DECIMAL(5,2),
	@nombre_medio VARCHAR(50)
AS
BEGIN
    INSERT INTO MetodosPago (comision, nombre_medio)
    VALUES (@comision, @nombre_medio);

    PRINT 'Metodo de Pago registrado exitosamente';
END;