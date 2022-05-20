Public Class Frm_Critical
    Private Sub Accep_Button_Click(sender As Object, e As EventArgs) Handles Accep_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        add()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Sub add()
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
        Dim _cultureTHInfo As New Globalization.CultureInfo("th-TH")
        Dim RolesName As String = Frm_Employee.ComboBoxRole.Text
        'table = "Roles"
        'field = "RoleId"
        'where = "Rolename='" & RolesName & "'"
        'Dim CheckRolename As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim imageUser As String = Frm_Employee.ImageBase64String
        Dim CheckRolename As DataTable = executesql("Select RoleId from Roles where Rolename='" & RolesName & "'")
        If CheckRolename.Rows.Count = 0 Then
            Me.Show()
            Me.head_Label.Text = "กรุณาเลือกตำแหน่งให้ถูกต้อง"
            Me.TableOkCancel.Visible = False

            Exit Sub
        End If
        Dim birthDay As String
        birthDay = Frm_Employee.DateTimePicker_BirthDate.Value.ToString("yyyy-MM-dd", _cultureEnInfo)
        Dim workTime As String
        workTime = Frm_Employee.DateTimePicker_BirthDate.Value.ToString("yyyy-MM-dd", _cultureEnInfo)
        Dim DateNow As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        DateNow = Frm_Employee.DateTimePicker_BirthDate.Value.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo)
        Clipboard.SetText("INSERT INTO Users(FristName,LastName,NickName,BirthDay,Email,CardId,GenderId,NationalityId,Address,Phone,Phone2,Phone3,RoleId,WorkTypeId,WorkStartDate,Pay,PayTypeId,OverTimePay,OverTimePayTypeId,Diligence,DiligenceTypeId,BreakId,RegisterDate,Image,Active) VALUES('" & Frm_Employee.txtEmployeeFullName.Text & "','" & Frm_Employee.txtEmployeeLastName.Text & "','" & Frm_Employee.txtNickName.Text & "','" & Format(Frm_Employee.DateTimePicker_BirthDate.Value, "yyyy-MM-dd") & "','" & Frm_Employee.txtEmail.Text & "','" & Frm_Employee.txtCardID.Text & "','" & Frm_Employee.ComboBoxGenger.SelectedValue & "','" & Frm_Employee.ComboBoxNationality.SelectedValue & "','" & Frm_Employee.txtAddress.Text & "','" & Frm_Employee.txtPhone1.Text & "','" & Frm_Employee.txtPhone2.Text & "','" & Frm_Employee.txtPhone3.Text & "','" & Frm_Employee.ComboBoxRole.SelectedValue & "','" & Frm_Employee.ComboBoxWorkType.SelectedValue & "','" & Format(Frm_Employee.DateTimePicker_WorkStart.Value, "yyyy-MM-dd") & "','" & Frm_Employee.txtPay.Text & "','" & Frm_Employee.ComboBoxUnit.SelectedValue & "','" & Frm_Employee.txtOverTimePay.Text & "','" & Frm_Employee.ComboBoxUnit2.SelectedValue & "','" & Frm_Employee.txtDiligence.Text & "','" & Frm_Employee.ComboBoxUnit3.SelectedValue & "','" & Frm_Employee.ComboBoxBreak.SelectedValue & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & imageUser & "','1')")
        executesql("INSERT INTO Users(FristName,LastName,NickName,BirthDay,Email,CardId,GenderId,NationalityId,Address,Phone,Phone2,Phone3,RoleId,WorkTypeId,WorkStartDate,Pay,PayTypeId,OverTimePay,OverTimePayTypeId,Diligence,DiligenceTypeId,BreakId,RegisterDate,Image,Active) VALUES('" & Frm_Employee.txtEmployeeFullName.Text & "','" & Frm_Employee.txtEmployeeLastName.Text & "','" & Frm_Employee.txtNickName.Text & "','" & Format(Frm_Employee.DateTimePicker_BirthDate.Value, "yyyy-MM-dd") & "','" & Frm_Employee.txtEmail.Text & "','" & Frm_Employee.txtCardID.Text & "','" & Frm_Employee.ComboBoxGenger.SelectedValue & "','" & Frm_Employee.ComboBoxNationality.SelectedValue & "','" & Frm_Employee.txtAddress.Text & "','" & Frm_Employee.txtPhone1.Text & "','" & Frm_Employee.txtPhone2.Text & "','" & Frm_Employee.txtPhone3.Text & "','" & Frm_Employee.ComboBoxRole.SelectedValue & "','" & Frm_Employee.ComboBoxWorkType.SelectedValue & "','" & Format(Frm_Employee.DateTimePicker_WorkStart.Value, "yyyy-MM-dd") & "','" & Frm_Employee.txtPay.Text & "','" & Frm_Employee.ComboBoxUnit.SelectedValue & "','" & Frm_Employee.txtOverTimePay.Text & "','" & Frm_Employee.ComboBoxUnit2.SelectedValue & "','" & Frm_Employee.txtDiligence.Text & "','" & Frm_Employee.ComboBoxUnit3.SelectedValue & "','" & Frm_Employee.ComboBoxBreak.SelectedValue & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & imageUser & "','1')")

        Dim selectUserId As DataTable = executesql("SELECT UserId FROM Users ORDER BY UserId DESC")
        'Dim UserId = selectUserId(0)(0)
        Dim Chk As CheckBox
        Dim dayId As Integer = 0
        For Each Chk In Frm_Employee.ShowDayOfWeek.Controls
            If TypeOf (Chk) Is CheckBox Then
                If Chk.Checked Then
                    If Chk.Tag > dayId Then dayId = Chk.Tag

                    executesql("INSERT INTO DayOfWork(UserId,DayId,Active) VALUES('" & selectUserId(0)(0) & "','" & Chk.Name & "','1')")
                Else
                    If Chk.Tag > dayId Then dayId = Chk.Tag

                    executesql("INSERT INTO DayOfWork(UserId,DayId,Active) VALUES('" & selectUserId(0)(0) & "','" & Chk.Name & "','0')")
                End If
            End If
        Next
        Me.Show()
        Me.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Me.Panel1.BackColor = Color.ForestGreen
        Me.TableOkCancel.Visible = False

        Frm_Employee.clearText()
        Frm_Employee.loadUser()
    End Sub
End Class