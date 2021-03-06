USE [master]
GO
/****** Object:  Database [JAPON]    Script Date: 1/08/2021 18:57:19 ******/
CREATE DATABASE [JAPON]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JAPON', FILENAME = N'D:\Program Files\SQLSERVER2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\JAPON.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JAPON_log', FILENAME = N'D:\Program Files\SQLSERVER2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\JAPON_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JAPON] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JAPON].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JAPON] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JAPON] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JAPON] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JAPON] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JAPON] SET ARITHABORT OFF 
GO
ALTER DATABASE [JAPON] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JAPON] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JAPON] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JAPON] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JAPON] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JAPON] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JAPON] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JAPON] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JAPON] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JAPON] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JAPON] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JAPON] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JAPON] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JAPON] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JAPON] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JAPON] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JAPON] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JAPON] SET RECOVERY FULL 
GO
ALTER DATABASE [JAPON] SET  MULTI_USER 
GO
ALTER DATABASE [JAPON] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JAPON] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JAPON] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JAPON] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JAPON] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JAPON] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'JAPON', N'ON'
GO
ALTER DATABASE [JAPON] SET QUERY_STORE = OFF
GO
USE [JAPON]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 1/08/2021 18:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[dpi_emp] [bigint] NOT NULL,
	[nombre_emp] [varchar](50) NULL,
	[hijos_emp] [int] NULL,
	[salariobase_emp] [float] NULL,
	[bono_emp] [float] NULL,
	[creacion_emp] [date] NULL,
	[iggs_emp] [float] NULL,
	[irtra_emp] [float] NULL,
	[bonopater_emp] [float] NULL,
	[salario_total_emp] [float] NULL,
	[salario_liquido_emp] [float] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[dpi_emp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 1/08/2021 18:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[cod_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [nchar](150) NULL,
	[apellido_usuario] [nchar](150) NULL,
	[correo_usuario] [nchar](150) NULL,
	[contra_usuario] [nchar](150) NULL,
	[contra_aux] [nchar](150) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[cod_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Empleados] ([dpi_emp], [nombre_emp], [hijos_emp], [salariobase_emp], [bono_emp], [creacion_emp], [iggs_emp], [irtra_emp], [bonopater_emp], [salario_total_emp], [salario_liquido_emp]) VALUES (2357, N'pedro morataya', 5, 3500, 250, CAST(N'2021-01-08' AS Date), 169.05, 35, 665, 4415, 4210.95)
INSERT [dbo].[Empleados] ([dpi_emp], [nombre_emp], [hijos_emp], [salariobase_emp], [bono_emp], [creacion_emp], [iggs_emp], [irtra_emp], [bonopater_emp], [salario_total_emp], [salario_liquido_emp]) VALUES (4332, N'Emanuel Suruy', 4, 5699, 250, CAST(N'2021-01-08' AS Date), 275.2617, 56.99, 532, 6481, 6148.7483)
INSERT [dbo].[Empleados] ([dpi_emp], [nombre_emp], [hijos_emp], [salariobase_emp], [bono_emp], [creacion_emp], [iggs_emp], [irtra_emp], [bonopater_emp], [salario_total_emp], [salario_liquido_emp]) VALUES (34353, N'Jorge Gomez', 6, 6000, 250, CAST(N'2021-01-08' AS Date), 289.8, 60, 798, 7048, 6698.2)
INSERT [dbo].[Empleados] ([dpi_emp], [nombre_emp], [hijos_emp], [salariobase_emp], [bono_emp], [creacion_emp], [iggs_emp], [irtra_emp], [bonopater_emp], [salario_total_emp], [salario_liquido_emp]) VALUES (54789, N'santiago gonzales', 1, 5000, 250, CAST(N'2021-01-08' AS Date), 241.5, 50, 133, 5383, 5091.5)
INSERT [dbo].[Empleados] ([dpi_emp], [nombre_emp], [hijos_emp], [salariobase_emp], [bono_emp], [creacion_emp], [iggs_emp], [irtra_emp], [bonopater_emp], [salario_total_emp], [salario_liquido_emp]) VALUES (54878, N'luis sandoval', 5, 7500, 250, CAST(N'2021-01-08' AS Date), 362.25, 75, 665, 8415, 7977.75)
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([cod_usuario], [nombre_usuario], [apellido_usuario], [correo_usuario], [contra_usuario], [contra_aux]) VALUES (1, N'JOSE                                                                                                                                                  ', N'GONZALES                                                                                                                                              ', N'aj1prueba@gmail.com                                                                                                                                   ', N'viernes                                                                                                                                               ', N'1397253245                                                                                                                                            ')
INSERT [dbo].[usuarios] ([cod_usuario], [nombre_usuario], [apellido_usuario], [correo_usuario], [contra_usuario], [contra_aux]) VALUES (2, N'JOSE                                                                                                                                                  ', N'GOMEZ                                                                                                                                                 ', N'aj2prueba@gmail.com                                                                                                                                   ', N'12345678                                                                                                                                              ', N'auxiliar                                                                                                                                              ')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [JAPON] SET  READ_WRITE 
GO
