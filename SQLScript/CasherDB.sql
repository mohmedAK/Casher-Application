USE [master]
GO
/****** Object:  Database [CasherDB]    Script Date: 4/27/2020 6:04:43 PM ******/
CREATE DATABASE [CasherDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CasherDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CasherDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CasherDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CasherDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CasherDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CasherDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CasherDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CasherDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CasherDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CasherDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CasherDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CasherDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CasherDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CasherDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CasherDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CasherDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CasherDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CasherDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CasherDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CasherDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CasherDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CasherDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CasherDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CasherDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CasherDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CasherDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CasherDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CasherDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CasherDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CasherDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CasherDB] SET  MULTI_USER 
GO
ALTER DATABASE [CasherDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CasherDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CasherDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CasherDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CasherDB', N'ON'
GO
USE [CasherDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteAllSaleDetail]    Script Date: 4/27/2020 6:04:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_DeleteAllSaleDetail]
@SaleMasterID int
as 
begin

DELETE FROM [dbo].[SaleDetail]
      WHERE SaleMasterID = @SaleMasterID
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCategory]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_DeleteCategory]
@CategoryID int
as
Begin

DELETE FROM [dbo].[Category]
      WHERE CategoryID = @CategoryID


End



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteItemCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_DeleteItemCard]
@ItemID int
As 
Begin
DELETE FROM [dbo].[ItemCard]
      WHERE ItemID =@ItemID
End



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_DeleteSaleMaster]
		   @SaleMasterID int
          
		   as
		   begin

DELETE FROM [dbo].[SaleMaster]
 WHERE SaleMasterID =@SaleMasterID



End



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSingleSaleDetail]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_DeleteSingleSaleDetail]
@SaleDetailID int
as 
begin

DELETE FROM [dbo].[SaleDetail]
      WHERE SaleDetailID = @SaleDetailID
end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteUnitCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_DeleteUnitCard]
@UnitID int
as
begin



DELETE FROM [dbo].[UnitCard]
      WHERE UnitID =@UnitID



end



GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteUser]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_DeleteUser]
@UserID int

as
begin

DELETE FROM [dbo].[Users]
      WHERE UserID =@UserID






end



