<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditTableChair
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
        Me.เก้าอี้ = New System.Windows.Forms.GroupBox()
        Me.DgChair = New System.Windows.Forms.DataGridView()
        Me.ชื่อ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericChair = New System.Windows.Forms.NumericUpDown()
        Me.BtnAddChair = New System.Windows.Forms.Button()
        Me.BtnDeleteChair = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAddTable = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTableName = New System.Windows.Forms.TextBox()
        Me.TxtZoneName = New System.Windows.Forms.TextBox()
        Me.เก้าอี้.SuspendLayout()
        CType(Me.DgChair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericChair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'เก้าอี้
        '
        Me.เก้าอี้.Controls.Add(Me.DgChair)
        Me.เก้าอี้.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.เก้าอี้.Location = New System.Drawing.Point(54, 118)
        Me.เก้าอี้.Name = "เก้าอี้"
        Me.เก้าอี้.Size = New System.Drawing.Size(264, 337)
        Me.เก้าอี้.TabIndex = 0
        Me.เก้าอี้.TabStop = False
        Me.เก้าอี้.Text = "เก้าอี้"
        '
        'DgChair
        '
        Me.DgChair.AllowUserToAddRows = False
        Me.DgChair.AllowUserToResizeColumns = False
        Me.DgChair.AllowUserToResizeRows = False
        Me.DgChair.BackgroundColor = System.Drawing.Color.White
        Me.DgChair.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgChair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgChair.ColumnHeadersVisible = False
        Me.DgChair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อ})
        Me.DgChair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgChair.EnableHeadersVisualStyles = False
        Me.DgChair.Location = New System.Drawing.Point(3, 35)
        Me.DgChair.Name = "DgChair"
        Me.DgChair.RowHeadersVisible = False
        Me.DgChair.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgChair.Size = New System.Drawing.Size(258, 299)
        Me.DgChair.TabIndex = 0
        '
        'ชื่อ
        '
        Me.ชื่อ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อ.HeaderText = "ชื่อ"
        Me.ชื่อ.Name = "ชื่อ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericChair)
        Me.GroupBox2.Controls.Add(Me.BtnAddChair)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จำนวนที่นั่ง"
        '
        'NumericChair
        '
        Me.NumericChair.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumericChair.Location = New System.Drawing.Point(19, 50)
        Me.NumericChair.Name = "NumericChair"
        Me.NumericChair.Size = New System.Drawing.Size(103, 33)
        Me.NumericChair.TabIndex = 5
        Me.NumericChair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddChair
        '
        Me.BtnAddChair.Location = New System.Drawing.Point(155, 46)
        Me.BtnAddChair.Name = "BtnAddChair"
        Me.BtnAddChair.Size = New System.Drawing.Size(95, 40)
        Me.BtnAddChair.TabIndex = 4
        Me.BtnAddChair.Text = "เพิ่ม"
        Me.BtnAddChair.UseVisualStyleBackColor = True
        '
        'BtnDeleteChair
        '
        Me.BtnDeleteChair.Font = New System.Drawing.Font("Kanit", 15.0!)
        Me.BtnDeleteChair.Location = New System.Drawing.Point(381, 414)
        Me.BtnDeleteChair.Name = "BtnDeleteChair"
        Me.BtnDeleteChair.Size = New System.Drawing.Size(75, 41)
        Me.BtnDeleteChair.TabIndex = 5
        Me.BtnDeleteChair.Text = "ลบ"
        Me.BtnDeleteChair.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Kanit", 15.0!)
        Me.BtnCancel.Location = New System.Drawing.Point(641, 414)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 41)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "ยกเลิก"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAddTable
        '
        Me.BtnAddTable.Font = New System.Drawing.Font("Kanit", 15.0!)
        Me.BtnAddTable.Location = New System.Drawing.Point(522, 414)
        Me.BtnAddTable.Name = "BtnAddTable"
        Me.BtnAddTable.Size = New System.Drawing.Size(75, 41)
        Me.BtnAddTable.TabIndex = 5
        Me.BtnAddTable.Text = "บันทึก"
        Me.BtnAddTable.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "EDIT TABLE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 59)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Zone :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(343, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ชื่อโต๊ะ :"
        '
        'TxtTableName
        '
        Me.TxtTableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtTableName.Location = New System.Drawing.Point(445, 68)
        Me.TxtTableName.Name = "TxtTableName"
        Me.TxtTableName.Size = New System.Drawing.Size(191, 31)
        Me.TxtTableName.TabIndex = 9
        '
        'TxtZoneName
        '
        Me.TxtZoneName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtZoneName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtZoneName.Location = New System.Drawing.Point(153, 71)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.ReadOnly = True
        Me.TxtZoneName.Size = New System.Drawing.Size(99, 24)
        Me.TxtZoneName.TabIndex = 8
        '
        'FrmEditTableChair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTableName)
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAddTable)
        Me.Controls.Add(Me.BtnDeleteChair)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.เก้าอี้)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEditTableChair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.เก้าอี้.ResumeLayout(False)
        CType(Me.DgChair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumericChair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents เก้าอี้ As GroupBox
    Friend WithEvents DgChair As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDeleteChair As Button
    Friend WithEvents BtnAddChair As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnAddTable As Button
    Friend WithEvents NumericChair As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTableName As TextBox
    Friend WithEvents TxtZoneName As TextBox
    Friend WithEvents ชื่อ As DataGridViewTextBoxColumn
End Class
