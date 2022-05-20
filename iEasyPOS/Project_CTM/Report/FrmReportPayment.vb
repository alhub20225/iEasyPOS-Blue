Imports DevExpress.XtraReports.UI
Public Class FrmReportPayment
    Public Shared Date_start As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub FrmReportPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim report As New Report_Payment
        Dim Datatable1 As DataTable = executesql("select CONVERT(date,SaleDate,101) As SaleDate,PaymentType.PaymentName as PaymentName,sum(PaymentDetail.PaidAmount) as PaidAmount
                                                    from ((dbo.PaymentDetail PaymentDetail
                                                            inner join dbo.PaymentType PaymentType
                                                            on (PaymentType.PaymentId = PaymentDetail.PaymentTypeId))
                                                               inner join dbo.Sale Sale
                                                               on (Sale.SaleId = PaymentDetail.SaleId))
                                                    where CONVERT(date,SaleDate,101) = '" & Date_start & "'
                                                    Group by CONVERT(date,SaleDate,101),PaymentType.PaymentName
                                                    order by CONVERT(date,SaleDate,101)")

        report.DataSource = Datatable1
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub
End Class