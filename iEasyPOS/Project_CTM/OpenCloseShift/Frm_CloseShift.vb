Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class Frm_CloseShift
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LbDate.Text = Now.ToShortDateString
        Lbtime.Text = TimeOfDay
    End Sub
    Private Sub Frm_CloseShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TxtAmount Clear 
        'TxtAmount1000.Text = 0
        'TxtAmount500.Text = 0
        'TxtAmount100.Text = 0
        'TxtAmount50.Text = 0
        'TxtAmount20.Text = 0
        'TxtAmount10.Text = 0
        'TxtAmount5.Text = 0
        'TxtAmount2.Text = 0
        'TxtAmount1.Text = 0
        'TxtAmount050.Text = 0
        'TxtAmount025.Text = 0
        'TxtCash Clear 
        'TxtCash1000.Text = 0
        'TxtCash500.Text = 0
        'TxtCash100.Text = 0
        'TxtCash50.Text = 0
        'TxtCash20.Text = 0
        'TxtCash10.Text = 0
        'TxtCash5.Text = 0
        'TxtCash2.Text = 0
        'TxtCash1.Text = 0
        'TxtCash050.Text = 0
        'TxtCash025.Text = 0
        'TxtNetSale.Text = 0
        'TxtSumSale.Text = 0
        TxtChangeMoney.Text = 0
        ModuleShift.LoadUserName(Frm_Login.UserId)
        Timer1.Start()
        ModuleShift.LoadDataOpenShift()
        ModuleShift.LoadNetSale()
    End Sub
    Private Sub BtnCloseShift_Click(sender As Object, e As EventArgs) Handles BtnCloseShift.Click
        'Close Shift
        Dim Ans As Integer = MsgBox("คุณแน่ใจว่าต้องการปิดการขาย ?", vbOKCancel, "เปิดกะ")
        If Ans = vbOK Then
            Dim Userid As Integer = Frm_Login.UserId
            Dim Money As Decimal
            If TxtMoney.Text = "" Then
                MsgBox("กรุณาใส่เงินที่นับได้", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
                'Money = 0.00
            ElseIf TxtMoney.Text <> "" Then
                Money = TxtMoney.Text
            End If
            If ModuleShift.CloseShift(Userid, Money) = "Not pass" Then
                Exit Sub
            Else
                ModuleShift.SendEmailExportPDF()

                Exit Sub
            End If
        Else
        End If
    End Sub
    Function CheackVarchar(text)
        Select Case Asc(text.KeyChar)
            Case 48 To 57 'ตัวเลข 0-9
            Case Keys.Back 'Backspace
            Case Else
                text.Handled = True
        End Select
    End Function
    Private Sub TxtAmount1000_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount1000.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount500_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount500.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount100_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount100.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount50.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount20.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount10.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount5.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount2.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount1.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount050_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount050.KeyPress
        CheackVarchar(e)
    End Sub
    Private Sub TxtAmount025_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount025.KeyPress
        CheackVarchar(e)
    End Sub
    Public MoneySend As Decimal = 0.00
    Public Amount As String = ""
    Private Sub TxtAmount1000_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount1000.TextChanged
        Amount = TxtAmount1000.Text
        TxtCash1000.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 1000.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount500_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount500.TextChanged
        Amount = TxtAmount500.Text
        TxtCash500.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 500.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount100_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount100.TextChanged
        Amount = TxtAmount100.Text
        TxtCash100.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 100.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount50_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount50.TextChanged
        Amount = TxtAmount50.Text
        TxtCash50.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 50.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount20_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount20.TextChanged
        Amount = TxtAmount20.Text
        TxtCash20.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 20.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount10_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount10.TextChanged
        Amount = TxtAmount10.Text
        TxtCash10.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 10.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub

    Private Sub TxtAmount5_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount5.TextChanged
        Amount = TxtAmount5.Text
        TxtCash5.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 5.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount2_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount2.TextChanged
        Amount = TxtAmount2.Text
        TxtCash2.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 2.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub

    Private Sub TxtAmount1_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount1.TextChanged
        Amount = TxtAmount1.Text
        TxtCash1.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 1.0))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub

    Private Sub TxtAmount050_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount050.TextChanged
        Amount = TxtAmount050.Text
        TxtCash050.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 0.5))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub TxtAmount025_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount025.TextChanged
        Amount = TxtAmount025.Text
        TxtCash025.Text = Convert.ToString(ModuleShift.CalculateCash(Amount, 0.25))
        TxtMoney.Text = ModuleShift.SumTotalCash
        MoneySend = CDbl(TxtMoney.Text)
        ModuleShift.CalculateNetSale(MoneySend, TxtChangeMoney.Text)
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'TxtAmount Clear 
        TxtAmount1000.Text = 0
        TxtAmount500.Text = 0
        TxtAmount100.Text = 0
        TxtAmount50.Text = 0
        TxtAmount20.Text = 0
        TxtAmount10.Text = 0
        TxtAmount5.Text = 0
        TxtAmount2.Text = 0
        TxtAmount1.Text = 0
        TxtAmount050.Text = 0
        TxtAmount025.Text = 0
        'TxtCash Clear 
        TxtCash1000.Text = 0
        TxtCash500.Text = 0
        TxtCash100.Text = 0
        TxtCash50.Text = 0
        TxtCash20.Text = 0
        TxtCash10.Text = 0
        TxtCash5.Text = 0
        TxtCash2.Text = 0
        TxtCash1.Text = 0
        TxtCash050.Text = 0
        TxtCash025.Text = 0
        'Clear Money
        TxtMoney.Text = 0
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public TxtAmountName As String = ""
    Private Sub TxtAmount1000_Enter(sender As Object, e As EventArgs) Handles TxtAmount1000.Enter
        TxtAmountName = "1000"
    End Sub

    Private Sub TxtAmount500_Enter(sender As Object, e As EventArgs) Handles TxtAmount500.Enter
        TxtAmountName = "500"
    End Sub

    Private Sub TxtAmount100_Enter(sender As Object, e As EventArgs) Handles TxtAmount100.Enter
        TxtAmountName = "100"
    End Sub
    Private Sub TxtAmount50_Enter(sender As Object, e As EventArgs) Handles TxtAmount50.Enter
        TxtAmountName = "50"
    End Sub
    Private Sub TxtAmount20_Enter(sender As Object, e As EventArgs) Handles TxtAmount20.Enter
        TxtAmountName = "20"
    End Sub
    Private Sub TxtAmount10_Enter(sender As Object, e As EventArgs) Handles TxtAmount10.Enter
        TxtAmountName = "10"
    End Sub
    Private Sub TxtAmount5_Enter(sender As Object, e As EventArgs) Handles TxtAmount5.Enter
        TxtAmountName = "5"
    End Sub
    Private Sub TxtAmount2_Enter(sender As Object, e As EventArgs) Handles TxtAmount2.Enter
        TxtAmountName = "2"
    End Sub
    Private Sub TxtAmount1_Enter(sender As Object, e As EventArgs) Handles TxtAmount1.Enter
        TxtAmountName = "1"
    End Sub
    Private Sub TxtAmount050_Enter(sender As Object, e As EventArgs) Handles TxtAmount050.Enter
        TxtAmountName = "050"
    End Sub
    Private Sub TxtAmount025_Enter(sender As Object, e As EventArgs) Handles TxtAmount025.Enter
        TxtAmountName = "025"
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "0" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "0" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "0" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "0" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "0" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "0" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "0" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "0" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "0" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "0" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "0" '025
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "1" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "1" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "1" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "1" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "1" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "1" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "1" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "1" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "1" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "1" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "1" '025
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "2" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "2" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "2" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "2" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "2" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "2" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "2" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "2" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "2" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "2" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "2" '025
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "3" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "3" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "3" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "3" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "3" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "3" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "3" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "3" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "3" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "3" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "3" '025
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "4" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "4" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "4" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "4" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "4" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "4" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "4" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "4" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "4" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "4" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "4" '025
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "5" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "5" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "5" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "5" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "5" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "5" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "5" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "5" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "5" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "5" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "5" '025
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "6" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "6" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "6" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "6" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "6" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "6" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "6" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "6" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "6" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "6" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "6" '025
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "7" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "7" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "7" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "7" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "7" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "7" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "7" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "7" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "7" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "7" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "7" '025
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "8" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "8" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "8" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "8" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "8" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "8" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "8" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "8" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "8" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "8" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "8" '025
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If TxtAmountName = "1000" Then
            TxtAmount1000.Text += "9" '1000
        ElseIf TxtAmountName = "500" Then
            TxtAmount500.Text += "9" '500
        ElseIf TxtAmountName = "100" Then
            TxtAmount100.Text += "9" '100
        ElseIf TxtAmountName = "50" Then
            TxtAmount50.Text += "9" '50
        ElseIf TxtAmountName = "20" Then
            TxtAmount20.Text += "9" '20
        ElseIf TxtAmountName = "10" Then
            TxtAmount10.Text += "9" '10
        ElseIf TxtAmountName = "5" Then
            TxtAmount5.Text += "9" '5
        ElseIf TxtAmountName = "2" Then
            TxtAmount2.Text += "9" '2
        ElseIf TxtAmountName = "1" Then
            TxtAmount1.Text += "9" '1
        ElseIf TxtAmountName = "050" Then
            TxtAmount050.Text += "9" '050
        ElseIf TxtAmountName = "025" Then
            TxtAmount025.Text += "9" '025
        End If
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If TxtAmountName = "1000" Then
            Dim count_txt As Integer = TxtAmount1000.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount1000.Text.Substring(0, i)
            Next
            TxtAmount1000.Text = 0
            TxtAmount1000.Text = newtxt
        ElseIf TxtAmountName = "500" Then
            Dim count_txt As Integer = TxtAmount500.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount500.Text.Substring(0, i)
            Next
            TxtAmount500.Text = 0
            TxtAmount500.Text = newtxt
        ElseIf TxtAmountName = "100" Then
            Dim count_txt As Integer = TxtAmount100.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount100.Text.Substring(0, i)
            Next
            TxtAmount100.Text = 0
            TxtAmount100.Text = newtxt
        ElseIf TxtAmountName = "50" Then
            Dim count_txt As Integer = TxtAmount50.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount50.Text.Substring(0, i)
            Next
            TxtAmount50.Text = 0
            TxtAmount50.Text = newtxt
        ElseIf TxtAmountName = "20" Then
            Dim count_txt As Integer = TxtAmount20.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount20.Text.Substring(0, i)
            Next
            TxtAmount20.Text = 0
            TxtAmount20.Text = newtxt
        ElseIf TxtAmountName = "10" Then
            Dim count_txt As Integer = TxtAmount10.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount10.Text.Substring(0, i)
            Next
            TxtAmount10.Text = 0
            TxtAmount10.Text = newtxt
        ElseIf TxtAmountName = "5" Then
            Dim count_txt As Integer = TxtAmount5.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount5.Text.Substring(0, i)
            Next
            TxtAmount5.Text = 0
            TxtAmount5.Text = newtxt
        ElseIf TxtAmountName = "2" Then
            Dim count_txt As Integer = TxtAmount2.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount2.Text.Substring(0, i)
            Next
            TxtAmount2.Text = 0
            TxtAmount2.Text = newtxt
        ElseIf TxtAmountName = "1" Then
            Dim count_txt As Integer = TxtAmount1.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount1.Text.Substring(0, i)
            Next
            TxtAmount1.Text = 0
            TxtAmount1.Text = newtxt
        ElseIf TxtAmountName = "050" Then
            Dim count_txt As Integer = TxtAmount050.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount050.Text.Substring(0, i)
            Next
            TxtAmount050.Text = 0
            TxtAmount050.Text = newtxt
        ElseIf TxtAmountName = "025" Then
            Dim count_txt As Integer = TxtAmount025.TextLength
            Dim newtxt As String = ""
            Dim i As Integer = 0
            For i = 1 To (count_txt - 1) Step 1
                newtxt = TxtAmount025.Text.Substring(0, i)
            Next
            TxtAmount025.Text = 0
            TxtAmount025.Text = newtxt
        End If
    End Sub

    Private Sub TxtMoney_TextChanged(sender As Object, e As EventArgs) Handles TxtMoney.TextChanged
        TxtNetSale.Text = CDbl(TxtMoney.Text) - (CDbl(TxtChangeMoney.Text) + CDbl(TxtSumSale.Text) - CDbl(txtWithdraw.Text))
        TxtNetSale.Text = FormatNumber(TxtNetSale.Text, 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        open_cash.OpenCashdrawer()
    End Sub
End Class