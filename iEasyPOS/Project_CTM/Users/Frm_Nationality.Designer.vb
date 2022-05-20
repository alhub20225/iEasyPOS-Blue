<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Nationality
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
        Me.txtNationalityTH = New System.Windows.Forms.TextBox()
        Me.btnAddNationality = New System.Windows.Forms.Button()
        Me.DataGridView_ShowNationality = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.สัญชาติTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.สัญชาติEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNationalityEN = New System.Windows.Forms.TextBox()
        Me.ComboBoxNationaliyActive = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_ShowNationality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNationalityTH
        '
        Me.txtNationalityTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNationalityTH.Location = New System.Drawing.Point(18, 59)
        Me.txtNationalityTH.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtNationalityTH.Name = "txtNationalityTH"
        Me.txtNationalityTH.Size = New System.Drawing.Size(182, 26)
        Me.txtNationalityTH.TabIndex = 0
        '
        'btnAddNationality
        '
        Me.btnAddNationality.Location = New System.Drawing.Point(548, 49)
        Me.btnAddNationality.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddNationality.Name = "btnAddNationality"
        Me.btnAddNationality.Size = New System.Drawing.Size(134, 50)
        Me.btnAddNationality.TabIndex = 1
        Me.btnAddNationality.Text = "บันทึกข้อมูล"
        Me.btnAddNationality.UseVisualStyleBackColor = True
        '
        'DataGridView_ShowNationality
        '
        Me.DataGridView_ShowNationality.AllowUserToAddRows = False
        Me.DataGridView_ShowNationality.AllowUserToDeleteRows = False
        Me.DataGridView_ShowNationality.AllowUserToResizeRows = False
        Me.DataGridView_ShowNationality.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_ShowNationality.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_ShowNationality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ShowNationality.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.สัญชาติTH, Me.สัญชาติEN})
        Me.DataGridView_ShowNationality.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_ShowNationality.Location = New System.Drawing.Point(18, 146)
        Me.DataGridView_ShowNationality.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DataGridView_ShowNationality.Name = "DataGridView_ShowNationality"
        Me.DataGridView_ShowNationality.RowHeadersVisible = False
        Me.DataGridView_ShowNationality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ShowNationality.Size = New System.Drawing.Size(664, 526)
        Me.DataGridView_ShowNationality.TabIndex = 2
        '
        'Id
        '
        Me.Id.HeaderText = ""
        Me.Id.Name = "Id"
        Me.Id.Width = 80
        '
        'สัญชาติTH
        '
        Me.สัญชาติTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.สัญชาติTH.HeaderText = "สัญชาติ(ภาษาไทย)"
        Me.สัญชาติTH.Name = "สัญชาติTH"
        '
        'สัญชาติEN
        '
        Me.สัญชาติEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.สัญชาติEN.HeaderText = "สัญชาติ(ภาษาอังกฤษ)"
        Me.สัญชาติEN.Name = "สัญชาติEN"
        '
        'txtNationalityEN
        '
        Me.txtNationalityEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNationalityEN.Location = New System.Drawing.Point(212, 59)
        Me.txtNationalityEN.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtNationalityEN.Name = "txtNationalityEN"
        Me.txtNationalityEN.Size = New System.Drawing.Size(182, 26)
        Me.txtNationalityEN.TabIndex = 3
        '
        'ComboBoxNationaliyActive
        '
        Me.ComboBoxNationaliyActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxNationaliyActive.FormattingEnabled = True
        Me.ComboBoxNationaliyActive.Location = New System.Drawing.Point(405, 59)
        Me.ComboBoxNationaliyActive.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ComboBoxNationaliyActive.Name = "ComboBoxNationaliyActive"
        Me.ComboBoxNationaliyActive.Size = New System.Drawing.Size(133, 26)
        Me.ComboBoxNationaliyActive.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "สัญชาติ(ภาษาไทย)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(207, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "สัญชาติ(ภาษาอังกฤษ)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(400, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "สถานะ"
        '
        'Frm_Nationality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(702, 748)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxNationaliyActive)
        Me.Controls.Add(Me.txtNationalityEN)
        Me.Controls.Add(Me.DataGridView_ShowNationality)
        Me.Controls.Add(Me.btnAddNationality)
        Me.Controls.Add(Me.txtNationalityTH)
        Me.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Nationality"
        Me.Text = "Nationality"
        CType(Me.DataGridView_ShowNationality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNationalityTH As TextBox
    Friend WithEvents btnAddNationality As Button
    Friend WithEvents DataGridView_ShowNationality As DataGridView
    Friend WithEvents txtNationalityEN As TextBox
    Friend WithEvents ComboBoxNationaliyActive As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents สัญชาติTH As DataGridViewTextBoxColumn
    Friend WithEvents สัญชาติEN As DataGridViewTextBoxColumn
End Class
