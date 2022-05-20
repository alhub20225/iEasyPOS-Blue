Public Class FrmAddToppingReceipe
    Private Sub FrmAddToppingReceipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FrmToppings.ToppingReceipeId = 0 Then
            txtQty.Clear()
            txtMatCode.Text = FrmToppings.ItemCodeToppings
            txtMatName.Text = FrmToppings.ItemNameTopping
        Else
            txtMatName.Text = FrmToppings.DataGridViewToppingReceipe.CurrentRow.Cells(0).Value
            txtMatCode.Text = FrmToppings.DataGridViewToppingReceipe.CurrentRow.Cells(1).Value
            txtQty.Text = FrmToppings.DataGridViewToppingReceipe.CurrentRow.Cells(1).Value
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleAddToppingReceipe.btnSave()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ModuleAddToppingReceipe.clearData()
        Me.Close()
    End Sub
End Class