USE [master]
GO
/****** Object:  Database [chrysallis_grupo3]    Script Date: 13/04/2020 12:01:11 ******/
CREATE DATABASE [chrysallis_grupo3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'chrysallis_grupo3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\chrysallis_grupo3.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'chrysallis_grupo3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\chrysallis_grupo3_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [chrysallis_grupo3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [chrysallis_grupo3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [chrysallis_grupo3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET ARITHABORT OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [chrysallis_grupo3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [chrysallis_grupo3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [chrysallis_grupo3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [chrysallis_grupo3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [chrysallis_grupo3] SET  MULTI_USER 
GO
ALTER DATABASE [chrysallis_grupo3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [chrysallis_grupo3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [chrysallis_grupo3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [chrysallis_grupo3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [chrysallis_grupo3] SET DELAYED_DURABILITY = DISABLED 
GO
USE [chrysallis_grupo3]
GO
/****** Object:  Table [dbo].[Assistir]    Script Date: 13/04/2020 12:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Assistir](
	[id_Soci] [int] NOT NULL,
	[id_Esdeveiment] [int] NOT NULL,
	[valoracio] [int] NULL,
	[comentari] [varchar](200) NULL,
	[aiste] [bit] NULL,
 CONSTRAINT [PK_Assistir_1] PRIMARY KEY CLUSTERED 
(
	[id_Soci] ASC,
	[id_Esdeveiment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comunitat]    Script Date: 13/04/2020 12:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comunitat](
	[id] [int] NOT NULL,
	[nombre] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Comunitat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Esdeveniment]    Script Date: 13/04/2020 12:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Esdeveniment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[horaInicio] [time](7) NOT NULL,
	[NombreEvento] [varchar](100) NOT NULL,
	[Direccio] [varchar](150) NULL,
	[id_Comunitat] [int] NOT NULL,
	[fechaFin] [date] NOT NULL,
	[horaFin] [time](7) NULL,
	[cuants] [int] NULL,
	[imagen] [image] NOT NULL,
	[descripcion] [varchar](300) NULL,
 CONSTRAINT [PK_Esdeveniment_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socis]    Script Date: 13/04/2020 12:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[telefon] [varchar](9) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[nom] [varchar](25) NOT NULL,
	[cognoms] [varchar](50) NOT NULL,
	[contrasenya] [varchar](20) NULL,
	[actiu] [bit] NOT NULL,
	[administrador] [bit] NOT NULL,
	[id_comunitat_admin] [int] NULL,
	[DNI] [varchar](9) NOT NULL,
	[id_comunidad_socio] [int] NULL,
	[contrasena_cambiada] [bit] NOT NULL,
 CONSTRAINT [PK_Socis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (1, N'Andalucía')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (2, N'Aragón')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (3, N'Principado de Asturias')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (4, N'Baleares')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (5, N'Canarias')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (6, N'Cantabria')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (7, N'Castilla-La Mancha')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (8, N'Castilla y León')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (9, N'Cataluña')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (10, N'Extremadura')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (11, N'Galicia')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (12, N'La Rioja')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (13, N'Comunidad de Madrid')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (14, N'Región de Murcia')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (15, N'Navarra')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (16, N'País Vasco')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (17, N'Comunidad Valenciana')
INSERT [dbo].[Comunitat] ([id], [nombre]) VALUES (18, N'Global')
/****** Object:  Index [IX_Socis]    Script Date: 13/04/2020 12:01:12 ******/
CREATE NONCLUSTERED INDEX [IX_Socis] ON [dbo].[Socis]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Assistir]  WITH CHECK ADD  CONSTRAINT [FK_Assistir_Esdeveniment] FOREIGN KEY([id_Esdeveiment])
REFERENCES [dbo].[Esdeveniment] ([id])
GO
ALTER TABLE [dbo].[Assistir] CHECK CONSTRAINT [FK_Assistir_Esdeveniment]
GO
ALTER TABLE [dbo].[Assistir]  WITH CHECK ADD  CONSTRAINT [FK_Assistir_Socis] FOREIGN KEY([id_Soci])
REFERENCES [dbo].[Socis] ([id])
GO
ALTER TABLE [dbo].[Assistir] CHECK CONSTRAINT [FK_Assistir_Socis]
GO
ALTER TABLE [dbo].[Esdeveniment]  WITH CHECK ADD  CONSTRAINT [FK_Esdeveniment_Comunitat] FOREIGN KEY([id_Comunitat])
REFERENCES [dbo].[Comunitat] ([id])
GO
ALTER TABLE [dbo].[Esdeveniment] CHECK CONSTRAINT [FK_Esdeveniment_Comunitat]
GO
ALTER TABLE [dbo].[Socis]  WITH CHECK ADD  CONSTRAINT [FK_Socis_Comunitat] FOREIGN KEY([id_comunitat_admin])
REFERENCES [dbo].[Comunitat] ([id])
GO
ALTER TABLE [dbo].[Socis] CHECK CONSTRAINT [FK_Socis_Comunitat]
GO
ALTER TABLE [dbo].[Socis]  WITH CHECK ADD  CONSTRAINT [FK_Socis_Comunitat1] FOREIGN KEY([id_comunidad_socio])
REFERENCES [dbo].[Comunitat] ([id])
GO
ALTER TABLE [dbo].[Socis] CHECK CONSTRAINT [FK_Socis_Comunitat1]
GO
ALTER TABLE [dbo].[Socis]  WITH CHECK ADD  CONSTRAINT [CK_Socis] CHECK  (([telefon]<='999999999'))
GO
ALTER TABLE [dbo].[Socis] CHECK CONSTRAINT [CK_Socis]
GO
USE [master]
GO
ALTER DATABASE [chrysallis_grupo3] SET  READ_WRITE 
GO
