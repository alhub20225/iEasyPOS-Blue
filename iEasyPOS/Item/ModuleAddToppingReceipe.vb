Module ModuleAddToppingReceipe
    Sub loadMatCate()
        Dim selectCategoryMaterial As DataTable = executesql("SELECT * FROM CategoryItem WHERE CateGroupId=2")
        If IsNothing(selectCategoryMaterial) Then
            Exit Sub
        ElseIf selectCategoryMaterial.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmToppings.RadDropDownListCategoryMatTopping.Properties.Items.Clear()
        For i As Integer = 0 To selectCategoryMaterial.Rows.Count - 1
            FrmToppings.RadDropDownListCategoryMatTopping.Properties.Items.Add(selectCategoryMaterial(i)("CategoryName"))
        Next
    End Sub
    Sub btnSearch()
        FrmToppings.DataGridViewShowMatToppingList.Rows.Clear()
        Dim Name As String = FrmToppings.txtMatTopping.Text
        Dim Cate As String = FrmToppings.RadDropDownListCategoryMatTopping.Text
        If Name = "" And Cate = "" Then
            Dim selectItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemName,Item.ItemCode,CategoryItem.CategoryName,UnitInStock.Qty FROM Item INNER JOIN CategoryItem ON(Item .CategoryId = CategoryItem.CategoryId) INNER JOIN UnitInStock ON(Item.ItemCode = UnitInStock.ItemCode )")
            If IsNothing(selectItem) Then
                Exit Sub
            ElseIf selectItem.Rows.Count = 0 Then
                Exit Sub
            End If
            FrmToppings.DataGridViewShowMatToppingList.Rows.Clear()
            For i As Integer = 0 To selectItem.Rows.Count - 1
                FrmToppings.DataGridViewShowMatToppingList.Rows.Add(selectItem(i)("CategoryName"), selectItem(i)("ItemName"), selectItem(i)("Qty"), selectItem(i)("ItemId"), selectItem(i)("ItemCode"))
            Next
        ElseIf Name IsNot "" And Cate = "" Then
            Dim selectItem As DataTable = executesql("SELECT Item.ItemId ,Item.ItemName,Item.ItemCode ,CategoryItem.CategoryName,UnitInStock.Qty FROM Item INNER JOIN CategoryItem ON(Item .CategoryId = CategoryItem.CategoryId) INNER JOIN UnitInStock ON(Item.ItemCode = UnitInStock.ItemCode) WHERE Item.ItemName LIKE '%" & Name & "%'")
            If IsNothing(selectItem) Then
                Exit Sub
            ElseIf selectItem.Rows.Count = 0 Then
                Exit Sub
            End If
            FrmToppings.DataGridViewShowMatToppingList.Rows.Clear()
            For i As Integer = 0 To selectItem.Rows.Count - 1
                FrmToppings.DataGridViewShowMatToppingList.Rows.Add(selectItem(i)("CategoryName"), selectItem(i)("ItemName"), selectItem(i)("Qty"), selectItem(i)("ItemId"), selectItem(i)("ItemCode"))
            Next
        ElseIf Name = "" And Cate IsNot "" Then
            Dim selectItem As DataTable = executesql("SELECT Item.ItemId ,Item.ItemName,Item.ItemCode ,CategoryItem.CategoryName,UnitInStock.Qty FROM Item INNER JOIN CategoryItem ON(Item .CategoryId = CategoryItem.CategoryId) INNER JOIN UnitInStock ON(Item.ItemCode = UnitInStock.ItemCode ) WHERE CategoryItem.CategoryName = '" & Cate & "'")
            If IsNothing(selectItem) Then
                Exit Sub
            ElseIf selectItem.Rows.Count = 0 Then
                Exit Sub
            End If
            FrmToppings.DataGridViewShowMatToppingList.Rows.Clear()
            For i As Integer = 0 To selectItem.Rows.Count - 1
                FrmToppings.DataGridViewShowMatToppingList.Rows.Add(selectItem(i)("CategoryName"), selectItem(i)("ItemName"), selectItem(i)("Qty"), selectItem(i)("ItemId"), selectItem(i)("ItemCode"))
            Next
        ElseIf Name IsNot "" And Cate IsNot "" Then
            Dim selectItem As DataTable = executesql("SELECT Item.ItemId ,Item.ItemName,Item.ItemCode ,CategoryItem.CategoryName,UnitInStock.Qty FROM Item INNER JOIN CategoryItem ON(Item .CategoryId = CategoryItem.CategoryId) INNER JOIN UnitInStock ON(Item.ItemCode = UnitInStock.ItemCode ) WHERE CategoryItem.CategoryName = '" & Cate & "' AND Item.ItemName LIKE '%" & Name & "%'")
            If IsNothing(selectItem) Then
                Exit Sub
            ElseIf selectItem.Rows.Count = 0 Then
                Exit Sub
            End If
            FrmToppings.DataGridViewShowMatToppingList.Rows.Clear()
            For i As Integer = 0 To selectItem.Rows.Count - 1
                FrmToppings.DataGridViewShowMatToppingList.Rows.Add(selectItem(i)("CategoryName"), selectItem(i)("ItemName"), selectItem(i)("Qty"), selectItem(i)("ItemId"), selectItem(i)("ItemCode"))
            Next
        End If
    End Sub
    Sub btnSave()
        If FrmAddToppingReceipe.txtQty.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim Qty As Decimal = FrmAddToppingReceipe.txtQty.Text
        Dim ToppingReceipeId As Integer = FrmToppings.ToppingReceipeId
        Dim MatName As String = FrmAddToppingReceipe.txtMatName.Text
        Dim MatCode As String = FrmAddToppingReceipe.txtMatCode.Text
        Dim selectMatDate As DataTable = executesql("SELECT  Item.ItemId,Costing.InitCost,Costing.UnitCost FROM Item INNER JOIN Costing ON(Costing.ItemId=Item.ItemId) WHERE Item.ItemCode='" & MatCode & "'")
        Dim MatInitCost As Decimal = selectMatDate(0)("InitCost")
        Dim MatUnitCost As Decimal = selectMatDate(0)("UnitCost")
        Dim TotalInitCost As Decimal = selectMatDate(0)("InitCost") * Qty
        Dim TotalCost As Decimal = selectMatDate(0)("UnitCost") * Qty
        If ToppingReceipeId = 0 Then
            executesql("INSERT INTO ToppingReceipe(ToppingId,MatIdTopping,MatName,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost) VALUES('" & FrmToppings.toppingIds & "','" & FrmToppings.ItemIdToTopping & "','" & MatName & "','" & Qty & "','" & MatInitCost & "','" & MatUnitCost & "','" & TotalInitCost & "','" & TotalCost & "')")
        Else
            executesql("UPDATE ToppingReceipe SET  ToppingId='" & FrmToppings.toppingIds & "',MatIdTopping='" & FrmToppings.ItemIdToTopping & "',MatName='" & MatName & "',Qty='" & Qty & "',MatInitCost='" & MatInitCost & "',MatUnitCost='" & MatUnitCost & "',TotalInitCost='" & TotalInitCost & "',TotalCost='" & TotalCost & "' WHERE ToppingReceipeId='" & ToppingReceipeId & "'")
        End If
        clearData()
        showData()
        FrmAddToppingReceipe.Close()
    End Sub
    Sub clearData()
        FrmToppings.ToppingReceipeId = 0
        FrmAddToppingReceipe.txtMatCode.Clear()
        FrmAddToppingReceipe.txtMatName.Clear()
        FrmAddToppingReceipe.txtQty.Clear()
    End Sub
    Sub showData()
        Dim ToppingReceipe As DataTable = executesql("SELECT * FROM ToppingReceipe WHERE ToppingId=" & FrmToppings.toppingIds)
        FrmToppings.DataGridViewToppingReceipe.Rows.Clear()
        For i As Integer = 0 To ToppingReceipe.Rows.Count - 1
            FrmToppings.DataGridViewToppingReceipe.Rows.Add(ToppingReceipe(i)("MatName"), ToppingReceipe(i)("Qty"), ToppingReceipe(i)("ToppingReceipeId"))
        Next
    End Sub
    Sub btnDel()
        If FrmToppings.ToppingReceipeId = 0 Then
            MsgBox("กรุณาเลิอกรายการการที่ต้องการลบ")
            Exit Sub
        Else
            executesql("DELETE FROM ToppingReceipe WHERE ToppingReceipeId='" & FrmToppings.ToppingReceipeId & "'")
        End If
        showData()
        FrmToppings.ToppingReceipeId = 0
    End Sub
End Module
