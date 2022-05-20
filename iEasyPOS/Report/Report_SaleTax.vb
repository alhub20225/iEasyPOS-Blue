Public Class Report_SaleTax

    Private Sub XrLabel2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        Try
            XrLabel2.Text = Convert.ToDateTime(XrLabel2.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrLabel21_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel21.BeforePrint
        Try
            XrLabel21.Text = Convert.ToDateTime(XrLabel21.Text).ToString("MMMM", New System.Globalization.CultureInfo("th-TH")) + " " + Convert.ToDateTime(XrLabel21.Text).ToString("yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception
        End Try
    End Sub
End Class