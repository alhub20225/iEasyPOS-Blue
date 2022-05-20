Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module CLI_Module
    Dim server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_server", Nothing)
    Dim db As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_database", Nothing)
    Dim Username As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_username", Nothing)
    Dim Password As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_password", Nothing)
    Dim HQstrcon As String = "Server='" & server & "';Database='" & db & "';User Id='" & Username & "';Password='" & Password & "'"
    Public Branchdata As New Branch
    Dim connMySql As MySqlConnection

    Function Hqexecutesql(sql As String) As DataTable
        '        Try
        '            Dim dtAdaptor As SqlDataAdapter
        '            Dim objConn As New System.Data.SqlClient.SqlConnection
        '            Dim dt As New DataTable

        '            objConn.ConnectionString = HQstrcon
        '            objConn.Open()
        '            dtAdaptor = New SqlDataAdapter(sql, objConn)
        '            dtAdaptor.Fill(dt)
        '            objConn.Close()
        '            objConn = Nothing
        '            Return dt
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '            MsgBox("กด continue แล้วเข้าไปตั้งค่า server")
        '        End Try
        '#Disable Warning BC42105 ' Function doesn't return a value on all code paths

        Try
            Dim dtAdaptor As MySqlDataAdapter
            Dim objConn As New MySqlConnection()
            Dim dt As New DataTable

            objConn.ConnectionString = HQstrcon
            objConn.Open()
            dtAdaptor = New MySqlDataAdapter(sql, objConn)
            dtAdaptor.Fill(dt)
            objConn.Close()
            objConn = Nothing
            Return dt
            connMySql.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("กด continue แล้วเข้าไปตั้งค่า server")
        End Try
        connMySql.Dispose()
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function




    Sub SyncCategory()
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Dim CliBranch As DataTable = executesql("select HqBranchId from Branch")

        Dim HqCategory As DataTable = Hqexecutesql("select CategoryId,CategoryName,CategoryName2,CateCode,NumberItemCode,Active,CateGroupId,ItemTypeId,CatePrinterName,BackGroundButton,FontColor,ImageBase64,ImageTextBase64,AllowPrint,CategoryGroupItemId from CategoryItem where Active = 1")

        'executesql("truncate table CategoryItem")
        For i As Integer = 0 To HqCategory.Rows.Count - 1

            Dim CliCategory As DataTable = executesql("select CategoryName,CategoryName2,CateCode,NumberItemCode,CategoryId from CategoryItem where Active = 1 and CategoryName='" & HqCategory(i)("CategoryName") & "' and CateCode='" & HqCategory(i)("CateCode") & "'")


            If CliCategory.Rows.Count = 0 Then

                executesql("INSERT INTO CategoryItem(CategoryName,CategoryName2,CateCode,NumberItemCode,Active,CateGroupId,ItemTypeId,CatePrinterName,BackGroundButton,FontColor,ImageBase64,ImageTextBase64,AllowPrint,CategoryGroupItemId) VALUES('" & HqCategory(i)("CategoryName") & "','" & HqCategory(i)("CategoryName2") & "','" & HqCategory(i)("CateCode") & "','" & HqCategory(i)("NumberItemCode") & "','" & HqCategory(i)("Active") & "','" & HqCategory(i)("CateGroupId") & "','" & HqCategory(i)("ItemTypeId") & "','" & HqCategory(i)("CatePrinterName") & "','" & HqCategory(i)("BackGroundButton") & "','" & HqCategory(i)("FontColor") & "','" & HqCategory(i)("ImageBase64") & "','" & HqCategory(i)("ImageTextBase64") & "','" & HqCategory(i)("AllowPrint") & "','" & HqCategory(i)("CategoryGroupItemId") & "')")

            Else
                executesql("update CategoryItem set CategoryName='" & HqCategory(i)("CategoryName") & "',CategoryName2='" & HqCategory(i)("CategoryName2") & "',CateCode='" & HqCategory(i)("CateCode") & "',NumberItemCode='" & HqCategory(i)("NumberItemCode") & "',CateGroupId='" & HqCategory(i)("CateGroupId") & "',ItemTypeId='" & HqCategory(i)("ItemTypeId") & "',BackGroundButton='" & HqCategory(i)("BackGroundButton") & "',FontColor='" & HqCategory(i)("FontColor") & "',ImageBase64='" & HqCategory(i)("ImageBase64") & "',ImageTextBase64='" & HqCategory(i)("ImageTextBase64") & "',AllowPrint='" & HqCategory(i)("AllowPrint") & "',CategoryGroupItemId='" & HqCategory(i)("CategoryGroupItemId") & "' where CategoryId=" & CliCategory(0)("CategoryId") & "")

            End If


        Next
        Hqexecutesql("insert into SyncLog (BranchId,DateSync,SyncText) values(" & Branchdata.id & ",'" & InsertDate & "','Sync Category')")


        'Re-Chach Category
        Dim ReCK_Category As DataTable = executesql("select CategoryName,CategoryName2,CateCode,NumberItemCode,CategoryId from CategoryItem where Active = 1")
        For e As Integer = 0 To ReCK_Category.Rows.Count - 1
            Dim RE_HQCategory As DataTable = Hqexecutesql("select CategoryName,CategoryName2,CateCode,NumberItemCode,CategoryId from CategoryItem where Active = 1 and CategoryName='" & ReCK_Category(e)("CategoryName") & "' and CateCode='" & ReCK_Category(e)("CateCode") & "'")
            If RE_HQCategory.Rows.Count = 0 Then
                executesql("update CategoryItem set Active=0 where CategoryId=" & ReCK_Category(e)("CategoryId") & "")
            End If
        Next
    End Sub

    Sub SyncItem()
        'Dim CliBranch As DataTable = executesql("select HqBranchId from Branch where Active=1")
        'Branchdata.id = CliBranch(0)("HqBranchId")

        SyncTax()
        SyncUnit()
        SyncCategory()
        'Dim HqItem As DataTable = Hqexecutesql("select ItemId,ItemCode,ItemName from Item where Active=1")
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))



        Dim DataBranchItem As DataTable = Hqexecutesql("SELECT BranchItem.ItemId,BranchItem.Active,Item.ItemCode,Item.ItemName,Item.Active as ItemActive FROM BranchItem INNER JOIN Item ON BranchItem.ItemId = Item.ItemId INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId WHERE (BranchItem.BranchId =" & Branchdata.id & ") AND (CategoryItem.Active = 1)")
        Dim CateId As Integer = 0
        Dim UserId As Integer = Frm_Login.UserId

        CompanySetting.ProgressBarControl2.Visible = True
        CompanySetting.ProgressBarControl2.Properties.Maximum = DataBranchItem.Rows.Count
        CompanySetting.ProgressBarControl2.Properties.Minimum = 0
        CompanySetting.ProgressBarControl2.Properties.Step = 1
        CompanySetting.ProgressBarControl2.Properties.PercentView = True

        Item.ProgressBarControl1.Visible = True
        Item.ProgressBarControl1.Properties.Maximum = DataBranchItem.Rows.Count
        Item.ProgressBarControl1.Properties.Minimum = 0
        Item.ProgressBarControl1.Properties.Step = 1
        Item.ProgressBarControl1.Properties.PercentView = True

        For i As Integer = 0 To DataBranchItem.Rows.Count - 1

            CompanySetting.ProgressBarControl2.PerformStep()
            CompanySetting.ProgressBarControl2.Update()
            Item.ProgressBarControl1.PerformStep()
            Item.ProgressBarControl1.Update()

            Dim HqCateData As DataTable = Hqexecutesql("SELECT CategoryItem.CategoryName FROM  BranchItem INNER JOIN Item ON BranchItem.ItemId = Item.ItemId INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId where BranchItem.ItemId=" & DataBranchItem(i)("ItemId") & " and CategoryItem.Active=1")

            Dim CliDataCateId As DataTable = executesql("select CategoryId,CatePrinterName from CategoryItem where CategoryName ='" & HqCateData(0)("CategoryName") & "'")
            CateId = CliDataCateId(0)("CategoryId")

            'Dim HqItem As DataTable = Hqexecutesql("select ItemCode,ItemName,ItemName2,CategoryId,ImageText,Active,InsertDate,UpdateDate,UserId,IsTrackStock,USUnitId,POUnitId,POUnitId2,AllowDC,IsPromotion,ItemPrice,PrinterName,ButtonColor,FontColor,IsVatChecked,TaxId,IsActive,ItemKiOsk from Item where ItemId=" & DataBranchItem(i)("ItemId") & "")


            Dim HqItem As DataTable = Hqexecutesql("SELECT Item.ItemCode, Item.ItemName, Item.ItemName2, Item.CategoryId, Item.ImageText, Item.Active, Item.InsertDate, Item.UpdateDate, Item.UserId, Item.IsTrackStock, Item.USUnitId, Item.POUnitId, Item.POUnitId2, Item.AllowDC, Item.IsPromotion, Item.ItemPrice, Item.PrinterName, Item.ButtonColor, Item.FontColor, Item.IsVatChecked, Item.TaxId, Item.IsActive, Item.ItemKiOsk, ItemPrice.Price FROM Item INNER JOIN ItemPrice ON Item.ItemId = ItemPrice.ItemId INNER JOIN Branch ON ItemPrice.BranchId = Branch.BranchId WHERE (Item.ItemId =" & DataBranchItem(i)("ItemId") & ") and (Branch.BranchId=" & Branchdata.id & ")")



            Dim CliItem As DataTable = executesql("select ItemId,ItemCode,ItemName from Item where ItemCode='" & HqItem(0)("ItemCode") & "' and ItemName='" & HqItem(0)("ItemName") & "'")

            If CliItem.Rows.Count = 0 Then
                executesql("INSERT INTO Item (ItemCode,ItemName,ItemName2,CategoryId,ImageText,Active,InsertDate,UpdateDate,UserId,IsTrackStock,USUnitId,POUnitId,POUnitId2,AllowDC,IsPromotion,ItemPrice,PrinterName,ButtonColor,FontColor,IsVatChecked,TaxId,IsActive,ItemKiOsk) VALUES('" & HqItem(0)("ItemCode") & "','" & HqItem(0)("ItemName") & "','" & HqItem(0)("ItemName2") & "'," & CateId & ",'" & HqItem(0)("ImageText") & "'," & DataBranchItem(i)("Active") & ",'" & InsertDate & "','" & InsertDate & "'," & UserId & "," & HqItem(0)("IsTrackStock") & "," & HqItem(0)("USUnitId") & "," & HqItem(0)("POUnitId") & "," & HqItem(0)("POUnitId2") & "," & HqItem(0)("AllowDC") & "," & HqItem(0)("IsPromotion") & "," & HqItem(0)("Price") & ",'" & CliDataCateId(0)("CatePrinterName") & "','" & HqItem(0)("ButtonColor") & "','" & HqItem(0)("FontColor") & "'," & HqItem(0)("IsVatChecked") & "," & HqItem(0)("TaxId") & "," & HqItem(0)("IsActive") & "," & HqItem(0)("ItemKiOsk") & ")")

            Else

                executesql("update Item Set IsActive=" & HqItem(0)("IsActive") & ",Active=" & DataBranchItem(i)("Active") & ",ItemPrice=" & HqItem(0)("Price") & ",IsTrackStock=" & HqItem(0)("IsTrackStock") & ",USUnitId=" & HqItem(0)("USUnitId") & ",POUnitId=" & HqItem(0)("POUnitId") & ",POUnitId2=" & HqItem(0)("POUnitId2") & ",AllowDC=" & HqItem(0)("AllowDC") & ",IsPromotion=" & HqItem(0)("IsPromotion") & ",TaxId=" & HqItem(0)("TaxId") & ",ItemKiOsk=" & HqItem(0)("ItemKiOsk") & ",UpdateDate='" & InsertDate & "',CategoryId=" & CateId & " where ItemId=" & CliItem(0)("ItemId") & "")
            End If

        Next
        Hqexecutesql("insert into SyncLog (BranchId,DateSync,SyncText) values(" & Branchdata.id & ",'" & InsertDate & "','Sync Item')")
        writeLog("User ID " + Frm_Login.UserId.ToString + " SyncItem")

        '''' Re-Check Item
        Dim Re_CliItem As DataTable = executesql("select ItemId,ItemCode,ItemName,ItemName2 from Item where Active=1")
        For e As Integer = 0 To Re_CliItem.Rows.Count - 1
            Dim Re_HqItem As DataTable = Hqexecutesql("select ItemId,ItemCode,ItemName,ItemName2 from Item where Active=1 and ItemCode='" & Re_CliItem(e)("ItemCode") & "' and ItemName='" & Re_CliItem(e)("ItemName") & "' and ItemName2='" & Re_CliItem(e)("ItemName2") & "'")
            If Re_HqItem.Rows.Count = 0 Then
                executesql("update Item set Active=0 where ItemId=" & Re_CliItem(e)("ItemId") & "")
            End If
        Next

        CompanySetting.ProgressBarControl2.Visible = False
        CompanySetting.ProgressBarControl2.Properties.Maximum = 0
        Item.ProgressBarControl1.Visible = False
        Item.ProgressBarControl1.Properties.Maximum = 0

        'LoadCliData()
    End Sub
    Public Class CategoryTopping
        Public CategoryItemId As Integer
        Public CategoryToppingId As Integer
    End Class
    Sub SyncTopping()
        Dim HqCateTopping As DataTable = Hqexecutesql("select CategoryItemId,CategoryToppingId from ItemTopping where Active=1")
        Dim CateTopping_L As List(Of CategoryTopping) = New List(Of CategoryTopping)
        For i = 0 To HqCateTopping.Rows.Count - 1
            Dim CateTop As CategoryTopping = New CategoryTopping With
                {
                .CategoryItemId = HqCateTopping(i)("CategoryItemId"),
                .CategoryToppingId = HqCateTopping(i)("CategoryToppingId")
                }
            CateTopping_L.Add(CateTop)
        Next

        For Each dt In CateTopping_L
            Console.WriteLine("CategoryItemId : " & dt.CategoryItemId & " CategoryToppingId : " & dt.CategoryToppingId)
            ' ----------------------------------------------------------- Cate Topping
            Dim HqCateToppingDetail As DataTable = Hqexecutesql("SELECT CategoryToppingName, CategoryToppingName2, CateToppingCode, NumberToppingCode,Active FROM CategoryTopping where CategoryToppingId=" & dt.CategoryToppingId & "")
            For i = 0 To HqCateToppingDetail.Rows.Count - 1
                Dim cliCate As DataTable = executesql("SELECT CategoryToppingName, CategoryToppingName2, CateToppingCode, NumberToppingCode FROM CategoryTopping where CategoryToppingName='" & HqCateToppingDetail(i)("CategoryToppingName") & "' and CategoryToppingName2='" & HqCateToppingDetail(i)("CategoryToppingName2") & "' and CateToppingCode='" & HqCateToppingDetail(i)("CateToppingCode") & "'")

                If cliCate.Rows.Count = 0 Then
                    Console.WriteLine("insert " & HqCateToppingDetail(i)("CategoryToppingName"))
                    executesql("insert into CategoryTopping (CategoryToppingName, CategoryToppingName2, CateToppingCode, NumberToppingCode) values('" & HqCateToppingDetail(i)("CategoryToppingName") & "','" & HqCateToppingDetail(i)("CategoryToppingName2") & "','" & HqCateToppingDetail(i)("CateToppingCode") & "','" & HqCateToppingDetail(i)("NumberToppingCode") & "')")
                Else
                    ' re-check
                    'Dim re_cliCate As DataTable = executesql("ELECT CategoryToppingId,CategoryToppingName, CategoryToppingName2, CateToppingCode, NumberToppingCode,Active FROM CategoryTopping where Active=1")
                    'For e = 0 To re_cliCate.Rows.Count - 1
                    '    Dim re_HQCate As DataTable = executesql("SELECT CategoryToppingName, CategoryToppingName2, CateToppingCode, NumberToppingCode FROM CategoryTopping where CategoryToppingName='" & re_cliCate(e)("CategoryToppingName") & "' and CategoryToppingName2='" & re_cliCate(e)("CategoryToppingName2") & "' and CateToppingCode='" & re_cliCate(e)("CateToppingCode") & "'")
                    '    If re_HQCate.Rows.Count = 0 Then
                    '        executesql("update CategoryTopping set Active=0 where CategoryToppingId=" & re_cliCate(e)("CategoryToppingId") & "")
                    '    End If
                    'Next
                End If
            Next

            '------------------------------------------------------------- Topping
            Dim HqTopping As DataTable = Hqexecutesql("SELECT ToppingId, ToppingName, ToppingName2, Costing, Pricing, ToppingCode, CategoryToppingId, Active FROM Topping  where CategoryToppingId=" & dt.CategoryToppingId & "")


        Next
    End Sub


    Sub SyncTax()
        Dim HqTax As DataTable = Hqexecutesql("select * from tax")

        executesql("truncate table tax")

        For i As Integer = 0 To HqTax.Rows.Count - 1
            executesql("insert into tax (TaxName,Multiply,Active) values('" & HqTax(i)("TaxName") & "'," & HqTax(i)("Multiply") & "," & HqTax(i)("Active") & ")")
        Next
    End Sub

    Sub SyncUnit()
        Dim HqUnit As DataTable = Hqexecutesql("select ItemUnitName,Multiply,Active from ItemUnit")

        executesql("truncate table ItemUnit")

        For i As Integer = 0 To HqUnit.Rows.Count - 1
            executesql("insert into ItemUnit (ItemUnitName,Multiply,Active) values('" & HqUnit(i)("ItemUnitName") & "'," & HqUnit(i)("Multiply") & "," & HqUnit(i)("Active") & ")")
        Next

    End Sub

    Sub SyncSale()
        Dim Dt1 As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim Dt2 As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Dim CliBranch As DataTable = executesql("select HqBranchId from Branch")
        'Dim AllHqSale As DataTable = executesql("select BranchSaleId,BranchId from sale")
        Dim BranchSale As DataTable = executesql("select SaleId,SaleDate,SaleNo,SubTotal,TaxAmt,Total,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,TerminalName,AmountDC from sale where HqSync=0")
        If BranchSale.Rows.Count = 0 Then
            SyncSaleItem()
            Hqexecutesql("insert into SyncLog (BranchId,DateSync,SyncText) values(" & Branchdata.id & ",'" & InsertDate & "','Sync Sale(0)')")
            Exit Sub
        End If
        CompanySetting.ProgressBarControl1.Visible = True
        CompanySetting.ProgressBarControl1.Properties.Maximum = BranchSale.Rows.Count
        CompanySetting.ProgressBarControl1.Properties.Minimum = 0
        CompanySetting.ProgressBarControl1.Properties.Step = 1
        CompanySetting.ProgressBarControl1.Properties.PercentView = True

        For i As Integer = 0 To BranchSale.Rows.Count - 1
            CompanySetting.ProgressBarControl1.PerformStep()
            CompanySetting.ProgressBarControl1.Update()

            'Dim HqSale As DataTable = Hqexecutesql("select * from sale where SaleDate between '" & Dt1 & "' and '" & Dt2 & "' and BranchSaleId=" & BranchSale(i)("SaleId") & " and BranchId=" &  Branchdata.id & "")
            Dim HqSale As DataTable = Hqexecutesql("select BranchSaleId,BranchId from sale where BranchSaleId=" & BranchSale(i)("SaleId") & " and BranchId=" & Branchdata.id & "")

            If HqSale.Rows.Count = 0 Then
                '--- insert Sale
                Dim InsertDate2 As String = Convert.ToDateTime(BranchSale(i)("SaleDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
                Hqexecutesql("insert into Sale (BranchSaleId,BranchId,SaleDate,SaleNo,SubTotal,TaxAmt,Total,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,TerminalName,AmountDC) VALUES(" & BranchSale(i)("SaleId") & "," & Branchdata.id & ",'" & InsertDate2 & "','" & BranchSale(i)("SaleNo") & "'," & BranchSale(i)("SubTotal") & ",'" & BranchSale(i)("TaxAmt") & "','" & BranchSale(i)("Total") & "','" & InsertDate2 & "','" & BranchSale(i)("CloseBillUserId") & "','" & BranchSale(i)("IsCloseBill") & "','" & BranchSale(i)("Active") & "','" & BranchSale(i)("SaveBillCount") & "','" & BranchSale(i)("CustomerId") & "','" & BranchSale(i)("NumOfCust") & "','" & BranchSale(i)("TerminalName") & "','" & BranchSale(i)("AmountDC") & "')")


            Else
                '--- update sale
                Hqexecutesql("update Sale set Active=" & BranchSale(i)("Active") & " where BranchSaleId=" & BranchSale(i)("SaleId") & " and BranchId=" & Branchdata.id & "")

                'Dim HqUpDateSale As DataTable = Hqexecutesql("select id,BranchSaleId,BranchId,Active from Sale where BranchSaleId=" & BranchSale(i)("SaleId") & " and BranchId=" &  Branchdata.id & " and Active not in(" & BranchSale(i)("Active") & ")")

                'If HqUpDateSale.Rows.Count > 0 Then
                '    Hqexecutesql("update Sale set Active=" & BranchSale(i)("Active") & " where id=" & HqUpDateSale(0)("id") & "")
                'End If

            End If

        Next
        CompanySetting.ProgressBarControl1.Visible = False
        CompanySetting.ProgressBarControl1.Properties.Maximum = 0
        Hqexecutesql("insert into SyncLog (BranchId,DateSync,SyncText) values(" & Branchdata.id & ",'" & InsertDate & "','Sync Sale')")

        SyncSaleItem()

        For e As Integer = 0 To BranchSale.Rows.Count - 1
            executesql("update Sale set HqSync=1 where SaleId=" & BranchSale(e)("SaleId") & "")
        Next
    End Sub

    Sub SyncSaleItem()

        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Dim CliBranch As DataTable = executesql("select HqBranchId from Branch")
        Dim BranchSaleItem As DataTable = executesql("SELECT SaleItem.SaleItemId, SaleItem.SaleId, SaleItem.ItemId, SaleItem.CategoryId, SaleItem.ItemCode, SaleItem.ItemName, SaleItem.InitPrice, SaleItem.UnitPrice, SaleItem.Qty, SaleItem.SubTotal, SaleItem.Tax, SaleItem.Total,SaleItem.InsertDate, SaleItem.PercentDC, SaleItem.BahtDC, SaleItem.AmtDC, SaleItem.TerminalName, SaleItem.Active, SaleItem.StatusPrint, SaleItem.PrinterName, CategoryItem.CategoryName FROM SaleItem INNER JOIN CategoryItem ON SaleItem.CategoryId = CategoryItem.CategoryId INNER JOIN Sale ON SaleItem.SaleId = Sale.SaleId  where sale.hqsync=0")
        If BranchSaleItem.Rows.Count = 0 Then
            Hqexecutesql("insert into SyncLog (BranchId,DateSync,SyncText) values(" & Branchdata.id & ",'" & InsertDate & "','Sync SaleItem(0)')")
            MsgBox("Sync Complete")
            Exit Sub
        End If

        CompanySetting.ProgressBarControl1.Visible = True
        CompanySetting.ProgressBarControl1.Properties.Maximum = BranchSaleItem.Rows.Count
        CompanySetting.ProgressBarControl1.Properties.Minimum = 0
        CompanySetting.ProgressBarControl1.Properties.Step = 1
        CompanySetting.ProgressBarControl1.Properties.PercentView = True

        For i As Integer = 0 To BranchSaleItem.Rows.Count - 1
            CompanySetting.ProgressBarControl1.PerformStep()
            CompanySetting.ProgressBarControl1.Update()

            Dim HqSaleItem As DataTable = Hqexecutesql("select BranchSaleItemId,BranchSaleId,BranchId from SaleItem where BranchSaleItemId=" & BranchSaleItem(i)("SaleItemId") & " and BranchSaleId=" & BranchSaleItem(i)("SaleId") & " and BranchId=" & Branchdata.id & "")
            If HqSaleItem.Rows.Count = 0 Then
                '--- insert SaleItem
                Hqexecutesql("INSERT INTO SaleItem(BranchSaleItemId,BranchSaleId,BranchId,CategoryName,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName) VALUES(" & BranchSaleItem(i)("SaleItemId") & "," & BranchSaleItem(i)("SaleId") & "," & Branchdata.id & ",'" & BranchSaleItem(i)("CategoryName") & "','" & BranchSaleItem(i)("ItemCode") & "','" & BranchSaleItem(i)("ItemName") & "','" & BranchSaleItem(i)("InitPrice") & "','" & BranchSaleItem(i)("UnitPrice") & "','" & BranchSaleItem(i)("QTY") & "','" & BranchSaleItem(i)("SubTotal") & "','" & BranchSaleItem(i)("Tax") & "','" & BranchSaleItem(i)("Total") & "','" & InsertDate & "','" & BranchSaleItem(i)("PercentDC") & "','" & BranchSaleItem(i)("BahtDC") & "','" & BranchSaleItem(i)("AmtDC") & "','" & BranchSaleItem(i)("TerminalName") & "','" & BranchSaleItem(i)("Active") & "','" & BranchSaleItem(i)("StatusPrint") & "','" & BranchSaleItem(i)("PrinterName") & "')")
            Else
                'Dim HqUpDateSaleItem As DataTable = Hqexecutesql("select SaleItemId,BranchSaleItemId,BranchId,Active from SaleItem where BranchSaleItemId=" & BranchSaleItem(i)("SaleId") & " and BranchId=" &  Branchdata.id & " and Active not in(" & BranchSaleItem(i)("Active") & ")")

                'If HqUpDateSaleItem.Rows.Count > 0 Then
                '    Hqexecutesql("update SaleItem set Active=" & BranchSaleItem(i)("Active") & " where SaleItemId=" & HqUpDateSaleItem(0)("SaleItemId") & "")
                'End If

            End If

        Next
        CompanySetting.ProgressBarControl1.Visible = False
        CompanySetting.ProgressBarControl1.Properties.Maximum = 0
        Hqexecutesql("insert into SyncLog (BranchId,DateSync,SyncText) values(" & Branchdata.id & ",'" & InsertDate & "','Sync SaleItem')")
        MsgBox("Sync Complete")
    End Sub

End Module

