DECLARE @id_proveedor INT;
DECLARE @mensaje NVARCHAR(200);

EXEC PROC_REGISTRAR_PROVEEDOR 
    @nombre_proveedor = 'Juegos del Sur',
    @telefono_proveedor = '1134556677',
    @cuit_proveedor = '30-71234567-9',
    @id_proveedor_generado = @id_proveedor OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'ID: ' + CAST(@id_proveedor AS VARCHAR) + ' | ' + @mensaje;

EXEC PROC_REGISTRAR_PROVEEDOR 
    @nombre_proveedor = 'Diversión Andina',
    @telefono_proveedor = '1169874321',
    @cuit_proveedor = '30-82345678-5',
    @id_proveedor_generado = @id_proveedor OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'ID: ' + CAST(@id_proveedor AS VARCHAR) + ' | ' + @mensaje;

EXEC PROC_REGISTRAR_PROVEEDOR 
    @nombre_proveedor = 'Lúdica Global',
    @telefono_proveedor = '1145638920',
    @cuit_proveedor = '30-93456789-1',
    @id_proveedor_generado = @id_proveedor OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'ID: ' + CAST(@id_proveedor AS VARCHAR) + ' | ' + @mensaje;

EXEC PROC_REGISTRAR_PROVEEDOR 
    @nombre_proveedor = 'Tableros y Dados',
    @telefono_proveedor = '1176543210',
    @cuit_proveedor = '30-64567890-7',
    @id_proveedor_generado = @id_proveedor OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'ID: ' + CAST(@id_proveedor AS VARCHAR) + ' | ' + @mensaje;

EXEC PROC_REGISTRAR_PROVEEDOR 
    @nombre_proveedor = 'Mente Estratégica',
    @telefono_proveedor = '1123984756',
    @cuit_proveedor = '30-75678901-3',
    @id_proveedor_generado = @id_proveedor OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'ID: ' + CAST(@id_proveedor AS VARCHAR) + ' | ' + @mensaje;

EXEC PROC_REGISTRAR_PROVEEDOR 
    @nombre_proveedor = 'Colección Lúdica',
    @telefono_proveedor = '1187654321',
    @cuit_proveedor = '30-86789012-4',
    @id_proveedor_generado = @id_proveedor OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'ID: ' + CAST(@id_proveedor AS VARCHAR) + ' | ' + @mensaje;
