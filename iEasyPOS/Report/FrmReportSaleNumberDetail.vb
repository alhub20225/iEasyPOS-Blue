Imports DevExpress.XtraReports.UI
Public Class FrmReportSaleNumberDetail
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        Dim Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Dim Date_End = Convert.ToDateTime(DTP2.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        Dim Report_Number_detail As New ReportSaleNumberDetail
        Report_Number_detail.Parameter1.Value = Date_start
        Report_Number_detail.Parameter2.Value = Date_End
        Report_Number_detail.LabelTimeStart.Text = Convert.ToDateTime(DTP1.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DTP2.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_Number_detail.SqlDataSource1.Connection.ConnectionString = rptConStr
        Report_Number_detail.CreateDocument()
        DocumentViewer1.DocumentSource = Report_Number_detail
        'MsgBox(Report_Number_detail.XrLabel19.Text)
    End Sub
End Class