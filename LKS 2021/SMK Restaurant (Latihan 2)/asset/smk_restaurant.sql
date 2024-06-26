USE [master]
GO
/****** Object:  Database [SMK_Restaurant2]    Script Date: 16/08/2021 22:48:48 ******/
CREATE DATABASE [SMK_Restaurant2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMK_Restaurant2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.FANTHOM\MSSQL\DATA\SMK_Restaurant2.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMK_Restaurant2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.FANTHOM\MSSQL\DATA\SMK_Restaurant2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SMK_Restaurant2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMK_Restaurant2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMK_Restaurant2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMK_Restaurant2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMK_Restaurant2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMK_Restaurant2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMK_Restaurant2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET RECOVERY FULL 
GO
ALTER DATABASE [SMK_Restaurant2] SET  MULTI_USER 
GO
ALTER DATABASE [SMK_Restaurant2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMK_Restaurant2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMK_Restaurant2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMK_Restaurant2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMK_Restaurant2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SMK_Restaurant2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SMK_Restaurant2', N'ON'
GO
ALTER DATABASE [SMK_Restaurant2] SET QUERY_STORE = OFF
GO
USE [SMK_Restaurant2]
GO
/****** Object:  Table [dbo].[Income]    Script Date: 16/08/2021 22:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Income](
	[Month] [nvarchar](255) NULL,
	[Income] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsEmployee$]    Script Date: 16/08/2021 22:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsEmployee$](
	[Id] [char](6) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [char](128) NOT NULL,
	[Handphone] [varchar](13) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MsEmployee$] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsMember$]    Script Date: 16/08/2021 22:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsMember$](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Handphone] [varchar](13) NOT NULL,
	[JoinDate] [date] NOT NULL,
 CONSTRAINT [PK_MsMember$] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsMenu$]    Script Date: 16/08/2021 22:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsMenu$](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Photo] [nvarchar](100) NOT NULL,
	[Carbo] [int] NOT NULL,
	[Protein] [int] NOT NULL,
 CONSTRAINT [PK_MsMenu$] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail$]    Script Date: 16/08/2021 22:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail$](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [char](12) NOT NULL,
	[MenuId] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Status] [varchar](10) NOT NULL,
 CONSTRAINT [PK_OderDetail$] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderHeader$]    Script Date: 16/08/2021 22:48:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHeader$](
	[id] [char](12) NOT NULL,
	[EmployeeId] [char](6) NOT NULL,
	[MemberId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[PaymentType] [varchar](20) NOT NULL,
	[CardNumber] [varchar](16) NOT NULL,
	[Bank] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OrderHeader$] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Januari', 100)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Februari', 150)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Maret', 130)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'April', 140)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Mei', 120)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Juni', 110)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Juli', 160)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Agustus', 200)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'September', 155)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'Oktober', 180)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'November', 146)
INSERT [dbo].[Income] ([Month], [Income]) VALUES (N'December', 190)
GO
INSERT [dbo].[MsEmployee$] ([Id], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0001', N'Stanley Giovany', N'stanley.giovany@gmail.com', N'cashier                                                                                                                         ', N'081516171819', N'cashier')
INSERT [dbo].[MsEmployee$] ([Id], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0002', N'Grady Leif', N'grady.leif@gmail.com', N'cashier                                                                                                                         ', N'089901020304', N'chef')
INSERT [dbo].[MsEmployee$] ([Id], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0003', N'Hengky', N'hengky@gmail.com', N'admin                                                                                                                           ', N'089899010203', N'admin')
INSERT [dbo].[MsEmployee$] ([Id], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0004', N'admin', N'admin', N'admin                                                                                                                           ', N'123456789', N'admin')
INSERT [dbo].[MsEmployee$] ([Id], [Name], [Email], [Password], [Handphone], [Position]) VALUES (N'EM0005', N'cashier', N'cashier', N'cashier                                                                                                                         ', N'12345678', N'cashier')
GO
SET IDENTITY_INSERT [dbo].[MsMember$] ON 

INSERT [dbo].[MsMember$] ([Id], [Name], [Email], [Handphone], [JoinDate]) VALUES (1, N'Komala Surya
', N'komala.surya.w@gmail.com
', N'081219575859', CAST(N'2021-05-05' AS Date))
INSERT [dbo].[MsMember$] ([Id], [Name], [Email], [Handphone], [JoinDate]) VALUES (2, N'Riza Budi Prasetya
', N'riza.bp@gmail.com
', N'081213141516', CAST(N'2021-05-05' AS Date))
INSERT [dbo].[MsMember$] ([Id], [Name], [Email], [Handphone], [JoinDate]) VALUES (3, N'Lailul Rahmaniah
', N'lailul.rahmaniah@gmail.com
', N'081314151617', CAST(N'2021-05-05' AS Date))
INSERT [dbo].[MsMember$] ([Id], [Name], [Email], [Handphone], [JoinDate]) VALUES (4, N'admin', N'admin@gmail.com', N'123456', CAST(N'2021-07-24' AS Date))
INSERT [dbo].[MsMember$] ([Id], [Name], [Email], [Handphone], [JoinDate]) VALUES (8, N'cashier', N'cashier', N'123456789', CAST(N'2021-07-25' AS Date))
SET IDENTITY_INSERT [dbo].[MsMember$] OFF
GO
SET IDENTITY_INSERT [dbo].[MsMenu$] ON 

INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (1, N'Risotto', 50000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\risotto.jpeg', 150, 50)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (2, N'Lasagna', 55000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\lasagna.jpg', 150, 200)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (3, N'Mac and Cheese', 60000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\mac.jpg', 150, 75)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (4, N'French Ries', 20000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\french.jpg', 120, 70)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (5, N'Cheese Burger', 35000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\burger.jpeg', 170, 120)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (6, N'Iced Coffe', 18000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\coffee.jpg', 50, 80)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (7, N'Matcha Latte', 21000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\matcha.jpg', 75, 75)
INSERT [dbo].[MsMenu$] ([Id], [Name], [Price], [Photo], [Carbo], [Protein]) VALUES (8, N'Pepperozino Pizza', 50000, N'E:\hasil_program\Programming\Visual Basic .NET\Projeck\SMK Restaurant (Latihan 2)\image\pizza.jpg', 160, 100)
SET IDENTITY_INSERT [dbo].[MsMenu$] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail$] ON 

INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (1, N'202107250001', 3, 2, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (2, N'202107250001', 0, 0, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (3, N'202107250001', 4, 3, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (4, N'202107250001', 0, 0, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (10, N'202107250001', 4, 2, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (11, N'202107250001', 0, 0, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (12, N'202107250001', 1, 2, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (13, N'202107250001', 4, 1, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (14, N'202107250001', 0, 0, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (15, N'202107250001', 3, 2, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (16, N'202107250001', 0, 0, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (17, N'202107250001', 2, 2, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (18, N'202107250001', 4, 3, N'Unpaid')
INSERT [dbo].[OrderDetail$] ([Id], [OrderId], [MenuId], [Qty], [Status]) VALUES (19, N'202107250001', 0, 0, N'Unpaid')
SET IDENTITY_INSERT [dbo].[OrderDetail$] OFF
GO
INSERT [dbo].[OrderHeader$] ([id], [EmployeeId], [MemberId], [Date], [PaymentType], [CardNumber], [Bank]) VALUES (N'202107250001', N'EM0001', 1, CAST(N'2021-12-08' AS Date), N'credit', N'12354698456', N'BNI')
INSERT [dbo].[OrderHeader$] ([id], [EmployeeId], [MemberId], [Date], [PaymentType], [CardNumber], [Bank]) VALUES (N'202107250002', N'EM0001', 2, CAST(N'2021-05-04' AS Date), N'cash', N'0', N'0')
GO
ALTER TABLE [dbo].[OrderDetail$]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail$_OrderHeader$] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderHeader$] ([id])
GO
ALTER TABLE [dbo].[OrderDetail$] CHECK CONSTRAINT [FK_OrderDetail$_OrderHeader$]
GO
ALTER TABLE [dbo].[OrderHeader$]  WITH CHECK ADD  CONSTRAINT [FK_OrderHeader$_MsEmployee$] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[MsEmployee$] ([Id])
GO
ALTER TABLE [dbo].[OrderHeader$] CHECK CONSTRAINT [FK_OrderHeader$_MsEmployee$]
GO
ALTER TABLE [dbo].[OrderHeader$]  WITH CHECK ADD  CONSTRAINT [FK_OrderHeader$_MsMember$] FOREIGN KEY([MemberId])
REFERENCES [dbo].[MsMember$] ([Id])
GO
ALTER TABLE [dbo].[OrderHeader$] CHECK CONSTRAINT [FK_OrderHeader$_MsMember$]
GO
USE [master]
GO
ALTER DATABASE [SMK_Restaurant2] SET  READ_WRITE 
GO
