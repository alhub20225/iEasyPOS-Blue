Public Class FrmAddCategorySelection
    Public Shared CateSelectionId As Integer
    Public Shared SelectionidSend As Integer
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'Btn Add
        CateSelectionId = 0
        ModuleCategorySelection.ClearTextData()
    End Sub
    Private Sub FrmAddCategorySelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Data GridView 
        ModuleCategorySelection.LoadDataCateSelection()
        ModuleCategorySelection.LoadCategorySelectionToComboSelection()
        ModuleCategorySelection.LoadCategorySelectionDetail()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CateSelectionId = 0 Then
            'Btn Save
            ModuleCategorySelection.SaveData()
            Exit Sub
        ElseIf CateSelectionId <> 0
            'Btn Update 
            ModuleCategorySelection.UpdateDataCateSelection()
        End If
    End Sub
    Private Sub DGDataCateSelection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDataCateSelection.CellClick
        Try
            'Cell Click
            CateSelectionId = 0
            CateSelectionId = DGDataCateSelection.CurrentRow.Cells(1).Value
            ModuleCategorySelection.DataSelectRows()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Btn Delete
        ModuleCategorySelection.DeleteCateSelection()
    End Sub

    Private Sub BtnSrc_Click(sender As Object, e As EventArgs) Handles BtnSrc.Click
        'Btn Src 
        ModuleCategorySelection.SearchDateCate()
    End Sub
    Private Sub DGDataCateSelection_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDataCateSelection.CellContentDoubleClick
        Try
            TabControl1.SelectTab(1)
            CateSelectionId = DGDataCateSelection.CurrentRow.Cells(1).Value
            TxtCateSelection.Text = DGDataCateSelection.CurrentRow.Cells(0).Value
            ModuleCategorySelection.LoadTabPageSelection()
            ModuleCategorySelection.LoadCategorySelectionToComboSelection()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ComboBoxSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelection.SelectedIndexChanged
        TxtCateSelection.Text = ComboBoxSelection.Text
        ModuleCategorySelection.SelectTabComboChange()

    End Sub
    Private Sub BtnAddSelection_Click(sender As Object, e As EventArgs) Handles BtnAddSelection.Click
        ModuleCategorySelection.ClearTextDataSelection()
    End Sub

    Private Sub BtnSaveSelection_Click(sender As Object, e As EventArgs) Handles BtnSaveSelection.Click
        If SelectionidSend = 0 Then
            'Btn Save
            ModuleCategorySelection.SaveSelection()
        ElseIf SelectionidSend <> 0
            'Btn Update
            ModuleCategorySelection.UpdateSelection()
        End If
    End Sub
    Private Sub BtnDeleteSelection_Click(sender As Object, e As EventArgs) Handles BtnDeleteSelection.Click
        'Btn Delete Selection 
        ModuleCategorySelection.DeleteSelection()
    End Sub
    Private Sub DgSelection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSelection.CellClick
        Try
            SelectionidSend = DgSelection.CurrentRow.Cells(1).Value
            ModuleCategorySelection.DataSelectionDetail()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class