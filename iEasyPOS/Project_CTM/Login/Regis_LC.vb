Public Class Regis_LC
    Private Sub Regis_LC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_serailnumber.Text = GetDriveSerialNumber()
        key_output.Text = EnCryptDecrypt.CryptorEngine.Encrypt(txt_serailnumber.Text, True)
        load_chk()
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
    Sub load_chk()
        Dim loadkey As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "KEY", Nothing)
        If loadkey = "" Then
            txt_status.Text = "ยังไม่ลงทะเบียน"
        End If
        If checkkey(loadkey) Then
            txt_status.Text = "ลงทะเบียนแล้ว"
            SimpleButton1.Enabled = False
            Frm_Login.Show()
            Me.Close()
        Else
            txt_status.Text = "ยังไม่ได้ลงทะเบียน"
            Frm_Login.Close()
        End If
    End Sub
    Function checkkey(key As String) As Boolean
        If key = EnCryptDecrypt.CryptorEngine.Encrypt(GetDriveSerialNumber(), True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If key_output.Text = txt_cdkey.Text Then
            MsgBox("ลงทะเบียนเรียบร้อย", MsgBoxStyle.MsgBoxRight, "แจ้งเตือน")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "KEY", txt_cdkey.Text)
            load_chk()
        Else
            MsgBox("Key ผิดพลาด", MsgBoxStyle.Critical, "แจ้งเตือน")
            load_chk()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class