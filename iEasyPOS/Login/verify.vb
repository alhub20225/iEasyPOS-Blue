Public Class verify
    Dim table As String
    Dim value As String
    Dim where As String
    Dim field As String
    Public Shared UserName_verify As String
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        table = "Users"
        field = "Passwords,FirstName"
        where = "UserId='" & UserIDver & "' AND Passwords='" & txt_password.Text & "'"
        Dim UpdateAcMail As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        If UpdateAcMail.Rows.Count > 0 Then
            table = "Users"
            value = "Active_Email=1"
            where = "UserId='" & UserIDver & "'"
            ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
            UserName_verify = UpdateAcMail(0)("FirstName")
            Me.Close()
            Main.Close()
            Main.Show()
        Else
            MsgBox("รหัสผ่านไม่ถูกต้อง", MsgBoxStyle.Information, "คำเตือน")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        txt_password.Text += "1"
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        txt_password.Text += "2"
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        txt_password.Text += "3"
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        txt_password.Text += "4"
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        txt_password.Text += "5"
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        txt_password.Text += "6"
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        txt_password.Text += "7"
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        txt_password.Text += "8"
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        txt_password.Text += "9"
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        txt_password.Text += "0"
    End Sub

    Private Sub btn_txtclear_Click(sender As Object, e As EventArgs) Handles btn_txtclear.Click
        txt_password.Text = ""
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_password.Text = txt_password.Text.Remove(txt_password.Text.Length - 1)
    End Sub
End Class