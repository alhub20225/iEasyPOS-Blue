Public Class Setting

    Dim BckColor As System.Drawing.Color
    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        writeLog("User ID " + Frm_Login.UserId.ToString + " Open setting")
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        'ปุ่มตัวเลือก ตั้งค่าทั่วไป
        PictureBox3.Image = iEasyPOS.My.Resources.Resources.Icon_SettingBlue
        PictureBox3.ForeColor = Color.FromArgb(45, 149, 239)
        PictureBox4.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemGray
        PictureBox4.ForeColor = Color.FromArgb(65, 73, 86)
        XtraTabMain.SelectedTabPageIndex = 0
        Panel5.Visible = True
        Panel3.Visible = False
        'PageManagementBrand.Text = "ตั้งค่าทั่วไป"
        'ตั้งค่าผู้ใช้งาน
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersBlue
        Button1.ForeColor = Color.FromArgb(45, 149, 239)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)
        Frm_ManageUsers.TopLevel = False
        Frm_ManageUsers.FormBorderStyle = FormBorderStyle.None
        Frm_ManageUsers.WindowState = FormWindowState.Maximized
        Frm_ManageUsers.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Frm_ManageUsers)
        Frm_ManageUsers.Show()

        'Frm_ManageUsers.TopLevel = False
        'SplitContainer1.Panel2.Controls.Add(Frm_ManageUsers)
        'Frm_ManageUsers.Show()

        'If My.Settings.PosType = 1 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(239, Byte), Integer))
        'ElseIf My.Settings.PosType = 0 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        'End If
        'Me.BackColor = BckColor
        'RadScrollablePanel1.BackColor = BckColor
        'RadScrollablePanel1.PanelContainer.BackColor = BckColor
        'Button1.BackColor = BckColor
        'Button2.BackColor = BckColor
        'Button3.BackColor = BckColor
        'Button5.BackColor = BckColor
        'Button6.BackColor = BckColor
        'Button7.BackColor = BckColor
        'Button8.BackColor = BckColor
        'Button9.BackColor = BckColor
        'Button10.BackColor = BckColor
        'Button11.BackColor = BckColor
        Button8.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'ปุ่มตัวเลือก ตั้งค่าทั่วไป
        PictureBox3.Image = iEasyPOS.My.Resources.Resources.Icon_SettingBlue
        PictureBox3.ForeColor = Color.FromArgb(45, 149, 239)
        PictureBox4.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemGray
        PictureBox4.ForeColor = Color.FromArgb(65, 73, 86)

        XtraTabMain.SelectedTabPageIndex = 0
        'ตั้งค่าผู้ใช้งาน
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersBlue
        Button1.ForeColor = Color.FromArgb(45, 149, 239)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        Panel5.Visible = True
        Panel3.Visible = False
        'PageManagementBrand.Text = "ตั้งค่าทั่วไป"

        Frm_ManageUsers.TopLevel = False
        Frm_ManageUsers.FormBorderStyle = FormBorderStyle.None
        Frm_ManageUsers.WindowState = FormWindowState.Maximized
        Frm_ManageUsers.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Frm_ManageUsers)
        Frm_ManageUsers.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'ปุ่มตัวเลือก ตั้งค่าระบบ
        PictureBox3.Image = iEasyPOS.My.Resources.Resources.Icon_SettingGray
        PictureBox3.ForeColor = Color.FromArgb(65, 73, 86)
        PictureBox4.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemBlue
        PictureBox4.ForeColor = Color.FromArgb(45, 149, 239)

        Dim Userid As Integer = Frm_Login.UserId
        Dim RoleId As Integer = 0
        Dim DataRoleId As DataTable = executesql("SELECT RoleId FROM Users WHERE UserId='" & Userid & "'")
        If IsNothing(DataRoleId) Then
            Exit Sub
        ElseIf DataRoleId.Rows.Count = 0 Then
            Exit Sub
        End If
        RoleId = DataRoleId(0)("RoleId")
        Dim DataAuthorityRole As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' and Active_role= 1 ORDER BY AuthorityId ASC")
        For i As Integer = 0 To DataAuthorityRole.Rows.Count - 1
            Dim AuthorityId As Integer = DataAuthorityRole(i)("AuthorityId")
            If AuthorityId = 2 Then
                XtraTabMain.SelectedTabPageIndex = 9
                Button5.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemGray
                Button5.ForeColor = Color.FromArgb(65, 73, 86)
                Button3.Image = iEasyPOS.My.Resources.Resources.Icon_SetDefinitionGray
                Button3.ForeColor = Color.FromArgb(65, 73, 86)
                Button2.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockBlue
                Button2.ForeColor = Color.FromArgb(45, 149, 239)

                Frm_RolesManage.TopLevel = False
                Frm_RolesManage.FormBorderStyle = FormBorderStyle.None
                Frm_RolesManage.WindowState = FormWindowState.Maximized
                Frm_RolesManage.Dock = DockStyle.Fill
                XtraTabPage10.Controls.Add(Frm_RolesManage)
                Frm_RolesManage.Show()
            Else
                XtraTabMain.SelectedTabPageIndex = 7
                'ตั้งค่าระบบ
                Button5.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemBlue
                Button5.ForeColor = Color.FromArgb(45, 149, 239)
                Button3.Image = iEasyPOS.My.Resources.Resources.Icon_SetDefinitionGray
                Button3.ForeColor = Color.FromArgb(65, 73, 86)
                Button2.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
                Button2.ForeColor = Color.FromArgb(65, 73, 86)

                SystemSetting.TopLevel = False
                SystemSetting.FormBorderStyle = FormBorderStyle.None
                SystemSetting.WindowState = FormWindowState.Maximized
                SystemSetting.Dock = DockStyle.Fill
                XtraTabPage8.Controls.Add(SystemSetting)
                SystemSetting.Show()
            End If
        Next
        Panel5.Visible = False
        Panel3.Visible = True
        'PageManagementBrand.Text = "ตั้งค่าระบบ"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'ตั้งค่าผู้ใช้งาน
        XtraTabMain.SelectedTabPageIndex = 0
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersBlue
        Button1.ForeColor = Color.FromArgb(45, 149, 239)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        Frm_ManageUsers.TopLevel = False
        Frm_ManageUsers.FormBorderStyle = FormBorderStyle.None
        Frm_ManageUsers.WindowState = FormWindowState.Maximized
        Frm_ManageUsers.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Frm_ManageUsers)
        Frm_ManageUsers.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'ตั้งค่าสาขา
        XtraTabMain.SelectedTabPageIndex = 1
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersGray
        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchBlue
        Button6.ForeColor = Color.FromArgb(45, 149, 239)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        CompanySetting.TopLevel = False
        CompanySetting.FormBorderStyle = FormBorderStyle.None
        CompanySetting.WindowState = FormWindowState.Maximized
        CompanySetting.Dock = DockStyle.Fill
        XtraTabPage2.Controls.Add(CompanySetting)
        CompanySetting.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'ตั้งค่าสต๊อค
        XtraTabMain.SelectedTabPageIndex = 2
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersGray
        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockBlue
        Button9.ForeColor = Color.FromArgb(45, 149, 239)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        FrmManageStock.TopLevel = False
        FrmManageStock.FormBorderStyle = FormBorderStyle.None
        FrmManageStock.WindowState = FormWindowState.Maximized
        FrmManageStock.Dock = DockStyle.Fill
        XtraTabPage3.Controls.Add(FrmManageStock)
        FrmManageStock.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'ตั้งค่าหน่วย
        XtraTabMain.SelectedTabPageIndex = 3
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersGray
        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitBlue
        Button10.ForeColor = Color.FromArgb(45, 149, 239)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        FrmUnit.TopLevel = False
        FrmUnit.FormBorderStyle = FormBorderStyle.None
        FrmUnit.WindowState = FormWindowState.Maximized
        FrmUnit.Dock = DockStyle.Fill
        XtraTabPage4.Controls.Add(FrmUnit)
        FrmUnit.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'พนักงาน
        XtraTabMain.SelectedTabPageIndex = 4
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersGray
        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffBlue
        Button8.ForeColor = Color.FromArgb(45, 149, 239)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        Frm_Employee.TopLevel = False
        Frm_Employee.FormBorderStyle = FormBorderStyle.None
        Frm_Employee.WindowState = FormWindowState.Maximized
        Frm_Employee.Dock = DockStyle.Fill
        XtraTabPage5.Controls.Add(Frm_Employee)
        Frm_Employee.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'ผู้จัดจำหน่าย
        XtraTabMain.SelectedTabPageIndex = 5
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersGray
        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserBlue
        Button11.ForeColor = Color.FromArgb(45, 149, 239)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherGray
        Button7.ForeColor = Color.FromArgb(65, 73, 86)

        FrmManageSupplier.TopLevel = False
        FrmManageSupplier.FormBorderStyle = FormBorderStyle.None
        FrmManageSupplier.WindowState = FormWindowState.Maximized
        FrmManageSupplier.Dock = DockStyle.Fill
        XtraTabPage6.Controls.Add(FrmManageSupplier)
        FrmManageSupplier.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'อื่นๆ
        XtraTabMain.SelectedTabPageIndex = 6
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_UsersGray
        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_SetBranchGray
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button9.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button9.ForeColor = Color.FromArgb(65, 73, 86)
        Button10.Image = iEasyPOS.My.Resources.Resources.Icon_SetUnitGray
        Button10.ForeColor = Color.FromArgb(65, 73, 86)
        Button8.Image = iEasyPOS.My.Resources.Resources.Icon_SetStaffGray
        Button8.ForeColor = Color.FromArgb(65, 73, 86)
        Button11.Image = iEasyPOS.My.Resources.Resources.Icons_SetUserGray
        Button11.ForeColor = Color.FromArgb(65, 73, 86)
        Button7.Image = iEasyPOS.My.Resources.Resources.Icon_SetOtherBlue
        Button7.ForeColor = Color.FromArgb(45, 149, 239)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'ตั้งค่าระบบ
        XtraTabMain.SelectedTabPageIndex = 7
        Button5.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemBlue
        Button5.ForeColor = Color.FromArgb(45, 149, 239)
        Button3.Image = iEasyPOS.My.Resources.Resources.Icon_SetDefinitionGray
        Button3.ForeColor = Color.FromArgb(65, 73, 86)
        Button2.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button2.ForeColor = Color.FromArgb(65, 73, 86)

        SystemSetting.TopLevel = False
        SystemSetting.FormBorderStyle = FormBorderStyle.None
        SystemSetting.WindowState = FormWindowState.Maximized
        SystemSetting.Dock = DockStyle.Fill
        XtraTabPage8.Controls.Add(SystemSetting)
        SystemSetting.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'คำจำกัดความระบบ
        XtraTabMain.SelectedTabPageIndex = 8
        Button5.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemGray
        Button5.ForeColor = Color.FromArgb(65, 73, 86)
        Button3.Image = iEasyPOS.My.Resources.Resources.Icon_SetDefinitionBlue
        Button3.ForeColor = Color.FromArgb(45, 149, 239)
        Button2.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockGray
        Button2.ForeColor = Color.FromArgb(65, 73, 86)

        Difin_setting.TopLevel = False
        Difin_setting.FormBorderStyle = FormBorderStyle.None
        Difin_setting.WindowState = FormWindowState.Maximized
        Difin_setting.Dock = DockStyle.Fill
        XtraTabPage9.Controls.Add(Difin_setting)
        Difin_setting.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ตั้งค่าสิทธิ์การใช้งาน
        XtraTabMain.SelectedTabPageIndex = 9
        Button5.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemGray
        Button5.ForeColor = Color.FromArgb(65, 73, 86)
        Button3.Image = iEasyPOS.My.Resources.Resources.Icon_SetDefinitionGray
        Button3.ForeColor = Color.FromArgb(65, 73, 86)
        Button2.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockBlue
        Button2.ForeColor = Color.FromArgb(45, 149, 239)

        Frm_RolesManage.TopLevel = False
        Frm_RolesManage.FormBorderStyle = FormBorderStyle.None
        Frm_RolesManage.WindowState = FormWindowState.Maximized
        Frm_RolesManage.Dock = DockStyle.Fill
        XtraTabPage10.Controls.Add(Frm_RolesManage)
        Frm_RolesManage.Show()
    End Sub


    'Private Sub Close_pos_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    '    Main.Close()
    '    Main.Show()
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Frm_ManageUsers.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(Frm_ManageUsers)
    '    Frm_ManageUsers.Show()
    '    Frm_RolesManage.Close()
    '    Difin_setting.Close()
    '    FrmUnit.Close()
    '    FrmManageStock.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    '    CompanySetting.Close()
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Frm_RolesManage.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(Frm_RolesManage)
    '    Frm_RolesManage.Show()
    '    Frm_ManageUsers.Close()
    '    Difin_setting.Close()
    '    FrmUnit.Close()
    '    FrmManageStock.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    '    CompanySetting.Close()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Difin_setting.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(Difin_setting)
    '    Difin_setting.Show()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmUnit.Close()
    '    FrmManageStock.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    '    CompanySetting.Close()
    'End Sub


    'Private Sub Button8_Click(sender As Object, e As EventArgs)
    '    Frm_Employee.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(Frm_Employee)
    '    Frm_Employee.Show()
    '    Difin_setting.Close()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmUnit.Close()
    '    FrmManageStock.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    '    CompanySetting.Close()
    'End Sub

    'Private Sub Button9_Click(sender As Object, e As EventArgs)
    '    FrmManageStock.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(FrmManageStock)
    '    FrmUnit.TopLevel = False
    '    Frm_Employee.Close()
    '    Difin_setting.Close()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmManageStock.Show()
    '    FrmUnit.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    '    CompanySetting.Close()
    'End Sub

    'Private Sub Button10_Click(sender As Object, e As EventArgs)
    '    FrmUnit.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(FrmUnit)
    '    Frm_Employee.Close()
    '    Difin_setting.Close()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmManageStock.Close()
    '    FrmUnit.Show()
    '    Frm_Employee.Close()
    '    CompanySetting.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    'End Sub

    'Private Sub Button11_Click(sender As Object, e As EventArgs)
    '    FrmManageSupplier.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(FrmManageSupplier)
    '    Frm_Employee.Close()
    '    Difin_setting.Close()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmManageStock.Close()
    '    FrmUnit.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Show()
    '    CompanySetting.Close()
    '    SystemSetting.Close()
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '    SystemSetting.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(SystemSetting)
    '    Frm_Employee.Close()
    '    Difin_setting.Close()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmManageStock.Close()
    '    FrmUnit.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Close()
    '    CompanySetting.Close()
    '    SystemSetting.Show()
    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs)
    '    CompanySetting.TopLevel = False
    '    SplitContainer1.Panel2.Controls.Add(CompanySetting)
    '    Frm_Employee.Close()
    '    Difin_setting.Close()
    '    Frm_ManageUsers.Close()
    '    Frm_RolesManage.Close()
    '    FrmManageStock.Close()
    '    FrmUnit.Close()
    '    Frm_Employee.Close()
    '    FrmManageSupplier.Close()
    '    SystemSetting.Close()
    '    CompanySetting.Show()
    'End Sub
    Sub change_to_th_text()
        PictureBox3.Text = My.Resources.setting_th.setting
        PictureBox4.Text = My.Resources.setting_th.system
        Button1.Text = My.Resources.setting_th.user
        Button6.Text = My.Resources.setting_th.branch
        Button9.Text = My.Resources.setting_th.stock
        Button10.Text = My.Resources.setting_th.unit
        Button8.Text = My.Resources.setting_th.employee
        Button11.Text = My.Resources.setting_th.seller
        Button2.Text = My.Resources.setting_th.privilege
        Button5.Text = My.Resources.setting_th.system
    End Sub
    Sub change_to_eng_text()
        PictureBox3.Text = My.Resources.setting_en.setting
        PictureBox4.Text = My.Resources.setting_en.system
        Button1.Text = My.Resources.setting_en.user
        Button6.Text = My.Resources.setting_en.branch
        Button9.Text = My.Resources.setting_en.stock
        Button10.Text = My.Resources.setting_en.unit
        Button8.Text = My.Resources.setting_en.employee
        Button11.Text = My.Resources.setting_en.seller
        Button2.Text = My.Resources.setting_en.privilege
        Button5.Text = My.Resources.setting_en.system

        Button1.Width = 80
        Button6.Width = 100
        Button9.Width = 80
        Button10.Width = 80
        'Button8.Width = 100
        Button11.Width = 80
        Button2.Width = 100
    End Sub
End Class