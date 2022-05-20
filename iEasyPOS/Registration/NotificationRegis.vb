Imports System.IO
Imports System.Net
Imports System.Net.Mail

Module NotificationRegis

    Dim email As String = "prawit@ieasy.asia"
    Dim password As String = "qwa177a5"
    Dim emailmessage As New MailMessage()
    Dim smtp As New SmtpClient("smtp.gmail.com")
    Dim TerminalName As String = Environment.MachineName

    Sub SendMailNotiRegis(key As String, RegisName As String, Address As String)
        Dim myIP = GetIP()

        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(email, password)
        emailmessage.From = New MailAddress(email)
        emailmessage.To.Add("alwcashpos@gmail.com")
        emailmessage.Subject = "iEasyPOS Registration"
        emailmessage.Body = "Registration [ iEasyPOS ] " + vbCrLf + "Regis Key : " + key + vbCrLf + "Regis Name : " + RegisName + vbCrLf + "Address : " + Address + vbCrLf + "Computer Name : " + TerminalName + vbCrLf + "IP : " + myIP

        smtp.Send(emailmessage)
    End Sub

    Public Function GetIP() As String
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12
        Dim uri_val As New Uri("https://ipv4.wtfismyip.com/text")
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri_val)

        request.Method = WebRequestMethods.Http.Get

        Dim response As HttpWebResponse = request.GetResponse()
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim myIP As String = reader.ReadToEnd()

        response.Close()

        Return myIP
    End Function
End Module
