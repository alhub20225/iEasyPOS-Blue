<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtUnitName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dg_ItemUnit = New System.Windows.Forms.DataGridView()
        Me.UnitId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtUnitName
        '
        Me.TxtUnitName.Location = New System.Drawing.Point(122, 22)
        Me.TxtUnitName.Name = "TxtUnitName"
        Me.TxtUnitName.Size = New System.Drawing.Size(207, 31)
        Me.TxtUnitName.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(254, 105)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 32)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "หน่วย :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ตัวคูณ :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dg_ItemUnit)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 456)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Dg_ItemUnit
        '
        Me.Dg_ItemUnit.AllowUserToAddRows = False
        Me.Dg_ItemUnit.AllowUserToDeleteRows = False
        Me.Dg_ItemUnit.AllowUserToResizeRows = False
        Me.Dg_ItemUnit.BackgroundColor = System.Drawing.Color.White
        Me.Dg_ItemUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_ItemUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnitId, Me.UnitName, Me.UnitValue})
        Me.Dg_ItemUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_ItemUnit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_ItemUnit.Location = New System.Drawing.Point(3, 27)
        Me.Dg_ItemUnit.Name = "Dg_ItemUnit"
        Me.Dg_ItemUnit.RowHeadersVisible = False
        Me.Dg_ItemUnit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_ItemUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_ItemUnit.Size = New System.Drawing.Size(438, 426)
        Me.Dg_ItemUnit.TabIndex = 0
        '
        'UnitId
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UnitId.DefaultCellStyle = DataGridViewCellStyle1
        Me.UnitId.HeaderText = "ลำดับ"
        Me.UnitId.Name = "UnitId"
        '
        'UnitName
        '
        Me.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UnitName.HeaderText = "หน่วย"
        Me.UnitName.Name = "UnitName"
        '
        'UnitValue
        '
        Me.UnitValue.HeaderText = "ตัวคูณ"
        Me.UnitValue.Name = "UnitValue"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtUnit)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TxtUnitName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 157)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'TxtUnit
        '
        Me.TxtUnit.Location = New System.Drawing.Point(122, 62)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.Size = New System.Drawing.Size(207, 31)
        Me.TxtUnit.TabIndex = 7
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(122, 105)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 32)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "เพิ่ม"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'FrmUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 643)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmUnit"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dg_ItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtUnitName As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Dg_ItemUnit As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtUnit As TextBox
    Friend WithEvents UnitId As DataGridViewTextBoxColumn
    Friend WithEvents UnitName As DataGridViewTextBoxColumn
    Friend WithEvents UnitValue As DataGridViewTextBoxColumn
End Class
