Public Class Frm_ReportDaysCateGroup
    Private Sub Frm_ReportDaysCateGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
         ProgressPanel1.Hide()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim report As New ReportDaysCategoryGroup
        report.parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        report.parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        report.DateTimeOpenShift = report.parameter1.Value
        report.DateTimeCloseShift = report.parameter2.Value
        report.XrLabel2.Text = "ตั้งแต่ :"
        report.XrLabel21.Text = "ถึง :"
        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
        ProgressPanel1.Hide()
    End Sub

    Private Sub Btn_Search_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_Search.MouseDown
        ProgressPanel1.Show()
        ProgressPanel1.BringToFront()
    End Sub
End Class