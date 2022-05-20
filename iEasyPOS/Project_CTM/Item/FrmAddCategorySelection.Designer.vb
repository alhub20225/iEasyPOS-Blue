<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCategorySelection
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
        Me.BtnSrc = New System.Windows.Forms.Button()
        Me.TxtSrc = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCateSelectName2 = New System.Windows.Forms.TextBox()
        Me.TxtCateSelectName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGDataCateSelection = New System.Windows.Forms.DataGridView()
        Me.ชื่อหมวดหมู่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnDeleteSelection = New System.Windows.Forms.Button()
        Me.BtnSaveSelection = New System.Windows.Forms.Button()
        Me.BtnAddSelection = New System.Windows.Forms.Button()
        Me.ComboBoxSelection = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DgSelection = New System.Windows.Forms.DataGridView()
        Me.SelectionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selectionid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtSelectionName2 = New System.Windows.Forms.TextBox()
        Me.TxtSelectionName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxCateSelectionNameDetail = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCateSelection = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGDataCateSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSrc)
        Me.GroupBox1.Controls.Add(Me.TxtSrc)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnSrc
        '
        Me.BtnSrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSrc.Location = New System.Drawing.Point(230, 17)
        Me.BtnSrc.Name = "BtnSrc"
        Me.BtnSrc.Size = New System.Drawing.Size(69, 39)
        Me.BtnSrc.TabIndex = 5
        Me.BtnSrc.Text = "ค้นหา"
        Me.BtnSrc.UseVisualStyleBackColor = True
        '
        'TxtSrc
        '
        Me.TxtSrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSrc.Location = New System.Drawing.Point(6, 24)
        Me.TxtSrc.Name = "TxtSrc"
        Me.TxtSrc.Size = New System.Drawing.Size(218, 26)
        Me.TxtSrc.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCateSelectName2)
        Me.GroupBox2.Controls.Add(Me.TxtCateSelectName)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(371, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 148)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อหมวดหมู่ EN :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ชื่อหมวดหมู่ :"
        '
        'TxtCateSelectName2
        '
        Me.TxtCateSelectName2.Location = New System.Drawing.Point(146, 73)
        Me.TxtCateSelectName2.Name = "TxtCateSelectName2"
        Me.TxtCateSelectName2.Size = New System.Drawing.Size(139, 31)
        Me.TxtCateSelectName2.TabIndex = 2
        '
        'TxtCateSelectName
        '
        Me.TxtCateSelectName.Location = New System.Drawing.Point(146, 31)
        Me.TxtCateSelectName.Name = "TxtCateSelectName"
        Me.TxtCateSelectName.Size = New System.Drawing.Size(139, 31)
        Me.TxtCateSelectName.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGDataCateSelection)
        Me.GroupBox3.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(305, 300)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'DGDataCateSelection
        '
        Me.DGDataCateSelection.AllowUserToAddRows = False
        Me.DGDataCateSelection.AllowUserToDeleteRows = False
        Me.DGDataCateSelection.AllowUserToResizeRows = False
        Me.DGDataCateSelection.BackgroundColor = System.Drawing.Color.White
        Me.DGDataCateSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDataCateSelection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อหมวดหมู่, Me.Id})
        Me.DGDataCateSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGDataCateSelection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGDataCateSelection.Location = New System.Drawing.Point(3, 21)
        Me.DGDataCateSelection.Name = "DGDataCateSelection"
        Me.DGDataCateSelection.ReadOnly = True
        Me.DGDataCateSelection.RowHeadersVisible = False
        Me.DGDataCateSelection.Size = New System.Drawing.Size(299, 276)
        Me.DGDataCateSelection.TabIndex = 0
        '
        'ชื่อหมวดหมู่
        '
        Me.ชื่อหมวดหมู่.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อหมวดหมู่.HeaderText = "ชื่อหมวดหมู่"
        Me.ชื่อหมวดหมู่.Name = "ชื่อหมวดหมู่"
        Me.ชื่อหมวดหมู่.ReadOnly = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(386, 346)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(95, 39)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "เพิ่มข้อมูล"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSave.Location = New System.Drawing.Point(517, 346)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 39)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnDelete.Location = New System.Drawing.Point(618, 346)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(95, 39)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "ลบ"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(150, 25)
        Me.TabControl1.Location = New System.Drawing.Point(12, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(727, 424)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.BtnDelete)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.BtnAdd)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(719, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "กลุ่มตัวเลือก"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnDeleteSelection)
        Me.TabPage2.Controls.Add(Me.BtnSaveSelection)
        Me.TabPage2.Controls.Add(Me.BtnAddSelection)
        Me.TabPage2.Controls.Add(Me.ComboBoxSelection)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.TxtCateSelection)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Font = New System.Drawing.Font("Kanit", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(719, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ตัวเลือก"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnDeleteSelection
        '
        Me.BtnDeleteSelection.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnDeleteSelection.Location = New System.Drawing.Point(638, 352)
        Me.BtnDeleteSelection.Name = "BtnDeleteSelection"
        Me.BtnDeleteSelection.Size = New System.Drawing.Size(75, 33)
        Me.BtnDeleteSelection.TabIndex = 8
        Me.BtnDeleteSelection.Text = "ลบข้อมูล"
        Me.BtnDeleteSelection.UseVisualStyleBackColor = True
        '
        'BtnSaveSelection
        '
        Me.BtnSaveSelection.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnSaveSelection.Location = New System.Drawing.Point(557, 352)
        Me.BtnSaveSelection.Name = "BtnSaveSelection"
        Me.BtnSaveSelection.Size = New System.Drawing.Size(75, 33)
        Me.BtnSaveSelection.TabIndex = 7
        Me.BtnSaveSelection.Text = "บันทึก"
        Me.BtnSaveSelection.UseVisualStyleBackColor = True
        '
        'BtnAddSelection
        '
        Me.BtnAddSelection.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnAddSelection.Location = New System.Drawing.Point(333, 352)
        Me.BtnAddSelection.Name = "BtnAddSelection"
        Me.BtnAddSelection.Size = New System.Drawing.Size(107, 33)
        Me.BtnAddSelection.TabIndex = 6
        Me.BtnAddSelection.Text = "เพิ่มข้อมูล"
        Me.BtnAddSelection.UseVisualStyleBackColor = True
        '
        'ComboBoxSelection
        '
        Me.ComboBoxSelection.FormattingEnabled = True
        Me.ComboBoxSelection.Location = New System.Drawing.Point(164, 52)
        Me.ComboBoxSelection.Name = "ComboBoxSelection"
        Me.ComboBoxSelection.Size = New System.Drawing.Size(131, 26)
        Me.ComboBoxSelection.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(7, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Category Selection :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DgSelection)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(289, 311)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'DgSelection
        '
        Me.DgSelection.AllowUserToAddRows = False
        Me.DgSelection.AllowUserToDeleteRows = False
        Me.DgSelection.BackgroundColor = System.Drawing.Color.White
        Me.DgSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSelection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectionName, Me.Selectionid})
        Me.DgSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgSelection.Location = New System.Drawing.Point(3, 21)
        Me.DgSelection.Name = "DgSelection"
        Me.DgSelection.ReadOnly = True
        Me.DgSelection.RowHeadersVisible = False
        Me.DgSelection.Size = New System.Drawing.Size(283, 287)
        Me.DgSelection.TabIndex = 0
        '
        'SelectionName
        '
        Me.SelectionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SelectionName.HeaderText = "SelectionName"
        Me.SelectionName.Name = "SelectionName"
        Me.SelectionName.ReadOnly = True
        '
        'Selectionid
        '
        Me.Selectionid.HeaderText = "Selectionid"
        Me.Selectionid.Name = "Selectionid"
        Me.Selectionid.ReadOnly = True
        Me.Selectionid.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtSelectionName2)
        Me.GroupBox4.Controls.Add(Me.TxtSelectionName)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBoxCateSelectionNameDetail)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(333, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(380, 129)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'TxtSelectionName2
        '
        Me.TxtSelectionName2.Location = New System.Drawing.Point(163, 91)
        Me.TxtSelectionName2.Name = "TxtSelectionName2"
        Me.TxtSelectionName2.Size = New System.Drawing.Size(217, 31)
        Me.TxtSelectionName2.TabIndex = 10
        '
        'TxtSelectionName
        '
        Me.TxtSelectionName.Location = New System.Drawing.Point(163, 54)
        Me.TxtSelectionName.Name = "TxtSelectionName"
        Me.TxtSelectionName.Size = New System.Drawing.Size(217, 31)
        Me.TxtSelectionName.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Selection Name EN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Selection Name:"
        '
        'ComboBoxCateSelectionNameDetail
        '
        Me.ComboBoxCateSelectionNameDetail.FormattingEnabled = True
        Me.ComboBoxCateSelectionNameDetail.Location = New System.Drawing.Point(163, 13)
        Me.ComboBoxCateSelectionNameDetail.Name = "ComboBoxCateSelectionNameDetail"
        Me.ComboBoxCateSelectionNameDetail.Size = New System.Drawing.Size(217, 32)
        Me.ComboBoxCateSelectionNameDetail.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Category Selection :"
        '
        'TxtCateSelection
        '
        Me.TxtCateSelection.Location = New System.Drawing.Point(164, 19)
        Me.TxtCateSelection.Name = "TxtCateSelection"
        Me.TxtCateSelection.ReadOnly = True
        Me.TxtCateSelection.Size = New System.Drawing.Size(131, 25)
        Me.TxtCateSelection.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Category Selection :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(752, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.BtnClose.Location = New System.Drawing.Point(701, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(51, 50)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(7, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ตัวเลือก"
        '
        'FrmAddCategorySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddCategorySelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGDataCateSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DgSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSrc As Button
    Friend WithEvents TxtSrc As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGDataCateSelection As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCateSelectName2 As TextBox
    Friend WithEvents TxtCateSelectName As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ComboBoxSelection As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DgSelection As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtCateSelection As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxCateSelectionNameDetail As ComboBox
    Friend WithEvents BtnDeleteSelection As Button
    Friend WithEvents BtnSaveSelection As Button
    Friend WithEvents BtnAddSelection As Button
    Friend WithEvents TxtSelectionName2 As TextBox
    Friend WithEvents TxtSelectionName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ชื่อหมวดหมู่ As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents SelectionName As DataGridViewTextBoxColumn
    Friend WithEvents Selectionid As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label8 As Label
End Class
