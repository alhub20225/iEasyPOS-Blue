Public Class ReportSale_ByItem
    Private Sub ReportSale_ByItem_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'Dim report As New ReportSale_ByItem
        XrLabel1.Text = Frm_ReportSale_ByItem.CateName
        XrLabel20.Text = Convert.ToDateTime(Frm_ReportSale_ByItem.Date_start).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(Frm_ReportSale_ByItem.Date_End).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Dim Datatable1 As DataTable = executesql("select 
Item.ItemName,
SUM(SaleItem.Qty) As Qty,
Item.ItemPrice,
SUM(SaleItem.BahtDC + SaleItem.PercentDC) As Discount,
SUM(SaleItem.SubTotal) As SubTotal,
SUM(SaleItem.Tax) As Tax
from Sale 
inner join SaleItem on(Sale.SaleId = SaleItem.SaleId)
inner join Item on(SaleItem.ItemId = Item.ItemId)
inner join PaymentDetail on(PaymentDetail.SaleId = Sale.SaleId)
inner join CategoryItem on(CategoryItem.CategoryId = Item.CategoryId)
Where SaleDate BETWEEN '" & Frm_ReportSale_ByItem.Date_start & "' AND '" & Frm_ReportSale_ByItem.Date_End & "' and Sale.Active = 1 and CategoryItem.CategoryName = '" & Frm_ReportSale_ByItem.CateName & "'
Group by Item.ItemName,Item.ItemId,Item.ItemPrice
Order by Item.ItemId ASC")
        DataSet1.Tables.Add(Datatable1)
        DataSource = DataSet1
        Dim Datatable2 As DataTable = executesql("select 
SUM(SaleItem.Total) As Total,
SUM(SaleItem.SubTotal) As SubTotal,
SUM(SaleItem.BahtDC + SaleItem.PercentDC) As Discount,
SUM(SaleItem.Tax) As Tax
from Sale 
inner join SaleItem on(Sale.SaleId = SaleItem.SaleId)
inner join Item on(SaleItem.ItemId = Item.ItemId)
inner join PaymentDetail on(PaymentDetail.SaleId = Sale.SaleId)
inner join CategoryItem on(CategoryItem.CategoryId = Item.CategoryId)
Where SaleDate BETWEEN '" & Frm_ReportSale_ByItem.Date_start & "' AND '" & Frm_ReportSale_ByItem.Date_End & "' and Sale.Active = 1  and CategoryItem.CategoryName = '" & Frm_ReportSale_ByItem.CateName & "'")
        If Datatable2.Rows.Count > 0 Then
            If Not IsDBNull(Datatable2(0)("Discount")) Or Not IsDBNull(Datatable2(0)("Total")) Or Not IsDBNull(Datatable2(0)("SubTotal")) Then
                sum_spe_dc.Text = FormatNumber(Datatable2(0)("Discount"), 2)
                XrLabel32.Text = FormatNumber(Datatable2(0)("Total"), 2)
                txt_gloss_sale.Text = FormatNumber(Datatable2(0)("SubTotal"), 2)
                'report.DataSource = Datatable1
            End If
        End If

        'report.CreateDocument()
        'DocumentViewer1.DocumentSource = report
    End Sub
End Class