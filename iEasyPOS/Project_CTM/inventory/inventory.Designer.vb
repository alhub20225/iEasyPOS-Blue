<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControls = New System.Windows.Forms.TabControl()
        Me.TabAddAmount = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.สินค้า = New System.Windows.Forms.GroupBox()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.รหัสสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.หน่วย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคาต่อหน่วย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคาต่อหน่วยภาษี = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ต้นทุน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ต้นทุนรวมภาษี = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtTotalTax = New System.Windows.Forms.TextBox()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.LabelUnit = New System.Windows.Forms.Label()
        Me.TxtAmountRecive = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtinitCost = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtExtaxCost = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtSumTotalitemTax = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtSumTotalItem = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtAmountBalance = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.TxtUnitMultiply = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RadDropDownUnit = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtSrcItemName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSearchItemId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_edit_store = New System.Windows.Forms.Button()
        Me.btn_edit_supply = New System.Windows.Forms.Button()
        Me.RadDropDownStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.RadDropDownItemType = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadDateTimePickerReciveDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.TxtTaxId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadDropDownStore = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadDropDownSuplier = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadDateTimePickerinvoice = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.TxtreciveBill = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtReciveId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewShowRecive = New System.Windows.Forms.DataGridView()
        Me.วันที่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.รายการ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ผู้จัดจำหน่าย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.สถานะ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSrc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DaterimePickerSrcEnd = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.DaterimePickerSrcStart = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadDropDownSrcSupplier = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtSrc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabTakeAmount = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewShowTakeItem = New System.Windows.Forms.DataGridView()
        Me.รหัสสินค้า2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อสินค้า2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.หน่วย2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ต้นทุนต่อหน่วย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวน2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ต้นทุนรวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnSaveData = New System.Windows.Forms.Button()
        Me.BtnAddNewTake = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtTotalTakeUnitCost = New System.Windows.Forms.TextBox()
        Me.BtnDeleteData = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.LUnit = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtTotalUnitCost = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.BtnAddTakeItem = New System.Windows.Forms.Button()
        Me.TxtMultiply = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.RadDropDownListItemUnit = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtItemName = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TxtItemCode = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TxtTakeDetail = New System.Windows.Forms.RichTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.RadDropDownListStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownListTakeType = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.RadDateTimePickerTakeDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.RadDropDownListStore = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtTakeId = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewShowTake = New System.Windows.Forms.DataGridView()
        Me.วันที่เบิก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เลขที่การเบิก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.RadDateTimePickerDateSearchEnd = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadDateTimePickerDateSearchStart = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.RadDropDownListTakeTypeSearch = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Close_inven = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.TabControls.SuspendLayout()
        Me.TabAddAmount.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.สินค้า.SuspendLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.RadDropDownUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RadDropDownStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownItemType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePickerReciveDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownStore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePickerinvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewShowRecive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DaterimePickerSrcEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaterimePickerSrcStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownSrcSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTakeAmount.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DataGridViewShowTakeItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.RadDropDownListItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.RadDropDownListStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownListTakeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePickerTakeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownListStore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridViewShowTake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.RadDateTimePickerDateSearchEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePickerDateSearchStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownListTakeTypeSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "INVENTORY"
        '
        'TabControls
        '
        Me.TabControls.Controls.Add(Me.TabAddAmount)
        Me.TabControls.Controls.Add(Me.TabTakeAmount)
        Me.TabControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControls.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControls.Location = New System.Drawing.Point(0, 0)
        Me.TabControls.Name = "TabControls"
        Me.TabControls.SelectedIndex = 0
        Me.TabControls.Size = New System.Drawing.Size(1274, 775)
        Me.TabControls.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControls.TabIndex = 7
        '
        'TabAddAmount
        '
        Me.TabAddAmount.Controls.Add(Me.Panel7)
        Me.TabAddAmount.Controls.Add(Me.Panel6)
        Me.TabAddAmount.Controls.Add(Me.Panel5)
        Me.TabAddAmount.Controls.Add(Me.Panel4)
        Me.TabAddAmount.Controls.Add(Me.Panel3)
        Me.TabAddAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabAddAmount.Location = New System.Drawing.Point(4, 34)
        Me.TabAddAmount.Name = "TabAddAmount"
        Me.TabAddAmount.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAddAmount.Size = New System.Drawing.Size(1266, 737)
        Me.TabAddAmount.TabIndex = 4
        Me.TabAddAmount.Text = "รับ"
        Me.TabAddAmount.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(358, 240)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(905, 494)
        Me.Panel7.TabIndex = 11
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.สินค้า)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(905, 409)
        Me.Panel8.TabIndex = 10
        '
        'สินค้า
        '
        Me.สินค้า.Controls.Add(Me.DataGridViewItems)
        Me.สินค้า.Dock = System.Windows.Forms.DockStyle.Fill
        Me.สินค้า.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.สินค้า.Location = New System.Drawing.Point(0, 0)
        Me.สินค้า.Name = "สินค้า"
        Me.สินค้า.Size = New System.Drawing.Size(905, 409)
        Me.สินค้า.TabIndex = 7
        Me.สินค้า.TabStop = False
        Me.สินค้า.Text = "สินค้า"
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.AllowUserToAddRows = False
        Me.DataGridViewItems.AllowUserToDeleteRows = False
        Me.DataGridViewItems.AllowUserToResizeRows = False
        Me.DataGridViewItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัสสินค้า, Me.ชื่อสินค้า, Me.หน่วย, Me.ราคาต่อหน่วย, Me.ราคาต่อหน่วยภาษี, Me.จำนวน, Me.ต้นทุน, Me.ต้นทุนรวมภาษี})
        Me.DataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewItems.Location = New System.Drawing.Point(3, 23)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.ReadOnly = True
        Me.DataGridViewItems.RowHeadersVisible = False
        Me.DataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewItems.Size = New System.Drawing.Size(899, 383)
        Me.DataGridViewItems.TabIndex = 1
        '
        'รหัสสินค้า
        '
        Me.รหัสสินค้า.HeaderText = "รหัสสินค้า"
        Me.รหัสสินค้า.Name = "รหัสสินค้า"
        Me.รหัสสินค้า.ReadOnly = True
        Me.รหัสสินค้า.Width = 150
        '
        'ชื่อสินค้า
        '
        Me.ชื่อสินค้า.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อสินค้า.HeaderText = "ชื่อสินค้า"
        Me.ชื่อสินค้า.Name = "ชื่อสินค้า"
        Me.ชื่อสินค้า.ReadOnly = True
        '
        'หน่วย
        '
        Me.หน่วย.HeaderText = "หน่วย"
        Me.หน่วย.Name = "หน่วย"
        Me.หน่วย.ReadOnly = True
        '
        'ราคาต่อหน่วย
        '
        Me.ราคาต่อหน่วย.HeaderText = "ราคาต่อหน่วย"
        Me.ราคาต่อหน่วย.Name = "ราคาต่อหน่วย"
        Me.ราคาต่อหน่วย.ReadOnly = True
        Me.ราคาต่อหน่วย.Width = 120
        '
        'ราคาต่อหน่วยภาษี
        '
        Me.ราคาต่อหน่วยภาษี.HeaderText = "ราคาต่อหน่วยภาษี"
        Me.ราคาต่อหน่วยภาษี.Name = "ราคาต่อหน่วยภาษี"
        Me.ราคาต่อหน่วยภาษี.ReadOnly = True
        Me.ราคาต่อหน่วยภาษี.Width = 120
        '
        'จำนวน
        '
        Me.จำนวน.HeaderText = "จำนวน"
        Me.จำนวน.Name = "จำนวน"
        Me.จำนวน.ReadOnly = True
        '
        'ต้นทุน
        '
        Me.ต้นทุน.HeaderText = "ต้นทุน"
        Me.ต้นทุน.Name = "ต้นทุน"
        Me.ต้นทุน.ReadOnly = True
        Me.ต้นทุน.Width = 120
        '
        'ต้นทุนรวมภาษี
        '
        Me.ต้นทุนรวมภาษี.HeaderText = "ต้นทุนรวมภาษี"
        Me.ต้นทุนรวมภาษี.Name = "ต้นทุนรวมภาษี"
        Me.ต้นทุนรวมภาษี.ReadOnly = True
        Me.ต้นทุนรวมภาษี.Width = 120
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.TxtTotalTax)
        Me.Panel1.Controls.Add(Me.TxtSum)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 409)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 85)
        Me.Panel1.TabIndex = 9
        '
        'Label44
        '
        Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label44.Location = New System.Drawing.Point(368, 43)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(98, 24)
        Me.Label44.TabIndex = 37
        Me.Label44.Text = "ราคารวมภาษี:"
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label33.Location = New System.Drawing.Point(393, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 24)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "ราคารวม:"
        '
        'TxtTotalTax
        '
        Me.TxtTotalTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalTax.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.TxtTotalTax.Location = New System.Drawing.Point(466, 43)
        Me.TxtTotalTax.Name = "TxtTotalTax"
        Me.TxtTotalTax.Size = New System.Drawing.Size(132, 31)
        Me.TxtTotalTax.TabIndex = 35
        '
        'TxtSum
        '
        Me.TxtSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSum.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.TxtSum.Location = New System.Drawing.Point(466, 15)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.Size = New System.Drawing.Size(132, 31)
        Me.TxtSum.TabIndex = 34
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(801, 28)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(88, 35)
        Me.BtnDelete.TabIndex = 33
        Me.BtnDelete.Text = "ลบข้อมูล"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSave.Location = New System.Drawing.Point(703, 28)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(88, 35)
        Me.BtnSave.TabIndex = 32
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnClear.Location = New System.Drawing.Point(604, 28)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(88, 35)
        Me.BtnClear.TabIndex = 31
        Me.BtnClear.Text = "เพิ่มข้อมูล"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(358, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(905, 103)
        Me.Panel6.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelUnit)
        Me.GroupBox4.Controls.Add(Me.TxtAmountRecive)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.TxtinitCost)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.TxtExtaxCost)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TxtSumTotalitemTax)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TxtSumTotalItem)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TxtAmountBalance)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.BtnAddItem)
        Me.GroupBox4.Controls.Add(Me.TxtUnitMultiply)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.RadDropDownUnit)
        Me.GroupBox4.Controls.Add(Me.TxtSrcItemName)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtSearchItemId)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(905, 103)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "สินค้า"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label38.Location = New System.Drawing.Point(122, 87)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(113, 13)
        Me.Label38.TabIndex = 30
        Me.Label38.Text = "ใส่ตัวเลขเเล้วกด Enter"
        Me.Label38.Visible = False
        '
        'LabelUnit
        '
        Me.LabelUnit.AutoSize = True
        Me.LabelUnit.Location = New System.Drawing.Point(418, 66)
        Me.LabelUnit.Name = "LabelUnit"
        Me.LabelUnit.Size = New System.Drawing.Size(39, 19)
        Me.LabelUnit.TabIndex = 29
        Me.LabelUnit.Text = "หน่วย"
        Me.LabelUnit.Visible = False
        '
        'TxtAmountRecive
        '
        Me.TxtAmountRecive.Location = New System.Drawing.Point(240, 63)
        Me.TxtAmountRecive.Name = "TxtAmountRecive"
        Me.TxtAmountRecive.Size = New System.Drawing.Size(100, 27)
        Me.TxtAmountRecive.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(267, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 19)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "จำนวนรับ"
        '
        'TxtinitCost
        '
        Me.TxtinitCost.Location = New System.Drawing.Point(125, 63)
        Me.TxtinitCost.Name = "TxtinitCost"
        Me.TxtinitCost.Size = New System.Drawing.Size(100, 27)
        Me.TxtinitCost.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(146, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 19)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "ทุนรวมภาษี"
        '
        'TxtExtaxCost
        '
        Me.TxtExtaxCost.Location = New System.Drawing.Point(13, 63)
        Me.TxtExtaxCost.Name = "TxtExtaxCost"
        Me.TxtExtaxCost.ReadOnly = True
        Me.TxtExtaxCost.Size = New System.Drawing.Size(100, 27)
        Me.TxtExtaxCost.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(25, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 19)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "ทุนก่อนภาษี"
        '
        'TxtSumTotalitemTax
        '
        Me.TxtSumTotalitemTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSumTotalitemTax.Location = New System.Drawing.Point(722, 63)
        Me.TxtSumTotalitemTax.Name = "TxtSumTotalitemTax"
        Me.TxtSumTotalitemTax.ReadOnly = True
        Me.TxtSumTotalitemTax.Size = New System.Drawing.Size(86, 27)
        Me.TxtSumTotalitemTax.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(727, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 19)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "ต้นทุนรวมภาษี"
        '
        'TxtSumTotalItem
        '
        Me.TxtSumTotalItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSumTotalItem.Location = New System.Drawing.Point(613, 63)
        Me.TxtSumTotalItem.Name = "TxtSumTotalItem"
        Me.TxtSumTotalItem.ReadOnly = True
        Me.TxtSumTotalItem.Size = New System.Drawing.Size(103, 27)
        Me.TxtSumTotalItem.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(641, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 19)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "ราคารวม"
        '
        'TxtAmountBalance
        '
        Me.TxtAmountBalance.Location = New System.Drawing.Point(346, 63)
        Me.TxtAmountBalance.Name = "TxtAmountBalance"
        Me.TxtAmountBalance.ReadOnly = True
        Me.TxtAmountBalance.Size = New System.Drawing.Size(71, 27)
        Me.TxtAmountBalance.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(346, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 19)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "จำนวนที่เหลือ"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddItem.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAddItem.Location = New System.Drawing.Point(814, 19)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(85, 66)
        Me.BtnAddItem.TabIndex = 16
        Me.BtnAddItem.Text = "เพิ่ม"
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'TxtUnitMultiply
        '
        Me.TxtUnitMultiply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUnitMultiply.Location = New System.Drawing.Point(722, 18)
        Me.TxtUnitMultiply.Name = "TxtUnitMultiply"
        Me.TxtUnitMultiply.ReadOnly = True
        Me.TxtUnitMultiply.Size = New System.Drawing.Size(86, 27)
        Me.TxtUnitMultiply.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(572, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 19)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "หน่วย"
        '
        'RadDropDownUnit
        '
        Me.RadDropDownUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownUnit.Location = New System.Drawing.Point(613, 19)
        Me.RadDropDownUnit.Name = "RadDropDownUnit"
        Me.RadDropDownUnit.Size = New System.Drawing.Size(103, 23)
        Me.RadDropDownUnit.TabIndex = 13
        '
        'TxtSrcItemName
        '
        Me.TxtSrcItemName.Location = New System.Drawing.Point(258, 18)
        Me.TxtSrcItemName.Name = "TxtSrcItemName"
        Me.TxtSrcItemName.Size = New System.Drawing.Size(306, 27)
        Me.TxtSrcItemName.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(205, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 19)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "ชื่อสินค้า"
        '
        'TxtSearchItemId
        '
        Me.TxtSearchItemId.Location = New System.Drawing.Point(72, 18)
        Me.TxtSearchItemId.Name = "TxtSearchItemId"
        Me.TxtSearchItemId.Size = New System.Drawing.Size(125, 27)
        Me.TxtSearchItemId.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 19)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "รหัสสินค้า"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(358, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(905, 134)
        Me.Panel5.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_edit_store)
        Me.GroupBox3.Controls.Add(Me.btn_edit_supply)
        Me.GroupBox3.Controls.Add(Me.RadDropDownStatus)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.RadDropDownItemType)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.RadDateTimePickerReciveDate)
        Me.GroupBox3.Controls.Add(Me.TxtTaxId)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.RadDropDownStore)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.RadDropDownSuplier)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.RadDateTimePickerinvoice)
        Me.GroupBox3.Controls.Add(Me.TxtreciveBill)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtReciveId)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(905, 134)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายละเอียด"
        '
        'btn_edit_store
        '
        Me.btn_edit_store.BackgroundImage = Global.Project_CTM.My.Resources.Resources.edit
        Me.btn_edit_store.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit_store.FlatAppearance.BorderSize = 0
        Me.btn_edit_store.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_store.Location = New System.Drawing.Point(501, 51)
        Me.btn_edit_store.Name = "btn_edit_store"
        Me.btn_edit_store.Size = New System.Drawing.Size(30, 31)
        Me.btn_edit_store.TabIndex = 23
        Me.btn_edit_store.UseVisualStyleBackColor = True
        '
        'btn_edit_supply
        '
        Me.btn_edit_supply.BackgroundImage = Global.Project_CTM.My.Resources.Resources.edit
        Me.btn_edit_supply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit_supply.FlatAppearance.BorderSize = 0
        Me.btn_edit_supply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_supply.Location = New System.Drawing.Point(501, 18)
        Me.btn_edit_supply.Name = "btn_edit_supply"
        Me.btn_edit_supply.Size = New System.Drawing.Size(30, 31)
        Me.btn_edit_supply.TabIndex = 22
        Me.btn_edit_supply.UseVisualStyleBackColor = True
        '
        'RadDropDownStatus
        '
        Me.RadDropDownStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownStatus.Location = New System.Drawing.Point(626, 55)
        Me.RadDropDownStatus.Name = "RadDropDownStatus"
        Me.RadDropDownStatus.Size = New System.Drawing.Size(137, 23)
        Me.RadDropDownStatus.TabIndex = 21
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(546, 59)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 19)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "สถานะ:"
        '
        'RadDropDownItemType
        '
        Me.RadDropDownItemType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownItemType.Location = New System.Drawing.Point(626, 90)
        Me.RadDropDownItemType.Name = "RadDropDownItemType"
        Me.RadDropDownItemType.Size = New System.Drawing.Size(137, 23)
        Me.RadDropDownItemType.TabIndex = 19
        Me.RadDropDownItemType.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(542, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 19)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "ประเภทสินค้า"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(537, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "วันที่รับเข้า"
        '
        'RadDateTimePickerReciveDate
        '
        Me.RadDateTimePickerReciveDate.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.RadDateTimePickerReciveDate.Location = New System.Drawing.Point(626, 25)
        Me.RadDateTimePickerReciveDate.Name = "RadDateTimePickerReciveDate"
        Me.RadDateTimePickerReciveDate.Size = New System.Drawing.Size(137, 25)
        Me.RadDateTimePickerReciveDate.TabIndex = 15
        Me.RadDateTimePickerReciveDate.TabStop = False
        Me.RadDateTimePickerReciveDate.Text = "22 มกราคม 2561"
        Me.RadDateTimePickerReciveDate.Value = New Date(2018, 1, 22, 0, 0, 0, 0)
        '
        'TxtTaxId
        '
        Me.TxtTaxId.Location = New System.Drawing.Point(376, 86)
        Me.TxtTaxId.Name = "TxtTaxId"
        Me.TxtTaxId.Size = New System.Drawing.Size(141, 27)
        Me.TxtTaxId.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "เลขที่ใบกำกับภาษี"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Store"
        '
        'RadDropDownStore
        '
        Me.RadDropDownStore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownStore.Location = New System.Drawing.Point(375, 55)
        Me.RadDropDownStore.Name = "RadDropDownStore"
        Me.RadDropDownStore.Size = New System.Drawing.Size(120, 23)
        Me.RadDropDownStore.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "ผู้จัดจำหน่าย"
        '
        'RadDropDownSuplier
        '
        Me.RadDropDownSuplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownSuplier.Location = New System.Drawing.Point(376, 22)
        Me.RadDropDownSuplier.Name = "RadDropDownSuplier"
        Me.RadDropDownSuplier.Size = New System.Drawing.Size(119, 23)
        Me.RadDropDownSuplier.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "วันที่ใบส่งของ"
        '
        'RadDateTimePickerinvoice
        '
        Me.RadDateTimePickerinvoice.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.RadDateTimePickerinvoice.Location = New System.Drawing.Point(123, 88)
        Me.RadDateTimePickerinvoice.Name = "RadDateTimePickerinvoice"
        Me.RadDateTimePickerinvoice.Size = New System.Drawing.Size(137, 25)
        Me.RadDateTimePickerinvoice.TabIndex = 7
        Me.RadDateTimePickerinvoice.TabStop = False
        Me.RadDateTimePickerinvoice.Text = "22 มกราคม 2561"
        Me.RadDateTimePickerinvoice.Value = New Date(2018, 1, 22, 0, 0, 0, 0)
        '
        'TxtreciveBill
        '
        Me.TxtreciveBill.Location = New System.Drawing.Point(124, 56)
        Me.TxtreciveBill.Name = "TxtreciveBill"
        Me.TxtreciveBill.Size = New System.Drawing.Size(136, 27)
        Me.TxtreciveBill.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ใบส่งของเลขที่"
        '
        'TxtReciveId
        '
        Me.TxtReciveId.Location = New System.Drawing.Point(125, 23)
        Me.TxtReciveId.Name = "TxtReciveId"
        Me.TxtReciveId.ReadOnly = True
        Me.TxtReciveId.Size = New System.Drawing.Size(136, 27)
        Me.TxtReciveId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เลขที่ใบรับสินค้า"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(342, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(16, 731)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(339, 731)
        Me.Panel3.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewShowRecive)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 597)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายการรับสินค้า"
        '
        'DataGridViewShowRecive
        '
        Me.DataGridViewShowRecive.AllowUserToAddRows = False
        Me.DataGridViewShowRecive.AllowUserToDeleteRows = False
        Me.DataGridViewShowRecive.AllowUserToResizeRows = False
        Me.DataGridViewShowRecive.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewShowRecive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowRecive.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่, Me.รายการ, Me.ผู้จัดจำหน่าย, Me.สถานะ})
        Me.DataGridViewShowRecive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewShowRecive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewShowRecive.Location = New System.Drawing.Point(3, 23)
        Me.DataGridViewShowRecive.Name = "DataGridViewShowRecive"
        Me.DataGridViewShowRecive.ReadOnly = True
        Me.DataGridViewShowRecive.RowHeadersVisible = False
        Me.DataGridViewShowRecive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewShowRecive.Size = New System.Drawing.Size(333, 571)
        Me.DataGridViewShowRecive.TabIndex = 0
        '
        'วันที่
        '
        Me.วันที่.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        'ผู้จัดจำหน่าย
        '
        Me.ผู้จัดจำหน่าย.HeaderText = "ผู้จัดจำหน่าย"
        Me.ผู้จัดจำหน่าย.Name = "ผู้จัดจำหน่าย"
        Me.ผู้จัดจำหน่าย.ReadOnly = True
        '
        'สถานะ
        '
        Me.สถานะ.HeaderText = "สถานะ"
        Me.สถานะ.Name = "สถานะ"
        Me.สถานะ.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSrc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DaterimePickerSrcEnd)
        Me.GroupBox1.Controls.Add(Me.DaterimePickerSrcStart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RadDropDownSrcSupplier)
        Me.GroupBox1.Controls.Add(Me.TxtSrc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 134)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหา"
        '
        'BtnSrc
        '
        Me.BtnSrc.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSrc.Location = New System.Drawing.Point(212, 74)
        Me.BtnSrc.Name = "BtnSrc"
        Me.BtnSrc.Size = New System.Drawing.Size(85, 48)
        Me.BtnSrc.TabIndex = 10
        Me.BtnSrc.Text = "ค้นหา"
        Me.BtnSrc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ถึงวันที่:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "วันที่ :"
        '
        'DaterimePickerSrcEnd
        '
        Me.DaterimePickerSrcEnd.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.DaterimePickerSrcEnd.Location = New System.Drawing.Point(89, 102)
        Me.DaterimePickerSrcEnd.Name = "DaterimePickerSrcEnd"
        Me.DaterimePickerSrcEnd.Size = New System.Drawing.Size(117, 25)
        Me.DaterimePickerSrcEnd.TabIndex = 7
        Me.DaterimePickerSrcEnd.TabStop = False
        Me.DaterimePickerSrcEnd.Text = "22 มกราคม 2561"
        Me.DaterimePickerSrcEnd.Value = New Date(2018, 1, 22, 0, 0, 0, 0)
        '
        'DaterimePickerSrcStart
        '
        Me.DaterimePickerSrcStart.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.DaterimePickerSrcStart.Location = New System.Drawing.Point(89, 74)
        Me.DaterimePickerSrcStart.Name = "DaterimePickerSrcStart"
        Me.DaterimePickerSrcStart.Size = New System.Drawing.Size(117, 25)
        Me.DaterimePickerSrcStart.TabIndex = 6
        Me.DaterimePickerSrcStart.TabStop = False
        Me.DaterimePickerSrcStart.Text = "22 มกราคม 2561"
        Me.DaterimePickerSrcStart.Value = New Date(2018, 1, 22, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ผู้จัดจำหน่าย:"
        '
        'RadDropDownSrcSupplier
        '
        Me.RadDropDownSrcSupplier.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.RadDropDownSrcSupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownSrcSupplier.Location = New System.Drawing.Point(89, 45)
        Me.RadDropDownSrcSupplier.Name = "RadDropDownSrcSupplier"
        Me.RadDropDownSrcSupplier.Size = New System.Drawing.Size(208, 23)
        Me.RadDropDownSrcSupplier.TabIndex = 4
        '
        'TxtSrc
        '
        Me.TxtSrc.Location = New System.Drawing.Point(89, 17)
        Me.TxtSrc.Name = "TxtSrc"
        Me.TxtSrc.Size = New System.Drawing.Size(208, 27)
        Me.TxtSrc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ค้นหา:"
        '
        'TabTakeAmount
        '
        Me.TabTakeAmount.Controls.Add(Me.GroupBox9)
        Me.TabTakeAmount.Controls.Add(Me.Panel16)
        Me.TabTakeAmount.Controls.Add(Me.Panel14)
        Me.TabTakeAmount.Controls.Add(Me.Panel13)
        Me.TabTakeAmount.Controls.Add(Me.Panel12)
        Me.TabTakeAmount.Controls.Add(Me.Panel9)
        Me.TabTakeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabTakeAmount.Location = New System.Drawing.Point(4, 34)
        Me.TabTakeAmount.Name = "TabTakeAmount"
        Me.TabTakeAmount.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTakeAmount.Size = New System.Drawing.Size(1266, 737)
        Me.TabTakeAmount.TabIndex = 5
        Me.TabTakeAmount.Text = "เบิก"
        Me.TabTakeAmount.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DataGridViewShowTakeItem)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox9.Location = New System.Drawing.Point(348, 219)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(915, 415)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        '
        'DataGridViewShowTakeItem
        '
        Me.DataGridViewShowTakeItem.AllowUserToAddRows = False
        Me.DataGridViewShowTakeItem.AllowUserToDeleteRows = False
        Me.DataGridViewShowTakeItem.AllowUserToResizeRows = False
        Me.DataGridViewShowTakeItem.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewShowTakeItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowTakeItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัสสินค้า2, Me.ชื่อสินค้า2, Me.หน่วย2, Me.ต้นทุนต่อหน่วย, Me.จำนวน2, Me.ต้นทุนรวม})
        Me.DataGridViewShowTakeItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewShowTakeItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewShowTakeItem.Location = New System.Drawing.Point(3, 23)
        Me.DataGridViewShowTakeItem.Name = "DataGridViewShowTakeItem"
        Me.DataGridViewShowTakeItem.ReadOnly = True
        Me.DataGridViewShowTakeItem.RowHeadersVisible = False
        Me.DataGridViewShowTakeItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewShowTakeItem.Size = New System.Drawing.Size(909, 389)
        Me.DataGridViewShowTakeItem.TabIndex = 3
        '
        'รหัสสินค้า2
        '
        Me.รหัสสินค้า2.HeaderText = "รหัสสินค้า"
        Me.รหัสสินค้า2.Name = "รหัสสินค้า2"
        Me.รหัสสินค้า2.ReadOnly = True
        '
        'ชื่อสินค้า2
        '
        Me.ชื่อสินค้า2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อสินค้า2.HeaderText = "ชื่อสินค้า"
        Me.ชื่อสินค้า2.Name = "ชื่อสินค้า2"
        Me.ชื่อสินค้า2.ReadOnly = True
        '
        'หน่วย2
        '
        Me.หน่วย2.HeaderText = "หน่วย"
        Me.หน่วย2.Name = "หน่วย2"
        Me.หน่วย2.ReadOnly = True
        '
        'ต้นทุนต่อหน่วย
        '
        Me.ต้นทุนต่อหน่วย.HeaderText = "ต้นทุนต่อหน่วย"
        Me.ต้นทุนต่อหน่วย.Name = "ต้นทุนต่อหน่วย"
        Me.ต้นทุนต่อหน่วย.ReadOnly = True
        '
        'จำนวน2
        '
        Me.จำนวน2.HeaderText = "จำนวน"
        Me.จำนวน2.Name = "จำนวน2"
        Me.จำนวน2.ReadOnly = True
        '
        'ต้นทุนรวม
        '
        Me.ต้นทุนรวม.HeaderText = "ต้นทุนรวม"
        Me.ต้นทุนรวม.Name = "ต้นทุนรวม"
        Me.ต้นทุนรวม.ReadOnly = True
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.BtnSaveData)
        Me.Panel16.Controls.Add(Me.BtnAddNewTake)
        Me.Panel16.Controls.Add(Me.Label36)
        Me.Panel16.Controls.Add(Me.TxtTotalTakeUnitCost)
        Me.Panel16.Controls.Add(Me.BtnDeleteData)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Location = New System.Drawing.Point(348, 634)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(915, 100)
        Me.Panel16.TabIndex = 30
        '
        'BtnSaveData
        '
        Me.BtnSaveData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveData.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSaveData.Location = New System.Drawing.Point(693, 59)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(102, 35)
        Me.BtnSaveData.TabIndex = 23
        Me.BtnSaveData.Text = "บันทึกข้อมูล"
        Me.BtnSaveData.UseVisualStyleBackColor = True
        '
        'BtnAddNewTake
        '
        Me.BtnAddNewTake.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNewTake.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnAddNewTake.Location = New System.Drawing.Point(585, 59)
        Me.BtnAddNewTake.Name = "BtnAddNewTake"
        Me.BtnAddNewTake.Size = New System.Drawing.Size(102, 35)
        Me.BtnAddNewTake.TabIndex = 17
        Me.BtnAddNewTake.Text = "เพิ่มข้อมูล"
        Me.BtnAddNewTake.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label36.Location = New System.Drawing.Point(690, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 24)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "ราคารวม :"
        '
        'TxtTotalTakeUnitCost
        '
        Me.TxtTotalTakeUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalTakeUnitCost.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.TxtTotalTakeUnitCost.Location = New System.Drawing.Point(767, 13)
        Me.TxtTotalTakeUnitCost.Name = "TxtTotalTakeUnitCost"
        Me.TxtTotalTakeUnitCost.Size = New System.Drawing.Size(136, 31)
        Me.TxtTotalTakeUnitCost.TabIndex = 22
        Me.TxtTotalTakeUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnDeleteData
        '
        Me.BtnDeleteData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteData.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnDeleteData.Location = New System.Drawing.Point(801, 59)
        Me.BtnDeleteData.Name = "BtnDeleteData"
        Me.BtnDeleteData.Size = New System.Drawing.Size(102, 35)
        Me.BtnDeleteData.TabIndex = 24
        Me.BtnDeleteData.Text = "ลบข้อมูล"
        Me.BtnDeleteData.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.GroupBox10)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(348, 119)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(915, 100)
        Me.Panel14.TabIndex = 28
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.LUnit)
        Me.GroupBox10.Controls.Add(Me.TxtAmount)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Controls.Add(Me.TxtUnitCost)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.TxtTotalUnitCost)
        Me.GroupBox10.Controls.Add(Me.Label39)
        Me.GroupBox10.Controls.Add(Me.TxtStock)
        Me.GroupBox10.Controls.Add(Me.Label40)
        Me.GroupBox10.Controls.Add(Me.BtnAddTakeItem)
        Me.GroupBox10.Controls.Add(Me.TxtMultiply)
        Me.GroupBox10.Controls.Add(Me.Label41)
        Me.GroupBox10.Controls.Add(Me.RadDropDownListItemUnit)
        Me.GroupBox10.Controls.Add(Me.TxtItemName)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.TxtItemCode)
        Me.GroupBox10.Controls.Add(Me.Label43)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(915, 100)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "สินค้า"
        '
        'LUnit
        '
        Me.LUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LUnit.AutoSize = True
        Me.LUnit.Location = New System.Drawing.Point(623, 68)
        Me.LUnit.Name = "LUnit"
        Me.LUnit.Size = New System.Drawing.Size(39, 19)
        Me.LUnit.TabIndex = 30
        Me.LUnit.Text = "หน่วย"
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(124, 65)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(102, 27)
        Me.TxtAmount.TabIndex = 28
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(152, 46)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 19)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "จำนวน"
        '
        'TxtUnitCost
        '
        Me.TxtUnitCost.Location = New System.Drawing.Point(13, 65)
        Me.TxtUnitCost.Name = "TxtUnitCost"
        Me.TxtUnitCost.ReadOnly = True
        Me.TxtUnitCost.Size = New System.Drawing.Size(102, 27)
        Me.TxtUnitCost.TabIndex = 24
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(25, 49)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(87, 19)
        Me.Label37.TabIndex = 23
        Me.Label37.Text = "ต้นทุน / หน่วย"
        '
        'TxtTotalUnitCost
        '
        Me.TxtTotalUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalUnitCost.Location = New System.Drawing.Point(714, 65)
        Me.TxtTotalUnitCost.Name = "TxtTotalUnitCost"
        Me.TxtTotalUnitCost.ReadOnly = True
        Me.TxtTotalUnitCost.Size = New System.Drawing.Size(96, 27)
        Me.TxtTotalUnitCost.TabIndex = 20
        '
        'Label39
        '
        Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(740, 49)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 19)
        Me.Label39.TabIndex = 19
        Me.Label39.Text = "ต้นทุนรวม"
        '
        'TxtStock
        '
        Me.TxtStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStock.Location = New System.Drawing.Point(520, 65)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(97, 27)
        Me.TxtStock.TabIndex = 18
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(526, 49)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(79, 19)
        Me.Label40.TabIndex = 17
        Me.Label40.Text = "จำนวนที่เหลือ"
        '
        'BtnAddTakeItem
        '
        Me.BtnAddTakeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddTakeItem.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAddTakeItem.Location = New System.Drawing.Point(827, 17)
        Me.BtnAddTakeItem.Name = "BtnAddTakeItem"
        Me.BtnAddTakeItem.Size = New System.Drawing.Size(85, 64)
        Me.BtnAddTakeItem.TabIndex = 16
        Me.BtnAddTakeItem.Text = "เพิ่ม"
        Me.BtnAddTakeItem.UseVisualStyleBackColor = True
        '
        'TxtMultiply
        '
        Me.TxtMultiply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMultiply.Location = New System.Drawing.Point(724, 17)
        Me.TxtMultiply.Name = "TxtMultiply"
        Me.TxtMultiply.ReadOnly = True
        Me.TxtMultiply.Size = New System.Drawing.Size(96, 27)
        Me.TxtMultiply.TabIndex = 15
        '
        'Label41
        '
        Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(581, 21)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(39, 19)
        Me.Label41.TabIndex = 14
        Me.Label41.Text = "หน่วย"
        '
        'RadDropDownListItemUnit
        '
        Me.RadDropDownListItemUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownListItemUnit.AutoSizeItems = True
        Me.RadDropDownListItemUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListItemUnit.Location = New System.Drawing.Point(622, 17)
        Me.RadDropDownListItemUnit.Name = "RadDropDownListItemUnit"
        Me.RadDropDownListItemUnit.Size = New System.Drawing.Size(92, 23)
        Me.RadDropDownListItemUnit.TabIndex = 13
        '
        'TxtItemName
        '
        Me.TxtItemName.Location = New System.Drawing.Point(242, 17)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(338, 27)
        Me.TxtItemName.TabIndex = 5
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(188, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(54, 19)
        Me.Label42.TabIndex = 4
        Me.Label42.Text = "ชื่อสินค้า"
        '
        'TxtItemCode
        '
        Me.TxtItemCode.Location = New System.Drawing.Point(72, 17)
        Me.TxtItemCode.Name = "TxtItemCode"
        Me.TxtItemCode.Size = New System.Drawing.Size(107, 27)
        Me.TxtItemCode.TabIndex = 3
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(10, 20)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(62, 19)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "รหัสสินค้า"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.GroupBox6)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(348, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(915, 116)
        Me.Panel13.TabIndex = 27
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label45)
        Me.GroupBox6.Controls.Add(Me.TxtTakeDetail)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.TxtTitle)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.RadDropDownListStatus)
        Me.GroupBox6.Controls.Add(Me.RadDropDownListTakeType)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.RadDateTimePickerTakeDate)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.RadDropDownListStore)
        Me.GroupBox6.Controls.Add(Me.TxtTakeId)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(915, 116)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "รายละเอียด"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(306, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(76, 19)
        Me.Label45.TabIndex = 24
        Me.Label45.Text = "รายละเอียด :"
        '
        'TxtTakeDetail
        '
        Me.TxtTakeDetail.Location = New System.Drawing.Point(410, 52)
        Me.TxtTakeDetail.Name = "TxtTakeDetail"
        Me.TxtTakeDetail.Size = New System.Drawing.Size(155, 51)
        Me.TxtTakeDetail.TabIndex = 23
        Me.TxtTakeDetail.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(306, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(86, 19)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "หัวข้อการเบิก :"
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(410, 19)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(155, 27)
        Me.TxtTitle.TabIndex = 11
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(599, 19)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 19)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "สถานะ :"
        '
        'RadDropDownListStatus
        '
        Me.RadDropDownListStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListStatus.Location = New System.Drawing.Point(702, 17)
        Me.RadDropDownListStatus.Name = "RadDropDownListStatus"
        Me.RadDropDownListStatus.Size = New System.Drawing.Size(169, 23)
        Me.RadDropDownListStatus.TabIndex = 20
        '
        'RadDropDownListTakeType
        '
        Me.RadDropDownListTakeType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListTakeType.Location = New System.Drawing.Point(702, 49)
        Me.RadDropDownListTakeType.Name = "RadDropDownListTakeType"
        Me.RadDropDownListTakeType.Size = New System.Drawing.Size(169, 23)
        Me.RadDropDownListTakeType.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(599, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 19)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "ประเภทการเบิก :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(24, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 19)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "วันที่เบิก :"
        '
        'RadDateTimePickerTakeDate
        '
        Me.RadDateTimePickerTakeDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDateTimePickerTakeDate.Location = New System.Drawing.Point(135, 52)
        Me.RadDateTimePickerTakeDate.Name = "RadDateTimePickerTakeDate"
        Me.RadDateTimePickerTakeDate.Size = New System.Drawing.Size(155, 23)
        Me.RadDateTimePickerTakeDate.TabIndex = 15
        Me.RadDateTimePickerTakeDate.TabStop = False
        Me.RadDateTimePickerTakeDate.Text = "16 มกราคม 2561"
        Me.RadDateTimePickerTakeDate.Value = New Date(2018, 1, 16, 16, 22, 51, 497)
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(24, 80)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 19)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Store :"
        '
        'RadDropDownListStore
        '
        Me.RadDropDownListStore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListStore.Location = New System.Drawing.Point(135, 78)
        Me.RadDropDownListStore.Name = "RadDropDownListStore"
        Me.RadDropDownListStore.Size = New System.Drawing.Size(155, 23)
        Me.RadDropDownListStore.TabIndex = 11
        '
        'TxtTakeId
        '
        Me.TxtTakeId.Location = New System.Drawing.Point(135, 19)
        Me.TxtTakeId.Name = "TxtTakeId"
        Me.TxtTakeId.ReadOnly = True
        Me.TxtTakeId.Size = New System.Drawing.Size(155, 27)
        Me.TxtTakeId.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(23, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(106, 19)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "เลขที่ใบเบิกสินค้า :"
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(332, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(16, 731)
        Me.Panel12.TabIndex = 26
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(329, 731)
        Me.Panel9.TabIndex = 25
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.GroupBox8)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 148)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(329, 583)
        Me.Panel11.TabIndex = 8
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DataGridViewShowTake)
        Me.GroupBox8.Controls.Add(Me.DataGridView5)
        Me.GroupBox8.Controls.Add(Me.DataGridView3)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(329, 583)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "รายละเอียดสินค้า"
        '
        'DataGridViewShowTake
        '
        Me.DataGridViewShowTake.AllowUserToAddRows = False
        Me.DataGridViewShowTake.AllowUserToDeleteRows = False
        Me.DataGridViewShowTake.AllowUserToResizeRows = False
        Me.DataGridViewShowTake.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewShowTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowTake.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่เบิก, Me.เลขที่การเบิก, Me.TakeType})
        Me.DataGridViewShowTake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewShowTake.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewShowTake.Location = New System.Drawing.Point(3, 23)
        Me.DataGridViewShowTake.Name = "DataGridViewShowTake"
        Me.DataGridViewShowTake.ReadOnly = True
        Me.DataGridViewShowTake.RowHeadersVisible = False
        Me.DataGridViewShowTake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewShowTake.Size = New System.Drawing.Size(323, 557)
        Me.DataGridViewShowTake.TabIndex = 2
        '
        'วันที่เบิก
        '
        Me.วันที่เบิก.HeaderText = "วันที่เบิก"
        Me.วันที่เบิก.Name = "วันที่เบิก"
        Me.วันที่เบิก.ReadOnly = True
        Me.วันที่เบิก.Width = 90
        '
        'เลขที่การเบิก
        '
        Me.เลขที่การเบิก.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.เลขที่การเบิก.HeaderText = "เลขที่การเบิก"
        Me.เลขที่การเบิก.Name = "เลขที่การเบิก"
        Me.เลขที่การเบิก.ReadOnly = True
        '
        'TakeType
        '
        Me.TakeType.HeaderText = "ปรเภทการเบิก"
        Me.TakeType.Name = "TakeType"
        Me.TakeType.ReadOnly = True
        '
        'DataGridView5
        '
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView5.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(323, 557)
        Me.DataGridView5.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(323, 557)
        Me.DataGridView3.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GroupBox7)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(329, 148)
        Me.Panel10.TabIndex = 7
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnSearch)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.RadDateTimePickerDateSearchEnd)
        Me.GroupBox7.Controls.Add(Me.RadDateTimePickerDateSearchStart)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.RadDropDownListTakeTypeSearch)
        Me.GroupBox7.Controls.Add(Me.txtSearch)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(329, 148)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ค้นหา"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(211, 76)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 51)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 19)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "ถึงวันที่:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(38, 19)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "วันที่ :"
        '
        'RadDateTimePickerDateSearchEnd
        '
        Me.RadDateTimePickerDateSearchEnd.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.RadDateTimePickerDateSearchEnd.Location = New System.Drawing.Point(88, 104)
        Me.RadDateTimePickerDateSearchEnd.Name = "RadDateTimePickerDateSearchEnd"
        Me.RadDateTimePickerDateSearchEnd.Size = New System.Drawing.Size(117, 25)
        Me.RadDateTimePickerDateSearchEnd.TabIndex = 7
        Me.RadDateTimePickerDateSearchEnd.TabStop = False
        Me.RadDateTimePickerDateSearchEnd.Text = "16 มกราคม 2561"
        Me.RadDateTimePickerDateSearchEnd.Value = New Date(2018, 1, 16, 16, 22, 51, 497)
        '
        'RadDateTimePickerDateSearchStart
        '
        Me.RadDateTimePickerDateSearchStart.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.RadDateTimePickerDateSearchStart.Location = New System.Drawing.Point(88, 76)
        Me.RadDateTimePickerDateSearchStart.Name = "RadDateTimePickerDateSearchStart"
        Me.RadDateTimePickerDateSearchStart.Size = New System.Drawing.Size(117, 25)
        Me.RadDateTimePickerDateSearchStart.TabIndex = 6
        Me.RadDateTimePickerDateSearchStart.TabStop = False
        Me.RadDateTimePickerDateSearchStart.Text = "16 มกราคม 2561"
        Me.RadDateTimePickerDateSearchStart.Value = New Date(2018, 1, 16, 16, 22, 51, 497)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 46)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 19)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "ประเภทการเบิก :"
        '
        'RadDropDownListTakeTypeSearch
        '
        Me.RadDropDownListTakeTypeSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListTakeTypeSearch.Location = New System.Drawing.Point(105, 48)
        Me.RadDropDownListTakeTypeSearch.Name = "RadDropDownListTakeTypeSearch"
        Me.RadDropDownListTakeTypeSearch.Size = New System.Drawing.Size(191, 23)
        Me.RadDropDownListTakeTypeSearch.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(88, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(208, 27)
        Me.txtSearch.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 19)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "ค้นหา:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControls)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1276, 777)
        Me.Panel2.TabIndex = 9
        '
        'Close_inven
        '
        Me.Close_inven.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_inven.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Close_inven.FlatAppearance.BorderSize = 0
        Me.Close_inven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_inven.Image = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.Close_inven.Location = New System.Drawing.Point(1215, 1)
        Me.Close_inven.Name = "Close_inven"
        Me.Close_inven.Size = New System.Drawing.Size(59, 56)
        Me.Close_inven.TabIndex = 4
        Me.Close_inven.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(1276, 58)
        Me.Top_tap.TabIndex = 5
        Me.Top_tap.TabStop = False
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 835)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close_inven)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControls.ResumeLayout(False)
        Me.TabAddAmount.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.สินค้า.ResumeLayout(False)
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.RadDropDownUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.RadDropDownStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownItemType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePickerReciveDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownStore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePickerinvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewShowRecive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DaterimePickerSrcEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaterimePickerSrcStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownSrcSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTakeAmount.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DataGridViewShowTakeItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.RadDropDownListItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.RadDropDownListStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownListTakeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePickerTakeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownListStore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DataGridViewShowTake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.RadDateTimePickerDateSearchEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePickerDateSearchStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownListTakeTypeSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Close_inven As Button
    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents TabControls As TabControl
    Friend WithEvents TabAddAmount As TabPage
    Friend WithEvents TabTakeAmount As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtAmountRecive As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtinitCost As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtExtaxCost As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtSumTotalitemTax As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtSumTotalItem As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtAmountBalance As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents TxtUnitMultiply As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents RadDropDownUnit As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TxtSrcItemName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSearchItemId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadDropDownItemType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RadDateTimePickerReciveDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TxtTaxId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RadDropDownStore As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label9 As Label
    Friend WithEvents RadDropDownSuplier As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label8 As Label
    Friend WithEvents RadDateTimePickerinvoice As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TxtreciveBill As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtReciveId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents DataGridViewShowTakeItem As DataGridView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TxtUnitCost As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents TxtTotalUnitCost As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents BtnAddTakeItem As Button
    Friend WithEvents TxtMultiply As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents RadDropDownListItemUnit As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TxtItemName As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents TxtItemCode As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents DataGridViewShowTake As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents RadDropDownListStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label23 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents RadDateTimePickerTakeDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents RadDropDownListStore As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TxtTakeId As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents RadDateTimePickerDateSearchEnd As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadDateTimePickerDateSearchStart As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents RadDropDownListTakeTypeSearch As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents RadDropDownStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents สินค้า As GroupBox
    Friend WithEvents DataGridViewItems As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewShowRecive As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSrc As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DaterimePickerSrcEnd As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents DaterimePickerSrcStart As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents RadDropDownSrcSupplier As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TxtSrc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtTotalTax As TextBox
    Friend WithEvents TxtSum As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents รหัสสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents หน่วย As DataGridViewTextBoxColumn
    Friend WithEvents ราคาต่อหน่วย As DataGridViewTextBoxColumn
    Friend WithEvents ราคาต่อหน่วยภาษี As DataGridViewTextBoxColumn
    Friend WithEvents จำนวน As DataGridViewTextBoxColumn
    Friend WithEvents ต้นทุน As DataGridViewTextBoxColumn
    Friend WithEvents ต้นทุนรวมภาษี As DataGridViewTextBoxColumn
    Friend WithEvents btn_edit_supply As Button
    Friend WithEvents RadDropDownListTakeType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label45 As Label
    Friend WithEvents TxtTakeDetail As RichTextBox
    Friend WithEvents BtnDeleteData As Button
    Friend WithEvents BtnSaveData As Button
    Friend WithEvents TxtTotalTakeUnitCost As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents BtnAddNewTake As Button
    Friend WithEvents LabelUnit As Label
    Friend WithEvents LUnit As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents รหัสสินค้า2 As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสินค้า2 As DataGridViewTextBoxColumn
    Friend WithEvents หน่วย2 As DataGridViewTextBoxColumn
    Friend WithEvents ต้นทุนต่อหน่วย As DataGridViewTextBoxColumn
    Friend WithEvents จำนวน2 As DataGridViewTextBoxColumn
    Friend WithEvents ต้นทุนรวม As DataGridViewTextBoxColumn
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents วันที่ As DataGridViewTextBoxColumn
    Friend WithEvents รายการ As DataGridViewTextBoxColumn
    Friend WithEvents ผู้จัดจำหน่าย As DataGridViewTextBoxColumn
    Friend WithEvents สถานะ As DataGridViewTextBoxColumn
    Friend WithEvents วันที่เบิก As DataGridViewTextBoxColumn
    Friend WithEvents เลขที่การเบิก As DataGridViewTextBoxColumn
    Friend WithEvents TakeType As DataGridViewTextBoxColumn
    Friend WithEvents btn_edit_store As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents TxtAmount As TextBox
End Class
