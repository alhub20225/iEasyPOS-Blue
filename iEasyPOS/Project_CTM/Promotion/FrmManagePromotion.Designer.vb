<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManagePromotion
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
        Me.DataGridViewShowPromotion = New System.Windows.Forms.DataGridView()
        Me.Point = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddItemPoint = New System.Windows.Forms.Button()
        Me.ComboBoxSelectCategory = New System.Windows.Forms.ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewShowItem = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewItemPromotion = New System.Windows.Forms.DataGridView()
        Me.ItemPointRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPointDateStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPointDateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionIds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.DataGridViewShowPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewShowItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewItemPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewShowPromotion
        '
        Me.DataGridViewShowPromotion.AllowUserToAddRows = False
        Me.DataGridViewShowPromotion.AllowUserToDeleteRows = False
        Me.DataGridViewShowPromotion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewShowPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowPromotion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Point, Me.DateStart, Me.DateEnd, Me.PromotionId})
        Me.DataGridViewShowPromotion.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewShowPromotion.Location = New System.Drawing.Point(0, 40)
        Me.DataGridViewShowPromotion.Name = "DataGridViewShowPromotion"
        Me.DataGridViewShowPromotion.ReadOnly = True
        Me.DataGridViewShowPromotion.RowHeadersVisible = False
        Me.DataGridViewShowPromotion.Size = New System.Drawing.Size(414, 261)
        Me.DataGridViewShowPromotion.TabIndex = 0
        '
        'Point
        '
        Me.Point.HeaderText = "รายการ"
        Me.Point.Name = "Point"
        Me.Point.ReadOnly = True
        Me.Point.Width = 200
        '
        'DateStart
        '
        Me.DateStart.HeaderText = "วันที่เริมใช้"
        Me.DateStart.Name = "DateStart"
        Me.DateStart.ReadOnly = True
        Me.DateStart.Width = 110
        '
        'DateEnd
        '
        Me.DateEnd.HeaderText = "วันหมดอายุ"
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.ReadOnly = True
        Me.DateEnd.Width = 110
        '
        'PromotionId
        '
        Me.PromotionId.HeaderText = "PromotionId"
        Me.PromotionId.Name = "PromotionId"
        Me.PromotionId.ReadOnly = True
        Me.PromotionId.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnDel)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.btnAddItemPoint)
        Me.Panel8.Controls.Add(Me.ComboBoxSelectCategory)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(222, 319)
        Me.Panel8.TabIndex = 4
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(17, 273)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 31)
        Me.btnDel.TabIndex = 4
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "เลือกหมวดหมู่สินค้า"
        '
        'btnAddItemPoint
        '
        Me.btnAddItemPoint.Location = New System.Drawing.Point(124, 273)
        Me.btnAddItemPoint.Name = "btnAddItemPoint"
        Me.btnAddItemPoint.Size = New System.Drawing.Size(90, 31)
        Me.btnAddItemPoint.TabIndex = 2
        Me.btnAddItemPoint.Text = "บันทึก"
        Me.btnAddItemPoint.UseVisualStyleBackColor = True
        '
        'ComboBoxSelectCategory
        '
        Me.ComboBoxSelectCategory.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.ComboBoxSelectCategory.FormattingEnabled = True
        Me.ComboBoxSelectCategory.Items.AddRange(New Object() {"ทั้งหมด"})
        Me.ComboBoxSelectCategory.Location = New System.Drawing.Point(7, 97)
        Me.ComboBoxSelectCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxSelectCategory.Name = "ComboBoxSelectCategory"
        Me.ComboBoxSelectCategory.Size = New System.Drawing.Size(203, 32)
        Me.ComboBoxSelectCategory.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(414, 40)
        Me.Panel9.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายการโปรโมชั่น"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewShowItem)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 726)
        Me.Panel2.TabIndex = 0
        '
        'DataGridViewShowItem
        '
        Me.DataGridViewShowItem.AllowUserToAddRows = False
        Me.DataGridViewShowItem.AllowUserToDeleteRows = False
        Me.DataGridViewShowItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewShowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShowItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.ItemId, Me.ItemSelect})
        Me.DataGridViewShowItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewShowItem.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewShowItem.Name = "DataGridViewShowItem"
        Me.DataGridViewShowItem.ReadOnly = True
        Me.DataGridViewShowItem.RowHeadersVisible = False
        Me.DataGridViewShowItem.Size = New System.Drawing.Size(538, 659)
        Me.DataGridViewShowItem.TabIndex = 1
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "รหัสสินค้า"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        Me.ItemCode.Width = 142
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ชื่อสินค้า"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 240
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "ItemId"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Visible = False
        '
        'ItemSelect
        '
        Me.ItemSelect.HeaderText = "เลือก"
        Me.ItemSelect.Name = "ItemSelect"
        Me.ItemSelect.ReadOnly = True
        Me.ItemSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ItemSelect.Width = 150
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Button1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 659)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(538, 67)
        Me.Panel10.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(352, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "จัดการ Promotion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridViewShowPromotion)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(228, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(414, 319)
        Me.Panel7.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1223, 726)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(581, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(642, 726)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridViewItemPromotion)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 331)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(642, 395)
        Me.Panel4.TabIndex = 2
        '
        'DataGridViewItemPromotion
        '
        Me.DataGridViewItemPromotion.AllowUserToAddRows = False
        Me.DataGridViewItemPromotion.AllowUserToDeleteRows = False
        Me.DataGridViewItemPromotion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewItemPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItemPromotion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemPointRate, Me.ItemPointDateStart, Me.ItemPointDateEnd, Me.PromotionIds})
        Me.DataGridViewItemPromotion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItemPromotion.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewItemPromotion.Name = "DataGridViewItemPromotion"
        Me.DataGridViewItemPromotion.ReadOnly = True
        Me.DataGridViewItemPromotion.RowHeadersVisible = False
        Me.DataGridViewItemPromotion.Size = New System.Drawing.Size(642, 395)
        Me.DataGridViewItemPromotion.TabIndex = 0
        '
        'ItemPointRate
        '
        Me.ItemPointRate.HeaderText = "รายการ"
        Me.ItemPointRate.Name = "ItemPointRate"
        Me.ItemPointRate.ReadOnly = True
        Me.ItemPointRate.Width = 250
        '
        'ItemPointDateStart
        '
        Me.ItemPointDateStart.HeaderText = "วันที่เริ่มใช้"
        Me.ItemPointDateStart.Name = "ItemPointDateStart"
        Me.ItemPointDateStart.ReadOnly = True
        Me.ItemPointDateStart.Width = 200
        '
        'ItemPointDateEnd
        '
        Me.ItemPointDateEnd.HeaderText = "วันหมดอายุ"
        Me.ItemPointDateEnd.Name = "ItemPointDateEnd"
        Me.ItemPointDateEnd.ReadOnly = True
        Me.ItemPointDateEnd.Width = 200
        '
        'PromotionIds
        '
        Me.PromotionIds.HeaderText = "PromotionId"
        Me.PromotionIds.Name = "PromotionIds"
        Me.PromotionIds.ReadOnly = True
        Me.PromotionIds.Visible = False
        Me.PromotionIds.Width = 150
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 319)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(642, 12)
        Me.Panel6.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(642, 319)
        Me.Panel5.TabIndex = 0
        '
        'FrmManagePromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 726)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmManagePromotion"
        Me.Text = "FrmManagePromotion"
        CType(Me.DataGridViewShowPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewShowItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridViewItemPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewShowPromotion As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddItemPoint As Button
    Friend WithEvents ComboBoxSelectCategory As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewShowItem As DataGridView
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemSelect As DataGridViewCheckBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewItemPromotion As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Point As DataGridViewTextBoxColumn
    Friend WithEvents DateStart As DataGridViewTextBoxColumn
    Friend WithEvents DateEnd As DataGridViewTextBoxColumn
    Friend WithEvents PromotionId As DataGridViewTextBoxColumn
    Friend WithEvents ItemPointRate As DataGridViewTextBoxColumn
    Friend WithEvents ItemPointDateStart As DataGridViewTextBoxColumn
    Friend WithEvents ItemPointDateEnd As DataGridViewTextBoxColumn
    Friend WithEvents PromotionIds As DataGridViewTextBoxColumn
End Class
