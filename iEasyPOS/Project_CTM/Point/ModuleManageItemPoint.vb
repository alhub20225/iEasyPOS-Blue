Module ModuleManageItemPoint
    Sub loadItem()
        Dim itemData As DataTable = executesql("select Item.ItemCode,Item.ItemName,Item.ItemId from Item inner join CategoryItem on (Item.CategoryId = CategoryItem.CategoryId) where Item.Active =1 and CategoryItem.CateGroupId = 1")
        If IsNothing(itemData) Then
            Exit Sub
        End If
        If itemData.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmManagePoint.DataGridViewShowItem.Rows.Clear()
        For i As Integer = 0 To itemData.Rows.Count - 1
            FrmManagePoint.DataGridViewShowItem.Rows.Add(itemData(i)("ItemCode"), itemData(i)("ItemName"), itemData(i)("ItemId"))
        Next
    End Sub
    Sub loadCategory()
        Dim cateData As DataTable = executesql("select CategoryName,CategoryId from CategoryItem where CateGroupId = 1 and Active = 1")
        If IsNothing(cateData) Then
            Exit Sub
        End If
        If cateData.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmManagePoint.ComboBoxSelectCategory.Controls.Clear()
        For i As Integer = 0 To cateData.Rows.Count - 1
            FrmManagePoint.ComboBoxSelectCategory.Items.Add(cateData(i)("CategoryName"))
        Next
    End Sub
    Sub loadPintRate()
        Dim PointData As DataTable = executesql("SELECT * FROM PointRate WHERE Active='1'")
        If IsDBNull(PointData) Then
            Exit Sub
        End If
        FrmManagePoint.DataGridViewShowPointRate.Rows.Clear()
        Dim dateNow As DateTime = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
        For i As Integer = 0 To PointData.Rows.Count - 1
            Dim dateStart As DateTime = Convert.ToDateTime(PointData(i)("DateStart") & " " & PointData(i)("TimeStart")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            Dim dateEnd As DateTime = Convert.ToDateTime(PointData(i)("DateEnd") & " " & PointData(i)("TimeEnd")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            If dateEnd >= dateNow Then
                FrmManagePoint.DataGridViewShowPointRate.Rows.Add(Convert.ToDateTime(PointData(i)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), Convert.ToDateTime(PointData(i)("DateEnd")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), PointData(i)("TotalAmount"), PointData(i)("TotalPrice"), PointData(i)("PointRate"), PointData(i)("PointRateId"))
            End If
        Next
    End Sub
    Sub btnAdd()
        If FrmManagePoint.mPointRateId = 0 Then
            MsgBox("เลือกแต้มสะสมก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim check As Boolean = False
        For i As Integer = 0 To FrmManagePoint.DataGridViewShowItem.Rows.Count - 1
            If FrmManagePoint.DataGridViewShowItem.Rows(i).Cells("ItemSelect").Value = True Then
                check = True
                Exit For
            End If
        Next
        If check = False Then
            MsgBox("เลือกสินค้าก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        For i As Integer = 0 To FrmManagePoint.DataGridViewShowItem.Rows.Count - 1
            If FrmManagePoint.DataGridViewShowItem.Rows(i).Cells("ItemSelect").Value = True Then
                Dim checkPointRate As DataTable = executesql("select * from ItemPoint where Active=1 and ItemId='" & FrmManagePoint.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "'")
                If checkPointRate.Rows.Count = 0 Then
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
        WHERE  ConditionPromotion.ConDateEnd >= '" & DateNows & "' AND Promotion.Active='1' AND PromotionItem.ItemId='" & FrmManagePoint.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "' AND PromotionItem.Active = '1' and GiftValue.Point IS NOT NULL")
                    If IsDBNull(checkPromotionPoint) Then

                    End If
                    If checkPromotionPoint.Rows.Count > 0 Then
                        'MsgBox(checkPromotionPoint(0)("ItemName") & " มีโปรโมชั่นที่ได้รับแต้มแล้ว", MsgBoxStyle.Information)
                    Else

                        executesql("Insert Into ItemPoint(ItemId,PointRateId,Active) Values('" & FrmManagePoint.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "','" & FrmManagePoint.mPointRateId & "','1')")
                    End If
                End If
            End If
        Next
        FrmManagePoint.mPointRateId = 0
        loadItemPoint()
        clearSelect()
    End Sub
    Sub loadItemPoint()
        Dim ItemId As Integer = 0
        If FrmManagePoint.ItemPointItemId = 0 Then
            ItemId = FrmManagePoint.DataGridViewShowItem.Rows(0).Cells("ItemId").Value
        Else
            ItemId = FrmManagePoint.ItemPointItemId
        End If
        Dim ItemPointData As DataTable = executesql("select ItemPoint.ItemId,PointRate.* from ItemPoint inner join PointRate on(ItemPoint.PointRateId = PointRate.PointRateId) where ItemPoint.Active = 1 and ItemPoint.ItemId = '" & ItemId & "'")
        If ItemPointData.Rows.Count > 0 Then
            FrmManagePoint.DataGridViewItemPoint.Rows.Clear()
            For i As Integer = 0 To ItemPointData.Rows.Count - 1
                FrmManagePoint.DataGridViewItemPoint.Rows.Add(Convert.ToDateTime(ItemPointData(i)("DateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), Convert.ToDateTime(ItemPointData(i)("DateEnd")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), ItemPointData(i)("TotalAmount"), ItemPointData(i)("TotalPrice"), ItemPointData(i)("PointRate"), ItemPointData(i)("PointRateId"))
            Next
        Else
            FrmManagePoint.DataGridViewItemPoint.Rows.Clear()
        End If
    End Sub
    Sub clearSelect()
        For i As Integer = 0 To FrmManagePoint.DataGridViewShowItem.Rows.Count - 1
            FrmManagePoint.DataGridViewShowItem.Rows(i).Cells("ItemSelect").Value = False
        Next
    End Sub
    Sub btnDel()
        If FrmManagePoint.ItemPointId = 0 Then
            MsgBox("เลือกรายการ Point Rate ที่ต้องการลบจากตารางข้างล่างก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim ItemData As DataTable
        Dim CategoryName As String = FrmManagePoint.ComboBoxSelectCategory.Text
        If CategoryName = "ทั้งหมด" Then
            ItemData = executesql("select Item.ItemId,Item.ItemCode,Item.ItemName from Item inner join CategoryItem on(Item.CategoryId = CategoryItem.CategoryId) where Item.Active=1 and CategoryItem.CateGroupId = 1")
            FrmManagePoint.DataGridViewShowItem.Rows.Clear()
            For i As Integer = 0 To ItemData.Rows.Count - 1
                executesql("update ItemPoint set Active=0 where ItemId='" & ItemData(i)("ItemId") & "' and PointRateId='" & FrmManagePoint.ItemPointId & "'")
            Next
        Else
            ItemData = executesql("select Item.ItemId,Item.ItemCode,Item.ItemName from Item inner join CategoryItem on(Item.CategoryId = CategoryItem.CategoryId) where Item.Active = 1 and CategoryItem.CategoryName = '" & CategoryName & "'")
            FrmManagePoint.DataGridViewShowItem.Rows.Clear()
            For i As Integer = 0 To ItemData.Rows.Count - 1
                executesql("update ItemPoint set Active=0 where ItemId='" & ItemData(i)("ItemId") & "' and PointRateId='" & FrmManagePoint.ItemPointId & "'")
            Next
        End If
        FrmManagePoint.ItemPointId = 0
        FrmManagePoint.ComboBoxSelectCategory.Text = "ทั้งหมด"
        FrmManagePoint.DataGridViewItemPoint.Rows.Clear()
        loadItem()
        loadItemPoint()
    End Sub
End Module
