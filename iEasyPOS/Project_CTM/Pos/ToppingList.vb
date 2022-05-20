Public Class ToppingList
    Public Shared typeToppingId As Integer = 0
    Private Sub ToppingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControlSelection.TabPages(0).Text = "รายการตัวเลือก"
        'TabControlSelection.TabPages(1).Text = "เพิ่มรายการตัวเลือก"
        'ModulePosTopping.loadItemTopping()
        'ModulePosTopping.loadItemSelection()

        DataGridViewItemTopping.Rows.Clear()
        BtnItemTopping()
        BtnSelection()

    End Sub
    Private Sub DataGridViewToppingListPos_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'MsgBox(DataGridViewToppingListPos.CurrentRow.Cells(1).Value)
        'typeToppingId = DataGridViewToppingListPos.CurrentRow.Cells(1).Value
        ModulePosTopping.AddTopping()
    End Sub
    Public Shared SelectionId As Integer = 0
    Public Shared SelectionName As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DataGridViewItemTopping.Rows.Count > 0 Then

            SelectionId = 0
            SelectionName = RichTextBoxSelection.Text
            'ModulePosTopping.AddSelection()
            If checktopping = 0 Then
                checktopping = 1
                ModulePOS.CheckItem2()
            End If
        End If
        btnSave.Visible = False
    End Sub
    Private Sub DataGridViewSelectionList_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'SelectionId = DataGridViewSelectionList.CurrentRow.Cells(1).Value
        'SelectionName = DataGridViewSelectionList.CurrentRow.Cells(0).Value
        ModulePosTopping.AddSelection()
    End Sub
    Public aa As Integer = 0
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        aa = 0
        SelectionId = 0
        SelectionName = ""
        typeToppingId = 0
        If checktopping = 0 Then
            If POS.DataGridViewPOS.Rows.Count = 0 Then
                checktopping = 2
                ModulePOS.CheckItem2()
                Me.Close()
                Exit Sub
            End If
            Dim checkExists As Boolean = False
            Dim a As Integer
            For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
                'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
                '    Exit For
                'End If
                If ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value Is Nothing Then
                    checkExists = True
                    a = i
                    Exit For
                End If
            Next
            Dim a2 As Integer
            Dim checkExists2 As Boolean = False
            For i As Integer = a To POS.DataGridViewPOS.RowCount - 1
                'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value = 1 Then
                '    Exit For
                'End If
                If ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 Then
                    checkExists2 = True
                    a2 = i
                    Exit For
                End If
            Next
            If checkExists2 = True Then
                If checkExists = True Then
                    'MsgBox(1)
                    checktopping = 0
                    ModulePOS.CheckItem()
                Else
                    'MsgBox(2)
                    checktopping = 3
                    aa = a2
                    ModulePOS.CheckItem2()
                End If
            Else
                If checkExists = True Then
                    'MsgBox(3)
                    checktopping = 2
                    aa = a
                    ModulePOS.CheckItem2()
                Else
                    'MsgBox(4)
                    checktopping = 0
                    ModulePOS.CheckItem()
                End If
            End If

            'If checkExists = True Then
            '    If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
            '        MsgBox(1)
            '        checktopping = 3
            '        aa = POS.DataGridViewPOS.Rows.Count - 1
            '        ModulePOS.CheckItem2()
            '    Else
            '        MsgBox(2)
            '        checktopping = 0
            '        ModulePOS.CheckItem()
            '    End If
            'Else
            '    If POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = 1 Then
            '        MsgBox(3)
            '        checktopping = 0
            '        ModulePOS.CheckItem()
            '    Else
            '        MsgBox(4)
            '    End If

            'End If
        End If
        Me.Close()
    End Sub
    Sub BtnItemTopping()
        'Dim itemId As Integer = POS.DataGridViewPOS.CurrentRow.Cells(4).Value
        'Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* 
        '        FROM ItemTopping 
        '        INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId)
        '        INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)  
        '        WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & ItemId & "'")
        Dim selectItemTopping As DataTable = executesql("SELECT * from Topping")
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
    Sub BtnSelection()
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
    Sub addToPos()
        For i As Integer = 0 To DataGridViewItemTopping.RowCount - 1
            If selectItemPosRow = Nothing Then
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
                    POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(0).Value = POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(0).Value & ", #" & DataGridViewItemTopping.Rows(i).Cells(0).Value
                    POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(9).Value = 1
                ElseIf DataGridViewItemTopping.Rows(i).Cells(2).Value <> 0 And DataGridViewItemTopping.Rows(i).Cells(3).Value = 0 Then
                    'Topping
                    POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(0).Value = POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(0).Value & ", *" & DataGridViewItemTopping.Rows(i).Cells(0).Value
                    POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(3).Value = FormatNumber((CDbl(POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(3).Value) + CDbl(DataGridViewItemTopping.Rows(i).Cells(1).Value) * POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(1).Value), 2)
                    POS.DataGridViewPOS.Rows(selectItemPosRow).Cells(8).Value = 1
                End If
            End If
        Next
        ModulePOS.calculatePrice()
        Me.Close()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If DataGridViewItemTopping.Rows.Count > 0 Then
            DataGridViewItemTopping.Rows.RemoveAt(DataGridViewItemTopping.CurrentCell.RowIndex)
        End If
    End Sub
End Class