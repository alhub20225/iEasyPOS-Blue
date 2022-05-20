Imports System.IO
Imports System.IO.Path
Imports System.IO.File
Imports System.IO.IOException
Imports System.IO.StreamWriter
Imports System.IO.MemoryStream
Imports System.IO.StreamReader
Imports System.Drawing.Imaging
Imports System.Drawing.Image
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.Strings

Public Class Frm_Employee
    Dim userId As Integer
    Dim table As String
    Dim field As String
    Dim where As String
    Dim value As String
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim _cultureTHInfo As New Globalization.CultureInfo("th-TH")
    Private Sub Frm_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadUser()
    End Sub
    Sub loadUser()
        DataGridViewShowUser.Rows.Clear()
        Dim field As String = "Users.UserId,Users.FristName,Roles.RoleName"
        Dim tables As String = "Users INNER JOIN Roles ON Roles.RoleId = Users.RoleId"
        Dim Where As String = "Users.Active=1 AND Roles.RoleId <> 1"

        Dim selectUser As DataTable = executesql("SELECT Users.UserId,Users.FristName,Roles.RoleName FROM Users INNER JOIN Roles ON Roles.RoleId = Users.RoleId  WHERE Users.Active=1")
        For i As Integer = 0 To selectUser.Rows.Count - 1
            DataGridViewShowUser.Rows.Add(selectUser(i)("UserId"), selectUser(i)("FristName"), selectUser(i)("RoleName"))
        Next
        userId = 0
    End Sub
    Sub loadData()

        Dim selectGender As DataTable = executesql("SELECT GenderId,GenderName FROM Gender")
        If selectGender.Rows.Count = 0 Then
        Else
            'For i As Integer = 0 To selectGender.Rows.Count - 1
            '    ComboBoxGenger.Items.Add(selectGender(i)("GenderName"))
            'Next
            ComboBoxGenger.DataSource = selectGender
            ComboBoxGenger.DisplayMember = "GenderName"
            ComboBoxGenger.ValueMember = "GenderId"
        End If


        Dim selectNationality As DataTable = executesql("SELECT NationalityId,NationalityNameTH FROM Nationality")
        If selectNationality.Rows.Count = 0 Then
        Else
            ComboBoxNationality.DataSource = selectNationality
            ComboBoxNationality.DisplayMember = "NationalityNameTH"
            ComboBoxNationality.ValueMember = "NationalityId"
        End If

        Dim selectRole As DataTable = executesql("SELECT RoleId,RoleName FROM Roles")
        If selectRole.Rows.Count = 0 Then
        Else
            ComboBoxRole.DataSource = selectRole
            ComboBoxRole.DisplayMember = "RoleName"
            ComboBoxRole.ValueMember = "RoleId"
        End If

        Dim selectPayType As DataTable = executesql("SELECT PayTypeId,PayTypeNameTH FROM PayType WHERE PayTypeNameTH<>'แรง'")
        If selectPayType.Rows.Count = 0 Then
        Else
            'ComboBoxUnit.Items.Clear()
            'For i As Integer = 0 To selectPayType.Rows.Count - 1
            '    ComboBoxUnit.Items.Add(selectPayType(i)("PayTypeNameTH"))
            'Next
            ComboBoxUnit.DataSource = selectPayType
            ComboBoxUnit.DisplayMember = "PayTypeNameTH"
            ComboBoxUnit.ValueMember = "PayTypeId"
        End If


        Dim selectOverTimePayType As DataTable = executesql("SELECT PayTypeId,PayTypeNameTH FROM PayType WHERE PayTypeNameTH<>('เดือน') AND PayTypeNameTH<>('วัน')")
        If selectOverTimePayType.Rows.Count = 0 Then
        Else
            'For i As Integer = 0 To selectOverTimePayType.Rows.Count - 1
            '    ComboBoxUnit2.Items.Add(selectOverTimePayType(i)("PayTypeNameTH"))
            'Next
            ComboBoxUnit2.DataSource = selectOverTimePayType
            ComboBoxUnit2.DisplayMember = "PayTypeNameTH"
            ComboBoxUnit2.ValueMember = "PayTypeId"
        End If

        Dim selectDiligenceType As DataTable = executesql("SELECT PayTypeId,PayTypeNameTH FROM PayType WHERE PayTypeNameTH<>'แรง'")
        If selectOverTimePayType.Rows.Count = 0 Then
        Else
            'For i As Integer = 0 To selectDiligenceType.Rows.Count - 1
            '    ComboBoxUnit3.Items.Add(selectDiligenceType(i)("PayTypeNameTH"))
            'Next
            ComboBoxUnit3.DataSource = selectDiligenceType
            ComboBoxUnit3.DisplayMember = "PayTypeNameTH"
            ComboBoxUnit3.ValueMember = "PayTypeId"
        End If


        Dim selectBreak As DataTable = executesql("SELECT BreakId,BreakName FROM Breaks")
        If selectBreak.Rows.Count = 0 Then
        Else
            ComboBoxBreak.DataSource = selectBreak
            ComboBoxBreak.DisplayMember = "BreakName"
            ComboBoxBreak.ValueMember = "BreakId"
        End If

        Dim selectDay As DataTable = executesql("SELECT DayId,DayTH FROM DayOfWeek")
        For i As Integer = 0 To selectDay.Rows.Count - 1
            Dim ShowDay As New CheckBox
            ShowDay.Text = selectDay(i)("DayTH")
            ShowDay.Name = selectDay(i)("DayId")
            ShowDayOfWeek.Controls.Add(ShowDay)
        Next


        Dim selectWorkType As DataTable = executesql("SELECT WorkTypeId,WorkTypeName FROM WorkType")
        If selectWorkType.Rows.Count = 0 Then
        Else
            'For i As Integer = 0 To selectWorkType.Rows.Count - 1
            '    ComboBoxWorkType.Items.Add(selectWorkType(i)("WorkTypeName"))
            'Next
            ComboBoxWorkType.DataSource = selectWorkType
            ComboBoxWorkType.DisplayMember = "WorkTypeName"
            ComboBoxWorkType.ValueMember = "WorkTypeId"
        End If
        'DateTimePicker_BirthDate.MaxDate = Date.Today
        txtWorkStartDate.Text = "0 ปี 0 เดือน 0 วัน"
    End Sub
    Sub clearText()
        txtEmployeeFullName.Clear()
        txtEmployeeLastName.Clear()
        txtNickName.Clear()
        txtCardID.Clear()
        txtAddress.Clear()
        txtPhone1.Clear()
        txtPhone2.Clear()
        txtPhone3.Clear()
        txtPay.Clear()
        txtOverTimePay.Clear()
        txtDiligence.Clear()
        txtEmail.Clear()
        DateTimePicker_BirthDate.Value = Date.Today()
        Dim Chk As CheckBox
        For Each Chk In ShowDayOfWeek.Controls
            Chk.Checked = False
        Next
        txtWorkStartDate.Text = "0 ปี 0 เดือน 0 วัน"
        BrowsImageUsers.Controls.Clear()
        PictureUsersResize.BackgroundImage = Nothing
        userId = 0
    End Sub
    Private Sub DataGridViewShowUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowUser.CellClick
        PictureUsersResize.BackgroundImage = Nothing
        userId = DataGridViewShowUser.CurrentRow.Cells(0).Value

        Dim selecUserFromDataGridView As DataTable = executesql("SELECT Users.UserId,Users.FristName,Users.LastName,Users.BirthDay,Users.Phone,Users.Phone2,Users.Phone3,Users.NickName,Users.CardId,Users.Email,Gender.GenderName,Users.Address,WorkType.WorkTypeName,Users.WorkStartDate,Users.Pay,Users.PayTypeId,Users.OverTimePay,Users.OverTimePayTypeId,Users.Diligence,Users.DiligenceTypeId,Breaks.BreakName,Roles.RoleName,Nationality.NationalityNameTH,Users.Image FROM Users INNER JOIN Roles ON Roles.RoleId=Users.RoleId INNER JOIN Gender ON Gender.GenderId=Users.GenderId INNER JOIN Nationality ON Nationality.NationalityId=Users.NationalityId INNER JOIN Breaks ON Breaks.BreakId=Users.BreakId INNER JOIN WorkType ON WorkType.WorkTypeId = Users.WorkTypeId WHERE Users.Active='1' AND Users.UserId='" & userId & "'")
        If IsDBNull(selecUserFromDataGridView(0)("FristName")) Then
            txtEmployeeFullName.Text = ""
        Else
            txtEmployeeFullName.Text = selecUserFromDataGridView(0)("FristName")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("LastName")) Then
            txtEmployeeLastName.Text = ""
        Else
            txtEmployeeLastName.Text = selecUserFromDataGridView(0)("LastName")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("NickName")) Then
            txtNickName.Text = ""
        Else
            txtNickName.Text = selecUserFromDataGridView(0)("NickName")
        End If
        'Dim birthDay As DateTime = Convert.ToDateTime(selecUserFromDataGridView(0)("BirthDay"), _cultureEnInfo)
        Dim birthDay As DateTime

        If IsDBNull(selecUserFromDataGridView(0)("BirthDay")) Then
            DateTimePicker_BirthDate.Value = Date.Today()
        Else
            birthDay = Convert.ToDateTime(selecUserFromDataGridView(0)("BirthDay"), _cultureEnInfo)
            DateTimePicker_BirthDate.Value = birthDay
        End If
        Dim workStartDate As DateTime
        If IsDBNull(selecUserFromDataGridView(0)("WorkStartDate")) Then
            DateTimePicker_WorkStart.Value = Date.Today()
        Else
            workStartDate = Convert.ToDateTime(selecUserFromDataGridView(0)("WorkStartDate"), _cultureEnInfo)
            DateTimePicker_WorkStart.Value = workStartDate
        End If
        txtWorkStartDate.Text = 543 - DateDiff(DateInterval.Year, CDate(Date.Now), CDate(workStartDate)) & "ปี"

        'คำนวณวัน
        Dim dayThisYear As New Date(Date.Today.Year, Me.DateTimePicker_WorkStart.Value.Month, Me.DateTimePicker_WorkStart.Value.Day)
        Dim years = Date.Today.Year - Me.DateTimePicker_WorkStart.Value.Year
        Dim months = Date.Today.Month - Me.DateTimePicker_WorkStart.Value.Month
        Dim days = Date.Today.Day - Me.DateTimePicker_WorkStart.Value.Day
        If dayThisYear > Date.Today Then
            years -= 1
            months += 12
        End If
        If dayThisYear.Day > Date.Today.Day Then
            Dim dt As New Date(dayThisYear.Year, DateTime.Today.Month - 1, dayThisYear.Day)
            Dim ts As TimeSpan = Date.Today - dt
            months -= 1
            days = ts.Days
        End If
        txtWorkStartDate.Text = String.Format("{0} ปี {1} เดือน {2} วัน", years.ToString, months.ToString, days.ToString)
        If IsDBNull(selecUserFromDataGridView(0)("CardId")) Then
            txtCardID.Text = ""
        Else
            txtCardID.Text = selecUserFromDataGridView(0)("CardId")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Address")) Then
            txtAddress.Text = ""
        Else
            txtAddress.Text = selecUserFromDataGridView(0)("Address")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Phone")) Then
            txtPhone1.Text = ""
        Else
            txtPhone1.Text = selecUserFromDataGridView(0)("Phone")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Phone2")) Then
            txtPhone2.Text = ""
        Else
            txtPhone2.Text = selecUserFromDataGridView(0)("Phone2")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Phone3")) Then
            txtPhone3.Text = ""
        Else
            txtPhone3.Text = selecUserFromDataGridView(0)("Phone3")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Email")) Then
            txtEmail.Text = ""
        Else
            txtEmail.Text = selecUserFromDataGridView(0)("Email")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Pay")) Then
            txtPay.Text = ""
        Else
            txtPay.Text = selecUserFromDataGridView(0)("Pay")
        End If

        If IsDBNull(selecUserFromDataGridView(0)("OverTimePay")) Then
            txtOverTimePay.Text = ""
        Else
            txtOverTimePay.Text = selecUserFromDataGridView(0)("OverTimePay")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("Diligence")) Then
            txtDiligence.Text = ""
        Else
            txtDiligence.Text = selecUserFromDataGridView(0)("Diligence")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("WorkTypeName")) Then
            ComboBoxWorkType.Text = ""
        Else
            ComboBoxWorkType.Text = selecUserFromDataGridView(0)("WorkTypeName")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("GenderName")) Then
            ComboBoxGenger.Text = ""
        Else
            ComboBoxGenger.Text = selecUserFromDataGridView(0)("GenderName")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("NationalityNameTH")) Then
            ComboBoxNationality.Text = ""
        Else
            ComboBoxNationality.Text = selecUserFromDataGridView(0)("NationalityNameTH")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("RoleName")) Then
            ComboBoxRole.Text = ""
        Else
            ComboBoxRole.Text = selecUserFromDataGridView(0)("RoleName")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("BreakName")) Then
            ComboBoxBreak.Text = ""
        Else
            ComboBoxBreak.Text = selecUserFromDataGridView(0)("BreakName")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("PayTypeId")) Then
            ComboBoxUnit.Text = ""
        Else
            Dim payType As DataTable = executesql("Select PayTypeNameTH As Unit1 FROM PayType WHERE PayTypeId='" & selecUserFromDataGridView(0)("PayTypeId") & "'")
            ComboBoxUnit.Text = payType(0)("Unit1")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("OverTimePayTypeId")) Then
            ComboBoxUnit2.Text = ""
        Else
            Dim overTimePayType As DataTable = executesql("SELECT PayTypeNameTH As Unit2 FROM PayType WHERE PayTypeId='" & selecUserFromDataGridView(0)("OverTimePayTypeId") & "'")
            ComboBoxUnit2.Text = overTimePayType(0)("Unit2")
        End If
        If IsDBNull(selecUserFromDataGridView(0)("DiligenceTypeId")) Then
            ComboBoxUnit3.Text = ""
        Else
            Dim diligenceType As DataTable = executesql("SELECT PayTypeNameTH As Unit3 FROM PayType WHERE PayTypeId='" & selecUserFromDataGridView(0)("DiligenceTypeId") & "'")
            ComboBoxUnit3.Text = diligenceType(0)("Unit3")
        End If


        If selecUserFromDataGridView.Rows.Count = 0 Then
            
            Dim selectDayOfWork As DataTable = executesql("SELECT DayId FROM DayOfWork WHERE UserId='" & selecUserFromDataGridView(0)("UserId") & "' AND Active=1")
            'ShowDayOfWeek.Controls.Clear()
            Dim checkBox As CheckBox
            For Each checkBox In ShowDayOfWeek.Controls
                checkBox.Checked = False
                For i As Integer = 0 To selectDayOfWork.Rows.Count - 1
                    If checkBox.Name = selectDayOfWork(i)("DayId") Then
                        checkBox.Checked = False
                    End If
                Next
            Next
        Else
            For Each checkBox In ShowDayOfWeek.Controls

                Dim selectDayOfWork As DataTable = executesql("Select DayId From DayOfWork Where UserId='" & selecUserFromDataGridView(0)("UserId") & "' AND Active=1")
                checkBox.Checked = False
                For i As Integer = 0 To selectDayOfWork.Rows.Count - 1
                    If checkBox.Name = selectDayOfWork(i)("DayId") Then
                        checkBox.Checked = True
                    End If
                Next

            Next
        End If



        Try

            If selecUserFromDataGridView.Rows.Count = 0 Then
                PictureUsersResize.BackgroundImage = Nothing
                Exit Sub
            Else
                'Convert Base64String To Image 
                Dim img As System.Drawing.Image
                Dim Ms As System.IO.MemoryStream = New System.IO.MemoryStream
                Dim b() As Byte
                'Convert Base64 encoded msg To Image Data 
                b = Convert.FromBase64String(selecUserFromDataGridView(0)("Image"))
                Ms = New System.IO.MemoryStream(b)
                'Create Image 
                img = System.Drawing.Image.FromStream(Ms)
                PictureUsersResize.BackgroundImage = img
                PictureUsersResize.BackgroundImageLayout = ImageLayout.Stretch
            End If
        Catch ex As Exception

        End Try
        'clearText()
        'userId = 0
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Dim checkUser As DataTable = executesql("SELECT UserId FROM Users WHERE CardId='" & txtCardID.Text & "' AND Active='1'")
        If txtEmployeeFullName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ", MsgBoxStyle.Critical)
            txtEmployeeFullName.Focus()
            Exit Sub
        End If
        If txtEmployeeLastName.Text = "" Then
            MsgBox("กรุณากรอกนามสกุล", MsgBoxStyle.Critical)
            txtEmployeeLastName.Focus()
            Exit Sub
        End If
        If txtNickName.Text = "" Then
            MsgBox("กรุณากรอกชื่อเล่น", MsgBoxStyle.Critical)
            txtNickName.Focus()
            Exit Sub
        End If
        If txtCardID.Text = "" Then
            MsgBox("กรุณากรอกหมายเลขบัตรประชาชน / หนังสือเดินทาง / บัตรต่างด้าว", MsgBoxStyle.Critical)
            txtNickName.Focus()
            Exit Sub
        End If
        If txtPhone1.Text = "" Then
            MsgBox("กรุณากรอกหมายเลขโทรศัทพ์ อย่างน้อย 1 หมายเลข", MsgBoxStyle.Critical)
            txtPhone1.Focus()
            Exit Sub
        End If
        If txtEmail.Text.IndexOf("@") = -1 OrElse txtEmail.Text.IndexOf(".") = -1 Then
            MsgBox("กรุณากรอกอีเมลให้ถูกต้อง", MsgBoxStyle.Critical)
            txtEmail.Focus()
            Exit Sub
        End If
        Dim imageUser As String = ImageBase64String
        If userId = 0 Then
            If checkUser.Rows.Count > 0 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "มีหมายเลขบัตรประชาชน / หนังสือเดินทาง / บัตรต่างด้าว แล้ว"
                Frm_Critical.TableOkCancel.Visible = False
                txtCardID.Focus()
                Exit Sub
            End If
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ต้องการเพิ่มพนักงานหรือใหม่"
                Frm_Critical.TableOkCancel.Visible = True
                Frm_Critical.Accep_Button.Visible = False
            If Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK Then
                '//////////////////////////////////////////////////////////////////////////////
            End If
        Else
            Dim birthDay As String
            birthDay = DateTimePicker_BirthDate.Value.ToString("yyyy-MM-dd", _cultureEnInfo)
            Dim workTime As String
            workTime = DateTimePicker_BirthDate.Value.ToString("yyyy-MM-dd", _cultureEnInfo)
            Dim DateNow As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            DateNow = DateTimePicker_BirthDate.Value.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo)

            executesql("UPDATE Users SET FristName='" & txtEmployeeFullName.Text & "',LastName='" & txtEmployeeLastName.Text & "',NickName='" & txtNickName.Text & "',BirthDay='" & Format(DateTimePicker_BirthDate.Value, "yyyy-MM-dd") & "',Email='" & txtEmail.Text & "',CardId='" & txtCardID.Text & "',GenderId='" & ComboBoxGenger.SelectedValue & "',NationalityId='" & ComboBoxNationality.SelectedValue & "',Address='" & txtAddress.Text & "',Phone='" & txtPhone1.Text & "',Phone2='" & txtPhone2.Text & "',Phone3='" & txtPhone3.Text & "',RoleId='" & ComboBoxRole.SelectedValue & "',WorkTypeId='" & ComboBoxWorkType.SelectedValue & "',WorkStartDate='" & Format(DateTimePicker_WorkStart.Value, "yyyy-MM-dd") & "',Pay=" & txtPay.Text & ",PayTypeId=" & ComboBoxUnit.SelectedValue & ",OverTimePay=" & txtOverTimePay.Text & ",OverTimePayTypeId=" & ComboBoxUnit2.SelectedValue & ",Diligence=" & txtDiligence.Text & ",DiligenceTypeId=" & ComboBoxUnit3.SelectedValue & ",BreakId=" & ComboBoxBreak.SelectedValue & ",UpdateDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' WHERE UserId='" & userId & "'")

            Dim CheckDateOfWorkUpdate As DataTable = executesql("SELECT UserId,DayId,Active FROM DayOfWork WHERE UserId='" & userId & "'")
            Dim CheckBoxUpdate As CheckBox
            For Each CheckBoxUpdate In ShowDayOfWeek.Controls
                If CheckBoxUpdate.Checked Then
                    For i As Integer = 0 To 6
                        If CheckBoxUpdate.Name = CheckDateOfWorkUpdate(i)("DayId") Then

                            executesql("UPDATE DayOfWork SET Active='1' WHERE userId='" & userId & "' AND DayId='" & CheckBoxUpdate.Name & "'")
                        End If
                    Next
                Else
                    For a As Integer = 0 To 6

                        executesql("UPDATE DayOfWork SET Active='0' WHERE userId='" & userId & "' AND DayId='" & CheckBoxUpdate.Name & "'")
                    Next
                End If
            Next
            If BrowsImageUsers.Value = Nothing Then
            ElseIf imageUser <> "" Then

                executesql("update users set Image='" & imageUser & "' WHERE UserId='" & userId & "'")
            End If
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
            clearText()
            loadData()
        End If
    End Sub
    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        'Resize Image 
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = IIf(percentHeight < percentWidth, percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        PictureUsersResize.BackgroundImage = newImage
        PictureUsersResize.BackgroundImageLayout = ImageLayout.Stretch
        'Create Folder
        If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
        End If
        'Save Files
        Dim Newpath As String = "C:\ImageFilesPOS\"
        Dim NewFileName As String = "ItemresizePOS.jpg"
        PictureUsersResize.BackgroundImage.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return newImage
    End Function
    Public Shared ImageBase64String As String
    Private Sub BrowsImageUsers_ValueChanged(sender As Object, e As EventArgs) Handles BrowsImageUsers.ValueChanged
        'Resize Image
        Dim PathFName As String = "C:\ImageFilesPOS\ItemresizePOS.jpg"
        PictureUsersOriginal.Image = Image.FromFile(BrowsImageUsers.Value)
        ResizeImage(PictureUsersOriginal.Image, New Size(200, 250), True)
        'Convert to Base64String 
        Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
        ImageBase64String = Convert.ToBase64String(Imageaaray)
    End Sub
    Public Sub txtPhone1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub txtPhone2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub txtPhone3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPay.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtOverTimePay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOverTimePay.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtDiligence_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiligence.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnClearImage_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        BrowsImageUsers.Controls.Clear()
        PictureUsersResize.BackgroundImage = Nothing
        PictureUsersOriginal.BackgroundImage = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If userId = 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกรายการที่ต้องการลบ"
            Frm_Critical.TableOkCancel.Visible = False

            Exit Sub
        Else
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ต้องการลบข้อมูลหรือไม่"
            Frm_Critical.TableOkCancel.Visible = True
            Frm_Critical.Accep_Button.Visible = False
            If Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK Then

                executesql("UPDATE UserS SET Active=0 WHERE UserId='" & userId & "'")
                clearText()
                loadUser()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Frm_Break.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class