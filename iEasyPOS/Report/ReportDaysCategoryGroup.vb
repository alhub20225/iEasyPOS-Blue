Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters

Public Class ReportDaysCategoryGroup
    Public DateTimeOpenShift As String = ""
    Public DateTimeCloseShift As String = ""
    Dim Ds As New DataSale

    Private Sub ReportDaysCategoryGroup_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        Ds = CalculateSale(DateTimeOpenShift, DateTimeCloseShift)
        txtDiscount.Text = FormatNumber(Ds.totalDiscount,)
        totalAFTER_discount.Text = FormatNumber(Ds.Allsale, 2)
        txtWithdraw.Text = FormatNumber(Ds.totalPayout, 2)
        totalNON_cash.Text = FormatNumber(Ds.totalNonCash, 2)
        txtGrossale.Text = FormatNumber(Ds.finalCash, 2)

    End Sub

    Private Sub XrLabel19_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel19.BeforePrint
        XrLabel19.Text = Convert.ToDateTime(DateTimeOpenShift).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub

    Private Sub XrLabel20_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel20.BeforePrint
        XrLabel20.Text = Convert.ToDateTime(DateTimeCloseShift).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub

End Class