Module ModulePOS
    Public ItemColumn As Integer = My.Settings.ItemColumn
    Sub LoadUser()
        Dim UserName As String = Frm_Login.UserName

    End Sub
    Sub LoadCategory()
        'Select Category
        POS.FlowLayoutPanelCategory.Controls.Clear()
        POS.FlowLayoutPanelItems.Controls.Clear()
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
            If Frm_Login.ComboLang.Text = "th-TH" Then
                ButtonCategory.Text = DataCategory(i)("CategoryName")
            Else
                ButtonCategory.Text = DataCategory(i)("CategoryName2")
            End If

            ButtonCategory.Name = DataCategory(i)("CategoryId")
            ButtonCategory.Font = My.Settings.ButtonFont
            'ButtonCategory.Font = New System.Drawing.Font("Kanit", 11, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            If SettingList.PosImge = 0 Then
                ButtonCategory.BackColor = Color.FromArgb(DataCategory(i)("BackGroundButton"))
            Else
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
            End If

            ButtonCategory.FlatStyle = FlatStyle.Flat
            ButtonCategory.FlatAppearance.BorderSize = 0
            ButtonCategory.Margin = New System.Windows.Forms.Padding(1)
            ButtonCategory.ForeColor = Color.FromArgb(DataCategory(i)("FontColor"))
            ButtonCategory.Width = (POS.FlowLayoutPanelCategory.Width / ItemColumn) - ItemColumn
            ButtonCategory.Height = My.Settings.ButtonCateSize.Height
            ButtonCategory.Cursor = Cursors.Hand
            'ButtonCategory.Height = (Math.Floor(POS.FlowLayoutPanelCategory.Height / 3))
            POS.FlowLayoutPanelCategory.Controls.Add(ButtonCategory)
            AddHandler ButtonCategory.Click, AddressOf GetItem_Perpage
            AddHandler ButtonCategory.Click, AddressOf ChangeBtnCateColor
        Next
        DisCount = 0
    End Sub
    Private OnClickBtnCate As Button = Nothing
    Sub ChangeBtnCateColor(Sender As Object, e As EventArgs)
        Dim SenderButton As Button = Sender
        If OnClickBtnCate IsNot Nothing Then
            OnClickBtnCate.FlatAppearance.BorderSize = 0
        End If
        If SenderButton IsNot OnClickBtnCate Then
            SenderButton.FlatAppearance.BorderSize = 2
            SenderButton.FlatAppearance.BorderColor = Color.Blue
        End If

        OnClickBtnCate = Sender
    End Sub
    Dim RowsDataItem As Integer = 0
    Dim CateId As Integer = 0
    Dim ButtonsL As New List(Of Button)
    Dim PageIndex As Integer = 0
    Dim BtnsPerPage As Integer = 0
    Dim ItemRow As Integer = 0

    Sub GetItem_Perpage(sender As Object, e As EventArgs)
        Console.WriteLine("ItemColumn " & ItemColumn)
        POS.TextBox3.Focus()
        POS.FlowLayoutPanelItems.Controls.Clear()
        ButtonsL.Clear()
        CateId = sender.Name
        ItemRow = Math.Floor(POS.FlowLayoutPanelItems.Height / My.Settings.ButtonItemSize.Height)
        BtnsPerPage = (ItemRow * ItemColumn)
        Dim DataItem As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ImageText,ButtonColor,FontColor,IsActive FROM Item WHERE CategoryId='" & CateId & "' AND Active = 1 AND IsActive=1 order by ItemName asc")
        For i As Integer = 0 To DataItem.Rows.Count - 1
            Dim ButtonItem As New Button
            ButtonItem.Height = My.Settings.ButtonItemSize.Height
            ButtonItem.Width = (POS.FlowLayoutPanelItems.Width / ItemColumn) - ItemColumn
            ButtonItem.Name = DataItem(i)("ItemId")
            If Frm_Login.ComboLang.Text = "th-TH" Then
                ButtonItem.Text = DataItem(i)("ItemName")
            Else
                ButtonItem.Text = DataItem(i)("ItemName2")
            End If
            ButtonItem.FlatStyle = FlatStyle.Flat
            ButtonItem.FlatAppearance.BorderSize = 0
            ButtonItem.Margin = New System.Windows.Forms.Padding(1)
            ButtonItem.ForeColor = Color.Black
            ButtonItem.Font = My.Settings.ButtonFont
            ButtonItem.TextAlign = ContentAlignment.MiddleCenter
            ButtonItem.Cursor = Cursors.Hand
            If SettingList.PosImge = 0 Then
                ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
            Else
                '******** Img  ************************************************************************************
                If IsDBNull(DataItem(i)("ImageText")) Then
                    ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                ElseIf DataItem(i)("ImageText") = "" Then
                    ButtonItem.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                Else
                    'Setup Image and get data Stream together
                    Dim img As System.Drawing.Image
                    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    Dim b() As Byte
                    'Converts the base64 encoded msg to image Data
                    b = Convert.FromBase64String(DataItem(i)("ImageText"))
                    MS = New System.IO.MemoryStream(b)
                    'Create Image 
                    img = System.Drawing.Image.FromStream(MS)
                    ButtonItem.BackgroundImage = img
                    ButtonItem.BackgroundImageLayout = ImageLayout.Stretch
                End If

                'Dim L1 As New Label
                'L1.Text = DataItem(i)("ItemName")
                'L1.Font = My.Settings.ButtonFont
                'L1.Dock = DockStyle.Bottom
                'L1.TextAlign = ContentAlignment.MiddleCenter
                'L1.BackColor = Color.FromArgb(80, Color.Black)
                'L1.ForeColor = Color.White
                'L1.AutoSize = False
                'If IsDBNull(DataItem(i)("ImageText")) Then
                '    ButtonItem.Font = My.Settings.ButtonFont
                '    ButtonItem.ForeColor = Color.Black
                '    ButtonItem.TextAlign = ContentAlignment.MiddleCenter
                'Else
                '    ButtonItem.Font = New Font("supermarket Regular", 0.1, FontStyle.Regular)
                '    ButtonItem.Controls.Add(L1)
                'End If

                '*************************************************************************************************
            End If
            ButtonsL.Add(ButtonItem)
            AddHandler ButtonItem.Click, AddressOf AddPOSItem

            If i < BtnsPerPage Then POS.FlowLayoutPanelItems.Controls.Add(ButtonItem)
            If BtnsPerPage > DataItem.Rows.Count Then
                POS.textPage.Text = ""
                POS.BtnNextPage.Visible = False
                POS.BtnBackPage.Visible = False
                POS.textPage.Visible = False
            Else
                POS.textPage.Text = "หน้า " & (PageIndex + 1).ToString
                POS.BtnNextPage.Visible = True
                POS.BtnBackPage.Visible = True
                POS.textPage.Visible = True
            End If
        Next

    End Sub

    Sub LoadPage(ByVal pgNext As Boolean)


        If pgNext And (PageIndex + 1) * BtnsPerPage <= ButtonsL.Count Then
            PageIndex += 1
        ElseIf Not pgNext And PageIndex - 1 >= 0 Then
            PageIndex -= 1
        Else
            Exit Sub
        End If


        For i As Integer = POS.FlowLayoutPanelItems.Controls.Count - 1 To 0 Step -1
            POS.FlowLayoutPanelItems.Controls.RemoveAt(i)
        Next


        Dim endpage As Integer = Math.Min(((PageIndex * BtnsPerPage) + BtnsPerPage) - 1, ButtonsL.Count - 1)


        For i As Integer = (PageIndex * BtnsPerPage) To endpage
            POS.FlowLayoutPanelItems.Controls.Add(ButtonsL(i))
        Next

        POS.textPage.Text = "หน้า " & (PageIndex + 1).ToString
    End Sub
    Sub GetItem(sender As Object, e As EventArgs)
        POS.TextBox3.Focus()
        POS.FlowLayoutPanelItems.Controls.Clear()
        'Select Items


        CateId = sender.Name
        Dim CateName As String = sender.Text
        Dim DataItem As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ImageText,ButtonColor,FontColor,IsActive FROM Item WHERE CategoryId='" & CateId & "' AND Active = 1 AND IsActive=1 order by ItemName asc")
        RowsDataItem = DataItem.Rows.Count
        Dim i As Integer
        Dim StockNo As Boolean = True

        ' Item Row count''

        ItemRow = Math.Floor(POS.FlowLayoutPanelItems.Height / My.Settings.ButtonItemSize.Height)


        Dim ItemToShow As Integer = 0

        If DataItem.Rows.Count > (ItemRow * ItemColumn) Then

            ItemToShow = ItemRow * ItemColumn
            POS.BtnNextPage.Visible = True
        Else
            ItemToShow = DataItem.Rows.Count

            POS.BtnNextPage.Visible = False
        End If
        ''''


        For i = 0 To ItemToShow - 1
            Dim SelectReceipe As DataTable = executesql("SELECT Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & DataItem(i)("ItemId") & "'")
            Dim ButtonItem As New Button

            ButtonItem.Height = My.Settings.ButtonItemSize.Height
            ButtonItem.Width = (POS.FlowLayoutPanelItems.Width / ItemColumn) - ItemColumn


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
                    AddHandler ButtonItem.Click, AddressOf AddPOSItem
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
                    AddHandler ButtonItem.Click, AddressOf AddPOSItem2
                End If
            End If
        Next

    End Sub
    Public ItemId As String
    Public ItemName As String
    Public ItemAmount As Decimal
    Public ItemPrice As Decimal
    Public ItemPricePerUnit As Decimal
    Public Total As Decimal
    Public DisCount As Decimal
    Public SubTotal As Decimal
    Public selectItemPosRow As Integer
    Sub AddPOSItem(sender As Object, e As EventArgs)
        POS.TextBox3.Focus()
        ItemId = sender.Name
        ItemName = sender.Text
        If POS.DataGridViewPOS.Rows.Count = 0 Then
            POS.DataGridViewPOS.Rows.Clear()

            'Dim selectPrice As DataTable = executesql("SELECT ItemPrice,ItemCode FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
            'ItemAmount = 1
            'ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            'ItemPricePerUnit = selectPrice(0)("ItemPrice")
            'POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            'POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            selectItemPosRow = Nothing
            selectItemPosRow = POS.DataGridViewPOS.Rows.Count
            checktopping = 0
            Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & ItemId & "'")
            If selectItemTopping.Rows.Count > 0 Then
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.7
                    plexi.Show()
                    ToppingList.StartPosition = FormStartPosition.CenterParent
                    ToppingList.ShowDialog(plexi)
                End Using
                CheckItem2()
            ElseIf selectItemTopping.Rows.Count = 0 Then
                Dim selectitem As DataTable = executesql("SELECT Selection.*,ItemSelection.* 
                FROM ItemSelection  
                INNER JOIN CategorySelection ON(CategorySelection.CategorySelectionId = ItemSelection.CateSelectionId)
                INNER JOIN Selection ON (Selection.CategorySelectionId = Selection.CategorySelectionId)  
                WHERE ItemSelection.Active=1 AND ItemSelection.ItemId='" & ItemId & "'")
                If selectitem.Rows.Count > 0 Then
                    Using plexi = New Form()
                        plexi.FormBorderStyle = FormBorderStyle.None
                        plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                        plexi.StartPosition = FormStartPosition.Manual
                        plexi.AutoScaleMode = AutoScaleMode.None
                        plexi.ShowInTaskbar = False
                        plexi.BackColor = Color.Black
                        plexi.Opacity = 0.7
                        plexi.Show()
                        ToppingList.StartPosition = FormStartPosition.CenterParent
                        ToppingList.ShowDialog(plexi)
                    End Using
                    CheckItem2()
                Else
                    CheckItem()
                End If
            End If
            POS.DataGridViewPOS.ClearSelection()
        ElseIf POS.DataGridViewPOS.Rows.Count > 0 Then
            checktopping = 0
            selectItemPosRow = Nothing
            selectItemPosRow = POS.DataGridViewPOS.Rows.Count
            Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & ItemId & "'")
            If selectItemTopping.Rows.Count > 0 Then
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.7
                    plexi.Show()
                    ToppingList.StartPosition = FormStartPosition.CenterParent
                    ToppingList.ShowDialog(plexi)
                End Using
                CheckItem2()
            ElseIf selectItemTopping.Rows.Count = 0 Then
                Dim selectitem As DataTable = executesql("SELECT Selection.*,ItemSelection.* 
                FROM ItemSelection  
                INNER JOIN CategorySelection ON(CategorySelection.CategorySelectionId = ItemSelection.CateSelectionId)
                INNER JOIN Selection ON (Selection.CategorySelectionId = Selection.CategorySelectionId)  
                WHERE ItemSelection.Active=1 AND ItemSelection.ItemId='" & ItemId & "'")
                If selectitem.Rows.Count > 0 Then
                    Using plexi = New Form()
                        plexi.FormBorderStyle = FormBorderStyle.None
                        plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                        plexi.StartPosition = FormStartPosition.Manual
                        plexi.AutoScaleMode = AutoScaleMode.None
                        plexi.ShowInTaskbar = False
                        plexi.BackColor = Color.Black
                        plexi.Opacity = 0.7
                        plexi.Show()
                        ToppingList.StartPosition = FormStartPosition.CenterParent
                        ToppingList.ShowDialog(plexi)
                    End Using
                    CheckItem2()
                Else
                    CheckItem()
                End If
            End If
        End If
        'calculatePrice()
        'ModulePosPromotion.checkPromotion()
    End Sub
    Sub AddPOSItem2(sender As Object, e As EventArgs)
        POS.TextBox3.Focus()
        If MsgBox("ต้องการดำเนินการขายต่อหรือไม่", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            ItemId = sender.Name
            ItemName = Mid(sender.Text, 1, 10)
            If POS.DataGridViewPOS.Rows.Count = 0 Then
                POS.DataGridViewPOS.Rows.Clear()

                'Dim selectPrice As DataTable = executesql("SELECT ItemPrice,ItemCode FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
                'ItemAmount = 1
                'ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
                'ItemPricePerUnit = selectPrice(0)("ItemPrice")
                'POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
                'POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                selectItemPosRow = Nothing
                selectItemPosRow = POS.DataGridViewPOS.Rows.Count
                checktopping = 0
                Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & ItemId & "'")
                If selectItemTopping.Rows.Count > 0 Then
                    Using plexi = New Form()
                        plexi.FormBorderStyle = FormBorderStyle.None
                        plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                        plexi.StartPosition = FormStartPosition.Manual
                        plexi.AutoScaleMode = AutoScaleMode.None
                        plexi.ShowInTaskbar = False
                        plexi.BackColor = Color.Black
                        plexi.Opacity = 0.7
                        plexi.Show()
                        ToppingList.StartPosition = FormStartPosition.CenterParent
                        ToppingList.ShowDialog(plexi)
                    End Using
                    CheckItem2()
                ElseIf selectItemTopping.Rows.Count = 0 Then
                    CheckItem()
                End If
                POS.DataGridViewPOS.ClearSelection()
            ElseIf POS.DataGridViewPOS.Rows.Count > 0 Then
                checktopping = 0
                selectItemPosRow = Nothing
                selectItemPosRow = POS.DataGridViewPOS.Rows.Count
                Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & ItemId & "'")
                If selectItemTopping.Rows.Count > 0 Then
                    Using plexi = New Form()
                        plexi.FormBorderStyle = FormBorderStyle.None
                        plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                        plexi.StartPosition = FormStartPosition.Manual
                        plexi.AutoScaleMode = AutoScaleMode.None
                        plexi.ShowInTaskbar = False
                        plexi.BackColor = Color.Black
                        plexi.Opacity = 0.7
                        plexi.Show()
                        ToppingList.StartPosition = FormStartPosition.CenterParent
                        ToppingList.ShowDialog(plexi)
                    End Using
                    CheckItem2()
                ElseIf selectItemTopping.Rows.Count = 0 Then
                    CheckItem()
                End If

            End If
            'calculatePrice()
            'ModulePosPromotion.checkPromotion()
        End If
    End Sub
    Sub CheckItem()
        Console.WriteLine("ModulePOS CheckItem")
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pos Add itemID: " + ItemId.ToString)
        Dim checkExists As Boolean = False
        Dim ToppingPrice As Decimal = 0
        'Clipboard.SetText("SELECT ItemId,ItemPrice FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
        Dim selectPrice As DataTable = executesql("SELECT ItemName,ItemId,ItemPrice,PosPriceMod FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
        Dim a As Integer
        For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    Exit For
            'End If
            If ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value IsNot Nothing Then
                checkExists = True
                Console.WriteLine("SaleItemId " & POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value.ToString)
                Console.WriteLine("checkExists = True")
                a = i
                Exit For
            End If
        Next
        ItemName = selectPrice(0)("ItemName")

        If checkExists = True Then

            If selectPrice(0)("PosPriceMod") = 1 Then
                Console.WriteLine("selectPrice PosPriceMod  = 1")
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(Pos_PriceMod.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.6
                    plexi.Show()
                    Pos_PriceMod.StartPosition = FormStartPosition.CenterParent
                    Pos_PriceMod.ShowDialog(plexi)
                End Using
                ItemAmount = 1
                If Pos_PriceMod.txtPriceAmount.Text = "" Then Exit Sub
                ItemPrice = ItemAmount * Pos_PriceMod.txtPriceAmount.Text
                ItemPricePerUnit = Pos_PriceMod.txtPriceAmount.Text
                ItemName = Pos_PriceMod.TextDescrip.Text
                POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            Else
                Console.WriteLine("selectPrice PosPriceMod  = 0")
                ItemAmount = 1 'CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
                ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")

                If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
                    ItemPrice = (POS.DataGridViewPOS.Rows(a).Cells(3).Value / POS.DataGridViewPOS.Rows(a).Cells(1).Value) * ItemAmount
                End If

                'POS.DataGridViewPOS.Rows(a).Cells(1).Value = ItemAmount
                'POS.DataGridViewPOS.Rows(a).Cells(3).Value = FormatNumber(ItemPrice, 2)
                POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            End If

            POS.DataGridViewPOS.ClearSelection()
        Else
            Console.WriteLine("checkExists = false")
            ItemAmount = 1
            If selectPrice(0)("PosPriceMod") = 1 Then
                Console.WriteLine("selectPrice PosPriceMod  = 1")
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(Pos_PriceMod.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.6
                    plexi.Show()
                    Pos_PriceMod.StartPosition = FormStartPosition.CenterParent
                    Pos_PriceMod.ShowDialog(plexi)
                End Using
                If Pos_PriceMod.txtPriceAmount.Text = "" Then Exit Sub
                ItemPrice = ItemAmount * Pos_PriceMod.txtPriceAmount.Text
                ItemPricePerUnit = Pos_PriceMod.txtPriceAmount.Text
                ItemName = Pos_PriceMod.TextDescrip.Text
            Else
                Console.WriteLine("selectPrice PosPriceMod  = 0")
                ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
                ItemPricePerUnit = selectPrice(0)("ItemPrice")
            End If

            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        End If
        'ItemId = 0
        calculatePrice()
        ModulePosPromotion.checkPromotion()
    End Sub
    Public checktopping As Integer = 0
    Sub CheckItem2()
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pos Add itemID: " + ItemId.ToString)
        Dim checkExists As Boolean = False
        Dim ToppingPrice As Decimal = 0
        Dim selectPrice As DataTable = executesql("SELECT ItemId,ItemPrice FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
        Dim a As Integer
        For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    Exit For
            'End If
            If ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value Then
                checkExists = True
                a = i
                Exit For
            End If
        Next
        If checkExists = True And checktopping = 2 Then
            ItemAmount = CDbl(POS.DataGridViewPOS.Rows(ToppingList.aa).Cells(1).Value + 1)
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            If POS.DataGridViewPOS.Rows(ToppingList.aa).Cells("Topping").Value = 1 Then
                ItemPrice = (POS.DataGridViewPOS.Rows(ToppingList.aa).Cells(3).Value / POS.DataGridViewPOS.Rows(ToppingList.aa).Cells(1).Value) * ItemAmount
            End If
            POS.DataGridViewPOS.Rows(ToppingList.aa).Cells(1).Value = ItemAmount
            POS.DataGridViewPOS.Rows(ToppingList.aa).Cells(3).Value = FormatNumber(ItemPrice, 2)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = True And checktopping = 3 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = True And checktopping = 1 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
            ToppingList.addToPos()
            'ElseIf checkExists = True And checktopping = 0 Then
            '    ItemAmount = CDbl(POS.DataGridViewPOS.Rows(a).Cells(1).Value + 1)
            '    ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            '    If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
            '        ToppingPrice = (POS.DataGridViewPOS.Rows(a).Cells(3).Value - POS.DataGridViewPOS.Rows(a).Cells(2).Value) * ItemAmount
            '    End If
            '    POS.DataGridViewPOS.Rows(a).Cells(1).Value = ItemAmount
            '    POS.DataGridViewPOS.Rows(a).Cells(3).Value = FormatNumber(ItemPrice + ToppingPrice, 2)
            '    POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = False And checktopping = 2 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = False And checktopping = 3 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
        ElseIf checkExists = False And checktopping = 1 Then
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            POS.DataGridViewPOS.ClearSelection()
            ToppingList.addToPos()
            'ElseIf checkExists = False And checktopping = 0 Then
            '    ItemAmount = 1
            '    ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            '    ItemPricePerUnit = selectPrice(0)("ItemPrice")
            '    POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemId, 0.00)
            '    POS.DataGridViewPOS.ClearSelection()
        End If
        ItemId = 0
        checktopping = 0
        calculatePrice()
        ModulePosPromotion.checkPromotion()
    End Sub
    Dim totalDiscount As Decimal
    Sub calculatePrice()
        Total = 0
        totalDiscount = POS.txtDiscount.Text
        For j As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            Total += POS.DataGridViewPOS.Rows(j).Cells(3).Value
            'totalDiscount += POS.DataGridViewPOS.Rows(j).Cells(5).Value
        Next
        'DisCount = 0
        If Type = 0 Then
            DisCount = FormatNumber(totalDiscount, 2)
            POS.txtDiscount.Text = FormatNumber(DisCount, 2)
        Else
            DisCount = FormatNumber(DisCount, 2)
            POS.txtDiscount.Text = FormatNumber(DisCount, 2)
        End If
        SubTotal = Total - DisCount
        POS.txtTotal.Text = FormatNumber(Total, 2)
        POS.txtSubTotal.Text = FormatNumber(Math.Round(SubTotal), 2)
    End Sub
    Sub AddAmount()
        Dim ToppingPrice As Decimal = 0
        If ItemId Is Nothing Then
            MsgBox("กรุณาเลือกรายการ", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            If POS.DataGridViewPOS.CurrentRow.Cells("ItemId").Value IsNot Nothing Then
                ItemId = POS.DataGridViewPOS.CurrentRow.Cells("ItemId").Value
            End If
            'Dim message, title As String
            Dim defaultValue As Decimal
            Dim myValue As Object
            'message = "จำนวน"
            'title = "จำนวน"
            defaultValue = 1
            myValue = Pos_AddAmount.Amount
            If myValue Is "" Then myValue = defaultValue

            Dim selectPrice As DataTable = executesql("SELECT ItemId,ItemPrice FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            'InitPrice = FormatNumber((POS.DataGridViewPOS.Rows(i).Cells(2).Value - TaxItem), 2)
            'UnitPrice = FormatNumber(POS.DataGridViewPOS.Rows(i).Cells(2).Value, 2)
            ItemAmount = CDbl(myValue)
            ItemPrice = ItemAmount * POS.DataGridViewPOS.CurrentRow.Cells(2).Value
            If POS.DataGridViewPOS.CurrentRow.Cells("Topping").Value = 1 Then
                ItemPrice = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value / POS.DataGridViewPOS.CurrentRow.Cells(1).Value) * ItemAmount
            End If
            POS.DataGridViewPOS.CurrentRow.Cells(1).Value = ItemAmount
            POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber(ItemPrice, 2)

            'Next
            calculatePrice()
            ModulePosPromotion.checkPromotion()
            Pos_AddAmount.Amount = 0
        End If
        ItemId = 0
    End Sub
    Public Type As Integer
    Public Property SystemColor As Object

    Sub AddDiscountPercent()
        'Dim message, title As String
        'Dim defaultValue As Decimal
        'Dim myValue As Object
        'message = "ส่วนลด %"
        'title = "ส่วนลด %"
        'defaultValue = 0.00
        'myValue = InputBox(message, title, defaultValue)
        'If myValue Is "" Then myValue = defaultValue
        DisCount = 0
        DisCount = (POS.txtTotal.Text * Pos_DiscountPercent.DiscPer) / 100
        Type = 1
        calculatePrice()
    End Sub
    Sub AddDiscount()
        'Dim message, title As String
        'Dim defaultValue As Decimal
        'Dim myValue As Object
        'message = "ส่วนลด"
        'title = "ส่วนลด"
        'defaultValue = 0.00
        'myValue = InputBox(message, title, defaultValue)
        'If myValue Is "" Then myValue = defaultValue
        DisCount = Pos_Discount.Discount_value
        POS.DataGridViewPOS.CurrentRow.Cells("AllowDC").Value = 1
        Type = 1
        calculatePrice()
    End Sub
    Sub AddDiscountByItem()
        Dim TotalDisCount As Decimal = POS.txtDiscount.Text
        Dim AmountDiscount As Decimal = Pos_DiscountByItem.DiscountByItem_value
        If Pos_DiscountByItem.ToggleSwitch.Value = False Then
            DisCount = AmountDiscount
            POS.DataGridViewPOS.CurrentRow.Cells(5).Value = AmountDiscount
            POS.DataGridViewPOS.CurrentRow.Cells("discountType").Value = 0
            POS.DataGridViewPOS.CurrentRow.Cells("AllowDC").Value = 1
            Pos_DiscountByItem.per = 0
        ElseIf Pos_DiscountByItem.ToggleSwitch.Value = True Then
            DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * AmountDiscount) / 100
            POS.DataGridViewPOS.CurrentRow.Cells(5).Value = DisCount
            Pos_DiscountByItem.DiscountByItem_value = DisCount
            POS.DataGridViewPOS.CurrentRow.Cells("discountType").Value = 1
            POS.DataGridViewPOS.CurrentRow.Cells("AllowDC").Value = 1
            Pos_DiscountByItem.per = 1
        End If

        For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
            POS.DataGridViewPOS.Rows(i).Cells("AllowDC").Value = 1
        Next
        Type = 0
        calculatePrice()
    End Sub
    Sub DelItem()
        If POS.DataGridViewPOS.SelectedRows.Count = 0 Then
            MsgBox("กรุณาเลือกรายการ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        If POS.DataGridViewPOS.CurrentRow.Cells(5).Value = 0 Then
            DisCount = 0
        Else
            DisCount = POS.txtDiscount.Text - POS.DataGridViewPOS.CurrentRow.Cells(5).Value
        End If
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
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
        'For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
        Dim selectSaleItem As DataTable = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
                                                        SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
                                                        SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
                                                        SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
                                                        CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
                                                        CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
                                                        CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate
                                                        FROM Sale 
                                                        INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
                                                        INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
                                                        INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
                                                        WHERE Sale.SaleId='" & GetSaleId & "' and SaleItem.Active=3
                                                        GROUP BY Sale.SaleId,Sale.SubTotal,
                                                        Sale.Total,SaleItem.SaleItemId,
                                                        SaleItem.ItemId,SaleItem.ItemName,
                                                        SaleItem.Total,SaleItem.BahtDC,
                                                        SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
                                                        SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),
                                                        SaleTable.SaleName,
                                                        CONVERT(date,SaleTable.InsertDate ,101),
                                                        CONVERT(date,SaleTable.UpdateDate ,101)")
        If selectSaleItem.Rows.Count > 0 Then
            For i As Integer = 0 To selectSaleItem.Rows.Count - 1
                ItemId = POS.DataGridViewPOS.CurrentRow.Cells("ItemId").Value
                Qty = POS.DataGridViewPOS.CurrentRow.Cells(1).Value
                If selectSaleItem(i)("ItemId") = ItemId Then
                    Dim selectdataitem As DataTable = executesql("select item.itemid,item.itemcode,item.itemname,item.categoryid,item.istrackstock,tax.multiply,item.itemprice from item inner join tax on (tax.taxid = item.taxid) where item.itemid='" & ItemId & "'")

                    If POS.DataGridViewPOS.CurrentRow.Cells("discounttype").Value = 0 Then
                        BahtDC = POS.DataGridViewPOS.CurrentRow.Cells("ส่วนลด").Value
                        PercentDC = 0
                    ElseIf POS.DataGridViewPOS.CurrentRow.Cells("discounttype").Value = 1 Then
                        PercentDC = POS.DataGridViewPOS.CurrentRow.Cells("ส่วนลด").Value
                        BahtDC = 0
                    End If
                    TaxItem = selectdataitem(0)("itemprice") - (selectdataitem(0)("itemprice") * 100 / (selectdataitem(0)("multiply") + 100))
                    InitPrice = FormatNumber((selectdataitem(0)("itemprice") - TaxItem), 2)
                    UnitPrice = FormatNumber(selectdataitem(0)("itemprice"), 2)
                    TotalItem = POS.DataGridViewPOS.CurrentRow.Cells(2).Value * Qty
                    SubTotalItem = (((POS.DataGridViewPOS.CurrentRow.Cells(2).Value * Qty)) - PercentDC) - BahtDC  'formatnumber(initprice * qty, 2)
                    TaxAmount = ((((selectdataitem(0)("itemprice") * Qty))) - ((((selectdataitem(0)("itemprice") * Qty))) * 100 / (selectdataitem(0)("multiply") + 100)))

                    'insert cancel saleitem
                    Dim printername As DataTable = executesql("select cateprintername from categoryitem where categoryid='" & selectdataitem(0)("categoryid") & "'")
                    executesql("insert into cancelsaleitem(saleitemid,itemcode,itemname,qty,initprice,unitprice,total,subtotal,tax,tableid,terminalname,allowprint,printername,statusprint,active) values('" & selectSaleItem(i)("SaleItemId") & "','" & selectdataitem(0)("itemcode") & "','" & selectdataitem(0)("itemname") & "','" & Qty & "','" & InitPrice & "','" & UnitPrice & "','" & TotalItem & "','" & SubTotalItem & "','" & TaxAmount & "',0,'" & Environment.MachineName & "',1,'" & printername(0)("cateprintername") & "',0,1)")

                    executesql("UPDATE SaleItem Set Active = 0 ,UpdateDate = '" & UpdateDate & "' where SaleItemId='" & selectSaleItem(i)("SaleItemId") & "'")
                    executesql("update Sale set SubTotal='" & TB_subtotal & "',Total='" & TB_total & "',TaxAmt = '" & TaxAmt & "' where SaleId = '" & GetSaleId & "'")
                End If
            Next
        End If

        POS.DataGridViewPOS.Rows.RemoveAt(POS.DataGridViewPOS.CurrentCell.RowIndex)
        ToppingList.SelectionId = 0
        ToppingList.SelectionName = ""
        ToppingList.typeToppingId = 0
        calculatePrice()
    End Sub
    Sub ClearPos()
        POS.DataGridViewPOS.Rows.Clear()
        DisCount = 0
        totalDiscount = 0
        POS.txtDiscount.Text = "0.00"
        POS.txtTotal.Text = "0.00"
        POS.txtSubTotal.Text = "0.00"
        calculatePrice()
        ToppingList.SelectionId = 0
        ToppingList.SelectionName = ""
        ToppingList.typeToppingId = 0

        'customer

        FrmCustomerMemberNo.customerMemNo = 0
        FrmCustomerMemberNo.CustomerId = 0

    End Sub
    Sub CancelBill()
        'If MsgBox("ต้องการยกเลิกการขายหรือไม่?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
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

        Dim selectSaleItem As DataTable = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
                                                    SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
                                                    SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
                                                    SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
                                                    CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
                                                    CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
                                                    CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,SaleItem.Tax
                                                    FROM Sale 
                                                    INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
                                                    INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
                                                    INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
                                                    WHERE Sale.SaleId='" & GetSaleId & "' and SaleItem.Active=3
                                                    GROUP BY Sale.SaleId,Sale.SubTotal,
                                                    Sale.Total,SaleItem.SaleItemId,
                                                    SaleItem.ItemId,SaleItem.ItemName,
                                                    SaleItem.Total,SaleItem.BahtDC,
                                                    SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
                                                    SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),
                                                    SaleTable.SaleName,
                                                    CONVERT(date,SaleTable.InsertDate ,101),
                                                    CONVERT(date,SaleTable.UpdateDate ,101),SaleItem.Tax")

        For i As Integer = 0 To selectSaleItem.Rows.Count - 1
            ItemId = selectSaleItem(i)("ItemId")
            Qty = selectSaleItem(i)("Qty")
            Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
            'Insert Cancel SaleItem
            Dim printerName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")
            executesql("insert into CancelSaleItem(SaleItemId,ItemCode,ItemName,Qty,InitPrice,UnitPrice,Total,SubTotal,Tax,TableId,TerminalName,AllowPrint,PrinterName,StatusPrint,Active) values('" & selectSaleItem(i)("SaleItemId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & Qty & "','" & selectSaleItem(i)("InitPrice") & "','" & selectSaleItem(i)("UnitPrice") & "','" & selectSaleItem(i)("SaleItem_Total") & "','" & selectSaleItem(i)("SaleItem_SubTotal") & "','" & selectSaleItem(i)("Tax") & "',0,'" & Environment.MachineName & "',1,'" & printerName(0)("CatePrinterName") & "',0,1)")
        Next

        executesql("update Sale set Active=0,UpdateDate='" & UpdateDate & "' where SaleId='" & GetSaleId & "'")
        executesql("update SaleItem set Active=0,UpdateDate='" & UpdateDate & "' where SaleId='" & GetSaleId & "'")
        'executesql("update Tables set StateStatus= 0 where TableId='" & TableId & "'")


        executesql("UPDATE Sale SET Active=0,UpdateDate='" & UpdateDate & "',EndTime='" & UpdateDate & "' WHERE SaleId='" & GetSaleId & "'")

        executesql("UPDATE SaleTable SET Active=0,UpdateDate='" & UpdateDate & "',CurrentUserUsed='" & Frm_Login.UserId & "' WHERE SaleId='" & GetSaleId & "'")
        ' If TableId > 0 Then
        executesql("UPDATE Tables SET StateStatus=0 WHERE TableId='" & TableId & "'")
        'End If
        POS.DataGridViewPOS.Rows.Clear()
        DisCount = 0
        totalDiscount = 0
        POS.txtDiscount.Text = "0.00"
        POS.txtTotal.Text = "0.00"
        POS.txtSubTotal.Text = "0.00"
        calculatePrice()
        'End If
    End Sub
    Sub AddItemFromBarCode(ItemIds As String)
        ItemId = ItemIds
        If POS.DataGridViewPOS.Rows.Count = 0 Then
            Dim selectPrice As DataTable = executesql("SELECT * FROM Item WHERE ItemId='" & ItemIds & "' AND Active=1")
            ItemAmount = 1
            'MsgBox(selectPrice(0)("ItemName"))
            ItemName = selectPrice(0)("ItemName")
            ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
            ItemPricePerUnit = selectPrice(0)("ItemPrice")
            POS.DataGridViewPOS.Rows.Add(ItemName, ItemAmount, FormatNumber(ItemPricePerUnit, 2), FormatNumber(ItemPrice, 2), ItemIds, 0.00)
            POS.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            POS.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            POS.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            POS.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            POS.DataGridViewPOS.ClearSelection()
        ElseIf POS.DataGridViewPOS.Rows.Count > 0 Then
            ItemId = ItemIds
            CheckItem()
        End If
        calculatePrice()
        ModulePosPromotion.checkPromotion()
    End Sub

    Sub updatePrice(saleID As Integer, saleItemID As Integer, newPricr As Decimal, SubTotal As Decimal, Total As Decimal, unitprice As Decimal)
        executesql("UPDATE SaleItem Set  Subtotal = " & newPricr & ",Total=" & newPricr & ",UnitPrice=" & unitprice & " where SaleItemId=" & saleItemID & "")
        executesql("update Sale set SubTotal='" & SubTotal & "',Total='" & Total & "' where SaleId = " & saleID & "")
    End Sub
End Module
