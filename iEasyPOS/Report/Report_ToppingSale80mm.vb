Public Class Report_ToppingSale80mm
    Private Sub Report_ToppingSale80mm_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        LabelTimeOpen.Text = Convert.ToDateTime(parameter1.Value).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        LabelTimeClose.Text = Convert.ToDateTime(parameter2.Value).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class