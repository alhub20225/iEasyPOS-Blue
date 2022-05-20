<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDifinitionProvince
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDeleteCountry = New System.Windows.Forms.Button()
        Me.BtnAddCountry = New System.Windows.Forms.Button()
        Me.TxtSearchCountryNameENG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSearchCountry = New System.Windows.Forms.Button()
        Me.TxtSearchCountry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_Country = New System.Windows.Forms.DataGridView()
        Me.ชื่อประเทศ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อประเทศENG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProvinceENG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddProvince = New System.Windows.Forms.Button()
        Me.BtnDeleteProvince = New System.Windows.Forms.Button()
        Me.BtnSearchProvince = New System.Windows.Forms.Button()
        Me.TxtSerachProvince = New System.Windows.Forms.TextBox()
        Me.DGProvince = New System.Windows.Forms.DataGridView()
        Me.ชื่อจังหวัดภาษาไทย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อจังหวัดEng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDistrictENG = New System.Windows.Forms.TextBox()
        Me.BtnAddDistrict = New System.Windows.Forms.Button()
        Me.BtnDeleteDistrict = New System.Windows.Forms.Button()
        Me.BtnSearchDistrict = New System.Windows.Forms.Button()
        Me.DGDistrict = New System.Windows.Forms.DataGridView()
        Me.ชื่ออำเภอ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่ออำเภอENG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSearchDistrict = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSubDistrictENG = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAddsubDistrict = New System.Windows.Forms.Button()
        Me.BtnDeleteSubDistrict = New System.Windows.Forms.Button()
        Me.BtnSerachSubDistrcit = New System.Windows.Forms.Button()
        Me.DgSubDistrict = New System.Windows.Forms.DataGridView()
        Me.ชื่อตำบล = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อตำบลENG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubdistrictId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSerachSubDistrict = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Country, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgSubDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDeleteCountry)
        Me.GroupBox1.Controls.Add(Me.BtnAddCountry)
        Me.GroupBox1.Controls.Add(Me.TxtSearchCountryNameENG)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnSearchCountry)
        Me.GroupBox1.Controls.Add(Me.TxtSearchCountry)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dg_Country)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 716)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเทศ"
        '
        'BtnDeleteCountry
        '
        Me.BtnDeleteCountry.Location = New System.Drawing.Point(206, 92)
        Me.BtnDeleteCountry.Name = "BtnDeleteCountry"
        Me.BtnDeleteCountry.Size = New System.Drawing.Size(80, 23)
        Me.BtnDeleteCountry.TabIndex = 7
        Me.BtnDeleteCountry.Text = "ลบ"
        Me.BtnDeleteCountry.UseVisualStyleBackColor = True
        Me.BtnDeleteCountry.Visible = False
        '
        'BtnAddCountry
        '
        Me.BtnAddCountry.Location = New System.Drawing.Point(206, 59)
        Me.BtnAddCountry.Name = "BtnAddCountry"
        Me.BtnAddCountry.Size = New System.Drawing.Size(80, 23)
        Me.BtnAddCountry.TabIndex = 6
        Me.BtnAddCountry.Text = "เพิ่ม"
        Me.BtnAddCountry.UseVisualStyleBackColor = True
        '
        'TxtSearchCountryNameENG
        '
        Me.TxtSearchCountryNameENG.Location = New System.Drawing.Point(9, 87)
        Me.TxtSearchCountryNameENG.Name = "TxtSearchCountryNameENG"
        Me.TxtSearchCountryNameENG.Size = New System.Drawing.Size(191, 24)
        Me.TxtSearchCountryNameENG.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อประเทศ(ENG)"
        '
        'BtnSearchCountry
        '
        Me.BtnSearchCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSearchCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchCountry.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnSearchCountry.ForeColor = System.Drawing.Color.White
        Me.BtnSearchCountry.Location = New System.Drawing.Point(206, 21)
        Me.BtnSearchCountry.Name = "BtnSearchCountry"
        Me.BtnSearchCountry.Size = New System.Drawing.Size(80, 23)
        Me.BtnSearchCountry.TabIndex = 3
        Me.BtnSearchCountry.Text = "ค้นหา"
        Me.BtnSearchCountry.UseVisualStyleBackColor = False
        '
        'TxtSearchCountry
        '
        Me.TxtSearchCountry.Location = New System.Drawing.Point(9, 42)
        Me.TxtSearchCountry.Name = "TxtSearchCountry"
        Me.TxtSearchCountry.Size = New System.Drawing.Size(191, 24)
        Me.TxtSearchCountry.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ชื่อประเทศ(TH)"
        '
        'Dg_Country
        '
        Me.Dg_Country.AllowUserToAddRows = False
        Me.Dg_Country.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Country.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Country.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อประเทศ, Me.ชื่อประเทศENG, Me.CountryId})
        Me.Dg_Country.Location = New System.Drawing.Point(6, 120)
        Me.Dg_Country.Name = "Dg_Country"
        Me.Dg_Country.RowHeadersVisible = False
        Me.Dg_Country.Size = New System.Drawing.Size(296, 590)
        Me.Dg_Country.TabIndex = 0
        '
        'ชื่อประเทศ
        '
        Me.ชื่อประเทศ.HeaderText = "ชื่อประเทศ"
        Me.ชื่อประเทศ.Name = "ชื่อประเทศ"
        Me.ชื่อประเทศ.Width = 120
        '
        'ชื่อประเทศENG
        '
        Me.ชื่อประเทศENG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อประเทศENG.HeaderText = "ชื่อประเทศENG"
        Me.ชื่อประเทศENG.Name = "ชื่อประเทศENG"
        '
        'CountryId
        '
        Me.CountryId.HeaderText = "CountryId"
        Me.CountryId.Name = "CountryId"
        Me.CountryId.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtProvinceENG)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtnAddProvince)
        Me.GroupBox2.Controls.Add(Me.BtnDeleteProvince)
        Me.GroupBox2.Controls.Add(Me.BtnSearchProvince)
        Me.GroupBox2.Controls.Add(Me.TxtSerachProvince)
        Me.GroupBox2.Controls.Add(Me.DGProvince)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(840, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จังหวัด"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.Label4.Location = New System.Drawing.Point(245, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ชื่อจังหวัด(ENG)"
        '
        'TxtProvinceENG
        '
        Me.TxtProvinceENG.Location = New System.Drawing.Point(248, 29)
        Me.TxtProvinceENG.Name = "TxtProvinceENG"
        Me.TxtProvinceENG.Size = New System.Drawing.Size(191, 24)
        Me.TxtProvinceENG.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.Label3.Location = New System.Drawing.Point(48, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ชื่อจังหวัด(TH)"
        '
        'BtnAddProvince
        '
        Me.BtnAddProvince.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnAddProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddProvince.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnAddProvince.ForeColor = System.Drawing.Color.White
        Me.BtnAddProvince.Location = New System.Drawing.Point(542, 26)
        Me.BtnAddProvince.Name = "BtnAddProvince"
        Me.BtnAddProvince.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddProvince.TabIndex = 7
        Me.BtnAddProvince.Text = "เพิ่ม"
        Me.BtnAddProvince.UseVisualStyleBackColor = False
        '
        'BtnDeleteProvince
        '
        Me.BtnDeleteProvince.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnDeleteProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteProvince.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnDeleteProvince.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteProvince.Location = New System.Drawing.Point(621, 26)
        Me.BtnDeleteProvince.Name = "BtnDeleteProvince"
        Me.BtnDeleteProvince.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteProvince.TabIndex = 6
        Me.BtnDeleteProvince.Text = "ลบ"
        Me.BtnDeleteProvince.UseVisualStyleBackColor = False
        '
        'BtnSearchProvince
        '
        Me.BtnSearchProvince.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSearchProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchProvince.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnSearchProvince.ForeColor = System.Drawing.Color.White
        Me.BtnSearchProvince.Location = New System.Drawing.Point(460, 26)
        Me.BtnSearchProvince.Name = "BtnSearchProvince"
        Me.BtnSearchProvince.Size = New System.Drawing.Size(80, 23)
        Me.BtnSearchProvince.TabIndex = 4
        Me.BtnSearchProvince.Text = "ค้นหา"
        Me.BtnSearchProvince.UseVisualStyleBackColor = False
        '
        'TxtSerachProvince
        '
        Me.TxtSerachProvince.Location = New System.Drawing.Point(51, 29)
        Me.TxtSerachProvince.Name = "TxtSerachProvince"
        Me.TxtSerachProvince.Size = New System.Drawing.Size(191, 24)
        Me.TxtSerachProvince.TabIndex = 5
        '
        'DGProvince
        '
        Me.DGProvince.AllowUserToAddRows = False
        Me.DGProvince.BackgroundColor = System.Drawing.Color.White
        Me.DGProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProvince.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อจังหวัดภาษาไทย, Me.ชื่อจังหวัดEng, Me.ProvinceId})
        Me.DGProvince.Location = New System.Drawing.Point(6, 57)
        Me.DGProvince.Name = "DGProvince"
        Me.DGProvince.RowHeadersVisible = False
        Me.DGProvince.Size = New System.Drawing.Size(828, 114)
        Me.DGProvince.TabIndex = 2
        '
        'ชื่อจังหวัดภาษาไทย
        '
        Me.ชื่อจังหวัดภาษาไทย.HeaderText = "ชื่อจังหวัดภาษาไทย"
        Me.ชื่อจังหวัดภาษาไทย.Name = "ชื่อจังหวัดภาษาไทย"
        Me.ชื่อจังหวัดภาษาไทย.Width = 414
        '
        'ชื่อจังหวัดEng
        '
        Me.ชื่อจังหวัดEng.HeaderText = "ชื่อจังหวัดEng"
        Me.ชื่อจังหวัดEng.Name = "ชื่อจังหวัดEng"
        Me.ชื่อจังหวัดEng.Width = 414
        '
        'ProvinceId
        '
        Me.ProvinceId.HeaderText = "ProvinceId"
        Me.ProvinceId.Name = "ProvinceId"
        Me.ProvinceId.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtDistrictENG)
        Me.GroupBox3.Controls.Add(Me.BtnAddDistrict)
        Me.GroupBox3.Controls.Add(Me.BtnDeleteDistrict)
        Me.GroupBox3.Controls.Add(Me.BtnSearchDistrict)
        Me.GroupBox3.Controls.Add(Me.DGDistrict)
        Me.GroupBox3.Controls.Add(Me.TxtSearchDistrict)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(326, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 292)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "อำเภอ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(245, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ชื่ออำเภอ(ENG)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(48, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ชื่ออำเภอ(TH)"
        '
        'TxtDistrictENG
        '
        Me.TxtDistrictENG.Location = New System.Drawing.Point(248, 37)
        Me.TxtDistrictENG.Name = "TxtDistrictENG"
        Me.TxtDistrictENG.Size = New System.Drawing.Size(191, 24)
        Me.TxtDistrictENG.TabIndex = 9
        '
        'BtnAddDistrict
        '
        Me.BtnAddDistrict.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnAddDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddDistrict.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnAddDistrict.ForeColor = System.Drawing.Color.White
        Me.BtnAddDistrict.Location = New System.Drawing.Point(542, 34)
        Me.BtnAddDistrict.Name = "BtnAddDistrict"
        Me.BtnAddDistrict.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddDistrict.TabIndex = 8
        Me.BtnAddDistrict.Text = "เพิ่ม"
        Me.BtnAddDistrict.UseVisualStyleBackColor = False
        '
        'BtnDeleteDistrict
        '
        Me.BtnDeleteDistrict.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnDeleteDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteDistrict.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnDeleteDistrict.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteDistrict.Location = New System.Drawing.Point(621, 34)
        Me.BtnDeleteDistrict.Name = "BtnDeleteDistrict"
        Me.BtnDeleteDistrict.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteDistrict.TabIndex = 7
        Me.BtnDeleteDistrict.Text = "ลบ"
        Me.BtnDeleteDistrict.UseVisualStyleBackColor = False
        '
        'BtnSearchDistrict
        '
        Me.BtnSearchDistrict.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSearchDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchDistrict.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnSearchDistrict.ForeColor = System.Drawing.Color.White
        Me.BtnSearchDistrict.Location = New System.Drawing.Point(460, 34)
        Me.BtnSearchDistrict.Name = "BtnSearchDistrict"
        Me.BtnSearchDistrict.Size = New System.Drawing.Size(80, 23)
        Me.BtnSearchDistrict.TabIndex = 6
        Me.BtnSearchDistrict.Text = "ค้นหา"
        Me.BtnSearchDistrict.UseVisualStyleBackColor = False
        '
        'DGDistrict
        '
        Me.DGDistrict.AllowUserToAddRows = False
        Me.DGDistrict.BackgroundColor = System.Drawing.Color.White
        Me.DGDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDistrict.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่ออำเภอ, Me.ชื่ออำเภอENG, Me.DistrictId})
        Me.DGDistrict.Location = New System.Drawing.Point(6, 63)
        Me.DGDistrict.Name = "DGDistrict"
        Me.DGDistrict.RowHeadersVisible = False
        Me.DGDistrict.Size = New System.Drawing.Size(828, 223)
        Me.DGDistrict.TabIndex = 1
        '
        'ชื่ออำเภอ
        '
        Me.ชื่ออำเภอ.HeaderText = "ชื่ออำเภอ"
        Me.ชื่ออำเภอ.Name = "ชื่ออำเภอ"
        '
        'ชื่ออำเภอENG
        '
        Me.ชื่ออำเภอENG.HeaderText = "ชื่ออำเภอENG"
        Me.ชื่ออำเภอENG.Name = "ชื่ออำเภอENG"
        '
        'DistrictId
        '
        Me.DistrictId.HeaderText = "DistrictId"
        Me.DistrictId.Name = "DistrictId"
        Me.DistrictId.Visible = False
        '
        'TxtSearchDistrict
        '
        Me.TxtSearchDistrict.Location = New System.Drawing.Point(51, 37)
        Me.TxtSearchDistrict.Name = "TxtSearchDistrict"
        Me.TxtSearchDistrict.Size = New System.Drawing.Size(191, 24)
        Me.TxtSearchDistrict.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtSubDistrictENG)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.BtnAddsubDistrict)
        Me.GroupBox4.Controls.Add(Me.BtnDeleteSubDistrict)
        Me.GroupBox4.Controls.Add(Me.BtnSerachSubDistrcit)
        Me.GroupBox4.Controls.Add(Me.DgSubDistrict)
        Me.GroupBox4.Controls.Add(Me.TxtSerachSubDistrict)
        Me.GroupBox4.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(326, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 224)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ตำบล"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(251, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ชื่อตำบล(ENG)"
        '
        'TxtSubDistrictENG
        '
        Me.TxtSubDistrictENG.Location = New System.Drawing.Point(254, 36)
        Me.TxtSubDistrictENG.Name = "TxtSubDistrictENG"
        Me.TxtSubDistrictENG.Size = New System.Drawing.Size(191, 24)
        Me.TxtSubDistrictENG.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(54, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ชื่อตำบล(TH)"
        '
        'BtnAddsubDistrict
        '
        Me.BtnAddsubDistrict.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnAddsubDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddsubDistrict.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnAddsubDistrict.ForeColor = System.Drawing.Color.White
        Me.BtnAddsubDistrict.Location = New System.Drawing.Point(548, 34)
        Me.BtnAddsubDistrict.Name = "BtnAddsubDistrict"
        Me.BtnAddsubDistrict.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddsubDistrict.TabIndex = 11
        Me.BtnAddsubDistrict.Text = "เพิ่ม"
        Me.BtnAddsubDistrict.UseVisualStyleBackColor = False
        '
        'BtnDeleteSubDistrict
        '
        Me.BtnDeleteSubDistrict.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnDeleteSubDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteSubDistrict.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnDeleteSubDistrict.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteSubDistrict.Location = New System.Drawing.Point(627, 34)
        Me.BtnDeleteSubDistrict.Name = "BtnDeleteSubDistrict"
        Me.BtnDeleteSubDistrict.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteSubDistrict.TabIndex = 10
        Me.BtnDeleteSubDistrict.Text = "ลบ"
        Me.BtnDeleteSubDistrict.UseVisualStyleBackColor = False
        '
        'BtnSerachSubDistrcit
        '
        Me.BtnSerachSubDistrcit.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSerachSubDistrcit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSerachSubDistrcit.Font = New System.Drawing.Font("Kanit", 8.999999!)
        Me.BtnSerachSubDistrcit.ForeColor = System.Drawing.Color.White
        Me.BtnSerachSubDistrcit.Location = New System.Drawing.Point(466, 34)
        Me.BtnSerachSubDistrcit.Name = "BtnSerachSubDistrcit"
        Me.BtnSerachSubDistrcit.Size = New System.Drawing.Size(80, 23)
        Me.BtnSerachSubDistrcit.TabIndex = 8
        Me.BtnSerachSubDistrcit.Text = "ค้นหา"
        Me.BtnSerachSubDistrcit.UseVisualStyleBackColor = False
        '
        'DgSubDistrict
        '
        Me.DgSubDistrict.AllowUserToAddRows = False
        Me.DgSubDistrict.BackgroundColor = System.Drawing.Color.White
        Me.DgSubDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSubDistrict.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อตำบล, Me.ชื่อตำบลENG, Me.SubdistrictId})
        Me.DgSubDistrict.Location = New System.Drawing.Point(12, 66)
        Me.DgSubDistrict.Name = "DgSubDistrict"
        Me.DgSubDistrict.RowHeadersVisible = False
        Me.DgSubDistrict.Size = New System.Drawing.Size(822, 146)
        Me.DgSubDistrict.TabIndex = 2
        '
        'ชื่อตำบล
        '
        Me.ชื่อตำบล.HeaderText = "ชื่อตำบล"
        Me.ชื่อตำบล.Name = "ชื่อตำบล"
        '
        'ชื่อตำบลENG
        '
        Me.ชื่อตำบลENG.HeaderText = "ชื่อตำบลENG"
        Me.ชื่อตำบลENG.Name = "ชื่อตำบลENG"
        '
        'SubdistrictId
        '
        Me.SubdistrictId.HeaderText = "SubdistrictId"
        Me.SubdistrictId.Name = "SubdistrictId"
        Me.SubdistrictId.Visible = False
        '
        'TxtSerachSubDistrict
        '
        Me.TxtSerachSubDistrict.Location = New System.Drawing.Point(57, 36)
        Me.TxtSerachSubDistrict.Name = "TxtSerachSubDistrict"
        Me.TxtSerachSubDistrict.Size = New System.Drawing.Size(191, 24)
        Me.TxtSerachSubDistrict.TabIndex = 9
        '
        'FrmDifinitionProvince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1189, 740)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDifinitionProvince"
        Me.Text = "FrmDifinitionProvince"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_Country, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DgSubDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSearchCountry As Button
    Friend WithEvents TxtSearchCountry As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dg_Country As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDeleteProvince As Button
    Friend WithEvents BtnSearchProvince As Button
    Friend WithEvents TxtSerachProvince As TextBox
    Friend WithEvents DGProvince As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnDeleteDistrict As Button
    Friend WithEvents BtnSearchDistrict As Button
    Friend WithEvents DGDistrict As DataGridView
    Friend WithEvents TxtSearchDistrict As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnDeleteSubDistrict As Button
    Friend WithEvents BtnSerachSubDistrcit As Button
    Friend WithEvents DgSubDistrict As DataGridView
    Friend WithEvents TxtSerachSubDistrict As TextBox
    Friend WithEvents BtnAddProvince As Button
    Friend WithEvents BtnAddDistrict As Button
    Friend WithEvents BtnAddsubDistrict As Button
    Friend WithEvents BtnDeleteCountry As Button
    Friend WithEvents BtnAddCountry As Button
    Friend WithEvents TxtSearchCountryNameENG As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtProvinceENG As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDistrictENG As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSubDistrictENG As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ชื่อประเทศ As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อประเทศENG As DataGridViewTextBoxColumn
    Friend WithEvents CountryId As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อตำบล As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อตำบลENG As DataGridViewTextBoxColumn
    Friend WithEvents SubdistrictId As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อจังหวัดภาษาไทย As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อจังหวัดEng As DataGridViewTextBoxColumn
    Friend WithEvents ProvinceId As DataGridViewTextBoxColumn
    Friend WithEvents ชื่ออำเภอ As DataGridViewTextBoxColumn
    Friend WithEvents ชื่ออำเภอENG As DataGridViewTextBoxColumn
    Friend WithEvents DistrictId As DataGridViewTextBoxColumn

End Class
