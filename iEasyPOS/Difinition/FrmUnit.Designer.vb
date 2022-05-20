<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnit
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel70 = New System.Windows.Forms.Panel()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel71 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtUnitName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel56 = New System.Windows.Forms.Panel()
        Me.Panel57 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Dg_ItemUnit = New System.Windows.Forms.DataGridView()
        Me.UnitId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.BtnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel70.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel56.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.Dg_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel54.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel2.Size = New System.Drawing.Size(1359, 648)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(20, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1319, 628)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(443, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(876, 628)
        Me.Panel5.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Panel70)
        Me.Panel6.Controls.Add(Me.Panel23)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(6, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(870, 628)
        Me.Panel6.TabIndex = 0
        '
        'Panel70
        '
        Me.Panel70.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel70.Controls.Add(Me.BtnSave)
        Me.Panel70.Controls.Add(Me.Panel71)
        Me.Panel70.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel70.Location = New System.Drawing.Point(0, 564)
        Me.Panel70.Name = "Panel70"
        Me.Panel70.Size = New System.Drawing.Size(870, 64)
        Me.Panel70.TabIndex = 166
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.Appearance.Options.UseForeColor = True
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_SaveWhite
        Me.BtnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnSave.Location = New System.Drawing.Point(752, 19)
        Me.BtnSave.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnSave.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnSave.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(103, 33)
        Me.BtnSave.TabIndex = 155
        Me.BtnSave.Text = "บันทึก"
        '
        'Panel71
        '
        Me.Panel71.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel71.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel71.Location = New System.Drawing.Point(0, 0)
        Me.Panel71.Name = "Panel71"
        Me.Panel71.Size = New System.Drawing.Size(870, 6)
        Me.Panel71.TabIndex = 159
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.TxtUnit)
        Me.Panel23.Controls.Add(Me.Label5)
        Me.Panel23.Controls.Add(Me.Panel4)
        Me.Panel23.Controls.Add(Me.TxtUnitName)
        Me.Panel23.Controls.Add(Me.Label2)
        Me.Panel23.Controls.Add(Me.Panel1)
        Me.Panel23.Controls.Add(Me.Panel56)
        Me.Panel23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(870, 192)
        Me.Panel23.TabIndex = 155
        '
        'TxtUnit
        '
        Me.TxtUnit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUnit.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnit.ForeColor = System.Drawing.Color.Black
        Me.TxtUnit.Location = New System.Drawing.Point(414, 87)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.Size = New System.Drawing.Size(319, 24)
        Me.TxtUnit.TabIndex = 168
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(403, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 24)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "ตัวคูณ"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(412, 116)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(319, 1)
        Me.Panel4.TabIndex = 170
        '
        'TxtUnitName
        '
        Me.TxtUnitName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUnitName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUnitName.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitName.ForeColor = System.Drawing.Color.Black
        Me.TxtUnitName.Location = New System.Drawing.Point(42, 87)
        Me.TxtUnitName.Name = "TxtUnitName"
        Me.TxtUnitName.Size = New System.Drawing.Size(319, 24)
        Me.TxtUnitName.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 24)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "หน่วย"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(40, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 1)
        Me.Panel1.TabIndex = 164
        '
        'Panel56
        '
        Me.Panel56.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel56.Controls.Add(Me.Panel57)
        Me.Panel56.Controls.Add(Me.Label1)
        Me.Panel56.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel56.Location = New System.Drawing.Point(0, 0)
        Me.Panel56.Name = "Panel56"
        Me.Panel56.Size = New System.Drawing.Size(870, 43)
        Me.Panel56.TabIndex = 155
        '
        'Panel57
        '
        Me.Panel57.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel57.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel57.Location = New System.Drawing.Point(0, 42)
        Me.Panel57.Name = "Panel57"
        Me.Panel57.Size = New System.Drawing.Size(870, 1)
        Me.Panel57.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "รายละเอียด"
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(6, 628)
        Me.Panel13.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Dg_ItemUnit)
        Me.Panel7.Controls.Add(Me.Panel54)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(443, 628)
        Me.Panel7.TabIndex = 5
        '
        'Dg_ItemUnit
        '
        Me.Dg_ItemUnit.AllowUserToAddRows = False
        Me.Dg_ItemUnit.AllowUserToDeleteRows = False
        Me.Dg_ItemUnit.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Dg_ItemUnit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dg_ItemUnit.BackgroundColor = System.Drawing.Color.White
        Me.Dg_ItemUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg_ItemUnit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dg_ItemUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_ItemUnit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dg_ItemUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_ItemUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitId, Me.UnitName, Me.UnitValue})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_ItemUnit.DefaultCellStyle = DataGridViewCellStyle10
        Me.Dg_ItemUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_ItemUnit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_ItemUnit.EnableHeadersVisualStyles = False
        Me.Dg_ItemUnit.GridColor = System.Drawing.Color.White
        Me.Dg_ItemUnit.Location = New System.Drawing.Point(0, 0)
        Me.Dg_ItemUnit.Name = "Dg_ItemUnit"
        Me.Dg_ItemUnit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_ItemUnit.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Dg_ItemUnit.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Dg_ItemUnit.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.Dg_ItemUnit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_ItemUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_ItemUnit.Size = New System.Drawing.Size(443, 564)
        Me.Dg_ItemUnit.TabIndex = 161
        '
        'UnitId
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.UnitId.DefaultCellStyle = DataGridViewCellStyle9
        Me.UnitId.HeaderText = "No."
        Me.UnitId.Name = "UnitId"
        '
        'UnitName
        '
        Me.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UnitName.HeaderText = "หน่วย"
        Me.UnitName.Name = "UnitName"
        '
        'UnitValue
        '
        Me.UnitValue.HeaderText = "ตัวคูณ"
        Me.UnitValue.Name = "UnitValue"
        '
        'Panel54
        '
        Me.Panel54.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel54.Controls.Add(Me.BtnAdd)
        Me.Panel54.Controls.Add(Me.Panel67)
        Me.Panel54.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel54.Location = New System.Drawing.Point(0, 564)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(443, 64)
        Me.Panel54.TabIndex = 160
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Appearance.Options.UseFont = True
        Me.BtnAdd.Appearance.Options.UseForeColor = True
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_AddWhite
        Me.BtnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnAdd.Location = New System.Drawing.Point(274, 19)
        Me.BtnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.Orange
        Me.BtnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnAdd.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(151, 33)
        Me.BtnAdd.TabIndex = 154
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(443, 6)
        Me.Panel67.TabIndex = 20
        '
        'FrmUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1359, 648)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel5.ResumeLayout(false)
        Me.Panel5.PerformLayout
        Me.Panel6.ResumeLayout(false)
        Me.Panel70.ResumeLayout(false)
        Me.Panel23.ResumeLayout(false)
        Me.Panel23.PerformLayout
        Me.Panel56.ResumeLayout(false)
        Me.Panel56.PerformLayout
        Me.Panel7.ResumeLayout(false)
        CType(Me.Dg_ItemUnit,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel54.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel70 As Panel
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel71 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents TxtUnit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtUnitName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel56 As Panel
    Friend WithEvents Panel57 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Dg_ItemUnit As DataGridView
    Friend WithEvents Panel54 As Panel
    Friend WithEvents BtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel67 As Panel
    Friend WithEvents UnitId As DataGridViewTextBoxColumn
    Friend WithEvents UnitName As DataGridViewTextBoxColumn
    Friend WithEvents UnitValue As DataGridViewTextBoxColumn
End Class
