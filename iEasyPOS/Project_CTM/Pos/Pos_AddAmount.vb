Public Class Pos_AddAmount
    Public Shared Amount As String
    Private Sub Pos_AddAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ItemId = 0 Then
            MsgBox("กรุณากดเลือกรายการ", MsgBoxStyle.Critical, "กดเลือกรายการ")
            Me.Close()
        End If
        txtAmount.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtAmount.Text += "1"
        txtAmount.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtAmount.Text += "2"
        txtAmount.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtAmount.Text += "3"
        txtAmount.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtAmount.Text += "4"
        txtAmount.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtAmount.Text += "5"
        txtAmount.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtAmount.Text += "6"
        txtAmount.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtAmount.Text += "7"
        txtAmount.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtAmount.Text += "8"
        txtAmount.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtAmount.Text += "9"
        txtAmount.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtAmount.Text = "" Then
            Exit Sub
        End If
        txtAmount.Text += "0"
        txtAmount.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        txtAmount.Clear()
        txtAmount.Focus()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Amount = txtAmount.Text
        Me.Close()
        ModulePOS.AddAmount()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Amount = txtAmount.Text
            Me.Close()
            ModulePOS.AddAmount()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class