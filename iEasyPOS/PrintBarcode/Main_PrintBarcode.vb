Imports DevExpress.XtraReports.UI
Imports Newtonsoft.Json

Public Class Main_PrintBarcode
    Private Sub Main_PrintBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGItems.RowTemplate.Height = 35
        DataGridItem.RowTemplate.Height = 35

        RadioButton3.Checked = True
        RadioButton4.Checked = False

        DGItems.Rows.Clear()
        ModulePrintBarcode.LoadDataItem()
        ModulePrintBarcode.LoadCategory()
    End Sub
    Dim IdItems As String = ""
    Private Sub BtnPayMent_Click(sender As Object, e As EventArgs) Handles BtnPayMent.Click
        If DataGridItem.Rows.Count = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        If RadioButton3.Checked = True Then
            For i As Integer = 0 To DataGridItem.Rows.Count - 1
                Dim IdItems2 As String = DataGridItem.Rows(i).Cells(0).Value
                If IdItems = "" Then
                    IdItems = IdItems2
                Else
                    IdItems += "," & IdItems2
                End If
            Next
            Dim rpt As New Rp_Barcode
            rpt.SqlDataSource1.Connection.ConnectionString = rptConStr
            Dim ctq As DevExpress.DataAccess.Sql.CustomSqlQuery
            ctq = rpt.SqlDataSource1.Queries(0)
            ctq.Sql = "SELECT ItemId,ItemCode,ItemName,ItemPrice FROM Item WHERE Item.ItemId in (" & IdItems & ") and Active='1' ORDER BY ItemCode ASC"
            Frm_BarcodeA4.DocumentViewer1.DocumentSource = rpt
            rpt.CreateDocument()
            Frm_BarcodeA4.ShowDialog()
            IdItems = ""
            DataGridItem.Rows.Clear()
            DropDownitem.Text = ""
        Else
            For i As Integer = 0 To DataGridItem.Rows.Count - 1
                Dim IdItems2 As String = DataGridItem.Rows(i).Cells(0).Value
                If IdItems = "" Then
                    IdItems = IdItems2
                Else
                    IdItems += "," & IdItems2
                End If
            Next
            Dim rpt As New Rp_Barcode80mm
            rpt.SqlDataSource1.Connection.ConnectionString = rptConStr
            Dim ctq As DevExpress.DataAccess.Sql.CustomSqlQuery
            ctq = rpt.SqlDataSource1.Queries(0)
            ctq.Sql = "SELECT ItemId,ItemCode,ItemName,ItemPrice FROM Item WHERE Item.ItemId in (" & IdItems & ") and Active='1' ORDER BY ItemCode ASC"
            Frm_Barcode80mm.DocumentViewer1.DocumentSource = rpt
            rpt.CreateDocument()
            Frm_Barcode80mm.ShowDialog()
            IdItems = ""
            DataGridItem.Rows.Clear()
            DropDownitem.Text = ""
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ModulePrintBarcode.SearchItems()
    End Sub

    Public Shared ItemIdSend As Integer
    Private Sub DGItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGItems.CellClick
        ItemIdSend = DGItems.CurrentRow.Cells(0).Value
        loadA()
    End Sub
    Sub loadA()
        Dim ItemId As Integer = DGItems.CurrentRow.Cells(0).Value
        Dim DataDetail As DataTable = executesql("Select * FROM Item where ItemId='" & ItemId & "' AND Active=1")
        Dim RowsDataItem As Integer = DataDetail.Rows.Count
        For i As Integer = 0 To DataGridItem.Rows.Count - 1
            Dim id As Integer = DataGridItem.Rows(i).Cells(0).Value
            'ตรวจสอบ ที่ซ้ำ
            If ItemId = id Then
                MsgBox("รายการนี้ได้ทำการเลือกแล้ว", MsgBoxStyle.Critical, "")
                Exit Sub
            End If
        Next
        DataGridItem.Rows.Add(DataDetail(0)("itemid"), DataDetail(0)("ItemCode"), DataDetail(0)("ItemName"), FormatNumber(DataDetail(0)("ItemPrice"), 2))

    End Sub

    Private Sub DropDownitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownitem.SelectedIndexChanged
        If DropDownitem.Text = Nothing Then
            Exit Sub
        End If
        ModulePrintBarcode.SelectCategoryItems()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        DropDownitem.Text = ""
        DataGridItem.Rows.Clear()
    End Sub

    Private Sub DataGridItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridItem.CellClick
        If DataGridItem.CurrentCell.ColumnIndex = 5 Then
            DataGridItem.Rows.Remove(DataGridItem.CurrentRow)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtSerachItem.Clear()
        ComboBoxCategorysearch.Text = ""
        DGItems.Rows.Clear()
        ModulePrintBarcode.LoadDataItem()
    End Sub


End Class