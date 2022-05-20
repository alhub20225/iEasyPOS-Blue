Imports System.Drawing.Printing
Public Class Report_CustomerSale80
    Private Sub TableCell11_BeforePrint(sender As Object, e As PrintEventArgs) Handles tableCell11.BeforePrint
        Try
            tableCell11.Text = Convert.ToDateTime(tableCell11.Text).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Catch ex As Exception

        End Try

    End Sub
End Class