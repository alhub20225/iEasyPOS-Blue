Public Class Frm_ManageUsers
    Public Shared UserIdCellClick As Integer = 0
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim _cultureTHInfo As New Globalization.CultureInfo("th-TH")
    Sub LoadRoles()
        ComboRoles.Items.Clear()
        Combo_RoleSrc.Items.Clear()
        'Dim DataRoles As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleName&table=Roles&where=Active = 1")
        Dim DataRoles As DataTable = executesql("SELECT RoleName FROM Roles WHERE Active = 1")
        Dim CountRoles As Integer = DataRoles.Rows.Count
        For i As Integer = 0 To CountRoles - 1
            ComboRoles.Items.Add(DataRoles(i)(0))
            Combo_RoleSrc.Items.Add(DataRoles(i)(0))
        Next
    End Sub
    Sub LoadUsers()
        DG_Users.Rows.Clear()
        'Dim DataUsers As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UserId,FristName&table=Users&where=Active = 1")
        Dim DataUsers As DataTable = executesql("SELECT UserId,FristName FROM Users WHERE Active = 1")
        Dim CountUsers As Integer = DataUsers.Rows.Count
        For i As Integer = 0 To CountUsers - 1
            Dim UserId As Integer = DataUsers(i)("UserId")
            Dim UserName As String = DataUsers(i)("FristName")
            DG_Users.Rows.Add(UserId, UserName)
        Next
    End Sub
    Sub ClearText()
        txtName.Clear()
        txtPass.Clear()
        txtPassCon.Clear()
        txtsrc.Clear()
        txtUserName.Clear()
    End Sub
    Private Sub Frm_ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        LoadRoles()
        ModuleCheckRoles.CheckRolesUserAuthority()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If UserIdCellClick <> 0 Then
            'Update Data Users
            Dim Name As String = txtName.Text
            Dim UserName As String = txtUserName.Text
            Dim Pass As String = txtPass.Text
            Dim RoleName As String = ComboRoles.Text
            Dim UserEdit As Integer = Frm_Login.UserId
            If UserName = "" Or Pass = "" Or RoleName = "" Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            Else
                executesql("UPDATE Users SET FristName ='" & txtUserName.Text & "',Passwords ='" & txtPass.Text & "',UpdateDate ='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',RoleId =(select RoleId from Roles where Rolename ='" & RoleName & "'),EditUserId='" & Frm_Login.UserId & "' WHERE UserId= '" & UserIdCellClick & "' ")
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "")
            End If
            LoadUsers()
            ClearText()
            LoadRoles()
            UserIdCellClick = 0
            Exit Sub
        ElseIf UserIdCellClick = 0 Then
            Dim Name As String = txtName.Text
            Dim UserName As String = txtUserName.Text
            Dim Pass As String = txtPass.Text
            Dim PassConn As String = txtPassCon.Text
            Dim Roles As String = ComboRoles.Text
            Dim RegisDate As String = Now.Date.ToString("dd-MM-yyyy HH:mm:ss")
            Dim DateNow As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            DateNow = Now.Date.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo)
            Dim Active As Integer = 1
            Dim RolesId As Integer
            If Pass = "" Or Pass = "" Or PassConn = "" Or Roles = "" Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")
                Exit Sub
            End If
            If Pass <> PassConn Then
                MsgBox("การยืนยันรหัสผ่านไม่ตรงกัน", MsgBoxStyle.Critical, "")
                Exit Sub
            ElseIf Pass = PassConn Then
                'Select RolesId
                'Dim SlcRoleid As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleId&table=Roles&where=RoleName ='" & Roles & "'")
                Dim SlcRoleid As DataTable = executesql("SELECT RoleId FROM Roles WHERE RoleName ='" & Roles & "'")
                RolesId = SlcRoleid(0)("RoleId")
                'Insert users
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=FristName,Passwords,LastName,RegisterDate,Active,RoleId&table=Users&value='" & UserName & "','" & PassConn & "','" & Name & "','" & RegisDate & "','" & Active & "','" & RolesId & "'")
                executesql("INSERT INTO Users(FristName,Passwords,LastName,RegisterDate,Active,RoleId) VALUES('" & UserName & "','" & PassConn & "','" & Name & "','" & DateNow & "','" & Active & "','" & RolesId & "')")
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
                Frm_Critical.Panel1.BackColor = Color.ForestGreen
                Frm_Critical.TableOkCancel.Visible = False
                LoadUsers()
                LoadRoles()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        UserIdCellClick = 0
        ClearText()
    End Sub
    Private Sub btn_src_Click(sender As Object, e As EventArgs) Handles btn_src.Click
        Dim WordSearch As String = txtsrc.Text
        Dim RoleName As String = Combo_RoleSrc.Text
        If Combo_RoleSrc.Text <> "" Then
            'Dim RoleId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleId&table=Roles&where=RoleName ='" & RoleName & "'")
            Dim RoleId As DataTable = executesql("SELECT RoleId FROM Roles WHERE RoleName ='" & RoleName & "'")
            'Dim SearchUsers As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UserId,FristName&table=Users&where=FristName LIKE '%" & WordSearch & "%' AND RoleId='" & RoleId(0)("RoleId") & "' AND Active = 1")
            Dim SearchUsers As DataTable = executesql("SELECT UserId,FristName FROM Users WHERE FristName LIKE '%" & WordSearch & "%' AND RoleId='" & RoleId(0)("RoleId") & "' AND Active = 1")
            DG_Users.Rows.Clear()
            Dim CountSearchUsers As Integer = SearchUsers.Rows.Count
            For i As Integer = 0 To CountSearchUsers - 1
                DG_Users.Rows.Add(SearchUsers(i)("UserId"), SearchUsers(i)("FristName"))
            Next
        ElseIf Combo_RoleSrc.Text = "" Then

        End If
    End Sub
    Private Sub DG_Users_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Users.CellClick

        UserIdCellClick = DG_Users.CurrentRow.Cells(0).Value
        'Dim DataUsers As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=FristName,LastName,Passwords,RoleId&table=Users&where=UserId ='" & UserIdCellClick & "'")
        Dim DataUsers As DataTable = executesql("SELECT FristName,LastName,Passwords,RoleId FROM Users WHERE UserId ='" & UserIdCellClick & "'")
        Dim UserName As String = DataUsers(0)("FristName")
        Dim FullName As String = DataUsers(0)("LastName")
        Try
            Dim Pass As String = DataUsers(0)("Passwords")
            txtPass.Text = Pass
            txtPassCon.Text = Pass
        Catch ex As Exception
        End Try
        'Dim RoleName As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=RoleName&table=Roles&where=RoleId ='" & DataUsers(0)("RoleId") & "'")
        Dim RoleName As DataTable = executesql("SELECT RoleName FROM Roles WHERE RoleId ='" & DataUsers(0)("RoleId") & "'")
        txtName.Text = FullName
        txtUserName.Text = UserName
        ComboRoles.Text = RoleName(0)("RoleName")
    End Sub

    Private Sub Close_main_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub BtnDeleteUsers_Click(sender As Object, e As EventArgs) Handles BtnDeleteUsers.Click
        'Delete Users 
        Dim Answer As Integer = MsgBox("แน่ใจว่าต้องการลบข้อมูล?", MsgBoxStyle.YesNo, "")
        If Answer = vbYes Then
            Dim UsersId As String = DG_Users.CurrentRow.Cells(0).Value
            Dim DeleteTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            Dim DeleteUserId As Integer = Frm_Login.UserId
            If UsersId = "" Then
                MsgBox("กรุณาเลือกข้อมูลก่อน", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            'Update Table Users
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Users&value=Active=0,Deletedate='" & DeleteTime & "',DeleteUserId='" & DeleteUserId & "'&where=UserId='" & UsersId & "' AND Active=1")
            executesql("UPDATE Users SET Active=0,Deletedate='" & DeleteTime & "',EditUserId='" & DeleteUserId & "' WHERE UserId='" & UsersId & "' AND Active=1")
            LoadUsers()
            txtUserName.Text = ""
            txtPass.Text = ""
            txtPassCon.Text = ""
        ElseIf Answer = vbNo Then
        End If
    End Sub
End Class