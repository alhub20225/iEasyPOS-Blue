Imports System.Windows.Forms

Public Class Main_close_Dialog

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " System close")
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim Prcss() As Process
        Prcss = Process.GetProcessesByName("PrintOrder")
        If Prcss.Count > 0 Then

            Process.GetProcessesByName("PrintOrder")(0).Kill()

        End If
        Frm_Login.Close()
        loading.Close()
        Main2.Close()
        Me.Close()
    End Sub
End Class
