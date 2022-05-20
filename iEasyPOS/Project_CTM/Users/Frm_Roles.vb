Public Class Frm_Roles
    Dim RoleId As Integer
    Private Sub Frm_Role_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Sub loadData()
        DataGridView_ShowRole.Rows.Clear()
        Dim selectNationaliy As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleId,RoleName,RoleNameEN&table=Roles&where=Active=1")
        'Dim selectNationaliy As DataTable = executesql("Select RoleId,RoleName,RoleNameEN FROM Roles WHERE Active='1'")
        If IsDBNull(selectNationaliy) Then
            Exit Sub
        Else
            For i As Integer = 0 To selectNationaliy.Rows.Count - 1
                DataGridView_ShowRole.Rows.Add(selectNationaliy(i)("RoleId"), selectNationaliy(i)("RoleName"), selectNationaliy(i)("RoleNameEN"))
            Next
            Dim active = New Dictionary(Of String, String)()
            active("1") = "เปิด"
            active("0") = "ปิด"
            ComboBoxRoleActive.DataSource = New BindingSource(active, Nothing)
            ComboBoxRoleActive.DisplayMember = "Value"
            ComboBoxRoleActive.ValueMember = "Key"
            RoleId = 0
        End If
    End Sub
    Sub clear()
        txtRoleNameTH.Clear()
        txtRoleNameEN.Clear()

    End Sub
    Private Sub DataGridView_ShowRole_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ShowRole.CellClick
        Try
            RoleId = DataGridView_ShowRole.CurrentRow.Cells(0).Value
            Dim showData As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleId,RoleName,RoleNameEN&table=Roles&where=RoleId='" & RoleId & "' AND Active=1")
            'Dim showData As DataTable = executesql("SELECT RoleId,RoleName,RoleNameEN FROM Roles WHERE RoleId='" & RoleId & "' AND Active='1'")
            txtRoleNameTH.Text = showData(0)("RoleName")
            txtRoleNameEN.Text = showData(0)("RoleNameEN")
        Catch ex As Exception
            RoleId = 0
            clear()
        End Try

    End Sub

    Private Sub btnAddRole_Click(sender As Object, e As EventArgs) Handles btnAddRole.Click
        If txtRoleNameTH.Text = "" Or txtRoleNameEN.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            If RoleId = 0 Then
                Dim checkRole As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleName,RoleNameEN&table=Roles&where=RoleName='" & txtRoleNameTH.Text & "'")
                'Dim checkRole As DataTable = executesql("SELECT RoleName,RoleNameEN FROM Roles WHERE RoleName='" & txtRoleNameTH.Text & "'")
                If checkRole.Rows.Count > 0 Then
                    MsgBox("มีตำแหน่งนี้แล้วในระบบ", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=RoleName,RoleNameEN,Active&table=Roles&value='" & txtRoleNameTH.Text & "','" & txtRoleNameEN.Text & "','1'")
                    'executesql("INSERT INTO Roles(RoleName,RoleNameEN,Active) VALUES('" & txtRoleNameTH.Text & "','" & txtRoleNameEN.Text & "','1')")
                End If
            Else
                ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Roles&value=RoleName='" & txtRoleNameTH.Text & "', RoleNameEN='" & txtRoleNameEN.Text & "',Active=" & ComboBoxRoleActive.SelectedValue & "&where=RoleId = '" & RoleId & "'")
                'executesql("UPDATE Roles SET RoleName='" & txtRoleNameTH.Text & "', RoleNameEN='" & txtRoleNameEN.Text & "',Active='" & ComboBoxRoleActive.SelectedValue & "' WHERE RoleId = '" & RoleId & "'")
            End If
        Catch ex As Exception

        End Try
        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
        clear()
        loadData()
    End Sub
    Private Sub txtRoleNameTH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoleNameTH.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' ตรงนี้คือโค๊ดตัวเลขน่ะครับเราตัดโค๊ด58-122ออกไปเพราะว่าโค๊ดดังกล่าวมันเป็นภาษาอังกฤษครับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรอกได้เฉพาะภาษาไทย", MsgBoxStyle.Critical)
        End Select
    End Sub
    Private Sub txtRoleNameEN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoleNameEN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรอกได้เฉพาะภาษาอังกฤษ", MsgBoxStyle.Critical)
        End Select
    End Sub
End Class