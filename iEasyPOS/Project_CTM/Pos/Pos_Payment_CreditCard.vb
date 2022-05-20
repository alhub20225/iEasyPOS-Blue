Public Class Pos_Payment_CreditCard
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub Pos_Payment_CreditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModulePayMent.loadBank()
        ModulePayMent.loadBankType()
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
            txtCardNumber.Text += "0"
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Text += "0"
        End If
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        If BoxName = "CardNum" Then
            txtCardNumber.Clear()
        ElseIf BoxName = "Total" Then
            txtTotalPriceCard.Clear()
        End If
    End Sub

    Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
        If BoxName = "Total" Then
            txtTotalPriceCard.Text += "."
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
End Class