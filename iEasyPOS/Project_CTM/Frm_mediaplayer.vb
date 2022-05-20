Public Class Frm_mediaplayer
    Private Sub LOAD_Click(sender As Object, e As EventArgs) Handles LOAD.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
            Exit Sub
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub
End Class