Public Class Table
    Private Sub Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ตำแหน่งปุ่ม
        'ปิด
        Close_table.Location = New System.Drawing.Point(
            Me.ClientRectangle.Width - Close_table.Width, 0)
        Close_table.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        Top_tap.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        Top_tap.Width = Me.Width
        ModuleZoneTable.LoadZone()
        'ModuleZoneTable.First_LoadTable()

        'clear
        'DisCount = 0
        Type = Nothing
        TB_DisCount = 0
        POS.DiscountByItem2 = Nothing

        Timer1.Start()
    End Sub
    Private Sub BtnAddZone_Click(sender As Object, e As EventArgs) Handles BtnAddZone.Click
        FrmAddZones.Show()
    End Sub
    Private Sub BtnEditZone_Click(sender As Object, e As EventArgs) Handles BtnEditZone.Click
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือก Zone ก่อนกดปุ่มแก้ไข", MsgBoxStyle.Information, "เลือก Zone")
            Exit Sub
        Else
            FrmEditZone.Show()
            FrmEditZone.TxtZoneName.Text = ZoneName
        End If
    End Sub
    Private Sub BtnDeleteZone_Click(sender As Object, e As EventArgs) Handles BtnDeleteZone.Click
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือก Zone ก่อนกดปุ่มลบ", MsgBoxStyle.Information, "เลือก Zone")
            Exit Sub
        Else
            ModuleZoneTable.DeleteZone()
        End If
    End Sub
    Private Sub BtnAddTable_Click(sender As Object, e As EventArgs) Handles BtnAddTable.Click
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือก Zone ก่อนเพิ่มโต๊ะ", MsgBoxStyle.Information, "เลือก Zone")
            Exit Sub
        Else
            FrmAddTable.Show()
        End If
    End Sub
    Private Sub BtnEditTable_Click(sender As Object, e As EventArgs) Handles BtnEditTable.Click
        If ModuleZoneTable.TableId = 0 Then
            MsgBox("กรุณาเลือกโต๊ะก่อน", MsgBoxStyle.Information, "เลือก")
            Exit Sub
        Else
            FrmEditTableChair.Show()
        End If
    End Sub
    Private Sub BtnDeleteTable_Click(sender As Object, e As EventArgs) Handles BtnDeleteTable.Click
        'Delete Table 
        Dim ZoneId As Integer = ModuleZoneTable.ZoneId
        Dim TableId As Integer = ModuleZoneTable.TableId
        If TableId = 0 Then
            MsgBox("กรุณาเลือก Table", MsgBoxStyle.Information, "เลือก")
            Exit Sub
        End If
        Dim Answer As String = MsgBox("แน่ใจว่าต้องการลบโต๊ะ", MsgBoxStyle.YesNo)
        If Answer = vbYes Then
            Dim field As String = "StateStatus"
            Dim table As String = "Tables"
            Dim Where As String = "TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'"
            'Dim CheckStatustable As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
            Dim CheckStatustable As DataTable = executesql("SELECT StateStatus FROM Tables WHERE TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'")
            'MsgBox(CheckStatustable(0)(0))
            If CheckStatustable(0)("StateStatus") <> 0 Then
                MsgBox("โต๊ะมีการใช้งาน", vbCritical, "")
                Exit Sub
            Else
                'Update Active Table
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=Active=0&where=" & Where & "")
                executesql("UPDATE Tables SET Active=0 WHERE TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'")
                'Update Chairs 
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Chairs&value=Active=0&where=TableId='" & TableId & "'")
                executesql("UPDATE Chairs SET Active=0 WHERE TableId='" & TableId & "'")
                ModuleZoneTable.LoadTable()
                Exit Sub
            End If
        ElseIf Answer = vbNo Then
            Exit Sub
        End If
    End Sub

    Private Sub Close_table_Click(sender As Object, e As EventArgs) Handles Close_table.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmQueue.Close()
        FrmQueue.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmShowQueue.Close()
        FrmShowQueue.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ModuleZoneTable.LoadZone()
        ModuleZoneTable.First_LoadTable()
        FlowLayoutPanelZone.Visible = True
        Panel1.Visible = True
        Panel4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("ต้องการลบคิวทั้งหมด ใช่หรือไม่", MsgBoxStyle.YesNo, "คำเตือน") = MsgBoxResult.Yes Then
            ResetQ()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTableTime.Text = TimeOfDay
    End Sub
End Class