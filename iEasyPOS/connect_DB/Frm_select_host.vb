Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Configuration.ConfigurationManager
Public Class Frm_select_host
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        If txt_servername.Text = "" Then
            MsgBox("กรุณากรอกชื่อ Server", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_database.Text = "" Then
            MsgBox("กรุณากรอกชื่อฐานข้อมูล", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If TxtUserName.Text = "" Then
            MsgBox("กรุณากรอกชื่อผู้ใช้งาน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If TxtPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน", MsgBoxStyle.Critical)
            Exit Sub
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "server", txt_servername.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "username", TxtUserName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "password", TxtPassword.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "database", txt_database.Text)
        Dim SqlConn As New SqlConnection
        Dim SqlConnStr As String = "user id='" & TxtUserName.Text & "';data source='" & txt_servername.Text & "'; persist security info=True;initial catalog='" & txt_database.Text & "';password='" & TxtPassword.Text & "'"
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = SqlConnStr
            Try
                SqlConn.Open()
                MessageBox.Show("Succsessfull DB Connnection", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnUpdateDB.Enabled = True
            Catch ex As Exception
                MsgBox("Conection Error", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim server As String = txt_servername.Text
        Dim DB As String = txt_database.Text
        If server = "" Or DB = "" Or TxtUserName.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบก่อน บันทึก", MsgBoxStyle.Critical)
            Exit Sub
        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "server", server)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "username", TxtUserName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "password", TxtPassword.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "database", DB)

        Dim ConnectionDB As String = "Data Source='" & server & "';Initial Catalog='" & DB & "';Persist Security Info=True;User ID='" & TxtUserName.Text & "';Password='" & TxtPassword.Text & "'"

        'My.Settings.ConnectionDB = ConnectionDB
        'My.Settings.Save()
        'Try
        '    Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        '    config.ConnectionStrings.ConnectionStrings("Project_CTM.My.MySettings.ConnectionDB").ConnectionString = ConnectionDB
        '    config.Save(ConfigurationSaveMode.Modified)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        save_complete.Show()
        loading.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        loading.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCreateDataBase2.Show()
        Me.Close()
    End Sub

    Private Sub BtnUpdateDB_Click(sender As Object, e As EventArgs) Handles BtnUpdateDB.Click
        'Rename FirstName in Users
        executesql("IF COL_LENGTH('[Users]','FirstName') IS NOT NULL
        select * from Users
        BEGIN
        EXEC sp_rename 'Users.FristName', 'FirstName', 'COLUMN';
        END")

        executesql("ALTER TABLE WithdrawMoney ALTER COLUMN InsertDate datetime")

        executesql("
                    DECLARE @@HasRow int
                    DECLARE @@table_name sysname
                    DECLARE @@column_name sysname

                    SET @@table_name = 'Branch'
                    SET @@column_name = 'HqBranchId'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name))
                    FROM     syscolumns c, sysobjects o
                    Where   c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN
                        ALTER table Branch Add HqBranchId int NOT NULL DEFAULT(0)
                    END")


        executesql("DECLARE @@HasRow int
                    DECLARE @@table_name sysname
                    DECLARE @@column_name sysname

                    SET @@table_name = 'Sale'
                    SET @@column_name = 'HqSync'
                    SET @@HasRow = ( SELECT   COUNT(convert(sysname, c.name))
                    FROM     syscolumns c, sysobjects o
                    Where   c.id = o.id
                    AND convert(sysname, o.name) = @@table_name
                    AND convert(sysname, c.name) = @@column_name)
                    if ( @@HasRow = 0 )
                    BEGIN
                        ALTER table Sale Add HqSync int NOT NULL DEFAULT(0)
                    END")

        executesql("truncate table AuthorityRoles

                    SET IDENTITY_INSERT [dbo].[AuthorityRoles] ON 


                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (1, 1, 1, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (2, 1, 2, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (3, 1, 3, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (4, 1, 4, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (5, 1, 5, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (6, 1, 6, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (7, 1, 7, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (8, 1, 8, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (9, 1, 9, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (10, 1, 10, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (11, 2, 1, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (12, 2, 2, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (13, 2, 3, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (14, 2, 4, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (15, 2, 5, 1)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (16, 2, 6, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (17, 2, 7, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (18, 2, 8, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (19, 2, 9, 0)

                    INSERT [dbo].[AuthorityRoles] ([AuthorityRolesId], [RoleId], [AuthorityId], [Active_role]) VALUES (20, 2, 10, 1)
                    SET IDENTITY_INSERT [dbo].[AuthorityRoles] OFF")

        executesql("ALTER TABLE Recive ALTER COLUMN ReciveId nvarchar(100)")
        executesql("ALTER TABLE Take ALTER COLUMN TakeId nvarchar(100)")

        executesql("ALTER TABLE ReciveItem ALTER COLUMN ReciveId nvarchar(100)")
        executesql("ALTER TABLE TakeItem ALTER COLUMN TakeId nvarchar(100)")

        MsgBox("Update Database complete")
    End Sub

    Private Sub btnUpdateFile_Click(sender As Object, e As EventArgs) Handles btnUpdateFile.Click
        Try

            Dim procStartInfo As New ProcessStartInfo
            Dim procExecuting As New Process

            With procStartInfo
                .UseShellExecute = True
                .FileName = "AutoUpdate.exe"
                .WindowStyle = ProcessWindowStyle.Normal
                .Verb = "runas"
            End With

            procExecuting = Process.Start(procStartInfo)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class