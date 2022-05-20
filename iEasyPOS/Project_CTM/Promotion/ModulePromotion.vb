Module ModulePromotion
    Sub AutoCompeleteSearchItem()
        Promotion.txtSearchGetItem.AutoCompleteMode = AutoCompleteMode.Suggest
        Promotion.txtSearchGetItem.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionId As New AutoCompleteStringCollection()
        getDataItemId(DataCollectionId)
        Promotion.txtSearchGetItem.AutoCompleteCustomSource = DataCollectionId
    End Sub
    Private Sub getDataItemId(ByVal dataCollectionId As AutoCompleteStringCollection)
        'Create the list to use as the custom source
        Dim MySource As New AutoCompleteStringCollection()
        Dim DataItemSearchId As DataTable = executesql("SELECT ItemCode,ItemName FROM Item WHERE Active=1")
        Dim RowsDataItemSearch As Integer = DataItemSearchId.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim ItemCode As String = DataItemSearchId(i)("ItemName")
            Dim Itemname As String = DataItemSearchId(i)("ItemName")
            dataCollectionId.Add(Itemname)
        Next
    End Sub
    Sub AddToDataGridViewGetFree()
        If Promotion.txtSearchGetItem.Text = "" Then
            Exit Sub
        End If
        If Promotion.NumGetItemDiscount.Value = 0 Then
            Exit Sub
        End If
        Dim Discount As String = Promotion.NumGetItemDiscount.Value
        Dim ItemName As String = Promotion.txtSearchGetItem.Text
        If Promotion.DataGridViewGetFree.RowCount > 0 Then
            For i As Integer = 0 To Promotion.DataGridViewGetFree.RowCount - 1
                Dim selectDataItem As DataTable = executesql("SELECT ItemId,ItemName FROM Item WHERE ItemName='" & Promotion.DataGridViewGetFree.Rows(i).Cells(0).Value & "' AND Active=1")
                If IsNothing(selectDataItem) Then
                    Promotion.DataGridViewGetFree.Rows.Add(selectDataItem(0)("ItemName"), Discount, selectDataItem(0)("ItemId"))
                End If
            Next
        Else
            Dim selectDataItem As DataTable = executesql("SELECT ItemId,ItemName FROM Item WHERE ItemName='" & ItemName & "' AND Active=1")
            Promotion.DataGridViewGetFree.Rows.Add(selectDataItem(0)("ItemName"), Discount, selectDataItem(0)("ItemId"))
        End If
        clearDataGetFree()
    End Sub
    Sub clearDataGetFree()
        Promotion.NumGetItemDiscount.Value = 0
        Promotion.txtSearchGetItem.Clear()
    End Sub
    Sub btnAddPromotion()
        Dim ConQty As Decimal
        Dim ConPrice As Decimal
        Dim ConAlertQty As Decimal
        'Dim ConPrice As Decimal
        'Dim ConAlertPrice As Decimal
        Dim DateStart As String
        Dim DateEnd As String
        Dim TimeStart As String
        Dim TimeEnd As String

        'Gift
        Dim GiftDiscount As Decimal = 0
        Dim ProName As String = Promotion.txtProName.Text
        Dim ProCode As String = Promotion.txtProCode.Text

        'checkProCode
        Dim checkProCode As DataTable = executesql("SELECT ProCode FROM Promotion WHERE ProCode='" & ProCode & "'")
        If checkProCode.Rows.Count > 0 Then
            MsgBox("รหัสโปรโมชั่นซ้ำ !!", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If

        If ProName = "" Then
            MsgBox("กรุณากรอกชื่อโปรโมชั่น", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ProCode = "" Then
            MsgBox("กรุณากรอกรหัสโปรโมชั่น", MsgBoxStyle.Critical)
            Exit Sub
        End If

        DateStart = Convert.ToDateTime(Promotion.DateStart.Text).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        DateEnd = Convert.ToDateTime(Promotion.DateEnd.Text).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        TimeStart = Promotion.TimeStart.Text
        TimeEnd = Promotion.TimeEnd.Text

        If DateStart = "" Then
            MsgBox("กรุณาระบุวันที่เริ่มโปรโมชั่น", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf DateEnd = "" Then
            MsgBox("กรุณาระบุวันที่สิ้นสุดโปรโมชั่น", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf TimeStart = "" Then
            MsgBox("กรุณาระบุเวลาที่เริ่มโปรโมชั่น", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf TimeEnd = "" Then
            MsgBox("กรุณาระบุเวลาที่สิ้นสุดโปรโมชั่น", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Promotion.GiftFree = 1 Then
            If Promotion.DataGridViewGetFree.RowCount = 0 Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ")
                Exit Sub
            End If
            executesql("INSERT INTO GiftValue(GiftName,DiscountPer,DiscountB) VALUES('" & ProName & "','0','0')")
            Dim GiftValueData As DataTable = executesql("SELECT Max(GiftId) AS GiftId FROM GiftValue") 'Select GiftId
            'insert GetFree 
            For i As Integer = 0 To Promotion.DataGridViewGetFree.RowCount - 1
                executesql("INSERT INTO GetFree(GiftValueId,ItemId,Discount) VALUES('" & GiftValueData(0)("GiftId") & "','" & Promotion.DataGridViewGetFree.Rows(i).Cells("ItemId").Value & "','" & Promotion.DataGridViewGetFree.Rows(i).Cells("Discount").Value & "')")
            Next
        ElseIf Promotion.GiftFree = 2 Then
            If Promotion.ChkB.Checked = True Then
                GiftDiscount = Promotion.NumDiscountB.Text
                'insert Gift
                executesql("INSERT INTO GiftValue(GiftName,DiscountB,DiscountPer) VALUES('" & ProName & "','" & GiftDiscount & "','0')")
                'MsgBox(1)
            Else
                GiftDiscount = Promotion.NumDiscountPer.Value
                'insert Gift
                executesql("INSERT INTO GiftValue(GiftName,DiscountPer,DiscountB) VALUES('" & ProName & "','" & GiftDiscount & "','0')")
                'MsgBox(2)
            End If
        ElseIf Promotion.GiftFree = 3 Then
            If Promotion.txtProPoint.Text = "" Then
                MsgBox("กรุณากรอกแต้มสะสม", MsgBoxStyle.Critical)
                Promotion.txtProPoint.Focus()
                Exit Sub
            End If
            executesql("INSERT INTO GiftValue(GiftName,DiscountB,DiscountPer,Point) VALUES('" & ProName & "','0','0','" & Promotion.txtProPoint.Text & "')")
        End If
        Dim GiftId As DataTable = executesql("SELECT Max(GiftId) AS GiftId FROM GiftValue") 'Select GiftId
        'Insert ConditionPromotion
        If Promotion.Condition = 1 Then
            ConQty = Promotion.NumericUpDownCon.Value
            ConAlertQty = Promotion.NumAlertQty.Value
            If ConQty = 0 Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            'If ConAlertQty = 0 Then
            '    MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If
            'จำนวน
            executesql("INSERT INTO ConditionPromotion(ConPrice,ConAmount,GiftId,AlertAmount,ConTimeStart,ConTimeEnd,ConDateStart,ConDateEnd) VALUES('0','" & ConQty & "','" & GiftId(0)("GiftId") & "','" & ConAlertQty & "','" & TimeStart & "','" & TimeEnd & "','" & DateStart & "','" & DateEnd & "')")
        ElseIf Promotion.Condition = 2 Then
            ConPrice = Promotion.NumPrice.Value
            ConAlertQty = Promotion.NumAlertPrice.Value
            If ConPrice = 0 Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            'ราคา
            executesql("INSERT INTO ConditionPromotion(ConPrice,ConAmount,GiftId,AlertPrice,ConTimeStart,ConTimeEnd,ConDateStart,ConDateEnd) VALUES('" & ConPrice & "','0','" & GiftId(0)("GiftId") & "','" & ConAlertQty & "','" & TimeStart & "','" & TimeEnd & "','" & DateStart & "','" & DateEnd & "')")
        End If
        Dim selectCondition As DataTable = executesql("SELECT Max(ConId) As ConId FROM ConditionPromotion")
        executesql("INSERT INTO Promotion(ConditionId,Active,ProName,ProCode) VALUES('" & selectCondition(0)("ConId") & "','1','" & ProName & "','" & ProCode & "')")
        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        selectData()
        clearData()
    End Sub
    Sub selectData()
        Dim SelectData As DataTable = executesql("SELECT * FROM Promotion WHERE Active='1' ORDER BY ProId DESC")
        Promotion.DataGridViewShowPromotion.Rows.Clear()
        For i As Integer = 0 To SelectData.Rows.Count - 1
            Promotion.DataGridViewShowPromotion.Rows.Add(SelectData(i)("ProCode"), SelectData(i)("ProName"), SelectData(i)("ProId"))
        Next
    End Sub
    Sub showData()
        Dim ShowData As DataTable = executesql("SELECT Promotion.ProName,Promotion.ProCode,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,ConditionPromotion.ConTimeStart,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConDateEnd,ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConPrice,ConditionPromotion.ConId,ConditionPromotion.GiftId FROM Promotion INNER JOIN ConditionPromotion ON(Promotion.ConditionId = ConditionPromotion.ConId) WHERE Promotion.ProId = '" & Promotion.PromotionId & "' AND  Promotion.Active='1'")
        Promotion.txtProCode.Enabled = False
        Promotion.txtProName.Text = ShowData(0)("ProName")
        Promotion.txtProCode.Text = ShowData(0)("ProCode")
        Promotion.DateStart.Text = Convert.ToDateTime(ShowData(0)("ConDateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Promotion.DateEnd.Text = Convert.ToDateTime(ShowData(0)("ConDateEnd")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Promotion.TimeStart.Text = ShowData(0)("ConTimeStart")
        Promotion.TimeEnd.Text = ShowData(0)("ConTimeEnd")

        If IsDBNull(ShowData(0)("ConPrice")) Then
            Promotion.RadioBtnQty.Checked = True
            Promotion.NumericUpDownCon.Value = FormatNumber(ShowData(0)("ConAmount"), 2)
            Promotion.NumAlertQty.Value = FormatNumber(ShowData(0)("AlertAmount"), 2)
        ElseIf IsDBNull(ShowData(0)("ConAmount")) Then
            Promotion.RadioBtnPrice.Checked = True
            Promotion.NumPrice.Value = FormatNumber(ShowData(0)("ConPrice"), 2)
            Promotion.NumAlertPrice.Value = FormatNumber(ShowData(0)("AlertPrice"), 2)
        End If

        Dim GiftData As DataTable = executesql("SELECT GiftId,GiftName,DiscountPer,DiscountB,Point FROM GiftValue  WHERE GiftId='" & ShowData(0)("GiftId") & "'")
        If GiftData(0)("DiscountB") = 0 And GiftData(0)("DiscountPer") <> 0 Then
            Promotion.RadioDiscount.Checked = True
            Promotion.NumDiscountPer.Value = GiftData(0)("DiscountPer")
            Promotion.NumDiscountB.Enabled = False
            Promotion.RadioPoint.Checked = False
        ElseIf GiftData(0)("DiscountPer") = 0 And GiftData(0)("DiscountB") <> 0 Then
            Promotion.RadioDiscount.Checked = True
            Promotion.ChkB.Checked = True
            Promotion.RadioPoint.Checked = False
            Promotion.NumDiscountB.Text = GiftData(0)("DiscountB")
        ElseIf GiftData(0)("DiscountB") = 0 And GiftData(0)("DiscountPer") = 0 And IsDBNull(GiftData(0)("Point")) Then
            Promotion.RadioDiscount.Checked = False
            Promotion.RadioBtnGetFree.Checked = True
            Promotion.RadioPoint.Checked = False
            Dim GetFreeData As DataTable = executesql("SELECT Item.ItemName,GetFree.ItemId,GetFree.Discount FROM GetFree INNER JOIN Item ON(GetFree.ItemId=Item.ItemId) WHERE GetFree.GiftValueId = '" & GiftData(0)("GiftId") & "'")
            Promotion.DataGridViewGetFree.Rows.Clear()
            For i As Integer = 0 To GetFreeData.Rows.Count - 1
                Promotion.DataGridViewGetFree.Rows.Add(GetFreeData(i)("ItemName"), GetFreeData(i)("Discount"), GetFreeData(i)("ItemId"))
            Next
        ElseIf GiftData(0)("DiscountB") = 0 And GiftData(0)("DiscountPer") = 0 And Not IsDBNull(GiftData(0)("Point")) Then
            Promotion.RadioDiscount.Checked = False
            Promotion.ChkB.Checked = False
            Promotion.RadioPoint.Checked = True
            Promotion.txtProPoint.Text = GiftData(0)("Point")
        End If

    End Sub
    Sub clearData()
        Promotion.txtProCode.Clear()
        Promotion.txtProName.Clear()
        Promotion.RadioBtnQty.Checked = True
        Promotion.NumericUpDownCon.Value = 0
        Promotion.NumAlertQty.Value = 0
        Promotion.NumPrice.Value = 0
        Promotion.NumAlertPrice.Value = 0
        Promotion.DateStart.Text = ""
        Promotion.DateEnd.Text = ""
        Promotion.TimeStart.Text = ""
        Promotion.TimeEnd.Text = ""
        Promotion.RadioBtnGetFree.Checked = True
        Promotion.NumGetItemDiscount.Value = 0
        Promotion.DataGridViewGetFree.Rows.Clear()
        Promotion.NumDiscountPer.Value = 0
        Promotion.NumDiscountB.Text = ""
        Promotion.ChkB.Checked = False
        Promotion.txtProCode.Enabled = True
        Promotion.btnSave.Enabled = True
        Promotion.PromotionId = 0
        Promotion.Condition = 0
        Promotion.GiftFree = 0
    End Sub
    Sub btnDel()
        If Promotion.PromotionId = 0 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการลบ", MsgBoxStyle.Critical)
            Exit Sub
        Else
            executesql("UPDATE Promotion SET Active='0' WHERE ProId='" & Promotion.PromotionId & "'")
            selectData()
            clearData()
            Exit Sub
        End If
    End Sub
    Sub btnSearch()
        Dim SelectData As DataTable = executesql("SELECT * FROM Promotion WHERE Active='1' AND ProCode='" & Promotion.txtSearch.Text & "' ORDER BY ProId DESC")
        Promotion.DataGridViewShowPromotion.Rows.Clear()
        For i As Integer = 0 To SelectData.Rows.Count - 1
            Promotion.DataGridViewShowPromotion.Rows.Add(SelectData(i)("ProCode"), SelectData(i)("ProName"), SelectData(i)("ProId"))
        Next
    End Sub
End Module
