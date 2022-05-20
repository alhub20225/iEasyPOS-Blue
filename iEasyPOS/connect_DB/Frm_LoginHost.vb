Public Class Frm_LoginHost
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_number.Clear()
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txt_number.Text += "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt_number.Text += "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt_number.Text += "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt_number.Text += "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt_number.Text += "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt_number.Text += "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt_number.Text += "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt_number.Text += "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt_number.Text += "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt_number.Text += "9"
    End Sub

    Sub enter_btn()
        Dim day As String = Now.Day.ToString
        If day.Length = 1 Then
            day = "0" + day
        End If
        Dim month As String = Now.Month.ToString
        Dim pass As String = day + month
        Dim txt_pass As String = txt_number.Text
        If pass = txt_pass Then
            Frm_select_host.Show()
            Me.Close()
        ElseIf pass <> txt_pass Then
            MsgBox("Not pass")
        End If
    End Sub
    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        enter_btn()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class