Imports System.Data.SqlClient
Module ModuleInventory
    Public PercentVat As Decimal
    Sub LoadReciveId()
        Dim DataRecive As DataTable = executesql("SELECT MAX(ReciveId) FROM Recive")
        Dim CountRecive As DataTable = executesql("SELECT COUNT(ReciveId) FROM Recive")
        Dim ReciveId As String
        Dim MaxreciveId As String
        Dim DateRecive As String = Convert.ToDateTime(Now).ToString("ddMM", New System.Globalization.CultureInfo("th-TH"))
        'If Null DB 
        If DataRecive.Rows.Count = 0 Then
            MaxreciveId = "1"
            ReciveId = DateRecive + MaxreciveId
            inventory.TxtReciveId.Text = ReciveId
            'Not Null DB
        Else
            MaxreciveId = CountRecive(0)(0)
            ReciveId = DateRecive + MaxreciveId
            inventory.TxtReciveId.Text = ReciveId + 1
        End If
    End Sub
    Sub LoadSupplier()
        inventory.RadDropDownSuplier.Items.Clear()
        Dim DataSupplier As DataTable = executesql("SELECT SupName FROM Supplier  where Active = 1")
        'Check DBNull
        If IsNothing(DataSupplier) Then
            MsgBox("ไม่มีรายชื่อผู้ใช้งาน", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim RowsDataSupplier As Integer = DataSupplier.Rows.Count
        inventory.RadDropDownSrcSupplier.Items.Clear()
        Dim i As Integer
        For i = 0 To RowsDataSupplier - 1
            inventory.RadDropDownSuplier.Items.Add(DataSupplier(i)("SupName"))
            inventory.RadDropDownSrcSupplier.Items.Add(DataSupplier(i)("SupName"))
        Next
    End Sub
    Sub LoadStore()
        inventory.RadDropDownStore.Items.Clear()
        Dim DataStore As DataTable = executesql("SELECT StockName FROM Stock WHERE Active=1")
        'Check DBNull
        If DataStore.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim RowsDataStore As Integer = DataStore.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataStore - 1
            inventory.RadDropDownStore.Items.Add(DataStore(i)("StockName"))
        Next
    End Sub
    Sub LoadItemsType()
        inventory.RadDropDownItemType.Items.Clear()
        Dim DataTypeItems As DataTable = executesql("SELECT ItemTypeName FROM ItemTypes")
        'Check DBNull
        If DataTypeItems.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim RowsDataTypeItems As Integer = DataTypeItems.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataTypeItems - 1
            inventory.RadDropDownItemType.Items.Add(DataTypeItems(i)("ItemTypeName"))
        Next
    End Sub
    Sub LoadRadDropDownStatus()
        inventory.RadDropDownStatus.Items.Clear()
        Dim DataStatus As DataTable = executesql("SELECT StatusName FROM StatusSystem")
        Dim RowsDataStatus As Integer = DataStatus.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataStatus - 1
            inventory.RadDropDownStatus.Items.Add(DataStatus(i)("StatusName"))
        Next
    End Sub
    Sub AutoCompeleteSearchItemId()
        inventory.TxtSearchItemId.AutoCompleteMode = AutoCompleteMode.Suggest
        inventory.TxtSearchItemId.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionId As New AutoCompleteStringCollection()
        getDataItemId(DataCollectionId)
        inventory.TxtSearchItemId.AutoCompleteCustomSource = DataCollectionId
    End Sub
    Private Sub getDataItemId(ByVal dataCollectionId As AutoCompleteStringCollection)
        'Create the list to use as the custom source
        Dim MySource As New AutoCompleteStringCollection()
        Dim DataItemSearchId As DataTable = executesql("SELECT ItemCode,ItemName FROM Item WHERE Active=1")
        Dim RowsDataItemSearch As Integer = DataItemSearchId.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim ItemCode As String = DataItemSearchId(i)("ItemCode")
            Dim Itemname As String = DataItemSearchId(i)("ItemCode")
            dataCollectionId.Add(ItemCode)
        Next
    End Sub
    Sub AutoCompeleteSearchItemName()
        inventory.TxtSrcItemName.AutoCompleteMode = AutoCompleteMode.Suggest
        inventory.TxtSrcItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionName As New AutoCompleteStringCollection()
        getDataItemName(DataCollectionName)
        inventory.TxtSrcItemName.AutoCompleteCustomSource = DataCollectionName
    End Sub
    Private Sub getDataItemName(ByVal dataCollectionName As AutoCompleteStringCollection)
        'Create the list to use as the custom source
        Dim DataItemSearchName As DataTable = executesql("SELECT ItemCode,ItemName FROM Item WHERE Active=1")
        Dim RowsDataItemSearch As Integer = DataItemSearchName.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim ItemCode As String = DataItemSearchName(i)("ItemCode")
            Dim Itemname As String = DataItemSearchName(i)("ItemName")
            dataCollectionName.Add(Itemname)
        Next
    End Sub
    Sub LoadDataFromItemId()
        Dim ItemId As String
        Dim ItemName As String
        txtItemCode = inventory.TxtSearchItemId.Text
        'Search From ItemCode
        If inventory.TxtSearchItemId.Text <> "" And inventory.TxtSrcItemName.Text = "" Then
            ItemId = inventory.TxtSearchItemId.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemCode='" & ItemId & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If

            inventory.TxtSrcItemName.Text = DataItemSearch(0)("ItemName")
            'Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            'inventory.LabelUnit.Text = Unit(0)("ItemUnitName")
            Dim POUnitId As DataTable = executesql("SELECT POUnitId,POUnitId2 FROM Item WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")
            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtAmountBalance.Text = 0
            Else
                inventory.TxtAmountBalance.Text = BalanceAmount(0)("Qty")
            End If
            inventory.RadDropDownUnit.Items.Clear()
            For i As Integer = 0 To POUnitId.Rows.Count - 1
                Dim POUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & POUnitId(i)("POUnitId") & "'")
                Dim POUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & POUnitId(i)("POUnitId2") & "'")
                inventory.RadDropDownUnit.Items.Add(POUnitName(i)("ItemUnitName"))
                inventory.RadDropDownUnit.Items.Add(POUnitName2(i)("ItemUnitName"))
            Next
            'Search ItemName
        ElseIf inventory.TxtSrcItemName.Text <> "" And inventory.TxtSearchItemId.Text = "" Then

            ItemName = inventory.TxtSrcItemName.Text
            Dim DataItemId As DataTable = executesql("SELECT ItemCode FROM Item WHERE ItemName='" & ItemName & "' AND Active=1")
            Dim DataItemSearch As DataTable = executesql("SELECT ItemCode,USUnitId,POUnitId,POUnitId2 FROM Item WHERE ItemName='" & ItemName & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            If IsNothing(DataItemSearch) Then
                Exit Sub
            End If
            inventory.TxtSearchItemId.Text = DataItemSearch(0)("ItemCode")
            'Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            'inventory.LabelUnit.Text = Unit(0)("UnitUsename")

            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE MatId='" & DataItemSearch(0)("ItemId") & "'")
            Dim POUnitId As DataTable = executesql("SELECT POUnitId,POUnitId2 FROM Item WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")
            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtAmountBalance.Text = 0
            Else
                inventory.TxtAmountBalance.Text = BalanceAmount(0)("Qty")
            End If
            inventory.RadDropDownUnit.Items.Clear()
            For i As Integer = 0 To DataItemSearch.Rows.Count - 1
                Dim POUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & POUnitId(i)("POUnitId") & "'")
                Dim POUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & POUnitId(i)("POUnitId2") & "'")
                inventory.RadDropDownUnit.Items.Add(POUnitName(i)("ItemUnitName"))
                inventory.RadDropDownUnit.Items.Add(POUnitName2(i)("ItemUnitName"))
            Next

        ElseIf inventory.TxtSrcItemName.Text <> "" And inventory.TxtSearchItemId.Text <> "" Then
            ItemId = inventory.TxtSearchItemId.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemCode='" & ItemId & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            inventory.TxtSrcItemName.Text = DataItemSearch(0)("ItemName")
            inventory.TxtSearchItemId.Text = DataItemSearch(0)("ItemCode")
            'Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            'inventory.LabelUnit.Text = Unit(0)("ItemUnitName")

            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE MatId='" & DataItemSearch(0)("ItemId") & "'")
            Dim POUnitId As DataTable = executesql("SELECT POUnitId,POUnitId2 FROM Item WHERE ItemId='" & DataItemSearch(0)("ItemId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")
            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtAmountBalance.Text = 0
            Else
                inventory.TxtAmountBalance.Text = BalanceAmount(0)("Qty")
            End If
            inventory.RadDropDownUnit.Items.Clear()
            For i As Integer = 0 To DataItemSearch.Rows.Count - 1
                Dim POUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & POUnitId(i)("POUnitId") & "'")
                Dim POUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & POUnitId(i)("POUnitId2") & "'")
                inventory.RadDropDownUnit.Items.Add(POUnitName(i)("ItemUnitName"))
                inventory.RadDropDownUnit.Items.Add(POUnitName2(i)("ItemUnitName"))
            Next
        End If
    End Sub
    Sub LoadDataReciveToGridView()
        inventory.DataGridViewShowRecive.Rows.Clear()
        ClearTextAll()
        LoadReciveId()
        Dim selectRecive As DataTable = executesql("SELECT Recive.ReciveId,Recive.ReciveBill,Recive.DateInvoice,Supplier.SupName,StatusId FROM Recive INNER JOIN Supplier ON Supplier.SupplierId=Recive.SupplierId WHERE Recive.Active=1")
        If selectRecive.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectRecive.Rows.Count - 1
            Dim DateRecive As String = Convert.ToDateTime(selectRecive(i)("DateInvoice")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
            Dim SelectStatusName As DataTable = executesql("SELECT StatusName FROM StatusSystem WHERE StatusId='" & selectRecive(i)("StatusId") & "'")
            inventory.DataGridViewShowRecive.Rows.Add(DateRecive, selectRecive(i)("ReciveId"), selectRecive(i)("SupName"), SelectStatusName(0)("StatusName"))
        Next

    End Sub
    Sub BtnSrc()
        Dim ReciveId As String = inventory.TxtSrc.Text
        Dim SupId As String = inventory.RadDropDownSrcSupplier.Text
        Dim StartDate As String = Convert.ToDateTime(inventory.DaterimePickerSrcStart.Value).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim EndDate As String = Convert.ToDateTime(inventory.DaterimePickerSrcEnd.Value).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        If ReciveId = "" And SupId = "" Then
            Dim Src As DataTable = executesql("SELECT DateInvoice,ReciveId,SupplierId,StatusId FROM Recive WHERE DateInvoice BETWEEN '" & StartDate & "' AND '" & EndDate & "'")
            inventory.DataGridViewShowRecive.Rows.Clear()
            For i As Integer = 0 To Src.Rows.Count - 1
                Dim SupName As DataTable = executesql("SELECT SupName FROm Supplier WHERE SupplierId='" & Src(i)("SupplierId") & "'")
                Dim StatusName As DataTable = executesql("SELECT StatusName FROM StatusSystem WHERE StatusId='" & Src(i)("StatusId") & "' ")
                inventory.DataGridViewShowRecive.Rows.Add(Src(i)("DateInvoice"), Src(i)("ReciveId"), SupName(0)("SupName"), StatusName(0)("StatusName"))
            Next
            Exit Sub
        End If
        If ReciveId <> "" And SupId = "" Then
            Dim Src As DataTable = executesql("SELECT DateInvoice,ReciveId,SupplierId,StatusId FROM Recive WHERE DateInvoice BETWEEN '" & StartDate & "' AND '" & EndDate & "' AND ReciveId LIKE '%" & ReciveId & "%' OR ReciveBill LIKE '%" & ReciveId & "%'")
            'MsgBox("2")
            inventory.DataGridViewShowRecive.Rows.Clear()
            For i As Integer = 0 To Src.Rows.Count - 1
                Dim SupName As DataTable = executesql("SELECT SupName FROM Supplier WHERE SupplierId ='" & Src(0)("SupplierId") & "'")
                Dim StatusName As DataTable = executesql("SELECT StatusName FROM StatusSystem WHERE StatusId='" & Src(i)("StatusId") & "'")
                inventory.DataGridViewShowRecive.Rows.Add(Src(i)("DateInvoice"), Src(i)("ReciveId"), SupName(0)("SupName"), StatusName(0)("StatusName"))
            Next
            Exit Sub
        End If
        If ReciveId = "" And SupId <> "" Then
            Dim SupName As DataTable = executesql("SELECT SupplierId FROM Supplier WHERE SupName='" & SupId & "'")
            Dim Src As DataTable = executesql("SELECT DateInvoice,ReciveId,SupplierId,StatusId FROM Recive WHERE DateInvoice BETWEEN '" & StartDate & "' AND '" & EndDate & "' AND SupplierId = '" & SupName(0)("SupplierId") & "'")
            inventory.DataGridViewShowRecive.Rows.Clear()
            For i As Integer = 0 To Src.Rows.Count - 1
                Dim StatusName As DataTable = executesql("SELECT StatusName FROM StatusSystem WHERE StatusId='" & Src(i)("StatusId") & "'")
                inventory.DataGridViewShowRecive.Rows.Add(Src(i)("DateInvoice"), Src(i)("ReciveId"), SupId, StatusName(0)("StatusName"))
            Next
            Exit Sub
        End If
    End Sub
    Sub LoadDataFromItemName()
        Dim ItemId As String
        Dim ItemName As String
        If inventory.TxtSrcItemName.Text <> "" And inventory.TxtSearchItemId.Text = "" Then
            ItemName = inventory.TxtSrcItemName.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemCode,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemName='" & ItemName & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            If IsDBNull(DataItemSearch(0)("ItemName")) Then
                Exit Sub
            End If
            inventory.TxtSrcItemName.Text = DataItemSearch(0)("ItemName")
            inventory.TxtSearchItemId.Text = DataItemSearch(0)("ItemCode")
            'Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")

            'inventory.LabelUnit.Text = Unit(0)("ItemUnitName")
            ItemId = DataItemSearch(0)("ItemCode")
            'Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE MatId='" & DataItemSearch(0)("ItemId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")
            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtAmountBalance.Text = 0
            Else
                inventory.TxtAmountBalance.Text = BalanceAmount(0)("Qty")
            End If
            inventory.RadDropDownUnit.Items.Clear()
            For i As Integer = 0 To DataItemSearch.Rows.Count - 1
                Dim POUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(i)("POUnitId") & "'")
                Dim POUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(i)("POUnitId2") & "'")
                inventory.RadDropDownUnit.Items.Add(POUnitName(i)("ItemUnitName"))
                inventory.RadDropDownUnit.Items.Add(POUnitName2(i)("ItemUnitName"))
            Next
        ElseIf inventory.TxtSrcItemName.Text <> "" And inventory.TxtSearchItemId.Text <> "" Then
            ItemName = inventory.TxtSrcItemName.Text
            Dim DataItemSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,USUnitId,POUnitId,POUnitId2,TaxId FROM Item WHERE ItemName='" & ItemName & "'")
            If DataItemSearch.Rows.Count = 0 Then
                Exit Sub
            End If
            If IsDBNull(DataItemSearch(0)("ItemName")) Then
                Exit Sub
            End If
            inventory.TxtSrcItemName.Text = DataItemSearch(0)("ItemName")
            inventory.TxtSearchItemId.Text = DataItemSearch(0)("ItemCode")
            'Dim Unit As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(0)("USUnitId") & "'")
            'inventory.LabelUnit.Text = Unit(0)("ItemUnitName")
            ItemId = DataItemSearch(0)("ItemCode")
            Dim USUnitIdName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE MatId='" & DataItemSearch(0)("ItemId") & "'")
            Dim BalanceAmount As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemId & "'")
            Dim Vat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId ='" & DataItemSearch(0)("TaxId") & "'")
            PercentVat = Vat(0)("Multiply")
            If BalanceAmount.Rows.Count = 0 Then
                inventory.TxtAmountBalance.Text = 0
            Else
                inventory.TxtAmountBalance.Text = BalanceAmount(0)("Qty")
            End If
            inventory.RadDropDownUnit.Items.Clear()
            For i As Integer = 0 To DataItemSearch.Rows.Count - 1
                Dim POUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(i)("POUnitId") & "'")
                Dim POUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataItemSearch(i)("POUnitId2") & "'")
                inventory.RadDropDownUnit.Items.Add(POUnitName(i)("ItemUnitName"))
                inventory.RadDropDownUnit.Items.Add(POUnitName2(i)("ItemUnitName"))
            Next
        End If
        txtItemCode = inventory.TxtSearchItemId.Text
    End Sub
    Dim txtItemCode As String
    Sub SelectMultiplyUnit()
        'Select Multiply Unit 
        Dim UnitName As String = inventory.RadDropDownUnit.Text
        Dim selectItemId As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & txtItemCode & "'")
        Dim DataUnitName As DataTable = executesql("SELECT Multiply FROM ItemUnit WHERE ItemUnitName ='" & UnitName & "' AND Active=1 AND MatId ='" & selectItemId(0)("ItemId") & "'")
        If DataUnitName.Rows.Count - 1 Then
            Exit Sub
        End If
        Dim selectStock As DataTable = executesql("SELECT UnitInStock.Qty,ReciveItem.Multiply FROM UnitInStock INNER JOIN ReciveItem ON ReciveItem.ItemCode = UnitInStock.ItemCode INNER JOIN Item ON Item.ItemCode = UnitInStock.ItemCode WHERE Item.ItemCode ='" & txtItemCode & "'")
        If selectStock.Rows.Count = 0 Then
            'Exit Sub
        Else
            inventory.TxtAmountBalance.Text = FormatNumber((selectStock(0)("Qty") / DataUnitName(0)("Multiply")), 3)
        End If
        inventory.TxtUnitMultiply.Text = FormatNumber(DataUnitName(0)("Multiply"), 2)
        inventory.LabelUnit.Text = inventory.RadDropDownUnit.Text  'หน่วย
        inventory.TxtinitCost.Focus()
    End Sub
    Sub CalculateInitCost()
        'ทุนก่อนภาษี
        If PercentVat = 0 Then
            'inventory.TxtExtaxCost.Text = inventory.TxtinitCost.Text
            Exit Sub
        End If
        If inventory.TxtExtaxCost.Text = "" Then
            Exit Sub
        End If
        'Cal Before tax 
        Dim Mutiply As Decimal = PercentVat
        Dim Extracost As Decimal = inventory.TxtExtaxCost.Text
        Dim SumTaxCost As Decimal = (Extracost * Mutiply) / 100
        Dim TotalTaxCost As Decimal = Extracost + SumTaxCost
        inventory.TxtinitCost.Text = FormatNumber(TotalTaxCost, 4)
    End Sub
    Sub CalculateSumCost()
        'ทุนรวมถาษี
        If PercentVat = 0 Then
            inventory.TxtExtaxCost.Text = inventory.TxtinitCost.Text
            inventory.TxtAmountRecive.Focus()
            Exit Sub
        End If
        Dim Multiply As Decimal = PercentVat
        Dim MultiplyTaxed As Decimal = 100 + Multiply 'ภาษีตัวคูณกลับ 100+7 vat 
        Dim CostSumTax As Decimal = inventory.TxtinitCost.Text
        Dim TotalCostBeforeTax As Decimal = (CostSumTax * Multiply) / MultiplyTaxed
        inventory.TxtExtaxCost.Text = FormatNumber(CostSumTax - TotalCostBeforeTax, 4)
        'inventory.TxtAmountRecive.Focus()
    End Sub

    Sub CalculateCostFromAmount()
        'Calculate SumCoase From Amount 
        If inventory.TxtinitCost.Text = "" Or inventory.TxtAmountRecive.Text = "" Then
            Exit Sub
        End If
        Dim Amount As Decimal = inventory.TxtAmountRecive.Text
        Dim CostBeforeTax As Decimal = inventory.TxtExtaxCost.Text
        Dim CostSumTax As Decimal = inventory.TxtinitCost.Text
        Dim SumCostBeforeTax As Decimal = FormatNumber(CostBeforeTax * Amount, 3)
        Dim SumCostTotalTax As Decimal = FormatNumber(CostSumTax * Amount, 3)
        inventory.TxtSumTotalItem.Text = SumCostBeforeTax
        inventory.TxtSumTotalitemTax.Text = SumCostTotalTax
        Exit Sub
    End Sub
    Sub AddItemToDataGridView()
        txtItemCode = inventory.TxtSearchItemId.Text
        'Add item 
        Dim ItemCode As String = inventory.TxtSearchItemId.Text
        Dim ItemName As String = inventory.TxtSrcItemName.Text
        Dim UnitName As String = inventory.RadDropDownUnit.Text
        Dim CostBeforeTax As String = inventory.TxtExtaxCost.Text
        Dim CostSumTax As String = inventory.TxtinitCost.Text
        Dim AmountRecive As String = inventory.TxtAmountRecive.Text
        Dim SumCostbeforeVat As String = inventory.TxtSumTotalItem.Text
        Dim SumTotalTax As String = inventory.TxtSumTotalitemTax.Text
        'If ItemCode = Nothing Or ItemName = Nothing Or UnitName = Nothing Or CostBeforeTax = Nothing Or CostSumTax = Nothing Or AmountRecive = Nothing Or SumCostbeforeVat = Nothing Or SumTotalTax = Nothing Then
        '    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        If inventory.RadDropDownUnit.Text = "" Then
            MsgBox("กรุณาเลือกหน่วย", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        inventory.DataGridViewItems.Rows.Add(ItemCode, ItemName, UnitName, CostBeforeTax, CostSumTax, AmountRecive, SumCostbeforeVat, SumTotalTax)
        ClearTxtAndData()

        Dim Tax As Decimal = 0.00
        Dim SubTotal As Decimal = 0.00
        Dim Total As Decimal = 0.00
        Dim CountDataGridViewItems As Integer = inventory.DataGridViewItems.Rows.Count
        Dim i As Integer
        'Cal Vat on ReciveBill
        For i = 0 To CountDataGridViewItems - 1
            SubTotal += inventory.DataGridViewItems.Rows(i).Cells(6).Value
            Total += inventory.DataGridViewItems.Rows(i).Cells(7).Value
        Next
        Tax = FormatNumber(Total - SubTotal, 3)
        inventory.TxtSum.Text = FormatNumber(SubTotal, 2)
        inventory.TxtTotalTax.Text = FormatNumber(Total, 2)
    End Sub
    Sub ClearTxtAndData()
        PercentVat = Nothing
        inventory.TxtSearchItemId.Text = Nothing
        inventory.TxtSrcItemName.Text = Nothing
        inventory.RadDropDownUnit.Items.Clear()
        inventory.TxtExtaxCost.Text = Nothing
        inventory.TxtinitCost.Text = Nothing
        inventory.TxtAmountRecive.Text = Nothing
        inventory.TxtSumTotalItem.Text = Nothing
        inventory.TxtSumTotalitemTax.Text = Nothing
        inventory.TxtAmountBalance.Text = Nothing
    End Sub
    Sub ClearTextAll()
        PercentVat = Nothing
        inventory.TxtSearchItemId.Text = Nothing
        inventory.TxtSrcItemName.Text = Nothing
        'inventory.RadDropDownUnit.Items.Clear()
        inventory.DataGridViewItems.Rows.Clear()
        inventory.TxtExtaxCost.Text = Nothing
        inventory.TxtinitCost.Text = Nothing
        inventory.TxtAmountRecive.Text = Nothing
        inventory.TxtSumTotalItem.Text = Nothing
        inventory.TxtSumTotalitemTax.Text = Nothing
        inventory.TxtreciveBill.Text = Nothing
        inventory.RadDropDownSuplier.Text = Nothing

        'inventory.RadDropDownSuplier.Items.Clear()
        inventory.RadDateTimePickerinvoice.Value = Date.Now
        inventory.RadDateTimePickerReciveDate.Value = Date.Now
        inventory.RadDropDownStore.Text = Nothing

        ' inventory.RadDropDownStore.Items.Clear()
        inventory.TxtTaxId.Text = Nothing
        inventory.RadDropDownStatus.Text = Nothing

        'inventory.RadDropDownStatus.Items.Clear()
        inventory.RadDropDownItemType.Text = Nothing
        inventory.GroupBox3.Enabled = True
        inventory.GroupBox4.Enabled = True
        inventory.TxtSum.Text = Nothing
        inventory.TxtTotalTax.Text = Nothing
        inventory.BtnSave.Enabled = True
        inventory.BtnDelete.Enabled = True
        CheckReciveId = 0
        inventory.TxtAmountBalance.Text = Nothing
        LoadReciveId()
    End Sub
    Dim CheckReciveId As Integer
    Sub ShowDetail()
        Try
            If inventory.DataGridViewShowRecive.SelectedRows Is Nothing Then
                CheckReciveId = 0
                Exit Sub
            Else
                CheckReciveId = inventory.DataGridViewShowRecive.CurrentRow.Cells(1).Value
                Dim selectData As DataTable = executesql("SELECT Recive.ReciveBill,Recive.DateInvoice,Recive.TaxId,Recive.ReciveDate,Supplier.SupName,Stock.StockName,StatusSystem.StatusName FROM Recive INNER JOIN Supplier ON Supplier.SupplierId = Recive.SupplierId INNER JOIN Stock ON Stock.StockId = Recive.StockId INNER JOIN StatusSystem ON StatusSystem.StatusId = Recive.StatusId WHERE Recive.ReciveId='" & CheckReciveId & "'")
                inventory.TxtReciveId.Text = CheckReciveId
                inventory.TxtreciveBill.Text = selectData(0)("ReciveBill")
                inventory.RadDateTimePickerinvoice.Value = Convert.ToDateTime(selectData(0)("DateInvoice")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
                inventory.RadDropDownSuplier.Text = selectData(0)("SupName")
                inventory.RadDropDownStore.Text = selectData(0)("StockName")
                inventory.TxtTaxId.Text = selectData(0)("TaxId")
                inventory.RadDateTimePickerReciveDate.Value = Convert.ToDateTime(selectData(0)("ReciveDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
                inventory.RadDropDownStatus.Text = selectData(0)("StatusName")

                Dim Total As Decimal
                Dim TotalInVat As Decimal
                Dim Amount As Decimal

                Dim selectDataReciveItem As DataTable = executesql("SELECT Reciveid,ItemCode,ItemName,CategoryId,CategoryName,CategoryName2,AmountRecive,POUnit,InitCost,UnitCost,Multiply,TotalInitCost,TotalUnitCost FROM ReciveItem WHERE ReciveId='" & CheckReciveId & "'")
                inventory.DataGridViewItems.Rows.Clear()
                If selectData(0)("StatusName") = "Approve" Then
                    inventory.GroupBox3.Enabled = False
                    inventory.GroupBox4.Enabled = False
                    inventory.TxtSum.Enabled = False
                    inventory.TxtTotalTax.Enabled = False
                    inventory.BtnSave.Enabled = False
                    inventory.BtnDelete.Enabled = False
                    For i As Integer = 0 To selectDataReciveItem.Rows.Count - 1
                        Dim selectUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & selectDataReciveItem(i)("POUnit") & "'")
                        inventory.DataGridViewItems.Rows.Add(selectDataReciveItem(i)("ItemCode"), selectDataReciveItem(i)("ItemName"), selectUnitName(0)("ItemUnitName"), FormatNumber(selectDataReciveItem(i)("InitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataReciveItem(i)("UnitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataReciveItem(i)("AmountRecive"), 3), FormatNumber(selectDataReciveItem(i)("TotalInitCost"), 3), FormatNumber(selectDataReciveItem(i)("TotalUnitCost"), 3))
                        Total += selectDataReciveItem(i)("TotalInitCost")
                        TotalInVat += selectDataReciveItem(i)("TotalUnitCost")
                    Next
                ElseIf selectData(0)("StatusName") = "Pending" Then
                    inventory.GroupBox3.Enabled = True
                    inventory.GroupBox4.Enabled = True
                    inventory.TxtSum.Enabled = True
                    inventory.TxtTotalTax.Enabled = True
                    inventory.BtnSave.Enabled = True
                    inventory.BtnDelete.Enabled = True
                    For i As Integer = 0 To selectDataReciveItem.Rows.Count - 1
                        Dim selectUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & selectDataReciveItem(i)("POUnit") & "'")
                        inventory.DataGridViewItems.Rows.Add(selectDataReciveItem(i)("ItemCode"), selectDataReciveItem(i)("ItemName"), selectUnitName(0)("ItemUnitName"), FormatNumber(selectDataReciveItem(i)("InitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataReciveItem(i)("UnitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataReciveItem(i)("AmountRecive"), 3), FormatNumber(selectDataReciveItem(i)("TotalInitCost"), 3), FormatNumber(selectDataReciveItem(i)("TotalUnitCost"), 3))
                        Total += selectDataReciveItem(i)("TotalInitCost")
                        TotalInVat += selectDataReciveItem(i)("TotalUnitCost")
                    Next
                ElseIf selectData(0)("StatusName") = "Not Pass" Then
                    inventory.GroupBox3.Enabled = False
                    inventory.GroupBox4.Enabled = False
                    inventory.TxtSum.Enabled = False
                    inventory.TxtTotalTax.Enabled = False
                    inventory.BtnSave.Enabled = False
                    inventory.BtnDelete.Enabled = False
                    For i As Integer = 0 To selectDataReciveItem.Rows.Count - 1
                        Dim selectUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & selectDataReciveItem(i)("POUnit") & "'")
                        inventory.DataGridViewItems.Rows.Add(selectDataReciveItem(i)("ItemCode"), selectDataReciveItem(i)("ItemName"), selectUnitName(0)("ItemUnitName"), FormatNumber(selectDataReciveItem(i)("InitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataReciveItem(i)("UnitCost") * selectUnitName(0)("Multiply"), 3), FormatNumber(selectDataReciveItem(i)("AmountRecive"), 3), FormatNumber(selectDataReciveItem(i)("TotalInitCost"), 3), FormatNumber(selectDataReciveItem(i)("TotalUnitCost"), 3))
                        Total += selectDataReciveItem(i)("TotalInitCost")
                        TotalInVat += selectDataReciveItem(i)("TotalUnitCost")
                    Next
                End If
                inventory.TxtSum.Text = FormatNumber(Total, 2)
                inventory.TxtTotalTax.Text = FormatNumber(TotalInVat, 2)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub SaveItems()
        'Insert Items 
        If inventory.TxtReciveId.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.TxtreciveBill.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.RadDropDownSuplier.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.RadDropDownStore.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.TxtTaxId.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf inventory.RadDropDownStatus.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        Dim ReciveId As String = inventory.TxtReciveId.Text
        Dim ReciveBill As String = inventory.TxtreciveBill.Text
        Dim DateInvoice As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Format(inventory.RadDateTimePickerinvoice.Value, "yyyy-MM-dd")
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Format(Now, "yyyy-MM-dd")
        Dim DataSuplierId As DataTable = executesql("SELECT SupplierId FROM Supplier WHERE SupName='" & inventory.RadDropDownSuplier.Text & "' AND Active=1")
        Dim DataStoreId As DataTable = executesql("SELECT StockId FROM Stock WHERE StockName='" & inventory.RadDropDownStore.Text & "' AND Active=1")

        Dim TaxId As String = inventory.TxtTaxId.Text
        Dim ReciveDate As String = Convert.ToDateTime(inventory.RadDateTimePickerReciveDate.Value).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim StatusItem As DataTable = executesql("SELECT StatusId FROM StatusSystem WHERE StatusName='" & inventory.RadDropDownStatus.Text & "'")

        Dim Active As Integer = 1
        Dim ItemTypeId As Integer = 2 ' 2 = material
        Dim Tax As Decimal
        Dim SubTotal As Decimal
        Dim Total As Decimal

        Dim ItemCode As String
        Dim ItemId As Integer
        Dim ItemName As String
        Dim CategoryId As Integer
        Dim CategoryName As String
        Dim CategoryName2 As String
        Dim AmountItem As Decimal
        Dim POUnitId As Integer
        Dim InitCost As Decimal
        Dim UnitCost As Decimal
        Dim Multiply As Decimal
        Dim BalanceRecive As Decimal
        Dim TotalInitCost As Decimal
        Dim TotalUnitCost As Decimal
        Dim QtyInStock As Decimal
        Dim AvgCost As Decimal
        Dim AvgUnitCost As Decimal
        Dim inCludeTax As Integer

        If inventory.DataGridViewItems.Rows.Count = 0 Then
            MsgBox("กรุณากรอกสินค้าก่อนเพิ่ม", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim CountDataGridViewItems As Integer = inventory.DataGridViewItems.Rows.Count
        Dim i As Integer
        'Cal Vat on ReciveBill
        For i = 0 To CountDataGridViewItems - 1
            SubTotal += inventory.DataGridViewItems.Rows(i).Cells(6).Value
            Total += inventory.DataGridViewItems.Rows(i).Cells(7).Value
        Next
        Tax = FormatNumber(Total - SubTotal, 3)
        inventory.TxtSum.Text = FormatNumber(SubTotal, 2)
        inventory.TxtTotalTax.Text = FormatNumber(Total, 2)
        'Insert Items
        If CheckReciveId = 0 Then
            Dim checkReciveBill As DataTable = executesql("SELECT ReciveBill FROM Recive WHERE ReciveBill='" & inventory.TxtreciveBill.Text & "'")
            If checkReciveBill.Rows.Count > 0 Then
                MsgBox("ใบส่งของซ้ำ", MsgBoxStyle.Critical, "")
                inventory.TxtreciveBill.Focus()
                Exit Sub
            End If
            Dim checkNotPass As DataTable = executesql("SELECT ReciveBill FROM Recive WHERE ReciveBill='" & inventory.TxtReciveId.Text & "'")

            If checkNotPass.Rows.Count = 0 And inventory.RadDropDownStatus.Text = "Not Pass" Then
                MsgBox("ไม่สามารถเพิ่มข้อมูล Not Pass ได้", MsgBoxStyle.Critical, "")
                inventory.RadDropDownStatus.Focus()
                Exit Sub
            ElseIf inventory.RadDropDownStatus.Text = "Pending" Then
                executesql("INSERT INTO Recive(ReciveId,ReciveBill,DateInvoice,SupplierId,StockId,TaxId,ReciveDate,ItemTypeId,Active,Tax,SubTotal,Total,StatusId) VALUES('" & ReciveId & "','" & ReciveBill & "','" & DateInvoice & "','" & DataSuplierId(0)("SupplierId") & "','" & DataStoreId(0)("StockId") & "','" & TaxId & "','" & ReciveDate & "','" & ItemTypeId & "','" & Active & "','" & Tax & "','" & SubTotal & "','" & Total & "','" & StatusItem(0)("StatusID") & "')")
                Dim selectRecive As DataTable = executesql("SELECT Max(ReciveId) FROM Recive")
                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewItems.Rows.Count - 1
                    ItemCode = inventory.DataGridViewItems.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewItems.Rows(a).Cells(1).Value
                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")

                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    AmountItem = inventory.DataGridViewItems.Rows(a).Cells(5).Value

                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewItems.Rows(a).Cells(2).Value & "'")

                    POUnitId = selectUnit(0)("ItemUnitId")
                    InitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(3).Value / selectUnit(0)("Multiply"), 4)
                    UnitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(4).Value / selectUnit(0)("Multiply"), 4)
                    Multiply = selectUnit(0)("Multiply")
                    'CheckBalanceRecive In Stock
                    Dim selectItemId As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & ItemCode & "'")
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")
                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = (inventory.DataGridViewItems.Rows(a).Cells(5).Value + QtyInStock)
                    TotalInitCost = inventory.DataGridViewItems.Rows(a).Cells(6).Value
                    TotalUnitCost = inventory.DataGridViewItems.Rows(a).Cells(7).Value
                    'Insert To ReciveItem
                    executesql("INSERT INTO ReciveItem(ReciveId,ReciveBill,InsertDate,Itemcode,ItemName,CategoryId,CategoryName,CategoryName2,AmountRecive,POUnit,InitCost,UnitCost,Multiply,BalanceRecive,TotalInitCost,TotalUnitCost) VALUES('" & selectRecive(0)(0) & "','" & ReciveBill & "','" & InsertDate & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & POUnitId & "','" & InitCost & "','" & UnitCost & "','" & Multiply & "','" & BalanceRecive & "','" & TotalInitCost & "','" & TotalUnitCost & "')")
                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                ' inventory.DataGridViewItems.Rows.Clear()
                Exit Sub
            ElseIf inventory.RadDropDownStatus.Text = "Approve" Then
                executesql("INSERT INTO Recive(ReciveId,ReciveBill,DateInvoice,SupplierId,StockId,TaxId,ReciveDate,ItemTypeId,Active,Tax,SubTotal,Total,StatusId) VALUES('" & ReciveId & "','" & ReciveBill & "','" & DateInvoice & "','" & DataSuplierId(0)("SupplierId") & "','" & DataStoreId(0)("StockId") & "','" & TaxId & "','" & ReciveDate & "','" & ItemTypeId & "','" & Active & "','" & Tax & "','" & SubTotal & "','" & Total & "','" & StatusItem(0)("StatusId") & "')")
                Dim selectRecive As DataTable = executesql("SELECT Max(ReciveId) FROM Recive")
                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewItems.Rows.Count - 1
                    ItemCode = inventory.DataGridViewItems.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewItems.Rows(a).Cells(1).Value
                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")

                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewItems.Rows(a).Cells(2).Value & "'")
                    POUnitId = selectUnit(0)("ItemUnitId")
                    InitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(3).Value / selectUnit(0)("Multiply"), 4)
                    UnitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(4).Value / selectUnit(0)("Multiply"), 4)
                    Multiply = selectUnit(0)("Multiply")
                    AmountItem = inventory.DataGridViewItems.Rows(a).Cells(5).Value
                    'CheckBalanceRecive In Stock
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")
                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = ((inventory.DataGridViewItems.Rows(a).Cells(5).Value * Multiply) + QtyInStock)
                    TotalInitCost = inventory.DataGridViewItems.Rows(a).Cells(6).Value
                    TotalUnitCost = inventory.DataGridViewItems.Rows(a).Cells(7).Value
                    'Insert To ReciveItem
                    executesql("INSERT INTO ReciveItem(ReciveId,ReciveBill,InsertDate,Itemcode,ItemName,CategoryId,CategoryName,CategoryName2,AmountRecive,POUnit,InitCost,UnitCost,Multiply,BalanceRecive,TotalInitCost,TotalUnitCost) VALUES('" & selectRecive(0)(0) & "','" & ReciveBill & "','" & InsertDate & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & POUnitId & "','" & InitCost & "','" & UnitCost & "','" & Multiply & "','" & BalanceRecive & "','" & TotalInitCost & "','" & TotalUnitCost & "')")

                    'Check Stock
                    Dim selectItemId As DataTable = executesql("SELECT ItemId,TaxId FROM Item WHERE ItemCode='" & ItemCode & "'")
                    Dim checkStock As DataTable = executesql("SELECT UnitInStock.id,UnitInStock.ItemCode,UnitInStock.Qty FROM UnitInStock INNER JOIN Recive ON Recive.StockId = UnitInStock.StockId INNER JOIN ReciveItem ON ReciveItem.ItemCode = UnitInStock.ItemCode WHERE UnitInStock.StockId = '" & DataStoreId(0)("StockId") & "' AND UnitInStock.ItemCode='" & ItemCode & "'")
                    If checkStock.Rows.Count = 0 Then
                        executesql("INSERT INTO UnitInStock(StockId,ItemId,ItemCode,Qty) VALUES('" & DataStoreId(0)("StockId") & "','" & selectItemId(0)("ItemId") & "','" & ItemCode & "','" & BalanceRecive & "')")
                    Else
                        executesql("UPDATE UnitInStock SET StockId='" & DataStoreId(0)("StockId") & "',ItemCode='" & ItemCode & "',Qty='" & BalanceRecive & "' WHERE id='" & checkStock(0)("Id") & "'")
                    End If
                    'check costing
                    Dim selectVat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & selectItemId(0)("TaxId") & "'")
                    Dim checkCosting As DataTable = executesql("SELECT ItemId,LastInitCost,LastUnitcost,AvgCost,AvgUnitCost FROM Costing  WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                    Dim selectTotalCost As DataTable = executesql("SELECT TotalInitCost,TotalUnitCost FROM ReciveItem WHERE ItemCode='" & ItemCode & "'")
                    If selectVat(0)("Multiply") = 0 Then
                        inCludeTax = "0"
                    Else
                        inCludeTax = "1"
                    End If
                    If checkCosting.Rows.Count = 0 Then
                        executesql("INSERT INTO Costing(ItemId,TaxId,InitCost,UnitCost,SupplierId,InsertDate,UserId,IsDefault,IsIncludeTax,LastInitCost,LastUnitCost,AvgCost,AvgUnitCost) VALUES('" & selectItemId(0)("ItemId") & "','" & TaxId & "','" & InitCost & "','" & UnitCost & "','" & DataSuplierId(0)("SupplierId") & "','" & InsertDate & "','" & Frm_Login.UserId & "','1','" & inCludeTax & "','" & InitCost & "','" & UnitCost & "','" & InitCost & "','" & UnitCost & "')")
                    Else
                        AvgCost = (selectTotalCost(0)("TotalInitCost") + TotalInitCost) / BalanceRecive 'no vat
                        AvgUnitCost = (selectTotalCost(0)("TotalUnitCost") + TotalUnitCost) / BalanceRecive 'in vat
                        executesql("UPDATE Costing SET TaxId='" & TaxId & "',InitCost='" & InitCost & "',UnitCost='" & UnitCost & "',SupplierId='" & DataSuplierId(0)("SupplierId") & "',UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',IsDefault='1',IsInCludeTax='" & inCludeTax & "',LastInitCost='" & checkCosting(0)("LastInitCost") & "',LastUnitCost='" & checkCosting(0)("LastUnitCost") & "',AvgCost='" & AvgCost & "',AvgUnitCost='" & AvgUnitCost & "' WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                    End If
                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                ' inventory.DataGridViewItems.Rows.Clear()
                Exit Sub
            End If
        Else
            'Update
            If inventory.RadDropDownStatus.Text = "Not Pass" Then
                executesql("UPDATE Recive SET Active='0' WHERE ReciveId='" & ReciveId & "'")
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                'inventory.DataGridViewItems.Rows.Clear()
                Exit Sub
            ElseIf inventory.RadDropDownStatus.Text = "Pending" Then
                executesql("UPDATE Recive SET ReciveBill='" & ReciveBill & "',DateInvoice='" & DateInvoice & "',SupplierId='" & DataSuplierId(0)("SupplierId") & "',StockId='" & DataStoreId(0)("StockId") & "',TaxId='" & TaxId & "',ReciveDate='" & ReciveDate & "',ItemTypeId='" & ItemTypeId & "',Tax='" & Tax & "',SubTotal='" & SubTotal & "',Total='" & Total & "',Status='" & StatusItem(0)("StatusID") & "' WHERE ReciveId='" & ReciveId & "'")
                Dim selectRecive As DataTable = executesql("SELECT Max(ReciveId) FROM Recive")
                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewItems.Rows.Count - 1
                    ItemCode = inventory.DataGridViewItems.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewItems.Rows(a).Cells(1).Value

                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")

                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")
                    AmountItem = inventory.DataGridViewItems.Rows(a).Cells(5).Value
                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewItems.Rows(a).Cells(2).Value & "'")

                    POUnitId = selectUnit(0)("ItemUnitId")
                    InitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(3).Value / selectUnit(0)("Multiply"), 4)
                    UnitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(4).Value / selectUnit(0)("Multiply"), 4)
                    Multiply = selectUnit(0)("Multiply")
                    'CheckBalanceRecive In Stock
                    Dim selectItemId As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & ItemCode & "'")
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")

                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = (inventory.DataGridViewItems.Rows(a).Cells(5).Value + QtyInStock)
                    TotalInitCost = inventory.DataGridViewItems.Rows(a).Cells(6).Value
                    TotalUnitCost = inventory.DataGridViewItems.Rows(a).Cells(7).Value
                    'Insert To ReciveItem
                    Dim checkReciveItem As DataTable = executesql("SELECT ItemCode FROM ReciveItem WHERE ItemCode='" & ItemCode & "' AND ReciveId='" & ReciveId & "'")
                    Dim selectTotalCost As DataTable = executesql("SELECT TotalInitCost,TotalUnitCost FROM ReciveItem WHERE ItemCode='" & ItemCode & "'")
                    AvgCost = (selectTotalCost(0)("TotalInitCost") + TotalInitCost) / BalanceRecive 'no vat
                    AvgUnitCost = (selectTotalCost(0)("TotalUnitCost") + TotalUnitCost) / BalanceRecive 'in vat
                    If checkReciveItem.Rows.Count = 0 Then
                        executesql("INSERT INTO ReciveItem(ReciveId,ReciveBill,InsertDate,Itemcode,ItemName,CategoryId,CategoryName,CategoryName2,AmountRecive,POUnit,InitCost,UnitCost,Multiply,BalanceRecive,TotalInitCost,TotalUnitCost) VALUES('" & selectRecive(0)(0) & "','" & ReciveBill & "','" & InsertDate & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & POUnitId & "','" & InitCost & "','" & UnitCost & "','" & Multiply & "','" & BalanceRecive & "','" & TotalInitCost & "','" & TotalUnitCost & "')")
                    Else
                        executesql("UPDATE ReciveItem SET ReciveBill='" & ReciveBill & "',InsertDate='" & InsertDate & "',Itemcode='" & ItemCode & "',ItemName='" & ItemName & "',CategoryId='" & CategoryId & "',CategoryName'" & CategoryName & "',CategoryName2='" & CategoryName2 & "' ,AmountRecive='" & AmountItem & "',POUnit='" & POUnitId & "',InitCost='" & InitCost & "' ,UnitCost='" & UnitCost & "',Multiply='" & Multiply & "',BalanceRecive='" & BalanceRecive & "',TotalInitCost='" & TotalInitCost & "',TotalUnitCost='" & TotalUnitCost & "',AvgCost='" & AvgCost & "',AvgUnitCost='" & AvgUnitCost & "' WHERE Itemcode='" & ItemCode & "'")
                    End If

                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                ' inventory.DataGridViewItems.Rows.Clear()
                Exit Sub
            ElseIf inventory.RadDropDownStatus.Text = "Approve" Then
                executesql("UPDATE Recive SET ReciveBill='" & ReciveBill & "',DateInvoice='" & DateInvoice & "',SupplierId='" & DataSuplierId(0)("SupplierId") & "',StockId='" & DataStoreId(0)("StockId") & "',TaxId='" & TaxId & "',ReciveDate='" & ReciveDate & "',ItemTypeId='" & ItemTypeId & "',Tax='" & Tax & "',SubTotal='" & SubTotal & "',Total='" & Total & "',StatusId='" & StatusItem(0)("StatusID") & "' WHERE ReciveId='" & ReciveId & "'")

                Dim selectRecive As DataTable = executesql("SELECT Max(ReciveId) FROM Recive")
                'Count Recive From DataGridView
                For a As Integer = 0 To inventory.DataGridViewItems.Rows.Count - 1
                    ItemCode = inventory.DataGridViewItems.Rows(a).Cells(0).Value
                    ItemName = inventory.DataGridViewItems.Rows(a).Cells(1).Value

                    Dim selectCategoryData As DataTable = executesql("SELECT CategoryItem.CategoryId,CategoryItem.CategoryName,CategoryItem.CategoryName2 FROM CategoryItem INNER JOIN Item ON Item.CategoryId = CategoryItem.CategoryId WHERE  Item.ItemCode='" & ItemCode & "'")
                    CategoryId = selectCategoryData(0)("CategoryId")
                    CategoryName = selectCategoryData(0)("CategoryName")
                    CategoryName2 = selectCategoryData(0)("CategoryName2")

                    Dim selectUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitName = '" & inventory.DataGridViewItems.Rows(a).Cells(2).Value & "'")
                    POUnitId = selectUnit(0)("ItemUnitId")
                    InitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(3).Value / selectUnit(0)("Multiply"), 4)
                    UnitCost = FormatNumber(inventory.DataGridViewItems.Rows(a).Cells(4).Value / selectUnit(0)("Multiply"), 4)
                    Multiply = selectUnit(0)("Multiply")
                    AmountItem = inventory.DataGridViewItems.Rows(a).Cells(5).Value
                    'CheckBalanceRecive In Stock
                    Dim selectItemId As DataTable = executesql("SELECT ItemId,TaxId FROM Item WHERE ItemCode='" & ItemCode & "'")
                    Dim selectQtyInStock As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE StockId='" & DataStoreId(0)("StockId") & "' AND ItemCode='" & ItemCode & "'")
                    If selectQtyInStock.Rows.Count = 0 Then
                        QtyInStock = 0
                    Else
                        QtyInStock = selectQtyInStock(0)(0)
                    End If
                    BalanceRecive = ((inventory.DataGridViewItems.Rows(a).Cells(5).Value * Multiply) + QtyInStock)
                    TotalInitCost = inventory.DataGridViewItems.Rows(a).Cells(6).Value
                    TotalUnitCost = inventory.DataGridViewItems.Rows(a).Cells(7).Value
                    'Insert To ReciveItem
                    Dim checkReciveItem As DataTable = executesql("SELECT ItemCode FROM ReciveItem WHERE ItemCode='" & ItemCode & "' AND ReciveId='" & ReciveId & "'")
                    If checkReciveItem.Rows.Count = 0 Then
                        executesql("INSERT INTO ReciveItem(ReciveId,ReciveBill,InsertDate,Itemcode,ItemName,CategoryId,CategoryName,CategoryName2,AmountRecive,POUnit,InitCost,UnitCost,Multiply,BalanceRecive,TotalInitCost,TotalUnitCost) VALUES('" & selectRecive(0)(0) & "','" & ReciveBill & "','" & InsertDate & "','" & ItemCode & "','" & ItemName & "','" & CategoryId & "','" & CategoryName & "','" & CategoryName2 & "','" & AmountItem & "','" & POUnitId & "','" & InitCost & "','" & UnitCost & "','" & Multiply & "','" & BalanceRecive & "','" & TotalInitCost & "','" & TotalUnitCost & "')")
                    Else
                        executesql("UPDATE ReciveItem SET ReciveBill='" & ReciveBill & "',InsertDate='" & InsertDate & "',Itemcode='" & ItemCode & "',ItemName='" & ItemName & "',CategoryId='" & CategoryId & "',CategoryName'" & CategoryName & "',CategoryName2='" & CategoryName2 & "' ,AmountRecive='" & AmountItem & "',POUnit='" & POUnitId & "',InitCost='" & InitCost & "' ,UnitCost='" & UnitCost & "',Multiply='" & Multiply & "',BalanceRecive='" & BalanceRecive & "',TotalInitCost='" & TotalInitCost & "',TotalUnitCost='" & TotalUnitCost & "' WHERE Itemcode='" & ItemCode & "'")
                    End If
                    'Check Stock
                    Dim checkStock As DataTable = executesql("SELECT UnitInStock.id,UnitInStock.ItemCode,UnitInStock.Qty FROM UnitInStock INNER JOIN Recive ON Recive.StockId = UnitInStock.StockId INNER JOIN ReciveItem ON ReciveItem.ItemCode = UnitInStock.ItemCode WHERE UnitInStock.StockId = '" & DataStoreId(0)("StockId") & "' AND UnitInStock.ItemCode='" & ItemCode & "'")
                    If checkStock.Rows.Count = 0 Then
                        executesql("INSERT INTO UnitInStock(StockId,ItemId,ItemCode,Qty) VALUES('" & DataStoreId(0)("StockId") & "','" & selectItemId(0)("ItemId") & "','" & ItemCode & "','" & BalanceRecive & "')")
                    Else
                        executesql("UPDATE UnitInStock SET StockId='" & DataStoreId(0)("StockId") & "',ItemCode='" & ItemCode & "',Qty='" & BalanceRecive & "' WHERE id='" & checkStock(0)("Id") & "'")
                    End If
                    'check costing
                    Dim selectVat As DataTable = executesql("SELECT Multiply FROM Tax WHERE TaxId='" & selectItemId(0)("TaxId") & "'")
                    Dim checkCosting As DataTable = executesql("SELECT ItemId,LastInitCost,LastUnitcost,AvgCost,AvgUnitCost FROM Costing  WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                    Dim selectTotalCost As DataTable = executesql("SELECT TotalInitCost,TotalUnitCost FROM ReciveItem WHERE ItemCode='" & ItemCode & "'")

                    If selectVat(0)("Multiply") = 0 Then
                        inCludeTax = "0"
                    Else
                        inCludeTax = "1"
                    End If
                    If checkCosting.Rows.Count = 0 Then
                        executesql("INSERT INTO Costing(ItemId,TaxId,InitCost,UnitCost,SupplierId,InsertDate,UserId,IsDefault,IsIncludeTax,LastInitCost,LastUnitCost,AvgCost,AvgUnitCost) VALUES('" & selectItemId(0)("ItemId") & "','" & TaxId & "','" & InitCost & "','" & UnitCost & "','" & DataSuplierId(0)("SupplierId") & "','" & InsertDate & "','" & Frm_Login.UserId & "','1','" & inCludeTax & "','" & InitCost & "','" & UnitCost & "','" & InitCost & "','" & UnitCost & "')")
                    Else
                        AvgCost = (selectTotalCost(0)("TotalInitCost") + TotalInitCost) / BalanceRecive 'no vat
                        AvgUnitCost = (selectTotalCost(0)("TotalUnitCost") + TotalUnitCost) / BalanceRecive 'in vat
                        executesql("UPDATE Costing SET TaxId='" & TaxId & "',InitCost='" & InitCost & "',UnitCost='" & UnitCost & "',SupplierId='" & DataSuplierId(0)("SupplierId") & "',UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',IsDefault='1',IsInCludeTax='" & inCludeTax & "',LastInitCost='" & checkCosting(0)("LastInitCost") & "',LastUnitCost='" & checkCosting(0)("LastUnitCost") & "',AvgCost='" & AvgCost & "',AvgUnitCost='" & AvgUnitCost & "' WHERE ItemId='" & selectItemId(0)("ItemId") & "'")
                    End If
                Next
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "")
                LoadDataReciveToGridView()
                'inventory.DataGridViewItems.Rows.Clear()
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub
    Dim checkReciveItemId As String
    Sub ShowDetailItem()
        Try
            If inventory.DataGridViewItems.SelectedRows Is Nothing Then
                checkReciveItemId = "0"
                Exit Sub
            Else
                checkReciveItemId = inventory.DataGridViewItems.CurrentRow.Cells(0).Value
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub DeleteReciveItem()
        If CheckReciveId = 0 Then
            For Each row As DataGridViewRow In inventory.DataGridViewItems.SelectedRows
                inventory.DataGridViewItems.Rows.Remove(row)
            Next
            Exit Sub
        Else
            If MsgBox("ต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                executesql("DELETE FROM ReciveItem WHERE ItemCode='" & checkReciveItemId & "' AND ReciveId='" & CheckReciveId & "'")
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว")
                LoadDataReciveToGridView()
                'inventory.DataGridViewItems.Rows.Clear()
            End If
        End If
    End Sub
End Module