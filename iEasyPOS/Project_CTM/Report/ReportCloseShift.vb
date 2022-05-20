Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class ReportCloseShift
    Public Shared TotalNetSale As Decimal = 0.00
    Public Shared PercentDc As Decimal = 0.00
    Public Shared BathDC As Decimal = 0.00
    Public Shared Tax As Decimal = 0.00
    Public Shared _cultureEnInfo As New Globalization.CultureInfo("th-TH")
    Public Shared dateFromDBCloseShift As DateTime
    Public Shared dateFromDBOpenShift As DateTime
    Public Shared Userin As String
    Public Shared UserOut As String
    Public Shared Change As Decimal = 0.00
    Public Shared OverShort As Decimal = 0.00
    Public Shared CashInDrawer As Decimal = 0.00
    Public Shared QrThai As Decimal = 0.00
    Public Shared QrAlipay As Decimal = 0.00
    Public Shared QrWechat As Decimal = 0.00
    Public Shared CreditCard As Decimal = 0.00
    Public Shared totalcash As Decimal = 0.00
    Public Shared AcmountDC As Decimal = 0.00
    Public Shared Withdraw As Decimal = 0.00
    Dim DateTimeOpenShift As String = ModuleShift.DateOpen
    'Dim DateTimeOpenShift As String = "2561-11-06 01:00:41"
    Dim DateTimeCloseShift As String = ModuleShift.DateClose
    'Dim DateTimeCloseShift As String = "2561-11-06 23:59:16"

    Private Sub ReportCloseShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        'Open shift 
        Dim TerminalName As String = Environment.MachineName
        Dim Dataset1 As New DataSet
        Dataset1.DataSetName = "DataSet1"
        Dim Datatable1 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025 FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE')")
        dateFromDBOpenShift = Convert.ToDateTime(Datatable1(0)("DateTimeOpen"), _cultureEnInfo)
        Change = Datatable1(0)("MoneyCash")
        'Sum Total Net Sale
        'Dim DateUse As String
        'Dim DateOpen As DateTime = Frm_CloseShift.labeldatetimeopen.Text
        'DateUse = DateOpen.ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserNameOpenShift As String = Frm_CloseShift.LabelUseropenshift.Text
        Dim DateClose As String = Now.ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim SumTotalNetSale As Decimal = 0.00
        Dim Datatable2 As DataTable = executesql("SELECT Sale.SubTotal FROM Sale WHERE Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1")
        If IsNothing(Datatable2) Then
        ElseIf Datatable2.Rows.Count < 0 Then
        ElseIf Datatable2.Rows.Count > 0 Then

            For i As Integer = 0 To Datatable2.Rows.Count - 1
                TotalNetSale += Datatable2(i)("SubTotal")
            Next
        End If
        'Branch Name 
        Dim Datatable3 As DataTable = executesql("SELECT BranchName FROM Branch")
        'Close Shift
        Dim Datatable4 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE')")
        'Over Short
        CashInDrawer += Datatable4(0)("B1000") * 1000
        CashInDrawer += Datatable4(0)("B500") * 500
        CashInDrawer += Datatable4(0)("B100") * 100
        CashInDrawer += Datatable4(0)("B50") * 50
        CashInDrawer += Datatable4(0)("B20") * 20
        CashInDrawer += Datatable4(0)("C10") * 10
        CashInDrawer += Datatable4(0)("C5") * 5
        CashInDrawer += Datatable4(0)("C2") * 2
        CashInDrawer += Datatable4(0)("C1") * 1
        CashInDrawer += Datatable4(0)("C05") * 0.5
        CashInDrawer += Datatable4(0)("C025") * 0.25
        'MsgBox(CashInDrawer)
        dateFromDBCloseShift = Convert.ToDateTime(Datatable4(0)("DateTimeOpen"), _cultureEnInfo)
        'UserName IN
        Dim Datatable5 As DataTable = executesql("SELECT FristName FROM Users WHERE UserId =" & Datatable1(0)("UserId") & "")
        Userin = Datatable5(0)("FristName")
        'UserName OUT
        Dim Datatable6 As DataTable = executesql("SELECT FristName FROM Users WHERE UserId =" & Datatable4(0)("UserId") & "")
        'DisCount Percent and BathDC and Tax
        Dim Datatable7 As DataTable = executesql("SELECT Sum(SaleItem.PercentDC) As PercentDc,Sum(SaleItem.BahtDC) As BahtDC,
(Select Sum(Sale.AmountDC) from Sale where Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1) As AmountDC,
(Select Sum(Sale.TaxAmt) from Sale where Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1) As Tax
FROM SaleItem inner join sale on(Sale.SaleId = SaleItem.SaleId) WHERE SaleItem.insertDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1")
        If Datatable7.Rows.Count > 0 Then
            If IsDBNull(Datatable7(0)("AmountDC")) Then
                AcmountDC = 0
                PercentDc = 0
                Tax = 0
            Else
                AcmountDC = Datatable7(0)("AmountDC")
                PercentDc = Datatable7(0)("PercentDC")
                BathDC = Datatable7(0)("BahtDC")
                Tax = Datatable7(0)("Tax")
            End If
        End If
        'If IsNothing(Datatable7) Then
        'ElseIf Datatable7.Rows.Count = 0 Then
        'ElseIf Datatable7.Rows.Count > 1 Then
        'PercentDc = Datatable7(0)("PercentDC")

        '    For j As Integer = 0 To Datatable7.Rows.Count - 1
        '        PercentDc += Datatable7(j)("PercentDC")
        '        BathDC += Datatable7(j)("BahtDC")
        '        Tax += Datatable7(j)("Tax")
        '    Next
        'End If
        'TotalQrThai
        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalCash
        Dim Datatable12 As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)
) As SubTotal
 from  Sale 
