Public Class CheckRoles
    Dim Userid As Integer = Frm_Login.UserId
    Dim RoleId As Integer = 0
    Public Function ClassCheckRolesAuthority()
        Dim DataRoleId As DataTable = executesql("SELECT RoleId FROM Users WHERE UserId='" & Userid & "'")
        If IsNothing(DataRoleId) Then
            Return True
            Exit Function
        ElseIf DataRoleId.Rows.Count = 0 Then
            Return True
            Exit Function
        End If
        RoleId = DataRoleId(0)("RoleId")
        Dim DataAuthorityRole As DataTable = executesql("SELECT RoleId,AuthorityId FROM AuthorityRoles WHERE RoleId='" & RoleId & "' ORDER BY AuthorityId ASC")
        If IsNothing(DataAuthorityRole) Then
            Return True
            Exit Function
        ElseIf DataAuthorityRole.Rows.Count = 0 Then
            Return True
            Exit Function
        End If
        For i As Integer = 0 To DataAuthorityRole.Rows.Count - 1
            Select Case DataAuthorityRole(0)("AuthorityId")
                Case "1" 'ตั้งค่าสินค้า
                    Main.BtnShowFrmItem.Visible = True
                Case "2" 'ตั้งค่าพนักงาน
                    Setting.Button8.Visible = True
                Case "3" 'จัดการสมาชิก
                    Main.BtnFrmManageCustomerShow.Visible = True
                Case "4" 'จัดการวัตถุดิบ
                    Main.BtnFrmMaterialShow.Visible = True
                Case "5" 'ดูรายงานย้อยหลัง
                    Main.BtnShowFrmReport.Visible = True
                Case "6" 'ตั้งค่าระบบ
                    Main.BtnSettigProgram.Visible = True
                Case "7" 'ตั้งค่าการขาย

                Case "8" 'ผังร้าน

                Case "9" 'order
                    Main.BtnShowFrmPos.Visible = True
                Case "10" 'ชำระเงิน
                    Main.BtnShowFrmPos.Visible = True
            End Select
        Next
        'BtnShowFrmItem ตั้งค่าสินค้า
        'BtnFrmCategoryShow ตั้งค่าหมวดหมู่
        'BtnShowFrmInventory คลังสินค้า
        'BtnFrmMaterialShow ตั้งค่าวัตถุดิบ
        'BtnFrmManageCustomerShow ตั้งค่าสมาชิก
        'BtnFrmRePrintBill ดูบิลย้อนหลัง
        'BtnShowFrmReport รายงานการขาย
        'BtnSettigProgram ตั้งค่าระบบ
    End Function
End Class
