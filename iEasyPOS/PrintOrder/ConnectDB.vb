Imports System.Data.SqlClient

Module ConnectDB
    Dim server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "server", Nothing)
    Dim db As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "database", Nothing)
    Dim Username As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "username", Nothing)
    Dim Password As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "password", Nothing)
    Public strcon As String = "Server='" & server & "';Database='" & db & "';User Id='" & Username & "';Password='" & Password & "'"
    Function executesql(sql As String) As DataTable
        Try
            Dim dtAdaptor As SqlDataAdapter
            Dim objConn As New System.Data.SqlClient.SqlConnection
            Dim dt As New DataTable

            objConn.ConnectionString = strcon
            objConn.Open()
            dtAdaptor = New SqlDataAdapter(sql, objConn)
            dtAdaptor.Fill(dt)
            objConn.Close()
            objConn = Nothing
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
End Module
