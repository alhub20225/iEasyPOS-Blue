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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DgRoles = New System.Windows.Forms.DataGridView()
        Me.Panel54 = New System.Windows.Forms.Panel()
        Me.BtnActive = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRolesName = New System.Windows.Forms.TextBox()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DgAuthorityRoles = New System.Windows.Forms.DataGridView()
        Me.RoleActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Authority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.ChkAll2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnUpdateRoleAut = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ลำดับ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อสิทธิการใช้งาน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DgRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel54.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DgAuthorityRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Panel2.Size = New System.Drawing.Size(1249, 728)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.DgRoles)
        Me.Panel3.Controls.Add(Me.Panel54)
        Me.Panel3.Controls.Add(Me.Panel24)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel3.Location = New System.Drawing.Point(20, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 708)
        Me.Panel3.TabIndex = 0
        '
        'DgRoles
        '
        Me.DgRoles.AllowUserToAddRows = False
        Me.DgRoles.AllowUserToDeleteRows = False
        Me.DgRoles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DgRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgRoles.BackgroundColor = System.Drawing.Color.White
        Me.DgRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ลำดับ, Me.ชื่อสิทธิการใช้งาน})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgRoles.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgRoles.EnableHeadersVisualStyles = False
        Me.DgRoles.GridColor = System.Drawing.Color.White
        Me.DgRoles.Location = New System.Drawing.Point(0, 158)
        Me.DgRoles.Name = "DgRoles"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgRoles.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DgRoles.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgRoles.Size = New System.Drawing.Size(609, 486)
        Me.DgRoles.TabIndex = 173
        '
        'Panel54
        '
        Me.Panel54.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel54.Controls.Add(Me.BtnActive)
        Me.Panel54.Controls.Add(Me.Panel67)
        Me.Panel54.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel54.Location = New System.Drawing.Point(0, 644)
        Me.Panel54.Name = "Panel54"
        Me.Panel54.Size = New System.Drawing.Size(609, 64)
        Me.Panel54.TabIndex = 172
        '
        'BtnActive
        '
        Me.BtnActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnActive.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActive.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnActive.Appearance.Options.UseFont = True
        Me.BtnActive.Appearance.Options.UseForeColor = True
        Me.BtnActive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActive.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_DeleteWhite
        Me.BtnActive.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnActive.Location = New System.Drawing.Point(488, 19)
        Me.BtnActive.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnActive.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnActive.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnActive.Name = "BtnActive"
        Me.BtnActive.Size = New System.Drawing.Size(103, 33)
        Me.BtnActive.TabIndex = 156
        Me.BtnActive.Text = "ลบข้อมูล"
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(609, 6)
        Me.Panel67.TabIndex = 20
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 152)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(609, 6)
        Me.Panel24.TabIndex = 170
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.BtnSave)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.TxtRolesName)
        Me.Panel10.Controls.Add(Me.Panel53)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(609, 152)
        Me.Panel10.TabIndex = 171
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Icon_AddTableGary
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(408, 88)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(30, 31)
        Me.BtnSave.TabIndex = 161
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(609, 43)
        Me.Panel11.TabIndex = 160
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 42)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(609, 1)
        Me.Panel12.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "สิทธิการใช้งาน"
        '
        'TxtRolesName
        '
        Me.TxtRolesName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtRolesName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRolesName.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRolesName.ForeColor = System.Drawing.Color.Black
        Me.TxtRolesName.Location = New System.Drawing.Point(33, 88)
        Me.TxtRolesName.Name = "TxtRolesName"
        Me.TxtRolesName.Size = New System.Drawing.Size(369, 24)
        Me.TxtRolesName.TabIndex = 148
        '
        'Panel53
        '
        Me.Panel53.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel53.Location = New System.Drawing.Point(31, 117)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(369, 1)
        Me.Panel53.TabIndex = 149
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "ชื่อสิทธิ์การใช้งาน"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(629, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(6, 708)
        Me.Panel7.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.DgAuthorityRoles)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel5.Location = New System.Drawing.Point(635, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(594, 708)
        Me.Panel5.TabIndex = 17
        '
        'DgAuthorityRoles
        '
        Me.DgAuthorityRoles.AllowUserToAddRows = False
        Me.DgAuthorityRoles.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DgAuthorityRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DgAuthorityRoles.BackgroundColor = System.Drawing.Color.White
        Me.DgAuthorityRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgAuthorityRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgAuthorityRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAuthorityRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgAuthorityRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAuthorityRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoleActive, Me.Authority, Me.Column1})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgAuthorityRoles.DefaultCellStyle = DataGridViewCellStyle9
        Me.DgAuthorityRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgAuthorityRoles.EnableHeadersVisualStyles = False
        Me.DgAuthorityRoles.GridColor = System.Drawing.Color.White
        Me.DgAuthorityRoles.Location = New System.Drawing.Point(0, 0)
        Me.DgAuthorityRoles.Name = "DgAuthorityRoles"
        Me.DgAuthorityRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAuthorityRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DgAuthorityRoles.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DgAuthorityRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAuthorityRoles.Size = New System.Drawing.Size(594, 644)
        Me.DgAuthorityRoles.TabIndex = 174
        '
        'RoleActive
        '
        Me.RoleActive.HeaderText = "เลือก"
        Me.RoleActive.Name = "RoleActive"
        Me.RoleActive.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RoleActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RoleActive.Width = 60
        '
        'Authority
        '
        Me.Authority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Authority.HeaderText = "สิทธิการใช้งาน"
        Me.Authority.Name = "Authority"
        '
        'Column1
        '
        Me.Column1.HeaderText = "AuthorityRolesId"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ChkAll)
        Me.Panel1.Controls.Add(Me.ChkAll2)
        Me.Panel1.Controls.Add(Me.BtnUpdateRoleAut)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 644)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 64)
        Me.Panel1.TabIndex = 173
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.ChkAll.ForeColor = System.Drawing.Color.White
        Me.ChkAll.Location = New System.Drawing.Point(19, 24)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(106, 26)
        Me.ChkAll.TabIndex = 157
        Me.ChkAll.Text = "เลือกทั้งหมด"
        Me.ChkAll.UseVisualStyleBackColor = True
        Me.ChkAll.Visible = False
        '
        'ChkAll2
        '
        Me.ChkAll2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAll2.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAll2.Appearance.ForeColor = System.Drawing.Color.White
        Me.ChkAll2.Appearance.Options.UseFont = True
        Me.ChkAll2.Appearance.Options.UseForeColor = True
        Me.ChkAll2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAll2.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_CheckallWhite
        Me.ChkAll2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.ChkAll2.Location = New System.Drawing.Point(340, 19)
        Me.ChkAll2.LookAndFeel.SkinMaskColor = System.Drawing.Color.Orange
        Me.ChkAll2.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.ChkAll2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ChkAll2.Name = "ChkAll2"
        Me.ChkAll2.Size = New System.Drawing.Size(127, 33)
        Me.ChkAll2.TabIndex = 156
        Me.ChkAll2.Text = "เลือกทั้งหมด"
        '
        'BtnUpdateRoleAut
        '
        Me.BtnUpdateRoleAut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdateRoleAut.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateRoleAut.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateRoleAut.Appearance.Options.UseFont = True
        Me.BtnUpdateRoleAut.Appearance.Options.UseForeColor = True
        Me.BtnUpdateRoleAut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateRoleAut.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_SaveWhite
        Me.BtnUpdateRoleAut.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnUpdateRoleAut.Location = New System.Drawing.Point(473, 19)
        Me.BtnUpdateRoleAut.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnUpdateRoleAut.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnUpdateRoleAut.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnUpdateRoleAut.Name = "BtnUpdateRoleAut"
        Me.BtnUpdateRoleAut.Size = New System.Drawing.Size(103, 33)
        Me.BtnUpdateRoleAut.TabIndex = 155
        Me.BtnUpdateRoleAut.Text = "บันทึก"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(594, 6)
        Me.Panel4.TabIndex = 20
        '
        'ลำดับ
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ลำดับ.DefaultCellStyle = DataGridViewCellStyle3
        Me.ลำดับ.HeaderText = "No."
        Me.ลำดับ.Name = "ลำดับ"
        '
        'ชื่อสิทธิการใช้งาน
        '
        Me.ชื่อสิทธิการใช้งาน.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อสิทธิการใช้งาน.HeaderText = "ชื่อสิทธิ์การใช้งาน"
        Me.ชื่อสิทธิการใช้งาน.Name = "ชื่อสิทธิการใช้งาน"
        '
        'Frm_RolesManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1249, 728)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_RolesManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการสิทธิการใช้งาน"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        CType(Me.DgRoles,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel54.ResumeLayout(false)
        Me.Panel10.ResumeLayout(false)
        Me.Panel10.PerformLayout
        Me.Panel11.ResumeLayout(false)
        Me.Panel11.PerformLayout
        Me.Panel5.ResumeLayout(false)
        CType(Me.DgAuthorityRoles,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DgRoles As DataGridView
    Friend WithEvents Panel54 As Panel
    Friend WithEvents BtnActive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel67 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRolesName As TextBox
    Friend WithEvents Panel53 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DgAuthorityRoles As DataGridView
    Friend WithEvents RoleActive As DataGridViewCheckBoxColumn
    Friend WithEvents Authority As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkAll2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnUpdateRoleAut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ChkAll As CheckBox
    Friend WithEvents ลำดับ As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อสิทธิการใช้งาน As DataGridViewTextBoxColumn
End Class
