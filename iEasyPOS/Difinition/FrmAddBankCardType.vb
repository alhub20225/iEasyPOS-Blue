Public Class FrmAddBankCardType
    Public Shared BankCardTypeNameIdSend As Integer
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleSettingPayment.ClearDataBankCardTypeName()
        ModuleSettingPayment.LoadBankCardType()
    End Sub
    Private Sub FrmAddBankCardType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSettingPayment.LoadBankCardType()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BankCardTypeNameIdSend = 0 Then
            'Insert
            ModuleSettingPayment.SaveBankCardType(BankCardTypeNameIdSend)
        ElseIf BankCardTypeNameIdSend <> 0
            'Update
            ModuleSettingPayment.SaveBankCardType(BankCardTypeNameIdSend)
        End If
    End Sub
    Private Sub DgBankCardType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgBankCardType.CellClick
        BankCardTypeNameIdSend = DgBankCardType.CurrentRow.Cells(0).Value
        ModuleSettingPayment.CellClickBankCardType(BankCardTypeNameIdSend)
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleSettingPayment.DeleteBankCardType(BankCardTypeNameIdSend)
    End Sub
End Class