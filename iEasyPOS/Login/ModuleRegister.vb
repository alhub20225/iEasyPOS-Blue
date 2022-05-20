Imports System.Data.Odbc
Imports System
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Globalization.CultureInfo
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Module ModuleRegister
    Dim table As String
    Dim field As String
    Dim value As String
    Dim where As String
    Public MacHddvariable As String = ""
    Public GenerateMacHdd As String = ""
    Public PasswordRandom As String = ""
    Sub ClearTxt()
        Register.TxtFirstName.Clear()
        Register.TxtLastName.Clear()
        Register.TxtEmail.Clear()
        Register.TxtPhone.Clear()
    End Sub
    Sub AddRegister()
        RandomPassword()
        Dim FirstName As String = Register.TxtFirstName.Text
        Dim LastName As String = Register.TxtLastName.Text
        Dim BirthDay As String = Convert.ToDateTime(Register.DateTimeBirthDay.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
        Dim Email As String = Register.TxtEmail.Text
        Dim Phone As String = Register.TxtPhone.Text
        Dim PassWordRan As String = PasswordRandom
        Dim Registerdate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm", New System.Globalization.CultureInfo("en-US"))
        'Check index Phone
        If Phone.Length > 10 Or Phone.Length < 10 Then
            MsgBox("กรุณากรอกหมายเลขโทรศัพทฺ์ให้ครบ", MsgBoxStyle.Information, "")

        End If
        'Check Email
        Dim EmailAt As Integer = Email.IndexOf("@")
        Dim EmailDot As Integer = Email.IndexOf(".")
        If EmailAt < 0 Or EmailDot < 0 Then
            MsgBox("กรุณากรอก email ให้ครบ", MsgBoxStyle.Information, "")

        End If
        'Check Null InTextbox
        If FirstName = "" Or LastName = "" Or Email = "" Or Phone = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical, "")

        Else
            'Generate Get Serial HDD And MacAddress 
            GetSerialHDD()
            GetMacaddress()
            GetEncrytion()
            RandomPassword()
            'Check Email
            Dim field As String = "Email"
            Dim table As String = "Users"
            Dim Where As String = "Email='" & Email & "' AND Active=1"
            Dim DataEmail As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
            'executesql("SELECT Email FROM Users WHERE Email='" & Email & "' AND Active=1")
            If DataEmail.Rows.Count > 0 Then
                MsgBox("Email นี้ได้ทำการสมัครเรียบร้อย กรุณาเปลี่ยน Email", MsgBoxStyle.Information, "")
                Exit Sub
            Else
                'insert into UserName 
                field = "FirstName, LastName, Passwords, BirthDay, Email, Phone, Registerdate, Active, UpdateDate, Deletedate, EditUserId, DeleteUserId, RoleId,Hash,GenderId,NationalityId"
                table = "Users"
                Dim value As String = "'" & FirstName & "','" & LastName & "','" & PassWordRan & "','" & BirthDay & "','" & Email & "','" & Phone & "','" & Registerdate & "',1,'','','','',1,'" & RandomHashing() & "',1,1"
                ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=" & field & "&table=" & table & "&value=" & value & "")
                'executesql("INSERT INTO Users(FirstName, LastName, Passwords, BirthDay, Email, Phone, Registerdate, Active, UpdateDate, Deletedate, EditUserId, DeleteUserId, RoleId,,Hash,GenderId,NationalityId) VALUES('" & FirstName & "','" & LastName & "','" & PassWordRan & "','" & BirthDay & "','" & Email & "','" & Phone & "','" & Registerdate & "',1,'','','','',2,'" & RandomHashing() & "',1,1)")
                ModuleSendToEmail.SendPassWord()
                ClearTxt()
            End If
        End If
    End Sub
    Public Function RandomPassword() As String
        Dim rand As New Random()
        Dim randomnumber As Integer
        randomnumber = rand.Next(100000, 999999)
        PasswordRandom = randomnumber
        CheckPasswordrandom()
    End Function
    Public Function RandomHashing()
        Dim Word As String = "abcdefghijklmnolqrstuvwxyz0123456789"
        Dim rand As New Random
        Dim Sb As New System.Text.StringBuilder
        Dim WordRandom As String
        For i As Integer = 1 To 32
            Dim idx As Integer = rand.Next(0, 35)
            Sb.Append(Word.Substring(idx, 1))
        Next
        WordRandom = Sb.ToString
        table = "Users"
        field = "UsersId"
        where = "Hash='" & WordRandom & "'"
        Dim CheckDataHashing As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        If CheckDataHashing.Rows.Count > 0 Then
            RandomHashing()
        Else
            Return WordRandom
        End If
    End Function
    Public Function GetSerialHDD() As String
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
        GetSerialHDD = Hex(Serial)
    End Function
    Public Function GetMacaddress() As String
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Dim Macaddress As String = nics(1).GetPhysicalAddress.ToString
        Dim MacHdd As String = Macaddress + GetSerialHDD()
        MacHddvariable = MacHdd
    End Function
    Public Function GetEncrytion() As String
        GenerateMacHdd = EnCryptDecrypt.CryptorEngine.Encrypt(MacHddvariable, True)
    End Function
    Public Function CheckEmail() As String
        Dim field As String = "Email"
        Dim table As String = "Users"
        Dim Where As String = "Email='" & Register.TxtEmail.Text & "' AND Active=1"
        Dim DataEmail As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
        'executesql("SELECT Email FROM Users WHERE Email='" & Register.TxtEmail.Text & "' AND Active=1")
        If DataEmail.Rows.Count > 0 Then
            MsgBox("Email ในการสมัครซ้ำกรุณาเปลี่ยน Email", MsgBoxStyle.Critical, "")
            Exit Function
        End If
    End Function
    Public Function CheckPasswordrandom()
        Dim field As String = "Passwords"
        Dim table As String = "Users"
        Dim Where As String = "Passwords='" & PasswordRandom & "' AND Active=1"
        Dim CheckNumberRandom As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
        'executesql("SELECT Passwords FROM Users WHERE Passwords='" & PasswordRandom & "' AND Active=1")
        If CheckNumberRandom.Rows.Count > 0 Then
            MsgBox("ซ้ำ")
            RandomPassword()
            Exit Function
        Else
            Exit Function
        End If
    End Function
    Sub Setregistry()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_HiveUp\POS", "server", "TER-PC\SQLEXPRESS")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_HiveUp\POS", "username", "sa")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_HiveUp\POS", "password", "admin123")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_HiveUp\POS", "database", "Server_HiveUp")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\POS_HiveUp\POS", "Email", Register.TxtEmail.Text)
    End Sub
    'Connect DataBase
    'Public strcon As String = "Server=localhost;User Id=hiveup_testnoi; Password=m9JWdqHWp5; Database=hiveup_testnoi"
    ''user id='hiveup_testnoi';data source=''; persist security info=True;initial catalog='hiveup_testnoi';password='m9JWdqHWp5'
    'Function ConnectServerDataBase(sql As String) As DataTable
    '    Try
    '        Dim sqlConnection As MySqlConnection = New MySqlConnection
    '        sqlConnection.ConnectionString = strcon
    '        If sqlConnection.State = ConnectionState.Closed Then
    '            sqlConnection.Open()
    '            MsgBox("Conected")
    '        Else
    '            sqlConnection.Close()
    '            MsgBox("Conect Faild")
    '        End If
    '        'Dim dtAdaptor As SqlDataAdapter
    '        'Dim objConn As New SqlConnection
    '        'Dim dt As New DataTable

    '        'objConn.ConnectionString = strcon
    '        'objConn.Open()
    '        'dtAdaptor = New SqlDataAdapter(sql, objConn)
    '        'dtAdaptor.Fill(dt)
    '        'objConn.Close()
    '        'objConn = Nothing
    '        'Return dt
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Sub AddToServer()
    '    Dim FirstName As String = Register.TxtFirstName.Text
    '    Dim Lastname As String = Register.TxtLastName.Text
    '    Dim BirthDay As String = Convert.ToDateTime(Register.DateTimeBirthDay.Value).ToString("yyyy-MM-dd HH:mm:ss")
    '    Dim Email As String = Register.TxtEmail.Text
    '    Dim Phone As String = Register.TxtPhone.Text
    '    '"INSERT INTO Users(FirstName,LastName,BirthDay,Email,Phone,Active) VALUES('" & FirstName & "','" & Lastname & "','" & BirthDay & "','" & Email & "','" & Phone & "',1)"
    '    ConnectServerDataBase("INSERT INTO users(FirstName) VALUES('" & FirstName & "')")
    '    Clipboard.SetText("INSERT INTO Users(FirstName) VALUES('" & FirstName & "')")
    'End Sub
End Module
