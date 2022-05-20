<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditZone
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorBoxEditZone = New Telerik.WinControls.UI.RadColorBox()
        Me.TxtZoneName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ColorBoxEditZone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Location = New System.Drawing.Point(133, 154)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 33)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.Location = New System.Drawing.Point(246, 154)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 33)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "ยกเลิก"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(93, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "สี :"
        '
        'ColorBoxEditZone
        '
        Me.ColorBoxEditZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColorBoxEditZone.Location = New System.Drawing.Point(134, 116)
        Me.ColorBoxEditZone.Name = "ColorBoxEditZone"
        Me.ColorBoxEditZone.Size = New System.Drawing.Size(234, 28)
        Me.ColorBoxEditZone.TabIndex = 6
        Me.ColorBoxEditZone.Text = "RadColorBox1"
        '
        'TxtZoneName
        '
        Me.TxtZoneName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtZoneName.Location = New System.Drawing.Point(134, 65)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.Size = New System.Drawing.Size(234, 29)
        Me.TxtZoneName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(38, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ชื่อ Zone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(128, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "EDIT ZONE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 59)
        Me.Panel1.TabIndex = 8
        '
        'FrmEditZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ColorBoxEditZone)
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEditZone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ColorBoxEditZone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColorBoxEditZone As Telerik.WinControls.UI.RadColorBox
    Friend WithEvents TxtZoneName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
