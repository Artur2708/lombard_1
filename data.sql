USE [master]
GO
/****** Object:  Database [Lombard_new]    Script Date: 22.07.2022 14:17:52 ******/
CREATE DATABASE [Lombard_new]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lombard_new', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Lombard_new.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Lombard_new_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Lombard_new_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Lombard_new] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lombard_new].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lombard_new] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lombard_new] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lombard_new] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lombard_new] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lombard_new] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lombard_new] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lombard_new] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lombard_new] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lombard_new] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lombard_new] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lombard_new] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lombard_new] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lombard_new] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lombard_new] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lombard_new] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Lombard_new] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lombard_new] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lombard_new] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lombard_new] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lombard_new] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lombard_new] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lombard_new] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lombard_new] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Lombard_new] SET  MULTI_USER 
GO
ALTER DATABASE [Lombard_new] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lombard_new] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lombard_new] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lombard_new] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Lombard_new] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Lombard_new] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Lombard_new] SET QUERY_STORE = OFF
GO
USE [Lombard_new]
GO
/****** Object:  Schema [pro]    Script Date: 22.07.2022 14:17:52 ******/
CREATE SCHEMA [pro]
GO
/****** Object:  Table [pro].[Archiv_dogovor]    Script Date: 22.07.2022 14:17:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [pro].[Archiv_dogovor](
	[ID_Archiv_dogovor] [int] IDENTITY(1,1) NOT NULL,
	[Client_Id] [int] NOT NULL,
	[ID_Dogovor] [int] NOT NULL,
	[Predmet] [nvarchar](50) NOT NULL,
	[Ocenochna_stoimost] [money] NOT NULL,
	[Vudano] [money] NOT NULL,
	[Procent] [money] NOT NULL,
	[Opisanie] [nvarchar](max) NOT NULL,
	[Date_Start] [date] NOT NULL,
	[Date_Finish] [date] NOT NULL,
	[Date_Start_prod] [date] NOT NULL,
	[Date_Finish_prod] [date] NOT NULL,
	[Ves_All] [float] NOT NULL,
	[Ves_zachet] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Archiv_dogovor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [pro].[Archiv_prod]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [pro].[Archiv_prod](
	[ID_Archiv_prod] [int] IDENTITY(1,1) NOT NULL,
	[Dogovor_Id] [int] NOT NULL,
	[ID_Prodlenie] [int] NOT NULL,
	[Date_start_prod] [date] NOT NULL,
	[Date_finish_prod] [date] NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Archiv_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [pro].[Client]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [pro].[Client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[Name_] [nvarchar](30) NOT NULL,
	[Father_name] [nvarchar](30) NOT NULL,
	[Surname] [nvarchar](30) NOT NULL,
	[Tel] [nvarchar](12) NOT NULL,
	[BD] [date] NOT NULL,
	[Seria_pasport] [nvarchar](20) NOT NULL,
	[Number_pasport] [nvarchar](20) NOT NULL,
	[Vudan] [nvarchar](300) NOT NULL,
	[INN] [nvarchar](20) NOT NULL,
	[Propiska] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [pro].[Dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [pro].[Dogovor](
	[ID_Dogovor] [int] IDENTITY(1,1) NOT NULL,
	[Client_Id] [int] NOT NULL,
	[Predmet] [nvarchar](50) NOT NULL,
	[Ocenochna_stoimost] [money] NOT NULL,
	[Vudano] [money] NOT NULL,
	[Procent] [money] NOT NULL,
	[Opisanie] [nvarchar](max) NOT NULL,
	[Date_Start] [date] NOT NULL,
	[Date_Finish] [date] NOT NULL,
	[Date_Start_prod] [date] NOT NULL,
	[Date_Finish_prod] [date] NOT NULL,
	[Ves_All] [float] NOT NULL,
	[Ves_zachet] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Dogovor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [pro].[Prodlenie]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [pro].[Prodlenie](
	[ID_Prodlenie] [int] IDENTITY(1,1) NOT NULL,
	[Dogovor_Id] [int] NOT NULL,
	[Date_start_prod] [date] NOT NULL,
	[Date_finish_prod] [date] NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Prodlenie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [pro].[Archiv_dogovor] ON 

INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (1, 8, 9, N'м.т. Redmi 8 32гб', 1800.0000, 1308.0000, 0.9900, N'(Реализация - 2400)', CAST(N'2022-05-04' AS Date), CAST(N'2022-05-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0, 0)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (2, 2, 3, N'Хрест', 256.0000, 250.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-04' AS Date), CAST(N'2022-05-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.32, 0.32)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (3, 21, 18, N'каблучка', 1035.0000, 1035.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-10' AS Date), CAST(N'2022-05-11' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.42, 1.38)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (4, 17, 15, N'підвіс', 408.0000, 400.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-07' AS Date), CAST(N'2022-05-14' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.51, 0.51)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (5, 3, 4, N'Ланцюг', 9678.0000, 9650.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-03' AS Date), CAST(N'2022-05-15' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 12.29, 12.25)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (6, 10, 12, N'ланцюг', 6720.0000, 4429.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-06' AS Date), CAST(N'2022-05-16' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 8.45, 8.4)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (7, 5, 6, N'Ланцюг', 130.0000, 130.0000, 1.5000, N'Серебро - 925', CAST(N'2022-05-03' AS Date), CAST(N'2022-05-19' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 9.19, 8.7)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (8, 37, 37, N'сережки', 5505.0000, 5505.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-19' AS Date), CAST(N'2022-05-19' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 8.15, 7.34)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (9, 37, 38, N'брухт', 1397.0000, 1397.0000, 0.3900, N'Золото - 850', CAST(N'2022-05-19' AS Date), CAST(N'2022-05-19' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.33, 1.33)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (10, 39, 40, N'брухт', 2541.0000, 2541.0000, 0.3900, N'Золото - 850', CAST(N'2022-05-19' AS Date), CAST(N'2022-05-19' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.42, 2.42)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (11, 23, 20, N'Обручка', 2393.0000, 500.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-12' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.19, 3.19)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (12, 40, 41, N'брухт', 18503.0000, 18500.0000, 0.3500, N'Золото - 585', CAST(N'2022-05-20' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 24.67, 24.67)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (13, 41, 42, N'каблучка', 2003.0000, 2000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-20' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.69, 2.67)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (14, 9, 10, N'Велосипед Bahrico MTB-26 24', 500.0000, 500.0000, 1.5000, N'реализация 1400', CAST(N'2022-05-05' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0, 0)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (15, 7, 8, N'м.т. Huawei TIT_U02', 1000.0000, 1000.0000, 0.9900, N'Пароль - 2901 (реализация - 1900)', CAST(N'2022-05-04' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0, 0)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (16, 42, 45, N'обручка', 6000.0000, 6000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-20' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 8.07, 8)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (17, 32, 29, N'каблучка деформ.', 825.0000, 825.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.13, 1.1)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (18, 43, 46, N'Брухт', 11640.0000, 11640.0000, 0.3500, N'Золото - 585', CAST(N'2022-05-21' AS Date), CAST(N'2022-05-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 16.39, 15.52)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (19, 43, 47, N'Проверка', 100.0000, 100.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-21' AS Date), CAST(N'2022-05-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 10, 10)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (20, 38, 39, N'сережка', 503.0000, 300.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-19' AS Date), CAST(N'2022-05-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.73, 0.67)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (21, 38, 49, N'Сережки', 1005.0000, 1000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-22' AS Date), CAST(N'2022-05-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.44, 1.34)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (22, 6, 7, N'Сережки', 1152.0000, 1150.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-03' AS Date), CAST(N'2022-05-23' AS Date), CAST(N'2022-05-16' AS Date), CAST(N'2022-05-23' AS Date), 1.44, 1.44)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (23, 50, 56, N'брухт', 375.0000, 370.0000, 0.0100, N'Золото - 585', CAST(N'2022-05-24' AS Date), CAST(N'2022-05-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.5, 0.5)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (24, 13, 43, N'обручка', 1053.0000, 1050.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-20' AS Date), CAST(N'2022-05-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.17, 1.17)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (25, 47, 57, N'Каблучка', 2817.0000, 2800.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-24' AS Date), CAST(N'2022-05-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.16, 3.13)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (26, 24, 21, N'Каблучка', 2700.0000, 2700.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-12' AS Date), CAST(N'2022-05-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.87, 3.6)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (27, 20, 58, N'Каблучка', 3303.0000, 3300.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-24' AS Date), CAST(N'2022-05-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.9, 3.67)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (28, 11, 13, N'м.т. Samsung A72', 9500.0000, 9500.0000, 0.7900, N'витрина 12500', CAST(N'2022-05-06' AS Date), CAST(N'2022-05-25' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0, 0)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (29, 4, 5, N'Обручка', 2001.0000, 2000.0000, 0.3900, N'Золото - 585', CAST(N'2022-04-30' AS Date), CAST(N'2022-05-25' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.44, 2.44)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (30, 52, 64, N'ланцюг', 200.0000, 200.0000, 0.0100, N'Серебро - 925', CAST(N'2022-05-26' AS Date), CAST(N'2022-05-26' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 14.66, 14.3)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (31, 52, 65, N'обручка', 4369.0000, 4369.0000, 0.0100, N'Золото - 585', CAST(N'2022-05-26' AS Date), CAST(N'2022-05-26' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.14, 5.14)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (32, 19, 44, N'Підвіс', 4624.0000, 4624.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-10' AS Date), CAST(N'2022-05-27' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.79, 5.44)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (33, 19, 17, N'ланцюги', 19703.0000, 19700.0000, 0.3500, N'Золото - 585', CAST(N'2022-05-10' AS Date), CAST(N'2022-05-27' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 26.83, 26.27)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (34, 19, 59, N'ланцюги', 15825.0000, 15800.0000, 0.3500, N'Золото - 585', CAST(N'2022-05-26' AS Date), CAST(N'2022-05-27' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 21.4, 21.1)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (35, 18, 16, N'підвіс', 3042.0000, 3000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-10' AS Date), CAST(N'2022-05-30' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.22, 3.9)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (36, 30, 50, N'Обручка', 5580.0000, 5580.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-23' AS Date), CAST(N'2022-05-31' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.2, 6.2)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (37, 56, 69, N'ланцюг', 50.0000, 50.0000, 1.5000, N'Серебро - 925', CAST(N'2022-05-29' AS Date), CAST(N'2022-05-31' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.61, 2.61)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (38, 55, 68, N'Ланцюг', 2457.0000, 2450.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-28' AS Date), CAST(N'2022-05-31' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.76, 2.73)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (39, 61, 74, N'Брухт', 375.0000, 375.0000, 0.0100, N'Золото - 585', CAST(N'2022-06-01' AS Date), CAST(N'2022-06-01' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.5, 0.5)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (40, 57, 70, N'каблучки', 3555.0000, 3550.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-29' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.95, 3.95)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (41, 59, 72, N'сережки', 1845.0000, 1845.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-30' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.46, 2.46)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (42, 58, 71, N'підвіс', 2610.0000, 2610.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-30' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.48, 3.48)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (43, 19, 76, N'сережки', 4608.0000, 4600.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-02' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.3, 5.12)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (44, 27, 77, N'обручка', 2100.0000, 2100.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-02' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.3, 2.3)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (45, 63, 78, N'обручка', 3352.0000, 3350.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-02' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.47, 4.47)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (46, 62, 75, N'обручка', 2502.0000, 2500.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-02' AS Date), CAST(N'2022-06-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.22, 3.22)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (47, 43, 80, N'Сережки', 7200.0000, 7200.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-04' AS Date), CAST(N'2022-06-04' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 8.04, 8)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (48, 23, 81, N'Каблучка', 4725.0000, 4725.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-04' AS Date), CAST(N'2022-06-04' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.34, 5.25)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (49, 36, 36, N'ланцюги', 10002.0000, 10001.0000, 0.3500, N'Золото - 585', CAST(N'2022-05-19' AS Date), CAST(N'2022-06-04' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 13.35, 13.16)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (50, 60, 73, N'Сережки', 2565.0000, 1500.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-31' AS Date), CAST(N'2022-06-04' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.42, 3.42)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (51, 65, 85, N'Ладанка', 915.0000, 915.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-05' AS Date), CAST(N'2022-06-05' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.22, 1.22)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (52, 53, 66, N'Ладанка', 2512.0000, 2000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-27' AS Date), CAST(N'2022-06-05' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.44, 3.35)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (53, 34, 30, N'підвіс', 1500.0000, 1500.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-18' AS Date), CAST(N'2022-06-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.03, 2)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (54, 14, 86, N'підвіс', 1306.0000, 1300.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-06' AS Date), CAST(N'2022-06-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.42, 1.42)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (55, 54, 67, N'Сережки', 1875.0000, 1870.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-27' AS Date), CAST(N'2022-06-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.59, 2.5)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (56, 26, 82, N'Сережка', 517.0000, 400.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-04' AS Date), CAST(N'2022-06-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.69, 0.69)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (57, 63, 87, N'підвіс', 1409.0000, 1400.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-06' AS Date), CAST(N'2022-06-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.83, 1.83)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (58, 46, 48, N'Каблучка', 1702.0000, 1700.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-22' AS Date), CAST(N'2022-06-07' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.85, 2.27)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (59, 24, 62, N'каблучка', 1403.0000, 1400.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-26' AS Date), CAST(N'2022-06-07' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.88, 1.87)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (60, 1, 2, N'Брухт', 1088.0000, 1080.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-04' AS Date), CAST(N'2022-06-08' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.55, 1.45)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (61, 1, 1, N'Брухт', 243.0000, 240.0000, 1.5000, N'Серебро - 925', CAST(N'2022-05-04' AS Date), CAST(N'2022-06-08' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 16.67, 16.2)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (62, 35, 35, N'каблучка з вст', 1360.0000, 1300.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-19' AS Date), CAST(N'2022-06-10' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.95, 1.7)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (63, 8, 11, N'м.т. Redmi 8 32гб.', 1797.0000, 1797.0000, 0.9900, N'2400 витрина', CAST(N'2022-05-06' AS Date), CAST(N'2022-06-10' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0, 0)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (64, 51, 63, N'сережки', 1208.0000, 1200.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-26' AS Date), CAST(N'2022-06-11' AS Date), CAST(N'2022-06-09' AS Date), CAST(N'2022-06-23' AS Date), 1.61, 1.61)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (65, 17, 83, N'Хрест', 400.0000, 400.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-04' AS Date), CAST(N'2022-06-11' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.52, 0.52)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (66, 60, 84, N'Сережки', 2565.0000, 2229.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-04' AS Date), CAST(N'2022-06-13' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.42, 3.42)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (67, 13, 98, N'сережка', 257.0000, 250.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-15' AS Date), CAST(N'2022-06-15' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.27, 0.27)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (68, 63, 99, N'ланцюг', 4972.0000, 4970.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-16' AS Date), CAST(N'2022-06-16' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.89, 5.85)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (69, 29, 27, N'Обручка(деформ)', 1650.0000, 1500.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-16' AS Date), CAST(N'2022-06-16' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.2, 2.2)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (70, 16, 14, N'підвіс', 562.0000, 550.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-07' AS Date), CAST(N'2022-06-18' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.73, 0.73)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (71, 25, 23, N'обручка', 2040.0000, 2000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-13' AS Date), CAST(N'2022-06-18' AS Date), CAST(N'2022-06-03' AS Date), CAST(N'2022-06-10' AS Date), 2.72, 2.72)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (72, 11, 101, N'Підвіс', 712.0000, 712.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-18' AS Date), CAST(N'2022-06-18' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.75, 0.75)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (73, 14, 102, N'Обручка', 2603.0000, 2600.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-18' AS Date), CAST(N'2022-06-18' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.74, 2.74)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (74, 71, 97, N'підвіс', 9409.0000, 8500.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-15' AS Date), CAST(N'2022-06-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 11.07, 11.07)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (75, 20, 22, N'Підвіс', 2317.0000, 2300.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-12' AS Date), CAST(N'2022-06-21' AS Date), CAST(N'2022-06-10' AS Date), CAST(N'2022-06-24' AS Date), 3.09, 3.09)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (76, 20, 93, N'ланцюг', 10013.0000, 1000.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-11' AS Date), CAST(N'2022-06-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 13.41, 13.35)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (77, 53, 91, N'підвіс', 2475.0000, 1500.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-10' AS Date), CAST(N'2022-06-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.43, 3.3)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (78, 66, 89, N'Ланцюг', 5137.0000, 5000.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-08' AS Date), CAST(N'2022-06-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.89, 6.85)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (79, 22, 19, N'Сережки', 1453.0000, 1450.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-11' AS Date), CAST(N'2022-06-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.53, 1.53)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (80, 10, 107, N'сережки ', 5770.0000, 5770.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-22' AS Date), CAST(N'2022-06-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.77, 5.77)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (81, 74, 106, N'обручка', 1601.0000, 1600.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-21' AS Date), CAST(N'2022-06-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.95, 1.95)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (82, 55, 79, N'каблучка', 2302.0000, 2300.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-03' AS Date), CAST(N'2022-06-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.24, 3.07)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (83, 19, 109, N'каблучка', 3050.0000, 3050.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-22' AS Date), CAST(N'2022-06-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.23, 3.05)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (84, 60, 96, N'Сережки', 2565.0000, 1816.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-13' AS Date), CAST(N'2022-06-23' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.42, 3.42)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (85, 76, 113, N'Брухт', 260.0000, 260.0000, 1.5000, N'Серебро - 925', CAST(N'2022-06-23' AS Date), CAST(N'2022-06-23' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 27.5, 21.7)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (86, 67, 90, N'Сережки', 3352.0000, 3350.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-09' AS Date), CAST(N'2022-06-23' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.75, 4.41)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (87, 29, 100, N'обручка', 1650.0000, 687.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-16' AS Date), CAST(N'2022-06-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.2, 2.2)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (88, 22, 114, N'Сережки', 4400.0000, 4400.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-24' AS Date), CAST(N'2022-06-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.75, 4.4)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (89, 4, 61, N'обручка', 1830.0000, 1600.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-25' AS Date), CAST(N'2022-06-25' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.44, 2.44)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (90, 70, 94, N'Сережка', 1000.0000, 1000.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-13' AS Date), CAST(N'2022-06-25' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.6, 1.25)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (91, 17, 103, N'Ланцюг', 1702.0000, 1700.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-18' AS Date), CAST(N'2022-06-25' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.28, 2.24)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (92, 49, 53, N'Обручка', 1357.0000, 1350.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-23' AS Date), CAST(N'2022-06-26' AS Date), CAST(N'2022-06-09' AS Date), CAST(N'2022-06-23' AS Date), 1.81, 1.81)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (93, 63, 120, N'сережки', 3606.0000, 3600.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-28' AS Date), CAST(N'2022-06-28' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.68, 3.68)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (94, 5, 121, N'Брухт', 774.0000, 774.0000, 0.0100, N'Серебро - 925', CAST(N'2022-06-29' AS Date), CAST(N'2022-06-29' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 48.26, 43)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (95, 78, 123, N'Ланцюг', 3060.0000, 3060.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-29' AS Date), CAST(N'2022-06-30' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.6, 3.6)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (96, 18, 122, N'Сережки', 6050.0000, 6050.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-29' AS Date), CAST(N'2022-06-30' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.09, 6.05)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (97, 15, 60, N'браслет деформ.', 3379.0000, 3350.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-25' AS Date), CAST(N'2022-07-01' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.57, 3.52)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (98, 79, 125, N'обручка', 1720.0000, 1720.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-02' AS Date), CAST(N'2022-07-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2, 2)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (99, 60, 112, N'Сережки', 2565.0000, 1494.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-23' AS Date), CAST(N'2022-07-02' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.42, 3.42)
GO
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (100, 66, 111, N'Підвіс', 2280.0000, 2000.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-23' AS Date), CAST(N'2022-07-05' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.4, 2.4)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (101, 66, 108, N'каблучка', 2160.0000, 2093.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-22' AS Date), CAST(N'2022-07-05' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.79, 2.7)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (102, 80, 127, N'Обручка', 5418.0000, 5000.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-06' AS Date), CAST(N'2022-07-06' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.02, 6.02)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (103, 73, 105, N'ланцюг', 658.0000, 650.0000, 0.5900, N'Серебро - 925', CAST(N'2022-06-21' AS Date), CAST(N'2022-07-07' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 47.63, 47)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (104, 80, 130, N'Обручка', 5418.0000, 5000.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.02, 6.02)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (105, 28, 88, N'каблучка', 1107.0000, 1100.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-06' AS Date), CAST(N'2022-07-09' AS Date), CAST(N'2022-07-02' AS Date), CAST(N'2022-07-16' AS Date), 1.67, 1.41)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (116, 28, 116, N'Сережка', 504.0000, 500.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-25' AS Date), CAST(N'2022-07-09' AS Date), CAST(N'2022-07-08' AS Date), CAST(N'2022-07-22' AS Date), 0.66, 0.56)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (117, 83, 132, N'брухт', 158.0000, 158.0000, 0.0100, N'Золото - 585', CAST(N'2022-07-10' AS Date), CAST(N'2022-07-10' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.17, 0.17)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (118, 31, 28, N'каблучка', 1125.0000, 1125.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-17' AS Date), CAST(N'2022-07-11' AS Date), CAST(N'2022-07-04' AS Date), CAST(N'2022-07-10' AS Date), 1.74, 1.5)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (119, 31, 31, N'каблучка', 1702.0000, 1700.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-18' AS Date), CAST(N'2022-07-11' AS Date), CAST(N'2022-07-04' AS Date), CAST(N'2022-07-10' AS Date), 2.37, 2.21)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (120, 60, 126, N'сережки', 2565.0000, 1252.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-02' AS Date), CAST(N'2022-07-11' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.42, 3.42)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (121, 82, 129, N'Ланцюг', 4360.0000, 4350.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-07' AS Date), CAST(N'2022-07-12' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.36, 4.36)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (122, 20, 117, N'підвіс', 2302.0000, 1000.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-26' AS Date), CAST(N'2022-07-12' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.07, 3.07)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (123, 82, 136, N'Ланцюг', 5014.0000, 5000.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-13' AS Date), CAST(N'2022-07-13' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.36, 4.36)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (124, 84, 135, N'Ланцюг', 2501.0000, 2501.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-13' AS Date), CAST(N'2022-07-13' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.65, 2.63)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (125, 71, 128, N'Хрест', 9622.0000, 9600.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-06' AS Date), CAST(N'2022-07-13' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 11.06, 11.06)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (135, 7, 139, N'каблучка', 94.0000, 94.0000, 0.0100, N'Серебро - 925', CAST(N'2022-07-15' AS Date), CAST(N'2022-07-15' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.01, 5.9)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (136, 33, 34, N'ланцюг', 1435.0000, 1400.0000, 0.5900, N'Серебро - 925', CAST(N'2022-05-18' AS Date), CAST(N'2022-07-15' AS Date), CAST(N'2022-07-09' AS Date), CAST(N'2022-08-08' AS Date), 71.75, 71.75)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (140, 77, 119, N'ланцюг', 6506.0000, 6500.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-28' AS Date), CAST(N'2022-07-18' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 7.33, 7.31)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (149, 75, 110, N'Браслет', 272.0000, 270.0000, 1.5000, N'Серебро - 925', CAST(N'2022-06-23' AS Date), CAST(N'2022-07-18' AS Date), CAST(N'2022-07-07' AS Date), CAST(N'2022-07-14' AS Date), 19.11, 17)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (150, 83, 131, N'підвіс', 2924.0000, 1900.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-10' AS Date), CAST(N'2022-07-18' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.44, 3.44)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (151, 80, 134, N'Обручка', 5719.0000, 5700.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-13' AS Date), CAST(N'2022-07-18' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.02, 6.02)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (152, 87, 145, N'Обручка', 1501.0000, 1500.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-19' AS Date), CAST(N'2022-07-19' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.64, 1.64)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (153, 32, 143, N'каблучка', 1100.0000, 1100.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-17' AS Date), CAST(N'2022-07-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.13, 1.1)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (154, 69, 92, N'сережки', 2250.0000, 2000.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-11' AS Date), CAST(N'2022-07-20' AS Date), CAST(N'2022-07-05' AS Date), CAST(N'2022-07-19' AS Date), 3.18, 3)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (155, 48, 52, N'Ланцюг', 4012.0000, 4000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-23' AS Date), CAST(N'2022-07-21' AS Date), CAST(N'2022-07-11' AS Date), CAST(N'2022-07-25' AS Date), 5.45, 5.35)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (156, 19, 138, N'ланцюг', 16000.0000, 16000.0000, 0.3500, N'Золото - 585', CAST(N'2022-07-14' AS Date), CAST(N'2022-07-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 16.34, 16)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (157, 26, 140, N'сережка', 714.0000, 500.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-16' AS Date), CAST(N'2022-07-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.68, 0.68)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (158, 13, 33, N'сережки', 3610.0000, 3600.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-18' AS Date), CAST(N'2022-07-21' AS Date), CAST(N'2022-06-15' AS Date), CAST(N'2022-06-29' AS Date), 4.25, 3.8)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (159, 13, 146, N'Обручка', 4370.0000, 4370.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-21' AS Date), CAST(N'2022-07-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.8, 3.8)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (160, 12, 55, N'Ланцюг', 10001.0000, 10000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-23' AS Date), CAST(N'2022-07-22' AS Date), CAST(N'2022-07-07' AS Date), CAST(N'2022-07-21' AS Date), 10.4, 10.31)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (161, 12, 54, N'Каблучка', 1450.0000, 1450.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-23' AS Date), CAST(N'2022-07-22' AS Date), CAST(N'2022-07-07' AS Date), CAST(N'2022-07-21' AS Date), 1.73, 1.45)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (162, 12, 147, N'брухт', 104.0000, 104.0000, 0.0100, N'Серебро - 925', CAST(N'2022-07-22' AS Date), CAST(N'2022-07-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 6.92, 6.5)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (163, 12, 148, N'брухт', 168.0000, 168.0000, 0.0100, N'Серебро - 875', CAST(N'2022-07-22' AS Date), CAST(N'2022-07-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 12.03, 12.03)
INSERT [pro].[Archiv_dogovor] ([ID_Archiv_dogovor], [Client_Id], [ID_Dogovor], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (164, 68, 95, N'Сережки', 4530.0000, 4400.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-13' AS Date), CAST(N'2022-07-22' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5, 4.67)
SET IDENTITY_INSERT [pro].[Archiv_dogovor] OFF
GO
SET IDENTITY_INSERT [pro].[Archiv_prod] ON 

INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (1, 7, 1, CAST(N'2022-05-16' AS Date), CAST(N'2022-05-23' AS Date), 63.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (2, 63, 11, CAST(N'2022-06-09' AS Date), CAST(N'2022-06-23' AS Date), 70.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (3, 23, 2, CAST(N'2022-05-23' AS Date), CAST(N'2022-05-30' AS Date), 86.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (4, 23, 9, CAST(N'2022-06-03' AS Date), CAST(N'2022-06-10' AS Date), 8.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (5, 22, 3, CAST(N'2022-05-25' AS Date), CAST(N'2022-06-08' AS Date), 126.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (6, 22, 13, CAST(N'2022-06-10' AS Date), CAST(N'2022-06-24' AS Date), 152.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (7, 53, 12, CAST(N'2022-06-09' AS Date), CAST(N'2022-06-23' AS Date), 95.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (8, 88, 20, CAST(N'2022-06-18' AS Date), CAST(N'2022-07-02' AS Date), 56.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (9, 88, 29, CAST(N'2022-07-02' AS Date), CAST(N'2022-07-16' AS Date), 60.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (20, 116, 37, CAST(N'2022-07-08' AS Date), CAST(N'2022-07-22' AS Date), 27.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (21, 28, 7, CAST(N'2022-05-30' AS Date), CAST(N'2022-06-13' AS Date), 61.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (22, 28, 15, CAST(N'2022-06-13' AS Date), CAST(N'2022-06-27' AS Date), 66.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (23, 28, 24, CAST(N'2022-06-27' AS Date), CAST(N'2022-07-04' AS Date), 61.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (24, 28, 32, CAST(N'2022-07-04' AS Date), CAST(N'2022-07-10' AS Date), 31.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (25, 31, 6, CAST(N'2022-05-30' AS Date), CAST(N'2022-06-13' AS Date), 86.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (26, 31, 16, CAST(N'2022-06-13' AS Date), CAST(N'2022-06-27' AS Date), 99.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (27, 31, 23, CAST(N'2022-06-27' AS Date), CAST(N'2022-07-04' AS Date), 93.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (28, 31, 31, CAST(N'2022-07-04' AS Date), CAST(N'2022-07-10' AS Date), 46.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (38, 34, 39, CAST(N'2022-07-09' AS Date), CAST(N'2022-08-08' AS Date), 438.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (46, 149, 36, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-14' AS Date), 61.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (47, 154, 21, CAST(N'2022-06-23' AS Date), CAST(N'2022-07-07' AS Date), 101.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (48, 154, 33, CAST(N'2022-07-05' AS Date), CAST(N'2022-07-19' AS Date), 94.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (49, 155, 10, CAST(N'2022-06-04' AS Date), CAST(N'2022-06-18' AS Date), 203.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (50, 155, 19, CAST(N'2022-06-17' AS Date), CAST(N'2022-07-01' AS Date), 203.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (51, 155, 26, CAST(N'2022-06-29' AS Date), CAST(N'2022-07-13' AS Date), 187.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (52, 155, 41, CAST(N'2022-07-11' AS Date), CAST(N'2022-07-25' AS Date), 187.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (53, 158, 18, CAST(N'2022-06-15' AS Date), CAST(N'2022-06-29' AS Date), 407.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (54, 160, 34, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-21' AS Date), 1794.0000)
INSERT [pro].[Archiv_prod] ([ID_Archiv_prod], [Dogovor_Id], [ID_Prodlenie], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (55, 161, 35, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-21' AS Date), 260.0000)
SET IDENTITY_INSERT [pro].[Archiv_prod] OFF
GO
SET IDENTITY_INSERT [pro].[Client] ON 

INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (1, N'Максим', N'Володимирович', N'Журавльов', N'0964180411', CAST(N'1976-03-21' AS Date), N'СЮ', N'382357', N'Шевченківським РВ УДМС україни в Зап.обл. 11,03,2015', N'2802303097', N'м. Запоріжжя вул.Вольська 5')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (2, N'Валентина', N'Олексіївна', N'Хлібко', N'0505560508', CAST(N'1977-04-20' AS Date), N'СЮ', N'384086', N'Ленінським РВ УДВС України в Зап.обл. 18,03,2015', N'2823414266', N' ')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (3, N'Владислав', N'Валерійович', N'Колодницький', N'0687418060', CAST(N'1999-02-07' AS Date), N'СЮ', N'369292', N'Шевченківським РВ УМВС України в Зап.обл. 10,02,2015', N'3619702553', N' ')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (4, N'Віталій', N'Миколайович', N'Лимар', N'0984856360', CAST(N'1988-01-06' AS Date), N'СВ', N'946761', N'Швченківським РВ УМВС України в Зап.обл. 20,09,2005', N'11111111111', N'')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (5, N'Олег', N'Віталійович', N'Литвиненко', N'0962408708', CAST(N'1993-02-27' AS Date), N'СЮ', N'134106', N'Шевченківським РВ УМВС України в Зап. обл. 24,04,2009', N'22222222222', N' ')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (6, N'Світлана', N'Володимирівна', N'Благорозумна', N'0953070387', CAST(N'1973-12-27' AS Date), N'СВ', N'497345', N'Шевченківським РВ УМВС України в Зап. обл. 19,12,2001', N'2702406509', N' ')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (7, N'Євгеній', N'Володимирович', N'Рибалка', N' ', CAST(N'1965-05-13' AS Date), N'ЕР', N'312217', N'Орджонікідзевським РВ УМВС в Зап.обл. 26,06,2004', N'2387408856', N'м. Запоріжжя, бул. Гвардійський 28\68')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (8, N'Вадим', N'Михайлович', N'Малєєв', N'0636034112', CAST(N'1986-07-21' AS Date), N'СВ', N'881351', N'Вільнянським РВ УМВС України в Зап.обл.', N'3161324071', N'с. Шевченко, вул. Побєди, д. 25')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (9, N'Олександр', N'Олександрович', N'Шаов', N' 0961334887', CAST(N'1982-11-01' AS Date), N'19821101-10657', N'004792830', N'1452 (18,05,2020)', N'3025503950', N'м.Чистякове Донецька область ')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (10, N'Тетяна', N'Сергіївна', N'Кривенко', N'0967976130', CAST(N'1987-09-16' AS Date), N'АО', N'365979', N'Жовтоводським МС ГУМВС України в Дніпропетровський обл.', N'3203500162', N'с.Новоуспенівка, вул.Молодіжна,1')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (11, N'Іван', N'Петрович', N'Кущ', N'0964528469', CAST(N'1983-04-26' AS Date), N'СЮ', N'301782', N'Запорізьким РВ УДМС України в Запор.обл. 09.08.2013', N'3043122894', N'смт.Балабине, вул. 30р.Перемоги 63')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (12, N'Марина', N'Віталіївна', N'Шевцова', N'0669583010', CAST(N'1984-08-10' AS Date), N'СЮ', N'421019', N'Вільнянським РВ ГУМВС України в Запорізькій обл. 03.03.2016', N'3090320346', N'с.Солоне, вул.Лесі Українки,14')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (13, N'Олексій', N'Ігорович', N'Фікс ', N'0668580739', CAST(N'2000-10-17' AS Date), N'..', N'005677340', N'2316 Шевченківський районний відділ у м.Запоріжжі 28.01.2021', N'3681503310', N'м.Запоріжжя, вул.Кузнецова, 40-12')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (14, N'Олександр', N'Сергійович', N'Соська', N'0676135307', CAST(N'1986-11-09' AS Date), N'СВ', N'829694', N'Шевченківським РВУМВС України в Запорізькій обл. 20.08.2003', N'3172416318', N'м.Запоріжжя, вул.Червонополянська,27')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (15, N'Лілія', N'Сергіївна', N'Агаєва', N'0684527518', CAST(N'1983-01-30' AS Date), N'СЮ', N'135962', N'Шевченківським РВУМВС України в Запорізькій обл. 20.06.2009', N'3034513901', N'м.Запоріжжя, вул.Кругова,152-26')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (16, N'Лілія', N'Григорівна', N'Надточій', N'0633996799', CAST(N'1984-09-25' AS Date), N'СВ', N'319120', N'Шевченківським РВ УМВС України в Запорізькій обл. 28.12.2000', N'3094911168', N'м.Запоріжжя, вул Кузнецова 19-124')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (17, N'Олександр', N'Геннадійович', N'Синій', N'0509624387', CAST(N'1967-07-04' AS Date), N'СА', N'594037', N'Шевченківським РВ УМВС України в Запорізькій обл. 23.10.1997', N'2465607837', N'м.Запоріжжя, вул.Копьонкіна 50-93')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (18, N'Ганна', N'Валеріївна', N'Писаренко', N'0673166925', CAST(N'1986-10-10' AS Date), N',,', N'002928360', N'2316   07.02.2019', N'3169417546', N'м.Запоріжжя, вул.Миколи Корищенка 40-11')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (19, N'Юлія', N'Олександрівна', N'Боренко', N'0505009660', CAST(N'1982-07-02' AS Date), N'СМ', N'742455', N'Шевченківським РВУМВС України в Запорізькій обл.', N'3013305964', N'м.Запоріжжя, вул.Фелікса Мовчановського 52а-20')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (20, N'Олександр', N'Юрійович', N'Стрельніков', N'', CAST(N'1991-01-19' AS Date), N',,', N'19910117', N'1465   21.02.2020', N'3325406817', N'м.Запоріжжя, вул.Іванова,21')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (21, N'Аліна', N'Павлівна', N'Голуб', N'', CAST(N'2000-09-16' AS Date), N',,', N'003320355', N'1234   06.05.2019', N'3678408083', N'м.Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (22, N'Владислав', N'Володимирович', N'Вінярський', N'0999544735', CAST(N'1982-02-23' AS Date), N'СВ', N'054546', N'Орджонікідзевським РВУМВС України в Зап.обл 03,09,1999', N'3000424893', N'м. Запоріжжя вул. Магара буд.7 кв.1')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (23, N'Віра', N'Іванівна', N'Стрельникова', N'0974601550', CAST(N'1952-05-16' AS Date), N'СА', N'489863', N'Шевченківським РВ УМВС України в Зап.обл. 17,06,1997', N'1912916521', N'м. Запоріжжя вул. Харчова буд. 73 кв. 3')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (24, N'Максим', N'Анатолійович', N'Гараздюк', N'0931902528', CAST(N'1991-08-13' AS Date), N'СЮ', N'114067', N'Михайлівським РВ ГУМВС України в Зап.обл. 13,11,2008', N'3346215255', N'смт.Пришиб вул. Леніна буд.39 кв. 3')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (25, N'Олег', N'Олегович', N'Александров', N'0972952110', CAST(N'1987-11-13' AS Date), N'СВ', N'923194', N'Шевченківським РВ УМВС України в Запорізькій обл. 10.03.2005', N'3209310972', N'м.Запоріжжя, вул.Харчова 5')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (26, N'Оксана', N'Володимирівна', N'Бєлоконева', N'0991283096', CAST(N'1993-11-22' AS Date), N'СЮ', N'430261', N'Комунарським РВ УМВС України в Запорізькій обл. 20.07.2016', N'3429406328', N'м.Запоріжжя, вул.Дмитра Миргородського 30')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (27, N'Вікторія', N'Анатоліївна', N'Якушонок', N'0505629480', CAST(N'1971-10-01' AS Date), N'СЮ', N'098773', N'Запорізькім РВ УМВС України в Запорізькій обл. 17.08.2008', N'2620620047', N'с.Малокатеринівка, вул.Кірова 35')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (28, N'Наталія', N'Миколаївна', N'Дмитрієнко', N'0665625132', CAST(N'1987-09-24' AS Date), N',,', N'003058005', N'2316', N'3204311543', N'м.Запоріжжя вул. Аваліані буд. 15 кв.14')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (29, N'Олександр', N'Сергійович', N'Годованець', N'0973894595', CAST(N'1986-03-13' AS Date), N'СВ', N'621698', N'Запорізьким РВ ГУМВС України в Зап.обл', N'3148312119', N'пгт. Балабіно просп. Вишнева буд.18')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (30, N'Максим', N'Євгенович', N'Македонський', N'0686859828', CAST(N'1999-08-26' AS Date), N',,', N'001290426', N'2312   04.12.2017', N'3639702814', N'м.Запоріжжя, вул. Олександра Говорухи 28а')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (31, N'Вікторія ', N'Вікторівна', N'Клещева', N'0952545287', CAST(N'1971-03-09' AS Date), N'СВ', N'390068', N'Шевченківським РВ УМВС України в Запорізькій обл.   26.04.2001', N'2600015206', N'м.Запоріжжя, вул.Магистральна 70а-13')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (32, N'Юлія', N'Леонідівна', N'Кибук', N'0953473482', CAST(N'1992-06-12' AS Date), N'СЮ', N'324486', N'Михайлівським РС УДМС України в Запорізькій обл.   26.11.2013', N'3376610364', N'с.Тимошівка, вул.Калініна 139')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (33, N'Олександр', N'Станиславович', N'Дашенко', N'0990012007', CAST(N'1980-07-18' AS Date), N',,', N'001852280', N'2316   10.05.2018', N'2941924979', N'м.Запоріжжя, вул.Солідарності 55а')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (34, N'Людмила', N'Василівна', N'Книрік', N'0997845755', CAST(N'1967-11-27' AS Date), N'СА', N'512281', N'Шевченківським РВ УМВС України в Запорізькій обл.  17.07.1977', N'2224619844', N'м.Запоріжжя, вул.Кутузова 140')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (35, N'Артем', N'Олегович', N'Похилько', N'0661559118', CAST(N'1991-12-28' AS Date), N'СЮ', N'086725', N'Чернігівським РВ УМВС України в Запорізькій обл.  15.05.2008', N'3359910034', N'смт.Чернігівка, вул.Горького18')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (36, N'Роман', N'Андрійович', N'Громов', N'0976089177', CAST(N'1988-10-29' AS Date), N',,', N'000983980', N'2316   19.09.2017', N'3244413511', N'м.Запоріжжя, вул.Садоводства 19б')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (37, N'Микита', N'Амбарцумович', N'Чилінгарян', N'', CAST(N'1960-10-30' AS Date), N'СА', N'226238', N'Шевченківським РВ УМКС України в Запорізькій обл. 04.06.1996', N'2221811838', N'с. Приморське, вул.Зелена 10')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (38, N'Сюзана', N'Русланівна', N'Ліманська', N'0636961760', CAST(N'1996-05-02' AS Date), N'АО', N'284710', N'Саксаганським ВР у м.Кривому Розі ГУ ДМС України в Дніпропетровській обл. 14.08.2015', N'3518613849', N'м.Горлівка, вул.Касьянова,26')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (39, N'Володимир', N'Володимирович', N'Апихтін', N'', CAST(N'1960-03-26' AS Date), N'СА', N'367748', N'Шевченківським РВ УМВС України в Запорізькій обл. 26.12.1996', N'2200005558', N'м.Запоріжжя, вул.Політаєва,46')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (40, N'В''ячеслав', N'Федорович', N'Алейкін', N'', CAST(N'1987-03-09' AS Date), N'СВ', N'820650', N'Гуляйпільським РВ УМВС України в Запорізькій обл. 16.05.2003', N'3184409136', N'с.Любимівка Молодіжна 36')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (41, N'Євген', N'Володимировмч', N'Скрипник', N'', CAST(N'1985-02-09' AS Date), N'СВ', N'391068', N'Шевченківським РВ УМВС України в Запорізькій обл. 22.05.2001', N'3108608358', N'м.Запоріжжя, вул.Криворізька 20-16')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (42, N'Віра', N'Миколаївна', N'Горпинич', N'', CAST(N'1956-09-03' AS Date), N'СВ', N'256619', N'Гуляйпільським РВУМВС України в Запорізькій обл. 18.08.2000', N'2070013322', N'с.Успенівка, вул.Спіральна 18')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (43, N'Тамара', N'Миколаївна', N'Боренко', N'', CAST(N'1950-01-01' AS Date), N',,', N'004948349', N'2316', N'1826386182', N'с. Новопавлівна буд. 4')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (46, N'Олена', N'Анатоліївна', N'Олексієнко', N'0678331072', CAST(N'1977-01-28' AS Date), N'СЮ', N'213437', N'Жовтневим РВ ГУМВС України в Запорізькій області', N'2815211109', N'м. Запоріжжя вул. Червоноралянська буд. 75')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (47, N'Маргарита', N'Владиславівна', N'Казакова', N'0502509025', CAST(N'1976-08-08' AS Date), N'СВ', N'102476', N'Хортицьким РВ УМВС України в Зап.обл. 02,12,1999', N'2797919204', N'вул. Рубана буд. 20 кв. 79')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (48, N'Ганна', N'Олександрівна', N'Турчаненко', N'0507073092', CAST(N'1982-02-04' AS Date), N'СА', N'972721', N'Хортицьким РВ МВС України в Зап.обл. 18,03,1999', N'2998501443', N'м. Запоріжжя вул. Космічна буд. 22а кв. 69')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (49, N'Ігор', N'Григорович', N'Семенков', N'0505668317', CAST(N'1987-04-12' AS Date), N',,', N'005245302', N'2316', N'3187809673', N'м. Сніжне вул. Миру 25')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (50, N'Віталій', N'Валерійович', N'Булгаков', N'', CAST(N'1982-08-30' AS Date), N'СВ', N'845226', N'Шевченкіським РВ УМВС України в Запорізькій області', N'31236987412', N'м. Запоріжжя вул. Військова буд.30')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (51, N'Яна', N'Миколаївна', N'Ховренко', N'0934095278', CAST(N'1987-11-12' AS Date), N'СВ', N'992890', N'Куйбишевським РВУМВС України в Запорізькій обл.', N'3209220746', N'с.Червоне Озеро, ул.Гагарина 84')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (52, N'Михайло', N'Леонідович', N'Чорний', N'', CAST(N'1972-04-15' AS Date), N'МО', N'632061', N'Верхорогачинським РВУМВС України в Херсонській обл. 26.01.1999', N'2640322112', N'с.Бережанка, вул.Леніна 40')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (53, N'Оксана', N'Станіславівна', N'Губка', N'0686048161', CAST(N'1981-10-25' AS Date), N'СЮ', N'315269', N'Орджонікідзевським РВ УМВС України в Зап.обл. 19,10,2013', N'2988317169', N'с. Новотавричеське вул. Шкільна буд. 94 кв. 9')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (54, N'Олена', N'Юріївна', N'Шпунтова', N'0961332706', CAST(N'1973-08-22' AS Date), N'СА', N'916449', N'Шевченківським РВ УМВс країни в Зап.обл. 21,11,1998', N'268950986', N'м. Запоріжжя провє. Світлодолинський буд. 8 ')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (55, N'Оксана', N'Сергіївна', N'Андросова', N'0978325048', CAST(N'1973-04-28' AS Date), N'СА', N'450639', N'Шевченківським РВ УМВС України в Зап.обл. 17,05,1997', N'2678112143', N'вул. Верхоянська буд. 11 кв. 1')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (56, N'Максим', N'Іванович', N'Новак', N'', CAST(N'1979-08-09' AS Date), N'СА', N'450379', N'Шевченківським РВ УМВС України в Запорізькій обл.', N'3333333333', N'М.Запоріжжя, вул.8 березня 76-14')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (57, N'Вікторія', N'Олександрівна', N'Крупенко', N'', CAST(N'1993-09-26' AS Date), N',,', N'003248145', N'2316  15.04.2019', N'3423706940', N'м.Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (58, N'Вячеслав', N'Михайлович', N'Чубук ', N'', CAST(N'1972-03-03' AS Date), N',,', N'000590779', N'2316   01.06.2017', N'2636014491', N'м.Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (59, N'Інна', N'Петрівна', N'Чурніна', N'', CAST(N'1987-04-07' AS Date), N',,', N'002365252', N'2316   27.09.2018', N'3187302104', N'м.Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (60, N'Андрій', N'Леонідович', N'Смага', N'0957137005', CAST(N'1976-05-29' AS Date), N'СВ', N'391494', N'Шевченківським РВ УМВС України в Зап.обл. 29,05,2001', N'2790801234', N'вул. Чарівна буд.46 кв.42')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (61, N'Яна', N'Володимирівна', N'Шуміліна', N'', CAST(N'1985-02-22' AS Date), N',,', N'000773284', N'2328', N'3109923147', N'смт. Кушугум')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (62, N'Наталія', N'Володимирівна', N'Биков', N'', CAST(N'1979-03-31' AS Date), N'СВ', N'502997', N'Комунарським РВЗМУУМВС України в Запорізькій обл.', N'2894417021', N'м.Запоріжжя, пр.Приволзький 23')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (63, N'Сергій', N'Анатолійович', N'Чернявський', N'', CAST(N'1963-04-22' AS Date), N'ЯТА', N'180494', N'ДАІ МВС УВС', N'4444444444', N'м.Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (65, N'Євгеній', N'Олександрович', N'Юлаєв', N'', CAST(N'1999-05-25' AS Date), N'СЮ', N'393011', N'Шевченківським РВ УДМС України в Зап.обл 03,07,2015', N'0', N'м. Запоріжжя вул. Чарівна буд. 143 кв.2')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (66, N'Ганна', N'Миколаївна', N'Чернова', N'0504545399', CAST(N'1980-04-17' AS Date), N'СЮ', N'376246', N'Запорізьким РВ УДМС України в Зап.обл. 13,12,2014', N'2932710766', N'с. Лежина вул. Жовтнева буд. 11')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (67, N'Наталія', N'Олександрівна', N'Лобкова', N'0665525621', CAST(N'1989-06-11' AS Date), N'СЮ', N'217976', N'Шевченківським РВ УМВС України в Зап.обл. 02,06,2011', N'3266909687', N'м. Запоріжжя вул. Яценка буд. 8 кв. 9')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (68, N'Олексій', N'Вікторович', N'Добришин', N'0684511742', CAST(N'1986-07-01' AS Date), N'СЮ', N'408712', N'Михайлівським РВ УМВС України в Запорізькій обл. 19.11.2015', N'3159303772', N'смт.Пришиб, вул.Заводська, 17-34')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (69, N'Ольга', N'Олександрівна', N'Кожевник', N'0502468358', CAST(N'1974-06-29' AS Date), N',,', N'003642896', N'2316    22.07.2019', N'2720816224', N'м.Запоріжжя, вул.Чарівна 105-65')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (70, N'Олександр', N'Анатолійович', N'Руденко', N'', CAST(N'1981-07-15' AS Date), N',,', N'007679334', N'2314', N'2978118638', N'м. Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (71, N'Олексій', N'Родіонович', N'Адамов', N'0503515236', CAST(N'1992-03-30' AS Date), N'СЮ', N'095069', N'Шевченківським РВ УМВС України в Запорізькій обл. 03.07.2008', N'3369208172', N'м.Запоріжжя, вул. Кутузова 26')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (72, N'Сергій', N'Миколайович', N'Шутка', N'0986170305', CAST(N'1985-06-06' AS Date), N'СЕ', N'192923', N'Шевченківським РВ УМВ України в Зап.обл.16,05,2003', N'3120320679', N'м. Запоріжжя вул.Бородинська буд.6А кім.209')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (73, N'Вардгєс', N'Самвелович', N'Єрицян', N'0982905471', CAST(N'1986-09-14' AS Date), N'СЮ', N'210351', N'Шевченківським РВ ЗМУ ГУМВС України в Запорізькій обл. 01.02.2011', N'3166823539', N'м.Запоріжжя, вул.Тимірязєва 345')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (74, N'Сергій', N'Юрійович', N'Щукін', N'', CAST(N'1973-12-16' AS Date), N',,', N'003123160', N'2316', N'2701301870', N'м.Запоріжжя')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (75, N'Вікторія', N'Вікторівна', N'Абашкіна', N'0952032686', CAST(N'1971-05-23' AS Date), N'СВ', N'932974', N'Хортицьким РВ УМВС України в Зап.обл 05,04,2005', N'2608020446', N'м. Запоріжжя вул. Хортицьке шосе б. 4 кв. 37')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (76, N'Олександра', N'Геннадіївна', N'Котова', N'', CAST(N'2002-11-28' AS Date), N',,', N'007420914', N'2316 (20,01,2022)', N'3758703408', N'м. Запоріжжя вул. Іванова 80 кв. 22')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (77, N'Євген', N'Юрійович', N'Левченко', N'0971077774', CAST(N'1988-01-09' AS Date), N'СВ', N'921618', N'Комунарським РВЗМУУМВС України в Запорізькій обл.   04.03.2005', N'3215012412', N'м.Запоріжжя, вул.Олімпійська 12/20Г')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (78, N'Людмила', N'Володимирівна', N'Терентьєва', N'', CAST(N'1958-03-23' AS Date), N'СЮ', N'127907', N'Шевченківським РВ УМВС України в Зап.обл.', N'00000000001', N'вул. Кузнецова буд. 29а кв. 71')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (79, N'Олександр', N'Георгійович', N'Собченко', N'', CAST(N'1965-10-22' AS Date), N'СВ', N'437762', N'Заводським РВ УМВС України в Запорізькій обл.  11.09.2001', N'2403610798', N'м.Запоріжжя, вул.Балкіна 19/4')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (80, N'Олександр', N'Олександрович', N'Горб', N'0997891261', CAST(N'1992-07-06' AS Date), N'СЮ', N'109000', N'Хоритицьким РВ УМВС України в Зап.обл. 02.10.2008', N'3379006196', N'м. Запоріжжя вул. Запорізького козацтва буд. 17 кв. 69')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (82, N'Віта', N'Олександрівна', N'Букасова', N'', CAST(N'1975-01-20' AS Date), N'СА', N'263714', N'Шевченківським РВ УМВС України в Зап.обл. 10.08.1996', N'2741302868', N'м. Запоріжжя вул. Верещагіна буд. 14')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (83, N'Олексій', N'Анатолійович', N'Губка', N'0686048110', CAST(N'1981-12-04' AS Date), N'СА', N'755648', N'Токмакцьким РВУМВС України в Запорізькій обл. 06.05.1998', N'2992314971', N'с. Новопрокопівка, вул.Кезікова 12')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (84, N'Лариса', N'Олександрівна', N'Недавня', N'', CAST(N'1978-02-10' AS Date), N'СА', N'088504', N'Шевченківським РВ УМВС України в Зап.обл.', N'2853010849', N'м. Запоріжжя вул. Войкова буд. 15')
INSERT [pro].[Client] ([ID_Client], [Name_], [Father_name], [Surname], [Tel], [BD], [Seria_pasport], [Number_pasport], [Vudan], [INN], [Propiska]) VALUES (87, N'Тетяна', N'Володимирівна', N'Чувашова', N'', CAST(N'1955-04-21' AS Date), N'СА', N'896884', N'Шевченківським РВ УМВС України в Зап.обл. 29.10.1998', N'0000000011', N'м. Запоріжжя вул. Кругова б.156 кв.49')
SET IDENTITY_INSERT [pro].[Client] OFF
GO
SET IDENTITY_INSERT [pro].[Dogovor] ON 

INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (24, 26, N'обручка', 1737.0000, 1735.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-13' AS Date), CAST(N'2022-05-26' AS Date), CAST(N'2022-07-12' AS Date), CAST(N'2022-07-26' AS Date), 1.93, 1.93)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (25, 27, N'каблучка з вст.', 1004.0000, 1000.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-13' AS Date), CAST(N'2022-05-26' AS Date), CAST(N'2022-07-01' AS Date), CAST(N'2022-07-15' AS Date), 1.21, 1.21)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (26, 28, N'Хрест', 716.0000, 700.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-16' AS Date), CAST(N'2022-05-29' AS Date), CAST(N'2022-07-08' AS Date), CAST(N'2022-07-22' AS Date), 0.93, 0.93)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (32, 13, N'сережки', 2707.0000, 2700.0000, 0.3900, N'Золото - 585', CAST(N'2022-05-18' AS Date), CAST(N'2022-05-31' AS Date), CAST(N'2022-06-29' AS Date), CAST(N'2022-07-13' AS Date), 2.85, 2.85)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (51, 47, N'Брухт', 472.0000, 470.0000, 1.0000, N'Серебро - 925', CAST(N'2022-05-23' AS Date), CAST(N'2022-06-21' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 62.6, 26.2)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (104, 72, N'Каблучка', 1600.0000, 1600.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-19' AS Date), CAST(N'2022-07-02' AS Date), CAST(N'2022-07-13' AS Date), CAST(N'2022-07-27' AS Date), 2.65, 2)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (115, 4, N'Обручка', 1830.0000, 1400.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-25' AS Date), CAST(N'2022-07-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 2.44, 2.44)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (118, 49, N'обручка', 2457.0000, 2445.0000, 0.3900, N'Золото - 585', CAST(N'2022-06-26' AS Date), CAST(N'2022-07-09' AS Date), CAST(N'2022-07-10' AS Date), CAST(N'2022-07-24' AS Date), 2.89, 2.89)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (124, 15, N'Браслет деформ', 3414.0000, 3346.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-01' AS Date), CAST(N'2022-07-14' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 3.57, 3.52)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (133, 72, N'Сережки', 2880.0000, 2869.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-13' AS Date), CAST(N'2022-07-26' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 5.06, 3)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (137, 71, N'крест', 10065.0000, 10000.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-14' AS Date), CAST(N'2022-07-20' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 11.06, 11.06)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (141, 51, N'сережки', 1520.0000, 1500.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-16' AS Date), CAST(N'2022-07-29' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 1.6, 1.6)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (142, 17, N'підвіс', 520.0000, 500.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-16' AS Date), CAST(N'2022-07-23' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 0.52, 0.52)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (144, 77, N'Ланцюг', 6213.0000, 5032.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-18' AS Date), CAST(N'2022-07-31' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 7.33, 7.31)
INSERT [pro].[Dogovor] ([ID_Dogovor], [Client_Id], [Predmet], [Ocenochna_stoimost], [Vudano], [Procent], [Opisanie], [Date_Start], [Date_Finish], [Date_Start_prod], [Date_Finish_prod], [Ves_All], [Ves_zachet]) VALUES (149, 68, N'каблучка', 4830.0000, 4830.0000, 0.3900, N'Золото - 585', CAST(N'2022-07-22' AS Date), CAST(N'2022-07-24' AS Date), CAST(N'1000-01-01' AS Date), CAST(N'1000-01-01' AS Date), 4.2, 4.2)
SET IDENTITY_INSERT [pro].[Dogovor] OFF
GO
SET IDENTITY_INSERT [pro].[Prodlenie] ON 

INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (4, 24, CAST(N'2022-05-27' AS Date), CAST(N'2022-06-10' AS Date), 101.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (5, 26, CAST(N'2022-05-28' AS Date), CAST(N'2022-06-11' AS Date), 35.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (8, 25, CAST(N'2022-06-02' AS Date), CAST(N'2022-06-16' AS Date), 82.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (14, 26, CAST(N'2022-06-11' AS Date), CAST(N'2022-06-25' AS Date), 41.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (17, 24, CAST(N'2022-06-14' AS Date), CAST(N'2022-06-28' AS Date), 122.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (22, 26, CAST(N'2022-06-25' AS Date), CAST(N'2022-07-09' AS Date), 38.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (25, 24, CAST(N'2022-06-28' AS Date), CAST(N'2022-07-12' AS Date), 95.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (27, 32, CAST(N'2022-06-29' AS Date), CAST(N'2022-07-13' AS Date), 453.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (28, 25, CAST(N'2022-07-01' AS Date), CAST(N'2022-07-15' AS Date), 113.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (30, 104, CAST(N'2022-07-02' AS Date), CAST(N'2022-07-16' AS Date), 87.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (38, 26, CAST(N'2022-07-08' AS Date), CAST(N'2022-07-22' AS Date), 35.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (40, 118, CAST(N'2022-07-10' AS Date), CAST(N'2022-07-24' AS Date), 143.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (42, 24, CAST(N'2022-07-12' AS Date), CAST(N'2022-07-26' AS Date), 95.0000)
INSERT [pro].[Prodlenie] ([ID_Prodlenie], [Dogovor_Id], [Date_start_prod], [Date_finish_prod], [Price]) VALUES (43, 104, CAST(N'2022-07-13' AS Date), CAST(N'2022-07-27' AS Date), 69.0000)
SET IDENTITY_INSERT [pro].[Prodlenie] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Client__33D15046E4501857]    Script Date: 22.07.2022 14:17:53 ******/
ALTER TABLE [pro].[Client] ADD UNIQUE NONCLUSTERED 
(
	[Number_pasport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Client__C490CCF50D33D3C1]    Script Date: 22.07.2022 14:17:53 ******/
ALTER TABLE [pro].[Client] ADD UNIQUE NONCLUSTERED 
(
	[INN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [pro].[Archiv_dogovor] ADD  DEFAULT ((1)) FOR [Client_Id]
GO
ALTER TABLE [pro].[Archiv_dogovor] ADD  DEFAULT ((1)) FOR [ID_Dogovor]
GO
ALTER TABLE [pro].[Archiv_dogovor] ADD  DEFAULT ('1000-01-01') FOR [Date_Start_prod]
GO
ALTER TABLE [pro].[Archiv_dogovor] ADD  DEFAULT ('1000-01-01') FOR [Date_Finish_prod]
GO
ALTER TABLE [pro].[Archiv_dogovor] ADD  CONSTRAINT [DF_Archiv_dogovor_Ves_All]  DEFAULT ((0.0)) FOR [Ves_All]
GO
ALTER TABLE [pro].[Archiv_dogovor] ADD  CONSTRAINT [DF_Archiv_dogovor_Ves_zachet]  DEFAULT ((0.0)) FOR [Ves_zachet]
GO
ALTER TABLE [pro].[Archiv_prod] ADD  DEFAULT ((1)) FOR [Dogovor_Id]
GO
ALTER TABLE [pro].[Archiv_prod] ADD  DEFAULT ((1)) FOR [ID_Prodlenie]
GO
ALTER TABLE [pro].[Client] ADD  DEFAULT ('') FOR [Tel]
GO
ALTER TABLE [pro].[Client] ADD  DEFAULT ('') FOR [Seria_pasport]
GO
ALTER TABLE [pro].[Client] ADD  CONSTRAINT [DF_Client_Propiska]  DEFAULT (N'Нет') FOR [Propiska]
GO
ALTER TABLE [pro].[Dogovor] ADD  DEFAULT ((1)) FOR [Client_Id]
GO
ALTER TABLE [pro].[Dogovor] ADD  DEFAULT ('1000-01-01') FOR [Date_Start_prod]
GO
ALTER TABLE [pro].[Dogovor] ADD  DEFAULT ('1000-01-01') FOR [Date_Finish_prod]
GO
ALTER TABLE [pro].[Dogovor] ADD  CONSTRAINT [DF_Dogovor_Ves_All]  DEFAULT ((0.0)) FOR [Ves_All]
GO
ALTER TABLE [pro].[Dogovor] ADD  CONSTRAINT [DF_Dogovor_Ves_zachet]  DEFAULT ((0.0)) FOR [Ves_zachet]
GO
ALTER TABLE [pro].[Prodlenie] ADD  DEFAULT ((1)) FOR [Dogovor_Id]
GO
ALTER TABLE [pro].[Archiv_dogovor]  WITH CHECK ADD  CONSTRAINT [FK_Archiv_dogovor_Client] FOREIGN KEY([Client_Id])
REFERENCES [pro].[Client] ([ID_Client])
GO
ALTER TABLE [pro].[Archiv_dogovor] CHECK CONSTRAINT [FK_Archiv_dogovor_Client]
GO
ALTER TABLE [pro].[Archiv_prod]  WITH CHECK ADD  CONSTRAINT [FK_Archiv_prod_Archiv_dogovor] FOREIGN KEY([Dogovor_Id])
REFERENCES [pro].[Archiv_dogovor] ([ID_Archiv_dogovor])
GO
ALTER TABLE [pro].[Archiv_prod] CHECK CONSTRAINT [FK_Archiv_prod_Archiv_dogovor]
GO
ALTER TABLE [pro].[Dogovor]  WITH CHECK ADD  CONSTRAINT [FK_Dogovor_Client] FOREIGN KEY([Client_Id])
REFERENCES [pro].[Client] ([ID_Client])
GO
ALTER TABLE [pro].[Dogovor] CHECK CONSTRAINT [FK_Dogovor_Client]
GO
ALTER TABLE [pro].[Prodlenie]  WITH CHECK ADD  CONSTRAINT [FK_Prodlenie_Dogovor] FOREIGN KEY([Dogovor_Id])
REFERENCES [pro].[Dogovor] ([ID_Dogovor])
GO
ALTER TABLE [pro].[Prodlenie] CHECK CONSTRAINT [FK_Prodlenie_Dogovor]
GO
ALTER TABLE [pro].[Archiv_dogovor]  WITH CHECK ADD CHECK  (([Ocenochna_stoimost]>(0.0)))
GO
ALTER TABLE [pro].[Archiv_dogovor]  WITH CHECK ADD CHECK  (([Predmet]<>N''))
GO
ALTER TABLE [pro].[Archiv_dogovor]  WITH CHECK ADD CHECK  (([Procent]>(0.0)))
GO
ALTER TABLE [pro].[Archiv_dogovor]  WITH CHECK ADD CHECK  (([Vudano]>(0.0)))
GO
ALTER TABLE [pro].[Archiv_prod]  WITH CHECK ADD CHECK  (([Price]>(0.0)))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([BD]>='1910-01-01' AND [BD]<=CONVERT([date],getdate())))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([Father_name]<>N''))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([INN]<>N''))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([Name_]<>N''))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([Number_pasport]<>N''))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([Surname]<>N''))
GO
ALTER TABLE [pro].[Client]  WITH CHECK ADD CHECK  (([Vudan]<>N''))
GO
ALTER TABLE [pro].[Dogovor]  WITH CHECK ADD CHECK  (([Ocenochna_stoimost]>(0.0)))
GO
ALTER TABLE [pro].[Dogovor]  WITH CHECK ADD CHECK  (([Predmet]<>N''))
GO
ALTER TABLE [pro].[Dogovor]  WITH CHECK ADD CHECK  (([Procent]>(0.0)))
GO
ALTER TABLE [pro].[Dogovor]  WITH CHECK ADD CHECK  (([Vudano]>(0.0)))
GO
ALTER TABLE [pro].[Prodlenie]  WITH CHECK ADD CHECK  (([Price]>(0.0)))
GO
/****** Object:  StoredProcedure [pro].[Day_Now]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[Day_Now]
AS
BEGIN
	SET NOCOUNT ON;

	select*
	from (select * from pro.Dogovor where Date_Finish_prod = '1000-01-01' and Date_Start_prod ='1000-01-01' and Date_Finish = CONVERT([date],getdate()) 
	union  
	select * from pro.Dogovor where Date_Finish_prod != '1000-01-01' and Date_Start_prod !='1000-01-01' and Date_Finish_prod = CONVERT([date],getdate()))as f
END
GO
/****** Object:  StoredProcedure [pro].[stp_Arhiv_Dogovor_Prodlenia]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Arhiv_Dogovor_Prodlenia]
@ID int
AS
BEGIN
	SET NOCOUNT ON;
Select p.ID_Archiv_prod, p.Dogovor_Id,p.ID_Prodlenie,p.Date_start_prod,p.Date_finish_prod,p.Price
from pro.Archiv_prod p
where p.Dogovor_Id = @ID 
order by p.ID_Prodlenie
END
GO
/****** Object:  StoredProcedure [pro].[stp_Delete_Archiv_dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Delete_Archiv_dogovor]
@ID int
AS
BEGIN

	SET NOCOUNT ON;
DELETE FROM [Lombard_new].[pro].[Archiv_dogovor]
      WHERE [ID_Archiv_dogovor] = @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Delete_Archiv_prod]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Delete_Archiv_prod]
@ID int
AS
BEGIN

	SET NOCOUNT ON;
DELETE FROM [Lombard_new].[pro].[Archiv_prod]
      WHERE [ID_Archiv_prod] = @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Delete_Client]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Delete_Client]
@ID int
AS
BEGIN

	SET NOCOUNT ON;
DELETE FROM [Lombard_new].[pro].[Client]
      WHERE [ID_Client] = @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Delete_Dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Delete_Dogovor]
@ID int
AS
BEGIN

	SET NOCOUNT ON;
DELETE FROM [Lombard_new].[pro].[Dogovor]
      WHERE [ID_Dogovor] = @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Delete_Prodlenie]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Delete_Prodlenie]
@ID int
AS
BEGIN

	SET NOCOUNT ON;
DELETE FROM [Lombard_new].[pro].[Prodlenie]
      WHERE [ID_Prodlenie] = @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Dogovor_Client_ID]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Dogovor_Client_ID]
@ID int
AS
BEGIN
	SET NOCOUNT ON;
Select *
from pro.Dogovor p
where p.Client_Id = @ID 
order by p.ID_Dogovor
END
GO
/****** Object:  StoredProcedure [pro].[stp_Dogovor_Update_Date]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Dogovor_Update_Date]
@ID int,
@Date_Start_prod date,
@Date_Finish_prod date
AS
BEGIN
	SET NOCOUNT ON;
UPDATE [Lombard_new].[pro].[Dogovor]
   SET 
		[Date_Start_prod] = @Date_Start_prod
      ,[Date_Finish_prod] = @Date_Finish_prod
 WHERE [ID_Dogovor] = @ID
 return @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Info_Archiv_dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Info_Archiv_dogovor]
AS
BEGIN
	SET NOCOUNT ON;
SELECT * FROM[Lombard_new].[pro].[Archiv_dogovor] order by [ID_Dogovor]
END
GO
/****** Object:  StoredProcedure [pro].[stp_Info_Client]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Info_Client]
AS
BEGIN
	SET NOCOUNT ON;
SELECT * FROM[Lombard_new].[pro].[Client] order by [ID_Client]
END
GO
/****** Object:  StoredProcedure [pro].[stp_Info_Dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Info_Dogovor]
AS
BEGIN
	SET NOCOUNT ON;
SELECT * FROM[Lombard_new].[pro].[Dogovor] order by [ID_Dogovor]
END
GO
/****** Object:  StoredProcedure [pro].[stp_insert_Archiv_dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_insert_Archiv_dogovor]
@Client_Id int,
@ID_Dogovor int,
@Predmet nvarchar(50),
@Ocenochna_stoimost money,
@Vudano money,
@Procent money,
@Opisanie nvarchar(max),
@Date_Start date,
@Date_Finish date,
@Date_Start_prod date,
@Date_Finish_prod date,
@Ves_All float,
@Ves_zachet float
AS
BEGIN
	SET NOCOUNT ON;
    INSERT INTO [Lombard_new].[pro].[Archiv_dogovor]
           ([Client_Id]
           ,[ID_Dogovor]
           ,[Predmet]
           ,[Ocenochna_stoimost]
		   ,[Vudano]
           ,[Procent]
           ,[Opisanie]
           ,[Date_Start]
           ,[Date_Finish]
           ,[Date_Start_prod]
           ,[Date_Finish_prod]
		   ,[Ves_All]
		   ,[Ves_zachet])
     VALUES
           (@Client_Id, @ID_Dogovor, @Predmet, @Ocenochna_stoimost,@Vudano, @Procent, @Opisanie, @Date_Start, @Date_Finish, @Date_Start_prod, @Date_Finish_prod,@Ves_All,@Ves_zachet)
END
GO
/****** Object:  StoredProcedure [pro].[stp_insert_Arhiv_Prodlenie]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_insert_Arhiv_Prodlenie]
@Dogovor_Id int,
@ID_Prodlenie int,
@Date_start_prod date,
@Date_finish_prod date,
@Price money
AS
BEGIN
	SET NOCOUNT ON;
    INSERT INTO [Lombard_new].[pro].[Archiv_prod]
           ([Dogovor_Id],
		    [ID_Prodlenie]
           ,[Date_start_prod]
           ,[Date_finish_prod]
           ,[Price])
     VALUES
           (@Dogovor_Id,@ID_Prodlenie, @Date_start_prod, @Date_finish_prod, @Price)
END
GO
/****** Object:  StoredProcedure [pro].[stp_insert_Client]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_insert_Client]
@Name_ nvarchar(30),
@Father_name nvarchar(30),
@Surname nvarchar(30),
@Tel nvarchar(12),
@BD date,
@Seria_pasport nvarchar(20),
@Number_pasport nvarchar(20),
@Vudan nvarchar(300),
@INN  nvarchar(20),
@Propiska nvarchar(200)

AS
BEGIN
	SET NOCOUNT ON;
    INSERT INTO [Lombard_new].[pro].[Client]
           ([Name_]
           ,[Father_name]
           ,[Surname]
		   ,[Tel]
           ,[BD]
           ,[Seria_pasport]
           ,[Number_pasport]
		   ,[Vudan]
           ,[INN]
		   ,[Propiska])
     VALUES
           (@Name_, @Father_name, @Surname,@Tel, @BD, @Seria_pasport, @Number_pasport,@Vudan, @INN,@Propiska)
END
GO
/****** Object:  StoredProcedure [pro].[stp_insert_Dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_insert_Dogovor]
@Client_Id int,
@Predmet nvarchar(50),
@Ocenochna_stoimost money,
@Vudano money,
@Procent money,
@Opisanie nvarchar(max),
@Date_Start date,
@Date_Finish date,
@Ves_All float,
@Ves_zachet float,
@DogovorID int output
AS
BEGIN
set @DogovorID = 0
	SET NOCOUNT ON;
	begin try
begin transaction
    INSERT INTO [Lombard_new].[pro].[Dogovor]
           ([Client_Id]
           ,[Predmet]
           ,[Ocenochna_stoimost]
		   ,[Vudano]
           ,[Procent]
           ,[Opisanie]
           ,[Date_Start]
           ,[Date_Finish]
		   ,[Ves_All]
		   ,[Ves_zachet])
     VALUES
           (@Client_Id,  @Predmet, @Ocenochna_stoimost,@Vudano, @Procent, @Opisanie, @Date_Start, @Date_Finish,@Ves_All,@Ves_zachet)
		   set @DogovorID  = SCOPE_IDENTITY();
		   commit
end try
begin catch
set @DogovorID = 0
rollback
end catch
END
GO
/****** Object:  StoredProcedure [pro].[stp_insert_Prodlenie]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_insert_Prodlenie]
@Dogovor_Id int,
@Date_start_prod date,
@Date_finish_prod date,
@Price money,
@ProdlenieID int output
AS
BEGIN
set @ProdlenieID = 0
	SET NOCOUNT ON;
	begin try
begin transaction
    INSERT INTO [Lombard_new].[pro].[Prodlenie]
           ([Dogovor_Id]
           ,[Date_start_prod]
           ,[Date_finish_prod]
           ,[Price])
     VALUES
           (@Dogovor_Id, @Date_start_prod, @Date_finish_prod, @Price)
		   set @ProdlenieID  = SCOPE_IDENTITY();
		   commit
end try
begin catch
set @ProdlenieID = 0
rollback
end catch
END
GO
/****** Object:  StoredProcedure [pro].[stp_Poisc_FIO]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Poisc_FIO]
@symbol nvarchar(max)
AS
BEGIN
	SET NOCOUNT ON;
SELECT		[ID_Client]
			,[Name_]
           ,[Father_name]
           ,[Surname]
		   ,[Tel]
           ,[BD]
           ,[Seria_pasport]
           ,[Number_pasport]
		   ,[Vudan]
           ,[INN]
		   ,[Propiska]
  FROM [Lombard_new].[pro].[Client]
  where Surname + ' '+ Name_ + ' ' +Father_name like  @symbol +'%'
END
GO
/****** Object:  StoredProcedure [pro].[stp_Poisc_tel]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Poisc_tel]
@symbol nvarchar(max)
AS
BEGIN
	SET NOCOUNT ON;
SELECT		[ID_Client]
			,[Name_]
           ,[Father_name]
           ,[Surname]
		   ,[Tel]
           ,[BD]
           ,[Seria_pasport]
           ,[Number_pasport]
		   ,[Vudan]
           ,[INN]
		   ,[Propiska]
  FROM [Lombard_new].[pro].[Client]
  where Tel like  @symbol +'%'
END
GO
/****** Object:  StoredProcedure [pro].[stp_Prodlenia_Dogovor_ID]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Prodlenia_Dogovor_ID]
@ID int
AS
BEGIN
	SET NOCOUNT ON;
Select p.ID_Prodlenie, p.Dogovor_Id,p.Date_start_prod,p.Date_finish_prod,p.Price
from pro.Prodlenie p
where p.Dogovor_Id = @ID 
order by p.ID_Prodlenie
END
GO
/****** Object:  StoredProcedure [pro].[stp_Prosrochka]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [pro].[stp_Prosrochka]
AS
BEGIN
	SET NOCOUNT ON;

	select*
	from (select * from pro.Dogovor where Date_Finish_prod = '1000-01-01' and Date_Start_prod ='1000-01-01' and Date_Finish< CONVERT([date],getdate()) 
	union  
	select * from pro.Dogovor where Date_Finish_prod != '1000-01-01' and Date_Start_prod !='1000-01-01' and Date_Finish_prod< CONVERT([date],getdate()))as f
END
GO
/****** Object:  StoredProcedure [pro].[stp_Update_Archiv_dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Update_Archiv_dogovor]
@ID int,
@Client_Id int,
@ID_Dogovor int,
@Predmet nvarchar(50),
@Ocenochna_stoimost money,
@Vudano money,
@Procent money,
@Opisanie nvarchar(max),
@Date_Start date,
@Date_Finish date,
@Date_Start_prod date,
@Date_Finish_prod date,
@Ves_All float,
@Ves_zachet float
AS
BEGIN
	SET NOCOUNT ON;
UPDATE [Lombard_new].[pro].[Archiv_dogovor]
   SET [Client_Id] = @Client_Id
      ,[ID_Dogovor] = @ID_Dogovor
      ,[Predmet] = @Predmet
      ,[Ocenochna_stoimost] = @Ocenochna_stoimost
	  ,[Vudano] = @Vudano
      ,[Procent] = @Procent
      ,[Opisanie] = @Opisanie
      ,[Date_Start] = @Date_Start
      ,[Date_Finish] = @Date_Finish
      ,[Date_Start_prod] = @Date_Start_prod
      ,[Date_Finish_prod] = @Date_Finish_prod
	  ,[Ves_All] = @Ves_All
	  ,[Ves_zachet] = @Ves_zachet
 WHERE [ID_Archiv_dogovor] = @ID
 return @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Update_Arhiv_prod]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Update_Arhiv_prod]
@ID int,
@Dogovor_Id int,
@ID_Prodlenie int,
@Date_Start_prod date,
@Date_Finish_prod date,
@Price money

AS
BEGIN
	SET NOCOUNT ON;
UPDATE [Lombard_new].[pro].[Archiv_prod]
   SET [Dogovor_Id] = @Dogovor_Id
      ,[ID_Prodlenie] = @ID_Prodlenie
      ,[Date_start_prod] = @Date_Start_prod
      ,[Date_finish_prod] = @Date_Finish_prod
      ,[Price] = @Price
 WHERE [ID_Archiv_prod] = @ID
 return @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Update_Client]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Update_Client]
@ID int,
@Name_ nvarchar(30),
@Father_name nvarchar(30),
@Surname nvarchar(30),
@Tel nvarchar(12),
@BD date,
@Seria_pasport nvarchar(20),
@Number_pasport nvarchar(20),
@Vudan nvarchar(300),
@INN  nvarchar(20),
@Propiska nvarchar(200)

AS
BEGIN
	SET NOCOUNT ON;
UPDATE [Lombard_new].[pro].[Client]
   SET [Name_] = @Name_
      ,[Father_name] = @Father_name
      ,[Surname] = @Surname
	  ,[Tel] = @Tel
      ,[BD] = @BD
	   ,[Seria_pasport] = @Seria_pasport
      ,[Number_pasport] = @Number_pasport
	  ,[Vudan] = @Vudan
      ,[INN] = @INN
	  ,[Propiska] = @Propiska
 WHERE [ID_Client] = @ID
 return @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Update_Dogovor]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Update_Dogovor]
@ID int,
@Client_Id int,
@Predmet nvarchar(50),
@Ocenochna_stoimost money,
@Vudano money,
@Procent money,
@Opisanie nvarchar(max),
@Date_Start date,
@Date_Finish date,
@Date_Start_prod date,
@Date_Finish_prod date,
@Ves_All float,
@Ves_zachet float
AS
BEGIN
	SET NOCOUNT ON;
UPDATE [Lombard_new].[pro].[Dogovor]
   SET [Client_Id] = @Client_Id
      ,[Predmet] = @Predmet
      ,[Ocenochna_stoimost] = @Ocenochna_stoimost
	  ,[Vudano] = @Vudano
      ,[Procent] = @Procent
      ,[Opisanie] = @Opisanie
      ,[Date_Start] = @Date_Start
      ,[Date_Finish] = @Date_Finish
      ,[Date_Start_prod] = @Date_Start_prod
      ,[Date_Finish_prod] = @Date_Finish_prod
	  ,[Ves_All]=@Ves_All
	  ,[Ves_zachet]=@Ves_zachet
 WHERE [ID_Dogovor] = @ID
 return @ID
END
GO
/****** Object:  StoredProcedure [pro].[stp_Update_Prodlenie]    Script Date: 22.07.2022 14:17:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [pro].[stp_Update_Prodlenie]
@ID int,
@Dogovor_Id int,
@Date_Start_prod date,
@Date_Finish_prod date,
@Price money

AS
BEGIN
	SET NOCOUNT ON;
UPDATE [Lombard_new].[pro].[Prodlenie]
   SET [Dogovor_Id] = @Dogovor_Id
      ,[Date_start_prod] = @Date_Start_prod
      ,[Date_finish_prod] = @Date_Finish_prod
      ,[Price] = @Price
 WHERE [ID_Prodlenie] = @ID
 return @ID
END
GO
USE [master]
GO
ALTER DATABASE [Lombard_new] SET  READ_WRITE 
GO
