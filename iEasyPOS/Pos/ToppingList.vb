Public Class ToppingList
    Public Shared typeToppingId As Integer = 0
    Private Sub ToppingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControlSelection.TabPages(0).Text = "รายการตัวเลือก"
        'TabControlSelection.TabPages(1).Text = "เพิ่มรายการตัวเลือก"
        'ModulePosTopping.loadItemTopping()
        'ModulePosTopping.loadItemSelection()
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        DataGridViewItemTopping.Rows.Clear()
        DataGridViewItemTopping.RowTemplate.Height = 35
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
        writeLog("User ID " + Frm_Login.UserId.ToString + " Add Topping")
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
                    Me.Close()
                    Exit Sub
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
        writeLog("User ID " + Frm_Login.UserId.ToString + " No Topping click")
        Me.Close()
    End Sub
    Sub BtnItemTopping()
        'Dim itemId As Integer = POS.DataGridViewPOS.CurrentRow.Cells(4).Value
        Dim selectItemTopping As DataTable = executesql("SELECT Topping.*,ItemTopping.* FROM ItemTopping INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId) INNER JOIN Topping ON (Topping.CategoryToppingId = CategoryTopping.CategoryToppingId) WHERE ItemTopping.Active=1 AND ItemTopping.ItemId='" & ItemId & "' AND Topping.Active=1")
        'Dim selectItemTopping As DataTable = executesql("SELECT * from Topping")
        Flow_Topping.Controls.Clear()

        If IsNothing(selectItemTopping) Then
            Exit Sub
        ElseIf selectItemTopping.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectItemTopping.Rows.Count - 1
            Dim BtnSelect As New Button
            BtnSelect.BackColor = Color.FromArgb(45, 149, 239)
            BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnSelect.FlatAppearance.BorderSize = 0
            BtnSelect.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            BtnSelect.ForeColor = System.Drawing.Color.White
            'BtnSelect.Location = New System.Drawing.Point(1, 1)
            'BtnSelect.Margin = New System.Windows.Forms.Padding(1)
            BtnSelect.TextAlign = ContentAlignment.MiddleCenter
            BtnSelect.Size = New System.Drawing.Size(153, 59)
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
        Dim selectItemSelection As DataTable = executesql("SELECT Selection.* FROM ItemSelection INNER JOIN CategorySelection ON(ItemSelection.CateSelectionId = CategorySelection.CategorySelectionId) INNER JOIN Selection ON (CategorySelection.CategorySelectionId = Selection.CategorySelectionId) WHERE ItemSelection.Active=1 and ItemSelection.ItemId ='" & ItemId & "' AND Selection.Active=1")
        Flow_Selection.Controls.Clear()

        If IsNothing(selectItemSelection) Then
            Exit Sub
        ElseIf selectItemSelection.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectItemSelection.Rows.Count - 1
            Dim BtnSelect As New Button
            BtnSelect.BackColor = Color.FromArgb(45, 149, 239)
            BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnSelect.FlatAppearance.BorderSize = 0
            BtnSelect.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            BtnSelect.ForeColor = System.Drawing.Color.White
            'BtnSelect.Location = New System.Drawing.Point(1, 1)
            'BtnSelect.Margin = New System.Windows.Forms.Padding(1)
            BtnSelect.TextAlign = ContentAlignment.MiddleCenter
            BtnSelect.Size = New System.Drawing.Size(153, 59)
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
                'MsgBox("selectItemPosRow = Nothing")
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
                'MsgBox("Else")
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

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ItemId = 0
        Me.Close()
    End Sub

    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_topping_th.topping
        Label3.Text = My.Resources.pos_topping_th.toppingList
        Label6.Text = My.Resources.pos_topping_th.note
        Label2.Text = My.Resources.pos_topping_th.selecttopping
        Label7.Text = My.Resources.pos_topping_th.topping
        Label1.Text = My.Resources.pos_topping_th.subCatetopping
        Label5.Text = My.Resources.pos_topping_th._event
        btnCancel.Text = My.Resources.pos_topping_th.noTopping
        btnDel.Text = My.Resources.pos_topping_th.delTopping
        btnSave.Text = My.Resources.pos_topping_th.save

        DataGridViewItemTopping.Columns(0).HeaderText = My.Resources.pos_topping_th.topping
        DataGridViewItemTopping.Columns(1).HeaderText = My.Resources.pos_topping_th.price
    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_topping_en.topping
        Label3.Text = My.Resources.pos_topping_en.toppingList
        Label6.Text = My.Resources.pos_topping_en.note
        Label2.Text = My.Resources.pos_topping_en.selecttopping
        Label7.Text = My.Resources.pos_topping_en.topping
        Label1.Text = My.Resources.pos_topping_en.subCatetopping
        Label5.Text = My.Resources.pos_topping_en._event
        btnCancel.Text = My.Resources.pos_topping_en.noTopping
        btnDel.Text = My.Resources.pos_topping_en.delTopping
        btnSave.Text = My.Resources.pos_topping_en.save

        DataGridViewItemTopping.Columns(0).HeaderText = My.Resources.pos_topping_en.topping
        DataGridViewItemTopping.Columns(1).HeaderText = My.Resources.pos_topping_en.price
    End Sub
End Class