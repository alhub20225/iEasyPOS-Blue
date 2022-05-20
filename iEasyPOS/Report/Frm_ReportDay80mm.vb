Public Class Frm_ReportDay80mm
    Public Shared SaleTerminalName As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        Dim report As New ReportDays80mmCloseShift
        report.Parameter1.Value = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        report.Parameter2.Value = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))

        report.DateTimeOpenShift = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        report.DateTimeCloseShift = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        report.HeaderLabel.Text = "รายงานการขาย"
        'report.txtSaleDate.Text = Convert.ToDateTime(DTP1.Value).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

End Class