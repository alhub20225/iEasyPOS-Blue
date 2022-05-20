<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_SaveSaleName
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
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.btnSaveSale = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSaleName
        '
        Me.txtSaleName.Font = New System.Drawing.Font("Kanit", 18.0!)
        Me.txtSaleName.Location = New System.Drawing.Point(88, 77)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(253, 43)
        Me.txtSaleName.TabIndex = 0
        Me.txtSaleName.Text = "ลูกค้าเงินสด"
        Me.txtSaleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSaveSale
        '
        Me.btnSaveSale.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.btnSaveSale.Location = New System.Drawing.Point(88, 141)
        Me.btnSaveSale.Name = "btnSaveSale"
        Me.btnSaveSale.Size = New System.Drawing.Size(107, 35)
        Me.btnSaveSale.TabIndex = 1
        Me.btnSaveSale.Text = "บันทึก"
        Me.btnSaveSale.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.btnCancel.Location = New System.Drawing.Point(234, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(135, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "บันทึกพักการขาย"
        '
        'Pos_SaveSaleName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveSale)
        Me.Controls.Add(Me.txtSaleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pos_SaveSaleName"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSaleName As TextBox
    Friend WithEvents btnSaveSale As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
