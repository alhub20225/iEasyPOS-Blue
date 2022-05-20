Public Class Pos_DiscountByItem
    Public Shared DiscountByItem_value As String
    Public Shared per As String
    Private Sub Pos_DiscountByItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ToggleSwitch.Value = False
        txtDiscount.Clear()
        per = 0
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
        POS.DiscountByItem2 = 1
        DiscountByItem_value = txtDiscount.Text
        ModulePOS.AddDiscountByItem()
        Me.Close()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'POS.DiscountByItem2 = 0
        Me.Close()
    End Sub

    Private Sub ToggleSwitch_ValueChanged(sender As Object, e As EventArgs) Handles ToggleSwitch.ValueChanged

    End Sub
End Class