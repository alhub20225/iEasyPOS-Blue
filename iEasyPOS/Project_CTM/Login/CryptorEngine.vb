
Imports System.Text
Imports System.Security.Cryptography


Namespace EnCryptDecrypt
    Public Class CryptorEngine

        Public Shared Function Encrypt(toEncrypt As String, useHashing As Boolean) As String
            Dim keyArray As Byte()
            Dim toEncryptArray As Byte() = UTF8Encoding.UTF8.GetBytes(toEncrypt)
            Dim key As String = "CTMPOS"

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

        Public Shared Function Decrypt(cipherString As String, useHashing As Boolean) As String
            Try
                Dim keyArray As Byte()
                Dim toEncryptArray As Byte() = Convert.FromBase64String(cipherString)
                'Get your key from config file to open the lock!
                Dim key As String = "CTMPOS"

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

                Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
                Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)

                tdes.Clear()
                Return UTF8Encoding.UTF8.GetString(resultArray)
            Catch ex As Exception
                'FrmDBSetting.ShowDialog()
                Return True
            End Try

        End Function

    End Class
End Namespace

