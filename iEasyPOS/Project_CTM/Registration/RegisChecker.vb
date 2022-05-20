Imports System.Text
Imports System.Security.Cryptography
Module RegisChecker
    Dim lc_key As String = EnCryptDecrypt.CryptorEngine.Encrypt(GetDriveSerialNumber, True)
    Dim VerifiedKey As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "VerifiedKEY", Nothing)
    Sub CheckKeyRegis()
        MsgBox(lc_key)
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
        Dim EncryptKey As String = Encrypt_verified(lc_key, True)
        If EncryptKey = VerifiedKey Then
            Frm_Login.Show()
        Else
            MsgBox("รหัสลงทะเบียน ไม่ถูกต้อง โปรดครวจสอบการลงทะเบียน", MsgBoxStyle.Critical, "รหัสลงทะเบียน")
            RegisOnline.ShowDialog()
        End If
    End Sub
    Sub RegisData()
        Dim GetRegisData As DataTable = ExecuteMysql("select id,RegisName,RegisKey,VerifiedCode,Address,Telephone,ContaceName from Registration where RegisKey = '" & RegisOnline.TextBoxRegisKey.Text & "'")

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


    End Sub

End Module
