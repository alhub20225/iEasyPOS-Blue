Module ModuleQueue
    Public tyepId As Integer
    Public typeName As String
    Sub Qnumber()
        Dim tables As String = "Queue"
        Dim field As String = "QueueId"
        'Dim where As String = "Status=1"
        Dim value As String
        'Dim selectQ As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "")
        Dim selectQ As DataTable = executesql("SELECT QueueId FROM Queue")
        Dim Num_Q As Integer = selectQ.Rows.Count
        Dim Q As Integer = Num_Q + 1
        field = "QueueId,NumOfCus,Status,Qtext,TableTypeId,StartTime"
        value = "'" & Q & "','" & FrmQueue.txtNumOfCus.Text & "',1,'" & FrmQueue.Label_Q.Text & "','" & tyepId & "','" & FrmQueue.txtTimeNow.Text & "'"
        tables = "Queue"
        Clipboard.SetText("INSERT INTO Queue(QueueId,NumOfCus,Status,Qtext,TableTypeId,StartTime) VALUES('" & Q & "','" & FrmQueue.txtNumOfCus.Text & "',1,'" & FrmQueue.Label_Q.Text & "','" & tyepId & "','" & FrmQueue.txtTimeNow.Text & "')")
        executesql("INSERT INTO Queue(QueueId,NumOfCus,Status,Qtext,TableTypeId,StartTime) VALUES('" & Q & "','" & FrmQueue.txtNumOfCus.Text & "',1,'" & FrmQueue.Label_Q.Text & "','" & tyepId & "','" & FrmQueue.txtTimeNow.Text & "')")
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=" & field & "&table=" & tables & "&value=" & value & "")
    End Sub
    Sub Qload()
        Dim tables As String = "Queue"
        Dim field As String = "Id"
        'Dim where As String = "Status=1"
        'Dim selectQ As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "")
        Dim selectQ As DataTable = executesql("SELECT Id FROM Queue")
        Dim Num_Q As Integer = selectQ.Rows.Count
        Dim Q As Integer = Num_Q + 1
        FrmQueue.Label_Q.Text = "Q" + Q.ToString
        FrmQueue.LabelTable.Text = ""
    End Sub
    Public Sub getId(sender As Object, e As EventArgs)
        tyepId = sender.tag
        typeName = sender.Name
        FrmQueue.LabelTable.Text = typeName
    End Sub
    Sub loadTableType()
        FrmQueue.FlowTableType.Controls.Clear()
        Dim tables As String = "TableType"
        Dim field As String = "TableTypeId,TableTypeName"
        Dim where As String = "Active=1"
        'Dim selectTableType As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & where & "")
        Dim selectTableType As DataTable = executesql("SELECT TableTypeId,TableTypeName FROM TableType WHERE Active=1")
        For i As Integer = 0 To selectTableType.Rows.Count - 1
            tables = "Tables"
            field = "TableId"
            where = "TableTypeId='" & selectTableType(i)("TableTypeId") & "' AND Active=1 AND StateStatus=0"
            'Dim selectTable As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & where & "")
            Dim selectTable As DataTable = executesql("SELECT TableId FROM Tables WHERE TableTypeId='" & selectTableType(i)("TableTypeId") & "' AND Active=1 AND StateStatus=0")
            Dim tablecount As Integer = selectTable.Rows.Count
            Dim TB_type As New Button
            TB_type.Tag = selectTableType(i)("TableTypeId")
            TB_type.Name = selectTableType(i)("TableTypeName")
            TB_type.Text = selectTableType(i)("TableTypeName") + vbCrLf + "ว่าง" + tablecount.ToString
            TB_type.Width = 100
            TB_type.Height = 100
            TB_type.BackColor = Color.DimGray
            TB_type.ForeColor = Color.White
            TB_type.FlatStyle = FlatStyle.Flat
            TB_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            FrmQueue.FlowTableType.Controls.Add(TB_type)
            AddHandler TB_type.Click, AddressOf getId
        Next
    End Sub
    Sub CancleQ()
        executesql("UPDATE Queue SET Status=0 WHERE QueueId='" & FrmShowQueue.QueueId_send & "'")
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Queue&value=Status=0&where=QueueId='" & FrmShowQueue.QueueId_send & "'")
        FrmShowQueue.QueueId_send = 0
    End Sub
    Sub EditQ()
        executesql("UPDATE Queue SET NumOfCus='" & FrmQueue.txtNumOfCus.Text & "',TableTypeId='" & tyepId & "' WHERE QueueId='" & SelectQ.QueueId_edit & "'")
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Queue&value=NumOfCus='" & FrmQueue.txtNumOfCus.Text & "',TableTypeId='" & tyepId & "'&where=QueueId='" & SelectQ.QueueId_edit & "'")
        SelectQ.QueueId_edit = 0
    End Sub
End Module
