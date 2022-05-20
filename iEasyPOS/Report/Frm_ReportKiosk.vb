Public Class Frm_ReportKiosk
    Public Shared Date_start As String
    Public Shared Date_End As String
    Public Shared CateName As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DateStart.Value).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Date_End = Convert.ToDateTime(DateEnd.Value).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        Dim TerminalName As String = "CTM_CTW1"
        Dim report As New Report_MainPOS
        Dim Datatable1 As DataTable = executesql("select CategoryItem.CategoryName,Item.ItemCode,Item.ItemName,
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
                                                    where Sale.SaleDate BETWEEN CONVERT(datetime, '" & Date_start & "', 126) AND CONVERT(datetime, '" & Date_End & "', 126) AND Sale.Active = 1 And SaleItem.TerminalName = '" & TerminalName & "'
                                                    group by CategoryItem.CategoryName,Item.ItemCode,Item.ItemName,CategoryItem.CategoryId
                                                    order by CategoryItem.CategoryId ASC")
        report.DataSource = Datatable1

        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

    Private Sub Frm_ReportKiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_start = Convert.ToDateTime(DateStart.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(DateEnd.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class