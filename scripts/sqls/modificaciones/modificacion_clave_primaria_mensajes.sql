USE [db_piazza_giovanni]
GO

/****** Object:  Table [dbo].[mensajes]    Script Date: 12/11/2024 18:19:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- 1. Crear la nueva tabla temporal con la columna `id` como IDENTITY
CREATE TABLE [dbo].[mensajes_temp] (
    [id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[mensaje] [varchar](max) NOT NULL,
    [leido] [bit] NULL,
    [created_at] [datetime] NULL,
    [updated_at] [datetime] NULL,
    [respuesta] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];

-- 2. Copiar los datos de la tabla original a la tabla temporal (excluyendo `id`)
INSERT INTO [dbo].[mensajes_temp] ([nombre], [correo], [mensaje], [leido], [created_at], [updated_at], [respuesta])
SELECT [nombre], [correo], [mensaje], [leido], [created_at], [updated_at], [respuesta]
FROM [dbo].[mensajes];

-- 3. Eliminar la tabla original
DROP TABLE [dbo].[mensajes];

-- 4. Renombrar la tabla temporal a `mensajes`
EXEC sp_rename 'dbo.mensajes_temp', 'mensajes';


