<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBankCardType
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
        Me.DgBankCardType = New System.Windows.Forms.DataGridView()
        Me.CardTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankCardTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImageCardType = New System.Windows.Forms.PictureBox()
        Me.RadBrowseEditorImageCaedType = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCardTypeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgBankCardType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxImageCardType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBrowseEditorImageCaedType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgBankCardType)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DgBankCardType
        '
        Me.DgBankCardType.AllowUserToAddRows = False
        Me.DgBankCardType.AllowUserToDeleteRows = False
        Me.DgBankCardType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBankCardType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardTypeId, Me.BankCardTypeName})
        Me.DgBankCardType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgBankCardType.Location = New System.Drawing.Point(3, 20)
        Me.DgBankCardType.Name = "DgBankCardType"
        Me.DgBankCardType.ReadOnly = True
        Me.DgBankCardType.Size = New System.Drawing.Size(246, 316)
        Me.DgBankCardType.TabIndex = 0
        '
        'CardTypeId
        '
        Me.CardTypeId.HeaderText = "CardTypeId"
        Me.CardTypeId.Name = "CardTypeId"
        Me.CardTypeId.ReadOnly = True
        '
        'BankCardTypeName
        '
        Me.BankCardTypeName.HeaderText = "BankCardTypeName"
        Me.BankCardTypeName.Name = "BankCardTypeName"
        Me.BankCardTypeName.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBoxImageCardType)
        Me.GroupBox2.Controls.Add(Me.RadBrowseEditorImageCaedType)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCardTypeName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(298, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'PictureBoxImageCardType
        '
        Me.PictureBoxImageCardType.Location = New System.Drawing.Point(137, 84)
        Me.PictureBoxImageCardType.Name = "PictureBoxImageCardType"
        Me.PictureBoxImageCardType.Size = New System.Drawing.Size(100, 81)
        Me.PictureBoxImageCardType.TabIndex = 4
        Me.PictureBoxImageCardType.TabStop = False
        '
        'RadBrowseEditorImageCaedType
        '
        Me.RadBrowseEditorImageCaedType.Location = New System.Drawing.Point(106, 58)
        Me.RadBrowseEditorImageCaedType.Name = "RadBrowseEditorImageCaedType"
        Me.RadBrowseEditorImageCaedType.Size = New System.Drawing.Size(179, 20)
        Me.RadBrowseEditorImageCaedType.TabIndex = 3
        Me.RadBrowseEditorImageCaedType.Text = "RadBrowseEditor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รูป ;"
        '
        'TxtCardTypeName
        '
        Me.TxtCardTypeName.Location = New System.Drawing.Point(106, 19)
        Me.TxtCardTypeName.Name = "TxtCardTypeName"
        Me.TxtCardTypeName.Size = New System.Drawing.Size(204, 27)
        Me.TxtCardTypeName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อประเภทบัตร:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(298, 197)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 31)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnSave.Location = New System.Drawing.Point(497, 197)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 31)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "บันทึกข้อมูล"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(578, 197)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 31)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "ลบข้อมูล"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmAddBankCardType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 501)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAddBankCardType"
        Me.Text = "ประเภทของบัตร"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgBankCardType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxImageCardType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBrowseEditorImageCaedType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgBankCardType As DataGridView
    Friend WithEvents CardTypeId As DataGridViewTextBoxColumn
    Friend WithEvents BankCardTypeName As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxImageCardType As PictureBox
    Friend WithEvents RadBrowseEditorImageCaedType As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCardTypeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
End Class
