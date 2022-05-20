Public Class Report_WithdrawMoney
    Private Sub XrTableCell18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell18.BeforePrint

    End Sub

    Private Sub XrTableCell10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint
        Try
            XrTableCell10.Text = Convert.ToDateTime(XrTableCell10.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception

        End Try

    End Sub
End Class