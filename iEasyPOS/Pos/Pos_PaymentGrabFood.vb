Public Class Pos_PaymentGrabFood
    Private Sub Pos_PaymentGrabFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrabNumber.Text = ""
        txtGrabNumber.Select()
    End Sub

    Private Sub BtnGrabPay_Click(sender As Object, e As EventArgs) Handles BtnGrabPay.Click
        If txtGrabNumber.Text = "" Then
            MsgBox("ใส่หมายเลข Grab food Order number", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Console.WriteLine("btn grab food add sale")
        GrabFoodAddSale(19, POS.txtSubTotal.Text, txtGrabNumber.Text)
        POS.DiscountByItem2 = 0
        Pos_payment.totalPay = 0
        Pos_payment.AmountPaid = 0
        'POS.txtItemCode.Focus()


        Me.Close()
        frm_payment_delivery.Close()
    End Sub

    Private Sub BtnGrabCancle_Click(sender As Object, e As EventArgs) Handles BtnGrabCancle.Click
        txtGrabNumber.Text = ""

        Me.Close()
    End Sub
End Class