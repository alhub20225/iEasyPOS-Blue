Public Class Pos_paymentLineman
    Private Sub Pos_paymentLineman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrabNumber.Text = ""
        txtGrabNumber.Select()
    End Sub

    Private Sub BtnGrabPay_Click(sender As Object, e As EventArgs) Handles BtnGrabPay.Click
        If txtGrabNumber.Text = "" Then
            MsgBox("ใส่หมายเลข LINE MAN Order number", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        'get paymenttypid
        Console.WriteLine("btn LINE MAN  add sale")
        Dim getPaymentLineman As DataTable = executesql("select PaymentId from Paymenttype where PaymentName = 'LINEMAN'")
        If getPaymentLineman.Rows.Count = 0 Then
            MsgBox("ไม่มีระบบชำระเงินผ่าน LINEMAN", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        LinemanAddSale(getPaymentLineman(0)("PaymentId"), POS.txtSubTotal.Text, txtGrabNumber.Text)
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