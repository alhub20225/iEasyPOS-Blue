Public Class FrmManageVoucher
    Public Shared VoucherIdSend As Integer
    Private Sub BtnAddVoucher_Click(sender As Object, e As EventArgs) Handles BtnAddVoucher.Click
        ModuleSettingPayment.ClearVoucher()
    End Sub
    Private Sub BtnSaveVoucher_Click(sender As Object, e As EventArgs) Handles BtnSaveVoucher.Click
        ModuleSettingPayment.BtnSaveVoucher()
    End Sub

    Private Sub FrmManageVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSettingPayment.LoadDataVoucher()
    End Sub
    Private Sub DgVoucher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgVoucher.CellClick
        VoucherIdSend = DgVoucher.CurrentRow.Cells(0).Value
        ModuleSettingPayment.CellClickDgVoucher(VoucherIdSend)
    End Sub
    Private Sub BtnSearchVoucher_Click(sender As Object, e As EventArgs) Handles BtnSearchVoucher.Click
        ModuleSettingPayment.SearchVoucher(TxtSearchVoucher.Text)
    End Sub
    Private Sub BtnDeleteVoucher_Click(sender As Object, e As EventArgs) Handles BtnDeleteVoucher.Click
        ModuleSettingPayment.DeleteVoucher(VoucherIdSend)
    End Sub
End Class