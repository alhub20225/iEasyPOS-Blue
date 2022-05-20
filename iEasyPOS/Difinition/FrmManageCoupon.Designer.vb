<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageCoupon
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
        Me.BtnSearchCoupon = New System.Windows.Forms.Button()
        Me.TxtSearchCoupon = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DatetimeStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtValueCoupon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCouponNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgHistoryCoupon = New System.Windows.Forms.DataGridView()
        Me.เลขที่บิล = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนเงิน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.คงเหลือ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.วันที่ใช้คูปอง = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgCoupon = New System.Windows.Forms.DataGridView()
        Me.CouponId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CouponNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAddCoupon = New System.Windows.Forms.Button()
        Me.BtnSaveCoupon = New System.Windows.Forms.Button()
        Me.BtnDeleteCoupon = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgHistoryCoupon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgCoupon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearchCoupon)
        Me.GroupBox1.Controls.Add(Me.TxtSearchCoupon)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหา"
        '
        'BtnSearchCoupon
        '
        Me.BtnSearchCoupon.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.BtnSearchCoupon.Location = New System.Drawing.Point(211, 18)
        Me.BtnSearchCoupon.Name = "BtnSearchCoupon"
        Me.BtnSearchCoupon.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchCoupon.TabIndex = 1
        Me.BtnSearchCoupon.Text = "ค้นหา"
        Me.BtnSearchCoupon.UseVisualStyleBackColor = True
        '
        'TxtSearchCoupon
        '
        Me.TxtSearchCoupon.Location = New System.Drawing.Point(6, 19)
        Me.TxtSearchCoupon.Name = "TxtSearchCoupon"
        Me.TxtSearchCoupon.Size = New System.Drawing.Size(199, 24)
        Me.TxtSearchCoupon.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimeEnd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DatetimeStart)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtValueCoupon)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCouponNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 96)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียด"
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Location = New System.Drawing.Point(270, 58)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(138, 24)
        Me.DateTimeEnd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(216, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "วันสิ้นสุด :"
        '
        'DatetimeStart
        '
        Me.DatetimeStart.Location = New System.Drawing.Point(270, 17)
        Me.DatetimeStart.Name = "DatetimeStart"
        Me.DatetimeStart.Size = New System.Drawing.Size(138, 24)
        Me.DatetimeStart.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(216, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "วันที่เริ่ม :"
        '
        'TxtValueCoupon
        '
        Me.TxtValueCoupon.Location = New System.Drawing.Point(83, 61)
        Me.TxtValueCoupon.Name = "TxtValueCoupon"
        Me.TxtValueCoupon.Size = New System.Drawing.Size(127, 24)
        Me.TxtValueCoupon.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(39, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "มูลค่า :"
        '
        'TxtCouponNumber
        '
        Me.TxtCouponNumber.Location = New System.Drawing.Point(83, 20)
        Me.TxtCouponNumber.Name = "TxtCouponNumber"
        Me.TxtCouponNumber.Size = New System.Drawing.Size(127, 24)
        Me.TxtCouponNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขที่คูปอง :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgHistoryCoupon)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(310, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 234)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ประวัติการใช้"
        '
        'DgHistoryCoupon
        '
        Me.DgHistoryCoupon.AllowUserToAddRows = False
        Me.DgHistoryCoupon.AllowUserToDeleteRows = False
        Me.DgHistoryCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgHistoryCoupon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.เลขที่บิล, Me.จำนวนเงิน, Me.คงเหลือ, Me.วันที่ใช้คูปอง})
        Me.DgHistoryCoupon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgHistoryCoupon.Location = New System.Drawing.Point(3, 20)
        Me.DgHistoryCoupon.Name = "DgHistoryCoupon"
        Me.DgHistoryCoupon.ReadOnly = True
        Me.DgHistoryCoupon.Size = New System.Drawing.Size(408, 211)
        Me.DgHistoryCoupon.TabIndex = 0
        '
        'เลขที่บิล
        '
        Me.เลขที่บิล.HeaderText = "เลขที่บิล"
        Me.เลขที่บิล.Name = "เลขที่บิล"
        Me.เลขที่บิล.ReadOnly = True
        '
        'จำนวนเงิน
        '
        Me.จำนวนเงิน.HeaderText = "จำนวนเงิน"
        Me.จำนวนเงิน.Name = "จำนวนเงิน"
        Me.จำนวนเงิน.ReadOnly = True
        '
        'คงเหลือ
        '
        Me.คงเหลือ.HeaderText = "คงเหลือ"
        Me.คงเหลือ.Name = "คงเหลือ"
        Me.คงเหลือ.ReadOnly = True
        '
        'วันที่ใช้คูปอง
        '
        Me.วันที่ใช้คูปอง.HeaderText = "วันที่ใช้คูปอง"
        Me.วันที่ใช้คูปอง.Name = "วันที่ใช้คูปอง"
        Me.วันที่ใช้คูปอง.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgCoupon)
        Me.GroupBox4.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 453)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "คูปอง"
        '
        'DgCoupon
        '
        Me.DgCoupon.AllowUserToAddRows = False
        Me.DgCoupon.AllowUserToDeleteRows = False
        Me.DgCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCoupon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CouponId, Me.CouponNumber})
        Me.DgCoupon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgCoupon.Location = New System.Drawing.Point(3, 20)
        Me.DgCoupon.Name = "DgCoupon"
        Me.DgCoupon.ReadOnly = True
        Me.DgCoupon.Size = New System.Drawing.Size(286, 430)
        Me.DgCoupon.TabIndex = 0
        '
        'CouponId
        '
        Me.CouponId.HeaderText = "CouponId"
        Me.CouponId.Name = "CouponId"
        Me.CouponId.ReadOnly = True
        '
        'CouponNumber
        '
        Me.CouponNumber.HeaderText = "CouponNumber"
        Me.CouponNumber.Name = "CouponNumber"
        Me.CouponNumber.ReadOnly = True
        '
        'BtnAddCoupon
        '
        Me.BtnAddCoupon.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnAddCoupon.Location = New System.Drawing.Point(313, 354)
        Me.BtnAddCoupon.Name = "BtnAddCoupon"
        Me.BtnAddCoupon.Size = New System.Drawing.Size(75, 27)
        Me.BtnAddCoupon.TabIndex = 4
        Me.BtnAddCoupon.Text = "เพิ่มข้อมูล"
        Me.BtnAddCoupon.UseVisualStyleBackColor = True
        '
        'BtnSaveCoupon
        '
        Me.BtnSaveCoupon.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnSaveCoupon.Location = New System.Drawing.Point(565, 354)
        Me.BtnSaveCoupon.Name = "BtnSaveCoupon"
        Me.BtnSaveCoupon.Size = New System.Drawing.Size(75, 27)
        Me.BtnSaveCoupon.TabIndex = 5
        Me.BtnSaveCoupon.Text = "บันทึกข้อมูล"
        Me.BtnSaveCoupon.UseVisualStyleBackColor = True
        '
        'BtnDeleteCoupon
        '
        Me.BtnDeleteCoupon.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnDeleteCoupon.Location = New System.Drawing.Point(646, 354)
        Me.BtnDeleteCoupon.Name = "BtnDeleteCoupon"
        Me.BtnDeleteCoupon.Size = New System.Drawing.Size(75, 27)
        Me.BtnDeleteCoupon.TabIndex = 6
        Me.BtnDeleteCoupon.Text = "ลบข้อมูล"
        Me.BtnDeleteCoupon.UseVisualStyleBackColor = True
        '
        'FrmManageCoupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 538)
        Me.Controls.Add(Me.BtnDeleteCoupon)
        Me.Controls.Add(Me.BtnSaveCoupon)
        Me.Controls.Add(Me.BtnAddCoupon)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmManageCoupon"
        Me.Text = "จัดการคูปองเงินสด"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgHistoryCoupon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DgCoupon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnSearchCoupon As Button
    Friend WithEvents TxtSearchCoupon As TextBox
    Friend WithEvents DgCoupon As DataGridView
    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DatetimeStart As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtValueCoupon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCouponNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgHistoryCoupon As DataGridView
    Friend WithEvents BtnAddCoupon As Button
    Friend WithEvents BtnSaveCoupon As Button
    Friend WithEvents BtnDeleteCoupon As Button
    Friend WithEvents CouponId As DataGridViewTextBoxColumn
    Friend WithEvents CouponNumber As DataGridViewTextBoxColumn
    Friend WithEvents เลขที่บิล As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนเงิน As DataGridViewTextBoxColumn
    Friend WithEvents คงเหลือ As DataGridViewTextBoxColumn
    Friend WithEvents วันที่ใช้คูปอง As DataGridViewTextBoxColumn
End Class
