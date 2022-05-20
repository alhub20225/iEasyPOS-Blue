Public Class Report_MainPOS
    Dim DTS As String = ModuleShift.DateOpen
    Dim DTE As String = ModuleShift.DateClose

    Private Sub Report_MainPOS_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'DTS = "2561-11-22 00:00:00"
        'DTE = "2561-11-22 23:59:00"
        Dim DataSet1 As New DataSet
        DataSet1.DataSetName = "Dataset1"
        Dim TerminalName As String = "CTM_CTW1"
        Dim DataTable1 As DataTable = executesql("select CategoryItem.CategoryName,Item.ItemCode,Item.ItemName,
SUM(SaleItem.PercentDC) AS PercentDC,
SUM(SaleItem.BahtDC) As BahtDC,
SUM(SaleItem.Qty) AS Qty,
SUM(SaleItem.SubTotal) As SubTotal, 
SUM(SaleItem.Tax) AS Tax,
SUM(SaleItem.Total) AS Total
from CategoryItem
inner join Item on(Item.CategoryId = CategoryItem.CategoryId)
inner join SaleItem on(SaleItem.ItemId = Item.ItemId)
inner join Sale on(SaleItem.SaleId = Sale.SaleId)
inner join PaymentDetail on(Sale.SaleId = PaymentDetail.SaleId)
where Sale.SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Sale.Active = 1 And SaleItem.TerminalName = '" & TerminalName & "'
group by CategoryItem.CategoryName,Item.ItemCode,Item.ItemName,CategoryItem.CategoryId
order by CategoryItem.CategoryId ASC")

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
Where SaleDate BETWEEN '" & DTS & "' AND '" & DTE & "' AND Sale.Active = 1 And SaleItem.TerminalName = '" & TerminalName & "'")
        If Datatable2.Rows.Count > 0 Then
            If Not IsDBNull(Datatable2(0)("Discount")) Or Not IsDBNull(Datatable2(0)("Total")) Or Not IsDBNull(Datatable2(0)("SubTotal")) Then
                sum_spe_dc.Text = FormatNumber(Datatable2(0)("Discount"), 2)
                XrLabel32.Text = FormatNumber(Datatable2(0)("Total"), 2)
                txt_gloss_sale.Text = FormatNumber(Datatable2(0)("SubTotal"), 2)
                'report.DataSource = Datatable1
            End If
        End If
        DataSet1.Tables.Add(DataTable1)
        DataSource = DataSet1
    End Sub

    Private Sub XrLabel20_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel20.BeforePrint
        XrLabel20.Text = Convert.ToDateTime(DTS).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class