Public Class CompanySetting
    Dim table As String
    Dim field As String
    Dim where As String
    Dim value As String
    Dim joint As String

    Private Sub CompanySetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataBranch()
        showEmailData()
    End Sub
    Sub Savebtn()
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim DataBranch As DataTable = executesql("Select BranchId From Branch Where Active=1")
        If DataBranch.Rows.Count = 0 Then
            executesql("Insert Into Branch(branchCode,BranchName,CompanyName,Active,Address,Address2,Provinces,ZipCode,TaxId,Telephone,Fax,BranchOrder,country,UpdateDate,InsertDate) VALUES('" & txtBranchCode.Text & "','" & txtBranchName.Text & "','" & txtCompanyName.Text & "',1,'" & txtAddress1.Text & "','" & txtAddress2.Text & "','" & txtProvice.Text & "','" & txtZipcode.Text & "','" & txtTaxId.Text & "','" & txtTelephone.Text & "','" & txtFax.Text & "',0,'','" & InsertDate & "','" & InsertDate & "')")
            executesql("Update Setting Set SettingValue='" & CheckBoxShowAdd.CheckState & "' where SettingId=7")
            MsgBox("บันทึกข้อมูลเรียบร้อบ", MsgBoxStyle.Information, "")
            LoadDataBranch()
        Else
            executesql("Update Branch Set BranchCode='" & txtBranchCode.Text & "',BranchName='" & txtBranchName.Text & "',CompanyName='" & txtCompanyName.Text & "',Address='" & txtAddress1.Text & "',Address2='" & txtAddress2.Text & "',Provinces='" & txtProvice.Text & "',ZipCode='" & txtZipcode.Text & "',TaxId='" & txtTaxId.Text & "',Telephone='" & txtTelephone.Text & "',Fax='" & txtFax.Text & "',UpdateDate='" & InsertDate & "' Where BranchId='" & DataBranch(0)("BranchId") & "'")
            executesql("Update Setting Set SettingValue='" & CheckBoxShowAdd.CheckState & "' Where SettingId=7")
            MsgBox("แก้ไขข้อมูลเรียบร้อบ", MsgBoxStyle.Information, "")
            LoadDataBranch()
        End If
    End Sub
    Sub LoadDataBranch()
        'table = "Branch"
        'field = "BranchCode,BranchName,CompanyName,Address,Address2,Provinces,ZipCode,TaxId,Telephone,Fax"
        'where = "Active=1"
        'Dim DataBranch As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataBranch As DataTable = executesql("Select BranchCode,BranchName,CompanyName,Address,Address2,Provinces,ZipCode,TaxId,Telephone,Fax From Branch Where Active=1")
        If DataBranch.Rows.Count = 0 Then
            Exit Sub
        Else
            txtBranchCode.Text = DataBranch(0)("BranchCode")
            txtBranchName.Text = DataBranch(0)("BranchName")
            txtCompanyName.Text = DataBranch(0)("CompanyName")
            txtAddress1.Text = DataBranch(0)("Address")
            txtAddress2.Text = DataBranch(0)("Address2")
            txtProvice.Text = DataBranch(0)("Provinces")
            txtZipcode.Text = DataBranch(0)("ZipCode")
            txtTaxId.Text = DataBranch(0)("TaxId")
            txtTelephone.Text = DataBranch(0)("Telephone")
            txtFax.Text = DataBranch(0)("Fax")
        End If
        'table = "Setting"
        'field = "SettingValue"
        'where = "SettingId=7"
        'Dim GetPrintOption As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & where & "")
        Dim GetPrintOption As DataTable = executesql("Select SettingValue From Setting Where SettingId=7")
        If GetPrintOption(0)("SettingValue") = 1 Then
            CheckBoxShowAdd.Checked = True
        Else CheckBoxShowAdd.Checked = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Savebtn()
    End Sub
    Private Sub btnAddEmail_Click(sender As Object, e As EventArgs) Handles btnAddEmail.Click
        Dim selectBranch As DataTable = executesql("SELECT BranchId,Emails FROM Branch WHERE Active=1")
        If IsNothing(selectBranch) Then
            Exit Sub
        End If
        If selectBranch.Rows.Count = 0 Then
            Exit Sub
        End If
        If selectBranch.Rows.Count > 0 Then
            If TxtAddEmail.Text = "" Then
                MsgBox("กรุณากรอก Email", MsgBoxStyle.Critical, "คำเตือน")
                TxtAddEmail.Focus()
                Exit Sub
            End If
            Dim Emails As String = ""
            If IsDBNull(selectBranch(0)("Emails")) Then
                Emails = TxtAddEmail.Text
            Else
                Emails = selectBranch(0)("Emails") & "," & TxtAddEmail.Text
            End If
            executesql("UPDATE Branch SET Emails='" & Emails & "' WHERE BranchId='" & selectBranch(0)("BranchId") & "'")
            showEmailData()
        End If
    End Sub
    Sub showEmailData()
        DataGridViewShowEmail.Rows.Clear()
        Dim selectBranch As DataTable = executesql("SELECT BranchId,Emails FROM Branch WHERE Active=1")
        If selectBranch.Rows.Count = 0 Then
            Exit Sub
        ElseIf IsDBNull(selectBranch(0)("Emails")) Then
            Exit Sub
        Else
            Dim Emails As String() = selectBranch(0)("Emails").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

            For i As Integer = 0 To Emails.Length - 1
                DataGridViewShowEmail.Rows.Add(Emails(i))
            Next
            TxtAddEmail.Text = ""
        End If
    End Sub
    Dim EmailName As String = ""
    Private Sub DataGridViewShowEmail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowEmail.CellClick
        EmailName = DataGridViewShowEmail.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If EmailName = "" Then
            MsgBox("กรุณาเลือก Email", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        Dim SelectEmail As DataTable = executesql("SELECT Emails FROM Branch WHERE Active=1")
        If IsDBNull(SelectEmail(0)("Emails")) Then
            Exit Sub
        End If
        If SelectEmail.Rows.Count = 0 Then
            Exit Sub
        End If
        If SelectEmail.Rows.Count > 0 Then
            Dim Emails As String() = SelectEmail(0)("Emails").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            Dim checkEmail As String
            If Emails.Length = 1 Then
                executesql("UPDATE Branch SET Emails=NULL")
                Exit Sub
            Else
                For i As Integer = 0 To Emails.Length - 1
                    If EmailName <> Emails(i) Then
                        If i = 0 Then
                            checkEmail += Emails(i)
                        Else
                            checkEmail += "," & Emails(i)
                        End If
                    End If
                Next
                executesql("UPDATE Branch SET Emails='" & checkEmail & "'")
            End If
            EmailName = ""
            TxtAddEmail.Text = ""
            showEmailData()
        End If
    End Sub

End Class