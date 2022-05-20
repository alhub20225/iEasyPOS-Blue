<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnitV2
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Dg_ItemUnit = New System.Windows.Forms.DataGridView()
        Me.UnitId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel102 = New System.Windows.Forms.Panel()
        Me.Panel101 = New System.Windows.Forms.Panel()
        Me.Panel100 = New System.Windows.Forms.Panel()
        Me.Panel99 = New System.Windows.Forms.Panel()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtUnitName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel68.SuspendLayout
        Me.Panel41.SuspendLayout
        CType(Me.Dg_ItemUnit,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Panel68.Size = New System.Drawing.Size(769, 43)
        Me.Panel68.TabIndex = 338
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
        Me.Button26.Location = New System.Drawing.Point(731, 5)
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
        Me.Panel69.Size = New System.Drawing.Size(769, 1)
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
        Me.Label34.Size = New System.Drawing.Size(55, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "หน่วย"
        '
        'Panel41
        '
        Me.Panel41.Controls.Add(Me.Dg_ItemUnit)
        Me.Panel41.Controls.Add(Me.Panel102)
        Me.Panel41.Controls.Add(Me.Panel101)
        Me.Panel41.Controls.Add(Me.Panel100)
        Me.Panel41.Controls.Add(Me.Panel99)
        Me.Panel41.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel41.Location = New System.Drawing.Point(30, 143)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(708, 224)
        Me.Panel41.TabIndex = 344
        '
        'Dg_ItemUnit
        '
        Me.Dg_ItemUnit.AllowUserToAddRows = false
        Me.Dg_ItemUnit.AllowUserToDeleteRows = false
        Me.Dg_ItemUnit.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Dg_ItemUnit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_ItemUnit.BackgroundColor = System.Drawing.Color.White
        Me.Dg_ItemUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg_ItemUnit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dg_ItemUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_ItemUnit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_ItemUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_ItemUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitId, Me.UnitName, Me.UnitValue})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_ItemUnit.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dg_ItemUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_ItemUnit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_ItemUnit.EnableHeadersVisualStyles = false
        Me.Dg_ItemUnit.GridColor = System.Drawing.Color.White
        Me.Dg_ItemUnit.Location = New System.Drawing.Point(1, 1)
        Me.Dg_ItemUnit.Name = "Dg_ItemUnit"
        Me.Dg_ItemUnit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_ItemUnit.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Dg_ItemUnit.RowHeadersVisible = false
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Dg_ItemUnit.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Dg_ItemUnit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_ItemUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_ItemUnit.Size = New System.Drawing.Size(706, 222)
        Me.Dg_ItemUnit.TabIndex = 297
        '
        'UnitId
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.UnitId.DefaultCellStyle = DataGridViewCellStyle3
        Me.UnitId.HeaderText = "ลำดับ"
        Me.UnitId.Name = "UnitId"
        '
        'UnitName
        '
        Me.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.UnitName.DefaultCellStyle = DataGridViewCellStyle4
        Me.UnitName.HeaderText = "หน่วย"
        Me.UnitName.Name = "UnitName"
        '
        'UnitValue
        '
        Me.UnitValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.UnitValue.DefaultCellStyle = DataGridViewCellStyle5
        Me.UnitValue.HeaderText = "ตัวคูณ"
        Me.UnitValue.Name = "UnitValue"
        '
        'Panel102
        '
        Me.Panel102.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel102.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel102.Location = New System.Drawing.Point(1, 223)
        Me.Panel102.Name = "Panel102"
        Me.Panel102.Size = New System.Drawing.Size(706, 1)
        Me.Panel102.TabIndex = 296
        '
        'Panel101
        '
        Me.Panel101.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel101.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel101.Location = New System.Drawing.Point(1, 0)
        Me.Panel101.Name = "Panel101"
        Me.Panel101.Size = New System.Drawing.Size(706, 1)
        Me.Panel101.TabIndex = 295
        '
        'Panel100
        '
        Me.Panel100.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel100.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel100.Location = New System.Drawing.Point(707, 0)
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
        'TxtUnit
        '
        Me.TxtUnit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUnit.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtUnit.ForeColor = System.Drawing.Color.Black
        Me.TxtUnit.Location = New System.Drawing.Point(387, 88)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.Size = New System.Drawing.Size(319, 24)
        Me.TxtUnit.TabIndex = 348
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(376, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 24)
        Me.Label5.TabIndex = 349
        Me.Label5.Text = "ตัวคูณ"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel4.Location = New System.Drawing.Point(385, 117)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(319, 1)
        Me.Panel4.TabIndex = 350
        '
        'TxtUnitName
        '
        Me.TxtUnitName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUnitName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUnitName.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtUnitName.ForeColor = System.Drawing.Color.Black
        Me.TxtUnitName.Location = New System.Drawing.Point(37, 88)
        Me.TxtUnitName.Name = "TxtUnitName"
        Me.TxtUnitName.Size = New System.Drawing.Size(319, 24)
        Me.TxtUnitName.TabIndex = 345
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 24)
        Me.Label2.TabIndex = 346
        Me.Label2.Text = "หน่วย"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel1.Location = New System.Drawing.Point(35, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 1)
        Me.Panel1.TabIndex = 347
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
        Me.BtnAdd.Location = New System.Drawing.Point(482, 385)
        Me.BtnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.Orange
        Me.BtnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnAdd.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnAdd.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(125, 33)
        Me.BtnAdd.TabIndex = 353
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
        Me.BtnSave.Location = New System.Drawing.Point(613, 385)
        Me.BtnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BtnSave.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnSave.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 33)
        Me.BtnSave.TabIndex = 352
        Me.BtnSave.Text = "บันทึก"
        '
        'FrmUnitV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 444)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtUnit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtUnitName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel41)
        Me.Controls.Add(Me.Panel68)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUnitV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUnitV2"
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        Me.Panel41.ResumeLayout(false)
        CType(Me.Dg_ItemUnit,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel68 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel102 As Panel
    Friend WithEvents Panel101 As Panel
    Friend WithEvents Panel100 As Panel
    Friend WithEvents Panel99 As Panel
    Friend WithEvents Dg_ItemUnit As DataGridView
    Friend WithEvents TxtUnit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtUnitName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UnitId As DataGridViewTextBoxColumn
    Friend WithEvents UnitName As DataGridViewTextBoxColumn
    Friend WithEvents UnitValue As DataGridViewTextBoxColumn
End Class
