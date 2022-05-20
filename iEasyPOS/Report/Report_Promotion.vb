Public Class Report_Promotion
    Private Sub TableCell8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tableCell8.BeforePrint
        tableCell8.Text = Convert.ToDateTime(tableCell8.Text).ToString("dd-mm-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class