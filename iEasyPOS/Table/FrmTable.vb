Public Class FrmTable
    Private Sub Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleZoneTable.LoadZone()
        Dim MinZone As DataTable = executesql("select min(ZoneId) as ZoneId ,ZoneName from Zones where Active=1 GROUP BY ZoneName")
        If MinZone.Rows.Count = 0 Then
            Exit Sub
        End If
        ModuleZoneTable.LoadTable(MinZone(0)("ZoneId"))
        LbZoneSelect.Text = MinZone(0)("ZoneName")
        ZoneId = MinZone(0)("ZoneId")
        'clear
        'DisCount = 0
        Type = Nothing
        TB_DisCount = 0
        POS.DiscountByItem2 = Nothing
        Timer1.Start()

        'ModuleZoneTable.LoadZone()
        'First_LoadTable()
        ''clear
        ''DisCount = 0
        'Type = Nothing
        'TB_DisCount = 0
        'POS.DiscountByItem2 = Nothing

        'Timer1.Start()
    End Sub

    Sub LoadRefresh()
        ModuleZoneTable.LoadZone()
        Dim MinZone As DataTable = executesql("select min(ZoneId) as ZoneId ,ZoneName from Zones where Active=1 GROUP BY ZoneName")
        If MinZone.Rows.Count = 0 Then
            Exit Sub
        End If
        ModuleZoneTable.LoadTable(MinZone(0)("ZoneId"))
        LbZoneSelect.Text = MinZone(0)("ZoneName")
        ZoneId = MinZone(0)("ZoneId")
        LbTableSelect.Text = ""

        Type = Nothing
        TB_DisCount = 0
        POS.DiscountByItem2 = Nothing
    End Sub
    Private Sub BtnAddZone_Click(sender As Object, e As EventArgs) Handles BtnAddZone.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmAddZones.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmAddZones.StartPosition = FormStartPosition.CenterParent
            FrmAddZones.ShowDialog(plexi)
        End Using
        'FrmAddZones.Show()
    End Sub
    Private Sub BtnEditZone_Click(sender As Object, e As EventArgs) Handles BtnEditZone.Click
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือก Zone ก่อนกดปุ่มแก้ไข", MsgBoxStyle.Information, "เลือก Zone")
            Exit Sub
        Else
            FrmEditZone.TxtZoneName.Text = ZoneName
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(FrmEditZone.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.6
                plexi.Show()
                FrmEditZone.StartPosition = FormStartPosition.CenterParent
                FrmEditZone.ShowDialog(plexi)
            End Using
            'FrmEditZone.Show()
        End If
    End Sub
    Private Sub BtnDeleteZone_Click(sender As Object, e As EventArgs) Handles BtnDeleteZone.Click
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือกโซน ก่อนกดปุ่มลบ", MsgBoxStyle.Information, "เลือกโซน")
            Exit Sub
        Else
            ModuleZoneTable.DeleteZone()
        End If
    End Sub
    Private Sub BtnAddTable_Click(sender As Object, e As EventArgs)
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือกโซน ก่อนเพิ่มโต๊ะ", MsgBoxStyle.Information, "เลือกโซน")
            Exit Sub
        Else
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(FrmAddTable.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.6
                plexi.Show()
                FrmAddTable.StartPosition = FormStartPosition.CenterParent
                FrmAddTable.ShowDialog(plexi)
            End Using
            'FrmAddTable.Show()
        End If
    End Sub
    Private Sub BtnEditTable_Click(sender As Object, e As EventArgs)
        If TableId2 <> Nothing Then
            MsgBox("ไม่สามารถแก้ไขได้ โต๊ะนี้ทำการรวมโต๊ะอยู่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ModuleZoneTable.TableId = 0 Then
            MsgBox("กรุณาเลือกโต๊ะก่อน", MsgBoxStyle.Information, "เลือก")
            Exit Sub
        Else
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(FrmEditTableChair.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.6
                plexi.Show()
                FrmEditTableChair.StartPosition = FormStartPosition.CenterParent
                FrmEditTableChair.ShowDialog(plexi)
            End Using
            'FrmEditTableChair.Show()
        End If
    End Sub
    Private Sub BtnDeleteTable_Click(sender As Object, e As EventArgs)
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

            Dim CheckStatustable As DataTable = executesql("SELECT StateStatus FROM Tables WHERE TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'")
            'MsgBox(CheckStatustable(0)(0))
            If CheckStatustable(0)("StateStatus") <> 0 Then
                MsgBox("ไม่สามารถลบได้ โต๊ะนี้มีการใช้งานอยู่", vbCritical, "")
                Exit Sub
            Else
                'Update Active Table

                executesql("UPDATE Tables SET Active=0 WHERE TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'")
                'Update Chairs 

                executesql("UPDATE Chairs SET Active=0 WHERE TableId='" & TableId & "'")
                ModuleZoneTable.LoadTable(ZoneId)
                LbTableSelect.Text = ""
                Exit Sub
            End If
        ElseIf Answer = vbNo Then
            Exit Sub
        End If
    End Sub

    'Private Sub Close_table_Click(sender As Object, e As EventArgs) Handles Close_table.Click
    '    Me.Close()
    '    Main2.Show()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmQueue.Close()
        FrmQueue.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmShowQueue.Close()
        FrmShowQueue.Show()
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    ModuleZoneTable.LoadZone()
    '    ModuleZoneTable.First_LoadTable()
    '    FlowLayoutPanelZone.Visible = True
    '    Panel1.Visible = True
    '    Panel4.Visible = True
    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("ต้องการลบคิวทั้งหมด ใช่หรือไม่", MsgBoxStyle.YesNo, "คำเตือน") = MsgBoxResult.Yes Then
            ResetQ()
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือกโซนก่อน", MsgBoxStyle.Information, "เลือกโซน")
            Exit Sub
        End If
        If LbZoneSelect.Text = Nothing Then
            MsgBox("กรุณาเลือกโซนก่อน", MsgBoxStyle.Information, "เลือกโซน")
            Exit Sub
        End If
        If ModuleZoneTable.TableId = 0 Then
            MsgBox("กรุณาเลือกโต๊ะก่อน", MsgBoxStyle.Information, "เลือกโต๊ะ")
            Exit Sub
        End If
        If LbTableSelect.Text = Nothing Then
            MsgBox("กรุณาเลือกโต๊ะก่อน", MsgBoxStyle.Information, "เลือกโต๊ะ")
            Exit Sub
        End If
        ModuleZoneTable.OpenTable()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmManageTable.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmManageTable.StartPosition = FormStartPosition.CenterParent
            FrmManageTable.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub btnDeleteTable_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class