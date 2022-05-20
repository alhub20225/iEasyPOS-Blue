
Imports System.Data
Imports System.Data.SqlClient
Imports Newtonsoft.Json

Module connect_database
    Dim server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "server", Nothing)
    Dim db As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "database", Nothing)
    Dim Username As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "username", Nothing)
    Dim Password As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "password", Nothing)
    Public strcon As String = "Server='" & server & "';Database='" & db & "';User Id='" & Username & "';Password='" & Password & "'"
    Public rptConStr As String = "Data Source='" & server & "';Initial Catalog='" & db & "';Persist Security Info=True;User ID='" & Username & "';Password='" & Password & "'"

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
    Public Function getDataToClass(sql As String) As String
        Dim dt As DataTable = New DataTable()
        Using con As SqlConnection = New SqlConnection(strcon)
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                con.Open()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim rows As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()
                Dim row As Dictionary(Of String, Object)

                For Each dr As DataRow In dt.Rows
                    row = New Dictionary(Of String, Object)()
                    For Each col As DataColumn In dt.Columns
                        row.Add(col.ColumnName, dr(col))
                    Next
                    rows.Add(row)
                Next
                Return JsonConvert.SerializeObject(rows)
            End Using
        End Using
    End Function

    Public Function getOneDataToClass(sql As String) As String
        Dim dt As DataTable = New DataTable()
        Using con As SqlConnection = New SqlConnection(strcon)
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                con.Open()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim rows As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()
                Dim row As Dictionary(Of String, Object)

                For Each dr As DataRow In dt.Rows
                    row = New Dictionary(Of String, Object)()
                    For Each col As DataColumn In dt.Columns
                        row.Add(col.ColumnName, dr(col))
                    Next
                    rows.Add(row)
                Next
                Dim a = JsonConvert.SerializeObject(rows)
                Dim result As String = a.Split("[").Last.Split("]").First
                Return result
            End Using
        End Using
    End Function

    Public Function getDataToClassList(sql As String, isList As Boolean?) As String
        Dim dt As DataTable = New DataTable()
        Using con As SqlConnection = New SqlConnection(rptConStr)
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                con.Open()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim rows As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()
                Dim row As Dictionary(Of String, Object)
                For Each dr As DataRow In dt.Rows
                    row = New Dictionary(Of String, Object)()
                    For Each col As DataColumn In dt.Columns
                        row.Add(col.ColumnName, dr(col))
                    Next
                    rows.Add(row)
                Next
                Dim result As String = JsonConvert.SerializeObject(rows)
                If isList = False Then
                    result = result.Split("[").Last.Split("]").First
                End If
                Return result
            End Using
        End Using
    End Function
End Module
