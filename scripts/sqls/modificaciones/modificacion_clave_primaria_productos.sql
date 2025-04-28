USE [db_piazza_giovanni]
GO

/****** Object:  Table [dbo].[productos_pc_temp]    Script Date: 11/11/2024 17:51:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productos_pc_temp](
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

ALTER TABLE [dbo].[productos_pc_temp]  WITH CHECK ADD  CONSTRAINT [FK_productos_categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias_pc] ([id_categoria])
GO

ALTER TABLE [dbo].[productos_pc_temp] CHECK CONSTRAINT [FK_productos_categorias]
GO

ALTER TABLE [dbo].[productos_pc_temp]  WITH CHECK ADD  CONSTRAINT [FK_productos_subcategorias] FOREIGN KEY([id_subcategoria], [id_categoria])
REFERENCES [dbo].[subcategorias_pc] ([id_subcategoria], [id_categoria])
GO

ALTER TABLE [dbo].[productos_pc_temp] CHECK CONSTRAINT [FK_productos_subcategorias]
GO


INSERT INTO productos_pc_temp (nombre, descripcion, marca, modelo, precio, stock, baja, id_categoria, id_subcategoria)
SELECT nombre, descripcion, marca, modelo, precio, stock, baja, id_categoria, id_subcategoria
FROM productos_pc;

DROP TABLE productos_pc;
EXEC sp_rename 'productos_pc_temp', 'productos_pc';