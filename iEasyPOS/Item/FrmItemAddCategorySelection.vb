Public Class FrmItemAddCategorySelection
    Private Sub FrmItemAddCategorySelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleAddCategorySelectionToItem.AutoCompeleteCategorySelection()
    End Sub
    Private Sub TxtSrcCategoryName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSrcCategoryName.KeyDown
        If e.KeyCode = Keys.Enter Then
            ModuleAddCategorySelectionToItem.LoadNameCategorySelection()
        End If
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        'Btn Save Insert to TB ItemSelection
        ModuleAddCategorySelectionToItem.SaveCateSelectionToItem()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class