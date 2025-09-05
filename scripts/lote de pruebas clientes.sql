-- Declarar variables de salida para capturar los resultados
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

-- Cliente 1
EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 28123456,
    @nombre_cliente = 'Mariana',
    @apellido_cliente = 'López',
    @telefono_cliente = '1123456780',
    @email_cliente = 'mariana.lopez@email.com',
    @direccion_cliente = 'Calle Falsa 123',
    @localidad_cliente = 'Córdoba',
    @provincia_cliente = 'Córdoba',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 2
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 35987654,
    @nombre_cliente = 'Rodrigo',
    @apellido_cliente = 'Gómez',
    @telefono_cliente = '1134567891',
    @email_cliente = 'rodrigo.gomez@email.com',
    @direccion_cliente = 'Av. San Martín 456',
    @localidad_cliente = 'Rosario',
    @provincia_cliente = 'Santa Fe',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 3
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 40765432,
    @nombre_cliente = 'Sofía',
    @apellido_cliente = 'Ramírez',
    @telefono_cliente = '1145678902',
    @email_cliente = 'sofia.ramirez@email.com',
    @direccion_cliente = 'Corrientes 789',
    @localidad_cliente = 'Mendoza',
    @provincia_cliente = 'Mendoza',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 4
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 32890123,
    @nombre_cliente = 'Juan',
    @apellido_cliente = 'Pérez',
    @telefono_cliente = '1156789013',
    @email_cliente = 'juan.perez@email.com',
    @direccion_cliente = 'Av. Rivadavia 101',
    @localidad_cliente = 'La Plata',
    @provincia_cliente = 'Buenos Aires',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 5
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 25678901,
    @nombre_cliente = 'Laura',
    @apellido_cliente = 'Díaz',
    @telefono_cliente = '1167890124',
    @email_cliente = 'laura.diaz@email.com',
    @direccion_cliente = 'Sarmiento 202',
    @localidad_cliente = 'Mar del Plata',
    @provincia_cliente = 'Buenos Aires',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 6
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 30112233,
    @nombre_cliente = 'Pedro',
    @apellido_cliente = 'Fernández',
    @telefono_cliente = '1178901235',
    @email_cliente = 'pedro.fernandez@email.com',
    @direccion_cliente = 'Belgrano 303',
    @localidad_cliente = 'San Miguel de Tucumán',
    @provincia_cliente = 'Tucumán',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 7
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 29445566,
    @nombre_cliente = 'Carolina',
    @apellido_cliente = 'Castro',
    @telefono_cliente = '1189012346',
    @email_cliente = 'carolina.castro@email.com',
    @direccion_cliente = 'Mitre 404',
    @localidad_cliente = 'Neuquén',
    @provincia_cliente = 'Neuquén',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 8
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 38778899,
    @nombre_cliente = 'Martín',
    @apellido_cliente = 'Morales',
    @telefono_cliente = '1190123457',
    @email_cliente = 'martin.morales@email.com',
    @direccion_cliente = 'Independencia 505',
    @localidad_cliente = 'Salta',
    @provincia_cliente = 'Salta',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 9
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 42001122,
    @nombre_cliente = 'Valeria',
    @apellido_cliente = 'Fernández',
    @telefono_cliente = '1112345678',
    @email_cliente = 'valeria.fernandez@email.com',
    @direccion_cliente = 'Maipú 606',
    @localidad_cliente = 'San Juan',
    @provincia_cliente = 'San Juan',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

-- Cliente 10
DECLARE @id_cliente_generado INT;
DECLARE @mensaje VARCHAR(500);

EXEC PROC_REGISTRAR_CLIENTE
    @dni_cliente = 33556677,
    @nombre_cliente = 'Gustavo',
    @apellido_cliente = 'Ruiz',
    @telefono_cliente = '1123456789',
    @email_cliente = 'gustavo.ruiz@email.com',
    @direccion_cliente = 'General Paz 707',
    @localidad_cliente = 'Resistencia',
    @provincia_cliente = 'Chaco',
    @id_cliente_generado = @id_cliente_generado OUTPUT,
    @mensaje = @mensaje OUTPUT;
PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID del cliente generado: ' + CONVERT(VARCHAR, @id_cliente_generado);
GO

SELECT * FROM Clientes