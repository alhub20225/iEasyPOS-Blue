
Imports System.Data
Imports System.Data.SqlClient
Module connect_database
    Dim server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "server", Nothing)
    Dim db As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "database", Nothing)
    Dim Username As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "username", Nothing)
    Dim Password As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "password", Nothing)
    Public strcon As String = "Server='" & server & "';Database='" & db & "';User Id='" & Username & "';Password='" & Password & "'"

    Function executesql(sql As String) As DataTable
        Try
            Dim dtAdaptor As SqlDataAdapter
            Dim objConn As New SqlConnection
            Dim dt As New DataTable

            objConn.ConnectionString = strcon
            objConn.Open()
            dtAdaptor = New SqlDataAdapter(sql, objConn)
            dtAdaptor.Fill(dt)
            objConn.Close()
            objConn = Nothing
            Return dt
        Catch ex As Exception
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
    Public Function getdate(datetime As DateTime)
        Dim strMonthDaye As String
        Dim stryeare As String
        Dim strmonthdayyeare As String
        Dim time As String
        time = Format(datetime, "H:mm:ss")
        stryeare = Format(datetime, "yyyy") - 543
        strMonthDaye = Format(datetime, "MM-dd")
        strmonthdayyeare = stryeare & "-" & strMonthDaye & " " & time
        Return strmonthdayyeare
    End Function

    Public Function getdateend(datetime As DateTime)
        Dim strMonthDaye As String
        Dim stryeare As String
        Dim strmonthdayyeare As String
        Dim time As String
        time = Format(datetime, "H:mm:ss")
        stryeare = Format(datetime, "yyyy") - 543
        strMonthDaye = Format(datetime, "MM-dd")
        strmonthdayyeare = stryeare & "-" & strMonthDaye
        Return strmonthdayyeare & " 23:59:59"
    End Function
End Module
