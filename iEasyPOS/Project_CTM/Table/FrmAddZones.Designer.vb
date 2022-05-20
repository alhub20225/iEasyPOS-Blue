<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddZones
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
        Me.ColorBtnZone = New Telerik.WinControls.UI.RadColorBox()
        Me.TxtZoneName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.ColorBtnZone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(75, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "สี :"
        '
        'ColorBtnZone
        '
        Me.ColorBtnZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColorBtnZone.Location = New System.Drawing.Point(134, 114)
        Me.ColorBtnZone.Name = "ColorBtnZone"
        Me.ColorBtnZone.Size = New System.Drawing.Size(205, 28)
        Me.ColorBtnZone.TabIndex = 2
        Me.ColorBtnZone.Text = "RadColorBox1"
        '
        'TxtZoneName
        '
        Me.TxtZoneName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtZoneName.Location = New System.Drawing.Point(134, 69)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.Size = New System.Drawing.Size(205, 29)
        Me.TxtZoneName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(14, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ Zone :"
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnClear.Location = New System.Drawing.Point(230, 153)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 35)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "ยกเลิก"
        Me.BtnClear.UseVisualStyleBackColor = True
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
        Me.Label3.Text = "ADD ZONE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 59)
        Me.Panel1.TabIndex = 7
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Location = New System.Drawing.Point(134, 153)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 35)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmAddZones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.ColorBtnZone)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddZones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ColorBtnZone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtZoneName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColorBtnZone As Telerik.WinControls.UI.RadColorBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
