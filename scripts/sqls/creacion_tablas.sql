USE [master]
GO
/****** Object:  Database [db_piazza_giovanni]    Script Date: 26/9/2024 10:51:30 ******/
CREATE DATABASE [db_piazza_giovanni]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_piazza_giovanni', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_piazza_giovanni.mdf' , SIZE = 139264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_piazza_giovanni_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_piazza_giovanni_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_piazza_giovanni] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_piazza_giovanni].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_piazza_giovanni] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_piazza_giovanni] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_piazza_giovanni] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_piazza_giovanni] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_piazza_giovanni] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_piazza_giovanni] SET  MULTI_USER 
GO
ALTER DATABASE [db_piazza_giovanni] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_piazza_giovanni] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_piazza_giovanni] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_piazza_giovanni] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_piazza_giovanni] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_piazza_giovanni] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_piazza_giovanni] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_piazza_giovanni] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_piazza_giovanni]
GO
/****** Object:  Table [dbo].[consultas]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consultas](
	[id] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[mensaje] [varchar](max) NOT NULL,
	[leido] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imagenes]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imagenes](
	[id] [int] NOT NULL,
	[producto_id] [int] NULL,
	[imagen_url] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mensajes]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mensajes](
	[id] [int] NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[mensaje] [varchar](max) NOT NULL,
	[leido] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfiles]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfiles](
	[id_perfiles] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos_pc]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos_pc](
	[id] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[categoria] [varchar](50) NULL,
	[subcategoria] [varchar](50) NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[precio] [decimal](10, 2) NULL,
	[stock] [int] NULL,
	[baja] [varchar](2) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[visitas] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[zipcode] [int] NOT NULL,
	[domicilio] [varchar](80) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[pass] [varchar](300) NOT NULL,
	[perfil_id] [int] NOT NULL,
	[baja] [varchar](2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas_cabecera]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas_cabecera](
	[id] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[total_venta] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas_detalle]    Script Date: 26/9/2024 10:51:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas_detalle](
	[id] [int] NOT NULL,
	[venta_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [db_piazza_giovanni] SET  READ_WRITE 
GO
