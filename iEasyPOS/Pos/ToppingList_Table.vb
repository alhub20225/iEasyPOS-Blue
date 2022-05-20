Public Class ToppingList_Table
    Public rowToppingTable As Integer = 0
    Public Shared SelectionId_Table As Integer = 0
    Public Shared SelectionName_Table As String = ""
    Public Shared typeToppingId_Table As Integer = 0
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        rowToppingTable = 0
        SelectionId_Table = 0
        SelectionName_Table = ""
        typeToppingId_Table = 0
        If checktopping_Table = 0 Then
            'If POS.DataGridViewPOS.Rows.Count = 0 Then
            '    checktopping_Table = 2
            '    ModulePosTable.checkItem()
            '    Me.Close()
            '    Exit Sub
            'End If
            'Dim checkExists As Boolean = False
            'Dim a As Integer
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            '    'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    '    Exit For
            '    'End If
            '    If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value Is Nothing Then
            '        checkExists = True
            '        a = i
            '        Exit For
            '    End If
            'Next
            'Dim a2 As Integer
            'Dim checkExists2 As Boolean = False
            'For i As Integer = a To POS.DataGridViewPOS.RowCount - 1
            '    'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
            '    '    Exit For
            '    'End If
            '    If TB_ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 Then
            '        checkExists2 = True
            '        a2 = i
            '        Exit For
            '    End If
            'Next
            'MsgBox(1)
            checktopping = 0
            'ModulePosTable.checkItem()
            ModulePosTable.CheckItem3()
            'If checkExists2 = True Then
            '    If checkExists = True Then
            '        checktopping_Table = 0
            '        'ModulePosTable.checkItem()
            '        ModulePosTable.CheckItem3()
            '    Else
            '        checktopping_Table = 3
            '        rowToppingTable = a2
            '        ModulePosTable.CheckItem3()
            '    End If
            'Else
            '    If checkExists = True Then
            '        checktopping_Table = 2
            '        rowToppingTable = a
            '        ModulePosTable.CheckItem3()
            '    Else
            '        checktopping = 0
            '        'ModulePosTable.checkItem()
            '        ModulePosTable.CheckItem3()
            '    End If
            'End If

            'If checkExists = True Then
            '    If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
            '        MsgBox(1)
            '        checktopping_Table = 3
            '        rowToppingTable = POS.DataGridViewPOS.Rows.Count - 1
            '        ModulePOS.CheckItem2()
            '    Else
            '        MsgBox(2)
            '        checktopping_Table = 0
            '        ModulePOS.CheckItem()
            '    End If
            'Else
            '    If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
            '        MsgBox(3)
            '        checktopping_Table = 0
            '        ModulePOS.CheckItem()
            '    Else
            '        MsgBox(4)
            '    End If

            'End If
        End If
        Me.Close()
    End Sub

    Private Sub ToppingList_Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadToppingData()
        loadSelection()
        DataGridViewItemTopping.Rows.Clear()
        RichTextBoxSelection.Clear()
    End Sub
    Sub loadToppingData()
        Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & TB_ItemId & "'")
        Flow_Topping.Controls.Clear()

        If IsNothing(selectItemTopping) Then
            Exit Sub
        ElseIf selectItemTopping.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectItemTopping.Rows.Count - 1
            Dim BtnSelect As New Button
            BtnSelect.BackColor = System.Drawing.Color.ForestGreen
            BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnSelect.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            BtnSelect.ForeColor = System.Drawing.Color.Black
            BtnSelect.Location = New System.Drawing.Point(1, 1)
            BtnSelect.Margin = New System.Windows.Forms.Padding(1)
            BtnSelect.Size = New System.Drawing.Size(120, 60)
            BtnSelect.TabIndex = 0
            BtnSelect.UseVisualStyleBackColor = False
            BtnSelect.Name = selectItemTopping(i)("ToppingId")
            BtnSelect.Text = selectItemTopping(i)("ToppingName")
            Flow_Topping.Controls.Add(BtnSelect)
            AddHandler BtnSelect.Click, AddressOf addTopping
        Next
    End Sub
    Sub addTopping(sender As Object, e As EventArgs)
        Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
                FROM ItemTopping 
                INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
                INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
                WHERE ItemTopping.Active=1 AND Topping.ToppingId=" & sender.name & "")
        DataGridViewItemTopping.Rows.Add(selectItemTopping(0)("ToppingName"), FormatNumber(selectItemTopping(0)("Pricing"), 2), selectItemTopping(0)("ToppingId"), 0, 0)
        DataGridViewItemTopping.Rows(DataGridViewItemTopping.Rows.Count - 1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        btnSave.Visible = True
    End Sub
    Sub loadSelection()
        Dim selectItemSelection As DataTable = executesql("SELECT Selection.* FROM ItemSelection INNER JOIN CategorySelection ON(ItemSelection.CateSelectionId = CategorySelection.CategorySelectionId) INNER JOIN Selection ON (CategorySelection.CategorySelectionId = Selection.CategorySelectionId) WHERE ItemSelection.Active=1")
        Flow_Selection.Controls.Clear()

        If IsNothing(selectItemSelection) Then
            Exit Sub
        ElseIf selectItemSelection.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectItemSelection.Rows.Count - 1
            Dim BtnSelect As New Button
            BtnSelect.BackColor = System.Drawing.Color.DeepPink
            BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnSelect.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            BtnSelect.ForeColor = System.Drawing.Color.Black
            BtnSelect.Location = New System.Drawing.Point(1, 1)
            BtnSelect.Margin = New System.Windows.Forms.Padding(1)
            BtnSelect.Size = New System.Drawing.Size(120, 60)
            BtnSelect.TabIndex = 0
            BtnSelect.UseVisualStyleBackColor = False
            BtnSelect.Name = selectItemSelection(i)("SelectionId")
            BtnSelect.Text = selectItemSelection(i)("SelectionName")
            Flow_Selection.Controls.Add(BtnSelect)
            AddHandler BtnSelect.Click, AddressOf addSelect
        Next
    End Sub
    Sub addSelect(sender As Object, e As EventArgs)
        Dim checkSelect As Boolean = False
        For i As Integer = 0 To DataGridViewItemTopping.RowCount - 1
            If DataGridViewItemTopping.Rows(i).Cells(3).Value <> 0 Then
                checkSelect = True
                Exit For
            End If
        Next
        If checkSelect = False Then
            Dim selectItemSelection As DataTable = executesql("SELECT Selection.* FROM ItemSelection INNER JOIN CategorySelection ON(ItemSelection.CateSelectionId = CategorySelection.CategorySelectionId) INNER JOIN Selection ON (CategorySelection.CategorySelectionId = Selection.CategorySelectionId) WHERE ItemSelection.Active=1 AND Selection.SelectionId=" & sender.name & "")
            DataGridViewItemTopping.Rows.Add(selectItemSelection(0)("SelectionName"), 0, 0, selectItemSelection(0)("SelectionId"), 0)
            DataGridViewItemTopping.Rows(DataGridViewItemTopping.Rows.Count - 1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End If
        btnSave.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DataGridViewItemTopping.Rows.Count > 0 Then
            SelectionId_Table = 0
            SelectionName_Table = RichTextBoxSelection.Text
            'ModulePosTopping.AddSelection()
            If checktopping_Table = 0 Then
                checktopping_Table = 1
                ModulePosTable.CheckItem3()
            End If
        End If
        Me.Close()
    End Sub
    Sub addToPos()
        For i As Integer = 0 To DataGridViewItemTopping.RowCount - 1
            If selectItemPosRow_Table = Nothing Then
                If DataGridViewItemTopping.Rows(i).Cells(2).Value = 0 And DataGridViewItemTopping.Rows(i).Cells(3).Value <> 0 Then
                    'Selection
                    POS.DataGridViewPOS.CurrentRow.Cells(0).Value = POS.DataGridViewPOS.CurrentRow.Cells(0).Value & ", #" & DataGridViewItemTopping.Rows(i).Cells(0).Value
                    POS.DataGridViewPOS.CurrentRow.Cells(9).Value = 1
                ElseIf DataGridViewItemTopping.Rows(i).Cells(2).Value <> 0 And DataGridViewItemTopping.Rows(i).Cells(3).Value = 0 Then
                    'Topping
                    POS.DataGridViewPOS.CurrentRow.Cells(0).Value = POS.DataGridViewPOS.CurrentRow.Cells(0).Value & ", *" & DataGridViewItemTopping.Rows(i).Cells(0).Value
                    POS.DataGridViewPOS.CurrentRow.Cells(3).Value = FormatNumber((CDbl(POS.DataGridViewPOS.CurrentRow.Cells(3).Value) + CDbl(DataGridViewItemTopping.Rows(i).Cells(1).Value) * POS.DataGridViewPOS.CurrentRow.Cells(1).Value), 2)
                    POS.DataGridViewPOS.CurrentRow.Cells(8).Value = 1
                End If
            Else

                If DataGridViewItemTopping.Rows(i).Cells(2).Value = 0 And DataGridViewItemTopping.Rows(i).Cells(3).Value <> 0 Then
                    'Selection
                    POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(0).Value = POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(0).Value & ", #" & DataGridViewItemTopping.Rows(i).Cells(0).Value
                    POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(9).Value = 1
                ElseIf DataGridViewItemTopping.Rows(i).Cells(2).Value <> 0 And DataGridViewItemTopping.Rows(i).Cells(3).Value = 0 Then
                    'Topping
                    POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(0).Value = POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(0).Value & ", *" & DataGridViewItemTopping.Rows(i).Cells(0).Value
                    POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(3).Value = FormatNumber((CDbl(POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(3).Value) + CDbl(DataGridViewItemTopping.Rows(i).Cells(1).Value) * POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(1).Value), 2)
                    POS.DataGridViewPOS.Rows(selectItemPosRow_Table).Cells(8).Value = 1
                End If
            End If
        Next
        ModulePosTable.calculatePrice()
        Me.Close()
    End Sub
End Class