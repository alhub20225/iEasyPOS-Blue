<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.BtnCloseShift = New System.Windows.Forms.Button()
        Me.LabelPageName = New System.Windows.Forms.Label()
        Me.BtnMain2Close = New System.Windows.Forms.Button()
        Me.BtnBranchTopPage = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnUserName = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelNameTabPage = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SaleList = New System.Windows.Forms.ListBox()
        Me.TabControlMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage10 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage11 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage12 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPromotion = New DevExpress.XtraTab.XtraTabControl()
        Me.TabPagePromotion = New DevExpress.XtraTab.XtraTabPage()
        Me.TabPagePoint = New DevExpress.XtraTab.XtraTabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlMain.SuspendLayout()
        Me.XtraTabPage12.SuspendLayout()
        CType(Me.XtraTabPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPromotion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelTime)
        Me.Panel1.Controls.Add(Me.BtnCloseShift)
        Me.Panel1.Controls.Add(Me.LabelPageName)
        Me.Panel1.Controls.Add(Me.BtnMain2Close)
        Me.Panel1.Controls.Add(Me.BtnBranchTopPage)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BtnUserName)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.LabelNameTabPage)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.SaleList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1339, 82)
        Me.Panel1.TabIndex = 2
        '
        'LabelTime
        '
        Me.LabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Kanit SemiBold", 12.0!)
        Me.LabelTime.Location = New System.Drawing.Point(615, 26)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(87, 24)
        Me.LabelTime.TabIndex = 22
        Me.LabelTime.Text = "LabelTime"
        '
        'BtnCloseShift
        '
        Me.BtnCloseShift.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCloseShift.BackColor = System.Drawing.Color.White
        Me.BtnCloseShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseShift.Font = New System.Drawing.Font("Kanit SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseShift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnCloseShift.Image = Global.Project_CTM.My.Resources.Resources.layers_1
        Me.BtnCloseShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCloseShift.Location = New System.Drawing.Point(1163, 22)
        Me.BtnCloseShift.Name = "BtnCloseShift"
        Me.BtnCloseShift.Size = New System.Drawing.Size(95, 31)
        Me.BtnCloseShift.TabIndex = 21
        Me.BtnCloseShift.Text = "ปิดกะ"
        Me.BtnCloseShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCloseShift.UseVisualStyleBackColor = False
        '
        'LabelPageName
        '
        Me.LabelPageName.AutoSize = True
        Me.LabelPageName.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPageName.Location = New System.Drawing.Point(120, 18)
        Me.LabelPageName.Name = "LabelPageName"
        Me.LabelPageName.Size = New System.Drawing.Size(146, 41)
        Me.LabelPageName.TabIndex = 20
        Me.LabelPageName.Text = "PageName"
        '
        'BtnMain2Close
        '
        Me.BtnMain2Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMain2Close.BackgroundImage = Global.Project_CTM.My.Resources.Resources.multiply_1
        Me.BtnMain2Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMain2Close.FlatAppearance.BorderSize = 0
        Me.BtnMain2Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMain2Close.Location = New System.Drawing.Point(1277, 13)
        Me.BtnMain2Close.Name = "BtnMain2Close"
        Me.BtnMain2Close.Size = New System.Drawing.Size(50, 50)
        Me.BtnMain2Close.TabIndex = 19
        Me.BtnMain2Close.UseVisualStyleBackColor = True
        '
        'BtnBranchTopPage
        '
        Me.BtnBranchTopPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBranchTopPage.FlatAppearance.BorderSize = 0
        Me.BtnBranchTopPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBranchTopPage.Font = New System.Drawing.Font("Kanit SemiBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBranchTopPage.ForeColor = System.Drawing.Color.Black
        Me.BtnBranchTopPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBranchTopPage.Location = New System.Drawing.Point(357, 7)
        Me.BtnBranchTopPage.Name = "BtnBranchTopPage"
        Me.BtnBranchTopPage.Size = New System.Drawing.Size(213, 63)
        Me.BtnBranchTopPage.TabIndex = 18
        Me.BtnBranchTopPage.Text = "สาขา"
        Me.BtnBranchTopPage.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1277, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 31)
        Me.Button2.TabIndex = 13
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnUserName
        '
        Me.BtnUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserName.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserName.Image = Global.Project_CTM.My.Resources.Resources.exit1
        Me.BtnUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUserName.Location = New System.Drawing.Point(936, 23)
        Me.BtnUserName.Name = "BtnUserName"
        Me.BtnUserName.Size = New System.Drawing.Size(159, 31)
        Me.BtnUserName.TabIndex = 12
        Me.BtnUserName.Text = "User"
        Me.BtnUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUserName.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(730, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 31)
        Me.DateTimePicker1.TabIndex = 11
        '
        'LabelNameTabPage
        '
        Me.LabelNameTabPage.AutoSize = True
        Me.LabelNameTabPage.Font = New System.Drawing.Font("Kanit", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameTabPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LabelNameTabPage.Location = New System.Drawing.Point(78, 14)
        Me.LabelNameTabPage.Name = "LabelNameTabPage"
        Me.LabelNameTabPage.Size = New System.Drawing.Size(0, 57)
        Me.LabelNameTabPage.TabIndex = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Project_CTM.My.Resources.Resources.LOGO_CHA_TM
        Me.PictureBox4.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(95, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'SaleList
        '
        Me.SaleList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SaleList.FormattingEnabled = True
        Me.SaleList.Location = New System.Drawing.Point(272, -1)
        Me.SaleList.Name = "SaleList"
        Me.SaleList.Size = New System.Drawing.Size(151, 78)
        Me.SaleList.TabIndex = 23
        '
        'TabControlMain
        '
        Me.TabControlMain.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TabControlMain.AppearancePage.Header.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabControlMain.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlMain.AppearancePage.Header.ForeColor = System.Drawing.Color.White
        Me.TabControlMain.AppearancePage.Header.Options.UseBackColor = True
        Me.TabControlMain.AppearancePage.Header.Options.UseFont = True
        Me.TabControlMain.AppearancePage.Header.Options.UseForeColor = True
        Me.TabControlMain.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabControlMain.AppearancePage.HeaderActive.Options.UseBackColor = True
        Me.TabControlMain.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlMain.AppearancePage.PageClient.Options.UseFont = True
        Me.TabControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.TabControlMain.Location = New System.Drawing.Point(0, 82)
        Me.TabControlMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControlMain.LookAndFeel.UseWindowsXPTheme = True
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.PaintStyleName = "Flat"
        Me.TabControlMain.SelectedTabPage = Me.XtraTabPage1
        Me.TabControlMain.Size = New System.Drawing.Size(1339, 597)
        Me.TabControlMain.TabIndex = 3
        Me.TabControlMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9, Me.XtraTabPage10, Me.XtraTabPage11, Me.XtraTabPage12})
        Me.TabControlMain.TabPageWidth = 80
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AllowTouchScroll = True
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage1.Appearance.PageClient.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Appearance.PageClient.Options.UseFont = True
        Me.XtraTabPage1.Image = Global.Project_CTM.My.Resources.Resources.ขายสินค้า
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Image = Global.Project_CTM.My.Resources.Resources.โต๊ะ
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage3.Appearance.PageClient.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage3.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage3.Appearance.PageClient.Options.UseFont = True
        Me.XtraTabPage3.Image = Global.Project_CTM.My.Resources.Resources.ค้นบิล
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Image = Global.Project_CTM.My.Resources.Resources.สินค้า
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.PageVisible = False
        Me.XtraTabPage4.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Image = Global.Project_CTM.My.Resources.Resources.กลุ่มสินค้า
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.PageVisible = False
        Me.XtraTabPage5.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.AllowTouchScroll = True
        Me.XtraTabPage6.Image = Global.Project_CTM.My.Resources.Resources.สต๊อก
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.PageVisible = False
        Me.XtraTabPage6.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Image = Global.Project_CTM.My.Resources.Resources.วัตถุดิบ
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.PageVisible = False
        Me.XtraTabPage7.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Image = Global.Project_CTM.My.Resources.Resources.รายงาน
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.PageVisible = False
        Me.XtraTabPage8.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Image = Global.Project_CTM.My.Resources.Resources.สมาชิก
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.PageVisible = False
        Me.XtraTabPage9.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage10
        '
        Me.XtraTabPage10.Image = Global.Project_CTM.My.Resources.Resources.พนักงาน
        Me.XtraTabPage10.Name = "XtraTabPage10"
        Me.XtraTabPage10.PageVisible = False
        Me.XtraTabPage10.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage11
        '
        Me.XtraTabPage11.AllowTouchScroll = True
        Me.XtraTabPage11.AutoScroll = True
        Me.XtraTabPage11.Image = Global.Project_CTM.My.Resources.Resources.ตั้งค่า
        Me.XtraTabPage11.Name = "XtraTabPage11"
        Me.XtraTabPage11.PageVisible = False
        Me.XtraTabPage11.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPage12
        '
        Me.XtraTabPage12.Controls.Add(Me.XtraTabPromotion)
        Me.XtraTabPage12.Image = Global.Project_CTM.My.Resources.Resources.โปร
        Me.XtraTabPage12.Name = "XtraTabPage12"
        Me.XtraTabPage12.Padding = New System.Windows.Forms.Padding(15)
        Me.XtraTabPage12.PageVisible = False
        Me.XtraTabPage12.Size = New System.Drawing.Size(1250, 597)
        '
        'XtraTabPromotion
        '
        Me.XtraTabPromotion.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPromotion.Appearance.Options.UseFont = True
        Me.XtraTabPromotion.AppearancePage.Header.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPromotion.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabPromotion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabPromotion.Location = New System.Drawing.Point(15, 15)
        Me.XtraTabPromotion.Name = "XtraTabPromotion"
        Me.XtraTabPromotion.SelectedTabPage = Me.TabPagePromotion
        Me.XtraTabPromotion.Size = New System.Drawing.Size(1220, 567)
        Me.XtraTabPromotion.TabIndex = 0
        Me.XtraTabPromotion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPagePromotion, Me.TabPagePoint})
        '
        'TabPagePromotion
        '
        Me.TabPagePromotion.Name = "TabPagePromotion"
        Me.TabPagePromotion.Size = New System.Drawing.Size(1214, 528)
        Me.TabPagePromotion.Text = "จัดการโปรโมชั่น"
        '
        'TabPagePoint
        '
        Me.TabPagePoint.Name = "TabPagePoint"
        Me.TabPagePoint.Size = New System.Drawing.Size(1214, 528)
        Me.TabPagePoint.Text = "จัดการแต้มสะสม"
        '
        'Timer1
        '
        '
        'Main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 679)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main2"
        Me.Text = "Main2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlMain.ResumeLayout(False)
        Me.XtraTabPage12.ResumeLayout(False)
        CType(Me.XtraTabPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPromotion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBranchTopPage As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnUserName As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelNameTabPage As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TabControlMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BtnMain2Close As Button
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage10 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage11 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelPageName As Label
    Friend WithEvents BtnCloseShift As Button
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTime As Label
    Friend WithEvents XtraTabPage12 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPromotion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabPagePromotion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabPagePoint As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SaleList As ListBox
End Class
