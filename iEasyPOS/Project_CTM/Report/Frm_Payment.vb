Imports DevExpress.XtraReports.UI
Public Class Frm_Payment
    Public Shared Date_start As String
    Public Shared Date_End As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim report As New Report_PaymentV1
        'Dim Datatable1 As DataTable = executesql("select convert(date,sale.saledate,101) as saledate,paymenttype.paymentname,sum            (sale.subtotal) as  paidamount
        '                                          from ((dbo.paymentdetail paymentdetail
        '                                          inner join dbo.sale sale
        '                                               on (sale.saleid = paymentdetail.saleid))
        '                                          inner join dbo.paymenttype paymenttype
        '                                               on (paymenttype.paymentid = paymentdetail.paymenttypeid))
        '                                          where convert(date,sale.saledate,101) = '" & Date_start & "' and sale.active= 1
        '                                          group by convert(date,sale.saledate,101),paymenttype.paymentname
        '                                          order by convert(date,sale.saledate,101)")
        Dim Datatable1 As DataTable = executesql("select CONVERT(date,Sale.SaleDate,101) as SaleDate,PaymentType.PaymentName,(case when PaymentDetail.PaymentTypeId = 9 then ((Select  sum(Sale.SubTotal) As SubTotal
from  Sale 
Where Sale.Active = 1  And CONVERT(date,Sale.SaleDate,101) =  '" & Date_start & "')) - ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And CONVERT(date,Sale.SaleDate,101) =  '" & Date_start & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And CONVERT(date,Sale.SaleDate,101) =  '" & Date_start & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And CONVERT(date,Sale.SaleDate,101) =  '" & Date_start & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And CONVERT(date,Sale.SaleDate,101) =  '" & Date_start & "'),0)
else
ISNULL(sum(PaymentDetail.PaidAmount),0)
end)  as  PaidAmount
from ((dbo.PaymentDetail PaymentDetail
inner join dbo.Sale Sale
    on (Sale.SaleId = PaymentDetail.SaleId))
inner join dbo.PaymentType PaymentType
    on (PaymentType.PaymentId = PaymentDetail.PaymentTypeId))
where CONVERT(date,Sale.SaleDate,101) =  '" & Date_start & "' AND Sale.Active= 1
group by CONVERT(date,Sale.SaleDate,101),PaymentType.PaymentName,PaymentDetail.PaymentTypeId
order by CONVERT(date,Sale.SaleDate,101)")
        report.DataSource = Datatable1
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

    Private Sub Frm_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP1.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class