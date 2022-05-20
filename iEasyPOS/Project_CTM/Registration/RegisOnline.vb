Imports MySql.Data.MySqlClient
Public Class RegisOnline
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxRegisKey.Text = EnCryptDecrypt.CryptorEngine.Encrypt(GetDriveSerialNumber, True)

        RegisData()

    End Sub

    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Long
        Dim fso As Object, Drv As Object
        'Create a FileSystemObject object
        fso = CreateObject("Scripting.FileSystemObject")
        Drv = fso.GetDrive(fso.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        'Clean up
        Drv = Nothing
        fso = Nothing
        GetDriveSerialNumber = Hex(DriveSerial)
    End Function
    Dim RegisType As String = "CTMPOS"




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "KEY", TextBoxRegisKey.Text)

            Dim CheckKey As DataTable = ExecuteMysql("select id from Registration where RegisKey='" & TextBoxRegisKey.Text & "'")

            Dim RegisDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            If CheckKey.Rows.Count = 1 Then
                MsgBox("เครื่องนี้มีการลงทะเบียนไว้แล้ว", MsgBoxStyle.MsgBoxRight, "แจ้งเตือน")
                Exit Sub
            Else
                ExecuteMysql("insert into Registration (RegisName,RegisKey,Address,Telephone,ContaceName,RegisType,RegisDate) VALUES ('" & TextBoxRegisName.Text & "','" & TextBoxRegisKey.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & RegisType & "','" & RegisDate & "')")

                MsgBox("ลงทะเบียนเรียบร้อย", MsgBoxStyle.MsgBoxRight, "แจ้งเตือน")

                SendMailNotiRegis(TextBoxRegisKey.Text, TextBoxRegisName.Text, TextBox1.Text)

                Panel1.Visible = True

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Regiskey As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "KEY", Nothing)
        Dim CheckKey As DataTable = ExecuteMysql("select id from Registration where VerifiedCode='" & TextBoxVerified.Text & "' and RegisKey='" & Regiskey & "'")

        If TextBoxVerified.Text = "" Then
            Exit Sub
        End If

        If CheckKey.Rows.Count = 0 Then
            MsgBox("ไม่พบรหัสยืนยัน", MsgBoxStyle.Critical, "ตรวจสอบรหัส")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "VerifiedKEY", TextBoxVerified.Text)
            ExecuteMysql("update Registration set Active = 1 where id='" & CheckKey(0)("id") & "'")

            MsgBox("Verified OK", MsgBoxStyle.Information, "Verified")
            loading.Close()
            Me.Close()
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Regiskey As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "KEY", Nothing)
        If Regiskey = "" Then
            Exit Sub
        End If
        Dim CheckKey As DataTable = ExecuteMysql("select VerifiedCode from Registration where RegisKey='" & Regiskey & "'")
        If CheckKey(0)("VerifiedCode") = "" Then
            MsgBox("ไม่พบรหัสยืนยัน", MsgBoxStyle.Critical, "ตรวจสอบรหัส")
        Else
            TextBoxVerified.Text = CheckKey(0)("VerifiedCode")
            'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POSRegis_test\POS", "VerifiedKEY", TextBoxVerified.Text)
            'ExecuteMysql("update Registration set Active = 1 where id='" & CheckKey(0)("id") & "'")

            'MsgBox("Verified OK")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        loading.Close()
    End Sub
End Class
