Public Class Frm_PromotionList
    Private Sub Frm_PromotionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModulePosPromotion.PromotionList()
    End Sub
    Public Shared PromotionIds As Integer
    Private Sub DataGridViewPromotionList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPromotionList.CellClick
        PromotionIds = DataGridViewPromotionList.CurrentRow.Cells(0).Value
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-EN"))
        Dim TimeNows As String = Convert.ToDateTime(Now).ToString("HH:mm", New System.Globalization.CultureInfo("en-EN"))
        Dim checkPromotion As DataTable = executesql("Select  Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,
        PromotionItem.ItemId
        FROM Promotion 
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
        WHERE ConditionPromotion.ConDateEnd >= '" & DateNows & "' AND Promotion.Active='1' AND PromotionItem.Active='1' AND Promotion.ProId='" & PromotionIds & "'")

        For a As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            For j As Integer = 0 To checkPromotion.Rows.Count - 1
                If Not IsDBNull(checkPromotion(j)("ConPrice")) Then 'Price
                    If TimeNows > checkPromotion(j)("ConTimeEnd") And DateNows <= checkPromotion(j)("ConDateEnd") Then
                        If checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") = 0 Then
                            If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                                PosPromotion.PromotionId = checkPromotion(j)("ProId")
                                PosPromotion.GiftvalueId = checkPromotion(j)("GiftId")
                                PosPromotion.Show()
                            End If
                        ElseIf checkPromotion(j)("DiscountPer") <> 0 And checkPromotion(j)("DiscountB") = 0 And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                            DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * FormatNumber(checkPromotion(j)("DiscountPer"), 2)) / 100
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                            Pos_DiscountByItem.DiscountByItem_value = DisCount
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 1
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                            Pos_DiscountByItem.per = 1
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = PromotionIds
                            ModulePOS.calculatePrice()
                        ElseIf checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") <> 0 And POS.DataGridViewPOS.Rows(a).Cells(3).Value >= checkPromotion(j)("ConPrice") Then
                            DisCount = FormatNumber(checkPromotion(j)("DiscountB"), 2)
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 0
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                            Pos_DiscountByItem.per = 0
                            POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = PromotionIds
                            ModulePOS.calculatePrice()
                        End If
                    End If
                ElseIf Not IsDBNull(checkPromotion(j)("ConAmount")) Then 'Amount
                    If TimeNows > checkPromotion(j)("ConTimeEnd") And DateNows <= checkPromotion(j)("ConDateEnd") Then
                        If checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") = 0 Then
                            If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(1).Value >= checkPromotion(j)("ConAmount") Then
                                PosPromotion.PromotionId = checkPromotion(j)("ProId")
                                PosPromotion.GiftvalueId = checkPromotion(j)("GiftId")
                                PosPromotion.Show()
                            End If
                        ElseIf checkPromotion(j)("DiscountPer") <> 0 And checkPromotion(j)("DiscountB") = 0 Then
                            If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(1).Value >= checkPromotion(j)("ConAmount") Then
                                DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * FormatNumber(checkPromotion(j)("DiscountPer"), 2)) / 100
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                                Pos_DiscountByItem.DiscountByItem_value = DisCount
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 1
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                                Pos_DiscountByItem.per = 1
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = PromotionIds
                                ModulePOS.calculatePrice()
                            End If
                        ElseIf checkPromotion(j)("DiscountPer") = 0 And checkPromotion(j)("DiscountB") <> 0 Then
                            If POS.DataGridViewPOS.Rows(a).Cells(4).Value = checkPromotion(j)("ItemId") And POS.DataGridViewPOS.Rows(a).Cells(1).Value >= checkPromotion(j)("ConAmount") Then
                                DisCount = FormatNumber(checkPromotion(j)("DiscountB"), 2)
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells(5).Value = DisCount
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("discountType").Value = 0
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("AllowDC").Value = 1
                                Pos_DiscountByItem.per = 0
                                POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).Cells("PromotionType").Value = PromotionIds
                                ModulePOS.calculatePrice()
                            End If
                        End If
                    End If
                End If
            Next
        Next
        Me.Close()
    End Sub
End Class