Module ModuleMaterailAddToItem

    'Sub LoadRadDropDownListCateMaterial()
    '    'Select Categorymaterial
    '    Dim MatId As Integer = 2

    '    Dim DataCategoryMaterial As DataTable = executesql("SELECT CategoryName FROM CategoryItem WHERE CateGroupId='" & MatId & "' AND Active=1")
    '    If IsNothing(DataCategoryMaterial) Then
    '        Exit Sub
    '    ElseIf DataCategoryMaterial.Rows.Count = 0 Then
    '        Exit Sub
    '    End If

    '    Dim RowsDataCategoryMaterial As Integer = DataCategoryMaterial.Rows.Count
    '    If RowsDataCategoryMaterial = 0 Then
    '        Exit Sub
    '    End If
    '    Dim i As Integer = 0
    '    For i = 0 To RowsDataCategoryMaterial - 1
    '        Dim CateMatname As String = DataCategoryMaterial(i)("CategoryName")
    '        Item.RadDropDownListCategoryMaterial.Items.Add(CateMatname)
    '    Next
    'End Sub
    'Sub SearchCateMaterial()
    '    Dim SqlString As String = ""
    '    If Item.TxtMaterialName.Text = "" Then
    '    ElseIf Item.TxtMaterialName.Text <> ""
    '        Dim WordSrc = Item.TxtMaterialName.Text
    '        SqlString = "AND ItemName LIKE '%" & WordSrc & "%'"
    '    End If
    '    'Check CateName 
    '    Dim CateName As String = Item.RadDropDownListCategoryMaterial.Text

    '    Dim CheckDataCateName As DataTable = executesql("SELECT CategoryId,CateGroupid FROM CategoryItem WHERE CategoryName='" & CateName & "'")
    '    Dim RowsCheckDataCateName As Integer = CheckDataCateName.Rows.Count
    '    If RowsCheckDataCateName = 0 Then
    '        MsgBox("ไม่มีหมวดหมู่นี้")
    '        Exit Sub
    '    End If
    '    Dim CateMatId As Integer = CheckDataCateName(0)("CategoryId")

    '    Dim SrcDataMaterial As DataTable = executesql("SELECT ItemId,ItemName,ItemCode,UsUnitId FROM Item WHERE CategoryId='" & CateMatId & "' " & SqlString & "")

    '    Dim RowsSrcDatamaterial As Integer = SrcDataMaterial.Rows.Count
    '    Dim i As Integer
    '    Item.DgMaterial.Rows.Clear()
    '    For i = 0 To RowsSrcDatamaterial - 1
    '        Dim ItemCode As String = SrcDataMaterial(i)("ItemCode")
    '        Dim ItemName As String = SrcDataMaterial(i)("ItemName")
    '        Dim ItemId As Integer = SrcDataMaterial(i)("ItemId")
    '        Dim UnitId As Integer = SrcDataMaterial(i)("UsUnitId")
    '        Dim Unit As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & UnitId & "'")
    '        Dim UnitName As String = Unit(0)("ItemUnitName")
    '        Dim Multiply As Decimal = Unit(0)("Multiply")
    '        Dim Qty As DataTable = executesql("SELECT Qty,Id FROM UnitInStock WHERE ItemCode='" & ItemCode & "'")
    '        Dim QtyAmount As Decimal


    '        'Check Qty in Stock 
    '        If Qty.Rows.Count = 0 Then
    '            QtyAmount = 0
    '            Item.DgMaterial.Rows.Add(ItemId, ItemName, UnitName, FormatNumber(QtyAmount * Multiply), 2)
    '        Else
    '            QtyAmount = Qty(0)("Qty")
    '            Item.DgMaterial.Rows.Add(ItemId, ItemName, UnitName, FormatNumber(QtyAmount * Multiply), 2)
    '        End If
    '    Next
    'End Sub
    ''Add Material To Item
    'Sub FromAddMaterial()
    '    Dim MatId As Integer = Item.MatId
    '    If MatId = 0 Then
    '        MsgBox("เลือกวัตถุดิบก่อน")
    '        Exit Sub
    '    ElseIf MatId > 0
    '        FrmAddMaterialToItem.Close()
    '        FrmAddMaterialToItem.Show()
    '    End If
    'End Sub
    'Sub LoadFromAddMaterialToItem()
    '    Dim MatId As Integer = Item.MatId
    '    Dim DataMaterial As DataTable = executesql("SELECT ItemId,ItemName,ItemCode,USUnitId FROM Item WHERE ItemId='" & MatId & "'")

    '    Dim DataItemUnitName As DataTable = executesql("SELECT ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & DataMaterial(0)("USUnitId") & "' AND Active=1")
    '    Dim ItemCode As String = DataMaterial(0)("ItemCode")
    '    Dim DataBalance As DataTable = executesql("SELECT Qty FROM UnitInStock WHERE ItemCode='" & ItemCode & "'")

    '    Dim DataCosting As DataTable = executesql("SELECT AvgCost,AvgUnitCost FROM Costing WHERE ItemId='" & MatId & "'")
    '    FrmAddMaterialToItem.TxtmaterialName.Text = DataMaterial(0)("ItemName")
    '    FrmAddMaterialToItem.TxtUsUnit.Text = DataItemUnitName(0)("ItemUnitName")
    '    If DataCosting.Rows.Count = 0 Then
    '        FrmAddMaterialToItem.TxtInitCost.Text = 0
    '        FrmAddMaterialToItem.TxtUnitCost.Text = 0
    '    Else
    '        FrmAddMaterialToItem.TxtInitCost.Text = DataCosting(0)("AvgCost")
    '        FrmAddMaterialToItem.TxtUnitCost.Text = DataCosting(0)("AvgUnitCost")
    '    End If
    '    If DataBalance.Rows.Count = 0 Then
    '        FrmAddMaterialToItem.TxtBalance.Text = 0
    '    Else
    '        FrmAddMaterialToItem.TxtBalance.Text = FormatNumber(DataBalance(0)("Qty"), 3)
    '    End If

    '    FrmAddMaterialToItem.TxtMatid.Text = DataMaterial(0)("ItemId")
    'End Sub
    'Sub AddMaterialToDataGridViewMaterial()
    '    Dim Matname As String = FrmAddMaterialToItem.TxtmaterialName.Text
    '    Dim UnitName As String = FrmAddMaterialToItem.ComboBoxUnitUseMaterial.Text
    '    Dim UseQty As Decimal = FrmAddMaterialToItem.TxtTakeAmount.Text
    '    Dim CostVat As Decimal = FrmAddMaterialToItem.TxtUnitCost.Text
    '    Dim Matid As Integer = FrmAddMaterialToItem.TxtMatid.Text
    '    Dim UseUnitid As String = FrmAddMaterialToItem.ComboBoxUnitUseMaterial.SelectedValue

    '    Dim DataMultipleUseUnit As DataTable = executesql("SELECT Multiply FROM ItemUnit WHERE ItemUnitId='" & UseUnitid & "'")
    '    Dim CalMatUse As Decimal = FormatNumber(UseQty * DataMultipleUseUnit(0)("Multiply"), 2)
    '    Item.DataGridViewMaterial.Rows.Add(Matname, CalMatUse, "หน่วยหลัก", UnitName, "Xหน่วยใช้", FormatNumber(CalMatUse * CostVat, 2), Matid)
    'End Sub
    'Sub DeleteOrderMaterial()
    '    'CanCel material In Dg material 
    '    If Item.DataGridViewMaterial.Rows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    executesql("DELETE FROM Receipe WHERE MatId='" & Item.MatIdCancel & "' AND ItemId='" & Item.ItemIdSend & "'")

    '    Item.DataGridViewMaterial.Rows.Remove(Item.DataGridViewMaterial.CurrentRow)
    'End Sub
    'Sub CalculateCostMaterial()
    '    Dim RowsInDgMaterial As Integer = Item.DataGridViewMaterial.Rows.Count
    '    If RowsInDgMaterial = 0 Then
    '        Item.TxtCost.Text = "0.00"
    '        Exit Sub
    '    ElseIf RowsInDgMaterial > 0
    '        Dim i As Integer = 0
    '        Dim CostMaterial As Decimal
    '        For i = 0 To RowsInDgMaterial - 1
    '            CostMaterial += Item.DataGridViewMaterial.Rows(i).Cells(5).Value
    '        Next
    '        Item.TxtCost.Text = CostMaterial
    '        Exit Sub
    '    End If
    'End Sub

    Public MatId_add As Integer = 0
    Sub SearchMatName(txtName As String)
        If txtName = "" Then Exit Sub
        Dim DataItemSearch As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode, Item.ItemName, Item.USUnitId, ItemUnit.ItemUnitName FROM Item INNER JOIN ItemUnit ON Item.USUnitId = ItemUnit.ItemUnitId INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId WHERE Item.Active = 1 and CategoryItem.CateGroupId=2 AND ItemName='" & txtName & "'")
        If DataItemSearch.Rows.Count = 0 Then
            Exit Sub
        End If
        Item.TextBoxSearchMat.Text = DataItemSearch(0)("ItemName")
        Item.TextMatUnit.Text = DataItemSearch(0)("ItemUnitName")
        MatId_add = DataItemSearch(0)("ItemId")
    End Sub
    Sub AutoCompeleteSearchMatName()
        Item.TextBoxSearchMat.AutoCompleteMode = AutoCompleteMode.Suggest
        Item.TextBoxSearchMat.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionName As New AutoCompleteStringCollection()
        getDataItemName(DataCollectionName)
        Item.TextBoxSearchMat.AutoCompleteCustomSource = DataCollectionName
    End Sub
    Private Sub getDataItemName(ByVal dataCollectionName As AutoCompleteStringCollection)

        Dim DataItemSearchName As DataTable = executesql("SELECT Item.ItemName FROM  Item INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId WHERE Item.Active = 1 and CategoryItem.CateGroupId=2")
        Dim RowsDataItemSearch As Integer = DataItemSearchName.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim Itemname As String = DataItemSearchName(i)("ItemName")
            dataCollectionName.Add(Itemname)
        Next
    End Sub
End Module
