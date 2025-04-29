CREATE PROC PROC_REGISTRAR_USUARIO(
    @nombre varchar(100),
    @apellido varchar(100),
    @dni varchar(20),
    @mail varchar(100),
    @username varchar(50),
    @pass varchar(255),
    @id_rol int,
    @baja_user bit = 0,

    @id_user_resultado int output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @id_user_resultado = 0
    SET @mensaje = ''
    
    -- Verificar si el email ya existe
    IF EXISTS (SELECT * FROM Users WHERE mail = @mail)
    BEGIN
        SET @mensaje = 'Este Email ya está registrado'
        RETURN
    END
    
    -- Verificar si el username ya existe
    IF EXISTS (SELECT * FROM Users WHERE username = @username)
    BEGIN
        SET @mensaje = 'Este nombre de usuario ya está en uso'
        RETURN
    END
    
    -- Verificar si el DNI ya existe
    IF EXISTS (SELECT * FROM Users WHERE dni = @dni)
    BEGIN
        SET @mensaje = 'Este DNI ya está registrado'
        RETURN
    END
    
    -- Insertar el nuevo usuario
    INSERT INTO Users (nombre, apellido, dni, mail, username, pass, baja_user, id_rol) 
    VALUES (@nombre, @apellido, @dni, @mail, @username, @pass, @baja_user, @id_rol)

    SET @id_user_resultado = SCOPE_IDENTITY()
END

CREATE PROC PROC_EDITAR_USUARIO(
    @id_user int,
    @nombre varchar(100),
    @apellido varchar(100),
    @dni varchar(20),
    @mail varchar(100),
    @username varchar(50),
    @pass varchar(255),
    @id_rol int,
    @baja_user bit,

    @respuesta bit output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @respuesta = 0
    SET @mensaje = ''
    
    -- Verificar si el email ya existe en otro usuario
    IF EXISTS (SELECT * FROM Users WHERE mail = @mail AND id_user != @id_user)
    BEGIN
        SET @mensaje = 'Este Email ya está registrado por otro usuario'
        RETURN
    END
    
    -- Verificar si el username ya existe en otro usuario
    IF EXISTS (SELECT * FROM Users WHERE username = @username AND id_user != @id_user)
    BEGIN
        SET @mensaje = 'Este nombre de usuario ya está en uso por otro usuario'
        RETURN
    END
    
    -- Verificar si el DNI ya existe en otro usuario
    IF EXISTS (SELECT * FROM Users WHERE dni = @dni AND id_user != @id_user)
    BEGIN
        SET @mensaje = 'Este DNI ya está registrado por otro usuario'
        RETURN
    END
    
    -- Actualizar el usuario
    UPDATE Users SET 
        nombre = @nombre,
        apellido = @apellido,
        dni = @dni,
        mail = @mail,
        username = @username,
        pass = @pass,
        id_rol = @id_rol,
        baja_user = @baja_user
    WHERE id_user = @id_user

    SET @respuesta = 1
END


CREATE PROC PROC_ELIMINAR_USUARIO(
    @id_user int,
    @respuesta bit output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @respuesta = 0
    SET @mensaje = ''
    
    -- Verificar si el usuario tiene ventas asociadas
    IF EXISTS (SELECT * FROM Ventas WHERE id_user = @id_user)
    BEGIN
        SET @mensaje = 'Este usuario no se puede eliminar porque tiene ventas asociadas'
        RETURN
    END
    
    -- Verificar si el usuario está relacionado con informes
    IF EXISTS (SELECT * FROM Informe WHERE id_user = @id_user)
    BEGIN
        SET @mensaje = 'Este usuario no se puede eliminar porque tiene informes asociados'
        RETURN
    END
    
    -- Eliminar permisos asociados primero (si es necesario)
    DELETE FROM Permisos WHERE id_rol IN (SELECT id_rol FROM Users WHERE id_user = @id_user)
    
    -- Eliminar el usuario
    DELETE FROM Users WHERE id_user = @id_user
    
    SET @respuesta = 1
END

------------------------------------PRUEBAS------------------------------------


select * from users

-- INSERTAR --

DECLARE @idResultado INT
DECLARE @mensaje VARCHAR(500)

EXEC PROC_REGISTRAR_USUARIO
    @nombre = 'Valentina',
    @apellido = 'Rossi',
    @dni = '30456789',
    @mail = 'valentina.rossi@example.com',
    @username = 'valenr',
    @pass = 'claveSegura123',
    @id_rol = 2,
    @baja_user = 0,
    @id_user_resultado = @idResultado OUTPUT,
    @mensaje = @mensaje OUTPUT

SELECT @idResultado AS ID_Usuario_Creado, @mensaje AS Mensaje

-- EDITAR --

DECLARE @respuesta BIT
DECLARE @mensaje VARCHAR(500)

EXEC PROC_EDITAR_USUARIO
    @id_user = 8,
    @nombre = 'Valentina',
    @apellido = 'Rossi',
    @dni = '30456789',
    @mail = 'valentina.rossi@actualizado.com',
    @username = 'valenr_updated',
    @pass = 'nuevaClave456',
    @id_rol = 3,
    @baja_user = 0,
    @respuesta = @respuesta OUTPUT,
    @mensaje = @mensaje OUTPUT

SELECT @respuesta AS ResultadoEdicion, @mensaje AS Mensaje


-- ELIMINAR --

DECLARE @respuesta BIT
DECLARE @mensaje VARCHAR(500)

EXEC PROC_ELIMINAR_USUARIO
    @id_user = 7,
    @respuesta = @respuesta OUTPUT,
    @mensaje = @mensaje OUTPUT

SELECT @respuesta AS ResultadoEliminacion, @mensaje AS Mensaje
