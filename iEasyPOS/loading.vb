Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CheckProcessRuning()

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False

            'CheckKeyRegis()
            Check_connect_DB()

        End If
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue

        writeLog("Start Sytem")

    End Sub

    Sub CheckProcessRuning()

        Dim Prcss() As Process

        Prcss = Process.GetProcessesByName("iEasyPOS")

        If Prcss.Count > 1 Then

            Me.Close()

        Else
            Exit Sub
        End If

    End Sub


End Class