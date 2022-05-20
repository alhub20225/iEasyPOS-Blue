Imports DevExpress.XtraReports.UI

Public Class Frm_Report_CustomerSale
    Private Sub Frm_Report_CustomerSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If ComboPeper.Text = "A4" Then
            Dim report As New Report_CustomerSale
            report.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
            report.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
            report.XrLabel1.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
            report.XrLabel2.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
            report.SqlDataSource1.Connection.ConnectionString = rptConStr
            report.CreateDocument()
            DocumentViewer1.DocumentSource = report
        Else
            Dim report As New Report_CustomerSale80
            report.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
            report.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
            report.XrLabel1.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
            report.XrLabel2.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
            report.SqlDataSource1.Connection.ConnectionString = rptConStr
            report.CreateDocument()
            DocumentViewer1.DocumentSource = report
        End If
    End Sub
End Class