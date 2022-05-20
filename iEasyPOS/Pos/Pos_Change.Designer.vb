<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pos_Change
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_Change))
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label355 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.BtnChange = New System.Windows.Forms.Button()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout
        Me.Panel67.SuspendLayout
        Me.SuspendLayout
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label355)
        Me.Panel1.Controls.Add(Me.txtChange)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Location = New System.Drawing.Point(90, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 144)
        Me.Panel1.TabIndex = 333
        '
        'Label355
        '
        Me.Label355.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label355.AutoSize = True
        Me.Label355.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label355.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label355.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label355.Location = New System.Drawing.Point(111, 85)
        Me.Label355.Name = "Label355"
        Me.Label355.Size = New System.Drawing.Size(78, 29)
        Me.Label355.TabIndex = 126
        Me.Label355.Text = "เงินทอน"
        '
        'txtChange
        '
        Me.txtChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChange.BackColor = System.Drawing.Color.White
        Me.txtChange.Font = New System.Drawing.Font("Kanit", 26.25!, System.Drawing.FontStyle.Bold)
        Me.txtChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtChange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtChange.Location = New System.Drawing.Point(5, 26)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(290, 64)
        Me.txtChange.TabIndex = 127
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(299, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 142)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 142)
        Me.Panel3.TabIndex = 21
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(300, 1)
        Me.Panel13.TabIndex = 20
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel14.Location = New System.Drawing.Point(0, 143)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(300, 1)
        Me.Panel14.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 219)
        Me.Panel5.TabIndex = 336
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 262)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(480, 1)
        Me.Panel6.TabIndex = 337
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(479, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 219)
        Me.Panel4.TabIndex = 335
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(20, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(74, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "เงินทอน"
        '
        'BtnChange
        '
        Me.BtnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChange.BackColor = System.Drawing.Color.Transparent
        Me.BtnChange.BackgroundImage = CType(resources.GetObject("BtnChange.BackgroundImage"), System.Drawing.Image)
        Me.BtnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnChange.FlatAppearance.BorderSize = 0
        Me.BtnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChange.ForeColor = System.Drawing.Color.White
        Me.BtnChange.Location = New System.Drawing.Point(442, 5)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(32, 32)
        Me.BtnChange.TabIndex = 19
        Me.BtnChange.UseVisualStyleBackColor = False
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel67.Controls.Add(Me.BtnChange)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(480, 43)
        Me.Panel67.TabIndex = 334
        '
        'Pos_Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 263)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel67)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pos_Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label355 As Label
    Friend WithEvents txtChange As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents BtnChange As Button
    Friend WithEvents Panel67 As Panel
End Class
