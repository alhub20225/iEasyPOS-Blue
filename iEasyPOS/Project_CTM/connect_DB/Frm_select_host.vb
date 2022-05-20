Imports System.Data.SqlClient
Imports System.Configuration
Public Class Frm_select_host
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
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
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "server", txt_servername.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "username", TxtUserName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "password", TxtPassword.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "database", txt_database.Text)
        Dim SqlConn As New SqlConnection
        Dim SqlConnStr As String = "user id='" & TxtUserName.Text & "';data source='" & txt_servername.Text & "'; persist security info=True;initial catalog='" & txt_database.Text & "';password='" & TxtPassword.Text & "'"
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = SqlConnStr
            Try
                SqlConn.Open()
                MessageBox.Show("Succsessfull DB Connnection", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox("Conection Error", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim server As String = txt_servername.Text
        Dim DB As String = txt_database.Text
        If server = "" Or DB = "" Or TxtUserName.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบก่อน บันทึก", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim SqlConnStr As String = "Server='" & server & "';Database='" & DB & "';User Id='" & TxtUserName.Text & "';Password='" & TxtPassword.Text & "'"
        'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        'config.ConnectionStrings.ConnectionStrings.Clear()
        'config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("localhost_Connection", String.Format(SqlConnStr)))
        'config.Save(ConfigurationSaveMode.Modified, True)
        'ConfigurationManager.RefreshSection("connectionStrings")


        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "server", server)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "username", TxtUserName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "password", TxtPassword.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "database", DB)
        save_complete.Show()
        loading.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        loading.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCreateDataBase2.Show()
        Me.Close()
    End Sub
End Class