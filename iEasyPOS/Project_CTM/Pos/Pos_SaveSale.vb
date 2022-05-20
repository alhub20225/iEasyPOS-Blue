Public Class Pos_SaveSale
    Private Sub Pos_SaveSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSaveSale.loadData()
    End Sub

    Private Sub DataGridViewSaveSale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSaveSale.CellClick
        ModuleSaveSale.showData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class