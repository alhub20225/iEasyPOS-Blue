Public Class ReportSaleNumberDetail
    Private Sub XrLabel3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        If XrLabel3.Text <> "" Then
            XrLabel3.Text = Convert.ToDateTime(XrLabel3.Text).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        End If

    End Sub
End Class