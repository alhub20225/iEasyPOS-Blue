<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmButtonManageZone
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
        Me.BtnAddZone = New System.Windows.Forms.Button()
        Me.BtnEditZone = New System.Windows.Forms.Button()
        Me.BtnDeleteZone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAddZone
        '
        Me.BtnAddZone.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.BtnAddZone.Location = New System.Drawing.Point(21, 26)
        Me.BtnAddZone.Name = "BtnAddZone"
        Me.BtnAddZone.Size = New System.Drawing.Size(70, 30)
        Me.BtnAddZone.TabIndex = 0
        Me.BtnAddZone.Text = "เพิ่ม Zone"
        Me.BtnAddZone.UseVisualStyleBackColor = True
        '
        'BtnEditZone
        '
        Me.BtnEditZone.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.BtnEditZone.Location = New System.Drawing.Point(97, 26)
        Me.BtnEditZone.Name = "BtnEditZone"
        Me.BtnEditZone.Size = New System.Drawing.Size(76, 30)
        Me.BtnEditZone.TabIndex = 1
        Me.BtnEditZone.Text = "แก้ไข"
        Me.BtnEditZone.UseVisualStyleBackColor = True
        '
        'BtnDeleteZone
        '
        Me.BtnDeleteZone.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.BtnDeleteZone.Location = New System.Drawing.Point(179, 26)
        Me.BtnDeleteZone.Name = "BtnDeleteZone"
        Me.BtnDeleteZone.Size = New System.Drawing.Size(73, 30)
        Me.BtnDeleteZone.TabIndex = 2
        Me.BtnDeleteZone.Text = "ลบ"
        Me.BtnDeleteZone.UseVisualStyleBackColor = True
        '
        'FrmButtonManageZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 83)
        Me.Controls.Add(Me.BtnDeleteZone)
        Me.Controls.Add(Me.BtnEditZone)
        Me.Controls.Add(Me.BtnAddZone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmButtonManageZone"
        Me.Text = "ButtonManageZone"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAddZone As Button
    Friend WithEvents BtnEditZone As Button
    Friend WithEvents BtnDeleteZone As Button
End Class
