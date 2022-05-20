Public Class FrmManageStock
    Private Sub FrmManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewSearch.RowTemplate.Height = 35
        ModuleManageStock.loadData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleManageStock.btnSave()
    End Sub

    Private Sub DataGridViewSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearch.CellClick
        ModuleManageStock.showData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleManageStock.clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ModuleManageStock.btnDelete()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModuleManageStock.btnSearch()
    End Sub
End Class