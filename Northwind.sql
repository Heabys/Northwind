USE [master]
GO
/****** Object:  Database [Northwind]    Script Date: 28/12/2017 11:54:48 ******/
CREATE DATABASE [Northwind]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Northwind', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Northwind.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Northwind_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Northwind_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Northwind] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Northwind].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Northwind] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Northwind] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Northwind] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Northwind] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Northwind] SET ARITHABORT OFF 
GO
ALTER DATABASE [Northwind] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Northwind] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Northwind] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Northwind] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Northwind] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Northwind] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Northwind] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Northwind] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Northwind] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Northwind] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Northwind] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Northwind] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Northwind] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Northwind] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Northwind] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Northwind] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Northwind] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Northwind] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Northwind] SET  MULTI_USER 
GO
ALTER DATABASE [Northwind] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Northwind] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Northwind] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Northwind] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Northwind] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Northwind]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerCustomDemo]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerCustomDemo](
	[CustomerID] [nchar](5) NOT NULL,
	[CustomerTypeID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CustomerCustomDemo] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[CustomerTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerDemographics]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerDemographics](
	[CustomerTypeID] [nchar](10) NOT NULL,
	[Customerdesc] [ntext] NULL,
 CONSTRAINT [PK_CustomerDemographics] PRIMARY KEY CLUSTERED 
(
	[CustomerTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [nchar](5) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[Title] [nvarchar](30) NULL,
	[TitleOfCourtesy] [nvarchar](25) NULL,
	[BirthDate] [datetime] NULL,
	[HireDate] [datetime] NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[HomePage] [nvarchar](24) NULL,
	[Extension] [nvarchar](4) NULL,
	[Photo] [image] NULL,
	[Notes] [ntext] NULL,
	[ReportsTo] [int] NULL,
	[PhotoPath] [nvarchar](250) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeTerritories]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTerritories](
	[EmployeeID] [int] NOT NULL,
	[TerritoryID] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[TerritoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[Discount] [real] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[CustomerID] [nchar](5) NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[RequiredDate] [datetime] NULL,
	[ShipperDate] [datetime] NULL,
	[ShipVia] [int] NULL,
	[Freight] [money] NULL,
	[ShipName] [nvarchar](40) NULL,
	[ShipAddress] [nvarchar](60) NULL,
	[ShipCity] [nvarchar](15) NULL,
	[ShipRegion] [nvarchar](15) NULL,
	[ShipPostalCode] [nvarchar](10) NULL,
	[ShipCountry] [nvarchar](15) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [nvarchar](20) NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [smallint] NULL,
	[UnitsOnOrder] [smallint] NULL,
	[ReorderLevel] [smallint] NULL,
	[Discontinued] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Region]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[RegionID] [int] NOT NULL,
	[RegionDescription] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[RegionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[ShipperID] [int] NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL,
	[HomePage] [ntext] NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Territories]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Territories](
	[TerritoryID] [nvarchar](20) NOT NULL,
	[TerritoryDescription] [nvarchar](50) NOT NULL,
	[RegionID] [int] NOT NULL,
 CONSTRAINT [PK_Territories] PRIMARY KEY CLUSTERED 
(
	[TerritoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CustomerCustomDemo]  WITH CHECK ADD  CONSTRAINT [FK_CustomerCustomDemo_CustomerDemographics] FOREIGN KEY([CustomerTypeID])
REFERENCES [dbo].[CustomerDemographics] ([CustomerTypeID])
GO
ALTER TABLE [dbo].[CustomerCustomDemo] CHECK CONSTRAINT [FK_CustomerCustomDemo_CustomerDemographics]
GO
ALTER TABLE [dbo].[CustomerCustomDemo]  WITH CHECK ADD  CONSTRAINT [FK_CustomerCustomDemo_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[CustomerCustomDemo] CHECK CONSTRAINT [FK_CustomerCustomDemo_Customers]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Employees] FOREIGN KEY([ReportsTo])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Employees]
GO
ALTER TABLE [dbo].[EmployeeTerritories]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTerritories_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeTerritories] CHECK CONSTRAINT [FK_EmployeeTerritories_Employees]
GO
ALTER TABLE [dbo].[EmployeeTerritories]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTerritories_Territories] FOREIGN KEY([TerritoryID])
REFERENCES [dbo].[Territories] ([TerritoryID])
GO
ALTER TABLE [dbo].[EmployeeTerritories] CHECK CONSTRAINT [FK_EmployeeTerritories_Territories]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Shippers] FOREIGN KEY([ShipVia])
REFERENCES [dbo].[Shippers] ([ShipperID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Shippers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [dbo].[Territories]  WITH CHECK ADD  CONSTRAINT [FK_Territories_Region] FOREIGN KEY([RegionID])
REFERENCES [dbo].[Region] ([RegionID])
GO
ALTER TABLE [dbo].[Territories] CHECK CONSTRAINT [FK_Territories_Region]
GO
/****** Object:  StoredProcedure [dbo].[Categories_Actualizar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categories_Actualizar](
	@xCategoryID int,
	@xCategoryName nvarchar(15),
	@xDescription text,
	@xPicture image
	)
AS
BEGIN
	set nocount on;
	UPDATE Categories set
		CategoryName=@xCategoryName,
		[Description]=@xDescription,
		Picture=@xPicture
	where CategoryID=@xCategoryID;
end
GO
/****** Object:  StoredProcedure [dbo].[Categories_Buscar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categories_Buscar](
	@xCategoryID int out,
	@xCategoryName	nvarchar(15),
	@xDescription	nvarchar(1000) out,
	@xPicture varbinary(max) out
	)
AS
BEGIN
	Select @xCategoryID=CategoryID,
		@xDescription=CAST([Description] as nvarchar(1000)),
		@xPicture= CAST(Picture as varbinary(max))
	From Categories
	WHERE CategoryName=@xCategoryName;
END

GO
/****** Object:  StoredProcedure [dbo].[Categories_Eliminar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categories_Eliminar]
	@xCategoryID int
AS
BEGIN
	SET NOCOUNT ON;
	Delete from Categories
	where CategoryID=@xCategoryID;
END

GO
/****** Object:  StoredProcedure [dbo].[Categories_Insertar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categories_Insertar](
	@xCategoryID int out,
	@xCategoryName nvarchar(15),
	@xDescription text,
	@xPicture image
	)
AS
BEGIN
	SET NOCOUNT ON;

	insert into Categories(CategoryName,[Description],Picture)
		values (@xCategoryName,@xDescription,@xPicture);

	SET @xCategoryID=@@IDENTITY;
END
GO
/****** Object:  StoredProcedure [dbo].[Employees_ReporteEmpleados]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Employees_ReporteEmpleados]
AS
BEGIN

	SELECT EmployeeID,
			LastName+', '+FirstName as Nombres,
			Title,
			DATEDIFF(year, hiredate, getdate()) AS Antiguedad,
			"Address"
	FROM Employees
	Order by Nombres;
END
GO
/****** Object:  StoredProcedure [dbo].[Products_Actualizar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_Actualizar](
	@xProductID int,
	@xProductName nvarchar(40),
	@xSupplierID int,
	@xCategoryID int,
	@xQuantityPerUnit nvarchar(20),
	@xUnitPrice money,
	@xUnitsInStock smallint,
	@xUnitsOnOrder smallint,
	@xReorderlevel smallint,
	@xDiscontinued bit
	)
AS
BEGIN
	UPDATE Products SET
		ProductName=@xProductName,SupplierID=@xSupplierID,CategoryID=@xCategoryID,
		QuantityPerUnit=@xQuantityPerUnit,UnitPrice=@xUnitPrice,UnitsInStock=@xUnitsInStock,
		UnitsOnOrder=@xUnitsOnOrder,ReorderLevel=@xReorderlevel,Discontinued=@xDiscontinued
	WHERE ProductID=@xProductID
END
GO
/****** Object:  StoredProcedure [dbo].[Products_Buscar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_Buscar](
	@xProductID int out,
	@xProductName nvarchar(40),
	@xSupplierID int out,
	@xCategoryID int out,
	@xQuantityPerUnit nvarchar(20) out,
	@xUnitPrice money out,
	@xUnitsInStock smallint out,
	@xUnitsOnOrder smallint out,
	@xReorderlevel smallint out,
	@xDiscontinued bit out
	)
AS
BEGIN
	SELECT @xProductID=ProductID,@xSupplierID=SupplierID,@xCategoryID=CategoryID,
		@xQuantityPerUnit=QuantityPerUnit,@xUnitPrice=@xUnitPrice,@xUnitsInStock=UnitsInStock,
		@xUnitsOnOrder=UnitsOnOrder,@xReorderlevel=ReorderLevel,@xDiscontinued=Discontinued
	FROM Products
	Where ProductName=@xProductName
END
GO
/****** Object:  StoredProcedure [dbo].[Products_Eliminar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_Eliminar](
	@xProductID int 
	)
AS
BEGIN
	DELETE FROM Products
	Where ProductID=@xProductID
END
GO
/****** Object:  StoredProcedure [dbo].[Products_Insertar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_Insertar](
	@xProductID int out,
	@xProductName nvarchar(40),
	@xSupplierID int,
	@xCategoryID int,
	@xQuantityPerUnit nvarchar(20),
	@xUnitPrice money,
	@xUnitsInStock smallint,
	@xUnitsOnOrder smallint,
	@xReorderlevel smallint,
	@xDiscontinued bit
	)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,
							UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)
		VALUES (@xProductName,@xSupplierID,@xCategoryID,@xQuantityPerUnit,@xUnitPrice,
				@xUnitsInStock,@xUnitsOnOrder,@xReorderlevel,@xDiscontinued);

	SET @xProductID=@@IDENTITY;
END;

GO
/****** Object:  StoredProcedure [dbo].[Shippers_Actualizar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Shippers_Actualizar](
	@xShipperID int,
	@xCompanyName nvarchar(40),
	@xPhone nvarchar(24)
	)
AS
BEGIN
	SET NOCOUNT ON;

	update Shippers Set
		CompanyName=@xCompanyName,
		Phone=@xPhone
	where ShipperID=@xShipperID
END

GO
/****** Object:  StoredProcedure [dbo].[Shippers_Eliminar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Shippers_Eliminar](
	@xShipperID int
	)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE Shippers
	WHERE ShipperID=@xShipperID
END

GO
/****** Object:  StoredProcedure [dbo].[Shippers_Insertar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Shippers_Insertar](
	@xShipperID int out,
	@xCompanyName nvarchar(40),
	@xPhone nvarchar(24)
	)
AS
BEGIN
	SET NOCOUNT ON;

	insert into Shippers(CompanyName,Phone)
		values (@xCompanyName,@xPhone);

	set @xShipperID=@@IDENTITY;
END

GO
/****** Object:  StoredProcedure [dbo].[Suppliers_Actualizar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Suppliers_Actualizar](
	@xSupplierID int ,
	@xCompanyName	nvarchar(40),
	@xContactName	nvarchar(30),
	@xContactTitle	nvarchar(30),
	@xAddress		nvarchar(60),
	@xCity			nvarchar(15),
	@xRegion		nvarchar(15),
	@xPostalCode	nvarchar(10),
	@xCountry		nvarchar(15),
	@xPhone			nvarchar(24),
	@xFax			nvarchar(24),
	@xHomePage		ntext
	)
AS
Begin
	UPDATE Suppliers SET
		CompanyName=@xCompanyName,
		ContactName=@xContactName,
		ContactTitle=@xContactTitle,
		[Address]=@xAddress,
		City=@xCity,
		Region=@xRegion,
		PostalCode=@xPostalCode,
		Country=@xCountry,
		Phone=@xPhone,
		Fax=@xFax,
		HomePage=@xHomePage
	WHERE SupplierID=@xSupplierID;
end
GO
/****** Object:  StoredProcedure [dbo].[Suppliers_Buscar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Suppliers_Buscar](
	@xSupplierID int out,
	@xCompanyName	nvarchar(40),
	@xContactName	nvarchar(30) out,
	@xContactTitle	nvarchar(30) out,
	@xAddress		nvarchar(60) out,
	@xCity			nvarchar(15) out,
	@xRegion		nvarchar(15) out,
	@xPostalCode	nvarchar(10) out,
	@xCountry		nvarchar(15) out,
	@xPhone			nvarchar(24) out,
	@xFax			nvarchar(24) out,
	@xHomePage		nvarchar(200) out
	)
AS
BEGIN
	SELECT @xSupplierID=SupplierID,
		@xCompanyName=CompanyName,
		@xContactName=ContactName,
		@xContactTitle=ContactTitle,
		@xAddress="Address",
		@xCity=City,
		@xRegion=Region,
		@xPostalCode=PostalCode,
		@xCountry=Country,
		@xFax=Fax,
		@xHomePage=CAST([HomePage] as nvarchar(200))
	FROM Suppliers
	Where CompanyName=@xCompanyName;
END
GO
/****** Object:  StoredProcedure [dbo].[Suppliers_Eliminar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Suppliers_Eliminar](
	@xSupplierID int
	)
AS
Begin
	DELETE FROM Suppliers
	WHERE SupplierID=@xSupplierID;
END
GO
/****** Object:  StoredProcedure [dbo].[Suppliers_Insertar]    Script Date: 28/12/2017 11:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Suppliers_Insertar](
	@xSupplierID int out,
	@xCompanyName	nvarchar(40),
	@xContactName	nvarchar(30),
	@xContactTitle	nvarchar(30),
	@xAddress		nvarchar(60),
	@xCity			nvarchar(15),
	@xRegion		nvarchar(15),
	@xPostalCode	nvarchar(10),
	@xCountry		nvarchar(15),
	@xPhone			nvarchar(24),
	@xFax			nvarchar(24),
	@xHomePage		ntext
	)
AS
Begin
	insert into Suppliers(CompanyName,ContactName,ContactTitle,"Address",
		City,Region,PostalCode,Country,Phone,Fax,HomePage)
		values
		(@xCompanyName,@xContactName,@xContactTitle,@xAddress,@xCity,
		@xRegion,@xPostalCode,@xCountry,@xPhone,@xFax,@xHomePage);

		set @xSupplierID=@@IDENTITY;
		end
GO
USE [master]
GO
ALTER DATABASE [Northwind] SET  READ_WRITE 
GO
