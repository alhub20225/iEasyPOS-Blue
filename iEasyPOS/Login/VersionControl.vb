Module VersionControl
    Sub checkVersion(ver As String)

        Dim client As New Net.WebClient
        Dim newVersion As String
        Try
            newVersion = client.DownloadString("http://www.cash-pos.com/Download/iEasyPOS_Version.txt")
        Catch ex As Exception
            Exit Sub
        End Try

        If CDec(newVersion) > CDec(ver) Then
            Console.WriteLine("new version")
            Try

                Dim procStartInfo As New ProcessStartInfo
                Dim procExecuting As New Process

                With procStartInfo
                    .UseShellExecute = True
                    .FileName = "AutoUpdate.exe"
                    .WindowStyle = ProcessWindowStyle.Normal
                    .Verb = "runas"
                End With

                procExecuting = Process.Start(procStartInfo)
            Catch ex As Exception
                Exit Sub
            End Try
        ElseIf CDec(newVersion) < CDec(ver) Then
            Console.WriteLine("old version")
            Exit Sub
        Else
            Console.WriteLine("last version")
            Exit Sub
        End If

    End Sub
End Module
