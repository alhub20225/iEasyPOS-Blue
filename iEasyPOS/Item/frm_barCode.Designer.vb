<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_barCode
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
        Me.btnAddTo = New DevExpress.XtraEditors.CheckButton()
        Me.GroupBoxItem = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemCode = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtItemName = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkAllItemByCategory = New DevExpress.XtraEditors.CheckEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkAllItem = New DevExpress.XtraEditors.CheckEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridItem = New System.Windows.Forms.DataGridView()
        Me.barcode = New System.Windows.Forms.DataGridViewImageColumn()
        Me.itemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevExpress.XtraEditors.CheckButton()
        Me.btnCancel = New DevExpress.XtraEditors.CheckButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllItemByCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAddTo)
        Me.Panel1.Controls.Add(Me.GroupBoxItem)
        Me.Panel1.Controls.Add(Me.chkAllItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 241)
        Me.Panel1.TabIndex = 0
        '
        'btnAddTo
        '
        Me.btnAddTo.Location = New System.Drawing.Point(792, 181)
        Me.btnAddTo.Name = "btnAddTo"
        Me.btnAddTo.Size = New System.Drawing.Size(96, 43)
        Me.btnAddTo.TabIndex = 268
        Me.btnAddTo.Text = "เพิ่ม"
        '
        'GroupBoxItem
        '
        Me.GroupBoxItem.Controls.Add(Me.GroupBox1)
        Me.GroupBoxItem.Controls.Add(Me.chkAllItemByCategory)
        Me.GroupBoxItem.Controls.Add(Me.Label3)
        Me.GroupBoxItem.Controls.Add(Me.cbbCategory)
        Me.GroupBoxItem.Enabled = False
        Me.GroupBoxItem.Location = New System.Drawing.Point(29, 57)
        Me.GroupBoxItem.Name = "GroupBoxItem"
        Me.GroupBoxItem.Size = New System.Drawing.Size(757, 167)
        Me.GroupBoxItem.TabIndex = 267
        Me.GroupBoxItem.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(15, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(719, 79)
        Me.GroupBox1.TabIndex = 268
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(6, 35)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtItemCode.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtItemCode.Properties.Appearance.Options.UseFont = True
        Me.txtItemCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItemCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "รหัส"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "ชื่อ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtItemCode.Properties.NullText = ""
        Me.txtItemCode.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.txtItemCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtItemCode.Size = New System.Drawing.Size(223, 30)
        Me.txtItemCode.TabIndex = 262
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(244, 35)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtItemName.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Properties.Appearance.Options.UseBackColor = True
        Me.txtItemName.Properties.Appearance.Options.UseFont = True
        Me.txtItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItemName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "รหัส"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "ชื่อ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.txtItemName.Properties.NullText = ""
        Me.txtItemName.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.txtItemName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtItemName.Size = New System.Drawing.Size(463, 30)
        Me.txtItemName.TabIndex = 263
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'chkAllItemByCategory
        '
        Me.chkAllItemByCategory.EditValue = True
        Me.chkAllItemByCategory.Location = New System.Drawing.Point(259, 36)
        Me.chkAllItemByCategory.Name = "chkAllItemByCategory"
        Me.chkAllItemByCategory.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllItemByCategory.Properties.Appearance.Options.UseFont = True
        Me.chkAllItemByCategory.Properties.Caption = "สินค้าทั้งหมดในหมวดหมู่"
        Me.chkAllItemByCategory.Size = New System.Drawing.Size(218, 28)
        Me.chkAllItemByCategory.TabIndex = 267
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "หมวดหมู่"
        '
        'cbbCategory
        '
        Me.cbbCategory.Location = New System.Drawing.Point(21, 38)
        Me.cbbCategory.Name = "cbbCategory"
        Me.cbbCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbCategory.Properties.Appearance.Options.UseFont = True
        Me.cbbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbCategory.Properties.NullText = ""
        Me.cbbCategory.Properties.PopupSizeable = False
        Me.cbbCategory.Size = New System.Drawing.Size(223, 26)
        Me.cbbCategory.TabIndex = 265
        '
        'chkAllItem
        '
        Me.chkAllItem.EditValue = True
        Me.chkAllItem.Location = New System.Drawing.Point(29, 23)
        Me.chkAllItem.Name = "chkAllItem"
        Me.chkAllItem.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllItem.Properties.Appearance.Options.UseFont = True
        Me.chkAllItem.Properties.Caption = "สินค้าทั้งหมด"
        Me.chkAllItem.Size = New System.Drawing.Size(127, 28)
        Me.chkAllItem.TabIndex = 266
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridItem)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 349)
        Me.Panel2.TabIndex = 1
        '
        'DataGridItem
        '
        Me.DataGridItem.AllowUserToAddRows = False
        Me.DataGridItem.AllowUserToDeleteRows = False
        Me.DataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barcode, Me.itemCode, Me.itemName, Me.itemid})
        Me.DataGridItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridItem.Location = New System.Drawing.Point(0, 0)
        Me.DataGridItem.Name = "DataGridItem"
        Me.DataGridItem.ReadOnly = True
        Me.DataGridItem.RowHeadersVisible = False
        Me.DataGridItem.Size = New System.Drawing.Size(917, 349)
        Me.DataGridItem.TabIndex = 0
        '
        'barcode
        '
        Me.barcode.HeaderText = "image"
        Me.barcode.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.Width = 200
        '
        'itemCode
        '
        Me.itemCode.HeaderText = "รหัสสินค้า"
        Me.itemCode.Name = "itemCode"
        Me.itemCode.ReadOnly = True
        '
        'itemName
        '
        Me.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemName.HeaderText = "ชื่อสินค้า"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        '
        'itemid
        '
        Me.itemid.HeaderText = "itemid"
        Me.itemid.Name = "itemid"
        Me.itemid.ReadOnly = True
        Me.itemid.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 590)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(917, 76)
        Me.Panel3.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(792, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 43)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "พิมพ์"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(679, 21)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 43)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "ยกเลิก"
        '
        'PrintDocument1
        '
        '
        'frm_barCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 666)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_barCode"
        Me.Text = "frm_barCode"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxItem.ResumeLayout(False)
        Me.GroupBoxItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllItemByCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtItemCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxItem As GroupBox
    Friend WithEvents chkAllItem As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbbCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.CheckButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkAllItemByCategory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataGridItem As DataGridView
    Friend WithEvents btnAddTo As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.CheckButton
    Friend WithEvents barcode As DataGridViewImageColumn
    Friend WithEvents itemCode As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents itemid As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
