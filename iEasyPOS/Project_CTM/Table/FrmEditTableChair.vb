Public Class FrmEditTableChair
    Sub LoadChair()
        DgChair.Rows.Clear()
        Dim field As String = "ChairName"
        Dim tables As String = "Chairs"
        Dim Where As String = "TableId='" & ModuleZoneTable.TableId & "' AND Active=1"
        Dim DataChair As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & Where & "")
        'Dim DataChair As DataTable = executesql("SELECT ChairName FROM Chairs WHERE TableId='" & ModuleZoneTable.TableId & "' AND Active=1")
        For i As Integer = 0 To DataChair.Rows.Count - 1
            DgChair.Rows.Add(DataChair(i)(0))
        Next
    End Sub
    Private Sub FrmAddTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtZoneName.Text = Table.LbZoneSelect.Text
        TxtTableName.Text = ModuleZoneTable.TableName
        LoadChair()
    End Sub
    Private Sub BtnAddChair_Click(sender As Object, e As EventArgs) Handles BtnAddChair.Click
        If NumericChair.Value = 0 Then
            MsgBox("กรุณากรอกชื่อเก้าอี้", MsgBoxStyle.Critical)
            Exit Sub
        Else
            'Insert Chairs
            Dim ChairItems As Integer = NumericChair.Value

            For i As Integer = 1 To ChairItems Step 1
                Dim field As String = "ChairId"
                Dim tables As String = "Chairs"
                Dim Where As String = "TableID ='" & ModuleZoneTable.TableId & "'"
                Dim RowsChairs As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & Where & "")
                'Dim RowsChairs As DataTable = executesql("SELECT ChairId FROM Chairs WHERE TableID ='" & ModuleZoneTable.TableId & "'")
                Dim Id As Integer
                If RowsChairs.Rows.Count = 0 Then
                    Id = 1
                ElseIf RowsChairs.Rows.Count > 0 Then
                    Id = CDbl(RowsChairs.Rows.Count) + 1
                End If
                Dim ChairsName As String = TxtTableName.Text + "-" + Id.ToString
                Dim InsDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
                ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=ChairName,TableId,Active,InsertDate,Status&table=Chairs&value='" & ChairsName & "','" & ModuleZoneTable.TableId & "','1','" & InsDate & "','0'")
                'executesql("INSERT INTO Chairs(ChairName, TableId, Active, InsertDate, Status) VALUES('" & ChairsName & "','" & ModuleZoneTable.TableId & "',1,'" & InsDate & "',0)")
            Next
            NumericChair.Value = 0
            LoadChair()
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnDeleteChair_Click(sender As Object, e As EventArgs) Handles BtnDeleteChair.Click
        Dim ChairName As String = DgChair.CurrentRow.Cells(0).Value
        Dim TaBleId As Integer = ModuleZoneTable.TableId
        'Delete Chairs
        Dim Where As String = "ChairName='" & ChairName & "' AND TableId='" & TaBleId & "'"
        ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Chairs&value=Active=0&where=" & Where & "")
        'executesql("UPDATE Chairs SET Active=0 WHERE ChairName='" & ChairName & "' AND TableId='" & TaBleId & "'")
        LoadChair()
    End Sub
    Private Sub BtnAddTable_Click(sender As Object, e As EventArgs) Handles BtnAddTable.Click
        'Update TableName 
        Dim Updatedate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim TableName As String = TxtTableName.Text
        Dim ZoneId As String = ModuleZoneTable.ZoneId
        Dim TableId As Integer = ModuleZoneTable.TableId
        Dim Where As String = "TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'"
        Dim Value As String = "TableName='" & TableName & "'"
        ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Tables&value=" & Value & "&where=" & Where & "")
        'executesql("UPDATE Tables SET TableName='" & TableName & "' WHERE TableId='" & TableId & "' AND ZoneId='" & ZoneId & "'")
        ModuleZoneTable.LoadTable()
        MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class