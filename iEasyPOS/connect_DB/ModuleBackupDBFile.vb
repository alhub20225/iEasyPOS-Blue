Module ModuleBackupDBFile
    Sub blank(ByVal str As String)

        'Try

        '    If str = "backup" Then

        '        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_server", txtServerName.Text)
        '        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_username", txtServerUser.Text)
        '        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_password", txtServerPass.Text)
        '        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_database", txtDatabase.Text)

        '        'SFDBackup.FileName = cmbdatabase.Text
        '        'SFDBackup.ShowDialog()
        '        'Timer1.Enabled = True
        '        'PRGBackup.Visible = True

        '        Dim dateNow As String = Format(Now, "yyyyMMdd")
        '        Dim s As String
        '        s = "C:\Program Files (x86)\ALW\ieasyEcom" & dateNow
        '        Dim sql As String = "BACKUP DATABASE " & My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_server") & " to disk='" & s & "'"
        '        executesql(sql)

        '    ElseIf str = "restore" Then
        '        OFDBackup.ShowDialog()
        '        Timer1.Enabled = True
        '        PRGBackup.Visible = True
        '        executesql("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk='" & OFDBackup.FileName & "'")
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub
End Module
