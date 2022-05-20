Public Class POS_Price
    Private Sub POS_Price_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtPriceAmount.Clear()
        Me.Close()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim total As Decimal = 0
        Dim subtotal As Decimal = 0
        Dim saleid As Integer = 0
        Dim unitprice As Decimal = 0
        Dim initPrice As Decimal = 0
        Dim saleItemid As Integer = POS.DataGridViewPOS.CurrentRow.Cells("SaleItemId").Value
        If TableId = 0 Then
            Console.WriteLine("TableId = 0")

            If POS.DataGridViewPOS.CurrentRow.Cells("SaleItemId").Value > 0 Then
                POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber(txtPriceAmount.Text, 2)
                POS.DataGridViewPOS.CurrentRow.Cells(2).Value = FormatNumber((txtPriceAmount.Text / POS.DataGridViewPOS.CurrentRow.Cells(1).Value), 2)
                ModulePOS.calculatePrice()
                total = POS.txtTotal.Text
                subtotal = POS.txtSubTotal.Text
                saleid = TB_GetSaleId
                unitprice = POS.DataGridViewPOS.CurrentRow.Cells(2).Value
                updatePrice(saleid, saleItemid, txtPriceAmount.Text, subtotal, total, unitprice)
            Else
                POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber(txtPriceAmount.Text, 2)
                POS.DataGridViewPOS.CurrentRow.Cells(2).Value = FormatNumber((txtPriceAmount.Text / POS.DataGridViewPOS.CurrentRow.Cells(1).Value), 2)
                ModulePOS.calculatePrice()
            End If

        Else

            Console.WriteLine("TableId > 0")
            If POS.DataGridViewPOS.CurrentRow.Cells("SaleItemId").Value > 0 Then
                POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber(txtPriceAmount.Text, 2)
                POS.DataGridViewPOS.CurrentRow.Cells(2).Value = FormatNumber((txtPriceAmount.Text / POS.DataGridViewPOS.CurrentRow.Cells(1).Value), 2)
                ModulePosTable.calculatePrice()
                total = POS.txtTotal.Text
                subtotal = POS.txtSubTotal.Text
                saleid = TB_GetSaleId
                unitprice = POS.DataGridViewPOS.CurrentRow.Cells(2).Value
                updatePrice(saleid, saleItemid, txtPriceAmount.Text, subtotal, total, unitprice)
            Else
                POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber(txtPriceAmount.Text, 2)
                POS.DataGridViewPOS.CurrentRow.Cells(2).Value = FormatNumber((txtPriceAmount.Text / POS.DataGridViewPOS.CurrentRow.Cells(1).Value), 2)
                ModulePosTable.calculatePrice()
            End If

        End If
        POS.DataGridViewPOS.CurrentRow.DefaultCellStyle.ForeColor = Color.Orange

        Me.Close()
    End Sub
End Class