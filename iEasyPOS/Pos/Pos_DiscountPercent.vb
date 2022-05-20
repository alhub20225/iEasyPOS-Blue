Public Class Pos_DiscountPercent
    Public Shared DiscPer As String
    Private Sub Pos_DiscountPercent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtDiscPercent.Clear()
        txtDiscPercent.Select()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtDiscPercent.Text += "1"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtDiscPercent.Text += "2"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtDiscPercent.Text += "3"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtDiscPercent.Text += "4"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtDiscPercent.Text += "5"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtDiscPercent.Text += "6"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtDiscPercent.Text += "7"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtDiscPercent.Text += "8"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtDiscPercent.Text += "9"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If txtDiscPercent.Text = "" Then
            Exit Sub
        End If
        Dim count_txt As Integer = txtDiscPercent.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtDiscPercent.Text.Substring(0, i)
        Next
        txtDiscPercent.Clear()
        txtDiscPercent.Text = newtxt
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtDiscPercent.Text = "" Then
            Exit Sub
        End If
        txtDiscPercent.Text += "0"
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If txtDiscPercent.Text = "" Then
            Exit Sub
        End If
        Dim dot As Boolean = False
        If txtDiscPercent.Text.IndexOf(".") >= 0 Then dot = True
        If dot = False Then txtDiscPercent.Text += "."
        'txtDiscPercent.Focus()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If txtDiscPercent.Text = "" Then
            Me.Close()
            Exit Sub
        End If
        POS.DiscountByItem2 = 2
        DiscPer = txtDiscPercent.Text
        Me.Close()
        ModulePOS.AddDiscountPercent()
        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDiscPer :" & DiscPer)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'POS.DiscountByItem2 = 0
        Me.Close()
    End Sub

    Private Sub txtDiscPercent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscPercent.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            DiscPer = txtDiscPercent.Text
            Me.Close()
            ModulePOS.AddDiscountPercent()
            writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDiscPer :" & DiscPer)
        ElseIf e.KeyCode = Keys.Escape Then
            txtDiscPercent.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDiscPercent.Clear()
        'txtDiscPercent.Focus()
    End Sub
    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_discount_percent_th.discountBath
        Label3.Text = My.Resources.pos_discount_percent_th.discount
        Button26.Text = My.Resources.pos_discount_percent_th.cancel
        Button27.Text = My.Resources.pos_discount_percent_th.save

    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_discount_percent_en.discountBath
        Label3.Text = My.Resources.pos_discount_percent_en.discount
        Button26.Text = My.Resources.pos_discount_percent_en.cancel
        Button27.Text = My.Resources.pos_discount_percent_en.save
    End Sub
End Class