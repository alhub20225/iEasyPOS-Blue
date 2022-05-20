Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class CompanySetting
    Dim table As String
    Dim field As String
    Dim where As String
    Dim value As String
    Dim joint As String
    Dim connMySql As MySqlConnection
    Private Sub CompanySetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        writeLog("User ID " + Frm_Login.UserId.ToString + " Open Branch setting")
        DataGridViewShowEmail.RowTemplate.Height = 35
        LoadDataBranch()
        showEmailData()

        txtServerName.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_server", Nothing)
        txtServerUser.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_username", Nothing)
        txtServerPass.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_password", Nothing)
        txtDatabase.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_database", Nothing)

        CheckBoxHqConnect.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_Connect", Nothing)

        If CheckBoxHqConnect.CheckState = False Then
            'GroupBoxServer.Visible = False
            Panel19.Visible = False
            Panel33.Visible = False
            txtBranchName.ReadOnly = False
            Me.Refresh()
        Else
            'GroupBoxServer.Visible = True
            Panel19.Visible = True
            Panel33.Visible = True
            txtBranchName.ReadOnly = True
            Me.Refresh()
        End If
    End Sub
    Sub Savebtn()
        writeLog("User ID " + Frm_Login.UserId.ToString + " Open Branch setting save")
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim DataBranch As DataTable = executesql("Select BranchId From Branch Where Active=1")
        Dim branchCode As String = txtBranchCode.Text
        Dim branchName As String = txtBranchName.Text
        Dim companyName As String = txtCompanyName.Text
        'If branchName = "" Then
        '    MsgBox("โปรดระบุชื่อสาขา", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        'If branchCode = "" Then
        '    MsgBox("โปรดระบุเลขที่สาขา", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        'If companyName = "" Then
        '    MsgBox("โปรดระบุชื่อบริษัท", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If DataBranch.Rows.Count = 0 Then
            executesql("Insert Into Branch(branchCode,BranchName,CompanyName,Active,Address,Address2,Provinces,ZipCode,TaxId,Telephone,Fax,BranchOrder,country,UpdateDate,InsertDate) VALUES('" & branchCode & "','" & branchName & "','" & companyName & "',1,'" & txtAddress1.Text & "','" & txtAddress2.Text & "','" & txtProvice.Text & "','" & txtZipcode.Text & "','" & txtTaxId.Text & "','" & txtTelephone.Text & "','" & txtFax.Text & "',0,'','" & InsertDate & "','" & InsertDate & "')")
            executesql("Update Setting Set SettingValue='" & CheckBoxShowAdd.CheckState & "' where SettingId=7")
            'insert stock name
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
        'If IsNothing(selectBranch) Then
        '    Exit Sub
        'End If
        If selectBranch.Rows.Count = 0 Then
            MsgBox("กรุณาเพิ่มข้อมูลสาขาก่อน", MsgBoxStyle.Critical, "คำเตือน")
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

    Private Sub BtnTestServer2_Click(sender As Object, e As EventArgs) Handles BtnTestServer.Click
        'Dim SqlConn As New SqlConnection
        'Dim SqlConnStr As String = "user id='" & txtServerUser.Text & "';data source='" & txtServerName.Text & "'; persist security info=True;initial catalog='" & txtDatabase.Text & "';password='" & txtServerPass.Text & "'"
        'Clipboard.SetText(SqlConnStr)
        'If SqlConn.State = ConnectionState.Closed Then
        '    SqlConn.ConnectionString = SqlConnStr
        '    Try
        '        SqlConn.Open()
        '        MessageBox.Show("Succsessfull DB Connnection", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        BtnSaveServer.Enabled = True
        '    Catch ex As Exception
        '        MsgBox("Conection Error", MsgBoxStyle.Critical)
        '        BtnSaveServer.Enabled = False
        '    End Try
        'End If
        connMySql = New MySqlConnection()
        connMySql.ConnectionString = "server=" & txtServerName.Text & ";user id=" & txtServerUser.Text & ";password=" & txtServerPass.Text & ";database=" & txtDatabase.Text & ""
        Try
            connMySql.Open()
            MessageBox.Show("Succsessfull DB Connnection", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connMySql.Close()
        Catch ex As Exception
            MsgBox("Conection Error", MsgBoxStyle.Critical)
            BtnSaveServer.Enabled = False
        End Try
        connMySql.Dispose()
    End Sub

    Private Sub BtnSaveServer2_Click(sender As Object, e As EventArgs) Handles BtnSaveServer.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_server", txtServerName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_username", txtServerUser.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_password", txtServerPass.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_database", txtDatabase.Text)

        MsgBox("Save Server")

        'Dim DtBranch As DataTable = Hqexecutesql("select BranchName from Branch where Active=1")
        'ComboBranch.DataSource = DtBranch
        'ComboBranch.DisplayMember = "BranchName"

        'Dim DtBranch As DataTable = Hqexecutesql("select BranchName from Branch where Active=1")
        'If DtBranch.Rows.Count > 0 Then
        '    For i As Integer = 0 To DtBranch.Rows.Count - 1
        '        Dim BranchDt As String = DtBranch(i)("BranchName")
        '        ComboBranch.Properties.Items.Add(BranchDt)
        '    Next
        'Else
        '    Dim localBranch As DataTable = executesql("select BranchName,Address from Branch where Active=1")
        '    Hqexecutesql("INSERT INTO Branch(BranchName,Address1,Active) VALUES('" & localBranch(0)("BranchName") & "','" & localBranch(0)("Address") & "','1')")
        'End If
        setBranch()


        BtnSaveCliBranch.Enabled = True
    End Sub

    Sub setBranch()
        Dim DtBranch As DataTable = Hqexecutesql("select BranchName from Branch where Active=1")
        If DtBranch.Rows.Count > 0 Then
            For i As Integer = 0 To DtBranch.Rows.Count - 1
                Dim BranchDt As String = DtBranch(i)("BranchName")
                ComboBranch.Properties.Items.Add(BranchDt)
            Next
        Else
            Dim localBranch As DataTable = executesql("select BranchName,Address from Branch where Active=1")
            If localBranch.Rows.Count > 0 Then
                Dim hqBranch As DataTable = Hqexecutesql("select BranchName from Branch where Active=1 and BranchName='" & localBranch(0)("BranchName") & "'")
                If hqBranch.Rows.Count = 0 Then
                    Hqexecutesql("INSERT INTO Branch(BranchName,Active) VALUES('" & localBranch(0)("BranchName") & "','1')")
                End If
                setBranch()
            Else
                'Return True
            End If

        End If
    End Sub


    Private Sub BtnSaveCliBranch2_Click(sender As Object, e As EventArgs) Handles BtnSaveCliBranch.Click
        Dim DtBranch As DataTable = Hqexecutesql("select BranchId from Branch where BranchName='" & ComboBranch.Text & "' and Active=1")
        executesql("update Branch set HqBranchId =" & DtBranch(0)("BranchId") & ",BranchName='" & ComboBranch.Text & "'")

        MsgBox("Save Branch Setting")

        BtnSync.Enabled = True
        BtnSyncSale.Enabled = True
    End Sub

    Private Sub BtnSync2_Click(sender As Object, e As EventArgs) Handles BtnSync.Click
        SyncItem()
    End Sub

    Private Sub CheckBoxHqConnect2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHqConnect.CheckedChanged
        If CheckBoxHqConnect.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_Connect", True)
            'GroupBoxServer.Visible = True
            'Panel29.Visible = True
            Panel19.Visible = True
            Panel33.Visible = True
            txtBranchName.ReadOnly = True
            Me.Refresh()
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_Connect", False)
            'GroupBoxServer.Visible = False
            'Panel29.Visible = False
            Panel19.Visible = False
            Panel33.Visible = False
            txtBranchName.ReadOnly = False
            Me.Refresh()
        End If
    End Sub

    Private Sub BtnSyncSale2_Click(sender As Object, e As EventArgs) Handles BtnSyncSale.Click
        SyncSale()
        'SyncSaleItem()
    End Sub

    Sub change_to_th_text()
        Button2.Text = My.Resources.branch_th.Del
        Label16.Text = My.Resources.branch_th.Branch
        Label14.Text = My.Resources.branch_th.BranchName
        Label6.Text = My.Resources.branch_th.BranchCode
        Label11.Text = My.Resources.branch_th.TaxID
        Label1.Text = My.Resources.branch_th.Address1
        Label4.Text = My.Resources.branch_th.Address2
        Label8.Text = My.Resources.branch_th.CompanyName
        Label9.Text = My.Resources.branch_th.Provin
        Label7.Text = My.Resources.branch_th.ZipCode
        Label10.Text = My.Resources.branch_th.PhoneNumber
        Label12.Text = My.Resources.branch_th.Fax
        Label15.Text = My.Resources.branch_th.More
        Label21.Text = My.Resources.branch_th.AddressOnReceipt
        Button1.Text = My.Resources.branch_th.Save
    End Sub

    Sub change_to_eng_text()
        Button2.Text = My.Resources.branch_en.Del
        Label16.Text = My.Resources.branch_en.Branch
        Label14.Text = My.Resources.branch_en.BranchName
        Label6.Text = My.Resources.branch_en.BranchCode
        Label11.Text = My.Resources.branch_en.TaxID
        Label1.Text = My.Resources.branch_en.Address1
        Label4.Text = My.Resources.branch_en.Address2
        Label8.Text = My.Resources.branch_en.CompanyName
        Label9.Text = My.Resources.branch_en.Provin
        Label7.Text = My.Resources.branch_en.ZipCode
        Label10.Text = My.Resources.branch_en.PhoneNumber
        Label12.Text = My.Resources.branch_en.Fax
        Label15.Text = My.Resources.branch_en.More
        Label21.Text = My.Resources.branch_en.AddressOnReceipt
        Button1.Text = My.Resources.branch_en.Save
    End Sub
End Class