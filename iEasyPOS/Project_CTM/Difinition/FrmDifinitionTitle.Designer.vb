<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDifinitionTitle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgName = New System.Windows.Forms.DataGridView()
        Me.ลำดับ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.คำนำหน้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(448, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 636)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'DgName
        '
        Me.DgName.AllowUserToAddRows = False
        Me.DgName.AllowUserToDeleteRows = False
        Me.DgName.AllowUserToResizeRows = False
        Me.DgName.BackgroundColor = System.Drawing.Color.White
        Me.DgName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ลำดับ, Me.คำนำหน้า, Me.TitleId})
        Me.DgName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgName.Location = New System.Drawing.Point(3, 23)
        Me.DgName.Name = "DgName"
        Me.DgName.RowHeadersVisible = False
        Me.DgName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DgName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgName.Size = New System.Drawing.Size(406, 610)
        Me.DgName.TabIndex = 3
        '
        'ลำดับ
        '
        Me.ลำดับ.HeaderText = "ลำดับ"
        Me.ลำดับ.Name = "ลำดับ"
        '
        'คำนำหน้า
        '
        Me.คำนำหน้า.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.คำนำหน้า.HeaderText = "คำนำหน้า"
        Me.คำนำหน้า.Name = "คำนำหน้า"
        '
        'TitleId
        '
        Me.TitleId.HeaderText = "TitleId"
        Me.TitleId.Name = "TitleId"
        Me.TitleId.Visible = False
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.TxtName.ForeColor = System.Drawing.Color.Black
        Me.TxtName.Location = New System.Drawing.Point(528, 34)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(212, 24)
        Me.TxtName.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.Location = New System.Drawing.Point(528, 104)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(119, 34)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'FrmDifinitionTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 636)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDifinitionTitle"
        Me.Text = "FrmDifinitionTitle"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgName As DataGridView
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ลำดับ As DataGridViewTextBoxColumn
    Friend WithEvents คำนำหน้า As DataGridViewTextBoxColumn
    Friend WithEvents TitleId As DataGridViewTextBoxColumn
End Class
