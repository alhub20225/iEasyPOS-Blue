<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Promotion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProCode = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.panelMainPromotion = New System.Windows.Forms.TabPage()
        Me.PanelDate = New System.Windows.Forms.Panel()
        Me.TimeEnd = New System.Windows.Forms.ComboBox()
        Me.TimeStart = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateEnd = New DevExpress.XtraEditors.DateEdit()
        Me.DateStart = New DevExpress.XtraEditors.DateEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioBtnPrice = New System.Windows.Forms.RadioButton()
        Me.RadioBtnQty = New System.Windows.Forms.RadioButton()
        Me.PanelPrice = New System.Windows.Forms.Panel()
        Me.NumPrice = New System.Windows.Forms.NumericUpDown()
        Me.NumAlertPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelQty = New System.Windows.Forms.Panel()
        Me.NumAlertQty = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownCon = New System.Windows.Forms.NumericUpDown()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RadioPoint = New System.Windows.Forms.RadioButton()
        Me.PanelPoint = New System.Windows.Forms.Panel()
        Me.txtProPoint = New System.Windows.Forms.TextBox()
        Me.RadioDiscount = New System.Windows.Forms.RadioButton()
        Me.PanelDiscount = New System.Windows.Forms.Panel()
        Me.NumDiscountB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkB = New System.Windows.Forms.CheckBox()
        Me.NumDiscountPer = New System.Windows.Forms.NumericUpDown()
        Me.PanelGetFree = New System.Windows.Forms.Panel()
        Me.btnAddToDataGridViewGetFree = New System.Windows.Forms.Button()
        Me.btnDelGetItem = New System.Windows.Forms.Button()
        Me.NumGetItemDiscount = New System.Windows.Forms.NumericUpDown()
        Me.txtSearchGetItem = New System.Windows.Forms.TextBox()
        Me.DataGridViewGetFree = New System.Windows.Forms.DataGridView()
        Me.รายการ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioBtnGetFree = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridViewShowPromotion = New System.Windows.Forms.DataGridView()
        Me.รหัสโปรโมชั่น = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อโปรโมชั่น = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.panelMainPromotion.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        CType(Me.DateEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrice.SuspendLayout()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlertPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelQty.SuspendLayout()
        CType(Me.NumAlertQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PanelPoint.SuspendLayout()
        Me.PanelDiscount.SuspendLayout()
        CType(Me.NumDiscountPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGetFree.SuspendLayout()
        CType(Me.NumGetItemDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewGetFree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewShowPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtProName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtProCode)
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(428, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 76)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อโปรโมชั่น :"
        '
        'txtProName
        '
        Me.txtProName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProName.Location = New System.Drawing.Point(115, 40)
        Me.txtProName.Name = "txtProName"
        Me.txtProName.Size = New System.Drawing.Size(289, 26)
        Me.txtProName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัสโปรโมชั่น :"
        '
        'txtProCode
        '
        Me.txtProCode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProCode.Location = New System.Drawing.Point(115, 5)
        Me.txtProCode.Name = "txtProCode"
        Me.txtProCode.Size = New System.Drawing.Size(111, 26)
        Me.txtProCode.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel2.Location = New System.Drawing.Point(428, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 459)
        Me.Panel2.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.panelMainPromotion)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(724, 459)
        Me.TabControl1.TabIndex = 3
        '
        'panelMainPromotion
        '
        Me.panelMainPromotion.Controls.Add(Me.PanelDate)
        Me.panelMainPromotion.Controls.Add(Me.Label3)
        Me.panelMainPromotion.Controls.Add(Me.RadioBtnPrice)
        Me.panelMainPromotion.Controls.Add(Me.RadioBtnQty)
        Me.panelMainPromotion.Controls.Add(Me.PanelPrice)
        Me.panelMainPromotion.Controls.Add(Me.PanelQty)
        Me.panelMainPromotion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.panelMainPromotion.Location = New System.Drawing.Point(4, 31)
        Me.panelMainPromotion.Name = "panelMainPromotion"
        Me.panelMainPromotion.Padding = New System.Windows.Forms.Padding(3)
        Me.panelMainPromotion.Size = New System.Drawing.Size(716, 424)
        Me.panelMainPromotion.TabIndex = 0
        Me.panelMainPromotion.Text = "เงื่อนไข"
        Me.panelMainPromotion.UseVisualStyleBackColor = True
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.TimeEnd)
        Me.PanelDate.Controls.Add(Me.TimeStart)
        Me.PanelDate.Controls.Add(Me.Label14)
        Me.PanelDate.Controls.Add(Me.Label13)
        Me.PanelDate.Controls.Add(Me.DateEnd)
        Me.PanelDate.Controls.Add(Me.DateStart)
        Me.PanelDate.Controls.Add(Me.Label12)
        Me.PanelDate.Controls.Add(Me.Label11)
        Me.PanelDate.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.PanelDate.Location = New System.Drawing.Point(209, 154)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(433, 93)
        Me.PanelDate.TabIndex = 6
        '
        'TimeEnd
        '
        Me.TimeEnd.FormattingEnabled = True
        Me.TimeEnd.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.TimeEnd.Location = New System.Drawing.Point(312, 44)
        Me.TimeEnd.Name = "TimeEnd"
        Me.TimeEnd.Size = New System.Drawing.Size(111, 27)
        Me.TimeEnd.TabIndex = 9
        '
        'TimeStart
        '
        Me.TimeStart.FormattingEnabled = True
        Me.TimeStart.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.TimeStart.Location = New System.Drawing.Point(312, 10)
        Me.TimeStart.Name = "TimeStart"
        Me.TimeStart.Size = New System.Drawing.Size(111, 27)
        Me.TimeStart.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(270, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 21)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "เวลา :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(270, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 21)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "เวลา :"
        '
        'DateEnd
        '
        Me.DateEnd.EditValue = Nothing
        Me.DateEnd.Location = New System.Drawing.Point(118, 49)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEnd.Properties.Appearance.Options.UseFont = True
        Me.DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Size = New System.Drawing.Size(141, 26)
        Me.DateEnd.TabIndex = 1
        '
        'DateStart
        '
        Me.DateStart.EditValue = Nothing
        Me.DateStart.Location = New System.Drawing.Point(118, 12)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStart.Properties.Appearance.Options.UseFont = True
        Me.DateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateStart.Size = New System.Drawing.Size(141, 26)
        Me.DateStart.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(4, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 21)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "วันที่สิ้นสุดโปรโมชั่น :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(4, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 21)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "วันที่เริ่มโปรโมชั่น :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "เงื่อนไขการคิดโปรโมชั่น :"
        '
        'RadioBtnPrice
        '
        Me.RadioBtnPrice.AutoSize = True
        Me.RadioBtnPrice.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.RadioBtnPrice.Location = New System.Drawing.Point(209, 101)
        Me.RadioBtnPrice.Name = "RadioBtnPrice"
        Me.RadioBtnPrice.Size = New System.Drawing.Size(107, 25)
        Me.RadioBtnPrice.TabIndex = 2
        Me.RadioBtnPrice.Text = "ซื้อสินค้ามูลค่า"
        Me.RadioBtnPrice.UseVisualStyleBackColor = True
        '
        'RadioBtnQty
        '
        Me.RadioBtnQty.AutoSize = True
        Me.RadioBtnQty.Checked = True
        Me.RadioBtnQty.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.RadioBtnQty.Location = New System.Drawing.Point(209, 42)
        Me.RadioBtnQty.Name = "RadioBtnQty"
        Me.RadioBtnQty.Size = New System.Drawing.Size(113, 25)
        Me.RadioBtnQty.TabIndex = 0
        Me.RadioBtnQty.TabStop = True
        Me.RadioBtnQty.Text = "ซื้อสินค้าจำนวน"
        Me.RadioBtnQty.UseVisualStyleBackColor = True
        '
        'PanelPrice
        '
        Me.PanelPrice.Controls.Add(Me.NumPrice)
        Me.PanelPrice.Controls.Add(Me.NumAlertPrice)
        Me.PanelPrice.Controls.Add(Me.Label5)
        Me.PanelPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelPrice.Location = New System.Drawing.Point(327, 83)
        Me.PanelPrice.Name = "PanelPrice"
        Me.PanelPrice.Size = New System.Drawing.Size(315, 55)
        Me.PanelPrice.TabIndex = 3
        '
        'NumPrice
        '
        Me.NumPrice.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumPrice.Location = New System.Drawing.Point(20, 14)
        Me.NumPrice.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumPrice.Name = "NumPrice"
        Me.NumPrice.Size = New System.Drawing.Size(94, 29)
        Me.NumPrice.TabIndex = 9
        Me.NumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumAlertPrice
        '
        Me.NumAlertPrice.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumAlertPrice.Location = New System.Drawing.Point(236, 16)
        Me.NumAlertPrice.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumAlertPrice.Name = "NumAlertPrice"
        Me.NumAlertPrice.Size = New System.Drawing.Size(69, 29)
        Me.NumAlertPrice.TabIndex = 8
        Me.NumAlertPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumAlertPrice.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(127, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "เตือนเมื่อมูลค่า :"
        Me.Label5.Visible = False
        '
        'PanelQty
        '
        Me.PanelQty.Controls.Add(Me.NumAlertQty)
        Me.PanelQty.Controls.Add(Me.Label4)
        Me.PanelQty.Controls.Add(Me.NumericUpDownCon)
        Me.PanelQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelQty.Location = New System.Drawing.Point(327, 27)
        Me.PanelQty.Name = "PanelQty"
        Me.PanelQty.Size = New System.Drawing.Size(315, 50)
        Me.PanelQty.TabIndex = 1
        '
        'NumAlertQty
        '
        Me.NumAlertQty.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumAlertQty.Location = New System.Drawing.Point(236, 13)
        Me.NumAlertQty.Name = "NumAlertQty"
        Me.NumAlertQty.Size = New System.Drawing.Size(69, 29)
        Me.NumAlertQty.TabIndex = 6
        Me.NumAlertQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumAlertQty.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(134, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "เตือนเมื่อจำนวน :"
        Me.Label4.Visible = False
        '
        'NumericUpDownCon
        '
        Me.NumericUpDownCon.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumericUpDownCon.Location = New System.Drawing.Point(20, 13)
        Me.NumericUpDownCon.Name = "NumericUpDownCon"
        Me.NumericUpDownCon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumericUpDownCon.Size = New System.Drawing.Size(94, 29)
        Me.NumericUpDownCon.TabIndex = 0
        Me.NumericUpDownCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RadioPoint)
        Me.TabPage2.Controls.Add(Me.PanelPoint)
        Me.TabPage2.Controls.Add(Me.RadioDiscount)
        Me.TabPage2.Controls.Add(Me.PanelDiscount)
        Me.TabPage2.Controls.Add(Me.PanelGetFree)
        Me.TabPage2.Controls.Add(Me.RadioBtnGetFree)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(716, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ของขวัญ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RadioPoint
        '
        Me.RadioPoint.AutoSize = True
        Me.RadioPoint.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.RadioPoint.Location = New System.Drawing.Point(76, 382)
        Me.RadioPoint.Name = "RadioPoint"
        Me.RadioPoint.Size = New System.Drawing.Size(87, 26)
        Me.RadioPoint.TabIndex = 13
        Me.RadioPoint.TabStop = True
        Me.RadioPoint.Text = "แต้มสะสม"
        Me.RadioPoint.UseVisualStyleBackColor = True
        '
        'PanelPoint
        '
        Me.PanelPoint.Controls.Add(Me.txtProPoint)
        Me.PanelPoint.Location = New System.Drawing.Point(167, 370)
        Me.PanelPoint.Name = "PanelPoint"
        Me.PanelPoint.Size = New System.Drawing.Size(412, 52)
        Me.PanelPoint.TabIndex = 12
        '
        'txtProPoint
        '
        Me.txtProPoint.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProPoint.Location = New System.Drawing.Point(50, 12)
        Me.txtProPoint.Name = "txtProPoint"
        Me.txtProPoint.Size = New System.Drawing.Size(111, 29)
        Me.txtProPoint.TabIndex = 1
        '
        'RadioDiscount
        '
        Me.RadioDiscount.AutoSize = True
        Me.RadioDiscount.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.RadioDiscount.Location = New System.Drawing.Point(76, 294)
        Me.RadioDiscount.Name = "RadioDiscount"
        Me.RadioDiscount.Size = New System.Drawing.Size(89, 26)
        Me.RadioDiscount.TabIndex = 11
        Me.RadioDiscount.Text = "รับส่วนลด"
        Me.RadioDiscount.UseVisualStyleBackColor = True
        '
        'PanelDiscount
        '
        Me.PanelDiscount.Controls.Add(Me.NumDiscountB)
        Me.PanelDiscount.Controls.Add(Me.Label9)
        Me.PanelDiscount.Controls.Add(Me.Label8)
        Me.PanelDiscount.Controls.Add(Me.ChkB)
        Me.PanelDiscount.Controls.Add(Me.NumDiscountPer)
        Me.PanelDiscount.Location = New System.Drawing.Point(167, 288)
        Me.PanelDiscount.Name = "PanelDiscount"
        Me.PanelDiscount.Size = New System.Drawing.Size(412, 78)
        Me.PanelDiscount.TabIndex = 10
        '
        'NumDiscountB
        '
        Me.NumDiscountB.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumDiscountB.Location = New System.Drawing.Point(50, 41)
        Me.NumDiscountB.Name = "NumDiscountB"
        Me.NumDiscountB.Size = New System.Drawing.Size(88, 29)
        Me.NumDiscountB.TabIndex = 14
        Me.NumDiscountB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(144, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "฿"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(144, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "%"
        '
        'ChkB
        '
        Me.ChkB.AutoSize = True
        Me.ChkB.Location = New System.Drawing.Point(19, 47)
        Me.ChkB.Name = "ChkB"
        Me.ChkB.Size = New System.Drawing.Size(15, 14)
        Me.ChkB.TabIndex = 11
        Me.ChkB.UseVisualStyleBackColor = True
        '
        'NumDiscountPer
        '
        Me.NumDiscountPer.Location = New System.Drawing.Point(50, 6)
        Me.NumDiscountPer.Name = "NumDiscountPer"
        Me.NumDiscountPer.Size = New System.Drawing.Size(88, 26)
        Me.NumDiscountPer.TabIndex = 10
        Me.NumDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelGetFree
        '
        Me.PanelGetFree.Controls.Add(Me.btnAddToDataGridViewGetFree)
        Me.PanelGetFree.Controls.Add(Me.btnDelGetItem)
        Me.PanelGetFree.Controls.Add(Me.NumGetItemDiscount)
        Me.PanelGetFree.Controls.Add(Me.txtSearchGetItem)
        Me.PanelGetFree.Controls.Add(Me.DataGridViewGetFree)
        Me.PanelGetFree.Controls.Add(Me.Label7)
        Me.PanelGetFree.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.PanelGetFree.Location = New System.Drawing.Point(167, 6)
        Me.PanelGetFree.Name = "PanelGetFree"
        Me.PanelGetFree.Size = New System.Drawing.Size(412, 276)
        Me.PanelGetFree.TabIndex = 9
        '
        'btnAddToDataGridViewGetFree
        '
        Me.btnAddToDataGridViewGetFree.Location = New System.Drawing.Point(322, 22)
        Me.btnAddToDataGridViewGetFree.Name = "btnAddToDataGridViewGetFree"
        Me.btnAddToDataGridViewGetFree.Size = New System.Drawing.Size(75, 32)
        Me.btnAddToDataGridViewGetFree.TabIndex = 10
        Me.btnAddToDataGridViewGetFree.Text = "เพิ่ม"
        Me.btnAddToDataGridViewGetFree.UseVisualStyleBackColor = True
        '
        'btnDelGetItem
        '
        Me.btnDelGetItem.Location = New System.Drawing.Point(322, 241)
        Me.btnDelGetItem.Name = "btnDelGetItem"
        Me.btnDelGetItem.Size = New System.Drawing.Size(75, 32)
        Me.btnDelGetItem.TabIndex = 9
        Me.btnDelGetItem.Text = "ลบ"
        Me.btnDelGetItem.UseVisualStyleBackColor = True
        '
        'NumGetItemDiscount
        '
        Me.NumGetItemDiscount.Location = New System.Drawing.Point(217, 25)
        Me.NumGetItemDiscount.Name = "NumGetItemDiscount"
        Me.NumGetItemDiscount.Size = New System.Drawing.Size(88, 27)
        Me.NumGetItemDiscount.TabIndex = 7
        Me.NumGetItemDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumGetItemDiscount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'txtSearchGetItem
        '
        Me.txtSearchGetItem.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearchGetItem.Location = New System.Drawing.Point(19, 25)
        Me.txtSearchGetItem.Name = "txtSearchGetItem"
        Me.txtSearchGetItem.Size = New System.Drawing.Size(183, 29)
        Me.txtSearchGetItem.TabIndex = 5
        '
        'DataGridViewGetFree
        '
        Me.DataGridViewGetFree.AllowUserToAddRows = False
        Me.DataGridViewGetFree.AllowUserToDeleteRows = False
        Me.DataGridViewGetFree.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewGetFree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGetFree.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รายการ, Me.Discount, Me.ItemId})
        Me.DataGridViewGetFree.Location = New System.Drawing.Point(19, 60)
        Me.DataGridViewGetFree.Name = "DataGridViewGetFree"
        Me.DataGridViewGetFree.ReadOnly = True
        Me.DataGridViewGetFree.RowHeadersVisible = False
        Me.DataGridViewGetFree.Size = New System.Drawing.Size(378, 175)
        Me.DataGridViewGetFree.TabIndex = 8
        '
        'รายการ
        '
        Me.รายการ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.รายการ.HeaderText = "รายการ"
        Me.รายการ.Name = "รายการ"
        Me.รายการ.ReadOnly = True
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "ItemId"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(213, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "% Discount"
        '
        'RadioBtnGetFree
        '
        Me.RadioBtnGetFree.AutoSize = True
        Me.RadioBtnGetFree.Checked = True
        Me.RadioBtnGetFree.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.RadioBtnGetFree.Location = New System.Drawing.Point(76, 32)
        Me.RadioBtnGetFree.Name = "RadioBtnGetFree"
        Me.RadioBtnGetFree.Size = New System.Drawing.Size(79, 26)
        Me.RadioBtnGetFree.TabIndex = 6
        Me.RadioBtnGetFree.TabStop = True
        Me.RadioBtnGetFree.Text = "รับสินค้า"
        Me.RadioBtnGetFree.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ของขวัญ :"
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.btn.Location = New System.Drawing.Point(908, 553)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 38)
        Me.btn.TabIndex = 4
        Me.btn.Text = "เพิ่ม"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.btnSave.Location = New System.Drawing.Point(989, 553)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.btnDel.Location = New System.Drawing.Point(1070, 553)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 38)
        Me.btnDel.TabIndex = 6
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.DataGridViewShowPromotion)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Panel3.Location = New System.Drawing.Point(12, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 541)
        Me.Panel3.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(1, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "รหัสโปรโมชั่น :"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(328, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridViewShowPromotion
        '
        Me.DataGridViewShowPromotion.AllowUserToAddRows = False
        Me.DataGridViewShowPromotion.AllowUserToDeleteRows = False
        Me.DataGridViewShowPromotion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewShowPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowPromotion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัสโปรโมชั่น, Me.ชื่อโปรโมชั่น, Me.ProId})
        Me.DataGridViewShowPromotion.Location = New System.Drawing.Point(0, 81)
        Me.DataGridViewShowPromotion.Name = "DataGridViewShowPromotion"
        Me.DataGridViewShowPromotion.ReadOnly = True
        Me.DataGridViewShowPromotion.RowHeadersVisible = False
        Me.DataGridViewShowPromotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewShowPromotion.Size = New System.Drawing.Size(403, 460)
        Me.DataGridViewShowPromotion.TabIndex = 0
        '
        'รหัสโปรโมชั่น
        '
        Me.รหัสโปรโมชั่น.HeaderText = "รหัสโปรโมชั่น"
        Me.รหัสโปรโมชั่น.Name = "รหัสโปรโมชั่น"
        Me.รหัสโปรโมชั่น.ReadOnly = True
        Me.รหัสโปรโมชั่น.Width = 180
        '
        'ชื่อโปรโมชั่น
        '
        Me.ชื่อโปรโมชั่น.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อโปรโมชั่น.HeaderText = "ชื่อโปรโมชั่น"
        Me.ชื่อโปรโมชั่น.Name = "ชื่อโปรโมชั่น"
        Me.ชื่อโปรโมชั่น.ReadOnly = True
        '
        'ProId
        '
        Me.ProId.HeaderText = "ProId"
        Me.ProId.Name = "ProId"
        Me.ProId.ReadOnly = True
        Me.ProId.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(96, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(226, 29)
        Me.txtSearch.TabIndex = 5
        '
        'Promotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 598)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Promotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promotion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.panelMainPromotion.ResumeLayout(False)
        Me.panelMainPromotion.PerformLayout()
        Me.PanelDate.ResumeLayout(False)
        Me.PanelDate.PerformLayout()
        CType(Me.DateEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrice.ResumeLayout(False)
        Me.PanelPrice.PerformLayout()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAlertPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelQty.ResumeLayout(False)
        Me.PanelQty.PerformLayout()
        CType(Me.NumAlertQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.PanelPoint.ResumeLayout(False)
        Me.PanelPoint.PerformLayout()
        Me.PanelDiscount.ResumeLayout(False)
        Me.PanelDiscount.PerformLayout()
        CType(Me.NumDiscountPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGetFree.ResumeLayout(False)
        Me.PanelGetFree.PerformLayout()
        CType(Me.NumGetItemDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewGetFree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewShowPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProCode As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents panelMainPromotion As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RadioBtnQty As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProName As TextBox
    Friend WithEvents RadioBtnPrice As RadioButton
    Friend WithEvents PanelPrice As Panel
    Friend WithEvents PanelQty As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownCon As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumPrice As NumericUpDown
    Friend WithEvents NumAlertPrice As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumAlertQty As NumericUpDown
    Friend WithEvents PanelDiscount As Panel
    Friend WithEvents PanelGetFree As Panel
    Friend WithEvents btnDelGetItem As Button
    Friend WithEvents NumGetItemDiscount As NumericUpDown
    Friend WithEvents txtSearchGetItem As TextBox
    Friend WithEvents DataGridViewGetFree As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioBtnGetFree As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioDiscount As RadioButton
    Friend WithEvents PanelDate As Panel
    Friend WithEvents DateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkB As CheckBox
    Friend WithEvents NumDiscountPer As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnAddToDataGridViewGetFree As Button
    Friend WithEvents btn As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents TimeEnd As ComboBox
    Friend WithEvents TimeStart As ComboBox
    Friend WithEvents NumDiscountB As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridViewShowPromotion As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents RadioPoint As RadioButton
    Friend WithEvents PanelPoint As Panel
    Friend WithEvents txtProPoint As TextBox
    Friend WithEvents รหัสโปรโมชั่น As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อโปรโมชั่น As DataGridViewTextBoxColumn
    Friend WithEvents ProId As DataGridViewTextBoxColumn
    Friend WithEvents รายการ As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
End Class
