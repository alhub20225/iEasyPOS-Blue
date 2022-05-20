Public Class FrmCreateDataBase2
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txt_servername.Text = "" Then
            MsgBox("กรุณากรอกชื่อ Server", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_database.Text = "" Then
            MsgBox("กรุณากรอกชื่อฐานข้อมูล", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If TxtUserName.Text = "" Then
            MsgBox("กรุณากรอกชื่อผู้ใช้งาน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If TxtPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ModuleCreateDatabase.btnAdd()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        loading.Close()
    End Sub
End Class