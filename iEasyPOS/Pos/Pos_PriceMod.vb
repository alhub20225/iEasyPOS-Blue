Public Class Pos_PriceMod
    Private Sub Pos_PriceMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pos Price mod " & ModulePOS.ItemName)
        TextDescrip.Text = ModulePOS.ItemName
        txtPriceAmount.Select()
        txtPriceAmount.Text = ""
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtPriceAmount.Text += "1"
        'txtAmount.Focus()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtPriceAmount.Text += "2"
        'txtAmount.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtPriceAmount.Text += "3"
        'txtAmount.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtPriceAmount.Text += "4"
        'txtAmount.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtPriceAmount.Text += "5"
        'txtAmount.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtPriceAmount.Text += "6"
        'txtAmount.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtPriceAmount.Text += "7"
        'txtAmount.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtPriceAmount.Text += "8"
        'txtAmount.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtPriceAmount.Text += "9"
        'txtAmount.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If txtPriceAmount.Text = "" Then
            Exit Sub
        End If
        txtPriceAmount.Text += "0"
        'txtAmount.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPriceAmount.Clear()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If txtPriceAmount.Text = "" Then
            Exit Sub
        End If
        txtPriceAmount.Text += "."
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If txtPriceAmount.Text = "" Then
            Exit Sub
        End If
        Dim count_txt As Integer = txtPriceAmount.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtPriceAmount.Text.Substring(0, i)
        Next
        txtPriceAmount.Clear()
        txtPriceAmount.Text = newtxt
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        txtPriceAmount.Text = ""
        Me.Close()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If txtPriceAmount.Text <> "" Then
            For Each txt_number As String In txtPriceAmount.Text
                If Not IsNumeric(txt_number) Then
                    MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPriceAmount.Clear()
                    txtPriceAmount.Focus()
                    Exit Sub
                    Exit For
                End If
            Next
            writeLog("User ID " + Frm_Login.UserId.ToString + " Enter Price mod = " & txtPriceAmount.Text)
            Me.Close()
        Else
            MessageBox.Show("กรุณาใส่ราคา", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPriceAmount.Focus()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextDescrip.Text = ""
        TextDescrip.Select()
    End Sub
End Class