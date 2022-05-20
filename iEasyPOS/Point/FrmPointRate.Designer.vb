<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPointRate
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TimeEnd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.DateEnd = New DevExpress.XtraEditors.DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TimeStart = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateStart = New DevExpress.XtraEditors.DateEdit()
        Me.totalPrice = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalAmount = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rTotalPrice = New System.Windows.Forms.RadioButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.rTotalAmount = New System.Windows.Forms.RadioButton()
        Me.PointRate = New System.Windows.Forms.NumericUpDown()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridViewPoint = New System.Windows.Forms.DataGridView()
        Me.วันที่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.แต้มสะสม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointRateId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New DevExpress.XtraEditors.DateEdit()
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel67.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.TimeEnd.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateEnd.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateEnd.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TimeStart.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateStart.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateStart.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.totalPrice,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.totalAmount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel11.SuspendLayout
        CType(Me.PointRate,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel32.SuspendLayout
        Me.Panel7.SuspendLayout
        CType(Me.DataGridViewPoint,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel33.SuspendLayout
        CType(Me.DateTimePicker1.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DateTimePicker1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel67.Controls.Add(Me.Button26)
        Me.Panel67.Controls.Add(Me.Panel69)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(963, 43)
        Me.Panel67.TabIndex = 338
        '
        'Button26
        '
        Me.Button26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button26.BackColor = System.Drawing.Color.Transparent
        Me.Button26.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Icon_CloseWindowsWhite
        Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.ForeColor = System.Drawing.Color.White
        Me.Button26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button26.Location = New System.Drawing.Point(925, 5)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(32, 32)
        Me.Button26.TabIndex = 19
        Me.Button26.UseVisualStyleBackColor = false
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(963, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(20, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(87, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "แต้มสะสม"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel18)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TimeEnd)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.DateEnd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TimeStart)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.DateStart)
        Me.Panel1.Controls.Add(Me.totalPrice)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.totalAmount)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.rTotalPrice)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.Panel15)
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.Panel17)
        Me.Panel1.Controls.Add(Me.rTotalAmount)
        Me.Panel1.Controls.Add(Me.PointRate)
        Me.Panel1.Location = New System.Drawing.Point(484, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 525)
        Me.Panel1.TabIndex = 341
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel18.Location = New System.Drawing.Point(24, 404)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(198, 1)
        Me.Panel18.TabIndex = 342
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(15, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 24)
        Me.Label9.TabIndex = 341
        Me.Label9.Text = "แต้มสะสม "
        '
        'TimeEnd
        '
        Me.TimeEnd.EditValue = ""
        Me.TimeEnd.Location = New System.Drawing.Point(230, 298)
        Me.TimeEnd.Name = "TimeEnd"
        Me.TimeEnd.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TimeEnd.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TimeEnd.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TimeEnd.Properties.Appearance.Options.UseBackColor = true
        Me.TimeEnd.Properties.Appearance.Options.UseFont = true
        Me.TimeEnd.Properties.Appearance.Options.UseForeColor = true
        Me.TimeEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TimeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeEnd.Properties.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.TimeEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TimeEnd.Size = New System.Drawing.Size(172, 28)
        Me.TimeEnd.TabIndex = 339
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel6.Location = New System.Drawing.Point(230, 329)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(176, 1)
        Me.Panel6.TabIndex = 340
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(222, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 24)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "เวลา"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel13.Location = New System.Drawing.Point(24, 329)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(175, 1)
        Me.Panel13.TabIndex = 336
        '
        'DateEnd
        '
        Me.DateEnd.EditValue = Nothing
        Me.DateEnd.Location = New System.Drawing.Point(29, 298)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DateEnd.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.DateEnd.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DateEnd.Properties.Appearance.Options.UseBackColor = true
        Me.DateEnd.Properties.Appearance.Options.UseFont = true
        Me.DateEnd.Properties.Appearance.Options.UseForeColor = true
        Me.DateEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Size = New System.Drawing.Size(167, 28)
        Me.DateEnd.TabIndex = 337
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(15, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 24)
        Me.Label8.TabIndex = 335
        Me.Label8.Text = "ถึง"
        '
        'TimeStart
        '
        Me.TimeStart.EditValue = ""
        Me.TimeStart.Location = New System.Drawing.Point(230, 223)
        Me.TimeStart.Name = "TimeStart"
        Me.TimeStart.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TimeStart.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TimeStart.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TimeStart.Properties.Appearance.Options.UseBackColor = true
        Me.TimeStart.Properties.Appearance.Options.UseFont = true
        Me.TimeStart.Properties.Appearance.Options.UseForeColor = true
        Me.TimeStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TimeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeStart.Properties.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.TimeStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TimeStart.Size = New System.Drawing.Size(172, 28)
        Me.TimeStart.TabIndex = 333
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel5.Location = New System.Drawing.Point(230, 254)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 1)
        Me.Panel5.TabIndex = 334
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(222, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 24)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "เวลา"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel4.Location = New System.Drawing.Point(24, 254)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(175, 1)
        Me.Panel4.TabIndex = 330
        '
        'DateStart
        '
        Me.DateStart.EditValue = Nothing
        Me.DateStart.Location = New System.Drawing.Point(29, 223)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DateStart.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.DateStart.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DateStart.Properties.Appearance.Options.UseBackColor = true
        Me.DateStart.Properties.Appearance.Options.UseFont = true
        Me.DateStart.Properties.Appearance.Options.UseForeColor = true
        Me.DateStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateStart.Size = New System.Drawing.Size(167, 28)
        Me.DateStart.TabIndex = 331
        '
        'totalPrice
        '
        Me.totalPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totalPrice.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.totalPrice.Location = New System.Drawing.Point(176, 148)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(143, 27)
        Me.totalPrice.TabIndex = 329
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel3.Location = New System.Drawing.Point(174, 177)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(148, 1)
        Me.Panel3.TabIndex = 328
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(15, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 327
        Me.Label3.Text = "วันที่ "
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSave.Appearance.Options.UseFont = true
        Me.btnSave.Appearance.Options.UseForeColor = true
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_SaveWhite
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(313, 472)
        Me.btnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.btnSave.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.btnSave.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 33)
        Me.btnSave.TabIndex = 326
        Me.btnSave.Text = "บันทึก"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "ประเภทการซื้อสินค้า"
        '
        'totalAmount
        '
        Me.totalAmount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totalAmount.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.totalAmount.Location = New System.Drawing.Point(176, 102)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(143, 27)
        Me.totalAmount.TabIndex = 322
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel2.Location = New System.Drawing.Point(174, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 1)
        Me.Panel2.TabIndex = 321
        '
        'rTotalPrice
        '
        Me.rTotalPrice.AutoSize = true
        Me.rTotalPrice.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.rTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.rTotalPrice.Location = New System.Drawing.Point(29, 145)
        Me.rTotalPrice.Name = "rTotalPrice"
        Me.rTotalPrice.Size = New System.Drawing.Size(122, 28)
        Me.rTotalPrice.TabIndex = 319
        Me.rTotalPrice.TabStop = true
        Me.rTotalPrice.Text = "ซื้อสินค้ามูลค่า"
        Me.rTotalPrice.UseVisualStyleBackColor = true
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(1, 1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(451, 43)
        Me.Panel11.TabIndex = 314
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 42)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(451, 1)
        Me.Panel12.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "จัดการ Point Rate"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(452, 1)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 523)
        Me.Panel14.TabIndex = 22
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 1)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 523)
        Me.Panel15.TabIndex = 21
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(453, 1)
        Me.Panel16.TabIndex = 20
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 524)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(453, 1)
        Me.Panel17.TabIndex = 19
        '
        'rTotalAmount
        '
        Me.rTotalAmount.AutoSize = true
        Me.rTotalAmount.Checked = true
        Me.rTotalAmount.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.rTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.rTotalAmount.Location = New System.Drawing.Point(29, 101)
        Me.rTotalAmount.Name = "rTotalAmount"
        Me.rTotalAmount.Size = New System.Drawing.Size(130, 28)
        Me.rTotalAmount.TabIndex = 318
        Me.rTotalAmount.TabStop = true
        Me.rTotalAmount.Text = "ซื้อสินค้าจำนวน"
        Me.rTotalAmount.UseVisualStyleBackColor = true
        '
        'PointRate
        '
        Me.PointRate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PointRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PointRate.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PointRate.Location = New System.Drawing.Point(32, 374)
        Me.PointRate.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.PointRate.Name = "PointRate"
        Me.PointRate.Size = New System.Drawing.Size(187, 27)
        Me.PointRate.TabIndex = 344
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Controls.Add(Me.btnClear)
        Me.Panel32.Controls.Add(Me.Button2)
        Me.Panel32.Controls.Add(Me.Panel7)
        Me.Panel32.Controls.Add(Me.Panel33)
        Me.Panel32.Controls.Add(Me.Label6)
        Me.Panel32.Controls.Add(Me.Panel35)
        Me.Panel32.Controls.Add(Me.Panel41)
        Me.Panel32.Controls.Add(Me.Panel42)
        Me.Panel32.Controls.Add(Me.Panel43)
        Me.Panel32.Controls.Add(Me.Panel44)
        Me.Panel32.Controls.Add(Me.DateTimePicker1)
        Me.Panel32.Controls.Add(Me.btnDel)
        Me.Panel32.Location = New System.Drawing.Point(25, 71)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(453, 525)
        Me.Panel32.TabIndex = 340
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClear.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnClear.Appearance.Options.UseFont = true
        Me.btnClear.Appearance.Options.UseForeColor = true
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_AddWhite
        Me.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClear.Location = New System.Drawing.Point(190, 472)
        Me.btnClear.LookAndFeel.SkinMaskColor = System.Drawing.Color.Orange
        Me.btnClear.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.btnClear.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btnClear.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 33)
        Me.btnClear.TabIndex = 320
        Me.btnClear.Text = "เพิ่มรายการ"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Icon_Search_48Gary
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Kanit", 12!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(280, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 317
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.DataGridViewPoint)
        Me.Panel7.Controls.Add(Me.Panel31)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel7.Location = New System.Drawing.Point(17, 149)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(416, 307)
        Me.Panel7.TabIndex = 315
        '
        'DataGridViewPoint
        '
        Me.DataGridViewPoint.AllowUserToAddRows = false
        Me.DataGridViewPoint.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.DataGridViewPoint.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPoint.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPoint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewPoint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewPoint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPoint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPoint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่, Me.แต้มสะสม, Me.PointRateId, Me.Amounts, Me.Prices})
        Me.DataGridViewPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPoint.EnableHeadersVisualStyles = false
        Me.DataGridViewPoint.GridColor = System.Drawing.Color.White
        Me.DataGridViewPoint.Location = New System.Drawing.Point(1, 1)
        Me.DataGridViewPoint.Name = "DataGridViewPoint"
        Me.DataGridViewPoint.ReadOnly = true
        Me.DataGridViewPoint.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewPoint.RowHeadersVisible = false
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.DataGridViewPoint.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPoint.Size = New System.Drawing.Size(414, 305)
        Me.DataGridViewPoint.TabIndex = 169
        '
        'วันที่
        '
        Me.วันที่.HeaderText = "วันที่"
        Me.วันที่.Name = "วันที่"
        Me.วันที่.ReadOnly = true
        Me.วันที่.Width = 120
        '
        'แต้มสะสม
        '
        Me.แต้มสะสม.HeaderText = "แต้มสะสม"
        Me.แต้มสะสม.Name = "แต้มสะสม"
        Me.แต้มสะสม.ReadOnly = true
        Me.แต้มสะสม.Width = 150
        '
        'PointRateId
        '
        Me.PointRateId.HeaderText = "PointRateId"
        Me.PointRateId.Name = "PointRateId"
        Me.PointRateId.ReadOnly = true
        Me.PointRateId.Visible = false
        '
        'Amounts
        '
        Me.Amounts.HeaderText = "ซื้อสินค้าจำนวน"
        Me.Amounts.Name = "Amounts"
        Me.Amounts.ReadOnly = true
        Me.Amounts.Width = 150
        '
        'Prices
        '
        Me.Prices.HeaderText = "ซื้อสินค้ามูลค่า"
        Me.Prices.Name = "Prices"
        Me.Prices.ReadOnly = true
        Me.Prices.Width = 150
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel31.Location = New System.Drawing.Point(1, 306)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(414, 1)
        Me.Panel31.TabIndex = 168
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(415, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 306)
        Me.Panel8.TabIndex = 22
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 306)
        Me.Panel9.TabIndex = 21
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(416, 1)
        Me.Panel10.TabIndex = 20
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel33.Controls.Add(Me.Panel34)
        Me.Panel33.Controls.Add(Me.Label4)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(1, 1)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(451, 43)
        Me.Panel33.TabIndex = 314
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel34.Location = New System.Drawing.Point(0, 42)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(451, 1)
        Me.Panel34.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(11, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "รายการแต้มสะสม"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(15, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 312
        Me.Label6.Text = "ค้นหาวันที่"
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel35.Location = New System.Drawing.Point(24, 132)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(250, 1)
        Me.Panel35.TabIndex = 313
        '
        'Panel41
        '
        Me.Panel41.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel41.Location = New System.Drawing.Point(452, 1)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(1, 523)
        Me.Panel41.TabIndex = 22
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel42.Location = New System.Drawing.Point(0, 1)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(1, 523)
        Me.Panel42.TabIndex = 21
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel43.Location = New System.Drawing.Point(0, 0)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(453, 1)
        Me.Panel43.TabIndex = 20
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel44.Location = New System.Drawing.Point(0, 524)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(453, 1)
        Me.Panel44.TabIndex = 19
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.EditValue = Nothing
        Me.DateTimePicker1.Location = New System.Drawing.Point(29, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DateTimePicker1.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.DateTimePicker1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Properties.Appearance.Options.UseBackColor = true
        Me.DateTimePicker1.Properties.Appearance.Options.UseFont = true
        Me.DateTimePicker1.Properties.Appearance.Options.UseForeColor = true
        Me.DateTimePicker1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DateTimePicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTimePicker1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTimePicker1.Size = New System.Drawing.Size(242, 28)
        Me.DateTimePicker1.TabIndex = 319
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDel.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.btnDel.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnDel.Appearance.Options.UseFont = true
        Me.btnDel.Appearance.Options.UseForeColor = true
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_DeleteWhite
        Me.btnDel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDel.Location = New System.Drawing.Point(313, 472)
        Me.btnDel.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.btnDel.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btnDel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(120, 33)
        Me.btnDel.TabIndex = 321
        Me.btnDel.Text = "ลบข้อมูล"
        '
        'FrmPointRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 626)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel32)
        Me.Controls.Add(Me.Panel67)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmPointRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แต้มสะสม"
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.TimeEnd.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateEnd.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateEnd.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TimeStart.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateStart.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateStart.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.totalPrice,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.totalAmount,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel11.ResumeLayout(false)
        Me.Panel11.PerformLayout
        CType(Me.PointRate,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel32.ResumeLayout(false)
        Me.Panel32.PerformLayout
        Me.Panel7.ResumeLayout(false)
        CType(Me.DataGridViewPoint,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel33.ResumeLayout(false)
        Me.Panel33.PerformLayout
        CType(Me.DateTimePicker1.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DateTimePicker1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel67 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TimeEnd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents DateEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents TimeStart As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents totalPrice As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents totalAmount As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rTotalPrice As RadioButton
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents rTotalAmount As RadioButton
    Friend WithEvents PointRate As NumericUpDown
    Friend WithEvents Panel32 As Panel
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DataGridViewPoint As DataGridView
    Friend WithEvents วันที่ As DataGridViewTextBoxColumn
    Friend WithEvents แต้มสะสม As DataGridViewTextBoxColumn
    Friend WithEvents PointRateId As DataGridViewTextBoxColumn
    Friend WithEvents Amounts As DataGridViewTextBoxColumn
    Friend WithEvents Prices As DataGridViewTextBoxColumn
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel44 As Panel
    Friend WithEvents DateTimePicker1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
End Class
