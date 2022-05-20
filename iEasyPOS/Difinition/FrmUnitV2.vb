Public Class FrmUnitV2
    Public Shared SendUnitId As Integer
    Private Sub FrmUnitV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dg_ItemUnit.RowTemplate.Height = 35
        ModuleUnitV2.LoadDataUnit()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        SendUnitId = 0
        ModuleUnitV2.ClearUnitData()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Add Unit 
        If SendUnitId = Nothing Then
            ModuleUnitV2.AddUnit()
            Item.DropDownUnitItem.Properties.Items.Clear()
            LoadUnit()
            'Load POUnitItem 
            Item.DropDownPOUnit.Properties.Items.Clear()
            LoadPOUnit()
            'Load POUnitItem2
            Item.DropDownPOUnit2.Properties.Items.Clear()
            LoadPOUnit2()
        ElseIf SendUnitId <> Nothing Then
            ModuleUnitV2.UpdateUnit()
            Item.DropDownUnitItem.Properties.Items.Clear()
            LoadUnit()
            'Load POUnitItem 
            Item.DropDownPOUnit.Properties.Items.Clear()
            LoadPOUnit()
            'Load POUnitItem2
            Item.DropDownPOUnit2.Properties.Items.Clear()
            LoadPOUnit2()
        End If
    End Sub
    Private Sub Dg_ItemUnit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_ItemUnit.CellClick
        SendUnitId = Dg_ItemUnit.CurrentRow.Cells(0).Value
        'Select Data 
        Dim DataUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & SendUnitId & "'")
        TxtUnitName.Text = DataUnit(0)("ItemUnitName")
        TxtUnit.Text = FormatNumber(DataUnit(0)("Multiply"), 2)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub
End Class