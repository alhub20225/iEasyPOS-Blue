Public Class FrmEditZone
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtZoneName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ Zone ก่อนบันทึก", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim BtnColor As Integer = ColorBoxEditZone.Value.ToArgb
            Dim ZoneId As Integer = ModuleZoneTable.ZoneId
            Dim UpdateTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            If BtnColor = 0 Then
                executesql("UPDATE Zones SET Zonename ='" & TxtZoneName.Text & "',UpdateDate='" & UpdateTime & "' WHERE ZoneId ='" & ZoneId & "'")
                MsgBox("แก้ไขเรียบร้อย", MsgBoxStyle.Information)
                ModuleZoneTable.LoadZone()
            Else
                executesql("UPDATE Zones SET Zonename='" & TxtZoneName.Text & "',UpdateDate='" & UpdateTime & "',BackgroundColor='" & BtnColor & "' WHERE ZoneId='" & ZoneId & "'")
                MsgBox("แก้ไขเรียบร้อย", MsgBoxStyle.Information)
                ModuleZoneTable.LoadZone()
            End If
            Me.Close()
            ModuleZoneTable.LoadZone()
            First_LoadTable()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class