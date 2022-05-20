<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQueue
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTimeNow = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelTable = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowTableType = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label_Q = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumOfCus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAddQ = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimeNow = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(433, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รับคิว"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtTimeNow)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LabelTable)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.FlowTableType)
        Me.Panel1.Controls.Add(Me.Label_Q)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNumOfCus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 695)
        Me.Panel1.TabIndex = 2
        '
        'txtTimeNow
        '
        Me.txtTimeNow.AutoSize = True
        Me.txtTimeNow.Font = New System.Drawing.Font("Kanit", 18.0!)
        Me.txtTimeNow.Location = New System.Drawing.Point(537, 71)
        Me.txtTimeNow.Name = "txtTimeNow"
        Me.txtTimeNow.Size = New System.Drawing.Size(123, 35)
        Me.txtTimeNow.TabIndex = 14
        Me.txtTimeNow.Text = "Time now"
        Me.txtTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 26.25!)
        Me.Label6.Location = New System.Drawing.Point(264, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 53)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ท่าน นั่ง"
        '
        'LabelTable
        '
        Me.LabelTable.AutoSize = True
        Me.LabelTable.Font = New System.Drawing.Font("Kanit", 26.25!)
        Me.LabelTable.Location = New System.Drawing.Point(405, 61)
        Me.LabelTable.Name = "LabelTable"
        Me.LabelTable.Size = New System.Drawing.Size(105, 53)
        Me.LabelTable.TabIndex = 12
        Me.LabelTable.Text = "Table"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(41, 538)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(596, 109)
        Me.TextBox1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Kanit Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 35)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "เพิ่มเติม"
        '
        'FlowTableType
        '
        Me.FlowTableType.Location = New System.Drawing.Point(41, 200)
        Me.FlowTableType.Name = "FlowTableType"
        Me.FlowTableType.Size = New System.Drawing.Size(596, 289)
        Me.FlowTableType.TabIndex = 9
        '
        'Label_Q
        '
        Me.Label_Q.AutoSize = True
        Me.Label_Q.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_Q.Location = New System.Drawing.Point(443, 3)
        Me.Label_Q.Name = "Label_Q"
        Me.Label_Q.Size = New System.Drawing.Size(47, 42)
        Me.Label_Q.TabIndex = 8
        Me.Label_Q.Text = "Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Kanit Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(35, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ประเภทคิว"
        '
        'txtNumOfCus
        '
        Me.txtNumOfCus.BackColor = System.Drawing.Color.White
        Me.txtNumOfCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNumOfCus.Location = New System.Drawing.Point(41, 71)
        Me.txtNumOfCus.Name = "txtNumOfCus"
        Me.txtNumOfCus.Size = New System.Drawing.Size(217, 38)
        Me.txtNumOfCus.TabIndex = 3
        Me.txtNumOfCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Kanit Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "จำนวนลูกค้า"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnAddQ)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(666, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(275, 695)
        Me.Panel2.TabIndex = 3
        '
        'BtnAddQ
        '
        Me.BtnAddQ.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnAddQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddQ.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAddQ.ForeColor = System.Drawing.Color.White
        Me.BtnAddQ.Location = New System.Drawing.Point(5, 606)
        Me.BtnAddQ.Name = "BtnAddQ"
        Me.BtnAddQ.Size = New System.Drawing.Size(265, 76)
        Me.BtnAddQ.TabIndex = 10
        Me.BtnAddQ.Text = "รับคิว"
        Me.BtnAddQ.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Kanit", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(65, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เพิ่มออเดอร์"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.BackgroundImage = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(882, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 59)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(941, 63)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TimeNow
        '
        '
        'FrmQueue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 758)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmQueue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FlowTableType As FlowLayoutPanel
    Friend WithEvents Label_Q As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumOfCus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAddQ As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelTable As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTimeNow As Label
    Friend WithEvents TimeNow As Timer
End Class
