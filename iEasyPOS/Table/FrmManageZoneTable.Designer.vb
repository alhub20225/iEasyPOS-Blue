<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManageZoneTable
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close_table = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.GroupBoxZone = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanelZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBoxTable = New System.Windows.Forms.GroupBox()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxZone.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "HiveUP  TABLE"
        '
        'Close_table
        '
        Me.Close_table.BackColor = System.Drawing.Color.YellowGreen
        Me.Close_table.FlatAppearance.BorderSize = 0
        Me.Close_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_table.Image = Global.iEasyPOS.My.Resources.Resources.times_circle_o1
        Me.Close_table.Location = New System.Drawing.Point(1205, 1)
        Me.Close_table.Name = "Close_table"
        Me.Close_table.Size = New System.Drawing.Size(58, 54)
        Me.Close_table.TabIndex = 4
        Me.Close_table.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.YellowGreen
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(1264, 58)
        Me.Top_tap.TabIndex = 5
        Me.Top_tap.TabStop = False
        '
        'GroupBoxZone
        '
        Me.GroupBoxZone.Controls.Add(Me.FlowLayoutPanelZone)
        Me.GroupBoxZone.Location = New System.Drawing.Point(12, 76)
        Me.GroupBoxZone.Name = "GroupBoxZone"
        Me.GroupBoxZone.Size = New System.Drawing.Size(267, 641)
        Me.GroupBoxZone.TabIndex = 7
        Me.GroupBoxZone.TabStop = False
        Me.GroupBoxZone.Text = "GroupBox1"
        '
        'FlowLayoutPanelZone
        '
        Me.FlowLayoutPanelZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelZone.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanelZone.Name = "FlowLayoutPanelZone"
        Me.FlowLayoutPanelZone.Size = New System.Drawing.Size(261, 622)
        Me.FlowLayoutPanelZone.TabIndex = 0
        '
        'GroupBoxTable
        '
        Me.GroupBoxTable.Location = New System.Drawing.Point(285, 76)
        Me.GroupBoxTable.Name = "GroupBoxTable"
        Me.GroupBoxTable.Size = New System.Drawing.Size(967, 638)
        Me.GroupBoxTable.TabIndex = 8
        Me.GroupBoxTable.TabStop = False
        Me.GroupBoxTable.Text = "GroupBox1"
        '
        'FrmManageZoneTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.GroupBoxTable)
        Me.Controls.Add(Me.GroupBoxZone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close_table)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmManageZoneTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxZone.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Close_table As Button
    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents GroupBoxZone As GroupBox
    Friend WithEvents FlowLayoutPanelZone As FlowLayoutPanel
    Friend WithEvents GroupBoxTable As GroupBox
End Class
