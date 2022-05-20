Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Reflection
Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel
Imports System.Threading.Thread
Imports System.Resources
Imports System.ComponentModel.Design

Public Class Frm_Login
    Public Shared txt_arr As Array
    Public Shared UserId As Integer
    Public Shared UserName As String
    Public Shared RoleId As Integer
    Public Shared SendUserId As Integer
    Public Shared SendUserName As String
    Public Shared SendRolesId As Integer
    Public Shared language As Integer = 0
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'checkLang()
        UpdateDatabase.Update()
        LoadUsers()
        'group_settings.Hide()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "language", Nothing) = "" Then
            ComboLang.Text = "th-TH"
            language = 0
        Else
            ComboLang.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "language", Nothing)
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "language", Nothing) = "th-TH" Then
                language = 0
                BtnLogIn.Text = "ตกลง"
            Else
                language = 1
                BtnLogIn.Text = "Login"
            End If
        End If

        LoadSetting()
        LabelVersion.Text = "1.220405002"
        checkVersion(LabelVersion.Text)
    End Sub
    Sub LoadUsers()
        FlowPanelUsers.Controls.Clear()
        txt_password.Text = ""
        LabelUser.Text = ""
        Dim DataUsers As DataTable = executesql("SELECT UserId,FirstName FROM Users WHERE Active=1")
        If IsNothing(DataUsers) Then
            Exit Sub
        End If
        Dim BckColor As System.Drawing.Color
        BckColor = Color.FromArgb(45, 149, 239)

        For i As Integer = 0 To DataUsers.Rows.Count - 1
            Dim Users As New DevExpress.XtraEditors.SimpleButton
            Users.Font = New System.Drawing.Font("Kanit", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Users.ForeColor = Color.White
            Users.LookAndFeel.SkinName = "Office 2019 Colorful"
            Users.LookAndFeel.UseDefaultLookAndFeel = False
            Users.LookAndFeel.SkinMaskColor = Color.FromArgb(45, 149, 239)
            Users.Size = New System.Drawing.Size(127, 48)
            Users.ImageOptions.Image = iEasyPOS.My.Resources.Resources.Icon_NameUserWhite
            Users.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Users.Cursor = Cursors.Hand
            Users.Tag = DataUsers.Rows(i)("UserId")
            Users.Name = DataUsers.Rows(i)("FirstName")
            Users.AccessibleName = DataUsers.Rows(i)("UserId")
            Users.AccessibleDescription = DataUsers.Rows(i)("FirstName")
            Users.Text = DataUsers.Rows(i)("FirstName")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " System close")
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim Prcss() As Process
        Prcss = Process.GetProcessesByName("PrintOrder")
        If Prcss.Count > 0 Then

            Process.GetProcessesByName("PrintOrder")(0).Kill()

        End If

        Me.Close()
        loading.Close()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    'Frm_LoginHost.Show()
    '    Frm_select_host.Show()
    'End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            'Count Textbox password Length
            Dim CountTextLength As Integer = txt_password.Text.Length
            If CountTextLength < 4 Then
                Frm_Critical.Show()
                If ComboLang.Text = "th-TH" Then
                    Frm_Critical.head_Label.Text = "รหัสผ่านอย่างน้อย 4 ตัว"
                Else
                    Frm_Critical.head_Label.Text = "Login failed!!"
                End If

                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'Btn Login 
            Dim PasswordCheck As String = txt_password.Text
            If PasswordCheck = "" Then
                Frm_Critical.Show()

                If ComboLang.Text = "th-TH" Then
                    Frm_Critical.head_Label.Text = "กรุณาใส่รหัสผ่าน"
                Else
                    Frm_Critical.head_Label.Text = "Login failed!!"
                End If
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            Dim CheckUsers As DataTable = executesql("Select UserId, FirstName, RoleId FROM Users WHERE UserId ='" & UserId & "' AND Passwords='" & PasswordCheck & "' AND Active=1")
            If CheckUsers.Rows.Count > 0 Then
                RoleId = CheckUsers(0)("RoleId")
                'send to ModuleCheckRolesId
                SendRolesId = CheckUsers(0)("RoleId")
                SendUserId = CheckUsers(0)("UserId")
                SendUserName = CheckUsers(0)("FirstName")
                UserName = SendUserName
                UserId = CheckUsers(0)("UserId")
                writeLog("User ID " + CheckUsers(0)("UserId").ToString + " " + CheckUsers(0)("FirstName") + " Login")
                Main2.Show()
                Me.Visible = False
                Exit Sub
            ElseIf CheckUsers.Rows.Count = 0 Then
                Frm_Critical.Show()
                If ComboLang.Text = "th-TH" Then
                    Frm_Critical.head_Label.Text = "รหัสผ่านไม่ถูกต้อง"
                Else
                    Frm_Critical.head_Label.Text = "Login failed!!"
                End If
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
            If ComboLang.Text = "th-TH" Then
                Frm_Critical.head_Label.Text = "รหัสผ่านอย่างน้อย 4 ตัว"
            Else
                Frm_Critical.head_Label.Text = "Login failed!!"
            End If
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Btn Login 
        Dim PasswordCheck As String = txt_password.Text
        If PasswordCheck = "" Then
            Frm_Critical.Show()
            If ComboLang.Text = "th-TH" Then
                Frm_Critical.head_Label.Text = "กรุณาใส่รหัสผ่าน"
            Else
                Frm_Critical.head_Label.Text = "Login failed!!"
            End If
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        Dim CheckUsers As DataTable = executesql("SELECT UserId,FirstName,RoleId FROM Users WHERE UserId ='" & UserId & "' AND Passwords='" & PasswordCheck & "' AND Active=1")
        If CheckUsers.Rows.Count > 0 Then
            RoleId = CheckUsers(0)("RoleId")
            'send to ModuleCheckRolesId
            SendRolesId = CheckUsers(0)("RoleId")
            SendUserId = CheckUsers(0)("UserId")
            SendUserName = CheckUsers(0)("FirstName")
            UserName = SendUserName
            UserId = CheckUsers(0)("UserId")
            writeLog("User ID " + CheckUsers(0)("UserId").ToString + " " + CheckUsers(0)("FirstName") + " Login")

            'CamCapture()
            Main2.Show()
            Me.Visible = False
            ModuleCreateDatabase.CheckField()
            Exit Sub
        ElseIf CheckUsers.Rows.Count = 0 Then
            Frm_Critical.Show()
            If ComboLang.Text = "th-TH" Then
                Frm_Critical.head_Label.Text = "รหัสผ่านไม่ถูกต้อง"
            Else
                Frm_Critical.head_Label.Text = "Login failed!!"
            End If
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

    'Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
    '    Dim count_txt As Integer = txt_password.TextLength
    '    Dim newtxt As String = ""
    '    Dim i As Integer = 0
    '    'Dim txt_arr As Array
    '    For i = 1 To (count_txt - 1) Step 1
    '        newtxt = txt_password.Text.Substring(0, i)
    '    Next
    '    txt_password.Clear()
    '    txt_password.Text = newtxt
    'End Sub

    'Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
    '    txt_password.Clear()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    'Me.Close()
    '    FrmCreateDataBase2.Show()
    'End Sub

    Private Sub ComboLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLang.SelectedIndexChanged
        'Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(sender.selectedItem)
        'Dim res As ComponentResourceManager = New ComponentResourceManager(Me.GetType)
        'For Each aControl As Control In Me.Controls
        '    res.ApplyResources(aControl, aControl.Name)
        'Next
        'For Each aControl As Control In panel_number.Controls
        '    res.ApplyResources(aControl, aControl.Name)
        'Next
        'For Each aControl As Control In PanelUsers.Controls
        '    res.ApplyResources(aControl, aControl.Name)
        'Next
        If ComboLang.Text = "th-TH" Then
            language = 0
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "language", "th-TH")
            change_to_th_text()
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\iEasyPOS\POS", "language", "en-US")
            language = 1
            change_to_eng_text()
        End If

        'Dim culture As CultureInfo
        'If ComboLang.Text = "th-TH" Then
        '    Console.WriteLine("language TH")
        '    language = 0
        '    culture = New CultureInfo("th-TH")
        'ElseIf ComboLang.Text = "en-US" Then
        '    Console.WriteLine("language EN")
        '    language = 1
        '    culture = New CultureInfo("en-US")
        'Else
        '    language = 0
        '    culture = New CultureInfo("th-TH")
        'End If
        'Thread.CurrentThread.CurrentCulture = culture
        'Thread.CurrentThread.CurrentUICulture = culture
    End Sub
    Public Sub checkLang()
        If language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
    End Sub
    Public Sub change_to_eng_text()
        Label1.Text = My.Resources.login_Eng.Label1
        Slide_down.Text = My.Resources.login_Eng.Slide_down
    End Sub
    Public Sub change_to_th_text()


        Label1.Text = My.Resources.login_Th.Label1
        Slide_down.Text = My.Resources.login_Th.Slide_down
    End Sub




    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Picturebox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Picturebox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Picturebox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub Frm_Login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Frm_Login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Frm_Login_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txt_password.Clear()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
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

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        txt_password.Text = ""
        txt_password.Select()
    End Sub

    Private Sub Slide_down_Click(sender As Object, e As EventArgs) Handles Slide_down.Click
        Frm_select_host.Show()
    End Sub
End Class
