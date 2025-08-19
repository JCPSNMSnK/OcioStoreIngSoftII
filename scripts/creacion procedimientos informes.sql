--1.PROCEDIMIENTO PRODUCTO MÁS VENDIDO

CREATE PROCEDURE PROC_INFORME_PRODUCTOS_MAS_VENDIDOS
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        p.nombre_producto,
        SUM(dv.cantidad) AS cantidad_vendida
    FROM
        Ventas v
    JOIN
        DetalleVenta dv ON v.id_venta = dv.id_venta
    JOIN
        Productos p ON dv.id_producto = p.id_producto
    WHERE
        v.fecha_venta >= @fecha_inicio AND v.fecha_venta <= @fecha_fin
    GROUP BY
        p.nombre_producto
    ORDER BY
        cantidad_vendida DESC;
END
GO

--2. PROCEDIMIENTO FLUCTUACION DE VENTAS

CREATE PROCEDURE PROC_INFORME_FLUCTUACION_VENTAS
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        CONVERT(DATE, fecha_venta) AS fecha_periodo,
        SUM(total) AS total_ventas
    FROM
        Ventas
    WHERE
        fecha_venta >= @fecha_inicio AND fecha_venta <= @fecha_fin
    GROUP BY
        CONVERT(DATE, fecha_venta)
    ORDER BY
        fecha_periodo ASC;
END
GO

--3. PROCEDIMIENTO CATEGORIAS MAS VENDIDA

CREATE PROCEDURE PROC_INFORME_CATEGORIAS_MAS_VENDIDAS
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.nombre_categoria,
        SUM(dv.cantidad) AS cantidad_vendida
    FROM
        Ventas v
    JOIN
        DetalleVenta dv ON v.id_venta = dv.id_venta
    JOIN
        Productos_Categorias pc ON dv.id_producto = pc.id_producto
    JOIN
        Categorias c ON pc.id_categoria = c.id_categoria
    WHERE
        v.fecha_venta >= @fecha_inicio AND v.fecha_venta <= @fecha_fin
    GROUP BY
        c.nombre_categoria
    ORDER BY
        cantidad_vendida DESC;
END
GO

--4. VENDEDOR CON MÁS VENTAS

CREATE PROCEDURE PROC_INFORME_VENDEDORES_MAS_VENTAS
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        u.nombre + ' ' + u.apellido AS nombre_vendedor,
        SUM(v.total) AS total_ventas
    FROM
        Ventas v
    JOIN
        Usuarios u ON v.id_usuario = u.id_usuario
    WHERE
        v.fecha_venta >= @fecha_inicio AND v.fecha_venta <= @fecha_fin
    GROUP BY
        u.nombre, u.apellido
    ORDER BY
        total_ventas DESC;
END
GO

--5. REGISTRAR INFORME

CREATE PROCEDURE PROC_REGISTRAR_INFORME
    @titulo NVARCHAR(100),
    @descripcion NVARCHAR(255),
    @fecha_generacion DATETIME,
    @tipo_informe NVARCHAR(50),
    @id_usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Informes (
        titulo,
        descripcion,
        fecha_generacion,
        tipo_informe,
        id_usuario
    )
    VALUES (
        @titulo,
        @descripcion,
        GETDATE(),
        @tipo_informe,
        @id_usuario
    );
END
GO