Where Sale.Active = 1  And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")

        If Datatable8.Rows.Count > 0 Then
            If IsDBNull(Datatable8(0)("SubTotal")) Then
                QrThai = 0
            Else
                QrThai = Datatable8(0)("SubTotal")
            End If
        End If
        If Datatable9.Rows.Count > 0 Then
            If IsDBNull(Datatable9(0)("SubTotal")) Then
                QrAlipay = 0
            Else
                QrAlipay = Datatable9(0)("SubTotal")
            End If
        End If
        If Datatable10.Rows.Count > 0 Then
            If IsDBNull(Datatable10(0)("SubTotal")) Then
                QrWechat = 0
            Else
                QrWechat = Datatable10(0)("SubTotal")
            End If
        End If
        If Datatable11.Rows.Count > 0 Then
            If IsDBNull(Datatable11(0)("SubTotal")) Then
                CreditCard = 0
            Else
                CreditCard = Datatable11(0)("SubTotal")
            End If
        End If
        If Datatable12.Rows.Count > 0 Then
            If IsDBNull(Datatable12(0)("SubTotal")) Then
                totalcash = 0
            Else
                totalcash = Datatable12(0)("SubTotal")
            End If
        End If

        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            txtWithdraw.Text = FormatNumber("0", 2)
            Withdraw = 0.00
        Else
            txtWithdraw.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
            Withdraw = sum_withDraw(0)("WithdrawAmount")
        End If
        UserOut = Datatable6(0)("FristName")
        Dataset1.Tables.Add(Datatable1)
        Dataset1.Tables.Add(Datatable2)
        Dataset1.Tables.Add(Datatable3)
        Dataset1.Tables.Add(Datatable4)
        Datatable1.TableName = "OpenCloseShift"
        Datatable2.TableName = "SumNetSale"
        Datatable3.TableName = "Branch"
        Datatable4.TableName = "DataCloseshift"
        DataSource = Dataset1
    End Sub

    Private Sub XrLabel8_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel8.BeforePrint
        XrLabel8.Text = FormatNumber(TotalNetSale, 2)
    End Sub

    Private Sub XrLabel12_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateCloseShift.BeforePrint
        LabelDateCloseShift.Text = DateTimeCloseShift
    End Sub
    Private Sub LabelDateOpenShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateOpenShift.BeforePrint
        LabelDateOpenShift.Text = DateTimeOpenShift
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateSale.BeforePrint
        LabelDateSale.Text = getdate(dateFromDBOpenShift)
    End Sub
    Private Sub XrLabel13_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserIn.BeforePrint
        LabelUserIn.Text = Userin
    End Sub
    Private Sub LabelUserOut_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserOut.BeforePrint
        LabelUserOut.Text = UserOut
    End Sub

    Private Sub LabelTableTotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTableTotal.BeforePrint
        LabelTableTotal.Text = FormatNumber(totalcash, 2)
    End Sub

    Private Sub LabelTotalOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalOrder.BeforePrint
        LabelTotalOrder.Text = FormatNumber(TotalNetSale, 2)
    End Sub

    Private Sub LabelTotalDiscount_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalDiscount.BeforePrint
        LabelTotalDiscount.Text = FormatNumber(AcmountDC + PercentDc + BathDC, 2)
    End Sub

    Private Sub LabelTotalExcTax_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalExcTax.BeforePrint
        LabelTotalExcTax.Text = FormatNumber(TotalNetSale - Tax, 2)
    End Sub
    Private Sub LabelTax_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTax.BeforePrint
        LabelTax.Text = FormatNumber(((TotalNetSale * 7) / 107), 2)
    End Sub

    Private Sub LabelRealSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelRealSale.BeforePrint
        LabelRealSale.Text = FormatNumber(TotalNetSale, 2)
    End Sub
    Private Sub LabelTotalOfSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalOfSale.BeforePrint
        LabelTotalOfSale.Text = FormatNumber(TotalNetSale, 2)
    End Sub
    Private Sub LabelChange_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelChange.BeforePrint
        LabelChange.Text = FormatNumber(Change, 2)
    End Sub

    Private Sub XrLabel51_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelOverShort.BeforePrint
        OverShort = CashInDrawer - (Change + totalcash - Withdraw)
        'MsgBox(TotalNetSale.ToString + "-" + Change.ToString + "-" + CashInDrawer.ToString)
        LabelOverShort.Text = FormatNumber(OverShort, 2)
    End Sub
    Private Sub LabelSaleCash_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelSaleCash.BeforePrint
        LabelSaleCash.Text = FormatNumber(totalcash, 2)
    End Sub

    Private Sub TotalQrThai_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalQrThai.BeforePrint
        TotalQrThai.Text = FormatNumber(QrThai, 2)
    End Sub

    Private Sub TotalAlipay_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalAlipay.BeforePrint
        TotalAlipay.Text = FormatNumber(QrAlipay, 2)
    End Sub

    Private Sub TotalQrWechat_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalQrWechat.BeforePrint
        TotalQrWechat.Text = FormatNumber(QrWechat, 2)
    End Sub

    Private Sub TotalCreditCard_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalCreditCard.BeforePrint
        TotalCreditCard.Text = FormatNumber(CreditCard, 2)
    End Sub

    Private Sub TotalPaymentDetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalPaymentDetail.BeforePrint
        TotalPaymentDetail.Text = FormatNumber(totalcash + QrThai + QrAlipay + QrWechat + CreditCard, 2)
    End Sub
End Class