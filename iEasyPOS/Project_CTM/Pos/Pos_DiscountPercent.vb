Public Class Pos_DiscountPercent
    Public Shared DiscPer As String
    Private Sub Pos_DiscountPercent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txtDiscPercent.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtDiscPercent.Text += "1"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtDiscPercent.Text += "2"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtDiscPercent.Text += "3"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtDiscPercent.Text += "4"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtDiscPercent.Text += "5"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtDiscPercent.Text += "6"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtDiscPercent.Text += "7"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtDiscPercent.Text += "8"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtDiscPercent.Text += "9"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        txtDiscPercent.Clear()
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        txtDiscPercent.Text += "0"
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        txtDiscPercent.Text += "."
        txtDiscPercent.Focus()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If txtDiscPercent.Text = "" Then
            Me.Close()
            Exit Sub
        End If
        POS.DiscountByItem2 = 2
        DiscPer = txtDiscPercent.Text
        Me.Close()
        ModulePOS.AddDiscountPercent()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'POS.DiscountByItem2 = 0
        Me.Close()
    End Sub

    Private Sub txtDiscPercent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscPercent.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            DiscPer = txtDiscPercent.Text
            Me.Close()
            ModulePOS.AddDiscountPercent()
        ElseIf e.KeyCode = Keys.Escape Then
            txtDiscPercent.Clear()
            Me.Close()
        End If
    End Sub
End Class