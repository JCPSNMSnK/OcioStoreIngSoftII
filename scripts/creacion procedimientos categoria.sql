--1. PROCEDIMIENTO REGISTRAR CATEGORIA
CREATE OR ALTER PROCEDURE PROC_REGISTRAR_CATEGORIA
    @nombre_categoria NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si ya existe una categoría con el mismo nombre.
    IF NOT EXISTS (SELECT 1 FROM Categorias WHERE nombre_categoria = @nombre_categoria)
    BEGIN
        -- Si no existe, insertar la nueva categoría.
        INSERT INTO Categorias (
            nombre_categoria,
            baja_categoria
        )
        VALUES (
            @nombre_categoria,
            0 -- Por defecto, una categoría nueva no está de baja.
        );
    END
END
GO

--2. PROCEDIMIENTO MODIFICAR CATEGORIA
CREATE OR ALTER PROCEDURE PROC_MODIFICAR_CATEGORIA
    @id_categoria INT,
    @nombre_categoria NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Categorias
    SET nombre_categoria = @nombre_categoria
    WHERE id_categoria = @id_categoria;
END
GO

--3. PROCEDIMIENTO NOMBRE YA EXISTE
CREATE OR ALTER PROCEDURE PROC_NOMBRE_CATEGORIA_EXISTE
    @id_categoria INT,
    @nombre_categoria NVARCHAR(50),
    @existe BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM Categorias
        WHERE nombre_categoria = @nombre_categoria AND id_categoria <> @id_categoria
    )
    BEGIN
        SET @existe = 1;
    END
    ELSE
    BEGIN
        SET @existe = 0;
    END
END
GO

--4. PROCEDIMIENTO BAJA CATEGORÍA

CREATE OR ALTER PROCEDURE PROC_DAR_DE_BAJA_CATEGORIA
    @id_categoria INT,
    @mensaje NVARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @mensaje = 'Operación completada exitosamente.';

    -- Iniciar la transacción
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Eliminar los vínculos de esta categoría con todos los productos
        DELETE FROM Productos_Categorias
        WHERE id_categoria = @id_categoria;

        -- 2. Dar de baja los productos que se quedaron sin ninguna categoría
        UPDATE Productos
        SET baja_producto = 1
        WHERE id_producto NOT IN (SELECT id_producto FROM Productos_Categorias);

        -- 3. Finalmente, dar de baja la categoría en la tabla de Categorias
        UPDATE Categorias
        SET baja_categoria = 1
        WHERE id_categoria = @id_categoria;

        -- 4. Si todo fue exitoso, confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- 5. Si algo falla, revertir la transacción y capturar el error
        ROLLBACK TRANSACTION;
        SET @mensaje = 'Error: No se pudo completar la operación. ' + ERROR_MESSAGE();
    END CATCH
END
GO

