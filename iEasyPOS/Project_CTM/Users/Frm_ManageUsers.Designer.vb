<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ManageUsers
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Combo_RoleSrc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_src = New System.Windows.Forms.Button()
        Me.txtsrc = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG_Users = New System.Windows.Forms.DataGridView()
        Me.รหัส = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnDeleteUsers = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ComboRoles = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassCon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Combo_RoleSrc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_src)
        Me.GroupBox1.Controls.Add(Me.txtsrc)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Combo_RoleSrc
        '
        Me.Combo_RoleSrc.FormattingEnabled = True
        Me.Combo_RoleSrc.Location = New System.Drawing.Point(102, 67)
        Me.Combo_RoleSrc.Name = "Combo_RoleSrc"
        Me.Combo_RoleSrc.Size = New System.Drawing.Size(168, 37)
        Me.Combo_RoleSrc.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "สิทธิ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา :"
        '
        'btn_src
        '
        Me.btn_src.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_src.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_src.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.btn_src.ForeColor = System.Drawing.Color.Black
        Me.btn_src.Location = New System.Drawing.Point(276, 29)
        Me.btn_src.Name = "btn_src"
        Me.btn_src.Size = New System.Drawing.Size(75, 33)
        Me.btn_src.TabIndex = 1
        Me.btn_src.Text = "ค้นหา"
        Me.btn_src.UseVisualStyleBackColor = False
        '
        'txtsrc
        '
        Me.txtsrc.Location = New System.Drawing.Point(102, 28)
        Me.txtsrc.Name = "txtsrc"
        Me.txtsrc.Size = New System.Drawing.Size(168, 36)
        Me.txtsrc.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_Users)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 466)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DG_Users
        '
        Me.DG_Users.AllowUserToAddRows = False
        Me.DG_Users.AllowUserToDeleteRows = False
        Me.DG_Users.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DG_Users.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Users.BackgroundColor = System.Drawing.Color.White
        Me.DG_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DG_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัส, Me.ชื่อ})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Kanit", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Users.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Users.GridColor = System.Drawing.Color.White
        Me.DG_Users.Location = New System.Drawing.Point(3, 20)
        Me.DG_Users.MultiSelect = False
        Me.DG_Users.Name = "DG_Users"
        Me.DG_Users.ReadOnly = True
        Me.DG_Users.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DG_Users.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Users.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DG_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Users.Size = New System.Drawing.Size(360, 443)
        Me.DG_Users.TabIndex = 0
        '
        'รหัส
        '
        Me.รหัส.HeaderText = "รหัส"
        Me.รหัส.Name = "รหัส"
        Me.รหัส.ReadOnly = True
        '
        'ชื่อ
        '
        Me.ชื่อ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อ.HeaderText = "ชื่อ"
        Me.ชื่อ.Name = "ชื่อ"
        Me.ชื่อ.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnDeleteUsers)
        Me.GroupBox3.Controls.Add(Me.BtnAdd)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtUserName)
        Me.GroupBox3.Controls.Add(Me.BtnSave)
        Me.GroupBox3.Controls.Add(Me.ComboRoles)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtPassCon)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtPass)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(408, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 593)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'BtnDeleteUsers
        '
        Me.BtnDeleteUsers.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteUsers.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.BtnDeleteUsers.ForeColor = System.Drawing.Color.Black
        Me.BtnDeleteUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeleteUsers.Location = New System.Drawing.Point(344, 538)
        Me.BtnDeleteUsers.Name = "BtnDeleteUsers"
        Me.BtnDeleteUsers.Size = New System.Drawing.Size(119, 49)
        Me.BtnDeleteUsers.TabIndex = 12
        Me.BtnDeleteUsers.Text = "ลบข้อมูล"
        Me.BtnDeleteUsers.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(215, 538)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(123, 49)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(75, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 31)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "UserName :"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(261, 70)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(243, 39)
        Me.txtUserName.TabIndex = 11
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(469, 538)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(116, 49)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'ComboRoles
        '
        Me.ComboRoles.FormattingEnabled = True
        Me.ComboRoles.Location = New System.Drawing.Point(261, 205)
        Me.ComboRoles.Name = "ComboRoles"
        Me.ComboRoles.Size = New System.Drawing.Size(243, 39)
        Me.ComboRoles.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(132, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 31)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "สิทธิ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(47, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ยืนยันรหัสผ่าน :"
        '
        'txtPassCon
        '
        Me.txtPassCon.Location = New System.Drawing.Point(261, 160)
        Me.txtPassCon.Name = "txtPassCon"
        Me.txtPassCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassCon.Size = New System.Drawing.Size(243, 39)
        Me.txtPassCon.TabIndex = 6
        Me.txtPassCon.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(99, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รหัสผ่าน :"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(261, 115)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(243, 39)
        Me.txtPass.TabIndex = 4
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(145, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ชื่อ :"
        Me.Label3.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(261, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(243, 39)
        Me.txtName.TabIndex = 2
        Me.txtName.Visible = False
        '
        'Frm_ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 673)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการผู้ใช้งานระบบ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_Users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Combo_RoleSrc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_src As Button
    Friend WithEvents txtsrc As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DG_Users As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ComboRoles As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassCon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents รหัส As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อ As DataGridViewTextBoxColumn
    Friend WithEvents BtnDeleteUsers As Button
End Class
