SCRIPT MODIFICAR TABLA PROVEEDORES:
-- Script SQL para añadir la columna 'baja_proveedor' a la tabla 'Proveedores'

ALTER TABLE Proveedores
ADD baja_proveedor BIT NULL DEFAULT 0;

-----------------------------
----------------------------
----------
SCRIPT TABLA INTERMEDIA:

USE [ocio_store]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 1. CREAR LA TABLA INTERMEDIA
CREATE TABLE [dbo].[ProductosProveedores](
    [id_producto] [int] NOT NULL,
    [id_proveedor] [int] NOT NULL,
    
    -- Se pueden añadir otros campos aquí (ej: precio_compra, fecha_registro)
) ON [PRIMARY]
GO

-- 2. DEFINIR LA CLAVE PRIMARIA COMPUESTA
ALTER TABLE [dbo].[ProductosProveedores] 
ADD CONSTRAINT [PK_ProductosProveedores] PRIMARY KEY CLUSTERED 
(
    [id_producto] ASC,
    [id_proveedor] ASC
) ON [PRIMARY]
GO

-- 3. DEFINIR LA CLAVE FORÁNEA HACIA PRODUCTOS
ALTER TABLE [dbo].[ProductosProveedores]  WITH CHECK ADD  CONSTRAINT [FK_ProductosProveedores_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
ON DELETE CASCADE -- Si se elimina el producto, se elimina la relación
GO

ALTER TABLE [dbo].[ProductosProveedores] CHECK CONSTRAINT [FK_ProductosProveedores_Producto]
GO

-- 4. DEFINIR LA CLAVE FORÁNEA HACIA PROVEEDORES
ALTER TABLE [dbo].[ProductosProveedores]  WITH CHECK ADD  CONSTRAINT [FK_ProductosProveedores_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedores] ([id_proveedor])
ON DELETE CASCADE -- Si se elimina el proveedor (físicamente, aunque usamos baja lógica), se elimina la relación
GO

ALTER TABLE [dbo].[ProductosProveedores] CHECK CONSTRAINT [FK_ProductosProveedores_Proveedor]
GO

-----------------------------
----------------------------
----------

PROCEDIMIENTOS CREADOS:  pegaré el código si es necesario, es decir, si no te pasé directamente el .bak
[PROC_ASIGNAR_PROVEEDORES_A_PRODUCTO]

USE [ocio_store]
GO

/****** Object:  StoredProcedure [dbo].[PROC_ASIGNAR_PROVEEDORES_A_PRODUCTO]    Script Date: 13/12/2025 13:56:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[PROC_ASIGNAR_PROVEEDORES_A_PRODUCTO]
    @id_producto INT,
    @lista_proveedores dbo.TipoIds READONLY
AS
BEGIN
    -- 1. Eliminar relaciones antiguas
    DELETE FROM ProductosProveedores WHERE id_producto = @id_producto;
    
    -- 2. Insertar nuevas relaciones
    INSERT INTO ProductosProveedores (id_producto, id_proveedor)
    SELECT @id_producto, ID
    FROM @lista_proveedores;
END

GO


PROC_LISTAR_PROVEEDORES_ACTIVOS

USE [ocio_store]
GO

/****** Object:  StoredProcedure [dbo].[PROC_LISTAR_PROVEEDORES_ACTIVOS]    Script Date: 13/12/2025 13:57:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Nuevo Procedimiento para listar solo proveedores que NO están dados de baja
CREATE PROCEDURE [dbo].[PROC_LISTAR_PROVEEDORES_ACTIVOS]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        id_proveedor,
        nombre_proveedor,
        telefono_proveedor, -- Incluimos el teléfono/celular para identificación rápida
        cuit_proveedor
    FROM 
        dbo.Proveedores
    WHERE 
        baja_proveedor = 0 -- Solo trae los proveedores activos
    ORDER BY
        nombre_proveedor ASC;
END
GO


-----------------------------
----------------------------
----------
SCRIPT PARA MODIFICAR LA TABLA PRODUCTOS:
USE [ocio_store]
GO

-- 1. ELIMINAR LA RESTRICCIÓN FOREIGN KEY (si existe)
-- Se asume que el nombre de la FK es FK_Productos_Proveedores, según el script de Productos.
IF OBJECT_ID('FK_Productos_Proveedores') IS NOT NULL
BEGIN
    ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [FK_Productos_Proveedores]
END
GO

-- 2. ELIMINAR LA COLUMNA DE LA TABLA PRODUCTOS
ALTER TABLE [dbo].[Productos] 
DROP COLUMN [id_proveedor]
GO

-----------------------------
----------------------------
----------
PROCEDIMIENTOS MODIFICADOS: pegaré el código si es necesario, es decir, si no te pasé directamente el .bak. 

PONGO EL SCRIPT OBTENIDO POR EL CREATE EN SQL SERVER . Reemplacé ALTER en CREATE para que lo cargues directamente sin problema.

1. PROC_MODIFICAR_PROVEEDOR (Punto 29)
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[PROC_MODIFICAR_PROVEEDOR]
    @id_proveedor INT,
    @nombre_proveedor VARCHAR(100) = NULL,
    @telefono_proveedor VARCHAR(20) = NULL,
    @cuit_proveedor VARCHAR(20) = NULL,
    @baja_proveedor BIT = NULL, -- Parámetro para la baja lógica
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar variable de salida
    SET @mensaje = '';

    -- 1. Validar si el proveedor con el ID especificado existe
    IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE id_proveedor = @id_proveedor)
    BEGIN
        SET @mensaje = 'Error: El proveedor con el ID especificado no existe.';
        RETURN;
    END

    BEGIN TRY
        DECLARE @current_baja_proveedor BIT;

        -- Obtener el estado actual del proveedor antes de la modificación
        SELECT @current_baja_proveedor = baja_proveedor
        FROM Proveedores
        WHERE id_proveedor = @id_proveedor;

        BEGIN TRANSACTION;

        -- 2. Actualizar la tabla principal de Proveedores
        UPDATE Proveedores
        SET
            nombre_proveedor = ISNULL(@nombre_proveedor, nombre_proveedor),
            telefono_proveedor = ISNULL(@telefono_proveedor, telefono_proveedor),
            cuit_proveedor = ISNULL(@cuit_proveedor, cuit_proveedor),
            baja_proveedor = ISNULL(@baja_proveedor, baja_proveedor) 
        WHERE
            id_proveedor = @id_proveedor;

        -- 3. Si el estado se cambió a baja (1) y antes no lo estaba (0)
        IF ISNULL(@baja_proveedor, @current_baja_proveedor) = 1 AND @current_baja_proveedor = 0
        BEGIN
            -- A. Eliminar los vínculos de este proveedor con todos los productos
            DELETE FROM ProductosProveedores
            WHERE id_proveedor = @id_proveedor;

            -- B. Dar de baja los productos que se quedaron sin NINGÚN proveedor
            UPDATE Productos
            SET baja_producto = 1
            WHERE id_producto NOT IN (SELECT id_producto FROM ProductosProveedores);
            
            SET @mensaje = 'Proveedor dado de baja. Productos sin proveedor también se dieron de baja.';
        END
        ELSE
        BEGIN
            SET @mensaje = 'Proveedor modificado con éxito.';
        END
           
        COMMIT TRANSACTION;

    END TRY
    BEGIN CATCH
        -- Si algo falla, revertimos todos los cambios
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorMensaje NVARCHAR(4000) = ERROR_MESSAGE();
        SET @mensaje = 'Error inesperado al modificar el proveedor: ' + @ErrorMensaje;
    END CATCH
END;

2. PROC_REGISTRAR_PROVEEDOR (Punto 43)

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_REGISTRAR_PROVEEDOR]
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
        INSERT INTO Proveedores 
        (
            nombre_proveedor, 
            telefono_proveedor, 
            cuit_proveedor,
            baja_proveedor -- AÑADIDO: Incluimos explícitamente la columna de baja
        )
        VALUES 
        (
            @nombre_proveedor, 
            @telefono_proveedor, 
            @cuit_proveedor,
            0 -- AÑADIDO: Se establece explícitamente como ACTIVO (0)
        );

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

3. PROC_BUSCAR_PROVEEDORES (Punto 7)

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_BUSCAR_PROVEEDORES]
    @nombre_proveedor VARCHAR(100) = NULL,
    @telefono_proveedor VARCHAR(20) = NULL,
    @cuit_proveedor VARCHAR(20) = NULL,
    @incluir_inactivos BIT = 0 -- AÑADIDO: Nuevo parámetro para controlar la baja lógica
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_proveedor,
        nombre_proveedor,
        telefono_proveedor,
        cuit_proveedor,
        baja_proveedor -- AÑADIDO: Incluir la columna de baja en la salida
    FROM
        Proveedores
    WHERE
        (@nombre_proveedor IS NULL OR nombre_proveedor LIKE '%' + @nombre_proveedor + '%')
        AND (@telefono_proveedor IS NULL OR telefono_proveedor LIKE '%' + @telefono_proveedor + '%')
        AND (@cuit_proveedor IS NULL OR cuit_proveedor LIKE '%' + @cuit_proveedor + '%')
        
        -- AÑADIDO: FILTRO DE BAJA LÓGICA
        -- Si @incluir_inactivos es 0 (FALSE, por defecto), solo muestra los NO dados de baja (baja_proveedor = 0).
        -- Si @incluir_inactivos es 1 (TRUE), ignora el filtro de baja y muestra todos.
        AND (@incluir_inactivos = 1 OR baja_proveedor = 0) 
        
    ORDER BY
        nombre_proveedor;
END


4. Otros Procedimientos Afectados (Solo Lectura)
PROC_OBTENER_PROVEEDOR_POR_ID (Punto 33)

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_OBTENER_PROVEEDOR_POR_ID]
    @id_proveedor INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_proveedor,
        nombre_proveedor,
        cuit_proveedor,
        telefono_proveedor,
        baja_proveedor -- AÑADIDO: Incluimos el estado de baja en la salida
    FROM
        Proveedores
    WHERE
        id_proveedor = @id_proveedor;
END



PROC_BUSCAR_PRODUCTO (Punto 6)

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_BUSCAR_PRODUCTO]
    @id_producto INT = NULL,
    @nombre_producto VARCHAR(100) = NULL,
    @fechaIngreso DATE = NULL,
    @precioLista DECIMAL(10,2) = NULL,
    @precioVenta DECIMAL(10,2) = NULL,
    @baja_producto BIT = NULL,
    @stock INT = NULL,
    @stock_min INT = NULL,
    @descripcion VARCHAR(250) = NULL,
    @id_categoria INT = NULL,
    @nombre_categoria VARCHAR(100) = NULL,
    @cod_producto INT = NULL,
    
    -- Eliminado: @id_proveedor INT = NULL,  <-- YA NO EXISTE EN PRODUCTOS
    @id_proveedor_filtro INT = NULL,        -- NUEVO: Parámetro de filtro para el proveedor
    @nombre_proveedor VARCHAR(100) = NULL,
    @busqueda_general VARCHAR(100) = NULL 
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id_producto,
        p.nombre_producto,
        p.fechaIngreso,
        p.precioLista,
        p.precioVenta,
        p.baja_producto,
        p.stock,
        p.stock_min,
        p.descripcion,
        p.cod_producto,
        c.id_categoria,
        c.nombre_categoria,
        
        -- DATOS DEL PROVEEDOR (AÑADIDOS)
        pr.id_proveedor,                        -- AHORA VIENE DE LA TABLA INTERMEDIA
        pr.nombre_proveedor,
        pr.baja_proveedor                       -- AÑADIDO: Estado de baja del proveedor
        
    FROM Productos p
    
    LEFT JOIN ProductosCategorias pc ON p.id_producto = pc.id_producto
    LEFT JOIN Categorias c ON pc.id_categoria = c.id_categoria
    
    -- MODIFICACIÓN CRÍTICA: JOIN a través de la tabla intermedia
    LEFT JOIN ProductosProveedores pp ON p.id_producto = pp.id_producto
    LEFT JOIN Proveedores pr ON pp.id_proveedor = pr.id_proveedor 

    WHERE
        -- Lógica de búsqueda general
        (@busqueda_general IS NULL OR
            p.nombre_producto LIKE '%' + @busqueda_general + '%' OR
            p.descripcion LIKE '%' + @busqueda_general + '%' OR
            p.cod_producto LIKE '%' + @busqueda_general + '%' OR
            c.nombre_categoria LIKE '%' + @busqueda_general + '%' OR
            pr.nombre_proveedor LIKE '%' + @busqueda_general + '%') 
        AND
        (@id_producto IS NULL OR p.id_producto = @id_producto) AND
        (@nombre_producto IS NULL OR p.nombre_producto COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_producto + '%' COLLATE Latin1_General_CI_AI) AND
        (@fechaIngreso IS NULL OR p.fechaIngreso = @fechaIngreso) AND
        (@precioLista IS NULL OR p.precioLista = @precioLista) AND
        (@precioVenta IS NULL OR p.precioVenta = @precioVenta) AND
        (@baja_producto IS NULL OR p.baja_producto = @baja_producto) AND
        (@stock IS NULL OR p.stock = @stock) AND
        (@stock_min IS NULL OR p.stock_min = @stock_min) AND
        (@descripcion IS NULL OR p.descripcion COLLATE Latin1_General_CI_AI LIKE '%' + @descripcion + '%' COLLATE Latin1_General_CI_AI) AND
        (@id_categoria IS NULL OR c.id_categoria = @id_categoria) AND
        (@nombre_categoria IS NULL OR c.nombre_categoria COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_categoria + '%' COLLATE Latin1_General_CI_AI) AND
        (@cod_producto IS NULL OR p.cod_producto = @cod_producto) AND
        
        --  CRÍTICA: Filtro por ID de proveedor ahora usa la tabla intermedia
        (@id_proveedor_filtro IS NULL OR pp.id_proveedor = @id_proveedor_filtro) AND 
        
        (@nombre_proveedor IS NULL OR pr.nombre_proveedor COLLATE Latin1_General_CI_AI LIKE '%' + @nombre_proveedor + '%' COLLATE Latin1_General_CI_AI)
    
END

PROC_BUSCAR_COMPRAS (Punto 4)

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_BUSCAR_COMPRAS]
    @id_proveedor INT = NULL,
    @fecha_inicio DATE = NULL,
    @fecha_fin DATE = NULL,
    @total_min DECIMAL(10, 2) = NULL,
    @total_max DECIMAL(10, 2) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_compra,
        c.fecha_compra,
        c.total,
        p.nombre_proveedor,
        p.baja_proveedor -- AÑADIDO: Devolver el estado actual de baja del proveedor
    FROM
        Compras c
    INNER JOIN
        Proveedores p ON c.id_proveedor = p.id_proveedor
    WHERE
        (@id_proveedor IS NULL OR c.id_proveedor = @id_proveedor)
        AND (@fecha_inicio IS NULL OR c.fecha_compra >= @fecha_inicio)
        AND (@fecha_fin IS NULL OR c.fecha_compra <= @fecha_fin)
        AND (@total_min IS NULL OR c.total >= @total_min)
        AND (@total_max IS NULL OR c.total <= @total_max)
    ORDER BY
        c.fecha_compra DESC;
END


PROC_CREAR_PRODUCTO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_CREAR_PRODUCTO]
    @nombre_producto VARCHAR(100),
    @id_categorias TipoIds READONLY, -- Lista de IDs de categorías
    @fechaIngreso DATE,
    @precioLista DECIMAL(10,2),
    @precioVenta DECIMAL(10,2),
    @stock INT,
    @stock_min INT,
    @eliminado BIT, -- Asumido: @eliminado = baja_producto
    @descripcion VARCHAR(MAX) = NULL,
    @cod_producto INT,
    @id_proveedores TipoIds READONLY, -- CAMBIADO: Lista de IDs de proveedores
    @id_producto_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @id_producto_generado = 0;
    SET @mensaje = '';

    -- Iniciar una transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Validar si el código de producto ya existe
        IF EXISTS (SELECT 1 FROM Productos WHERE cod_producto = @cod_producto)
        BEGIN
            SET @mensaje = 'Error: El código de producto ya existe.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Insertar el nuevo producto (SIN id_proveedor)
        INSERT INTO Productos (nombre_producto, fechaIngreso, precioLista, precioVenta, baja_producto, stock, stock_min, descripcion, cod_producto)
        VALUES (@nombre_producto, @fechaIngreso, @precioLista, @precioVenta, @eliminado, @stock, @stock_min, @descripcion, @cod_producto);

        -- Obtener el ID del producto recién insertado
        SET @id_producto_generado = SCOPE_IDENTITY();

        -- 3. Insertar las categorías en la tabla intermedia ProductosCategorias (Lógica existente)
        INSERT INTO ProductosCategorias (id_producto, id_categoria)
        SELECT @id_producto_generado, ID
        FROM @id_categorias;
        
        -- 4. Insertar los proveedores en la tabla intermedia ProductosProveedores (NUEVA LÓGICA)
        INSERT INTO ProductosProveedores (id_producto, id_proveedor)
        SELECT @id_producto_generado, ID
        FROM @id_proveedores;
        
        -- Confirmar la transacción
        COMMIT TRANSACTION;
        SET @mensaje = 'Producto, categorías y proveedores registrados exitosamente.';
        
    END TRY
    BEGIN CATCH
        -- En caso de error, revertir la transacción
        SET @id_producto_generado = 0;
        SET @mensaje = 'Error al registrar el producto. Detalles: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;
END;


PROC_EDITAR_PRODUCTO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[PROC_EDITAR_PRODUCTO]
    @id_producto INT,
    @nombre_producto VARCHAR(100),
    @precioLista DECIMAL(10,2),
    @precioVenta DECIMAL(10,2),
    @baja_producto BIT,
    @stock INT,
    @stock_min INT,
    @descripcion TEXT,
    @cod_producto INT,
    -- ELIMINADO: @id_proveedor INT, 
    @nuevas_categorias TipoIds READONLY, 
    @nuevos_proveedores TipoIds READONLY, -- AÑADIDO: Lista de IDs de los nuevos proveedores
    @respuesta BIT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @respuesta = 0;
    SET @mensaje = '';

    -- Iniciar una transacción para asegurar que todo se haga o nada se haga
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Validar nombre repetido en otro producto
        IF EXISTS (SELECT 1 FROM Productos WHERE nombre_producto = @nombre_producto AND id_producto != @id_producto)
        BEGIN
            SET @mensaje = 'Ya existe otro producto con ese nombre.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Validar código repetido en otro producto
        IF EXISTS (SELECT 1 FROM Productos WHERE cod_producto = @cod_producto AND id_producto != @id_producto)
        BEGIN
            SET @mensaje = 'Ya existe otro producto con ese código.';
            ROLLBACK TRANSACTION;
            RETURN;
        END
        
        -- 2.5 OPCIONAL: Validar que todos los IDs de proveedores existan antes de la actualización.
        -- Se puede omitir por ahora si el control se hace en el lado de la aplicación.
        
        -- 3. Actualizar la tabla principal de Productos
        UPDATE Productos SET
            nombre_producto = @nombre_producto,
            precioLista = @precioLista,
            precioVenta = @precioVenta,
            baja_producto = @baja_producto,
            stock = @stock,
            stock_min = @stock_min,
            descripcion = @descripcion,
            cod_producto = @cod_producto
            -- ELIMINADA: id_proveedor = @id_proveedor
        WHERE id_producto = @id_producto;

        -- 4. Sincronizar las categorías (Lógica existente)
        DELETE FROM ProductosCategorias WHERE id_producto = @id_producto;
        INSERT INTO ProductosCategorias (id_producto, id_categoria)
        SELECT @id_producto, ID FROM @nuevas_categorias;
        
        -- 5. Sincronizar los proveedores (NUEVA LÓGICA)
        --    Primero, borramos las relaciones viejas para este producto.
        DELETE FROM ProductosProveedores WHERE id_producto = @id_producto;
        
        --    Segundo, insertamos las nuevas relaciones desde la lista que recibimos.
        INSERT INTO ProductosProveedores (id_producto, id_proveedor)
        SELECT @id_producto, ID FROM @nuevos_proveedores;
        
        -- Si todo salió bien, confirmamos los cambios
        COMMIT TRANSACTION;
        SET @respuesta = 1;
        SET @mensaje = 'Producto actualizado correctamente.';

    END TRY
    BEGIN CATCH
        -- Si algo falla, revertimos todos los cambios
        SET @mensaje = 'Error al actualizar el producto. Detalles: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH
END


PROC_OBTENER_PRODUCTO_COMPLETO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Se usa ALTER para modificar el procedimiento existente
ALTER PROCEDURE [dbo].[PROC_OBTENER_PRODUCTO_COMPLETO]
    @id_producto INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Primer SELECT: Obtener los datos del producto (Datos principales)
    SELECT
        id_producto,
        nombre_producto,
        fechaIngreso,
        precioLista,
        precioVenta,
        baja_producto,
        stock,
        stock_min,
        descripcion,
        cod_producto
        -- ELIMINADO: id_proveedor <-- Ya no existe en la tabla Productos
    FROM
        Productos
    WHERE
        id_producto = @id_producto;

    -- Segundo SELECT: Obtener la lista de categorías asociadas (Lógica existente)
    SELECT
        c.id_categoria,
        c.nombre_categoria
    FROM
        ProductosCategorias pc
    INNER JOIN
        Categorias c ON pc.id_categoria = c.id_categoria
    WHERE
        pc.id_producto = @id_producto;

    -- Tercer SELECT: Obtener la lista de proveedores asociados (NUEVA LÓGICA)
    SELECT
        p.id_proveedor,
        p.nombre_proveedor,
        p.baja_proveedor -- Incluir estado de baja
    FROM
        ProductosProveedores pp -- Tabla intermedia
    INNER JOIN
        Proveedores p ON pp.id_proveedor = p.id_proveedor
    WHERE
        pp.id_producto = @id_producto;

END;


PROCEDIMIENTO PROC_REGISTRAR_COMPRA_TRANSACCIÓN
USE [ocio_store]
GO

/****** Object:  StoredProcedure [dbo].[PROC_REGISTRAR_COMPRA_TRANSACCION]    Script Date: 14/12/2025 00:28:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER   PROCEDURE [dbo].[PROC_REGISTRAR_COMPRA_TRANSACCION]
    @id_proveedor INT,
    @total_compra DECIMAL(10, 2),

    @detalles_compra AS TIPO_DETALLE_COMPRA READONLY,

    @id_compra_generado INT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @id_compra_generado = 0;
    SET @mensaje = '';

    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Insertar la compra principal en la tabla Compras
        INSERT INTO Compras (id_proveedor, total, fecha_compra)
        VALUES (@id_proveedor, @total_compra, GETDATE());

        SET @id_compra_generado = SCOPE_IDENTITY();

        -- 2. Insertar los detalles de la compra en la tabla DetallesCompras
        INSERT INTO DetallesCompras (id_compra, id_producto, precio_unitario, cantidad)
        SELECT @id_compra_generado, id_producto, precio_unitario, cantidad
        FROM @detalles_compra;
        
        -- 3. Actualizar el stock de los productos comprados
        UPDATE P
        SET P.stock = P.stock + DC.cantidad
        FROM Productos P
        INNER JOIN @detalles_compra DC ON P.id_producto = DC.id_producto;

		-- -------------------------------------------------------------------------
        -- 4. NUEVO: Vincular productos con el proveedor (Relación Muchos a Muchos)
        -- -------------------------------------------------------------------------
        -- Insertamos en la tabla intermedia SOLO si la relación no existe aún.
        INSERT INTO ProductosProveedores (id_producto, id_proveedor)
        SELECT DISTINCT DC.id_producto, @id_proveedor
        FROM @detalles_compra DC
        WHERE NOT EXISTS (
            SELECT 1 
            FROM ProductosProveedores PP 
            WHERE PP.id_producto = DC.id_producto 
              AND PP.id_proveedor = @id_proveedor
        );

        -- Confirmar la transacción si todas las operaciones son exitosas
        COMMIT TRANSACTION;
        SET @mensaje = 'Compra registrada y stock actualizado exitosamente.';

    END TRY
    BEGIN CATCH
        -- Si ocurre un error, revertir la transacción para mantener la consistencia
        ROLLBACK TRANSACTION;
        SET @id_compra_generado = 0;
        SET @mensaje = 'Error al registrar la compra. Se ha cancelado la operación. ' + ERROR_MESSAGE();
    END CATCH;
END;
GO



<z
-----------------------------
----------------------------
----------

SCRIPT SQL DAR PROVEEDORES DE ALTA:
-- Script SQL para establecer 'baja_proveedor' a 0 (ACTIVO)
-- para todos los proveedores existentes en la tabla.

UPDATE Proveedores
SET baja_proveedor = 0
WHERE baja_proveedor IS NULL OR baja_proveedor = 1; -- Aseguramos que se actualicen los que estaban NULL
GO

-- OPCIONAL: Verificar los resultados
EXEC PROC_LISTAR_PROVEEDORES_ACTIVOS
