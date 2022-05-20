Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class OrderTableSingle

    Private Sub OrderTableSingle_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        Dim Dataset1 As New DataSet

        Dim SelectMinId As DataTable = executesql("SELECT Min(Id) AS Id FROM SaleItemOrder WHERE SaleItemOrder.StatusPrint=0")
        Dataset1.DataSetName = "DataSet1"

        Dim Datatable1 As DataTable = executesql("SELECT SaleItem.Qty,SaleItem.ItemName,SaleItem.UserId,SaleItem.InsertDate,SaleItem.TerminalName,SaleItem.PrinterName,Tables.TableName,Zones.ZoneName,Users.FristName INNER JOIN SaleItem ON (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleItemOrder ON (SaleItemOrder.SaleItemId = SaleItem.SaleItemId)INNER JOIN SaleTable ON (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef ON (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables ON (Tables.TableId = SaleTabRef.TableId)INNER JOIN Zones ON(Zones.ZoneId = Tables.ZoneId)INNER JOIN Users ON(Users.UserId = SaleItemOrder.UserId) WHERE Sale.SaleId='" & GetSaleId & "' AND SaleItemOrder.StatusPrint=0 AND SaleItemOrder.Id='" & SelectMinId(0)("Id") & "'")

        Dataset1.Tables.Add(Datatable1)
        Datatable1.TableName = "Sale"
        DataSource = Dataset1
    End Sub


End Class