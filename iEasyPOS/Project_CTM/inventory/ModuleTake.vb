Module ModuleTake
    Sub LoadTakeId()
        Dim DataTake As DataTable = executesql("SELECT MAX(TakeId) FROM TakeItem")
        If IsNothing(DataTake) Then

        End If
        Dim CountTake As DataTable = executesql("SELECT COUNT(TakeId) FROM TakeItem")
        If IsNothing(CountTake) Then

        End If
        Dim TakeId As String
        Dim MaxreciveId As String
        Dim DateTake As String = Convert.ToDateTime(Now).ToString("ddMM", New System.Globalization.CultureInfo("th-TH"))
        'If Null DB 
        If DataTake.Rows.Count = 0 Then
            MaxreciveId = "1"
            TakeId = DateTake + MaxreciveId
            inventory.TxtTakeId.Text = TakeId
            'Not Null DB
        ElseIf DataTake.Rows.Count > 0 Then
            MaxreciveId = CountTake(0)(0)
            TakeId = DateTake + MaxreciveId
            inventory.TxtTakeId.Text = TakeId + 1
        End If
    End Sub
    Sub LoadStore()
        Dim DataStore As DataTable = executesql("SELECT StockName FROM Stock")
        'Check DBNull
        If IsNothing(DataStore) Then
            Exit Sub
        End If
        Dim RowsDataStore As Integer = DataStore.Rows.Count
        Dim i As Integer
        inventory.RadDropDownListStore.Items.Clear()
        For i = 0 To RowsDataStore - 1
            inventory.RadDropDownListStore.Items.Add(DataStore(i)("StockName"))
        Next
    End Sub
    Sub LoadTakeType()
        Dim DataTypeItems As DataTable = executesql("SELECT TakeTypeName FROM TakeType")
        If IsNothing(DataTypeItems) Then
            Exit Sub
        End If
        'Check DBNull
        If DataTypeItems.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim RowsDataTypeItems As Integer = DataTypeItems.Rows.Count
        Dim i As Integer
        inventory.RadDropDownListTakeType.Items.Clear()
        For i = 0 To RowsDataTypeItems - 1
            inventory.RadDropDownListTakeTypeSearch.Items.Add(DataTypeItems(i)("TakeTypeName"))
            inventory.RadDropDownListTakeType.Items.Add(DataTypeItems(i)("TakeTypeName"))
        Next
    End Sub
    Sub LoadRadDropDownStatus()
        Dim DataStatus As DataTable = executesql("SELECT StatusName FROM StatusSystem")
        If IsNothing(DataStatus) Then
            Exit Sub
        End If
        Dim RowsDataStatus As Integer = DataStatus.Rows.Count
        Dim i As Integer
        inventory.RadDropDownListStatus.Items.Clear()
        For i = 0 To RowsDataStatus - 1
            inventory.RadDropDownListStatus.Items.Add(DataStatus(i)("StatusName"))
        Next
    End Sub
    'AutoComplete
    Sub AutoCompeleteSearchItemId()
        inventory.TxtItemCode.AutoCompleteMode = AutoCompleteMode.Suggest
        inventory.TxtItemCode.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionId As New AutoCompleteStringCollection()
        getDataItemId(DataCollectionId)
        inventory.TxtItemCode.AutoCompleteCustomSource = DataCollectionId
    End Sub
    Private Sub getDataItemId(ByVal dataCollectionId As AutoCompleteStringCollection)
        'Create the list to use as the custom source
        Dim MySource As New AutoCompleteStringCollection()
        Dim DataItemSearchId As DataTable = executesql("SELECT ItemCode,ItemName FROM Item WHERE Active=1")
        If IsNothing(DataItemSearchId) Then
            Exit Sub
        End If
        Dim RowsDataItemSearch As Integer = DataItemSearchId.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim ItemCode As String = DataItemSearchId(i)("ItemCode")
            Dim Itemname As String = DataItemSearchId(i)("ItemCode")
            dataCollectionId.Add(ItemCode)
        Next
    End Sub
    Sub AutoCompeleteSearchItemName()
        inventory.TxtItemName.AutoCompleteMode = AutoCompleteMode.Suggest
        inventory.TxtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionName As New AutoCompleteStringCollection()
        getDataItemName(DataCollectionName)
        inventory.TxtItemName.AutoCompleteCustomSource = DataCollectionName
    End Sub
    Private Sub getDataItemName(ByVal dataCollectionName As AutoCompleteStringCollection)
        'Create the list to use as the custom source
        Dim MySource As New AutoCompleteStringCollection()
        Dim DataItemSearchName As DataTable = executesql("SELECT ItemCode,ItemName FROM Item WHERE Active=1")
        If IsNothing(DataItemSearchName) Then
            Exit Sub
        End If
        Dim RowsDataItemSearch As Integer = DataItemSearchName.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim ItemCode As String = DataItemSearchName(i)("ItemCode")
            Dim Itemname As String = DataItemSearchName(i)("ItemName")
            dataCollectionName.Add(Itemname)
        Next
    End Sub
    Sub BtnSrc()
        Dim TakeId As String = inventory.txtSearch.Text
        Dim TakeType As String = inventory.RadDropDownListTakeTypeSearch.Text
        Dim StartDate As String = Format(inventory.RadDateTimePickerDateSearchStart.Value, "yyyy-MM-dd 00:00:00")
        Dim EndDate As String = Format(inventory.RadDateTimePickerDateSearchEnd.Value, "yyyy-MM-dd 23:59:5")
        If TakeId = "" And TakeType = "" Then
            Dim Src As DataTable = executesql("SELECT TakeId,TakeDate,TakeTypeId FROM Take WHERE TakeDate BETWEEN'" & StartDate & "' AND '" & EndDate & "'")
            If IsNothing(Src) Then
                Exit Sub
            End If
            inventory.DataGridViewShowTake.Rows.Clear()
            For i As Integer = 0 To Src.Rows.Count - 1
                Dim TakeTypeName As DataTable = executesql("SELECT TakeTypeName FROM TakeType WHERE TakeTypeId='" & Src(i)("TakeTypeId") & "'")
                inventory.DataGridViewShowTake.Rows.Add(Format(Src(i)("TakeDate"), "dd/MM/yyyy"), Src(i)("TakeId"), TakeTypeName(i)("TakeTypeName"))
            Next
            Exit Sub
        End If
        If TakeId <> "" And TakeType = "" Then
            Dim Src As DataTable = executesql("SELECT TakeId,TakeDate,TakeTypeId FROM Take WHERE TakeDate BETWEEN '" & StartDate & "' AND '" & EndDate & "' AND TakeId LIKE '%" & TakeId & "%'")
            If IsNothing(Src) Then
                Exit Sub
            End If
            inventory.DataGridViewShowTake.Rows.Clear()
            For i As Integer = 0 To Src.Rows.Count - 1
                Dim TakeTypeName As DataTable = executesql("SELECT TakeTypeName FROM TakeType WHERE TakeTypeId='" & Src(i)("TakeTypeId") & "'")
                inventory.DataGridViewShowTake.Rows.Add(Convert.ToDateTime(Src(i)("TakeDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), Src(i)("TakeId"), TakeTypeName(i)("TakeTypeName"))
            Next
            Exit Sub
        End If
        If TakeId = "" And TakeType <> "" Then
            Dim SupName As DataTable = executesql("SELECT TakeTypeId FROM TakeType WHERE TakeTypeName='" & TakeType & "'")
            If IsNothing(SupName) Then
                Exit Sub
            End If
            Dim Src As DataTable = executesql("SELECT TakeId,TakeDate,TakeTypeId FROM Take WHERE TakeDate BETWEEN '" & StartDate & "' AND '" & EndDate & "' AND TakeTypeId = '" & SupName(0)("TakeTypeId") & "'")
            inventory.DataGridViewShowTake.Rows.Clear()
            For i As Integer = 0 To Src.Rows.Count - 1
                inventory.DataGridViewShowTake.Rows.Add(Convert.ToDateTime(Src(i)("TakeDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), Src(i)("TakeId"), TakeType)
            Next
            Exit Sub
        End If
    End Sub
    Sub LoadDataFromItemId()
        Dim ItemId As String
        Dim ItemName As String
        txtItemCode = inventory.TxtItemCode.Text
        'Search From ItemCode
        If inventory.TxtItemCode.Text <> "" And inventory.TxtItemName.Text = "" Then
            ItemId = inventory.TxtItemCode.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemCode='" & ItemId & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            inventory.TxtItemName.Text = DataItemSearch(0)("ItemName")
            Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            inventory.LUnit.Text = Unit(0)("ItemUnitName")
            'select Cost
            Dim selectUnitCost As DataTable = executesql("SELECT UnitCost FROM Costing WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            If selectUnitCost.Rows.Count = 0 Then
                MsgBox("กรุณารับเข้าสินค้าก่อน !!", MsgBoxStyle.Critical, "คำเตือน")
                ClearTextAll()
                Exit Sub
            End If
            If IsDBNull(selectUnitCost(0)("UnitCost")) Then
                MsgBox("กรุณารับเข้าสินค้าก่อน !!", MsgBoxStyle.Critical, "คำเตือน")
                ClearTextAll()
                Exit Sub
            End If
            inventory.TxtUnitCost.Text = FormatNumber(selectUnitCost(0)("UnitCost"), 3)

            'Add Unit To RadDropDown
            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")

            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtStock.Text = 0
            Else
                inventory.TxtStock.Text = FormatNumber(BalanceAmount(0)("Qty"), 3)
            End If
            inventory.RadDropDownListItemUnit.Items.Clear()
            For i As Integer = 0 To USUnitIdName.Rows.Count - 1
                inventory.RadDropDownListItemUnit.Items.Add(USUnitIdName(i)("ItemUnitName"))
            Next

        ElseIf inventory.TxtItemName.Text <> "" And inventory.TxtItemCode.Text = "" Then
            ItemName = inventory.TxtItemName.Text
            Dim DataItemId As DataTable = executesql("SELECT ItemCode FROM Item WHERE ItemName='" & ItemName & "' AND Active=1")
            If IsNothing(DataItemId) Then
                Exit Sub
            End If
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemCode,USUnitId,POUnitId,POUnitId2 FROM Item WHERE ItemName='" & ItemName & "'")
            If IsNothing(DataItemSearch) = 0 Then
                Exit Sub
            End If
            inventory.TxtItemCode.Text = DataItemSearch(0)("ItemCode")
            Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            inventory.LUnit.Text = Unit(0)("UnitUseName")
            'select Cost
            Dim selectUnitCost As DataTable = executesql("SELECT UnitCost FROM Costing WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            inventory.TxtUnitCost.Text = FormatNumber(selectUnitCost(0)("UnitCost"), 3)
            'Add Unit To RadDropDown
            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & DataItemId(0)(0) & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")

            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtStock.Text = 0
            Else
                inventory.TxtStock.Text = FormatNumber(BalanceAmount(0)("Qty"), 3)
            End If
            inventory.RadDropDownListItemUnit.Items.Clear()
            For i As Integer = 0 To USUnitIdName.Rows.Count - 1
                inventory.RadDropDownListItemUnit.Items.Add(USUnitIdName(0)("UnitUsename"))
            Next

        ElseIf inventory.TxtItemName.Text <> "" And inventory.TxtItemCode.Text <> "" Then
            ItemId = inventory.TxtItemCode.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemCode='" & ItemId & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            inventory.TxtItemName.Text = DataItemSearch(0)("ItemName")
            inventory.TxtItemCode.Text = DataItemSearch(0)("ItemCode")
            Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            inventory.LUnit.Text = Unit(0)("ItemUnitName")
            'select Cost
            Dim selectUnitCost As DataTable = executesql("SELECT UnitCost FROM Costing WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            inventory.TxtUnitCost.Text = FormatNumber(selectUnitCost(0)("UnitCost"), 3)
            'Add Unit To RadDropDown
            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")

            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtStock.Text = 0
            Else
                inventory.TxtStock.Text = FormatNumber(BalanceAmount(0)("Qty"), 3)
            End If
            inventory.RadDropDownListItemUnit.Items.Clear()
            For i As Integer = 0 To USUnitIdName.Rows.Count - 1
                inventory.RadDropDownListItemUnit.Items.Add(USUnitIdName(0)("ItemUnitName"))
            Next
        End If
    End Sub
    Sub LoadDataFromItemName()
        'Dim ItemId As String
        Dim ItemName As String
        If inventory.TxtItemName.Text <> "" And inventory.TxtItemCode.Text = "" Then
            ItemName = inventory.TxtItemName.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemName='" & ItemName & "'")
            If DataItemSearch.Rows.Count = 0 Then
                'MsgBox("1")
                Exit Sub
            End If
            inventory.TxtItemName.Text = DataItemSearch(0)("ItemName")
            inventory.TxtItemCode.Text = DataItemSearch(0)("ItemCode")
            Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            inventory.LUnit.Text = Unit(0)("ItemUnitName")
            'select Cost
            Dim selectUnitCost As DataTable = executesql("SELECT UnitCost FROM Costing WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            If selectUnitCost.Rows.Count = 0 Then
                inventory.TxtUnitCost.Text = "0"
            Else
                inventory.TxtUnitCost.Text = FormatNumber(selectUnitCost(0)("UnitCost"), 3)
            End If

            'Add Unit To RadDropDown
            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & DataItemSearch(0)(1) & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")
            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtStock.Text = 0
            Else
                inventory.TxtStock.Text = FormatNumber(BalanceAmount(0)("Qty"), 3)
            End If
            inventory.RadDropDownListItemUnit.Items.Clear()
            For i As Integer = 0 To USUnitIdName.Rows.Count - 1
                inventory.RadDropDownListItemUnit.Items.Add(USUnitIdName(0)("ItemUnitName"))
            Next
            'Select Costing 
            Dim DataCosting As DataTable = executesql("SELECT AvgUnitCost FROM Costing WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
        ElseIf inventory.TxtItemName.Text <> "" And inventory.TxtItemCode.Text <> "" Then
            ItemName = inventory.TxtItemName.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemName='" & ItemName & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            inventory.TxtItemName.Text = DataItemSearch(0)("ItemName")
            inventory.TxtItemCode.Text = DataItemSearch(0)("ItemCode")
            Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            inventory.LUnit.Text = Unit(0)("ItemUnitName")
            'select Cost
            Dim selectUnitCost As DataTable = executesql("SELECT UnitCost FROM Costing WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            inventory.TxtUnitCost.Text = FormatNumber(selectUnitCost(0)("UnitCost"), 3)
            'Add Unit To RadDropDown
            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & DataItemSearch(0)(1) & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")

            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtStock.Text = 0
            Else
                inventory.TxtStock.Text = BalanceAmount(0)("Qty")
            End If
            inventory.RadDropDownListItemUnit.Items.Clear()
            For i As Integer = 0 To USUnitIdName.Rows.Count - 1
                inventory.RadDropDownListItemUnit.Items.Add(USUnitIdName(0)("ItemUnitName"))
            Next
        End If
        txtItemCode = inventory.TxtItemCode.Text
    End Sub
    Dim txtItemCode As String
    Sub SelectMultiplyUnit()
        'Select Multiply Unit 
        Dim UnitName As String = inventory.RadDropDownListItemUnit.Text
        Dim selectItemId As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & txtItemCode & "'")
        Dim DataUnitName As DataTable = executesql("SELECT Multiply FROM ItemUnit WHERE ItemUnitName ='" & UnitName & "' AND Active=1")
        If DataUnitName.Rows.Count - 0 Then
            Exit Sub
        End If
        Dim selectStock As DataTable = executesql("SELECT UnitInStock.Qty,ReciveItem.Multiply FROM UnitInStock INNER JOIN ReciveItem ON ReciveItem.ItemCode = UnitInStock.ItemCode INNER JOIN Item ON Item.ItemCode = UnitInStock.ItemCode WHERE Item.ItemCode ='" & txtItemCode & "'")
        If selectStock.Rows.Count = 0 Then
            Exit Sub
        Else
            inventory.TxtStock.Text = FormatNumber(selectStock(0)("Qty") / DataUnitName(0)("Multiply"), 3)
        End If
        inventory.TxtMultiply.Text = FormatNumber(DataUnitName(0)("Multiply"), 2)
        inventory.LUnit.Text = inventory.RadDropDownListItemUnit.Text  'หน่วย
        Dim selectItem As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & txtItemCode & "'")
        Dim selectUnitCost As DataTable = executesql("SELECT AvgUnitCost FROM Costing WHERE ItemId='" & selectItem(0)(0) & "'")

        If IsNothing(selectUnitCost) Then
            Exit Sub
        End If
        inventory.TxtUnitCost.Text = selectUnitCost(0)("AvgUnitCost") * DataUnitName(0)("Multiply")
    End Sub
    Sub CalculateCostFromAmount()
        'Calculate SumCoase From Amount 
        If inventory.TxtUnitCost.Text = "" Or inventory.TxtAmount.Text = "" Then
            Exit Sub
        End If
        For Each txt_number As String In inventory.TxtAmount.Text
            If Not IsNumeric(txt_number) Then
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข", "โปรดระวัง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                inventory.TxtAmount.Clear()
                inventory.TxtAmount.Focus()
                Exit Sub
                Exit For
            End If
        Next
        Dim Amount2 As Decimal = FormatNumber(inventory.TxtAmount.Text, 2)
        Dim Stock As Decimal = FormatNumber(inventory.TxtStock.Text, 2)
        If Amount2 > Stock Then
            MsgBox("จำนวนใน Stock ไม่พอต่อการเบิก", MsgBoxStyle.Critical, "")
            inventory.TxtAmount.Focus()
            inventory.TxtAmount.Clear()
            Exit Sub
        End If
        Dim Amount As Decimal = inventory.TxtAmount.Text
        Dim CostSumTax As Decimal = inventory.TxtUnitCost.Text
        Dim SumCostTotalTax As Decimal = FormatNumber(CostSumTax * Amount, 3)
        inventory.TxtTotalUnitCost.Text = SumCostTotalTax
        Exit Sub
    End Sub
    Sub AddItemToDataGridView()
        'Add item 
        Dim ItemCode As String = inventory.TxtItemCode.Text 'รหัสสินค้า
        Dim ItemName As String = inventory.TxtItemName.Text 'ชื่อสินค้า
        Dim UnitName As String = inventory.RadDropDownListItemUnit.Text 'หน่วย
        Dim CostSumTax As String = inventory.TxtUnitCost.Text 'ต้นทุนต่อหน่วย
        Dim AmountRecive As String = inventory.TxtAmount.Text 'จำนวน
        Dim SumTotalTax As String = inventory.TxtTotalUnitCost.Text 'ต้นทุนรวม
        If ItemCode = "" Or ItemName = "" Or UnitName = "" Or CostSumTax = "" Or AmountRecive = "" Or SumTotalTax = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        inventory.DataGridViewShowTakeItem.Rows.Add(ItemCode, ItemName, UnitName, CostSumTax, AmountRecive, SumTotalTax)
        ClearTxtAndData()

        Dim Total As Decimal
        Dim CountDataGridViewShowTakeItem As Integer = inventory.DataGridViewShowTakeItem.Rows.Count
        Dim i As Integer
        'Cal Vat on ReciveBill
        For i = 0 To CountDataGridViewShowTakeItem - 1
            Total += inventory.DataGridViewShowTakeItem.Rows(i).Cells(5).Value
        Next
        inventory.TxtTotalTakeUnitCost.Text = FormatNumber(Total, 2)
    End Sub
    Sub ClearTxtAndData()
        PercentVat = Nothing
        inventory.TxtItemCode.Text = Nothing
        inventory.TxtItemName.Text = Nothing
        inventory.RadDropDownListItemUnit.Items.Clear()
        inventory.TxtUnitCost.Text = Nothing
        inventory.TxtAmount.Text = Nothing
        inventory.TxtTotalUnitCost.Text = Nothing
        inventory.TxtTotalTakeUnitCost.Text = Nothing
    End Sub
    Sub ClearTextAll()
        PercentVat = Nothing
        inventory.TxtItemCode.Text = Nothing
        inventory.TxtItemName.Text = Nothing
        'inventory.RadDropDownListItemUnit.Items.Clear()
        inventory.TxtMultiply.Text = Nothing
        inventory.TxtUnitCost.Text = Nothing
        inventory.TxtAmount.Text = Nothing
        inventory.TxtStock.Text = Nothing
        inventory.TxtTotalUnitCost.Text = Nothing
        inventory.RadDateTimePickerTakeDate.Value = Date.Now
        inventory.RadDropDownListStore.Text = Nothing
        ' inventory.RadDropDownListStore.Items.Clear()
        inventory.TxtTitle.Text = Nothing
        inventory.TxtTakeDetail.Text = Nothing
        ' inventory.RadDropDownListStatus.Items.Clear()
        inventory.RadDropDownListStatus.Text = Nothing
        'inventory.RadDropDownListTakeType.Items.Clear()
        inventory.RadDropDownListTakeType.Text = Nothing
        inventory.GroupBox6.Enabled = True
        inventory.GroupBox10.Enabled = True
        inventory.TxtTotalTakeUnitCost.Text = Nothing
        inventory.BtnDeleteData.Enabled = True
        inventory.BtnSaveData.Enabled = True
        inventory.DataGridViewShowTakeItem.Rows.Clear()
        inventory.TxtUnitMultiply.Clear()
        CheckReciveId = 0
        LoadTakeId()
    End Sub
    Sub LoadDataReciveToGridView()
        LoadTakeId()
        Dim selectTake As DataTable = executesql("SELECT TakeId,TakeDate,TakeTypeId FROM Take WHERE Active=1")
        If IsNothing(selectTake) Then
            Exit Sub
        End If
        inventory.DataGridViewShowTake.Rows.Clear()
        For i As Integer = 0 To selectTake.Rows.Count - 1
            Dim TakeTypeId As DataTable = executesql("SELECT TakeTypeName FROM TakeType WHERE TakeTypeId = '" & selectTake(i)("TakeTypeId") & "'")
            inventory.DataGridViewShowTake.Rows.Add(Convert.ToDateTime(selectTake(i)("TakeDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), selectTake(i)("TakeId"), TakeTypeId(0)("TakeTypeName"))
        Next
        ClearTextAll()
    End Sub
    Sub ShowDetail()
        If inventory.DataGridViewShowTake.SelectedRows Is Nothing Then
            CheckReciveId = 0
            Exit Sub
        Else
            CheckReciveId = inventory.DataGridViewShowTake.CurrentRow.Cells(1).Value
            Dim selectData As DataTable = executesql("SELECT Take.TakeId,Take.TakeDate,Take.TakeTitle,Take.TakeDetail,TakeType.TakeTypeName,Stock.StockName,StatusSystem.StatusName,Take.TakeTypeId FROM Take INNER JOIN Stock ON Stock.StockId = Take.StockId  INNER JOIN StatusSystem ON StatusSystem.StatusId = Take.StatusId INNER JOIN TakeType ON TakeType.TakeTypeId = Take.TakeTypeId WHERE Take.TakeId='" & CheckReciveId & "'")
            Dim Detail As String
            If selectData(0)("TakeDetail") = "" Then
                Detail = ""
            Else
                Detail = selectData(0)("TakeDetail")
            End If
            inventory.TxtTakeId.Text = CheckReciveId
            inventory.RadDateTimePickerTakeDate.Value = Convert.ToDateTime(selectData(0)("TakeDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            inventory.RadDropDownListStore.Text = selectData(0)("StockName")
            inventory.TxtTitle.Text = selectData(0)("TakeTitle")
            inventory.TxtTakeDetail.Text = Detail
            inventory.RadDropDownListStatus.Text = selectData(0)("StatusName")
            Dim TakeTypeName As DataTable = executesql("SELECT TakeTypeName FROM TakeType WHERE TakeTypeId = '" & selectData(0)("TakeTypeId") & "'")
            inventory.RadDropDownListTakeType.Text = TakeTypeName(0)("TakeTypeName")
            'Dim Total As Decimal
            Dim TotalInVat As Decimal
            Dim selectDataTakeItem As DataTable = executesql("SELECT TakeId,ItemCode,ItemName,CategoryId,CategoryName,CategoryName2,Amount,ItemUnitId,Multiply,UnitCost,TotalUnitCost FROM TakeItem WHERE TakeId='" & CheckReciveId & "'")
            inventory.DataGridViewShowTakeItem.Rows.Clear()
            If selectData(0)("StatusName") = "Approve" Then
                inventory.GroupBox6.Enabled = False
                inventory.GroupBox10.Enabled = False
                inventory.TxtTotalTakeUnitCost.Enabled = False
                inventory.TxtTotalTax.Enabled = False
                inventory.BtnSaveData.Enabled = False
                inventory.BtnDeleteData.Enabled = False
                For i As Integer = 0 To selectDataTakeItem.Rows.Count - 1
                    Dim selectUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & selectDataTakeItem(i)("ItemUnitId") & "'")
                    inventory.DataGridViewShowTakeItem.Rows.Add(selectDataTakeItem(i)("ItemCode"), selectDataTakeItem(i)("ItemName"), selectUnitName(0)("ItemUnitName"), FormatNumber(selectDataTakeItem(i)("UnitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataTakeItem(i)("Amount"), 3), selectDataTakeItem(i)("TotalUnitCost"))
                    TotalInVat += selectDataTakeItem(i)("TotalUnitCost")
                Next
            ElseIf selectData(0)("StatusName") = "Pending" Then
                inventory.GroupBox6.Enabled = True
                inventory.GroupBox10.Enabled = True
                inventory.TxtTotalTakeUnitCost.Enabled = True
                inventory.TxtTotalTax.Enabled = True
                inventory.BtnSaveData.Enabled = True
                inventory.BtnDeleteData.Enabled = True
                For i As Integer = 0 To selectDataTakeItem.Rows.Count - 1
                    Dim selectUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & selectDataTakeItem(i)("ItemUnitId") & "'")
                    inventory.DataGridViewShowTakeItem.Rows.Add(selectDataTakeItem(i)("ItemCode"), selectDataTakeItem(i)("ItemName"), selectUnitName(0)("ItemUnitName"), FormatNumber(selectDataTakeItem(i)("UnitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataTakeItem(i)("Amount"), 3), selectDataTakeItem(i)("TotalUnitCost"))
                    TotalInVat += selectDataTakeItem(i)("TotalUnitCost")
                Next
            ElseIf selectData(0)("StatusName") = "Not Pass" Then
                inventory.GroupBox6.Enabled = False
                inventory.GroupBox10.Enabled = False
                inventory.TxtTotalTakeUnitCost.Enabled = False
                inventory.TxtTotalTax.Enabled = False
                inventory.BtnSaveData.Enabled = False
                inventory.BtnDeleteData.Enabled = False

                For i As Integer = 0 To selectDataTakeItem.Rows.Count - 1
                    Dim selectUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & selectDataTakeItem(i)("ItemUnitId") & "'")

                    inventory.DataGridViewShowTakeItem.Rows.Add(selectDataTakeItem(i)("ItemCode"), selectDataTakeItem(i)("ItemName"), selectUnitName(0)("ItemUnitName"), FormatNumber(selectDataTakeItem(i)("UnitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataTakeItem(i)("Amount"), 3), selectDataTakeItem(i)("TotalUnitCost"))
                    TotalInVat += selectDataTakeItem(i)("TotalUnitCost")
                Next
            End If
            inventory.TxtTotalTakeUnitCost.Text = FormatNumber(TotalInVat, 2)
        End If
    End Sub
    Dim CheckReciveId As Integer
    Sub SaveItems()
        'Insert Items 
        If inventory.TxtTakeId.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.RadDateTimePickerTakeDate.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.RadDropDownListStore.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.TxtTitle.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
            'ElseIf inventory.TxtTakeDetail.Text = "" Then
            '    MsgBox("กรุณากรอกข้อมูลให้ครบ")
            '    Exit Sub
        ElseIf inventory.RadDropDownListStatus.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.RadDropDownListTakeType.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim TakeId As String = inventory.TxtTakeId.Text
        Dim ReciveBill As String = inventory.TxtreciveBill.Text
        Dim TakeTitle As String = inventory.TxtTitle.Text
        Dim TakeDetail As String = inventory.TxtTakeDetail.Text
        Dim TakeDate As String = Format(inventory.RadDateTimePickerTakeDate.Value, "yyyy-MM-dd HH:mm:ss")
        Dim InsertDate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim DataSuplierId As DataTable = executesql("SELECT SupplierId FROM Supplier WHERE SupName='" & inventory.RadDropDownListStore.Text & "' AND Active=1")
        Dim DataStoreId As DataTable = executesql("SELECT StockId FROM Stock WHERE StockName='" & inventory.RadDropDownListStore.Text & "' AND Active=1 ")

        Dim TaxId As String = inventory.TxtTaxId.Text
        Dim ReciveDate As String = Format(inventory.RadDateTimePickerReciveDate.Value, "yyyy-MM-dd HH:mm:ss")
        Dim StatusItem As DataTable = executesql("SELECT StatusID FROM StatusSystem WHERE StatusName='" & inventory.RadDropDownListStatus.Text & "'")
        Dim TakeType As DataTable = executesql("SELECT TakeTypeId FROM TakeType WHERE TakeTypeName = '" & inventory.RadDropDownListTakeType.Text & "'")

        Dim Active As Integer = 1
        Dim ItemTypeId As Integer = 2 ' 2 = material
        Dim Tax As Decimal
        'Dim SubTotal As Decimal
        Dim Total As Decimal

        Dim ItemCode As String
        Dim ItemName As String
        Dim CategoryId As Integer
        Dim CategoryName As String
        Dim CategoryName2 As String
        Dim AmountItem As Integer
        Dim POUnitId As Integer
        'Dim InitCost As Decimal
        Dim UnitCost As Decimal
        Dim Multiply As Decimal
        Dim BalanceRecive As Decimal
        'Dim TotalInitCost As Decimal
        Dim TotalUnitCost As Decimal
        Dim QtyInStock As Decimal
        Dim AvgCost As Decimal
        Dim AvgUnitCost As Decimal
        Dim inCludeTax As Integer

        If inventory.DataGridViewShowTakeItem.Rows.Count = 0 Then
            MsgBox("กรุณากรอกสินค้าก่อนเพิ่ม")
            Exit Sub
        End If
        Dim CountDataGridViewShowTakeItem As Integer = inventory.DataGridViewShowTakeItem.Rows.Count
        Dim i As Integer
        'Cal Vat on ReciveBill
        For i = 0 To CountDataGridViewShowTakeItem - 1
            'SubTotal += inventory.DataGridViewShowTakeItem.Rows(i).Cells(6).Value
            Total += inventory.DataGridViewShowTakeItem.Rows(i).Cells(5).Value
        Next
        inventory.TxtTotalTakeUnitCost.Text = FormatNumber(Total, 2)
        'Insert Items
        If CheckReciveId = 0 Then
            Dim checkNotPass As DataTable = executesql("SELECT Id FROM Take WHERE TakeId='" & inventory.TxtTakeId.Text & "'")
            If checkNotPass.Rows.Count = 0 And inventory.RadDropDownListStatus.Text = "Not Pass" Then
                MsgBox("ไม่สามารถเพิ่มข้อมูล Not Pass ได้", MsgBoxStyle.Critical, "")
                inventory.RadDropDownListStatus.Focus()
                Exit Sub
            ElseIf inventory.RadDropDownListStatus.Text = "Pending" Then
                executesql("INSERT INTO  Take(TakeId,TakeDate,TakeTitle,TakeDetail,TakeTypeId,StockId,Total,StatusId,InsertDate,UserId,Active) VALUES('" & TakeId & "','" & TakeDate & "','" & TakeTitle & "','" & TakeDetail & "','" & TakeType(0)("TakeTypeId") & "','" & DataStoreId(0)("StockId") & "','" & Total & "','" & StatusItem(0)("StatusID") & "','" & InsertDate & "','" & Frm_Login.UserId & "','" & Active & "')")
                Dim selectTake As DataTable = executesql("SELECT Max(TakeId) FROM Take")

                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewShowTakeItem.Rows.Count - 1
                    ItemCode = inventory.DataGridViewShowTakeItem.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewShowTakeItem.Rows(a).Cells(1).Value
                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")

                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    AmountItem = inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value
                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewShowTakeItem.Rows(a).Cells(2).Value & "'")

                    POUnitId = selectUnit(0)("ItemUnitId")
                    UnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    Multiply = selectUnit(0)("Multiply")
                    'CheckBalanceTake In Stock
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")

                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = (inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value + QtyInStock)
                    TotalUnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    'Insert To TakeItem
                    executesql("INSERT INTO TakeItem(TakeId,ItemCode,ItemName,CategoryId,CategoryName,CategoryName2,Amount,ItemUnitId,Multiply,UnitCost,TotalUnitCost)  VALUES('" & TakeId & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & selectUnit(0)("ItemUnitId") & "','" & Multiply & "','" & UnitCost & "','" & TotalUnitCost & "')")

                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                '  inventory.DataGridViewShowTakeItem.Rows.Clear()
                Exit Sub
            ElseIf inventory.RadDropDownListStatus.Text = "Approve" Then
                executesql("INSERT INTO  Take(TakeId,TakeDate,TakeTitle,TakeDetail,TakeTypeId,StockId,Total,StatusId,InsertDate,UserId,Active) VALUES('" & TakeId & "','" & TakeDate & "','" & TakeTitle & "','" & TakeDetail & "','" & TakeType(0)("TakeTypeId") & "','" & DataStoreId(0)("StockId") & "','" & Total & "','" & StatusItem(0)("StatusID") & "','" & InsertDate & "','" & Frm_Login.UserId & "','" & Active & "')")
                Dim selectTake As DataTable = executesql("SELECT Max(TakeId) FROM Take")

                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewShowTakeItem.Rows.Count - 1
                    ItemCode = inventory.DataGridViewShowTakeItem.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewShowTakeItem.Rows(a).Cells(1).Value
                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")

                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    AmountItem = inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value
                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewShowTakeItem.Rows(a).Cells(2).Value & "'")

                    POUnitId = selectUnit(0)("ItemUnitId")
                    UnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    Multiply = selectUnit(0)("Multiply")
                    'CheckBalanceTake In Stock
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")
                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = (QtyInStock - (inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value * Multiply))
                    TotalUnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    'Insert To TakeItem
                    executesql("INSERT INTO TakeItem(TakeId,ItemCode,ItemName,CategoryId,CategoryName,CategoryName2,Amount,ItemUnitId,Multiply,UnitCost,TotalUnitCost)  VALUES('" & TakeId & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & selectUnit(0)("ItemUnitId") & "','" & Multiply & "','" & UnitCost & "','" & TotalUnitCost & "')")

                    'Update Stock
                    executesql("UPDATE UnitInStock SET StockId='" & DataStoreId(0)("StockId") & "',ItemCode='" & ItemCode & "',Qty='" & BalanceRecive & "' WHERE ItemCode='" & ItemCode & "'")

                    'check costing
                    Dim selectItemId As DataTable = executesql("SELECT ItemId,TaxId FROM Item WHERE ItemCode = '" & ItemCode & "'")
                    Dim selectVat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & selectItemId(0)("TaxId") & "'")
                    Dim checkCosting As DataTable = executesql("SELECT ItemId,LastInitCost,LastUnitcost,AvgCost,AvgUnitCost FROM Costing  WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                    Dim selectTotalCost As DataTable = executesql("SELECT TotalUnitCost FROM TakeItem WHERE ItemCode='" & ItemCode & "'")

                    If selectVat(0)("Multiply") = 0 Then
                        inCludeTax = "0"
                    Else
                        inCludeTax = "1"
                    End If

                    AvgCost = (((checkCosting(0)("LastInitCost") * QtyInStock) - TotalUnitCost)) / BalanceRecive 'no vat
                    AvgUnitCost = ((checkCosting(0)("LastUnitcost") * QtyInStock) - TotalUnitCost) / BalanceRecive 'in vat
                    executesql("UPDATE Costing SET  UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',AvgCost='" & AvgCost & "',AvgUnitCost='" & AvgUnitCost & "' WHERE ItemId='" & selectItemId(0)("ItemId") & "'")

                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                ' inventory.DataGridViewShowTakeItem.Rows.Clear()
                Exit Sub
            End If
        Else
            'Update
            If inventory.RadDropDownListStatus.Text = "Not Pass" Then
                executesql("UPDATE Take SET Active='0' WHERE TakeId='" & CheckReciveId & "'")

                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                ' inventory.DataGridViewShowTakeItem.Rows.Clear()
                Exit Sub
            ElseIf inventory.RadDropDownListStatus.Text = "Pending" Then
                executesql("UPDATE Take SET TakeId='" & TakeId & "',TakeDate='" & TakeDate & "',TakeTitle='" & TakeTitle & "',TakeDetail='" & TakeDetail & "',TakeTypeId='" & TakeType(0)("TakeTypeId") & "',StockId='" & DataStoreId(0)("StockId") & "',Total='" & Total & "',StatusId='" & StatusItem(0)("StatusID") & "',UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',Active='" & Active & "' WHERE TakeId='" & CheckReciveId & "'")
                Dim selectTake As DataTable = executesql("SELECT Max(TakeId) FROM Take")

                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewShowTakeItem.Rows.Count - 1
                    ItemCode = inventory.DataGridViewShowTakeItem.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewShowTakeItem.Rows(a).Cells(1).Value
                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")
                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    AmountItem = inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value
                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewShowTakeItem.Rows(a).Cells(2).Value & "'")

                    POUnitId = selectUnit(0)("ItemUnitId")
                    UnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    Multiply = selectUnit(0)("Multiply")
                    'CheckBalanceTake In Stock
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")

                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = (inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value + QtyInStock)
                    TotalUnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    'Insert To TakeItem
                    Dim checkReciveItem As DataTable = executesql("SELECT ItemCode,Amount FROM TakeItem WHERE ItemCode='" & ItemCode & "' AND TakeId='" & TakeId & "'")

                    If checkReciveItem.Rows.Count = 0 Then
                        executesql("INSERT INTO TakeItem(TakeId,ItemCode,ItemName,CategoryId,CategoryName,CategoryName2,Amount,ItemUnitId,Multiply,UnitCost,TotalUnitCost)  VALUES('" & TakeId & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & selectUnit(0)("ItemUnitId") & "','" & Multiply & "','" & UnitCost & "','" & TotalUnitCost & "')")
                    Else
                        executesql("UPDATE TakeItem SET TakeId='" & TakeId & "',ItemCode='" & ItemCode & "',ItemName='" & ItemName & "', CategoryId='" & CategoryId & "',CategoryName='" & CategoryName & "',CategoryName2='" & CategoryName2 & "',Amount='" & AmountItem & "',ItemUnitId='" & selectUnit(0)("ItemUnitId") & "',Multiply='" & Multiply & "',UnitCost='" & UnitCost & "',TotalUnitCost='" & TotalUnitCost & "' WHERE TakeId='" & CheckReciveId & "'")
                    End If
                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                ' inventory.DataGridViewShowTakeItem.Rows.Clear()
                Exit Sub
            ElseIf inventory.RadDropDownListStatus.Text = "Approve" Then
                executesql("UPDATE Take SET TakeId='" & TakeId & "',TakeDate='" & TakeDate & "',TakeTitle='" & TakeTitle & "',TakeDetail='" & TakeDetail & "',TakeTypeId='" & TakeType(0)("TakeTypeId") & "',StockId='" & DataStoreId(0)("StockId") & "',Total='" & Total & "',StatusId='" & StatusItem(0)("StatusID") & "',UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',Active='" & Active & "' WHERE TakeId='" & CheckReciveId & "'")
                Dim selectTake As DataTable = executesql("SELECT Max(TakeId) FROM Take")

                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewShowTakeItem.Rows.Count - 1
                    ItemCode = inventory.DataGridViewShowTakeItem.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewShowTakeItem.Rows(a).Cells(1).Value
                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")

                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    AmountItem = inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value

                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewShowTakeItem.Rows(a).Cells(2).Value & "'")

                    POUnitId = selectUnit(0)("ItemUnitId")
                    UnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value
                    Multiply = selectUnit(0)("Multiply")
                    'CheckBalanceTake In Stock
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")

                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = (QtyInStock - (inventory.DataGridViewShowTakeItem.Rows(a).Cells(4).Value * Multiply))
                    TotalUnitCost = inventory.DataGridViewShowTakeItem.Rows(a).Cells(5).Value

                    'Insert To TakeItem
                    Dim checkReciveItem As DataTable = executesql("SELECT ItemCode,Amount FROM TakeItem WHERE ItemCode='" & ItemCode & "' AND TakeId='" & TakeId & "'")

                    If checkReciveItem.Rows.Count = 0 Then
                        executesql("INSERT INTO TakeItem(TakeId,ItemCode,ItemName,CategoryId,CategoryName,CategoryName2,Amount,ItemUnitId,Multiply,UnitCost,TotalUnitCost)  VALUES('" & TakeId & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & selectUnit(0)("ItemUnitId") & "','" & Multiply & "','" & UnitCost & "','" & TotalUnitCost & "')")
                    Else

                        executesql("UPDATE TakeItem SET TakeId='" & TakeId & "',ItemCode='" & ItemCode & "',ItemName='" & ItemName & "', CategoryId='" & CategoryId & "',CategoryName='" & CategoryName & "',CategoryName2='" & CategoryName2 & "',Amount='" & AmountItem & "',ItemUnitId='" & selectUnit(0)("ItemUnitId") & "',Multiply='" & Multiply & "',UnitCost='" & UnitCost & "',TotalUnitCost='" & TotalUnitCost & "' WHERE TakeId='" & CheckReciveId & "'")
                    End If

                    'Update Stock
                    executesql("UPDATE UnitInStock SET StockId='" & DataStoreId(0)("StockId") & "',ItemCode='" & ItemCode & "',Qty='" & BalanceRecive & "' WHERE ItemCode='" & ItemCode & "'")

                    'check costing
                    Dim selectItemId As DataTable = executesql("SELECT ItemId,TaxId FROM Item WHERE ItemCode = '" & ItemCode & "'")
                    Dim selectVat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & selectItemId(0)("TaxId") & "'")
                    Dim checkCosting As DataTable = executesql("SELECT ItemId,LastInitCost,LastUnitcost,AvgCost,AvgUnitCost FROM Costing  WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                    Dim selectTotalCost As DataTable = executesql("SELECT TotalUnitCost FROM TakeItem WHERE ItemCode='" & ItemCode & "'")

                    If selectVat(0)("Multiply") = 0 Then
                        inCludeTax = "0"
                    Else
                        inCludeTax = "1"
                    End If

                    AvgCost = (((checkCosting(0)("LastInitCost") * QtyInStock) - TotalUnitCost)) / BalanceRecive 'no vat
                    AvgUnitCost = ((checkCosting(0)("LastUnitcost") * QtyInStock) - TotalUnitCost) / BalanceRecive 'in vat
                    executesql("UPDATE Costing SET  UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',AvgCost='" & AvgCost & "',AvgUnitCost='" & AvgUnitCost & "' WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                'inventory.DataGridViewShowTakeItem.Rows.Clear()
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub

    Private Function checkStock(v As Integer) As Object
        Throw New NotImplementedException()
    End Function

    Dim checkReciveItemId As String
    Sub ShowDetailItem()
        Try
            If inventory.DataGridViewItems.SelectedRows Is Nothing Then
                checkReciveItemId = "0"
                Exit Sub
            Else
                checkReciveItemId = inventory.DataGridViewShowTakeItem.CurrentRow.Cells(0).Value
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub DeleteReciveItem()
        If CheckReciveId = 0 Then
            For Each row As DataGridViewRow In inventory.DataGridViewShowTakeItem.SelectedRows
                inventory.DataGridViewShowTakeItem.Rows.Remove(row)
            Next
            Exit Sub
        Else
            If MsgBox("ต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                executesql("DELETE FROM TakeItem WHERE ItemCode='" & checkReciveItemId & "' AND TakeId='" & CheckReciveId & "'")
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Critical, "")
                LoadDataReciveToGridView()
                'inventory.DataGridViewShowTakeItem.Rows.Clear()
            End If
        End If
    End Sub
End Module
