SELECT * FROM Roles

/*--
1	Administrador	Gestiona usuarios, productos y categorias
2	Analista de Ventas	Genera informes y análisis de ventas, empleados y productos
3	Vendedor	Atiende ventas y ve estaditicas propias
4	Administrador de Bases de Datos	Realiza copia de seguridad de BD y tambien puede restaurarlas.
--*/


-- Declarar variables de salida para capturar los resultados
DECLARE @id_user_resultado INT;
DECLARE @mensaje VARCHAR(500);

-- Usuario 1: Analista de Ventas
-- id_rol = 2
EXEC PROC_REGISTRAR_USUARIO
    @nombre = 'Ana',
    @apellido = 'García',
    @dni = '30123456',
    @mail = 'ana.garcia@tienda.com',
    @username = 'anagarcia',
    @pass = 'pass123', -- En una aplicación real, usarías un hash de la contraseña
    @id_rol = 2,
    @baja_user = 0,
    @telefono_user = '1123456789',
    @direccion_user = 'Av. Libertador 1234',
    @localidad_user = 'Ciudad Autónoma de Buenos Aires',
    @provincia_user = 'Buenos Aires',
    @id_user_resultado = @id_user_resultado OUTPUT,
    @mensaje = @mensaje OUTPUT;

PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID de usuario generado: ' + CONVERT(VARCHAR, @id_user_resultado);
GO

-- Usuario 2: Vendedor
-- id_rol = 3
DECLARE @id_user_resultado INT;
DECLARE @mensaje VARCHAR(500);


EXEC PROC_REGISTRAR_USUARIO
    @nombre = 'Carlos',
    @apellido = 'Pérez',
    @dni = '35987654',
    @mail = 'carlos.perez@tienda.com',
    @username = 'carlosp',
    @pass = 'venta456', -- En una aplicación real, usarías un hash de la contraseña
    @id_rol = 3,
    @baja_user = 0,
    @telefono_user = '1198765432',
    @direccion_user = 'Calle Falsa 123',
    @localidad_user = 'Córdoba',
    @provincia_user = 'Córdoba',
    @id_user_resultado = @id_user_resultado OUTPUT,
    @mensaje = @mensaje OUTPUT;

PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID de usuario generado: ' + CONVERT(VARCHAR, @id_user_resultado);
GO

-- Usuario 3: Administrador de Bases de Datos
-- id_rol = 4
DECLARE @id_user_resultado INT;
DECLARE @mensaje VARCHAR(500);


EXEC PROC_REGISTRAR_USUARIO
    @nombre = 'Laura',
    @apellido = 'Martínez',
    @dni = '25456789',
    @mail = 'laura.martinez@tienda.com',
    @username = 'dbadmin',
    @pass = 'admin_db123', -- En una aplicación real, usarías un hash de la contraseña
    @id_rol = 4,
    @baja_user = 0,
    @telefono_user = '1156789012',
    @direccion_user = 'Pasaje de los Sólidos 456',
    @localidad_user = 'Rosario',
    @provincia_user = 'Santa Fe',
    @id_user_resultado = @id_user_resultado OUTPUT,
    @mensaje = @mensaje OUTPUT;

PRINT 'Mensaje: ' + @mensaje;
PRINT 'ID de usuario generado: ' + CONVERT(VARCHAR, @id_user_resultado);
GO

--Verificar Users
SELECT * FROM Users