Public Class Pos_AddAmount
    Public Shared Amount As String
    Private Sub Pos_AddAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim BckColor As System.Drawing.Color
        'If My.Settings.PosType = 1 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(239, Byte), Integer))
        'ElseIf My.Settings.PosType = 0 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        'End If
        'PictureBox1.BackColor = BckColor
        'Label2.BackColor = BckColor
        If Frm_Login.language = 0 Then
            If ItemId = 0 Then
                MsgBox("กรุณากดเลือกรายการ", MsgBoxStyle.Critical, "กดเลือกรายการ")
                Me.Close()
            End If
            change_to_th_text()
        Else
            If ItemId = 0 Then
                MsgBox("Please select item.", MsgBoxStyle.Critical, "info")
                Me.Close()
            End If
            change_to_eng_text()
        End If


        txtAmount.Clear()
        txtAmount.Select()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtAmount.Text += "1"
        'txtAmount.Focus()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtAmount.Text += "2"
        'txtAmount.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtAmount.Text += "3"
        'txtAmount.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtAmount.Text += "4"
        'txtAmount.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtAmount.Text += "5"
        'txtAmount.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtAmount.Text += "6"
        'txtAmount.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtAmount.Text += "7"
        'txtAmount.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtAmount.Text += "8"
        'txtAmount.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtAmount.Text += "9"
        'txtAmount.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtAmount.Text = "" Then
            Exit Sub
        End If
        txtAmount.Text += "0"
        'txtAmount.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If txtAmount.Text = "" Then
            Exit Sub
        End If
        Dim count_txt As Integer = txtAmount.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtAmount.Text.Substring(0, i)
        Next
        txtAmount.Clear()
        txtAmount.Text = newtxt
        'txtAmount.Focus()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Amount = txtAmount.Text
        Me.Close()
        ModulePOS.AddAmount()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Amount = txtAmount.Text
            Me.Close()
            ModulePOS.AddAmount()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button02(sender As Object, e As EventArgs) Handles Button2.Click
        txtAmount.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_amount_th.qty
        Label3.Text = My.Resources.pos_amount_th.qty
        Button26.Text = My.Resources.pos_amount_th.cancel
        Button27.Text = My.Resources.pos_amount_th.save
    End Sub

    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_amount_en.qty
        Label3.Text = My.Resources.pos_amount_en.qty
        Button26.Text = My.Resources.pos_amount_en.cancel
        Button27.Text = My.Resources.pos_amount_en.save
    End Sub
End Class