<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_Search
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_Search))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnSerchEnter = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridSearch = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextSearch = New DevExpress.XtraEditors.TextEdit()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel68.SuspendLayout
        Me.Panel7.SuspendLayout
        CType(Me.DataGridSearch,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextSearch.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel68
        '
        Me.Panel68.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel68.Controls.Add(Me.Button14)
        Me.Panel68.Controls.Add(Me.Panel69)
        Me.Panel68.Controls.Add(Me.Label34)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(529, 43)
        Me.Panel68.TabIndex = 162
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
        Me.Button14.Location = New System.Drawing.Point(491, 5)
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
        Me.Panel69.Size = New System.Drawing.Size(529, 1)
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
        Me.Label34.Size = New System.Drawing.Size(157, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "ค้นหารายการสินค้า"
        '
        'BtnSerchEnter
        '
        Me.BtnSerchEnter.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSerchEnter.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnSerchEnter.Appearance.Options.UseFont = true
        Me.BtnSerchEnter.Appearance.Options.UseForeColor = true
        Me.BtnSerchEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSerchEnter.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.BtnSerchEnter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnSerchEnter.Location = New System.Drawing.Point(383, 545)
        Me.BtnSerchEnter.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BtnSerchEnter.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnSerchEnter.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnSerchEnter.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnSerchEnter.Name = "BtnSerchEnter"
        Me.BtnSerchEnter.Size = New System.Drawing.Size(103, 33)
        Me.BtnSerchEnter.TabIndex = 323
        Me.BtnSerchEnter.Text = "ตกลง"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Icon_Search_48Gary
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Kanit", 12!)
        Me.BtnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSearch.Location = New System.Drawing.Point(336, 102)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(30, 30)
        Me.BtnSearch.TabIndex = 322
        Me.BtnSearch.UseVisualStyleBackColor = true
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridSearch)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel7.Location = New System.Drawing.Point(38, 157)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(449, 373)
        Me.Panel7.TabIndex = 321
        '
        'DataGridSearch
        '
        Me.DataGridSearch.AllowUserToAddRows = false
        Me.DataGridSearch.AllowUserToDeleteRows = false
        Me.DataGridSearch.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.DataGridSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridSearch.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.ItemCode, Me.ItemName, Me.ItemPrice})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(31,Byte),Integer), CType(CType(53,Byte),Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridSearch.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridSearch.EnableHeadersVisualStyles = false
        Me.DataGridSearch.GridColor = System.Drawing.Color.White
        Me.DataGridSearch.Location = New System.Drawing.Point(1, 1)
        Me.DataGridSearch.Name = "DataGridSearch"
        Me.DataGridSearch.ReadOnly = true
        Me.DataGridSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSearch.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridSearch.RowHeadersVisible = false
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.DataGridSearch.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSearch.Size = New System.Drawing.Size(447, 371)
        Me.DataGridSearch.TabIndex = 23
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = true
        Me.id.Visible = false
        '
        'ItemCode
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.ItemCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemCode.HeaderText = "รหัสสินค้า"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = true
        Me.ItemCode.Width = 110
        '
        'ItemName
        '
        Me.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemName.HeaderText = "ชื่อสินค้า"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = true
        '
        'ItemPrice
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.ItemPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.ItemPrice.HeaderText = "ราคา"
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.ReadOnly = true
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(448, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 371)
        Me.Panel8.TabIndex = 22
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1, 371)
        Me.Panel9.TabIndex = 21
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(449, 1)
        Me.Panel10.TabIndex = 20
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 372)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(449, 1)
        Me.Panel11.TabIndex = 19
        '
        'TextSearch
        '
        Me.TextSearch.Location = New System.Drawing.Point(50, 98)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextSearch.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TextSearch.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TextSearch.Properties.Appearance.Options.UseBackColor = true
        Me.TextSearch.Properties.Appearance.Options.UseFont = true
        Me.TextSearch.Properties.Appearance.Options.UseForeColor = true
        Me.TextSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextSearch.Size = New System.Drawing.Size(280, 28)
        Me.TextSearch.TabIndex = 318
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel44.Location = New System.Drawing.Point(45, 130)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(285, 1)
        Me.Panel44.TabIndex = 320
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label24.Location = New System.Drawing.Point(34, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 24)
        Me.Label24.TabIndex = 319
        Me.Label24.Text = "ค้นหารายการสินค้า"
        '
        'Pos_Search
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 608)
        Me.Controls.Add(Me.BtnSerchEnter)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Panel68)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.Panel44)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Pos_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหารายการสินค้า"
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        Me.Panel7.ResumeLayout(false)
        CType(Me.DataGridSearch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextSearch.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents BtnSerchEnter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DataGridSearch As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemPrice As DataGridViewTextBoxColumn
End Class
