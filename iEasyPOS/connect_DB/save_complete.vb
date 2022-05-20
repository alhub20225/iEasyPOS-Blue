Public Class save_complete
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Login.Close()
        Frm_LoginHost.Close()
        Frm_select_host.Close()
        Me.Close()
    End Sub
End Class