<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerMemberNo
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
        Me.btn = New System.Windows.Forms.Button()
        Me.txtCustomerMemNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btn.Location = New System.Drawing.Point(176, 120)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(149, 42)
        Me.btn.TabIndex = 0
        Me.btn.Text = "ตกลง"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txtCustomerMemNo
        '
        Me.txtCustomerMemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerMemNo.Location = New System.Drawing.Point(70, 56)
        Me.txtCustomerMemNo.Name = "txtCustomerMemNo"
        Me.txtCustomerMemNo.Size = New System.Drawing.Size(363, 44)
        Me.txtCustomerMemNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(69, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัสสมาชิก"
        '
        'FrmCustomerMemberNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 200)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustomerMemNo)
        Me.Controls.Add(Me.btn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCustomerMemberNo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents txtCustomerMemNo As TextBox
    Friend WithEvents Label1 As Label
End Class
