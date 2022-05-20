Imports System.Drawing.Printing

Public Class Report_TaxSale

    Private Sub XrLabel2_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel2.BeforePrint
        If XrLabel2.Text <> "" Then
            XrLabel2.Text = Convert.ToDateTime(XrLabel2.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        End If

    End Sub

    Private Sub XrLabel32_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel32.BeforePrint
        XrLabel32.Text += 1
    End Sub
End Class