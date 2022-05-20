Public Class Pos_Discount
    Public Shared Discount_value As String
    Private Sub Pos_Discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txtDiscount.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtDiscount.Text += "1"
        txtDiscount.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtDiscount.Text += "2"
        txtDiscount.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtDiscount.Text += "3"
        txtDiscount.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtDiscount.Text += "4"
        txtDiscount.Focus()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtDiscount.Text += "5"
        txtDiscount.Focus()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtDiscount.Text += "6"
        txtDiscount.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtDiscount.Text += "7"
        txtDiscount.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtDiscount.Text += "8"
        txtDiscount.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtDiscount.Text += "9"
        txtDiscount.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        txtDiscount.Text += "0"
        txtDiscount.Focus()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        txtDiscount.Text += "."
        txtDiscount.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        txtDiscount.Clear()
        txtDiscount.Focus()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
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
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
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
        ElseIf e.KeyCode = Keys.Escape Then
            txtDiscount.Clear()
            Me.Close()
        End If
    End Sub
End Class