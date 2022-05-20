Public Class Pos_Payment_Voucher
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        ModulePayMent.checkVoucher()
        Me.Close()
    End Sub

    Private Sub Pos_Payment_Voucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Pos_payment.TopMost = False
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        txtVoucherNumber.Text += "1"
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        txtVoucherNumber.Text += "2"
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        txtVoucherNumber.Text += "3"
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        txtVoucherNumber.Text += "4"
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        txtVoucherNumber.Text += "5"
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        txtVoucherNumber.Text += "6"
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        txtVoucherNumber.Text += "7"
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        txtVoucherNumber.Text += "8"
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        txtVoucherNumber.Text += "9"
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        txtVoucherNumber.Text += "0"
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        txtVoucherNumber.Text += "-"
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim count_txt As Integer = txtVoucherNumber.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtVoucherNumber.Text.Substring(0, i)
        Next
        txtVoucherNumber.Clear()
        txtVoucherNumber.Text = newtxt
    End Sub
End Class