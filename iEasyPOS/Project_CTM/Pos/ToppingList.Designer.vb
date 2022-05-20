<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToppingList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.RichTextBoxSelection = New System.Windows.Forms.RichTextBox()
        Me.DataGridViewItemTopping = New System.Windows.Forms.DataGridView()
        Me.Topping = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToppingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToppingId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selecttion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Flow_Topping = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Flow_Selection = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewItemTopping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.RichTextBoxSelection)
        Me.Panel1.Controls.Add(Me.DataGridViewItemTopping)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.Flow_Topping)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Flow_Selection)
        Me.Panel1.Location = New System.Drawing.Point(7, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.Panel1.Size = New System.Drawing.Size(888, 622)
        Me.Panel1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(734, 561)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 48)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "ไม่เพิ่ม Topping"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RichTextBoxSelection
        '
        Me.RichTextBoxSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxSelection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBoxSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxSelection.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.RichTextBoxSelection.Location = New System.Drawing.Point(415, 462)
        Me.RichTextBoxSelection.Name = "RichTextBoxSelection"
        Me.RichTextBoxSelection.Size = New System.Drawing.Size(460, 93)
        Me.RichTextBoxSelection.TabIndex = 0
        Me.RichTextBoxSelection.Text = ""
        '
        'DataGridViewItemTopping
        '
        Me.DataGridViewItemTopping.AllowUserToAddRows = False
        Me.DataGridViewItemTopping.AllowUserToDeleteRows = False
        Me.DataGridViewItemTopping.AllowUserToResizeColumns = False
        Me.DataGridViewItemTopping.AllowUserToResizeRows = False
        Me.DataGridViewItemTopping.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewItemTopping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewItemTopping.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewItemTopping.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewItemTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItemTopping.ColumnHeadersVisible = False
        Me.DataGridViewItemTopping.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Topping, Me.ToppingPrice, Me.ToppingId, Me.Selecttion, Me.DetailItemId})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewItemTopping.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewItemTopping.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewItemTopping.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewItemTopping.Location = New System.Drawing.Point(10, 462)
        Me.DataGridViewItemTopping.Name = "DataGridViewItemTopping"
        Me.DataGridViewItemTopping.ReadOnly = True
        Me.DataGridViewItemTopping.RowHeadersVisible = False
        Me.DataGridViewItemTopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewItemTopping.Size = New System.Drawing.Size(399, 147)
        Me.DataGridViewItemTopping.TabIndex = 3
        '
        'Topping
        '
        Me.Topping.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Topping.HeaderText = "รายการ"
        Me.Topping.Name = "Topping"
        Me.Topping.ReadOnly = True
        '
        'ToppingPrice
        '
        Me.ToppingPrice.HeaderText = "ราคา"
        Me.ToppingPrice.Name = "ToppingPrice"
        Me.ToppingPrice.ReadOnly = True
        Me.ToppingPrice.Width = 114
        '
        'ToppingId
        '
        Me.ToppingId.HeaderText = "ToppingId"
        Me.ToppingId.Name = "ToppingId"
        Me.ToppingId.ReadOnly = True
        Me.ToppingId.Visible = False
        '
        'Selecttion
        '
        Me.Selecttion.HeaderText = "Selecttion"
        Me.Selecttion.Name = "Selecttion"
        Me.Selecttion.ReadOnly = True
        Me.Selecttion.Visible = False
        '
        'DetailItemId
        '
        Me.DetailItemId.HeaderText = "DetailItemId"
        Me.DetailItemId.Name = "DetailItemId"
        Me.DetailItemId.ReadOnly = True
        Me.DetailItemId.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.btnDel.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDel.Location = New System.Drawing.Point(415, 561)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(108, 48)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "ลบรายการ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Flow_Topping
        '
        Me.Flow_Topping.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Flow_Topping.Location = New System.Drawing.Point(10, 51)
        Me.Flow_Topping.Name = "Flow_Topping"
        Me.Flow_Topping.Size = New System.Drawing.Size(417, 396)
        Me.Flow_Topping.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(868, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รายการ Topping"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Kanit SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(565, 561)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 48)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "ตกลง"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Flow_Selection
        '
        Me.Flow_Selection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Flow_Selection.Location = New System.Drawing.Point(433, 51)
        Me.Flow_Selection.Name = "Flow_Selection"
        Me.Flow_Selection.Size = New System.Drawing.Size(442, 396)
        Me.Flow_Selection.TabIndex = 4
        '
        'ToppingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 688)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ToppingList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewItemTopping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBoxSelection As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Flow_Topping As FlowLayoutPanel
    Friend WithEvents DataGridViewItemTopping As DataGridView
    Friend WithEvents Flow_Selection As FlowLayoutPanel
    Friend WithEvents Topping As DataGridViewTextBoxColumn
    Friend WithEvents ToppingPrice As DataGridViewTextBoxColumn
    Friend WithEvents ToppingId As DataGridViewTextBoxColumn
    Friend WithEvents Selecttion As DataGridViewTextBoxColumn
    Friend WithEvents DetailItemId As DataGridViewTextBoxColumn
    Friend WithEvents btnDel As Button
End Class
