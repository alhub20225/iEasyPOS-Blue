<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectSplitBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectSplitBill))
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.txtBillName = New System.Windows.Forms.Label()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.RadButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel67.SuspendLayout
        Me.Panel13.SuspendLayout
        Me.Panel39.SuspendLayout
        Me.Panel9.SuspendLayout
        Me.SuspendLayout
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel67.Controls.Add(Me.Button1)
        Me.Panel67.Controls.Add(Me.Panel69)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(790, 43)
        Me.Panel67.TabIndex = 340
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"),System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(752, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = false
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
        Me.Label36.Size = New System.Drawing.Size(76, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "เลือกบิล"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.BtnClear)
        Me.Panel13.Controls.Add(Me.txtBillName)
        Me.Panel13.Location = New System.Drawing.Point(90, 56)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(445, 29)
        Me.Panel13.TabIndex = 360
        '
        'BtnClear
        '
        Me.BtnClear.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Icon_ClearTex23tGary
        Me.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClear.FlatAppearance.BorderSize = 0
        Me.BtnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Kanit", 12!)
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnClear.Location = New System.Drawing.Point(0, 0)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(30, 29)
        Me.BtnClear.TabIndex = 357
        Me.BtnClear.UseVisualStyleBackColor = true
        '
        'txtBillName
        '
        Me.txtBillName.AutoSize = true
        Me.txtBillName.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtBillName.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.txtBillName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.txtBillName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBillName.Location = New System.Drawing.Point(0, 0)
        Me.txtBillName.Name = "txtBillName"
        Me.txtBillName.Size = New System.Drawing.Size(0, 29)
        Me.txtBillName.TabIndex = 331
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
        Me.Panel39.Size = New System.Drawing.Size(740, 299)
        Me.Panel39.TabIndex = 361
        '
        'FlowLayoutPanelZone
        '
        Me.FlowLayoutPanelZone.AutoScroll = true
        Me.FlowLayoutPanelZone.AutoSize = true
        Me.FlowLayoutPanelZone.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelZone.Location = New System.Drawing.Point(11, 54)
        Me.FlowLayoutPanelZone.Name = "FlowLayoutPanelZone"
        Me.FlowLayoutPanelZone.Size = New System.Drawing.Size(728, 234)
        Me.FlowLayoutPanelZone.TabIndex = 169
        '
        'Panel34
        '
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel34.Location = New System.Drawing.Point(11, 288)
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
        Me.Panel29.Size = New System.Drawing.Size(10, 254)
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
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "บิล"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel40.Location = New System.Drawing.Point(739, 1)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(1, 297)
        Me.Panel40.TabIndex = 22
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 1)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1, 297)
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
        Me.Panel43.Location = New System.Drawing.Point(0, 298)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(740, 1)
        Me.Panel43.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label4.Image = Global.iEasyPOS.My.Resources.Resources.Icon_BillGary
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(25, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 29)
        Me.Label4.TabIndex = 359
        Me.Label4.Text = "บิล :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnDel
        '
        Me.BtnDel.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnDel.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnDel.Appearance.Options.UseFont = true
        Me.BtnDel.Appearance.Options.UseForeColor = true
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.ImageOptions.Image = CType(resources.GetObject("BtnDel.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnDel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnDel.Location = New System.Drawing.Point(553, 417)
        Me.BtnDel.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnDel.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnDel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(103, 33)
        Me.BtnDel.TabIndex = 363
        Me.BtnDel.Text = "ยกเลิก"
        '
        'RadButton10
        '
        Me.RadButton10.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadButton10.Appearance.ForeColor = System.Drawing.Color.White
        Me.RadButton10.Appearance.Options.UseFont = true
        Me.RadButton10.Appearance.Options.UseForeColor = true
        Me.RadButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadButton10.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.RadButton10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.RadButton10.Location = New System.Drawing.Point(662, 417)
        Me.RadButton10.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.RadButton10.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.RadButton10.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.RadButton10.LookAndFeel.UseDefaultLookAndFeel = false
        Me.RadButton10.Name = "RadButton10"
        Me.RadButton10.Size = New System.Drawing.Size(103, 33)
        Me.RadButton10.TabIndex = 362
        Me.RadButton10.Text = "ตกลง"
        '
        'FrmSelectSplitBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 471)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.RadButton10)
        Me.Controls.Add(Me.Panel39)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel67)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSelectSplitBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        Me.Panel13.ResumeLayout(false)
        Me.Panel13.PerformLayout
        Me.Panel39.ResumeLayout(false)
        Me.Panel39.PerformLayout
        Me.Panel9.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel67 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtnClear As Button
    Friend WithEvents txtBillName As Label
    Friend WithEvents Label4 As Label
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
    Friend WithEvents BtnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadButton10 As DevExpress.XtraEditors.SimpleButton
End Class
