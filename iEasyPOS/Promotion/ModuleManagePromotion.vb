Module ModuleManagePromotion
    Sub loadItem()
        Dim itemData As DataTable = executesql("select Item.ItemCode,Item.ItemName,Item.ItemId from Item inner join CategoryItem on (Item.CategoryId = CategoryItem.CategoryId) where Item.Active =1 and CategoryItem.CateGroupId = 1")
        If IsNothing(itemData) Then
            Exit Sub
        End If
        If itemData.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmManagePromotion.DataGridViewShowItem.Rows.Clear()
        For i As Integer = 0 To itemData.Rows.Count - 1
            FrmManagePromotion.DataGridViewShowItem.Rows.Add(itemData(i)("ItemCode"), itemData(i)("ItemName"), itemData(i)("ItemId"))
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
        FrmManagePromotion.ComboBoxSelectCategory.Controls.Clear()
        For i As Integer = 0 To cateData.Rows.Count - 1
            FrmManagePromotion.ComboBoxSelectCategory.Properties.Items.Add(cateData(i)("CategoryName"))
        Next
    End Sub
    Sub loadPromotion()
        Dim ProData As DataTable = executesql("Select  Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        WHERE Promotion.Active='1'")
        If IsDBNull(ProData) Then
            Exit Sub
        End If
        FrmManagePromotion.DataGridViewShowPromotion.Rows.Clear()
        Dim dateNow As DateTime = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
        For i As Integer = 0 To ProData.Rows.Count - 1
            Dim dateStart As DateTime = Convert.ToDateTime(ProData(i)("ConDateStart") & " " & ProData(i)("ConTimeStart")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            Dim dateEnd As DateTime = Convert.ToDateTime(ProData(i)("ConDateEnd") & " " & ProData(i)("ConTimeEnd")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            If dateEnd >= dateNow Then
                FrmManagePromotion.DataGridViewShowPromotion.Rows.Add(ProData(i)("ProName"), Convert.ToDateTime(ProData(i)("ConDateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), Convert.ToDateTime(ProData(i)("ConDateEnd")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), ProData(i)("ProId"))
            End If
        Next
    End Sub
    Sub btnAdd()
        If FrmManagePromotion.mProId = 0 Then
            MsgBox("เลือก Promotion ก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim check As Boolean = False
        For i As Integer = 0 To FrmManagePromotion.DataGridViewShowItem.Rows.Count - 1
            If FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemSelect").Value = True Then
                check = True
                Exit For
            End If
        Next
        If check = False Then
            MsgBox("เลือกสินค้าก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
        For i As Integer = 0 To FrmManagePromotion.DataGridViewShowItem.Rows.Count - 1
            If FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemSelect").Value = True Then
                Dim checkPromotionPoint As DataTable = executesql("select Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        WHERE Promotion.Active='1' and Promotion.ProId = '" & FrmManagePromotion.mProId & "'")
                If checkPromotionPoint.Rows.Count > 0 Then
                    If IsDBNull(checkPromotionPoint(0)("Point")) Then
                        executesql("Insert Into PromotionItem(PromotionId,ItemId,Active) Values('" & FrmManagePromotion.mProId & "','" & FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "','1')")
                    ElseIf Not IsDBNull(checkPromotionPoint(0)("Point")) Then
                        Dim checkPoint As DataTable = executesql("select Item.ItemName from ItemPoint inner join Item on(Item.ItemId = ItemPoint.ItemId) where ItemPoint.ItemId = '" & FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "' and ItemPoint.Active = 1")
                        If checkPoint.Rows.Count = 0 Then
                            executesql("Insert Into PromotionItem(PromotionId,ItemId,Active) Values('" & FrmManagePromotion.mProId & "','" & FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "','1')")
                        ElseIf checkPoint.Rows.Count > 0 Then
                            'MsgBox(checkPoint(0)("ItemName") & " มีรายการแต้มสะสมแล้ว", MsgBoxStyle.Information)
                        End If
                    End If
                Else
                    executesql("Insert Into PromotionItem(PromotionId,ItemId,Active) Values('" & FrmManagePromotion.mProId & "','" & FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemId").Value & "','1')")
                End If
            End If
        Next
        FrmManagePromotion.mProId = 0
        loadPromotionItem()
        clearSelect()
    End Sub
    Sub loadPromotionItem()
        Dim ItemId As Integer = 0
        If FrmManagePromotion.mItemId = 0 Then
            ItemId = FrmManagePromotion.DataGridViewShowItem.Rows(0).Cells("ItemId").Value
        Else
            ItemId = FrmManagePromotion.mItemId
        End If
        Dim ItemPromotionData As DataTable = executesql("select Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point,
        PromotionItem.ItemId
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
        WHERE Promotion.Active='1' AND PromotionItem.Active='1' AND PromotionItem.ItemId = '" & ItemId & "'")
        If ItemPromotionData.Rows.Count > 0 Then
            FrmManagePromotion.DataGridViewItemPromotion.Rows.Clear()
            For i As Integer = 0 To ItemPromotionData.Rows.Count - 1
                FrmManagePromotion.DataGridViewItemPromotion.Rows.Add(ItemPromotionData(i)("ProName"), Convert.ToDateTime(ItemPromotionData(i)("ConDateStart")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), Convert.ToDateTime(ItemPromotionData(i)("ConDateEnd")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), ItemPromotionData(i)("ProId"))
            Next
        Else
            FrmManagePromotion.DataGridViewItemPromotion.Rows.Clear()
        End If
    End Sub
    Sub clearSelect()
        For i As Integer = 0 To FrmManagePromotion.DataGridViewShowItem.Rows.Count - 1
            FrmManagePromotion.DataGridViewShowItem.Rows(i).Cells("ItemSelect").Value = False
        Next
    End Sub
    Sub btnDel()
        If FrmManagePromotion.mProItemId = 0 Then
            MsgBox("เลือกรายการโปรโมชั่นที่ต้องการลบจากตารางข้างล่างก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim CategoryName As String = FrmManagePromotion.ComboBoxSelectCategory.Text
        If CategoryName = "ทั้งหมด" Then
            Dim ItemData As DataTable = executesql("select Item.ItemId,Item.ItemCode,Item.ItemName from Item inner join CategoryItem on(Item.CategoryId = CategoryItem.CategoryId) where Item.Active=1 and CategoryItem.CateGroupId = 1")
            FrmManagePromotion.DataGridViewShowItem.Rows.Clear()
            For i As Integer = 0 To ItemData.Rows.Count - 1
                executesql("update PromotionItem set Active=0 where ItemId='" & ItemData(i)("ItemId") & "' and PromotionId='" & FrmManagePromotion.mProItemId & "'")
            Next
        Else
            Dim ItemData As DataTable = executesql("select Item.ItemId,Item.ItemCode,Item.ItemName from Item inner join CategoryItem on(Item.CategoryId = CategoryItem.CategoryId) where Item.Active = 1 and CategoryItem.CategoryName = '" & CategoryName & "'")
            FrmManagePromotion.DataGridViewShowItem.Rows.Clear()
            For i As Integer = 0 To ItemData.Rows.Count - 1
                executesql("update PromotionItem set Active=0 where ItemId='" & ItemData(i)("ItemId") & "' and PromotionId='" & FrmManagePromotion.mProItemId & "'")
            Next
        End If
        FrmManagePromotion.mProItemId = 0
        FrmManagePromotion.ComboBoxSelectCategory.Text = "ทั้งหมด"
        FrmManagePromotion.DataGridViewItemPromotion.Rows.Clear()
        loadItem()
        loadPromotionItem()
    End Sub
End Module
