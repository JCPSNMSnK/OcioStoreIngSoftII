--1. Procedimiento para registrar ventas

CREATE PROCEDURE PROC_REGISTRAR_VENTA
    @total DECIMAL(10,2),
    @id_medio INT,
    @id_user INT,
	@fecha_venta DATE
AS
BEGIN
    INSERT INTO ventas (total, id_medio, id_user, fecha_venta)
    VALUES (@total, @id_medio, @id_user, @fecha_venta);

    PRINT 'Venta registrada exitosamente';
END;



