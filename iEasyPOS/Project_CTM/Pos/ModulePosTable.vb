Module ModulePosTable
    Sub LoadUser()
        Dim UserName As String = Frm_Login.UserName

    End Sub
    Sub TableZoneName()
        If TableId > 0 Then
            POS.txtTableName.Visible = True
            POS.txtZoneName.Visible = True
            POS.Label2.Visible = True
            POS.txtTableName.Text = TableName
            POS.txtZoneName.Text = ZoneName
        End If
    End Sub
    Sub LoadCategory()
        Dim DataCategory As DataTable = executesql("SELECT CategoryId,CategoryName,CategoryName2,FontColor,BackGroundButton,ImageTextBase64 FROM CategoryItem WHERE CateGroupId=1 AND Active =1")
        If IsNothing(DataCategory) Then
            Exit Sub
        ElseIf DataCategory.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim RowsDataCategory As Integer = DataCategory.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataCategory - 1
            Dim ButtonCategory As New Button
            ButtonCategory.Text = DataCategory(i)("CategoryName")
            ButtonCategory.Name = DataCategory(i)("CategoryId")
            ButtonCategory.Font = My.Settings.ButtonFont
            If DataCategory(i)("ImageTextBase64") = "" Then
                ButtonCategory.BackColor = Color.FromArgb(DataCategory(i)("BackGroundButton"))
            Else
                If DataCategory(i)("ImageTextBase64") <> "" Then
                    'Setup image and get data stream together
                    Dim img As System.Drawing.Image
                    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    Dim b() As Byte
                    'Converts the base64 encoded msg to image data
                    b = Convert.FromBase64String(DataCategory(i)("ImageTextBase64"))
                    MS = New System.IO.MemoryStream(b)
                    'creates image
                    img = System.Drawing.Image.FromStream(MS)
                    ButtonCategory.BackgroundImage = img
                    ButtonCategory.BackgroundImageLayout = ImageLayout.Stretch
                End If
            End If
            ButtonCategory.FlatStyle = FlatStyle.Flat
            ButtonCategory.FlatAppearance.BorderSize = 0
            ButtonCategory.Margin = New System.Windows.Forms.Padding(1)
            ButtonCategory.ForeColor = Color.FromArgb(DataCategory(i)("FontColor"))
            ButtonCategory.Width = My.Settings.ButtonCateSize.Width
            ButtonCategory.Height = My.Settings.ButtonCateSize.Height
            POS.FlowLayoutPanelCategory.Controls.Add(ButtonCategory)
            AddHandler ButtonCategory.Click, AddressOf GetItem
        Next
        DisCount = 0
    End Sub
    Sub GetItem(sender As Object, e As EventArgs)
        POS.txtItemCode.Focus()
        POS.FlowLayoutPanelItems.Controls.Clear()
        'Select Items
        Dim CateId As Integer = sender.Name
        Dim CateName As String = sender.Text
        Dim DataItem As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ImageText,ButtonColor,FontColor,IsActive FROM Item WHERE CategoryId='" & CateId & "' AND Active = 1")
        Dim RowsDataItem As Integer = DataItem.Rows.Count
        Dim i As Integer
        Dim StockNo As Boolean = True
        For i = 0 To RowsDataItem - 1
            Dim SelectReceipe As DataTable = executesql("SELECT Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & DataItem(i)("ItemId") & "'")
            Dim ButtonItem As New Button
            If DataItem(i)("IsActive") = 1 Then
                ButtonItem.Name = DataItem(i)("ItemId")
                If SelectReceipe.Rows.Count > 0 Then
                    For a As Integer = 0 To SelectReceipe.Rows.Count - 1
                        Dim checkStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode = '" & SelectReceipe(a)("ItemCode") & "'")
                        If IsDBNull(checkStock) Then
                            StockNo = True
                            Exit For
                        End If
                        If checkStock.Rows.Count > 0 Then
                            If checkStock(a)("Qty") <= 0 Then
                                StockNo = False
                                Exit For
                            ElseIf checkStock(a)("Qty") > 0 Then
                                StockNo = True
                                Exit For
                            End If
                        Else
                            StockNo = True
                            Exit For
                        End If
                    Next
                Else
                    StockNo = True
                End If
                ButtonItem.Width = My.Settings.ButtonItemSize.Width
                ButtonItem.Height = My.Settings.ButtonItemSize.Height
                ButtonItem.Margin = New System.Windows.Forms.Padding(1)
                If StockNo = True Then
                    ButtonItem.Text = DataItem(i)("ItemName")
                    ButtonItem.FlatStyle = FlatStyle.Flat
                    ButtonItem.FlatAppearance.BorderSize = 0
                    ButtonItem.ForeColor = Color.Black
                    ButtonItem.Font = My.Settings.ButtonFont
                    ButtonItem.TextAlign = ContentAlignment.MiddleCenter
                    'If IsDBNull(DataItem(i)("ImageText")) Then
                    ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                    'ElseIf DataItem(i)("ImageText") = "" Then
                    '    ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                    'Else
                    '    'Setup Image and get data Stream together
                    '    Dim img As System.Drawing.Image
                    '    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    '    Dim b() As Byte
                    '    'Converts the base64 encoded msg to image Data
                    '    b = Convert.FromBase64String(DataItem(i)("ImageText"))
                    '    MS = New System.IO.MemoryStream(b)
                    '    'Create Image 
                    '    img = System.Drawing.Image.FromStream(MS)
                    '    ButtonItem.BackgroundImage = img
                    '    ButtonItem.BackgroundImageLayout = ImageLayout.Stretch
                    'End If

                    'L1.Text = DataItem(i)("ItemName")
                    ''If IsDBNull(DataItem(i)("ImageText")) Then
                    'ButtonItem.Font = New Font("supermarket Regular", 12.0, FontStyle.Regular)
                    '    ButtonItem.ForeColor = Color.Black
                    '    ButtonItem.TextAlign = ContentAlignment.MiddleCenter
                    ''Else
                    'ButtonItem.Font = New Font("supermarket Regular", 0.1, FontStyle.Regular)
                    '    ButtonItem.Controls.Add(L1)
                    ''End If

                    POS.FlowLayoutPanelItems.Controls.Add(ButtonItem)
                    AddHandler ButtonItem.Click, AddressOf AddPOSItem_
                ElseIf StockNo = False Then
                    ButtonItem.Text = DataItem(i)("ItemName") & Environment.NewLine & "วัตถุดิบหมด"
                    ButtonItem.FlatStyle = FlatStyle.Flat
                    ButtonItem.FlatAppearance.BorderSize = 1
                    ButtonItem.FlatAppearance.BorderColor = Color.Red
                    ButtonItem.BackColor = Color.Red
                    ButtonItem.Font = My.Settings.ButtonFont
                    'If IsDBNull(DataItem(i)("ImageText")) Then
                    ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                    'ElseIf DataItem(i)("ImageText") = "" Then
                    '    ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                    'Else
                    '    'Setup Image and get data Stream together
                    '    Dim img As System.Drawing.Image
                    '    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    '    Dim b() As Byte
                    '    'Converts the base64 encoded msg to image Data
                    '    b = Convert.FromBase64String(DataItem(i)("ImageText"))
                    '    MS = New System.IO.MemoryStream(b)
                    '    'Create Image 
                    '    img = System.Drawing.Image.FromStream(MS)
                    '    ButtonItem.BackgroundImage = img
                    '    ButtonItem.BackgroundImageLayout = ImageLayout.Stretch
                    'End If
                    POS.FlowLayoutPanelItems.Controls.Add(ButtonItem)
                    AddHandler ButtonItem.Click, AddressOf AddPOSItem_
                End If
            End If
        Next
    End Sub
    Public TB_ItemId As String
    Public TB_ItemName As String
    Public TB_ItemAmount As Decimal
    Public TB_ItemPrice As Decimal
    Public TB_ItemPricePerUnit As Decimal
    Public TB_Total As Decimal
    Public TB_DisCount As Decimal
    Public TB_SubTotal As Decimal
    Public checktopping_Table As Integer = 0
    Public selectItemPosRow_Table As Integer
    Sub AddPOSItem_(sender As Object, e As EventArgs)
        TB_ItemId = sender.Name
        TB_ItemName = sender.Text
        Dim TB_saleName As String = POS.txtTableName.Text
        Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_subtotal As Decimal = POS.txtSubTotal.Text
        Dim TB_total As Decimal = POS.txtTotal.Text
        Dim TB_IsCloseBill As Integer = 0
        Dim TB_CustomerId As Integer = 0
        TB_ItemAmount = 1
        Dim TB_Active As Integer = 1
        Dim selectPrice As DataTable = executesql("Select ItemId,ItemPrice,ItemName  From Item Where ItemId='" & TB_ItemId & "' AND Active=1")
        TB_ItemPrice = TB_ItemAmount * selectPrice(0)("ItemPrice")
        'Dim TB_InitPrice As Decimal
        'Dim TB_UnitPrice As Decimal
        'Dim TB_SubTotalItem As Decimal
        'Dim TB_TotalItem As Decimal
        'Dim TB_TaxItem As Decimal
        'Dim TB_BahtDC As Decimal
        Dim Rowsdg As Integer
        Dim TerminalName As String = Environment.MachineName
        If POS.DataGridViewPOS.Rows.Count = 0 Then
            POS.DataGridViewPOS.Rows.Clear()
            checktopping_Table = 0
            selectItemPosRow_Table = Nothing
            selectItemPosRow_Table = POS.DataGridViewPOS.Rows.Count
            Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & TB_ItemId & "'")
            If selectItemTopping.Rows.Count > 0 Then
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(ToppingList_Table.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.7
                    plexi.Show()
                    ToppingList_Table.StartPosition = FormStartPosition.CenterParent
                    ToppingList_Table.ShowDialog(plexi)
                End Using
                calculatePrice()
                'CheckItem3()
                'CheckItem3()
            ElseIf selectItemTopping.Rows.Count = 0 Then
                CheckItem3()
                calculatePrice()
            End If


            ''POS.DataGridViewPOS.Rows.Add(TB_ItemName, TB_ItemAmount, FormatNumber(TB_ItemPrice, 2), FormatNumber(TB_ItemAmount * TB_ItemPrice, 2), TB_ItemId, 0.00)
            ''POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ''POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ''POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ''POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ''POS.DataGridViewPOS.ClearSelection()

            ''Insert into Sale---------------------------------------------------------------------
            'Dim PercentDC As Decimal = 0
            'Dim BahtDC As Decimal = 0
            'Dim AmtDC As Decimal = 0
            'Dim checkExists As Boolean = False
            'Dim ToppingPrice As Decimal = 0

            'Dim a As Integer
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            '    'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    '    Exit For
            '    'End If
            '    If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value Then
            '        checkExists = True
            '        a = i
            '        Exit For
            '    End If
            'Next

            ''MsgBox(TB_ItemId.ToString + "=" + ItemIdDg.ToString)

            'Dim Amount As Integer = TB_ItemAmount
            'Dim Price As Decimal = selectPrice(0)("ItemPrice")
            'Dim Sumprice As Integer = Amount * Price

            ''select categoryid------------------------------------------------------------------
            'Clipboard.SetText("SELECT CategoryId,ItemCode,ItemName,TaxId,ItemPrice,PrinterName FROM Item WHERE ItemId='" & TB_ItemId & "'")
            'Dim DataCategoryId As DataTable = executesql("SELECT CategoryId,ItemCode,ItemName,TaxId,ItemPrice,PrinterName FROM Item WHERE ItemId='" & TB_ItemId & "'")
            'Dim CategoryId As Integer = DataCategoryId(0)("CategoryId")
            'Dim ItemCode As String = DataCategoryId(0)("ItemCode")
            'Dim TaxId As String = DataCategoryId(0)("TaxId")
            'Dim PrinterName As String = DataCategoryId(0)("PrinterName")
            ''Select Tax ------------------------------------------------------------------------
            'Dim DataTax As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & TaxId & "'")
            'Dim Multiply As Decimal = DataTax(0)("Multiply")
            ''insert SaleItem --------------------------------------------------------------------
            'If POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 0 Then
            '    BahtDC = POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value
            '    PercentDC = 0
            'ElseIf POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 1 Then
            '    PercentDC = POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value
            '    BahtDC = 0
            'End If
            ''''''TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
            ''''''InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
            ''''''UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
            ''''''TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
            ''''''SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
            '''''''TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
            '''''''TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
            'Dim TaxItem As Decimal = DataCategoryId(0)("ItemPrice") - (DataCategoryId(0)("ItemPrice") * 100 / (DataTax(0)("Multiply") + 100))
            'Dim InitPrice As Decimal = FormatNumber((DataCategoryId(0)("ItemPrice") - TaxItem), 2)
            'Dim UnitPrice As Decimal = FormatNumber(DataCategoryId(0)("ItemPrice"), 2)
            'Dim Qty As Integer = 1
            'Dim SubTotal As Decimal = (((DataCategoryId(0)("ItemPrice") * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
            'Dim Tax As Decimal = ((((DataCategoryId(0)("ItemPrice") * Qty))) - ((((DataCategoryId(0)("ItemPrice") * Qty))) * 100 / (DataTax(0)("Multiply") + 100)))
            'Dim Total As Decimal = Qty * DataCategoryId(0)("ItemPrice")
            'Dim StatusPrint As Integer = 0
            'Dim Active As Integer = 3
            'Dim UserId As Integer = Frm_Login.UserId
            'MsgBox(1)


            'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,TerminalName,UserId,PrinterName,StatusPrint,InsertDate,Active) VALUES('0','" & TB_ItemId & "','" & CategoryId & "','" & ItemCode & "','" & TB_ItemName & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotal & "','" & Tax & "','" & Total & "','" & TerminalName & "','" & UserId & "','" & PrinterName & "','" & StatusPrint & "','" & TB_InsertDate & "','" & Active & "')")
            'Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "' group by Qty,InsertDate,ItemId,CategoryId")

            ''Insert To Sale Item Order
            'Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")
            'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName,Active) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & Convert.ToDateTime(GetSaleItemID(0)("InsertDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & TB_ItemName & "','1')")

        Else
            selectItemPosRow_Table = Nothing
            selectItemPosRow_Table = POS.DataGridViewPOS.Rows.Count
            checktopping = 0
            selectItemPosRow = Nothing
            selectItemPosRow = POS.DataGridViewPOS.Rows.Count
            Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & TB_ItemId & "'")
            If selectItemTopping.Rows.Count > 0 Then
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(ToppingList_Table.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.7
                    plexi.Show()
                    ToppingList_Table.StartPosition = FormStartPosition.CenterParent
                    ToppingList_Table.ShowDialog(plexi)
                End Using
                'CheckItem3()
                'checkItem3()
                calculatePrice()
            ElseIf selectItemTopping.Rows.Count = 0 Then
                CheckItem3()
                calculatePrice()
            End If
            'CheckItem2()
            'MsgBox(2)
            'For Rowsdg = 0 To POS.DataGridViewPOS.Rows.Count - 1
            '    Dim ItemIdDg As Integer = POS.DataGridViewPOS.Rows(Rowsdg).Cells(4).Value
            '    'MsgBox(TB_ItemId.ToString + "=" + ItemIdDg.ToString)
            '    If TB_ItemId = ItemIdDg Then
            '        Dim Amount As Integer = POS.DataGridViewPOS.Rows(Rowsdg).Cells(1).Value + 1
            '        Dim Price As Integer = POS.DataGridViewPOS.Rows(Rowsdg).Cells(2).Value
            '        Dim Sumprice As Integer = Amount * Price
            '        POS.DataGridViewPOS.Rows(Rowsdg).Cells(1).Value = Amount
            '        POS.DataGridViewPOS.Rows(Rowsdg).Cells(3).Value = Sumprice
            '        'select categoryid------------------------------------------------------------------
            '        Dim DataCategoryId As DataTable = executesql("SELECT CategoryId,ItemCode,ItemName,TaxId,ItemPrice,PrinterName FROM Item WHERE ItemId='" & TB_ItemId & "'")
            '        Dim CategoryId As Integer = DataCategoryId(0)("CategoryId")
            '        Dim ItemCode As String = DataCategoryId(0)("ItemCode")
            '        Dim ItemName As String = DataCategoryId(0)("ItemName")
            '        Dim TaxId As String = DataCategoryId(0)("TaxId")
            '        Dim ItemPrice As Decimal = DataCategoryId(0)("ItemPrice")
            '        Dim PrinterName As String = DataCategoryId(0)("PrinterName")
            '        'Select Tax ------------------------------------------------------------------------
            '        Dim DataTax As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & TaxId & "'")
            '        Dim Multiply As Decimal = DataTax(0)("Multiply")
            '        'insert SaleItem --------------------------------------------------------------------
            '        Dim InitPrice As Decimal = ItemPrice
            '        Dim UnitPrice As Decimal = (InitPrice - (InitPrice * Multiply / 100))
            '        Dim Qty As Integer = 1
            '        Dim SubTotal As Decimal = Qty * InitPrice
            '        Dim Tax As Decimal = InitPrice * Multiply / 100
            '        Dim Total As Decimal = Qty * UnitPrice
            '        Dim StatusPrint As Integer = 0
            '        Dim Active As Integer = 0
            '        Dim UserId As Integer = Frm_Login.UserId

            '        'executesql("INSERT INTO SaleItem(SaleItem,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,TerminalName,UserId,PrinterName,StatusPrint,InsertDate,Active) VALUES('0','" & TB_ItemId & "','" & CategoryId & "','" & ItemCode & "','" & ItemName & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotal & "','" & Tax & "','" & Total & "','" & TerminalName & "','" & UserId & "','" & PrinterName & "','" & StatusPrint & "','" & TB_InsertDate & "','" & Active & "')")
            '    Else
            '        POS.DataGridViewPOS.Rows.Add(TB_ItemName, TB_ItemAmount, TB_ItemPrice, (TB_ItemAmount * TB_ItemPrice), TB_ItemId)
            '        POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '        POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '        POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '        POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '        POS.DataGridViewPOS.ClearSelection()
            '        'select categoryid------------------------------------------------------------------
            '        Dim DataCategoryId As DataTable = executesql("Select CategoryId,ItemCode,ItemName,TaxId,ItemPrice,PrinterName FROM Item WHERE ItemId='" & TB_ItemId & "'")

            '        Dim CategoryId As Integer = DataCategoryId(0)("CategoryId")
            '        Dim ItemCode As String = DataCategoryId(0)("ItemCode")
            '        Dim ItemName As String = DataCategoryId(0)("ItemName")
            '        Dim TaxId As String = DataCategoryId(0)("TaxId")
            '        Dim ItemPrice As Decimal = DataCategoryId(0)("ItemPrice")
            '        Dim PrinterName As String = DataCategoryId(0)("PrinterName")
            '        'Select Tax ------------------------------------------------------------------------
            '        Dim DataTax As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & TaxId & "'")
            '        Dim Multiply As Decimal = DataTax(0)("Multiply")
            '        'insert SaleItem --------------------------------------------------------------------
            '        Dim InitPrice As Decimal = ItemPrice
            '        Dim UnitPrice As Decimal = (InitPrice - (InitPrice * Multiply / 100))
            '        Dim Qty As Integer = 1
            '        Dim SubTotal As Decimal = Qty * InitPrice
            '        Dim Tax As Decimal = InitPrice * Multiply / 100
            '        Dim Total As Decimal = Qty * UnitPrice
            '        Dim StatusPrint As Integer = 0
            '        Dim Active As Integer = 0
            '        Dim UserId As Integer = Frm_Login.UserId
            '        'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,TerminalName,UserId,PrinterName,StatusPrint,InsertDate,Active) VALUES('0','" & TB_ItemId & "','" & CategoryId & "','" & ItemCode & "','" & ItemName & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotal & "','" & Tax & "','" & Total & "','" & TerminalName & "','" & UserId & "','" & PrinterName & "','" & StatusPrint & "','" & TB_InsertDate & "','" & Active & "')")
            '    End If
            '    ModulePOS.calculatePrice()
            'Next
        End If
        'ModulePOS.calculatePrice()
    End Sub
    Sub AddPOSItem(sender As Object, e As EventArgs)
        TB_ItemId = sender.Name
        TB_ItemName = sender.Text
        Dim TB_saleName As String = POS.txtTableName.Text
        Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_subtotal As Decimal = POS.txtSubTotal.Text
        Dim TB_total As Decimal = POS.txtTotal.Text
        Dim TB_IsCloseBill As Integer = 0
        Dim TB_CustomerId As Integer = 0
        Dim TB_Active As Integer = 1
        Dim TB_InitPrice As Decimal
        Dim TB_UnitPrice As Decimal
        Dim TB_SubTotalItem As Decimal
        Dim TB_TotalItem As Decimal
        Dim TB_TaxItem As Decimal
        Dim TB_BahtDC As Decimal
        If POS.DataGridViewPOS.Rows.Count = 0 Then
            POS.DataGridViewPOS.Rows.Clear()
            Dim selectPrice As DataTable = executesql("SELECT ItemPrice FROM Item WHERE ItemId='" & TB_ItemId & "' AND Active=1")
            TB_ItemAmount = 1
            TB_ItemPrice = TB_ItemAmount * selectPrice(0)("ItemPrice")
            TB_ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, TB_ItemAmount, FormatNumber(TB_ItemPricePerUnit, 2), FormatNumber(TB_ItemPrice, 2), TB_ItemId, 0.00, 0, 0)
            POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            POS.DataGridViewPOS.ClearSelection()
            Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & TB_ItemId & "'")
            TB_TaxItem = (SelectDataItem(0)("ItemPrice") * SelectDataItem(0)("Multiply") / 100)
            TB_InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TB_TaxItem), 2)
            TB_UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
            TB_TotalItem = POS.DataGridViewPOS.CurrentRow.Cells(2).Value * TB_ItemAmount
            TB_SubTotalItem = FormatNumber(TB_InitPrice * TB_ItemAmount, 2)
            TB_BahtDC = POS.DataGridViewPOS.CurrentRow.Cells(5).Value
            'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,BahtDC,TerminalName,UserId) VALUES('0','" & TB_ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & TB_InitPrice & "','" & TB_UnitPrice & "','" & TB_ItemAmount & "','" & TB_InitPrice & "','" & TB_TaxItem & "','" & TB_UnitPrice & "','" & TB_InsertDate & "','" & TB_BahtDC & "','" & Environment.MachineName & "','" & Frm_Login.UserId & "')")
            'Insert To Sale Item Order
            Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "'")

            Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")

            'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName) VALUES('" & GetSaleItemID(0)("SaleItemId") & "','" & GetSaleItemID(0)("Qty") & "','" & Frm_Login.UserId & "','" & GetSaleItemID(0)("InsertDate") & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & SelectDataItem(0)("ItemName") & "')")
        ElseIf POS.DataGridViewPOS.Rows.Count > 0 Then
            'CheckItem2()
        End If
        calculatePrice()
    End Sub
    Sub checkItem()
        Dim checkExists As Boolean = False
        Dim ToppingPrice As Decimal = 0
        'Clipboard.SetText("SELECT ItemId,ItemPrice FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
        Dim selectPrice As DataTable = executesql("SELECT ItemName,ItemId,ItemPrice FROM Item WHERE ItemId='" & TB_ItemId & "' AND Active=1")
        Dim a As Integer
        For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    Exit For
            'End If
            If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And IsDBNull(POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value) Then
                checkExists = True
                a = i
                Exit For
            End If
        Next
        ItemName = selectPrice(0)("ItemName")
        If checkExists = True Then
            ItemAmount = CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
                ItemPrice = (POS.DataGridViewPOS.Rows(a).Cells(3).Value / POS.DataGridViewPOS.Rows(a).Cells(1).Value) * ItemAmount
            End If
            POS.DataGridViewPOS.Rows(a).Cells(1).Value = ItemAmount
            POS.DataGridViewPOS.Rows(a).Cells(3).Value = FormatNumber(ItemPrice, 2)
            POS.DataGridViewPOS.ClearSelection()
        Else
            ItemAmount = 1
            ItemPrice = selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, 1, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        End If
        ''TB_ItemId = 0
        calculatePrice()
    End Sub
    'Sub CheckItem()
    '    Dim TB_saleName As String = POS.txtTableName.Text
    '    Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    '    Dim TB_SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    '    Dim TB_StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    '    Dim TB_UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    '    Dim TB_subtotal As Decimal = POS.txtSubTotal.Text
    '    Dim TB_total As Decimal = POS.txtTotal.Text
    '    Dim TB_IsCloseBill As Integer = 0
    '    Dim TB_CustomerId As Integer = 0
    '    Dim TB_Active As Integer = 1
    '    Dim TB_InitPrice As Decimal
    '    Dim TB_UnitPrice As Decimal
    '    Dim TB_SubTotalItem As Decimal
    '    Dim TB_TotalItem As Decimal
    '    Dim TB_TaxItem As Decimal
    '    Dim TB_BahtDC As Decimal
    '    Dim checkExists As Boolean = False
    '    Dim selectPrice As DataTable = executesql("SELECT ItemId,ItemPrice FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
    '    Dim a As Integer
    '    For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
    '        If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value Then
    '            checkExists = True
    '            a = i
    '            Exit For
    '        End If
    '    Next

    '    If checkExists = True Then
    '        TB_ItemAmount = CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
    '        TB_ItemPrice = TB_ItemAmount * selectPrice(0)("ItemPrice")
    '        POS.DataGridViewPOS.Rows(a).Cells(1).Value = TB_ItemAmount
    '        POS.DataGridViewPOS.Rows(a).Cells(3).Value = FormatNumber(TB_ItemPrice, 2)

    '        Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & TB_ItemId & "'")

    '        TB_TaxItem = (SelectDataItem(0)("ItemPrice") * SelectDataItem(0)("Multiply") / 100)
    '        TB_InitPrice = FormatNumber((selectPrice(0)("ItemPrice") - TB_TaxItem), 2)
    '        TB_UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
    '        ItemId = POS.DataGridViewPOS.Rows(a).Cells("ItemId").Value
    '        TB_TotalItem = POS.DataGridViewPOS.Rows(a).Cells(2).Value * TB_ItemAmount
    '        TB_SubTotalItem = FormatNumber(TB_InitPrice * TB_ItemAmount, 2)
    '        TB_BahtDC = POS.DataGridViewPOS.Rows(a).Cells(5).Value
    '        'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,BahtDC,TerminalName,UserId) VALUES('0','" & TB_ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & TB_InitPrice & "','" & TB_UnitPrice & "',1,'" & TB_InitPrice & "','" & TB_TaxItem & "','" & TB_UnitPrice & "','" & TB_InsertDate & "','" & TB_BahtDC & "','" & Environment.MachineName & "','" & Frm_Login.UserId & "')")

    '        Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")

    '        'Insert To Sale Item Order
    '        Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")

    '        'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & GetSaleItemID(0)("InsertDate") & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & SelectDataItem(0)("ItemName") & "')")
    '    ElseIf checkExists = False Then
    '        TB_ItemAmount = 1
    '        TB_ItemPrice = TB_ItemAmount * selectPrice(0)("ItemPrice")
    '        TB_ItemPricePerUnit = selectPrice(0)("ItemPrice")
    '        POS.DataGridViewPOS.Rows.Add(TB_ItemName, TB_ItemAmount, FormatNumber(TB_ItemPricePerUnit, 2), FormatNumber(TB_ItemPrice, 2), TB_ItemId, 0, 0)
    '        POS.DataGridViewPOS.ClearSelection()
    '        Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & TB_ItemId & "'")
    '        TB_TaxItem = (SelectDataItem(0)("ItemPrice") * SelectDataItem(0)("Multiply") / 100)
    '        TB_InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TB_TaxItem), 2)
    '        TB_UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
    '        TB_TotalItem = POS.DataGridViewPOS.CurrentRow.Cells(2).Value * TB_ItemAmount
    '        TB_SubTotalItem = FormatNumber(TB_InitPrice * TB_ItemAmount, 2)
    '        TB_BahtDC = POS.DataGridViewPOS.CurrentRow.Cells(5).Value
    '        'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,BahtDC,TerminalName,UserId) VALUES('0','" & TB_ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & TB_InitPrice & "','" & TB_UnitPrice & "',1,'" & TB_InitPrice & "','" & TB_TaxItem & "','" & TB_UnitPrice & "','" & TB_InsertDate & "','" & TB_BahtDC & "','" & Environment.MachineName & "','" & Frm_Login.UserId & "')")
    '        'Insert To Sale Item Order
    '        Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")
    '        Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")
    '        'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & GetSaleItemID(0)("InsertDate") & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & SelectDataItem(0)("ItemName") & "')")
    '    End If
    'End Sub
    'Sub CheckItem2()
    '    Dim PercentDC As Decimal = 0
    '    Dim BahtDC As Decimal = 0
    '    Dim AmtDC As Decimal = 0
    '    Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    '    Dim checkExists As Boolean = False
    '    Dim ToppingPrice As Decimal = 0
    '    Dim selectPrice As DataTable = executesql("SELECT ItemId,ItemPrice,ItemName FROM Item WHERE ItemId='" & TB_ItemId & "' AND Active=1")
    '    Dim a As Integer = 0
    '    For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
    '        'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
    '        '    Exit For
    '        'End If
    '        If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value Then
    '            checkExists = True
    '            a = i
    '            Exit For
    '        End If
    '    Next
    '    If checkExists = True Then
    '        ItemAmount = CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
    '        ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
    '        ItemName = selectPrice(0)("ItemName")
    '        If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
    '            ToppingPrice = (POS.DataGridViewPOS.Rows(a).Cells(3).Value - POS.DataGridViewPOS.Rows(a).Cells(2).Value) * ItemAmount
    '        End If
    '        POS.DataGridViewPOS.Rows(a).Cells(1).Value = ItemAmount
    '        POS.DataGridViewPOS.Rows(a).Cells(3).Value = FormatNumber(ItemPrice + ToppingPrice, 2)
    '        POS.DataGridViewPOS.ClearSelection()

    '        'MsgBox(TB_ItemId.ToString + "=" + ItemIdDg.ToString)

    '        Dim Amount As Integer = ItemAmount
    '        Dim Price As Decimal = ItemPrice
    '        Dim Sumprice As Integer = Amount * Price

    '        'select categoryid------------------------------------------------------------------
    '        Dim DataCategoryId As DataTable = executesql("SELECT CategoryId,ItemCode,ItemName,TaxId,ItemPrice,PrinterName FROM Item WHERE ItemId='" & TB_ItemId & "'")
    '        Dim CategoryId As Integer = DataCategoryId(0)("CategoryId")
    '        Dim ItemCode As String = DataCategoryId(0)("ItemCode")
    '        Dim TaxId As String = DataCategoryId(0)("TaxId")
    '        Dim PrinterName As String = DataCategoryId(0)("PrinterName")
    '        'Select Tax ------------------------------------------------------------------------
    '        Dim DataTax As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & TaxId & "'")
    '        Dim Multiply As Decimal = DataTax(0)("Multiply")
    '        'insert SaleItem --------------------------------------------------------------------
    '        If POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 0 Then
    '            BahtDC = POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value
    '            PercentDC = 0
    '        ElseIf POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 1 Then
    '            PercentDC = POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value
    '            BahtDC = 0
    '        End If
    '        Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
    '        Dim TaxItem As Decimal = DataCategoryId(0)("ItemPrice") - (DataCategoryId(0)("ItemPrice") * 100 / (DataTax(0)("Multiply") + 100))
    '        Dim InitPrice As Decimal = FormatNumber((DataCategoryId(0)("ItemPrice") - TaxItem), 2)
    '        Dim UnitPrice As Decimal = FormatNumber(DataCategoryId(0)("ItemPrice"), 2)
    '        Dim Qty As Integer = ItemAmount
    '        Dim SubTotal As Decimal = (((DataCategoryId(0)("ItemPrice") * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
    '        Dim Tax As Decimal = ((((DataCategoryId(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((DataCategoryId(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (DataTax(0)("Multiply") + 100)))
    '        Dim Total As Decimal = Qty * DataCategoryId(0)("ItemPrice")
    '        Dim Active As Integer = 3
    '        Dim StatusPrint As Integer = 0

    '        Dim UserId As Integer = Frm_Login.UserId
    '        Dim TerminalName As String = Environment.MachineName
    '        executesql("UPDATE SaleItem SET SaleId='0',ItemId='" & TB_ItemId & "',CategoryId='" & CategoryId & "',ItemCode='" & ItemCode & "',ItemName='" & ItemName & "',InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotal & "',Tax='" & Tax & "',Total='" & Total & "',TerminalName='" & TerminalName & "',UserId='" & UserId & "',PrinterName='" & PrinterName & "',StatusPrint='" & StatusPrint & "',InsertDate='" & TB_InsertDate & "',Active='" & Active & "' WHERE SaleItemId='" & selectSaleItemId(0)("SaleItemId") & "' AND ItemId='" & TB_ItemId & "'")

    '        Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "' group by Qty,InsertDate,ItemId,CategoryId")

    '        'Insert To Sale Item Order
    '        Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")

    '        'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName,Active) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & Convert.ToDateTime(GetSaleItemID(0)("InsertDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & ItemName & "','1')")
    '    Else
    '        ItemAmount = 1
    '        ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
    '        ItemPricePerUnit = selectPrice(0)("ItemPrice")
    '        ItemName = selectPrice(0)("ItemName")
    '        POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
    '        POS.DataGridViewPOS.ClearSelection()

    '        ItemAmount = CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
    '        ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
    '        ItemName = selectPrice(0)("ItemName")

    '        'MsgBox(TB_ItemId.ToString + "=" + ItemIdDg.ToString)

    '        Dim Amount As Integer = ItemAmount
    '        Dim Price As Decimal = ItemPrice
    '        Dim Sumprice As Integer = Amount * Price

    '        'select categoryid------------------------------------------------------------------
    '        Dim DataCategoryId As DataTable = executesql("SELECT CategoryId,ItemCode,ItemName,TaxId,ItemPrice,PrinterName FROM Item WHERE ItemId='" & TB_ItemId & "'")
    '        Dim CategoryId As Integer = DataCategoryId(0)("CategoryId")
    '        Dim ItemCode As String = DataCategoryId(0)("ItemCode")
    '        Dim TaxId As String = DataCategoryId(0)("TaxId")
    '        Dim PrinterName As String = DataCategoryId(0)("PrinterName")
    '        'Select Tax ------------------------------------------------------------------------
    '        Dim DataTax As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & TaxId & "'")
    '        Dim Multiply As Decimal = DataTax(0)("Multiply")
    '        'insert SaleItem --------------------------------------------------------------------
    '        If POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 0 Then
    '            BahtDC = POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value
    '            PercentDC = 0
    '        ElseIf POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 1 Then
    '            PercentDC = POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value
    '            BahtDC = 0
    '        End If
    '        Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
    '        Dim TaxItem As Decimal = DataCategoryId(0)("ItemPrice") - (DataCategoryId(0)("ItemPrice") * 100 / (DataTax(0)("Multiply") + 100))
    '        Dim InitPrice As Decimal = FormatNumber((DataCategoryId(0)("ItemPrice") - TaxItem), 2)
    '        Dim UnitPrice As Decimal = FormatNumber(DataCategoryId(0)("ItemPrice"), 2)
    '        Dim Qty As Integer = 1
    '        Dim SubTotal As Decimal = (((DataCategoryId(0)("ItemPrice") * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
    '        Dim Tax As Decimal = ((((DataCategoryId(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((DataCategoryId(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (DataTax(0)("Multiply") + 100)))
    '        Dim Total As Decimal = Qty * DataCategoryId(0)("ItemPrice")
    '        Dim StatusPrint As Integer = 0
    '        Dim Active As Integer = 3
    '        Dim UserId As Integer = Frm_Login.UserId
    '        Dim TerminalName As String = Environment.MachineName
    '        'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,TerminalName,UserId,PrinterName,StatusPrint,InsertDate,Active) VALUES('0','" & TB_ItemId & "','" & CategoryId & "','" & ItemCode & "','" & ItemName & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotal & "','" & Tax & "','" & Total & "','" & TerminalName & "','" & UserId & "','" & PrinterName & "','" & StatusPrint & "','" & TB_InsertDate & "','" & Active & "')")

    '        Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "' group by Qty,InsertDate,ItemId,CategoryId")

    '        'Insert To Sale Item Order
    '        Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")

    '        'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName,Active) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & Convert.ToDateTime(GetSaleItemID(0)("InsertDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & ItemName & "','1')")

    '    End If
    'End Sub
    Sub CheckItem3()
        Dim checkExists As Boolean = False
        Dim ToppingPrice As Decimal = 0
        Dim selectPrice As DataTable = executesql("SELECT ItemId,ItemPrice FROM Item WHERE ItemId='" & TB_ItemId & "' AND Active=1")
        Dim a As Integer
        For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    Exit For
            'End If
            If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value Then
                checkExists = True
                a = i
                Exit For
            End If
        Next
        If checkExists = True And checktopping_Table = 2 Then
            'ItemAmount = CDbl(POS.DataGridViewPOS.Rows(ToppingList_Table.rowToppingTable).Cells(1).Value + 1)
            'ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            'If POS.DataGridViewPOS.Rows(ToppingList_Table.rowToppingTable).Cells("Topping").Value = 1 Then
            '    ItemPrice = (POS.DataGridViewPOS.Rows(ToppingList_Table.rowToppingTable).Cells(3).Value / POS.DataGridViewPOS.Rows(ToppingList_Table.rowToppingTable).Cells(1).Value) * ItemAmount
            'End If
            'POS.DataGridViewPOS.Rows(ToppingList_Table.rowToppingTable).Cells(1).Value = ItemAmount
            'POS.DataGridViewPOS.Rows(ToppingList_Table.rowToppingTable).Cells(3).Value = FormatNumber(ItemPrice, 2)
            'POS.DataGridViewPOS.ClearSelection()
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = True And checktopping_Table = 3 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = True And checktopping_Table = 1 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
            ToppingList_Table.addToPos()
            'ElseIf checkExists = True And checktopping_Table = 0 Then
            '    ItemAmount = CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
            '    ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            '    If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
            '        ToppingPrice = (POS.DataGridViewPOS.Rows(a).Cells(3).Value - POS.DataGridViewPOS.Rows(a).Cells(2).Value) * ItemAmount
            '    End If
            '    POS.DataGridViewPOS.Rows(a).Cells(1).Value = ItemAmount
            '    POS.DataGridViewPOS.Rows(a).Cells(3).Value = FormatNumber(ItemPrice + ToppingPrice, 2)
            '    POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = False And checktopping_Table = 2 Or checktopping_Table = 0 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, 1, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = False And checktopping_Table = 3 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = False And checktopping_Table = 1 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(TB_ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), TB_ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
            ToppingList_Table.addToPos()
            'ElseIf checkExists = False And checktopping_Table = 0 Then
            '    ItemAmount = 1
            '    ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            '    ItemPricePerUnit = selectPrice(0)("ItemPrice")
            '    POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            '    POS.DataGridViewPOS.ClearSelection()
        End If
        'TB_ItemId = 0
        checktopping_Table = 0
        calculatePrice()
    End Sub
    Dim totalDiscount As Decimal
    Dim Type As Integer
    Sub calculatePrice()
        TB_Total = 0
        totalDiscount = 0
        POS.txtDiscount.Text = FormatNumber(0, 2)
        For j As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            TB_Total += POS.DataGridViewPOS.Rows(j).Cells(3).Value
            totalDiscount += POS.DataGridViewPOS.Rows(j).Cells(5).Value
        Next
        'DisCount = 0
        If Type = 0 Then
            POS.txtDiscount.Text = FormatNumber(totalDiscount, 2)
        Else
            POS.txtDiscount.Text = FormatNumber(TB_DisCount, 2)
        End If
        TB_SubTotal = TB_Total - TB_DisCount
        POS.txtTotal.Text = FormatNumber(TB_Total, 2)
        POS.txtSubTotal.Text = FormatNumber(TB_SubTotal, 2)
    End Sub
    Sub SaveSaleTable()
        Dim TB_saleName As String = POS.txtTableName.Text
        Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_subtotal As Decimal = POS.txtSubTotal.Text
        Dim TB_total As Decimal = POS.txtTotal.Text
        Dim TB_IsCloseBill As Integer = 0
        Dim TB_CustomerId As Integer = 0
        Dim TB_Active As Integer = 1
        Dim TB_openUserId As Integer = Frm_Login.UserId
        'Dim TB_Qty As Decimal
        'Dim TB_InitPrice As Decimal
        'Dim TB_UnitPrice As Decimal
        'Dim TB_SubTotalItem As Decimal
        'Dim TB_TotalItem As Decimal
        'Dim TB_TaxItem As Decimal
        'Dim TB_BahtDC As Decimal
        Dim SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim EndTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim CloseBillUserId As Integer = Frm_Login.UserId
        Dim OpenUserId As Integer = Frm_Login.UserId
        Dim CurrentUser As Integer = Frm_Login.UserId
        Dim Active As Integer = 3
        Dim IsPrintFullTax As Integer = 1
        Dim IsCloseBill As Integer = 0
        Dim SaveBillCount As Integer = 0
        Dim SubTotal As Decimal = POS.txtSubTotal.Text
        Dim Total As Decimal = POS.txtTotal.Text
        Dim Terminalid As Integer = 0
        Dim CustomerId As Integer = FrmCustomerMemberNo.CustomerId
        Dim NumOfCust As Integer = 0
        Dim TaxAmt As Decimal = 0
        Dim SaleName As String
        Dim AllowPrint As Integer = 0

        Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate LIKE '%" & Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) & "%'")
        'Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate='" & InsertDate & "'")
        Dim No As Integer = 0
        If checkSaleNo.Rows.Count = 0 Then
            No = 1
        Else
            No = checkSaleNo.Rows.Count + 1
        End If
        NumQ = No
        Dim SaleNo As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH")) & No.ToString("0000")
        Dim ABBNo As String
        Dim FullTaxNo As String
        Dim IsUsing As Integer = 1

        Dim ItemId As Integer
        Dim Qty As Decimal
        Dim InitPrice As Decimal
        Dim UnitPrice As Decimal
        Dim SubTotalItem As Decimal
        Dim TotalItem As Decimal
        Dim TaxItem As Decimal
        Dim MatAmount As Decimal

        Dim MatInitCostUseReceipe As Decimal
        Dim MatUnitCostUseReceipe As Decimal
        Dim TotalInitCostUseReceip As Decimal
        Dim TotalCostUseReceipe As Decimal
        Dim MatAmount2 As Decimal
        Dim TaxAmount As Decimal = 0
        Dim PercentDC As Decimal = 0
        Dim BahtDC As Decimal = 0
        Dim AmtDC As Decimal = 0
        Dim TotalCash As Decimal = 0
        Dim TotalCretdit As Decimal = 0
        'If Pos_DiscountPercent.DiscPer IsNot "" Then
        '    PercentDC = Pos_DiscountPercent.DiscPer
        'End If
        'If Pos_Discount.Discount_value IsNot "" Then
        '    BahtDC = Pos_Discount.Discount_value
        'End If

        Dim AmountDC As Decimal = 0
        Dim TerminalName As String = Environment.MachineName
        Dim aleardyPromotion As Boolean = False
        Dim PromotionId As Integer
        Dim ItemPromotionId As Integer
        Dim IsGetPoint As Boolean = True
        For a As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            If POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
            Else
                aleardyPromotion = True
                PromotionId = POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value
                ItemPromotionId = POS.DataGridViewPOS.Rows(a).Cells("ItemIdPromotionId").Value
                Exit For
            End If
        Next
        'Dim checkDiscount As Boolean = False
        'For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
        '    If POS.DataGridViewPOS.Rows(i).Cells("AllowDC").Value = 1 Then
        '        checkDiscount = True
        '        Exit For
        '    End If
        'Next
        If POS.DiscountByItem2 = 1 Then
            AmountDC = 0
        Else POS.DiscountByItem2 = 2
            AmountDC = POS.txtDiscount.Text
        End If
        If TB_GetSaleId = 0 Then
            'executesql("INSERT INTO Sale(Subtotal,Total,InsertDate,IsCloseBill,Active,CustomerId,StartTime) VALUES('" & TB_subtotal & "','" & TB_total & "','" & TB_InsertDate & "'," & TB_IsCloseBill & "," & TB_Active & ",'" & TB_CustomerId & "','" & TB_StartTime & "')")
            ''Print_()


            'Dim selectSaleId As DataTable = executesql("SELECT Max(saleId) AS SaleId FROM Sale")
            'Dim GetSaleItemID As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")
            ''Update SaleId
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            '    executesql("UPDATE SaleItem SET SaleId='" & selectSaleId(0)("SaleId") & "',Active=1 WHERE ItemId='" & POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value & "' AND SaleId=0 AND Active=3")
            'Next
            executesql("INSERT INTO Sale(SaleDate,SubTotal,TaxAmt,Total,ABBNo,FullTaxNo,IsPrintFullTax,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,StartTime,TerminalId,TerminalName,AmountDC,SaleNo) VALUES('" & SaleDate & "','" & SubTotal & "','" & TaxAmt & "','" & Total & "','" & ABBNo & "','" & FullTaxNo & "','" & IsPrintFullTax & "','" & InsertDate & "','" & CloseBillUserId & "','" & IsCloseBill & "','" & Active & "','" & SaveBillCount & "','" & CustomerId & "','" & NumOfCust & "','" & StartTime & "','" & Terminalid & "','" & TerminalName & "','" & AmountDC & "','" & SaleNo & "')")
            Dim selectSaleId As DataTable = executesql("SELECT Max(SaleId) As SaleId FROM Sale")
            TB_GetSaleId = selectSaleId(0)("SaleId")
            executesql("INSERT INTO SaleTabRef(TableId) VALUES('" & TableId & "')")
            Dim selectSaleTabId As DataTable = executesql("SELECT Max(SaleTabId) AS SaleTabId FROM SaleTabRef")
            executesql("INSERT INTO SaleTable(SaleTabId,SaleId,SaleName,InsertDate,OpenUserId,Active,CurrentUserUsed) VALUES('" & selectSaleTabId(0)("SaleTabId") & "','" & selectSaleId(0)("SaleId") & "','" & TB_saleName & "','" & TB_InsertDate & "','" & TB_openUserId & "','" & TB_Active & "','" & Frm_Login.UserId & "')")
            executesql("UPDATE Tables SET StateStatus=1 WHERE TableId='" & TableId & "'")
            'Insert SaleItem
            For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
                ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
                Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value
                Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
                Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName,AllowPrint FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")

                If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                    BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                    PercentDC = 0
                ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                    PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                    BahtDC = 0
                End If
                If Printer_cate(0)("AllowPrint") = 0 Then
                    AllowPrint = 2
                ElseIf Printer_cate(0)("AllowPrint") = 1 Then
                    AllowPrint = 0
                End If
                TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
                InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                'TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmt += TaxAmount


                If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                    executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName,UserId) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',3," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "','" & Frm_Login.UserId & "')")
                    'Insert UseReceipeItem
                    Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                    Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                    Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                    Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                    If IsNothing(SelectReceipe) Then
                        'DisStock
                        If SelectDataItem(0)("IsTrackStock") = 1 Then
                            MatAmount = Qty
                            'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                            MatAmount = Qty
                            ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        End If
                    ElseIf SelectReceipe.Rows.Count = 0 Then
                        'DisStock
                        If SelectDataItem(0)("IsTrackStock") = 1 Then
                            MatAmount = Qty
                            'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                            MatAmount = Qty
                            ''MsgBox(SelectDataItem(i)("ItemCode"))
                            ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        End If
                    Else
                        For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                            MatAmount2 = SelectReceipe(j)("Qty")
                            MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                            MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                            TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                            TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                            executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                            'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & SelectReceipe(j)("MatId") & "'")
                        Next
                    End If
                    'Insert Topping
                    'Dim ToppingName As String =

                    If POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 Then
                        Dim ToppingName As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        For a As Integer = 0 To ToppingName.Length - 1
                            Dim selectTopping As DataTable = executesql("SELECT Topping.ToppingId,Topping.Pricing,Topping.ToppingName,ToppingReceipe.* FROM Topping INNER JOIN ToppingReceipe ON(Topping.ToppingId = ToppingReceipe.ToppingId) WHERE Topping.ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                            Dim ToppingData As DataTable = executesql("SELECT ToppingId,ToppingName,Pricing FROM Topping WHERE ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                            If selectTopping.Rows.Count > 0 Then
                                For r As Integer = 0 To selectTopping.Rows.Count - 1
                                    'UseTopping
                                    'UseReceipeTopping
                                    'executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & selectTopping(0)("MatIdTopping") & "','" & selectTopping(0)("Qty") & "','" & selectTopping(0)("MatinitCost") & "','" & selectTopping(0)("MatUnitCost") & "','" & selectTopping(0)("TotalInitCost") & "','" & selectTopping(0)("TotalCost") & "','" & InsertDate & "')")

                                    executesql("INSERT INTO UseReceipeTopping(ToppingReceipeId,ToppingId,MatIdTopping,MatName,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost) VALUES('" & selectTopping(r)("ToppingReceipeId") & "','" & selectTopping(r)("ToppingId") & "','" & selectTopping(r)("MatIdTopping") & "','" & selectTopping(r)("MatName") & "','" & selectTopping(r)("Qty") & "','" & selectTopping(r)("MatInitCost") & "','" & selectTopping(r)("MatUnitCost") & "','" & selectTopping(r)("TotalInitCost") & "','" & selectTopping(r)("TotalCost") & "')")

                                    Dim selectItemCode As DataTable = executesql("SELECT Item.ItemCode From ToppingReceipe INNER JOIN Item ON(Item.ItemName = ToppingReceipe.MatName) WHERE ToppingReceipe.MatName = '" & selectTopping(r)("MatName") & "'")
                                    Dim q As Decimal = selectTopping(r)("Qty")
                                    Dim tItemid As Integer = selectTopping(r)("MatIdTopping")
                                    'executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")
                                Next
                            End If
                            If ToppingData.Rows.Count > 0 Then
                                executesql("INSERT INTO UseTopping(ToppingId,SaleItemId,ToppingName,InsertDate) VALUES('" & ToppingData(0)("ToppingId") & "','" & SaleItemId & "','" & ToppingData(0)("ToppingName") & "','" & InsertDate & "')")
                            End If
                            If ToppingData.Rows.Count > 0 Then
                                'Clipboard.SetText("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                                executesql("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                                Dim selectSubTotal As DataTable = executesql("select SaleId,SubTotal from SaleItem where SaleItemId='" & SaleItemId & "'")
                                Dim TaxTopping As Decimal = ((ToppingData(0)("Pricing") * Qty) - ((ToppingData(0)("Pricing") * Qty) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                Dim UpdateSubTotal As Decimal = (selectSubTotal(0)("SubTotal") - (selectSubTotal(0)("SubTotal") * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                executesql("update SaleItem set Tax='" & UpdateSubTotal & "' where SaleItemId='" & SaleItemId & "'")
                                TaxAmt += TaxTopping
                            End If
                        Next
                    End If
                    If POS.DataGridViewPOS.Rows(i).Cells("Selection").Value IsNot Nothing Then
                        'Insert Selection 
                        Dim Selection As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        For g As Integer = 1 To Selection.Length - 1
                            Dim selectSelection As DataTable = executesql("SELECT * FROM Selection WHERE SelectionName='" & Selection(g).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                            Dim selectionId2 As Integer = POS.DataGridViewPOS.Rows(i).Cells(9).Value
                            If selectSelection.Rows.Count = 0 Then
                                selectionId2 = 0
                            Else
                                selectionId2 = selectSelection(0)("SelectionId")
                                executesql("INSERT INTO UseSelection(SelectionId,SaleItemId,SelectionName) VALUES('" & selectionId2 & "','" & SaleItemId & "','" & selectSelection(0)("SelectionName") & "')")
                            End If
                        Next
                    End If
                    'Insert To Sale Item Order
                    'Clipboard.SetText("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem")
                    Dim GetSaleItemID As DataTable = executesql("SELECT ItemName,SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem where SaleItemId=(SELECT Max(SaleItemId) As SaleItemId FROM SaleItem)")
                    Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")
                    executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName,Active) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & Convert.ToDateTime(GetSaleItemID(0)("InsertDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & GetSaleItemID(0)("ItemName") & "','1')")
                End If
            Next
            executesql("update Sale set TaxAmt = '" & TaxAmt & "' where SaleId = '" & selectSaleId(0)("SaleId") & "'")

        Else
            Dim checkTax As Boolean = False
            Dim checkDisc As Boolean = False
            'update
            If POS.DiscountByItem2 = 1 Then
                AmountDC = 0
            Else POS.DiscountByItem2 = 2
                AmountDC = POS.txtDiscount.Text
            End If
            executesql("UPDATE SaleTable SET UpdateDate='" & TB_UpdateDate & "' WHERE SaleId='" & TB_GetSaleId & "'")
            'executesql("UPDATE Sale SET Subtotal='" & POS.txtSubTotal.Text & "',Total='" & POS.txtTotal.Text & "',UpdateDate='" & TB_UpdateDate & "',AmountDC='" & AmountDC & "' WHERE SaleId='" & TB_GetSaleId & "'")
            executesql("UPDATE Sale SET Subtotal='" & Convert.ToDecimal(POS.txtSubTotal.Text) & "',Total='" & Convert.ToDecimal(POS.txtTotal.Text) & "',UpdateDate='" & TB_UpdateDate & "',AmountDC='" & Convert.ToDecimal(AmountDC) & "' WHERE SaleId='" & TB_GetSaleId & "'")
            ''Update SaleId
            'Dim GetSaleItemID As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND
            'ModulePrinrOrder.PrinteOrder() UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            '    executesql("UPDATE SaleItem SET SaleId='" & TB_GetSaleId & "',Active=1 WHERE ItemId='" & POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value & "' AND SaleId=0 AND Active=3")
            'Next
            ''executesql("UPDATE SaleItem SET SaleId='" & TB_GetSaleId & "',Active=1 WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND SaleId=0 AND Active=3")
            'Print_()
            Dim checkExists As Boolean = False
            Dim checkExists2 As Boolean = False
            Dim checkItem As DataTable
            'Dim selectTableId2 As DataTable = executesql("select TableId2 From Tables where TableId = '" & ModuleZoneTable.TableId & "'")
            'If IsDBNull(selectTableId2(0)("TableId2")) Then
            checkItem = executesql("SELECT SaleItem.SaleItemId,Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
Tables.TableName,Item.CategoryId
FROM Sale 
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
INNER JOIN Item on(Item.ItemId = SaleItem.ItemId)
WHERE Sale.SaleId='" & TB_GetSaleId & "' AND Sale.Active=3 AND SaleItem.Active=3
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101),
Tables.TableName,Item.CategoryId")
            '            Else
            '                Dim a As String() = selectTableId2(0)("TableId2").split({","}, StringSplitOptions.None)
            '                Dim c As Integer = a.Length
            '                Dim TabId2 As DataTable = executesql("select TableId from SaleTabRef where TableId ='" & a(c - 1) & "'")
            '                checkItem = executesql("SELECT SaleItem.SaleItemId,Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
            'SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
            'SaleItem.BahtDC,SaleItem.PercentDC,SaleItem.AmtDC,
            'SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
            'CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
            'CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
            'CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
            'Tables.TableName,Item.CategoryId
            'FROM Sale 
            'INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
            'INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
            'INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
            'INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
            'INNER JOIN Item on(Item.ItemId = SaleItem.ItemId)
            'WHERE SaleTabRef.TableId='" & TabId2(0)("TableId") & "' AND Sale.Active=3 AND SaleItem.Active=3
            'GROUP BY Sale.SaleId,Sale.SubTotal,
            'Sale.Total,SaleItem.SaleItemId,
            'SaleItem.ItemId,SaleItem.ItemName,
            'SaleItem.Total,SaleItem.BahtDC,
            'SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,
            'SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
            'CONVERT(date,SaleTable.InsertDate ,101),
            'CONVERT(date,SaleTable.UpdateDate ,101),
            'Tables.TableName,Item.CategoryId")
            '            End If

            Dim rowscheckItem As Integer = checkItem.Rows.Count

                For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
                    ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
                    Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value
                    Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")

                    TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
                    InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                    UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                    TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                    SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                    'TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                    TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                    TaxAmt += TaxAmount

                    Dim SelectDataItem2 As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
                    Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName,AllowPrint FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")

                    Dim checkSaleItem As DataTable = executesql("SELECT ItemId FROM SaleItem WHERE SaleId=" & TB_GetSaleId & " AND ItemId='" & ItemId & "'")

                    If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                        If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                            BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            PercentDC = 0
                        ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                            PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            BahtDC = 0
                        End If
                        If checkSaleItem.Rows.Count = 0 Then
                            'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,Active,PercentDC,BahtDC,AmtDC,TerminalName) VALUES('" & TB_GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxItem * Qty & "','" & TotalItem & "','" & InsertDate & "','1','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "')")
                        Else
                            'executesql("UPDATE SaleItem SET Active='1',InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxItem * Qty & "',Total='" & TotalItem & "',UpdateDate='" & UpdateDate & "',BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',AmtDC='" & AmtDC & "' WHERE SaleId='" & TB_GetSaleId & "'")
                        End If
                        'CheckItem

                        'MsgBox(rowscheckItem)
                        'If i <= rowscheckItem - 1 Then
                        If POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value IsNot Nothing Then
                            'เพิ่มจำนวน
                            'MsgBox(4)
                            If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                                BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                PercentDC = 0
                            ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                                PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                BahtDC = 0
                            End If
                            'check Cancel Item
                            If checkItem(i)("Qty") > POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                                Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & checkItem(0)("CategoryId") & "'")
                                executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & checkItem(i)("SaleItemId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & checkItem(i)("Qty") - POS.DataGridViewPOS.Rows(i).Cells(1).Value & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
                            End If
                            executesql("UPDATE SaleItem SET InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxAmount & "',Total='" & TotalItem & "',UpdateDate='" & UpdateDate & "',BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',AmtDC='" & AmtDC & "' WHERE SaleId='" & TB_GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "'")
                        Else

                            '    checkTax = False
                            '    If checkItem(i)("ItemId") = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value Is Nothing And checkItem(i)("Qty") = POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            '        checkExists = True
                            '    Else
                            '        checkExists = False
                            '    End If
                            '    If checkItem(i)("ItemId") = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 And checkItem(i)("Qty") = POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            '        checkExists2 = True
                            '    Else
                            '        checkExists2 = False
                            '    End If

                            '    If checkExists2 = True Then
                            '        If checkExists = True Then
                            '            'checktopping_Table = 0
                            '            'ModulePosTable.checkItem()
                            '            'MsgBox(1)
                            '        ElseIf checkExists = False Then
                            '            'เหมือนเดิม
                            '            'MsgBox(2)
                            '            If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                            '                BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            '                PercentDC = 0
                            '            ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                            '                PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            '                BahtDC = 0
                            '            End If
                            '            checkDisc = True
                            '            'check Cancel Item
                            '            If checkItem(i)("Qty") > POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            '                Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & checkItem(0)("CategoryId") & "'")
                            '                executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & checkItem(i)("SaleItemId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & checkItem(i)("Qty") - POS.DataGridViewPOS.Rows(i).Cells(1).Value & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
                            '            End If
                            '            executesql("UPDATE SaleItem SET BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',UpdateDate='" & UpdateDate & "' WHERE SaleId='" & TB_GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "'")
                            '        End If
                            '    ElseIf checkExists2 = False Then
                            '        If checkExists = True Then
                            '            'เหมือนเดิม
                            '            'MsgBox(3)
                            '            If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                            '                BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            '                PercentDC = 0
                            '            ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                            '                PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            '                BahtDC = 0
                            '            End If
                            '            checkDisc = True
                            '            'check Cancel Item
                            '            If checkItem(i)("Qty") > POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            '                Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & checkItem(0)("CategoryId") & "'")
                            '                executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & checkItem(i)("SaleItemId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & checkItem(i)("Qty") - POS.DataGridViewPOS.Rows(i).Cells(1).Value & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
                            '            End If
                            '            executesql("UPDATE SaleItem SET BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',UpdateDate='" & UpdateDate & "' WHERE SaleId='" & TB_GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "'")
                            '        ElseIf checkExists = False Then
                            '            'เพิ่มจำนวน
                            '            'MsgBox(4)
                            '            If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                            '                BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            '                PercentDC = 0
                            '            ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                            '                PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            '                BahtDC = 0
                            '            End If
                            '            'check Cancel Item
                            '            If checkItem(i)("Qty") > POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            '                Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & checkItem(0)("CategoryId") & "'")
                            '                executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & checkItem(i)("SaleItemId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & checkItem(i)("Qty") - POS.DataGridViewPOS.Rows(i).Cells(1).Value & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
                            '            End If
                            '            executesql("UPDATE SaleItem SET InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxAmount & "',Total='" & TotalItem & "',UpdateDate='" & UpdateDate & "',BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',AmtDC='" & AmtDC & "' WHERE SaleId='" & TB_GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "'")
                            '        End If
                            '    End If

                            'Else
                            'Add New
                            checkTax = True
                            If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                                executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName,UserId) VALUES('" & TB_GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',3," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "','" & Frm_Login.UserId & "')")
                                'Insert UseReceipeItem
                                Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                                Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                                Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                                Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                                If IsNothing(SelectReceipe) Then
                                    'DisStock
                                    If SelectDataItem(0)("IsTrackStock") = 1 Then
                                        MatAmount = Qty
                                        'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                    ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                        MatAmount = Qty
                                        ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                    End If
                                ElseIf SelectReceipe.Rows.Count = 0 Then
                                    'DisStock
                                    If SelectDataItem(0)("IsTrackStock") = 1 Then
                                        MatAmount = Qty
                                        'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                    ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                        MatAmount = Qty
                                        ''MsgBox(SelectDataItem(i)("ItemCode"))
                                        ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                    End If
                                Else
                                    For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                                        MatAmount2 = SelectReceipe(j)("Qty")
                                        MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                                        MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                                        TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                                        TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                                        executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                                        'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & SelectReceipe(j)("MatId") & "'")
                                    Next
                                End If
                                'Insert Topping
                                'Dim ToppingName As String =
                                If POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 Then
                                    Dim ToppingName As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    For a As Integer = 0 To ToppingName.Length - 1
                                        Dim selectTopping As DataTable = executesql("SELECT Topping.ToppingId,Topping.Pricing,Topping.ToppingName,ToppingReceipe.* FROM Topping INNER JOIN ToppingReceipe ON(Topping.ToppingId = ToppingReceipe.ToppingId) WHERE Topping.ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                                        Dim ToppingData As DataTable = executesql("SELECT ToppingId,ToppingName,Pricing FROM Topping WHERE ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                                        If selectTopping.Rows.Count > 0 Then
                                            For r As Integer = 0 To selectTopping.Rows.Count - 1
                                                'UseTopping
                                                'UseReceipeTopping
                                                'executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & selectTopping(0)("MatIdTopping") & "','" & selectTopping(0)("Qty") & "','" & selectTopping(0)("MatinitCost") & "','" & selectTopping(0)("MatUnitCost") & "','" & selectTopping(0)("TotalInitCost") & "','" & selectTopping(0)("TotalCost") & "','" & InsertDate & "')")

                                                executesql("INSERT INTO UseReceipeTopping(ToppingReceipeId,ToppingId,MatIdTopping,MatName,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost) VALUES('" & selectTopping(r)("ToppingReceipeId") & "','" & selectTopping(r)("ToppingId") & "','" & selectTopping(r)("MatIdTopping") & "','" & selectTopping(r)("MatName") & "','" & selectTopping(r)("Qty") & "','" & selectTopping(r)("MatInitCost") & "','" & selectTopping(r)("MatUnitCost") & "','" & selectTopping(r)("TotalInitCost") & "','" & selectTopping(r)("TotalCost") & "')")

                                                Dim selectItemCode As DataTable = executesql("SELECT Item.ItemCode From ToppingReceipe INNER JOIN Item ON(Item.ItemName = ToppingReceipe.MatName) WHERE ToppingReceipe.MatName = '" & selectTopping(r)("MatName") & "'")
                                                Dim q As Decimal = selectTopping(r)("Qty")
                                                Dim tItemid As Integer = selectTopping(r)("MatIdTopping")
                                                'executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")
                                            Next
                                        End If
                                        If ToppingData.Rows.Count > 0 Then
                                            executesql("INSERT INTO UseTopping(ToppingId,SaleItemId,ToppingName,InsertDate) VALUES('" & ToppingData(0)("ToppingId") & "','" & SaleItemId & "','" & ToppingData(0)("ToppingName") & "','" & InsertDate & "')")
                                        End If
                                        If ToppingData.Rows.Count > 0 Then
                                            'Clipboard.SetText("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                                            executesql("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                                            Dim selectSubTotal As DataTable = executesql("select SaleId,SubTotal from SaleItem where SaleItemId='" & SaleItemId & "'")
                                            Dim TaxTopping As Decimal = ((ToppingData(0)("Pricing") * Qty) - ((ToppingData(0)("Pricing") * Qty) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                            Dim UpdateSubTotal As Decimal = (selectSubTotal(0)("SubTotal") - (selectSubTotal(0)("SubTotal") * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                            executesql("update SaleItem set Tax='" & UpdateSubTotal & "' where SaleItemId='" & SaleItemId & "'")
                                            TaxAmt += TaxTopping
                                        End If
                                    Next
                                End If
                                If POS.DataGridViewPOS.Rows(i).Cells("Selection").Value IsNot Nothing Then
                                    'Insert Selection 
                                    Dim Selection As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    For g As Integer = 1 To Selection.Length - 1
                                        Dim selectSelection As DataTable = executesql("SELECT * FROM Selection WHERE SelectionName='" & Selection(g).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                                        Dim selectionId2 As Integer = POS.DataGridViewPOS.Rows(i).Cells(9).Value
                                        If selectSelection.Rows.Count = 0 Then
                                            selectionId2 = 0
                                        Else
                                            selectionId2 = selectSelection(0)("SelectionId")
                                            executesql("INSERT INTO UseSelection(SelectionId,SaleItemId,SelectionName) VALUES('" & selectionId2 & "','" & SaleItemId & "','" & selectSelection(0)("SelectionName") & "')")
                                        End If
                                    Next
                                End If
                            End If
                        End If

                    End If
                    If POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value = 0 Then
                        AmountDC = POS.txtDiscount.Text
                    End If
                Next
                If checkTax = True Then
                    executesql("update Sale set TaxAmt = '" & TaxAmt & "' where SaleId = '" & TB_GetSaleId & "'")
                ElseIf checkDisc = False Then
                    executesql("update Sale set AmountDC='" & AmountDC & "' where SaleId = '" & TB_GetSaleId & "'")
                End If
                'CheckItem
                'Insert To Sale Item Order
                'Clipboard.SetText("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND ItemId='" & TB_ItemId & "' group by Qty,InsertDate,ItemId,CategoryId")
                Dim GetSaleItemID As DataTable = executesql("SELECT ItemName,SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem where SaleItemId=(SELECT Max(SaleItemId) As SaleItemId FROM SaleItem)")
                Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")
                executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName,Active) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & Convert.ToDateTime(GetSaleItemID(0)("InsertDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & GetSaleItemID(0)("ItemName") & "','1')")
            End If

        'If TB_GetSaleId = 0 Then
        '    executesql("INSERT INTO Sale(Subtotal,Total,InsertDate,IsCloseBill,Active,CustomerId,StartTime) VALUES('" & TB_subtotal & "','" & TB_total & "','" & TB_InsertDate & "'," & TB_IsCloseBill & "," & TB_Active & ",'" & TB_CustomerId & "','" & TB_StartTime & "')")

        '    Dim selectSaleId As DataTable = executesql("SELECT Max(saleId) AS SaleId FROM Sale")

        '    executesql("INSERT INTO SaleTable(SaleTabId,SaleId,SaleName,InsertDate,OpenUserId,Active) VALUES('" & selectSaleTabId(0)("SaleTabId") & "','" & selectSaleId(0)("SaleId") & "','" & saleName & "','" & InsertDate & "','" & openUserId & "','" & Active & "')")

        '    For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
        '        ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
        '        Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value

        '        Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
        '        TaxItem = (SelectDataItem(0)("ItemPrice") * SelectDataItem(0)("Multiply") / 100)
        '        InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
        '        UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
        '        TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
        '        SubTotalItem = FormatNumber(InitPrice * Qty, 2)
        '        BahtDC = POS.DataGridViewPOS.Rows(i).Cells(5).Value
        '        Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")
        '        If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
        '            BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
        '            PercentDC = 0
        '        ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
        '            PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
        '            BahtDC = 0
        '        End If
        '        If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
        '            executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,Active,StatusPrint,PrinterName,PercentDC,BahtDC,AmtDC,TerminalName) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxItem * Qty & "','" & TotalItem & "','" & InsertDate & "','1','0','" & Printer_cate(0)("CatePrinterName") & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "')")
        '        End If
        '    Next
        'Else
        '    executesql("UPDATE SaleTable SET SaleName='" & saleName & "',UpdateDate='" & UpdateDate & "' WHERE SaleId='" & TB_GetSaleId & "'")
        '    For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
        '        ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
        '        Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value

        '        Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")

        '        TaxItem = (SelectDataItem(0)("ItemPrice") * SelectDataItem(0)("Multiply") / 100)
        '        InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
        '        UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
        '        TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
        '        SubTotalItem = FormatNumber(InitPrice * Qty, 2)
        '        BahtDC = POS.DataGridViewPOS.Rows(i).Cells(5).Value

        '        Dim checkSaleItem As DataTable = executesql("SELECT ItemId FROM SaleItem WHERE SaleId=" & TB_GetSaleId & " AND ItemId='" & ItemId & "'")

        '        If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
        '            If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
        '                BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
        '                PercentDC = 0
        '            ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
        '                PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
        '                BahtDC = 0
        '            End If
        '            If checkSaleItem.Rows.Count = 0 Then
        '                executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,Active,PercentDC,BahtDC,AmtDC,TerminalName) VALUES('" & TB_GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxItem * Qty & "','" & TotalItem & "','" & InsertDate & "','1','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "')")
        '            Else
        '                executesql("UPDATE SaleItem SET Active='1',InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxItem * Qty & "',Total='" & TotalItem & "',UpdateDate='" & UpdateDate & "',BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',AmtDC='" & AmtDC & "' WHERE SaleId='" & TB_GetSaleId & "'")
        '            End If
        '        End If
        '    Next
        'End If
    End Sub
    Public SaleTableId As Integer = 0
    Sub LoadSaveSaleTable()
        POS.txtDiscount.Text = 0
        Dim topping As Integer = Nothing
        Dim selection As Integer = Nothing
        Dim TableId2 As DataTable = executesql("select IsGroupTable,TableId2 From Tables where TableId = '" & TableId & "'")
        Dim checkSplitBill As DataTable
        Dim selectSaleData As DataTable
        '        If IsDBNull(TableId2(0)("IsGroupTable")) Or TableId2(0)("IsGroupTable") = 0 Then
        '            checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
        'INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
        'INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
        'INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
        'INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
        'WHERE SaleTabRef.TableId in(" & TableId & ") AND Sale.Active=3 AND SaleItem.Active=3 
        'GROUP BY Sale.SaleId")
        '        Else
        '            checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
        'INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
        'INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
        'INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
        'INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
        'WHERE SaleTabRef.TableId in(" & TableId2(0)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 
        'GROUP BY Sale.SaleId")
        '        End If
        Dim T1 As String
        If IsDBNull(TableId2(0)("IsGroupTable")) Then
            checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & TableId & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
            T1 = TableId
        Else
            If TableId2(0)("IsGroupTable") = 0 Then
                checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & TableId & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
                T1 = TableId
            Else
                checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & TableId2(0)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
                T1 = TableId2(0)("TableId2")
            End If
        End If
        If checkSplitBill.Rows.Count > 1 Then
            selectSaleData = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
Tables.TableName,SaleTable.SaleTabId
FROM Sale 
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE Sale.SaleId in(" & TB_GetSaleId & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101),
Tables.TableName,SaleTable.SaleTabId")
        Else
            selectSaleData = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
Tables.TableName,SaleTable.SaleTabId
FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & T1 & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101),
Tables.TableName,SaleTable.SaleTabId")
        End If
        If selectSaleData.Rows.Count = 0 Then
            TB_GetSaleId = 0
        Else
            TB_GetSaleId = selectSaleData(0)("SaleId")
        End If
        POS.DataGridViewPOS.Rows.Clear()
        Dim BahtDC As Decimal
        SaleTableId = selectSaleData(0)("SaleTabId")
        For i As Integer = 0 To selectSaleData.Rows.Count - 1
            If selectSaleData(i)("BahtDC") <> 0 Then
                POS.DiscountByItem2 = 1
                BahtDC = selectSaleData(i)("BahtDC")
                TB_DisCount = BahtDC
            ElseIf selectSaleData(i)("PercentDC") <> 0 Then
                POS.DiscountByItem2 = 1
                BahtDC = selectSaleData(i)("PercentDC")
                TB_DisCount = BahtDC
            End If
            POS.DataGridViewPOS.Rows.Add(selectSaleData(i)("ItemName"), FormatNumber(selectSaleData(i)("Qty"), 0), FormatNumber(selectSaleData(i)("UnitPrice"), 2), FormatNumber(selectSaleData(i)("SaleItem_SubTotal"), 2), selectSaleData(i)("ItemId"), FormatNumber(BahtDC, 2), selectSaleData(i)("SaleItemId"))
            If selectSaleData(i)("AmountDC") <> 0 Then
                POS.DiscountByItem2 = 2
                TB_DisCount = selectSaleData(i)("AmountDC")
                POS.DataGridViewPOS.Rows(i).Cells("AllowDC").Value = 1
                Type = 1
            End If
            Dim SelectUseTopping As DataTable = executesql("select 
UseTopping.ToppingId,UseTopping.SaleItemId,UseTopping.ToppingName,UseTopping.InsertDate,
SaleItem.ItemId
from UseTopping
inner join SaleItem on(SaleItem.SaleItemId = UseTopping.SaleItemId) 
where SaleItem.SaleItemId='" & selectSaleData(i)("SaleItemId") & "'")
            If SelectUseTopping.Rows.Count > 0 Then
                topping = 1
                For a As Integer = 0 To SelectUseTopping.Rows.Count - 1
                    If SelectUseTopping(a)("ItemId") = selectSaleData(i)("ItemId") Then
                        POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = topping
                    End If
                Next
            End If
            Dim SelectUseSelect As DataTable = executesql("select 
SaleItem.ItemId
from UseSelection
inner join SaleItem on(SaleItem.SaleItemId = UseSelection.SaleItemId) 
where SaleItem.SaleItemId='" & selectSaleData(i)("SaleItemId") & "'")
            If SelectUseSelect.Rows.Count > 0 Then
                selection = 1
                For a As Integer = 0 To SelectUseTopping.Rows.Count - 1
                    If SelectUseSelect(a)("ItemId") = selectSaleData(i)("ItemId") Then
                        POS.DataGridViewPOS.Rows(i).Cells("Selection").Value = selection
                    End If
                Next
            End If
            'POS.DataGridViewPOS.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon
            'POS.DataGridViewPOS.RowsDefaultCellStyle.BackColor = Color.Salmon
        Next
        POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ModulePosTable.calculatePrice()
        'totalDiscount += FormatNumber(BahtDC, 2)
        'SubTotal = FormatNumber(selectSaleData(0)("SubTotal"), 2)
        'POS.txtDiscount.Text = totalDiscount
        'POS.txtTotal.Text = SubTotal - totalDiscount
        'POS.txtSubTotal.Text = SubTotal
    End Sub
    Sub Print_()
        Dim Datatable As DataTable = executesql("Select SaleItemOrder.Id FROM Sale INNER JOIN SaleItem On (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleItemOrder On (SaleItemOrder.SaleItemId = SaleItem.SaleItemId) WHERE Sale.SaleId='" & TB_GetSaleId & "' AND SaleItemOrder.StatusPrint=0")
        For i As Integer = 0 To Datatable.Rows.Count - 1
            ModulePrinrOrder.PrintOrderTable()
        Next
    End Sub
    Sub SaleItemNoSave()
        executesql("UPDATE SaleItem SET Active=2 WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND SaleId=0 AND Active=0")
    End Sub
    Sub DelItem()
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

        Dim TB_subtotal As Decimal = POS.txtSubTotal.Text
        Dim TB_total As Decimal = POS.txtTotal.Text
        Dim TaxItem As Decimal = 0
        Dim TaxAmount As Decimal = 0
        Dim TaxAmt As Decimal = 0
        Dim ItemId As Integer = 0
        Dim Qty As Decimal = 0
        Dim InitPrice As Decimal = 0
        Dim UnitPrice As Decimal = 0
        Dim TotalItem As Decimal = 0
        Dim SubTotalItem As Decimal = 0
        Dim PercentDC As Decimal = 0
        Dim BahtDC As Decimal = 0

        ItemId = POS.DataGridViewPOS.CurrentRow.Cells("ItemId").Value
        Qty = POS.DataGridViewPOS.CurrentRow.Cells(1).Value
        Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")

        If POS.DataGridViewPOS.CurrentRow.Cells("discountType").Value = 0 Then
            BahtDC = POS.DataGridViewPOS.CurrentRow.Cells("ส่วนลด").Value
            PercentDC = 0
        ElseIf POS.DataGridViewPOS.CurrentRow.Cells("discountType").Value = 1 Then
            PercentDC = POS.DataGridViewPOS.CurrentRow.Cells("ส่วนลด").Value
            BahtDC = 0
        End If

        TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
        InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
        UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
        TotalItem = POS.DataGridViewPOS.CurrentRow.Cells(2).Value * Qty
        SubTotalItem = (((POS.DataGridViewPOS.CurrentRow.Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
        TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
        'Insert Cancel SaleItem
        Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")
        executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & POS.DataGridViewPOS.CurrentRow.Cells("SaleItemId").Value & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & Qty & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")

        executesql("UPDATE SaleItem Set Active = 0 ,UpdateDate = '" & UpdateDate & "' where SaleItemId='" & POS.DataGridViewPOS.CurrentRow.Cells("SaleItemId").Value & "'")
        executesql("update Sale set SubTotal='" & TB_subtotal & "',Total='" & TB_total & "',TaxAmt = '" & TaxAmt & "' where SaleId = '" & TB_GetSaleId & "'")
        POS.DataGridViewPOS.Rows.RemoveAt(POS.DataGridViewPOS.CurrentCell.RowIndex)
        ModulePosTable.calculatePrice()

    End Sub
    Sub CancelBill()
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim TaxItem As Decimal = 0
        Dim TaxAmount As Decimal = 0
        Dim TaxAmt As Decimal = 0
        Dim ItemId As Integer = 0
        Dim Qty As Decimal = 0
        Dim InitPrice As Decimal = 0
        Dim UnitPrice As Decimal = 0
        Dim TotalItem As Decimal = 0
        Dim SubTotalItem As Decimal = 0
        Dim PercentDC As Decimal = 0
        Dim BahtDC As Decimal = 0

        Dim checkIsBills As DataTable = executesql("select Sale.SaleId
from SaleTable
inner join Sale on(Sale.SaleId = SaleTable.SaleId)
inner join SaleItem on(Sale.SaleId = SaleItem.SaleId)
inner join SaleTabRef on(SaleTabRef.SaleTabId = SaleTable.SaleTabId)
inner join Tables on(SaleTabRef.TableId = Tables.TableId)
where Tables.TableId = '" & TableId & "' and Sale.Active = 3 group by Sale.SaleId")
        If checkIsBills.Rows.Count > 0 Then
            For a As Integer = 0 To checkIsBills.Rows.Count - 1
                Dim SaleItem As DataTable = executesql("select * from SaleItem where SaleId = '" & checkIsBills(a)("SaleId") & "'")
                For i As Integer = 0 To SaleItem.Rows.Count - 1
                    ItemId = SaleItem(i)("ItemId")
                    Qty = SaleItem(i)("Qty")
                    Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
                    If SaleItem(i)("BahtDC") = 0 Then
                        BahtDC = 0
                        PercentDC = SaleItem(i)("PercentDC")
                    ElseIf SaleItem(i)("PercentDC") = 0 Then
                        PercentDC = 0
                        BahtDC = SaleItem(i)("BahtDC")
                    End If
                    Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")
                    executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & SaleItem(i)("SaleItemId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & Qty & "','" & SaleItem(i)("InitPrice") & "','" & SaleItem(i)("UnitPrice") & "','" & SaleItem(i)("Total") & "','" & SaleItem(i)("SubTotal") & "','" & SaleItem(i)("Tax") & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
                Next
                executesql("update Sale set Active=0,UpdateDate='" & UpdateDate & "' where SaleId='" & checkIsBills(a)("SaleId") & "'")
                executesql("update SaleItem set Active=0,UpdateDate='" & UpdateDate & "' where SaleId='" & checkIsBills(a)("SaleId") & "'")
            Next
            executesql("update Tables set StateStatus= 0 where TableId='" & TableId & "'")
        End If
        'For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
        '    ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
        '    Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value
        '    Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")

        '    If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
        '        BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
        '        PercentDC = 0
        '    ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
        '        PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
        '        BahtDC = 0
        '    End If
        '    TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
        '    InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
        '    UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
        '    TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
        '    SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
        '    TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
        '    'Insert Cancel SaleItem
        '    Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")
        '    Clipboard.SetText("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & Qty & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
        '    executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & Qty & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "','" & TableId & "','" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")

        'Next

        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE TableId='" & TableId & "'")
        If IsDBNull(LoadDatatable(0)("IsGroupTable")) Then
        Else
            If LoadDatatable(0)("IsGroupTable") = 0 Then
            Else
                executesql("update Tables set StateStatus= 0,IsGroupTable = 0, IsSplitBill = 0 ,TableName2= NULL, TableId2 = NULL where TableId in(" & LoadDatatable(0)("TableId2") & ")")
            End If
        End If
        GetSaleId = 0
        POS.DiscountByItem2 = 0
        TB_GetSaleId = 0
        'customer
        FrmCustomerMemberNo.customerMemNo = 0

        POS.DataGridViewPOS.Rows.Clear()
        DisCount = 0
        totalDiscount = 0
        POS.txtDiscount.Text = "0.00"
        POS.txtTotal.Text = "0.00"
        POS.txtSubTotal.Text = "0.00"
        TB_DisCount = 0

        POS.Close()
        Table.Show()
    End Sub
    Sub ShowDialogTable()
        POS.Close()
        Table.Show()
    End Sub
End Module
