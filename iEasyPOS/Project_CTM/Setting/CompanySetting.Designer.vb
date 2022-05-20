<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanySetting
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxShowAdd = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTaxId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProvice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranchCode = New System.Windows.Forms.TextBox()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAddEmail = New System.Windows.Forms.Button()
        Me.DataGridViewShowEmail = New System.Windows.Forms.DataGridView()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtAddEmail = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewShowEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBoxShowAdd)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtTaxId)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtFax)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtTelephone)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtZipcode)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtProvice)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAddress2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtAddress1)
        Me.Panel1.Controls.Add(Me.txtCompanyName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBranchCode)
        Me.Panel1.Controls.Add(Me.txtBranchName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 700)
        Me.Panel1.TabIndex = 0
        '
        'CheckBoxShowAdd
        '
        Me.CheckBoxShowAdd.AutoSize = True
        Me.CheckBoxShowAdd.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.CheckBoxShowAdd.Location = New System.Drawing.Point(139, 468)
        Me.CheckBoxShowAdd.Name = "CheckBoxShowAdd"
        Me.CheckBoxShowAdd.Size = New System.Drawing.Size(163, 28)
        Me.CheckBoxShowAdd.TabIndex = 56
        Me.CheckBoxShowAdd.Text = "แสดงที่อยู่บนใบเสร็จ"
        Me.CheckBoxShowAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(245, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 36)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(12, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "เลขประจำตัวผู้เสียภาษี"
        '
        'txtTaxId
        '
        Me.txtTaxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxId.Location = New System.Drawing.Point(139, 399)
        Me.txtTaxId.Name = "txtTaxId"
        Me.txtTaxId.Size = New System.Drawing.Size(342, 26)
        Me.txtTaxId.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(12, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "แฟกส์"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(139, 334)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(342, 26)
        Me.txtFax.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 24)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "โทรศัพท์"
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(139, 299)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(342, 26)
        Me.txtTelephone.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(12, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "รหัสไปษณีย์"
        '
        'txtZipcode
        '
        Me.txtZipcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipcode.Location = New System.Drawing.Point(139, 264)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(342, 26)
        Me.txtZipcode.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "จังหวัด"
        '
        'txtProvice
        '
        Me.txtProvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvice.Location = New System.Drawing.Point(139, 229)
        Me.txtProvice.Name = "txtProvice"
        Me.txtProvice.Size = New System.Drawing.Size(342, 26)
        Me.txtProvice.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ที่อยู่ 2"
        '
        'txtAddress2
        '
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(139, 194)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(342, 26)
        Me.txtAddress2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ที่อยู่ 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "เลขที่สาขา"
        '
        'txtAddress1
        '
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(139, 159)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(342, 26)
        Me.txtAddress1.TabIndex = 6
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(139, 124)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(342, 26)
        Me.txtCompanyName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ชื่อบริษัท"
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(139, 89)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(342, 26)
        Me.txtBranchCode.TabIndex = 3
        '
        'txtBranchName
        '
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(139, 54)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(342, 26)
        Me.txtBranchName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อร้าน/สาขา"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(111, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ตั้งค่าร้านค้า"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnAddEmail)
        Me.Panel2.Controls.Add(Me.DataGridViewShowEmail)
        Me.Panel2.Controls.Add(Me.TxtAddEmail)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(487, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 700)
        Me.Panel2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(134, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ตั้งค่าอีเมล์"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Button2.Location = New System.Drawing.Point(294, 512)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "ลบ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAddEmail
        '
        Me.btnAddEmail.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.btnAddEmail.Location = New System.Drawing.Point(271, 54)
        Me.btnAddEmail.Name = "btnAddEmail"
        Me.btnAddEmail.Size = New System.Drawing.Size(85, 29)
        Me.btnAddEmail.TabIndex = 8
        Me.btnAddEmail.Text = "เพิ่ม"
        Me.btnAddEmail.UseVisualStyleBackColor = True
        '
        'DataGridViewShowEmail
        '
        Me.DataGridViewShowEmail.AllowUserToAddRows = False
        Me.DataGridViewShowEmail.AllowUserToDeleteRows = False
        Me.DataGridViewShowEmail.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewShowEmail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewShowEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowEmail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Email})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewShowEmail.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewShowEmail.Location = New System.Drawing.Point(21, 106)
        Me.DataGridViewShowEmail.Name = "DataGridViewShowEmail"
        Me.DataGridViewShowEmail.ReadOnly = True
        Me.DataGridViewShowEmail.RowHeadersVisible = False
        Me.DataGridViewShowEmail.Size = New System.Drawing.Size(348, 400)
        Me.DataGridViewShowEmail.TabIndex = 7
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'TxtAddEmail
        '
        Me.TxtAddEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddEmail.Location = New System.Drawing.Point(21, 55)
        Me.TxtAddEmail.Name = "TxtAddEmail"
        Me.TxtAddEmail.Size = New System.Drawing.Size(244, 26)
        Me.TxtAddEmail.TabIndex = 6
        '
        'CompanySetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CompanySetting"
        Me.Text = "CompanySetting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewShowEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTaxId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProvice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBranchCode As TextBox
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxShowAdd As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAddEmail As Button
    Friend WithEvents DataGridViewShowEmail As DataGridView
    Friend WithEvents TxtAddEmail As TextBox
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
