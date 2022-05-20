Public Class Pos_Discount
    Public Shared Discount_value As String
    Private Sub Pos_Discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim BckColor As System.Drawing.Color
        'If My.Settings.PosType = 1 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(239, Byte), Integer))
        'ElseIf My.Settings.PosType = 0 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        'End If
        'PictureBox1.BackColor = BckColor
        'Label2.BackColor = BckColor
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        Me.TopMost = True
        txtDiscount.Clear()
        txtDiscount.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtDiscount.Text += "1"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtDiscount.Text += "2"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtDiscount.Text += "3"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtDiscount.Text += "4"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtDiscount.Text += "5"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtDiscount.Text += "6"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtDiscount.Text += "7"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtDiscount.Text += "8"
        'txtDiscount.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtDiscount.Text += "9"
        'txtDiscount.Focus()
    End Sub

    Private Sub Butto21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtDiscount.Text = "" Then
            Exit Sub
        End If
        txtDiscount.Text += "0"
        'txtDiscount.Focus()
    End Sub

    Private Sub Butto20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If txtDiscount.Text = "" Then
            Exit Sub
        End If
        Dim dot As Boolean = False
        If txtDiscount.Text.IndexOf(".") >= 0 Then dot = True
        If dot = False Then txtDiscount.Text += "."
        'txtDiscount.Focus()
    End Sub

    Private Sub Butto22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If txtDiscount.Text = "" Then
            Exit Sub
        End If
        Dim count_txt As Integer = txtDiscount.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtDiscount.Text.Substring(0, i)
        Next
        txtDiscount.Clear()
        txtDiscount.Text = newtxt
        'txtDiscount.Focus()
    End Sub

    Private Sub Butto27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If txtDiscount.Text = "" Then
            Me.Close()
            Exit Sub
        End If
        Discount_value = txtDiscount.Text
        If Discount_value = Nothing Then
            Discount_value = 0
        End If
        POS.DiscountByItem2 = 2
        Me.Close()
        ModulePOS.AddDiscount()
        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDiscBath :" & Discount_value)
    End Sub

    Private Sub Butto26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'POS.DiscountByItem2 = 0
        Me.Close()
    End Sub

    Private Sub txtDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Discount_value = txtDiscount.Text
            If Discount_value = Nothing Then
                Discount_value = 0
            End If
            Me.Close()
            ModulePOS.AddDiscount()
            writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDiscBath :" & Discount_value)
        ElseIf e.KeyCode = Keys.Escape Then
            txtDiscount.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txtDiscount.Clear()
        'txtDiscount.Focus()
    End Sub

    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_discount_bath_th.discountBath
        Label3.Text = My.Resources.pos_discount_bath_th.discount
        Button26.Text = My.Resources.pos_discount_bath_th.cancel
        Button27.Text = My.Resources.pos_discount_bath_th.save

    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_discount_bath_en.discountBath
        Label3.Text = My.Resources.pos_discount_bath_en.discount
        Button26.Text = My.Resources.pos_discount_bath_en.cancel
        Button27.Text = My.Resources.pos_discount_bath_en.save
    End Sub
End Class