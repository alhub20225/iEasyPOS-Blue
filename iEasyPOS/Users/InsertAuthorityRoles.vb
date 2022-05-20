Module InsertAuthorityRoles
    Sub InsertAuthorityRoles()
        'Dim RoleId As Integer = Frm_RolesManage.RolesIdSent
        'Dim CountCheckRole As Integer = Frm_RolesManage.ChkRoles.Items.Count
        'For i As Integer = 0 To CountCheckRole - 1
        '    Dim AuthorityName As String = Frm_RolesManage.ChkRoles.Items(i).ToString
        '    Dim AuthorityId As DataTable = executesql("SELECT AuthorityId FROM Authority WHERE AuthorityNameTH='" & AuthorityName & "'")
        '    If Frm_RolesManage.ChkRoles.GetItemChecked(i) = True Then
        '        Dim CheckAuthorityRoles As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' AND AuthorityId='" & AuthorityId(0)("AuthorityId") & "'")
        '        If CheckAuthorityRoles.Rows.Count = 0 Then
        '            executesql("INSERT INTO AuthorityRoles(RoleId,AuthorityId) VALUES('" & RoleId & "','" & AuthorityId(0)("AuthorityId") & "')")
        '        ElseIf CheckAuthorityRoles.Rows.Count > 0 Then
        '        End If
        '    ElseIf Frm_RolesManage.ChkRoles.GetItemChecked(i) = False Then
        '        Dim UncheckAuthorityRoles As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' AND AuthorityId='" & AuthorityId(0)("AuthorityId") & "'")
        '        If UncheckAuthorityRoles.Rows.Count > 0 Then
        '            executesql("DELETE FROM AuthorityRoles WHERE RoleId='" & RoleId & "' AND AuthorityId='" & AuthorityId(0)("AuthorityId") & "'")
        '        ElseIf UncheckAuthorityRoles.Rows.Count = 0 Then
        '        End If
        '    End If
        'Next
        'ModuleCheckRoles.CheckRolesUserAuthority()
        'Frm_Critical.Show()
        'Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
        'Frm_Critical.Panel1.BackColor = Color.ForestGreen
        'Frm_Critical.TableOkCancel.Visible = False
        'Frm_RolesManage.LoadDataRoles()
        ''Frm_RolesManage.LoadAuthority()
    End Sub
End Module
