Imports MySql.Data.MySqlClient

Module ConnectRegisDB
    'Dim Mystrcon As String = "Server=103.246.19.221;Port=3306;Database=cashpos_lc;Uid=cashpos_admin;Pwd=Qwa177a5;Character Set=utf8;"
    Dim Mystrcon As String = "Server=103.246.19.219;Port=3306;Database=witzyz_cart_db;Uid=witzyz_admin;Pwd=qwa177a5;Character Set=utf8;"

    Function ExecuteMysql(sql As String) As DataTable
        Try
            Dim dtAdaptor As MySqlDataAdapter
            Dim objConn As New MySqlConnection
            Dim dt As New DataTable

            objConn.ConnectionString = Mystrcon
            objConn.Open()
            dtAdaptor = New MySqlDataAdapter(sql, objConn)
            dtAdaptor.Fill(dt)
            objConn.Close()
            objConn = Nothing
            Return dt
        Catch ex As Exception
            writeLog("MySqlConnection " & ex.Message)
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
End Module
