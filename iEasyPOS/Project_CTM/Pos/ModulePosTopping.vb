Module ModulePosTopping
    Sub loadItemTopping()
        If POS.DataGridViewPOS.SelectedRows.Count = 0 Then
            MsgBox("กรุณาเลือกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
        Else
            Dim itemId As Integer = POS.DataGridViewPOS.CurrentRow.Cells(4).Value
            Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & itemId & "'")
            'ToppingList.DataGridViewToppingListPos.Rows.Clear()
            If IsNothing(selectItemTopping) Then
                Exit Sub
            ElseIf selectItemTopping.Rows.Count = 0 Then
                Exit Sub
            End If
            For i As Integer = 0 To selectItemTopping.Rows.Count - 1
                'ToppingList.DataGridViewToppingListPos.Rows.Add(selectItemTopping(i)("ToppingName"), selectItemTopping(i)("ToppingId"))
            Next

        End If
    End Sub
    Sub loadItemSelection()
        If POS.DataGridViewPOS.SelectedRows.Count = 0 Then
            MsgBox("กรุณาเลือกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
        Else
            Dim itemId As Integer = POS.DataGridViewPOS.CurrentRow.Cells(4).Value
            Dim selectItemSelection As DataTable = executesql("SELECT Selection.* FROM ItemSelection INNER JOIN CategorySelection ON(ItemSelection.CateSelectionId = CategorySelection.CategorySelectionId) INNER JOIN Selection ON (CategorySelection.CategorySelectionId = Selection.CategorySelectionId) WHERE ItemSelection.Active=1 AND ItemSelection.ItemId='" & itemId & "'")
            'ToppingList.DataGridViewSelectionList.Rows.Clear()
            If IsNothing(selectItemSelection) Then
                Exit Sub
            ElseIf selectItemSelection.Rows.Count = 0 Then
                Exit Sub
            End If
            For i As Integer = 0 To selectItemSelection.Rows.Count - 1
                'ToppingList.DataGridViewSelectionList.Rows.Add(selectItemSelection(i)("SelectionName"), selectItemSelection(i)("SelectionId"))
            Next
        End If
    End Sub
    Sub AddTopping()
        If POS.DataGridViewPOS.CurrentRow.Cells(8).Value = ToppingList.typeToppingId Then
            ToppingList.Close()
            Exit Sub
        Else
            Dim selectPrice As DataTable = executesql("SELECT ToppingName,Pricing FROM Topping WHERE ToppingId='" & ToppingList.typeToppingId & "'")
            ItemAmount = 1
            ItemPrice = ItemAmount * selectPrice(0)("Pricing")
            ItemPricePerUnit = selectPrice(0)("Pricing")
            ItemName = " *" & selectPrice(0)("ToppingName")
            POS.DataGridViewPOS.CurrentRow.Cells(0).Value += ItemName
            POS.DataGridViewPOS.CurrentRow.Cells(2).Value = FormatNumber((POS.DataGridViewPOS.CurrentRow.Cells(2).Value + ItemPricePerUnit), 2)
            POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber((POS.DataGridViewPOS.CurrentRow.Cells(3).Value + ItemPrice), 2)
            POS.DataGridViewPOS.CurrentRow.Cells(8).Value = ToppingList.typeToppingId
            ToppingList.typeToppingId = 0
            ModulePOS.calculatePrice()
            ToppingList.Close()
        End If
    End Sub
    Sub AddSelection()
        'If POS.DataGridViewPOS.CurrentRow.Cells(9).Value = ToppingList.SelectionId Then
        '    ToppingList.Close()
        '    Exit Sub
        'Else
        ItemName = " #" + ToppingList.SelectionName
        POS.DataGridViewPOS.CurrentRow.Cells(0).Value += ItemName
        POS.DataGridViewPOS.CurrentRow.Cells(9).Value = ToppingList.SelectionId
        ToppingList.SelectionId = 0
        ToppingList.SelectionName = ""
        ToppingList.Close()
        'End If
    End Sub
End Module
