Public Class Frm_RolesManage
    'Public RolesIdSent As Integer
    Dim RoleId As Integer = 0
    'Load Data Roles 
    Private Sub Frm_RolesManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        Panel5.Width = Me.Width / 2
        DgRoles.RowTemplate.Height = 35
        DgAuthorityRoles.RowTemplate.Height = 35
        'ModuleCheckRoles.CheckRolesUserAuthority()
        'LoadAuthority()
        LoadDataRoles()
    End Sub
    Sub LoadDataRoles()
        DgRoles.Rows.Clear()

        Dim DataRoles As DataTable = executesql("SELECT RoleId,RoleName FROM Roles WHERE Active = 1")
        Dim CountRoles As Integer = DataRoles.Rows.Count
        For i As Integer = 0 To CountRoles - 1
            DgRoles.Rows.Add(DataRoles(i)("RoleId"), DataRoles(i)("RoleName"))
        Next
    End Sub
    Sub LoadAuthority(ByVal roleID As Integer)
        DgAuthorityRoles.Rows.Clear()
        Dim DataAuthurity As DataTable = executesql("SELECT Authority.AuthorityNameTH, AuthorityRoles.Active_role,AuthorityRoles.AuthorityRolesId FROM Authority INNER JOIN AuthorityRoles ON Authority.AuthorityId = AuthorityRoles.AuthorityId INNER JOIN Roles ON AuthorityRoles.RoleId = Roles.RoleId  where Roles.RoleId =" & roleID & "")
        For i As Integer = 0 To DataAuthurity.Rows.Count - 1
            Dim Active As Boolean = True
            If DataAuthurity(i)("Active_role") = 0 Then Active = False
            DgAuthorityRoles.Rows.Add(Active, DataAuthurity(i)("AuthorityNameTH"), DataAuthurity(i)("AuthorityRolesId"))
        Next
        TxtRolesName.Text = DgRoles.CurrentRow.Cells(1).Value
    End Sub
    ' Load Data Roles Details 
    Sub LoadDataRolesDetail(ByVal RolesId As Integer)
        LoadAuthority(RolesId)
        'RolesIdSent = RolesId
        'SelectRoleCheckbox.SelectRoles()
    End Sub
    Sub ClearData()
        DgRoles.Rows.Clear()
        LoadDataRoles()
        TxtRolesName.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Insert Roles
        Dim RolesName As String = TxtRolesName.Text
        If RolesName = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If

        Dim CheckRoles As DataTable = executesql("SELECT RoleName,RoleId FROM Roles WHERE RoleId =" & RoleId & "")
        If CheckRoles.Rows.Count > 0 Then
            executesql("update Roles set RoleName='" & RolesName & "' where RoleId =" & RoleId & "")
            '
            Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
                Frm_Critical.Panel1.BackColor = Color.ForestGreen
                Frm_Critical.TableOkCancel.Visible = False
                LoadDataRoles()
            Else

                executesql("INSERT INTO Roles(RoleName,Active) VALUES('" & RolesName & "',1)")

            Dim DtRole As DataTable = executesql("select max(RoleId) as id from Roles where Active=1")
            Dim dtAut As DataTable = executesql("select AuthorityId from Authority")
            For i As Integer = 0 To dtAut.Rows.Count - 1
                executesql("insert into AuthorityRoles(RoleId,AuthorityId,Active_role) values(" & DtRole(0)("id") & "," & dtAut(i)("AuthorityId") & ",1)")
            Next

            ClearData()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
            LoadDataRoles()
        End If
    End Sub
    Private Sub BtnActive_Click(sender As Object, e As EventArgs) Handles BtnActive.Click
        'BtnDelete
        Dim RoleId As Integer = DgRoles.CurrentRow.Cells(0).Value
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "ต้องการลบข้อมูลหรือไม่"
        Frm_Critical.TableOkCancel.Visible = True
        Frm_Critical.Accep_Button.Visible = False
        If Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK Then
            executesql("UPDATE Roles SET Active = 0 WHERE RoleId = '" & RoleId & "'")

            LoadDataRoles()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ลบข้อมูลเรียบร้อย"
            Frm_Critical.TableOkCancel.Visible = False
            Frm_Critical.Panel1.BackColor = Color.ForestGreen

        ElseIf Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
    Private Sub DgRoles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgRoles.CellClick
        RoleId = DgRoles.CurrentRow.Cells(0).Value
        LoadDataRolesDetail(RoleId)
    End Sub

    Private Sub Close_main_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    'Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
    '    If ChkAll.Checked = True Then
    '        For i As Integer = 0 To DgAuthorityRoles.Rows.Count - 1
    '            DgAuthorityRoles.Rows(i).Cells(0).Value = -1
    '        Next
    '    ElseIf ChkAll.Checked = False Then
    '        For i As Integer = 0 To DgAuthorityRoles.Rows.Count - 1
    '            DgAuthorityRoles.Rows(i).Cells(0).Value = 0
    '        Next
    '    End If
    'End Sub

    Private Sub BtnUpdateRoleAut_Click(sender As Object, e As EventArgs) Handles BtnUpdateRoleAut.Click
        If RoleId = 0 Then Exit Sub
        Dim active As Integer = 0
        For i As Integer = 0 To DgAuthorityRoles.Rows.Count - 1
            If DgAuthorityRoles.Rows(i).Cells(0).Value = 0 Then
                active = 0
            ElseIf DgAuthorityRoles.Rows(i).Cells(0).Value = -1 Then
                active = 1
            End If
            executesql("update AuthorityRoles set Active_role=" & active & " where AuthorityRolesId=" & DgAuthorityRoles.Rows(i).Cells(2).Value & "")
        Next

        LoadAuthority(RoleId)
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
    End Sub

    Private Sub ChkAll_Click(sender As Object, e As EventArgs) Handles ChkAll2.Click
        If ChkAll.Checked = True Then
            ChkAll.Checked = False
            For i As Integer = 0 To DgAuthorityRoles.Rows.Count - 1
                DgAuthorityRoles.Rows(i).Cells(0).Value = 0
            Next
        ElseIf ChkAll.Checked = False Then
            ChkAll.Checked = True
            For i As Integer = 0 To DgAuthorityRoles.Rows.Count - 1
                DgAuthorityRoles.Rows(i).Cells(0).Value = -1
            Next
        End If
    End Sub

    Sub change_to_th_text()
        Label2.Text = My.Resources.privilege_th.role
        Label3.Text = My.Resources.privilege_th.role
        ChkAll.Text = My.Resources.privilege_th.selectAll
        ChkAll2.Text = My.Resources.privilege_th.selectAll
        BtnUpdateRoleAut.Text = My.Resources.privilege_th.save
        BtnActive.Text = My.Resources.privilege_th.del

        DgRoles.Columns(1).HeaderText = My.Resources.privilege_th.role
        DgAuthorityRoles.Columns(0).HeaderText = My.Resources.privilege_th._select
        DgAuthorityRoles.Columns(1).HeaderText = My.Resources.privilege_th.role

    End Sub
    Sub change_to_eng_text()
        Label2.Text = My.Resources.privilege_en.role
        Label3.Text = My.Resources.privilege_en.role
        ChkAll.Text = My.Resources.privilege_en.selectAll
        ChkAll2.Text = My.Resources.privilege_en.selectAll
        BtnUpdateRoleAut.Text = My.Resources.privilege_en.save
        BtnActive.Text = My.Resources.privilege_en.del

        DgRoles.Columns(1).HeaderText = My.Resources.privilege_en.role
        DgAuthorityRoles.Columns(0).HeaderText = My.Resources.privilege_en._select
        DgAuthorityRoles.Columns(1).HeaderText = My.Resources.privilege_en.role
    End Sub
End Class