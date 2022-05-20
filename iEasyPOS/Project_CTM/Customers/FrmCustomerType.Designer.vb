<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerType
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridViewShowData = New System.Windows.Forms.DataGridView()
        Me.ประเภทลูกค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustype = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.DataGridViewShowData)
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 442)
        Me.Panel1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnSearch.Location = New System.Drawing.Point(230, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 31)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(15, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ประเภทลูกค้า :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(19, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(190, 26)
        Me.txtSearch.TabIndex = 2
        '
        'DataGridViewShowData
        '
        Me.DataGridViewShowData.AllowUserToAddRows = False
        Me.DataGridViewShowData.AllowUserToDeleteRows = False
        Me.DataGridViewShowData.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ประเภทลูกค้า, Me.CustypeId})
        Me.DataGridViewShowData.Location = New System.Drawing.Point(0, 87)
        Me.DataGridViewShowData.Name = "DataGridViewShowData"
        Me.DataGridViewShowData.ReadOnly = True
        Me.DataGridViewShowData.RowHeadersVisible = False
        Me.DataGridViewShowData.Size = New System.Drawing.Size(324, 354)
        Me.DataGridViewShowData.TabIndex = 0
        '
        'ประเภทลูกค้า
        '
        Me.ประเภทลูกค้า.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ประเภทลูกค้า.HeaderText = "ประเภทลูกค้า"
        Me.ประเภทลูกค้า.Name = "ประเภทลูกค้า"
        Me.ประเภทลูกค้า.ReadOnly = True
        '
        'CustypeId
        '
        Me.CustypeId.HeaderText = "CustypeId"
        Me.CustypeId.Name = "CustypeId"
        Me.CustypeId.ReadOnly = True
        Me.CustypeId.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCustype)
        Me.Panel2.Location = New System.Drawing.Point(339, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 442)
        Me.Panel2.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnClear.Location = New System.Drawing.Point(118, 132)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 31)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "เพิ่ม"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnSave.Location = New System.Drawing.Point(234, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnDel.Location = New System.Drawing.Point(33, 132)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(79, 31)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ประเภทลูกค้า :"
        '
        'txtCustype
        '
        Me.txtCustype.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtCustype.Location = New System.Drawing.Point(133, 59)
        Me.txtCustype.Name = "txtCustype"
        Me.txtCustype.Size = New System.Drawing.Size(180, 31)
        Me.txtCustype.TabIndex = 0
        '
        'FrmCustomerType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCustomerType"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewShowData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewShowData As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustype As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents ประเภทลูกค้า As DataGridViewTextBoxColumn
    Friend WithEvents CustypeId As DataGridViewTextBoxColumn
End Class
