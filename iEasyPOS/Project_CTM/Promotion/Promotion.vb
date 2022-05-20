Public Class Promotion
    Public Shared Condition As Integer
    Private Sub Promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Condition
        RadioBtnQty.Checked = True
        Condition = 1 'Promotion Qty

        PanelPrice.Enabled = False
        PanelQty.Enabled = True
        RadioBtnGetFree.Checked = True

        PanelDate.Enabled = True

        'AutoCompelete ItemCode
        ModulePromotion.AutoCompeleteSearchItem()
        'AutoCompelete ItemCode
        'ModulePromotion.AutoCompeleteSearchItem2()

        ModulePromotion.selectData()
    End Sub

    Private Sub RadioBtnPrice_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtnPrice.CheckedChanged
        PanelPrice.Enabled = True
        PanelQty.Enabled = False
        Condition = 2 'Promotion Price
        NumAlertQty.Value = 0.00
        'NumPrice.Value = 0.00
    End Sub
    Private Sub RadioBtnQty_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtnQty.CheckedChanged
        PanelPrice.Enabled = False
        PanelQty.Enabled = True
        NumericUpDownCon.Value = 0.00
        Condition = 1 'Promotion Qty
        NumAlertPrice.Value = 0.00
    End Sub
    Public Shared GiftFree As Integer
    Private Sub RadioBtnGetFree_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtnGetFree.CheckedChanged
        'RadioDiscount.Checked = False
        ChkB.Checked = False
        NumDiscountPer.Value = 0.00
        NumDiscountB.Text = 0.00
        PanelDiscount.Enabled = False
        PanelGetFree.Enabled = True
        GiftFree = 1
        PanelPoint.Enabled = False
        txtProPoint.Clear()
    End Sub
    Private Sub RadioDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDiscount.CheckedChanged
        'RadioBtnGetFree.Checked = False
        txtSearchGetItem.Clear()
        NumGetItemDiscount.Value = 0.00
        PanelGetFree.Enabled = False
        PanelDiscount.Enabled = True
        DataGridViewGetFree.Rows.Clear()
        GiftFree = 2
        PanelPoint.Enabled = False
        txtProPoint.Clear()
    End Sub

    Private Sub ChkB_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB.CheckedChanged
        If ChkB.Checked = True Then
            NumDiscountPer.Enabled = False
            NumDiscountB.Enabled = True
        Else
            NumDiscountPer.Enabled = True
            NumDiscountB.Enabled = False
        End If
    End Sub

    Private Sub btnAddToDataGridViewGetFree_Click(sender As Object, e As EventArgs) Handles btnAddToDataGridViewGetFree.Click
        Try
            ModulePromotion.AddToDataGridViewGetFree()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelGetItem_Click(sender As Object, e As EventArgs) Handles btnDelGetItem.Click
        Try
            DataGridViewGetFree.Rows.Remove(DataGridViewGetFree.CurrentRow)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'MsgBox(Condition)
        'MsgBox(GiftFree)
        ModulePromotion.btnAddPromotion()
        ModulePromotionToItem.btnSearch()
    End Sub

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs)
        'If ChkDate.Checked = True Then
        '    PanelDate.Enabled = True
        'ElseIf ChkDate.Checked = False Then
        '    PanelDate.Enabled = False
        'End If
    End Sub
    Public Shared PromotionId As Integer
    Private Sub DataGridViewShowPromotion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowPromotion.CellClick
        Try
            PromotionId = DataGridViewShowPromotion.CurrentRow.Cells("ProId").Value
            If PromotionId = 0 Then
                btnSave.Enabled = False
            Else
                ModulePromotion.showData()
                btnSave.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        ModulePromotion.clearData()
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModulePromotion.btnDel()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModulePromotion.btnSearch()
    End Sub

    Private Sub RadioPoint_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPoint.CheckedChanged
        'RadioBtnGetFree.Checked = False
        txtSearchGetItem.Clear()
        NumGetItemDiscount.Value = 0.00
        PanelGetFree.Enabled = False
        PanelDiscount.Enabled = False
        DataGridViewGetFree.Rows.Clear()
        GiftFree = 3
        PanelPoint.Enabled = True
    End Sub
End Class