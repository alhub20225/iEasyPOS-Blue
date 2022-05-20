<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageVoucher
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
        Me.BtnSearchVoucher = New System.Windows.Forms.Button()
        Me.TxtSearchVoucher = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtVoucherValue = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtVoucherNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtVoucherName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgVoucher = New System.Windows.Forms.DataGridView()
        Me.VoucherId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAddVoucher = New System.Windows.Forms.Button()
        Me.BtnSaveVoucher = New System.Windows.Forms.Button()
        Me.BtnDeleteVoucher = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearchVoucher)
        Me.GroupBox1.Controls.Add(Me.TxtSearchVoucher)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnSearchVoucher
        '
        Me.BtnSearchVoucher.Location = New System.Drawing.Point(157, 17)
        Me.BtnSearchVoucher.Name = "BtnSearchVoucher"
        Me.BtnSearchVoucher.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchVoucher.TabIndex = 2
        Me.BtnSearchVoucher.Text = "ค้นหา"
        Me.BtnSearchVoucher.UseVisualStyleBackColor = True
        '
        'TxtSearchVoucher
        '
        Me.TxtSearchVoucher.Location = New System.Drawing.Point(51, 19)
        Me.TxtSearchVoucher.Name = "TxtSearchVoucher"
        Me.TxtSearchVoucher.Size = New System.Drawing.Size(100, 25)
        Me.TxtSearchVoucher.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtVoucherValue)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtVoucherNumber)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerEnd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerStart)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtVoucherName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TxtVoucherValue
        '
        Me.TxtVoucherValue.Location = New System.Drawing.Point(98, 86)
        Me.TxtVoucherValue.Name = "TxtVoucherValue"
        Me.TxtVoucherValue.Size = New System.Drawing.Size(156, 25)
        Me.TxtVoucherValue.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "มูลค่า :"
        '
        'TxtVoucherNumber
        '
        Me.TxtVoucherNumber.Location = New System.Drawing.Point(98, 54)
        Me.TxtVoucherNumber.Name = "TxtVoucherNumber"
        Me.TxtVoucherNumber.Size = New System.Drawing.Size(156, 25)
        Me.TxtVoucherNumber.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Voucher Number:"
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(98, 160)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePickerEnd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "วันหมดอายุ :"
        '
        'DateTimePickerStart
        '
        Me.DateTimePickerStart.Location = New System.Drawing.Point(98, 121)
        Me.DateTimePickerStart.Name = "DateTimePickerStart"
        Me.DateTimePickerStart.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePickerStart.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "วันที่เริ่ม :"
        '
        'TxtVoucherName
        '
        Me.TxtVoucherName.Location = New System.Drawing.Point(98, 18)
        Me.TxtVoucherName.Name = "TxtVoucherName"
        Me.TxtVoucherName.Size = New System.Drawing.Size(156, 25)
        Me.TxtVoucherName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Voucher Name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgVoucher)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 376)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'DgVoucher
        '
        Me.DgVoucher.AllowUserToAddRows = False
        Me.DgVoucher.AllowUserToDeleteRows = False
        Me.DgVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VoucherId, Me.VoucherName, Me.VoucherNumber})
        Me.DgVoucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgVoucher.Location = New System.Drawing.Point(3, 20)
        Me.DgVoucher.Name = "DgVoucher"
        Me.DgVoucher.ReadOnly = True
        Me.DgVoucher.Size = New System.Drawing.Size(233, 353)
        Me.DgVoucher.TabIndex = 0
        '
        'VoucherId
        '
        Me.VoucherId.HeaderText = "VoucherId"
        Me.VoucherId.Name = "VoucherId"
        Me.VoucherId.ReadOnly = True
        '
        'VoucherName
        '
        Me.VoucherName.HeaderText = "VoucherName"
        Me.VoucherName.Name = "VoucherName"
        Me.VoucherName.ReadOnly = True
        '
        'VoucherNumber
        '
        Me.VoucherNumber.HeaderText = "VoucherNumber"
        Me.VoucherNumber.Name = "VoucherNumber"
        Me.VoucherNumber.ReadOnly = True
        '
        'BtnAddVoucher
        '
        Me.BtnAddVoucher.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnAddVoucher.Location = New System.Drawing.Point(263, 218)
        Me.BtnAddVoucher.Name = "BtnAddVoucher"
        Me.BtnAddVoucher.Size = New System.Drawing.Size(75, 29)
        Me.BtnAddVoucher.TabIndex = 3
        Me.BtnAddVoucher.Text = "เพิ่มข้อมูล"
        Me.BtnAddVoucher.UseVisualStyleBackColor = True
        '
        'BtnSaveVoucher
        '
        Me.BtnSaveVoucher.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnSaveVoucher.Location = New System.Drawing.Point(586, 218)
        Me.BtnSaveVoucher.Name = "BtnSaveVoucher"
        Me.BtnSaveVoucher.Size = New System.Drawing.Size(75, 29)
        Me.BtnSaveVoucher.TabIndex = 4
        Me.BtnSaveVoucher.Text = "บันทึกข้อมูล"
        Me.BtnSaveVoucher.UseVisualStyleBackColor = True
        '
        'BtnDeleteVoucher
        '
        Me.BtnDeleteVoucher.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnDeleteVoucher.Location = New System.Drawing.Point(667, 218)
        Me.BtnDeleteVoucher.Name = "BtnDeleteVoucher"
        Me.BtnDeleteVoucher.Size = New System.Drawing.Size(75, 29)
        Me.BtnDeleteVoucher.TabIndex = 5
        Me.BtnDeleteVoucher.Text = "ลบข้อมูล"
        Me.BtnDeleteVoucher.UseVisualStyleBackColor = True
        '
        'FrmManageVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 462)
        Me.Controls.Add(Me.BtnDeleteVoucher)
        Me.Controls.Add(Me.BtnSaveVoucher)
        Me.Controls.Add(Me.BtnAddVoucher)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmManageVoucher"
        Me.Text = "Manage Voucher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSearchVoucher As Button
    Friend WithEvents TxtSearchVoucher As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgVoucher As DataGridView
    Friend WithEvents TxtVoucherValue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtVoucherNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerEnd As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePickerStart As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtVoucherName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VoucherId As DataGridViewTextBoxColumn
    Friend WithEvents VoucherName As DataGridViewTextBoxColumn
    Friend WithEvents VoucherNumber As DataGridViewTextBoxColumn
    Friend WithEvents BtnAddVoucher As Button
    Friend WithEvents BtnSaveVoucher As Button
    Friend WithEvents BtnDeleteVoucher As Button
End Class
