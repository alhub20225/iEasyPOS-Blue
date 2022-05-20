<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_RolesManage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgRoles = New System.Windows.Forms.DataGridView()
        Me.ลำดับ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อสิทธิการใช้งาน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.TabSetRoles = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ChkRoles = New System.Windows.Forms.CheckedListBox()
        Me.TxtRolesName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnActive = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabSetRoles.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.DgRoles)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 564)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DgRoles
        '
        Me.DgRoles.AllowUserToAddRows = False
        Me.DgRoles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DgRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgRoles.BackgroundColor = System.Drawing.Color.White
        Me.DgRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 14.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ลำดับ, Me.ชื่อสิทธิการใช้งาน})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Kanit", 14.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgRoles.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgRoles.Location = New System.Drawing.Point(3, 32)
        Me.DgRoles.Name = "DgRoles"
        Me.DgRoles.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DgRoles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgRoles.Size = New System.Drawing.Size(443, 529)
        Me.DgRoles.TabIndex = 0
        '
        'ลำดับ
        '
        Me.ลำดับ.HeaderText = "ลำดับ"
        Me.ลำดับ.Name = "ลำดับ"
        '
        'ชื่อสิทธิการใช้งาน
        '
        Me.ชื่อสิทธิการใช้งาน.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อสิทธิการใช้งาน.HeaderText = "ชื่อสิทธิการใช้งาน"
        Me.ชื่อสิทธิการใช้งาน.Name = "ชื่อสิทธิการใช้งาน"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.ChkAll)
        Me.GroupBox2.Controls.Add(Me.TabSetRoles)
        Me.GroupBox2.Controls.Add(Me.TxtRolesName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(531, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 586)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.ChkAll.Location = New System.Drawing.Point(10, 558)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(106, 26)
        Me.ChkAll.TabIndex = 3
        Me.ChkAll.Text = "เลือกทั้งหมด"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'TabSetRoles
        '
        Me.TabSetRoles.Controls.Add(Me.TabPage1)
        Me.TabSetRoles.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.TabSetRoles.Location = New System.Drawing.Point(10, 65)
        Me.TabSetRoles.Name = "TabSetRoles"
        Me.TabSetRoles.SelectedIndex = 0
        Me.TabSetRoles.Size = New System.Drawing.Size(384, 487)
        Me.TabSetRoles.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ChkRoles)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "สิทธิการใช้งาน"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ChkRoles
        '
        Me.ChkRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkRoles.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.ChkRoles.FormattingEnabled = True
        Me.ChkRoles.HorizontalScrollbar = True
        Me.ChkRoles.Items.AddRange(New Object() {"ตั้งค่าสินค้า", "ตั้งค่าพนักงาน", "จัดการสมาชิก", "จัดการวัตถุดิบ", "ดูรายงานย้อนหลัง", "ตั้งค่าระบบ", "ตั้งค่าโปรโมชั่น", "ผังร้าน", "ออร์เดอร์", "ชำระเงิน"})
        Me.ChkRoles.Location = New System.Drawing.Point(3, 3)
        Me.ChkRoles.Name = "ChkRoles"
        Me.ChkRoles.Size = New System.Drawing.Size(370, 439)
        Me.ChkRoles.TabIndex = 5
        '
        'TxtRolesName
        '
        Me.TxtRolesName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtRolesName.Location = New System.Drawing.Point(189, 26)
        Me.TxtRolesName.Name = "TxtRolesName"
        Me.TxtRolesName.Size = New System.Drawing.Size(205, 33)
        Me.TxtRolesName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อสิทธิการใช้งาน :"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Location = New System.Drawing.Point(917, 604)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(92, 33)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(369, 604)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(92, 33)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnActive
        '
        Me.BtnActive.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActive.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnActive.ForeColor = System.Drawing.Color.Black
        Me.BtnActive.Location = New System.Drawing.Point(531, 604)
        Me.BtnActive.Name = "BtnActive"
        Me.BtnActive.Size = New System.Drawing.Size(92, 33)
        Me.BtnActive.TabIndex = 4
        Me.BtnActive.Text = "ลบ"
        Me.BtnActive.UseVisualStyleBackColor = False
        '
        'Frm_RolesManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 649)
        Me.Controls.Add(Me.BtnActive)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_RolesManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการสิทธิการใช้งาน"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabSetRoles.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgRoles As DataGridView
    Friend WithEvents TxtRolesName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabSetRoles As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnActive As Button
    Friend WithEvents ChkRoles As CheckedListBox
    Friend WithEvents ลำดับ As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสิทธิการใช้งาน As DataGridViewTextBoxColumn
    Friend WithEvents ChkAll As CheckBox
End Class
