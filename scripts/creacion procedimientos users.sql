--1. REGISTRAR USUARIO

CREATE OR ALTER PROC PROC_REGISTRAR_USUARIO(
    @nombre varchar(100),
    @apellido varchar(100),
    @dni varchar(20),
    @mail varchar(100),
    @username varchar(50),
    @pass varchar(255),
    @id_rol int,
    @baja_user bit = 0,
    @telefono_user VARCHAR(20),
    @direccion_user VARCHAR(100),
    @localidad_user VARCHAR(50),
    @provincia_user VARCHAR(50),
    
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
    INSERT INTO Users (nombre, apellido, dni, mail, username, pass, baja_user, id_rol, telefono_user, direccion_user, localidad_user, provincia_user) 
    VALUES (@nombre, @apellido, @dni, @mail, @username, @pass, @baja_user, @id_rol, @telefono_user, @direccion_user, @localidad_user, @provincia_user)

    SET @id_user_resultado = SCOPE_IDENTITY()
END

--2. EDITAR USUARIO

CREATE OR ALTER PROC PROC_EDITAR_USUARIO(
    @id_user int,
    @nombre varchar(100),
    @apellido varchar(100),
    @dni varchar(20),
    @mail varchar(100),
    @username varchar(50),
    @pass varchar(255),
    @id_rol int,
    @baja_user bit,
    @telefono_user VARCHAR(20),
    @direccion_user VARCHAR(100),
    @localidad_user VARCHAR(50),
    @provincia_user VARCHAR(50),

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
        baja_user = @baja_user,
        telefono_user = @telefono_user,
        direccion_user = @direccion_user,
        localidad_user = @localidad_user,
        provincia_user = @provincia_user
    WHERE id_user = @id_user

    SET @respuesta = 1
END

--3. ELIMINAR USUARIO

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


-- 4. BUSCAR USUARIO

CREATE OR ALTER PROCEDURE [dbo].[PROC_BUSCAR_USUARIO]
    @id_user INT = NULL,
    @apellido VARCHAR(100) = NULL,
    @nombre VARCHAR(100) = NULL,
    @dni VARCHAR(20) = NULL,
    @mail VARCHAR(100) = NULL,
    @username VARCHAR(50) = NULL,
	@pass VARCHAR(255) = NULL,
    @baja_user BIT = NULL,
    @id_rol INT = NULL,
    @nombre_rol VARCHAR(50) = NULL, 
    @busqueda_general VARCHAR(100) = NULL --  NUEVO PARÁMETRO

AS
BEGIN
    SELECT 
        u.id_user,
        u.apellido,
        u.nombre,
        u.dni,
        u.mail,
        u.username,
		u.pass,
        u.baja_user,
        u.id_rol,
        r.nombre_rol,
        u.telefono_user,
        u.direccion_user,
        u.localidad_user,
        u.provincia_user
    FROM dbo.Users u
    INNER JOIN dbo.Roles r ON u.id_rol = r.id_rol
    WHERE 
            -- Búsqueda general
        (@busqueda_general IS NULL OR
            u.apellido LIKE '%' + @busqueda_general + '%' OR
            u.nombre LIKE '%' + @busqueda_general + '%' OR
            u.dni LIKE '%' + @busqueda_general + '%' OR
            u.mail LIKE '%' + @busqueda_general + '%' OR
            u.username LIKE '%' + @busqueda_general + '%' OR
            r.nombre_rol LIKE '%' + @busqueda_general + '%')
        AND
        (@id_user IS NULL OR u.id_user = @id_user) AND
        (@apellido IS NULL OR u.apellido COLLATE Latin1_General_CI_AI LIKE '%' + @apellido + '%' COLLATE Latin1_General_CI_AI) AND
        (@nombre IS NULL OR u.nombre COLLATE Latin1_General_CI_AI LIKE '%' + @nombre + '%' COLLATE Latin1_General_CI_AI) AND
        (@dni IS NULL OR u.dni LIKE '%' + @dni + '%') AND
        (@mail IS NULL OR u.mail LIKE '%' + @mail + '%') AND
        (@username IS NULL OR u.username LIKE '%' + @username + '%') AND
        (@baja_user IS NULL OR u.baja_user = @baja_user) AND
        (@id_rol IS NULL OR u.id_rol = @id_rol) AND
        (@nombre_rol IS NULL OR r.nombre_rol COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_rol + '%' COLLATE Latin1_General_CI_AI)
END




