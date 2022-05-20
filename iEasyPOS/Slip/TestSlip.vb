Imports System.IO
Imports System.Net
Imports DevExpress.XtraReports.UI

Public Class TestSlip

    Private Sub TestSlip_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim report_ As New Report_CustomerSale
        report_.Parameter1.Value = "2562-07-01 00:00:00"
        report_.Parameter2.Value = "2562-07-31 23:00:00"
        report_.SqlDataSource1.Connection.ConnectionString = rptConStr
        report_.CreateDocument()
        report_.ShowPreviewDialog
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim request As FtpWebRequest = WebRequest.Create("ftp://www.cash-pos.com/private/items.json")
        'request.Credentials = New NetworkCredential("witzyz_cashpos", "qwa177a5")
        'request.Method = WebRequestMethods.Ftp.UploadFile

        'Using fileStream As Stream = File.OpenRead("D:\items.json"),
        '      ftpStream As Stream = request.GetRequestStream()
        '    Dim read As Integer
        '    Do
        '        Dim buffer() As Byte = New Byte(10240) {}
        '        read = fileStream.Read(buffer, 0, buffer.Length)
        '        If read > 0 Then
        '            ftpStream.Write(buffer, 0, read)
        '            Console.WriteLine("Uploaded {0} bytes", fileStream.Position)
        '        End If
        '    Loop While read > 0
        'End Using

        'Report.Parameter2.Value = "2561-12-01 00:00:00"
        'Report.Parameter3.Value = "2561-12-01 23:59:00"
        'Report.Parameter1.Value = "ASUS-K401"

        'Report.CreateDocument()



    End Sub

End Class