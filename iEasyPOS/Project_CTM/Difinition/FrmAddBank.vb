Public Class FrmAddBank
    Dim BankIdSend As Integer
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleSettingPayment.ClearDataFrmAddBank()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleSettingPayment.SaveBank()
    End Sub
    Private Sub FrmAddBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSettingPayment.LoadBank()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        BankIdSend = DgBank.CurrentRow.Cells(0).Value
        ModuleSettingPayment.DeleteBank(BankIdSend)
    End Sub
    Private Sub DgBank_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgBank.CellClick
        BankIdSend = DgBank.CurrentRow.Cells(0).Value
        ModuleSettingPayment.CellClickDgBank(BankIdSend)
    End Sub
End Class