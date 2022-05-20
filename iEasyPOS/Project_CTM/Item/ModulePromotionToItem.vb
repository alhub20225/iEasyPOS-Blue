Module ModulePromotionToItem
    Sub loadData()
        Dim SelectData As DataTable = executesql("SELECT * FROM Promotion WHERE Active='1' ORDER BY ProId DESC")
        Item.DataGridViewSearch.Rows.Clear()
        For i As Integer = 0 To SelectData.Rows.Count - 1
            Item.DataGridViewSearch.Rows.Add(SelectData(i)("ProCode"), SelectData(i)("ProName"), SelectData(i)("ProId"))
        Next
    End Sub
    Sub btnAddPromotionToItem()
        If Item.ProId = 0 Then
            MsgBox("กรุณาเลือกโปรโมชั่นก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Item.ItemIdSend = 0 Then
            MsgBox("กรุณาเลิอก Item ก่อน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim checkPromotionItem As DataTable = executesql("SELECT * FROM PromotionItem WHERE ItemId='" & Item.ItemIdSend & "' AND PromotionId='" & Item.ProId & "' AND Active='1'")
        If checkPromotionItem.Rows.Count > 0 Then
            MsgBox("มีโปรโมชั่นนี้แล้ว", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim checkPromotionPoint As DataTable = executesql("select    ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,ConditionPromotion.ConDateStart,ConditionPromotion.ConTimeStart,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.Point,
        PromotionItem.ItemId,Item.ItemName
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
		INNER JOIN Item ON(Item.ItemId = PromotionItem.ItemId)
        WHERE Promotion.Active='1' AND PromotionItem.Active = '1' AND Promotion.ProId = '" & Item.ProId & "' AND GiftValue.Point IS NOT NULL")
        If IsDBNull(checkPromotionPoint) Then

        End If
        If checkPromotionPoint.Rows.Count > 0 Then
            Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
            Dim checkPointRate As DataTable = executesql("select ItemPoint.ItemId from ItemPoint inner join PointRate on(ItemPoint.PointRateId = PointRate.PointRateId) where ItemPoint.ItemId = '" & Item.ItemIdSend & "' and ItemPoint.Active = 1 and PointRate.DateEnd >= '" & DateNows & "' ")
            If checkPointRate.Rows.Count > 0 Then
                MsgBox("สินค้านี้มีโปรโมชั่นแต้มสะสมแล้ว", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        executesql("INSERT INTO PromotionItem(PromotionId,ItemId,Active) VALUES('" & Item.ProId & "','" & Item.ItemIdSend & "','1')")
        Item.ProId = 0
        showData()
    End Sub
    Sub showData()
        Dim SelectData As DataTable = executesql("SELECT PromotionItem.*,Promotion.ProName,Promotion.ProCode FROM PromotionItem INNER JOIN Promotion ON(PromotionItem.PromotionId = Promotion.ProId) WHERE PromotionItem.Active='1' AND PromotionItem.ItemId='" & Item.ItemIdSend & "'")
        Item.DataGridViewPromotionItem.Rows.Clear()
        For i As Integer = 0 To SelectData.Rows.Count - 1
            Item.DataGridViewPromotionItem.Rows.Add(SelectData(i)("ProCode"), SelectData(i)("ProName"), SelectData(i)("PromotionId"))
        Next
    End Sub
    Sub btnSearch()
        Item.DataGridViewSearch.Rows.Clear()
        If Item.txtSearchPromotion.Text = "" Then
            Dim SelectData As DataTable = executesql("SELECT * FROM Promotion WHERE Active='1' ORDER BY ProId DESC")
            For i As Integer = 0 To SelectData.Rows.Count - 1
                Item.DataGridViewSearch.Rows.Add(SelectData(i)("ProCode"), SelectData(i)("ProName"), SelectData(i)("ProId"))
            Next
        Else
            Dim SelectData As DataTable = executesql("SELECT * FROM Promotion WHERE Active='1' AND ProCode='" & Item.txtSearchPromotion.Text & "' ORDER BY ProId DESC")
            For i As Integer = 0 To SelectData.Rows.Count - 1
                Item.DataGridViewSearch.Rows.Add(SelectData(i)("ProCode"), SelectData(i)("ProName"), SelectData(i)("ProId"))
            Next
        End If
    End Sub
    Sub btnDel()
        executesql("UPDATE PromotionItem SET Active='0' WHERE PromotionId = '" & Item.PromotionItemId & "' AND ItemId='" & Item.ItemIdSend & "'")
        showData()
    End Sub
End Module
