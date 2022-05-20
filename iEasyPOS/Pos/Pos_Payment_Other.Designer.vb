<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pos_Payment_Other
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_Payment_Other))
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCancle = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotalPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxPaytype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Panel68.SuspendLayout
        Me.Panel39.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboBoxPaytype.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel68
        '
        Me.Panel68.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel68.Controls.Add(Me.Button26)
        Me.Panel68.Controls.Add(Me.Panel69)
        Me.Panel68.Controls.Add(Me.Label34)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(422, 43)
        Me.Panel68.TabIndex = 337
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
        Me.Button26.Location = New System.Drawing.Point(384, 5)
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
        Me.Panel69.Size = New System.Drawing.Size(422, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(20, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(161, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "ชำระเงินช่องทางอื่น"
        '
        'Panel39
        '
        Me.Panel39.Controls.Add(Me.PictureBox2)
        Me.Panel39.Controls.Add(Me.BtnCancle)
        Me.Panel39.Controls.Add(Me.Button1)
        Me.Panel39.Controls.Add(Me.txtTotalPay)
        Me.Panel39.Controls.Add(Me.Label4)
        Me.Panel39.Controls.Add(Me.Panel11)
        Me.Panel39.Controls.Add(Me.Label3)
        Me.Panel39.Controls.Add(Me.ComboBoxPaytype)
        Me.Panel39.Controls.Add(Me.Panel4)
        Me.Panel39.Controls.Add(Me.Panel3)
        Me.Panel39.Controls.Add(Me.Panel22)
        Me.Panel39.Controls.Add(Me.Panel42)
        Me.Panel39.Controls.Add(Me.Panel43)
        Me.Panel39.Location = New System.Drawing.Point(25, 75)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(371, 370)
        Me.Panel39.TabIndex = 351
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Logo_QRThai
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(124, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox2.TabIndex = 325
        Me.PictureBox2.TabStop = false
        '
        'BtnCancle
        '
        Me.BtnCancle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnCancle.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnCancle.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnCancle.Appearance.Options.UseFont = true
        Me.BtnCancle.Appearance.Options.UseForeColor = true
        Me.BtnCancle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancle.ImageOptions.Image = CType(resources.GetObject("BtnCancle.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnCancle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnCancle.Location = New System.Drawing.Point(131, 317)
        Me.BtnCancle.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnCancle.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnCancle.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(103, 33)
        Me.BtnCancle.TabIndex = 324
        Me.BtnCancle.Text = "ยกเลิก"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Appearance.ForeColor = System.Drawing.Color.White
        Me.Button1.Appearance.Options.UseFont = true
        Me.Button1.Appearance.Options.UseForeColor = true
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.Button1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Button1.Location = New System.Drawing.Point(240, 317)
        Me.Button1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.Button1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.Button1.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.Button1.LookAndFeel.UseDefaultLookAndFeel = false
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 33)
        Me.Button1.TabIndex = 323
        Me.Button1.Text = "ตกลง"
        '
        'txtTotalPay
        '
        Me.txtTotalPay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalPay.Font = New System.Drawing.Font("Kanit", 12!)
        Me.txtTotalPay.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPay.Location = New System.Drawing.Point(26, 263)
        Me.txtTotalPay.Name = "txtTotalPay"
        Me.txtTotalPay.ReadOnly = true
        Me.txtTotalPay.Size = New System.Drawing.Size(318, 24)
        Me.txtTotalPay.TabIndex = 315
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(15, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 316
        Me.Label4.Text = "จำนวนเงิน"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel11.Location = New System.Drawing.Point(24, 292)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(318, 1)
        Me.Panel11.TabIndex = 317
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(15, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 312
        Me.Label3.Text = "ช่องทางชำระ"
        '
        'ComboBoxPaytype
        '
        Me.ComboBoxPaytype.EditValue = "QR Thai"
        Me.ComboBoxPaytype.Location = New System.Drawing.Point(25, 189)
        Me.ComboBoxPaytype.Name = "ComboBoxPaytype"
        Me.ComboBoxPaytype.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBoxPaytype.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.ComboBoxPaytype.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxPaytype.Properties.Appearance.Options.UseBackColor = true
        Me.ComboBoxPaytype.Properties.Appearance.Options.UseFont = true
        Me.ComboBoxPaytype.Properties.Appearance.Options.UseForeColor = true
        Me.ComboBoxPaytype.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ComboBoxPaytype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxPaytype.Properties.Items.AddRange(New Object() {"QR Thai", "QR Alipay", "QR WeChat"})
        Me.ComboBoxPaytype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxPaytype.Size = New System.Drawing.Size(315, 28)
        Me.ComboBoxPaytype.TabIndex = 313
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel4.Location = New System.Drawing.Point(25, 220)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(319, 1)
        Me.Panel4.TabIndex = 314
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(370, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 368)
        Me.Panel3.TabIndex = 22
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 1)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1, 368)
        Me.Panel22.TabIndex = 21
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(0, 0)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(371, 1)
        Me.Panel42.TabIndex = 20
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel43.Location = New System.Drawing.Point(0, 369)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(371, 1)
        Me.Panel43.TabIndex = 19
        '
        'Pos_Payment_Other
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(422, 473)
        Me.Controls.Add(Me.Panel39)
        Me.Controls.Add(Me.Panel68)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Pos_Payment_Other"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        Me.Panel39.ResumeLayout(false)
        Me.Panel39.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboBoxPaytype.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel39 As Panel
    Friend WithEvents BtnCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxPaytype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
