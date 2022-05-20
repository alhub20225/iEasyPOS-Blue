Public Class FrmShowQueue
    Private Sub FrmShowQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeNow.Start()
        loadQ()
    End Sub
    Sub loadQ()
        'Dim selectType As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=TableTypeId,TableTypeName&table=TableType&where=Active=1")
        Dim selectType As DataTable = executesql("SELECT TableTypeId,TableTypeName FROM TableType WHERE Active=1")
        Dim main_flow As New FlowLayoutPanel
        Dim main_panel As New Panel
        main_panel.Dock = DockStyle.Fill
        main_flow.Dock = DockStyle.Fill
        main_flow.AutoScroll = True
        main_flow.WrapContents = False
        Toppanel.Controls.Add(main_panel)
        main_panel.Controls.Add(main_flow)
        For i As Integer = 0 To selectType.Rows.Count - 1
            Dim Panel1 As New Panel
            Panel1.Width = 350
            Panel1.Height = Me.Height - 100
            Panel1.BackColor = Color.White
            Panel1.Name = "Panel1" + selectType(i)("TableTypeId")
            main_flow.Controls.Add(Panel1)
            Dim Panel_subflow As New Panel
            Panel_subflow.Dock = DockStyle.Fill
            Panel_subflow.Name = "PanelSubFlow" + selectType(i)("TableTypeId")
            Panel1.Controls.Add(Panel_subflow)
            Dim LB_panle As New Panel
            LB_panle.Width = 350
            LB_panle.Dock = DockStyle.Top
            LB_panle.Name = "LB_panle" + selectType(i)("TableTypeId")
            Panel1.Controls.Add(LB_panle)
            Dim L1 As New Label
            L1.AutoSize = False
            L1.BackColor = Color.Green
            L1.ForeColor = Color.White
            L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            L1.TextAlign = ContentAlignment.MiddleCenter
            L1.Dock = DockStyle.Fill
            L1.Name = "L1" + selectType(i)("TableTypeId")
            'Dim tables As String = "Tables"
            'Dim field As String = "TableId"
            'Dim where As String = "TableTypeId='" & selectType(i)("TableTypeId") & "' AND Active=1 AND StateStatus=0"
            'Dim selectTable As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & where & "")
            Dim selectTable As DataTable = executesql("SELECT TableId FROM Tables WHERE TableTypeId='" & selectType(i)("TableTypeId") & "' AND Active=1 AND StateStatus=0")
            Dim tablecount As Integer = selectTable.Rows.Count
            L1.Text = selectType(i)("TableTypeName") + vbCrLf + "ว่าง" + tablecount.ToString
            LB_panle.Controls.Add(L1)
            Dim sup_flow As New FlowLayoutPanel
            sup_flow.Dock = DockStyle.Fill
            sup_flow.BackColor = Color.WhiteSmoke
            sup_flow.Name = "SubFlow" + selectType(i)("TableTypeId")
            Panel_subflow.Controls.Add(sup_flow)
            'Dim GetTypeId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=TableTypeId,TableTypeName&table=TableType&where=TableTypeName='" & selectType(i)("TableTypeName") & "'")
            Dim GetTypeId As DataTable = executesql("SELECT TableTypeId,TableTypeName FROM TableType WHERE TableTypeName='" & selectType(i)("TableTypeName") & "'")
            'tables = "Queue"
            'field = "Id,QueueId,Qtext,TableTypeId,NumOfCus,StartTime"
            'where = "Status=1 AND TableTypeId='" & GetTypeId(0)("TableTypeId") & "'"
            'Dim selectQ As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & where & "")
            Dim selectQ As DataTable = executesql("SELECT Id,QueueId,Qtext,TableTypeId,NumOfCus,StartTime FROM Queue WHERE Status=1 AND TableTypeId='" & GetTypeId(0)("TableTypeId") & "'")
            For q As Integer = 0 To selectQ.Rows.Count - 1
                Dim Btn_Q As New Button
                Dim totalTime = DateDiff(DateInterval.Minute, CDate(selectQ(0)("StartTime")), CDate(Now))
                Btn_Q.Name = selectQ(q)("QueueId")
                Btn_Q.Text = selectQ(q)("Qtext") + vbCrLf + selectQ(q)("NumOfCus") + "ท่าน"
                Btn_Q.Height = 100
                Btn_Q.Width = 345
                Btn_Q.ForeColor = Color.White
                If totalTime > 30 Then
                    Btn_Q.Image = Global.iEasyPOS.My.Resources.Resources.Smile_Red64
                ElseIf totalTime <= 30 Then
                    Btn_Q.Image = Global.iEasyPOS.My.Resources.Resources.Smile_Green64
                End If
                Btn_Q.ImageAlign = ContentAlignment.MiddleLeft
                Btn_Q.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
                Btn_Q.BackColor = Color.DodgerBlue
                Btn_Q.FlatStyle = FlatStyle.Flat
                sup_flow.Controls.Add(Btn_Q)
                Dim Time_label As New Label
                Time_label.Text = "เวลารอ " + totalTime.ToString + " นาที"
                Time_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
                Time_label.TextAlign = ContentAlignment.MiddleCenter
                Time_label.ForeColor = Color.White
                Time_label.BackColor = Color.DodgerBlue
                Time_label.AutoSize = False
                Time_label.Width = 120
                Time_label.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
                Time_label.Location = New System.Drawing.Point((Btn_Q.Width - Time_label.Width) - 10, 65)
                Btn_Q.Controls.Add(Time_label)
                AddHandler Btn_Q.Click, AddressOf GetIdQ
            Next
        Next
    End Sub
    Public QueueId_send As Integer = 0
    Public Sub GetIdQ(sender As Object, e As EventArgs)
        QueueId_send = sender.name
        SelectQ.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TimeNow_Tick(sender As Object, e As EventArgs) Handles TimeNow.Tick
        txtTimeNow_ShowQ.Text = TimeOfDay
    End Sub
End Class