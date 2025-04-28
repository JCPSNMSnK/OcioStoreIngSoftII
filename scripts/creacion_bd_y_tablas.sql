CREATE DATABASE ocio_store;
GO

USE ocio_store;
GO

CREATE TABLE Roles (
    id_rol INT IDENTITY(1,1) PRIMARY KEY,
    nombre_rol VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Users (
    id_user INT IDENTITY(1,1) PRIMARY KEY,
    apellido VARCHAR(50) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    mail VARCHAR(100) UNIQUE NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL,
    pass VARCHAR(255) NOT NULL,
    baja BIT NOT NULL DEFAULT 0,
    id_rol INT NOT NULL,
    FOREIGN KEY (id_rol) REFERENCES Roles(id_rol)
);

CREATE TABLE MediosPago (
    id_medio INT IDENTITY(1,1) PRIMARY KEY,
    nombre_medio VARCHAR(50) UNIQUE NOT NULL,
    comision DECIMAL(5,2) NOT NULL -- porcentaje por ejemplo
);

CREATE TABLE Productos (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    fechaIngreso DATE NOT NULL,
    precioLista DECIMAL(10,2) NOT NULL,
    precioVenta DECIMAL(10,2) NOT NULL,
    baja BIT NOT NULL DEFAULT 0,
    stock INT NOT NULL,
    stockMin INT NOT NULL,
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Categorias (
    id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    nombre_categoria VARCHAR(100) NOT NULL,
    baja BIT NOT NULL DEFAULT 0
);

CREATE TABLE ProductosCategorias (
    id_categoria INT NOT NULL,
    id_producto INT NOT NULL,
    PRIMARY KEY (id_categoria, id_producto),
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

CREATE TABLE Ventas (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    total DECIMAL(10,2) NOT NULL,
    id_medio INT NOT NULL,
    id_user INT NOT NULL,
    fechaVenta DATE NOT NULL,
    FOREIGN KEY (id_medio) REFERENCES MediosPago(id_medio),
    FOREIGN KEY (id_user) REFERENCES Users(id_user)
);

CREATE TABLE DetallesVentas (
    id_venta INT NOT NULL,
    id_producto INT NOT NULL,
    precioUnitario DECIMAL(10,2) NOT NULL,
    cantidad INT NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (id_venta, id_producto),
    FOREIGN KEY (id_venta) REFERENCES Ventas(id_venta),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);
