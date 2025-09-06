USE ocio_store;
GO

-- Roles
INSERT INTO Roles (nombre_rol, descripcion) VALUES
('Administrador', 'Gestiona usuarios, productos y categorias'),
('Analista de Ventas', 'Genera informes y análisis de ventas, empleados y productos'),
('Vendedor', 'Atiende ventas y ve estaditicas propias'),
('Super Admin', 'Gestiona usuarios, proveedores, backup, ve todas las facturaciones.');
-- Users
INSERT INTO Users (apellido, nombre, dni, mail, username, pass, id_rol) VALUES
('González', 'María', '30222444', 'maria_gonzalez@gmail.com', 'mariaG', 'pass123', 3), -- Vendedor
('Pérez', 'Juan', '28444555', 'juan_perez@gmail.com', 'juanP', 'pass123', 3), -- Vendedor
('Sánchez', 'Lucía', '31555666', 'lucia_sanchez@gmail.com', 'luciaS', 'pass123', 2), -- Analista de ventas
('Admin', 'Admin', '00000000', 'admin@ociostore.com', 'admin', 'admin123', 1), -- Administrador
('Fernández', 'Luis', '38123456', 'luis.fernandez@mail.com', 'lfernandez', 'hashedpass345', 4);

-- Métodos de pago
INSERT INTO MetodosPago (comision, nombre_medio) VALUES
(0.00, 'Efectivo'),
(2.50, 'Tarjeta de Crédito'),
(1.75, 'Transferencia Bancaria');

-- Categorías
INSERT INTO Categorias (nombre_categoria) VALUES
('Juegos de Mesa Clásicos'),
('Juegos de Cartas'),
('Juegos de Estrategia'),
('Juegos de Rol'),
('Accesorios');

-- Productos
INSERT INTO Productos (nombre_producto, fechaIngreso, precioLista, precioVenta, stock, stock_min, descripcion) VALUES
('Ajedrez', '2025-04-01', 5000, 8500, 20, 5, 'Juego clásico de estrategia.'),
('Damas', '2025-04-01', 3000, 5000, 15, 5, 'Juego clásico de lógica y movimiento.'),
('Baraja Española', '2025-04-01', 1500, 2500, 30, 10, 'Mazo de cartas españolas.'),
('Catan', '2025-04-01', 15000, 22000, 10, 2, 'Juego de estrategia para colonizar islas.'),
('Carcassonne', '2025-04-01', 12000, 18000, 8, 2, 'Juego de construcción de caminos y ciudades.'),
('Dungeons & Dragons Starter Set', '2025-04-01', 17000, 25000, 5, 1, 'Set de inicio para D&D.'),
('Fundas para cartas (100 unidades)', '2025-04-01', 2000, 3500, 50, 10, 'Fundas protectoras tamaño estándar.');

-- ProductosCategorias
INSERT INTO ProductosCategorias (id_producto, id_categoria) VALUES
(1, 1), -- Ajedrez → Juegos de Mesa Clásicos
(2, 1), -- Damas → Juegos de Mesa Clásicos
(3, 2), -- Baraja Española → Juegos de Cartas
(4, 3), -- Catan → Juegos de Estrategia
(5, 3), -- Carcassonne → Juegos de Estrategia
(6, 4), -- D&D Starter Set → Juegos de Rol
(7, 5); -- Fundas → Accesorios

-- Insertar datos en Ventas
INSERT INTO Ventas (total, id_medio, id_user, fecha_venta) VALUES
(729.98, 2, 2, '2023-05-10 10:30:00'),  -- Venta 1
(89.98, 1, 2, '2023-05-11 15:45:00'),    -- Venta 2
(209.97, 3, 2, '2023-05-12 11:20:00'),   -- Venta 3
(49.99, 1, 2, '2023-05-13 16:10:00');    -- Venta 4

-- DetalleVentas
INSERT INTO DetalleVentas (id_venta, id_producto, cantidad, subtotal) VALUES
(2, 4, 1, 22000), -- Vendido 1 Catan
(2, 1, 2, 17000), -- Vendido 2 Ajedrez
(3, 2, 1, 5000), -- Vendido 1 Damas
(3, 3, 3, 7500); -- Vendido 3 Baraja Española

-- Informe
INSERT INTO Informe (titulo, descripcion, fechaGeneracion, tipo_informe, id_user) VALUES
('Informe de Ventas Semana 1', 'Informe detallado de ventas entre el 20 y 21 de abril.', 2025-04-22, 'Ventas', 3); -- Hecho por Analista

-- InformeDetalle
INSERT INTO InformeDetalle (id_informe, id_venta, id_user, id_producto, id_categoria) VALUES
(1, 1, 1, 4, 3), -- Catan vendido por María
(1, 1, 1, 1, 1), -- Ajedrez vendido por María
(1, 2, 2, 2, 1), -- Damas vendido por Juan
(1, 2, 2, 3, 2); -- Baraja vendida por Juan

--Permisos
INSERT INTO Permisos (id_rol, nombre_acceso) VALUES
(1, 'UserButton'),
(1, 'ProductsButton'),
(1, 'CategoriesButton'),
(2, 'ReceiptsButton'),
(2, 'StatsButton'),
(2, 'UserButton'),
(3, 'SellButton'),
(3, 'StatsButton'),
(3, 'ReceiptsButton'),
(4, 'RestoreButton'),
(4, 'BackupButton');
