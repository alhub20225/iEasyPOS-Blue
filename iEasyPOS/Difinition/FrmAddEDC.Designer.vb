<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddEDC
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
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEDCBarCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBoxBank = New System.Windows.Forms.PictureBox()
        Me.RadBrowseImage = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEDCName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgEDC = New System.Windows.Forms.DataGridView()
        Me.EDCId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDCName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBrowseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgEDC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(530, 225)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 31)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "ลบข้อมูล"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnSave.Location = New System.Drawing.Point(449, 225)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 31)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(277, 225)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 31)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEDCBarCode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PictureBoxBank)
        Me.GroupBox2.Controls.Add(Me.RadBrowseImage)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtEDCName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 217)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'TxtEDCBarCode
        '
        Me.TxtEDCBarCode.Location = New System.Drawing.Point(123, 57)
        Me.TxtEDCBarCode.Name = "TxtEDCBarCode"
        Me.TxtEDCBarCode.Size = New System.Drawing.Size(143, 27)
        Me.TxtEDCBarCode.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "EDC Barcode :"
        '
        'PictureBoxBank
        '
        Me.PictureBoxBank.Location = New System.Drawing.Point(113, 121)
        Me.PictureBoxBank.Name = "PictureBoxBank"
        Me.PictureBoxBank.Size = New System.Drawing.Size(92, 79)
        Me.PictureBoxBank.TabIndex = 6
        Me.PictureBoxBank.TabStop = False
        '
        'RadBrowseImage
        '
        Me.RadBrowseImage.Location = New System.Drawing.Point(113, 95)
        Me.RadBrowseImage.Name = "RadBrowseImage"
        Me.RadBrowseImage.Size = New System.Drawing.Size(143, 20)
        Me.RadBrowseImage.TabIndex = 5
        Me.RadBrowseImage.Text = "RadBrowseEditor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รูป :"
        '
        'TxtEDCName
        '
        Me.TxtEDCName.Location = New System.Drawing.Point(123, 26)
        Me.TxtEDCName.Name = "TxtEDCName"
        Me.TxtEDCName.Size = New System.Drawing.Size(143, 27)
        Me.TxtEDCName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อเครื่อง EDC :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgEDC)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 392)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ธนาคาร"
        '
        'DgEDC
        '
        Me.DgEDC.AllowUserToAddRows = False
        Me.DgEDC.AllowUserToDeleteRows = False
        Me.DgEDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEDC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EDCId, Me.EDCName})
        Me.DgEDC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgEDC.Location = New System.Drawing.Point(3, 20)
        Me.DgEDC.Name = "DgEDC"
        Me.DgEDC.ReadOnly = True
        Me.DgEDC.Size = New System.Drawing.Size(249, 369)
        Me.DgEDC.TabIndex = 0
        '
        'EDCId
        '
        Me.EDCId.HeaderText = "EDCId"
        Me.EDCId.Name = "EDCId"
        Me.EDCId.ReadOnly = True
        '
        'EDCName
        '
        Me.EDCName.HeaderText = "EDCName"
        Me.EDCName.Name = "EDCName"
        Me.EDCName.ReadOnly = True
        '
        'FrmAddEDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 405)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAddEDC"
        Me.Text = "เครื่อง EDC"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBrowseImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgEDC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEDCBarCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBoxBank As PictureBox
    Friend WithEvents RadBrowseImage As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEDCName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgEDC As DataGridView
    Friend WithEvents EDCId As DataGridViewTextBoxColumn
    Friend WithEvents EDCName As DataGridViewTextBoxColumn
End Class
