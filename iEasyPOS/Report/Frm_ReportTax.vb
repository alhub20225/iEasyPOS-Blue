Imports DevExpress.XtraReports.UI
Public Class Frm_ReportTax
    Public Shared Date_start As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM", New System.Globalization.CultureInfo("en-US"))
        Dim report As New Report_TaxSale

        report.Parameter1.Value = "%" & Date_start & "%"
        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.textDate.Text = "เดือนภาษี " & Convert.ToDateTime(DTP1.Value).ToString("MMMM", New System.Globalization.CultureInfo("th-TH")) + " ปีภาษี " + Convert.ToDateTime(DTP1.Value).ToString("yyyy", New System.Globalization.CultureInfo("th-TH"))

        report.CreateDocument()
        DocumentViewer1.DocumentSource = report

    End Sub

    Private Sub Frm_ReportTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP1.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class