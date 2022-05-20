<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageSupplier
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSrc = New System.Windows.Forms.Button()
        Me.TxtSrc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgSupplier = New System.Windows.Forms.DataGridView()
        Me.รหัส = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อผู้จัดจำหน่าย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadDropDownListPaymentTerm = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddSupplier = New System.Windows.Forms.Button()
        Me.BtnSaveSupplier = New System.Windows.Forms.Button()
        Me.BtnDeleteSupplier = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RadDropDownListPaymentTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSrc)
        Me.GroupBox1.Controls.Add(Me.TxtSrc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหา"
        '
        'BtnSrc
        '
        Me.BtnSrc.Location = New System.Drawing.Point(285, 26)
        Me.BtnSrc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSrc.Name = "BtnSrc"
        Me.BtnSrc.Size = New System.Drawing.Size(74, 35)
        Me.BtnSrc.TabIndex = 2
        Me.BtnSrc.Text = "ค้นหา"
        Me.BtnSrc.UseVisualStyleBackColor = True
        '
        'TxtSrc
        '
        Me.TxtSrc.Location = New System.Drawing.Point(76, 29)
        Me.TxtSrc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSrc.Name = "TxtSrc"
        Me.TxtSrc.Size = New System.Drawing.Size(198, 31)
        Me.TxtSrc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgSupplier)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 122)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(368, 558)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DgSupplier
        '
        Me.DgSupplier.AllowUserToAddRows = False
        Me.DgSupplier.AllowUserToDeleteRows = False
        Me.DgSupplier.BackgroundColor = System.Drawing.Color.White
        Me.DgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัส, Me.ชื่อผู้จัดจำหน่าย, Me.id})
        Me.DgSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgSupplier.Location = New System.Drawing.Point(4, 29)
        Me.DgSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgSupplier.Name = "DgSupplier"
        Me.DgSupplier.ReadOnly = True
        Me.DgSupplier.RowHeadersVisible = False
        Me.DgSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgSupplier.Size = New System.Drawing.Size(360, 524)
        Me.DgSupplier.TabIndex = 0
        '
        'รหัส
        '
        Me.รหัส.HeaderText = "รหัส"
        Me.รหัส.Name = "รหัส"
        Me.รหัส.ReadOnly = True
        '
        'ชื่อผู้จัดจำหน่าย
        '
        Me.ชื่อผู้จัดจำหน่าย.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อผู้จัดจำหน่าย.HeaderText = "ชื่อผู้จัดจำหน่าย"
        Me.ชื่อผู้จัดจำหน่าย.Name = "ชื่อผู้จัดจำหน่าย"
        Me.ชื่อผู้จัดจำหน่าย.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadDropDownListPaymentTerm)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtAddress)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtSupplierName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtCodeSupplier)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(408, 18)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(499, 555)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายละเอียด"
        '
        'RadDropDownListPaymentTerm
        '
        Me.RadDropDownListPaymentTerm.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.RadDropDownListPaymentTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownListPaymentTerm.Location = New System.Drawing.Point(142, 372)
        Me.RadDropDownListPaymentTerm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadDropDownListPaymentTerm.Name = "RadDropDownListPaymentTerm"
        Me.RadDropDownListPaymentTerm.Size = New System.Drawing.Size(234, 27)
        Me.RadDropDownListPaymentTerm.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 372)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "การจ่ายเงิน :"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(142, 178)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(325, 147)
        Me.TxtAddress.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ที่อยู่ :"
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(142, 103)
        Me.TxtSupplierName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(325, 31)
        Me.TxtSupplierName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ชื่อผู้จัดจำหน่าย"
        '
        'TxtCodeSupplier
        '
        Me.TxtCodeSupplier.Location = New System.Drawing.Point(142, 42)
        Me.TxtCodeSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCodeSupplier.Name = "TxtCodeSupplier"
        Me.TxtCodeSupplier.Size = New System.Drawing.Size(198, 31)
        Me.TxtCodeSupplier.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสผู้จัดจำหน่าย"
        '
        'BtnAddSupplier
        '
        Me.BtnAddSupplier.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnAddSupplier.Location = New System.Drawing.Point(410, 583)
        Me.BtnAddSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddSupplier.Name = "BtnAddSupplier"
        Me.BtnAddSupplier.Size = New System.Drawing.Size(112, 35)
        Me.BtnAddSupplier.TabIndex = 3
        Me.BtnAddSupplier.Text = "เพิ่มข้อมูล"
        Me.BtnAddSupplier.UseVisualStyleBackColor = True
        '
        'BtnSaveSupplier
        '
        Me.BtnSaveSupplier.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSaveSupplier.Location = New System.Drawing.Point(658, 583)
        Me.BtnSaveSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSaveSupplier.Name = "BtnSaveSupplier"
        Me.BtnSaveSupplier.Size = New System.Drawing.Size(112, 35)
        Me.BtnSaveSupplier.TabIndex = 4
        Me.BtnSaveSupplier.Text = "บันทึก"
        Me.BtnSaveSupplier.UseVisualStyleBackColor = True
        '
        'BtnDeleteSupplier
        '
        Me.BtnDeleteSupplier.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnDeleteSupplier.Location = New System.Drawing.Point(795, 583)
        Me.BtnDeleteSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDeleteSupplier.Name = "BtnDeleteSupplier"
        Me.BtnDeleteSupplier.Size = New System.Drawing.Size(112, 35)
        Me.BtnDeleteSupplier.TabIndex = 5
        Me.BtnDeleteSupplier.Text = "ลบข้อมูล"
        Me.BtnDeleteSupplier.UseVisualStyleBackColor = True
        '
        'FrmManageSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 688)
        Me.Controls.Add(Me.BtnDeleteSupplier)
        Me.Controls.Add(Me.BtnSaveSupplier)
        Me.Controls.Add(Me.BtnAddSupplier)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmManageSupplier"
        Me.Text = "FrmManageSupplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.RadDropDownListPaymentTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSrc As Button
    Friend WithEvents TxtSrc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnAddSupplier As Button
    Friend WithEvents BtnSaveSupplier As Button
    Friend WithEvents BtnDeleteSupplier As Button
    Friend WithEvents DgSupplier As DataGridView
    Friend WithEvents RadDropDownListPaymentTerm As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSupplierName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCodeSupplier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents รหัส As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อผู้จัดจำหน่าย As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class
