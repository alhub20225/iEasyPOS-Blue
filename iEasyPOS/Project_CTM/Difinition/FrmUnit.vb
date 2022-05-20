Public Class FrmUnit
    Public Shared SendUnitId As Integer
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        SendUnitId = 0
        ModuleUnit.ClearUnitData()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Add Unit 
        If SendUnitId = Nothing Then
            ModuleUnit.AddUnit()
            Item.DropDownUnitItem.Items.Clear()
            LoadUnit()
            'Load POUnitItem 
            Item.DropDownPOUnit.Items.Clear()
            LoadPOUnit()
            'Load POUnitItem2
            Item.DropDownPOUnit2.Items.Clear()
            LoadPOUnit2()
        ElseIf SendUnitId <> Nothing Then
            ModuleUnit.UpdateUnit()
            Item.DropDownUnitItem.Items.Clear()
            LoadUnit()
            'Load POUnitItem 
            Item.DropDownPOUnit.Items.Clear()
            LoadPOUnit()
            'Load POUnitItem2
            Item.DropDownPOUnit2.Items.Clear()
            LoadPOUnit2()
        End If
    End Sub
    Private Sub Dg_ItemUnit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_ItemUnit.CellClick
        SendUnitId = Dg_ItemUnit.CurrentRow.Cells(0).Value
        'Select Data 
        Dim DataUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & SendUnitId & "'")
        TxtUnitName.Text = DataUnit(0)("ItemUnitName")
        TxtUnit.Text = DataUnit(0)("Multiply")
    End Sub
    Private Sub FrmUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleUnit.LoadDataUnit()
    End Sub
End Class