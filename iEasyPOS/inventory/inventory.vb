Public Class inventory
    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        DataGridViewShowRecive.RowTemplate.Height = 35
        DataGridViewItems.RowTemplate.Height = 35
        DataGridViewShowTake.RowTemplate.Height = 35
        DataGridViewShowTakeItem.RowTemplate.Height = 35


        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        XtraTabMain.SelectedTabPageIndex = 0
        Label3.Image = iEasyPOS.My.Resources.Resources.Icon_ReceiveProductBlue
        Label3.ForeColor = Color.FromArgb(45, 149, 239)
        Label14.Image = iEasyPOS.My.Resources.Resources.Icon_WithdrawProductGray
        Label14.ForeColor = Color.FromArgb(65, 73, 86)

        ModuleInventory.LoadReciveId()
        ModuleInventory.LoadSupplier()
        ModuleInventory.LoadStore()
        ModuleInventory.LoadItemsType()
        ModuleInventory.LoadRadDropDownStatus()
        'AutoCompelete ItemName 
        ModuleInventory.AutoCompeleteSearchItemName()
        'AutoCompelete ItemCode
        ModuleInventory.AutoCompeleteSearchItemId()
        'TxtSrcItemName.Width = GroupBox4.Width * 0.6
        'TxtItemName.Width = GroupBox10.Width * 0.6
        ModuleInventory.LoadDataReciveToGridView()
        'RadDateTimePickerReciveDate.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        'RadDateTimePickerinvoice.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        'DaterimePickerSrcStart.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        'DaterimePickerSrcEnd.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")

        RadDateTimePickerReciveDate.EditValue = Now
        RadDateTimePickerinvoice.EditValue = Now
        DaterimePickerSrcStart.EditValue = Now
        DaterimePickerSrcEnd.EditValue = Now

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

        RadDateTimePickerDateSearchStart.EditValue = Now
        RadDateTimePickerDateSearchEnd.EditValue = Now
        RadDateTimePickerTakeDate.EditValue = Now

        'RadDateTimePickerDateSearchStart.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        'RadDateTimePickerDateSearchEnd.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        'RadDateTimePickerTakeDate.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")

        Panel27.AutoScroll = True
        Panel27.VerticalScroll.Visible = True
        Panel27.HorizontalScroll.Visible = True

        'Panel13.AutoScroll = True
        'Panel13.VerticalScroll.Visible = True
        'Panel13.HorizontalScroll.Visible = True

        'Panel3.Dock = DockStyle.Fill
        'Dim Size = Panel3.Size
        'Panel3.Dock = DockStyle.Top
        'Panel3.Size = Size
    End Sub
    'Private Sub Close_inven_Click(sender As Object, e As EventArgs) Handles Close_inven.Click
    '    Me.Close()
    'End Sub

    Private Sub TxtSearchItemId_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearchItemId.KeyDown
        'Search For ItemId
        If e.KeyCode = Keys.Enter Then
            ModuleInventory.LoadDataFromItemId()
            TxtinitCost.Select()
        End If
    End Sub

    Private Sub TxtSrcItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSrcItemName.KeyDown
        'Search ItemName 
        If e.KeyCode = Keys.Enter Then
            ModuleInventory.LoadDataFromItemName()
            TxtinitCost.Select()
        End If
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
        If e.KeyCode = Keys.Enter Then
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
            End If
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
        TxtSearchItemId.Select()
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
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(edit_spply.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            edit_spply.StartPosition = FormStartPosition.CenterParent
            edit_spply.ShowDialog(plexi)
        End Using
        'edit_spply.Show()
    End Sub

    Private Sub BtnSave2_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleInventory.SaveItems()
    End Sub
    Private Sub BtnClear2_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ModuleInventory.ClearTextAll()
        ModuleInventory.LoadReciveId()
        ModuleInventory.LoadSupplier()
        ModuleInventory.LoadStore()
        ModuleInventory.LoadItemsType()
        ModuleInventory.LoadRadDropDownStatus()
        'Panel13.Enabled = True
    End Sub
    Private Sub DataGridViewShowRecive_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowRecive.CellClick
        ModuleInventory.ShowDetail()
    End Sub

    Private Sub BtnDelete2_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleInventory.DeleteReciveItem()
    End Sub
    Private Sub DataGridViewItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItems.CellClick
        ModuleInventory.ShowDetailItem()
    End Sub

    Private Sub BtnSrc1_Click(sender As Object, e As EventArgs) Handles BtnSrc.Click
        ModuleInventory.BtnSrc()
    End Sub

    'การเบิก
    Private Sub TxtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemCode.KeyDown
        'Search For ItemId
        If e.KeyCode = Keys.Enter Then
            ModuleTake.LoadDataFromItemId()
            TxtAmount.Select()
        End If
    End Sub

    Private Sub TxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemName.KeyDown
        'Search ItemName 
        If e.KeyCode = Keys.Enter Then
            ModuleTake.LoadDataFromItemName()
            TxtAmount.Select()
        End If
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        'Cal sum From Amount 
        ModuleTake.CalculateCostFromAmount()
    End Sub
    Private Sub BtnAddTakeItem_Click(sender As Object, e As EventArgs) Handles BtnAddTakeItem.Click
        ModuleTake.AddItemToDataGridView()
        TxtItemCode.Select()
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
        Panel52.Enabled = True
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
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Edit_Store.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Edit_Store.StartPosition = FormStartPosition.CenterParent
            Edit_Store.ShowDialog(plexi)
        End Using
        'Edit_Store.ShowDialog()
    End Sub

    Private Sub TxtAmountRecive_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAmountRecive.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAddItem.Select()
        End If
    End Sub

    Private Sub TxtAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAddTakeItem.Select()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        XtraTabMain.SelectedTabPageIndex = 0
        Label3.Image = iEasyPOS.My.Resources.Resources.Icon_ReceiveProductBlue
        Label3.ForeColor = Color.FromArgb(45, 149, 239)
        Label14.Image = iEasyPOS.My.Resources.Resources.Icon_WithdrawProductGray
        Label14.ForeColor = Color.FromArgb(65, 73, 86)
    End Sub

    Private Sub Label142_Click(sender As Object, e As EventArgs) Handles Label14.Click
        XtraTabMain.SelectedTabPageIndex = 1
        Label3.Image = iEasyPOS.My.Resources.Resources.Icon_ReceiveProductGray
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Label14.Image = iEasyPOS.My.Resources.Resources.Icon_WithdrawProductBlue
        Label14.ForeColor = Color.FromArgb(45, 149, 239)
    End Sub

    Private Sub RadDropDownUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadDropDownUnit.SelectedIndexChanged
        ModuleInventory.SelectMultiplyUnit()
    End Sub

    Private Sub RadDropDownListItemUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadDropDownListItemUnit.SelectedIndexChanged
        'Search Multoply Unit 
        ModuleTake.SelectMultiplyUnit()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        ModuleInventory.AddItemToDataGridView()
        TxtSearchItemId.Select()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ModuleTake.AddItemToDataGridView()
        TxtItemCode.Select()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ModuleInventory.AddItemToDataGridView()
        TxtSearchItemId.Select()
    End Sub
    Sub change_to_th_text()
        'stock
        PageManagementBrand.Text = My.Resources.inventory_stock_th.stock
        Label3.Text = My.Resources.inventory_stock_th.ReceiptProduct
        Label14.Text = My.Resources.inventory_stock_th.TakeProduct
        Label31.Text = My.Resources.inventory_stock_th.search
        Label34.Text = My.Resources.inventory_stock_th.search
        Label32.Text = My.Resources.inventory_stock_th.seller
        Label4.Text = My.Resources.inventory_stock_th._date
        Label2.Text = My.Resources.inventory_stock_th.todate
        'Label12.Text = My.Resources.inventory_stock_th.detail
        Label11.Text = My.Resources.inventory_stock_th.deliveryNoteNo
        Label6.Text = My.Resources.inventory_stock_th.dateReceipt
        Label5.Text = My.Resources.inventory_stock_th.seller
        Label10.Text = My.Resources.inventory_stock_th.deliveryNoteNo
        Label15.Text = My.Resources.inventory_stock_th.ShippingDate
        Label13.Text = My.Resources.inventory_stock_th.TaxID
        Label8.Text = My.Resources.inventory_stock_th.status
        Label24.Text = My.Resources.inventory_stock_th.productCode
        Label20.Text = My.Resources.inventory_stock_th.productName
        Label19.Text = My.Resources.inventory_stock_th.unit
        Label23.Text = My.Resources.inventory_stock_th.costbeforetax
        Label18.Text = My.Resources.inventory_stock_th.costaftertax
        Label36.Text = My.Resources.inventory_stock_th.Canfillout
        Label35.Text = My.Resources.inventory_stock_th.Canfillout
        Label43.Text = My.Resources.inventory_stock_th.Canfillout
        Label44.Text = My.Resources.inventory_stock_th.Canfillout
        Label38.Text = My.Resources.inventory_stock_th.Canfillout
        Label22.Text = My.Resources.inventory_stock_th.amount
        Label16.Text = My.Resources.inventory_stock_th.balance
        Label17.Text = My.Resources.inventory_stock_th.totalPrice
        Label21.Text = My.Resources.inventory_stock_th.costing
        Label41.Text = My.Resources.inventory_stock_th.Afterfillingout
        SimpleButton1.Text = My.Resources.inventory_stock_th.addItem
        Label29.Text = My.Resources.inventory_stock_th.subTotal
        Label28.Text = My.Resources.inventory_stock_th.total
        BtnClear.Text = My.Resources.inventory_stock_th.clearText
        BtnDelete.Text = My.Resources.inventory_stock_th.del
        BtnSave.Text = My.Resources.inventory_stock_th.save
        Label9.Text = My.Resources.inventory_stock_th.producttype
        LabelUnit.Text = My.Resources.inventory_stock_th.unit

        DataGridViewShowRecive.Columns(0).HeaderText = My.Resources.inventory_stock_th._date
        DataGridViewShowRecive.Columns(1).HeaderText = My.Resources.inventory_stock_th.receiptNo
        DataGridViewShowRecive.Columns(2).HeaderText = My.Resources.inventory_stock_th.seller
        DataGridViewShowRecive.Columns(3).HeaderText = My.Resources.inventory_stock_th.status

        DataGridViewItems.Columns(0).HeaderText = My.Resources.inventory_stock_th.productCode
        DataGridViewItems.Columns(1).HeaderText = My.Resources.inventory_stock_th.productName
        DataGridViewItems.Columns(2).HeaderText = My.Resources.inventory_stock_th.unit
        DataGridViewItems.Columns(3).HeaderText = My.Resources.inventory_stock_th.costperunit
        DataGridViewItems.Columns(4).HeaderText = My.Resources.inventory_stock_th.costpercostunit
        DataGridViewItems.Columns(5).HeaderText = My.Resources.inventory_stock_th.qty
        DataGridViewItems.Columns(6).HeaderText = My.Resources.inventory_stock_th.costing
        DataGridViewItems.Columns(7).HeaderText = My.Resources.inventory_stock_th.costaftertax

        Label71.Text = My.Resources.inventory_stock_th.search
        Label72.Text = My.Resources.inventory_take_th.requisitionType
        Label70.Text = My.Resources.inventory_take_th._date
        Label69.Text = My.Resources.inventory_take_th._to
        Label67.Text = My.Resources.inventory_take_th.detail
        Label66.Text = My.Resources.inventory_take_th.requisitionNo
        Label45.Text = My.Resources.inventory_take_th.Canfillout
        Label61.Text = My.Resources.inventory_take_th.requisitionTitle
        Label63.Text = My.Resources.inventory_take_th.requisitionType
        Label62.Text = My.Resources.inventory_take_th.status
        Label65.Text = My.Resources.inventory_take_th.requisitionDate
        Label58.Text = My.Resources.inventory_take_th.detail
        Label56.Text = My.Resources.inventory_take_th.prodcutCode
        Label54.Text = My.Resources.inventory_take_th.productName
        Label53.Text = My.Resources.inventory_take_th.unit
        Label52.Text = My.Resources.inventory_take_th.costperunit
        Label50.Text = My.Resources.inventory_take_th.Canfillout
        Label51.Text = My.Resources.inventory_take_th.Canfillout
        Label55.Text = My.Resources.inventory_take_th.Canfillout
        Label49.Text = My.Resources.inventory_take_th.unit
        Label48.Text = My.Resources.inventory_take_th.balance
        Label39.Text = My.Resources.inventory_take_th.Afterfillingout
        SimpleButton2.Text = My.Resources.inventory_take_th.addItem
        Label40.Text = My.Resources.inventory_take_th.total
        BtnAddNewTake.Text = My.Resources.inventory_take_th.clearTExt
        BtnDeleteData.Text = My.Resources.inventory_take_th.del
        BtnSaveData.Text = My.Resources.inventory_take_th.save

        DataGridViewShowTake.Columns(0).HeaderText = My.Resources.inventory_take_th._date
        DataGridViewShowTake.Columns(1).HeaderText = My.Resources.inventory_take_th.requisitionNo
        DataGridViewShowTake.Columns(2).HeaderText = My.Resources.inventory_take_th.requisitionType

        DataGridViewShowTakeItem.Columns(0).HeaderText = My.Resources.inventory_take_th.prodcutCode
        DataGridViewShowTakeItem.Columns(1).HeaderText = My.Resources.inventory_take_th.productName
        DataGridViewShowTakeItem.Columns(2).HeaderText = My.Resources.inventory_take_th.unit
        DataGridViewShowTakeItem.Columns(3).HeaderText = My.Resources.inventory_take_th.costperunit
        DataGridViewShowTakeItem.Columns(4).HeaderText = My.Resources.inventory_take_th.amount
        DataGridViewShowTakeItem.Columns(5).HeaderText = My.Resources.inventory_take_th.totalCost

    End Sub

    Sub change_to_eng_text()
        'stock
        PageManagementBrand.Text = My.Resources.inventory_stock_en.stock
        Label3.Text = My.Resources.inventory_stock_en.ReceiptProduct
        Label14.Text = My.Resources.inventory_stock_en.TakeProduct
        Label31.Text = My.Resources.inventory_stock_en.search
        Label34.Text = My.Resources.inventory_stock_en.search
        Label32.Text = My.Resources.inventory_stock_en.seller
        Label4.Text = My.Resources.inventory_stock_en._date
        Label2.Text = My.Resources.inventory_stock_en.todate
        ' Label12.Text = My.Resources.inventory_stock_en.detail
        Label11.Text = My.Resources.inventory_stock_en.receiptNo
        Label6.Text = My.Resources.inventory_stock_en.dateReceipt
        Label5.Text = My.Resources.inventory_stock_en.seller
        Label10.Text = My.Resources.inventory_stock_en.deliveryNoteNo
        Label15.Text = My.Resources.inventory_stock_en.ShippingDate
        Label13.Text = My.Resources.inventory_stock_en.TaxID
        Label8.Text = My.Resources.inventory_stock_en.status
        Label24.Text = My.Resources.inventory_stock_en.productCode
        Label20.Text = My.Resources.inventory_stock_en.productName
        Label19.Text = My.Resources.inventory_stock_en.unit
        Label23.Text = My.Resources.inventory_stock_en.costbeforetax
        Label18.Text = My.Resources.inventory_stock_en.costaftertax
        Label36.Text = My.Resources.inventory_stock_en.Canfillout
        Label35.Text = My.Resources.inventory_stock_en.Canfillout
        Label43.Text = My.Resources.inventory_stock_en.Canfillout
        Label44.Text = My.Resources.inventory_stock_en.Canfillout
        Label38.Text = My.Resources.inventory_stock_en.Canfillout
        Label22.Text = My.Resources.inventory_stock_en.amount
        Label16.Text = My.Resources.inventory_stock_en.balance
        Label17.Text = My.Resources.inventory_stock_en.totalPrice
        Label21.Text = My.Resources.inventory_stock_en.costing
        Label41.Text = My.Resources.inventory_stock_en.Afterfillingout
        SimpleButton1.Text = My.Resources.inventory_stock_en.addItem
        Label29.Text = My.Resources.inventory_stock_en.subTotal
        Label28.Text = My.Resources.inventory_stock_en.total
        BtnClear.Text = My.Resources.inventory_stock_en.clearText
        BtnDelete.Text = My.Resources.inventory_stock_en.del
        BtnSave.Text = My.Resources.inventory_stock_en.save
        Label9.Text = My.Resources.inventory_stock_en.producttype
        LabelUnit.Text = My.Resources.inventory_stock_en.unit

        DataGridViewShowRecive.Columns(0).HeaderText = My.Resources.inventory_stock_en._date
        DataGridViewShowRecive.Columns(1).HeaderText = My.Resources.inventory_stock_en.receiptNo
        DataGridViewShowRecive.Columns(2).HeaderText = My.Resources.inventory_stock_en.seller
        DataGridViewShowRecive.Columns(3).HeaderText = My.Resources.inventory_stock_en.status

        DataGridViewItems.Columns(0).HeaderText = My.Resources.inventory_stock_en.productCode
        DataGridViewItems.Columns(1).HeaderText = My.Resources.inventory_stock_en.productName
        DataGridViewItems.Columns(2).HeaderText = My.Resources.inventory_stock_en.unit
        DataGridViewItems.Columns(3).HeaderText = My.Resources.inventory_stock_en.costperunit
        DataGridViewItems.Columns(4).HeaderText = My.Resources.inventory_stock_en.costpercostunit
        DataGridViewItems.Columns(5).HeaderText = My.Resources.inventory_stock_en.qty
        DataGridViewItems.Columns(6).HeaderText = My.Resources.inventory_stock_en.costing
        DataGridViewItems.Columns(7).HeaderText = My.Resources.inventory_stock_en.costaftertax
    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint

    End Sub
End Class