Public Class Pos_Payment_Other
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pos_payment.totalPay += txtTotalPay.Text
        Pos_payment.AmountPaid = txtTotalPay.Text
        Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
        Pos_payment.PaymentType = ComboBoxPaytype.Text
        Pos_payment.DataGridViewSale.Rows.Add(ComboBoxPaytype.Text, FormatNumber(txtTotalPay.Text, 2))
        writeLog("User ID " + Frm_Login.UserId.ToString + " Other payment ok click")
        Me.Close()
    End Sub

    Private Sub Pos_Payment_Other_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        writeLog("User ID " + Frm_Login.UserId.ToString + " Show Other payment")
        txtTotalPay.Text = Pos_payment.Label3.Text
        ComboBoxPaytype.Text = ComboBoxPaytype.Properties.Items(0)
        PictureBox2.BackgroundImage = iEasyPOS.My.Resources.Resources.Logo_QRThai
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxPaytype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaytype.SelectedIndexChanged
        If ComboBoxPaytype.Text = "QR Thai" Then
            PictureBox2.BackgroundImage = iEasyPOS.My.Resources.Resources.Logo_QRThai
        ElseIf ComboBoxPaytype.Text = "QR Alipay" Then
            PictureBox2.BackgroundImage = iEasyPOS.My.Resources.Resources.Logo_QRAlipay
        ElseIf ComboBoxPaytype.Text = "QR WeChat" Then
            PictureBox2.BackgroundImage = iEasyPOS.My.Resources.Resources.Logo_QRWechat
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_payment_other_th.PaymentTypeOther
        Label3.Text = My.Resources.pos_payment_other_th.PaymentType
        Label4.Text = My.Resources.pos_payment_other_th.Amounts
        BtnCancle.Text = My.Resources.pos_payment_other_th.Cancel
        Button1.Text = My.Resources.pos_payment_other_th.Ok
    End Sub

    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_payment_other_en.PaymentTypeOther
        Label3.Text = My.Resources.pos_payment_other_en.PaymentType
        Label4.Text = My.Resources.pos_payment_other_en.Amounts
        BtnCancle.Text = My.Resources.pos_payment_other_en.Cancel
        Button1.Text = My.Resources.pos_payment_other_en.Ok
    End Sub
End Class