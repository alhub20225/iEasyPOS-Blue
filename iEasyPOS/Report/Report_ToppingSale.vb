Public Class Report_ToppingSale
    Private Sub Report_ToppingSale_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        LabelTimeOpen.Text = Convert.ToDateTime(Parameter1.Value).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        LabelTimeClose.Text = Convert.ToDateTime(Parameter2.Value).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class