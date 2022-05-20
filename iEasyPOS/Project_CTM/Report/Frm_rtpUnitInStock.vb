Imports DevExpress.XtraReports.UI
Public Class Frm_rtpUnitInStock
    Public Shared Date_start As String
    Public Shared Date_End As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Dim report As New Report_UnitInStock
        Dim Datatable1 As DataTable = executesql("select UnitInStock.Qty, UnitInStock.ItemCode,Item.ItemName, ItemUnit.ItemUnitName
                                                    from ((dbo.UnitInStock UnitInStock
                                                    inner join dbo.Item Item
                                                    on (Item.ItemCode = UnitInStock.ItemCode))
                                                    inner join dbo.ItemUnit ItemUnit
                                                    on (ItemUnit.ItemUnitId = Item.USUnitId))
                                                    where UnitInStock.ItemCode like '%" & txt_search.Text & "%'")
        report.DataSource = Datatable1
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
        clear()
    End Sub
    Sub clear()
        txt_search.Text = ""
    End Sub
End Class