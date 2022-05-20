Public Class FrmAddTable
    Private Sub FrmAddTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtZoneName.Text = ModuleZoneTable.ZoneName
        ModuleZoneTable.LoadTableType()
    End Sub
    Private Sub BtnAddTable_Click(sender As Object, e As EventArgs) Handles BtnAddTable.Click
        'Save Table
        If TxtTableName.Text = "" Then
            MsgBox("กรุรากรอกชื่อโต๊ะ", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim CheckTableName As DataTable = executesql("SELECT TableName FROM Tables WHERE TableName='" & TxtTableName.Text & "' AND ZoneId='" & ModuleZoneTable.ZoneId & "'")
            If CheckTableName.Rows.Count > 0 Then
                MsgBox("ชื่อโต๊ะซ้ำ", MsgBoxStyle.Information)
                Exit Sub
            Else
                'insert Table 
                Dim ZoneId As Integer = ModuleZoneTable.ZoneId
                Dim TableName As String = TxtTableName.Text
                Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
                executesql("INSERT INTO Tables(ZoneId,TableName,Active,InsertDate,StateStatus) VALUES('" & ZoneId & "','" & TableName & "',1,'" & InsertDate & "',0)")
                ModuleZoneTable.LoadTable()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class