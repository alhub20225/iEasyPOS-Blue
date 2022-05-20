Public Class FrmWithdrawMoney
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtWithdrawAmount.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtWithdrawAmount.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtWithdrawAmount.Text += "3"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtWithdrawAmount.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtWithdrawAmount.Text += "5"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtWithdrawAmount.Text += "6"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtWithdrawAmount.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtWithdrawAmount.Text += "8"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtWithdrawAmount.Text += "9"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If txtWithdrawAmount.Text = "" Then
            Exit Sub
        End If
        Dim dot As Boolean = False
        If txtWithdrawAmount.Text.IndexOf(".") >= 0 Then dot = True
        If dot = False Then txtWithdrawAmount.Text += "."
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If txtWithdrawAmount.Text = "" Then
            Exit Sub
        End If
        txtWithdrawAmount.Text += "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If txtWithdrawAmount.Text = "" Then
            Exit Sub
        End If
        Dim count_txt As Integer = txtWithdrawAmount.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txtWithdrawAmount.Text.Substring(0, i)
        Next
        txtWithdrawAmount.Clear()
        txtWithdrawAmount.Text = newtxt
    End Sub
    Public Shared WithdrawMoneyId As Integer = 0
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleWithdrawMoney.btnSave()
        Me.Close()
    End Sub

    Private Sub DataGridViewShowWithdraw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowWithdraw.CellClick
        Try
            WithdrawMoneyId = DataGridViewShowWithdraw.CurrentRow.Cells(3).Value
            ModuleWithdrawMoney.showData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmWithdrawMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleWithdrawMoney.loadData()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModuleWithdrawMoney.btnDel()
    End Sub

    Private Sub DateTimePickerSearchWithdraw_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerSearchWithdraw.ValueChanged
        ModuleWithdrawMoney.search()
    End Sub
End Class