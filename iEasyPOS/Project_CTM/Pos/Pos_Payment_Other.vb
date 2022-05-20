Public Class Pos_Payment_Other
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pos_payment.totalPay += txtTotalPay.Text
        Pos_payment.AmountPaid = txtTotalPay.Text
        Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
        Pos_payment.PaymentType = ComboBoxPaytype.Text
        Pos_payment.DataGridViewSale.Rows.Add(ComboBoxPaytype.Text, FormatNumber(txtTotalPay.Text, 2))
        Me.Close()
    End Sub

    Private Sub Pos_Payment_Other_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotalPay.Text = Pos_payment.Label3.Text
        ComboBoxPaytype.Text = ComboBoxPaytype.Items(0)
    End Sub
End Class