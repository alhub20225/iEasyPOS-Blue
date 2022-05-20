Public Class Frm_ReportTopSale
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim report As New ReportTopSaleMail
        report.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        report.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
        ProgressPanel1.Hide()
    End Sub

    Private Sub Frm_ReportTopSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        ProgressPanel1.Hide()
    End Sub

    Private Sub Btn_Search_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_Search.MouseDown
        ProgressPanel1.Show()
        ProgressPanel1.BringToFront()
    End Sub
End Class