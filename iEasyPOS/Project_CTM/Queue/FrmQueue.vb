Public Class FrmQueue
    Private Sub BtnAddQ_Click(sender As Object, e As EventArgs) Handles BtnAddQ.Click
        If SelectQ.QueueId_edit > 0 Then
            If txtNumOfCus.Text = "" Then
                MsgBox("กรุณาใส่จำนวนลูกค้า", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            EditQ()
            FrmShowQueue.Close()
            FrmShowQueue.Show()
            Me.Close()
        Else
            If txtNumOfCus.Text = "" Then
                MsgBox("กรุณาใส่จำนวนลูกค้า", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            ModuleQueue.Qnumber()
            txtNumOfCus.Text = ""
            txtNumOfCus.Focus()
            ModuleQueue.Qload()
            ModuleQueue.loadTableType()
            FrmShowQueue.Close()
            FrmShowQueue.Show()
            Me.Close()
        End If

    End Sub

    Private Sub FrmQueue_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimeNow.Start()
        If SelectQ.QueueId_edit > 0 Then
            'Dim tables As String = "Queue"
            'Dim field As String = "QueueId,Qtext"
            'Dim where As String = "QueueId ='" & SelectQ.QueueId_edit & "'"
            'Dim selectQ_Edit As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & where & "")
            Dim selectQ_Edit As DataTable = executesql("SELECT QueueId,Qtext FROM Queue WHERE QueueId ='" & SelectQ.QueueId_edit & "'")
            Label_Q.Text = selectQ_Edit(0)("Qtext")
            ModuleQueue.loadTableType()
        ElseIf SelectQ.QueueId_edit = 0 Then
            ModuleQueue.Qload()
            ModuleQueue.loadTableType()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TimeNow_Tick(sender As Object, e As EventArgs) Handles TimeNow.Tick
        txtTimeNow.Text = TimeOfDay
    End Sub
End Class