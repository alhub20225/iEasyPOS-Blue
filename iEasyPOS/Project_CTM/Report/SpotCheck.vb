Imports System.Drawing.Printing

Public Class SpotCheck
    Public Shared TotalNetSale As Decimal = 0.00
    Public Shared PercentDc As Decimal = 0.00
    Public Shared BathDC As Decimal = 0.00
    Public Shared Tax As Decimal = 0.00
    Public Shadows QrThai As Decimal = 0.00
    Public Shadows QrAlipay As Decimal = 0.00
    Public Shadows QrWechat As Decimal = 0.00
    Public Shadows CreditCard As Decimal = 0.00
    Public Shared totalcash As Decimal = 0.00
    Public Shared AcmountDC As Decimal = 0.00
    Dim DTS As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
    Dim DTE As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

    Private Sub SpotCheck_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Try
            Dim SumTotalNetSale As Decimal = 0.00
            Dim Datatable2 As DataTable = executesql("SELECT SubTotal FROM Sale WHERE SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Active=1")
        If Datatable2.Rows.Count = 0 Then
                Exit Sub
            ElseIf Datatable2.Rows.Count > 0 Then

            For i As Integer = 0 To Datatable2.Rows.Count - 1
                TotalNetSale += Datatable2(i)("SubTotal")
            Next
        End If

        Dim Datatable7 As DataTable = executesql("SELECT Sum(SaleItem.PercentDC) As PercentDc,Sum(SaleItem.BahtDC) As BahtDC,
(Select Sum(Sale.AmountDC) from Sale where Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Sale.Active=1
) As AmountDC,
(Select Sum(Sale.TaxAmt) from Sale where Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Sale.Active=1
) As Tax
FROM SaleItem inner join sale on(Sale.SaleId = SaleItem.SaleId) WHERE SaleItem.insertDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Sale.Active=1")
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

        'TotalQrThai
        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        Where Sale.Active = 1  And PaymentType.PaymentId= 16 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'")

        Dim Datatable12 As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
    ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'),0)-
    ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'),0)-
    ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'),0)-
    ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'),0)
    ) As SubTotal
        from  Sale 
    Where Sale.Active = 1  And Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "'")
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

            Datatable2.TableName = "SumNetSale"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub XrLabel8_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel8.BeforePrint
        XrLabel8.Text = FormatNumber(TotalNetSale, 2)
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateSale.BeforePrint
        'LabelDateSale.Text = getdate(DTS)
        LabelDateSale.Text = Convert.ToDateTime(Now).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
    End Sub



    Private Sub LabelTableTotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTableTotal.BeforePrint
        LabelTableTotal.Text = FormatNumber(totalcash, 2)
    End Sub

    Private Sub LabelTotalOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalOrder.BeforePrint

        Dim Datatable2 As DataTable = executesql("SELECT SUM(SubTotal) As SubTotal FROM Sale WHERE SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Active=1")
        If IsDBNull(Datatable2(0)("SubTotal")) Then
            Exit Sub
        Else
            LabelTotalOrder.Text = FormatNumber(Datatable2(0)("SubTotal"), 2)
        End If
    End Sub

    Private Sub LabelTotalDiscount_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalDiscount.BeforePrint
        LabelTotalDiscount.Text = FormatNumber(AcmountDC + PercentDc + BathDC, 2)
    End Sub

    Private Sub LabelTotalExcTax_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalExcTax.BeforePrint
        LabelTotalExcTax.Text = FormatNumber(TotalNetSale - Tax, 2)
    End Sub
    Private Sub LabelTax_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTax.BeforePrint
        LabelTax.Text = FormatNumber(Tax, 2)
    End Sub

    Private Sub LabelRealSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelRealSale.BeforePrint
        LabelRealSale.Text = FormatNumber(TotalNetSale, 2)
    End Sub
    Private Sub LabelTotalOfSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalOfSale.BeforePrint
        LabelTotalOfSale.Text = FormatNumber(TotalNetSale, 2)
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

    Private Sub LabelTotalDeleteSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalDeleteSale.BeforePrint
        Dim DT As DataTable = executesql("select sum(Sale.SubTotal) as SubTotal  from Sale WHERE Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Sale.Active = 2")
        If IsDBNull(DT(0)("SubTotal")) Then
            LabelTotalDeleteSale.Text = 0.00
        Else
            LabelTotalDeleteSale.Text = FormatNumber(DT(0)("SubTotal"), 2)
        End If
    End Sub


    Private Sub TotalPaymentDetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalPaymentDetail.BeforePrint
        TotalPaymentDetail.Text = FormatNumber(totalcash + QrAlipay + QrThai + QrWechat + CreditCard, 2)
    End Sub

    Private Sub XrLabel1_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel1.BeforePrint
        Dim Datatable3 As DataTable = executesql("SELECT BranchName FROM Branch")
        XrLabel1.Text = Datatable3(0)("BranchName")
    End Sub

    Private Sub XrLabel5_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel5.BeforePrint
        XrLabel5.Text = Environment.MachineName
    End Sub
End Class