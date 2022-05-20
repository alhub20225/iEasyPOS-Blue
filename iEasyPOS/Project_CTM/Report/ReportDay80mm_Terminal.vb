Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters
Public Class ReportDay80mm_Terminal
    Public Shadows QrThai As Decimal = 0.00
    Public Shadows QrAlipay As Decimal = 0.00
    Public Shadows QrWechat As Decimal = 0.00
    Public Shadows CreditCard As Decimal = 0.00
    Public Shared totalcash As Decimal = 0.00

    Dim Date_start As String = Convert.ToDateTime(Frm_ReportDay80mm_Terminal.DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
    Dim Date_End As String = Convert.ToDateTime(Frm_ReportDay80mm_Terminal.DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    Private Sub ReportDays80mm_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        'Date_start = "2561-10-31 07:54:00.000"
        'TotalQrThai
        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")
        'TotalCash
        'Dim Datatable12 As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'),0)-
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'),0)-
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'),0)-
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'),0)
        ') As SubTotal
        ' from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        'Where Sale.Active = 1  And PaymentType.PaymentId = 9 And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")
        Dim Datatable12 As DataTable = executesql("Select  sum(SubTotal) As SubTotal from sale   Where sale.Active = 1 And SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")
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
                totalcash = totalcash - CreditCard - QrWechat - QrAlipay - QrThai
            End If
        End If
    End Sub

    Private Sub ReportDays80mm_ParametersRequestBeforeShow(sender As Object, e As ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        'Parameter1.Value = Convert.ToDateTime(Frm_ReportDay80mm_Terminal.DTP1.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))

    End Sub
    Dim a As Decimal = 0
    Dim AmtDC As Decimal = 0
    Dim Total As Decimal = 0
    Dim SubTotal As Decimal = 0
    Dim withdraw As Decimal = 0
    Private Sub TxtBranchName_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TxtBranchName.BeforePrint
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        If Baranch_name.Rows.Count = 0 Then
            TxtBranchName.Text = ""
        Else
            TxtBranchName.Text = Baranch_name(0)("BranchName")
        End If

    End Sub
    Private Sub txt_gloss_sale_BeforePrint(sender As Object, e As PrintEventArgs) Handles txt_gloss_sale.BeforePrint

        Dim AmountDC As DataTable = executesql("SELECT Sum(Sale.AmountDC) AS AmountDC FROM SALE WHERE Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' And Sale.Active=1")
        Dim Stt As DataTable = executesql("select SUM(sale.Total) AS Total from Sale WHERE Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND Sale.Active=1")
        Dim St As Double = 0
        Dim Adc As Double = 0
        If IsDBNull(Stt(0)("Total")) Then
            St = 0
        Else
            St = Stt(0)("Total")
            Total = Stt(0)("Total")
        End If

        If IsDBNull(AmountDC(0)("AmountDC")) Then
            sum_spe_dc.Text = 0.00
            Adc = 0
        Else
            sum_spe_dc.Text = FormatNumber(AmountDC(0)("AmountDC"), 2)
            Adc = AmountDC(0)("AmountDC")
            'AmtDC = AmountDC(0)("AmountDC")
        End If
        txt_gloss_sale.Text = FormatNumber(St, 2)
    End Sub

    Private Sub XrLabel18_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel18.BeforePrint
        Dim AmountDC As DataTable = executesql("SELECT Sum(AmountDC) AS AmountDC FROM SALE WHERE SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND Active= 1 And Sale.TerminalName='" & Frm_ReportDay80mm_Terminal.SaleTerminalName & "'")
        If IsDBNull(AmountDC(0)("AmountDC")) Then
            Exit Sub
        Else
            Dim SelectDC As DataTable = executesql("select SUM(SaleItem.PercentDC + SaleItem.BahtDC) AS DC from SaleItem inner join Sale on(Sale.SaleId = SaleItem.SaleId)  WHERE SaleItem.InsertDate BETWEEN  '" & Date_start & "' AND '" & Date_End & "' AND Sale.Active= 1 and SaleItem.TerminalName='" & Frm_ReportDay80mm_Terminal.SaleTerminalName & "'")
            If IsDBNull(SelectDC(0)("DC")) Then
                XrLabel18.Text = FormatNumber(AmountDC(0)("AmountDC"), 2)
                AmtDC = FormatNumber(AmountDC(0)("AmountDC"), 2)
            Else
                XrLabel18.Text = FormatNumber(AmountDC(0)("AmountDC") + SelectDC(0)("DC"), 2)
                AmtDC = FormatNumber(AmountDC(0)("AmountDC") + SelectDC(0)("DC"), 2)
            End If
        End If
    End Sub

    Private Sub XrLabel16_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel16.BeforePrint
        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate = '" & Date_start & "'")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            XrLabel16.Text = FormatNumber(0, 2)
        Else
            XrLabel16.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
            a = sum_withDraw(0)("WithdrawAmount")
        End If
    End Sub

    Private Sub XrLabel21_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel21.BeforePrint
        XrLabel21.Text = FormatNumber((Total - AmtDC) - a, 2)
    End Sub

End Class