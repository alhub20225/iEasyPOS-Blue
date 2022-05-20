<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboCustomerType = New System.Windows.Forms.ComboBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgCustomers = New System.Windows.Forms.DataGridView()
        Me.รหัสลูกค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อลูกค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnManageCustype = New System.Windows.Forms.Button()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DatetimeBirthDay = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNickname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMidName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFristName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboTitles = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboDataTypeCustomer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustomerId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabMenu = New System.Windows.Forms.TabControl()
        Me.TabAdress = New System.Windows.Forms.TabPage()
        Me.txtSubDistrict = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtMobilePhone = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtPostNumber = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboCountryName = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboProvinceName = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboSubDistrict = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboDistrictName = New System.Windows.Forms.ComboBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tabhistory = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.วันที่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.รายการ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ส่วนลด = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคา = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคารวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabUsePoint = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.แต้มรวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Close_pos = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.TabAdress.SuspendLayout()
        Me.Tabhistory.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUsePoint.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboCustomerType)
        Me.GroupBox1.Controls.Add(Me.TxtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Kanit", 18.0!)
        Me.BtnSearch.Location = New System.Drawing.Point(313, 33)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(126, 50)
        Me.BtnSearch.TabIndex = 0
        Me.BtnSearch.Text = "ค้นหา"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ประเภทลูกค้า:"
        '
        'ComboCustomerType
        '
        Me.ComboCustomerType.FormattingEnabled = True
        Me.ComboCustomerType.Location = New System.Drawing.Point(107, 63)
        Me.ComboCustomerType.Name = "ComboCustomerType"
        Me.ComboCustomerType.Size = New System.Drawing.Size(200, 30)
        Me.ComboCustomerType.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(107, 26)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(200, 30)
        Me.TxtSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgCustomers)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 555)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DgCustomers
        '
        Me.DgCustomers.AllowUserToAddRows = False
        Me.DgCustomers.AllowUserToDeleteRows = False
        Me.DgCustomers.BackgroundColor = System.Drawing.Color.White
        Me.DgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัสลูกค้า, Me.ชื่อลูกค้า, Me.CustId})
        Me.DgCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgCustomers.Location = New System.Drawing.Point(3, 27)
        Me.DgCustomers.Name = "DgCustomers"
        Me.DgCustomers.ReadOnly = True
        Me.DgCustomers.RowHeadersVisible = False
        Me.DgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgCustomers.Size = New System.Drawing.Size(516, 525)
        Me.DgCustomers.TabIndex = 0
        '
        'รหัสลูกค้า
        '
        Me.รหัสลูกค้า.HeaderText = "รหัสลูกค้า"
        Me.รหัสลูกค้า.Name = "รหัสลูกค้า"
        Me.รหัสลูกค้า.ReadOnly = True
        Me.รหัสลูกค้า.Width = 180
        '
        'ชื่อลูกค้า
        '
        Me.ชื่อลูกค้า.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อลูกค้า.HeaderText = "ชื่อลูกค้า"
        Me.ชื่อลูกค้า.Name = "ชื่อลูกค้า"
        Me.ชื่อลูกค้า.ReadOnly = True
        '
        'CustId
        '
        Me.CustId.HeaderText = "CustId"
        Me.CustId.Name = "CustId"
        Me.CustId.ReadOnly = True
        Me.CustId.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnManageCustype)
        Me.GroupBox3.Controls.Add(Me.ComboGender)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DatetimeBirthDay)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TxtEmail)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtNickname)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtLastName)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtMidName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtFristName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ComboTitles)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ComboDataTypeCustomer)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtCustomerId)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(606, 264)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnManageCustype
        '
        Me.btnManageCustype.BackgroundImage = Global.Project_CTM.My.Resources.Resources.edit
        Me.btnManageCustype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageCustype.FlatAppearance.BorderSize = 0
        Me.btnManageCustype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageCustype.Location = New System.Drawing.Point(417, 35)
        Me.btnManageCustype.Name = "btnManageCustype"
        Me.btnManageCustype.Size = New System.Drawing.Size(30, 31)
        Me.btnManageCustype.TabIndex = 59
        Me.btnManageCustype.UseVisualStyleBackColor = True
        '
        'ComboGender
        '
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Location = New System.Drawing.Point(19, 221)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(108, 32)
        Me.ComboGender.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "เพศ"
        '
        'DatetimeBirthDay
        '
        Me.DatetimeBirthDay.CustomFormat = "yyy MM dd"
        Me.DatetimeBirthDay.Location = New System.Drawing.Point(133, 165)
        Me.DatetimeBirthDay.Name = "DatetimeBirthDay"
        Me.DatetimeBirthDay.Size = New System.Drawing.Size(197, 31)
        Me.DatetimeBirthDay.TabIndex = 20
        Me.DatetimeBirthDay.Value = New Date(2018, 7, 13, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(130, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 24)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "วันเกิด"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(363, 165)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(234, 31)
        Me.TxtEmail.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(360, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Email :"
        '
        'TxtNickname
        '
        Me.TxtNickname.Location = New System.Drawing.Point(19, 165)
        Me.TxtNickname.Name = "TxtNickname"
        Me.TxtNickname.Size = New System.Drawing.Size(108, 31)
        Me.TxtNickname.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ชื่อเล่น"
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(363, 103)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(153, 31)
        Me.TxtLastName.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(360, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "นามสกุล"
        '
        'TxtMidName
        '
        Me.TxtMidName.Location = New System.Drawing.Point(241, 103)
        Me.TxtMidName.Name = "TxtMidName"
        Me.TxtMidName.Size = New System.Drawing.Size(106, 31)
        Me.TxtMidName.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(238, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ชื่อกลาง"
        '
        'TxtFristName
        '
        Me.TxtFristName.Location = New System.Drawing.Point(123, 103)
        Me.TxtFristName.Name = "TxtFristName"
        Me.TxtFristName.Size = New System.Drawing.Size(101, 31)
        Me.TxtFristName.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ชื่อ"
        '
        'ComboTitles
        '
        Me.ComboTitles.FormattingEnabled = True
        Me.ComboTitles.Location = New System.Drawing.Point(19, 102)
        Me.ComboTitles.Name = "ComboTitles"
        Me.ComboTitles.Size = New System.Drawing.Size(76, 32)
        Me.ComboTitles.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ประเภทลูกค้า"
        '
        'ComboDataTypeCustomer
        '
        Me.ComboDataTypeCustomer.FormattingEnabled = True
        Me.ComboDataTypeCustomer.Location = New System.Drawing.Point(216, 36)
        Me.ComboDataTypeCustomer.Name = "ComboDataTypeCustomer"
        Me.ComboDataTypeCustomer.Size = New System.Drawing.Size(194, 32)
        Me.ComboDataTypeCustomer.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "คำนำหน้าชื่อ"
        '
        'TxtCustomerId
        '
        Me.TxtCustomerId.Location = New System.Drawing.Point(19, 36)
        Me.TxtCustomerId.Name = "TxtCustomerId"
        Me.TxtCustomerId.Size = New System.Drawing.Size(150, 31)
        Me.TxtCustomerId.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "รหัสลูกค้า"
        '
        'TabMenu
        '
        Me.TabMenu.Controls.Add(Me.TabAdress)
        Me.TabMenu.Controls.Add(Me.Tabhistory)
        Me.TabMenu.Controls.Add(Me.TabUsePoint)
        Me.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMenu.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.TabMenu.ItemSize = New System.Drawing.Size(150, 30)
        Me.TabMenu.Location = New System.Drawing.Point(0, 0)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.SelectedIndex = 0
        Me.TabMenu.Size = New System.Drawing.Size(743, 383)
        Me.TabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabMenu.TabIndex = 0
        '
        'TabAdress
        '
        Me.TabAdress.BackColor = System.Drawing.Color.White
        Me.TabAdress.Controls.Add(Me.txtSubDistrict)
        Me.TabAdress.Controls.Add(Me.TxtFax)
        Me.TabAdress.Controls.Add(Me.Label22)
        Me.TabAdress.Controls.Add(Me.TxtPhone)
        Me.TabAdress.Controls.Add(Me.Label21)
        Me.TabAdress.Controls.Add(Me.TxtMobilePhone)
        Me.TabAdress.Controls.Add(Me.Label20)
        Me.TabAdress.Controls.Add(Me.TxtPostNumber)
        Me.TabAdress.Controls.Add(Me.Label19)
        Me.TabAdress.Controls.Add(Me.Label18)
        Me.TabAdress.Controls.Add(Me.ComboCountryName)
        Me.TabAdress.Controls.Add(Me.Label17)
        Me.TabAdress.Controls.Add(Me.ComboProvinceName)
        Me.TabAdress.Controls.Add(Me.Label16)
        Me.TabAdress.Controls.Add(Me.ComboSubDistrict)
        Me.TabAdress.Controls.Add(Me.Label15)
        Me.TabAdress.Controls.Add(Me.ComboDistrictName)
        Me.TabAdress.Controls.Add(Me.TxtAddress2)
        Me.TabAdress.Controls.Add(Me.Label14)
        Me.TabAdress.Controls.Add(Me.TxtAddress1)
        Me.TabAdress.Controls.Add(Me.Label13)
        Me.TabAdress.Location = New System.Drawing.Point(4, 34)
        Me.TabAdress.Name = "TabAdress"
        Me.TabAdress.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAdress.Size = New System.Drawing.Size(735, 345)
        Me.TabAdress.TabIndex = 0
        Me.TabAdress.Text = "ที่อยู่"
        '
        'txtSubDistrict
        '
        Me.txtSubDistrict.Location = New System.Drawing.Point(2, 299)
        Me.txtSubDistrict.Name = "txtSubDistrict"
        Me.txtSubDistrict.Size = New System.Drawing.Size(148, 31)
        Me.txtSubDistrict.TabIndex = 32
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(193, 296)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(150, 31)
        Me.TxtFax.TabIndex = 30
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(190, 276)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 24)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Fax"
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(193, 234)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(150, 31)
        Me.TxtPhone.TabIndex = 28
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(190, 211)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 24)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "เบอร์โทร"
        '
        'TxtMobilePhone
        '
        Me.TxtMobilePhone.Location = New System.Drawing.Point(193, 175)
        Me.TxtMobilePhone.Name = "TxtMobilePhone"
        Me.TxtMobilePhone.Size = New System.Drawing.Size(150, 31)
        Me.TxtMobilePhone.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(190, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 24)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "โทรศัพท์"
        '
        'TxtPostNumber
        '
        Me.TxtPostNumber.Location = New System.Drawing.Point(193, 105)
        Me.TxtPostNumber.Name = "TxtPostNumber"
        Me.TxtPostNumber.Size = New System.Drawing.Size(150, 31)
        Me.TxtPostNumber.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(190, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 24)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "ไปรษณีย์"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 24)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "ประเทศ"
        '
        'ComboCountryName
        '
        Me.ComboCountryName.FormattingEnabled = True
        Me.ComboCountryName.Location = New System.Drawing.Point(6, 104)
        Me.ComboCountryName.Name = "ComboCountryName"
        Me.ComboCountryName.Size = New System.Drawing.Size(148, 32)
        Me.ComboCountryName.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 24)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "จังหวัด"
        '
        'ComboProvinceName
        '
        Me.ComboProvinceName.FormattingEnabled = True
        Me.ComboProvinceName.Location = New System.Drawing.Point(6, 175)
        Me.ComboProvinceName.Name = "ComboProvinceName"
        Me.ComboProvinceName.Size = New System.Drawing.Size(148, 32)
        Me.ComboProvinceName.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 276)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 24)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "ตำบล"
        '
        'ComboSubDistrict
        '
        Me.ComboSubDistrict.FormattingEnabled = True
        Me.ComboSubDistrict.Location = New System.Drawing.Point(2, 300)
        Me.ComboSubDistrict.Name = "ComboSubDistrict"
        Me.ComboSubDistrict.Size = New System.Drawing.Size(148, 32)
        Me.ComboSubDistrict.TabIndex = 9
        Me.ComboSubDistrict.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 24)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "อำเภอ"
        '
        'ComboDistrictName
        '
        Me.ComboDistrictName.FormattingEnabled = True
        Me.ComboDistrictName.Location = New System.Drawing.Point(6, 234)
        Me.ComboDistrictName.Name = "ComboDistrictName"
        Me.ComboDistrictName.Size = New System.Drawing.Size(148, 32)
        Me.ComboDistrictName.TabIndex = 7
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Location = New System.Drawing.Point(237, 30)
        Me.TxtAddress2.Multiline = True
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(189, 46)
        Me.TxtAddress2.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(234, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 24)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "ที่อยู่"
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Location = New System.Drawing.Point(6, 30)
        Me.TxtAddress1.Multiline = True
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(189, 46)
        Me.TxtAddress1.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 24)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "ที่อยู่"
        '
        'Tabhistory
        '
        Me.Tabhistory.Controls.Add(Me.DataGridView2)
        Me.Tabhistory.Location = New System.Drawing.Point(4, 34)
        Me.Tabhistory.Name = "Tabhistory"
        Me.Tabhistory.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabhistory.Size = New System.Drawing.Size(735, 345)
        Me.Tabhistory.TabIndex = 1
        Me.Tabhistory.Text = "ประวัติการซื้อ"
        Me.Tabhistory.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่, Me.รายการ, Me.จำนวน, Me.ส่วนลด, Me.ราคา, Me.ราคารวม, Me.SaleNo})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(729, 339)
        Me.DataGridView2.TabIndex = 0
        '
        'วันที่
        '
        Me.วันที่.HeaderText = "วันที่"
        Me.วันที่.Name = "วันที่"
        Me.วันที่.ReadOnly = True
        '
        'รายการ
        '
        Me.รายการ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.รายการ.HeaderText = "รายการ"
        Me.รายการ.Name = "รายการ"
        Me.รายการ.ReadOnly = True
        '
        'จำนวน
        '
        Me.จำนวน.HeaderText = "จำนวน"
        Me.จำนวน.Name = "จำนวน"
        Me.จำนวน.ReadOnly = True
        '
        'ส่วนลด
        '
        Me.ส่วนลด.HeaderText = "ส่วนลด"
        Me.ส่วนลด.Name = "ส่วนลด"
        Me.ส่วนลด.ReadOnly = True
        '
        'ราคา
        '
        Me.ราคา.HeaderText = "ราคา"
        Me.ราคา.Name = "ราคา"
        Me.ราคา.ReadOnly = True
        Me.ราคา.Visible = False
        '
        'ราคารวม
        '
        Me.ราคารวม.HeaderText = "ราคารวม"
        Me.ราคารวม.Name = "ราคารวม"
        Me.ราคารวม.ReadOnly = True
        '
        'SaleNo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SaleNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaleNo.HeaderText = "เลขที่บิล"
        Me.SaleNo.Name = "SaleNo"
        Me.SaleNo.ReadOnly = True
        Me.SaleNo.Width = 150
        '
        'TabUsePoint
        '
        Me.TabUsePoint.Controls.Add(Me.DataGridView1)
        Me.TabUsePoint.Location = New System.Drawing.Point(4, 34)
        Me.TabUsePoint.Name = "TabUsePoint"
        Me.TabUsePoint.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUsePoint.Size = New System.Drawing.Size(735, 345)
        Me.TabUsePoint.TabIndex = 2
        Me.TabUsePoint.Text = "ประวัติการใช้แต้มสะสม"
        Me.TabUsePoint.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PDate, Me.PItemName, Me.PQty, Me.PPoint, Me.แต้มรวม})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(729, 339)
        Me.DataGridView1.TabIndex = 0
        '
        'PDate
        '
        Me.PDate.HeaderText = "วันที่"
        Me.PDate.Name = "PDate"
        Me.PDate.ReadOnly = True
        '
        'PItemName
        '
        Me.PItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PItemName.HeaderText = "รายการ"
        Me.PItemName.Name = "PItemName"
        Me.PItemName.ReadOnly = True
        '
        'PQty
        '
        Me.PQty.HeaderText = "จำนวน"
        Me.PQty.Name = "PQty"
        Me.PQty.ReadOnly = True
        '
        'PPoint
        '
        Me.PPoint.HeaderText = "แต้ม/หน่วย"
        Me.PPoint.Name = "PPoint"
        Me.PPoint.ReadOnly = True
        '
        'แต้มรวม
        '
        Me.แต้มรวม.HeaderText = "แต้มรวม"
        Me.แต้มรวม.Name = "แต้มรวม"
        Me.แต้มรวม.ReadOnly = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnAdd.Location = New System.Drawing.Point(6, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(141, 49)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnDelete.Location = New System.Drawing.Point(359, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(111, 49)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "ลบ"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnSave.Location = New System.Drawing.Point(173, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 49)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(12, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(246, 25)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Customer / ข้อมูลลูกค้า"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 710)
        Me.Panel1.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(522, 555)
        Me.Panel5.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 655)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(522, 55)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(522, 100)
        Me.Panel3.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(522, 58)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 710)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(525, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 710)
        Me.Panel2.TabIndex = 11
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TabMenu)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 272)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(743, 383)
        Me.Panel8.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BtnAdd)
        Me.Panel7.Controls.Add(Me.BtnDelete)
        Me.Panel7.Controls.Add(Me.BtnSave)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 655)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(755, 55)
        Me.Panel7.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(755, 272)
        Me.Panel6.TabIndex = 6
        '
        'Close_pos
        '
        Me.Close_pos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_pos.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Close_pos.FlatAppearance.BorderSize = 0
        Me.Close_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_pos.Image = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.Close_pos.Location = New System.Drawing.Point(1221, 0)
        Me.Close_pos.Name = "Close_pos"
        Me.Close_pos.Size = New System.Drawing.Size(59, 56)
        Me.Close_pos.TabIndex = 7
        Me.Close_pos.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(1280, 58)
        Me.Top_tap.TabIndex = 6
        Me.Top_tap.TabStop = False
        '
        'ManageCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Close_pos)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageCustomers"
        Me.Text = "จัดการลูกค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabMenu.ResumeLayout(False)
        Me.TabAdress.ResumeLayout(False)
        Me.TabAdress.PerformLayout()
        Me.Tabhistory.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUsePoint.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboCustomerType As ComboBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgCustomers As DataGridView
    Friend WithEvents ComboGender As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNickname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMidName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtFristName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboTitles As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboDataTypeCustomer As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCustomerId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabMenu As TabControl
    Friend WithEvents TabAdress As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboCountryName As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboProvinceName As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboSubDistrict As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboDistrictName As ComboBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Tabhistory As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtMobilePhone As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtPostNumber As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Close_pos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DatetimeBirthDay As DateTimePicker
    Friend WithEvents txtSubDistrict As TextBox
    Friend WithEvents รหัสลูกค้า As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อลูกค้า As DataGridViewTextBoxColumn
    Friend WithEvents CustId As DataGridViewTextBoxColumn
    Friend WithEvents btnManageCustype As Button
    Friend WithEvents TabUsePoint As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents วันที่ As DataGridViewTextBoxColumn
    Friend WithEvents รายการ As DataGridViewTextBoxColumn
    Friend WithEvents จำนวน As DataGridViewTextBoxColumn
    Friend WithEvents ส่วนลด As DataGridViewTextBoxColumn
    Friend WithEvents ราคา As DataGridViewTextBoxColumn
    Friend WithEvents ราคารวม As DataGridViewTextBoxColumn
    Friend WithEvents SaleNo As DataGridViewTextBoxColumn
    Friend WithEvents PDate As DataGridViewTextBoxColumn
    Friend WithEvents PItemName As DataGridViewTextBoxColumn
    Friend WithEvents PQty As DataGridViewTextBoxColumn
    Friend WithEvents PPoint As DataGridViewTextBoxColumn
    Friend WithEvents แต้มรวม As DataGridViewTextBoxColumn
End Class
