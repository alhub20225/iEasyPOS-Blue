<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPointRate
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewPoint = New System.Windows.Forms.DataGridView()
        Me.วันที่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.แต้มสะสม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointRateId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pPrice = New System.Windows.Forms.Panel()
        Me.totalPrice = New System.Windows.Forms.NumericUpDown()
        Me.pAmount = New System.Windows.Forms.Panel()
        Me.totalAmount = New System.Windows.Forms.NumericUpDown()
        Me.rTotalPrice = New System.Windows.Forms.RadioButton()
        Me.rTotalAmount = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateStart = New System.Windows.Forms.DateTimePicker()
        Me.PointRate = New System.Windows.Forms.NumericUpDown()
        Me.TimeStart = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimeEnd = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pPrice.SuspendLayout()
        CType(Me.totalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pAmount.SuspendLayout()
        CType(Me.totalAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PointRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 463)
        Me.Panel1.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDel)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.DataGridViewPoint)
        Me.Panel3.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Panel3.Location = New System.Drawing.Point(8, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(404, 443)
        Me.Panel3.TabIndex = 15
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(314, 397)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(84, 42)
        Me.btnDel.TabIndex = 12
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(225, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(173, 31)
        Me.DateTimePicker1.TabIndex = 11
        '
        'DataGridViewPoint
        '
        Me.DataGridViewPoint.AllowUserToAddRows = False
        Me.DataGridViewPoint.AllowUserToDeleteRows = False
        Me.DataGridViewPoint.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPoint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่, Me.แต้มสะสม, Me.PointRateId, Me.Amounts, Me.Prices})
        Me.DataGridViewPoint.Location = New System.Drawing.Point(0, 73)
        Me.DataGridViewPoint.Name = "DataGridViewPoint"
        Me.DataGridViewPoint.ReadOnly = True
        Me.DataGridViewPoint.RowHeadersVisible = False
        Me.DataGridViewPoint.Size = New System.Drawing.Size(404, 319)
        Me.DataGridViewPoint.TabIndex = 0
        '
        'วันที่
        '
        Me.วันที่.HeaderText = "วันที่"
        Me.วันที่.Name = "วันที่"
        Me.วันที่.ReadOnly = True
        '
        'แต้มสะสม
        '
        Me.แต้มสะสม.HeaderText = "แต้มสะสม"
        Me.แต้มสะสม.Name = "แต้มสะสม"
        Me.แต้มสะสม.ReadOnly = True
        '
        'PointRateId
        '
        Me.PointRateId.HeaderText = "PointRateId"
        Me.PointRateId.Name = "PointRateId"
        Me.PointRateId.ReadOnly = True
        Me.PointRateId.Visible = False
        '
        'Amounts
        '
        Me.Amounts.HeaderText = "ซื้อสินค้าจำนวน"
        Me.Amounts.Name = "Amounts"
        Me.Amounts.ReadOnly = True
        '
        'Prices
        '
        Me.Prices.HeaderText = "ซื้อสินค้ามูลค่า"
        Me.Prices.Name = "Prices"
        Me.Prices.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pPrice)
        Me.Panel2.Controls.Add(Me.pAmount)
        Me.Panel2.Controls.Add(Me.rTotalPrice)
        Me.Panel2.Controls.Add(Me.rTotalAmount)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.DateEnd)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.DateStart)
        Me.Panel2.Controls.Add(Me.PointRate)
        Me.Panel2.Controls.Add(Me.TimeStart)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TimeEnd)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(434, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 439)
        Me.Panel2.TabIndex = 14
        '
        'pPrice
        '
        Me.pPrice.Controls.Add(Me.totalPrice)
        Me.pPrice.Enabled = False
        Me.pPrice.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.pPrice.Location = New System.Drawing.Point(182, 80)
        Me.pPrice.Name = "pPrice"
        Me.pPrice.Size = New System.Drawing.Size(155, 48)
        Me.pPrice.TabIndex = 17
        '
        'totalPrice
        '
        Me.totalPrice.Location = New System.Drawing.Point(16, 7)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(120, 31)
        Me.totalPrice.TabIndex = 14
        '
        'pAmount
        '
        Me.pAmount.Controls.Add(Me.totalAmount)
        Me.pAmount.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.pAmount.Location = New System.Drawing.Point(182, 26)
        Me.pAmount.Name = "pAmount"
        Me.pAmount.Size = New System.Drawing.Size(155, 48)
        Me.pAmount.TabIndex = 16
        '
        'totalAmount
        '
        Me.totalAmount.Location = New System.Drawing.Point(16, 7)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(120, 31)
        Me.totalAmount.TabIndex = 14
        '
        'rTotalPrice
        '
        Me.rTotalPrice.AutoSize = True
        Me.rTotalPrice.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.rTotalPrice.Location = New System.Drawing.Point(40, 90)
        Me.rTotalPrice.Name = "rTotalPrice"
        Me.rTotalPrice.Size = New System.Drawing.Size(120, 28)
        Me.rTotalPrice.TabIndex = 13
        Me.rTotalPrice.TabStop = True
        Me.rTotalPrice.Text = "ซื้อสินค้ามูลค่า"
        Me.rTotalPrice.UseVisualStyleBackColor = True
        '
        'rTotalAmount
        '
        Me.rTotalAmount.AutoSize = True
        Me.rTotalAmount.Checked = True
        Me.rTotalAmount.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.rTotalAmount.Location = New System.Drawing.Point(40, 35)
        Me.rTotalAmount.Name = "rTotalAmount"
        Me.rTotalAmount.Size = New System.Drawing.Size(127, 28)
        Me.rTotalAmount.TabIndex = 12
        Me.rTotalAmount.TabStop = True
        Me.rTotalAmount.Text = "ซื้อสินค้าจำนวน"
        Me.rTotalAmount.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnClear.Location = New System.Drawing.Point(201, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 42)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "เพิ่ม"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnSave.Location = New System.Drawing.Point(300, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 42)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateEnd
        '
        Me.DateEnd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateEnd.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEnd.Location = New System.Drawing.Point(89, 197)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(140, 31)
        Me.DateEnd.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(5, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "แต้มสะสม :"
        '
        'DateStart
        '
        Me.DateStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateStart.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateStart.Location = New System.Drawing.Point(89, 147)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(140, 31)
        Me.DateStart.TabIndex = 0
        '
        'PointRate
        '
        Me.PointRate.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.PointRate.Location = New System.Drawing.Point(89, 248)
        Me.PointRate.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.PointRate.Name = "PointRate"
        Me.PointRate.Size = New System.Drawing.Size(140, 31)
        Me.PointRate.TabIndex = 8
        Me.PointRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TimeStart
        '
        Me.TimeStart.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.TimeStart.FormattingEnabled = True
        Me.TimeStart.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.TimeStart.Location = New System.Drawing.Point(291, 152)
        Me.TimeStart.Name = "TimeStart"
        Me.TimeStart.Size = New System.Drawing.Size(93, 30)
        Me.TimeStart.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(240, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "เวลา :"
        '
        'TimeEnd
        '
        Me.TimeEnd.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.TimeEnd.FormattingEnabled = True
        Me.TimeEnd.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.TimeEnd.Location = New System.Drawing.Point(291, 202)
        Me.TimeEnd.Name = "TimeEnd"
        Me.TimeEnd.Size = New System.Drawing.Size(93, 30)
        Me.TimeEnd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(240, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เวลา :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(36, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "วันที่ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(44, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ถึง :"
        '
        'FrmPointRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 479)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPointRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แต้มสะสม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pPrice.ResumeLayout(False)
        CType(Me.totalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pAmount.ResumeLayout(False)
        CType(Me.totalAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PointRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridViewPoint As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DateEnd As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateStart As DateTimePicker
    Friend WithEvents PointRate As NumericUpDown
    Friend WithEvents TimeStart As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeEnd As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents totalAmount As NumericUpDown
    Friend WithEvents rTotalPrice As RadioButton
    Friend WithEvents rTotalAmount As RadioButton
    Friend WithEvents pPrice As Panel
    Friend WithEvents totalPrice As NumericUpDown
    Friend WithEvents pAmount As Panel
    Friend WithEvents วันที่ As DataGridViewTextBoxColumn
    Friend WithEvents แต้มสะสม As DataGridViewTextBoxColumn
    Friend WithEvents PointRateId As DataGridViewTextBoxColumn
    Friend WithEvents Amounts As DataGridViewTextBoxColumn
    Friend WithEvents Prices As DataGridViewTextBoxColumn
End Class
