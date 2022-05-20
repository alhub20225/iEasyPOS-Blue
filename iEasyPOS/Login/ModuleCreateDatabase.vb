Imports System.Data.SqlClient
Imports System.Configuration
Module ModuleCreateDatabase
    Sub btnAdd()
        Dim str As String
        Dim server As String = FrmCreateDataBase2.txt_servername.Text
        Dim Username As String = FrmCreateDataBase2.TxtUserName.Text
        Dim Password As String = FrmCreateDataBase2.TxtPassword.Text
        Dim db As String = FrmCreateDataBase2.txt_database.Text
        Dim myConn As SqlConnection = New SqlConnection("Server='" & server & "';Database=master;User Id='" & Username & "';Password='" & Password & "'")
		str = "USE [master] CREATE DATABASE [" & db & "] 
			ALTER DATABASE [" & db & "]  
            COLLATE Thai_CI_AS; "
		Dim myCommand As SqlCommand = New SqlCommand(str, myConn)
        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            'MessageBox.Show("Database is created successfully","MyProgram", MessageBoxButtons.OK,MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try
        Dim myConn2 As SqlConnection = New SqlConnection("Server=" & server & ";Database=" & db & ";User Id='" & Username & "';Password='" & Password & "'")
        Dim SqlConnStr As String = "Server='" & server & "';Database='" & db & "';User Id='" & Username & "';Password='" & Password & "'"
        'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        'config.ConnectionStrings.ConnectionStrings.Clear()
        'config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("localhost_Connection", String.Format(SqlConnStr)))
        'config.Save(ConfigurationSaveMode.Modified, True)
        'ConfigurationManager.RefreshSection("connectionStrings")
        str = "USE [" & db & "]


