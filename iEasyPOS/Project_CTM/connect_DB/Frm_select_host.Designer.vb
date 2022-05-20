<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_select_host
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.btn_test = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.txt_servername = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Controls.Add(Me.btn_test)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_database)
        Me.GroupBox1.Controls.Add(Me.txt_servername)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server setting"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(289, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "New Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(45, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password :"
        '
        'TxtPassword
        '
        Me.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPassword.Location = New System.Drawing.Point(135, 130)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(246, 31)
        Me.TxtPassword.TabIndex = 7
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(36, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "UserName :"
        '
        'TxtUserName
        '
        Me.TxtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtUserName.Location = New System.Drawing.Point(135, 90)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(246, 31)
        Me.TxtUserName.TabIndex = 5
        '
        'btn_test
        '
        Me.btn_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_test.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btn_test.Location = New System.Drawing.Point(135, 226)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(148, 35)
        Me.btn_test.TabIndex = 4
        Me.btn_test.Text = "Test Connection"
        Me.btn_test.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(45, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DataBase :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server Name :"
        '
        'txt_database
        '
        Me.txt_database.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_database.Location = New System.Drawing.Point(135, 175)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(246, 31)
        Me.txt_database.TabIndex = 1
        '
        'txt_servername
        '
        Me.txt_servername.Location = New System.Drawing.Point(135, 41)
        Me.txt_servername.Name = "txt_servername"
        Me.txt_servername.Size = New System.Drawing.Size(246, 31)
        Me.txt_servername.TabIndex = 0
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(411, 285)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 30)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(318, 285)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 30)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "ตกลง"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Frm_select_host
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_select_host"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_database As TextBox
    Friend WithEvents txt_servername As TextBox
    Friend WithEvents btn_test As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents Button1 As Button
End Class
