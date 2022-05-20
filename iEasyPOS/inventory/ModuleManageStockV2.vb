Module ModuleManageStockV2
    Dim stockId As Integer
    Dim field As String = ""
    Dim table As String = ""
    Dim Where As String = ""
    Dim join As String = ""
    Dim value As String = ""
    Sub loadData()
        stockId = 0
        genNewCode()
        field = "StockId,StockCode,StockName"
        table = "Stock"
        Where = "Active=1"
        'Dim showData As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
        Dim showData As DataTable = executesql("SELECT StockId,StockCode,StockName FROM Stock WHERE Active=1")
        Edit_Store.DataGridViewSearch.Rows.Clear()
        For i As Integer = 0 To showData.Rows.Count - 1
            Edit_Store.DataGridViewSearch.Rows.Add(showData(i)("StockCode"), showData(i)("StockName"))
        Next
    End Sub
    Sub genNewCode()
        field = "COUNT(StockId) As CountStock"
        table = "Stock"
        Where = ""
        'Dim countStock As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "")
        Dim countStock As DataTable = executesql("SELECT COUNT(StockId) As CountStock FROM Stock")
        Dim numStock As Integer = countStock(0)("CountStock") + 1
        Edit_Store.txtStockCode.Text = "ST" & numStock.ToString("D5")
    End Sub
    Sub clear()
        genNewCode()
        Edit_Store.txtStockName.Clear()
        stockId = 0
    End Sub
    Sub btnSearch()
        Edit_Store.DataGridViewSearch.Rows.Clear()
        field = "StockId,StockCode,StockName"
        table = "Stock"
        Where = "Active=1 AND StockCode LIKE '%" & Edit_Store.txtSearch.Text & "%'"
        'Dim showData As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
        Dim showData As DataTable = executesql("SELECT StockId,StockCode,StockName FROM Stock WHERE Active=1 AND StockCode LIKE '%" & FrmManageStock.txtSearch.Text & "%'")
        For i As Integer = 0 To showData.Rows.Count - 1
            Edit_Store.DataGridViewSearch.Rows.Add(showData(i)("StockCode"), showData(i)("StockName"))
        Next
    End Sub
    Sub showData()
        Try
            field = "StockId,StockCode,StockName"
            table = "Stock"
            Where = "StockCode='" & Edit_Store.DataGridViewSearch.CurrentRow.Cells(0).Value & "' AND Active = 1"
            'Dim getStockData As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
            Dim getStockData As DataTable = executesql("SELECT StockId,StockCode,StockName FROM Stock WHERE StockCode='" & FrmManageStock.DataGridViewSearch.CurrentRow.Cells(0).Value & "' AND Active = 1")
            stockId = getStockData(0)("StockId")
            Edit_Store.txtStockCode.Text = getStockData(0)("StockCode")
            Edit_Store.txtStockName.Text = getStockData(0)("StockName")
        Catch ex As Exception
            clear()
        End Try
    End Sub
    Sub btnSave()
        If Edit_Store.txtStockCode.Text = "" Then
            MsgBox("กรุณากรอก Stock Code", MsgBoxStyle.Critical)
            Edit_Store.txtStockCode.Focus()
            Exit Sub
        End If
        If Edit_Store.txtStockName.Text = "" Then
            MsgBox("กรุณากรอก Stock Name", MsgBoxStyle.Critical)
            Edit_Store.txtStockName.Focus()
            Exit Sub
        End If
        If stockId = 0 Then
            field = "StockId"
            table = "Stock"
            Where = "StockCode='" & Edit_Store.txtStockCode.Text & "'"
            ' Dim checkStockCode As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
            Dim checkStockCode As DataTable = executesql("SELECT StockId FROM Stock WHERE StockCode='" & Edit_Store.txtStockCode.Text & "'")
            If checkStockCode.Rows.Count > 0 Then
                MsgBox("Stock Code ซ้ำ", MsgBoxStyle.Critical)
                Edit_Store.txtStockCode.Focus()
                Exit Sub
            End If
            field = "StockCode,StockName,Active"
            table = "Stock"
            value = "'" & Edit_Store.txtStockCode.Text & "','" & Edit_Store.txtStockName.Text & "','1'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=" & field & "&table=" & table & "&value=" & value & "")
            executesql("INSERT INTO Stock(StockCode,StockName,Active) VALUES('" & Edit_Store.txtStockCode.Text & "','" & Edit_Store.txtStockName.Text & "','1')")
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
            loadData()
            ModuleManageStock.loadData()
            clear()
        Else
            field = "StockId"
            table = "Stock"
            Where = "StockCode='" & Edit_Store.txtStockCode.Text & "' AND StockId<>'" & stockId & "'"
            'Dim checkStockCode As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
            Dim checkStockCode As DataTable = executesql("SELECT StockId FROM Stock WHERE StockCode='" & Edit_Store.txtStockCode.Text & "' AND StockId<>'" & stockId & "'")
            If checkStockCode.Rows.Count > 0 Then
                MsgBox("Stock Code ซ้ำ", MsgBoxStyle.Critical)
                Edit_Store.txtStockCode.Focus()
                Exit Sub
            End If
            value = "StockCode='" & Edit_Store.txtStockCode.Text & "',StockName='" & Edit_Store.txtStockName.Text & "'"
            table = "Stock"
            Where = "StockId='" & stockId & "'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&value=" & value & "&table=" & table & "&where=" & Where & "")
            executesql("UPDATE Stock SET StockCode='" & Edit_Store.txtStockCode.Text & "',StockName='" & Edit_Store.txtStockName.Text & "' WHERE StockId='" & stockId & "'")
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
            loadData()
            ModuleManageStock.loadData()
            clear()
        End If
    End Sub
    Sub btnDelete()
        If stockId = 0 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการที่จะลบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("ต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            value = "Active=0"
            table = "Stock"
            Where = "StockId='" & stockId & "'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&value=" & value & "&table=" & table & "&where=" & Where & "")
            executesql("UPDATE Stock SET Active=0 WHERE StockId='" & stockId & "'")
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
            loadData()
            ModuleManageStock.loadData()
            clear()
        End If
    End Sub
End Module
