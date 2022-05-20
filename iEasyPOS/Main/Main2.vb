Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel
Public Class Main2
    Dim SendTypeSale As String = ""
    Private Sub Main2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        'Panel2.Visible = False
        'Label13.Image = iEasyPOS.My.Resources.Resources.Icon_ArrowDownWhite

        'Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Frm_Login.ComboLang.Text)
        'Dim res As ComponentResourceManager = New ComponentResourceManager(Me.GetType)
        'If Frm_Login.ComboLang.Text = "en-US" Then
        '    XtraTabPage1.Image = My.Resources.POS
        '    XtraTabPage2.Image = My.Resources.TableZone
        '    XtraTabPage3.Image = My.Resources.Bill
        '    XtraTabPage4.Image = My.Resources.Product
        '    XtraTabPage5.Image = My.Resources.CategoryItem
        '    XtraTabPage6.Image = My.Resources.Inventory
        '    XtraTabPage7.Image = My.Resources.Material
        '    XtraTabPage8.Image = My.Resources.Report
        '    XtraTabPage9.Image = My.Resources.Customer
        '    XtraTabPage10.Image = My.Resources.Staff
        '    XtraTabPage11.Image = My.Resources.Setting
        'End If
        'TabControlMain.SelectedTabPageIndex = 0
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        If SettingList.UsePosTable = 1 Then
            'รูป LOGO
            PictureBox2.Visible = True
            PictureBox4.Visible = False
            Panel5.Location = New Point(127, 22)
            XtraTabPage2.PageVisible = True
            'BtnTable.Visible = True
            'BtnTable.BringToFront()
            'LineTable.Visible = True
            'LineTable.BringToFront()

            TabControlMain.SelectedTabPageIndex = 1
            FrmTable.TopLevel = False
            FrmTable.FormBorderStyle = FormBorderStyle.None
            FrmTable.WindowState = FormWindowState.Maximized
            FrmTable.Dock = DockStyle.Fill
            FrmTable.LoadRefresh()
            XtraTabPage2.Controls.Add(FrmTable)
            FrmTable.Show()
            TableId = 0
            ''ปุ่มโต๊ะ
            'POS.ShowBtnTable.Visible = True
            'POS.Panel28.Visible = True
        Else
            POS.TopLevel = False
            POS.FormBorderStyle = FormBorderStyle.None
            POS.WindowState = FormWindowState.Maximized
            POS.Dock = DockStyle.Fill
            POS.TextBox3.Focus()
            POS.LabelPageName.Text = "ขายสินค้า"
            POS.DataGridViewPOS.Rows.Clear()
            POS.Panel28.Visible = False

            POS.BtnOpenSaveSale.Enabled = True
            POS.txtTotal.Text = FormatNumber(0, 2)
            POS.txtDiscount.Text = FormatNumber(0, 2)
            POS.txtSubTotal.Text = FormatNumber(0, 2)
            POS.Refresh()
            'TableId = 0
            If TableId = 0 Then
                POS.BtnDelSale.Text = "ยกเลิกการขาย"
            Else
                POS.BtnDelSale.Text = "ยกเลิกโต๊ะ"
            End If

            XtraTabPage1.Controls.Add(POS)
            POS.Show()

            If GetSaleId = 0 Then
                POS.DataGridViewPOS.Columns(13).Visible = True
            End If

            'customer
            FrmCustomerMemberNo.CustomerId = 0
            POS.BtnPoint.Enabled = False
            POS.PanelMember.Visible = False
            POS.LabelMemberName.Text = ""
            FrmCustomerMemberNo.customerMemNo = 0
        End If
        XtraTabPage2.PageVisible = False

        CheckRolesUserMain2()
        Timer1.Start()
        CheckDataShitf()
        LoadBtnCloseShift()

        Dim Branch_Data As DataTable = executesql("SELECT BranchName,HqBranchId FROM Branch  where Active=1")

        If Branch_Data.Rows.Count = 0 Then
            BtnBranchTopPage.Text = "<Null>"
        Else
            BtnBranchTopPage.Text = Branch_Data(0)("BranchName")
            Branchdata.id = Branch_Data(0)("HqBranchId")
        End If

        BtnUserName.Text = Frm_Login.SendUserName

        '// เช็คใช้งานวัตถุดิบ
        Console.WriteLine("dataExt.ext_mat " & dataExt.ext_mat)
        If dataExt.ext_mat = 0 Then
            XtraTabPage7.PageVisible = False
        Else
            XtraTabPage7.PageVisible = True
        End If

    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnClosing(e)
        My.Settings.Panel_POS_size = POS.Panel7.Size
        My.Settings.Split1_panel1 = POS.Panel5.Size
        My.Settings.Save()
    End Sub

    Private Sub BtnMain2Close_Click(sender As Object, e As EventArgs)
        writeLog("User ID " + Frm_Login.UserId.ToString + " Close System click")
        Main_close_Dialog.ShowDialog()
    End Sub

    Private Sub TabControlMain_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles TabControlMain.SelectedPageChanged

        If TabControlMain.SelectedTabPageIndex = 0 Then
            POS.TopLevel = False
            POS.FormBorderStyle = FormBorderStyle.None
            POS.WindowState = FormWindowState.Maximized
            POS.Dock = DockStyle.Fill
            POS.TextBox3.Focus()
            POS.LabelPageName.Text = "ขายสินค้า"
            POS.DataGridViewPOS.Rows.Clear()
            POS.Panel28.Visible = False

            POS.BtnOpenSaveSale.Enabled = True
            POS.txtTotal.Text = FormatNumber(0, 2)
            POS.txtDiscount.Text = FormatNumber(0, 2)
            POS.txtSubTotal.Text = FormatNumber(0, 2)
            POS.Refresh()
            'TableId = 0
            If TableId = 0 Then
                POS.BtnDelSale.Text = "ยกเลิกการขาย"
            Else
                POS.BtnDelSale.Text = "ยกเลิกโต๊ะ"
            End If

            XtraTabPage1.Controls.Add(POS)
            POS.Show()

            If GetSaleId = 0 Then
                POS.DataGridViewPOS.Columns(13).Visible = True
            End If

            'customer
            FrmCustomerMemberNo.CustomerId = 0
            POS.BtnPoint.Enabled = False
            POS.PanelMember.Visible = False
            POS.LabelMemberName.Text = ""
            FrmCustomerMemberNo.customerMemNo = 0
        ElseIf TabControlMain.SelectedTabPageIndex = 1 Then
            'โต๊ะ/โซน
            FrmTable.TopLevel = False
            FrmTable.FormBorderStyle = FormBorderStyle.None
            FrmTable.WindowState = FormWindowState.Maximized
            FrmTable.Dock = DockStyle.Fill
            FrmTable.LoadRefresh()
            XtraTabPage2.Controls.Add(FrmTable)
            FrmTable.Show()
            TableId = 0
            'GetSaleId = 0
            POS.txtDiscount.Text = "0.00"

            'customer
            FrmCustomerMemberNo.CustomerId = 0
            POS.BtnPoint.Enabled = False
            POS.PanelMember.Visible = False
            POS.LabelMemberName.Text = ""
            FrmCustomerMemberNo.customerMemNo = 0
        ElseIf TabControlMain.SelectedTabPageIndex = 2 Then
            'ค้นบิล
            Frm_RecallBill.Close()
            Frm_RecallBill.TopLevel = False
            Frm_RecallBill.FormBorderStyle = FormBorderStyle.None
            Frm_RecallBill.WindowState = FormWindowState.Maximized
            Frm_RecallBill.Dock = DockStyle.Fill
            GetSaleId = 0
            Frm_RecallBill.GridView_Sale.ClearSelection()
            Frm_RecallBill.GridView_SaleDetail.Rows.Clear()
            XtraTabPage3.Controls.Add(Frm_RecallBill)
            Frm_RecallBill.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 3 Then
            'สินค้า
            Item.TopLevel = False
            Item.FormBorderStyle = FormBorderStyle.None
            Item.WindowState = FormWindowState.Maximized
            Item.Dock = DockStyle.Fill
            Item.TopLevel = False
            XtraTabPage4.Controls.Add(Item)
            Item.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 4 Then
            'กลุ่มสินค้า
            category.TopLevel = False
            category.FormBorderStyle = FormBorderStyle.None
            category.WindowState = FormWindowState.Maximized
            category.Dock = DockStyle.Fill
            XtraTabPage5.Controls.Add(category)
            category.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 5 Then
            'สต๊อก
            inventory.TopLevel = False
            inventory.FormBorderStyle = FormBorderStyle.None
            inventory.WindowState = FormWindowState.Maximized
            inventory.Dock = DockStyle.Fill
            XtraTabPage6.Controls.Add(inventory)
            inventory.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 6 Then
            'วัตถุดิบ
            Material.TopLevel = False
            Material.FormBorderStyle = FormBorderStyle.None
            Material.WindowState = FormWindowState.Maximized
            Material.Dock = DockStyle.Fill
            XtraTabPage7.Controls.Add(Material)
            Material.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 7 Then
            'รายงาน
            Frm_Report.TopLevel = False
            Frm_Report.FormBorderStyle = FormBorderStyle.None
            Frm_Report.WindowState = FormWindowState.Maximized
            Frm_Report.Dock = DockStyle.Fill
            XtraTabPage8.Controls.Add(Frm_Report)
            Frm_Report.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 8 Then
            'สมาชิก
            ManageCustomers.TopLevel = False
            ManageCustomers.FormBorderStyle = FormBorderStyle.None
            ManageCustomers.WindowState = FormWindowState.Maximized
            ManageCustomers.Dock = DockStyle.Fill
            XtraTabPage9.Controls.Add(ManageCustomers)
            ManageCustomers.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 9 Then
            'พนักงาน
            Frm_PunchTheClock.TopLevel = False
            Frm_PunchTheClock.FormBorderStyle = FormBorderStyle.None
            Frm_PunchTheClock.WindowState = FormWindowState.Maximized
            Frm_PunchTheClock.Dock = DockStyle.Fill
            Frm_PunchTheClock.Label1.Visible = False
            XtraTabPage10.Controls.Add(Frm_PunchTheClock)
            Frm_PunchTheClock.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 10 Then
            'ตั้งค่า
            Setting.TopLevel = False
            Setting.FormBorderStyle = FormBorderStyle.None
            Setting.WindowState = FormWindowState.Maximized
            Setting.Dock = DockStyle.Fill
            XtraTabPage11.Controls.Add(Setting)
            Setting.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 11 Then
            'โปรโมชั่น
            Frm_Promotion.TopLevel = False
            Frm_Promotion.FormBorderStyle = FormBorderStyle.None
            Frm_Promotion.WindowState = FormWindowState.Maximized
            Frm_Promotion.Dock = DockStyle.Fill
            'XtraTabPage12.Controls.Add(Frm_Promotion)
            Frm_Promotion.Show()
        ElseIf TabControlMain.SelectedTabPageIndex = 12 Then
            Main_PrintBarcode.TopLevel = False
            Main_PrintBarcode.FormBorderStyle = FormBorderStyle.None
            Main_PrintBarcode.WindowState = FormWindowState.Maximized
            Main_PrintBarcode.Dock = DockStyle.Fill
            XtraTabPage13.Controls.Add(Main_PrintBarcode)
            Main_PrintBarcode.Show()
        End If


    End Sub

    Private Sub BtnSignout2_Click(sender As Object, e As EventArgs) Handles BtnSignout.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " LogOut click")
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
            BtnCloseShift.Enabled = False
            Exit Sub
        ElseIf DataShift.Rows.Count = 0 Then
            BtnCloseShift.Enabled = False
            Exit Sub
        End If
        If DataShift(0)("TypeShift") = "OPEN" Then
            BtnCloseShift.Enabled = True
        ElseIf DataShift(0)("TypeShift") = "CLOSE" Then
            BtnCloseShift.Enabled = False
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
                plexi.Opacity = 0.6
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
                plexi.Opacity = 0.6
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
                plexi.Opacity = 0.6
                plexi.Show()
                Frm_OpenShift.StartPosition = FormStartPosition.CenterParent
                Frm_OpenShift.ShowDialog(plexi)
            End Using
        End If
    End Sub

    Private Sub BtnCloseShift_Click(sender As Object, e As EventArgs) Handles BtnCloseShift.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " Close click")
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Frm_CloseShift.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Frm_CloseShift.StartPosition = FormStartPosition.CenterParent
            Frm_CloseShift.ShowDialog(plexi)
        End Using
        'Frm_CloseShift.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTime.Text = TimeOfDay
        DateTimePicker1.Text = Now.ToShortDateString
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
                cmd.CommandText = "SELECT SaleId,Active FROM dbo.[SaleItem] where StatusPrint = 0 and Active in (1,3)"
                cmd.Notification = Nothing

                ' creates a new dependency for the SqlCommand
                Dim dep As SqlDependency = New SqlDependency(cmd)
                ' creates an event handler for the notification of data changes in the database
                AddHandler dep.OnChange, AddressOf dep_onchange

                cn.Open()

                Using dr As SqlDataReader = cmd.ExecuteReader()

                    While dr.Read()
                        If dr.GetInt32(1) = 1 Then
                            SaleList.Items.Add(dr.GetInt32(0))
                            GetSaleId = dr.GetInt32(0)
                            ModulePrinrOrder.PrinteOrder(GetSaleId)
                        ElseIf dr.GetInt32(1) = 3 Then
                            SaleList.Items.Add(dr.GetInt32(0))
                            TB_GetSaleId = dr.GetInt32(0)
                            ModulePrinrOrder.PrintOrderTable(TB_GetSaleId, TableName)
                            TB_GetSaleId = 0
                            GetSaleId = 0
                        End If
                    End While

                End Using
                cn.Close()

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

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        writeLog("User ID " + Frm_Login.UserId.ToString + " LogOut click")
        Me.Close()
        Frm_Login.Show()
        Frm_Login.panel_number.Visible = False
        Frm_Login.PanelUsers.Visible = True
        Frm_Login.txt_password.Text = ""
        Frm_Login.LabelUser.Text = ""
        Frm_Login.UserId = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'writeLog("User ID " + Frm_Login.UserId.ToString + " LogOut click")
        Me.Close()
        Frm_Login.Show()
        Frm_Login.panel_number.Visible = False
        Frm_Login.PanelUsers.Visible = True
        Frm_Login.txt_password.Text = ""
        Frm_Login.LabelUser.Text = ""
        Frm_Login.UserId = 0
    End Sub

    Private Sub BtnPOS_Click(sender As Object, e As EventArgs) Handles BtnPOS.Click
        'ขายสินค้า
        TabControlMain.SelectedTabPageIndex = 0
        POS.TopLevel = False
        POS.FormBorderStyle = FormBorderStyle.None
        POS.WindowState = FormWindowState.Maximized
        POS.Dock = DockStyle.Fill
        POS.TextBox3.Focus()
        POS.LabelPageName.Text = "ขายสินค้า"
        POS.DataGridViewPOS.Rows.Clear()
        POS.Panel28.Visible = False

        POS.BtnOpenSaveSale.Enabled = True
        POS.txtTotal.Text = FormatNumber(0, 2)
        POS.txtDiscount.Text = FormatNumber(0, 2)
        POS.txtSubTotal.Text = FormatNumber(0, 2)
        POS.Refresh()
        TableId = 0
        If TableId = 0 Then
            POS.BtnDelSale.Text = "ยกเลิกการขาย"
        Else
            POS.BtnDelSale.Text = "ยกเลิกโต๊ะ"
        End If

        XtraTabPage1.Controls.Add(POS)
        POS.Show()

        'TabControlMain.SelectedTabPageIndex = 0
        'POS.TopLevel = False
        'POS.FormBorderStyle = FormBorderStyle.None
        'POS.WindowState = FormWindowState.Maximized
        'POS.Dock = DockStyle.Fill
        'POS.TextBox3.Focus()
        'POS.DataGridViewPOS.Rows.Clear()
        'POS.LabelPageName.Text = "ขายสินค้า"
        'XtraTabPage1.Controls.Add(POS)
        'POS.Show()
        'ClearDataPayMent()
        'calBalance()
        'TableName = ""
        'TB_GetSaleId = 0
        'GetSaleId = 0
    End Sub

    Private Sub BtnTable_Click(sender As Object, e As EventArgs) Handles BtnTable.Click
        'โต๊ะ/โซน
        TabControlMain.SelectedTabPageIndex = 1
        FrmTable.TopLevel = False
        FrmTable.FormBorderStyle = FormBorderStyle.None
        FrmTable.WindowState = FormWindowState.Maximized
        FrmTable.Dock = DockStyle.Fill
        FrmTable.LoadRefresh()
        XtraTabPage2.Controls.Add(FrmTable)
        FrmTable.Show()
        TableId = 0
        POS.txtDiscount.Text = "0.00"
        ''LabelPageName.Text = "โต๊ะและโซน"
        ''LabelPageName.Text = XtraTabPage2.Text
        'FrmTable.TopLevel = False
        'FrmTable.Top_tap.Visible = False
        'FrmTable.txtTableTime.Visible = False
        'FrmTable.Button3.Visible = False
        'XtraTabPage2.Controls.Add(FrmTable)
        'FrmTable.Show()
        'TableId = 0
    End Sub

    Private Sub BtnRecallBill_Click_1(sender As Object, e As EventArgs) Handles BtnRecallBill.Click
        'ค้นหาบิล
        TabControlMain.SelectedTabPageIndex = 2
        Frm_RecallBill.TopLevel = False
        Frm_RecallBill.FormBorderStyle = FormBorderStyle.None
        Frm_RecallBill.WindowState = FormWindowState.Maximized
        Frm_RecallBill.Dock = DockStyle.Fill
        'Frm_RecallBill.LoadData()
        GetSaleId = 0
        Frm_RecallBill.GridView_Sale.ClearSelection()
        Frm_RecallBill.GridView_SaleDetail.Rows.Clear()
        XtraTabPage3.Controls.Add(Frm_RecallBill)
        Frm_RecallBill.Show()


        ''LabelPageName.Text = "ค้นบิล"
        ''LabelPageName.Text = XtraTabPage3.Text
        'Frm_RecallBill.TopLevel = False
        'Frm_RecallBill.FormBorderStyle = FormBorderStyle.None
        ''Frm_RecallBill.PictureBox1.Visible = False
        ''Frm_RecallBill.Label1.Visible = False
        'Frm_RecallBill.WindowState = FormWindowState.Maximized
        'Frm_RecallBill.LoadData()
        'GetSaleId = 0
        'Frm_RecallBill.GridView_Sale.ClearSelection()
        'Frm_RecallBill.GridView_SaleDetail.Rows.Clear()
        'XtraTabPage3.Controls.Add(Frm_RecallBill)
        'Frm_RecallBill.Show()
    End Sub

    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles BtnItem.Click
        'สินค้า
        TabControlMain.SelectedTabPageIndex = 3
        Item.TopLevel = False
        Item.FormBorderStyle = FormBorderStyle.None
        Item.WindowState = FormWindowState.Maximized
        Item.Dock = DockStyle.Fill
        Item.TopLevel = False
        XtraTabPage4.Controls.Add(Item)
        Item.Show()

        ''LabelPageName.Text = "จัดการสินค้า"
        ''LabelPageName.Text = XtraTabPage4.Text
        'Item.TopLevel = False
        'XtraTabPage4.Controls.Add(Item)
        'Item.Show()
    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles BtnCategory.Click
        'กลุ่มสินค้า
        TabControlMain.SelectedTabPageIndex = 4
        category.TopLevel = False
        category.FormBorderStyle = FormBorderStyle.None
        category.WindowState = FormWindowState.Maximized
        category.Dock = DockStyle.Fill
        'category.Top_tap.Visible = False
        XtraTabPage5.Controls.Add(category)
        category.Show()

        ''LabelPageName.Text = "จัดการหมวดสินค้า"
        ''LabelPageName.Text = XtraTabPage5.Text
        'category.TopLevel = False
        'category.Top_tap.Visible = False
        'XtraTabPage5.Controls.Add(category)
        'category.Show()
    End Sub

    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        'สต๊อก
        TabControlMain.SelectedTabPageIndex = 5
        inventory.TopLevel = False
        inventory.FormBorderStyle = FormBorderStyle.None
        inventory.WindowState = FormWindowState.Maximized
        inventory.Dock = DockStyle.Fill
        XtraTabPage6.Controls.Add(inventory)
        inventory.Show()

        ''LabelPageName.Text = "จัดการคลังสินค้า"
        ''LabelPageName.Text = XtraTabPage6.Text
        'inventory.TopLevel = False
        'XtraTabPage6.Controls.Add(inventory)
        'inventory.Show()
    End Sub

    Private Sub BtnMaterial_Click(sender As Object, e As EventArgs) Handles BtnMaterial.Click
        'วัตถุดิบ
        TabControlMain.SelectedTabPageIndex = 6
        Material.TopLevel = False
        Material.FormBorderStyle = FormBorderStyle.None
        Material.WindowState = FormWindowState.Maximized
        Material.Dock = DockStyle.Fill
        'Material.Top_tap.Visible = False
        XtraTabPage7.Controls.Add(Material)
        Material.Show()

        ''LabelPageName.Text = "จัดการวัตถุดิบ"
        ''LabelPageName.Text = XtraTabPage7.Text
        'Material.TopLevel = False
        'Material.Top_tap.Visible = False
        'XtraTabPage7.Controls.Add(Material)
        'Material.Show()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        'รายงาน
        TabControlMain.SelectedTabPageIndex = 7
        Frm_Report.TopLevel = False
        Frm_Report.FormBorderStyle = FormBorderStyle.None
        Frm_Report.WindowState = FormWindowState.Maximized
        Frm_Report.Dock = DockStyle.Fill
        XtraTabPage8.Controls.Add(Frm_Report)
        Frm_Report.Show()

        'Frm_Report.TopLevel = False
        'Frm_Report.WindowState = FormWindowState.Maximized
        'XtraTabPage8.Controls.Add(Frm_Report)
        'Frm_Report.Show()
    End Sub

    Private Sub BtnManageCustomers_Click(sender As Object, e As EventArgs) Handles BtnManageCustomers.Click
        'สมาชิก
        TabControlMain.SelectedTabPageIndex = 8
        ManageCustomers.TopLevel = False
        ManageCustomers.FormBorderStyle = FormBorderStyle.None
        ManageCustomers.WindowState = FormWindowState.Maximized
        ManageCustomers.Dock = DockStyle.Fill
        'ManageCustomers.Top_tap.Visible = False
        XtraTabPage9.Controls.Add(ManageCustomers)
        ManageCustomers.Show()

        'ManageCustomers.TopLevel = False
        'ManageCustomers.Top_tap.Visible = False
        'XtraTabPage9.Controls.Add(ManageCustomers)
        'ManageCustomers.Show()
    End Sub

    Private Sub BtnPunchTheClock_Click(sender As Object, e As EventArgs) Handles BtnPunchTheClock.Click
        'พนักงาน
        TabControlMain.SelectedTabPageIndex = 9
        Frm_PunchTheClock.TopLevel = False
        Frm_PunchTheClock.FormBorderStyle = FormBorderStyle.None
        Frm_PunchTheClock.WindowState = FormWindowState.Maximized
        Frm_PunchTheClock.Dock = DockStyle.Fill
        'Frm_PunchTheClock.PictureBox1.Visible = False
        Frm_PunchTheClock.Label1.Visible = False
        'Frm_PunchTheClock.Close_PunchTime.Visible = False
        XtraTabPage10.Controls.Add(Frm_PunchTheClock)
        Frm_PunchTheClock.Show()

        'Frm_PunchTheClock.TopLevel = False
        'Frm_PunchTheClock.PictureBox1.Visible = False
        'Frm_PunchTheClock.Label1.Visible = False
        'Frm_PunchTheClock.Close_PunchTime.Visible = False
        'Frm_PunchTheClock.FormBorderStyle = FormBorderStyle.None
        'XtraTabPage10.Controls.Add(Frm_PunchTheClock)
        'Frm_PunchTheClock.Show()
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        'ตั้งค่า
        TabControlMain.SelectedTabPageIndex = 10
        Setting.TopLevel = False
        Setting.FormBorderStyle = FormBorderStyle.None
        Setting.WindowState = FormWindowState.Maximized
        Setting.Dock = DockStyle.Fill
        'Setting.Top_tap.Visible = False
        XtraTabPage11.Controls.Add(Setting)
        Setting.Show()

        'Setting.TopLevel = False
        'Setting.Top_tap.Visible = False
        'XtraTabPage11.Controls.Add(Setting)
        'Setting.Show()
    End Sub

    Private Sub BtnPromotion_Click(sender As Object, e As EventArgs) Handles BtnPromotion.Click
        'โปรโมชั่น
        TabControlMain.SelectedTabPageIndex = 11
        Frm_Promotion.TopLevel = False
        Frm_Promotion.FormBorderStyle = FormBorderStyle.None
        Frm_Promotion.WindowState = FormWindowState.Maximized
        Frm_Promotion.Dock = DockStyle.Fill
        XtraTabPage12.Controls.Add(Frm_Promotion)
        Frm_Promotion.Show()
    End Sub

    Private Sub Panel4_DoubleClick(sender As Object, e As EventArgs) Handles Panel4.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel4_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel4.MouseUp
        drag = False
    End Sub

    Sub change_to_th_text()
        BtnCloseShift.Text = My.Resources.main_th.closeship
        BtnSignout.Text = My.Resources.main_th.logout

        XtraTabPage1.ImageOptions.Image = My.Resources.Icon_NewPOS
        XtraTabPage2.ImageOptions.Image = My.Resources.Icon_NewTable
        XtraTabPage3.ImageOptions.Image = My.Resources.Icon_NewBill
        XtraTabPage4.ImageOptions.Image = My.Resources.Icon_NewProduct
        XtraTabPage5.ImageOptions.Image = My.Resources.Icon_NewGroup
        XtraTabPage6.ImageOptions.Image = My.Resources.Icon_NewStock
        XtraTabPage7.ImageOptions.Image = My.Resources.Icon_NewMaterial
        XtraTabPage8.ImageOptions.Image = My.Resources.Icon_NewReport
        XtraTabPage9.ImageOptions.Image = My.Resources.Icon_NewVIP
        XtraTabPage10.ImageOptions.Image = My.Resources.Icon_NewStaff
        XtraTabPage11.ImageOptions.Image = My.Resources.Icon_NewSetting
        XtraTabPage12.ImageOptions.Image = My.Resources.Icon_NewPomotion
        XtraTabPage13.ImageOptions.Image = My.Resources.Icon_NewBarcode
    End Sub

    Sub change_to_eng_text()
        BtnCloseShift.Text = My.Resources.main_en.closeship
        BtnSignout.Text = My.Resources.main_en.logout

        XtraTabPage1.ImageOptions.Image = My.Resources.Icon_NewPOS_en
        XtraTabPage2.ImageOptions.Image = My.Resources.Icon_NewTable_en
        XtraTabPage3.ImageOptions.Image = My.Resources.Icon_NewBill_en
        XtraTabPage4.ImageOptions.Image = My.Resources.Icon_NewProduct_en
        XtraTabPage5.ImageOptions.Image = My.Resources.Icon_NewGroup_en
        XtraTabPage6.ImageOptions.Image = My.Resources.Icon_NewStock_en
        XtraTabPage7.ImageOptions.Image = My.Resources.Icon_NewMaterial_en
        XtraTabPage8.ImageOptions.Image = My.Resources.Icon_NewReport_en
        XtraTabPage9.ImageOptions.Image = My.Resources.Icon_NewStaff_en
        XtraTabPage10.ImageOptions.Image = My.Resources.Icon_NewEmployee_en
        XtraTabPage11.ImageOptions.Image = My.Resources.Icon_NewSetting_en
        XtraTabPage12.ImageOptions.Image = My.Resources.Icon_NewPomotion_en
        XtraTabPage13.ImageOptions.Image = My.Resources.Icon_NewBarcode_en
    End Sub

    Private Sub TabControlMain_Click(sender As Object, e As EventArgs) Handles TabControlMain.Click

    End Sub
End Class