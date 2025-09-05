SELECT * FROM TiposFactura

-- Declarar variables de salida
DECLARE @id_tipo_factura_generado INT;
DECLARE @mensaje VARCHAR(500);

-- Tipo de Factura 0: Consumidor Final
EXEC PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura = 'Consumidor Final',
    @id_tipo_factura_generado = @id_tipo_factura_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del tipo de factura generado: ' + CONVERT(VARCHAR, @id_tipo_factura_generado);
GO

-- Tipo de Factura 1: Factura A

DECLARE @id_tipo_factura_generado INT;
DECLARE @mensaje VARCHAR(500);


EXEC PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura = 'Factura A',
    @id_tipo_factura_generado = @id_tipo_factura_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del tipo de factura generado: ' + CONVERT(VARCHAR, @id_tipo_factura_generado);
GO

-- Tipo de Factura 2: Factura B
DECLARE @id_tipo_factura_generado INT;
DECLARE @mensaje VARCHAR(500);


EXEC PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura = 'Factura B',
    @id_tipo_factura_generado = @id_tipo_factura_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del tipo de factura generado: ' + CONVERT(VARCHAR, @id_tipo_factura_generado);
GO

-- Tipo de Factura 3: Factura C
DECLARE @id_tipo_factura_generado INT;
DECLARE @mensaje VARCHAR(500);


EXEC PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura = 'Factura C',
    @id_tipo_factura_generado = @id_tipo_factura_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del tipo de factura generado: ' + CONVERT(VARCHAR, @id_tipo_factura_generado);
GO

-- Tipo de Factura 4: Nota de Crédito
DECLARE @id_tipo_factura_generado INT;
DECLARE @mensaje VARCHAR(500);


EXEC PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura = 'Nota de Crédito',
    @id_tipo_factura_generado = @id_tipo_factura_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del tipo de factura generado: ' + CONVERT(VARCHAR, @id_tipo_factura_generado);
GO

-- Tipo de Factura 5: Nota de Débito
DECLARE @id_tipo_factura_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_TIPO_FACTURA
    @nombre_tipo_factura = 'Nota de Débito',
    @id_tipo_factura_generado = @id_tipo_factura_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del tipo de factura generado: ' + CONVERT(VARCHAR, @id_tipo_factura_generado);
GO

SELECT * FROM TiposFactura