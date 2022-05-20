Public Class FrmDifinitionTitle
    Public Shared TitleIdSent As String = ""
    Sub LoadTitleName()
        'LoadData TitleName 
        DgName.Rows.Clear()
        Dim DataTitleName As DataTable = executesql("SELECT TitleId,TitleName FROM Titles WHERE Active=1")
        Dim Order As Integer = 1
        For i As Integer = 0 To DataTitleName.Rows.Count - 1
            Dim TitleId As Integer = DataTitleName(i)("TitleId")
            Dim TitleName As String = DataTitleName(i)("TitleName")
            DgName.Rows.Add(Order, TitleName, TitleId)
            Order += 1
        Next
        TxtName.Text = ""
    End Sub
    Private Sub FrmDifinitionTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTitleName()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtName.Text = "" Then
            MsgBox("กรุณากรอกชื่อข้อมูล", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Dim CheckData As DataTable = executesql("SELECT TitleName FROM Titles WHERE TitleName='" & TxtName.Text & "'")
            If CheckData.Rows.Count > 0 Then
                MsgBox("คำหน้านี้มีอยู๋แล้ว", MsgBoxStyle.Information)
                Exit Sub
            End If
            If TitleIdSent <> "" Then
                'Update TitleName
                executesql("UPDATE Titles SET TitleName='" & TxtName.Text & "' WHERE TitleId='" & TitleIdSent & "'")
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
                LoadTitleName()
                Exit Sub
            Else
                'insert TitleName
                executesql("INSERT INTO Titles(TitleName,Active) VALUES('" & TxtName.Text & "',1)")
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
                LoadTitleName()
            End If
        End If
    End Sub
    Private Sub DgName_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgName.CellClick
        TitleIdSent = DgName.CurrentRow.Cells(2).Value
        Dim TitleName As String = DgName.CurrentRow.Cells(1).Value
        TxtName.Text = TitleName
    End Sub
End Class