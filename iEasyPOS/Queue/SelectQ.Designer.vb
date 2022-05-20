<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectQ
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
        Me.Label_Qnumber = New System.Windows.Forms.Label()
        Me.LabelNumCus = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Qnumber
        '
        Me.Label_Qnumber.Font = New System.Drawing.Font("Kanit", 27.75!)
        Me.Label_Qnumber.Location = New System.Drawing.Point(7, 27)
        Me.Label_Qnumber.Name = "Label_Qnumber"
        Me.Label_Qnumber.Size = New System.Drawing.Size(333, 54)
        Me.Label_Qnumber.TabIndex = 0
        Me.Label_Qnumber.Text = "Qnumber"
        Me.Label_Qnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNumCus
        '
        Me.LabelNumCus.Font = New System.Drawing.Font("Kanit", 21.75!)
        Me.LabelNumCus.Location = New System.Drawing.Point(9, 81)
        Me.LabelNumCus.Name = "LabelNumCus"
        Me.LabelNumCus.Size = New System.Drawing.Size(333, 33)
        Me.LabelNumCus.TabIndex = 1
        Me.LabelNumCus.Text = "NumCus"
        Me.LabelNumCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.times_circle_o
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(305, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 40)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Image = Global.iEasyPOS.My.Resources.Resources.cancel_button
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(7, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(333, 67)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "ยกเลิกคิว"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Image = Global.iEasyPOS.My.Resources.Resources.create_new_pencil_button
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(7, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(333, 67)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "แก้ไข"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Image = Global.iEasyPOS.My.Resources.Resources.exit_to_app_button
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(7, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(333, 67)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "เรียกเข้าโต๊ะ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SelectQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelNumCus)
        Me.Controls.Add(Me.Label_Qnumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SelectQ"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Qnumber As Label
    Friend WithEvents LabelNumCus As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
