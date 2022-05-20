Imports System.Data.SqlClient
Imports DevExpress.XtraTab

Public Class Main2
    Dim SendTypeSale As String = ""
    Private Sub Main2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSale()
        Timer1.Start()
        CheckDataShitf()
        LoadBtnCloseShift()
        CheckRolesUserMain2()
        Dim GetSetting As DataTable = executesql("Select SettingValue From Setting Where SettingId=8")
        If GetSetting(0)("SettingValue") = 1 Then
            XtraTabPage2.PageVisible = True
        Else
            XtraTabPage2.PageVisible = False
        End If

        Dim BranchData As DataTable = executesql("SELECT BranchName FROM Branch")

        If BranchData.Rows.Count = 0 Then
            BtnBranchTopPage.Text = ""
        Else
            BtnBranchTopPage.Text = BranchData(0)("BranchName")
        End If

        BtnUserName.Text = Frm_Login.SendUserName
        TabControlMain.SelectedTabPageIndex = 0
        LabelPageName.Text = "ขายสินค้า"
        POS.TopLevel = False
        POS.Panel11.Visible = False
        XtraTabPage1.Controls.Add(POS)
        POS.Show()
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnClosing(e)
        My.Settings.Panel_POS_size = POS.Panel1.Size
        My.Settings.Split1_panel1 = POS.Panel14.Size
        My.Settings.Save()
    End Sub

    Private Sub BtnMain2Close_Click(sender As Object, e As EventArgs) Handles BtnMain2Close.Click
        Main_close_Dialog.ShowDialog()
    End Sub

    Private Sub TabControlMain_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles TabControlMain.SelectedPageChanged
        If TabControlMain.SelectedTabPageIndex = 0 Then
            LabelPageName.Text = "ขายสินค้า"
            POS.TopLevel = False
            POS.Panel11.Visible = False
            XtraTabPage1.Controls.Add(POS)
            POS.txtItemCode.Focus()
            POS.Show()
            GetSaleId = 0
        ElseIf TabControlMain.SelectedTabPageIndex = 1 Then
            LabelPageName.Text = "โต๊ะและโซน"
            Table.TopLevel = False
            Table.Top_tap.Visible = False
            Table.txtTableTime.Visible = False
            Table.Button3.Visible = False
            XtraTabPage2.Controls.Add(Table)
            Table.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 2 Then
            LabelPageName.Text = "ค้นบิล"
            Frm_RecallBill.TopLevel = False
            Frm_RecallBill.FormBorderStyle = FormBorderStyle.None
            Frm_RecallBill.PictureBox1.Visible = False
            Frm_RecallBill.Label1.Visible = False
            Frm_RecallBill.LoadData()
            XtraTabPage3.Controls.Add(Frm_RecallBill)
            Frm_RecallBill.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 3 Then
            LabelPageName.Text = "จัดการสินค้า"
            Item.TopLevel = False
            Item.Top_tap.Visible = False
            XtraTabPage4.Controls.Add(Item)
            Item.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 4 Then
            LabelPageName.Text = "จัดการหมวดสินค้า"
            category.TopLevel = False
            category.Top_tap.Visible = False
            XtraTabPage5.Controls.Add(category)
            category.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 5 Then
            LabelPageName.Text = "จัดการคลังสินค้า"
            inventory.TopLevel = False
            inventory.Top_tap.Visible = False
            XtraTabPage6.Controls.Add(inventory)
            inventory.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 6 Then
            LabelPageName.Text = "จัดการวัตถุดิบ"
            Material.TopLevel = False
            Material.Top_tap.Visible = False
            XtraTabPage7.Controls.Add(Material)
            Material.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 7 Then
            LabelPageName.Text = "รายงาน"
            Frm_Report.TopLevel = False
            Frm_Report.Top_tap.Visible = False
            Frm_Report.WindowState = FormWindowState.Maximized
            XtraTabPage8.Controls.Add(Frm_Report)
            Frm_Report.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 8 Then
            LabelPageName.Text = "ข้อมูลลูกค้า"
            ManageCustomers.TopLevel = False
            ManageCustomers.Top_tap.Visible = False
            XtraTabPage9.Controls.Add(ManageCustomers)
            ManageCustomers.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 9 Then
            LabelPageName.Text = "ลงเวลาเข้างาน"
            Frm_PunchTheClock.TopLevel = False
            Frm_PunchTheClock.PictureBox1.Visible = False
            Frm_PunchTheClock.Label1.Visible = False
            Frm_PunchTheClock.Close_PunchTime.Visible = False
            Frm_PunchTheClock.FormBorderStyle = FormBorderStyle.None
            XtraTabPage10.Controls.Add(Frm_PunchTheClock)
            Frm_PunchTheClock.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 10 Then
            LabelPageName.Text = "ตั้งค่า"
            Setting.TopLevel = False
            Setting.Top_tap.Visible = False
            XtraTabPage11.Controls.Add(Setting)
            Setting.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 11 Then
            LabelPageName.Text = "โปโมชั่น"
            FrmManagePoint.TopLevel = False
            TabPagePoint.Controls.Add(FrmManagePoint)
            FrmManagePoint.Show()
            FrmManagePromotion.TopLevel = False
            TabPagePromotion.Controls.Add(FrmManagePromotion)
            FrmManagePromotion.Show()
        End If
    End Sub

    Private Sub BtnUserName_Click(sender As Object, e As EventArgs) Handles BtnUserName.Click
        Me.Close()
        Frm_Login.Show()
        Frm_Login.panel_number.Visible = False
        Frm_Login.PanelUsers.Visible = True
        Frm_Login.txt_password.Text = ""
        Frm_Login.LabelUser.Text = ""
        Frm_Login.UserId = 0
    End Sub

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
    Sub CheckDataShitf()
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
            Exit Sub
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

    Private Sub BtnCloseShift_Click(sender As Object, e As EventArgs) Handles BtnCloseShift.Click
        Frm_CloseShift.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTime.Text = TimeOfDay
    End Sub

    'check DB form App
    Private Function DoesUserHavePermission() As Boolean

        Try
            Dim clientPermission As SqlClientPermission = New SqlClientPermission(Security.Permissions.PermissionState.Unrestricted)

            ' this will throw an error if the user does not have the permissions
            clientPermission.Demand()

            Return True

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function
    Public Sub getSale()
        If Not DoesUserHavePermission() Then
            Return
        End If

        SaleList.Items.Clear()

        ' You must stop the dependency before starting a new one.
        ' You must start the dependency when creating a new one.
        SqlDependency.Stop(strcon)
        SqlDependency.Start(strcon)

        Using cn As SqlConnection = New SqlConnection(strcon)

            Using cmd As SqlCommand = cn.CreateCommand()

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT SaleId FROM dbo.[SaleItem] where StatusPrint = 0 and Active = 1"

                cmd.Notification = Nothing

                ' creates a new dependency for the SqlCommand
                Dim dep As SqlDependency = New SqlDependency(cmd)
                ' creates an event handler for the notification of data changes in the database
                AddHandler dep.OnChange, AddressOf dep_onchange

                cn.Open()

                Using dr As SqlDataReader = cmd.ExecuteReader()

                    While dr.Read()

                        SaleList.Items.Add(dr.GetInt32(0))
                        GetSaleId = dr.GetInt32(0)
                        ModulePrinrOrder.PrinteOrder()

                    End While

                End Using

            End Using

        End Using
    End Sub


    Private Sub dep_onchange(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlNotificationEventArgs)

        ' this event is run asynchronously so you will need to invoke to run on the UI thread(if required)
        If Me.InvokeRequired Then

            SaleList.BeginInvoke(New MethodInvoker(AddressOf getSale))

        Else

            getSale()

        End If

        ' this will remove the event handler since the dependency is only for a single notification
        Dim dep As SqlDependency = DirectCast(sender, SqlDependency)
        RemoveHandler dep.OnChange, AddressOf dep_onchange

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        SqlDependency.Stop(strcon)

    End Sub
End Class