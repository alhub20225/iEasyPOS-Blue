Module ModulePosPromotion
    Sub checkPromotion()
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim TimeNows As String = Convert.ToDateTime(Now).ToString("HH:mm", New System.Globalization.CultureInfo("th-TH"))

        Dim checkPromotion As DataTable = executesql("Select  Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point,
        PromotionItem.ItemId
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
        WHERE ConditionPromotion.ConDateEnd >= '" & DateNows & "' AND Promotion.Active='1' AND PromotionItem.Active='1'")

        ''If checkPromotion.Rows.Count > 0 Then
        ''    If Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) > Convert.ToDateTime(checkPromotion(0)("ConDateStart") & " " & checkPromotion(0)("ConTimeStart")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) And Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) < Convert.ToDateTime(checkPromotion(0)("ConDateEnd") & " " & checkPromotion(0)("ConTimeEnd")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) Then
        ''        PosPromotion.PromotionId = checkPromotion(0)("ProId")
        ''        PosPromotion.GiftvalueId = checkPromotion(0)("GiftId")
        ''        PosPromotion.Show()
        ''        PosPromotion.TopMost = True
        ''    End If
        ''End If

        Dim checkcountPromotion As DataTable = executesql("Select  Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point,
        PromotionItem.ItemId
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
        WHERE ConditionPromotion.ConDateEnd >= '" & DateNows & "' AND Promotion.Active='1' AND PromotionItem.ItemId='" & ModulePOS.ItemId & "' AND PromotionItem.Active = '1'")

        If IsNothing(checkPromotion) Then
            Exit Sub
        ElseIf checkPromotion.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim CountItem As Integer = POS.DataGridViewPOS.RowCount
        Dim TotalPrice As Decimal
        If POS.DataGridViewPOS.RowCount > 0 Then
            Dim aleardy As Boolean = False
            For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
                If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Then
                Else
                    aleardy = True
                    Exit For
                End If
            Next
            If aleardy = False Then
                If checkcountPromotion.Rows.Count > 0 Then
                    Dim DateNows2 As DateTime = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
                    Dim DateStart As DateTime = Convert.ToDateTime(checkcountPromotion(0)("ConDateStart") & " " & checkcountPromotion(0)("ConTimeStart")).ToString("yyyy-MM-dd  HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
                    Dim DateEnd As DateTime = Convert.ToDateTime(checkcountPromotion(0)("ConDateEnd") & " " & checkcountPromotion(0)("ConTimeEnd")).ToString("yyyy-MM-dd  HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
                    Dim DateStart2 As DateTime
                    Dim DateEnd2 As DateTime

                    For a As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
                        For j As Integer = 0 To checkPromotion.Rows.Count - 1
                            DateStart2 = Convert.ToDateTime(checkPromotion(j)("ConDateStart") & " " & checkPromotion(j)("ConTimeStart")).ToString("yyyy-MM-dd  HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
                            DateEnd2 = Convert.ToDateTime(checkPromotion(j)("ConDateEnd") & " " & checkPromotion(j)("ConTimeEnd")).ToString("yyyy-MM-dd  HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
                            If (DateNows2 > DateStart And DateNows2 < DateEnd) And (DateNows2 > DateStart2 And DateNows2 < DateEnd2) Then
                                '(Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) >= Convert.ToDateTime(checkPromotion(j)("ConDateStart") & " " & checkPromotion(j)("ConTimeStart")).ToString("yyyy-MM-dd  HH:mm:ss", New System.Globalization.CultureInfo("en-US")) And Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) <= Convert.ToDateTime(checkPromotion(j)("ConDateEnd") & " " & checkPromotion(j)("ConTimeEnd")).ToString("yyyy-MM-dd  HH:mm:ss", New System.Globalization.CultureInfo("en-US")))
                                If Not IsDBNull(checkPromotion(j)("ConPrice")) Then 'Price
                                    If checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") = 0 Then
                                        'If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And checkPromotion(j)("AlertPrice") <= POS.DataGridViewPOS.Rows(a).Cells(3).Value And POS.DataGridViewPOS.Rows(a).Cells(3).Value < checkPromotion(j)("ConPrice") Then
                                        '    If POS.countAlert = False And POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
                                        '        MsgBox(checkPromotion(j)("ProName"), MsgBoxStyle.OkOnly)
                                        '        'POS.countAlert = True
                                        '    End If
                                        'End If
                                        If IsDBNull(checkPromotion(j)("Point")) Then
                                            If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                                                If checkcountPromotion.Rows.Count > 1 Then
                                                    Frm_PromotionList.Show()
                                                Else
                                                    PosPromotion.PromotionId = checkPromotion(j)("ProId")
                                                    PosPromotion.GiftvalueId = checkPromotion(j)("GiftId")
                                                    PosPromotion.Show()
                                                    PosPromotion.TopMost = True
                                                End If
                                            End If
                                        End If
                                    ElseIf checkPromotion(j)("DiscountPer") <> 0 And checkPromotion(j)("DiscountB") = 0 And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                                        'If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And checkPromotion(j)("AlertPrice") <= POS.DataGridViewPOS.Rows(a).Cells(3).Value And POS.DataGridViewPOS.Rows(a).Cells(3).Value < checkPromotion(j)("ConPrice") Then
                                        '    If POS.countAlert = False And POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
                                        '        MsgBox(checkPromotion(j)("ProName"), MsgBoxStyle.OkOnly)
                                        '        ' POS.countAlert = True
                                        '    End If
                                        'End If
                                        If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                                            If checkcountPromotion.Rows.Count > 1 Then
                                                Frm_PromotionList.Show()
                                            Else
                                                DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * FormatNumber(checkPromotion(j)("DiscountPer"), 2)) / 100
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                                                Pos_DiscountByItem.DiscountByItem_value = DisCount
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 1
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                                                Pos_DiscountByItem.per = 1
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = checkPromotion(j)("ProId")
                                                ModulePOS.calculatePrice()
                                            End If
                                        End If
                                    ElseIf checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") <> 0 And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                                        'If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And checkPromotion(j)("AlertPrice") <= POS.DataGridViewPOS.Rows(a).Cells(3).Value And POS.DataGridViewPOS.Rows(a).Cells(3).Value < checkPromotion(j)("ConPrice") Then
                                        '    If POS.countAlert = False And POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
                                        '        MsgBox(checkPromotion(j)("ProName"), MsgBoxStyle.OkOnly)
                                        '        ' POS.countAlert = True
                                        '    End If
                                        'End If
                                        If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                                            If checkcountPromotion.Rows.Count > 1 Then
                                                Frm_PromotionList.Show()
                                            Else
                                                DisCount = FormatNumber(checkPromotion(j)("DiscountB"), 2)
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 0
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                                                Pos_DiscountByItem.per = 0
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = checkPromotion(j)("ProId")
                                                ModulePOS.calculatePrice()
                                            End If
                                        End If
                                    End If
                                ElseIf Not IsDBNull(checkPromotion(j)("ConAmount")) Then 'Amount
                                    If checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") = 0 Then
                                        'If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And checkPromotion(j)("ConAmount") = POS.DataGridViewPOS.Rows(a).Cells(1).Value And POS.DataGridViewPOS.Rows(a).Cells(1).Value < checkPromotion(j)("ConAmount") Then
                                        '    If POS.countAlert = False And POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
                                        '        MsgBox(checkPromotion(j)("ProName"), MsgBoxStyle.OkOnly)
                                        '        'POS.countAlert = True
                                        '    End If
                                        'End If
                                        If IsDBNull(checkPromotion(j)("Point")) Then
                                            If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(1).Value >= checkPromotion(j)("ConAmount") Then
                                                If checkcountPromotion.Rows.Count > 1 Then
                                                    Frm_PromotionList.Show()
                                                Else
                                                    PosPromotion.PromotionId = checkPromotion(j)("ProId")
                                                    PosPromotion.GiftvalueId = checkPromotion(j)("GiftId")
                                                    PosPromotion.Show()
                                                    PosPromotion.TopMost = True
                                                End If
                                            End If
                                        End If
                                    ElseIf checkPromotion(j)("DiscountPer") <> 0 And checkPromotion(j)("DiscountB") = 0 Then
                                        'If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And checkPromotion(j)("ConAmount") = POS.DataGridViewPOS.Rows(a).Cells(1).Value And POS.DataGridViewPOS.Rows(a).Cells(1).Value < checkPromotion(j)("ConAmount") Then
                                        '    If POS.countAlert = False And POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
                                        '        MsgBox(checkPromotion(j)("ProName"), MsgBoxStyle.OkOnly)
                                        '        'POS.countAlert = True
                                        '    End If
                                        'End If
                                        If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(1).Value >= checkPromotion(j)("ConAmount") Then
                                            If checkcountPromotion.Rows.Count > 1 Then
                                                Frm_PromotionList.Show()
                                            Else
                                                DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * FormatNumber(checkPromotion(j)("DiscountPer"), 2)) / 100
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                                                Pos_DiscountByItem.DiscountByItem_value = DisCount
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 1
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                                                Pos_DiscountByItem.per = 1
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = checkPromotion(j)("ProId")
                                                ModulePOS.calculatePrice()
                                            End If
                                        End If
                                    ElseIf checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") <> 0 Then
                                        'If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And checkPromotion(j)("ConAmount") = POS.DataGridViewPOS.Rows(a).Cells(1).Value And POS.DataGridViewPOS.Rows(a).Cells(1).Value < checkPromotion(j)("ConAmount") Then
                                        '    If POS.countAlert = False And POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
                                        '        MsgBox(checkPromotion(j)("ProName"), MsgBoxStyle.OkOnly)
                                        '        'POS.countAlert = True
                                        '    End If
                                        'End If
                                        If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(1).Value >= checkPromotion(j)("ConAmount") Then
                                            If checkcountPromotion.Rows.Count > 1 Then
                                                Frm_PromotionList.Show()
                                            Else
                                                DisCount = FormatNumber(checkPromotion(j)("DiscountB"), 2)
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 0
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                                                Pos_DiscountByItem.per = 0
                                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = checkPromotion(j)("ProId")
                                                ModulePOS.calculatePrice()
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                        Next
                    Next
                End If
            End If
        End If
    End Sub
    Sub GetFree()
        'Clipboard.SetText("SELECT Getfree.*,Item.ItemCode,Item.ItemName,Item.ImageText,Item.ButtonColor,Item.FontColor FROM Getfree INNER JOIN Item ON(Item.ItemId = GetFree.ItemId) WHERE GetFree.GiftValueId='" & PosPromotion.GiftvalueId & "'")
        Dim GetFreeData As DataTable = executesql("SELECT Getfree.*,Item.ItemCode,Item.ItemName,Item.ImageText,Item.ButtonColor,Item.FontColor FROM Getfree INNER JOIN Item ON(Item.ItemId = GetFree.ItemId) WHERE GetFree.GiftValueId='" & PosPromotion.GiftvalueId & "'")
        Dim CategoryId As DataTable = executesql("select CategoryId from Item where ItemId='" & GetFreeData(0)("ItemId") & "'")
        LoadCategory(CategoryId(0)("CategoryId"))
        GetItem2(CategoryId(0)("CategoryId"), GetFreeData(0)("ItemId"))
        'Dim GetFreeData As DataTable = executesql("SELECT * FROM Item INNER JOIN CategoryItem ON(Item.CategoryId = CategoryItem.CategoryId) WHERE CategoryItem.CateGroupId='1' and Item.Active=1")

        ''PosPromotion.DataGridViewPromotionGetFree.Rows.Clear()
        'For i As Integer = 0 To GetFreeData.Rows.Count - 1
        '    'PosPromotion.DataGridViewPromotionGetFree.Rows.Add(GetFreeData(i)("ItemId"), GetFreeData(i)("ItemCode"), GetFreeData(i)("ItemName"), GetFreeData(i)("Discount"))
        '    Dim PromtionGiftItem As New Button
        '    PromtionGiftItem.Text = GetFreeData(i)("ItemName")
        '    PromtionGiftItem.Name = GetFreeData(i)("ItemId")
        '    PromtionGiftItem.FlatStyle = FlatStyle.Flat
        '    PromtionGiftItem.ForeColor = Color.FromArgb(GetFreeData(i)("FontColor"))
        '    PromtionGiftItem.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
        '    'If IsDBNull(GetFreeData(i)("ImageText")) Then
        '    '    PromtionGiftItem.BackColor = Color.FromArgb(GetFreeData(i)("ButtonColor"))
        '    'ElseIf GetFreeData(i)("ImageText") = "" Then
        '    PromtionGiftItem.BackColor = Color.FromArgb(GetFreeData(i)("ButtonColor"))
        '    'Else
        '    'Setup Image and get data Stream together
        '    'Dim img As System.Drawing.Image
        '    'Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
        '    'Dim b() As Byte
        '    ''Converts the base64 encoded msg to image Data
        '    'b = Convert.FromBase64String(GetFreeData(i)("ImageText"))
        '    'MS = New System.IO.MemoryStream(b)
        '    ''Create Image 
        '    'img = System.Drawing.Image.FromStream(MS)
        '    'PromtionGiftItem.BackgroundImage = img
        '    'PromtionGiftItem.BackgroundImageLayout = ImageLayout.Stretch
        '    'End If
        '    PromtionGiftItem.Width = 138
        '    PromtionGiftItem.Height = 140
        '    PosPromotion.PromotionGiftItem.Controls.Add(PromtionGiftItem)
        '    AddHandler PromtionGiftItem.Click, AddressOf getItem
        'Next
    End Sub
    Sub getItem(sender As Object, e As EventArgs)
        Dim ItemId As Integer = sender.Name
        Dim selectPrice As DataTable = executesql("SELECT ItemName,ItemPrice,ItemCode,ItemId FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
        ItemAmount = 1
        ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
        ItemPricePerUnit = selectPrice(0)("ItemPrice") 'FormatNumber(Discount, 2)
        POS.DataGridViewPOS.Rows.Add(selectPrice(0)("ItemName") & " #ฟรี ", ItemAmount, 0.00, 0.00, ItemId, 0, 0, 0, 0, 0, 0, PosPromotion.PromotionId, selectPrice(0)("ItemId"))
        POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).DefaultCellStyle.ForeColor = Color.Green
        PosPromotion.GiftvalueId = 0
        PosPromotion.Close()
    End Sub
    'Sub AddGetFreeToDataGridViewPos()
    '    Dim ItemId As Integer = PosPromotion.DataGridViewPromotionGetFree.CurrentRow.Cells(0).Value
    '    Dim Discount As Decimal = PosPromotion.DataGridViewPromotionGetFree.CurrentRow.Cells("GetFreeDiscount").Value
    '    Dim selectPrice As DataTable = executesql("SELECT ItemName,ItemPrice,ItemCode,ItemId FROM Item WHERE ItemId='" & ItemId & "' AND Active=1")
    '    ItemAmount = 1
    '    ItemPrice = ItemAmount * selectPrice(0)("ItemPrice")
    '    ItemPricePerUnit = selectPrice(0)("ItemPrice") 'FormatNumber(Discount, 2)
    '    POS.DataGridViewPOS.Rows.Add(selectPrice(0)("ItemName") & " *ฟรี ", ItemAmount, 0.00, 0.00, ItemId, 0, 0, 0, 0, 0, 0, PosPromotion.PromotionId, selectPrice(0)("ItemId"))
    '    POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).DefaultCellStyle.ForeColor = Color.Green
    '    PosPromotion.GiftvalueId = 0
    '    PosPromotion.Close()
    'End Sub
    Sub PromotionList()
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim checkcountPromotion As DataTable = executesql("Select  Promotion.ProId,Promotion.ProName,Promotion.ProCode,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,
        PromotionItem.ItemId
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
        WHERE ConditionPromotion.ConDateEnd >= '" & DateNows & "' AND Promotion.Active='1' AND PromotionItem.ItemId='" & ModulePOS.ItemId & "' AND PromotionItem.Active = '1'")
        Frm_PromotionList.DataGridViewPromotionList.Rows.Clear()
        For i As Integer = 0 To checkcountPromotion.Rows.Count - 1
            Frm_PromotionList.DataGridViewPromotionList.Rows.Add(checkcountPromotion(i)("ProId"), checkcountPromotion(i)("ProCode"), checkcountPromotion(i)("ProName"))
        Next
    End Sub
    Sub LoadCategory(CategoryId As Integer)
        'Select Category
        'Dim DataCategory As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
        Dim DataCategory As DataTable = executesql("SELECT CategoryId,CategoryName,CategoryName2,FontColor,BackGroundButton,ImageTextBase64 FROM CategoryItem WHERE CateGroupId=1 AND Active =1 AND CategoryId='" & CategoryId & "'")
        If IsNothing(DataCategory) Then
            Exit Sub
        ElseIf DataCategory.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim RowsDataCategory As Integer = DataCategory.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataCategory - 1
            Dim ButtonCategory2 As New Button
            ButtonCategory2.Text = DataCategory(i)("CategoryName")
            ButtonCategory2.Name = DataCategory(i)("CategoryId")
            ButtonCategory2.Font = My.Settings.ButtonFont
            If DataCategory(i)("ImageTextBase64") = "" Then
                ButtonCategory2.BackColor = Color.FromArgb(DataCategory(i)("BackGroundButton"))
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
                    ButtonCategory2.BackgroundImage = img
                    ButtonCategory2.BackgroundImageLayout = ImageLayout.Stretch
                End If
            End If
            ButtonCategory2.FlatStyle = FlatStyle.Flat
            ButtonCategory2.FlatAppearance.BorderSize = 0
            ButtonCategory2.Margin = New System.Windows.Forms.Padding(1)
            ButtonCategory2.ForeColor = Color.FromArgb(DataCategory(i)("FontColor"))
            ButtonCategory2.Width = My.Settings.ButtonCateSize.Width
            ButtonCategory2.Height = My.Settings.ButtonCateSize.Height
            PosPromotion.FlowLayoutPanel1.Controls.Add(ButtonCategory2)
            'AddHandler ButtonCategory2.Click, AddressOf GetItem2
        Next
        DisCount = 0
    End Sub
    Sub GetItem2(CateId As Integer, ItemId As Integer)
        POS.txtItemCode.Focus()
        POS.FlowLayoutPanelItems.Controls.Clear()
        'Select Items
        'Dim CateId As Integer = sender.Name
        'Dim CateName As String = sender.Text
        Dim DataItem As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ImageText,ButtonColor,FontColor,IsActive FROM Item WHERE CategoryId='" & CateId & "' and ItemId='" & ItemId & "' AND Active = 1")
        Dim RowsDataItem As Integer = DataItem.Rows.Count
        Dim i As Integer
        Dim StockNo As Boolean = True
        For i = 0 To RowsDataItem - 1
            Dim SelectReceipe As DataTable = executesql("SELECT Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & DataItem(i)("ItemId") & "'")
            Dim ButtonItem2 As New Button
            Dim L1 As New Label
            L1.AutoSize = False
            L1.BackColor = Color.White
            L1.BackColor = Color.FromArgb(100, Color.White)
            L1.ForeColor = Color.Black
            L1.Font = New System.Drawing.Font("supermarket Regular", 12.0, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            L1.TextAlign = ContentAlignment.MiddleCenter
            L1.Dock = DockStyle.Bottom
            L1.Height = 170 * 0.3
            If DataItem(i)("IsActive") = 1 Then
                ButtonItem2.Name = DataItem(i)("ItemId")
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
                ButtonItem2.Width = My.Settings.ButtonItemSize.Width
                ButtonItem2.Height = My.Settings.ButtonItemSize.Height
                ButtonItem2.Margin = New System.Windows.Forms.Padding(1)
                If StockNo = True Then
                    ButtonItem2.Text = DataItem(i)("ItemName")
                    ButtonItem2.FlatStyle = FlatStyle.Flat
                    ButtonItem2.FlatAppearance.BorderSize = 0
                    ButtonItem2.ForeColor = Color.Black
                    ButtonItem2.Font = My.Settings.ButtonFont
                    ButtonItem2.TextAlign = ContentAlignment.MiddleCenter
                    'If IsDBNull(DataItem(i)("ImageText")) Then
                    ButtonItem2.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                    'ElseIf DataItem(i)("ImageText") = "" Then
                    '    ButtonItem2.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
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
                    '    ButtonItem2.BackgroundImage = img
                    '    ButtonItem2.BackgroundImageLayout = ImageLayout.Stretch
                    'End If

                    'L1.Text = DataItem(i)("ItemName")
                    ''If IsDBNull(DataItem(i)("ImageText")) Then
                    'ButtonItem2.Font = New Font("supermarket Regular", 12.0, FontStyle.Regular)
                    '    ButtonItem2.ForeColor = Color.Black
                    '    ButtonItem2.TextAlign = ContentAlignment.MiddleCenter
                    ''Else
                    'ButtonItem2.Font = New Font("supermarket Regular", 0.1, FontStyle.Regular)
                    '    ButtonItem2.Controls.Add(L1)
                    ''End If

                    PosPromotion.PromotionGiftItem.Controls.Add(ButtonItem2)
                    AddHandler ButtonItem2.Click, AddressOf getItem
                ElseIf StockNo = False Then
                    ButtonItem2.Text = DataItem(i)("ItemName") & Environment.NewLine & "วัตถุดิบหมด"
                    ButtonItem2.FlatStyle = FlatStyle.Flat
                    ButtonItem2.FlatAppearance.BorderSize = 1
                    ButtonItem2.FlatAppearance.BorderColor = Color.Red
                    ButtonItem2.BackColor = Color.Red
                    ButtonItem2.Font = My.Settings.ButtonFont
                    'If IsDBNull(DataItem(i)("ImageText")) Then
                    ButtonItem2.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
                    'ElseIf DataItem(i)("ImageText") = "" Then
                    '    ButtonItem2.BackColor = Color.FromArgb(DataItem(i)("ButtonColor"))
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
                    '    ButtonItem2.BackgroundImage = img
                    '    ButtonItem2.BackgroundImageLayout = ImageLayout.Stretch
                    'End If
                    PosPromotion.PromotionGiftItem.Controls.Add(ButtonItem2)
                    AddHandler ButtonItem2.Click, AddressOf getItem
                End If
            End If
        Next
    End Sub
End Module
