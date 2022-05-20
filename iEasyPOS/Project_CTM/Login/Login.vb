Imports System.Data.SqlClient

Public Class Frm_Login
    Public Shared txt_arr As Array
    Public Shared UserId As Integer
    Public Shared UserName As String
    Public Shared RoleId As Integer
    Public Shared SendUserId As Integer
    Public Shared SendUserName As String
    Public Shared SendRolesId As Integer
    Sub LoadUsers()
        FlowPanelUsers.Controls.Clear()
        txt_password.Text = ""
        LabelUser.Text = ""
        Dim DataUsers As DataTable = executesql("SELECT UserId,FristName FROM Users WHERE Active=1")
        If IsNothing(DataUsers) Then
            Exit Sub
        End If
        For i As Integer = 0 To DataUsers.Rows.Count - 1
            Dim Users As New Telerik.WinControls.UI.RadButton
            CType(Users.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Users.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Users.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Users.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Users.Size = New System.Drawing.Size(130, 55)
            Users.Tag = DataUsers.Rows(i)("UserId")
            Users.Name = DataUsers.Rows(i)("FristName")
            Users.AccessibleName = DataUsers.Rows(i)("UserId")
            Users.AccessibleDescription = DataUsers.Rows(i)("FristName")
            Users.Text = DataUsers.Rows(i)("FristName")
            'Users.BackColor = Color.FromArgb(234, 52, 52)
            'Users.ForeColor = Color.White
            'Users.FlatStyle = FlatStyle.Flat
            'Users.Height = 60
            'Users.Width = 150
            'Users.TextAlign = ContentAlignment.MiddleCenter
            FlowPanelUsers.Controls.Add(Users)
            AddHandler Users.Click, AddressOf checkdata
        Next
    End Sub
    Public Sub checkdata(sender As Object, e As EventArgs)
        UserId = sender.Tag
        UserName = sender.Name
        LabelUser.Text = UserName
        panel_number.Visible = True
        PanelUsers.Visible = False
        txt_password.Focus()
    End Sub
    Private Sub Slide_down_Click(sender As Object, e As EventArgs) Handles Slide_down.Click
        'While (Me.Width < 1243)
        '    Me.Width += 1
        'End While
        'group_settings.Show()
        Frm_select_host.Show()
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        group_settings.Hide()

        'check DB App
        'checkSale()
        'panel_number.Hide()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        While (Me.Width > 1021)
            Me.Width -= 1
        End While
        group_settings.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        loading.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Frm_LoginHost.Show()
        Frm_select_host.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Register.Show()
    End Sub
    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            'Count Textbox password Length
            Dim CountTextLength As Integer = txt_password.Text.Length
            If CountTextLength < 4 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "รหัสผ่านอย่างน้อย 4 ตัว"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'Btn Login 
            Dim PasswordCheck As String = txt_password.Text
            If PasswordCheck = "" Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "กรุณาใส่รหัสผ่าน"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            Dim CheckUsers As DataTable = executesql("Select UserId, FristName, RoleId FROM Users WHERE UserId ='" & UserId & "' AND Passwords='" & PasswordCheck & "' AND Active=1")
            If CheckUsers.Rows.Count > 0 Then
                RoleId = CheckUsers(0)("RoleId")
                'send to ModuleCheckRolesId
                SendRolesId = CheckUsers(0)("RoleId")
                SendUserId = CheckUsers(0)("UserId")
                SendUserName = CheckUsers(0)("FristName")
                UserName = SendUserName
                UserId = CheckUsers(0)("UserId")
                Main2.Show()
                Me.Visible = False
                Exit Sub
            ElseIf CheckUsers.Rows.Count = 0 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "รหัสผ่านไม่ถูกต้อง"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Frm_PunchTheClock.Show()
    End Sub

    Private Sub BckBtn_Click(sender As Object, e As EventArgs) Handles BckBtn.Click
        panel_number.Visible = False
        PanelUsers.Visible = True
        txt_password.Clear()
    End Sub

    Private Sub BtnLogIn_Click_1(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        Dim CountTextLength As Integer = txt_password.Text.Length
        If CountTextLength < 4 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "รหัสผ่านอย่างน้อย 4 ตัว"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Btn Login 
        Dim PasswordCheck As String = txt_password.Text
        If PasswordCheck = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาใส่รหัสผ่าน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        Dim CheckUsers As DataTable = executesql("SELECT UserId,FristName,RoleId FROM Users WHERE UserId ='" & UserId & "' AND Passwords='" & PasswordCheck & "' AND Active=1")
        If CheckUsers.Rows.Count > 0 Then
            RoleId = CheckUsers(0)("RoleId")
            'send to ModuleCheckRolesId
            SendRolesId = CheckUsers(0)("RoleId")
            SendUserId = CheckUsers(0)("UserId")
            SendUserName = CheckUsers(0)("FristName")
            UserName = SendUserName
            UserId = CheckUsers(0)("UserId")
            Main2.Show()
            Me.Visible = False
            ModuleCreateDatabase.CheckField()
            Exit Sub
        ElseIf CheckUsers.Rows.Count = 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "รหัสผ่านไม่ถูกต้อง"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        txt_password.Text += "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        txt_password.Text += "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        txt_password.Text += "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        txt_password.Text += "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        txt_password.Text += "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        txt_password.Text += "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        txt_password.Text += "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        txt_password.Text += "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        txt_password.Text += "9"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        txt_password.Text += "0"
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim count_txt As Integer = txt_password.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = txt_password.Text.Substring(0, i)
        Next
        txt_password.Clear()
        txt_password.Text = newtxt
    End Sub

    Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
        txt_password.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Me.Close()
        FrmCreateDataBase2.Show()
    End Sub

End Class
