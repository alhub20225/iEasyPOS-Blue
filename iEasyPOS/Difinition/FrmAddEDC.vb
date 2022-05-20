Public Class FrmAddEDC
    Public Shared EDCIdSend As Integer
    Private Sub FrmAddEDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSettingPayment.LoadDgEDC()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleSettingPayment.ClearTxtFrmAddEDC()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If EDCIdSend = 0 Then
            'Insert
            ModuleSettingPayment.SaveEDC(EDCIdSend)
        ElseIf EDCIdSend <> 0
            'Update
            ModuleSettingPayment.SaveEDC(EDCIdSend)
        End If
    End Sub
    Private Sub DgEDC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEDC.CellClick
        EDCIdSend = DgEDC.CurrentRow.Cells(0).Value
        ModuleSettingPayment.CellClickDgEdc(EDCIdSend)
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If EDCIdSend = 0 Then
            MsgBox("กรุณาเลือกข้อมูลก่อน")
            Exit Sub
        End If
        Dim Message As Integer = MsgBox("แน่ใจว่าต้องการลบข้อมูล", vbYesNo)
        If Message = vbYes Then
            ModuleSettingPayment.DeleteEdcBank(EDCIdSend)
        ElseIf Message = vbNo
            Exit Sub
        End If
    End Sub
End Class