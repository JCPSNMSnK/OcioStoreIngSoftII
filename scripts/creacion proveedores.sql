CREATE TABLE Proveedores (
    id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
    nombre_proveedor VARCHAR(100),
    telefono_proveedor VARCHAR(20),
    cuit_proveedor VARCHAR(20) UNIQUE
);


--1.REGISTRAR PROVEEDORES

CREATE OR ALTER PROCEDURE PROC_REGISTRAR_PROVEEDOR
    @nombre_proveedor VARCHAR(100),
    @telefono_proveedor VARCHAR(20),
    @cuit_proveedor VARCHAR(20),
    @id_proveedor_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variables de salida
    SET @id_proveedor_generado = 0;
    SET @mensaje = '';

    -- Validar que el CUIT no esté duplicado
    IF EXISTS (SELECT 1 FROM Proveedores WHERE cuit_proveedor = @cuit_proveedor)
    BEGIN
        SET @mensaje = 'Error: El CUIT ingresado ya pertenece a un proveedor registrado.';
        RETURN;
    END

    -- Intentar insertar el nuevo proveedor
    BEGIN TRY
        INSERT INTO Proveedores (nombre_proveedor, telefono_proveedor, cuit_proveedor)
        VALUES (@nombre_proveedor, @telefono_proveedor, @cuit_proveedor);

        -- Obtener el ID del proveedor recién insertado
        SET @id_proveedor_generado = SCOPE_IDENTITY();
        SET @mensaje = 'Proveedor registrado exitosamente.';
    END TRY
    BEGIN CATCH
        -- En caso de error, capturar el mensaje
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al registrar el proveedor: ' + @ErrorMensaje;
        SET @id_proveedor_generado = 0;
    END CATCH
END;
GO

--2. MODIFICAR PROVEEDOR

CREATE OR ALTER PROCEDURE PROC_MODIFICAR_PROVEEDOR
    @id_proveedor INT,
    @nombre_proveedor VARCHAR(100) = NULL,
    @telefono_proveedor VARCHAR(20) = NULL,
    @cuit_proveedor VARCHAR(20) = NULL,

    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variable de salida
    SET @mensaje = '';

    -- Validar si el proveedor con el ID especificado existe
    IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE id_proveedor = @id_proveedor)
    BEGIN
        SET @mensaje = 'Error: El proveedor con el ID especificado no existe.';
        RETURN;
    END

    -- Intentar actualizar los datos del proveedor
    BEGIN TRY
        UPDATE Proveedores
        SET
            nombre_proveedor = ISNULL(@nombre_proveedor, nombre_proveedor),
            telefono_proveedor = ISNULL(@telefono_proveedor, telefono_proveedor),
            cuit_proveedor = ISNULL(@cuit_proveedor, cuit_proveedor)
        WHERE
            id_proveedor = @id_proveedor;

        SET @mensaje = 'Proveedor modificado exitosamente.';
    END TRY
    BEGIN CATCH
        -- Capturar el error y guardar el mensaje en caso de fallo
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al modificar el proveedor: ' + @ErrorMensaje;
    END CATCH
END;
GO

--3. BUSCAR PROVEEDORES

CREATE OR ALTER PROCEDURE PROC_BUSCAR_PROVEEDORES
    @nombre_proveedor VARCHAR(100) = NULL,
    @telefono_proveedor VARCHAR(20) = NULL,
    @cuit_proveedor VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_proveedor,
        nombre_proveedor,
        telefono_proveedor,
        cuit_proveedor
    FROM
        Proveedores
    WHERE
        (@nombre_proveedor IS NULL OR nombre_proveedor LIKE '%' + @nombre_proveedor + '%')
        AND (@telefono_proveedor IS NULL OR telefono_proveedor LIKE '%' + @telefono_proveedor + '%')
        AND (@cuit_proveedor IS NULL OR cuit_proveedor LIKE '%' + @cuit_proveedor + '%')
    ORDER BY
        nombre_proveedor;
END
GO

--4. OBTENER PROVEEDOR POR ID

CREATE OR ALTER PROCEDURE PROC_OBTENER_PROVEEDOR_POR_ID
    @id_proveedor INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_proveedor,
        nombre_proveedor,
        cuit_proveedor,
        telefono_proveedor
    FROM
        Proveedores
    WHERE
        id_proveedor = @id_proveedor;
END
GO




