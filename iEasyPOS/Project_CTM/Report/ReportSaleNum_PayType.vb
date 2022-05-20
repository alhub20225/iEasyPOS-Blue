Public Class ReportSaleNum_PayType
    Private Sub XrTableCell22_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell22.BeforePrint
        XrTableCell22.Text = Convert.ToDateTime(XrTableCell22.Text).ToString("dd/MM/yyyy HH:MM:ss", New System.Globalization.CultureInfo("en-US"))
    End Sub
End Class