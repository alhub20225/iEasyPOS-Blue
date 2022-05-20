Public Class SelectQ
    Public Shared TableTypeId_send As Integer
    Public Shared QueueId_edit As Integer
    Private Sub SelectQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSenderQ()
    End Sub
    Sub loadSenderQ()
        Dim Table As String = "Queue"
        Dim field As String = "Id,QueueId,Qtext,TableTypeId,NumOfCus"
        Dim Where As String = "Status=1 AND QueueId='" & FrmShowQueue.QueueId_send & "'"
        Dim selectQ As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & Table & "&where=" & Where & "")
        Label_Qnumber.Text = selectQ(0)("Qtext")
        LabelNumCus.Text = selectQ(0)("NumOfCus") + "ท่าน"
        TableTypeId_send = selectQ(0)("TableTypeId")
        QueueId_edit = selectQ(0)("QueueId")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("ต้องการลบคิว ใช่หรือไม่", MsgBoxStyle.YesNo, "คำเตือน") = MsgBoxResult.Yes Then
            CancleQ()
            FrmShowQueue.QueueId_send = 0
            QueueId_edit = 0
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        FrmShowQueue.QueueId_send = 0
        QueueId_edit = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmShowQueue.Close()
        FrmTable.Show()
        ModuleZoneTable.Add_Qtable()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmQueue.Close()
        FrmQueue.Show()
        Me.Close()
    End Sub
End Class