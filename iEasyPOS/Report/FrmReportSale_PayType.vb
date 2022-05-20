Imports DevExpress.XtraReports.UI
Public Class FrmReportSale_PayType
    Private Sub FrmReportSale_PayType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim PayName As DataTable = executesql("SELECT Paymentname FROM PaymentType")
        For i As Integer = 0 To PayName.Rows.Count - 1
            ComboPayment.Items.Add(PayName(i)("Paymentname"))
        Next

    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If ComboPayment.Text = "" Then
            MsgBox("กรุณาเลือกประเภทการชำระเงิน", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim ReportPay As New ReportSaleNum_PayType
        Dim Date_start = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim Date_End = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

        '        Dim dt As DataTable = executesql("select Sale.SaleId,Sale.SaleDate, Sale.SaleNo, 
        'CASE WHEN Sale.SaleId = ISNULL((Select Sale.SaleId from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)

        'THEN
        'ISNULL((case when PaymentDetail.PaymentTypeId = 9 then Sale.SubTotal - ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'else
        'ISNULL(PaymentDetail.PaidAmount,0) end),0) ELSE Sale.SubTotal END as  SubTotal ,

        'CASE WHEN Sale.SaleId = ISNULL((Select Sale.SaleId from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'THEN
        'ISNULL((case when PaymentDetail.PaymentTypeId = 9 then Sale.SubTotal - ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'else
        'ISNULL(PaymentDetail.PaidAmount,0) end),0) * 7 /107 ELSE Sale.TaxAmt END as  TaxAmt, 

        'CASE WHEN Sale.SaleId = ISNULL((Select Sale.SaleId from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'THEN
        'ISNULL((case when PaymentDetail.PaymentTypeId = 9 then Sale.Total - ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17  And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And SaleItem.SaleId = Sale.SaleId  And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'else
        'ISNULL(PaymentDetail.PaidAmount,0) end),0) ELSE Sale.SubTotal END as  Total , Sale.ABBNo,
        'Sale.FullTaxNo,
        'Sale.closeBillUserId, Sale.customerId,
        'Sale.NumOfCust
        ', PaymentType.PaymentName,
        'CASE WHEN Sale.SaleId = ISNULL((Select Sale.SaleId from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'THEN
        'ISNULL((case when PaymentDetail.PaymentTypeId = 9 then Sale.SubTotal - ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And SaleItem.SaleId = Sale.SaleId And   Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)-
        'ISNULL((Select PaymentDetail.PaidAmount from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And SaleItem.SaleId = Sale.SaleId And Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' ),0)
        'else
        'ISNULL(PaymentDetail.PaidAmount,0) end),0) ELSE Sale.SubTotal END as  SubTotal,
        '((Select Sum(Sale.AmountDC) from Sale  where Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND Active=1) +
        '(Select Sum(SaleItem.PercentDC) from SaleItem inner join Sale on(Sale.SaleId=SaleItem.SaleId) inner join PaymentDetail on(SaleItem.SaleId = PaymentDetail.SaleId) where SaleItem.InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND SaleItem.Active=1) +
        '(Select Sum(SaleItem.BahtDC) from SaleItem inner join Sale on(Sale.SaleId=SaleItem.SaleId) inner join PaymentDetail on(SaleItem.SaleId = PaymentDetail.SaleId) where SaleItem.InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND SaleItem.Active=1)) As AmountDC

        'from SaleItem
        'inner join Item
        'on (Item.ItemId = SaleItem.ItemId)
        'inner join Sale
        'on (Sale.SaleId = SaleItem.SaleId)
        'inner join CategoryItem
        'on (CategoryItem.CategoryId = SaleItem.CategoryId)
        'inner join PaymentDetail on(Sale.SaleId = PaymentDetail.SaleId)
        'inner join dbo.PaymentType PaymentType
        'on (PaymentType.PaymentId = PaymentDetail.PaymentTypeId)
        'where Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND SaleItem.Active = 1 
        'and PaymentType.Paymentname = '" & ComboPayment.Text & "'
        'group by Sale.SaleId,Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,
        '        Sale.TaxAmt, Sale.Total, Sale.ABBNo,
        '        Sale.FullTaxNo,Sale.closeBillUserId, Sale.customerId,
        '        Sale.NumOfCust,PaymentDetail.PaymentTypeId,Sale.SaleNo,PaymentDetail.PaidAmount,PaymentType.PaymentName,SaleItem.SaleId
        'order by Sale.SaleDate Asc")
        Dim dt As DataTable = executesql("select Sale.SaleId,Sale.SaleNo,Sale.SaleDate,Sale.Total,
(Sale.AmountDC + SaleItem.PercentDC + SaleItem.BahtDC) As AmountDC,Sale.SubTotal,Sale.TaxAmt,PaymentType.PaymentName
from SaleItem
INNER JOIN Sale on(Sale.SaleId = SaleItem.SaleId)
INNER JOIN Item on(Item.ItemId = SaleItem.ItemId)
INNER JOIN SalePayment on(Sale.SaleId = SalePayment.SaleId)
INNER JOIN PaymentDetail on(Sale.SaleId = PaymentDetail.SaleId)
INNER JOIN PaymentType on(PaymentDetail.PaymentTypeId = PaymentType.PaymentId)
where SaleItem.InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND SaleItem.Active = 1 AND SaleItem.Active = 1 AND PaymentType.PaymentName = '" & ComboPayment.Text & "'
group by Sale.SaleNo,Sale.SaleId,Sale.SaleDate,Sale.AmountDC,SaleItem.PercentDC,SaleItem.BahtDC,Sale.Total,Sale.SubTotal,Sale.TaxAmt,PaymentType.PaymentName")
        If dt.Rows.Count = 0 Then
            MsgBox("ไม่มีรายการที่ชำระผ่าน " & ComboPayment.Text, MsgBoxStyle.Critical)
            Exit Sub
        Else
            ReportPay.DataSource = dt
            ReportPay.TxtStartDate.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
            ReportPay.TxtEndDate.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
            ReportPay.CreateDocument()
            DocumentViewer1.DocumentSource = ReportPay
        End If

    End Sub
End Class