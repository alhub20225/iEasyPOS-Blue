Public Class Frm_RolesManage
    Public RolesIdSent As Integer
    'Load Data Roles 
    Sub LoadDataRoles()
        DgRoles.Rows.Clear()
        'Dim DataRoles As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleId,RoleName,RoleNameEN&table=Roles&where=Active=1")
        Dim DataRoles As DataTable = executesql("SELECT RoleId,RoleName FROM Roles WHERE Active = 1")
        Dim CountRoles As Integer = DataRoles.Rows.Count
        For i As Integer = 0 To CountRoles - 1
            DgRoles.Rows.Add(DataRoles(i)("RoleId"), DataRoles(i)("RoleName"))
        Next
    End Sub
    Sub LoadAuthority()
        'ChkRoles.Items.Clear()
        'Dim DataAuthurity As DataTable = executesql("SELECT AuthorityNameTH FROM Authority")
        'For i As Integer = 0 To DataAuthurity.Rows.Count - 1
        '    Dim AuthorityName As String = DataAuthurity(i)("AuthorityNameTH")
        '    ChkRoles.Items.Add(AuthorityName)
        'Next
    End Sub
    ' Load Data Roles Details 
    Sub LoadDataRolesDetail(ByVal a As Integer)
        LoadAuthority()
        Dim RolesId As Integer = a
        RolesIdSent = RolesId
        SelectRoleCheckbox.SelectRoles()
    End Sub
    Sub ClearData()
        DgRoles.Rows.Clear()
        LoadDataRoles()
        TxtRolesName.Clear()
    End Sub
    Private Sub Frm_RolesManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleCheckRoles.CheckRolesUserAuthority()
        LoadAuthority()
        LoadDataRoles()
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

        Dim CheckRoles As DataTable = executesql("SELECT RoleName FROM Roles WHERE RoleName ='" & RolesName & "' AND Active =1")
        If CheckRoles.Rows.Count > 0 Then
            InsertAuthorityRoles.InsertAuthority()
            Exit Sub
        Else

            executesql("INSERT INTO Roles(RoleName,Active) VALUES('" & RolesName & "',1)")
            ClearData()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ClearData()
    End Sub
    Private Sub BtnActive_Click(sender As Object, e As EventArgs) Handles BtnActive.Click
        'BtnDelete
        Dim RoleId As Integer = DgRoles.CurrentRow.Cells(0).Value
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "ต้องการลบข้อมูลหรือไม่"
        Frm_Critical.TableOkCancel.Visible = True
        Frm_Critical.Accep_Button.Visible = False
        If Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK Then
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Roles&value=Active = 0&where=RoleId = '" & RoleId & "'")
            executesql("UPDATE Roles SET Active = 0 WHERE RoleId = '" & RoleId & "'")
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=DELETE&table=AuthorityRoles&where=RoleId='" & RoleId & "'")
            executesql("DELETE FROM AuthorityRoles WHERE RoleId='" & RoleId & "'")
            LoadDataRoles()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ลบข้อมูลเรียบร้อย"
            Frm_Critical.TableOkCancel.Visible = False
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Exit Sub
        ElseIf Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
    Private Sub DgRoles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgRoles.CellClick
        Dim roleid As Integer = DgRoles.CurrentRow.Cells(0).Value
        LoadDataRolesDetail(roleid)
    End Sub

    Private Sub Close_main_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
        If ChkAll.Checked = True Then
            For i As Integer = 0 To ChkRoles.Items.Count - 1
                ChkRoles.SetItemChecked(i, True)
            Next
        ElseIf ChkAll.Checked = False Then
            For i As Integer = 0 To ChkRoles.Items.Count - 1
                ChkRoles.SetItemChecked(i, False)
            Next
        End If
    End Sub


End Class