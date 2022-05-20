Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters

Public Class ReportDaysCategoryGroup
    Public DateTimeOpenShift As String = ModuleShift.DateOpen
    Public DateTimeCloseShift As String = ModuleShift.DateClose

    Private Sub ReportDaysCategoryGroup_ParametersRequestBeforeShow(sender As Object, e As ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        parameter1.Value = DateTimeOpenShift
        parameter2.Value = DateTimeCloseShift
    End Sub

    Private Sub XrLabel19_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel19.BeforePrint
        XrLabel19.Text = Convert.ToDateTime(DateTimeOpenShift).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub

    Private Sub XrLabel20_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel20.BeforePrint
        XrLabel20.Text = Convert.ToDateTime(DateTimeCloseShift).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub
    Public Shadows QrThai As Decimal = 0.00
    Public Shadows QrAlipay As Decimal = 0.00
    Public Shadows QrWechat As Decimal = 0.00
    Public Shadows CreditCard As Decimal = 0.00
    Public Shared totalcash As Decimal = 0.00
    Private Sub ReportDaysCategoryGroup_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId=16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
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
Where Sale.Active = 1  And Sale.SaleDate BETWEEN'" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")

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

        LabelTableTotal.Text = FormatNumber(totalcash, 2)
        TotalQrThai.Text = FormatNumber(QrThai, 2)
        TotalAlipay.Text = FormatNumber(QrAlipay, 2)
        TotalQrWechat.Text = FormatNumber(QrWechat, 2)
        TotalCreditCard.Text = FormatNumber(CreditCard, 2)
        TotalPaymentDetail.Text = FormatNumber(totalcash + QrThai + QrAlipay + QrWechat + CreditCard, 2)


        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        Dim SumSale As DataTable = executesql("select SUM(Subtotal) as Subtotal from sale where SaleDate BETWEEN  '" & DateTimeOpenShift & "' AND  '" & DateTimeCloseShift & "' and Active = 1")

        If IsDBNull(SumSale(0)("Subtotal")) Then
            txtGrossale.Text = "0"
        Else

            If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
                txtWithdraw.Text = FormatNumber("0", 2)
                txtGrossale.Text = FormatNumber(CDbl(SumSale(0)("Subtotal")) - (QrThai + QrAlipay + QrWechat + CreditCard), 2)
                txtTax.Text = FormatNumber(((SumSale(0)("Subtotal") * 7) / 107), 2)
            Else
                txtWithdraw.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
                txtGrossale.Text = FormatNumber(CDbl(SumSale(0)("Subtotal")) - CDbl(sum_withDraw(0)("WithdrawAmount")) - (QrThai + QrAlipay + QrWechat + CreditCard), 2)
                txtTax.Text = FormatNumber(((SumSale(0)("Subtotal") * 7) / 107), 2)
            End If

        End If



    End Sub

    Private Sub XrLabel30_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel30.BeforePrint
        XrLabel30.Text = FormatNumber((totalcash + QrThai + QrAlipay + QrWechat + CreditCard), 2)
    End Sub

    Private Sub XrLabel31_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel31.BeforePrint
        XrLabel31.Text = FormatNumber((QrThai + QrAlipay + QrWechat + CreditCard), 2)
    End Sub
End Class