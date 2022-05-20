Imports System.Data
Imports System.Data.SqlClient
Public Class loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CheckProcessRuning()

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False

            CheckKeyRegis()

            Check_connect_DB()

        End If
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
    End Sub
    Sub Check_connect_DB()
        Dim server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "server", Nothing)
        If server Is Nothing Then
            Frm_select_host.Show()
        Else
            Dim objConn As New SqlConnection
            'Dim dt As New DataTable
            objConn.ConnectionString = strcon
            Try
                objConn.Open()
            Catch sqlError As SqlException
                Frm_select_host.Show()
                Exit Sub
            End Try
        End If


    End Sub

    Sub CheckProcessRuning()

        Dim Prcss() As Process

        Prcss = Process.GetProcessesByName("Project_CTM")

        If Prcss.Count > 1 Then

            Me.Close()

        Else
            Exit Sub
        End If

    End Sub


End Class