<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FloorPlan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Close_table = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Floor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 671)
        Me.Panel1.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FlowLayoutPanelZone)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 601)
        Me.Panel3.TabIndex = 4
        '
        'FlowLayoutPanelZone
        '
        Me.FlowLayoutPanelZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelZone.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelZone.Name = "FlowLayoutPanelZone"
        Me.FlowLayoutPanelZone.Size = New System.Drawing.Size(155, 601)
        Me.FlowLayoutPanelZone.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 601)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 70)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Floor Img"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = Global.Project_CTM.My.Resources.Resources.cog
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(96, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 41)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Floor Plan"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.BackgroundImage = Global.Project_CTM.My.Resources.Resources.save
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1144, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Close_table
        '
        Me.Close_table.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_table.BackColor = System.Drawing.Color.YellowGreen
        Me.Close_table.FlatAppearance.BorderSize = 0
        Me.Close_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_table.Image = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.Close_table.Location = New System.Drawing.Point(1206, 2)
        Me.Close_table.Name = "Close_table"
        Me.Close_table.Size = New System.Drawing.Size(58, 54)
        Me.Close_table.TabIndex = 7
        Me.Close_table.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.YellowGreen
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(1264, 58)
        Me.Top_tap.TabIndex = 6
        Me.Top_tap.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Floor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(155, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1109, 671)
        Me.Panel4.TabIndex = 14
        '
        'Floor
        '
        Me.Floor.BackColor = System.Drawing.Color.Silver
        Me.Floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Floor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Floor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Floor.Location = New System.Drawing.Point(0, 0)
        Me.Floor.Name = "Floor"
        Me.Floor.Size = New System.Drawing.Size(1109, 671)
        Me.Floor.TabIndex = 14
        '
        'FloorPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Close_table)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FloorPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FloorPlan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents Close_table As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanelZone As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Floor As Panel
End Class
