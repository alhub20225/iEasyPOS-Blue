Module ModuleAddCategorySelectionToItem
    Sub autocompeletecategoryselection()
        FrmItemAddCategorySelection.TxtSrcCategoryName.AutoCompleteMode = AutoCompleteMode.Suggest
        FrmItemAddCategorySelection.TxtSrcCategoryName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim datacategoryselection As New AutoCompleteStringCollection()
        getcategoryselection(datacategoryselection)
        FrmItemAddCategorySelection.TxtSrcCategoryName.AutoCompleteCustomSource = datacategoryselection
    End Sub
    Private Sub getcategoryselection(ByVal datacategoryselection As AutoCompleteStringCollection)
        Dim mysource As New AutoCompleteStringCollection()
        'dim table as string = "categoryselection"
        'dim field as string = "categoryselectionname"
        'dim where as string = "active=1"
        'dim datacategory as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim datacategory As DataTable = executesql("SELECT CategorySelectionName FROM CategorySelection WHERE Active=1")
        'executesql("select categoryselectionname from categoryselection where active=1")
        Dim rowsdatacategory As Integer = datacategory.Rows.Count
        If rowsdatacategory = 0 Then
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To rowsdatacategory - 1
            Dim catename As String = datacategory(i)("CategorySelectionName")
            datacategoryselection.Add(catename)
        Next
    End Sub
    Sub loadnamecategoryselection()
        'loadnamecategory to textbox 
        Dim catename As String = FrmItemAddCategorySelection.TxtSrcCategoryName.Text
        'dim table as string = "categoryselection"
        'dim field as string = "categoryselectionid,categoryselectionname2"
        'dim where as string = "categoryselectionname='" & catename & "'"
        'dim datacateid as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim datacateid As DataTable = executesql("SELECT CategorySelectionId,CategorySelectionName2 FROM CategorySelection WHERE CategorySelectionName='" & catename & "'")
        'executesql("select categoryselectionid,categoryselectionname2 from categoryselection where categoryselectionname='" & catename & "'")
        Dim rowsdatacate As Integer = datacateid.Rows.Count
        If rowsdatacate = 0 Then
            Exit Sub
        End If
        FrmItemAddCategorySelection.TxtSelectionName.Text = catename
        FrmItemAddCategorySelection.TxtCateSelectionName2.Text = datacateid(0)("CategorySelectionName2")
    End Sub
    'Sub loadcombocateselection()
    '    Item.comboselection.items.clear()
    '    'dim table as string = "categoryselection"
    '    'dim field as string = "categoryselectionid,categoryselectionname,categoryselectionname2"
    '    'dim where as string = "active=1"
    '    'dim datacateid as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
    '    Dim datacateid As DataTable = executesql("select categoryselectionid,categoryselectionname,categoryselectionname2 from categoryselection where active=1")
    '    For i As Integer = 0 To datacateid.Rows.Count - 1
    '        Dim dateselectoinname As String = datacateid(i)("categoryselectionname")
    '        Item.comboselection.items.add(dateselectoinname)
    '    Next
    'End Sub
    'Sub loadselectionitemcombo()
    '    Item.flowselect.controls.clear()
    '    Dim itemid As Integer = Item.ItemIdSend
    '    'dim table as string = "itemselection"
    '    'dim field as string = "cateselectionid"
    '    'dim where as string = "itemid='" & itemid & "' and active=1"
    '    'dim dataitemid as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
    '    Dim dataitemid As DataTable = executesql("select cateselectionid from itemselection where itemid='" & itemid & "' and active=1")
    '    'msgbox(dataitemid(0)("cateselectionid"))
    '    If dataitemid.Rows.Count = 0 Then
    '        Exit Sub
    '    Else
    '        Dim selectionid As String = dataitemid(0)("cateselectionid")
    '        'table = "categoryselection"
    '        'field = "categoryselectionname,categoryselectionid"
    '        'where = "categoryselectionid='" & selectionid & "'"
    '        'dim checkdata as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
    '        Dim checkdata As DataTable = executesql("select categoryselectionname,categoryselectionid from categoryselection where categoryselectionid='" & selectionid & "'")
    '        For i As Integer = 0 To checkdata.Rows.Count - 1
    '            Dim btncateselection As New Button
    '            btncateselection.Name = checkdata(i)("categoryselectionid")
    '            btncateselection.Text = checkdata(i)("categoryselectionname")
    '            btncateselection.Height = 30
    '            btncateselection.Width = 375
    '            btncateselection.BackColor = Color.LightGray
    '            btncateselection.FlatStyle = FlatStyle.Flat
    '            Item.flowselect.controls.add(btncateselection)
    '        Next
    '    End If
    'End Sub
    Sub savecateselectiontoitem()
        'check cateselection
        Dim cateselectionname As String = FrmItemAddCategorySelection.TxtSrcCategoryName.Text
        'dim table as string = "categoryselection"
        'dim field as string = "categoryselectionname,categoryselectionid"
        'dim where as string = "categoryselectionname='" & cateselectionname & "'"
        'dim checkdata as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim checkdata As DataTable = executesql("SELECT CategorySelectionName,CategorySelectionId FROM CategorySelection WHERE CategorySelectionName='" & cateselectionname & "'")
        'executesql("select categoryselectionname,categoryselectionid from categoryselection where categoryselectionname='" & cateselectionname & "'")
        If checkdata.Rows.Count = 0 Then
            MsgBox("กรุณาเลือกหมวดให้ถูกต้อง")
            Exit Sub
        End If
        Dim cateselectionid As Integer = checkdata(0)("CategorySelectionId")
        'check in table itemseletion
        'table = "itemselection"
        'field = "cateselectionid"
        'where = "cateselectionid='" & cateselectionid & "'"
        'dim checkselection as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim checkselection As DataTable = executesql("SELECT CateSelectionId FROM ItemSelection WHERE CateSelectionId='" & cateselectionid & "' and ItemId = '" & Item.ItemIdSend & "'")
        'executesql("select cateselectionid from itemselection where cateselectionid='" & cateselectionid & "'")
        If checkselection.Rows.Count > 0 Then
            MsgBox("มีหมวดสินค้านี้อยู่แล้ว")
            Exit Sub
        End If
        'insert into itemselection 
        Dim itemid As Integer = Item.TxtItemId.Text
        Dim cateid As Integer = cateselectionid
        Dim active As Integer = 1
        'table = "itemselection"
        'field = "itemid,cateselectionid,active"
        'value = "'" & itemid & "','" & cateid & "','" & active & "'"
        'modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=insert&table=" & table & "&field=" & field & "&value=" & value & "")
        executesql("INSERT INTO ItemSelection(ItemId,CateSelectionId,Active) values('" & itemid & "','" & cateid & "','" & active & "')")
        'executesql("insert into itemselection(itemid,cateselectionid,active) values('" & itemid & "','" & cateid & "','" & active & "')")
        ModuleItems.LoadCategorySelection()
        FrmItemAddCategorySelection.Close()
    End Sub
    'Sub savecateselectioncombo()
    '    'check cateselection
    '    Dim cateselectionname As String = Item.comboselection.text
    '    'dim table as string = "categoryselection"
    '    'dim field as string = "categoryselectionname,categoryselectionid"
    '    'dim where as string = "categoryselectionname='" & cateselectionname & "'"
    '    Dim value As String
    '    'dim checkdata as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
    '    Dim checkdata As DataTable = executesql("select categoryselectionname,categoryselectionid from categoryselection where categoryselectionname='" & cateselectionname & "'")
    '    'executesql("select categoryselectionname,categoryselectionid from categoryselection where categoryselectionname='" & cateselectionname & "'")
    '    If checkdata.Rows.Count = 0 Then
    '        MsgBox("กรุณาเลือกหมวดให้ถูกต้อง")
    '        Exit Sub
    '    End If
    '    Dim cateselectionid As Integer = checkdata(0)("categoryselectionid")
    '    'check in table itemseletion
    '    'table = "itemselection"
    '    'field = "cateselectionid"
    '    'where = "cateselectionid='" & cateselectionid & "'"
    '    'dim checkselection as datatable = modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=select&table=" & table & "&field=" & field & "&where=" & where & "")
    '    Dim checkselection As DataTable = executesql("select cateselectionid from itemselection where cateselectionid='" & cateselectionid & "'")
    '    'executesql("select cateselectionid from itemselection where cateselectionid='" & cateselectionid & "'")
    '    If checkselection.Rows.Count > 0 Then
    '        MsgBox("มีหมวดสินค้านี้อยู่แล้ว")
    '        Exit Sub
    '    End If
    '    'insert into itemselection 
    '    Dim itemid As Integer = Item.ItemIdSend
    '    Dim cateid As Integer = cateselectionid
    '    Dim active As Integer = 1
    '    'table = "itemselection"
    '    'field = "itemid,cateselectionid,active"
    '    'value = "'" & itemid & "','" & cateid & "','" & active & "'"
    '    'modulegetdataapi.gett("http://testnoi.hiveup.co/api/vbapi.php?action=insert&table=" & table & "&field=" & field & "&value=" & value & "")
    '    executesql("insert itemselection(itemid,cateselectionid,active) values('" & itemid & "','" & cateid & "','" & active & "')")
    '    'executesql("insert into itemselection(itemid,cateselectionid,active) values('" & itemid & "','" & cateid & "','" & active & "')")
    '    ModuleItems.LoadCategorySelection()
    '    For i As Integer = 0 To checkdata.Rows.Count - 1
    '        Dim btncateselection As New Button
    '        btncateselection.Name = checkdata(i)("categoryselectionid")
    '        btncateselection.Text = checkdata(i)("categoryselectionname")
    '        btncateselection.Height = 30
    '        btncateselection.Width = 375
    '        btncateselection.BackColor = Color.LightGray
    '        btncateselection.FlatStyle = FlatStyle.Flat
    '        Item.flowselect.controls.add(btncateselection)
    '    Next

    'End Sub
End Module