GO
/****** Object:  StoredProcedure [dbo].[SP_GetUserID]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_GetUserID]
@UserName NVARCHAR(50)

as
begin
SELECT [UserID]
     
  FROM [dbo].[Users]
  where UserName =@UserName 
end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCategory]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_InsertCategory]
@CategoryName NVARCHAR(50)
as
Begin

INSERT INTO [dbo].[Category]
           ([CategoryName])
     VALUES
           (@CategoryName)
End



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertItemCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_InsertItemCard]

	@Code nvarchar(50),
    @Name nvarchar(50),
    @Unit nvarchar(50),
    @Price float,
           @AddItem bit,
           @CategoryID int
as
begin

INSERT INTO [dbo].[ItemCard]
           ([Code]
           ,[Name]
           ,[Unit]
           ,[Price]
           ,[AddItem]
           ,[CategoryID])
     VALUES
           (@Code
           ,@Name
           ,@Unit
           ,@Price
           ,@AddItem
           ,@CategoryID)
end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSaleDetail]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_InsertSaleDetail]

@EntryDate date
           ,@Code nvarchar(50)
           ,@Name nvarchar(50)
           ,@Qty float
           ,@Unit nvarchar(50)
           ,@Price float
           ,@Total float
           ,@SaleMasterID int
as
begin

INSERT INTO [dbo].[SaleDetail]
           ([EntryDate]
           ,[Code]
           ,[Name]
           ,[Qty]
           ,[Unit]
           ,[Price]
           ,[Total]
           ,[SaleMasterID])
     VALUES
           (@EntryDate
           ,@Code
           ,@Name
           ,@Qty
           ,@Unit
           ,@Price
           ,@Total
           ,@SaleMasterID)



end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_InsertSaleMaster]
		   @SaleMasterID int,
           @EntryDate date,
           @Currency nvarchar(50),
           @QtyTotal float,
           @FinalTotal float,
           @UserName nvarchar(50)
		   as
		   begin
INSERT INTO [dbo].[SaleMaster]
           ([SaleMasterID]
           ,[EntryDate]
           ,[Currency]
           ,[QtyTotal]
           ,[FinalTotal]
           ,[UserName])
     VALUES
           (@SaleMasterID
           ,@EntryDate
           ,@Currency
           ,@QtyTotal
           ,@FinalTotal
           ,@UserName)
End



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertUnitCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_InsertUnitCard]
@UnitName nvarchar(50)
as
begin


INSERT INTO [dbo].[UnitCard]
           ([UnitName])
     VALUES
           (@UnitName )


end



GO
/****** Object:  StoredProcedure [dbo].[SP_InsertUser]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_InsertUser]
@UserName NVARCHAR(50),
@UserPassword NVARCHAR(max)
as
begin


INSERT INTO [dbo].[Users]
           ([UserName]
           ,[UserPassword])
     VALUES
           (@UserName
           ,@UserPassword)

end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllCategory]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SelectAllCategory]
as
Begin 
SELECT [CategoryID]
      ,[CategoryName]
  FROM [dbo].[Category]
End



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllItemCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_SelectAllItemCard]
as
begin
SELECT [ItemID]
      ,[Code]
      ,[Name]
      ,[Unit]
      ,[Price]
      ,[AddItem]
      ,[CategoryID]
  FROM [dbo].[ItemCard]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_SelectAllSaleMaster]
as
begin
SELECT [SaleMasterID]
      ,[EntryDate]
      ,[Currency]
      ,[QtyTotal]
      ,[FinalTotal]
      ,[UserName]
  FROM [dbo].[SaleMaster]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllUnitCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_SelectAllUnitCard]

as
begin
SELECT [UnitID]
      ,[UnitName]
  FROM [dbo].[UnitCard]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllUserEvents]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_SelectAllUserEvents]
as
begin

SELECT [EvintID]
      ,[EvintDate]
      ,[EventName]
      ,[SaleMasterID]
      ,[SaleDate]
      ,[FinalTotal]
      ,[UserName]
  FROM [dbo].[UserEvent]
End



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllUsers]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_SelectAllUsers]

as
begin
SELECT [UserID]
      ,[UserName]
      ,[UserPassword]
  FROM [dbo].[Users]
end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectSaleDetailByID]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_SelectSaleDetailByID]
@SaleMasterID int 
as
begin
SELECT [SaleDetailID]
      ,[EntryDate]
      ,[Code]
      ,[Name]
      ,[Qty]
      ,[Unit]
      ,[Price]
      ,[Total]
      ,[SaleMasterID]
  FROM [dbo].[SaleDetail]
  where SaleMasterID = @SaleMasterID
end



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectSaleView]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SP_SelectSaleView]
@SaleMasterID int
AS
 BEGIN

SELECT [EntryDate]
      ,[Code]
      ,[Name]
      ,[SaleDetailID]
      ,[Qty]
      ,[Unit]
      ,[Price]
      ,[Total]
      ,[SaleMasterID]
      ,[EntryDate1]
      ,[Currency]
      ,[QtyTotal]
      ,[FinalTotal]
      ,[UserName]
      ,[SaleMasterID1]
  FROM [dbo].[SaleView]

  WHERE SaleMasterID = @SaleMasterID
End



GO
/****** Object:  StoredProcedure [dbo].[SP_SelectUsersByUserAndPassword]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_SelectUsersByUserAndPassword]
@UserName NVARCHAR(50),
@UserPassword NVARCHAR(MAX)
as
begin
SELECT [UserID]
      ,[UserName]
      ,[UserPassword]
  FROM [dbo].[Users]
  where UserName =@UserName And UserPassword = @UserPassword
end



GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateItemCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_UpdateItemCard]
	@ItemID int,
	@Code nvarchar(50),
    @Name nvarchar(50),
    @Unit nvarchar(50),
    @Price float,
    @AddItem bit,
    @CategoryID int
as
Begin

UPDATE [dbo].[ItemCard]
   SET [Code] = @Code
      ,[Name] = @Name
      ,[Unit] = @Unit
      ,[Price] = @Price
      ,[AddItem] = @AddItem
      ,[CategoryID] = @CategoryID
 WHERE ItemID =@ItemID
End



GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SP_UpdateSaleMaster]
		   @SaleMasterID int,
           @EntryDate date,
           @Currency nvarchar(50),
           @QtyTotal float,
           @FinalTotal float,
           @UserName nvarchar(50)
		   as
		   begin

UPDATE [dbo].[SaleMaster]
   SET [SaleMasterID] = @SaleMasterID
      ,[EntryDate] =  @EntryDate
      ,[Currency] =  @Currency
      ,[QtyTotal] = @QtyTotal
      ,[FinalTotal] = @FinalTotal
      ,[UserName] = @UserName
 WHERE SaleMasterID =@SaleMasterID



End



GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateUser]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_UpdateUser]
@UserID int,
@UserName NVARCHAR(50),
@UserPassword NVARCHAR(max)
as
begin


UPDATE [dbo].[Users]
   SET [UserName] = @UserName
      ,[UserPassword] = @UserPassword
 WHERE UserID =@UserID




end



GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCard](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Unit] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[AddItem] [bit] NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_ItemCard] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleDetail]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetail](
	[SaleDetailID] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [date] NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Qty] [float] NULL,
	[Unit] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Total] [float] NULL,
	[SaleMasterID] [int] NULL,
 CONSTRAINT [PK_SaleDetail] PRIMARY KEY CLUSTERED 
(
	[SaleDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleMaster](
	[SaleMasterID] [int] NOT NULL,
	[EntryDate] [date] NULL,
	[Currency] [nvarchar](50) NULL,
	[QtyTotal] [float] NULL,
	[FinalTotal] [float] NULL,
	[UserName] [nvarchar](50) NULL,
 CONSTRAINT [PK_SaleMaster] PRIMARY KEY CLUSTERED 
(
	[SaleMasterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UnitCard]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitCard](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](50) NULL,
 CONSTRAINT [PK_UnitCard] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserEvent]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserEvent](
	[EvintID] [int] IDENTITY(1,1) NOT NULL,
	[EvintDate] [date] NULL,
	[EventName] [nvarchar](50) NULL,
	[SaleMasterID] [int] NULL,
	[SaleDate] [date] NULL,
	[FinalTotal] [float] NULL,
	[UserName] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserEvent] PRIMARY KEY CLUSTERED 
(
	[EvintID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPassword] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[SaleView]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SaleView]
AS
SELECT        dbo.SaleDetail.EntryDate, dbo.SaleDetail.Code, dbo.SaleDetail.Name, dbo.SaleDetail.SaleDetailID, dbo.SaleDetail.Qty, dbo.SaleDetail.Unit, dbo.SaleDetail.Price, dbo.SaleDetail.Total, dbo.SaleMaster.SaleMasterID, 
                         dbo.SaleMaster.EntryDate AS EntryDate1, dbo.SaleMaster.Currency, dbo.SaleMaster.QtyTotal, dbo.SaleMaster.FinalTotal, dbo.SaleMaster.UserName, dbo.SaleDetail.SaleMasterID AS SaleMasterID1
FROM            dbo.SaleDetail INNER JOIN
                         dbo.SaleMaster ON dbo.SaleDetail.SaleMasterID = dbo.SaleMaster.SaleMasterID

GO
ALTER TABLE [dbo].[SaleDetail]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetail_SaleMaster] FOREIGN KEY([SaleMasterID])
REFERENCES [dbo].[SaleMaster] ([SaleMasterID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SaleDetail] CHECK CONSTRAINT [FK_SaleDetail_SaleMaster]
GO
/****** Object:  Trigger [dbo].[TR_DeleteSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Trigger [dbo].[TR_DeleteSaleMaster]
On [dbo].[SaleMaster]

For DELETE

As

Begin

Declare @SaleMasterID int
Declare @EntryDate Date
Declare @FinalTotal float
Declare @UserName NVARCHAR(50)

select @SaleMasterID = Deleted.SaleMasterID , @EntryDate = Deleted.EntryDate ,@FinalTotal =Deleted.FinalTotal
,@UserName = Deleted.UserName from Deleted




INSERT dbo.UserEvent
        ( EvintDate ,
          EventName ,
          SaleMasterID ,
          SaleDate ,
          FinalTotal ,
          UserName
        )
VALUES  ( GETDATE() , -- EvintDate - date
          N'حذف' , -- EventName - nvarchar(50)
          @SaleMasterID , -- SaleMasterID - int
          @EntryDate , -- SaleDate - date
          @FinalTotal, -- FinalTotal - float
          @UserName  -- UserName - nvarchar(50)
        )



End
GO
/****** Object:  Trigger [dbo].[TR_InsertSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Trigger [dbo].[TR_InsertSaleMaster]
On [dbo].[SaleMaster]

For Insert

As

Begin

Declare @SaleMasterID int
Declare @EntryDate Date
Declare @FinalTotal float
Declare @UserName NVARCHAR(50)

select @SaleMasterID = Inserted.SaleMasterID , @EntryDate = inserted.EntryDate ,@FinalTotal =inserted.FinalTotal
,@UserName = inserted.UserName from Inserted




INSERT dbo.UserEvent
        ( EvintDate ,
          EventName ,
          SaleMasterID ,
          SaleDate ,
          FinalTotal ,
          UserName
        )
VALUES  ( GETDATE() , -- EvintDate - date
          N'جديد' , -- EventName - nvarchar(50)
          @SaleMasterID , -- SaleMasterID - int
          @EntryDate , -- SaleDate - date
          @FinalTotal, -- FinalTotal - float
          @UserName  -- UserName - nvarchar(50)
        )



End
GO
/****** Object:  Trigger [dbo].[TR_UpdateSaleMaster]    Script Date: 4/27/2020 6:04:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Trigger [dbo].[TR_UpdateSaleMaster]
On [dbo].[SaleMaster]

For Update

As

Begin

Declare @SaleMasterID int
Declare @EntryDate Date
Declare @FinalTotal float
Declare @UserName NVARCHAR(50)

select @SaleMasterID = Inserted.SaleMasterID , @EntryDate = inserted.EntryDate ,@FinalTotal =inserted.FinalTotal
,@UserName = inserted.UserName from Inserted




INSERT dbo.UserEvent
        ( EvintDate ,
          EventName ,
          SaleMasterID ,
          SaleDate ,
          FinalTotal ,
          UserName
        )
VALUES  ( GETDATE() , -- EvintDate - date
          N'تعديل' , -- EventName - nvarchar(50)
          @SaleMasterID , -- SaleMasterID - int
          @EntryDate , -- SaleDate - date
          @FinalTotal, -- FinalTotal - float
          @UserName  -- UserName - nvarchar(50)
        )



End
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[49] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SaleDetail"
            Begin Extent = 
               Top = 3
               Left = 474
               Bottom = 198
               Right = 644
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "SaleMaster"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 201
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SaleView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SaleView'
GO
USE [master]
GO
ALTER DATABASE [CasherDB] SET  READ_WRITE 
GO
