Public Class FrmAddMaterialToItem

    Private Sub BtnCanCel_Click(sender As Object, e As EventArgs) Handles BtnCanCel.Click
        Me.Close()
    End Sub
    Private Sub FrmAddMaterialToItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Material 
        'ModuleMaterailAddToItem.LoadFromAddMaterialToItem()
        LoadComboboxUnitUseMaterial()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'Add Material to Dg_Fomula
        'If TxtTakeAmount.Text = "" Then
        '    Exit Sub
        'ElseIf TxtTakeAmount.Text <> ""
        '    'Insert Into Receipe
        '    If ModuleItems.SaveMaterialItem() = "NotInsert" Then
        '        MsgBox("มีวัตถุดิบนี้อยู่แล้ว")
        '        Exit Sub
        '    ElseIf ModuleItems.SaveMaterialItem() <> "Insert" Then
        '        'ModuleMaterailAddToItem.AddMaterialToDataGridViewMaterial()
        '        'ModuleMaterailAddToItem.CalculateCostMaterial()
        '    End If
        'End If
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Sub LoadComboboxUnitUseMaterial()
        Dim MatId As Integer = Item.MatId

        Dim DataUnitUseMaterail As DataTable = executesql("SELECT ItemUnitId,ItemUnitName FROM ItemUnit")
        ComboBoxUnitUseMaterial.DataSource = DataUnitUseMaterail
        ComboBoxUnitUseMaterial.DisplayMember = "ItemUnitName"
        ComboBoxUnitUseMaterial.ValueMember = "ItemUnitId"
    End Sub
End Class