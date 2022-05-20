Imports DevExpress.XtraReports.Parameters
Public Class Report_Payment
    Private Sub XrLabel7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel7.BeforePrint
        Try
            XrLabel7.Text = Convert.ToDateTime(XrLabel7.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrLabel8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel8.BeforePrint
        Try
            XrLabel8.Text = Convert.ToDateTime(XrLabel8.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception
        End Try
    End Sub

End Class