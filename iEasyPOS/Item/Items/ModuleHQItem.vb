Imports System.Net
Imports Newtonsoft.Json

Module ModuleHQItem
    Sub upload()
        'Item.Cursor = Cursors.WaitCursor
        Dim branchL As New List(Of Branch)
        Dim categroyItemL As New List(Of CategoryItems)
        Dim itemL As New List(Of Items)
        Dim toppingL As New List(Of Toppings)
        Dim selectionL As New List(Of Selections)
        Dim categoryItemData As DataTable = executesql("Select CategoryId,CategoryName from CategoryItem where Active = 1 and CateGroupId = 1")
        For i As Integer = 0 To categoryItemData.Rows.Count - 1
            Dim cateData As CategoryItems = New CategoryItems() With {
                .id = categoryItemData(i)("CategoryId"),
                .name = categoryItemData(i)("CategoryName"),
                .items = getItemList(categoryItemData(i)("CategoryId"))
            }
            categroyItemL.Add(cateData)
        Next
        Dim branchData As DataTable = executesql("select BranchId,BranchName from Branch where Active = 1")
        For i As Integer = 0 To branchData.Rows.Count - 1
            Dim data As Branch = New Branch() With {
                .id = branchData(i)("BranchId"),
                .name = branchData(i)("BranchName"),
                .categoryItem = categroyItemL
                }
            branchL.Add(data)
        Next
        'ลอง ทำเป็นไฟล์ ก่อนเฉยๆ
        Dim json As String = JsonConvert.SerializeObject(branchL)
        System.IO.File.WriteAllText("D:\items.json", json)
        MsgBox("เรียบร้อยแล้ว", MsgBoxStyle.Information)
        'Item.Cursor = Cursors.Default
    End Sub
    Function getItemList(cateid As Integer)
        Dim itemL As New List(Of Items)
        Dim toppingL As New List(Of Toppings)
        Dim selectionL As New List(Of Selections)
        Dim itemData As DataTable = executesql("select ItemId,ItemCode,ItemName,ItemPrice from Item where Active = 1 and CategoryId = '" & cateid & "'")
        If itemData.Rows.Count = 0 Then
            itemL = Nothing
        Else
            For a As Integer = 0 To itemData.Rows.Count - 1
                Dim ItemId As Integer = itemData(a)("ItemId")
                Dim idata As Items = New Items With {
                    .id = ItemId,
                    .ItemCode = itemData(a)("ItemCode"),
                    .name = itemData(a)("ItemName"),
                    .price = itemData(a)("ItemPrice"),
                    .topping = getToppingList(ItemId),
                    .selections = getSelectionList(ItemId)
                }
                itemL.Add(idata)
            Next
        End If
        Return itemL
    End Function
    Function getToppingList(itemid As Integer)
        Dim toppingL As New List(Of Toppings)
        Dim toppingData As DataTable = executesql("select Topping.ToppingId,Topping.ToppingName,Topping.Pricing  from ItemTopping inner join CategoryTopping on(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId) inner join Topping on(CategoryTopping.CategoryToppingId = Topping.CategoryToppingId)inner join Item on(Item.ItemId = ItemTopping.ItemId) inner join CategoryItem on(CategoryItem.CategoryId = Item.CategoryId) where ItemTopping.Active = 1 and item.ItemId = " & itemid & " group by Topping.ToppingId, Topping.ToppingName, Topping.Pricing ")
        If toppingData.Rows.Count = 0 Then
            toppingL = Nothing
        Else
            For j As Integer = 0 To toppingData.Rows.Count - 1
                Dim topping As Toppings = New Toppings() With {
                    .id = toppingData(j)("ToppingId"),
                    .name = toppingData(j)("ToppingName"),
                    .pricing = toppingData(j)("Pricing")
                }
                toppingL.Add(topping)
            Next
        End If
        Return toppingL
    End Function
    Function getSelectionList(itemid As Integer)
        Dim selectionL As New List(Of Selections)
        Dim selectionData As DataTable = executesql("select Selection.SelectionId,Selection.SelectionName from ItemSelection inner join CategorySelection on(ItemSelection.CateSelectionId = CategorySelection.CategorySelectionId) inner join Selection on(CategorySelection.CategorySelectionId = Selection.CategorySelectionId) where Selection.Active = 1 and ItemSelection.ItemId=" & itemid & " group by Selection.SelectionId,Selection.SelectionName")
        If selectionData.Rows.Count = 0 Then
            selectionL = Nothing
        Else
            For j As Integer = 0 To selectionData.Rows.Count - 1
                Dim selection As Selections = New Selections() With {
                    .selectionId = selectionData(j)("SelectionId"),
                    .selectionName = selectionData(j)("SelectionName")
                }
                selectionL.Add(selection)
            Next
        End If
        Return selectionL
    End Function
End Module
