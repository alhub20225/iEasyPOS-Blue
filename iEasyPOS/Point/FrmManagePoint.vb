Public Class FrmManagePoint
    Private Sub FrmManagePoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewShowItem.RowTemplate.Height = 35
        DataGridViewShowPointRate.RowTemplate.Height = 35
        DataGridViewItemPoint.RowTemplate.Height = 35
        ModuleManageItemPoint.loadItem()
        ModuleManageItemPoint.loadCategory()
        ModuleManageItemPoint.loadPintRate()
    End Sub
    Public Shared ItemPointItemId As Integer = 0
    Private Sub DataGridViewShowItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowItem.CellClick
        Dim checked As Boolean = CType(DataGridViewShowItem.CurrentRow.Cells("ItemSelect").Value, Boolean)
        If checked = True Then
            DataGridViewShowItem.CurrentRow.Cells("ItemSelect").Value = False
        Else
            DataGridViewShowItem.CurrentRow.Cells("ItemSelect").Value = True
        End If
        ItemPointItemId = DataGridViewShowItem.CurrentRow.Cells("ItemId").Value
        ModuleManageItemPoint.loadItemPoint()
    End Sub

    Private Sub ComboBoxSelectCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelectCategory.SelectedIndexChanged
        'ModuleManageItemPoint.Itemselect()

        Dim CategoryName As String = ComboBoxSelectCategory.Text
        If CategoryName = "ทั้งหมด" Then
            Dim ItemData As DataTable = executesql("select Item.ItemId,Item.ItemCode,Item.ItemName from Item inner join CategoryItem on(Item.CategoryId = CategoryItem.CategoryId) where Item.Active=1 and CategoryItem.CateGroupId = 1")
            DataGridViewShowItem.Rows.Clear()
            For i As Integer = 0 To ItemData.Rows.Count - 1
                DataGridViewShowItem.Rows.Add(ItemData(i)("ItemCode"), ItemData(i)("ItemName"), ItemData(i)("ItemId"), True)
            Next
        Else
            Dim ItemData As DataTable = executesql("select Item.ItemId,Item.ItemCode,Item.ItemName from Item inner join CategoryItem on(Item.CategoryId = CategoryItem.CategoryId) where Item.Active = 1 and CategoryItem.CategoryName = '" & CategoryName & "'")
            DataGridViewShowItem.Rows.Clear()
            For i As Integer = 0 To ItemData.Rows.Count - 1
                DataGridViewShowItem.Rows.Add(ItemData(i)("ItemCode"), ItemData(i)("ItemName"), ItemData(i)("ItemId"), True)
            Next
        End If
        ModuleManageItemPoint.loadItemPoint()
    End Sub

    Private Sub btnAddItemPoint_Click(sender As Object, e As EventArgs) Handles btnAddItemPoint.Click
        ModuleManageItemPoint.btnAdd()
    End Sub
    Public Shared mPointRateId As Integer = 0
    Private Sub DataGridViewShowPointRate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowPointRate.CellClick
        mPointRateId = DataGridViewShowPointRate.CurrentRow.Cells("PointId").Value
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmPointRate.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmPointRate.StartPosition = FormStartPosition.CenterParent
            FrmPointRate.ShowDialog(plexi)
        End Using
        'FrmPointRate.ShowDialog()
    End Sub

    Public Shared ItemPointId As Integer = 0
    Private Sub DataGridViewItemPoint_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItemPoint.CellClick
        ItemPointId = DataGridViewItemPoint.CurrentRow.Cells("PointRateId").Value
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModuleManageItemPoint.btnDel()
    End Sub
End Class