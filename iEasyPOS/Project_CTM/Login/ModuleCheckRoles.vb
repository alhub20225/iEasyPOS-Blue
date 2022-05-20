Module ModuleCheckRoles

    Sub CheckRolesUserAuthority()
        Dim Userid As Integer = Frm_Login.UserId
        Dim RoleId As Integer = 0
        Dim DataRoleId As DataTable = executesql("SELECT RoleId FROM Users WHERE UserId='" & Userid & "'")
        If IsNothing(DataRoleId) Then
            Exit Sub
        ElseIf DataRoleId.Rows.Count = 0 Then
            Exit Sub
        End If
        RoleId = DataRoleId(0)("RoleId")
        Dim DataAuthorityRole As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' ORDER BY AuthorityId ASC")
        If IsNothing(DataAuthorityRole) Then
            Exit Sub
        ElseIf DataAuthorityRole.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DataAuthorityRole.Rows.Count - 1
            Dim AuthorityId As Integer = DataAuthorityRole(i)("AuthorityId")
            If AuthorityId = 1 Then 'ตั้งค่าสินค้า
                Main.BtnShowFrmItem.Visible = True
                Main.BtnFrmCategoryShow.Visible = True
                Main.BtnFrmMaterialShow.Visible = True
                Main.BtnShowFrmInventory.Visible = True
            ElseIf AuthorityId = 2 Then 'ตั้งค่าพนักงาน
                'Setting.Button8.Visible = True
                'Setting.Button2.Visible = True
                'Setting.Button1.Visible = True
            ElseIf AuthorityId = 3 Then 'จัดการสมาชิก
                Main.BtnFrmManageCustomerShow.Visible = True
            ElseIf AuthorityId = 4 Then 'จัดการวัตถุดิบ
                Main.BtnFrmMaterialShow.Visible = True
            ElseIf AuthorityId = 5 Then 'ดูรายงานย้อนหลัง
                Main.BtnShowFrmReport.Visible = True
            ElseIf AuthorityId = 6 Then 'ตั้งค่าระบบ
                Main.BtnSettigProgram.Visible = True
            ElseIf AuthorityId = 7 Then ' ตั้งค่าโปรโมชั่น

            ElseIf AuthorityId = 8 Then 'ผังร้าน
            ElseIf AuthorityId = 9 Then 'Order
            ElseIf AuthorityId = 10 Then 'ชำระเงิน
                Main.BtnShowFrmPos.Visible = True
                Main.BtnFrmRePrintBill.Visible = True
                'Main.BtnShowFrmTable.Enabled = True
            End If
        Next
        'BtnShowFrmItem ตั้งค่าสินค้า
        'BtnFrmCategoryShow ตั้งค่าหมวดหมู่
        'BtnShowFrmInventory คลังสินค้า
        'BtnFrmMaterialShow ตั้งค่าวัตถุดิบ
        'BtnFrmManageCustomerShow ตั้งค่าสมาชิก
        'BtnFrmRePrintBill ดูบิลย้อนหลัง
        'BtnShowFrmReport รายงานการขาย
        'BtnSettigProgram ตั้งค่าระบบ
    End Sub

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
        Dim DataAuthorityRole As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' ORDER BY AuthorityId ASC")
        If IsNothing(DataAuthorityRole) Then
            Exit Sub
        ElseIf DataAuthorityRole.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DataAuthorityRole.Rows.Count - 1
            Dim AuthorityId As Integer = DataAuthorityRole(i)("AuthorityId")
            If AuthorityId = 1 Then 'ตั้งค่าสินค้า
                Main2.XtraTabPage4.PageVisible = True
                Main2.XtraTabPage5.PageVisible = True
                Main2.XtraTabPage6.PageVisible = True
                Main2.XtraTabPage7.PageVisible = True
            ElseIf AuthorityId = 2 Then 'ตั้งค่าพนักงาน

            ElseIf AuthorityId = 3 Then 'จัดการสมาชิก
                Main2.XtraTabPage9.PageVisible = True
            ElseIf AuthorityId = 4 Then 'จัดการวัตถุดิบ
                Main2.XtraTabPage7.PageVisible = True
            ElseIf AuthorityId = 5 Then 'ดูรายงานย้อนหลัง
                Main2.XtraTabPage8.PageVisible = True
            ElseIf AuthorityId = 6 Then 'ตั้งค่าระบบ
                Main2.XtraTabPage11.PageVisible = True
            ElseIf AuthorityId = 7 Then ' ตั้งค่าโปรโมชั่น
                Main2.XtraTabPage12.PageVisible = True
            ElseIf AuthorityId = 8 Then 'ผังร้าน
            ElseIf AuthorityId = 9 Then 'Order
            ElseIf AuthorityId = 10 Then 'ชำระเงิน

            End If
        Next

    End Sub
End Module
