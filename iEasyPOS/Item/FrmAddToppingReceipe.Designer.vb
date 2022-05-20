<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddToppingReceipe
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
        Me.txtMatCode = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtMatName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMatCode
        '
        Me.txtMatCode.Enabled = False
        Me.txtMatCode.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtMatCode.Location = New System.Drawing.Point(111, 37)
        Me.txtMatCode.Name = "txtMatCode"
        Me.txtMatCode.Size = New System.Drawing.Size(151, 31)
        Me.txtMatCode.TabIndex = 0
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtQty.Location = New System.Drawing.Point(111, 108)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(151, 31)
        Me.txtQty.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "จำนวนเบิก :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รหัสวัตถุดิบ :"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnSave.Location = New System.Drawing.Point(25, 167)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 36)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "ตกลง"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnClose.Location = New System.Drawing.Point(164, 167)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 36)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "ยกเลิก"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtMatName
        '
        Me.txtMatName.Enabled = False
        Me.txtMatName.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtMatName.Location = New System.Drawing.Point(111, 73)
        Me.txtMatName.Name = "txtMatName"
        Me.txtMatName.Size = New System.Drawing.Size(151, 31)
        Me.txtMatName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ชื่อวัตถุดิบ :"
        '
        'FrmAddToppingReceipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 235)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMatName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtMatCode)
        Me.Name = "FrmAddToppingReceipe"
        Me.Text = "FrmAddToppingReceipe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMatCode As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtMatName As TextBox
    Friend WithEvents Label3 As Label
End Class
