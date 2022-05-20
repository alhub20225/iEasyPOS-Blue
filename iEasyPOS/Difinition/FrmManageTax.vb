Public Class FrmManageTax
    Public Shared TaxIdSend As Integer
    Private Sub FrmManageTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dg_Tax.RowTemplate.Height = 35
        ModuleTax.LoadTax()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleTax.ClearData()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TaxIdSend = Nothing Then
            'Insert Into tax
            ModuleTax.SaveTax()
            Item.DropDownVat.Properties.Items.Clear()
            LoadRadDropDownVat()
        ElseIf TaxIdSend <> Nothing Then
            'Update Tax
            ModuleTax.UpdateTax()
            Item.DropDownVat.Properties.Items.Clear()
            LoadRadDropDownVat()
        End If
    End Sub
    Private Sub Dg_Tax_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Tax.CellClick
        TaxIdSend = Dg_Tax.CurrentRow.Cells(2).Value
        ModuleTax.CellClickDataGridView()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleTax.Deletetax()
    End Sub
End Class