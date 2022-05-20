GO
IF NOT  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[CancelSaleItem]') AND type in (N'U'))
BEGIN
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[CancelSaleItem2](
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
END
GO
