Module ModulePrintBarcode
    Sub LoadDataItem()
        'Select Data Item
        Dim DataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,isnull((Select QTY From UnitInStock where Item.ItemCode = 'UnitInStock.ItemCode' ),0) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CateGroupId='1' AND CategoryItem.Active=1  ORDER BY ItemCode ASC")
        If IsNothing(DataItem) Then
            Exit Sub
        ElseIf DataItem.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer
        Dim RowsDataItem As Integer = DataItem.Rows.Count
        For i = 0 To RowsDataItem - 1
            Dim Qty As Decimal
            If DataItem(i)("IsTrackStock") = 0 Then
                Qty = 0
            ElseIf IsDBNull(DataItem(i)("QTY")) Then
                Qty = 0
            Else
                Qty = DataItem(i)("QTY")
            End If
            Main_PrintBarcode.DGItems.Rows.Add(DataItem(i)("Itemid"), DataItem(i)("ItemCode"), DataItem(i)("ItemName"), FormatNumber(DataItem(i)("ItemPrice"), 2), FormatNumber(Qty, 2))
        Next
    End Sub

    Sub LoadCategory()
        Dim DataCategory As DataTable = executesql("SELECT CategoryId,CategoryName FROM CategoryItem WHERE Active=1 AND CateGroupId = 1 ")
        If IsNothing(DataCategory) Then
            Exit Sub
        ElseIf DataCategory.Rows.Count = 0 Then
            Exit Sub
        End If
        Main_PrintBarcode.DropDownitem.Properties.Items.Clear()
        Main_PrintBarcode.ComboBoxCategorysearch.Properties.Items.Clear()

        For i As Integer = 0 To DataCategory.Rows.Count - 1
            Main_PrintBarcode.DropDownitem.Properties.Items.Add(DataCategory(i)("CategoryName"))
            Main_PrintBarcode.ComboBoxCategorysearch.Properties.Items.Add(DataCategory(i)("CategoryName"))
        Next
    End Sub
    Sub SearchItems()
        If Main_PrintBarcode.TxtSerachItem.Text = Nothing And Main_PrintBarcode.ComboBoxCategorysearch.Text = Nothing Then
            MsgBox("กรุณาใส่ข้อมูลที่ต้องการค้นหา", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Main_PrintBarcode.DGItems.Rows.Clear()
        Dim WordSearch As String = Main_PrintBarcode.TxtSerachItem.Text
        Dim CategoryName As String = Main_PrintBarcode.ComboBoxCategorysearch.Text
        Dim CateId As Integer
        'No CateName Search From All
        If CategoryName <> Nothing Then
            If CategoryName = "ทั้งหมด" Then
                'Search Item No CategoryName
                'Dim DataSearchAll As DataTable = executesql("SELECT ItemId,Item.ItemCode, Item.ItemName, Item.ItemName2,Item.ItemPrice FROM  Item INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId where CateGroupId = 1 and Item.Active=1 ORDER BY Item.ItemCode ASC")
                'If WordSearch = "" Then
                '    Exit Sub
                'End If
                Dim DataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CateGroupId='1' AND CategoryItem.Active=1 AND Item.ItemName LIKE '%" & WordSearch & "%' ORDER BY ItemCode ASC")
                'Dim RowsDataSearchAll As Integer = DataSearchAll.Rows.Count
                Dim RowsDataItem As Integer = DataItem.Rows.Count
                For a As Integer = 0 To RowsDataItem - 1
                    Dim Qty As Decimal
                    If DataItem(a)("IsTrackStock") = 0 Then
                        Qty = 0
                    ElseIf IsDBNull(DataItem(a)("QTY")) Then
                        Qty = 0
                    Else
                        Qty = DataItem(a)("QTY")
                    End If
                    Main_PrintBarcode.DGItems.Rows.Add(DataItem(a)("Itemid"), DataItem(a)("ItemCode"), DataItem(a)("ItemName"), FormatNumber(DataItem(a)("ItemPrice"), 2), FormatNumber(Qty, 2))
                Next
                Exit Sub
            Else
                'Select CateID
                Dim DataCateId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & CategoryName & "'")
                CateId = DataCateId(0)("CategoryId")
            End If
        End If
        'No word And Search From Category
        If WordSearch = Nothing And CategoryName <> Nothing Then
            'No WordSearch 
            Dim DataCateIdNoWord As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName ='" & CategoryName & "'")
            Dim CateIdNoWord As Integer = DataCateIdNoWord(0)("CategoryId")
            'Dim DataNoWord As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ItemPrice FROM Item WHERE CategoryId='" & CateIdNoWord & "' and Active=1 ORDER BY ItemCode ASC")
            Dim DataNoWord As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CategoryId='" & CateIdNoWord & "'  ORDER BY ItemCode ASC")
            Dim RowsDataItems As Integer = DataNoWord.Rows.Count
            Dim j As Integer
            For j = 0 To RowsDataItems - 1

                Dim Qty As Decimal

                If DataNoWord(j)("IsTrackStock") = 0 Then
                    Qty = 0
                ElseIf IsDBNull(DataNoWord(j)("QTY")) Then
                    Qty = 0
                Else
                    Qty = DataNoWord(j)("Qty")
                End If
                Main_PrintBarcode.DGItems.Rows.Add(DataNoWord(j)("Itemid"), DataNoWord(j)("ItemCode"), DataNoWord(j)("ItemName"), FormatNumber(DataNoWord(j)("ItemPrice"), 2), FormatNumber(Qty, 2))

            Next
            Exit Sub
        End If
        'Search Item From categoryname 
        'Dim DataSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ItemPrice FROM Item WHERE ItemName LIKE '%" & WordSearch & "%' AND CategoryId='" & CateId & "' and Active=1 ORDER BY ItemCode ASC")
        Dim DataSearch As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CategoryId='" & CateId & "' AND Item.ItemName LIKE '%" & WordSearch & "%' ORDER BY ItemCode ASC")
        Dim RowsDataSearch As Integer = DataSearch.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataSearch - 1

            Dim Qty As Decimal

            If DataSearch(i)("IsTrackStock") = 0 Then
                Qty = 0
            ElseIf IsDBNull(DataSearch(i)("QTY")) Then
                Qty = 0
            Else
                Qty = DataSearch(i)("Qty")
            End If
            'Item.DGItems.Rows.Add(ItemId, ItemCode, ItemName, FormatNumber(DataSearch(i)("ItemPrice"), 2), FormatNumber(Qty, 2))
            Main_PrintBarcode.DGItems.Rows.Add(DataSearch(i)("Itemid"), DataSearch(i)("ItemCode"), DataSearch(i)("ItemName"), FormatNumber(DataSearch(i)("ItemPrice"), 2), FormatNumber(Qty, 2))
        Next
    End Sub

    Sub SelectCategoryItems()
        Main_PrintBarcode.DataGridItem.Rows.Clear()
        Dim CategoryName As String = Main_PrintBarcode.DropDownitem.Text
        Dim DataCateIdNoWord As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName ='" & CategoryName & "'")
        Dim CateIdNoWord As Integer = DataCateIdNoWord(0)("CategoryId")

        Dim DataNoWord As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CategoryId='" & CateIdNoWord & "'  ORDER BY ItemCode ASC")
        Dim RowsDataSearch As Integer = DataNoWord.Rows.Count

        Dim i As Integer = 0
        For i = 0 To RowsDataSearch - 1
            Main_PrintBarcode.DataGridItem.Rows.Add(DataNoWord(i)("ItemId"), DataNoWord(i)("ItemCode"), DataNoWord(i)("ItemName"), FormatNumber(DataNoWord(i)("ItemPrice"), 2))
        Next


    End Sub
End Module
