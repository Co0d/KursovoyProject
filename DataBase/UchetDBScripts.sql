USE [master]
GO
/****** Object:  Database [UchetBase]    Script Date: 25.04.2023 5:04:00 ******/
CREATE DATABASE [UchetBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UchetBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UchetBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UchetBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UchetBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UchetBase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UchetBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UchetBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UchetBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UchetBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UchetBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UchetBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [UchetBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UchetBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UchetBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UchetBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UchetBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UchetBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UchetBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UchetBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UchetBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UchetBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UchetBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UchetBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UchetBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UchetBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UchetBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UchetBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UchetBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UchetBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UchetBase] SET  MULTI_USER 
GO
ALTER DATABASE [UchetBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UchetBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UchetBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UchetBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UchetBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UchetBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UchetBase] SET QUERY_STORE = OFF
GO
USE [UchetBase]
GO
/****** Object:  Table [dbo].[DocumentEducation]    Script Date: 25.04.2023 5:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentEducation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[Institute] [nvarchar](50) NOT NULL,
	[Education] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DocumentEducation_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 25.04.2023 5:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Post] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LD]    Script Date: 25.04.2023 5:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LD](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[WorkExperience] [nvarchar](50) NOT NULL,
	[Education] [nvarchar](50) NOT NULL,
	[Profession] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LD_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passport]    Script Date: 25.04.2023 5:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[Series] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Passport_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statement]    Script Date: 25.04.2023 5:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statement](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[Cash] [nvarchar](50) NOT NULL,
	[DayWork] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Statement_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 25.04.2023 5:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Post] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DocumentEducation] ON 

INSERT [dbo].[DocumentEducation] ([id], [FirstName], [Name], [MiddleName], [Institute], [Education]) VALUES (1, N'Иконников', N'Артем', N'Олегович', N'ВГЭК', N'Среднее профессиональное')
INSERT [dbo].[DocumentEducation] ([id], [FirstName], [Name], [MiddleName], [Institute], [Education]) VALUES (3, N'Родин', N'Олег', N'Альбертович', N'ВГЭК', N'Среднее профессиональное')
INSERT [dbo].[DocumentEducation] ([id], [FirstName], [Name], [MiddleName], [Institute], [Education]) VALUES (4, N'Оскретков', N'Данил', N'Витальевич', N'ВГЭК', N'Среднее профессиональное')
SET IDENTITY_INSERT [dbo].[DocumentEducation] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([id], [FirstName], [Name], [MiddleName], [DateOfBirth], [Post]) VALUES (1, N'Иконников', N'Артем', N'Олегович', CAST(N'2004-05-24' AS Date), N'Программист')
INSERT [dbo].[Employee] ([id], [FirstName], [Name], [MiddleName], [DateOfBirth], [Post]) VALUES (2, N'Родин', N'Олег', N'Альбертович', CAST(N'2004-09-22' AS Date), N'Программист')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[LD] ON 

INSERT [dbo].[LD] ([id], [FirstName], [Name], [MiddleName], [WorkExperience], [Education], [Profession]) VALUES (1, N'Иконников', N'Артем', N'Олегович', N'4', N'Среднее профессиональное', N'Программист')
INSERT [dbo].[LD] ([id], [FirstName], [Name], [MiddleName], [WorkExperience], [Education], [Profession]) VALUES (3, N'Родин', N'Олег', N'Альбертович', N'4', N'Среднее профессиональное', N'Программист')
SET IDENTITY_INSERT [dbo].[LD] OFF
GO
SET IDENTITY_INSERT [dbo].[Passport] ON 

INSERT [dbo].[Passport] ([id], [Number], [Series], [FirstName], [Name], [MiddleName]) VALUES (1, N'8888', N'8888', N'Иконников', N'Артем', N'Олегович')
INSERT [dbo].[Passport] ([id], [Number], [Series], [FirstName], [Name], [MiddleName]) VALUES (2, N'9999', N'9999', N'Родин', N'Олег', N'Альбертович')
INSERT [dbo].[Passport] ([id], [Number], [Series], [FirstName], [Name], [MiddleName]) VALUES (4, N'4444', N'4444', N'Оскретков', N'Данил', N'Витальевич')
SET IDENTITY_INSERT [dbo].[Passport] OFF
GO
SET IDENTITY_INSERT [dbo].[Statement] ON 

INSERT [dbo].[Statement] ([id], [FirstName], [Name], [MiddleName], [Cash], [DayWork]) VALUES (1, N'Иконников', N'Артем', N'Олегович', N'60000', N'28')
INSERT [dbo].[Statement] ([id], [FirstName], [Name], [MiddleName], [Cash], [DayWork]) VALUES (2, N'Родин', N'Олег', N'Альбертович', N'62000', N'29')
INSERT [dbo].[Statement] ([id], [FirstName], [Name], [MiddleName], [Cash], [DayWork]) VALUES (3, N'Оскретков', N'Данил', N'Витальевич', N'55000', N'25')
SET IDENTITY_INSERT [dbo].[Statement] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [Login], [Password], [Post]) VALUES (1, N'admin', N'admin', N'Administrator')
INSERT [dbo].[User] ([id], [Login], [Password], [Post]) VALUES (2, N'artem', N'ikonnikov', N'User')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
USE [master]
GO
ALTER DATABASE [UchetBase] SET  READ_WRITE 
GO
