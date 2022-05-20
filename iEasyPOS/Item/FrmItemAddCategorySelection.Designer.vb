<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemAddCategorySelection
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCateSelectionName2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSelectionName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSrcCategoryName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCateSelectionName2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtSelectionName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSrcCategoryName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        '
        'TxtCateSelectionName2
        '
        Me.TxtCateSelectionName2.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TxtCateSelectionName2.Location = New System.Drawing.Point(259, 104)
        Me.TxtCateSelectionName2.Name = "TxtCateSelectionName2"
        Me.TxtCateSelectionName2.Size = New System.Drawing.Size(240, 31)
        Me.TxtCateSelectionName2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12!)
        Me.Label3.Location = New System.Drawing.Point(32, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CategorySelectionName2 :"
        '
        'TxtSelectionName
        '
        Me.TxtSelectionName.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TxtSelectionName.Location = New System.Drawing.Point(259, 57)
        Me.TxtSelectionName.Name = "TxtSelectionName"
        Me.TxtSelectionName.Size = New System.Drawing.Size(240, 31)
        Me.TxtSelectionName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12!)
        Me.Label2.Location = New System.Drawing.Point(41, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CategorySelectionName :"
        '
        'TxtSrcCategoryName
        '
        Me.TxtSrcCategoryName.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TxtSrcCategoryName.Location = New System.Drawing.Point(259, 14)
        Me.TxtSrcCategoryName.Name = "TxtSrcCategoryName"
        Me.TxtSrcCategoryName.Size = New System.Drawing.Size(240, 31)
        Me.TxtSrcCategoryName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12!)
        Me.Label1.Location = New System.Drawing.Point(179, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา :"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.BtnOk.Location = New System.Drawing.Point(178, 234)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 36)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "ตกลง"
        Me.BtnOk.UseVisualStyleBackColor = true
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.BtnCancel.Location = New System.Drawing.Point(271, 234)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 36)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "ยกเลิก"
        Me.BtnCancel.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(149,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(555, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = false
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(149,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.iEasyPOS.My.Resources.Resources.times_circle_o1
        Me.BtnClose.Location = New System.Drawing.Point(504, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(51, 50)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.UseVisualStyleBackColor = false
        '
        'FrmItemAddCategorySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 279)
        Me.ControlBox = false
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmItemAddCategorySelection"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtCateSelectionName2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSelectionName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSrcCategoryName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnClose As Button
End Class
