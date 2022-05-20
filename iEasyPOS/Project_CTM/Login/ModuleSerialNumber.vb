Imports System.Net.NetworkInformation
Module ModuleSerialNumber
    Public SerialHDDData As String = ""
    Public MacAddressData As String = ""
    Public MacHddData As String = ""
    Public GenerateIdData As String = ""
    Sub LoadGenerateRegister()
        SerialHDDData = GetDriveSerialNumber()
        GetMacAddress()
        GetHDDMAC()
        GetEncrytion()
        'insert into RegisterSystem 
        Dim DateRegister As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim field As String = "SerialHDD,MacAddress,GenerateId,RegisterDate,Active"
        Dim table As String = "RegisterSystem"
        Dim value As String = "'" & SerialHDDData & "','" & MacAddressData & "','" & GenerateIdData & "','" & DateRegister & "',1"
        ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=" & field & "&table=" & table & "&value=" & value & "")
        'executesql("INSERT INTO RegisterSystem(SerialHDD,MacAddress,GenerateId,RegisterDate,Active) VALUES('" & SerialHDDData & "','" & MacAddressData & "','" & GenerateIdData & "','" & DateRegister & "',1)")
    End Sub
    Public Function GetDriveSerialNumber() As String
        Dim Serial As Long
        Dim fso As Object, Drv As Object
        fso = CreateObject("Scripting.FileSystemObject")
        Drv = fso.GetDrive(fso.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
        With Drv
            If .IsReady Then
                Serial = .SerialNumber
            Else    '"Drive Not Ready!"
                Serial = -1
            End If
        End With
        'Clean up
        Drv = Nothing
        fso = Nothing
        GetDriveSerialNumber = Hex(Serial)
    End Function
    Public Function GetMacAddress() As String
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        MacAddressData = nics(1).GetPhysicalAddress.ToString
    End Function
    Public Function GetHDDMAC() As String
        MacHddData = SerialHDDData + MacAddressData
    End Function
    Public Function GetEncrytion() As String
        GenerateIdData = EnCryptDecrypt.CryptorEngine.Encrypt(MacHddData, True)
    End Function
    Public Function CheckValidate() As Integer
        Dim RegisterDate As DataTable = executesql("SELECT RegisterDate FROM RegisterSystem WHERE Active=1")
    End Function
End Module
