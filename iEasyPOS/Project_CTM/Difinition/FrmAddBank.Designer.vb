<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBank
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
        Me.DgBank = New System.Windows.Forms.DataGridView()
        Me.BankId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxBank = New System.Windows.Forms.PictureBox()
        Me.RadBrowseImage = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBankName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBrowseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgBank)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ธนาคาร"
        '
        'DgBank
        '
        Me.DgBank.AllowUserToAddRows = False
        Me.DgBank.AllowUserToDeleteRows = False
        Me.DgBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BankId, Me.BankName})
        Me.DgBank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgBank.Location = New System.Drawing.Point(3, 23)
        Me.DgBank.Name = "DgBank"
        Me.DgBank.ReadOnly = True
        Me.DgBank.Size = New System.Drawing.Size(249, 366)
        Me.DgBank.TabIndex = 0
        '
        'BankId
        '
        Me.BankId.HeaderText = "BankId"
        Me.BankId.Name = "BankId"
        Me.BankId.ReadOnly = True
        '
        'BankName
        '
        Me.BankName.HeaderText = "BankName"
        Me.BankName.Name = "BankName"
        Me.BankName.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBoxBank)
        Me.GroupBox2.Controls.Add(Me.RadBrowseImage)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtBankName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'PictureBoxBank
        '
        Me.PictureBoxBank.Location = New System.Drawing.Point(86, 84)
        Me.PictureBoxBank.Name = "PictureBoxBank"
        Me.PictureBoxBank.Size = New System.Drawing.Size(92, 79)
        Me.PictureBoxBank.TabIndex = 6
        Me.PictureBoxBank.TabStop = False
        '
        'RadBrowseImage
        '
        Me.RadBrowseImage.Location = New System.Drawing.Point(86, 58)
        Me.RadBrowseImage.Name = "RadBrowseImage"
        Me.RadBrowseImage.Size = New System.Drawing.Size(143, 20)
        Me.RadBrowseImage.TabIndex = 5
        Me.RadBrowseImage.Text = "RadBrowseEditor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รูป :"
        '
        'TxtBankName
        '
        Me.TxtBankName.Location = New System.Drawing.Point(86, 22)
        Me.TxtBankName.Name = "TxtBankName"
        Me.TxtBankName.Size = New System.Drawing.Size(143, 27)
        Me.TxtBankName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อธนาคาร :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(284, 187)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 35)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnSave.Location = New System.Drawing.Point(456, 187)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 35)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(537, 187)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 35)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "ลบข้อมูล"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmAddBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 416)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAddBank"
        Me.Text = "ธนาคาร"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBrowseImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgBank As DataGridView
    Friend WithEvents BankId As DataGridViewTextBoxColumn
    Friend WithEvents BankName As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBankName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents PictureBoxBank As PictureBox
    Friend WithEvents RadBrowseImage As Telerik.WinControls.UI.RadBrowseEditor
End Class
