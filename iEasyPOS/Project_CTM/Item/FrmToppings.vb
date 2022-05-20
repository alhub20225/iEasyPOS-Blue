Public Class FrmToppings
    Private Sub FrmToppings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleTopping.loadCategoryTopping()
        ModuleTopping.loadData()
        'Receipe Topping
        ModuleAddToppingReceipe.loadMatCate()
    End Sub

    Private Sub RadDropDownListCateTopping_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        ModuleTopping.getToppingCode()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ModuleTopping.clearData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        ModuleTopping.btnSave()
    End Sub
    Public Shared toppingIds As Integer = 0
    Private Sub DataGridViewToppingList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingList.CellClick
        Try
            toppingIds = DataGridViewToppingList.CurrentRow.Cells(0).Value
            ModuleTopping.showData()
            ModuleAddToppingReceipe.showData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCate_Click(sender As Object, e As EventArgs) Handles btnCate.Click
        FrmCategoryTopping.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModuleTopping.btnSearch()
    End Sub

    Private Sub btnSearchMatTopping_Click(sender As Object, e As EventArgs) Handles btnSearchMatTopping.Click
        ModuleAddToppingReceipe.btnSearch()
    End Sub
    Public Shared ItemIdToTopping As Integer = 0
    Public Shared ItemNameTopping As String
    Public Shared ItemCodeToppings As String
    Private Sub btnAddToppingReceipe_Click(sender As Object, e As EventArgs) Handles btnAddToppingReceipe.Click
        Try
            If toppingIds = 0 Then
                MsgBox("กรุณาเลือกรายการ Topping", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf ItemIdToTopping = 0 Then
                MsgBox("กรุณาเลือกวัตถุดิบ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            ItemNameTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(1).Value
            ItemIdToTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(3).Value
            ItemCodeToppings = DataGridViewShowMatToppingList.CurrentRow.Cells(4).Value
            FrmAddToppingReceipe.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewShowMatToppingList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowMatToppingList.CellClick
        Try
            ItemNameTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(1).Value
            ItemIdToTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(3).Value
            ItemCodeToppings = DataGridViewShowMatToppingList.CurrentRow.Cells(4).Value
            'FrmAddToppingReceipe.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridViewShowMatToppingList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowMatToppingList.CellContentDoubleClick
        Try
            If toppingIds = 0 Then
                MsgBox("กรุณาเลือกรายการ Topping", MsgBoxStyle.Critical)
                Exit Sub
            End If
            ItemNameTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(1).Value
            ItemIdToTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(3).Value
            ItemCodeToppings = DataGridViewShowMatToppingList.CurrentRow.Cells(4).Value
            FrmAddToppingReceipe.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleTopping.clearData()
    End Sub

    Private Sub RadDropDownListCateTopping_SelectedIndexChanged_1(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownListCateTopping.SelectedIndexChanged
        ModuleTopping.getToppingCode()
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleTopping.btnSave()
    End Sub
    Public Shared ToppingReceipeId As Integer = 0
    Private Sub DataGridViewToppingReceipe_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingReceipe.CellDoubleClick
        Try
            ToppingReceipeId = DataGridViewToppingReceipe.CurrentRow.Cells(2).Value
            FrmAddToppingReceipe.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewToppingReceipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingReceipe.CellClick
        Try
            ToppingReceipeId = DataGridViewToppingReceipe.CurrentRow.Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModuleAddToppingReceipe.btnDel()
    End Sub



    'Private Sub DataGridViewToppingList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingList.CellContentClick
    '    toppingIds = DataGridViewToppingList.CurrentRow.Cells(0).Value
    '    ModuleTopping.showData()
    'End Sub
End Class