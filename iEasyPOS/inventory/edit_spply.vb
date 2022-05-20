Public Class edit_spply
    Public Shared SupidSend As Integer
    Private Sub edit_spply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FrmManageSupplier.TopLevel = False
        'Panel1.Controls.Add(FrmManageSupplier)
        'FrmManageSupplier.Show()

        DgSupplier.RowTemplate.Height = 35
        'Load Frm Supplier
        ModuleManageSupplierV2.LoadCodeSupplier()
        ModuleManageSupplierV2.LoadPaymentTerm()
        ModuleManageSupplierV2.LoadDataSupplier()
    End Sub

    'Private Sub cloes_edit_supply_Click(sender As Object, e As EventArgs)
    '    ModuleInventory.LoadSupplier()
    '    Me.Close()
    'End Sub
    Private Sub BtnAddSupplier_Click(sender As Object, e As EventArgs) Handles BtnAddSupplier.Click
        'Clear Supplier Text
        ModuleManageSupplierV2.ClearText()
        ModuleManageSupplierV2.LoadCodeSupplier()
        SupidSend = 0
    End Sub
    Private Sub BtnSaveSupplier_Click(sender As Object, e As EventArgs) Handles BtnSaveSupplier.Click
        If SupidSend = Nothing Then
            'Save Supplier
            ModuleManageSupplierV2.SaveSupplier()
        Else
            'Update Supplier
            ModuleManageSupplierV2.UpdateSupplier()
        End If
    End Sub

    Private Sub BtnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles BtnDeleteSupplier.Click
        'Delete Supplier
        ModuleManageSupplierV2.DeleteSupplier()
    End Sub
    Private Sub DgSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSupplier.CellClick
        SupidSend = DgSupplier.CurrentRow.Cells(2).Value
        ModuleManageSupplierV2.LoadDetailSupplier()
    End Sub
    Private Sub BtnSrc_Click(sender As Object, e As EventArgs) Handles BtnSrc.Click
        'Search Supplier 
        ModuleManageSupplierV2.SearchSupplier()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ModuleInventory.LoadSupplier()
        Me.Close()
    End Sub
End Class