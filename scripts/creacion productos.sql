USE [ocio_store]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 28/8/2025 20:26:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](100) NOT NULL,
	[fechaIngreso] [date] NOT NULL,
	[precioLista] [decimal](10, 2) NOT NULL,
	[precioVenta] [decimal](10, 2) NOT NULL,
	[baja_producto] [bit] NULL,
	[stock] [int] NOT NULL,
	[stock_min] [int] NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Productos] ADD  DEFAULT (getdate()) FOR [fechaIngreso]
GO

ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [baja_producto]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [CHK_Productos_precio] CHECK  (([precioVenta]>[precioLista]))
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [CHK_Productos_precio]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [CHK_Productos_stock] CHECK  (([stock]>=(0)))
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [CHK_Productos_stock]
GO

ALTER TABLE Productos
ADD 
    cod_producto INT NULL,
    id_proveedor INT NULL;

ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Proveedores
FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor);