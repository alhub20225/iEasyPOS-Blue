<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSplitBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplitBill))
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelBillList = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel33.SuspendLayout
        Me.Panel32.SuspendLayout
        Me.Panel67.SuspendLayout
        Me.SuspendLayout
        '
        'Panel29
        '
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel29.Location = New System.Drawing.Point(1, 44)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(10, 372)
        Me.Panel29.TabIndex = 316
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel34.Location = New System.Drawing.Point(0, 42)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(678, 1)
        Me.Panel34.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(11, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "รายการบิล"
        '
        'Panel41
        '
        Me.Panel41.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel41.Location = New System.Drawing.Point(679, 1)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(1, 415)
        Me.Panel41.TabIndex = 22
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel42.Location = New System.Drawing.Point(0, 1)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(1, 415)
        Me.Panel42.TabIndex = 21
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel43.Location = New System.Drawing.Point(0, 0)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(680, 1)
        Me.Panel43.TabIndex = 20
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel44.Location = New System.Drawing.Point(0, 416)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(680, 1)
        Me.Panel44.TabIndex = 19
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel33.Controls.Add(Me.Panel34)
        Me.Panel33.Controls.Add(Me.Label4)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(1, 1)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(678, 43)
        Me.Panel33.TabIndex = 314
        '
        'FlowLayoutPanelBillList
        '
        Me.FlowLayoutPanelBillList.AutoScroll = true
        Me.FlowLayoutPanelBillList.AutoSize = true
        Me.FlowLayoutPanelBillList.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelBillList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelBillList.Location = New System.Drawing.Point(11, 54)
        Me.FlowLayoutPanelBillList.Name = "FlowLayoutPanelBillList"
        Me.FlowLayoutPanelBillList.Size = New System.Drawing.Size(668, 352)
        Me.FlowLayoutPanelBillList.TabIndex = 315
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(11, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 10)
        Me.Panel1.TabIndex = 318
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.Controls.Add(Me.FlowLayoutPanelBillList)
        Me.Panel32.Controls.Add(Me.Panel1)
        Me.Panel32.Controls.Add(Me.Panel2)
        Me.Panel32.Controls.Add(Me.Panel29)
        Me.Panel32.Controls.Add(Me.Panel33)
        Me.Panel32.Controls.Add(Me.Panel41)
        Me.Panel32.Controls.Add(Me.Panel42)
        Me.Panel32.Controls.Add(Me.Panel43)
        Me.Panel32.Controls.Add(Me.Panel44)
        Me.Panel32.Location = New System.Drawing.Point(25, 71)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(680, 417)
        Me.Panel32.TabIndex = 341
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(11, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(668, 10)
        Me.Panel2.TabIndex = 317
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(732, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(20, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(76, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "เลือกบิล"
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel67.Controls.Add(Me.Button1)
        Me.Panel67.Controls.Add(Me.Panel69)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(732, 43)
        Me.Panel67.TabIndex = 339
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"),System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(694, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = false
        '
        'FrmSplitBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 515)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel32)
        Me.Controls.Add(Me.Panel67)
        Me.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmSplitBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplitBill"
        Me.Panel33.ResumeLayout(false)
        Me.Panel33.PerformLayout
        Me.Panel32.ResumeLayout(false)
        Me.Panel32.PerformLayout
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents FlowLayoutPanelBillList As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel67 As Panel
End Class
