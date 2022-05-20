<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmToppings
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.RadDropDownListCateToppingSearch = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnCate = New System.Windows.Forms.Button()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewToppingList = New System.Windows.Forms.DataGridView()
        Me.ToppingId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CateTopping = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToppingName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToppingCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPricing = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtToppingCosting = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtToppingNameEN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNameTopping = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadDropDownListCateTopping = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtToppingCode = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddToppingReceipe = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewShowMatToppingList = New System.Windows.Forms.DataGridView()
        Me.หมวดหมู่MatTopping = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameItemMatTopping = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนสต๊อก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeTopping = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadDropDownListCategoryMatTopping = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnSearchMatTopping = New System.Windows.Forms.Button()
        Me.txtMatTopping = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewToppingReceipe = New System.Windows.Forms.DataGridView()
        Me.ชื่อสูตรวัตถุดิบ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนที่ใช้ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToppingReceipeId2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatToppingReceipeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนToppingReceipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RadDropDownListCateToppingSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewToppingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.RadDropDownListCateTopping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewShowMatToppingList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownListCategoryMatTopping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewToppingReceipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.RadDropDownListCateToppingSearch)
        Me.GroupBox1.Controls.Add(Me.btnCate)
        Me.GroupBox1.Controls.Add(Me.txtNameSearch)
        Me.GroupBox1.Controls.Add(Me.DataGridViewToppingList)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 535)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "หมวดหมู่ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ชื่อ :"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(220, 54)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 22)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'RadDropDownListCateToppingSearch
        '
        Me.RadDropDownListCateToppingSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListCateToppingSearch.Location = New System.Drawing.Point(69, 27)
        Me.RadDropDownListCateToppingSearch.Name = "RadDropDownListCateToppingSearch"
        Me.RadDropDownListCateToppingSearch.Size = New System.Drawing.Size(212, 21)
        Me.RadDropDownListCateToppingSearch.TabIndex = 15
        '
        'btnCate
        '
        Me.btnCate.Location = New System.Drawing.Point(287, 27)
        Me.btnCate.Name = "btnCate"
        Me.btnCate.Size = New System.Drawing.Size(72, 49)
        Me.btnCate.TabIndex = 15
        Me.btnCate.Text = "หมวดหมู่ Topping"
        Me.btnCate.UseVisualStyleBackColor = True
        '
        'txtNameSearch
        '
        Me.txtNameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNameSearch.Location = New System.Drawing.Point(39, 54)
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(175, 22)
        Me.txtNameSearch.TabIndex = 15
        '
        'DataGridViewToppingList
        '
        Me.DataGridViewToppingList.AllowUserToAddRows = False
        Me.DataGridViewToppingList.AllowUserToDeleteRows = False
        Me.DataGridViewToppingList.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewToppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewToppingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToppingId, Me.CateTopping, Me.ToppingName, Me.ToppingCode})
        Me.DataGridViewToppingList.Location = New System.Drawing.Point(1, 82)
        Me.DataGridViewToppingList.Name = "DataGridViewToppingList"
        Me.DataGridViewToppingList.ReadOnly = True
        Me.DataGridViewToppingList.RowHeadersVisible = False
        Me.DataGridViewToppingList.Size = New System.Drawing.Size(358, 447)
        Me.DataGridViewToppingList.TabIndex = 0
        '
        'ToppingId
        '
        Me.ToppingId.HeaderText = "ToppingId"
        Me.ToppingId.Name = "ToppingId"
        Me.ToppingId.ReadOnly = True
        Me.ToppingId.Visible = False
        '
        'CateTopping
        '
        Me.CateTopping.HeaderText = "หมวดหมู่"
        Me.CateTopping.Name = "CateTopping"
        Me.CateTopping.ReadOnly = True
        '
        'ToppingName
        '
        Me.ToppingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ToppingName.HeaderText = "ชื่อ"
        Me.ToppingName.Name = "ToppingName"
        Me.ToppingName.ReadOnly = True
        '
        'ToppingCode
        '
        Me.ToppingCode.HeaderText = "รหัส Topping"
        Me.ToppingCode.Name = "ToppingCode"
        Me.ToppingCode.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.TabControl1.Location = New System.Drawing.Point(377, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(636, 535)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnDel)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtPricing)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtToppingCosting)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtToppingNameEN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtNameTopping)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.RadDropDownListCateTopping)
        Me.TabPage1.Controls.Add(Me.txtToppingCode)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(628, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูล Topping"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(352, 225)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(263, 225)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 31)
        Me.btnDel.TabIndex = 28
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(169, 225)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "เพิ่ม"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(181, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "ราคาขาย :"
        '
        'txtPricing
        '
        Me.txtPricing.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.txtPricing.Location = New System.Drawing.Point(263, 167)
        Me.txtPricing.Name = "txtPricing"
        Me.txtPricing.Size = New System.Drawing.Size(164, 27)
        Me.txtPricing.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(186, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ราคาซื้อ :"
        '
        'txtToppingCosting
        '
        Me.txtToppingCosting.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.txtToppingCosting.Location = New System.Drawing.Point(263, 139)
        Me.txtToppingCosting.Name = "txtToppingCosting"
        Me.txtToppingCosting.Size = New System.Drawing.Size(164, 27)
        Me.txtToppingCosting.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(119, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Topping Name EN :"
        '
        'txtToppingNameEN
        '
        Me.txtToppingNameEN.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.txtToppingNameEN.Location = New System.Drawing.Point(263, 111)
        Me.txtToppingNameEN.Name = "txtToppingNameEN"
        Me.txtToppingNameEN.Size = New System.Drawing.Size(164, 27)
        Me.txtToppingNameEN.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(140, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Topping Name :"
        '
        'txtNameTopping
        '
        Me.txtNameTopping.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.txtNameTopping.Location = New System.Drawing.Point(263, 83)
        Me.txtNameTopping.Name = "txtNameTopping"
        Me.txtNameTopping.Size = New System.Drawing.Size(164, 27)
        Me.txtNameTopping.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(144, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Topping Code :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(124, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Category Topping :"
        '
        'RadDropDownListCateTopping
        '
        Me.RadDropDownListCateTopping.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.RadDropDownListCateTopping.Location = New System.Drawing.Point(263, 24)
        Me.RadDropDownListCateTopping.Name = "RadDropDownListCateTopping"
        Me.RadDropDownListCateTopping.Size = New System.Drawing.Size(164, 25)
        Me.RadDropDownListCateTopping.TabIndex = 16
        '
        'txtToppingCode
        '
        Me.txtToppingCode.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.txtToppingCode.Location = New System.Drawing.Point(263, 54)
        Me.txtToppingCode.Name = "txtToppingCode"
        Me.txtToppingCode.Size = New System.Drawing.Size(164, 27)
        Me.txtToppingCode.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(628, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "สูตร Topping"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAddToppingReceipe)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DataGridViewShowMatToppingList)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.RadDropDownListCategoryMatTopping)
        Me.GroupBox3.Controls.Add(Me.btnSearchMatTopping)
        Me.GroupBox3.Controls.Add(Me.txtMatTopping)
        Me.GroupBox3.Location = New System.Drawing.Point(267, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 493)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาวัตถุดิบ"
        '
        'btnAddToppingReceipe
        '
        Me.btnAddToppingReceipe.Location = New System.Drawing.Point(274, 463)
        Me.btnAddToppingReceipe.Name = "btnAddToppingReceipe"
        Me.btnAddToppingReceipe.Size = New System.Drawing.Size(75, 24)
        Me.btnAddToppingReceipe.TabIndex = 6
        Me.btnAddToppingReceipe.Text = "เพิ่ม"
        Me.btnAddToppingReceipe.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "หมวดหมู่ :"
        '
        'DataGridViewShowMatToppingList
        '
        Me.DataGridViewShowMatToppingList.AllowUserToAddRows = False
        Me.DataGridViewShowMatToppingList.AllowUserToDeleteRows = False
        Me.DataGridViewShowMatToppingList.AllowUserToResizeRows = False
        Me.DataGridViewShowMatToppingList.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewShowMatToppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowMatToppingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.หมวดหมู่MatTopping, Me.NameItemMatTopping, Me.จำนวนสต๊อก, Me.MatItemId, Me.ItemCodeTopping})
        Me.DataGridViewShowMatToppingList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewShowMatToppingList.Location = New System.Drawing.Point(0, 91)
        Me.DataGridViewShowMatToppingList.Name = "DataGridViewShowMatToppingList"
        Me.DataGridViewShowMatToppingList.ReadOnly = True
        Me.DataGridViewShowMatToppingList.RowHeadersVisible = False
        Me.DataGridViewShowMatToppingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewShowMatToppingList.Size = New System.Drawing.Size(349, 366)
        Me.DataGridViewShowMatToppingList.TabIndex = 4
        '
        'หมวดหมู่MatTopping
        '
        Me.หมวดหมู่MatTopping.HeaderText = "หมวดหมู่"
        Me.หมวดหมู่MatTopping.Name = "หมวดหมู่MatTopping"
        Me.หมวดหมู่MatTopping.ReadOnly = True
        '
        'NameItemMatTopping
        '
        Me.NameItemMatTopping.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameItemMatTopping.HeaderText = "ชื่อ"
        Me.NameItemMatTopping.Name = "NameItemMatTopping"
        Me.NameItemMatTopping.ReadOnly = True
        '
        'จำนวนสต๊อก
        '
        Me.จำนวนสต๊อก.HeaderText = "จำนวนคงเหลือ"
        Me.จำนวนสต๊อก.Name = "จำนวนสต๊อก"
        Me.จำนวนสต๊อก.ReadOnly = True
        '
        'MatItemId
        '
        Me.MatItemId.HeaderText = "ItemId"
        Me.MatItemId.Name = "MatItemId"
        Me.MatItemId.ReadOnly = True
        Me.MatItemId.Visible = False
        '
        'ItemCodeTopping
        '
        Me.ItemCodeTopping.HeaderText = "ItemCode"
        Me.ItemCodeTopping.Name = "ItemCodeTopping"
        Me.ItemCodeTopping.ReadOnly = True
        Me.ItemCodeTopping.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ชื่อวัตถุดิบ :"
        '
        'RadDropDownListCategoryMatTopping
        '
        Me.RadDropDownListCategoryMatTopping.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListCategoryMatTopping.Location = New System.Drawing.Point(82, 50)
        Me.RadDropDownListCategoryMatTopping.Name = "RadDropDownListCategoryMatTopping"
        Me.RadDropDownListCategoryMatTopping.Size = New System.Drawing.Size(186, 23)
        Me.RadDropDownListCategoryMatTopping.TabIndex = 2
        '
        'btnSearchMatTopping
        '
        Me.btnSearchMatTopping.Location = New System.Drawing.Point(274, 22)
        Me.btnSearchMatTopping.Name = "btnSearchMatTopping"
        Me.btnSearchMatTopping.Size = New System.Drawing.Size(75, 52)
        Me.btnSearchMatTopping.TabIndex = 1
        Me.btnSearchMatTopping.Text = "ค้นหา"
        Me.btnSearchMatTopping.UseVisualStyleBackColor = True
        '
        'txtMatTopping
        '
        Me.txtMatTopping.Location = New System.Drawing.Point(82, 22)
        Me.txtMatTopping.Name = "txtMatTopping"
        Me.txtMatTopping.Size = New System.Drawing.Size(186, 27)
        Me.txtMatTopping.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DataGridViewToppingReceipe)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 493)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "สูตร"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ลบ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewToppingReceipe
        '
        Me.DataGridViewToppingReceipe.AllowUserToAddRows = False
        Me.DataGridViewToppingReceipe.AllowUserToDeleteRows = False
        Me.DataGridViewToppingReceipe.AllowUserToResizeRows = False
        Me.DataGridViewToppingReceipe.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewToppingReceipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewToppingReceipe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อสูตรวัตถุดิบ, Me.จำนวนที่ใช้, Me.ToppingReceipeId2})
        Me.DataGridViewToppingReceipe.Location = New System.Drawing.Point(0, 21)
        Me.DataGridViewToppingReceipe.Name = "DataGridViewToppingReceipe"
        Me.DataGridViewToppingReceipe.ReadOnly = True
        Me.DataGridViewToppingReceipe.RowHeadersVisible = False
        Me.DataGridViewToppingReceipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewToppingReceipe.Size = New System.Drawing.Size(255, 436)
        Me.DataGridViewToppingReceipe.TabIndex = 0
        '
        'ชื่อสูตรวัตถุดิบ
        '
        Me.ชื่อสูตรวัตถุดิบ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อสูตรวัตถุดิบ.HeaderText = "ชื่อวัตถุดิบ"
        Me.ชื่อสูตรวัตถุดิบ.Name = "ชื่อสูตรวัตถุดิบ"
        Me.ชื่อสูตรวัตถุดิบ.ReadOnly = True
        '
        'จำนวนที่ใช้
        '
        Me.จำนวนที่ใช้.HeaderText = "จำนวน"
        Me.จำนวนที่ใช้.Name = "จำนวนที่ใช้"
        Me.จำนวนที่ใช้.ReadOnly = True
        '
        'ToppingReceipeId2
        '
        Me.ToppingReceipeId2.HeaderText = "ToppingReceipeId2"
        Me.ToppingReceipeId2.Name = "ToppingReceipeId2"
        Me.ToppingReceipeId2.ReadOnly = True
        Me.ToppingReceipeId2.Visible = False
        '
        'MatToppingReceipeName
        '
        Me.MatToppingReceipeName.HeaderText = "ชื่อวัตถุดิบ"
        Me.MatToppingReceipeName.Name = "MatToppingReceipeName"
        Me.MatToppingReceipeName.ReadOnly = True
        '
        'จำนวนToppingReceipe
        '
        Me.จำนวนToppingReceipe.HeaderText = "จำนวน"
        Me.จำนวนToppingReceipe.Name = "จำนวนToppingReceipe"
        Me.จำนวนToppingReceipe.ReadOnly = True
        '
        'FrmToppings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 559)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmToppings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmToppings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RadDropDownListCateToppingSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewToppingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.RadDropDownListCateTopping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridViewShowMatToppingList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownListCategoryMatTopping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewToppingReceipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewToppingList As DataGridView
    Friend WithEvents txtNameSearch As TextBox
    Friend WithEvents btnCate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents RadDropDownListCateToppingSearch As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPricing As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtToppingCosting As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtToppingNameEN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNameTopping As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadDropDownListCateTopping As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtToppingCode As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridViewShowMatToppingList As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents RadDropDownListCategoryMatTopping As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnSearchMatTopping As Button
    Friend WithEvents txtMatTopping As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddToppingReceipe As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewToppingReceipe As DataGridView
    Friend WithEvents MatToppingReceipeName As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนToppingReceipe As DataGridViewTextBoxColumn
    Friend WithEvents ToppingId As DataGridViewTextBoxColumn
    Friend WithEvents CateTopping As DataGridViewTextBoxColumn
    Friend WithEvents ToppingName As DataGridViewTextBoxColumn
    Friend WithEvents ToppingCode As DataGridViewTextBoxColumn
    Friend WithEvents หมวดหมู่MatTopping As DataGridViewTextBoxColumn
    Friend WithEvents NameItemMatTopping As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนสต๊อก As DataGridViewTextBoxColumn
    Friend WithEvents MatItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeTopping As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสูตรวัตถุดิบ As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนที่ใช้ As DataGridViewTextBoxColumn
    Friend WithEvents ToppingReceipeId2 As DataGridViewTextBoxColumn
    'Friend WithEvents ToppingReceipeId As DataGridViewTextBoxColumn
End Class
