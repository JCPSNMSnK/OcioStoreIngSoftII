CREATE DATABASE [db_piazza_giovanni]
GO
USE [db_piazza_giovanni]
GO
CREATE TABLE [dbo].[categorias_pc](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_categoria] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[subcategorias_pc](
	[id_subcategoria] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[descripcion_subcategoria] [varchar](max) NULL,
 CONSTRAINT [PK_subcategorias] PRIMARY KEY CLUSTERED 
(
	[id_subcategoria] ASC,
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[subcategorias_pc]  WITH CHECK ADD  CONSTRAINT [FK_subcategorias_categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias_pc] ([id_categoria])
GO

ALTER TABLE [dbo].[subcategorias_pc] CHECK CONSTRAINT [FK_subcategorias_categorias]
GO

CREATE TABLE [dbo].[consultas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[mensaje] [varchar](max) NOT NULL,
	[leido] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
	[respuesta] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[imagenes](
	[id] [int] NOT NULL,
	[producto_id] [int] NULL,
	[imagen_url] [varchar](255) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[mensajes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[mensaje] [varchar](max) NOT NULL,
	[leido] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
	[respuesta] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[perfiles](
	[id_perfiles] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_id_perfil] PRIMARY KEY CLUSTERED 
(
	[id_perfiles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[permiso](
	[id_permiso] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[nombreAcceso] [varchar](150) NOT NULL,
	[fechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_id_permiso] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[permiso] ADD  CONSTRAINT [DF_producto_fecha_publicacion]  DEFAULT (getdate()) FOR [fechaCreacion]
GO

ALTER TABLE [dbo].[permiso]  WITH CHECK ADD  CONSTRAINT [FK_id_perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfiles] ([id_perfiles])
GO

ALTER TABLE [dbo].[permiso] CHECK CONSTRAINT [FK_id_perfil]
GO


CREATE TABLE [dbo].[productos_pc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[precio] [decimal](10, 2) NULL,
	[stock] [int] NULL,
	[baja] [bit] NULL,
	[fecha_creacion] [datetime] NULL,
	[visitas] [int] NULL,
	[id_categoria] [int] NULL,
	[id_subcategoria] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[productos_pc]  WITH CHECK ADD  CONSTRAINT [FK_productos_categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias_pc] ([id_categoria])
GO

ALTER TABLE [dbo].[productos_pc] CHECK CONSTRAINT [FK_productos_categorias]
GO

ALTER TABLE [dbo].[productos_pc]  WITH CHECK ADD  CONSTRAINT [FK_productos_subcategorias] FOREIGN KEY([id_subcategoria], [id_categoria])
REFERENCES [dbo].[subcategorias_pc] ([id_subcategoria], [id_categoria])
GO

ALTER TABLE [dbo].[productos_pc] CHECK CONSTRAINT [FK_productos_subcategorias]
GO

CREATE TABLE [dbo].[usuarios](
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[zipcode] [int] NOT NULL,
	[domicilio] [varchar](80) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[pass] [varchar](300) NOT NULL,
	[perfil_id] [int] NOT NULL,
	[baja] [bit] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ventas_cabecera](
	[id] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[total_venta] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ventas_detalle](
	[id] [int] NOT NULL,
	[venta_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO

USE [db_piazza_giovanni_II];
GO

-- Tabla: categorias_pc
INSERT INTO [dbo].[categorias_pc] (descripcion_categoria)
VALUES
('Componentes de Hardware'), ('Mantenimiento y limpieza electronica'), ('Perifericos'), ('Redes');

-- Tabla: subcategorias_pc
INSERT INTO [dbo].[subcategorias_pc] (id_categoria, descripcion_subcategoria)
VALUES
	(1, 'Almacenamiento'),
    (1, 'Cables de Energia'),
    (1, 'CPU'),
    (1, 'Estabilizadores y UPS'),
    (1, 'Fuentes de Energia'),
    (1, 'Gabinetes'),
    (1, 'Placas de Video'),
    (1, 'Placas Madre'),
    (1, 'RAM'),
    (1, 'Refrigeracion');

-- Tabla: consultas
INSERT INTO [dbo].[consultas] (usuario, nombre, apellido, correo, mensaje, leido, created_at, updated_at, respuesta)
VALUES
('GioSPD', 'Giovanni', 'Piazza', 'supertruck.2013@gmail.com', 'Consulta sobre producto', 0, GETDATE(), NULL, NULL),
('GioSPD', 'Giovanni', 'Piazza', 'supertruck.2013@gmail.com', 'Solicitud de información', 0, GETDATE(), NULL, NULL),
('GioSPD', 'Giovanni', 'Piazza', 'supertruck.2013@gmail.com', 'Duda sobre precios', 0, GETDATE(), NULL, NULL),
('admin', 'admin', 'admin', 'gpiazza1804@gmail.com', 'Queja sobre un pedido', 0, GETDATE(), NULL, NULL),
('Osvaldo90', 'Osvaldo', 'Quintana', 'osvaldo@gmail.com', 'Información de productos',0,  GETDATE(), NULL, NULL);

GO

-- Tabla: mensajes
INSERT INTO [dbo].[mensajes] (nombre, correo, mensaje, leido, created_at, updated_at, respuesta)
VALUES
('Juan', 'juan@example.com', 'Mensaje importante', 0, GETDATE(), NULL, NULL),
('Ana', 'ana@example.com', 'Consulta rápida', 0, GETDATE(), NULL, NULL),
('Luis', 'luis@example.com', 'Duda general', 1, GETDATE(), NULL, NULL),
('María', 'maria@example.com', 'Consulta técnica', 0, GETDATE(), NULL, NULL),
('Carlos', 'carlos@example.com', 'Sugerencia', 1, GETDATE(), NULL, NULL),
('Lucía', 'lucia@example.com', 'Comentario', 1, GETDATE(), NULL, NULL),
('Jorge', 'jorge@example.com', 'Pregunta de soporte', 0, GETDATE(), NULL, NULL),
('Laura', 'laura@example.com', 'Consulta sobre el servicio', 0, GETDATE(), NULL, NULL),
('Diego', 'diego@example.com', 'Solicitud de información', 1, GETDATE(), NULL, NULL),
('Sofía', 'sofia@example.com', 'Reclamo', 0, GETDATE(), NULL, NULL);

-- Tabla: perfiles
INSERT INTO [dbo].[perfiles] (id_perfiles, descripcion)
VALUES
(0,'cliente'),
(1,'admin'),
(2,'gerente'),
(3,'empleado');

-- Tabla: permiso
INSERT INTO [dbo].[permiso] (id_permiso, id_perfil, nombreAcceso)
VALUES
(1, 1, 'UserButton'),
(2, 1, 'ConsultasButton'),
(3, 1, 'MsgButton'),
(4, 1, 'ProductsButton'),
(5, 1, 'StatsButton'),
(6, 1, 'ReceiptsButton'),
(7, 1, 'BackupButton'),

(8, 3, 'ConsultasButton'),
(9, 3, 'MsgButton'),
(10, 3, 'ProductsButton'),
(11, 3, 'ReceiptsButton'),

(12, 2, 'UserButton'),
(13, 2, 'ConsultasButton'),
(14, 2, 'MsgButton'),
(15, 2, 'ProductsButton'),
(16, 2, 'StatsButton'),
(17, 2, 'ReceiptsButton');

-- Tabla: productos_pc
INSERT INTO [dbo].[productos_pc] (nombre, descripcion, marca, modelo, precio, stock, baja, fecha_creacion, visitas, id_categoria, id_subcategoria)
VALUES
('Procesador Intel Core i7-10700K', 'Procesador de 8 núcleos y 16 hilos con velocidad base de 3.8 GHz, turbo hasta 5.1 GHz.', 'Intel', 'Core i7-10700K', 120000.00, 14, 1, '2024-06-12 13:23:45.000', 8, 1, 3),
('Memoria RAM Corsair Vengeance LPX 16GB', 'DDR4 3200MHz, ideal para gaming y aplicaciones exigentes.', 'Corsair', 'Vengeance LPX', 18000.00, 30, 0, '2024-06-12 14:45:32.000', 4, 1, 9),
('Tarjeta Gráfica NVIDIA GeForce RTX 3070', '8GB GDDR6, rendimiento superior para juegos y trabajos gráficos.', 'NVIDIA', 'GeForce RTX 3070', 220000.00, 9, 0, '2024-06-12 15:30:21.000', 8, 1, 7),
('Disco Duro SSD Samsung 970 EVO Plus 1TB', 'Unidad de estado sólido NVMe M.2 con velocidades de lectura/escritura de hasta 3500/3300 MB/s.', 'Samsung', '970 EVO Plus', 45000.00, 24, 0, '2024-06-12 16:12:54.000', 4, 1, 1),
('Fuente de Alimentación EVGA 600W 80+ White', 'Certificación 80+ White, 600W de potencia, cableado fijo.', 'EVGA', '600 W1', 10000.00, 18, 0, '2024-06-12 18:22:10.000', 9, 1, 5),
('Gabinete Cooler Master MasterBox Q300L', 'Gabinete ATX Mid Tower, diseño modular, con panel lateral transparente.', 'Cooler Master', 'MasterBox Q300L', 15000.00, 8, 0, '2024-06-12 19:18:40.000', 3, 1, 6),
('Enfriador Líquido Corsair Hydro Series H100i', 'Enfriamiento líquido de alto rendimiento para CPUs, radiador de 240mm.', 'Corsair', 'Hydro Series H100i', 20000.00, 5, 0, '2024-06-12 20:25:50.000', 4, 1, 10),
('Estabilizador de Tensión Forza NT-751', 'Capacidad de 750VA, 6 tomas de corriente, protección contra sobretensiones.', 'Forza', 'NT-751', 7000.00, 18, 0, '2024-06-12 21:10:05.000', 1, 1, 4),
('Memoria RAM Fury Renegade 3600 Mhz 8GB DDR4', 'Color de la luz: RGB. Optimiza el rendimiento con DDR4 SDRAM. 3600 MHz, formato DIMM, 28800 MB/s, compatible con AMD Ryzen.', 'Kingston', 'Fury Renegade', 60000.00, 46, 0, '2024-06-04 18:13:10.000', 1, 1, 9),
('Placa de Video Msi GeForce RTX 3080 Gaming Trio RGB', '10 GB, PCI-Express 4.0, 320bit, frecuencia boost 1830MHz, soporte para hasta 4 pantallas.', 'MSI', 'Geforce RTX 3080', 750000.00, 10, 0, '2024-06-04 18:26:07.000', 2, 1, 7),
('Placa Base Asus ROG Strix z490-e RGB', 'Socket Intel LGA 1200, Ethernet de 2,5 Gb, salida HDMI 1.4 y DisplayPort 1.4.', 'ASUS', 'z490-e', 370000.00, 5, 0, '2024-06-04 18:29:07.000', 1, 1, 8),
('Fuente de Alimentación Modular Thermaltake Toughpower GF2 1200W 80Plus Gold', 'Potencia de salida 1200W.', 'Thermaltake', 'Toughpower GF2', 530000.00, 5, 0, '2024-06-05 11:23:37.000', 2, 1, 5),
('CPU AMD Ryzen 9 7950X3D', 'Modelo 7950X3D, memoria caché de 128 MB, potencia de 120 W, compatible con AMD Ryzen.', 'AMD', 'Ryzen 9 7950X3D', 1025000.00, 5, 0, '2024-06-05 11:24:56.000', 1, 1, 3),
('Motherboard Asus Prime A520m-a Ii Csm Amd Ryzen 5ta Gen M.2 Color Negro', 'Socket Amd am4, factor de forma ATX, chipset Amd a520, compatible con DDR4.', 'ASUS', 'A520m-a Ii', 143909.00, 48, 0, '2024-06-05 11:30:06.000', 4, 1, 8),
('Memoria RAM Fury Beast DDR4 RGB gamer color negro 8GB 1 Kingston KF432C16BBA/8', 'RGB, DDR4 SDRAM, 3200 MHz, formato DIMM, 25600 MB/s, compatible con AMD Ryzen.', 'Kingston', 'Fury Beast', 51500.00, 5, 0, '2024-06-07 12:16:27.000', 7, 1, 9),
('Cable Red 15 Metros Rj45 Utp Armado Cat 5e Ethernet Interior Handa', 'Bobina redonda, revestimiento de PVC, conductor de CCA, ancho de banda 1000MHz.', 'Handa', 'CAT 5E', 4859.00, 20, 0, '2024-06-07 13:43:30.000', 3, 4, NULL),
('Access point TP-Link Archer C80 V1 negro 110V/220V', '1900Mbps, doble banda, 4 antenas, 5 puertos, firewall integrado, soporte WEP.', 'TP-Link', 'Archer C80 V1', 65790.00, 10, 0, '2024-06-07 13:45:17.000', 2, 4, NULL),
('Mouse gamer de juego Logitech G Series Hero G502 kda', 'Cable, rueda de desplazamiento, luces, sensor óptico, resolución de 25600dpi.', 'Logitech', 'Hero G502', 71147.00, 49, 0, '2024-06-07 13:49:45.000', 4, 3, NULL);

INSERT INTO [dbo].[usuarios] (nombre, apellido, zipcode, domicilio, email, usuario, pass, perfil_id, baja)
VALUES
('admin', 'admin', 3400, 'Paraguay 884', 'gpiazza1804@gmail.com', 'admin', '$2y$10$9KWYcle4JGh/HCIGapxMDun5ik14EIrKVY62e0obkyA6xCVb.e3DK', 1, 0),
('Charlean', 'Hurche', 3428, '38 Kim Circle', 'churche1@hubpages.com', 'churche1', '$2a$04$i93j2zlwJq30m7FhdQ.eAege0n/U6H6vvXB1qYQ82AkDf.vo8VjmC', 0, 1),
('Vlad', 'Burdge', 3420, '49882 Nevada Parkway', 'vburdge2@pagesperso-orange.fr', 'vburdge2', '$2a$04$yMNHy89u/DY6Bzth3eum0u5U54CWa00P2Ftneh8c6RUGDKaYNugqe', 0, 0),
('Norah', 'Jeays', 3400, '19 Nelson Road', 'njeays3@census.gov', 'njeays3', '$2a$04$cscBtNpo/yIyN2y69MCxiufnFcHIXMHZVyZIM053AL0oVCnYYM7eq', 0, 0),
('Andee', 'Bakhrushin', 3420, '79 Hooker Trail', 'abakhrushin4@nature.com', 'abakhrushin4', '$2a$04$3vCfJPldIiuF2ayEaVUVeO1xdbqIlsmwJ0y3w6uZ3cxco94qoLeTy', 0, 0),
('Meridel', 'Scocroft', 3428, '73466 Norway Maple Junction', 'mscocroft5@sciencedirect.com', 'mscocroft5', '$2a$04$.2Im03OJ7MrvgtXR5mR1TO0p6mT7qX3EA.BFELm9AAR.1CnLECKNi', 0, 0),
('Cyndy', 'Arnholtz', 3420, '75626 4th Lane', 'carnholtz6@odnoklassniki.ru', 'carnholtz6', '$2a$04$S2X9tuYz2sSx.29bijbLg.yNC4h6Fx6MjVBMx9OIgIrVr0yE5vuly', 0, 0),
('Lockwood', 'Carberry', 3400, '46331 Longview Court', 'lcarberry7@earthlink.net', 'lcarberry7', '$2a$04$a7uUs1psN71.ct73SfNenehSee0vlaZUYY1EuazuoPF8yrPjXkSy.', 0, 0),
('Nikolaos', 'Blaymires', 3420, '10851 Lerdahl Circle', 'nblaymires8@woothemes.com', 'nblaymires8', '$2a$04$GNpXca5fFu5UEsgyEhe49eg.T4A8A3.S8VaGL07lABfnN7jPpGv82', 0, 0),
('Eustacia', 'Von Welden', 3400, '5232 Fairview Park', 'evonwelden9@mit.edu', 'evonwelden9', '$2a$04$FisfVG0tNl6KR/5biQwh8u8BCu8MJq8H9Vg.5LiN8A37kTVvNu5A2', 0, 0),
('Feliks', 'Seywood', 3420, '8 High Crossing Junction', 'fseywooda@hud.gov', 'fseywooda', '$2a$04$Sq2VCWr0hOuZME9iNxeADO1rP7t2eOlUXN6Eqk5CRdcFGJ7hz5/u.', 0, 0),
('Armstrong', 'Togher', 3420, '04 Eastlawn Terrace', 'atogherb@cisco.com', 'atogherb', '$2a$04$KzgU3JcvYVn1B0/WlhrTJeVJRrV6I3d3j.iOc7XGUeWBpwRcvra/q', 0, 0),
('Aleta', 'Broom', 3428, '03 Ronald Regan Crossing', 'abroomc@theatlantic.com', 'abroomc', '$2a$04$Hq6sHc9fMo2Ef2PHzrMPPu.Y0vkY2RpAVaggcRw6BwRMv7iSjbDK.', 0, 1),
('Juan', 'Perez', 3428, 'Av. Juan Pujol 2101', 'killerghast.2013@gmail.com', 'Juan04', '$2y$10$U9j5otN4CSTc6451Fd/ZpeU8697VT3WZhjWcY7ruMmQj81UxQDXd.', 0, 0),
('Marcelo', 'Rajoy', 3400, 'Av. Tte Ibañez', 'Marcelo2090@gmail.com', 'Marce90', '$2y$10$RgDo.iRFpNLglRYGFUfrs.UB.6lgZ.aT33T/pBpiV.paU4BKRuz9y', 0, 0),
('Gaston', 'Rodriguez', 3400, 'Junin 401', 'gastonrodriguez401@gmail.com', 'gaston401', '$2y$10$eI6.ydCdO9CEf1revdhlMuMpMmTGp079RpsOfL2bt8pKQ67jg7T3e', 0, 0),
('Sebastian', 'Prado', 3400, 'Junin 401', 'sebianp@gmail.com', 'sebas301', '$2y$10$os/ItpRu0Kp6y.0XUAGzPugZavYxEs2usbl75oZi6wUNTP1NGtZ/K', 0, 1),
('Graciela', 'Benitez', 3428, 'Av. Juan Pujol 2101', 'rosagra114@gmail.com', 'Rosagra114', '$2y$10$g7MwyH2Z86mvQCz9sExEVOuwaNPFXjE6DS7oAIflEWMufAHLLkUFW', 0, 0),
('Mario', 'Piazza', 3428, 'Av. Juan Pujol 2101', 'piazzaoscar55@gmail.com', 'Cachito59', '$2y$10$PatRLx4gYF/DThmHJYeXVOTSeLlwJHBcqb0UshaM5IG9dsx6AVkyG', 0, 1),
('Lannie', 'Miskimmon', 3420, '8 Loeprich Junction', 'lmiskimmonk@ocn.ne.jp', 'lmiskimmonk', '$2a$04$.nS7Ls6AoPgJJRRxiHMI.eqBVXM7z3FZevd7/vjnMPsvbLNQ0EG8y', 0, 0),
('Charita', 'Nayer', 3400, '3308 Texas Junction', 'cnayerl@dion.ne.jp', 'cnayerl', '$2a$04$EKFc9k3yT01HGlFs.khYB.ygfr2rOZd0gXOWjlkIr5LV79gVrMFdq', 0, 0),
('Jannelle', 'Boich', 3428, '46229 Comanche Pass', 'jboichm@ning.com', 'jboichm', '$2a$04$qCgaLsZ.qi8RW29ngtyygumatgUVovtdvpAcuKNUx8EUJa42Ln142', 0, 1),
('Willy', 'Crisp', 3428, '4119 Green Road', 'wcrispn@google.fr', 'wcrispn', '$2a$04$XIFDnnq0/YKmfPfvOBfO7OdOEYjSbYr5g6pEJakZJjTgaRFEGTel6', 0, 0),
('Cornell', 'Etridge', 3428, '29 Duke Avenue', 'cetridgeo@eventbrite.com', 'cetridgeo', '$2a$04$JFnzJMvTAkRqfBNQs6qcZO18HhYdkA/bqhSJATDYuzBvef3NO5QR6', 0, 0),
('Prissie', 'Kivelhan', 3428, '4950 Bluejay Way', 'pkivelhanp@xing.com', 'pkivelhanp', '$2a$04$CWzIYGvBGqq311HJt.uSV.S9Okux6LOi4loal6saV3qAk2qODs4bC', 0, 0),
('Burl', 'Buske', 3400, '2081 Nancy Circle', 'bbuskeq@smugmug.com', 'bbuskeq', '$2a$04$C9T0RUGNEL83HmFlCyQ8xugc1gCSM9KFXZ5eszl42m1ns7vxeX4m2', 0, 0),
('Ellynn', 'Sobieski', 3400, '37 Surrey Lane', 'esobieskir@ted.com', 'esobieskir', '$2a$04$WY/q9PDaqKaWFSGWjNflbeLzYTg0bBaVktZDCeZ76JTaQZHfM5sG6', 0, 0),
('Chucho', 'Dudney', 3428, '42 Lotheville Road', 'cdudneys@salon.com', 'cdudneys', '$2a$04$M31EM1TDpmQZy3wyF.Oa/udYHkoawOF0puH.QT5rP6gKOM0Do3KVG', 0, 0),
('Baily', 'Hagston', 3428, '729 Moland Plaza', 'bhagstont@youtube.com', 'bhagstont', '$2a$04$A36QahUsP5ppj6Tq96FXMe8jFHn8ySKzJj.3QIaXKWtuDsaWqPwPu', 0, 0),
('Dody', 'Marcham', 3420, '818 Mariners Cove Way', 'dmarchamu@noaa.gov', 'dmarchamu', '$2a$04$0SGI5CRkvnZdIXwROCVnMuJEFPTz2GDUv2PbmFvK5RRwpJ0VZnfO.', 0, 1),
('Weidar', 'Perrelle', 3420, '185 Michigan Junction', 'wperrellev@foxnews.com', 'wperrellev', '$2a$04$ibDRgY5aw1.MArW0EtNMk.TsXoQN3CcEWfFnG.QnX39jhKDxcvUEi', 0, 0),
('Hoebart', 'Graeme', 3428, '43178 Maryland Court', 'hgraemew@cnet.com', 'hgraemew', '$2a$04$iM/qmDFQr3zVpHq5jxIVNueFR/7.v6BHhHMKLuCAsFxq8C/CCwb2.', 0, 0),
('Anett', 'Dabbes', 3420, '9644 Northview Lane', 'adabbesx@columbia.edu', 'adabbesx', '$2a$04$0eTxYVzwNNDyc22hajj4/eu3yNtegaxek5Xr8SuMCAKAPAW3jDQ1G', 0, 0),
('Sunshine', 'Wayon', 3428, '28 Lien Road', 'swayony@yale.edu', 'swayony', '$2a$04$pwFelWFYjvYJXLayjrZQgOoKUPcWcAwnmT3dFwJ0wf1yarDt6AwtG', 0, 0),
('Ron', 'Belin', 3428, '9647 Roxbury Trail', 'rbelinz@paginegialle.it', 'rbelinz', '$2a$04$DvafNoEmAIu8HahKbSCeoOLl5x/8qbGYzQd4DqZbfQ6n7FazzWhOO', 0, 0),
('Gerti', 'Rossbrook', 3428, '380 Dwight Place', 'grossbrook10@nih.gov', 'grossbrook10', '$2a$04$UP56g40zgKnGpjRxaZKtR.JTqJXL4fy2.b8qjhDpvMAkT7PTxaNYG', 0, 0),
('Louisa', 'Slee', 3420, '4842 Acker Drive', 'lslee11@twitter.com', 'lslee11', '$2a$04$cvhIfHrug9BeZY9IqeSPjOl6fmeBIOv3753tOcCb6hKAsyBEgvQOK', 0, 0),
('Stearn', 'Lambot', 3420, '3 Mcguire Way', 'slambot12@sitemeter.com', 'slambot12', '$2a$04$jjW9QelVUWLfN5Yw7Z9SDO6XQfBvXsDdKYUWIzb7RrUdDoNaBWCNO', 0, 1),
('Alisa', 'Riccioppo', 3420, '9389 6th Drive', 'ariccioppo13@foxnews.com', 'ariccioppo13', '$2a$04$LAapXj.lWQDq4hVT1LdpEebAYH9MbkwhUzhYhMAaf4VaW2zDuphZ.', 0, 1),
('Addy', 'Holme', 3428, '48 Graedel Point', 'aholme14@bing.com', 'aholme14', '$2a$04$SNC1wyb1vilqvY42094wX.7xBg.GGvSdftHe6sivLQgE9UV8gE7FC', 0, 0),
('Austin', 'Dunckley', 3420, '3 Gulseth Way', 'adunckley15@unc.edu', 'adunckley15', '$2a$04$RRoR2qHYjwFQU5FCmkQgMOcefGJ1n9/rK1gUnSelgYbYjzE8PV1rW', 0, 1),
('Anton', 'Barnaclough', 3428, '7 Service Plaza', 'abarnaclough16@zdnet.com', 'abarnaclough16', '$2a$04$uufGbyn4hQp1IoamlCuL2umW4RjXQo6cTkLli3HfXEv05pbzlkJNO', 0, 0),
('Ezra', 'Deetlefs', 3400, '8 Shoshone Point', 'edeetlefs17@nbcnews.com', 'edeetlefs17', '$2a$04$5s0OvinqjJKkWrseLGrtKO6WdX9PF8TN9166mF8lqnFeonZ/JXfKq', 0, 1),
('Kore', 'Hancox', 3428, '63 Blue Bill Park Terrace', 'khancox18@blog.com', 'khancox18', '$2a$04$yxG4/JRKGEgG5olVann4Oeh63DSeYO5.xVhqQfV9TIkLE0/WBsc.2', 0, 0),
('Aggy', 'Donald', 3400, '811 Springview Road', 'adonald19@imgur.com', 'adonald19', '$2a$04$C1hMJUmtkFMlAcGih9P5j.6/jhWQloOO0VYcbCO15dUS5CraQmfcG', 0, 0),
('Jesus', 'Tuny', 3428, '94 Bunker Hill Road', 'jtuny1a@craigslist.org', 'jtuny1a', '$2a$04$a5blxNUw6Ard0IPri/Q/J.sLP1zZleb5mf8nhKx2Q8ooYy9OYBray', 0, 0),
('Emmery', 'Gisburne', 3420, '9 Dwight Lane', 'egisburne1b@jugem.jp', 'egisburne1b', '$2a$04$rogYCLdXVRqflwYkYdBoku3zph31tVJhCY2d1OHW3vX5.46Rz7MbK', 0, 0),
('Alexina', 'Sommerville', 3400, '66 Bobwhite Terrace', 'asommerville1c@princeton.edu', 'asommerville1c', '$2a$04$ZnUPm7hDMF/yrNAmOqxeL.Wx2HcJR/C1yYNRnpLBDBUBzp4eyNqwu', 0, 0),
('Karalynn', 'Tinton', 3400, '229 Anthes Crossing', 'ktinton1d@tripod.com', 'ktinton1d', '$2a$04$aEQ60FE/sQZ1H9BFaXX2Vus9iFkGuWTSvXQsFrSKQT/CRRKDirypW', 0, 0),
('Osvaldo', 'Quintana', 3400, '9 de julio 1443', 'osvaldo@gmail.com', 'Osvaldo90', '$2y$10$49NAE76IRZPFco1oHK9UU..7yUcJdsWxapJr14mrO0QyUjQwGCxt6', 0, 0),
('Julio', 'Pintos', 3400, 'Av. Libertad', 'JP@gmail.com', 'JP2002', '$2y$10$L.b4pjDIXs58t7XEuIV6p.TZLHclM4pIF3WpDFHAZ4LD2/Ju0Gw9q', 2, 0);


INSERT dbo.ventas_cabecera(id, fecha, usuario_id, total_venta) 
VALUES 
	(1, '2024-06-17', 16, 320000.00),
	(2, '2024-06-17', 15, 736965.00),
	(3, '2024-06-17', 16, 185000.00),
	(4, '2024-06-19', 53, 71500.00),
	(5, '2024-06-19', 53, 2000002.00);
GO

INSERT dbo.ventas_detalle(id, venta_id, producto_id, cantidad, precio) 
VALUES 
	(1, 1, 10, 1, 100000.00),
	(2, 1, 3, 1, 220000.00),
	(3, 2, 1, 1, 120000.00),
	(4, 2, 28, 1, 18000.00),
	(5, 2, 16, 2, 143909.00),
	(6, 2, 20, 1, 71147.00),
	(7, 2, 11, 4, 60000.00),
	(8, 3, 25, 2, 70000.00),
	(9, 3, 4, 1, 45000.00),
	(10, 4, 17, 1, 51500.00),
	(11, 4, 6, 2, 10000.00),
	(12, 5, 63, 2, 1000001.00);
GO

----- PROCEDIMIENTOS

--usuarios

-- Procedimiento para registrar un usuario
CREATE PROC PROC_REGISTRAR_USUARIO(
    @nombre varchar(30),
    @apellido varchar(30),
    @zipcode int,
    @domicilio varchar(80),
    @email varchar(50),
    @usuario varchar(30),
    @pass varchar(300),
    @id_perfil int,
    @baja varchar(2),
    @id_user_resultado int output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @id_user_resultado = 0;
    SET @mensaje = '';
    
    IF NOT EXISTS (SELECT * FROM usuarios WHERE email = @email)
    BEGIN
        INSERT INTO usuarios(nombre, apellido, zipcode, domicilio, email, usuario, pass, perfil_id, baja) 
        VALUES (@nombre, @apellido, @zipcode, @domicilio, @email, @usuario, @pass, @id_perfil, @baja);
        SET @id_user_resultado = SCOPE_IDENTITY();
    END
    ELSE 
        SET @mensaje = 'Este Email ya está registrado';
END;
GO
-- Procedimiento para editar un usuario
CREATE PROC PROC_EDITAR_USUARIO(
    @id_user int,
    @nombre varchar(30),
    @apellido varchar(30),
    @zipcode int,
    @domicilio varchar(80),
    @email varchar(50),
    @usuario varchar(30),
    @pass varchar(300),
    @id_perfil int,
    @baja varchar(2),
    @respuesta bit output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @respuesta = 0;
    SET @mensaje = '';
    
    IF NOT EXISTS (SELECT * FROM usuarios WHERE email = @email AND id != @id_user)
    BEGIN
        UPDATE usuarios SET 
            nombre = @nombre,
            apellido = @apellido,
            zipcode = @zipcode,
            domicilio = @domicilio,
            email = @email,
            usuario = @usuario,
            pass = @pass,
            perfil_id = @id_perfil,
            baja = @baja
        WHERE id = @id_user;
        SET @respuesta = 1;
    END
    ELSE 
        SET @mensaje = 'Este Email ya está registrado';
END;
GO
-- Procedimiento para eliminar un usuario
CREATE PROC PROC_ELIMINAR_USUARIO(
    @id_user int,
    @respuesta bit output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @respuesta = 0;
    SET @mensaje = '';
    DECLARE @validarError bit = 1;
    
    IF EXISTS (SELECT * FROM ventas_cabecera vc
               INNER JOIN usuarios u ON u.id = vc.usuario_id
               WHERE u.id = @id_user)
    BEGIN
        SET @validarError = 0;
        SET @respuesta = 0;
        SET @mensaje = @mensaje + 'Este usuario no se puede eliminar porque se encuentra relacionado a una venta\n';
    END

    IF (@validarError = 1)
    BEGIN 
        DELETE FROM usuarios WHERE id = @id_user;
        SET @respuesta = 1;
    END
END;
GO
-- Procedimiento para registrar un producto
CREATE PROC PROC_REGISTRAR_PRODUCTO(
    @nombre varchar(100),
    @descripcion varchar(max),
    @marca varchar(50),
    @modelo varchar(50),
    @precio decimal(10,2),
    @stock int,
    @baja bit,
    @id_categoria int,
    @id_subcategoria int,
    @resultado int output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @resultado = 0;
    
    IF NOT EXISTS (SELECT * FROM productos_pc WHERE modelo = @modelo)
    BEGIN
        INSERT INTO productos_pc(nombre, descripcion, marca, modelo, precio, stock, baja, id_categoria, id_subcategoria) 
        VALUES (@nombre, @descripcion, @marca, @modelo, @precio, @stock, @baja, @id_categoria, @id_subcategoria);
        SET @resultado = SCOPE_IDENTITY();
    END
    ELSE 
        SET @mensaje = 'Ya existe este modelo.';
END;
GO
-- Procedimiento para editar un producto
CREATE PROC PROC_EDITAR_PRODUCTO(
    @id_prod int,
    @nombre varchar(100),
    @descripcion varchar(max),
    @marca varchar(50),
    @modelo varchar(50),
    @precio decimal(10,2),
    @stock int,
    @baja bit,
    @id_categoria int,
    @id_subcategoria int,
    @resultado int output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @resultado = 1;
    
    IF NOT EXISTS (SELECT * FROM productos_pc pc WHERE pc.modelo = @modelo AND pc.id != @id_prod)
    BEGIN
        UPDATE productos_pc SET 
            nombre = @nombre,
            descripcion = @descripcion,
            marca = @marca,
            modelo = @modelo,
            precio = @precio,
            stock = @stock,
            baja = @baja,
            id_categoria = @id_categoria,
            id_subcategoria = @id_subcategoria
        WHERE id = @id_prod;
    END
    ELSE
    BEGIN
        SET @resultado = 0;
        SET @mensaje = 'Ya existe este modelo.';
    END
END;
GO
-- Procedimiento para eliminar un producto
CREATE PROC PROC_ELIMINAR_PRODUCTO(
    @id_prod int,
    @respuesta bit output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @respuesta = 0;
    SET @mensaje = '';
    DECLARE @validarError bit = 1;
    
    IF EXISTS (SELECT * FROM ventas_detalle vd
               INNER JOIN productos_pc p ON p.id = vd.producto_id
               WHERE p.id = @id_prod)
    BEGIN
        SET @validarError = 0;
        SET @respuesta = 0;
        SET @mensaje = @mensaje + 'Este producto no se puede eliminar porque se encuentra relacionado a una venta\n';
    END

    IF (@validarError = 1)
    BEGIN 
        DELETE FROM productos_pc WHERE id = @id_prod;
        SET @respuesta = 1;
    END
END;
GO
-- Procedimiento para registrar respuesta en mensajes
CREATE PROC PROC_REGISTRAR_RESPUESTA(
    @id_mensaje int,
    @respuesta varchar(250),
    @resultado int output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @resultado = 1;
    SET @mensaje = 'Respuesta registrada exitosamente.';

    IF EXISTS (SELECT 1 FROM mensajes WHERE id = @id_mensaje AND respuesta IS NULL)
    BEGIN
        UPDATE mensajes SET 
            respuesta = @respuesta,
            updated_at = GETDATE()
        WHERE id = @id_mensaje;
    END
    ELSE
    BEGIN
        SET @resultado = 0;
        SET @mensaje = 'El mensaje ya ha sido respondido.';
    END
END;
GO
-- Procedimiento para registrar respuesta en consultas
CREATE PROC PROC_REGISTRAR_RESPUESTA_CONSULTA(
    @id_consulta int,
    @respuesta varchar(250),
    @resultado int output,
    @mensaje varchar(500) output
)
AS
BEGIN 
    SET @resultado = 1;
    SET @mensaje = 'Respuesta registrada exitosamente.';

    IF EXISTS (SELECT 1 FROM consultas c WHERE c.id = @id_consulta AND c.respuesta IS NULL)
    BEGIN
        UPDATE consultas SET 
            respuesta = @respuesta,
            updated_at = GETDATE()
        WHERE id = @id_consulta;
    END
    ELSE
    BEGIN
        SET @resultado = 0;
        SET @mensaje = 'El mensaje ya ha sido respondido.';
    END
END;
