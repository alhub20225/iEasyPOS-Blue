Public Class ReportSaleNumber

    Private Sub XrTableCell22_BeforePrint_1(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell22.BeforePrint
        Try
            XrTableCell22.Text = Convert.ToDateTime(XrTableCell22.Text).ToString("dd/MM/yyyy HH:MM:ss", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception

        End Try

    End Sub
End Class