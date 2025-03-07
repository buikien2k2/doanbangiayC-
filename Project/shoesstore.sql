USE [master]
GO
/****** Object:  Database [shoestore]    Script Date: 19/02/2025 5:58:36 SA ******/
CREATE DATABASE [shoestore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shoestore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ACERKIENAI\MSSQL\DATA\shoestore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shoestore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ACERKIENAI\MSSQL\DATA\shoestore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [shoestore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shoestore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shoestore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [shoestore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [shoestore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [shoestore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [shoestore] SET ARITHABORT OFF 
GO
ALTER DATABASE [shoestore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [shoestore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shoestore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shoestore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shoestore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [shoestore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [shoestore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shoestore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [shoestore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shoestore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [shoestore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shoestore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shoestore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shoestore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shoestore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shoestore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shoestore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shoestore] SET RECOVERY FULL 
GO
ALTER DATABASE [shoestore] SET  MULTI_USER 
GO
ALTER DATABASE [shoestore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shoestore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shoestore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shoestore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [shoestore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [shoestore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'shoestore', N'ON'
GO
ALTER DATABASE [shoestore] SET QUERY_STORE = OFF
GO
USE [shoestore]
GO
/****** Object:  Table [dbo].[account]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[Username] [varchar](200) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[Createdate] [date] NOT NULL,
	[EmployeeID] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[CustomerID] [varchar](200) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Phone] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[EmployeeID] [varchar](200) NOT NULL,
	[EmployeeName] [nvarchar](200) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Gender] [bit] NOT NULL,
	[DateJoined] [date] NOT NULL,
	[Phone] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employeedetail]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employeedetail](
	[EmployeeID] [varchar](200) NULL,
	[Gmail] [varchar](200) NULL,
	[EmployeeAddress] [nvarchar](200) NULL,
	[EmployeeImage] [nvarchar](200) NULL,
	[EmployeePay] [int] NULL,
	[Office] [nvarchar](200) NULL,
	[Status] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[importnote]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[importnote](
	[ImportNoteID] [varchar](200) NOT NULL,
	[SupplierID] [varchar](200) NOT NULL,
	[ImportDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ImportNoteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[importnotedetail]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[importnotedetail](
	[ImportNoteID] [varchar](200) NOT NULL,
	[ProductID] [varchar](200) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[ProductAmount] [int] NOT NULL,
	[ImportPrice] [float] NOT NULL,
	[ImportQuantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipt]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[ReceiptID] [varchar](200) NOT NULL,
	[CustomerID] [varchar](200) NOT NULL,
	[EmployeeID] [varchar](200) NOT NULL,
	[ReceiptDate] [date] NOT NULL,
	[TotalMoney] [float] NOT NULL,
 CONSTRAINT [receipt_pk] PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receiptdetail]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receiptdetail](
	[ReceiptID] [varchar](200) NOT NULL,
	[ProductID] [varchar](200) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[ProductAmount] [int] NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[Money] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shoes]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shoes](
	[ProductID] [varchar](200) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[ProductType] [nvarchar](200) NOT NULL,
	[TypeGender] [bit] NOT NULL,
	[Img] [varchar](200) NULL,
	[Size] [int] NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[Brand] [nvarchar](100) NOT NULL,
	[ProductAmount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 19/02/2025 5:58:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[SupplierID] [varchar](200) NOT NULL,
	[SupplierName] [nvarchar](200) NOT NULL,
	[SupplierAdress] [nvarchar](200) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD  CONSTRAINT [employee_ibfk] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[account] CHECK CONSTRAINT [employee_ibfk]
GO
ALTER TABLE [dbo].[employeedetail]  WITH CHECK ADD  CONSTRAINT [employeedetail_ibfk] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[employee] ([EmployeeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[employeedetail] CHECK CONSTRAINT [employeedetail_ibfk]
GO
ALTER TABLE [dbo].[importnote]  WITH CHECK ADD  CONSTRAINT [Supplier_ibfk] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[importnote] CHECK CONSTRAINT [Supplier_ibfk]
GO
ALTER TABLE [dbo].[importnotedetail]  WITH CHECK ADD  CONSTRAINT [ImportNote_ibfk] FOREIGN KEY([ImportNoteID])
REFERENCES [dbo].[importnote] ([ImportNoteID])
GO
ALTER TABLE [dbo].[importnotedetail] CHECK CONSTRAINT [ImportNote_ibfk]
GO
ALTER TABLE [dbo].[importnotedetail]  WITH CHECK ADD  CONSTRAINT [product_idfk] FOREIGN KEY([ProductID])
REFERENCES [dbo].[shoes] ([ProductID])
GO
ALTER TABLE [dbo].[importnotedetail] CHECK CONSTRAINT [product_idfk]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [Customer_ibfk] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customer] ([CustomerID])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [Customer_ibfk]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [Employee_ibfk1] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [Employee_ibfk1]
GO
ALTER TABLE [dbo].[receiptdetail]  WITH CHECK ADD  CONSTRAINT [Receipt_ibfk] FOREIGN KEY([ReceiptID])
REFERENCES [dbo].[receipt] ([ReceiptID])
GO
ALTER TABLE [dbo].[receiptdetail] CHECK CONSTRAINT [Receipt_ibfk]
GO
ALTER TABLE [dbo].[receiptdetail]  WITH CHECK ADD  CONSTRAINT [Shoes_ibfk] FOREIGN KEY([ProductID])
REFERENCES [dbo].[shoes] ([ProductID])
GO
ALTER TABLE [dbo].[receiptdetail] CHECK CONSTRAINT [Shoes_ibfk]
GO
USE [master]
GO
ALTER DATABASE [shoestore] SET  READ_WRITE 
GO
