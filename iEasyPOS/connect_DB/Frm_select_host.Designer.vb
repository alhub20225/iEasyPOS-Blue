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
        Me.BtnUpdateDB = New System.Windows.Forms.Button()
        Me.btnUpdateFile = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 329)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server setting"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(385, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "New Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(60, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password :"
        '
        'TxtPassword
        '
        Me.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPassword.Location = New System.Drawing.Point(180, 160)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(327, 37)
        Me.TxtPassword.TabIndex = 7
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "UserName :"
        '
        'TxtUserName
        '
        Me.TxtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtUserName.Location = New System.Drawing.Point(180, 111)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(327, 37)
        Me.TxtUserName.TabIndex = 5
        '
        'btn_test
        '
        Me.btn_test.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_test.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btn_test.Location = New System.Drawing.Point(180, 278)
        Me.btn_test.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(197, 43)
        Me.btn_test.TabIndex = 4
        Me.btn_test.Text = "Test Connection"
        Me.btn_test.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(60, 219)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DataBase :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server Name :"
        '
        'txt_database
        '
        Me.txt_database.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_database.Location = New System.Drawing.Point(180, 215)
        Me.txt_database.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(327, 37)
        Me.txt_database.TabIndex = 1
        '
        'txt_servername
        '
        Me.txt_servername.Location = New System.Drawing.Point(180, 50)
        Me.txt_servername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_servername.Name = "txt_servername"
        Me.txt_servername.Size = New System.Drawing.Size(327, 37)
        Me.txt_servername.TabIndex = 0
        Me.txt_servername.Text = ".\SQLEXPRESS"
        '
        'btn_cancel
        '
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(525, 351)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(123, 41)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(391, 351)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(127, 41)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "Save"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'BtnUpdateDB
        '
        Me.BtnUpdateDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateDB.Enabled = False
        Me.BtnUpdateDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateDB.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.BtnUpdateDB.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateDB.Location = New System.Drawing.Point(16, 348)
        Me.BtnUpdateDB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUpdateDB.Name = "BtnUpdateDB"
        Me.BtnUpdateDB.Size = New System.Drawing.Size(197, 43)
        Me.BtnUpdateDB.TabIndex = 5
        Me.BtnUpdateDB.Text = "UpdateDB"
        Me.BtnUpdateDB.UseVisualStyleBackColor = True
        '
        'btnUpdateFile
        '
        Me.btnUpdateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateFile.Font = New System.Drawing.Font("Kanit Medium", 12.0!)
        Me.btnUpdateFile.ForeColor = System.Drawing.Color.White
        Me.btnUpdateFile.Location = New System.Drawing.Point(391, 411)
        Me.btnUpdateFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdateFile.Name = "btnUpdateFile"
        Me.btnUpdateFile.Size = New System.Drawing.Size(257, 37)
        Me.btnUpdateFile.TabIndex = 11
        Me.btnUpdateFile.Text = "Download update file"
        Me.btnUpdateFile.UseVisualStyleBackColor = True
        '
        'Frm_select_host
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(664, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdateFile)
        Me.Controls.Add(Me.BtnUpdateDB)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm_select_host"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

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
    Friend WithEvents BtnUpdateDB As Button
    Friend WithEvents btnUpdateFile As Button
End Class
