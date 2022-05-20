<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimeBirthDay = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAddRegister = New System.Windows.Forms.Button()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtFristName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(158, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 95)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ยินดีต้อนรับ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(158, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 95)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "POS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DateTimeBirthDay)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BtnAddRegister)
        Me.Panel1.Controls.Add(Me.TxtPhone)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtLastName)
        Me.Panel1.Controls.Add(Me.TxtFristName)
        Me.Panel1.Location = New System.Drawing.Point(563, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 555)
        Me.Panel1.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(93, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(278, 24)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "ระบบจะส่ง รหัสยืนยันไปยังอีเมล์ของท่าน "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(12, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 24)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "เบอร์โทร"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(27, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 24)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "อีเมล์"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(28, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 24)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "วันเกิด"
        '
        'DateTimeBirthDay
        '
        Me.DateTimeBirthDay.CalendarFont = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimeBirthDay.CalendarForeColor = System.Drawing.SystemColors.ControlDark
        Me.DateTimeBirthDay.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark
        Me.DateTimeBirthDay.Font = New System.Drawing.Font("Kanit", 20.25!)
        Me.DateTimeBirthDay.Location = New System.Drawing.Point(85, 176)
        Me.DateTimeBirthDay.Name = "DateTimeBirthDay"
        Me.DateTimeBirthDay.Size = New System.Drawing.Size(304, 48)
        Me.DateTimeBirthDay.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(12, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "นามสกุล"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(49, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ชื่อ"
        '
        'BtnAddRegister
        '
        Me.BtnAddRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnAddRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddRegister.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.BtnAddRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnAddRegister.Location = New System.Drawing.Point(172, 490)
        Me.BtnAddRegister.Name = "BtnAddRegister"
        Me.BtnAddRegister.Size = New System.Drawing.Size(106, 37)
        Me.BtnAddRegister.TabIndex = 7
        Me.BtnAddRegister.Text = "สมัครใช้งาน"
        Me.BtnAddRegister.UseVisualStyleBackColor = True
        '
        'TxtPhone
        '
        Me.TxtPhone.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtPhone.Location = New System.Drawing.Point(84, 365)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(305, 40)
        Me.TxtPhone.TabIndex = 6
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(84, 312)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(305, 40)
        Me.TxtEmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(158, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ข้อมูลยืนยันตัวตน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(168, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ข้อมูลส่วนตัว"
        '
        'TxtLastName
        '
        Me.TxtLastName.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtLastName.Location = New System.Drawing.Point(84, 112)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(305, 40)
        Me.TxtLastName.TabIndex = 1
        '
        'TxtFristName
        '
        Me.TxtFristName.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtFristName.Location = New System.Drawing.Point(84, 49)
        Me.TxtFristName.Name = "TxtFristName"
        Me.TxtFristName.Size = New System.Drawing.Size(305, 40)
        Me.TxtFristName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 21.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(182, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 43)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "สมัครใช้งาน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 21.75!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(102, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(359, 43)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "กรอกข้อมูลส่วนตัวเพื่อใช้งาน"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Project_CTM.My.Resources.Resources.address_card
        Me.PictureBox2.Location = New System.Drawing.Point(179, 333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.Button1.Location = New System.Drawing.Point(967, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 49)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAddRegister As Button
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFristName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimeBirthDay As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtLastName As TextBox
End Class
