Public Class inventory
    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleInventory.LoadReciveId()
        ModuleInventory.LoadSupplier()
        ModuleInventory.LoadStore()
        ModuleInventory.LoadItemsType()
        ModuleInventory.LoadRadDropDownStatus()
        'AutoCompelete ItemName 
        ModuleInventory.AutoCompeleteSearchItemName()
        'AutoCompelete ItemCode
        ModuleInventory.AutoCompeleteSearchItemId()
        TxtSrcItemName.Width = GroupBox4.Width * 0.6
        TxtItemName.Width = GroupBox10.Width * 0.6
        ModuleInventory.LoadDataReciveToGridView()
        RadDateTimePickerReciveDate.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        RadDateTimePickerinvoice.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        DaterimePickerSrcStart.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        DaterimePickerSrcEnd.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")

        'เบิก
        ModuleTake.LoadTakeId()
        ModuleTake.LoadStore()
        ModuleTake.LoadTakeType()
        ModuleTake.LoadRadDropDownStatus()
        'AutoCompelete ItemName 
        ModuleTake.AutoCompeleteSearchItemName()
        'AutoCompelete ItemCode
        ModuleTake.AutoCompeleteSearchItemId()
        ModuleTake.LoadDataReciveToGridView()
        RadDateTimePickerDateSearchStart.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        RadDateTimePickerDateSearchEnd.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        RadDateTimePickerTakeDate.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
    End Sub
    Private Sub Close_inven_Click(sender As Object, e As EventArgs) Handles Close_inven.Click
        Me.Close()
    End Sub

    Private Sub TxtSearchItemId_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearchItemId.KeyDown
        'Search For ItemId
        'If e.KeyCode = Keys.Enter Then
        ModuleInventory.LoadDataFromItemId()
        'End If
    End Sub

    Private Sub TxtSrcItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSrcItemName.KeyDown
        'Search ItemName 
        ' If e.KeyCode = Keys.Enter Then
        ModuleInventory.LoadDataFromItemName()
        'End If
    End Sub
    Private Sub RadDropDownUnit_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownUnit.SelectedIndexChanged
        'Search Multoply Unit 
        ModuleInventory.SelectMultiplyUnit()
    End Sub

    'Private Sub TxtExtaxCost_TextChanged(sender As Object, e As EventArgs) Handles TxtExtaxCost.TextChanged
    '    'ทุนก่อนภาษี
    '    ModuleInventory.CalculateInitCost()
    'End Sub

    'Private Sub TxtinitCost_TextChanged(sender As Object, e As EventArgs) Handles TxtinitCost.TextChanged
    '    'ทุนรวมภาษี
    '    ModuleInventory.CalculateSumCost()
    'End Sub
    Private Sub TxtinitCost_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtinitCost.KeyDown
        If TxtinitCost.Text <> "" Then
            'Dim txt_TxtinitCost As String = TxtinitCost.Text
            'For Each txt_number As String In txt_TxtinitCost
            '    If Not IsNumeric(txt_number) Then
            '        MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        TxtinitCost.Clear()
            '        TxtinitCost.Focus()
            '        Exit Sub
            '        Exit For
            '    End If
            'Next
            'ModuleInventory.CalculateSumCost()
        End If
    End Sub
    Private Sub TxtAmountRecive_TextChanged(sender As Object, e As EventArgs) Handles TxtAmountRecive.TextChanged
        'Cal sum From Amount'
        If TxtExtaxCost.Text = "" Then
            Exit Sub
        End If
        ModuleInventory.CalculateCostFromAmount()
    End Sub
    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        ModuleInventory.AddItemToDataGridView()
    End Sub

    'Private Sub TxtExtaxCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExtaxCost.KeyPress
    '    'Check Data Keypress 
    '    If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ControlChars.Back) Then
    '        MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub TxtinitCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtinitCost.KeyPress
    '    'Check Data Keypress 
    '    If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ControlChars.Back) Then
    '        MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        e.Handled = True
    '    End If
    'End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        'SaveItems()
    End Sub

    Private Sub btn_edit_supply_Click(sender As Object, e As EventArgs) Handles btn_edit_supply.Click
        edit_spply.Show()
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleInventory.SaveItems()
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ModuleInventory.ClearTextAll()
        ModuleInventory.LoadReciveId()
        ModuleInventory.LoadSupplier()
        ModuleInventory.LoadStore()
        ModuleInventory.LoadItemsType()
        ModuleInventory.LoadRadDropDownStatus()
    End Sub
    Private Sub DataGridViewShowRecive_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowRecive.CellClick
        ModuleInventory.ShowDetail()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleInventory.DeleteReciveItem()
    End Sub
    Private Sub DataGridViewItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItems.CellClick
        ModuleInventory.ShowDetailItem()
    End Sub

    Private Sub BtnSrc_Click(sender As Object, e As EventArgs) Handles BtnSrc.Click
        ModuleInventory.BtnSrc()
    End Sub

    'การเบิก
    Private Sub TxtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemCode.KeyDown
        'Search For ItemId
        'If e.KeyCode = Keys.Enter Then
        ModuleTake.LoadDataFromItemId()
        'End If
    End Sub

    Private Sub TxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemName.KeyDown
        'Search ItemName 
        ' If e.KeyCode = Keys.Enter Then
        ModuleTake.LoadDataFromItemName()
        'End If
    End Sub
    Private Sub RadDropDownListItemUnit_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownListItemUnit.SelectedIndexChanged
        'Search Multoply Unit 
        ModuleTake.SelectMultiplyUnit()
    End Sub
    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        'Cal sum From Amount 
        ModuleTake.CalculateCostFromAmount()
    End Sub
    Private Sub BtnAddTakeItem_Click(sender As Object, e As EventArgs) Handles BtnAddTakeItem.Click
        ModuleTake.AddItemToDataGridView()
    End Sub

    Private Sub BtnSaveData_Click(sender As Object, e As EventArgs) Handles BtnSaveData.Click
        ModuleTake.SaveItems()
    End Sub
    Private Sub DataGridViewShowTake_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowTake.CellClick
        ModuleTake.ShowDetail()
    End Sub

    Private Sub BtnAddNewTake_Click(sender As Object, e As EventArgs) Handles BtnAddNewTake.Click
        ModuleTake.ClearTextAll()
        ModuleTake.LoadStore()
        ModuleTake.LoadRadDropDownStatus()
        ModuleTake.LoadTakeId()
        ModuleTake.LoadTakeType()
        ModuleTake.LoadRadDropDownStatus()
        ModuleTake.LoadDataReciveToGridView()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModuleTake.BtnSrc()
    End Sub

    Private Sub BtnDeleteData_Click(sender As Object, e As EventArgs) Handles BtnDeleteData.Click
        ModuleTake.DeleteReciveItem()
    End Sub

    Private Sub DataGridViewShowTakeItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowTakeItem.CellClick
        ModuleTake.ShowDetailItem()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btn_edit_store_Click(sender As Object, e As EventArgs) Handles btn_edit_store.Click
        Edit_Store.ShowDialog()
    End Sub

    Private Sub TxtinitCost_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtinitCost.KeyUp
        If TxtinitCost.Text <> "" Then
            Dim txt_TxtinitCost As String = TxtinitCost.Text
            For Each txt_number As String In txt_TxtinitCost
                If Not IsNumeric(txt_number) Then
                    MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxtinitCost.Clear()
                    TxtinitCost.Focus()
                    Exit Sub
                    Exit For
                End If
            Next
            ModuleInventory.CalculateSumCost()
            If e.KeyCode = Keys.Enter Then
                TxtAmountRecive.Focus()
            End If
        End If
    End Sub
End Class