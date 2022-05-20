Public Class Pos_PaymentGift
    Private Sub Pos_PaymentGift_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtGiftNumber.Clear()
        txtGiftNumber.Select()
    End Sub
    Private Sub BtnGiftPay_Click(sender As Object, e As EventArgs) Handles BtnGiftPay.Click
        If txtGiftNumber.Text = "" Then
            MsgBox("Fill Gift card number", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        GiftAddSale(18, POS.txtSubTotal.Text, txtGiftNumber.Text)

        POS.DiscountByItem2 = 0
        Pos_payment.totalPay = 0
        Pos_payment.AmountPaid = 0
        POS.TextBox3.Focus()
        Me.Close()
    End Sub

    Private Sub BtnGiftCancle_Click(sender As Object, e As EventArgs) Handles BtnGiftCancle.Click
        txtGiftNumber.Clear()
        Me.Close()
    End Sub
End Class