Public Class Pos_payment
    Public PaymentType As String
    Public AmountPaid As Decimal
    Private Sub Pos_payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelPayCash.Visible = True
        ' PanelPayCredit.Visible = False
        Label3.Text = POS.txtSubTotal.Text
        'ModulePayMent.saveDataToDataGridView()
        'PaymentType = "เงินสด"
        ToggleSwitch.Value = False
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        txtPayTotal.Text = FormatNumber(0, 2)
        totalPay = 0
        totalPay2 = 0
        AmountPaid = 0
        Button1.Enabled = True
        Pos_Discount.Discount_value = 0
        Pos_DiscountByItem.DiscountByItem_value = 0
        DisCount = 0
        DataGridViewSale.Rows.Clear()
        Me.Close()
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        PanelPayCash.Visible = True
        'PanelPayCredit.Visible = False
        'PanelVoucher.Visible = False
        PaymentType = sender.Text
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ModulePayMent.loadBank()
        ModulePayMent.loadBankType()
        'PanelPayCash.Visible = False
        'PanelPayCredit.Visible = True
        'PanelVoucher.Visible = False
        'PanelCoupon.Visible = False
        'PaymentType = sender.Text
        If My.Settings.Comport = 0 Then
            Pos_Payment_CreditCard.Show()
        ElseIf My.Settings.Comport > 0 Then
            Pos_Payment_EDC.Show()
        End If

    End Sub

    Private Sub txtCardNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Public totalPay As Decimal = 0
    Dim totalPay2 As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 1
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 1, 2)
        AmountPaid = 1
        PaymentType = "เงินสด"
        AddPaymentToDG()
        'UpdatePaymentDG()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 5
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 5, 2)
        AmountPaid = 5
        PaymentType = "เงินสด"
        AddPaymentToDG()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 10
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 10, 2)
        PaymentType = "เงินสด"
        AmountPaid = 10
        AddPaymentToDG()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 20
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 20, 2)
        PaymentType = "เงินสด"
        AmountPaid = 20
        AddPaymentToDG()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 50
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 50, 2)
        PaymentType = "เงินสด"
        AmountPaid = 50
        AddPaymentToDG()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 100
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 100, 2)
        PaymentType = "เงินสด"
        AmountPaid = 100
        AddPaymentToDG()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 500
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 500, 2)
        PaymentType = "เงินสด"
        AmountPaid = 500
        AddPaymentToDG()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        totalPay += 1000
        txtPayTotal.Text = FormatNumber(txtPayTotal.Text + 1000, 2)
        PaymentType = "เงินสด"
        AmountPaid = 1000
        AddPaymentToDG()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridViewSale.Rows.Clear()
        totalPay = 0
        AmountPaid = 0
        txtPayTotal.Text = FormatNumber(POS.txtSubTotal.Text, 2)
        UpdatePaymentDG()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPayTotal.Text = FormatNumber(0, 2)
        totalPay = 0
        totalPay2 = 0
        AmountPaid = 0
        Button1.Enabled = True
        DataGridViewSale.Rows.Clear()
        Pos_Discount.Discount_value = 0
        Pos_DiscountByItem.DiscountByItem_value = 0
        DisCount = 0
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtNumpad.Text += "1"
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtNumpad.Text += "2"
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtNumpad.Text += "3"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtNumpad.Text += "4"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtNumpad.Text += "5"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtNumpad.Text += "6"

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtNumpad.Text += "7"

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtNumpad.Text += "8"

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtNumpad.Text += "9"

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtNumpad.Text = "" Then
            Exit Sub
        End If
        txtNumpad.Text += "0"

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If txtNumpad.Text = "" Then
            Exit Sub
        End If
        Dim dot As Boolean = False
        If txtNumpad.Text.IndexOf(".") >= 0 Then dot = True
        If dot = False Then txtNumpad.Text += "."
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        DisCount = 0
        ModulePayMent.BtnAddSale()
        POS.DiscountByItem2 = 0
        totalPay = 0
        AmountPaid = 0

        'Me.Close()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Pos_Payment_CashCard.Show()
        'PanelPayCash.Visible = False
        'PanelPayCredit.Visible = False
        'PanelVoucher.Visible = True
        'PanelCoupon.Visible = False
        PaymentType = sender.Text
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Pos_Payment_Coupon.Show()
        'PanelPayCash.Visible = False
        ''PanelPayCredit.Visible = False
        'PanelVoucher.Visible = False
        'PanelCoupon.Visible = True
        PaymentType = sender.Text
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        'Pos_Payment_Voucher.Show()
        'PaymentType = sender.Text
        If MsgBox("ยืนยันการชำระเงินผ่าน QR Code", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            FrmQRPayment.Show()
        End If
    End Sub

    Private Sub txtPayTotal_Click(sender As Object, e As EventArgs) Handles txtPayTotal.Click
        PanelCashNumPad.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub btnNumPadEnter_Click(sender As Object, e As EventArgs) Handles btnNumPadEnter.Click
        If (Label3.Text - txtPayTotal.Text) <= 0 Then
            MsgBox("จำนวนเงินครบแล้ว", MsgBoxStyle.Information, "คำเตือน")
            Exit Sub
        End If
        If txtNumpad.Text = "" Then
            Exit Sub
        End If
        If txtNumpad.Text = 0 Then
            Exit Sub
            DataGridViewSale.Rows.Clear()
        End If
        totalPay = 0
        AmountPaid = 0
        Dim paytotal As Decimal = txtPayTotal.Text
        Dim numpadTotal As Decimal = FormatNumber(txtNumpad.Text, 2)
        txtPayTotal.Text = FormatNumber(numpadTotal, 2)
        totalPay = txtNumpad.Text
        AmountPaid = txtNumpad.Text
        PaymentType = "เงินสด"
        ModulePayMent.AddPaymentToDG()
        txtNumpad.Clear()
    End Sub

    Private Sub btnClearNumPad_Click(sender As Object, e As EventArgs) Handles btnClearNumPad.Click

        txtNumpad.Clear()
        totalPay = 0
        totalPay2 = 0
        AmountPaid = 0
        Button1.Enabled = True
        Pos_Discount.Discount_value = 0
        Pos_DiscountByItem.DiscountByItem_value = 0
        DisCount = 0
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If DataGridViewSale.Rows.Count = 0 Then
            Exit Sub
        End If
        DataGridViewSale.Rows.RemoveAt(DataGridViewSale.CurrentCell.RowIndex)
        txtPayTotal.Text = FormatNumber(0, 2)
        totalPay = 0
        totalPay2 = 0
        totalPay = 0
        AmountPaid = 0
        Button1.Enabled = True
        DataGridViewSale.Rows.Clear()
        Pos_Discount.Discount_value = 0
        Pos_DiscountByItem.DiscountByItem_value = 0
        DisCount = 0
    End Sub

    Private Sub ToggleSwitch_ValueChanged(sender As Object, e As EventArgs) Handles ToggleSwitch.ValueChanged
        If ToggleSwitch.Value = False Then
            Panel3.Visible = True
            PanelCashNumPad.Visible = False
        ElseIf ToggleSwitch.Value = True Then
            Panel3.Visible = False
            PanelCashNumPad.Visible = True
        End If
    End Sub


    'Private Sub Button33_Click(sender As Object, e As EventArgs)
    '    'txtTotalPriceCard.Text -= "1"
    '    Dim count_txt As Integer = txtTotalPriceCard.TextLength
    '    Dim newtxt As String = ""
    '    Dim i As Integer = 0
    '    'Dim txt_arr As Array
    '    For i = 1 To (count_txt - 1) Step 1
    '        newtxt = txtTotalPriceCard.Text.Substring(0, i)
    '    Next
    '    txtTotalPriceCard.Clear()
    '    txtTotalPriceCard.Text = newtxt
    'End Sub


    'Private Sub Button54_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "1"
    'End Sub

    'Private Sub Button53_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "2"
    'End Sub

    'Private Sub Button52_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "3"
    'End Sub

    'Private Sub Button51_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "4"
    'End Sub

    'Private Sub Button50_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "5"
    'End Sub

    'Private Sub Button49_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "6"
    'End Sub

    'Private Sub Button48_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "7"
    'End Sub

    'Private Sub Button47_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "8"
    'End Sub

    'Private Sub Button46_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "9"
    'End Sub

    'Private Sub Button44_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "0"
    'End Sub

    'Private Sub Button43_Click(sender As Object, e As EventArgs)
    '    txtVoucherNumber.Text += "-"
    'End Sub

    'Private Sub Button45_Click(sender As Object, e As EventArgs)
    '    'txtTotalPriceCard.Text -= "1"
    '    Dim count_txt As Integer = txtVoucherNumber.TextLength
    '    Dim newtxt As String = ""
    '    Dim i As Integer = 0
    '    'Dim txt_arr As Array
    '    For i = 1 To (count_txt - 1) Step 1
    '        newtxt = txtVoucherNumber.Text.Substring(0, i)
    '    Next
    '    txtVoucherNumber.Clear()
    '    txtVoucherNumber.Text = newtxt
    'End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs)
        ModulePayMent.checkVoucher()
    End Sub

    Private Sub txtTotalPriceCard_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub Button67_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "1"
    'End Sub

    'Private Sub Button66_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "2"
    'End Sub

    'Private Sub Button65_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "3"
    'End Sub

    'Private Sub Button64_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "4"
    'End Sub

    'Private Sub Button63_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "5"
    'End Sub

    'Private Sub Button62_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "6"
    'End Sub

    'Private Sub Button61_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "7"
    'End Sub

    'Private Sub Button60_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "8"
    'End Sub

    'Private Sub Button59_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "9"
    'End Sub

    'Private Sub Button57_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "0"
    'End Sub

    'Private Sub Button56_Click(sender As Object, e As EventArgs)
    '    txtCouponNumber.Text += "0"
    'End Sub

    'Private Sub Button58_Click(sender As Object, e As EventArgs)
    '    'txtTotalPriceCard.Text -= "1"
    '    Dim count_txt As Integer = txtCouponNumber.TextLength
    '    Dim newtxt As String = ""
    '    Dim i As Integer = 0
    '    'Dim txt_arr As Array
    '    For i = 1 To (count_txt - 1) Step 1
    '        newtxt = txtCouponNumber.Text.Substring(0, i)
    '    Next
    '    txtCouponNumber.Clear()
    '    txtCouponNumber.Text = newtxt
    'End Sub

    Private Sub btnAddCoupon_Click(sender As Object, e As EventArgs)
        'ModulePayMent.checkCoupon
    End Sub

    Private Sub BtnPayOrther_Click(sender As Object, e As EventArgs) Handles BtnPayOrther.Click
        Pos_Payment_Other.Show()
    End Sub
End Class