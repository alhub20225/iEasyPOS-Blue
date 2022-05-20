Module ModuleCheckRoles

    Sub CheckRolesUserAuthority()
        'Dim Userid As Integer = Frm_Login.UserId
        'Dim RoleId As Integer = 0
        'Dim DataRoleId As DataTable = executesql("SELECT RoleId FROM Users WHERE UserId='" & Userid & "'")
        'If IsNothing(DataRoleId) Then
        '    Exit Sub
        'ElseIf DataRoleId.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'RoleId = DataRoleId(0)("RoleId")
        'Dim DataAuthorityRole As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' ORDER BY AuthorityId ASC")
        'If IsNothing(DataAuthorityRole) Then
        '    Exit Sub
        'ElseIf DataAuthorityRole.Rows.Count = 0 Then
        '    Exit Sub
        'End If
        'For i As Integer = 0 To DataAuthorityRole.Rows.Count - 1
        '    Dim AuthorityId As Integer = DataAuthorityRole(i)("AuthorityId")
        '    If AuthorityId = 1 Then 'ตั้งค่าสินค้า
        '        Main.BtnShowFrmItem.Visible = True
        '        Main.BtnFrmCategoryShow.Visible = True
        '        Main.BtnFrmMaterialShow.Visible = True
        '        Main.BtnShowFrmInventory.Visible = True
        '    ElseIf AuthorityId = 2 Then 'ตั้งค่าพนักงาน
        '        'Setting.Button8.Visible = True
        '        'Setting.Button2.Visible = True
        '        'Setting.Button1.Visible = True
        '    ElseIf AuthorityId = 3 Then 'จัดการสมาชิก
        '        Main.BtnFrmManageCustomerShow.Visible = True
        '    ElseIf AuthorityId = 4 Then 'จัดการวัตถุดิบ
        '        Main.BtnFrmMaterialShow.Visible = True
        '    ElseIf AuthorityId = 5 Then 'ดูรายงานย้อนหลัง
        '        Main.BtnShowFrmReport.Visible = True
        '    ElseIf AuthorityId = 6 Then 'ตั้งค่าระบบ
        '        Main.BtnSettigProgram.Visible = True
        '    ElseIf AuthorityId = 7 Then ' ตั้งค่าโปรโมชั่น

        '    ElseIf AuthorityId = 8 Then 'ผังร้าน
        '    ElseIf AuthorityId = 9 Then 'Order
        '    ElseIf AuthorityId = 10 Then 'ชำระเงิน
        '        Main.BtnShowFrmPos.Visible = True
        '        Main.BtnFrmRePrintBill.Visible = True
        '        'Main.BtnShowFrmTable.Enabled = True
        '    End If
        'Next
        'BtnShowFrmItem ตั้งค่าสินค้า
        'BtnFrmCategoryShow ตั้งค่าหมวดหมู่
        'BtnShowFrmInventory คลังสินค้า
        'BtnFrmMaterialShow ตั้งค่าวัตถุดิบ
        'BtnFrmManageCustomerShow ตั้งค่าสมาชิก
        'BtnFrmRePrintBill ดูบิลย้อนหลัง
        'BtnShowFrmReport รายงานการขาย
        'BtnSettigProgram ตั้งค่าระบบ
    End Sub
    Public dtRolesUser As New RolesUser
    Sub CheckRolesUserMain2()

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
        'Main2.BtnCloseShift.Visible = False
        Frm_OpenShift.BtnCancel.Visible = False
        If IsNothing(DataAuthorityRole) Then
            Exit Sub
        ElseIf DataAuthorityRole.Rows.Count = 0 Then

            Frm_Login.Show()
            Frm_Login.panel_number.Visible = False
            Frm_Login.PanelUsers.Visible = True
            Frm_Login.txt_password.Text = ""
            Frm_Login.LabelUser.Text = ""
            Frm_Login.UserId = 0
            Main2.TabControlMain.Visible = False

        End If

        For i As Integer = 0 To DataAuthorityRole.Rows.Count - 1
            Dim AuthorityId As Integer = DataAuthorityRole(i)("AuthorityId")
            If AuthorityId = 1 Then 'ตั้งค่าสินค้า
                'สินค้า 
                Main2.XtraTabPage4.PageVisible = True
                Main2.XtraTabPage5.PageVisible = True
                Main2.XtraTabPage6.PageVisible = True
                dtRolesUser.settingItem = True
            ElseIf AuthorityId = 2 Then 'ตั้งค่าพนักงาน
                'ตั้งค่าผู้ใช้งาน 
                Setting.Button1.Visible = True
                Setting.Line1.Visible = True

                'ตั้งค่าพนักงาน 
                Setting.Button8.Visible = True
                Setting.Line8.Visible = True

                Setting.XtraTabMain.SelectedTabPageIndex = 9
                Setting.Button5.Image = iEasyPOS.My.Resources.Resources.Icon_SetSystemGray
                Setting.Button5.ForeColor = Color.FromArgb(65, 73, 86)
                Setting.Button3.Image = iEasyPOS.My.Resources.Resources.Icon_SetDefinitionGray
                Setting.Button3.ForeColor = Color.FromArgb(65, 73, 86)
                Setting.Button2.Image = iEasyPOS.My.Resources.Resources.Icon_SetStockBlue
                Setting.Button2.ForeColor = Color.FromArgb(45, 149, 239)

                Frm_RolesManage.TopLevel = False
                Frm_RolesManage.FormBorderStyle = FormBorderStyle.None
                Frm_RolesManage.WindowState = FormWindowState.Maximized
                Frm_RolesManage.Dock = DockStyle.Fill
                Setting.XtraTabPage10.Controls.Add(Frm_RolesManage)
                Frm_RolesManage.Show()
                dtRolesUser.userSetting = True
            ElseIf AuthorityId = 3 Then 'จัดการสมาชิก
                'สมาชิก 
                Main2.XtraTabPage9.PageVisible = True
                dtRolesUser.member = True
            ElseIf AuthorityId = 4 Then 'จัดการวัตถุดิบ
                'วัตถุดิบ 
                Main2.XtraTabPage7.PageVisible = True
                dtRolesUser.material = True
            ElseIf AuthorityId = 5 Then 'ดูรายงานย้อนหลัง
                'รายงาน 
                Main2.XtraTabPage8.PageVisible = True
                dtRolesUser.report = True
            ElseIf AuthorityId = 6 Then 'ตั้งค่าระบบ
                'ตั้งค่า
                Main2.XtraTabPage11.PageVisible = True

            ElseIf AuthorityId = 7 Then ' ตั้งค่าโปรโมชั่น
                'โปรโมชั่น
                Main2.XtraTabPage12.PageVisible = False
                dtRolesUser.promotion = True
            ElseIf AuthorityId = 8 Then 'ยกเลิกบิล
                'MsgBox("AuthorityId = 8")
                'Frm_RecallBill.btnDeleteSale.Visible = True
                'Frm_RecallBill.Label5.Visible = True
                'Frm_RecallBill.Label6.Visible = True
                'Frm_RecallBill.BtnVoid.Visible = True
                POS.BtnDelSale.Visible = True
                POS.DataGridViewPOS.Columns(13).Visible = True
                'dtRolesUser.cancleSale = True
            ElseIf AuthorityId = 9 Then 'Order
                'POS.BtnSaveOrder.Visible = True
                'POS.BtnOpenSaveSale.Visible = True
            ElseIf AuthorityId = 10 Then 'ชำระเงิน
                POS.BtnPayMent.Visible = True
                dtRolesUser.payment = True
            ElseIf AuthorityId = 11 Then 'ปิดกะ
                Frm_OpenShift.BtnCancel.Visible = True
                Main2.BtnCloseShift.Visible = True
            End If
        Next
    End Sub

    '    Public Function RoleCancleSale(UserID As Integer) As Boolean
    '        Dim dtRole As DataTable = executesql("SELECT  AuthorityRoles.AuthorityId FROM AuthorityRoles INNER JOIN Users ON AuthorityRoles.RoleId = Users.RoleId
    'WHERE  AuthorityRoles.AuthorityId = 8 AND Active_role = 1 AND users.UserId=" & UserID & "")
    '        Dim IsRole As Boolean
    '        If dtRole.Rows.Count > 0 Then
    '            IsRole = True
    '            Console.WriteLine(" IsRole = True")
    '        Else
    '            IsRole = False
    '            Console.WriteLine(" IsRole = False")
    '        End If
    '        Return IsRole
    '    End Function
End Module
