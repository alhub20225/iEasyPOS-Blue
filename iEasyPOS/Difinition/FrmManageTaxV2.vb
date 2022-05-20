Public Class FrmManageTaxV2
    Public Shared TaxIdSend As Integer
    Private Sub FrmManageTaxV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dg_Tax.RowTemplate.Height = 35
        ModuleTaxV2.LoadTax()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleTaxV2.ClearData()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TaxIdSend = Nothing Then
            'Insert Into tax
            ModuleTaxV2.SaveTax()
            Item.DropDownVat.Properties.Items.Clear()
            LoadRadDropDownVat()
        ElseIf TaxIdSend <> Nothing Then
            'Update Tax
            ModuleTaxV2.UpdateTax()
            Item.DropDownVat.Properties.Items.Clear()
            LoadRadDropDownVat()
        End If
    End Sub
    Private Sub Dg_Tax_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Tax.CellClick
        TaxIdSend = Dg_Tax.CurrentRow.Cells(2).Value
        ModuleTaxV2.CellClickDataGridView()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleTaxV2.Deletetax()
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub
End Class