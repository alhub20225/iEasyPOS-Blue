Imports System.IO
Imports System.Net
Imports System.Security.AccessControl

Public Class Form1
    Dim url = "ftp://witzyz_cashpos@103.246.19.219/public_html/Download/iEasyPOS_Update"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLocalpath.Text = Application.StartupPath() & "\"

        CheckProcessRuning()

        Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(url), FtpWebRequest)
        ftpRequest.Credentials = New NetworkCredential("witzyz_cashpos", "qwa177a5")
        ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
        Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim directoriesServer As New List(Of String)()


        Dim line As String = streamReader.ReadLine()
        While Not String.IsNullOrEmpty(line)
            directoriesServer.Add(line)
            line = streamReader.ReadLine()
        End While
        streamReader.Close()
        For i As Integer = 0 To directoriesServer.Count - 1
            DGV1.Rows.Add(directoriesServer(i).ToString())
        Next
        DGV1.ClearSelection()

        LoadFtp()
    End Sub
    Sub LoadFtp()
        Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(url), FtpWebRequest)
        ftpRequest.Credentials = New NetworkCredential("witzyz_cashpos", "qwa177a5")
        ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
        Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim directoriesServer As New List(Of String)()
        Dim directoriesLocal As New List(Of String)()

        Dim line As String = streamReader.ReadLine()
        While Not String.IsNullOrEmpty(line)
            directoriesServer.Add(line)
            directoriesLocal.Add(line.Split("/")(1))
            line = streamReader.ReadLine()
        End While
        streamReader.Close()

        Using ftpClient As New WebClient()
            ftpClient.Credentials = New System.Net.NetworkCredential("witzyz_cashpos", "qwa177a5")

            For i As Integer = 0 To directoriesServer.Count - 1
                If directoriesServer(i).Contains(".") Then

                    Dim Path As String = "ftp://witzyz_cashpos@103.246.19.219/public_html/Download/" + directoriesServer(i).ToString()
                    Dim LocalPath As String = txtLocalpath.Text + directoriesLocal(i).ToString()

                    Try
                        AccControle(LocalPath)
                        ftpClient.DownloadFile(Path, LocalPath)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try

                End If
            Next
            MsgBox("update successfully")
            Process.Start("iEasyPOS.exe")
            Me.Close()
        End Using
    End Sub

    Sub AccControle(path As String)
        Dim UserAccount As String = "Everyone" 'Specify the user here
        Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(path)
        Dim FolderAcl As New DirectorySecurity
        FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.FullControl, AccessControlType.Allow))

        FolderAcl.SetAccessRuleProtection(True, False)
        FolderInfo.SetAccessControl(FolderAcl)
    End Sub

    Sub CheckProcessRuning()

        Dim Prcss = Process.GetProcessesByName("iEasyPOS")

        For i = 0 To Prcss.Count - 1
            Prcss(i).Kill()
        Next

    End Sub

End Class
