Imports DevExpress.XtraReports.UI
Public Class FrmReportSaleNumber
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Report_SaleNumber As New ReportSaleNumber
        Dim Date_start = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim Date_End = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim DT1 As DataTable = executesql("select Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,
Sale.TaxAmt, Sale.Total, Sale.ABBNo,
Sale.FullTaxNo, Sale.InsertDate,
Sale.closeBillUserId, Sale.TerminalName, Sale.AmountDC,
Users.FristName
from Sale Sale
inner join dbo.Users Users
on (Users.UserId = Sale.closeBillUserId)
WHERE Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'
                                         AND   Sale.Active = 1")
        Report_SaleNumber.DataSource = DT1
        Report_SaleNumber.TxtStartDate.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_SaleNumber.TxtEndDate.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_SaleNumber.CreateDocument()
        DocumentViewer1.DocumentSource = Report_SaleNumber
    End Sub

    Private Sub FrmReportSaleNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class