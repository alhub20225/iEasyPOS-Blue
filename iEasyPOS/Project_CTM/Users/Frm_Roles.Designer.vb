<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Roles
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
        Me.txtRoleNameTH = New System.Windows.Forms.TextBox()
        Me.txtRoleNameEN = New System.Windows.Forms.TextBox()
        Me.ComboBoxRoleActive = New System.Windows.Forms.ComboBox()
        Me.btnAddRole = New System.Windows.Forms.Button()
        Me.DataGridView_ShowRole = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ตำแหน่ง = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ตำแหน่งEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_ShowRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRoleNameTH
        '
        Me.txtRoleNameTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRoleNameTH.Location = New System.Drawing.Point(12, 47)
        Me.txtRoleNameTH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRoleNameTH.Name = "txtRoleNameTH"
        Me.txtRoleNameTH.Size = New System.Drawing.Size(136, 24)
        Me.txtRoleNameTH.TabIndex = 0
        '
        'txtRoleNameEN
        '
        Me.txtRoleNameEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRoleNameEN.Location = New System.Drawing.Point(154, 47)
        Me.txtRoleNameEN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRoleNameEN.Name = "txtRoleNameEN"
        Me.txtRoleNameEN.Size = New System.Drawing.Size(136, 24)
        Me.txtRoleNameEN.TabIndex = 1
        '
        'ComboBoxRoleActive
        '
        Me.ComboBoxRoleActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxRoleActive.FormattingEnabled = True
        Me.ComboBoxRoleActive.Location = New System.Drawing.Point(296, 47)
        Me.ComboBoxRoleActive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxRoleActive.Name = "ComboBoxRoleActive"
        Me.ComboBoxRoleActive.Size = New System.Drawing.Size(87, 24)
        Me.ComboBoxRoleActive.TabIndex = 2
        '
        'btnAddRole
        '
        Me.btnAddRole.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.btnAddRole.Location = New System.Drawing.Point(389, 47)
        Me.btnAddRole.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddRole.Name = "btnAddRole"
        Me.btnAddRole.Size = New System.Drawing.Size(96, 30)
        Me.btnAddRole.TabIndex = 3
        Me.btnAddRole.Text = "บันทึกข้อมูล"
        Me.btnAddRole.UseVisualStyleBackColor = True
        '
        'DataGridView_ShowRole
        '
        Me.DataGridView_ShowRole.AllowUserToAddRows = False
        Me.DataGridView_ShowRole.AllowUserToDeleteRows = False
        Me.DataGridView_ShowRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ShowRole.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ตำแหน่ง, Me.ตำแหน่งEN})
        Me.DataGridView_ShowRole.Location = New System.Drawing.Point(12, 84)
        Me.DataGridView_ShowRole.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView_ShowRole.Name = "DataGridView_ShowRole"
        Me.DataGridView_ShowRole.ReadOnly = True
        Me.DataGridView_ShowRole.Size = New System.Drawing.Size(473, 395)
        Me.DataGridView_ShowRole.TabIndex = 4
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'ตำแหน่ง
        '
        Me.ตำแหน่ง.HeaderText = "ตำแหน่ง (ภาษาไทย)"
        Me.ตำแหน่ง.Name = "ตำแหน่ง"
        Me.ตำแหน่ง.ReadOnly = True
        Me.ตำแหน่ง.Width = 190
        '
        'ตำแหน่งEN
        '
        Me.ตำแหน่งEN.HeaderText = "ตำแหน่ง (ภาษาอังกฤษ)"
        Me.ตำแหน่งEN.Name = "ตำแหน่งEN"
        Me.ตำแหน่งEN.ReadOnly = True
        Me.ตำแหน่งEN.Width = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ตำแหน่ง (ภาษาไทย)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ตำแหน่ง (ภาษาอังกฤษ)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "สถานะ"
        '
        'Frm_Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 503)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_ShowRole)
        Me.Controls.Add(Me.btnAddRole)
        Me.Controls.Add(Me.ComboBoxRoleActive)
        Me.Controls.Add(Me.txtRoleNameEN)
        Me.Controls.Add(Me.txtRoleNameTH)
        Me.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Roles"
        Me.Text = "Frm_Roles"
        CType(Me.DataGridView_ShowRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRoleNameTH As TextBox
    Friend WithEvents txtRoleNameEN As TextBox
    Friend WithEvents ComboBoxRoleActive As ComboBox
    Friend WithEvents btnAddRole As Button
    Friend WithEvents DataGridView_ShowRole As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents ตำแหน่ง As DataGridViewTextBoxColumn
    Friend WithEvents ตำแหน่งEN As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
