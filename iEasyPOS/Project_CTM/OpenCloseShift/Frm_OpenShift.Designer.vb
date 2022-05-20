<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OpenShift
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
        Me.TxtMoney = New System.Windows.Forms.TextBox()
        Me.BtnOpenShift = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbUserName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbtime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMoney
        '
        Me.TxtMoney.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.TxtMoney.Location = New System.Drawing.Point(105, 206)
        Me.TxtMoney.Name = "TxtMoney"
        Me.TxtMoney.Size = New System.Drawing.Size(229, 36)
        Me.TxtMoney.TabIndex = 0
        Me.TxtMoney.Text = "0"
        Me.TxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnOpenShift
        '
        Me.BtnOpenShift.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnOpenShift.Location = New System.Drawing.Point(105, 248)
        Me.BtnOpenShift.Name = "BtnOpenShift"
        Me.BtnOpenShift.Size = New System.Drawing.Size(120, 38)
        Me.BtnOpenShift.TabIndex = 1
        Me.BtnOpenShift.Text = "เปิดกะการขาย"
        Me.BtnOpenShift.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnCancel.Location = New System.Drawing.Point(231, 248)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(103, 38)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "ยกเลิก"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(63, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ผู้ใช้งาน"
        '
        'LbUserName
        '
        Me.LbUserName.AutoSize = True
        Me.LbUserName.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.LbUserName.Location = New System.Drawing.Point(51, 116)
        Me.LbUserName.Name = "LbUserName"
        Me.LbUserName.Size = New System.Drawing.Size(100, 29)
        Me.LbUserName.TabIndex = 4
        Me.LbUserName.Text = "UserName"
        Me.LbUserName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(292, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "วัน/เวลา"
        '
        'LbDate
        '
        Me.LbDate.AutoSize = True
        Me.LbDate.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.LbDate.Location = New System.Drawing.Point(251, 116)
        Me.LbDate.Name = "LbDate"
        Me.LbDate.Size = New System.Drawing.Size(51, 29)
        Me.LbDate.TabIndex = 6
        Me.LbDate.Text = "Date"
        '
        'Timer1
        '
        '
        'Lbtime
        '
        Me.Lbtime.AutoSize = True
        Me.Lbtime.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Lbtime.Location = New System.Drawing.Point(351, 116)
        Me.Lbtime.Name = "Lbtime"
        Me.Lbtime.Size = New System.Drawing.Size(55, 29)
        Me.Lbtime.TabIndex = 7
        Me.Lbtime.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(200, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "เงินทอน"
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(459, 42)
        Me.Top_tap.TabIndex = 9
        Me.Top_tap.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(164, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "เปิดกะการขาย"
        '
        'Frm_OpenShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Top_tap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbtime)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LbUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOpenShift)
        Me.Controls.Add(Me.TxtMoney)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_OpenShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMoney As TextBox
    Friend WithEvents BtnOpenShift As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbUserName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LbDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbtime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents Label4 As Label
End Class
