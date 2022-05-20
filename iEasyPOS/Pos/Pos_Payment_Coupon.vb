Public Class Pos_Payment_Coupon
    Private Sub btnAddCoupon_Click(sender As Object, e As EventArgs) Handles btnAddCoupon.Click
        ModulePayMent.checkCoupon()
        Me.Close()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub Pos_Payment_Coupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Pos_payment.TopMost = False
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        txtCouponNumber.Text += "1"
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        txtCouponNumber.Text += "2"
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        txtCouponNumber.Text += "3"
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        txtCouponNumber.Text += "4"
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        txtCouponNumber.Text += "5"
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        txtCouponNumber.Text += "6"
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        txtCouponNumber.Text += "7"
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        txtCouponNumber.Text += "8"
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        txtCouponNumber.Text += "9"
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        txtCouponNumber.Text += "0"
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        txtCouponNumber.Text += "-"
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Dim count_txt As Integer = txtCouponNumber.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtCouponNumber.Text.Substring(0, i)
        Next
        txtCouponNumber.Clear()
        txtCouponNumber.Text = newtxt
    End Sub
End Class