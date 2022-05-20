Imports DevExpress.XtraReports.UI
Public Class FrmReportSaleNumberDetail
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Report_Number_detail As New ReportSaleNumberDetail
        Dim Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim Date_End = Convert.ToDateTime(DTP2.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim Datatable1 As DataTable = executesql("select Sale.SaleNo, Sale.SaleDate, SaleItem.InitPrice,
                                                   SaleItem.Qty, SaleItem.SubTotal,
                                                   SaleItem.UnitPrice, SaleItem.PercentDC,
                                                   SaleItem.Total, SaleItem.Tax, SaleItem.BahtDC,
                                                   SaleItem.AmtDC, SaleItem.ItemCode, Item.ItemName
                                              from ((dbo.Sale Sale
                                              inner join dbo.SaleItem SaleItem
                                                   on (SaleItem.SaleId = Sale.SaleId))
                                              inner join dbo.Item Item
                                                   on (Item.ItemId = SaleItem.SaleId))
                                            WHERE Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'AND Sale.Active = 1 ")
        Report_Number_detail.DataSource = Datatable1
        Report_Number_detail.CreateDocument()
        DocumentViewer1.DocumentSource = Report_Number_detail
    End Sub
End Class