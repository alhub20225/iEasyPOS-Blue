Public Class Pos_Payment_CreditCard
    Private Sub Pos_Payment_CreditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        ModulePayMent.loadBank()
        ModulePayMent.loadBankType()
        txtTotalPriceCard.Text = POS.txtSubTotal.Text
        txtTotalPriceCard.Select()
        txtCardNumber.Text = ""
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
        RadDropDownCardType.Text = "ประเภทบัตร"
        RadDropDownBankType.Text = "ธนาคาร"
        txtCardNumber.Clear()
        txtTotalPriceCard.Clear()
    End Sub

    Public BoxName As String = ""

    Private Sub txtCardNumber_Enter(sender As Object, e As EventArgs) Handles txtCardNumber.Enter
        BoxName = "CardNum"
    End Sub

    Private Sub txtTotalPriceCard_Enter(sender As Object, e As EventArgs) Handles txtTotalPriceCard.Enter
        BoxName = "Total"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "1"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "1"
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "2"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "2"
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "3"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "3"
        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "4"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "4"
        End If
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "5"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "5"
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "6"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "6"
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "7"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "7"
        End If
    End Sub

    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "8"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "8"
        End If
    End Sub

    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Text += "9"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "9"
        End If
    End Sub

    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles RadButton9.Click
        If BoxName = "CardNum" Then
            If txtCardNumber.Text = "" Then
                Exit Sub
            End If
            txtCardNumber.Text += "0"
        ElseIf BoxName = "Total" Then
            If txtTotalPriceCard.Text = "" Then
                Exit Sub
            End If
            txtTotalPriceCard.Text += "0"
        End If
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        If BoxName = "CardNum" Then
            'txtCardNumber.Clear()
            If txtCardNumber.Text = "" Then
                Exit Sub
            End If
            Dim count_txt As Integer = txtCardNumber.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            'Dim txt_arr As Array
            For i = 1 To (count_txt - 1) Step 1
                newtxt = txtCardNumber.Text.Substring(0, i)
            Next
            txtCardNumber.Clear()
            txtCardNumber.Text = newtxt
        ElseIf BoxName = "Total" Then
            'txtTotalPriceCard.Clear()
            If txtTotalPriceCard.Text = "" Then
                Exit Sub
            End If
            Dim count_txt As Integer = txtTotalPriceCard.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            'Dim txt_arr As Array
            For i = 1 To (count_txt - 1) Step 1
                newtxt = txtTotalPriceCard.Text.Substring(0, i)
            Next
            txtTotalPriceCard.Clear()
            txtTotalPriceCard.Text = newtxt
        End If
    End Sub

    Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
        If BoxName = "Total" Then
            If txtTotalPriceCard.Text = "" Then
                Exit Sub
            End If
            Dim dot As Boolean = False
            If txtTotalPriceCard.Text.IndexOf(".") >= 0 Then dot = True
            If dot = False Then txtTotalPriceCard.Text += "."
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If (Pos_payment.Label3.Text - Pos_payment.txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        If (Pos_payment.totalPay + txtTotalPriceCard.Text) > FormatNumber(Pos_payment.Label3.Text, 2) Then
            MsgBox("ขาดจำนวนเงินที่ต้องชำระอีก " & FormatNumber(Pos_payment.Label3.Text, 2) - Pos_payment.totalPay & " บาท", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        Pos_payment.totalPay += txtTotalPriceCard.Text
        Pos_payment.AmountPaid = txtTotalPriceCard.Text
        Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
        Pos_payment.PaymentType = "บัตรเครดิต"
        AddPaymentToDGCreditCard()
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        RadDropDownCardType.Text = "ประเภทบัตร"
        RadDropDownBankType.Text = "ธนาคาร"
        txtCardNumber.Clear()
        txtTotalPriceCard.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCardNumber.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtTotalPriceCard.Clear()
    End Sub

    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_credit_th.creditCard
        Label3.Text = My.Resources.pos_credit_th.cardType
        Label2.Text = My.Resources.pos_credit_th.Bank
        Label4.Text = My.Resources.pos_credit_th.BankNo
        Label5.Text = My.Resources.pos_credit_th.TotalPaid
        Label1.Text = My.Resources.pos_credit_th.buttonNumber
        Button26.Text = My.Resources.pos_credit_th.cancel
        Button30.Text = My.Resources.pos_credit_th.ok
    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_credit_en.creditCard
        Label3.Text = My.Resources.pos_credit_en.cardType
        Label2.Text = My.Resources.pos_credit_en.Bank
        Label4.Text = My.Resources.pos_credit_en.BankNo
        Label5.Text = My.Resources.pos_credit_en.TotalPaid
        Label1.Text = My.Resources.pos_credit_en.buttonNumber
        Button26.Text = My.Resources.pos_credit_en.cancel
        Button30.Text = My.Resources.pos_credit_en.ok
    End Sub
End Class