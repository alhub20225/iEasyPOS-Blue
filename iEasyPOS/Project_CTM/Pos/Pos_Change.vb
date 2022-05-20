Public Class Pos_Change
    Private Sub Pos_Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChange.Text = FormatNumber(change, 2)
    End Sub
    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        GetSaleId = 0
        TB_GetSaleId = 0
        Me.Close()
    End Sub
End Class