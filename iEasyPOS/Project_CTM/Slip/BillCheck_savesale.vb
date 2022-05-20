Imports System.Drawing.Printing

Public Class BillCheck_savesale
    Dim Sale_id As Integer
    Private Sub BillCheck_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        If GetSaleId > 0 Then
            Sale_id = GetSaleId
        ElseIf TB_GetSaleId > 0 Then
            Sale_id = TB_GetSaleId
        End If
        Dim Dataset1 As New DataSet
        Dataset1.DataSetName = "DataSet1"

        Dim Datatable1 As DataTable = executesql("SELECT Sale.SubTotal,Sale.Total,SaleItem.ItemId,SaleItem.ItemName,SaleItem.Qty,SaleItem.BahtDC,SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.Tax,SaleItem.InitPrice,SaleItem.UnitPrice FROM Sale INNER JOIN SaleItem ON(SaleItem.SaleId = Sale.SaleId) WHERE Sale.SaleId=" & Sale_id & "")

        Dim Datatable2 As DataTable = executesql("SELECT SaleTable.InsertDate,SaleTable.SaleName,SaleTable.SaleId FROM SaleTable INNER JOIN Sale ON(Sale.SaleId=SaleTable.SaleId) WHERE Sale.SaleId=" & Sale_id & "")

        Dataset1.Tables.Add(Datatable1)
        Dataset1.Tables.Add(Datatable2)
        Datatable1.TableName = "Sale"
        Datatable2.TableName = "SaleTable"
        DataSource = Dataset1
    End Sub

    Private Sub txtQty_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtQty.BeforePrint
        txtQty.Text = FormatNumber(txtQty.Text, 0)
    End Sub

    Private Sub txtUnitPrice_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtUnitPrice.BeforePrint
        txtUnitPrice.Text = FormatNumber(txtUnitPrice.Text, 2)
    End Sub

    Private Sub txtSubtotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtSubtotal.BeforePrint
        txtSubtotal.Text = FormatNumber(txtSubtotal.Text, 2)
    End Sub

    Private Sub txtTotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtTotal.BeforePrint
        txtTotal.Text = FormatNumber(txtTotal.Text, 2)
    End Sub
    Private Sub txtAmcDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtAmcDC.BeforePrint
        txtAmcDC.Text = FormatNumber(txtAmcDC.Text, 2)
    End Sub
    Private Sub txtBathDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtBathDC.BeforePrint
        txtBathDC.Text = FormatNumber(txtBathDC.Text, 2)
    End Sub

    Private Sub txtPercentDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtPercentDC.BeforePrint
        txtPercentDC.Text = FormatNumber(txtPercentDC.Text, 2)
    End Sub
    Private Sub TableDetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles TableDetail.BeforePrint
        If txtAmcDC.Text = 0 Then
            RowAmtDC.Visible = False
        End If
        If txtBathDC.Text = 0 Then
            RowBathDC.Visible = False
        End If
        If txtPercentDC.Text = 0 Then
            RowPercentDC.Visible = False
        End If
    End Sub

End Class