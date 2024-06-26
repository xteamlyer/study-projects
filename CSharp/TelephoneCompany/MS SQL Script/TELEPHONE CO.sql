USE [master]
GO
/****** Object:  Database [TelephoneCompany]    Script Date: Пт.14.04.2023 1:00:43 ******/
CREATE DATABASE [TelephoneCompany]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TelephoneCompany', FILENAME = N'C:\Databasez\TelephoneCompany.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TelephoneCompany_log', FILENAME = N'C:\Databasez\TelephoneCompany_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TelephoneCompany] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TelephoneCompany].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TelephoneCompany] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TelephoneCompany] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TelephoneCompany] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TelephoneCompany] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TelephoneCompany] SET ARITHABORT OFF 
GO
ALTER DATABASE [TelephoneCompany] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TelephoneCompany] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TelephoneCompany] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TelephoneCompany] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TelephoneCompany] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TelephoneCompany] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TelephoneCompany] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TelephoneCompany] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TelephoneCompany] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TelephoneCompany] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TelephoneCompany] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TelephoneCompany] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TelephoneCompany] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TelephoneCompany] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TelephoneCompany] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TelephoneCompany] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TelephoneCompany] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TelephoneCompany] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TelephoneCompany] SET  MULTI_USER 
GO
ALTER DATABASE [TelephoneCompany] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TelephoneCompany] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TelephoneCompany] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TelephoneCompany] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TelephoneCompany] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TelephoneCompany] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TelephoneCompany] SET QUERY_STORE = ON
GO
ALTER DATABASE [TelephoneCompany] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TelephoneCompany]
GO
/****** Object:  Table [dbo].[CallHistory]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CallHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[CallStart] [datetime] NOT NULL,
	[CallEnd] [datetime] NOT NULL,
	[PhoneNumber] [bigint] NOT NULL,
 CONSTRAINT [PK_CallHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PhoneNumber] [bigint] NOT NULL,
	[PlanID] [int] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[PaymentTime] [time](7) NOT NULL,
	[Amount] [money] NOT NULL,
	[PaymentMethod] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plans](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
	[InternetCount] [int] NOT NULL,
	[MinutesCount] [int] NOT NULL,
 CONSTRAINT [PK_Plans] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SMS]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SMS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SenderNumber] [varchar](50) NOT NULL,
	[RecipientsNumber] [varchar](50) NOT NULL,
	[SendDate] [date] NOT NULL,
	[SendTime] [time](7) NOT NULL,
	[Content] [text] NULL,
	[CostOfMessage] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[is_admin] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CallHistory]  WITH CHECK ADD  CONSTRAINT [FK_CallHistory_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[CallHistory] CHECK CONSTRAINT [FK_CallHistory_Clients]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Plans] FOREIGN KEY([PlanID])
REFERENCES [dbo].[Plans] ([ID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Plans]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Clients]
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery]
AS
	SET NOCOUNT ON;
SELECT dbo.CallHistory.[ID] as "Код звонка",
dbo.CallHistory.[ClientID] as "Код клиента", 
dbo.Clients.FullName as "ФИО клиента", 
dbo.CallHistory.CallStart as "Начало звонка",
dbo.CallHistory.CallEnd as "Конец звонка",
dbo.CallHistory.PhoneNumber as "Номер звонка"

FROM (dbo.CallHistory INNER JOIN dbo.Clients ON dbo.CallHistory.[ClientID] = dbo.Clients.[ID])

GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery1]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery1]
AS
	SET NOCOUNT ON;
SELECT        CallHistory.*
FROM            CallHistory
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery5]    Script Date: Пт.14.04.2023 1:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery5]
AS
	SET NOCOUNT ON;
SELECT dbo.Payments.[ID] as "Код платежа",
dbo.Payments.[ClientID] as "Код клиента", 
dbo.Clients.FullName as "ФИО клиента", 
dbo.Payments.PaymentDate as "Дата платежа",
dbo.Payments.PaymentTime as "Время платежа",
dbo.Payments.Amount as "Сумма платежа"

FROM (dbo.Payments INNER JOIN dbo.Clients ON dbo.Payments.[ClientID] = dbo.Clients.[ID])
GO
USE [master]
GO
ALTER DATABASE [TelephoneCompany] SET  READ_WRITE 
GO
