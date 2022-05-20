Public Class FrmAmount20
    Private Sub FrmAmount20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Clear()
        txtAmount.Select()
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtAmount.Text += "1"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtAmount.Text += "2"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtAmount.Text += "3"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtAmount.Text += "4"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtAmount.Text += "5"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtAmount.Text += "6"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtAmount.Text += "7"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtAmount.Text += "8"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtAmount.Text += "9"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtAmount.Text = "" Then
            Exit Sub
        End If
        txtAmount.Text += "0"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If txtAmount.Text = "" Then
            Exit Sub
        End If
        Dim count_txt As Integer = txtAmount.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtAmount.Text.Substring(0, i)
        Next
        txtAmount.Clear()
        txtAmount.Text = newtxt
    End Sub
    Private Sub txtAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Frm_CloseShift.TxtAmount20.Text = txtAmount.Text
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAmount.Clear()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Me.Close()
        If txtAmount.Text = "" Then
            Frm_CloseShift.TxtAmount20.Text = 0
        Else
            Frm_CloseShift.TxtAmount20.Text = txtAmount.Text
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub
End Class