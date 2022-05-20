Module SelectRoleCheckbox
    Sub SelectRoles()
        'Dim ChkBoxListCount As Integer = Frm_RolesManage.ChkRoles.Items.Count
        'For Clear As Integer = 0 To ChkBoxListCount - 1
        '    Frm_RolesManage.ChkRoles.SetItemChecked(Clear, False)
        'Next
        'Dim RoleName As String = Frm_RolesManage.DgRoles.CurrentRow.Cells(1).Value
        'Frm_RolesManage.TxtRolesName.Text = RoleName
        'Dim RolesId As Integer = Frm_RolesManage.RolesIdSent
        'Dim AuthorityRoles As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RolesId & "' ORDER BY AuthorityId ASC")
        'Dim AuthorityName As String = ""
        'Dim AuthorityRolesName As DataTable
        'For i As Integer = 0 To ChkBoxListCount - 1
        '    AuthorityName = Frm_RolesManage.ChkRoles.Items(i).ToString
        '    For j As Integer = 0 To AuthorityRoles.Rows.Count - 1
        '        AuthorityRolesName = executesql("SELECT AuthorityNameTH FROM Authority WHERE AuthorityId='" & AuthorityRoles(j)("AuthorityId") & "'")
        '        If AuthorityName = AuthorityRolesName(0)("AuthorityNameTH") Then
        '            Frm_RolesManage.ChkRoles.SetItemChecked(i, True)
        '        Else

        '        End If
        '    Next
        'Next
        'Dim ItemCount As Integer = Frm_RolesManage.ChkRoles.Items.Count
        'MsgBox(ItemCount)
        'Next
        'Dim AuthorityName As String = Frm_RolesManage.ChkRoles.Items(i).ToString
        'Dim AuthId As String = AuthorityRoles(i)("AuthorityId")
        'Dim AuthName As DataTable = executesql("SELECT AuthorityNameTH FROM Authority WHERE AuthorityId='" & AuthId & "'")
        'If AuthorityName = AuthName(0)("AuthorityNameTH") Then
        '    Frm_RolesManage.ChkRoles.SetItemChecked(i, True)
        'End If
    End Sub
End Module
