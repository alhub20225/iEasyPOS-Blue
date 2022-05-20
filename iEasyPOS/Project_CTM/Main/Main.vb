Imports System.IO
Public Class Main
    Public SendTypeSale As String = ""
    Sub LoadBtnCloseShift()
        Dim TerminalName As String = Environment.MachineName
        Dim DataShift As DataTable = executesql("SELECT TypeShift,StatusShift FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "')")
        If IsNothing(DataShift) Then
            BtnCloseShift.Visible = False
            Exit Sub
        ElseIf DataShift.Rows.Count = 0 Then
            BtnCloseShift.Visible = False
            Exit Sub
        End If
        If DataShift(0)("TypeShift") = "OPEN" Then
            BtnCloseShift.Visible = True
        ElseIf DataShift(0)("TypeShift") = "CLOSE" Then
            BtnCloseShift.Visible = False
        End If
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BtnShowFrmTable.Visible = False
        'If UserIDver > 0 Then
        '    Frm_Login.UserId = UserIDver
        '    LbUserName.Text = verify.UserName_verify
        '    ModuleCheckRoles.CheckRolesUserAuthority()
        'Else
        '    ModuleCheckRoles.CheckRolesUserAuthority()
        '    LbUserName.Text = Frm_Login.SendUserName
        'End If
        LbUserName.Text = Frm_Login.SendUserName
        ModuleCheckRoles.CheckRolesUserAuthority()
        LoadBtnCloseShift()
        'UseTable()
        Timer1.Start()


    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        POS.Show()
    End Sub

    Private Sub Close_main_Click(sender As Object, e As EventArgs) Handles Close_main.Click
        Main_close_Dialog.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSettigProgram.Click
        Setting.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnShowFrmTable.Click
        Dim TerminalName As String = Environment.MachineName
        Dim DataShift As DataTable = executesql("SELECT TypeShift,StatusShift FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "')")
        If IsNothing(DataShift) Then
            SendTypeSale = "Table"
            Frm_OpenShift.Show()
            Exit Sub
        ElseIf DataShift.Rows.Count = 0 Then
            SendTypeSale = "Table"
            Frm_OpenShift.Show()
            Exit Sub
        End If
        If DataShift(0)("TypeShift") = "OPEN" Then
            Table.Close()
            'FloorPlan.Show()
            Table.Show()
        ElseIf DataShift(0)("TypeShift") = "CLOSE" Then
            SendTypeSale = "Table"
            Frm_OpenShift.Show()
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles BtnShowFrmPos.Click
        TableId = 0
        GetSaleId = 0
        Dim TerminalName As String = Environment.MachineName
        Dim DataShift As DataTable = executesql("SELECT TypeShift,StatusShift FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "')")
        If IsNothing(DataShift) Then
            SendTypeSale = "POS"
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Frm_OpenShift.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                Frm_OpenShift.StartPosition = FormStartPosition.CenterParent
                Frm_OpenShift.ShowDialog(plexi)
            End Using
            'Frm_OpenShift.Show()
            Exit Sub
        ElseIf DataShift.Rows.Count = 0 Then
            SendTypeSale = "POS"
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Frm_OpenShift.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                Frm_OpenShift.StartPosition = FormStartPosition.CenterParent
                Frm_OpenShift.ShowDialog(plexi)
            End Using
            'Frm_OpenShift.Show()
            Exit Sub
        End If
        If DataShift(0)("TypeShift") = "OPEN" Then
            POS.Show()
        ElseIf DataShift(0)("TypeShift") = "CLOSE" Then
            SendTypeSale = "POS"
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Frm_OpenShift.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                Frm_OpenShift.StartPosition = FormStartPosition.CenterParent
                Frm_OpenShift.ShowDialog(plexi)
            End Using
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_show.Text = Now.ToShortDateString
        timer.Text = TimeOfDay
    End Sub

    Private Sub Top_tap_Click(sender As Object, e As EventArgs) Handles Top_tap.Click

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        Frm_Login.Show()
        Frm_Login.panel_number.Visible = False
        Frm_Login.PanelUsers.Visible = True
        Frm_Login.txt_password.Text = ""
        Frm_Login.LabelUser.Text = ""
        Frm_Login.UserId = 0
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles BtnFrmManageCustomerShow.Click
        ManageCustomers.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BtnShowFrmReport_Click(sender As Object, e As EventArgs) Handles BtnShowFrmReport.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Frm_Report.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            Frm_Report.StartPosition = FormStartPosition.CenterParent
            Frm_Report.ShowDialog(plexi)
        End Using
        'Frm_Report.Show()
        'FrmReportDay.Show()
    End Sub
    Private Sub BtnShowFrmItem_Click(sender As Object, e As EventArgs) Handles BtnShowFrmItem.Click
        Item.Show()
    End Sub
    Private Sub BtnFrmCategoryShow_Click(sender As Object, e As EventArgs) Handles BtnFrmCategoryShow.Click
        category.Show()
    End Sub
    Private Sub BtnFrmMaterialShow_Click(sender As Object, e As EventArgs) Handles BtnFrmMaterialShow.Click
        Material.Close()
        Material.Show()
    End Sub
    Private Sub BtnShowFrmInventory_Click(sender As Object, e As EventArgs) Handles BtnShowFrmInventory.Click
        inventory.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Frm_PunchTheClock.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Market.Show()
    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Top_tap_MouseDown(sender As Object, e As MouseEventArgs) Handles Top_tap.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Top_tap_MouseUp(sender As Object, e As MouseEventArgs) Handles Top_tap.MouseUp
        drag = False
    End Sub

    Private Sub Top_tap_MouseMove(sender As Object, e As MouseEventArgs) Handles Top_tap.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub BtnTimeCard_Click(sender As Object, e As EventArgs) Handles BtnTimeCard.Click
        'Frm_PunchTheClock.Close()
        Frm_PunchTheClock.Show()
    End Sub
    Sub UseTable()
        Dim GetSetting As DataTable = executesql("Select SettingValue From Setting Where SettingId=8")
        If GetSetting(0)("SettingValue") = 1 Then
            BtnShowFrmTable.Visible = True
        Else
            BtnShowFrmTable.Visible = False
        End If
    End Sub

    Private Sub BtnFrmRePrintBill_Click(sender As Object, e As EventArgs) Handles BtnFrmRePrintBill.Click
        'Frm_RecallBill.Close()
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Frm_RecallBill.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            Frm_RecallBill.StartPosition = FormStartPosition.CenterParent
            Frm_RecallBill.ShowDialog(plexi)
        End Using
        'Frm_RecallBill.Show()
    End Sub
    Private Sub BtnCloseShift_Click(sender As Object, e As EventArgs) Handles BtnCloseShift.Click
        'Frm_CloseShift.Close()
        'Using plexi = New Form()
        '    plexi.FormBorderStyle = FormBorderStyle.None
        '    plexi.Bounds = Screen.FromPoint(Frm_CloseShift.Location).Bounds
        '    plexi.StartPosition = FormStartPosition.Manual
        '    plexi.AutoScaleMode = AutoScaleMode.None
        '    plexi.ShowInTaskbar = False
        '    plexi.BackColor = Color.Black
        '    plexi.Opacity = 0.7
        '    plexi.Show()
        '    Frm_CloseShift.StartPosition = FormStartPosition.CenterParent
        '    Frm_CloseShift.ShowDialog(plexi)
        'End Using
        Frm_CloseShift.Show()
    End Sub
End Class