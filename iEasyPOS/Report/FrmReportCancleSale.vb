Public Class FrmReportCancleSale
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Report_CancleSale As New ReportCancleSale

        Report_CancleSale.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Report_CancleSale.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))

        Report_CancleSale.TxtStartDate.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_CancleSale.TxtEndDate.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_CancleSale.SqlDataSource1.Connection.ConnectionString = rptConStr
        Report_CancleSale.CreateDocument()
        DocumentViewer1.DocumentSource = Report_CancleSale
    End Sub

    Private Sub FrmReportCancleSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class