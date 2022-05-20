<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryMaterial
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
        Me.FlowLayoutPanelShowCategoryMaterial = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCateMatNameEN = New System.Windows.Forms.TextBox()
        Me.txtCateMatNameTH = New System.Windows.Forms.TextBox()
        Me.NumericUpDownMaxCateMateId = New System.Windows.Forms.NumericUpDown()
        Me.txtCateMatId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDownMaxCateMateId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanelShowCategoryMaterial)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 324)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "หมวดหมู่"
        '
        'FlowLayoutPanelShowCategoryMaterial
        '
        Me.FlowLayoutPanelShowCategoryMaterial.AutoScroll = True
        Me.FlowLayoutPanelShowCategoryMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelShowCategoryMaterial.Location = New System.Drawing.Point(4, 29)
        Me.FlowLayoutPanelShowCategoryMaterial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanelShowCategoryMaterial.Name = "FlowLayoutPanelShowCategoryMaterial"
        Me.FlowLayoutPanelShowCategoryMaterial.Size = New System.Drawing.Size(292, 290)
        Me.FlowLayoutPanelShowCategoryMaterial.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.txtCateMatNameEN)
        Me.GroupBox2.Controls.Add(Me.txtCateMatNameTH)
        Me.GroupBox2.Controls.Add(Me.NumericUpDownMaxCateMateId)
        Me.GroupBox2.Controls.Add(Me.txtCateMatId)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(414, 320)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "หมวดหมู่ วัตถุดิบ"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(154, 275)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "เพิ่ม"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(32, 275)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 35)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ชื่อหมวดหมู่วัตถุดิบ EN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ชื่อหมวดหมู่วัตถุดิบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Max Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "รหัสวัตถุดิบ"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(276, 275)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCateMatNameEN
        '
        Me.txtCateMatNameEN.Location = New System.Drawing.Point(190, 178)
        Me.txtCateMatNameEN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCateMatNameEN.Name = "txtCateMatNameEN"
        Me.txtCateMatNameEN.Size = New System.Drawing.Size(198, 31)
        Me.txtCateMatNameEN.TabIndex = 3
        '
        'txtCateMatNameTH
        '
        Me.txtCateMatNameTH.Location = New System.Drawing.Point(190, 138)
        Me.txtCateMatNameTH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCateMatNameTH.Name = "txtCateMatNameTH"
        Me.txtCateMatNameTH.Size = New System.Drawing.Size(198, 31)
        Me.txtCateMatNameTH.TabIndex = 2
        '
        'NumericUpDownMaxCateMateId
        '
        Me.NumericUpDownMaxCateMateId.Location = New System.Drawing.Point(190, 98)
        Me.NumericUpDownMaxCateMateId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericUpDownMaxCateMateId.Name = "NumericUpDownMaxCateMateId"
        Me.NumericUpDownMaxCateMateId.Size = New System.Drawing.Size(62, 31)
        Me.NumericUpDownMaxCateMateId.TabIndex = 1
        Me.NumericUpDownMaxCateMateId.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCateMatId
        '
        Me.txtCateMatId.Location = New System.Drawing.Point(190, 58)
        Me.txtCateMatId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCateMatId.Name = "txtCateMatId"
        Me.txtCateMatId.Size = New System.Drawing.Size(198, 31)
        Me.txtCateMatId.TabIndex = 0
        '
        'CategoryMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 354)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CategoryMaterial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "หมวดหมู่ วัตถุดิบ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDownMaxCateMateId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlowLayoutPanelShowCategoryMaterial As FlowLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCateMatNameEN As TextBox
    Friend WithEvents txtCateMatNameTH As TextBox
    Friend WithEvents NumericUpDownMaxCateMateId As NumericUpDown
    Friend WithEvents txtCateMatId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
End Class
