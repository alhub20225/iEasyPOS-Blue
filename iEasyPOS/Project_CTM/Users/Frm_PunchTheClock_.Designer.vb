<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PunchTheClock
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelUserPosition = New System.Windows.Forms.Label()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerSearch = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewShowTimeInOut = New System.Windows.Forms.DataGridView()
        Me.วันที่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เข้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ออก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เข้า2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ออก2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnOTOut = New System.Windows.Forms.Button()
        Me.btnOTIn = New System.Windows.Forms.Button()
        Me.btnTimeOut = New System.Windows.Forms.Button()
        Me.btnBreakOut = New System.Windows.Forms.Button()
        Me.btnBreakIn = New System.Windows.Forms.Button()
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateNow = New System.Windows.Forms.Label()
        Me.timeNow = New System.Windows.Forms.Label()
        Me.TimerNow = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close_PunchTime = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewShowTimeInOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelUserPosition)
        Me.GroupBox1.Controls.Add(Me.LabelUserName)
        Me.GroupBox1.Controls.Add(Me.PictureBoxUser)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลพนักงาน"
        '
        'LabelUserPosition
        '
        Me.LabelUserPosition.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.LabelUserPosition.Location = New System.Drawing.Point(6, 203)
        Me.LabelUserPosition.Name = "LabelUserPosition"
        Me.LabelUserPosition.Size = New System.Drawing.Size(338, 20)
        Me.LabelUserPosition.TabIndex = 2
        Me.LabelUserPosition.Text = "Label2"
        Me.LabelUserPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelUserName
        '
        Me.LabelUserName.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.LabelUserName.Location = New System.Drawing.Point(6, 176)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(338, 25)
        Me.LabelUserName.TabIndex = 1
        Me.LabelUserName.Text = "Label1"
        Me.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.BackgroundImage = Global.Project_CTM.My.Resources.Resources.touch_screen
        Me.PictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxUser.Location = New System.Drawing.Point(92, 19)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(149, 154)
        Me.PictureBoxUser.TabIndex = 0
        Me.PictureBoxUser.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePickerSearch)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DataGridViewShowTimeInOut)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(365, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(653, 429)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DateTimePickerSearch
        '
        Me.DateTimePickerSearch.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePickerSearch.Location = New System.Drawing.Point(447, 28)
        Me.DateTimePickerSearch.Name = "DateTimePickerSearch"
        Me.DateTimePickerSearch.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePickerSearch.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ประวัติการเข้างาน"
        '
        'DataGridViewShowTimeInOut
        '
        Me.DataGridViewShowTimeInOut.AllowUserToAddRows = False
        Me.DataGridViewShowTimeInOut.AllowUserToDeleteRows = False
        Me.DataGridViewShowTimeInOut.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewShowTimeInOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewShowTimeInOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowTimeInOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่, Me.เข้า, Me.ออก, Me.เข้า2, Me.ออก2, Me.OTin, Me.OTout})
        Me.DataGridViewShowTimeInOut.Location = New System.Drawing.Point(6, 60)
        Me.DataGridViewShowTimeInOut.Name = "DataGridViewShowTimeInOut"
        Me.DataGridViewShowTimeInOut.ReadOnly = True
        Me.DataGridViewShowTimeInOut.RowHeadersVisible = False
        Me.DataGridViewShowTimeInOut.Size = New System.Drawing.Size(641, 363)
        Me.DataGridViewShowTimeInOut.TabIndex = 0
        '
        'วันที่
        '
        Me.วันที่.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.วันที่.HeaderText = "วันที่"
        Me.วันที่.Name = "วันที่"
        Me.วันที่.ReadOnly = True
        '
        'เข้า
        '
        Me.เข้า.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.เข้า.HeaderText = "เข้างาน"
        Me.เข้า.Name = "เข้า"
        Me.เข้า.ReadOnly = True
        '
        'ออก
        '
        Me.ออก.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ออก.HeaderText = "พัก"
        Me.ออก.Name = "ออก"
        Me.ออก.ReadOnly = True
        '
        'เข้า2
        '
        Me.เข้า2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.เข้า2.HeaderText = "เข้า"
        Me.เข้า2.Name = "เข้า2"
        Me.เข้า2.ReadOnly = True
        '
        'ออก2
        '
        Me.ออก2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ออก2.HeaderText = "เลิกงาน"
        Me.ออก2.Name = "ออก2"
        Me.ออก2.ReadOnly = True
        '
        'OTin
        '
        Me.OTin.HeaderText = "เริ่ม OT"
        Me.OTin.Name = "OTin"
        Me.OTin.ReadOnly = True
        '
        'OTout
        '
        Me.OTout.HeaderText = "ออก OT"
        Me.OTout.Name = "OTout"
        Me.OTout.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnOTOut)
        Me.GroupBox3.Controls.Add(Me.btnOTIn)
        Me.GroupBox3.Controls.Add(Me.btnTimeOut)
        Me.GroupBox3.Controls.Add(Me.btnBreakOut)
        Me.GroupBox3.Controls.Add(Me.btnBreakIn)
        Me.GroupBox3.Controls.Add(Me.btnTimeIn)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dateNow)
        Me.GroupBox3.Controls.Add(Me.timeNow)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 197)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnOTOut
        '
        Me.btnOTOut.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.btnOTOut.Location = New System.Drawing.Point(178, 126)
        Me.btnOTOut.Name = "btnOTOut"
        Me.btnOTOut.Size = New System.Drawing.Size(80, 45)
        Me.btnOTOut.TabIndex = 12
        Me.btnOTOut.Text = "OT ออก"
        Me.btnOTOut.UseVisualStyleBackColor = True
        '
        'btnOTIn
        '
        Me.btnOTIn.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.btnOTIn.Location = New System.Drawing.Point(92, 126)
        Me.btnOTIn.Name = "btnOTIn"
        Me.btnOTIn.Size = New System.Drawing.Size(80, 45)
        Me.btnOTIn.TabIndex = 11
        Me.btnOTIn.Text = "OT เข้า"
        Me.btnOTIn.UseVisualStyleBackColor = True
        '
        'btnTimeOut
        '
        Me.btnTimeOut.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.btnTimeOut.Location = New System.Drawing.Point(264, 75)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(80, 45)
        Me.btnTimeOut.TabIndex = 10
        Me.btnTimeOut.Text = "เลิกงาน"
        Me.btnTimeOut.UseVisualStyleBackColor = True
        '
        'btnBreakOut
        '
        Me.btnBreakOut.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.btnBreakOut.Location = New System.Drawing.Point(178, 75)
        Me.btnBreakOut.Name = "btnBreakOut"
        Me.btnBreakOut.Size = New System.Drawing.Size(80, 45)
        Me.btnBreakOut.TabIndex = 9
        Me.btnBreakOut.Text = "เข้า"
        Me.btnBreakOut.UseVisualStyleBackColor = True
        '
        'btnBreakIn
        '
        Me.btnBreakIn.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.btnBreakIn.Location = New System.Drawing.Point(92, 75)
        Me.btnBreakIn.Name = "btnBreakIn"
        Me.btnBreakIn.Size = New System.Drawing.Size(80, 45)
        Me.btnBreakIn.TabIndex = 8
        Me.btnBreakIn.Text = "พัก"
        Me.btnBreakIn.UseVisualStyleBackColor = True
        '
        'btnTimeIn
        '
        Me.btnTimeIn.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.btnTimeIn.Location = New System.Drawing.Point(6, 75)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(80, 45)
        Me.btnTimeIn.TabIndex = 7
        Me.btnTimeIn.Text = "เข้างาน"
        Me.btnTimeIn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(8, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "โปรดเลือกเวาลาที่ต้องการบันทึก"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "บันทึกเวลา"
        '
        'dateNow
        '
        Me.dateNow.AutoSize = True
        Me.dateNow.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.dateNow.Location = New System.Drawing.Point(258, 45)
        Me.dateNow.Name = "dateNow"
        Me.dateNow.Size = New System.Drawing.Size(49, 19)
        Me.dateNow.TabIndex = 4
        Me.dateNow.Text = "Label4"
        '
        'timeNow
        '
        Me.timeNow.AutoSize = True
        Me.timeNow.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.timeNow.Location = New System.Drawing.Point(256, 16)
        Me.timeNow.Name = "timeNow"
        Me.timeNow.Size = New System.Drawing.Size(76, 31)
        Me.timeNow.TabIndex = 3
        Me.timeNow.Text = "Label3"
        '
        'TimerNow
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ตอกบัตร"
        '
        'Close_PunchTime
        '
        Me.Close_PunchTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_PunchTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Close_PunchTime.BackgroundImage = Global.Project_CTM.My.Resources.Resources.times_circle_o2
        Me.Close_PunchTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_PunchTime.FlatAppearance.BorderSize = 0
        Me.Close_PunchTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_PunchTime.Location = New System.Drawing.Point(973, 0)
        Me.Close_PunchTime.Name = "Close_PunchTime"
        Me.Close_PunchTime.Size = New System.Drawing.Size(57, 57)
        Me.Close_PunchTime.TabIndex = 3
        Me.Close_PunchTime.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1030, 57)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Frm_PunchTheClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close_PunchTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_PunchTheClock"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewShowTimeInOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelUserPosition As Label
    Friend WithEvents LabelUserName As Label
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewShowTimeInOut As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnOTOut As Button
    Friend WithEvents btnOTIn As Button
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents btnBreakOut As Button
    Friend WithEvents btnBreakIn As Button
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dateNow As Label
    Friend WithEvents timeNow As Label
    Friend WithEvents TimerNow As Timer
    Friend WithEvents DateTimePickerSearch As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Close_PunchTime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents วันที่ As DataGridViewTextBoxColumn
    Friend WithEvents เข้า As DataGridViewTextBoxColumn
    Friend WithEvents ออก As DataGridViewTextBoxColumn
    Friend WithEvents เข้า2 As DataGridViewTextBoxColumn
    Friend WithEvents ออก2 As DataGridViewTextBoxColumn
    Friend WithEvents OTin As DataGridViewTextBoxColumn
    Friend WithEvents OTout As DataGridViewTextBoxColumn
End Class
