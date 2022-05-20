Public Class Frm_Nationality
    Dim nationalityId As Integer
    Private Sub Nationality_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Sub loadData()
        DataGridView_ShowNationality.Rows.Clear()
        'Dim selectNationaliy As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=NationalityID,NationalityNameTH,NationalityNameEN&table=Nationality&where=Active=1")
        Dim selectNationaliy As DataTable = executesql("Select NationalityID,NationalityNameTH,NationalityNameEN FROM Nationality WHERE Active='1'")
        For i As Integer = 0 To selectNationaliy.Rows.Count - 1
            DataGridView_ShowNationality.Rows.Add(selectNationaliy(i)("NationalityID"), selectNationaliy(i)("NationalityNameTH"), selectNationaliy(i)("NationalityNameEN"))
        Next
        Dim active = New Dictionary(Of String, String)()
        active("1") = "เปิด"
        active("0") = "ปิด"
        ComboBoxNationaliyActive.DataSource = New BindingSource(active, Nothing)
        ComboBoxNationaliyActive.DisplayMember = "Value"
        ComboBoxNationaliyActive.ValueMember = "Key"
        nationalityId = 0
    End Sub
    Sub clear()
        txtNationalityTH.Clear()
        txtNationalityEN.Clear()
    End Sub
    Private Sub btnAddNationality_Click(sender As Object, e As EventArgs) Handles btnAddNationality.Click
        If txtNationalityTH.Text = "" Or txtNationalityEN.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Dim checkNationality As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=NationalityID,NationalityNameTH&table=Nationality&where=NationalityNameTH='" & txtNationalityTH.Text & "' OR NationalityNameEN ='" & txtNationalityEN.Text & "'")
        Dim checkNationality As DataTable = executesql("SELECT NationalityID,NationalityNameTH FROM Nationality WHERE NationalityNameTH='" & txtNationalityTH.Text & "' OR NationalityNameEN ='" & txtNationalityEN.Text & "'")
        If nationalityId = 0 Then
            If checkNationality.Rows.Count > 0 Then
                MsgBox("มีชื่อสัญชาตินี้แล้ว", MsgBoxStyle.Critical)
                Exit Sub
            Else
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=NationalityNameTH,NationalityNameEN,Active&table=Nationality&value='" & txtNationalityTH.Text & "','" & txtNationalityEN.Text & "','1'")
                executesql("INSERT INTO Nationality(NationalityNameTH,NationalityNameEN,Active) VALUES('" & txtNationalityTH.Text & "','" & txtNationalityEN.Text & "','1')")
            End If
        Else
            Try
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Nationality&value=NationalityNameTH='" & txtNationalityTH.Text & "',NationalityNameEN='" & txtNationalityEN.Text & "',Active=" & ComboBoxNationaliyActive.SelectedValue & "&where=NationalityId='" & nationalityId & "'")
                executesql("UPDATE Nationality SET NationalityNameTH='" & txtNationalityTH.Text & "',NationalityNameEN='" & txtNationalityEN.Text & "',Active='" & ComboBoxNationaliyActive.SelectedValue & "' WHERE NationalityId='" & nationalityId & "'")
            Catch ex As Exception
                clear()
            End Try
        End If

        loadData()
        MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
        clear()
    End Sub
    Private Sub DataGridView_ShowNationality_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ShowNationality.CellClick
        Try
            nationalityId = DataGridView_ShowNationality.CurrentRow.Cells(0).Value
            'Dim showData As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=NationalityID,NationalityNameTH,NationalityNameEN,Active&table=Nationality&where=NationalityId='" & nationalityId & "'")
            Dim showData As DataTable = executesql("SELECT NationalityID,NationalityNameTH,NationalityNameEN,Active FROM Nationality WHERE NationalityId='" & nationalityId & "'")
            txtNationalityTH.Text = showData(0)("NationalityNameTH")
            txtNationalityEN.Text = showData(0)("NationalityNameEN")
        Catch ex As Exception
            nationalityId = 0
        End Try
    End Sub
    'Private Sub txtNationalityTH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNationalityTH.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 57 ' ตรงนี้คือโค๊ดตัวเลขน่ะครับเราตัดโค๊ด58-122ออกไปเพราะว่าโค๊ดดังกล่าวมันเป็นภาษาอังกฤษครับ
    '            e.Handled = False
    '        Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
    '            e.Handled = False
    '        Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
    '            e.Handled = False
    '        Case Else
    '            e.Handled = True
    '            MsgBox("กรอกได้เฉพาะภาษาไทย", MsgBoxStyle.Critical)
    '    End Select
    'End Sub
    'Private Sub txtNationalityEN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNationalityEN.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
    '            e.Handled = False
    '        Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
    '            e.Handled = False
    '        Case Else
    '            e.Handled = True
    '            MsgBox("กรอกได้เฉพาะภาษาอังกฤษ", MsgBoxStyle.Critical)
    '    End Select
    'End Sub
End Class