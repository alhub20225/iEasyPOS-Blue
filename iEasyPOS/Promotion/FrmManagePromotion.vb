Public Class FrmManagePromotion
    Private Sub FrmManagePromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewShowItem.RowTemplate.Height = 35
        DataGridViewShowPromotion.RowTemplate.Height = 35
        DataGridViewItemPromotion.RowTemplate.Height = 35
        ModuleManagePromotion.loadCategory()
        ModuleManagePromotion.loadItem()
        ModuleManagePromotion.loadPromotion()
        DataGridViewShowPromotion.ClearSelection()
    End Sub

    Private Sub ComboBoxSelectCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelectCategory.SelectedIndexChanged
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
        ModuleManagePromotion.loadPromotionItem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Promotion.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Promotion.StartPosition = FormStartPosition.CenterParent
            Promotion.ShowDialog(plexi)
        End Using
        'Promotion.ShowDialog()
    End Sub

    Private Sub btnAddItemPoint_Click(sender As Object, e As EventArgs) Handles btnAddItemPoint.Click
        ModuleManagePromotion.btnAdd()
        DataGridViewShowPromotion.ClearSelection()
    End Sub
    Public Shared mProId As Integer = 0
    Private Sub DataGridViewShowPromotion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowPromotion.CellClick
        mProId = DataGridViewShowPromotion.CurrentRow.Cells("PromotionId").Value
    End Sub

    Public Shared mItemId As Integer = 0
    Private Sub DataGridViewShowItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowItem.CellClick
        Dim checked As Boolean = CType(DataGridViewShowItem.CurrentRow.Cells("ItemSelect").Value, Boolean)
        If checked = True Then
            DataGridViewShowItem.CurrentRow.Cells("ItemSelect").Value = False
        Else
            DataGridViewShowItem.CurrentRow.Cells("ItemSelect").Value = True
        End If
        mItemId = DataGridViewShowItem.CurrentRow.Cells("ItemId").Value
        ModuleManagePromotion.loadPromotionItem()
    End Sub

    Public Shared mProItemId As Integer = 0
    Private Sub DataGridViewItemPromotion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItemPromotion.CellClick
        mProItemId = DataGridViewItemPromotion.CurrentRow.Cells("PromotionIds").Value
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModuleManagePromotion.btnDel()
    End Sub
End Class