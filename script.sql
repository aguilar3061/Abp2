USE [master]
GO
/****** Object:  Database [chrysallis_grupo3]    Script Date: 06/04/2020 14:33:55 ******/
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
/****** Object:  Table [dbo].[Assistir]    Script Date: 06/04/2020 14:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Assistir](
	[id_Soci] [int] NOT NULL,
	[id_Esdeveiment] [int] NOT NULL,
	[quants] [int] NOT NULL,
	[valoracio] [int] NULL,
	[comentari] [varchar](200) NULL,
 CONSTRAINT [PK_Assistir_1] PRIMARY KEY CLUSTERED 
(
	[id_Soci] ASC,
	[id_Esdeveiment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comunitat]    Script Date: 06/04/2020 14:33:55 ******/
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
/****** Object:  Table [dbo].[Comunitat_Soci]    Script Date: 06/04/2020 14:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comunitat_Soci](
	[id_Soci] [int] NOT NULL,
	[id_Comunitat] [int] NOT NULL,
 CONSTRAINT [PK_Comunitat_Soci] PRIMARY KEY CLUSTERED 
(
	[id_Soci] ASC,
	[id_Comunitat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Documents]    Script Date: 06/04/2020 14:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documents](
	[id] [int] NOT NULL,
	[link_document] [varchar](150) NOT NULL,
	[id_esdeveniment] [int] NOT NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Esdeveniment]    Script Date: 06/04/2020 14:33:56 ******/
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
	[NombreEvento] [varchar](100) NULL,
	[Direccio] [varchar](150) NULL,
	[id_Comunitat] [int] NOT NULL,
	[fechaFin] [date] NOT NULL,
	[horaFin] [time](7) NULL,
 CONSTRAINT [PK_Esdeveniment_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Notificacions]    Script Date: 06/04/2020 14:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notificacions](
	[id] [int] NOT NULL,
	[antelacio] [datetime] NULL,
 CONSTRAINT [PK_Notificacions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Notificacions_Esdeveiment]    Script Date: 06/04/2020 14:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notificacions_Esdeveiment](
	[id_esdeveiment] [int] NOT NULL,
	[id_notificacio] [int] NOT NULL,
 CONSTRAINT [PK_Notificacions_Esdeveiment] PRIMARY KEY CLUSTERED 
(
	[id_esdeveiment] ASC,
	[id_notificacio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Socis]    Script Date: 06/04/2020 14:33:56 ******/
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
SET IDENTITY_INSERT [dbo].[Esdeveniment] ON 

INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (0, CAST(N'2020-03-20' AS Date), CAST(N'22:00:00' AS Time), N'Carrer Prova', N'mmm funcionara', 3, CAST(N'2020-03-21' AS Date), CAST(N'23:00:00' AS Time))
INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (1, CAST(N'2020-03-21' AS Date), CAST(N'13:55:59.7125111' AS Time), N'evento2', N'Evento 1', 1, CAST(N'2020-03-21' AS Date), CAST(N'13:55:59.7095188' AS Time))
INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (3, CAST(N'2020-04-09' AS Date), CAST(N'13:00:00' AS Time), N'calle de la gominola', N'evento 3', 7, CAST(N'2020-05-16' AS Date), CAST(N'18:00:00' AS Time))
INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (4, CAST(N'2020-05-16' AS Date), CAST(N'20:10:08.8036902' AS Time), N'carrer Edgar', N'Evento edgar', 14, CAST(N'2020-07-17' AS Date), CAST(N'20:10:08.8016955' AS Time))
INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (5, CAST(N'2020-04-16' AS Date), CAST(N'05:05:05' AS Time), N'mi polla', N'Evento del Carlos', 4, CAST(N'2020-04-23' AS Date), CAST(N'20:43:31.1951400' AS Time))
INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (6, CAST(N'2020-03-10' AS Date), CAST(N'22:43:11' AS Time), N'DFGDGDG', N'EVENTO PREU', 18, CAST(N'2020-03-27' AS Date), CAST(N'22:43:11' AS Time))
INSERT [dbo].[Esdeveniment] ([id], [fechaInicio], [horaInicio], [NombreEvento], [Direccio], [id_Comunitat], [fechaFin], [horaFin]) VALUES (7, CAST(N'2020-03-24' AS Date), CAST(N'11:34:49.1381001' AS Time), N'pepepepepepepep', N'Evento 1', 18, CAST(N'2020-03-24' AS Date), CAST(N'11:34:49.1332112' AS Time))
SET IDENTITY_INSERT [dbo].[Esdeveniment] OFF
SET IDENTITY_INSERT [dbo].[Socis] ON 

INSERT [dbo].[Socis] ([id], [telefon], [mail], [nom], [cognoms], [contrasenya], [actiu], [administrador], [id_comunitat_admin], [DNI]) VALUES (1, N'617451282', N'aguilarcepnet@gmail.com', N'carlos', N'aguuilar', NULL, 1, 1, 18, N'47988333y')
INSERT [dbo].[Socis] ([id], [telefon], [mail], [nom], [cognoms], [contrasenya], [actiu], [administrador], [id_comunitat_admin], [DNI]) VALUES (2, N'782346729', N'pepe@gmail.com', N'pepe', N'mauel', NULL, 1, 0, NULL, N'88933445a')
SET IDENTITY_INSERT [dbo].[Socis] OFF
/****** Object:  Index [IX_Socis]    Script Date: 06/04/2020 14:33:56 ******/
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
ALTER TABLE [dbo].[Comunitat_Soci]  WITH CHECK ADD  CONSTRAINT [FK_Comunitat_Soci_Comunitat] FOREIGN KEY([id_Comunitat])
REFERENCES [dbo].[Comunitat] ([id])
GO
ALTER TABLE [dbo].[Comunitat_Soci] CHECK CONSTRAINT [FK_Comunitat_Soci_Comunitat]
GO
ALTER TABLE [dbo].[Comunitat_Soci]  WITH CHECK ADD  CONSTRAINT [FK_Comunitat_Soci_Socis] FOREIGN KEY([id_Soci])
REFERENCES [dbo].[Socis] ([id])
GO
ALTER TABLE [dbo].[Comunitat_Soci] CHECK CONSTRAINT [FK_Comunitat_Soci_Socis]
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_Esdeveniment] FOREIGN KEY([id_esdeveniment])
REFERENCES [dbo].[Esdeveniment] ([id])
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_Esdeveniment]
GO
ALTER TABLE [dbo].[Esdeveniment]  WITH CHECK ADD  CONSTRAINT [FK_Esdeveniment_Comunitat] FOREIGN KEY([id_Comunitat])
REFERENCES [dbo].[Comunitat] ([id])
GO
ALTER TABLE [dbo].[Esdeveniment] CHECK CONSTRAINT [FK_Esdeveniment_Comunitat]
GO
ALTER TABLE [dbo].[Notificacions_Esdeveiment]  WITH CHECK ADD  CONSTRAINT [FK_Notificacions_Esdeveiment_Esdeveniment] FOREIGN KEY([id_esdeveiment])
REFERENCES [dbo].[Esdeveniment] ([id])
GO
ALTER TABLE [dbo].[Notificacions_Esdeveiment] CHECK CONSTRAINT [FK_Notificacions_Esdeveiment_Esdeveniment]
GO
ALTER TABLE [dbo].[Notificacions_Esdeveiment]  WITH CHECK ADD  CONSTRAINT [FK_Notificacions_Esdeveiment_Notificacions] FOREIGN KEY([id_notificacio])
REFERENCES [dbo].[Notificacions] ([id])
GO
ALTER TABLE [dbo].[Notificacions_Esdeveiment] CHECK CONSTRAINT [FK_Notificacions_Esdeveiment_Notificacions]
GO
ALTER TABLE [dbo].[Socis]  WITH CHECK ADD  CONSTRAINT [FK_Socis_Comunitat] FOREIGN KEY([id_comunitat_admin])
REFERENCES [dbo].[Comunitat] ([id])
GO
ALTER TABLE [dbo].[Socis] CHECK CONSTRAINT [FK_Socis_Comunitat]
GO
ALTER TABLE [dbo].[Socis]  WITH CHECK ADD  CONSTRAINT [CK_Socis] CHECK  (([telefon]<='999999999'))
GO
ALTER TABLE [dbo].[Socis] CHECK CONSTRAINT [CK_Socis]
GO
USE [master]
GO
ALTER DATABASE [chrysallis_grupo3] SET  READ_WRITE 
GO
