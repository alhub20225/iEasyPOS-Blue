Imports DevExpress.XtraReports.UI
Public Class FrmReportSaleNumber
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Report_SaleNumber As New ReportSaleNumber
        Dim Date_start = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Dim Date_End = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))

        Report_SaleNumber.Parameter1.Value = Date_start
        Report_SaleNumber.Parameter2.Value = Date_End

        Report_SaleNumber.TxtStartDate.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_SaleNumber.TxtEndDate.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_SaleNumber.SqlDataSource1.Connection.ConnectionString = rptConStr
        Report_SaleNumber.CreateDocument()
        DocumentViewer1.DocumentSource = Report_SaleNumber
    End Sub

    Private Sub FrmReportSaleNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class