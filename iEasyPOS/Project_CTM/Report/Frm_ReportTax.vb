Imports DevExpress.XtraReports.UI
Public Class Frm_ReportTax
    Public Shared Date_start As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM", New System.Globalization.CultureInfo("th-TH"))
        Dim report As New Report_TaxSale
        Dim Datatable1 As DataTable = executesql("SELECT CONVERT(date,sale.SaleDate,101) as SaleDate,sale.Terminalname,min(sale.SaleNo) as minSaleNo,max(sale.SaleNo) as maxSaleNo,
                                                    CASE
                                                        WHEN
                                                      CustomerId = 0
                                                      THEN
                                                       'ลูกค้าเงินสดทั่วไป'
                                                     ELSE
                                                      (SELECT Customer.FirstName FROM Customer WHERE Customer.CustomerId=sale.CustomerId)
                                                      END AS CustomerName,
                                                      sum(sale.Total) as Total,sum(sale.TaxAmt) as TaxAmt,(sum(sale.Total) - sum(sale.TaxAmt)) as NoTaxAmt
                                                    FROM Sale
                                                    where CONVERT(date,sale.SaleDate,101) like '" & Date_start & "-%' AND Sale.Active= 1
                                                    group by CONVERT(date,sale.SaleDate,101),sale.CustomerId,sale.Terminalname
                                                    order by CONVERT(date,sale.SaleDate,101)")
        report.DataSource = Datatable1
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

    Private Sub Frm_ReportTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP1.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class