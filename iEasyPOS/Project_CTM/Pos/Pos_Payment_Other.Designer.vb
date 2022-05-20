<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_Payment_Other
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
        Me.ComboBoxPaytype = New System.Windows.Forms.ComboBox()
        Me.txtTotalPay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxPaytype
        '
        Me.ComboBoxPaytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPaytype.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.ComboBoxPaytype.FormattingEnabled = True
        Me.ComboBoxPaytype.Items.AddRange(New Object() {"QR Thai", "QR Alipay"})
        Me.ComboBoxPaytype.Location = New System.Drawing.Point(78, 40)
        Me.ComboBoxPaytype.Name = "ComboBoxPaytype"
        Me.ComboBoxPaytype.Size = New System.Drawing.Size(334, 32)
        Me.ComboBoxPaytype.TabIndex = 0
        '
        'txtTotalPay
        '
        Me.txtTotalPay.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtTotalPay.Location = New System.Drawing.Point(78, 129)
        Me.txtTotalPay.Name = "txtTotalPay"
        Me.txtTotalPay.Size = New System.Drawing.Size(334, 31)
        Me.txtTotalPay.TabIndex = 1
        Me.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(185, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(205, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "จำนวนเงิน"
        '
        'Pos_Payment_Other
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 378)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTotalPay)
        Me.Controls.Add(Me.ComboBoxPaytype)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pos_Payment_Other"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPaytype As ComboBox
    Friend WithEvents txtTotalPay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
