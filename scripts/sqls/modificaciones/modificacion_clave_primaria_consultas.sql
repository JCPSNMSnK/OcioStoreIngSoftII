USE [db_piazza_giovanni]
GO

/****** Object:  Table [dbo].[consultas]    Script Date: 12/11/2024 23:14:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[consultas_temp](
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

INSERT INTO [dbo].[consultas_temp] ([usuario], [nombre], [apellido], [correo], [mensaje], [leido], [created_at], [updated_at], [respuesta])
SELECT [usuario], [nombre], [apellido], [correo], [mensaje], [leido], [created_at], [updated_at], [respuesta]
FROM [dbo].[consultas];

-- 3. Eliminar la tabla original
DROP TABLE [dbo].[consultas];

-- 4. Renombrar la tabla temporal a `mensajes`
EXEC sp_rename 'dbo.consultas_temp', 'consultas';

