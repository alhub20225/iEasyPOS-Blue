Imports System.Data.Odbc
Imports System
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Globalization.CultureInfo
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient
Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub BtnAddRegister_Click(sender As Object, e As EventArgs) Handles BtnAddRegister.Click
        ModuleRegister.AddRegister()
        Frm_Login.Close()
        Me.Close()
    End Sub
    'Dim strcon As String = "Server=localhost;User Id=hiveup_testnoi; Password=m9JWdqHWp5; Database=hiveup_testnoi"
    'Dim sqlConnection As MySqlConnection = New MySqlConnection
    'Private Sub BtnAddRegister_Click(sender As Object, e As EventArgs) Handles BtnAddRegister.Click

    '    SqlConnection.ConnectionString = strcon
    '    Try
    '        If sqlConnection.State = ConnectionState.Closed Then
    '            sqlConnection.Open()
    '            MsgBox("Conected")
    '        Else
    '            sqlConnection.Close()
    '            MsgBox("Conect Faild")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'ModuleRegister.AddRegister()
    'ModuleRegister.AddToServer()
    'ModuleSerialNumber.LoadGenerateRegister()
    'ModuleRegister.Setregistry()
    ' ModuleRegister.ClearTxt()
    'verify.Show()
    ' Me.Close()
    'End Sub
End Class