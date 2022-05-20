Public Class Edit_Store
    Private Sub Edit_Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FrmManageStock.TopLevel = False
        'Panel1.Controls.Add(FrmManageStock)
        'FrmManageStock.Show()
        DataGridViewSearch.RowTemplate.Height = 35
        ModuleManageStockV2.loadData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleManageStockV2.btnSave()
    End Sub

    Private Sub DataGridViewSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearch.CellClick
        ModuleManageStockV2.showData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleManageStockV2.clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ModuleManageStockV2.btnDelete()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModuleManageStockV2.btnSearch()
    End Sub

    Private Sub cloes_edit_store_Click(sender As Object, e As EventArgs) Handles cloes_edit_store.Click
        ModuleInventory.LoadStore()
        Me.Close()
    End Sub
End Class