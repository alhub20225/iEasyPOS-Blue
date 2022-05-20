<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCardType
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
        Me.TxtMoreMoney = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDisCount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxCharge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxBank = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBoxImageCardType = New System.Windows.Forms.PictureBox()
        Me.RadBrowseEditorImageCaedType = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCardTypeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgCardType = New System.Windows.Forms.DataGridView()
        Me.CardTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxImageCardType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBrowseEditorImageCaedType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgCardType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(524, 421)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 30)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "ลบข้อมูล"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnSave.Location = New System.Drawing.Point(443, 421)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 30)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "บันทึกข้อมูล"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(244, 421)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 30)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtMoreMoney)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtDisCount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtBoxCharge)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBoxBank)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImageCardType)
        Me.GroupBox2.Controls.Add(Me.RadBrowseEditorImageCaedType)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtCardTypeName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 400)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'TxtMoreMoney
        '
        Me.TxtMoreMoney.Location = New System.Drawing.Point(122, 109)
        Me.TxtMoreMoney.Name = "TxtMoreMoney"
        Me.TxtMoreMoney.Size = New System.Drawing.Size(204, 27)
        Me.TxtMoreMoney.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Moremoney :"
        '
        'TxtDisCount
        '
        Me.TxtDisCount.Location = New System.Drawing.Point(122, 195)
        Me.TxtDisCount.Name = "TxtDisCount"
        Me.TxtDisCount.Size = New System.Drawing.Size(204, 27)
        Me.TxtDisCount.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Discount % :"
        '
        'TxtBoxCharge
        '
        Me.TxtBoxCharge.Location = New System.Drawing.Point(122, 146)
        Me.TxtBoxCharge.Name = "TxtBoxCharge"
        Me.TxtBoxCharge.Size = New System.Drawing.Size(204, 27)
        Me.TxtBoxCharge.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Charge% :"
        '
        'ComboBoxBank
        '
        Me.ComboBoxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBank.FormattingEnabled = True
        Me.ComboBoxBank.Location = New System.Drawing.Point(122, 65)
        Me.ComboBoxBank.Name = "ComboBoxBank"
        Me.ComboBoxBank.Size = New System.Drawing.Size(165, 27)
        Me.ComboBoxBank.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ธนาคาร :"
        '
        'PictureBoxImageCardType
        '
        Me.PictureBoxImageCardType.Location = New System.Drawing.Point(153, 269)
        Me.PictureBoxImageCardType.Name = "PictureBoxImageCardType"
        Me.PictureBoxImageCardType.Size = New System.Drawing.Size(100, 81)
        Me.PictureBoxImageCardType.TabIndex = 4
        Me.PictureBoxImageCardType.TabStop = False
        '
        'RadBrowseEditorImageCaedType
        '
        Me.RadBrowseEditorImageCaedType.Location = New System.Drawing.Point(122, 243)
        Me.RadBrowseEditorImageCaedType.Name = "RadBrowseEditorImageCaedType"
        Me.RadBrowseEditorImageCaedType.Size = New System.Drawing.Size(179, 20)
        Me.RadBrowseEditorImageCaedType.TabIndex = 3
        Me.RadBrowseEditorImageCaedType.Text = "RadBrowseEditor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รูป ;"
        '
        'TxtCardTypeName
        '
        Me.TxtCardTypeName.Location = New System.Drawing.Point(122, 16)
        Me.TxtCardTypeName.Name = "TxtCardTypeName"
        Me.TxtCardTypeName.Size = New System.Drawing.Size(204, 27)
        Me.TxtCardTypeName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อประเภทบัตร:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgCardType)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 520)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'DgCardType
        '
        Me.DgCardType.AllowUserToAddRows = False
        Me.DgCardType.AllowUserToDeleteRows = False
        Me.DgCardType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCardType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardTypeId, Me.CardTypeName})
        Me.DgCardType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgCardType.Location = New System.Drawing.Point(3, 20)
        Me.DgCardType.Name = "DgCardType"
        Me.DgCardType.ReadOnly = True
        Me.DgCardType.Size = New System.Drawing.Size(232, 497)
        Me.DgCardType.TabIndex = 0
        '
        'CardTypeId
        '
        Me.CardTypeId.HeaderText = "CardTypeId"
        Me.CardTypeId.Name = "CardTypeId"
        Me.CardTypeId.ReadOnly = True
        '
        'CardTypeName
        '
        Me.CardTypeName.HeaderText = "CardTypeName"
        Me.CardTypeName.Name = "CardTypeName"
        Me.CardTypeName.ReadOnly = True
        '
        'FrmAddCardType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 547)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAddCardType"
        Me.Text = "ชนิดของบัตร"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxImageCardType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBrowseEditorImageCaedType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgCardType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxImageCardType As PictureBox
    Friend WithEvents RadBrowseEditorImageCaedType As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCardTypeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgCardType As DataGridView
    Friend WithEvents CardTypeId As DataGridViewTextBoxColumn
    Friend WithEvents CardTypeName As DataGridViewTextBoxColumn
    Friend WithEvents TxtDisCount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxCharge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxBank As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMoreMoney As TextBox
    Friend WithEvents Label6 As Label
End Class
