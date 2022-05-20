Public Class FrmUnit
    Public Shared SendUnitId As Integer
    Private Sub FrmUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        Dg_ItemUnit.RowTemplate.Height = 35
        ModuleUnit.LoadDataUnit()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        SendUnitId = 0
        ModuleUnit.ClearUnitData()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Add Unit 
        If SendUnitId = Nothing Then
            ModuleUnit.AddUnit()
            Item.DropDownUnitItem.Properties.Items.Clear()
            LoadUnit()
            'Load POUnitItem 
            Item.DropDownPOUnit.Properties.Items.Clear()
            LoadPOUnit()
            'Load POUnitItem2
            Item.DropDownPOUnit2.Properties.Items.Clear()
            LoadPOUnit2()
        ElseIf SendUnitId <> Nothing Then
            ModuleUnit.UpdateUnit()
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

    Sub change_to_th_text()
        Dg_ItemUnit.Columns(1).HeaderText = My.Resources.unit_th.unit
        Dg_ItemUnit.Columns(2).HeaderText = My.Resources.unit_th.multiply

        BtnAdd.Text = My.Resources.unit_th.cleartext
        Label1.Text = My.Resources.unit_th.detail
        Label2.Text = My.Resources.unit_th.unit
        Label5.Text = My.Resources.unit_th.multiply
        BtnSave.Text = My.Resources.unit_th.save
    End Sub

    Sub change_to_eng_text()
        Dg_ItemUnit.Columns(1).HeaderText = My.Resources.unit_en.unit
        Dg_ItemUnit.Columns(2).HeaderText = My.Resources.unit_en.multiply

        BtnAdd.Text = My.Resources.unit_en.cleartext
        Label1.Text = My.Resources.unit_en.detail
        Label2.Text = My.Resources.unit_en.unit
        Label5.Text = My.Resources.unit_en.multiply
        BtnSave.Text = My.Resources.unit_en.save
    End Sub
End Class