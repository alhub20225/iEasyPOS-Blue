Public Class FrmManageTable
    Private Sub FrmManageTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanelTable.Controls.Clear()
        txtZoneName.Text = ""
        txtTableName.Text = ""
        ModuleManageTable2.LoadZone()
    End Sub

    Private Sub BtnAddTable_Click(sender As Object, e As EventArgs) Handles BtnAddTable.Click
        If ModuleManageTable2.ZoneId_Zone = 0 Then
            MsgBox("กรุณาเลือก Zone ก่อนเพิ่มโต๊ะ", MsgBoxStyle.Information, "เลือก Zone")
            Exit Sub
        End If
        If ModuleManageTable2.ZoneId_Zone = 0 Then
            MsgBox("กรุณาเลือก Zone ก่อนเพิ่มโต๊ะ", MsgBoxStyle.Information, "เลือก Zone")
            Exit Sub
        Else
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(FrmAddTable.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.2
                plexi.Show()
                FrmAddTable.StartPosition = FormStartPosition.CenterParent
                FrmAddTable.ShowDialog(plexi)
            End Using
            'FrmAddTable.Show()
        End If
    End Sub

    Private Sub BtnEditTable_Click(sender As Object, e As EventArgs) Handles BtnEditTable.Click
        Dim LoadDatatable As DataTable = executesql("SELECT StateStatus FROM Tables WHERE TableId='" & TableId_Zone & "' AND Active=1")
        If ModuleManageTable2.TableId_Zone = 0 Then
            MsgBox("กรุณาเลือกโต๊ะก่อน", MsgBoxStyle.Information, "เลือก")
            Exit Sub
        End If
        If TableId2_Zone <> Nothing Then
            MsgBox("ไม่สามารถแก้ไขได้ โต๊ะนี้ทำการรวมโต๊ะอยู่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If LoadDatatable(0)("StateStatus") = 1 Then
            MsgBox("ไม่สามารถแก้ไขได้ โต๊ะนี้ใช้งานอยู่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmEditTableChair.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.2
            plexi.Show()
            FrmEditTableChair.StartPosition = FormStartPosition.CenterParent
            FrmEditTableChair.ShowDialog(plexi)
        End Using
        'FrmEditTableChair.Show()
    End Sub

    Private Sub BtnDeleteTable_Click(sender As Object, e As EventArgs) Handles BtnDeleteTable.Click
        'Delete Table 
        If TableId2_Zone <> Nothing Then
            MsgBox("ไม่สามารถแก้ไขได้ โต๊ะนี้ทำการรวมโต๊ะอยู่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim LoadDatatable As DataTable = executesql("SELECT StateStatus FROM Tables WHERE TableId='" & TableId_Zone & "' AND Active=1")
        If LoadDatatable(0)("StateStatus") = 1 Then
            MsgBox("ไม่สามารถแก้ไขได้ โต๊ะนี้ใช้งานอยู่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim ZoneId As Integer = ModuleManageTable2.ZoneId_Zone
        Dim TableId As Integer = ModuleManageTable2.TableId_Zone
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
                MsgBox("ไม่สามารถลบได้ โต๊ะนี้มีการใช้งานอยู่", MsgBoxStyle.Critical)
                Exit Sub
            Else
                'Update Active Table

                executesql("UPDATE Tables SET Active=0 WHERE TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'")
                'Update Chairs 

                executesql("UPDATE Chairs SET Active=0 WHERE TableId='" & TableId & "'")
                ModuleZoneTable.LoadTable(ZoneId)
                ModuleManageTable2.LoadTable(ZoneId)
                txtTableName.Text = ""
                Exit Sub
            End If
        ElseIf Answer = vbNo Then
            Exit Sub
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
        Main2.TabControlMain.SelectedTabPageIndex = 1
        FrmTable.TopLevel = False
        FrmTable.FormBorderStyle = FormBorderStyle.None
        FrmTable.WindowState = FormWindowState.Maximized
        FrmTable.Dock = DockStyle.Fill
        FrmTable.LoadRefresh()
        Main2.XtraTabPage2.Controls.Add(FrmTable)
        FrmTable.Show()
        TableId = 0
    End Sub
End Class