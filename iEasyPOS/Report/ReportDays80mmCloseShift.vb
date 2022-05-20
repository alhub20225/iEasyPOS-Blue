Public Class ReportDays80mmCloseShift
    Public DateTimeOpenShift As String = ""
    Public DateTimeCloseShift As String = ""
    Dim Ds As New DataSale


    Private Sub TxtBranchName_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TxtBranchName.BeforePrint
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        If Baranch_name.Rows.Count = 0 Then
            TxtBranchName.Text = ""
        Else
            TxtBranchName.Text = Baranch_name(0)("BranchName")
        End If


        Ds = CalculateSale(DateTimeOpenShift, DateTimeCloseShift)
        txtDiscount.Text = FormatNumber(Ds.totalDiscount,)
        totalAFTER_discount.Text = FormatNumber(Ds.Allsale, 2)
        txtwithDraw.Text = FormatNumber(Ds.totalPayout, 2)
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