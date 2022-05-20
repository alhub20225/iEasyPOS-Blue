
Public Class ReportDaySale
    Private Sub XrLabel19_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel19.BeforePrint
        Try
            XrLabel19.Text = Convert.ToDateTime(XrLabel19.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception

        End Try

    End Sub
End Class