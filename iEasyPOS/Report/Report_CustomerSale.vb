Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UserDesigner

Public Class Report_CustomerSale
    Private Sub TableCell11_BeforePrint(sender As Object, e As PrintEventArgs)
        Try
            tableCell11.Text = Convert.ToDateTime(tableCell11.Text).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Catch ex As Exception

        End Try

    End Sub

End Class