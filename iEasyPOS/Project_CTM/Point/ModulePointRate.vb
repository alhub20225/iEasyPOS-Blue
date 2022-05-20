Module ModulePointRate
    Sub btnSave()
        If FrmPointRate.totalPrice.Value = 0 And FrmPointRate.totalAmount.Value = 0 Then
            MsgBox("กรุณากรอกเงื่อนไขการรับแต้มสะสม", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If FrmPointRate.DateStart.Text = "" Then
            MsgBox("กรุณากรอกวันที่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If FrmPointRate.DateEnd.Text = "" Then
            MsgBox("กรุณากรอกวันที่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If FrmPointRate.TimeStart.Text = "" Then
            MsgBox("กรุณากรอกเวลา", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If FrmPointRate.TimeEnd.Text = "" Then
            MsgBox("กรุณากรอกเวลา", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If FrmPointRate.PointRate.Value = 0 Then
            MsgBox("กรุณากรอกจำนวนแต้มสะสม", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim PointRate As Decimal = FrmPointRate.PointRate.Value
        Dim DateStart As String = Convert.ToDateTime(FrmPointRate.DateStart.Text).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
        Dim DateEnd As String = Convert.ToDateTime(FrmPointRate.DateEnd.Text).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
        Dim TimeStart As String = FrmPointRate.TimeStart.Text
        Dim TimeEnd As String = FrmPointRate.TimeEnd.Text
        Dim totalAmount As Decimal = FrmPointRate.totalAmount.Value
        Dim totalPrice As Decimal = FrmPointRate.totalPrice.Value
        If FrmPointRate.PointId = 0 Then
            'insert to pointrate
            executesql("INSERT INTO PointRate(PointRate,DateStart,DateEnd,TimeStart,TimeEnd,Active,TotalAmount,TotalPrice) VALUES('" & PointRate & "','" & DateStart & "','" & DateEnd & "','" & TimeStart & "','" & TimeEnd & "','1','" & totalAmount & "','" & totalPrice & "')")
        Else
            executesql("UPDATE PointRate SET PointRate='" & PointRate & "',DateStart='" & DateStart & "',DateEnd='" & DateEnd & "',TimeStart='" & TimeStart & "',TimeEnd='" & TimeEnd & "',TotalAmount = '" & totalAmount & "',TotalPrice='" & totalPrice & "' WHERE PointRateId='" & FrmPointRate.PointId & "'")
        End If
        btnClear()
        loadData()
    End Sub
    Sub loadData()
        Dim PointData As DataTable = executesql("SELECT * FROM PointRate WHERE Active='1'")
        FrmPointRate.DataGridViewPoint.Rows.Clear()
        For i As Integer = 0 To PointData.Rows.Count - 1
            FrmPointRate.DataGridViewPoint.Rows.Add(Convert.ToDateTime(PointData(i)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), PointData(i)("PointRate"), PointData(i)("PointRateId"), PointData(i)("TotalAmount"), PointData(i)("TotalPrice"))
        Next
    End Sub
    Sub btnSearch()
        Dim SearchData As DataTable = executesql("SELECT * FROM PointRate WHERE Active ='1' AND DateStart >= '" & Convert.ToDateTime(FrmPointRate.DateTimePicker1.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US")) & "'")
        FrmPointRate.DataGridViewPoint.Rows.Clear()
        For i As Integer = 0 To SearchData.Rows.Count - 1
            FrmPointRate.DataGridViewPoint.Rows.Add(Convert.ToDateTime(SearchData(i)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), SearchData(i)("PointRate"), SearchData(i)("PointRateId"), SearchData(i)("TotalAmount"), SearchData(i)("TotalPrice"))
        Next
    End Sub
    Sub showData()
        Dim PointData As DataTable = executesql("SELECT * FROM PointRate WHERE Active='1' AND PointRateId='" & FrmPointRate.PointId & "'")
        FrmPointRate.PointRate.Value = PointData(0)("PointRate")
        FrmPointRate.DateStart.Text = PointData(0)("DateStart")
        FrmPointRate.DateEnd.Text = PointData(0)("DateEnd")
        FrmPointRate.TimeStart.Text = PointData(0)("TimeStart")
        FrmPointRate.TimeEnd.Text = PointData(0)("TimeEnd")
        If PointData(0)("TotalAmount") > 0 Then
            FrmPointRate.rTotalAmount.Checked = True
            FrmPointRate.pAmount.Enabled = True
            FrmPointRate.totalAmount.Value = PointData(0)("TotalAmount")

            FrmPointRate.rTotalPrice.Checked = False
            FrmPointRate.pPrice.Enabled = False
            FrmPointRate.totalPrice.Value = 0
        End If
        If PointData(0)("TotalPrice") > 0 Then
            FrmPointRate.rTotalAmount.Checked = False
            FrmPointRate.pAmount.Enabled = False
            FrmPointRate.totalAmount.Value = 0

            FrmPointRate.rTotalPrice.Checked = True
            FrmPointRate.pPrice.Enabled = True
            FrmPointRate.totalPrice.Value = PointData(0)("TotalAmount")
        End If
    End Sub
    Sub btnClear()
        FrmPointRate.PointRate.Value = 0
        FrmPointRate.DateStart.Text = ""
        FrmPointRate.DateEnd.Text = ""
        FrmPointRate.TimeStart.Text = ""
        FrmPointRate.TimeEnd.Text = ""
        FrmPointRate.totalAmount.Value = 0
        FrmPointRate.totalPrice.Value = 0
        FrmPointRate.rTotalAmount.Checked = True
        FrmPointRate.rTotalPrice.Checked = False
        FrmPointRate.pAmount.Enabled = True
        FrmPointRate.pPrice.Enabled = False
        FrmPointRate.PointId = 0
    End Sub
    Sub btnDel()
        If FrmPointRate.PointId = 0 Then
            MsgBox("กรุณาเลือกรายการก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        executesql("UPDATE PointRate SET Active='0' WHERE PointRateId='" & FrmPointRate.PointId & "'")
        btnClear()
        loadData()
    End Sub

    'หน้า Item
    Sub btnSearchPointToItem()
        Dim SearchData As DataTable = executesql("SELECT * FROM PointRate WHERE Active ='1' AND DateStart LIKE '%" & Convert.ToDateTime(Item.DateStart.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US")) & "%'")
        Item.DataGridViewShowPointRateList.Rows.Clear()
        For i As Integer = 0 To SearchData.Rows.Count - 1
            Item.DataGridViewShowPointRateList.Rows.Add(Convert.ToDateTime(SearchData(i)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), SearchData(i)("PointRate"), SearchData(i)("PointRateId"))
        Next
    End Sub
    Sub loadDataPointToItem()
        Dim PointData As DataTable = executesql("SELECT * FROM PointRate WHERE Active='1'")
        If IsDBNull(PointData) Then
            Exit Sub
        End If
        Item.DataGridViewShowPointRateList.Rows.Clear()
        Dim dateNow As DateTime = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
        For i As Integer = 0 To PointData.Rows.Count - 1
            Dim dateStart As DateTime = Convert.ToDateTime(PointData(i)("DateStart") & " " & PointData(i)("TimeStart")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            Dim dateEnd As DateTime = Convert.ToDateTime(PointData(i)("DateEnd") & " " & PointData(i)("TimeEnd")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            If dateEnd >= dateNow Then
                Item.DataGridViewShowPointRateList.Rows.Add(Convert.ToDateTime(PointData(i)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), PointData(i)("PointRate"), PointData(i)("PointRateId"))
            End If
        Next
    End Sub
    Sub btnAddPointToDataGridView()
        If Item.PointRate = 0 Then
            MsgBox("กรุณาเลือกรายการคะแนนสะสม", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim checkPoinEx As DataTable = executesql("select DateEnd,TimeEnd from PointRate where PointRateId ='" & Item.DataGridViewShowPointRateList.CurrentRow.Cells(2).Value & "'")
        Dim DateEx As DateTime = Convert.ToDateTime(checkPoinEx(0)("DateEnd") & " " & checkPoinEx(0)("TimeEnd")).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim DateNow As DateTime = Convert.ToDateTime(Now).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        If (DateNow > DateEx) = True Then
            MsgBox("แต้มสะสมหมดอายุ !", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If

        Dim checkPromotionPoint As DataTable = executesql("
Select  Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point,
        PromotionItem.ItemId,Item.ItemName
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
		INNER JOIN Item ON(Item.ItemId = PromotionItem.ItemId)
        WHERE  ConditionPromotion.ConDateEnd >= '" & DateNow & "' AND Promotion.Active='1' AND PromotionItem.ItemId='" & Item.ItemIdSend & "' AND PromotionItem.Active = '1' and GiftValue.Point IS NOT NULL")
        If IsDBNull(checkPromotionPoint) Then

        End If
        If checkPromotionPoint.Rows.Count > 0 Then
            MsgBox("สินค้านี้มีโปรโมชั่นแต้มสะสมแล้ว", MsgBoxStyle.Information)
            Exit Sub
        End If
        'Dim selectPointRate As DataTable = executesql("SELECT * FROM PointRate WHERE PointRateId='" & Item.PointRate & "'")
        'Item.DataGridViewItemPointRate.Rows.Clear()
        'Item.DataGridViewItemPointRate.Rows.Add(Convert.ToDateTime(selectPointRate(0)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), selectPointRate(0)("PointRate"), selectPointRate(0)("PointRateId"))
        Dim checkItemPoint As DataTable = executesql("SELECT * FROM ItemPoint WHERE ItemId='" & Item.ItemIdSend & "'")
        If checkItemPoint.Rows.Count = 0 Then
            executesql("INSERT INTO ItemPoint(ItemId,PointRateId,Active) VALUES('" & Item.ItemIdSend & "','" & Item.DataGridViewShowPointRateList.CurrentRow.Cells(2).Value & "','1')")
        Else
            executesql("UPDATE ItemPoint SET PointRateId='" & Item.DataGridViewShowPointRateList.CurrentRow.Cells(2).Value & "',Active='1' WHERE ItemId='" & Item.ItemIdSend & "'")
        End If
        Item.PointRate = 0
        showDataItemPoint()
    End Sub
    Sub btnSavePointToItem()
        If Item.PointToRedeem.Value = 0 Then
            MsgBox("กรุณากรอกแต้มสะสมที่ใช้แลกซื้อ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'If Item.DataGridViewItemPointRate.RowCount = 0 Then
        '    MsgBox("กรุณาเลือกรายการแต้มสะสม", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If Item.ItemIdSend = 0 Then
            MsgBox("กรุณาเลือกรายการสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim checkItemPoint As DataTable = executesql("SELECT * FROM ItemPoint WHERE ItemId='" & Item.ItemIdSend & "'")
        If checkItemPoint.Rows.Count = 0 Then
            'executesql("INSERT INTO ItemPoint(ItemId,PointRateId,Active) VALUES('" & Item.ItemIdSend & "','" & Item.DataGridViewItemPointRate.Rows(0).Cells(2).Value & "','1')")
            executesql("UPDATE Item SET PointToRedeem='" & Item.PointToRedeem.Value & "' WHERE ItemId = '" & Item.ItemIdSend & "'")
        Else
            'executesql("UPDATE ItemPoint SET ItemId='" & Item.ItemIdSend & "',PointRateId='" & Item.DataGridViewItemPointRate.Rows(0).Cells(2).Value & "',Active='1' WHERE ItemId='" & Item.ItemIdSend & "'")
            executesql("UPDATE Item SET PointToRedeem='" & Item.PointToRedeem.Value & "' WHERE ItemId = '" & Item.ItemIdSend & "'")
        End If
        MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
        showDataItemPoint()
    End Sub
    Sub showDataItemPoint()
        Dim selectPointRate As DataTable = executesql("SELECT ItemPoint.*,PointRate.* FROM ItemPoint INNER JOIN PointRate ON(ItemPoint.PointRateId = PointRate.PointRateId) WHERE ItemPoint.Active='1' AND ItemPoint.ItemId='" & Item.ItemIdSend & "'")
        If IsNothing(selectPointRate) Then
            Item.DataGridViewItemPointRate.Rows.Clear()
            'Item.PointToRedeem.Value = 0
            Exit Sub
        End If
        If selectPointRate.Rows.Count = 0 Then
            Item.DataGridViewItemPointRate.Rows.Clear()
            'Item.PointToRedeem.Value = 0
            Exit Sub
        End If
        Item.DataGridViewItemPointRate.Rows.Clear()
        Item.DataGridViewItemPointRate.Rows.Add(Convert.ToDateTime(selectPointRate(0)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), selectPointRate(0)("PointRate"), selectPointRate(0)("PointRateId"))
        Dim SelectItemData As DataTable = executesql("SELECT PointToRedeem FROM Item WHERE ItemId = '" & Item.ItemIdSend & "'")
        'Item.PointToRedeem.Value = SelectItemData(0)("PointToRedeem")
    End Sub
    Sub PointToRedeem()
        Dim selectPointToRedeem As DataTable = executesql("SELECT PointToRedeem FROM Item WHERE ItemId ='" & Item.ItemIdSend & "'")
        If IsNothing(selectPointToRedeem) Then
            Item.PointToRedeem.Value = 0
            Exit Sub
        End If
        If IsDBNull(selectPointToRedeem(0)("PointToRedeem")) Then
            Item.PointToRedeem.Value = 0
            Exit Sub
        End If
        If selectPointToRedeem.Rows.Count = 0 Then
            Item.PointToRedeem.Value = 0
            Exit Sub
        End If
        Item.PointToRedeem.Value = selectPointToRedeem(0)("PointToRedeem")
    End Sub
    Sub btnDelItemPointRate()
        If Item.PointRateItem = 0 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการลบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Item.ItemIdSend = 0 Then
            MsgBox("กรุณาเลือกรายการสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        executesql("UPDATE ItemPoint SET Active='0' WHERE ItemId='" & Item.ItemIdSend & "'")
        showDataItemPoint()
    End Sub
End Module
