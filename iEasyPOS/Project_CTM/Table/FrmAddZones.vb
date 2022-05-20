Public Class FrmAddZones
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtZoneName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ Zone ให้เรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim CheckNameZone As DataTable = executesql("SELECT ZoneName FROM Zones WHERE ZoneName='" & TxtZoneName.Text & "' AND Active=1")
            If CheckNameZone.Rows.Count > 0 Then
                MsgBox("ชื่อ Zone ซ้ำกรุณาเปลี่ยน", MsgBoxStyle.Critical)
                Exit Sub
            Else
                'Insert Zone 
                Dim InsDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
                Dim BtnColor As Integer = ColorBtnZone.Value.ToArgb
                If BtnColor = 0 Then
                    BtnColor = -1
                End If
                executesql("INSERT INTO Zones(ZoneName,Active,InsertDate,BackgroundColor) VALUES('" & TxtZoneName.Text & "',1,'" & InsDate & "','" & BtnColor & "')")
                MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information)
                ModuleZoneTable.LoadZone()
                First_LoadTable()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Me.Close()
    End Sub
End Class