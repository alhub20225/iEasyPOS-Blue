Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class ReportDays_Test
    'Dim DateStart As Date = Convert.ToDateTime(FrmReportDay.Date_start).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
    'Dim DateEnd As Date = Convert.ToDateTime(FrmReportDay.Date_End).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
    Private Sub ReportDays_Test_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        Dim Dataset1 As New DataSet
        Dataset1.DataSetName = "Dataset1"
        Dim DataSelectCate As DataTable = executesql("SELECT CategoryId FROM SaleItem GROUP BY CategoryId")
        If IsNothing(DataSelectCate) Then
            Exit Sub
        ElseIf DataSelectCate.Rows.Count = 0
            Exit Sub
        End If

        Dim DataItemSale As DataTable = executesql("SELECT SaleItem.CategoryId,SaleItem.ItemId,SaleItem.ItemCode,SaleItem.ItemName,SaleItem.InitPrice,SaleItem.UnitPrice,
SaleItem.Qty,SaleItem.SubTotal,SaleItem.Tax,SaleItem.Total,CategoryItem.CategoryName FROM SaleItem INNER JOIN CategoryItem ON(CategoryItem.CategoryId = SaleItem.CategoryId ) 
WHERE SaleItem.InsertDate BETWEEN '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "'")


        Dataset1.Tables.Add(DataItemSale)
        DataItemSale.TableName = "SaleItem"
        DataSource = Dataset1
    End Sub
End Class