/****** Object:  Table [dbo].[Authority]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Authority](
	[AuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorityNameTH] [nvarchar](250) NULL,
	[AuthorityNameENG] [nvarchar](250) NULL,
	[AuthorityType] [nvarchar](250) NULL,
 CONSTRAINT [PK_Authority] PRIMARY KEY CLUSTERED 
(
	[AuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[AuthorityRoles]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[AuthorityRoles](
	[AuthorityRolesId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[AuthorityId] [int] NOT NULL,
	[Active_role] [smallint] NULL,
 CONSTRAINT [PK_AuthorityRoles_AuthorityRolesId] PRIMARY KEY CLUSTERED 
(
	[AuthorityRolesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CardDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[TIDs] [nvarchar](50) NULL,
	[MIDs] [nvarchar](50) NULL,
	[VisaType] [nvarchar](50) NULL,
	[Batch] [nvarchar](50) NULL,
	[CradId] [nvarchar](50) NULL,
	[APPRCode] [nvarchar](50) NULL,
	[RefNo] [nvarchar](50) NULL,
	[CardName] [nvarchar](50) NULL, 
	[Trace] [nvarchar](50) NULL,
	[SaleNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_CradDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Bank]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Bank](
	[BankId] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](100) NULL,
	[Image] [nvarchar](max) NULL,
	[Active] [int] NULL,
	[test] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bank_BankId] PRIMARY KEY CLUSTERED 
(
	[BankId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[BankCardType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[BankCardType](
	[BankCardTypeId] [int] IDENTITY(1,1) NOT NULL,
	[BankCardTypeName] [nvarchar](100) NULL,
	[Image] [nvarchar](max) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_BankCardType_BankCardTypeId] PRIMARY KEY CLUSTERED 
(
	[BankCardTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[Branch]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Branch](
	[BranchId] [int] IDENTITY(1,1) NOT NULL,
	[BranchCode] [nvarchar](50) NOT NULL,
	[BranchName] [nvarchar](50) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[Active] [int] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Address2] [nvarchar](50) NOT NULL,
	[Provinces] [nvarchar](50) NOT NULL,
	[country] [nvarchar](50) NOT NULL,
	[ZipCode] [nvarchar](50) NOT NULL,
	[TaxId] [nvarchar](50) NOT NULL,
	[Fax] [nvarchar](50) NOT NULL,
	[InsertDate] [datetime2](0) NOT NULL,
	[UpdateDate] [datetime2](0) NOT NULL,
	[BranchOrder] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
    [Emails] [text] NULL,
    [HqBranchId] [int] NOT NULL DEFAULT(0),
 CONSTRAINT [PK_Branch_BranchId] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[CancelSaleItem]    Script Date: 26/11/2561 17:29:27 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[CancelSaleItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleItemId] [int] NULL,
	[ItemCode] [nvarchar](50) NULL,
	[ItemName] [nvarchar](100) NULL,
	[Qty] [decimal](18, 2) NULL,
	[InitPrice] [decimal](26, 6) NULL,
	[UnitPrice] [decimal](26, 6) NULL,
	[Total] [decimal](26, 6) NULL,
	[SubTotal] [decimal](26, 6) NULL,
	[Tax] [decimal](26, 6) NULL,
	[TableId] [int] NULL,
	[TerminalName] [nvarchar](100) NULL,
	[AllowPrint] [bit] NULL,
	[PrinterName] [nvarchar](100) NULL,
	[StatusPrint] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CancelSaleItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Breaks]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Breaks](
	[BreakId] [int] IDENTITY(1,1) NOT NULL,
	[BreakName] [nvarchar](50) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_Breaks_BreakId] PRIMARY KEY CLUSTERED 
(
	[BreakId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CardType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CardType](
	[CardTypeId] [int] IDENTITY(1,1) NOT NULL,
	[CardTypeName] [nvarchar](100) NOT NULL,
	[Charge] [decimal](29, 6) NOT NULL,
	[MoreMoney] [decimal](29, 6) NOT NULL,
	[Discount] [decimal](29, 6) NOT NULL,
	[BankId] [int] NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_CardType_CardTypeId] PRIMARY KEY CLUSTERED 
(
	[CardTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryGroup]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryGroup](
	[CateGroupId] [int] IDENTITY(1,1) NOT NULL,
	[CateGroupName] [nvarchar](50) NULL,
	[CateGroupNameTH] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_CategoryGroup_CateGroupId] PRIMARY KEY CLUSTERED 
(
	[CateGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryItem](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[CategoryName2] [nvarchar](100) NULL,
	[CateCode] [nvarchar](50) NULL,
	[NumberItemCode] [int] NULL,
	[Active] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[Updatedate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[DeleteDate] [datetime2](0) NULL,
	[DeleteUserId] [int] NULL,
	[CateGroupId] [int] NULL,
	[ItemTypeId] [int] NULL,
	[CatePrinterName] [nvarchar](100) NULL,
	[BackGroundButton] [int] NULL,
	[PathImage] [nvarchar](255) NULL,
	[FontColor] [int] NULL,
	[ImageBase64] [nvarchar](max) NULL,
	[ImageTextBase64] [nvarchar](max) NULL,
	[AllowPrint] [int] NULL,
	[CategoryGroupItemId] [int] NULL,
 CONSTRAINT [PK_CategoryItem_CategoryId] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryItemLevel2]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryItemLevel2](
	[CategoryLevel2Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CategoryLevel2NameTH] [nvarchar](100) NOT NULL,
	[CategoryLevel2NameEN] [nvarchar](100) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_CategoryItemLevel2_CategoryLevel2Id] PRIMARY KEY CLUSTERED 
(
	[CategoryLevel2Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryItemLevel3]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryItemLevel3](
	[CategoryLevel3Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryLevel2Id] [int] NOT NULL,
	[CategoryLevel3NameTH] [nvarchar](100) NOT NULL,
	[CategoryLevel3NameEN] [nvarchar](100) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_CategoryItemLevel3_CategoryLevel3Id] PRIMARY KEY CLUSTERED 
(
	[CategoryLevel3Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryItemLevel4]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryItemLevel4](
	[CategoryLevel4Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryLevel3Id] [int] NOT NULL,
	[CategoryLevel4NameTH] [nvarchar](100) NOT NULL,
	[CategoryLevel4NameEN] [nvarchar](100) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_CategoryItemLevel4_CategoryLevel4Id] PRIMARY KEY CLUSTERED 
(
	[CategoryLevel4Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryPakgeItems]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryPakgeItems](
	[CategoryPakgeId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryGroup] [int] NOT NULL,
	[CategoryPakgeName] [nvarchar](100) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_CategoryPakgeItems_CategoryPakgeId] PRIMARY KEY CLUSTERED 
(
	[CategoryPakgeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategorySelection]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategorySelection](
	[CategorySelectionId] [int] IDENTITY(1,1) NOT NULL,
	[CategorySelectionName] [nvarchar](100) NULL,
	[CategorySelectionName2] [nvarchar](100) NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[DeleteDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CategorySelection_CategorySelectionId] PRIMARY KEY CLUSTERED 
(
	[CategorySelectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CategoryTopping]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CategoryTopping](
	[CategoryToppingId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryToppingName] [nvarchar](100) NULL,
	[CategoryToppingName2] [nvarchar](100) NULL,
	[CateToppingCode] [nvarchar](50) NULL,
	[NumberToppingCode] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[DeleteDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[PrinterName] [nvarchar](150) NULL,
 CONSTRAINT [PK_CategoryTopping_CategoryToppingId] PRIMARY KEY CLUSTERED 
(
	[CategoryToppingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Chairs]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[Chairs](
	[ChairId] [int] IDENTITY(1,1) NOT NULL,
	[ChairName] [nvarchar](50) NOT NULL,
	[TableId] [int] NOT NULL,
	[Active] [binary](1) NOT NULL,
	[InsertDate] [datetime2](0) NOT NULL,
	[UpdateDate] [datetime2](0) NOT NULL,
	[DeleteDate] [datetime2](0) NOT NULL,
	[UserId] [int] NOT NULL,
	[DeleteUserId] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Chairs_ChairId] PRIMARY KEY CLUSTERED 
(
	[ChairId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[ChoiceReceipe]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ChoiceReceipe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChoiceId] [int] NOT NULL,
	[MatId] [int] NOT NULL,
	[Qty] [decimal](29, 6) NOT NULL,
	[MatInitCost] [decimal](29, 6) NOT NULL,
	[MatUnitCost] [decimal](29, 6) NOT NULL,
	[TotalInitCost] [decimal](29, 6) NOT NULL,
	[TotalCost] [decimal](29, 6) NOT NULL,
 CONSTRAINT [PK_ChoiceReceipe_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ConditionPromotion]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ConditionPromotion](
	[ConId] [int] IDENTITY(1,1) NOT NULL,
	[ConPrice] [decimal](29, 6) NULL,
	[ConAmount] [decimal](29, 6) NULL,
	[ConTimeStart] [nvarchar](50) NULL,
	[ConTimeEnd] [nvarchar](50) NULL,
	[ConDateStart] [date] NULL,
	[ConDateEnd] [date] NULL,
	[GiftId] [int] NULL,
	[AlertAmount] [decimal](29, 6) NULL,
	[AlertPrice] [decimal](29, 6) NULL,
 CONSTRAINT [PK_ConditionPromotion] PRIMARY KEY CLUSTERED 
(
	[ConId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Costing]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[Costing](
	[CostId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[TaxId] [varchar](50) NULL,
	[InitCost] [decimal](29, 6) NULL,
	[UnitCost] [decimal](29, 6) NULL,
	[SupplierId] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[IsDefault] [int] NULL,
	[IsInCludeTax] [int] NULL,
	[LastInitCost] [decimal](29, 6) NULL,
	[LastUnitCost] [decimal](29, 6) NULL,
	[AvgCost] [decimal](29, 6) NULL,
	[AvgUnitCost] [decimal](29, 6) NULL,
 CONSTRAINT [PK_Costing_CostId] PRIMARY KEY CLUSTERED 
(
	[CostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[Countries]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Countries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryNameTH] [nvarchar](150) NOT NULL,
	[CountryNameENG] [nvarchar](150) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_Countries_CountryId] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Coupon]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Coupon](
	[CouponId] [int] IDENTITY(1,1) NOT NULL,
	[CouponNumber] [nvarchar](100) NULL,
	[CouponPrice] [decimal](29, 6) NULL,
	[CouponBalance] [decimal](29, 6) NULL,
	[ExpDate] [datetime] NULL,
	[InsertDate] [datetime] NULL,
	[DeleteDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[UserId] [int] NULL,
	[Active] [int] NULL,
	[StatusId] [bit] NULL,
 CONSTRAINT [PK_Coupon_CouponId] PRIMARY KEY CLUSTERED 
(
	[CouponId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CustAddress]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CustAddress](
	[AddrId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[CountryId] [int] NULL,
	[DistrictId] [int] NULL,
	[SubDistrict] [nvarchar](100) NULL,
	[ProvinceId] [int] NULL,
	[Zipcode] [nvarchar](100) NULL,
	[MobilePhone] [nvarchar](100) NULL,
	[TelePhone] [nvarchar](100) NULL,
	[Fax] [nvarchar](100) NULL,
 CONSTRAINT [PK_CustAddress_AddrId] PRIMARY KEY CLUSTERED 
(
	[AddrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Customer]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[MemberNo] [nvarchar](50) NULL,
	[Title] [int] NULL,
	[FirstName] [nvarchar](50) NULL,
	[MidName] [nvarchar](100) NULL,
	[LastName] [nvarchar](50) NULL,
	[Active] [bit] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[DeleteDate] [datetime2](0) NULL,
	[DeleteUserId] [int] NULL,
	[DefaultMobliePhone] [nvarchar](50) NULL,
	[DefaultTelephone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NickName] [nvarchar](250) NULL,
	[BirthDay] [datetime2](0) NULL,
	[Gender] [int] NULL,
	[CustomerType] [int] NULL,
	[Point] [decimal](29, 2) NULL,
 CONSTRAINT [PK_Customer_CustomerId] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[CustomerType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[CustomerType](
	[CustomerTypeId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerTypeName] [nvarchar](100) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_CustomerType_CustomerTypeId] PRIMARY KEY CLUSTERED 
(
	[CustomerTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[DayOfWeek]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[DayOfWeek](
	[DayId] [int] IDENTITY(1,1) NOT NULL,
	[DayTH] [nvarchar](50) NOT NULL,
	[DayEN] [nvarchar](50) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_DayOfWeek_DayId] PRIMARY KEY CLUSTERED 
(
	[DayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[DayOfWork]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[DayOfWork](
	[DayOfWorkId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[DayId] [int] NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_DayOfWork_DayOfWorkId] PRIMARY KEY CLUSTERED 
(
	[DayOfWorkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Districts]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Districts](
	[DistrictId] [int] NOT NULL,
	[DistrictNameTH] [nvarchar](255) NOT NULL,
	[DistrictNameENG] [nvarchar](400) NOT NULL,
	[ProvinceId] [int] NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_Districts_DistrictId] PRIMARY KEY CLUSTERED 
(
	[DistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[EdcBank]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[EdcBank](
	[EdcBankId] [int] IDENTITY(1,1) NOT NULL,
	[EdcBankName] [nvarchar](100) NULL,
	[EdcBarcode] [nvarchar](100) NULL,
	[Image] [nvarchar](max) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_EdcBank_EdcBankId] PRIMARY KEY CLUSTERED 
(
	[EdcBankId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[Gender]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Gender](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](150) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_Gender_GenderId] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[GetFree]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[GetFree](
	[GetFreeId] [int] IDENTITY(1,1) NOT NULL,
	[GiftValueId] [int] NULL,
	[ItemId] [int] NULL,
	[Discount] [decimal](29, 2) NULL,
 CONSTRAINT [PK_GiftFree] PRIMARY KEY CLUSTERED 
(
	[GetFreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[GiftValue]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[GiftValue](
	[GiftId] [int] IDENTITY(1,1) NOT NULL,
	[GiftName] [nvarchar](100) NULL,
	[DiscountPer] [decimal](29, 6) NULL,
	[DiscountB] [decimal](29, 6) NULL,
	[GetFree] [decimal](29, 6) NULL,
	[Point] [decimal](29, 6) NULL,
 CONSTRAINT [PK_GiftValue] PRIMARY KEY CLUSTERED 
(
	[GiftId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[HistoryCoupon]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[HistoryCoupon](
	[HistoryCouponId] [int] IDENTITY(1,1) NOT NULL,
	[CouponId] [int] NOT NULL,
	[PaidAmount] [datetime2](0) NOT NULL,
	[Balance] [decimal](29, 6) NOT NULL,
	[InsertDate] [datetime2](0) NOT NULL,
	[SaleId] [int] NOT NULL,
 CONSTRAINT [PK_HistoryCoupon_HistoryCouponId] PRIMARY KEY CLUSTERED 
(
	[HistoryCouponId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[HistoryItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[HistoryItem](
	[HistoryItemId] [int] IDENTITY(1,1) NOT NULL,
	[HistoryItemSequenceId] [int] NULL,
	[HistoryItemType] [int] NULL,
	[HistoryItemSpecies] [int] NULL,
	[ItemId] [int] NULL,
	[UserId] [int] NULL,
	[ImportQty] [decimal](29, 6) NULL,
	[ExportQty] [decimal](29, 6) NULL,
	[Waste] [decimal](29, 6) NULL,
	[Date] [datetime2](0) NULL,
 CONSTRAINT [PK_HistoryItem_HistoryItemId] PRIMARY KEY CLUSTERED 
(
	[HistoryItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[HistoryItemDate]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[HistoryItemDate](
	[HistoryDateId] [int] IDENTITY(1,1) NOT NULL,
	[HistoryItemType] [int] NULL,
	[HistoryDate] [date] NULL,
 CONSTRAINT [PK_HistoryItemDate_HistoryDateId] PRIMARY KEY CLUSTERED 
(
	[HistoryDateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[HistoryItemSequence]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[HistoryItemSequence](
	[HistoryItemSequenceId] [int] IDENTITY(7,1) NOT NULL,
	[HistoryItemType] [int] NULL,
	[Date] [datetime2](0) NULL,
	[Percent] [decimal](29, 2) NULL,
 CONSTRAINT [PK_HistoryItemSequence_HistoryItemSequenceId] PRIMARY KEY CLUSTERED 
(
	[HistoryItemSequenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Item]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Item](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [nvarchar](50) NOT NULL,
	[ItemName] [nvarchar](100) NOT NULL,
	[ItemName2] [nvarchar](100) NULL,
	[Notes] [nvarchar](255) NULL,
	[Notes2] [nvarchar](255) NULL,
	[CategoryId] [int] NOT NULL,
	[CategoryId2] [int] NULL,
	[CategoryId3] [int] NULL,
	[CategoryId4] [int] NULL,
	[CategoryGroupId] [int] NULL,
	[CategoryPakgeId] [int] NULL,
	[SupplierId] [int] NULL,
	[ImageText] [nvarchar](max) NULL,
	[Active] [int] NOT NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[DeleteDate] [datetime2](0) NULL,
	[DeleteUserId] [int] NULL,
	[IsTrackStock] [int] NOT NULL,
	[USUnitId] [int] NOT NULL,
	[POUnitId] [int] NULL,
	[POUnitId2] [int] NULL,
	[ItemStatusId] [int] NULL,
	[AllowDC] [int] NULL,
	[MaxPercentDC] [decimal](18, 2) NULL,
	[AllowRedeemPoint] [int] NULL,
	[PointToRedeem] [int] NULL,
	[IsRecommended] [int] NULL,
	[IsOnSeason] [int] NULL,
	[IsCanDelivery] [int] NULL,
	[IsTakeTime] [int] NULL,
	[IsTraddingItem] [int] NULL,
	[IsWeight] [int] NULL,
	[IsPromotion] [int] NULL,
	[IsPackage] [int] NULL,
	[ItemCost] [decimal](29, 6) NULL,
	[ItemPrice] [decimal](29, 6) NULL,
	[PrinterName] [nvarchar](100) NULL,
	[ButtonColor] [int] NULL,
	[FontColor] [int] NULL,
	[IsVatChecked] [int] NULL,
	[TaxId] [int] NULL,
	[IsActive] [int] NULL,
	[OrderTypeId] [int] NULL,
	[OrderOfferId] [int] NULL,
	[TimeSend] [int] NULL,
	[IsAlertInventory] [int] NULL,
	[TypeCateItemId] [int] NULL,
	[ItemKiOsk] [bit] NULL,
 CONSTRAINT [PK_Item_ItemId] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[ItemPoint]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemPoint](
	[ItemPointId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[PointRateId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_ItemPoint] PRIMARY KEY CLUSTERED 
(
	[ItemPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ItemSelection]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemSelection](
	[ItemId] [int] NOT NULL,
	[CateSelectionId] [int] NULL,
	[Active] [int] NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[ItemStatus]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemStatus](
	[ItemStatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusDesc] [nvarchar](100) NULL,
 CONSTRAINT [PK_ItemStatus_ItemStatusId] PRIMARY KEY CLUSTERED 
(
	[ItemStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ItemTopping]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemTopping](
	[ItemId] [int] NOT NULL,
	[CategoryToppingId] [int] NULL,
	[Active] [bit] NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[ItemTypes]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemTypes](
	[ItemTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ItemTypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_ItemTypes_ItemTypeId] PRIMARY KEY CLUSTERED 
(
	[ItemTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ItemUnit]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemUnit](
	[ItemUnitId] [int] IDENTITY(1,1) NOT NULL,
	[MatId] [int] NULL,
	[ItemUnitName] [nvarchar](100) NULL,
	[Multiply] [decimal](18, 6) NULL,
	[UnitUseId] [int] NULL,
	[UnitUseName] [nvarchar](100) NULL,
	[TypeUnitId] [int] NULL,
	[Active] [int] NULL,
	[ItemUnitDetail] [nchar](50) NULL,
 CONSTRAINT [PK_ItemUnit_ItemUnitId] PRIMARY KEY CLUSTERED 
(
	[ItemUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ItemUseUnitDefault]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ItemUseUnitDefault](
	[UnitUseId] [int] IDENTITY(1,1) NOT NULL,
	[UnitUsename] [nvarchar](150) NOT NULL,
	[Multiply] [decimal](29, 6) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_ItemUseUnitDefault_UnitUseId] PRIMARY KEY CLUSTERED 
(
	[UnitUseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[MenuOptional]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[MenuOptional](
	[MOPId] [int] IDENTITY(1,1) NOT NULL,
	[MOptionalName] [nvarchar](50) NULL,
	[OptionalTypeId] [int] NULL,
	[Active] [int] NULL,
	[MandatorySelection] [int] NULL,
	[MaxSelection] [int] NULL,
 CONSTRAINT [PK_MenuOptional_MOPId] PRIMARY KEY CLUSTERED 
(
	[MOPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[MenuOptionRef]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[MenuOptionRef](
	[MOPId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
 CONSTRAINT [PK_MenuOptionRef_MOPId] PRIMARY KEY CLUSTERED 
(
	[MOPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Nationality]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Nationality](
	[NationalityId] [int] IDENTITY(1,1) NOT NULL,
	[NationalityNameTH] [nvarchar](50) NULL,
	[NationalityNameEN] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Nationality_NationalityId] PRIMARY KEY CLUSTERED 
(
	[NationalityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[OpenCloseShift]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[OpenCloseShift](
	[ShiftId] [int] IDENTITY(1,1) NOT NULL,
	[MoneyCash] [decimal](29, 6) NULL,
	[UserId] [int] NULL,
	[TypeShift] [nvarchar](50) NOT NULL,
	[DateTimeOpen] [datetime] NULL,
	[StatusShift] [int] NOT NULL,
	[TerminalName] [nvarchar](150) NULL,
	[B1000] [int] NULL,
	[B500] [int] NULL,
	[B100] [int] NULL,
	[B50] [int] NULL,
	[B20] [int] NULL,
	[C10] [int] NULL,
	[C5] [int] NULL,
	[C2] [int] NULL,
	[C1] [int] NULL,
	[C05] [int] NULL,
	[C025] [int] NULL,
	[TotalNetSale] [decimal](26, 9) NULL,
    [DateTimeClose] [datetime] NULL,
	[CloseUserID] [int] NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[OptionalChoice]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[OptionalChoice](
	[ChoiceId] [int] IDENTITY(1,1) NOT NULL,
	[MOPId] [int] NULL,
	[ChoiceName] [nvarchar](50) NULL,
	[Active] [int] NULL,
	[ItemId] [int] NULL,
	[Qty] [int] NULL,
	[AddingPrice] [decimal](29, 6) NULL,
	[ChoiceCost] [decimal](29, 6) NULL,
	[UseItemReciepe] [int] NULL,
 CONSTRAINT [PK_OptionalChoice_ChoiceId] PRIMARY KEY CLUSTERED 
(
	[ChoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[OptionType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[OptionType](
	[OptionTypeId] [int] IDENTITY(1,1) NOT NULL,
	[OptionTypeDesc] [nvarchar](100) NULL,
 CONSTRAINT [PK_OptionType_OptionTypeId] PRIMARY KEY CLUSTERED 
(
	[OptionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[OrderOffer]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[OrderOffer](
	[OrderOfferId] [int] IDENTITY(1,1) NOT NULL,
	[OrderOfferName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_OrderOffer_OrderOfferId] PRIMARY KEY CLUSTERED 
(
	[OrderOfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[OrderType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[OrderType](
	[OrderTypeId] [int] IDENTITY(1,1) NOT NULL,
	[OrderTypeName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_OrderType_OrderTypeId] PRIMARY KEY CLUSTERED 
(
	[OrderTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Pakge]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Pakge](
	[PakgeItemId] [int] IDENTITY(1,1) NOT NULL,
	[CostPakge] [decimal](29, 6) NULL,
	[pic] [nvarchar](max) NULL,
	[PakgeItemName] [nvarchar](100) NULL,
	[PakgeType] [nvarchar](100) NULL,
 CONSTRAINT [PK_Pakge_PakgeItemId] PRIMARY KEY CLUSTERED 
(
	[PakgeItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[PakgeItems]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PakgeItems](
	[PackageItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[CostPackage] [decimal](29, 0) NULL,
	[PackageItemName] [nvarchar](max) NULL,
 CONSTRAINT [PK_PakgeItems_PackageItemId] PRIMARY KEY CLUSTERED 
(
	[PackageItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[PaymentDetail]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PaymentDetail](
	[PaymentDetailId] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[PaymentTypeId] [int] NULL,
	[BankId] [int] NULL,
	[BankNumber] [nchar](100) NULL,
	[EdcBankId] [int] NULL,
	[BankCardTypeId] [int] NULL,
	[CardTypeId] [int] NULL,
	[PaidAmount] [decimal](29, 6) NULL,
	[CouponNumber] [nvarchar](100) NULL,
	[VoucherNumber] [nvarchar](100) NULL,
 CONSTRAINT [PK_PaymentDetail] PRIMARY KEY CLUSTERED 
(
	[PaymentDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[PaymentType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PaymentType](
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_PaymentType_PaymentId] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[PayType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PayType](
	[PayTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PayTypeNameTH] [nvarchar](50) NULL,
	[PayTypeNameEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_PayType_PayTypeId] PRIMARY KEY CLUSTERED 
(
	[PayTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[PointRate]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PointRate](
	[PointRateId] [int] IDENTITY(1,1) NOT NULL,
	[PointRate] [decimal](18, 2) NULL,
	[DateStart] [date] NULL,
	[DateEnd] [date] NULL,
	[TimeStart] [nvarchar](50) NULL,
	[TimeEnd] [nvarchar](50) NULL,
	[Active] [bit] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PointRate] PRIMARY KEY CLUSTERED 
(
	[PointRateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Position]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Position](
	[PositionId] [int] IDENTITY(1,1) NOT NULL,
	[Staff_ZoneId] [int] NULL,
	[PositionNameTH] [nvarchar](50) NULL,
	[PositionNameEN] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Position_PositionId] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Pricing]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Pricing](
	[PriceId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[TaxId] [int] NULL,
	[InitPrice] [decimal](29, 6) NULL,
	[UnitPrice] [decimal](29, 6) NULL,
	[CustomerTypeId] [int] NULL,
	[UseTimePeriod] [int] NULL,
	[StartDate] [datetime2](0) NULL,
	[EndDate] [datetime2](0) NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[IsDefault] [int] NOT NULL,
	[IsIncludeTax] [int] NOT NULL,
 CONSTRAINT [PK_Pricing_PriceId] PRIMARY KEY CLUSTERED 
(
	[PriceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Promotion]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Promotion](
	[ProId] [int] IDENTITY(1,1) NOT NULL,
	[ProName] [nvarchar](100) NULL,
	[ProCode] [nvarchar](50) NULL,
	[ItemId] [int] NULL,
	[ConditionId] [int] NULL,
	[ConditionIdDate] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PromotionItem] PRIMARY KEY CLUSTERED 
(
	[ProId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[PromotionItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PromotionItem](
	[PromotionItemId] [int] IDENTITY(1,1) NOT NULL,
	[PromotionId] [int] NULL,
	[ItemId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PromotionItem_1] PRIMARY KEY CLUSTERED 
(
	[PromotionItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Provinces]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Provinces](
	[ProvinceId] [int] NOT NULL,
	[CountryId] [int] NULL,
	[ProvinceNameTH] [nvarchar](150) NULL,
	[ProvinceNameENG] [nvarchar](150) NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_Provinces_ProvinceId] PRIMARY KEY CLUSTERED 
(
	[ProvinceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[PunchTheClock]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[PunchTheClock](
	[PunchTheClock] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[DateOfWork] [date] NULL,
	[ClockIn] [time](7) NULL,
	[ClockOut] [time](7) NULL,
	[ClockBreakIn] [time](7) NULL,
	[ClockBreakOut] [time](7) NULL,
	[ClockOTIn] [time](7) NULL,
	[ClockOTOut] [time](7) NULL,
	[ClockTotalTimeOfDay] [time](7) NULL,
	[ClockTotalTimeOfOT] [time](7) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_PunchTheClock_PunchTheClock] PRIMARY KEY CLUSTERED 
(
	[PunchTheClock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Que]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Que](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleNo] [nvarchar](50) NULL,
	[DatetimeSale] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Que] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Queue]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Queue](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QueueId] [int] NULL,
	[Status] [int] NULL,
	[NumOfCus] [int] NULL,
	[TableTypeId] [int] NULL,
	[Qtext] [nvarchar](50) NULL,
	[StartTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
 CONSTRAINT [PK_Queue_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Receipe]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Receipe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[MatId] [int] NULL,
	[ItemUnitId] [int] NULL,
	[Qty] [decimal](29, 6) NULL,
	[MatInitCost] [decimal](29, 6) NULL,
	[MatUnitCost] [decimal](29, 6) NULL,
	[TotalInitCost] [decimal](29, 6) NULL,
	[TotalCost] [decimal](29, 6) NULL,
 CONSTRAINT [PK_Receipe_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Recive]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Recive](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReciveId] [nvarchar](100) NULL,
	[ReciveBill] [nvarchar](100) NULL,
	[DateInvoice] [date] NULL,
	[SupplierId] [int] NULL,
	[StockId] [int] NULL,
	[TaxId] [nvarchar](100) NULL,
	[ReciveDate] [date] NULL,
	[ItemTypeId] [int] NULL,
	[Active] [int] NULL,
	[Tax] [decimal](29, 6) NULL,
	[SubTotal] [decimal](29, 6) NULL,
	[Total] [decimal](29, 6) NULL,
	[StatusId] [int] NULL,
 CONSTRAINT [PK_Recive_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ReciveItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ReciveItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReciveId] [nvarchar](100) NOT NULL,
	[ReciveBill] [nvarchar](100) NULL,
	[InsertDate] [datetime2](0) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[ItemName] [nvarchar](100) NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](100) NULL,
	[CategoryName2] [nvarchar](100) NULL,
	[AmountRecive] [decimal](29, 6) NULL,
	[POUnit] [int] NULL,
	[InitCost] [decimal](29, 6) NULL,
	[UnitCost] [decimal](29, 6) NULL,
	[Multiply] [decimal](29, 6) NULL,
	[BalanceRecive] [decimal](29, 6) NULL,
	[TotalInitCost] [decimal](29, 6) NULL,
	[TotalUnitCost] [decimal](29, 6) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_ReciveItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[RegisterSystem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[RegisterSystem](
	[RegisterId] [int] IDENTITY(1,1) NOT NULL,
	[SerialHDD] [nvarchar](150) NULL,
	[MacAddress] [nvarchar](150) NULL,
	[GenerateId] [nvarchar](255) NULL,
	[RegisterDate] [datetime2](0) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_RegisterSystem_RegisterId] PRIMARY KEY CLUSTERED 
(
	[RegisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Roles]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
	[RoleNameEN] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Sale]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Sale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[SaleDate] [datetime2](0) NULL,
	[SaleNo] [nvarchar](50) NULL,
	[SubTotal] [decimal](29, 6) NULL,
	[TaxAmt] [decimal](29, 6) NULL,
	[Total] [decimal](29, 6) NULL,
	[ABBNo] [nvarchar](50) NULL,
	[FullTaxNo] [nvarchar](50) NULL,
	[IsPrintFulltax] [int] NULL,
	[VoidDate] [datetime2](0) NULL,
	[VoidUserId] [int] NULL,
	[InsertDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[CloseBillUserId] [int] NULL,
	[IsCloseBill] [int] NULL,
	[Active] [int] NULL,
	[SaveBillCount] [int] NULL,
	[CustomerId] [int] NULL,
	[NumOfCust] [int] NULL,
	[StartTime] [datetime2](0) NULL,
	[EndTime] [datetime2](0) NULL,
	[TerminalId] [int] NULL,
	[TerminalName] [nvarchar](100) NULL,
	[AmountDC] [decimal](29, 6) NULL,
	[partnerTxnUid] [nvarchar](150) NULL,
    [HqSync] [int] NOT NULL DEFAULT(0),
 CONSTRAINT [PK_Sale_SaleId] PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SaleItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SaleItem](
	[SaleItemId] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NULL,
	[SaleId] [int] NULL,
	[ItemId] [int] NULL,
	[CategoryId] [int] NULL,
	[ItemCode] [nvarchar](100) NULL,
	[ItemName] [nvarchar](100) NULL,
	[InitPrice] [decimal](29, 6) NULL,
	[UnitPrice] [decimal](29, 6) NULL,
	[Qty] [decimal](18, 6) NULL,
	[SubTotal] [decimal](29, 6) NULL,
	[Tax] [decimal](29, 6) NULL,
	[Total] [decimal](29, 6) NULL,
	[PercentDC] [decimal](18, 4) NULL,
	[BahtDC] [decimal](29, 6) NULL,
	[AmtDC] [decimal](29, 6) NULL,
	[AmtDCWTax] [decimal](29, 6) NULL,
	[SVCPercent] [decimal](18, 4) NULL,
	[SVCAmt] [decimal](29, 6) NULL,
	[SVCAmtWTax] [decimal](29, 6) NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[TerminalName] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[PrinterName] [nvarchar](100) NULL,
	[TerminalId] [int] NULL,
	[StatusPrint] [int] NULL,
 CONSTRAINT [PK_SaleItem_SaleItemId] PRIMARY KEY CLUSTERED 
(
	[SaleItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SaleItemModifier]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SaleItemModifier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleItemId] [int] NULL,
	[ModifierDesc] [nvarchar](100) NULL,
	[AddUnitPrice] [decimal](29, 6) NULL,
	[AddInitPrice] [decimal](29, 6) NULL,
 CONSTRAINT [PK_SaleItemModifier_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SaleItemOrder]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[SaleItemOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleItemId] [int] NULL,
	[Qty] [decimal](18, 6) NULL,
	[ItemName] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[OrderTime] [datetime2](0) NULL,
	[PrinterName] [nvarchar](100) NULL,
	[TerminalId] [int] NULL,
	[TerminalName] [nvarchar](50) NULL,
	[StatusPrint] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SaleItemOrder_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[SalePayment]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SalePayment](
	[SalePaymentId] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[PaymentId] [int] NULL,
	[PaymentCode] [nvarchar](50) NULL,
	[PaidAmount] [decimal](28, 6) NULL,
	[Rate] [decimal](18, 6) NULL,
	[InsertDate] [datetime2](0) NULL,
	[RefNumber] [nvarchar](50) NULL,
	[CC_type] [nvarchar](50) NULL,
	[CC_Number] [nvarchar](50) NULL,
 CONSTRAINT [PK_SalePayment_SalePaymentId] PRIMARY KEY CLUSTERED 
(
	[SalePaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SaleTable]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SaleTable](
	[SaleTabId] [int] NOT NULL,
	[SaleId] [int] NULL,
	[SaleName] [nvarchar](50) NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[OpenUserId] [int] NULL,
	[Active] [int] NULL,
	[IsUsing] [int] NULL,
	[CurrentUserUsed] [int] NULL,
 CONSTRAINT [PK_SaleTable_SaleTabId] PRIMARY KEY CLUSTERED 
(
	[SaleTabId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SaleTabRef]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SaleTabRef](
	[SaleTabId] [int] IDENTITY(1,1) NOT NULL,
	[TableId] [int] NULL,
 CONSTRAINT [PK_SaleTabRef_SaleTabId] PRIMARY KEY CLUSTERED 
(
	[SaleTabId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Selection]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Selection](
	[SelectionId] [int] IDENTITY(1,1) NOT NULL,
	[CategorySelectionId] [int] NULL,
	[SelectionName] [nvarchar](100) NULL,
	[SelectionName2] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Selection_SelectionId] PRIMARY KEY CLUSTERED 
(
	[SelectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Setting]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Setting](
	[SettingId] [int] IDENTITY(1,1) NOT NULL,
	[SettingName] [nvarchar](100) NULL,
	[SettingValue] [nvarchar](MAX) NULL,
	[SettingTypeId] [int] NULL,
	[TerminalId] [int] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Setting_SettingId] PRIMARY KEY CLUSTERED 
(
	[SettingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SettingApp]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SettingApp](
	[SettingAppId] [int] IDENTITY(1,1) NOT NULL,
	[SettingAppName] [nvarchar](100) NULL,
	[SettingAppDetail] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SettingApp_SettingAppId] PRIMARY KEY CLUSTERED 
(
	[SettingAppId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SettingAppCheck]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SettingAppCheck](
	[SettingAppId] [int] NOT NULL,
	[SettingAppSubId] [int] NULL,
	[SettingPrinterId] [int] NULL,
	[SettingPaperId] [int] NULL,
	[Active] [int] NOT NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[SettingAppSub]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SettingAppSub](
	[SettingAppSubId] [int] IDENTITY(1,1) NOT NULL,
	[SettingAppId] [int] NULL,
	[SettingAppSubName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SettingAppSub_SettingAppSubId] PRIMARY KEY CLUSTERED 
(
	[SettingAppSubId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SettingPaper]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SettingPaper](
	[SettingPaperId] [int] IDENTITY(1,1) NOT NULL,
	[SettingPaperName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SettingPaper_SettingPaperId] PRIMARY KEY CLUSTERED 
(
	[SettingPaperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SettingPrinter]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SettingPrinter](
	[SettingPrinterId] [int] IDENTITY(1,1) NOT NULL,
	[SettingPrinterName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SettingPrinter_SettingPrinterId] PRIMARY KEY CLUSTERED 
(
	[SettingPrinterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Staff_Zone]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Staff_Zone](
	[Staff_ZoneId] [int] IDENTITY(1,1) NOT NULL,
	[Staff_ZoneName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Staff_Zone_Staff_ZoneId] PRIMARY KEY CLUSTERED 
(
	[Staff_ZoneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[StatusSystem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[StatusSystem](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](150) NULL,
 CONSTRAINT [PK_StatusSystem_StatusId] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Stock]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Stock](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[StockCode] [nvarchar](50) NULL,
	[StockName] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Stock_StockId] PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[SubDistricts]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[SubDistricts](
	[SubDistrictId] [int] IDENTITY(1,1) NOT NULL,
	[DistrictId] [int] NULL,
	[SubDistrictNameTH] [nvarchar](255) NULL,
	[SubDistrictNameENG] [nvarchar](400) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SubDistricts_SubDistrictId] PRIMARY KEY CLUSTERED 
(
	[SubDistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Supplier]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[SupCode] [nvarchar](50) NULL,
	[SupName] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
	[PaymentTermId] [int] NULL,
	[Active] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[DeleteDate] [datetime2](0) NULL,
	[DeleteUserId] [int] NULL,
 CONSTRAINT [PK_Supplier_SupplierId] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Tables]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Tables](
	[TableId] [int] IDENTITY(1,1) NOT NULL,
	[TableTypeId] [int] NULL,
	[ZoneId] [int] NULL,
	[TableName] [nvarchar](50) NULL,
	[Active] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[DeleteDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[DeleteUserId] [int] NULL,
	[StateStatus] [int] NULL,
	[IsGroupTable] [bit] NULL,
	[IsSplitBill] [bit] NULL,
	[TableName2] [nvarchar](100) NULL,
	[TableId2] [nvarchar](100) NULL,
 CONSTRAINT [PK_Tables_TableId] PRIMARY KEY CLUSTERED 
(
	[TableId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Tables] ADD  CONSTRAINT [DF_Tables_IsGroupTable]  DEFAULT ((0)) FOR [IsGroupTable]

ALTER TABLE [dbo].[Tables] ADD  CONSTRAINT [DF_Tables_IsSplitBill]  DEFAULT ((0)) FOR [IsSplitBill]

/****** Object:  Table [dbo].[TableType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[TableType](
	[TableTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TableTypeName] [nvarchar](100) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_TableType_TableTypeId] PRIMARY KEY CLUSTERED 
(
	[TableTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Take]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Take](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TakeId] [nvarchar](100) NULL,
	[TakeDate] [datetime2](0) NULL,
	[TakeTitle] [nvarchar](100) NULL,
	[TakeDetail] [nvarchar](max) NULL,
	[TakeTypeId] [int] NULL,
	[StockId] [int] NULL,
	[Total] [decimal](29, 6) NULL,
	[StatusId] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Take_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


/****** Object:  Table [dbo].[TakeItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[TakeItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TakeId] [nvarchar](100) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[ItemName] [nvarchar](150) NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](150) NULL,
	[CategoryName2] [nvarchar](150) NULL,
	[Amount] [decimal](29, 6) NULL,
	[ItemUnitId] [int] NULL,
	[Multiply] [decimal](18, 6) NULL,
	[UnitCost] [decimal](29, 6) NULL,
	[TotalUnitCost] [decimal](29, 6) NULL,
 CONSTRAINT [PK_TakeItem_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[TakeType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[TakeType](
	[TakeTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TakeTypeName] [nvarchar](150) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_TakeType_TakeTypeId] PRIMARY KEY CLUSTERED 
(
	[TakeTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Tax]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Tax](
	[TaxId] [int] IDENTITY(1,1) NOT NULL,
	[TaxName] [nvarchar](100) NULL,
	[Multiply] [decimal](18, 6) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Tax_TaxId] PRIMARY KEY CLUSTERED 
(
	[TaxId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Terminal]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Terminal](
	[TerminalId] [int] IDENTITY(1,1) NOT NULL,
	[TerminalName] [int] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Terminal_TerminalId] PRIMARY KEY CLUSTERED 
(
	[TerminalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Titles]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Titles](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Titles_TitleId] PRIMARY KEY CLUSTERED 
(
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Topping]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Topping](
	[ToppingId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryToppingId] [int] NULL,
	[ToppingName] [nvarchar](100) NULL,
	[ToppingName2] [nvarchar](100) NULL,
	[Costing] [decimal](29, 6) NULL,
	[Pricing] [decimal](29, 6) NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[DeleteDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[ToppingCode] [nvarchar](100) NULL,
 CONSTRAINT [PK_Topping_ToppingId] PRIMARY KEY CLUSTERED 
(
	[ToppingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[ToppingReceipe]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[ToppingReceipe](
	[ToppingReceipeId] [int] IDENTITY(1,1) NOT NULL,
	[ToppingId] [int] NULL,
	[MatIdTopping] [int] NULL,
	[MatName] [nvarchar](100) NULL,
	[Qty] [decimal](29, 6) NULL,
	[MatInitCost] [decimal](29, 6) NULL,
	[MatUnitCost] [decimal](29, 6) NULL,
	[TotalInitCost] [decimal](29, 6) NULL,
	[TotalCost] [decimal](29, 6) NULL,
 CONSTRAINT [PK_ToppingReceipe] PRIMARY KEY CLUSTERED 
(
	[ToppingReceipeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[TypeCateItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[TypeCateItem](
	[typecateitemid] [int] IDENTITY(1,1) NOT NULL,
	[typecateitemname] [nvarchar](100) NULL,
 CONSTRAINT [PK_TypeCateItem_typecateitemid] PRIMARY KEY CLUSTERED 
(
	[typecateitemid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[TypeUnit]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[TypeUnit](
	[TypeUnitId] [int] NOT NULL,
	[TypeUnitName] [nvarchar](100) NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[UnitInStock]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UnitInStock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StockId] [int] NULL,
	[ItemId] [int] NULL,
	[ItemCode] [nvarchar](100) NULL,
	[Qty] [decimal](29, 6) NULL,
 CONSTRAINT [PK_UnitInStock_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[UsePointItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UsePointItem](
	[UsePointItem] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[InsertDate] [datetime] NULL,
	[PointRate] [decimal](18, 2) NULL,
	[CustomerNo] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[Qty] [decimal](18, 2) NULL,
	[StatusPrint] [bit] NULL,
    [PointRateId] [int] NULL,
 CONSTRAINT [PK_UsePointItem] PRIMARY KEY CLUSTERED 
(
	[UsePointItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[UsePromotion]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UsePromotion](
	[UsePromotionId] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[SaleNo] [nvarchar](100) NULL,
	[PromotionId] [int] NULL,
	[ItemPromotionId] [int] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_UsePromotion] PRIMARY KEY CLUSTERED 
(
	[UsePromotionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[UseReceipeItem]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UseReceipeItem](
	[UseReceipeId] [int] IDENTITY(1,1) NOT NULL,
	[SaleItemId] [int] NULL,
	[ItemId] [int] NULL,
	[MatId] [int] NULL,
	[Qty] [decimal](29, 6) NULL,
	[MatInitCostUseReceipe] [decimal](29, 6) NULL,
	[MatUnitCostUseReceipe] [decimal](29, 6) NULL,
	[TotalInitCostUseReceipe] [decimal](29, 6) NULL,
	[TotalCostUseReceipe] [decimal](29, 6) NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_UseReceipeItem] PRIMARY KEY CLUSTERED 
(
	[UseReceipeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[UseReceipeModifier]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UseReceipeModifier](
	[UseReceipeModifierId] [int] NOT NULL,
	[SaleItemId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[MatId] [int] NULL,
	[Qty] [decimal](29, 6) NULL,
	[MatInitCost] [decimal](29, 6) NULL,
	[MatUnitCost] [decimal](29, 6) NULL,
	[TotalInitCost] [decimal](29, 6) NULL,
	[TotalCost] [decimal](29, 6) NULL,
 CONSTRAINT [PK_UseReceipeModifier_UseReceipeModifierId] PRIMARY KEY CLUSTERED 
(
	[UseReceipeModifierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[UseReceipeTopping]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UseReceipeTopping](
	[ToppingReceipeId] [int] IDENTITY(1,1) NOT NULL,
	[ToppingId] [int] NULL,
	[MatIdTopping] [int] NULL,
	[MatName] [nvarchar](50) NULL,
	[Qty] [decimal](29, 6) NULL,
	[MatInitCost] [decimal](29, 6) NULL,
	[MatUnitCost] [decimal](29, 6) NULL,
	[TotalInitCost] [decimal](29, 6) NULL,
	[TotalCost] [decimal](29, 6) NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[Users]    Script Date: 8/10/2561 13:50:49 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Passwords] [nvarchar](50) NULL,
	[BirthDay] [datetime] NULL,
	[Email] [nvarchar](100) NULL,
	[Active_Email] [int] NULL,
	[Hash] [nvarchar](32) NULL,
	[Pin] [nvarchar](6) NULL,
	[QRcode] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[RegisterDate] [datetime] NULL,
	[Active] [int] NULL,
	[Staff_Active] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Deletedate] [datetime] NULL,
	[DeleteUserId] [datetime] NULL,
	[RoleId] [nvarchar](10) NULL,
	[Nickname] [nvarchar](50) NULL,
	[CardId] [nvarchar](50) NULL,
	[GenderId] [int] NULL,
	[NationalityId] [int] NULL,
	[Address] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[PositionId] [nvarchar](13) NULL,
	[UserPayType] [nvarchar](50) NULL,
	[Phone2] [nvarchar](50) NULL,
	[Phone3] [nvarchar](50) NULL,
	[WorkStartDate] [datetime] NULL,
	[Pay] [decimal](18, 4) NULL,
	[PayTypeId] [int] NULL,
	[OverTimePay] [decimal](18, 4) NULL,
	[OverTimePayTypeId] [int] NULL,
	[Diligence] [decimal](18, 4) NULL,
	[DiligenceTypeId] [int] NULL,
	[BreakId] [int] NULL,
	[WorkTypeId] [int] NULL,
	[BranchId] [int] NULL,
	[EditUserId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



/****** Object:  Table [dbo].[UseSelection]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UseSelection](
	[SelectionId] [int] NULL,
	[SaleItemId] [int] NULL,
	[SelectionName] [nvarchar](50) NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[UseTopping]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[UseTopping](
	[ToppingId] [int] NOT NULL,
	[SaleItemId] [int] NULL,
	[ToppingName] [nvarchar](50) NULL,
	[InsertDate] [datetime] NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[Voucher]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Voucher](
	[VoucherId] [int] IDENTITY(1,1) NOT NULL,
	[VoucherName] [nvarchar](100) NULL,
	[VoucherNumber] [nvarchar](100) NULL,
	[VoucherPrice] [decimal](29, 6) NULL,
	[VoucherBalance] [decimal](29, 6) NULL,
	[StatusId] [int] NULL,
	[StartVoucherDate] [datetime2](0) NULL,
	[ExpDate] [datetime2](0) NULL,
	[UseVoucherDate] [datetime2](0) NULL,
	[InsertDate] [datetime2](0) NULL,
	[DeleteDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Voucher_VoucherId] PRIMARY KEY CLUSTERED 
(
	[VoucherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[VoucherHistory]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[VoucherHistory](
	[VoucherHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[VoucherId] [int] NULL,
	[PaidAmount] [decimal](29, 6) NULL,
	[InsertDate] [datetime] NULL,
	[SaleId] [int] NULL,
 CONSTRAINT [PK_VoucherHistory] PRIMARY KEY CLUSTERED 
(
	[VoucherHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[WithdrawMoney]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[WithdrawMoney](
	[WithdrawMoneyId] [int] IDENTITY(1,1) NOT NULL,
	[TypeShift] [nvarchar](50) NULL,
	[TerminalName] [nvarchar](50) NULL,
	[InsertDate] [date] NULL,
	[UpdateDate] [date] NULL,
	[WithdrawAmount] [decimal](29, 6) NULL,
	[WithdrawName] [nvarchar](100) NULL,
	[UserId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_WithdrawMoney] PRIMARY KEY CLUSTERED 
(
	[WithdrawMoneyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[WorkType]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[WorkType](
	[WorkTypeId] [int] IDENTITY(1,1) NOT NULL,
	[WorkTypeName] [nvarchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_WorkType_WorkTypeId] PRIMARY KEY CLUSTERED 
(
	[WorkTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Zones]    Script Date: 7/25/2018 12:51:43 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Zones](
	[ZoneId] [int] IDENTITY(1,1) NOT NULL,
	[ZoneName] [nvarchar](50) NULL,
	[Active] [int] NULL,
	[InsertDate] [datetime2](0) NULL,
	[UpdateDate] [datetime2](0) NULL,
	[DeleteDate] [datetime2](0) NULL,
	[UserId] [int] NULL,
	[DeleteUserId] [int] NULL,
	[BackgroundColor] [int] NULL,
 CONSTRAINT [PK_Zones_ZoneId] PRIMARY KEY CLUSTERED 
(
	[ZoneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryId], [CountryNameTH], [CountryNameENG], [Active]) VALUES (1, N'ประเทศไทย', N'Thailand', 1)

SET IDENTITY_INSERT [dbo].[Countries] OFF



SET IDENTITY_INSERT [dbo].[Authority] ON 

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (1, N'ตั้งค่าสินค้า', N'Managemenu', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (2, N'ตั้งค่าพนักงาน', N'Manageemployee', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (3, N'จัดการสมาชิก', N'ManageCustomers', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (4, N'จัดการวัตถุดิบ', N'Material inventory', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (5, N'ดูรายงานย้อนหลัง', N'Document History', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (6, N'ตั้งค่าระบบ', N'System Setting', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (7, N'ตั้งค่าการขาย', N'Sale Setting', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (8, N'ผังร้าน', N'Store Plan', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (9, N'ออร์เดอร์', N'Order', N'')

INSERT [dbo].[Authority] ([AuthorityId], [AuthorityNameTH], [AuthorityNameENG], [AuthorityType]) VALUES (10, N'ชำระเงิน', N'Payment', N'')

SET IDENTITY_INSERT [dbo].[Authority] OFF

SET IDENTITY_INSERT [dbo].[AuthorityRoles] ON 

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (1, 1, 1, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (2, 1, 2, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (3, 1, 3, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (4, 1, 4, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (5, 1, 5, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (6, 1, 6, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (7, 1, 7, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (8, 1, 8, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (9, 1, 9, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (10, 1, 10, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (11, 2, 1, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (12, 2, 2, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (13, 2, 3, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (14, 2, 4, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (15, 2, 5, 1)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (16, 2, 6, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (17, 2, 7, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (18, 2, 8, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (19, 2, 9, 0)

INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (20, 2, 10, 1)

SET IDENTITY_INSERT [dbo].[AuthorityRoles] OFF

SET IDENTITY_INSERT [dbo].[Bank] ON 


INSERT [dbo].[Bank] ([BankId], [BankName], [Image], [Active], [test]) VALUES (1, N'ธนาคารไทยพาณิชย์', NULL, 1, NULL)

INSERT [dbo].[Bank] ([BankId], [BankName], [Image], [Active], [test]) VALUES (2, N'ธนาคารกรุงไทย', NULL, 1, NULL)

INSERT [dbo].[Bank] ([BankId], [BankName], [Image], [Active], [test]) VALUES (3, N'ธนาคารกรุงเทพ', NULL, 1, NULL)

INSERT [dbo].[Bank] ([BankId], [BankName], [Image], [Active], [test]) VALUES (4, N'ธนาคารกสิกรไทย', NULL, 1, NULL)

SET IDENTITY_INSERT [dbo].[Bank] OFF

SET IDENTITY_INSERT [dbo].[BankCardType] ON 


INSERT [dbo].[BankCardType] ([BankCardTypeId], [BankCardTypeName], [Image], [Active]) VALUES (1, N'VISA', NULL, 1)

INSERT [dbo].[BankCardType] ([BankCardTypeId], [BankCardTypeName], [Image], [Active]) VALUES (2, N'Master Cards', NULL, 1)

INSERT [dbo].[BankCardType] ([BankCardTypeId], [BankCardTypeName], [Image], [Active]) VALUES (3, N'JCB', NULL, 1)

INSERT [dbo].[BankCardType] ([BankCardTypeId], [BankCardTypeName], [Image], [Active]) VALUES (4, N'TestCard', NULL, 0)

SET IDENTITY_INSERT [dbo].[BankCardType] OFF

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (1, N'เขตพระนคร', N'Khet Phra Nakhon', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (2, N'เขตดุสิต', N'Khet Dusit', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (3, N'เขตหนองจอก', N'Khet  Nong Chok', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (4, N'เขตบางรัก', N'Khet Bang Rak', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (5, N'เขตบางเขน', N'Khet Bang Khen', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (6, N'เขตบางกะปิ', N'Khet Bang Kapi', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (7, N'เขตปทุมวัน', N'Khet Pathum Wan', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (8, N'เขตป้อมปราบศัตรูพ่าย', N'Khet Pom Prap Sattru Phai', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (9, N'เขตพระโขนง', N'Khet Phra Khanong', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (10, N'เขตมีนบุรี', N'Khet Min Buri', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (11, N'เขตลาดกระบัง', N'Khet Lat Krabang', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (12, N'เขตยานนาวา', N'Khet Yan Nawa', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (13, N'เขตสัมพันธวงศ์', N'Khet Samphanthawong', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (14, N'เขตพญาไท', N'Khet Phaya Thai', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (15, N'เขตธนบุรี', N'Khet Thon Buri', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (16, N'เขตบางกอกใหญ่', N'Khet Bangkok Yai', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (17, N'เขตห้วยขวาง', N'Khet Huai Khwang', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (18, N'เขตคลองสาน', N'Khet Khlong San', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (19, N'เขตตลิ่งชัน', N'Khet Taling Chan', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (20, N'เขตบางกอกน้อย', N'Khet Bangkok Noi', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (21, N'เขตบางขุนเทียน', N'Khet Bang Khun Thian', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (22, N'เขตภาษีเจริญ', N'Khet Phasi Charoen', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (23, N'เขตหนองแขม', N'Khet Nong Khaem', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (24, N'เขตราษฎร์บูรณะ', N'Khet Rat Burana', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (25, N'เขตบางพลัด', N'Khet Bang Phlat', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (26, N'เขตดินแดง', N'Khet Din Daeng', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (27, N'เขตบึงกุ่ม', N'Khet Bueng Kum', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (28, N'เขตสาทร', N'Khet Sathon', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (29, N'เขตบางซื่อ', N'Khet Bang Sue', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (30, N'เขตจตุจักร', N'Khet Chatuchak', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (31, N'เขตบางคอแหลม', N'Khet Bang Kho Laem', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (32, N'เขตประเวศ', N'Khet Prawet', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (33, N'เขตคลองเตย', N'Khet Khlong Toei', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (34, N'เขตสวนหลวง', N'Khet Suan Luang', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (35, N'เขตจอมทอง', N'Khet Chom Thong', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (36, N'เขตดอนเมือง', N'Khet Don Mueang', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (37, N'เขตราชเทวี', N'Khet Ratchathewi', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (38, N'เขตลาดพร้าว', N'Khet Lat Phrao', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (39, N'เขตวัฒนา', N'Khet Watthana', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (40, N'เขตบางแค', N'Khet Bang Khae', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (41, N'เขตหลักสี่', N'Khet Lak Si', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (42, N'เขตสายไหม', N'Khet Sai Mai', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (43, N'เขตคันนายาว', N'Khet Khan Na Yao', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (44, N'เขตสะพานสูง', N'Khet Saphan Sung', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (45, N'เขตวังทองหลาง', N'Khet Wang Thonglang', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (46, N'เขตคลองสามวา', N'Khet Khlong Sam Wa', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (47, N'เขตบางนา', N'Khet Bang Na', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (48, N'เขตทวีวัฒนา', N'Khet Thawi Watthana', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (49, N'เขตทุ่งครุ', N'Khet Thung Khru', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (50, N'เขตบางบอน', N'Khet Bang Bon', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (51, N'*บ้านทะวาย', N'*Bantawai', 1, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (52, N'เมืองสมุทรปราการ', N'Mueang Samut Prakan', 2, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (53, N'บางบ่อ', N'Bang Bo', 2, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (54, N'บางพลี', N'Bang Phli', 2, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (55, N'พระประแดง', N'Phra Pradaeng', 2, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (56, N'พระสมุทรเจดีย์', N'Phra Samut Chedi', 2, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (57, N'บางเสาธง', N'Bang Sao Thong', 2, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (58, N'เมืองนนทบุรี', N'Mueang Nonthaburi', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (59, N'บางกรวย', N'Bang Kruai', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (60, N'บางใหญ่', N'Bang Yai', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (61, N'บางบัวทอง', N'Bang Bua Thong', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (62, N'ไทรน้อย', N'Sai Noi', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (63, N'ปากเกร็ด', N'Pak Kret', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (64, N'เทศบาลนครนนทบุรี(สาขาแขวงท่าทราย)*', N'Tetsaban Nonthaburi', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (65, N'เทศบาลเมืองปากเกร็ด*', N'Tetsaban Pak Kret', 3, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (66, N'เมืองปทุมธานี', N'Mueang Pathum Thani', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (67, N'คลองหลวง', N'Khlong Luang', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (68, N'ธัญบุรี', N'Thanyaburi', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (69, N'หนองเสือ', N'Nong Suea', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (70, N'ลาดหลุมแก้ว', N'Lat Lum Kaeo', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (71, N'ลำลูกกา', N'Lam Luk Ka', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (72, N'สามโคก', N'Sam Khok', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (73, N'ลำลูกกา(สาขาตำบลคูคต)*', N'Khlong Luang(Kukod)', 4, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (74, N'พระนครศรีอยุธยา', N'Phra Nakhon Si Ayutthaya', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (75, N'ท่าเรือ', N'Tha Ruea', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (76, N'นครหลวง', N'Nakhon Luang', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (77, N'บางไทร', N'Bang Sai', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (78, N'บางบาล', N'Bang Ban', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (79, N'บางปะอิน', N'Bang Pa-in', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (80, N'บางปะหัน', N'Bang Pahan', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (81, N'ผักไห่', N'Phak Hai', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (82, N'ภาชี', N'Phachi', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (83, N'ลาดบัวหลวง', N'Lat Bua Luang', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (84, N'วังน้อย', N'Wang Noi', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (85, N'เสนา', N'Sena', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (86, N'บางซ้าย', N'Bang Sai', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (87, N'อุทัย', N'Uthai', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (88, N'มหาราช', N'Maha Rat', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (89, N'บ้านแพรก', N'Ban Phraek', 5, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (90, N'เมืองอ่างทอง', N'Mueang Ang Thong', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (91, N'ไชโย', N'Chaiyo', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (92, N'ป่าโมก', N'Pa Mok', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (93, N'โพธิ์ทอง', N'Pho Thong', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (94, N'แสวงหา', N'Sawaeng Ha', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (95, N'วิเศษชัยชาญ', N'Wiset Chai Chan', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (96, N'สามโก้', N'Samko', 6, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (97, N'เมืองลพบุรี', N'Mueang Lop Buri', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (98, N'พัฒนานิคม', N'Phatthana Nikhom', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (99, N'โคกสำโรง', N'Khok Samrong', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (100, N'ชัยบาดาล', N'Chai Badan', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (101, N'ท่าวุ้ง', N'Tha Wung', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (102, N'บ้านหมี่', N'Ban Mi', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (103, N'ท่าหลวง', N'Tha Luang', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (104, N'สระโบสถ์', N'Sa Bot', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (105, N'โคกเจริญ', N'Khok Charoen', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (106, N'ลำสนธิ', N'Lam Sonthi', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (107, N'หนองม่วง', N'Nong Muang', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (108, N'*อ.บ้านเช่า  จ.ลพบุรี', N'*Amphoe Ban Chao', 7, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (109, N'เมืองสิงห์บุรี', N'Mueang Sing Buri', 8, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (110, N'บางระจัน', N'Bang Rachan', 8, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (111, N'ค่ายบางระจัน', N'Khai Bang Rachan', 8, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (112, N'พรหมบุรี', N'Phrom Buri', 8, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (113, N'ท่าช้าง', N'Tha Chang', 8, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (114, N'อินทร์บุรี', N'In Buri', 8, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (115, N'เมืองชัยนาท', N'Mueang Chai Nat', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (116, N'มโนรมย์', N'Manorom', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (117, N'วัดสิงห์', N'Wat Sing', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (118, N'สรรพยา', N'Sapphaya', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (119, N'สรรคบุรี', N'Sankhaburi', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (120, N'หันคา', N'Hankha', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (121, N'หนองมะโมง', N'Nong Mamong', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (122, N'เนินขาม', N'Noen Kham', 9, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (123, N'เมืองสระบุรี', N'Mueang Saraburi', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (124, N'แก่งคอย', N'Kaeng Khoi', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (125, N'หนองแค', N'Nong Khae', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (126, N'วิหารแดง', N'Wihan Daeng', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (127, N'หนองแซง', N'Nong Saeng', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (128, N'บ้านหมอ', N'Ban Mo', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (129, N'ดอนพุด', N'Don Phut', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (130, N'หนองโดน', N'Nong Don', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (131, N'พระพุทธบาท', N'Phra Phutthabat', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (132, N'เสาไห้', N'Sao Hai', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (133, N'มวกเหล็ก', N'Muak Lek', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (134, N'วังม่วง', N'Wang Muang', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (135, N'เฉลิมพระเกียรติ', N'Chaloem Phra Kiat', 10, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (136, N'เมืองชลบุรี', N'Mueang Chon Buri', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (137, N'บ้านบึง', N'Ban Bueng', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (138, N'หนองใหญ่', N'Nong Yai', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (139, N'บางละมุง', N'Bang Lamung', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (140, N'พานทอง', N'Phan Thong', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (141, N'พนัสนิคม', N'Phanat Nikhom', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (142, N'ศรีราชา', N'Si Racha', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (143, N'เกาะสีชัง', N'Ko Sichang', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (144, N'สัตหีบ', N'Sattahip', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (145, N'บ่อทอง', N'Bo Thong', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (146, N'เกาะจันทร์', N'Ko Chan', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (147, N'สัตหีบ(ตำบลบางเสร่)*', N'Sattahip(Bang Sre)*', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (148, N'ท้องถิ่นเทศบาลเมืองหนองปรือ*', N'Tong Tin Tetsaban Mueang Nong Prue*', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (149, N'เทศบาลตำบลแหลมฉบัง*', N'Tetsaban Tambon Lamsabang*', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (150, N'เทศบาลเมืองชลบุรี*', N'Mueang Chon Buri', 11, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (151, N'เมืองระยอง', N'Mueang Rayong', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (152, N'บ้านฉาง', N'Ban Chang', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (153, N'แกลง', N'Klaeng', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (154, N'วังจันทร์', N'Wang Chan', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (155, N'บ้านค่าย', N'Ban Khai', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (156, N'ปลวกแดง', N'Pluak Daeng', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (157, N'เขาชะเมา', N'Khao Chamao', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (158, N'นิคมพัฒนา', N'Nikhom Phatthana', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (159, N'สาขาตำบลมาบข่า*', N'Saka Tambon Mabka', 12, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (160, N'เมืองจันทบุรี', N'Mueang Chanthaburi', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (161, N'ขลุง', N'Khlung', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (162, N'ท่าใหม่', N'Tha Mai', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (163, N'โป่งน้ำร้อน', N'Pong Nam Ron', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (164, N'มะขาม', N'Makham', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (165, N'แหลมสิงห์', N'Laem Sing', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (166, N'สอยดาว', N'Soi Dao', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (167, N'แก่งหางแมว', N'Kaeng Hang Maeo', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (168, N'นายายอาม', N'Na Yai Am', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (169, N'เขาคิชฌกูฏ', N'Khoa Khitchakut', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (170, N'*กิ่ง อ.กำพุธ  จ.จันทบุรี', N'*King Amphoe Kampud', 13, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (171, N'เมืองตราด', N'Mueang Trat', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (172, N'คลองใหญ่', N'Khlong Yai', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (173, N'เขาสมิง', N'Khao Saming', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (174, N'บ่อไร่', N'Bo Rai', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (175, N'แหลมงอบ', N'Laem Np', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (176, N'เกาะกูด', N'Ko Kut', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (177, N'เกาะช้าง', N'Ko Chang', 14, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (178, N'เมืองฉะเชิงเทรา', N'Mueang Chachoengsao', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (179, N'บางคล้า', N'Bang Khla', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (180, N'บางน้ำเปรี้ยว', N'Bang Nam Priao', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (181, N'บางปะกง', N'Bang Pakong', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (182, N'บ้านโพธิ์', N'Ban Pho', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (183, N'พนมสารคาม', N'Phanom Sarakham', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (184, N'ราชสาส์น', N'Ratchasan', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (185, N'สนามชัยเขต', N'Sanam Chai Khet', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (186, N'แปลงยาว', N'Plaeng Yao', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (187, N'ท่าตะเกียบ', N'Tha Takiap', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (188, N'คลองเขื่อน', N'Khlong Khuean', 15, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (189, N'เมืองปราจีนบุรี', N'Mueang Prachin Buri', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (190, N'กบินทร์บุรี', N'Kabin Buri', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (191, N'นาดี', N'Na Di', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (192, N'*สระแก้ว', N'Sa Kaeo', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (193, N'*วังน้ำเย็น', N'Wang Nam Yen', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (194, N'บ้านสร้าง', N'Ban Sang', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (195, N'ประจันตคาม', N'Prachantakham', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (196, N'ศรีมหาโพธิ', N'Si Maha Phot', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (197, N'ศรีมโหสถ', N'Si Mahosot', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (198, N'*อรัญประเทศ', N'Aranyaprathet', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (199, N'*ตาพระยา', N'Ta Phraya', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (200, N'*วัฒนานคร', N'Watthana Nakhon', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (201, N'*คลองหาด', N'Khlong Hat', 16, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (202, N'เมืองนครนายก', N'Mueang Nakhon Nayok', 17, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (203, N'ปากพลี', N'Pak Phli', 17, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (204, N'บ้านนา', N'Ban Na', 17, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (205, N'องครักษ์', N'Ongkharak', 17, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (206, N'เมืองสระแก้ว', N'Mueang Sa Kaeo', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (207, N'คลองหาด', N'Khlong Hat', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (208, N'ตาพระยา', N'Ta Phraya', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (209, N'วังน้ำเย็น', N'Wang Nam Yen', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (210, N'วัฒนานคร', N'Watthana Nakhon', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (211, N'อรัญประเทศ', N'Aranyaprathet', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (212, N'เขาฉกรรจ์', N'Khao Chakan', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (213, N'โคกสูง', N'Khok Sung', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (214, N'วังสมบูรณ์', N'Wang Sombun', 18, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (215, N'เมืองนครราชสีมา', N'Mueang Nakhon Ratchasima', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (216, N'ครบุรี', N'Khon Buri', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (217, N'เสิงสาง', N'Soeng Sang', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (218, N'คง', N'Khong', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (219, N'บ้านเหลื่อม', N'Ban Lueam', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (220, N'จักราช', N'Chakkarat', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (221, N'โชคชัย', N'Chok Chai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (222, N'ด่านขุนทด', N'Dan Khun Thot', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (223, N'โนนไทย', N'Non Thai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (224, N'โนนสูง', N'Non Sung', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (225, N'ขามสะแกแสง', N'Kham Sakaesaeng', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (226, N'บัวใหญ่', N'Bua Yai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (227, N'ประทาย', N'Prathai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (228, N'ปักธงชัย', N'Pak Thong Chai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (229, N'พิมาย', N'Phimai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (230, N'ห้วยแถลง', N'Huai Thalaeng', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (231, N'ชุมพวง', N'Chum Phuang', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (232, N'สูงเนิน', N'Sung Noen', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (233, N'ขามทะเลสอ', N'Kham Thale So', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (234, N'สีคิ้ว', N'Sikhio', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (235, N'ปากช่อง', N'Pak Chong', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (236, N'หนองบุญมาก', N'Nong Bunnak', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (237, N'แก้งสนามนาง', N'Kaeng Sanam Nang', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (238, N'โนนแดง', N'Non Daeng', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (239, N'วังน้ำเขียว', N'Wang Nam Khiao', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (240, N'เทพารักษ์', N'Thepharak', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (241, N'เมืองยาง', N'Mueang Yang', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (242, N'พระทองคำ', N'Phra Thong Kham', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (243, N'ลำทะเมนชัย', N'Lam Thamenchai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (244, N'บัวลาย', N'Bua Lai', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (245, N'สีดา', N'Sida', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (246, N'เฉลิมพระเกียรติ', N'Chaloem Phra Kiat', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (247, N'ท้องถิ่นเทศบาลตำบลโพธิ์กลาง*', N'Pho Krang', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (248, N'สาขาตำบลมะค่า-พลสงคราม*', N'Ma Ka-Pon Songkram*', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (249, N'*โนนลาว', N'*Non Lao', 19, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (250, N'เมืองบุรีรัมย์', N'Mueang Buri Ram', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (251, N'คูเมือง', N'Khu Mueang', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (252, N'กระสัง', N'Krasang', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (253, N'นางรอง', N'Nang Rong', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (254, N'หนองกี่', N'Nong Ki', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (255, N'ละหานทราย', N'Lahan Sai', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (256, N'ประโคนชัย', N'Prakhon Chai', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (257, N'บ้านกรวด', N'Ban Kruat', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (258, N'พุทไธสง', N'Phutthaisong', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (259, N'ลำปลายมาศ', N'Lam Plai Mat', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (260, N'สตึก', N'Satuek', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (261, N'ปะคำ', N'Pakham', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (262, N'นาโพธิ์', N'Na Pho', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (263, N'หนองหงส์', N'Nong Hong', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (264, N'พลับพลาชัย', N'Phlapphla Chai', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (265, N'ห้วยราช', N'Huai Rat', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (266, N'โนนสุวรรณ', N'Non Suwan', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (267, N'ชำนิ', N'Chamni', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (268, N'บ้านใหม่ไชยพจน์', N'Ban Mai Chaiyaphot', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (269, N'โนนดินแดง', N'Din Daeng', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (270, N'บ้านด่าน', N'Ban Dan', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (271, N'แคนดง', N'Khaen Dong', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (272, N'เฉลิมพระเกียรติ', N'Chaloem Phra Kiat', 20, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (273, N'เมืองสุรินทร์', N'Mueang Surin', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (274, N'ชุมพลบุรี', N'Chumphon Buri', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (275, N'ท่าตูม', N'Tha Tum', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (276, N'จอมพระ', N'Chom Phra', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (277, N'ปราสาท', N'Prasat', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (278, N'กาบเชิง', N'Kap Choeng', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (279, N'รัตนบุรี', N'Rattanaburi', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (280, N'สนม', N'Sanom', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (281, N'ศีขรภูมิ', N'Sikhoraphum', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (282, N'สังขะ', N'Sangkha', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (283, N'ลำดวน', N'Lamduan', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (284, N'สำโรงทาบ', N'Samrong Thap', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (285, N'บัวเชด', N'Buachet', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (286, N'พนมดงรัก', N'Phanom Dong Rak', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (287, N'ศรีณรงค์', N'Si Narong', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (288, N'เขวาสินรินทร์', N'Khwao Sinarin', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (289, N'โนนนารายณ์', N'Non Narai', 21, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (290, N'เมืองศรีสะเกษ', N'Mueang Si Sa Ket', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (291, N'ยางชุมน้อย', N'Yang Chum Noi', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (292, N'กันทรารมย์', N'Kanthararom', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (293, N'กันทรลักษ์', N'Kantharalak', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (294, N'ขุขันธ์', N'Khukhan', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (295, N'ไพรบึง', N'Phrai Bueng', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (296, N'ปรางค์กู่', N'Prang Ku', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (297, N'ขุนหาญ', N'Khun Han', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (298, N'ราษีไศล', N'Rasi Salai', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (299, N'อุทุมพรพิสัย', N'Uthumphon Phisai', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (300, N'บึงบูรพ์', N'Bueng Bun', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (301, N'ห้วยทับทัน', N'Huai Thap Than', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (302, N'โนนคูณ', N'Non Khun', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (303, N'ศรีรัตนะ', N'Si Rattana', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (304, N'น้ำเกลี้ยง', N'Si Rattana', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (305, N'วังหิน', N'Wang Hin', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (306, N'ภูสิงห์', N'Phu Sing', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (307, N'เมืองจันทร์', N'Mueang Chan', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (308, N'เบญจลักษ์', N'Benchalak', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (309, N'พยุห์', N'Phayu', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (310, N'โพธิ์ศรีสุวรรณ', N'Pho Si Suwan', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (311, N'ศิลาลาด', N'Sila Lat', 22, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (312, N'เมืองอุบลราชธานี', N'Mueang Ubon Ratchathani', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (313, N'ศรีเมืองใหม่', N'Si Mueang Mai', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (314, N'โขงเจียม', N'Khong Chiam', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (315, N'เขื่องใน', N'Khueang Nai', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (316, N'เขมราฐ', N'Khemarat', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (317, N'*ชานุมาน', N'*Shanuman', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (318, N'เดชอุดม', N'Det Udom', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (319, N'นาจะหลวย', N'Na Chaluai', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (320, N'น้ำยืน', N'Nam Yuen', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (321, N'บุณฑริก', N'Buntharik', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (322, N'ตระการพืชผล', N'Trakan Phuet Phon', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (323, N'กุดข้าวปุ้น', N'Kut Khaopun', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (324, N'*พนา', N'*Phana', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (325, N'ม่วงสามสิบ', N'Muang Sam Sip', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (326, N'วารินชำราบ', N'Warin Chamrap', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (327, N'*อำนาจเจริญ', N'*Amnat Charoen', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (328, N'*เสนางคนิคม', N'*Senangkhanikhom', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (329, N'*หัวตะพาน', N'*Hua Taphan', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (330, N'พิบูลมังสาหาร', N'Phibun Mangsahan', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (331, N'ตาลสุม', N'Tan Sum', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (332, N'โพธิ์ไทร', N'Pho Sai', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (333, N'สำโรง', N'Samrong', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (334, N'*กิ่งอำเภอลืออำนาจ', N'*King Amphoe Lue Amnat', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (335, N'ดอนมดแดง', N'Don Mot Daeng', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (336, N'สิรินธร', N'Sirindhorn', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (337, N'ทุ่งศรีอุดม', N'Thung Si Udom', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (338, N'*ปทุมราชวงศา', N'*Pathum Ratchawongsa', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (339, N'*กิ่งอำเภอศรีหลักชัย', N'*King Amphoe Sri Lunk Chai', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (340, N'นาเยีย', N'Na Yia', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (341, N'นาตาล', N'Na Tan', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (342, N'เหล่าเสือโก้ก', N'Lao Suea Kok', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (343, N'สว่างวีระวงศ์', N'Sawang Wirawong', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (344, N'น้ำขุ่', N'Nam Khun', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (345, N'*อ.สุวรรณวารี  จ.อุบลราชธานี', N'*Suwan Wari', 23, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (346, N'เมืองยโสธร', N'Mueang Yasothon', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (347, N'ทรายมูล', N'Sai Mun', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (348, N'กุดชุม', N'Kut Chum', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (349, N'คำเขื่อนแก้ว', N'Kham Khuean Kaeo', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (350, N'ป่าติ้ว', N'Pa Tio', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (351, N'มหาชนะชัย', N'Maha Chana Chai', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (352, N'ค้อวัง', N'Kho Wang', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (353, N'เลิงนกทา', N'Loeng Nok Tha', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (354, N'ไทยเจริญ', N'Thai Charoen', 24, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (355, N'เมืองชัยภูมิ', N'Mueang Chaiyaphum', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (356, N'บ้านเขว้า', N'Ban Khwao', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (357, N'คอนสวรรค์', N'Khon Sawan', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (358, N'เกษตรสมบูรณ์', N'Kaset Sombun', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (359, N'หนองบัวแดง', N'Nong Bua Daeng', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (360, N'จัตุรัส', N'Chatturat', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (361, N'บำเหน็จณรงค์', N'Bamnet Narong', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (362, N'หนองบัวระเหว', N'Nong Bua Rawe', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (363, N'เทพสถิต', N'Thep Sathit', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (364, N'ภูเขียว', N'Phu Khiao', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (365, N'บ้านแท่น', N'Ban Thaen', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (366, N'แก้งคร้อ', N'Kaeng Khro', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (367, N'คอนสาร', N'Khon San', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (368, N'ภักดีชุมพล', N'Phakdi Chumphon', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (369, N'เนินสง่า', N'Noen Sa-nga', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (370, N'ซับใหญ่', N'Sap Yai', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (371, N'เมืองชัยภูมิ(ตำบลโนนสำราญ)*', N'Mueang Chaiyaphum(Non Sumran)*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (372, N'สาขาตำบลบ้านหว่าเฒ่า*', N'Ban Wha Tao*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (373, N'หนองบัวแดง*', N'Nong Bua Daeng', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (374, N'กิ่งอำเภอซับใหญ่*', N'King Amphoe Sap Yai*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (375, N'สาขาตำบลโคกเพชร*', N'Coke Phet*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (376, N'เทพสถิต*', N'Thep Sathit*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (377, N'บ้านแท่น*', N'Ban Thaen', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (378, N'แก้งคร้อ*', N'Kaeng Khro*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (379, N'คอนสาร*', N'Khon San*', 25, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (380, N'เมืองอำนาจเจริญ', N'Mueang Amnat Charoen', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (381, N'ชานุมาน', N'Chanuman', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (382, N'ปทุมราชวงศา', N'Pathum Ratchawongsa', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (383, N'พนา', N'Phana', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (384, N'เสนางคนิคม', N'Senangkhanikhom', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (385, N'หัวตะพาน', N'Hua Taphan', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (386, N'ลืออำนาจ', N'Lue Amnat', 26, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (387, N'เมืองหนองบัวลำภู', N'Mueang Nong Bua Lam Phu', 27, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (388, N'นากลาง', N'Na Klang', 27, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (389, N'โนนสัง', N'Non Sang', 27, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (390, N'ศรีบุญเรือง', N'Si Bun Rueang', 27, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (391, N'สุวรรณคูหา', N'Suwannakhuha', 27, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (392, N'นาวัง', N'Na Wang', 27, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (393, N'เมืองขอนแก่น', N'Mueang Khon Kaen', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (394, N'บ้านฝาง', N'Ban Fang', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (395, N'พระยืน', N'Phra Yuen', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (396, N'หนองเรือ', N'Nong Ruea', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (397, N'ชุมแพ', N'Chum Phae', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (398, N'สีชมพู', N'Si Chomphu', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (399, N'น้ำพอง', N'Nam Phong', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (400, N'อุบลรัตน์', N'Ubolratana', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (401, N'กระนวน', N'Kranuan', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (402, N'บ้านไผ่', N'Ban Phai', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (403, N'เปือยน้อย', N'Pueai Noi', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (404, N'พล', N'Phon', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (405, N'แวงใหญ่', N'Waeng Yai', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (406, N'แวงน้อย', N'Waeng Noi', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (407, N'หนองสองห้อง', N'Nong Song Hong', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (408, N'ภูเวียง', N'Phu Wiang', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (409, N'มัญจาคีรี', N'Mancha Khiri', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (410, N'ชนบท', N'Chonnabot', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (411, N'เขาสวนกวาง', N'Khao Suan Kwang', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (412, N'ภูผาม่าน', N'Phu Pha Man', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (413, N'ซำสูง', N'Sam Sung', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (414, N'โคกโพธิ์ไชย', N'Khok Pho Chai', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (415, N'หนองนาคำ', N'Nong Na Kham', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (416, N'บ้านแฮด', N'Ban Haet', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (417, N'โนนศิลา', N'Non Sila', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (418, N'เวียงเก่า', N'Wiang Kao', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (419, N'ท้องถิ่นเทศบาลตำบลบ้านเป็ด*', N'Ban Pet*', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (420, N'เทศบาลตำบลเมืองพล*', N'Tet Saban Tambon Muang Phon*', 28, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (421, N'เมืองอุดรธานี', N'Mueang Udon Thani', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (422, N'กุดจับ', N'Kut Chap', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (423, N'หนองวัวซอ', N'Nong Wua So', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (424, N'กุมภวาปี', N'Kumphawapi', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (425, N'โนนสะอาด', N'Non Sa-at', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (426, N'หนองหาน', N'Nong Han', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (427, N'ทุ่งฝน', N'Thung Fon', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (428, N'ไชยวาน', N'Chai Wan', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (429, N'ศรีธาตุ', N'Si That', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (430, N'วังสามหมอ', N'Wang Sam Mo', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (431, N'บ้านดุง', N'Ban Dung', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (432, N'*หนองบัวลำภู', N'*Nong Bua Lam Phu', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (433, N'*ศรีบุญเรือง', N'*Si Bun Rueang', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (434, N'*นากลาง', N'*Na Klang', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (435, N'*สุวรรณคูหา', N'*Suwannakhuha', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (436, N'*โนนสัง', N'*Non Sang', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (437, N'บ้านผือ', N'Ban Phue', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (438, N'น้ำโสม', N'Nam Som', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (439, N'เพ็ญ', N'Phen', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (440, N'สร้างคอม', N'Sang Khom', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (441, N'หนองแสง', N'Nong Saeng', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (442, N'นายูง', N'Na Yung', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (443, N'พิบูลย์รักษ์', N'Phibun Rak', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (444, N'กู่แก้ว', N'Ku Kaeo', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (445, N'ประจักษ์ศิลปาคม', N'rachak-sinlapakhom', 29, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (446, N'เมืองเลย', N'Mueang Loei', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (447, N'นาด้วง', N'Na Duang', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (448, N'เชียงคาน', N'Chiang Khan', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (449, N'ปากชม', N'Pak Chom', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (450, N'ด่านซ้าย', N'Dan Sai', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (451, N'นาแห้ว', N'Na Haeo', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (452, N'ภูเรือ', N'Phu Ruea', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (453, N'ท่าลี่', N'Tha Li', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (454, N'วังสะพุง', N'Wang Saphung', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (455, N'ภูกระดึง', N'Phu Kradueng', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (456, N'ภูหลวง', N'Phu Luang', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (457, N'ผาขาว', N'Pha Khao', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (458, N'เอราวัณ', N'Erawan', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (459, N'หนองหิน', N'Nong Hin', 30, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (460, N'เมืองหนองคาย', N'Mueang Nong Khai', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (461, N'ท่าบ่อ', N'Tha Bo', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (462, N'เมืองบึงกาฬ', N'Mueang Bueng Kan', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (463, N'พรเจริญ', N'Phon Charoen', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (464, N'โพนพิสัย', N'Phon Phisai', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (465, N'โซ่พิสัย', N'So Phisai', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (466, N'ศรีเชียงใหม่', N'Si Chiang Mai', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (467, N'สังคม', N'Sangkhom', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (468, N'เซกา', N'Seka', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (469, N'ปากคาด', N'Pak Khat', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (470, N'บึงโขงหลง', N'Bueng Khong Long', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (471, N'ศรีวิไล', N'Si Wilai', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (472, N'บุ่งคล้า', N'Bung Khla', 97, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (473, N'สระใคร', N'Sakhrai', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (474, N'เฝ้าไร่', N'Fao Rai', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (475, N'รัตนวาปี', N'Rattanawapi', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (476, N'โพธิ์ตาก', N'Pho Tak', 31, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (477, N'เมืองมหาสารคาม', N'Mueang Maha Sarakham', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (478, N'แกดำ', N'Kae Dam', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (479, N'โกสุมพิสัย', N'Kosum Phisai', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (480, N'กันทรวิชัย', N'Kantharawichai', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (481, N'เชียงยืน', N'Kantharawichai', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (482, N'บรบือ', N'Borabue', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (483, N'นาเชือก', N'Na Chueak', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (484, N'พยัคฆภูมิพิสัย', N'Phayakkhaphum Phisai', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (485, N'วาปีปทุม', N'Wapi Pathum', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (486, N'นาดูน', N'Na Dun', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (487, N'ยางสีสุราช', N'Yang Sisurat', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (488, N'กุดรัง', N'Kut Rang', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (489, N'ชื่นชม', N'Chuen Chom', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (490, N'*หลุบ', N'*Lub', 32, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (491, N'เมืองร้อยเอ็ด', N'Mueang Roi Et', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (492, N'เกษตรวิสัย', N'Kaset Wisai', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (493, N'ปทุมรัตต์', N'Pathum Rat', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (494, N'จตุรพักตรพิมาน', N'Chaturaphak Phiman', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (495, N'ธวัชบุรี', N'Thawat Buri', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (496, N'พนมไพร', N'Phanom Phrai', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (497, N'โพนทอง', N'Phon Thong', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (498, N'โพธิ์ชัย', N'Pho Chai', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (499, N'หนองพอก', N'Nong Phok', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (500, N'เสลภูมิ', N'Selaphum', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (501, N'สุวรรณภูมิ', N'Suwannaphum', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (502, N'เมืองสรวง', N'Mueang Suang', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (503, N'โพนทราย', N'Phon Sai', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (504, N'อาจสามารถ', N'At Samat', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (505, N'เมยวดี', N'Moei Wadi', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (506, N'ศรีสมเด็จ', N'Si Somdet', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (507, N'จังหาร', N'Changhan', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (508, N'เชียงขวัญ', N'Chiang Khwan', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (509, N'หนองฮี', N'Nong Hi', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (510, N'ทุ่งเขาหลวง', N'Thung Khao Luangกิ่', 33, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (511, N'เมืองกาฬสินธุ์', N'Mueang Kalasin', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (512, N'นามน', N'Na Mon', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (513, N'กมลาไสย', N'Kamalasai', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (514, N'ร่องคำ', N'Rong Kham', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (515, N'กุฉินารายณ์', N'Kuchinarai', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (516, N'เขาวง', N'Khao Wong', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (517, N'ยางตลาด', N'Yang Talat', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (518, N'ห้วยเม็ก', N'Huai Mek', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (519, N'สหัสขันธ์', N'Sahatsakhan', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (520, N'คำม่วง', N'Kham Muang', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (521, N'ท่าคันโท', N'Tha Khantho', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (522, N'หนองกุงศรี', N'Nong Kung Si', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (523, N'สมเด็จ', N'Somdet', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (524, N'ห้วยผึ้ง', N'Huai Phueng', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (525, N'สามชัย', N'Sam Chai', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (526, N'นาคู', N'Na Khu', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (527, N'ดอนจาน', N'Don Chan', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (528, N'ฆ้องชัย', N'Khong Chai', 34, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (529, N'เมืองสกลนคร', N'Mueang Sakon Nakhon', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (530, N'กุสุมาลย์', N'Kusuman', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (531, N'กุดบาก', N'Kut Bak', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (532, N'พรรณานิคม', N'Phanna Nikhom', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (533, N'พังโคน', N'Phang Khon', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (534, N'วาริชภูมิ', N'Waritchaphum', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (535, N'นิคมน้ำอูน', N'Nikhom Nam Un', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (536, N'วานรนิวาส', N'Wanon Niwat', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (537, N'คำตากล้า', N'Kham Ta Kla', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (538, N'บ้านม่วง', N'Ban Muang', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (539, N'อากาศอำนวย', N'Akat Amnuai', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (540, N'สว่างแดนดิน', N'Sawang Daen Din', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (541, N'ส่องดาว', N'Song Dao', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (542, N'เต่างอย', N'Tao Ni', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (543, N'โคกศรีสุพรรณ', N'Khok Si Suphan', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (544, N'เจริญศิลป์', N'Charoen Sin', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (545, N'โพนนาแก้ว', N'Phon Na Kaeo', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (546, N'ภูพาน', N'Phu Phan', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (547, N'วานรนิวาส*', N'Wanon Niwat', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (548, N'*อ.บ้านหัน  จ.สกลนคร', N'*Banhan', 35, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (549, N'เมืองนครพนม', N'Mueang Nakhon Phanom', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (550, N'ปลาปาก', N'Pla Pak', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (551, N'ท่าอุเทน', N'Tha Uthen', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (552, N'บ้านแพง', N'Ban Phaeng', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (553, N'ธาตุพนม', N'That Phanom', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (554, N'เรณูนคร', N'Renu Nakhon', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (555, N'นาแก', N'Na Kae', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (556, N'ศรีสงคราม', N'Si Songkhram', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (557, N'นาหว้า', N'Na Wa', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (558, N'โพนสวรรค์', N'Phon Sawan', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (559, N'นาทม', N'Na Thom', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (560, N'วังยาง', N'Wang Yang', 36, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (561, N'เมืองมุกดาหาร', N'Mueang Mukdahan', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (562, N'นิคมคำสร้อย', N'Nikhom Kham Soi', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (563, N'ดอนตาล', N'Don Tan', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (564, N'ดงหลวง', N'Dong Luang', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (565, N'คำชะอี', N'Khamcha-i', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (566, N'หว้านใหญ่', N'Wan Yai', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (567, N'หนองสูง', N'Nong Sung', 37, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (568, N'เมืองเชียงใหม่', N'Mueang Chiang Mai', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (569, N'จอมทอง', N'Chom Thong', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (570, N'แม่แจ่ม', N'Mae Chaem', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (571, N'เชียงดาว', N'Chiang Dao', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (572, N'ดอยสะเก็ด', N'Doi Saket', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (573, N'แม่แตง', N'Mae Taeng', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (574, N'แม่ริม', N'Mae Rim', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (575, N'สะเมิง', N'Samoeng', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (576, N'ฝาง', N'Fang', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (577, N'แม่อาย', N'Mae Ai', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (578, N'พร้าว', N'Phrao', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (579, N'สันป่าตอง', N'San Pa Tong', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (580, N'สันกำแพง', N'San Kamphaeng', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (581, N'สันทราย', N'San Sai', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (582, N'หางดง', N'Hang Dong', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (583, N'ฮอด', N'Hot', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (584, N'ดอยเต่า', N'Doi Tao', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (585, N'อมก๋อย', N'Omkoi', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (586, N'สารภี', N'Saraphi', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (587, N'เวียงแหง', N'Wiang Haeng', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (588, N'ไชยปราการ', N'Chai Prakan', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (589, N'แม่วาง', N'Mae Wang', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (590, N'แม่ออน', N'Mae On', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (591, N'ดอยหล่อ', N'Doi Lo', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (592, N'เทศบาลนครเชียงใหม่(แขวงกาลวิละ)*', N'Tet Saban Nakorn Chiangmai(Kan lawi la)*', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (593, N'เทศบาลนครเชียงใหม่(แขวงศรีวิชั)*', N'Tet Saban Nakorn Chiangmai(Sri Wi)*', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (594, N'เทศบาลนครเชียงใหม่(แขวงเม็งราย)*', N'Tet Saban Nakorn Chiangmai(Meng Rai)*', 38, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (595, N'เมืองลำพูน', N'Mueang Lamphun', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (596, N'แม่ทา', N'Mae Tha', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (597, N'บ้านโฮ่ง', N'Ban Hong', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (598, N'ลี้', N'Li', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (599, N'ทุ่งหัวช้าง', N'Thung Hua Chang', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (600, N'ป่าซาง', N'Pa Sang', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (601, N'บ้านธิ', N'Ban Thi', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (602, N'เวียงหนองล่อง', N'Wiang Nong Long', 39, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (603, N'เมืองลำปาง', N'Mueang Lampang', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (604, N'แม่เมาะ', N'Mae Mo', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (605, N'เกาะคา', N'Ko Kha', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (606, N'เสริมงาม', N'Soem Ngam', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (607, N'งาว', N'Ngao', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (608, N'แจ้ห่ม', N'Chae Hom', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (609, N'วังเหนือ', N'Wang Nuea', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (610, N'เถิน', N'Thoen', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (611, N'แม่พริก', N'Mae Phrik', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (612, N'แม่ทะ', N'Mae Tha', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (613, N'สบปราบ', N'Sop Prap', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (614, N'ห้างฉัตร', N'Hang Chat', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (615, N'เมืองปาน', N'Mueang Pan', 40, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (616, N'เมืองอุตรดิตถ์', N'Mueang Uttaradit', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (617, N'ตรอน', N'Tron', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (618, N'ท่าปลา', N'Tha Pla', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (619, N'น้ำปาด', N'Nam Pat', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (620, N'ฟากท่า', N'Fak Tha', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (621, N'บ้านโคก', N'Ban Khok', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (622, N'พิชัย', N'Phichai', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (623, N'ลับแล', N'Laplae', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (624, N'ทองแสนขัน', N'Thong Saen Khan', 41, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (625, N'เมืองแพร่', N'Mueang Phrae', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (626, N'ร้องกวาง', N'Rong Kwang', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (627, N'ลอง', N'Long', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (628, N'สูงเม่น', N'Sung Men', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (629, N'เด่นชัย', N'Den Chai', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (630, N'สอง', N'Song', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (631, N'วังชิ้น', N'Wang Chin', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (632, N'หนองม่วงไข่', N'Nong Muang Khai', 42, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (633, N'เมืองน่าน', N'Mueang Nan', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (634, N'แม่จริม', N'Mae Charim', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (635, N'บ้านหลวง', N'Ban Luang', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (636, N'นาน้อย', N'Na Noi', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (637, N'ปัว', N'Pua', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (638, N'ท่าวังผา', N'Tha Wang Pha', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (639, N'เวียงสา', N'Wiang Sa', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (640, N'ทุ่งช้าง', N'Thung Chang', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (641, N'เชียงกลาง', N'Chiang Klang', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (642, N'นาหมื่น', N'Na Muen', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (643, N'สันติสุข', N'Santi Suk', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (644, N'บ่อเกลือ', N'Bo Kluea', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (645, N'สองแคว', N'Song Khwae', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (646, N'ภูเพียง', N'Phu Phiang', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (647, N'เฉลิมพระเกียรติ', N'Chaloem Phra Kiat', 43, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (648, N'เมืองพะเยา', N'Mueang Phayao', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (649, N'จุน', N'Chun', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (650, N'เชียงคำ', N'Chiang Kham', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (651, N'เชียงม่วน', N'Chiang Muan', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (652, N'ดอกคำใต้', N'Dok Khamtai', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (653, N'ปง', N'Pong', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (654, N'แม่ใจ', N'Mae Chai', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (655, N'ภูซาง', N'Phu Sang', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (656, N'ภูกามยาว', N'Phu Kamyao', 44, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (657, N'เมืองเชียงราย', N'Mueang Chiang Rai', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (658, N'เวียงชัย', N'Wiang Chai', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (659, N'เชียงของ', N'Chiang Khong', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (660, N'เทิง', N'Thoeng', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (661, N'พาน', N'Phan', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (662, N'ป่าแดด', N'Pa Daet', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (663, N'แม่จัน', N'Mae Chan', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (664, N'เชียงแสน', N'Chiang Saen', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (665, N'แม่สาย', N'Mae Sai', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (666, N'แม่สรวย', N'Mae Suai', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (667, N'เวียงป่าเป้า', N'Wiang Pa Pao', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (668, N'พญาเม็งราย', N'Phaya Mengrai', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (669, N'เวียงแก่น', N'Wiang Kaen', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (670, N'ขุนตาล', N'Khun Tan', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (671, N'แม่ฟ้าหลวง', N'Mae Fa Luang', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (672, N'แม่ลาว', N'Mae Lao', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (673, N'เวียงเชียงรุ้ง', N'Wiang Chiang Rung', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (674, N'ดอยหลวง', N'Doi Luang', 45, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (675, N'เมืองแม่ฮ่องสอน', N'Mueang Mae Hong Son', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (676, N'ขุนยวม', N'Khun Yuam', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (677, N'ปาย', N'Pai', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (678, N'แม่สะเรียง', N'Mae Sariang', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (679, N'แม่ลาน้อย', N'Mae La Noi', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (680, N'สบเมย', N'Sop Moei', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (681, N'ปางมะผ้า', N'Pang Mapha', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (682, N'*อ.ม่วยต่อ  จ.แม่ฮ่องสอน', N'Muen Tor', 46, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (683, N'เมืองนครสวรรค์', N'Mueang Nakhon Sawan', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (684, N'โกรกพระ', N'Krok Phra', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (685, N'ชุมแสง', N'Chum Saeng', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (686, N'หนองบัว', N'Nong Bua', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (687, N'บรรพตพิสัย', N'Banphot Phisai', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (688, N'เก้าเลี้ยว', N'Kao Liao', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (689, N'ตาคลี', N'Takhli', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (690, N'ท่าตะโก', N'Takhli', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (691, N'ไพศาลี', N'Phaisali', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (692, N'พยุหะคีรี', N'Phayuha Khiri', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (693, N'ลาดยาว', N'Phayuha Khiri', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (694, N'ตากฟ้า', N'Tak Fa', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (695, N'แม่วงก์', N'Mae Wong', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (696, N'แม่เปิน', N'Mae Poen', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (697, N'ชุมตาบง', N'Chum Ta Bong', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (698, N'สาขาตำบลห้วยน้ำหอม*', N'Huen Nam Hom', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (699, N'กิ่งอำเภอชุมตาบง', N'Chum Ta Bong', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (700, N'แม่วงก์*', N'Mea Ley', 47, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (701, N'เมืองอุทัยธานี', N'Mueang Uthai Thani', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (702, N'ทัพทัน', N'Thap Than', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (703, N'สว่างอารมณ์', N'Sawang Arom', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (704, N'หนองฉาง', N'Nong Chang', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (705, N'หนองขาหย่าง', N'Nong Khayang', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (706, N'บ้านไร่', N'Ban Rai', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (707, N'ลานสัก', N'Lan Sak', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (708, N'ห้วยคต', N'Huai Khot', 48, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (709, N'เมืองกำแพงเพชร', N'Mueang Kamphaeng Phet', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (710, N'ไทรงาม', N'Sai Ngam', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (711, N'คลองลาน', N'Khlong Lan', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (712, N'ขาณุวรลักษบุรี', N'Khanu Woralaksaburi', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (713, N'คลองขลุง', N'Khlong Khlung', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (714, N'พรานกระต่าย', N'Phran Kratai', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (715, N'ลานกระบือ', N'Lan Krabue', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (716, N'ทรายทองวัฒนา', N'Sai Thong Watthana', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (717, N'ปางศิลาทอง', N'Pang Sila Thong', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (718, N'บึงสามัคคี', N'Bueng Samakkhi', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (719, N'โกสัมพีนคร', N'Kosamphi Nakhon', 49, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (720, N'เมืองตาก', N'Mueang Tak', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (721, N'บ้านตาก', N'Ban Tak', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (722, N'สามเงา', N'Sam Ngao', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (723, N'แม่ระมาด', N'Mae Ramat', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (724, N'ท่าสองยาง', N'Tha Song Yang', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (725, N'แม่สอด', N'Mae Sot', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (726, N'พบพระ', N'Phop Phra', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (727, N'อุ้มผาง', N'Umphang', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (728, N'วังเจ้า', N'Wang Chao', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (729, N'*กิ่ง อ.ท่าปุย  จ.ตาก', N'*King Ta Pui', 50, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (730, N'เมืองสุโขทัย', N'Mueang Sukhothai', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (731, N'บ้านด่านลานหอย', N'Ban Dan Lan Hoi', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (732, N'คีรีมาศ', N'Khiri Mat', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (733, N'กงไกรลาศ', N'Kong Krailat', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (734, N'ศรีสัชนาลัย', N'Si Satchanalai', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (735, N'ศรีสำโรง', N'Si Samrong', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (736, N'สวรรคโลก', N'Sawankhalok', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (737, N'ศรีนคร', N'Si Nakhon', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (738, N'ทุ่งเสลี่ยม', N'Thung Saliam', 51, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (739, N'เมืองพิษณุโลก', N'Mueang Phitsanulok', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (740, N'นครไทย', N'Nakhon Thai', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (741, N'ชาติตระการ', N'Chat Trakan', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (742, N'บางระกำ', N'Bang Rakam', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (743, N'บางกระทุ่ม', N'Bang Krathum', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (744, N'พรหมพิราม', N'Phrom Phiram', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (745, N'วัดโบสถ์', N'Wat Bot', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (746, N'วังทอง', N'Wang Thong', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (747, N'เนินมะปราง', N'Noen Maprang', 52, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (748, N'เมืองพิจิตร', N'Mueang Phichit', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (749, N'วังทรายพูน', N'Wang Sai Phun', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (750, N'โพธิ์ประทับช้าง', N'Pho Prathap Chang', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (751, N'ตะพานหิน', N'Taphan Hin', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (752, N'บางมูลนาก', N'Bang Mun Nak', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (753, N'โพทะเล', N'Pho Thale', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (754, N'สามง่าม', N'Sam Ngam', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (755, N'ทับคล้อ', N'Tap Khlo', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (756, N'สากเหล็ก', N'Sak Lek', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (757, N'บึงนาราง', N'Bueng Na Rang', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (758, N'ดงเจริญ', N'Dong Charoen', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (759, N'วชิรบารมี', N'Wachirabarami', 53, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (760, N'เมืองเพชรบูรณ์', N'Mueang Phetchabun', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (761, N'ชนแดน', N'Chon Daen', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (762, N'หล่มสัก', N'Lom Sak', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (763, N'หล่มเก่า', N'Lom Kao', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (764, N'วิเชียรบุรี', N'Wichian Buri', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (765, N'ศรีเทพ', N'Si Thep', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (766, N'หนองไผ่', N'Nong Phai', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (767, N'บึงสามพัน', N'Bueng Sam Phan', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (768, N'น้ำหนาว', N'Nam Nao', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (769, N'วังโป่ง', N'Wang Pong', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (770, N'เขาค้อ', N'Khao Kho', 54, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (771, N'เมืองราชบุรี', N'Mueang Ratchaburi', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (772, N'จอมบึง', N'Chom Bueng', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (773, N'สวนผึ้ง', N'Suan Phueng', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (774, N'ดำเนินสะดวก', N'Damnoen Saduak', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (775, N'บ้านโป่ง', N'Ban Pong', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (776, N'บางแพ', N'Bang Phae', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (777, N'โพธาราม', N'Photharam', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (778, N'ปากท่อ', N'Pak Tho', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (779, N'วัดเพลง', N'Wat Phleng', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (780, N'บ้านคา', N'Ban Kha', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (781, N'ท้องถิ่นเทศบาลตำบลบ้านฆ้อง', N'Tet Saban Ban Kong', 55, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (782, N'เมืองกาญจนบุรี', N'Mueang Kanchanaburi', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (783, N'ไทรโยค', N'Sai Yok', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (784, N'บ่อพลอย', N'Bo Phloi', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (785, N'ศรีสวัสดิ์', N'Si Sawat', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (786, N'ท่ามะกา', N'Tha Maka', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (787, N'ท่าม่วง', N'Tha Muang', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (788, N'ทองผาภูมิ', N'Pha Phum', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (789, N'สังขละบุรี', N'Sangkhla Buri', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (790, N'พนมทวน', N'Phanom Thuan', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (791, N'เลาขวัญ', N'Lao Khwan', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (792, N'ด่านมะขามเตี้ย', N'Dan Makham Tia', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (793, N'หนองปรือ', N'Nong Prue', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (794, N'ห้วยกระเจา', N'Huai Krachao', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (795, N'สาขาตำบลท่ากระดาน*', N'Tha Kra Dan', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (796, N'*บ้านทวน  จ.กาญจนบุรี', N'*Ban Tuan', 56, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (797, N'เมืองสุพรรณบุรี', N'Mueang Suphan Buri', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (798, N'เดิมบางนางบวช', N'Doem Bang Nang Buat', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (799, N'ด่านช้าง', N'Dan Chang', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (800, N'บางปลาม้า', N'Bang Pla Ma', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (801, N'ศรีประจันต์', N'Si Prachan', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (802, N'ดอนเจดีย์', N'Don Chedi', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (803, N'สองพี่น้อง', N'Song Phi Nong', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (804, N'สามชุก', N'Sam Chuk', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (805, N'อู่ทอง', N'U Thong', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (806, N'หนองหญ้าไซ', N'Nong Ya Sai', 57, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (807, N'เมืองนครปฐม', N'Mueang Nakhon Pathom', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (808, N'กำแพงแสน', N'Kamphaeng Saen', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (809, N'นครชัยศรี', N'Nakhon Chai Si', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (810, N'ดอนตูม', N'Don Tum', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (811, N'บางเลน', N'Bang Len', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (812, N'สามพราน', N'Sam Phran', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (813, N'พุทธมณฑล', N'Phutthamonthon', 58, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (814, N'เมืองสมุทรสาคร', N'Mueang Samut Sakhon', 59, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (815, N'กระทุ่มแบน', N'Krathum Baen', 59, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (816, N'บ้านแพ้ว', N'Ban Phaeo', 59, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (817, N'เมืองสมุทรสงคราม', N'Mueang Samut Songkhram', 60, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (818, N'บางคนที', N'Bang Khonthi', 60, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (819, N'อัมพวา', N'Amphawa', 60, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (820, N'เมืองเพชรบุรี', N'Mueang Phetchaburi', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (821, N'เขาย้อย', N'Khao Yoi', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (822, N'หนองหญ้าปล้อง', N'Nong Ya Plong', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (823, N'ชะอำ', N'Cha-am', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (824, N'ท่ายาง', N'Tha Yang', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (825, N'บ้านลาด', N'Ban Lat', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (826, N'บ้านแหลม', N'Ban Laem', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (827, N'แก่งกระจาน', N'Kaeng Krachan', 61, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (828, N'เมืองประจวบคีรีขันธ์', N'Mueang Prachuap Khiri Khan', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (829, N'กุยบุรี', N'Kui Buri', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (830, N'ทับสะแก', N'Thap Sakae', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (831, N'บางสะพาน', N'Bang Saphan', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (832, N'บางสะพานน้อย', N'Bang Saphan Noi', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (833, N'ปราณบุรี', N'Pran Buri', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (834, N'หัวหิน', N'Hua Hin', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (835, N'สามร้อยยอด', N'Sam Roi Yot', 62, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (836, N'เมืองนครศรีธรรมราช', N'Mueang Nakhon Si Thammarat', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (837, N'พรหมคีรี', N'Phrom Khiri', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (838, N'ลานสกา', N'Lan Saka', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (839, N'ฉวาง', N'Chawang', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (840, N'พิปูน', N'Phipun', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (841, N'เชียรใหญ่', N'Chian Yai', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (842, N'ชะอวด', N'Cha-uat', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (843, N'ท่าศาลา', N'Tha Sala', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (844, N'ทุ่งสง', N'Thung Song', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (845, N'นาบอน', N'Na Bon', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (846, N'ทุ่งใหญ่', N'Thung Yai', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (847, N'ปากพนัง', N'Pak Phanang', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (848, N'ร่อนพิบูลย์', N'Ron Phibun', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (849, N'สิชล', N'Sichon', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (850, N'ขนอม', N'Khanom', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (851, N'หัวไทร', N'Hua Sai', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (852, N'บางขัน', N'Bang Khan', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (853, N'ถ้ำพรรณรา', N'Tham Phannara', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (854, N'จุฬาภรณ์', N'Chulabhorn', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (855, N'พระพรหม', N'Phra Phrom', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (856, N'นบพิตำ', N'Nopphitam', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (857, N'ช้างกลาง', N'Chang Klang', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (858, N'เฉลิมพระเกียรติ', N'Chaloem Phra Kiat', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (859, N'เชียรใหญ่', N'Chian Yai*', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (860, N'สาขาตำบลสวนหลวง**', N'Suan Luang', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (861, N'ร่อนพิบูลย์*', N'Ron Phibun', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (862, N'หัวไทร*', N'Hua Sai', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (863, N'ทุ่งสง*', N'Thung Song', 63, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (864, N'เมืองกระบี่', N'Mueang Krabi', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (865, N'เขาพนม', N'Khao Phanom', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (866, N'เกาะลันตา', N'Ko Lanta', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (867, N'คลองท่อม', N'Khlong Thom', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (868, N'อ่าวลึก', N'Ao Luek', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (869, N'ปลายพระยา', N'Plai Phraya', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (870, N'ลำทับ', N'Lam Thap', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (871, N'เหนือคลอง', N'Nuea Khlong', 64, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (872, N'เมืองพังงา', N'Mueang Phang-nga', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (873, N'เกาะยาว', N'Ko Yao', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (874, N'กะปง', N'Kapong', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (875, N'ตะกั่วทุ่ง', N'Takua Thung', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (876, N'ตะกั่วป่า', N'Takua Pa', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (877, N'คุระบุรี', N'Khura Buri', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (878, N'ทับปุด', N'Thap Put', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (879, N'ท้ายเหมือง', N'Thai Mueang', 65, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (880, N'เมืองภูเก็ต', N'Mueang Phuket', 66, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (881, N'กะทู้', N'Kathu', 66, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (882, N'ถลาง', N'Thalang', 66, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (883, N'*ทุ่งคา', N'*Tung Ka', 66, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (884, N'เมืองสุราษฎร์ธานี', N'Mueang Surat Thani', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (885, N'กาญจนดิษฐ์', N'Kanchanadit', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (886, N'ดอนสัก', N'Don Sak', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (887, N'เกาะสมุย', N'Ko Samui', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (888, N'เกาะพะงัน', N'Ko Pha-ngan', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (889, N'ไชยา', N'Chaiya', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (890, N'ท่าชนะ', N'Tha Chana', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (891, N'คีรีรัฐนิคม', N'Khiri Rat Nikhom', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (892, N'บ้านตาขุน', N'Ban Ta Khun', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (893, N'พนม', N'Phanom', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (894, N'ท่าฉาง', N'Tha Chang', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (895, N'บ้านนาสาร', N'Ban Na San', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (896, N'บ้านนาเดิม', N'Ban Na Doem', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (897, N'เคียนซา', N'Khian Sa', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (898, N'เวียงสระ', N'Wiang Sa', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (899, N'พระแสง', N'Phrasaeng', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (900, N'พุนพิน', N'Phunphin', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (901, N'ชัยบุรี', N'Chai Buri', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (902, N'วิภาวดี', N'Vibhavadi', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (903, N'เกาะพงัน*', N'Ko Pha-ngan', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (904, N'*อ.บ้านดอน  จ.สุราษฎร์ธานี', N'*Ban Don', 67, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (905, N'เมืองระนอง', N'Mueang Ranong', 68, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (906, N'ละอุ่น', N'La-un', 68, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (907, N'กะเปอร์', N'Kapoe', 68, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (908, N'กระบุรี', N'Kra Buri', 68, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (909, N'สุขสำราญ', N'Suk Samran', 68, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (910, N'เมืองชุมพร', N'Mueang Chumphon', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (911, N'ท่าแซะ', N'Tha Sae', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (912, N'ปะทิว', N'Pathio', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (913, N'หลังสวน', N'Lang Suan', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (914, N'ละแม', N'Lamae', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (915, N'พะโต๊ะ', N'Phato', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (916, N'สวี', N'Sawi', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (917, N'ทุ่งตะโก', N'Thung Tako', 69, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (918, N'เมืองสงขลา', N'Mueang Songkhla', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (919, N'สทิงพระ', N'Sathing Phra', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (920, N'จะนะ', N'Chana', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (921, N'นาทวี', N'Na Thawi', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (922, N'เทพา', N'Thepha', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (923, N'สะบ้าย้อย', N'Saba Yoi', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (924, N'ระโนด', N'Ranot', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (925, N'กระแสสินธุ์', N'Krasae Sin', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (926, N'รัตภูมิ', N'Rattaphum', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (927, N'สะเดา', N'Sadao', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (928, N'หาดใหญ่', N'Hat Yai', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (929, N'นาหม่อม', N'Na Mom', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (930, N'ควนเนียง', N'Khuan Niang', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (931, N'บางกล่ำ', N'Bang Klam', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (932, N'สิงหนคร', N'Singhanakhon', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (933, N'คลองหอยโข่ง', N'Khlong Hoi Khong', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (934, N'ท้องถิ่นเทศบาลตำบลสำนักขาม', N'Sum Nung Kam', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (935, N'เทศบาลตำบลบ้านพรุ*', N'Ban Pru*', 70, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (936, N'เมืองสตูล', N'Mueang Satun', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (937, N'ควนโดน', N'Khuan Don', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (938, N'ควนกาหลง', N'Khuan Kalong', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (939, N'ท่าแพ', N'Tha Phae', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (940, N'ละงู', N'La-ngu', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (941, N'ทุ่งหว้า', N'Thung Wa', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (942, N'มะนัง', N'Manang', 71, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (943, N'เมืองตรัง', N'Mueang Trang', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (944, N'กันตัง', N'Kantang', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (945, N'ย่านตาขาว', N'Yan Ta Khao', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (946, N'ปะเหลียน', N'Palian', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (947, N'สิเกา', N'Sikao', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (948, N'ห้วยยอด', N'Huai Yot', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (949, N'วังวิเศษ', N'Wang Wiset', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (950, N'นาโยง', N'Na Yong', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (951, N'รัษฎา', N'Ratsada', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (952, N'หาดสำราญ', N'Hat Samran', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (953, N'อำเภอเมืองตรัง', N'Mueang Trang', 72, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (954, N'เมืองพัทลุง', N'Mueang Phatthalung', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (955, N'กงหรา', N'Kong Ra', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (956, N'เขาชัยสน', N'Khao Chaison', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (957, N'ตะโหมด', N'Tamot', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (958, N'ควนขนุน', N'Khuan Khanun', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (959, N'ปากพะยูน', N'Pak Phayun', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (960, N'ศรีบรรพต', N'Si Banphot', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (961, N'ป่าบอน', N'Pa Bon', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (962, N'บางแก้ว', N'Bang Kaeo', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (963, N'ป่าพะยอม', N'Pa Phayom', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (964, N'ศรีนครินทร์', N'Srinagarindra', 73, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (965, N'เมืองปัตตานี', N'Mueang Pattani', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (966, N'โคกโพธิ์', N'Khok Pho', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (967, N'หนองจิก', N'Nong Chik', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (968, N'ปะนาเระ', N'Panare', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (969, N'มายอ', N'Mayo', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (970, N'ทุ่งยางแดง', N'Thung Yang Daeng', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (971, N'สายบุรี', N'Sai Buri', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (972, N'ไม้แก่น', N'Mai Kaen', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (973, N'ยะหริ่ง', N'Yaring', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (974, N'ยะรัง', N'Yarang', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (975, N'กะพ้อ', N'Kapho', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (976, N'แม่ลาน', N'Mae Lan', 74, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (977, N'เมืองยะลา', N'Mueang Yala', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (978, N'เบตง', N'Betong', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (979, N'บันนังสตา', N'Bannang Sata', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (980, N'ธารโต', N'Than To', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (981, N'ยะหา', N'Yaha', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (982, N'รามัน', N'Raman', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (983, N'กาบัง', N'Kabang', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (984, N'กรงปินัง', N'Krong Pinang', 75, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (985, N'เมืองนราธิวาส', N'Mueang Narathiwat', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (986, N'ตากใบ', N'Tak Bai', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (987, N'บาเจาะ', N'Bacho', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (988, N'ยี่งอ', N'Yi-n', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (989, N'ระแงะ', N'Ra-ngae', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (990, N'รือเสาะ', N'Rueso', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (991, N'ศรีสาคร', N'Si Sakhon', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (992, N'แว้ง', N'Waeng', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (993, N'สุคิริน', N'Sukhirin', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (994, N'สุไหงโก-ลก', N'Su-ngai Kolok', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (995, N'สุไหงปาดี', N'Su-ngai Padi', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (996, N'จะแนะ', N'Chanae', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (997, N'เจาะไอร้อง', N'Cho-airong', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (998, N'*อ.บางนรา  จ.นราธิวาส', N'*Bang Nra', 76, 1)

INSERT [dbo].[Districts] ([DistrictId], [DistrictNameTH], [DistrictNameENG], [ProvinceId], [Active]) VALUES (999, N'212121', N'212121', 76, 1)

SET IDENTITY_INSERT [dbo].[Gender] ON 


INSERT [dbo].[Gender] ([GenderId], [GenderName], [Active]) VALUES (1, N'ชาย', 1)

INSERT [dbo].[Gender] ([GenderId], [GenderName], [Active]) VALUES (2, N'หญิง', 1)

SET IDENTITY_INSERT [dbo].[Gender] OFF

SET IDENTITY_INSERT [dbo].[ItemUnit] ON 


INSERT [dbo].[ItemUnit] ([ItemUnitId], [MatId], [ItemUnitName], [Multiply], [UnitUseId], [UnitUseName], [TypeUnitId], [Active], [ItemUnitDetail]) VALUES (1, NULL, N'แก้ว', CAST(1.000000 AS Decimal(18, 6)), NULL, NULL, NULL, 1, NULL)

INSERT [dbo].[ItemUnit] ([ItemUnitId], [MatId], [ItemUnitName], [Multiply], [UnitUseId], [UnitUseName], [TypeUnitId], [Active], [ItemUnitDetail]) VALUES (2, NULL, N'กรัม', CAST(1.000000 AS Decimal(18, 6)), NULL, NULL, NULL, 1, NULL)

INSERT [dbo].[ItemUnit] ([ItemUnitId], [MatId], [ItemUnitName], [Multiply], [UnitUseId], [UnitUseName], [TypeUnitId], [Active], [ItemUnitDetail]) VALUES (3, NULL, N'กิโลกรัม', CAST(1000.000000 AS Decimal(18, 6)), NULL, NULL, NULL, 1, NULL)

SET IDENTITY_INSERT [dbo].[ItemUnit] OFF

SET IDENTITY_INSERT [dbo].[Nationality] ON 


INSERT [dbo].[Nationality] ([NationalityId], [NationalityNameTH], [NationalityNameEN], [Active]) VALUES (1, N'ไทย', N'Thai', 1)

SET IDENTITY_INSERT [dbo].[Nationality] OFF

SET IDENTITY_INSERT [dbo].[PaymentType] ON 


INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (9, N'เงินสด', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (10, N'โอนผ่านธนาคาร', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (11, N'บัตรเครดิต', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (12, N'บัตรเงินสด', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (13, N'คูปอง', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (14, N'Voucher', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (15, N'QR Thai', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (16, N'QR Alipay', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (17, N'QR WeChat', 1)

INSERT [dbo].[PaymentType] ([PaymentId], [PaymentName], [Active]) VALUES (18, N'Gift Card', 1)

SET IDENTITY_INSERT [dbo].[PaymentType] OFF

SET IDENTITY_INSERT [dbo].[PayType] ON 


INSERT [dbo].[PayType] ([PayTypeId], [PayTypeNameTH], [PayTypeNameEN]) VALUES (1, N'แรง', N'P')

INSERT [dbo].[PayType] ([PayTypeId], [PayTypeNameTH], [PayTypeNameEN]) VALUES (2, N'เดือน', N'M')

INSERT [dbo].[PayType] ([PayTypeId], [PayTypeNameTH], [PayTypeNameEN]) VALUES (3, N'วัน', N'Day')

INSERT [dbo].[PayType] ([PayTypeId], [PayTypeNameTH], [PayTypeNameEN]) VALUES (4, N'ชั่วโมง', N'H')

SET IDENTITY_INSERT [dbo].[PayType] OFF

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (1, 1, N'กรุงเทพมหานคร', N'Bangkok', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (2, 1, N'สมุทรปราการ', N'Samut Prakan', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (3, 1, N'นนทบุรี', N'Nonthaburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (4, 1, N'ปทุมธานี', N'Pathum Thani', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (5, 1, N'พระนครศรีอยุธยา', N'Phra Nakhon Si Ayutthaya', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (6, 1, N'อ่างทอง', N'Ang Thong', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (7, 1, N'ลพบุรี', N'Loburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (8, 1, N'สิงห์บุรี', N'Sing Buri', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (9, 1, N'ชัยนาท', N'Chai Nat', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (10, 1, N'สระบุรี', N'Saraburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (11, 1, N'ชลบุรี', N'Chon Buri', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (12, 1, N'ระยอง', N'Rayong', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (13, 1, N'จันทบุรี', N'Chanthaburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (14, 1, N'ตราด', N'Trat', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (15, 1, N'ฉะเชิงเทรา', N'Chachoengsao', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (16, 1, N'ปราจีนบุรี', N'Prachin Buri', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (17, 1, N'นครนายก', N'Nakhon Nayok', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (18, 1, N'สระแก้ว', N'Sa Kaeo', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (19, 1, N'นครราชสีมา', N'Nakhon Ratchasima', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (20, 1, N'บุรีรัมย์', N'Buri Ram', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (21, 1, N'สุรินทร์', N'Surin', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (22, 1, N'ศรีสะเกษ', N'Si Sa Ket', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (23, 1, N'อุบลราชธานี', N'Ubon Ratchathani', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (24, 1, N'ยโสธร', N'Yasothon', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (25, 1, N'ชัยภูมิ', N'Chaiyaphum', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (26, 1, N'อำนาจเจริญ', N'Amnat Charoen', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (27, 1, N'หนองบัวลำภู', N'Nong Bua Lam Phu', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (28, 1, N'ขอนแก่น', N'Khon Kaen', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (29, 1, N'อุดรธานี', N'Udon Thani', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (30, 1, N'เลย', N'Loei', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (31, 1, N'หนองคาย', N'Nong Khai', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (32, 1, N'มหาสารคาม', N'Maha Sarakham', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (33, 1, N'ร้อยเอ็ด', N'Roi Et', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (34, 1, N'กาฬสินธุ์', N'Kalasin', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (35, 1, N'สกลนคร', N'Sakon Nakhon', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (36, 1, N'นครพนม', N'Nakhon Phanom', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (37, 1, N'มุกดาหาร', N'Mukdahan', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (38, 1, N'เชียงใหม่', N'Chiang Mai', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (39, 1, N'ลำพูน', N'Lamphun', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (40, 1, N'ลำปาง', N'Lampang', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (41, 1, N'อุตรดิตถ์', N'Uttaradit', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (42, 1, N'แพร่', N'Phrae', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (43, 1, N'น่าน', N'Nan', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (44, 1, N'พะเยา', N'Phayao', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (45, 1, N'เชียงราย', N'Chiang Rai', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (46, 1, N'แม่ฮ่องสอน', N'Mae Hong Son', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (47, 1, N'นครสวรรค์', N'Nakhon Sawan', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (48, 1, N'อุทัยธานี', N'Uthai Thani', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (49, 1, N'กำแพงเพชร', N'Kamphaeng Phet', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (50, 1, N'ตาก', N'Tak', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (51, 1, N'สุโขทัย', N'Sukhothai', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (52, 1, N'พิษณุโลก', N'Phitsanulok', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (53, 1, N'พิจิตร', N'Phichit', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (54, 1, N'เพชรบูรณ์', N'Phetchabun', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (55, 1, N'ราชบุรี', N'Ratchaburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (56, 1, N'กาญจนบุรี', N'Kanchanaburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (57, 1, N'สุพรรณบุรี', N'Suphan Buri', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (58, 1, N'นครปฐม', N'Nakhon Pathom', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (59, 1, N'สมุทรสาคร', N'Samut Sakhon', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (60, 1, N'สมุทรสงคราม', N'Samut Songkhram', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (61, 1, N'เพชรบุรี', N'Phetchaburi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (62, 1, N'ประจวบคีรีขันธ์', N'Prachuap Khiri Khan', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (63, 1, N'นครศรีธรรมราช', N'Nakhon Si Thammarat', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (64, 1, N'กระบี่', N'Krabi', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (65, 1, N'พังงา', N'Phangnga', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (66, 1, N'ภูเก็ต', N'Phuket', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (67, 1, N'สุราษฎร์ธานี', N'Surat Thani', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (68, 1, N'ระนอง', N'Ranong', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (69, 1, N'ชุมพร', N'Chumphon', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (70, 1, N'สงขลา', N'Songkhla', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (71, 1, N'สตูล', N'Satun', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (72, 1, N'ตรัง', N'Trang', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (73, 1, N'พัทลุง', N'Phatthalung', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (74, 1, N'ปัตตานี', N'Pattani', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (75, 1, N'ยะลา', N'Yala', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (76, 1, N'นราธิวาส', N'Narathiwat', 1)

INSERT [dbo].[Provinces] ([ProvinceId], [CountryId], [ProvinceNameTH], [ProvinceNameENG], [Active]) VALUES (77, 1, N'บึงกาฬ', N'buogkan', 1)

SET IDENTITY_INSERT [dbo].[Roles] ON 


INSERT [dbo].[Roles] ([RoleId], [RoleName], [RoleNameEN], [Active]) VALUES (1, N'Admin', NULL, 1)

INSERT [dbo].[Roles] ([RoleId], [RoleName], [RoleNameEN], [Active]) VALUES (2, N'Manager', NULL, 1)

SET IDENTITY_INSERT [dbo].[Roles] OFF

SET IDENTITY_INSERT [dbo].[Setting] ON 


INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (1, N'PrinterReceipt', N'Snagit 13', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (2, N'ReceiptHeader1', N'FaceBook : ALW', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (3, N'ReceiptHeader2', N'www.cash-pos.com', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (4, N'ReceiptFooter1', N'Line ID : ALWCASHPOS', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (5, N'ReceiptFooter2', N'*****', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (6, N'AlwaysPrintReceipt', N'1', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (7, N'ShowBranchAddress', N'1', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (8, N'UsePosTable', N'1', 1, 1, 1)

INSERT [dbo].[Setting] ([SettingId], [SettingName], [SettingValue], [SettingTypeId], [TerminalId], [Active]) VALUES (9, N'PosImge', N'1', 1, 1, 1)

SET IDENTITY_INSERT [dbo].[Setting] OFF

SET IDENTITY_INSERT [dbo].[StatusSystem] ON 


INSERT [dbo].[StatusSystem] ([StatusId], [StatusName]) VALUES (1, N'Approve')

INSERT [dbo].[StatusSystem] ([StatusId], [StatusName]) VALUES (2, N'Pending')

INSERT [dbo].[StatusSystem] ([StatusId], [StatusName]) VALUES (3, N'Not Pass')

SET IDENTITY_INSERT [dbo].[StatusSystem] OFF

SET IDENTITY_INSERT [dbo].[TakeType] ON 


INSERT [dbo].[TakeType] ([TakeTypeId], [TakeTypeName], [Active]) VALUES (1, N'ตัดของใช้', NULL)

INSERT [dbo].[TakeType] ([TakeTypeId], [TakeTypeName], [Active]) VALUES (2, N'สูญเสีย', NULL)

INSERT [dbo].[TakeType] ([TakeTypeId], [TakeTypeName], [Active]) VALUES (3, N'โอนย้ายไปยังสโตร์', NULL)

INSERT [dbo].[TakeType] ([TakeTypeId], [TakeTypeName], [Active]) VALUES (4, N'คืนผู้จัดจำหน่าย', NULL)

INSERT [dbo].[TakeType] ([TakeTypeId], [TakeTypeName], [Active]) VALUES (5, N'อื่นๆ', NULL)

SET IDENTITY_INSERT [dbo].[TakeType] OFF

SET IDENTITY_INSERT [dbo].[Tax] ON 


INSERT [dbo].[Tax] ([TaxId], [TaxName], [Multiply], [Active]) VALUES (1, N'n/a', CAST(0.000000 AS Decimal(18, 6)), 1)

INSERT [dbo].[Tax] ([TaxId], [TaxName], [Multiply], [Active]) VALUES (2, N'7%', CAST(7.000000 AS Decimal(18, 6)), 1)

SET IDENTITY_INSERT [dbo].[Tax] OFF

SET IDENTITY_INSERT [dbo].[Titles] ON 


INSERT [dbo].[Titles] ([TitleId], [TitleName], [Active]) VALUES (1, N'นาย', 1)

INSERT [dbo].[Titles] ([TitleId], [TitleName], [Active]) VALUES (2, N'นาง', 1)

INSERT [dbo].[Titles] ([TitleId], [TitleName], [Active]) VALUES (3, N'นางสาว', 1)

SET IDENTITY_INSERT [dbo].[Titles] OFF

SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Passwords], [BirthDay], [Email], [Active_Email], [Hash], [Pin], [QRcode], [Phone], [RegisterDate], [Active], [Staff_Active], [UpdateDate], [Deletedate], [EditUserId], [DeleteUserId], [RoleId], [Nickname], [CardId], [GenderId], [NationalityId], [Address], [Image], [PositionId], [UserPayType], [Phone2], [Phone3], [WorkStartDate], [Pay], [PayTypeId], [OverTimePay], [OverTimePayTypeId], [Diligence], [DiligenceTypeId], [BreakId], [WorkTypeId], [BranchId]) VALUES (1, N'admin', N'admin', N'0000', CAST(0x000000003252140000 AS DateTime2), N'admin@ieasy.asia', NULL, NULL, NULL, NULL, N'099999999', NULL, 1, NULL, CAST(0x00D9E200C5440E0000 AS DateTime2), NULL, NULL, NULL, N'1', N'A', N'99999999999999', 1, 1, N'', N'', N'1', N'1', N'', N'', CAST(0x000000003252140000 AS DateTime2), CAST(1.0000 AS Decimal(18, 4)), 2, CAST(1.0000 AS Decimal(18, 4)), 1, CAST(1.0000 AS Decimal(18, 4)), 2, 1, 1, 1)

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Passwords], [BirthDay], [Email], [Active_Email], [Hash], [Pin], [QRcode], [Phone], [RegisterDate], [Active], [Staff_Active], [UpdateDate], [Deletedate], [EditUserId], [DeleteUserId], [RoleId], [Nickname], [CardId], [GenderId], [NationalityId], [Address], [Image], [PositionId], [UserPayType], [Phone2], [Phone3], [WorkStartDate], [Pay], [PayTypeId], [OverTimePay], [OverTimePayTypeId], [Diligence], [DiligenceTypeId], [BreakId], [WorkTypeId], [BranchId]) VALUES (2, N'Kiosk', N'', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x00000000B03E0B0000 AS DateTime2), 0, NULL, NULL, NULL, NULL, NULL, N'3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF

SET IDENTITY_INSERT [dbo].[WorkType] ON 


INSERT [dbo].[WorkType] ([WorkTypeId], [WorkTypeName], [Active]) VALUES (1, N'รายวัน', 1)

INSERT [dbo].[WorkType] ([WorkTypeId], [WorkTypeName], [Active]) VALUES (2, N'รายเดือน
', 1)

INSERT [dbo].[WorkType] ([WorkTypeId], [WorkTypeName], [Active]) VALUES (3, N'
รายสัปดาห์', 1)

SET IDENTITY_INSERT [dbo].[WorkType] OFF
SET IDENTITY_INSERT [dbo].[ItemTypes] ON 
INSERT [dbo].[ItemTypes] ([ItemTypeId], [ItemTypeName]) VALUES (1, N'อาหาร')
INSERT [dbo].[ItemTypes] ([ItemTypeId], [ItemTypeName]) VALUES (2, N'เครื่องดื่ม')
INSERT [dbo].[ItemTypes] ([ItemTypeId], [ItemTypeName]) VALUES (3, N'อื่นๆ')
SET IDENTITY_INSERT [dbo].[ItemTypes] OFF

SET IDENTITY_INSERT [dbo].[CategoryItem] ON 


INSERT [dbo].[CategoryItem] ([CategoryId], [CategoryName], [CategoryName2], [CateCode], [NumberItemCode], [Active], [InsertDate], [Updatedate], [UserId], [DeleteDate], [DeleteUserId], [CateGroupId], [ItemTypeId], [CatePrinterName], [BackGroundButton], [PathImage], [FontColor], [ImageBase64], [ImageTextBase64], [AllowPrint], [CategoryGroupItemId]) VALUES (1, N'Drink', N'Drink', N'OH', 5, 1, CAST(0x00F1AA0035450E0000 AS DateTime2), CAST(0x00E2A80059450E0000 AS DateTime2), 1, NULL, NULL, 1, 2, N'Snagit 13', -8323055, N'', -1, NULL, N'', 1, 1)

SET IDENTITY_INSERT [dbo].[CategoryItem] OFF

SET IDENTITY_INSERT [dbo].[CategoryGroup] ON 

INSERT [dbo].[CategoryGroup] ([CateGroupId], [CateGroupName], [CateGroupNameTH], [Active]) VALUES (1, N'Hot', N'ร้อน', 1)

INSERT [dbo].[CategoryGroup] ([CateGroupId], [CateGroupName], [CateGroupNameTH], [Active]) VALUES (2, N'COLD', N'เย็น', 1)

INSERT [dbo].[CategoryGroup] ([CateGroupId], [CateGroupName], [CateGroupNameTH], [Active]) VALUES (3, N'FRAPPE', N'ปั่น', 1)

INSERT [dbo].[CategoryGroup] ([CateGroupId], [CateGroupName], [CateGroupNameTH], [Active]) VALUES (4, N'อื่นๆ', N'อื่นๆ', 1)

SET IDENTITY_INSERT [dbo].[CategoryGroup] OFF

"

        Dim myCommand2 As SqlCommand = New SqlCommand(str, myConn2)
        Try
            myConn2.Open()
            myCommand2.ExecuteNonQuery()
            MessageBox.Show("Database is created successfully", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If (myConn2.State = ConnectionState.Open) Then
                myConn2.Close()
            End If
        End Try

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "server", server)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "username", Username)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "password", Password)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "database", db)

        FrmCreateDataBase2.Close()
        loading.Close()
    End Sub
    Sub CheckField()
        'Tables
        executesql("IF COL_LENGTH('[Tables]','TableName2') IS NOT NULL
select * from Tables where TableId =1
BEGIN
	ALTER TABLE Tables
ADD [IsGroupTable] [bit] NULL
ALTER TABLE Tables
ADD [IsSplitBill] [bit] NULL
ALTER TABLE Tables
ADD [TableName2] [nvarchar](100) NULL
ALTER TABLE Tables
ADD [TableId2] [nvarchar](100) NULL

ALTER TABLE [dbo].[Tables] ADD  CONSTRAINT [DF_Tables_IsGroupTable]  DEFAULT ((0)) FOR [IsGroupTable]

ALTER TABLE [dbo].[Tables] ADD  CONSTRAINT [DF_Tables_IsSplitBill]  DEFAULT ((0)) FOR [IsSplitBill]

END")
        'usepointItem
        executesql("IF COL_LENGTH('[UsePointItem]','StatusPrint') IS NOT NULL
select * from Tables where TableId =1
BEGIN
ALTER TABLE UsePointItem
ADD [StatusPrint] [bit] NULL
END")
        'pointrate
        executesql("IF COL_LENGTH('[PointRate]','TotalAmount') IS NOT NULL
select * from PointRate
BEGIN
ALTER TABLE PointRate
ADD [TotalAmount] [decimal](18, 2) NULL
ALTER TABLE PointRate
ADD [TotalPrice] [decimal](18, 2) NULL
END")
        executesql("IF COL_LENGTH('[UsePointItem]','PointRateId') IS NOT NULL
select * from UsePointItem
BEGIN
ALTER TABLE UsePointItem
ADD [PointRateId] [int] NULL
END")
    End Sub
End Module
