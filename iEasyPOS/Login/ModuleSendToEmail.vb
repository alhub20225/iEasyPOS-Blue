Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mail.SmtpException
Imports System.Net.NetworkCredential
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO.Directory
Module ModuleSendToEmail
    Public UserIDver As Integer
    Sub SendPassWord()
        Dim EmailMessage As New MailMessage()
        Try
            Dim field As String = "UserId,Email,Passwords"
            Dim table As String = "Users"
            Dim Where As String = "FirstName = '" & Register.TxtFirstName.Text & "' AND Email='" & Register.TxtEmail.Text & "'"
            Dim SelectEmail As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
            Dim EmailUsers As String = SelectEmail(0)("Email")
            Dim Passwords As String = SelectEmail(0)("Passwords")
            EmailMessage.From = New MailAddress("prawit@ieasy.asia")
            EmailMessage.To.Add(EmailUsers)
            EmailMessage.Subject = "รหัสการยืนยันตัวตน Hive Up"
            EmailMessage.Body = "รหัสการยืนยัน :" + Passwords
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("prawit@ieasy.asia", "qwa177a5")
            SMTP.Send(EmailMessage)
            UserIDver = SelectEmail(0)("UserId")
        Catch ex As Exception
        End Try
        MsgBox("กรุณาดูรหัสการยืนยันตัวตนใน Email ของท่าน", vbMsgBoxRight, "การยืนยันตัวตน")
        verify.Close()
        verify.Show()
    End Sub
End Module
