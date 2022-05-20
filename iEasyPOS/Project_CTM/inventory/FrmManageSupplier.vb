Public Class FrmManageSupplier
    Public Shared SupidSend As Integer
    Private Sub BtnAddSupplier_Click(sender As Object, e As EventArgs) Handles BtnAddSupplier.Click
        'Clear Supplier Text
        ModuleManageSupplier.ClearText()
        ModuleManageSupplier.LoadCodeSupplier()
        SupidSend = 0
    End Sub
    Private Sub BtnSaveSupplier_Click(sender As Object, e As EventArgs) Handles BtnSaveSupplier.Click
        If SupidSend = Nothing Then
            'Save Supplier
            ModuleManageSupplier.SaveSupplier()
        Else
            'Update Supplier
            ModuleManageSupplier.UpdateSupplier()
        End If
    End Sub
    Private Sub FrmManageSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Frm Supplier
        ModuleManageSupplier.LoadCodeSupplier()
        ModuleManageSupplier.LoadPaymentTerm()
        ModuleManageSupplier.LoadDataSupplier()
    End Sub
    Private Sub BtnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles BtnDeleteSupplier.Click
        'Delete Supplier
        ModuleManageSupplier.DeleteSupplier()
    End Sub
    Private Sub DgSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSupplier.CellClick
        SupidSend = DgSupplier.CurrentRow.Cells(2).Value
        ModuleManageSupplier.LoadDetailSupplier()
    End Sub
    Private Sub BtnSrc_Click(sender As Object, e As EventArgs) Handles BtnSrc.Click
        'Search Supplier 
        ModuleManageSupplier.SearchSupplier()
    End Sub
End Class