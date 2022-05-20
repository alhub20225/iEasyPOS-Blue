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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryMaterial))
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
        Me.BtnCloseFrm = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDownMaxCateMateId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel68.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanelShowCategoryMaterial)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(366, 488)
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
        Me.FlowLayoutPanelShowCategoryMaterial.Size = New System.Drawing.Size(358, 454)
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
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(387, 51)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(445, 488)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียด"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Global.iEasyPOS.My.Resources.Resources.Icon_AddWhite
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(203, 443)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "เพิ่ม"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.iEasyPOS.My.Resources.Resources.Icon_DeleteWhite
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(81, 443)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 35)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ชื่อหมวดหมู่วัตถุดิบ EN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ชื่อหมวดหมู่วัตถุดิบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ความยาวรหัสสินค้า"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(93, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "รหัสวัตถุดิบ"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.iEasyPOS.My.Resources.Resources.Icon_SaveWhite
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(325, 443)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtCateMatNameEN
        '
        Me.txtCateMatNameEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCateMatNameEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCateMatNameEN.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCateMatNameEN.Location = New System.Drawing.Point(190, 200)
        Me.txtCateMatNameEN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCateMatNameEN.Name = "txtCateMatNameEN"
        Me.txtCateMatNameEN.Size = New System.Drawing.Size(247, 31)
        Me.txtCateMatNameEN.TabIndex = 3
        '
        'txtCateMatNameTH
        '
        Me.txtCateMatNameTH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCateMatNameTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCateMatNameTH.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCateMatNameTH.Location = New System.Drawing.Point(190, 160)
        Me.txtCateMatNameTH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCateMatNameTH.Name = "txtCateMatNameTH"
        Me.txtCateMatNameTH.Size = New System.Drawing.Size(247, 31)
        Me.txtCateMatNameTH.TabIndex = 2
        '
        'NumericUpDownMaxCateMateId
        '
        Me.NumericUpDownMaxCateMateId.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownMaxCateMateId.Location = New System.Drawing.Point(190, 98)
        Me.NumericUpDownMaxCateMateId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericUpDownMaxCateMateId.Name = "NumericUpDownMaxCateMateId"
        Me.NumericUpDownMaxCateMateId.Size = New System.Drawing.Size(62, 31)
        Me.NumericUpDownMaxCateMateId.TabIndex = 1
        Me.NumericUpDownMaxCateMateId.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCateMatId
        '
        Me.txtCateMatId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCateMatId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCateMatId.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCateMatId.Location = New System.Drawing.Point(190, 40)
        Me.txtCateMatId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCateMatId.Name = "txtCateMatId"
        Me.txtCateMatId.Size = New System.Drawing.Size(247, 31)
        Me.txtCateMatId.TabIndex = 0
        '
        'BtnCloseFrm
        '
        Me.BtnCloseFrm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCloseFrm.BackColor = System.Drawing.Color.Transparent
        Me.BtnCloseFrm.BackgroundImage = CType(resources.GetObject("BtnCloseFrm.BackgroundImage"), System.Drawing.Image)
        Me.BtnCloseFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCloseFrm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCloseFrm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCloseFrm.FlatAppearance.BorderSize = 0
        Me.BtnCloseFrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCloseFrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCloseFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseFrm.ForeColor = System.Drawing.Color.White
        Me.BtnCloseFrm.Location = New System.Drawing.Point(807, 5)
        Me.BtnCloseFrm.Name = "BtnCloseFrm"
        Me.BtnCloseFrm.Size = New System.Drawing.Size(32, 32)
        Me.BtnCloseFrm.TabIndex = 19
        Me.BtnCloseFrm.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(20, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(188, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "จัดการหมวดหมู่วัตถุดิบ"
        '
        'Panel68
        '
        Me.Panel68.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel68.Controls.Add(Me.BtnCloseFrm)
        Me.Panel68.Controls.Add(Me.Label34)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(845, 43)
        Me.Panel68.TabIndex = 355
        '
        'CategoryMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 553)
        Me.Controls.Add(Me.Panel68)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CategoryMaterial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "หมวดหมู่ วัตถุดิบ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDownMaxCateMateId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel68.ResumeLayout(False)
        Me.Panel68.PerformLayout()
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
    Friend WithEvents BtnCloseFrm As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel68 As Panel
End Class
