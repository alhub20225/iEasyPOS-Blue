Public Class Frm_Break
    Dim breakId As Integer
    Private Sub Frm_Break_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Sub loadData()
        DataGridView_Break.Rows.Clear()

        Dim selectBreak As DataTable = executesql("SELECT BreakId,BreakName FROM Breaks WHERE Active=1")
        If IsDBNull(selectBreak) Then
            Exit Sub
        Else
            For i As Integer = 0 To selectBreak.Rows.Count - 1
                DataGridView_Break.Rows.Add(selectBreak(i)("BreakId"), selectBreak(i)("BreakName"))
            Next
            Dim active = New Dictionary(Of String, String)()
            active("1") = "เปิด"
            active("0") = "ปิด"
            ComboBoxBreakActive.DataSource = New BindingSource(active, Nothing)
            ComboBoxBreakActive.DisplayMember = "Value"
            ComboBoxBreakActive.ValueMember = "Key"
            breakId = 0
        End If

    End Sub
    Sub clear()
        txtBreak.Clear()
    End Sub
    Private Sub btnAddBreak_Click(sender As Object, e As EventArgs) Handles btnAddBreak.Click
        If txtBreak.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            txtBreak.Focus()
            Exit Sub
        End If
        'Dim checkBreak As DataTable = executesql("SELECT BreakName FROM Break WHERE BreakId='" & DataGridView_Break.CurrentRow.Cells(0).Value & "'")
        Try
            If breakId = 0 Then
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=BreakName,Active&table=Breaks&value='" & txtBreak.Text & "','1'")
                executesql("INSERT INTO Breaks(BreakName,Active) VALUES('" & txtBreak.Text & "','1')")
            Else
                'Dim Value As String = "BreakName='" & txtBreak.Text & "', Active=" & ComboBoxBreakActive.SelectedValue & ""
                'Dim Where As String = "BreakId='" & DataGridView_Break.CurrentRow.Cells(0).Value & "'"
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Breaks&value=" & Value & "&where=" & Where & "")
                executesql("UPDATE Breaks SET BreakName='" & txtBreak.Text & "', Active='" & ComboBoxBreakActive.SelectedValue & "' WHERE BreakId='" & DataGridView_Break.CurrentRow.Cells(0).Value & "'")
            End If
        Catch ex As Exception
        End Try
        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        loadData()
        Frm_Employee.loadData()
        clear()
    End Sub

    Private Sub DataGridView_Break_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Break.CellClick
        Try
            breakId = DataGridView_Break.CurrentRow.Cells(0).Value
            'Dim field As String = "BreakId,BreakName"
            'Dim tables As String = "Breaks"
            'Dim Where As String = "BreakId='" & DataGridView_Break.CurrentRow.Cells(0).Value & "'"
            'Dim showBreak As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & tables & "&where=" & Where & "")
            Dim showBreak As DataTable = executesql("SELECT BreakId,BreakName FROM Breaks WHERE BreakId='" & DataGridView_Break.CurrentRow.Cells(0).Value & "'")
            txtBreak.Text = showBreak(0)("BreakName")
        Catch ex As Exception
            breakId = 0
            clear()
        End Try
    End Sub

End Class