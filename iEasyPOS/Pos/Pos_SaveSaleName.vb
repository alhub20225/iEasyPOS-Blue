Public Class Pos_SaveSaleName
    Public Shared SaleName As String
    Private Sub Pos_SaveSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveSale.Click
        SaleName = txtSaleName.Text
        ModuleSaveSale.btnSave()
        POS.DiscountByItem2 = 0
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class