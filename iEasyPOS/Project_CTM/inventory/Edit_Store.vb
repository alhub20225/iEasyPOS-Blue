Public Class Edit_Store
    Private Sub Edit_Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmManageStock.TopLevel = False
        Panel1.Controls.Add(FrmManageStock)
        FrmManageStock.Show()
    End Sub

    Private Sub cloes_edit_store_Click(sender As Object, e As EventArgs) Handles cloes_edit_store.Click
        ModuleInventory.LoadStore()
        Me.Close()
    End Sub
End Class