<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsePoint
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewUseItemPoint = New System.Windows.Forms.DataGridView()
        Me.ชื่อสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.แต้ม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.แต้มรวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtTotalPoint = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelItemPoint = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomerName = New System.Windows.Forms.Label()
        Me.txtMemberNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCustomerPoint = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveUsePointItem = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewUseItemPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridViewUseItemPoint)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(374, 392)
        Me.Panel4.TabIndex = 7
        '
        'DataGridViewUseItemPoint
        '
        Me.DataGridViewUseItemPoint.AllowUserToAddRows = False
        Me.DataGridViewUseItemPoint.AllowUserToDeleteRows = False
        Me.DataGridViewUseItemPoint.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewUseItemPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUseItemPoint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ชื่อสินค้า, Me.จำนวน, Me.แต้ม, Me.แต้มรวม, Me.UseItemId})
        Me.DataGridViewUseItemPoint.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewUseItemPoint.Name = "DataGridViewUseItemPoint"
        Me.DataGridViewUseItemPoint.ReadOnly = True
        Me.DataGridViewUseItemPoint.RowHeadersVisible = False
        Me.DataGridViewUseItemPoint.Size = New System.Drawing.Size(368, 386)
        Me.DataGridViewUseItemPoint.TabIndex = 2
        '
        'ชื่อสินค้า
        '
        Me.ชื่อสินค้า.HeaderText = "ชื่อสินค้า"
        Me.ชื่อสินค้า.Name = "ชื่อสินค้า"
        Me.ชื่อสินค้า.ReadOnly = True
        Me.ชื่อสินค้า.Width = 140
        '
        'จำนวน
        '
        Me.จำนวน.HeaderText = "จำนวน"
        Me.จำนวน.Name = "จำนวน"
        Me.จำนวน.ReadOnly = True
        Me.จำนวน.Width = 80
        '
        'แต้ม
        '
        Me.แต้ม.HeaderText = "แต้ม"
        Me.แต้ม.Name = "แต้ม"
        Me.แต้ม.ReadOnly = True
        Me.แต้ม.Width = 80
        '
        'แต้มรวม
        '
        Me.แต้มรวม.HeaderText = "แต้มรวม"
        Me.แต้มรวม.Name = "แต้มรวม"
        Me.แต้มรวม.ReadOnly = True
        Me.แต้มรวม.Width = 80
        '
        'UseItemId
        '
        Me.UseItemId.HeaderText = "UseItemId"
        Me.UseItemId.Name = "UseItemId"
        Me.UseItemId.ReadOnly = True
        Me.UseItemId.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(518, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(12, 410)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(374, 56)
        Me.Panel3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(55, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "แต้มที่ใช้"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtTotalPoint)
        Me.Panel5.Location = New System.Drawing.Point(181, 7)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(187, 56)
        Me.Panel5.TabIndex = 2
        '
        'txtTotalPoint
        '
        Me.txtTotalPoint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalPoint.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTotalPoint.Enabled = False
        Me.txtTotalPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalPoint.Location = New System.Drawing.Point(0, 0)
        Me.txtTotalPoint.Name = "txtTotalPoint"
        Me.txtTotalPoint.Size = New System.Drawing.Size(187, 37)
        Me.txtTotalPoint.TabIndex = 4
        Me.txtTotalPoint.Text = "0.00"
        Me.txtTotalPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.FlowLayoutPanelItemPoint)
        Me.Panel2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(389, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 293)
        Me.Panel2.TabIndex = 5
        '
        'FlowLayoutPanelItemPoint
        '
        Me.FlowLayoutPanelItemPoint.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanelItemPoint.Name = "FlowLayoutPanelItemPoint"
        Me.FlowLayoutPanelItemPoint.Size = New System.Drawing.Size(592, 285)
        Me.FlowLayoutPanelItemPoint.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCustomerName)
        Me.Panel1.Controls.Add(Me.txtMemberNo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(389, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 96)
        Me.Panel1.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.AutoSize = True
        Me.txtCustomerName.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtCustomerName.Location = New System.Drawing.Point(61, 60)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(13, 24)
        Me.txtCustomerName.TabIndex = 4
        Me.txtCustomerName.Text = "."
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AutoSize = True
        Me.txtMemberNo.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtMemberNo.Location = New System.Drawing.Point(61, 15)
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(13, 24)
        Me.txtMemberNo.TabIndex = 3
        Me.txtMemberNo.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ชื่อ :"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtCustomerPoint)
        Me.Panel6.Location = New System.Drawing.Point(384, 28)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 52)
        Me.Panel6.TabIndex = 1
        '
        'txtCustomerPoint
        '
        Me.txtCustomerPoint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerPoint.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCustomerPoint.Enabled = False
        Me.txtCustomerPoint.Font = New System.Drawing.Font("Kanit", 24.0!, System.Drawing.FontStyle.Bold)
        Me.txtCustomerPoint.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomerPoint.Name = "txtCustomerPoint"
        Me.txtCustomerPoint.Size = New System.Drawing.Size(200, 48)
        Me.txtCustomerPoint.TabIndex = 5
        Me.txtCustomerPoint.Text = "0.00"
        Me.txtCustomerPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัส :"
        '
        'btnSaveUsePointItem
        '
        Me.btnSaveUsePointItem.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.btnSaveUsePointItem.Location = New System.Drawing.Point(870, 420)
        Me.btnSaveUsePointItem.Name = "btnSaveUsePointItem"
        Me.btnSaveUsePointItem.Size = New System.Drawing.Size(117, 40)
        Me.btnSaveUsePointItem.TabIndex = 8
        Me.btnSaveUsePointItem.Text = "ตกลง"
        Me.btnSaveUsePointItem.UseVisualStyleBackColor = True
        '
        'FrmUsePoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 473)
        Me.Controls.Add(Me.btnSaveUsePointItem)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsePoint"
        Me.Text = "FrmUsePoint"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridViewUseItemPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewUseItemPoint As DataGridView
    Friend WithEvents ชื่อสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents จำนวน As DataGridViewTextBoxColumn
    Friend WithEvents แต้ม As DataGridViewTextBoxColumn
    Friend WithEvents แต้มรวม As DataGridViewTextBoxColumn
    Friend WithEvents UseItemId As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtTotalPoint As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanelItemPoint As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtCustomerPoint As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerName As Label
    Friend WithEvents txtMemberNo As Label
    Friend WithEvents btnSaveUsePointItem As Button
End Class
