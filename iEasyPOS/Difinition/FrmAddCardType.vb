Public Class FrmAddCardType
    Public Shared CardTypeIdSend As Integer
    Private Sub FrmAddCardType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSettingPayment.LoadCardType()
        ModuleSettingPayment.LoadComboBoxBankCardType()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CardTypeIdSend = 0 Then
            ModuleSettingPayment.SaveCardType(CardTypeIdSend)
        ElseIf CardTypeIdSend <> 0
            ModuleSettingPayment.SaveCardType(CardTypeIdSend)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleSettingPayment.ClearDataCardType()
    End Sub
    Private Sub DgCardType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCardType.CellClick
        CardTypeIdSend = DgCardType.CurrentRow.Cells(0).Value
        ModuleSettingPayment.CellClickCardType(CardTypeIdSend)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleSettingPayment.DeleteCardType(CardTypeIdSend)
    End Sub

    Private Sub TxtMoreMoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMoreMoney.KeyPress
        ModuleSettingPayment.ValidateNumberTextBox(e)
    End Sub
    Private Sub TxtBoxCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxCharge.KeyPress
        ModuleSettingPayment.ValidateNumberTextBox(e)
    End Sub
    Private Sub TxtDisCount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDisCount.KeyPress
        ModuleSettingPayment.ValidateNumberTextBox(e)
    End Sub
End Class