Imports DevExpress.XtraReports.UI
Public Class Frm_DateSale
    Public Shared Date_start As String
    Public Shared Date_End As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Date_End = Convert.ToDateTime(DTP2.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        Dim report As New ReportDaySale_V2

        report.Parameter1.Value = Date_start
        report.Parameter2.Value = Date_End

        'Dim Datatable1 As DataTable = executesql("select CONVERT(date,SaleDate,101) As SaleDate,SUM(SubTotal) AS Subtotal,Sum(TaxAmt) As TaxAmt,Sum(Total) As Total,Sum(AmountDC) As AmountDC from Sale where Active = 1 AND CONVERT(date,SaleDate,101) between '" & Date_start & "' and '" & Date_End & "' group by CONVERT(date,SaleDate,101) order by SaleDate asc")

        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

    Private Sub Frm_DateSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(DTP2.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
    End Sub

End Class