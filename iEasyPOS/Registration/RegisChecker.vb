Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Module RegisChecker
    Dim lc_key As String = EnCryptDecrypt.CryptorEngine.Encrypt(GetDriveSerialNumber, True)
    Dim VerifiedKey As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "VerifiedKEY", Nothing)
    Public isDemo As Boolean = False
    Sub CheckKeyRegis()
        If lc_key = "" Or VerifiedKey = "" Then
            RegisOnline.ShowDialog()
        Else
            ReCheckKey()
        End If
    End Sub
    Function Encrypt_verified(toEncrypt As String, useHashing As Boolean) As String
        Dim keyArray As Byte()
        Dim toEncryptArray As Byte() = UTF8Encoding.UTF8.GetBytes(toEncrypt)
        Dim key As String = "ALWVERIFIED"

        If useHashing Then
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
            hashmd5.Clear()
        Else
            keyArray = UTF8Encoding.UTF8.GetBytes(key)
        End If

        Dim tdes As New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
        tdes.Clear()
        Return Convert.ToBase64String(resultArray, 0, resultArray.Length)
    End Function

    Sub ReCheckKey()
        Console.WriteLine("ReCheckKey")
        Dim EncryptKey As String = Encrypt_verified(lc_key, True)
        If EncryptKey = VerifiedKey Then
            RecheckKeyOnline()
            Check_connect_DB()
        Else
            writeLog("ReCheckKey fail")
            MsgBox("รหัสลงทะเบียน ไม่ถูกต้อง โปรดครวจสอบการลงทะเบียน", MsgBoxStyle.Critical, "รหัสลงทะเบียน")
            RegisOnline.ShowDialog()
        End If
    End Sub

    Sub RecheckKeyOnline()
        Console.WriteLine("RecheckKeyOnline")
        Dim VeriCode As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "VerifiedKEY", Nothing)
        Dim CheckNum As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", Nothing)
        If CheckNum = "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", "qDYamMlSx0M=") ' set offline count =0
            'Dim a = EnCryptDecrypt.CryptorEngine.Encrypt(0, True)
            'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", a)
            CheckNum = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", Nothing)
        End If

        CheckNum = EnCryptDecrypt.CryptorEngine.Decrypt(CheckNum, True)
        Console.WriteLine("offline = " & CheckNum)
        writeLog("offline = " & CheckNum)
        If CDbl(CheckNum) > 10 Then ' Offline เกิน 10 ครั้ง
            writeLog("VerifiedKEY Check fail Check CheckRegis offline count > 10")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "VerifiedKEY", "") 'ลบหรัสยืนยัน
            MsgBox("ไม่สามารถตรวจสอบข้อมูลการลงทะเบียนได้ กรุณาเชื่อมต่ออินเตอร์เน็ต / ติดต่อผู้จัดจำหน่าย", MsgBoxStyle.Critical, "กรุณาเชื่อมต่ออินเตอร์เน็ต")
            RegisOnline.ShowDialog()
            Exit Sub
        End If

        Try
            Dim GetRegisData As DataTable = ExecuteMysql("select id,RegisDate,isDEMO from Registration where VerifiedCode = '" & VeriCode & "'")
            Dim Countdate As Integer = 0
            Dim AcDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))

            If GetRegisData.Rows.Count = 0 Then
                writeLog("VerifiedKEY Check fail")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "VerifiedKEY", "")
                MsgBox("ไม่สามารถตรวจสอบข้อมูลการลงทะเบียนได้ กรุณาเชื่อมต่ออินเตอร์เน็ต / ติดต่อผู้จัดจำหน่าย", MsgBoxStyle.Critical, "ตรวจสอบข้อมูลการลงทะเบียน")
                RegisOnline.ShowDialog()
                Exit Sub
            ElseIf IsDBNull(GetRegisData) Then
                writeLog("VerifiedKEY Check fail")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "VerifiedKEY", "")
                MsgBox("ไม่สามารถตรวจสอบข้อมูลการลงทะเบียนได้ กรุณาเชื่อมต่ออินเตอร์เน็ต / ติดต่อผู้จัดจำหน่าย", MsgBoxStyle.Critical, "ตรวจสอบข้อมูลการลงทะเบียน")
                RegisOnline.ShowDialog()
                Exit Sub

            Else
                writeLog("VerifiedKEY Check ok")
                Console.WriteLine("VerifiedKEY Check ok")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", "qDYamMlSx0M=") ' set offline count =0
                ExecuteMysql("UPDATE Registration SET ActiveIP='" & GetIP() & "',LastActive='" & AcDate & "' where VerifiedCode = '" & VeriCode & "'")
                Countdate = DayCal(Convert.ToDateTime(GetRegisData(0)("RegisDate")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US")))
                ExtData(VeriCode)
                If GetRegisData(0)("isDEMO") = 1 And Countdate < 45 Then

                    Console.WriteLine(Countdate.ToString & "  :  " & Convert.ToDateTime(GetRegisData(0)("RegisDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")))
                    isDemo = True
                    Dim l1 As New Label
                    l1.Text = "DEMO"
                    l1.AutoSize = True
                    l1.Font = New Font("Kanit Medium", 36, FontStyle.Bold)
                    l1.ForeColor = Color.White
                    l1.BackColor = Color.Transparent
                    l1.Location = New Point(20, 50)
                    Frm_Login.Panel1.Controls.Add(l1)
                ElseIf GetRegisData(0)("isDEMO") = 1 And Countdate > 45 Then
                    Console.WriteLine(Countdate.ToString)
                    writeLog("VerifiedKEY Check fail >> 45 Day !!")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "VerifiedKEY", "")
                    RegisOnline.ShowDialog()
                Else
                    isDemo = False
                    Exit Sub
                End If

            End If


        Catch ex As Exception
            RegisCheckCound()
            writeLog("RecheckKeyOnline " & ex.Message)
            Dim lb As New Label
            lb.Text = "OFFLINE"
            lb.AutoSize = True
            lb.Font = New Font("Kanit", 10, FontStyle.Bold)
            lb.ForeColor = Color.White
            lb.BackColor = Color.Transparent
            lb.Location = New Point(10, 500)
            Frm_Login.Panel1.Controls.Add(lb)
            Exit Sub
        End Try

    End Sub

    Sub RegisCheckCound()
        Dim CheckNum As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", Nothing)
        CheckNum = EnCryptDecrypt.CryptorEngine.Decrypt(CheckNum, True)

        CheckNum = CDbl(CheckNum) + 1

        CheckNum = EnCryptDecrypt.CryptorEngine.Encrypt(CheckNum, True)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "CheckCount", CheckNum)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IE\C3", "C", CheckNum)

    End Sub

    Public Function DayCal(D As Date) As String
        Dim day As Integer = DateDiff(DateInterval.Day, D, Now) 'Mod 30 - 10
        Dim TextDay As String = day
        Return TextDay
    End Function
    Sub RegisData()
        Dim GetRegisData As DataTable = ExecuteMysql("select id,RegisName,RegisKey,VerifiedCode,Address,Telephone,ContaceName from Registration where RegisKey = '" & RegisOnline.TextBoxRegisKey.Text & "'")
        Console.WriteLine("select id,RegisName,RegisKey,VerifiedCode,Address,Telephone,ContaceName from Registration where RegisKey = '" & RegisOnline.TextBoxRegisKey.Text & "'")
        If IsNothing(GetRegisData) Then
            Exit Sub
        End If
        If GetRegisData.Rows.Count = 0 Then
            Exit Sub
        Else
            RegisOnline.TextBoxRegisName.Text = GetRegisData(0)("RegisName")
            RegisOnline.TextBox1.Text = GetRegisData(0)("Address")
            RegisOnline.TextBox2.Text = GetRegisData(0)("Telephone")
            RegisOnline.TextBox3.Text = GetRegisData(0)("ContaceName")
            RegisOnline.TextBoxVerified.Text = GetRegisData(0)("VerifiedCode")

            RegisOnline.TextBoxRegisName.ReadOnly = True
            RegisOnline.TextBox1.ReadOnly = True
            RegisOnline.TextBox2.ReadOnly = True
            RegisOnline.TextBox3.ReadOnly = True
            RegisOnline.TextBoxVerified.ReadOnly = True
        End If

        writeLog("Regisdata")
    End Sub

    Sub Check_connect_DB()

        Dim server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "server", Nothing)
        If server Is Nothing Then
            Frm_select_host.Show()
        Else
            Dim TobjConn As New SqlConnection
            TobjConn.ConnectionString = strcon
            Try
                TobjConn.Open()
                Frm_Login.Show()
            Catch sqlError As SqlException
                Frm_select_host.Show()
                Exit Sub
            End Try
        End If


    End Sub
    Public dataExt As New ExtDataClass
    Sub ExtData(verCode As String)
        Dim GetRegisData As DataTable = ExecuteMysql("select id,Ext_mat from Registration where VerifiedCode = '" & verCode & "'")

        If GetRegisData.Rows.Count = 0 Then
            dataExt.ext_mat = 0
        Else

            dataExt.ext_mat = GetRegisData(0)("Ext_mat")
        End If

    End Sub
End Module

Public Class ExtDataClass
    Public ext_mat As Integer
End Class
