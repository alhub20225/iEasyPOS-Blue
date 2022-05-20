<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageTaxV2
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.NumerricMultiply = New System.Windows.Forms.NumericUpDown()
        Me.BtnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Dg_Tax = New System.Windows.Forms.DataGridView()
        Me.รายละเอียด = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ตัวคูณ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel102 = New System.Windows.Forms.Panel()
        Me.Panel101 = New System.Windows.Forms.Panel()
        Me.Panel100 = New System.Windows.Forms.Panel()
        Me.Panel99 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel62 = New System.Windows.Forms.Panel()
        Me.TxtnameTax = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel63 = New System.Windows.Forms.Panel()
        Me.Panel68.SuspendLayout
        CType(Me.NumerricMultiply,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel41.SuspendLayout
        CType(Me.Dg_Tax,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Panel68.Size = New System.Drawing.Size(789, 43)
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
        Me.Button26.Location = New System.Drawing.Point(751, 5)
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
        Me.Panel69.Size = New System.Drawing.Size(789, 1)
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
        Me.Label34.Size = New System.Drawing.Size(45, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "ภาษี"
        '
        'BtnAdd
        '
        Me.BtnAdd.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnAdd.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Appearance.Options.UseFont = true
        Me.BtnAdd.Appearance.Options.UseForeColor = true
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_AddWhite
        Me.BtnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnAdd.Location = New System.Drawing.Point(372, 385)
        Me.BtnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.Orange
        Me.BtnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnAdd.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnAdd.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(125, 33)
        Me.BtnAdd.TabIndex = 347
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Appearance.Options.UseFont = true
        Me.BtnSave.Appearance.Options.UseForeColor = true
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_SaveWhite
        Me.BtnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnSave.Location = New System.Drawing.Point(634, 385)
        Me.BtnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BtnSave.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnSave.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 33)
        Me.BtnSave.TabIndex = 346
        Me.BtnSave.Text = "บันทึก"
        '
        'NumerricMultiply
        '
        Me.NumerricMultiply.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NumerricMultiply.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumerricMultiply.Font = New System.Drawing.Font("Kanit", 12!)
        Me.NumerricMultiply.Location = New System.Drawing.Point(404, 89)
        Me.NumerricMultiply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumerricMultiply.Name = "NumerricMultiply"
        Me.NumerricMultiply.Size = New System.Drawing.Size(312, 27)
        Me.NumerricMultiply.TabIndex = 345
        '
        'BtnDelete
        '
        Me.BtnDelete.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnDelete.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Appearance.Options.UseFont = true
        Me.BtnDelete.Appearance.Options.UseForeColor = true
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_DeleteWhite
        Me.BtnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnDelete.Location = New System.Drawing.Point(503, 385)
        Me.BtnDelete.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnDelete.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnDelete.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(125, 33)
        Me.BtnDelete.TabIndex = 344
        Me.BtnDelete.Text = "ลบข้อมูล"
        '
        'Panel41
        '
        Me.Panel41.Controls.Add(Me.Dg_Tax)
        Me.Panel41.Controls.Add(Me.Panel102)
        Me.Panel41.Controls.Add(Me.Panel101)
        Me.Panel41.Controls.Add(Me.Panel100)
        Me.Panel41.Controls.Add(Me.Panel99)
        Me.Panel41.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel41.Location = New System.Drawing.Point(30, 143)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(729, 224)
        Me.Panel41.TabIndex = 343
        '
        'Dg_Tax
        '
        Me.Dg_Tax.AllowUserToAddRows = false
        Me.Dg_Tax.AllowUserToResizeColumns = false
        Me.Dg_Tax.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Dg_Tax.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Tax.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Tax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg_Tax.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dg_Tax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Tax.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Tax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Tax.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รายละเอียด, Me.ตัวคูณ, Me.TaxId})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Tax.DefaultCellStyle = DataGridViewCellStyle5
        Me.Dg_Tax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Tax.EnableHeadersVisualStyles = false
        Me.Dg_Tax.GridColor = System.Drawing.Color.White
        Me.Dg_Tax.Location = New System.Drawing.Point(1, 1)
        Me.Dg_Tax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dg_Tax.Name = "Dg_Tax"
        Me.Dg_Tax.ReadOnly = true
        Me.Dg_Tax.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Tax.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Dg_Tax.RowHeadersVisible = false
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Dg_Tax.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dg_Tax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Tax.Size = New System.Drawing.Size(727, 222)
        Me.Dg_Tax.TabIndex = 297
        '
        'รายละเอียด
        '
        Me.รายละเอียด.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.รายละเอียด.DefaultCellStyle = DataGridViewCellStyle3
        Me.รายละเอียด.HeaderText = "รายละเอียด"
        Me.รายละเอียด.Name = "รายละเอียด"
        Me.รายละเอียด.ReadOnly = true
        '
        'ตัวคูณ
        '
        Me.ตัวคูณ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.ตัวคูณ.DefaultCellStyle = DataGridViewCellStyle4
        Me.ตัวคูณ.HeaderText = "ตัวคูณ"
        Me.ตัวคูณ.Name = "ตัวคูณ"
        Me.ตัวคูณ.ReadOnly = true
        '
        'TaxId
        '
        Me.TaxId.HeaderText = "TaxId"
        Me.TaxId.Name = "TaxId"
        Me.TaxId.ReadOnly = true
        Me.TaxId.Visible = false
        '
        'Panel102
        '
        Me.Panel102.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel102.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel102.Location = New System.Drawing.Point(1, 223)
        Me.Panel102.Name = "Panel102"
        Me.Panel102.Size = New System.Drawing.Size(727, 1)
        Me.Panel102.TabIndex = 296
        '
        'Panel101
        '
        Me.Panel101.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel101.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel101.Location = New System.Drawing.Point(1, 0)
        Me.Panel101.Name = "Panel101"
        Me.Panel101.Size = New System.Drawing.Size(727, 1)
        Me.Panel101.TabIndex = 295
        '
        'Panel100
        '
        Me.Panel100.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel100.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel100.Location = New System.Drawing.Point(728, 0)
        Me.Panel100.Name = "Panel100"
        Me.Panel100.Size = New System.Drawing.Size(1, 224)
        Me.Panel100.TabIndex = 294
        '
        'Panel99
        '
        Me.Panel99.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel99.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel99.Location = New System.Drawing.Point(0, 0)
        Me.Panel99.Name = "Panel99"
        Me.Panel99.Size = New System.Drawing.Size(1, 224)
        Me.Panel99.TabIndex = 293
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label14.Location = New System.Drawing.Point(391, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 24)
        Me.Label14.TabIndex = 341
        Me.Label14.Text = "ตัวคูณ"
        '
        'Panel62
        '
        Me.Panel62.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel62.Location = New System.Drawing.Point(400, 117)
        Me.Panel62.Name = "Panel62"
        Me.Panel62.Size = New System.Drawing.Size(319, 1)
        Me.Panel62.TabIndex = 342
        '
        'TxtnameTax
        '
        Me.TxtnameTax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtnameTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtnameTax.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtnameTax.Location = New System.Drawing.Point(37, 88)
        Me.TxtnameTax.Name = "TxtnameTax"
        Me.TxtnameTax.Size = New System.Drawing.Size(317, 24)
        Me.TxtnameTax.TabIndex = 338
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label16.Location = New System.Drawing.Point(26, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 24)
        Me.Label16.TabIndex = 339
        Me.Label16.Text = "ภาษี"
        '
        'Panel63
        '
        Me.Panel63.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel63.Location = New System.Drawing.Point(35, 117)
        Me.Panel63.Name = "Panel63"
        Me.Panel63.Size = New System.Drawing.Size(319, 1)
        Me.Panel63.TabIndex = 340
        '
        'FrmManageTaxV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 444)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.NumerricMultiply)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Panel41)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel62)
        Me.Controls.Add(Me.TxtnameTax)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel63)
        Me.Controls.Add(Me.Panel68)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmManageTaxV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmManageTaxV2"
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        CType(Me.NumerricMultiply,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel41.ResumeLayout(false)
        CType(Me.Dg_Tax,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel68 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents BtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NumerricMultiply As NumericUpDown
    Friend WithEvents BtnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Dg_Tax As DataGridView
    Friend WithEvents รายละเอียด As DataGridViewTextBoxColumn
    Friend WithEvents ตัวคูณ As DataGridViewTextBoxColumn
    Friend WithEvents TaxId As DataGridViewTextBoxColumn
    Friend WithEvents Panel102 As Panel
    Friend WithEvents Panel101 As Panel
    Friend WithEvents Panel100 As Panel
    Friend WithEvents Panel99 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel62 As Panel
    Friend WithEvents TxtnameTax As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel63 As Panel
End Class
