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



--5. BUSCAR CATEGORIA

CREATE OR ALTER PROCEDURE PROC_BUSCAR_CATEGORIA
    @busqueda_general VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        id_categoria,
        nombre_categoria,
        baja_categoria
    FROM 
        Categorias
    WHERE 
        (@busqueda_general IS NULL OR 
        nombre_categoria COLLATE Latin1_General_CI_AI LIKE '%' + @busqueda_general + '%' COLLATE Latin1_General_CI_AI);
END
GO

--6. CONTAR PRODUCTOS POR CATEGORIA

CREATE OR ALTER PROCEDURE PROC_CONTAR_PRODUCTOS_POR_CATEGORIA
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_categoria,
        c.nombre_categoria,
        COUNT(pc.id_producto) AS cantidad_productos
    FROM
        Categorias AS c
    INNER JOIN
        ProductosCategorias AS pc ON c.id_categoria = pc.id_categoria
    GROUP BY
        c.id_categoria, c.nombre_categoria
    ORDER BY
        cantidad_productos DESC, c.nombre_categoria ASC;
END
GO

--8. NUEVO MODIFICAR

CREATE OR ALTER PROCEDURE PROC_MODIFICAR_CATEGORIA
    -- Parámetros de entrada
    @id_categoria INT,
    @nombre_categoria NVARCHAR(50),
    @baja_categoria BIT, -- Nuevo parámetro para el estado (0 para alta, 1 para baja)
    
    -- Parámetro de salida
    @mensaje NVARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DECLARE @rows_affected INT;
        DECLARE @current_baja_categoria BIT;

        -- Obtener el estado actual de la categoría antes de la modificación
        SELECT @current_baja_categoria = baja_categoria
        FROM Categorias
        WHERE id_categoria = @id_categoria;

        BEGIN TRANSACTION;

        -- Actualizar el estado de la categoría en la tabla
        UPDATE Categorias
        SET 
            nombre_categoria = @nombre_categoria,
            baja_categoria = @baja_categoria
        WHERE id_categoria = @id_categoria;

        SET @rows_affected = @@ROWCOUNT;

        IF @rows_affected > 0
        BEGIN
            -- Si el estado se cambió a baja y antes no lo estaba
            IF @baja_categoria = 1 AND @current_baja_categoria = 0
            BEGIN
                -- 1. Eliminar los vínculos de esta categoría con todos los productos
                DELETE FROM ProductosCategorias
                WHERE id_categoria = @id_categoria;

                -- 2. Dar de baja los productos que se quedaron sin ninguna categoría
                UPDATE Productos
                SET baja_producto = 1
                WHERE id_producto NOT IN (SELECT id_producto FROM ProductosCategorias);
                
                SET @mensaje = 'Categoría y sus productos desvinculados dados de baja con éxito.';
            END
            ELSE
            BEGIN
                SET @mensaje = 'Categoría modificada con éxito.';
            END
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            -- Si no se afectaron filas, la categoría no existe
            SET @mensaje = 'Error: La categoría especificada no existe.';
            ROLLBACK TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        -- Si ocurre un error, deshacer cualquier cambio y capturar el mensaje de error del sistema
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        SET @mensaje = 'Error del sistema: ' + ERROR_MESSAGE();
    END CATCH
END
GO