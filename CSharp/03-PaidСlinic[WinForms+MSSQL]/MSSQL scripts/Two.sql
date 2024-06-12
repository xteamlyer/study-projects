USE [master]
GO
/****** Object:  Database [Платная поликлиника]    Script Date: Пт.14.04.2023 1:01:42 ******/
CREATE DATABASE [Платная поликлиника]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Платная поликлиника', FILENAME = N'C:\Databasez\Платная поликлиника.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Платная поликлиника_log', FILENAME = N'C:\Databasez\Платная поликлиника_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Платная поликлиника] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Платная поликлиника].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Платная поликлиника] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Платная поликлиника] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Платная поликлиника] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Платная поликлиника] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Платная поликлиника] SET ARITHABORT OFF 
GO
ALTER DATABASE [Платная поликлиника] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Платная поликлиника] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Платная поликлиника] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Платная поликлиника] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Платная поликлиника] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Платная поликлиника] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Платная поликлиника] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Платная поликлиника] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Платная поликлиника] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Платная поликлиника] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Платная поликлиника] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Платная поликлиника] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Платная поликлиника] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Платная поликлиника] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Платная поликлиника] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Платная поликлиника] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Платная поликлиника] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Платная поликлиника] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Платная поликлиника] SET  MULTI_USER 
GO
ALTER DATABASE [Платная поликлиника] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Платная поликлиника] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Платная поликлиника] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Платная поликлиника] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Платная поликлиника] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Платная поликлиника] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Платная поликлиника] SET QUERY_STORE = ON
GO
ALTER DATABASE [Платная поликлиника] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Платная поликлиника]
GO
/****** Object:  Table [dbo].[register]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[login_user] [nvarchar](50) NOT NULL,
	[password_user] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Врач]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Врач](
	[Код врача] [bigint] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nchar](10) NOT NULL,
	[Имя] [nchar](10) NOT NULL,
	[Отчество] [nchar](10) NULL,
	[Код специальности] [bigint] NOT NULL,
	[Код уровня квалификации] [bigint] NOT NULL,
 CONSTRAINT [PK_Врач] PRIMARY KEY CLUSTERED 
(
	[Код врача] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Консультация]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Консультация](
	[Код консультации] [bigint] NOT NULL,
	[Код врача] [bigint] NOT NULL,
	[Код пациента] [bigint] NOT NULL,
	[Дата и время консультации] [datetime] NOT NULL,
	[Отметка о проведении] [bit] NOT NULL,
 CONSTRAINT [PK_Консультация] PRIMARY KEY CLUSTERED 
(
	[Код консультации] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Пациент]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пациент](
	[Код пациента] [bigint] IDENTITY(1,1) NOT NULL,
	[Фамилия] [varchar](30) NOT NULL,
	[Имя] [varchar](30) NOT NULL,
	[Отчество] [varchar](30) NULL,
	[Адрес] [varchar](150) NOT NULL,
	[Телефон] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK_Пациент] PRIMARY KEY CLUSTERED 
(
	[Код пациента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Специальность]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Специальность](
	[Код специальности] [bigint] IDENTITY(1,1) NOT NULL,
	[Наименования специальности] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Специальность] PRIMARY KEY CLUSTERED 
(
	[Код специальности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Уровень квалификации]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Уровень квалификации](
	[Код уровня квалификации] [bigint] IDENTITY(1,1) NOT NULL,
	[Наименование уровня квалификации] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Уровень квалификации] PRIMARY KEY CLUSTERED 
(
	[Код уровня квалификации] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Цена услуги]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Цена услуги](
	[Код специальности] [bigint] NOT NULL,
	[Код уровня квалификации] [bigint] NOT NULL,
	[Цена] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_Цена услуги] PRIMARY KEY CLUSTERED 
(
	[Код специальности] ASC,
	[Код уровня квалификации] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Консультация] ADD  CONSTRAINT [DF_Консультация_Признак факта проведения]  DEFAULT ((0)) FOR [Отметка о проведении]
GO
ALTER TABLE [dbo].[Врач]  WITH CHECK ADD  CONSTRAINT [FK_Врач_Специальность] FOREIGN KEY([Код специальности])
REFERENCES [dbo].[Специальность] ([Код специальности])
GO
ALTER TABLE [dbo].[Врач] CHECK CONSTRAINT [FK_Врач_Специальность]
GO
ALTER TABLE [dbo].[Врач]  WITH CHECK ADD  CONSTRAINT [FK_Врач_Уровень квалификации1] FOREIGN KEY([Код уровня квалификации])
REFERENCES [dbo].[Уровень квалификации] ([Код уровня квалификации])
GO
ALTER TABLE [dbo].[Врач] CHECK CONSTRAINT [FK_Врач_Уровень квалификации1]
GO
ALTER TABLE [dbo].[Консультация]  WITH CHECK ADD  CONSTRAINT [FK_Консультация_Врач] FOREIGN KEY([Код врача])
REFERENCES [dbo].[Врач] ([Код врача])
GO
ALTER TABLE [dbo].[Консультация] CHECK CONSTRAINT [FK_Консультация_Врач]
GO
ALTER TABLE [dbo].[Консультация]  WITH CHECK ADD  CONSTRAINT [FK_Консультация_Пациент] FOREIGN KEY([Код пациента])
REFERENCES [dbo].[Пациент] ([Код пациента])
GO
ALTER TABLE [dbo].[Консультация] CHECK CONSTRAINT [FK_Консультация_Пациент]
GO
ALTER TABLE [dbo].[Цена услуги]  WITH CHECK ADD  CONSTRAINT [FK_Цена услуги_Специальность] FOREIGN KEY([Код специальности])
REFERENCES [dbo].[Специальность] ([Код специальности])
GO
ALTER TABLE [dbo].[Цена услуги] CHECK CONSTRAINT [FK_Цена услуги_Специальность]
GO
ALTER TABLE [dbo].[Цена услуги]  WITH CHECK ADD  CONSTRAINT [FK_Цена услуги_Уровень квалификации] FOREIGN KEY([Код уровня квалификации])
REFERENCES [dbo].[Уровень квалификации] ([Код уровня квалификации])
GO
ALTER TABLE [dbo].[Цена услуги] CHECK CONSTRAINT [FK_Цена услуги_Уровень квалификации]
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery]
AS
	SET NOCOUNT ON;
SELECT dbo.Врач.[Код врача], dbo.Врач.Фамилия, dbo.Врач.Имя, dbo.Врач.Отчество, dbo.Специальность.[Наименования специальности], dbo.[Уровень квалификации].[Код уровня квалификации]

FROM (dbo.Врач INNER JOIN dbo.Специальность ON dbo.Врач.[Код специальности] = dbo.Специальность.[Код специальности]) INNER JOIN dbo.[Уровень квалификации] ON dbo.Врач.[Код уровня квалификации] = dbo.[Уровень квалификации].[Код уровня квалификации]

ORDER BY dbo.Врач.Фамилия, dbo.Врач.Имя, dbo.Врач.Отчество
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery1]    Script Date: Пт.14.04.2023 1:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery1]
AS
	SET NOCOUNT ON;
SELECT dbo.Пациент.[Код пациента], dbo.Пациент.Фамилия, dbo.Пациент.Имя, dbo.Пациент.Отчество, dbo.Пациент.Адрес, Count(*) AS [Количество консультаций]

FROM dbo.Пациент INNER JOIN dbo.Консультация ON dbo.Пациент.[Код пациента] = dbo.Консультация.[Код пациента]

GROUP BY dbo.Пациент.[Код пациента], dbo.Пациент.Фамилия, dbo.Пациент.Имя, dbo.Пациент.Отчество, dbo.Пациент.Адрес

ORDER BY dbo.Пациент.Фамилия, dbo.Пациент.Имя, dbo.Пациент.Отчество
GO
USE [master]
GO
ALTER DATABASE [Платная поликлиника] SET  READ_WRITE 
GO
