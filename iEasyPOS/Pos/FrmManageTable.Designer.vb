<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManageTable))
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtZoneName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelTable = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTableName = New System.Windows.Forms.Label()
        Me.BtnAddTable = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDeleteTable = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditTable = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel67.SuspendLayout
        Me.Panel39.SuspendLayout
        Me.Panel9.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel67.Controls.Add(Me.Button14)
        Me.Panel67.Controls.Add(Me.Panel69)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(790, 43)
        Me.Panel67.TabIndex = 324
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"),System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(752, 5)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(32, 32)
        Me.Button14.TabIndex = 19
        Me.Button14.UseVisualStyleBackColor = false
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(790, 1)
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
        Me.Label36.Size = New System.Drawing.Size(90, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "จัดการโต๊ะ"
        '
        'txtZoneName
        '
        Me.txtZoneName.AutoSize = true
        Me.txtZoneName.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.txtZoneName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.txtZoneName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtZoneName.Location = New System.Drawing.Point(93, 56)
        Me.txtZoneName.Name = "txtZoneName"
        Me.txtZoneName.Size = New System.Drawing.Size(0, 29)
        Me.txtZoneName.TabIndex = 364
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label6.Image = Global.iEasyPOS.My.Resources.Resources.Icon_ZoneGray
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(25, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 29)
        Me.Label6.TabIndex = 363
        Me.Label6.Text = "โซน :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel39
        '
        Me.Panel39.Controls.Add(Me.FlowLayoutPanelZone)
        Me.Panel39.Controls.Add(Me.Panel34)
        Me.Panel39.Controls.Add(Me.Panel33)
        Me.Panel39.Controls.Add(Me.Panel29)
        Me.Panel39.Controls.Add(Me.Panel9)
        Me.Panel39.Controls.Add(Me.Panel40)
        Me.Panel39.Controls.Add(Me.Panel22)
        Me.Panel39.Controls.Add(Me.Panel42)
        Me.Panel39.Controls.Add(Me.Panel43)
        Me.Panel39.Location = New System.Drawing.Point(25, 99)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(740, 240)
        Me.Panel39.TabIndex = 359
        '
        'FlowLayoutPanelZone
        '
        Me.FlowLayoutPanelZone.AutoScroll = true
        Me.FlowLayoutPanelZone.AutoSize = true
        Me.FlowLayoutPanelZone.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelZone.Location = New System.Drawing.Point(11, 54)
        Me.FlowLayoutPanelZone.Name = "FlowLayoutPanelZone"
        Me.FlowLayoutPanelZone.Size = New System.Drawing.Size(728, 175)
        Me.FlowLayoutPanelZone.TabIndex = 169
        '
        'Panel34
        '
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel34.Location = New System.Drawing.Point(11, 229)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(728, 10)
        Me.Panel34.TabIndex = 172
        '
        'Panel33
        '
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(11, 44)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(728, 10)
        Me.Panel33.TabIndex = 171
        '
        'Panel29
        '
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel29.Location = New System.Drawing.Point(1, 44)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(10, 195)
        Me.Panel29.TabIndex = 170
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(1, 1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(738, 43)
        Me.Panel9.TabIndex = 168
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 42)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(738, 1)
        Me.Panel11.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.iEasyPOS.My.Resources.Resources.Icon_ZoneWhite
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "โซน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel40.Location = New System.Drawing.Point(739, 1)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(1, 238)
        Me.Panel40.TabIndex = 22
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 1)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1, 238)
        Me.Panel22.TabIndex = 21
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(0, 0)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(740, 1)
        Me.Panel42.TabIndex = 20
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel43.Location = New System.Drawing.Point(0, 239)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(740, 1)
        Me.Panel43.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanelTable)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Location = New System.Drawing.Point(24, 354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 240)
        Me.Panel1.TabIndex = 360
        '
        'FlowLayoutPanelTable
        '
        Me.FlowLayoutPanelTable.AutoScroll = true
        Me.FlowLayoutPanelTable.AutoSize = true
        Me.FlowLayoutPanelTable.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelTable.Location = New System.Drawing.Point(11, 54)
        Me.FlowLayoutPanelTable.Name = "FlowLayoutPanelTable"
        Me.FlowLayoutPanelTable.Size = New System.Drawing.Size(728, 175)
        Me.FlowLayoutPanelTable.TabIndex = 164
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(11, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(728, 10)
        Me.Panel3.TabIndex = 167
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(11, 44)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(728, 10)
        Me.Panel10.TabIndex = 166
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(1, 44)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 195)
        Me.Panel12.TabIndex = 165
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 43)
        Me.Panel2.TabIndex = 158
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 42)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(738, 1)
        Me.Panel8.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.iEasyPOS.My.Resources.Resources.Icon_TableWhite
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(16, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "โต๊ะ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(739, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 238)
        Me.Panel4.TabIndex = 22
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 238)
        Me.Panel5.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(740, 1)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 239)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(740, 1)
        Me.Panel7.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label4.Image = Global.iEasyPOS.My.Resources.Resources.Icon_TableGray
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(221, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 29)
        Me.Label4.TabIndex = 365
        Me.Label4.Text = "โต๊ะ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTableName
        '
        Me.txtTableName.AutoSize = true
        Me.txtTableName.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.txtTableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.txtTableName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTableName.Location = New System.Drawing.Point(288, 57)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(0, 29)
        Me.txtTableName.TabIndex = 366
        '
        'BtnAddTable
        '
        Me.BtnAddTable.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.BtnAddTable.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnAddTable.Appearance.Options.UseFont = true
        Me.BtnAddTable.Appearance.Options.UseForeColor = true
        Me.BtnAddTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddTable.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_TableAddWhite
        Me.BtnAddTable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnAddTable.Location = New System.Drawing.Point(403, 613)
        Me.BtnAddTable.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(149,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.BtnAddTable.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnAddTable.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnAddTable.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnAddTable.Name = "BtnAddTable"
        Me.BtnAddTable.Size = New System.Drawing.Size(116, 33)
        Me.BtnAddTable.TabIndex = 369
        Me.BtnAddTable.Text = "เพิ่มโต๊ะ"
        '
        'BtnDeleteTable
        '
        Me.BtnDeleteTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteTable.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.BtnDeleteTable.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteTable.Appearance.Options.UseFont = true
        Me.BtnDeleteTable.Appearance.Options.UseForeColor = true
        Me.BtnDeleteTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteTable.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_TableDeleteWhite
        Me.BtnDeleteTable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnDeleteTable.Location = New System.Drawing.Point(647, 613)
        Me.BtnDeleteTable.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnDeleteTable.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnDeleteTable.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnDeleteTable.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnDeleteTable.Name = "BtnDeleteTable"
        Me.BtnDeleteTable.Size = New System.Drawing.Size(116, 33)
        Me.BtnDeleteTable.TabIndex = 368
        Me.BtnDeleteTable.Text = "ลบโต๊ะ"
        '
        'BtnEditTable
        '
        Me.BtnEditTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnEditTable.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.BtnEditTable.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnEditTable.Appearance.Options.UseFont = true
        Me.BtnEditTable.Appearance.Options.UseForeColor = true
        Me.BtnEditTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditTable.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_TableEditWhite
        Me.BtnEditTable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnEditTable.Location = New System.Drawing.Point(525, 613)
        Me.BtnEditTable.LookAndFeel.SkinMaskColor = System.Drawing.Color.Orange
        Me.BtnEditTable.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnEditTable.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnEditTable.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnEditTable.Name = "BtnEditTable"
        Me.BtnEditTable.Size = New System.Drawing.Size(116, 33)
        Me.BtnEditTable.TabIndex = 367
        Me.BtnEditTable.Text = "แก้ไขโต๊ะ"
        '
        'FrmManageTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 670)
        Me.Controls.Add(Me.BtnAddTable)
        Me.Controls.Add(Me.BtnEditTable)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.txtZoneName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel39)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel67)
        Me.Controls.Add(Me.BtnDeleteTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmManageTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmManageTable"
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        Me.Panel39.ResumeLayout(false)
        Me.Panel39.PerformLayout
        Me.Panel9.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel67 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents txtZoneName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel39 As Panel
    Friend WithEvents FlowLayoutPanelZone As FlowLayoutPanel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanelTable As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTableName As Label
    Friend WithEvents BtnAddTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDeleteTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditTable As DevExpress.XtraEditors.SimpleButton
End Class
