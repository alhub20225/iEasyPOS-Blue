<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageTax
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dg_Tax = New System.Windows.Forms.DataGridView()
        Me.รายละเอียด = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ตัวคูณ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumerricMultiply = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtnameTax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Tax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumerricMultiply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dg_Tax)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(345, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียด"
        '
        'Dg_Tax
        '
        Me.Dg_Tax.AllowUserToAddRows = False
        Me.Dg_Tax.AllowUserToResizeColumns = False
        Me.Dg_Tax.AllowUserToResizeRows = False
        Me.Dg_Tax.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Tax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Tax.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รายละเอียด, Me.ตัวคูณ, Me.TaxId})
        Me.Dg_Tax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Tax.Location = New System.Drawing.Point(4, 29)
        Me.Dg_Tax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dg_Tax.Name = "Dg_Tax"
        Me.Dg_Tax.ReadOnly = True
        Me.Dg_Tax.RowHeadersVisible = False
        Me.Dg_Tax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Tax.Size = New System.Drawing.Size(337, 361)
        Me.Dg_Tax.TabIndex = 0
        '
        'รายละเอียด
        '
        Me.รายละเอียด.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.รายละเอียด.HeaderText = "รายละเอียด"
        Me.รายละเอียด.Name = "รายละเอียด"
        Me.รายละเอียด.ReadOnly = True
        '
        'ตัวคูณ
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ตัวคูณ.DefaultCellStyle = DataGridViewCellStyle1
        Me.ตัวคูณ.HeaderText = "ตัวคูณ"
        Me.ตัวคูณ.Name = "ตัวคูณ"
        Me.ตัวคูณ.ReadOnly = True
        '
        'TaxId
        '
        Me.TaxId.HeaderText = "TaxId"
        Me.TaxId.Name = "TaxId"
        Me.TaxId.ReadOnly = True
        Me.TaxId.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumerricMultiply)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtnameTax)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(477, 171)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'NumerricMultiply
        '
        Me.NumerricMultiply.Location = New System.Drawing.Point(81, 95)
        Me.NumerricMultiply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumerricMultiply.Name = "NumerricMultiply"
        Me.NumerricMultiply.Size = New System.Drawing.Size(231, 31)
        Me.NumerricMultiply.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ตัวคูณ :"
        '
        'TxtnameTax
        '
        Me.TxtnameTax.Location = New System.Drawing.Point(80, 38)
        Me.TxtnameTax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtnameTax.Name = "TxtnameTax"
        Me.TxtnameTax.Size = New System.Drawing.Size(230, 31)
        Me.TxtnameTax.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ภาษี :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(494, 198)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(112, 35)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "เพิ่ม"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSave.Location = New System.Drawing.Point(615, 198)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 35)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(736, 198)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(112, 35)
        Me.BtnDelete.TabIndex = 6
        Me.BtnDelete.Text = "ลบ"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmManageTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmManageTax"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dg_Tax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumerricMultiply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Dg_Tax As DataGridView
    Friend WithEvents NumerricMultiply As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtnameTax As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents รายละเอียด As DataGridViewTextBoxColumn
    Friend WithEvents ตัวคูณ As DataGridViewTextBoxColumn
    Friend WithEvents TaxId As DataGridViewTextBoxColumn
End Class
