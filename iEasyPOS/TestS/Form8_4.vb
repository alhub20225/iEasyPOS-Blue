Public Class Form8_4
    Private Sub Form8_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBoxHqConnect.Checked = True Then
            Panel29.Visible = True
            Panel19.Visible = True
            Me.Refresh()
        Else
            Panel29.Visible = False
            Panel19.Visible = False
            Me.Refresh()
        End If
    End Sub

    Private Sub Connect_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHqConnect.CheckedChanged
        If CheckBoxHqConnect.Checked = True Then
            Panel29.Visible = True
            Panel19.Visible = True
            Me.Refresh()
        Else
            Panel29.Visible = False
            Panel19.Visible = False
            Me.Refresh()
        End If
    End Sub
End Class