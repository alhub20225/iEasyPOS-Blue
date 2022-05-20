BEGIN ALTER table [dbo].[Saletabref] Add
[BillSplit_Id] [int] NULL,
[BillSplit_Name] [nchar](100) NULL
END


BEGIN ALTER table [dbo].[CancelSaleItem] add
[BillSplit_Id] [int] NULL,
[BillSplit_Name] [nchar](100) NULL
end


BEGIN ALTER table [dbo].[Sale] add
[BillSplit_Id] [int] NULL,
[BillSplit_Name] [nchar](100) NULL
end


BEGIN ALTER table [dbo].[SaleItem] add
[BillSplit_Id] [int] NULL,
[BillSplit_Name] [nchar](100) NULL
end

BEGIN ALTER table [dbo].[SaleTable] add
[BillSplit_Id] [int] NULL,
[BillSplit_Name] [nchar](100) NULL,
[TableId] [int] NULL
end