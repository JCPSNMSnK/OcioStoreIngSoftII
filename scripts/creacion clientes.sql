CREATE TABLE Clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    dni_cliente INT UNIQUE,
    nombre_cliente VARCHAR(50),
    apellido_cliente VARCHAR(50),
    telefono_cliente VARCHAR(20),
    email_cliente VARCHAR(50),
    direccion_cliente VARCHAR(100),
    localidad_cliente VARCHAR(50),
    provincia_cliente VARCHAR(50)
);

--1. REGISTRAR CLIENTE
CREATE OR ALTER PROCEDURE PROC_REGISTRAR_CLIENTE
    @dni_cliente INT,
    @nombre_cliente VARCHAR(50),
    @apellido_cliente VARCHAR(50),
    @telefono_cliente VARCHAR(20),
    @email_cliente VARCHAR(50),
    @direccion_cliente VARCHAR(100),
    @localidad_cliente VARCHAR(50),
    @provincia_cliente VARCHAR(50),
    @id_cliente_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variables de salida
    SET @id_cliente_generado = 0;
    SET @mensaje = '';

    -- Validar si el DNI ya existe en la base de datos
    IF EXISTS (SELECT 1 FROM Clientes WHERE dni_cliente = @dni_cliente)
    BEGIN
        SET @mensaje = 'Error: El DNI ingresado ya pertenece a un cliente registrado.';
        RETURN;
    END

    -- Intentar insertar el nuevo cliente
    BEGIN TRY
        INSERT INTO Clientes (
            dni_cliente,
            nombre_cliente,
            apellido_cliente,
            telefono_cliente,
            email_cliente,
            direccion_cliente,
            localidad_cliente,
            provincia_cliente
        )
        VALUES (
            @dni_cliente,
            @nombre_cliente,
            @apellido_cliente,
            @telefono_cliente,
            @email_cliente,
            @direccion_cliente,
            @localidad_cliente,
            @provincia_cliente
        );

        -- Obtener el ID del cliente recién insertado
        SET @id_cliente_generado = SCOPE_IDENTITY();
        SET @mensaje = 'Cliente registrado exitosamente.';
    END TRY
    BEGIN CATCH
        -- Capturar el error y guardar el mensaje en caso de fallo
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al registrar el cliente: ' + @ErrorMensaje;
        SET @id_cliente_generado = 0;
    END CATCH
END;
GO

--2. MODIFICAR CLIENTE


CREATE  OR ALTER PROCEDURE PROC_MODIFICAR_CLIENTE
    @id_cliente INT,
    @nombre_cliente VARCHAR(50),
    @apellido_cliente VARCHAR(50),
    @telefono_cliente VARCHAR(20),
    @email_cliente VARCHAR(50),
    @direccion_cliente VARCHAR(100),
    @localidad_cliente VARCHAR(50),
    @provincia_cliente VARCHAR(50),
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variable de salida
    SET @mensaje = '';

    -- Validar si el cliente con el ID especificado existe
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE id_cliente = @id_cliente)
    BEGIN
        SET @mensaje = 'Error: El cliente con el ID especificado no existe.';
        RETURN;
    END

    -- Intentar actualizar los datos del cliente
    BEGIN TRY
        UPDATE Clientes
        SET
            nombre_cliente = @nombre_cliente,
            apellido_cliente = @apellido_cliente,
            telefono_cliente = @telefono_cliente,
            email_cliente = @email_cliente,
            direccion_cliente = @direccion_cliente,
            localidad_cliente = @localidad_cliente,
            provincia_cliente = @provincia_cliente
        WHERE
            id_cliente = @id_cliente;

        SET @mensaje = 'Cliente modificado exitosamente.';
    END TRY
    BEGIN CATCH
        -- Capturar el error y guardar el mensaje en caso de fallo
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al modificar el cliente: ' + @ErrorMensaje;
    END CATCH
END;
GO

--3. BUSCAR CLIENTE

CREATE OR ALTER PROCEDURE PROC_BUSCAR_CLIENTE
    @dni_cliente INT = NULL,
    @nombre_cliente VARCHAR(50) = NULL,
    @apellido_cliente VARCHAR(50) = NULL,
    @telefono_cliente VARCHAR(20) = NULL,
    @email_cliente VARCHAR(50) = NULL,
    @localidad_cliente VARCHAR(50) = NULL,
    @provincia_cliente VARCHAR(50) = NULL,
    @busqueda_general VARCHAR(100) = NULL --  NUEVO PARÁMETRO

AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_cliente,
        dni_cliente,
        nombre_cliente,
        apellido_cliente,
        telefono_cliente,
        email_cliente,
        direccion_cliente,
        localidad_cliente,
        provincia_cliente
    FROM
        Clientes
    WHERE
        (@busqueda_general IS NULL OR
            apellido_cliente LIKE '%' + @busqueda_general + '%' OR
            nombre_cliente LIKE '%' + @busqueda_general + '%' OR
            dni_cliente LIKE '%' + @busqueda_general + '%' OR
            email_cliente LIKE '%' + @busqueda_general + '%')
        AND (@dni_cliente IS NULL OR dni_cliente = @dni_cliente)
        AND (@nombre_cliente IS NULL OR nombre_cliente LIKE '%' + @nombre_cliente + '%')
        AND (@apellido_cliente IS NULL OR apellido_cliente LIKE '%' + @apellido_cliente + '%')
        AND (@telefono_cliente IS NULL OR telefono_cliente LIKE '%' + @telefono_cliente + '%')
        AND (@email_cliente IS NULL OR email_cliente LIKE '%' + @email_cliente + '%')
        AND (@localidad_cliente IS NULL OR localidad_cliente LIKE '%' + @localidad_cliente + '%')
        AND (@provincia_cliente IS NULL OR provincia_cliente LIKE '%' + @provincia_cliente + '%')
    ORDER BY
        apellido_cliente, nombre_cliente;
END
GO
