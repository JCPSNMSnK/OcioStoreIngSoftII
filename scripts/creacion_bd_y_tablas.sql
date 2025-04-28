CREATE DATABASE ocio_store;
GO

USE ocio_store;
GO

-- Tabla Roles
CREATE TABLE Roles (
    id_rol INT IDENTITY(1,1),
    nombre_rol VARCHAR(50) NOT NULL,
    descripcion VARCHAR(255),
    CONSTRAINT PK_Roles PRIMARY KEY (id_rol),
    CONSTRAINT UQ_Roles_nombre UNIQUE (nombre_rol)
);

-- Tabla Users
CREATE TABLE Users (
    id_user INT IDENTITY(1,1),
    apellido VARCHAR(100) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    dni VARCHAR(20) NOT NULL,
    mail VARCHAR(100) NOT NULL,
    username VARCHAR(50) NOT NULL,
    pass VARCHAR(255) NOT NULL,
    baja_user BIT DEFAULT 0,  -- Aquí se usa BIT (0 para falso, 1 para verdadero)
    id_rol INT NOT NULL,
    CONSTRAINT PK_Users PRIMARY KEY (id_user),
    CONSTRAINT UQ_Users_dni UNIQUE (dni),
    CONSTRAINT UQ_Users_mail UNIQUE (mail),
    CONSTRAINT UQ_Users_username UNIQUE (username),
    CONSTRAINT FK_Users_Rol FOREIGN KEY (id_rol) REFERENCES Roles(id_rol) ON DELETE CASCADE
);

-- Tabla MetodosPago
CREATE TABLE MetodosPago (
    id_medioPago INT IDENTITY(1,1),
    comision DECIMAL(5,2) NOT NULL,
    nombre_medio VARCHAR(50) NOT NULL,
    CONSTRAINT PK_MetodosPago PRIMARY KEY (id_medioPago),
    CONSTRAINT UQ_MetodosPago_nombre UNIQUE (nombre_medio)
);

-- Tabla Categorias
CREATE TABLE Categorias (
    id_categoria INT IDENTITY(1,1),
    nombre_categoria VARCHAR(100) NOT NULL,
    baja_categoria BIT DEFAULT 0,  -- Aquí también se usa BIT (0 para falso, 1 para verdadero)
    CONSTRAINT PK_Categorias PRIMARY KEY (id_categoria),
    CONSTRAINT UQ_Categorias_nombre UNIQUE (nombre_categoria)
);

-- Tabla Productos
CREATE TABLE Productos (
    id_producto INT IDENTITY(1,1),
    nombre_producto VARCHAR(100) NOT NULL,
    fecha_ingreso DATE NOT NULL,
    precio_culata DECIMAL(10,2) NOT NULL,
    precio_venta DECIMAL(10,2) NOT NULL,
    baja_producto BIT DEFAULT 0,  -- Lo mismo aquí, 0 para falso
    stock INT NOT NULL,
    stock_min INT NOT NULL,
    descripcion TEXT,
    CONSTRAINT PK_Productos PRIMARY KEY (id_producto)
);

-- Tabla ProductosCategorias (tabla puente muchos a muchos)
CREATE TABLE ProductosCategorias (
    id_producto INT NOT NULL,
    id_categoria INT NOT NULL,
    CONSTRAINT PK_ProductosCategorias PRIMARY KEY (id_producto, id_categoria),
    CONSTRAINT FK_ProductosCategorias_Producto FOREIGN KEY (id_producto) REFERENCES Productos(id_producto) ON DELETE CASCADE,
    CONSTRAINT FK_ProductosCategorias_Categoria FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria) ON DELETE CASCADE
);

-- Tabla Ventas
CREATE TABLE Ventas (
    id_venta INT IDENTITY(1,1),
    id_medio INT NOT NULL,
    id_user INT NOT NULL,
    fecha_venta DATETIME NOT NULL,
    CONSTRAINT PK_Ventas PRIMARY KEY (id_venta),
    CONSTRAINT FK_Ventas_MetodoPago FOREIGN KEY (id_medio) REFERENCES MetodosPago(id_medioPago) ON DELETE CASCADE,
    CONSTRAINT FK_Ventas_User FOREIGN KEY (id_user) REFERENCES Users(id_user) ON DELETE CASCADE
);

-- Tabla DetalleVentas
CREATE TABLE DetalleVentas (
    id_venta INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    CONSTRAINT PK_DetalleVentas PRIMARY KEY (id_venta, id_producto),
    CONSTRAINT FK_DetalleVentas_Venta FOREIGN KEY (id_venta) REFERENCES Ventas(id_venta) ON DELETE CASCADE,
    CONSTRAINT FK_DetalleVentas_Producto FOREIGN KEY (id_producto) REFERENCES Productos(id_producto) ON DELETE CASCADE
);

-- Tabla Informe
CREATE TABLE Informe (
    id_informe INT IDENTITY(1,1),
    titulo VARCHAR(100) NOT NULL,
    descripcion TEXT,
    fecha_generacion DATETIME NOT NULL,
    tipo_informe VARCHAR(50) NOT NULL,
    id_user INT NOT NULL,
    CONSTRAINT PK_Informe PRIMARY KEY (id_informe),
    CONSTRAINT FK_Informe_User FOREIGN KEY (id_user) REFERENCES Users(id_user) ON DELETE CASCADE
);

-- Tabla InformeDetalle
CREATE TABLE InformeDetalle (
    id_informeDetalle INT IDENTITY(1,1),
    id_informe INT NOT NULL,
    id_venta INT NOT NULL,
    id_user INT NOT NULL,
    id_producto INT NOT NULL,
    id_categoria INT NOT NULL,
    CONSTRAINT PK_InformeDetalle PRIMARY KEY (id_informeDetalle),
    CONSTRAINT FK_InformeDetalle_Informe FOREIGN KEY (id_informe) REFERENCES Informe(id_informe) ON DELETE CASCADE,
    CONSTRAINT FK_InformeDetalle_Venta FOREIGN KEY (id_venta) REFERENCES Ventas(id_venta),
    CONSTRAINT FK_InformeDetalle_User FOREIGN KEY (id_user) REFERENCES Users(id_user),
    CONSTRAINT FK_InformeDetalle_Producto FOREIGN KEY (id_producto) REFERENCES Productos(id_producto) ON DELETE CASCADE,
    CONSTRAINT FK_InformeDetalle_Categoria FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria) ON DELETE CASCADE,
    CONSTRAINT UQ_InformeDetalle_Combinacion UNIQUE (id_informe, id_venta, id_user, id_producto, id_categoria)
);

