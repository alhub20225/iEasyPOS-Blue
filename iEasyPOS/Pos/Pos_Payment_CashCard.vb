Public Class Pos_Payment_CashCard
    Public Shared Function Plexiglass(dialog As Form) As DialogResult
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(dialog.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.45
            plexi.Show()
            dialog.StartPosition = FormStartPosition.CenterParent
            Return dialog.ShowDialog(plexi)
        End Using
    End Function

    Private Sub Pos_Payment_CashCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Pos_payment.Close()
        Plexiglass(Me)
        'Me.TopMost = True
        'Pos_payment.BackColor = Color.Black
        'Pos_payment.Opacity = 0.45
        'Me.TopMost = True
        'Pos_payment.TopMost = False
    End Sub
End Class