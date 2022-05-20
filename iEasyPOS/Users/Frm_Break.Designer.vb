<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Break
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnAddBreak = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtBreak = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.DataGridView_Break = New System.Windows.Forms.DataGridView()
        Me.Panel102 = New System.Windows.Forms.Panel()
        Me.Panel101 = New System.Windows.Forms.Panel()
        Me.Panel100 = New System.Windows.Forms.Panel()
        Me.Panel99 = New System.Windows.Forms.Panel()
        Me.ComboBoxBreakActive = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.IdStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เวลาพัก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel68.SuspendLayout()
        Me.Panel41.SuspendLayout()
        CType(Me.DataGridView_Break, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxBreakActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel68
        '
        Me.Panel68.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel68.Controls.Add(Me.Button26)
        Me.Panel68.Controls.Add(Me.Panel69)
        Me.Panel68.Controls.Add(Me.Label34)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(539, 43)
        Me.Panel68.TabIndex = 339
        '
        'Button26
        '
        Me.Button26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button26.BackColor = System.Drawing.Color.Transparent
        Me.Button26.BackgroundImage = Global.iEasyPOS.My.Resources.Resources.Icon_CloseWindowsWhite
        Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.ForeColor = System.Drawing.Color.White
        Me.Button26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button26.Location = New System.Drawing.Point(501, 5)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(32, 32)
        Me.Button26.TabIndex = 19
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(539, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(20, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(73, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "เวลาพัก"
        '
        'btnAddBreak
        '
        Me.btnAddBreak.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBreak.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAddBreak.Appearance.Options.UseFont = True
        Me.btnAddBreak.Appearance.Options.UseForeColor = True
        Me.btnAddBreak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBreak.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_SaveWhite
        Me.btnAddBreak.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAddBreak.Location = New System.Drawing.Point(382, 386)
        Me.btnAddBreak.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAddBreak.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btnAddBreak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAddBreak.Name = "btnAddBreak"
        Me.btnAddBreak.Size = New System.Drawing.Size(125, 33)
        Me.btnAddBreak.TabIndex = 361
        Me.btnAddBreak.Text = "บันทึก"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(277, 120)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(196, 1)
        Me.Panel4.TabIndex = 360
        '
        'txtBreak
        '
        Me.txtBreak.BackColor = System.Drawing.Color.White
        Me.txtBreak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBreak.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBreak.ForeColor = System.Drawing.Color.Black
        Me.txtBreak.Location = New System.Drawing.Point(37, 91)
        Me.txtBreak.Name = "txtBreak"
        Me.txtBreak.Size = New System.Drawing.Size(221, 24)
        Me.txtBreak.TabIndex = 355
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 356
        Me.Label2.Text = "เวลาพัก"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(35, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 1)
        Me.Panel2.TabIndex = 357
        '
        'Panel41
        '
        Me.Panel41.Controls.Add(Me.DataGridView_Break)
        Me.Panel41.Controls.Add(Me.Panel102)
        Me.Panel41.Controls.Add(Me.Panel101)
        Me.Panel41.Controls.Add(Me.Panel100)
        Me.Panel41.Controls.Add(Me.Panel99)
        Me.Panel41.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Panel41.Location = New System.Drawing.Point(30, 146)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(477, 224)
        Me.Panel41.TabIndex = 354
        '
        'DataGridView_Break
        '
        Me.DataGridView_Break.AllowUserToAddRows = False
        Me.DataGridView_Break.AllowUserToDeleteRows = False
        Me.DataGridView_Break.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DataGridView_Break.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridView_Break.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Break.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_Break.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView_Break.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Break.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridView_Break.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Break.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.เวลาพัก})
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Break.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridView_Break.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Break.EnableHeadersVisualStyles = False
        Me.DataGridView_Break.GridColor = System.Drawing.Color.White
        Me.DataGridView_Break.Location = New System.Drawing.Point(1, 1)
        Me.DataGridView_Break.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Break.MultiSelect = False
        Me.DataGridView_Break.Name = "DataGridView_Break"
        Me.DataGridView_Break.ReadOnly = True
        Me.DataGridView_Break.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Break.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView_Break.RowHeadersVisible = False
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Kanit", 11.25!)
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.DataGridView_Break.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridView_Break.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView_Break.Size = New System.Drawing.Size(475, 222)
        Me.DataGridView_Break.TabIndex = 3
        '
        'Panel102
        '
        Me.Panel102.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel102.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel102.Location = New System.Drawing.Point(1, 223)
        Me.Panel102.Name = "Panel102"
        Me.Panel102.Size = New System.Drawing.Size(475, 1)
        Me.Panel102.TabIndex = 296
        '
        'Panel101
        '
        Me.Panel101.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel101.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel101.Location = New System.Drawing.Point(1, 0)
        Me.Panel101.Name = "Panel101"
        Me.Panel101.Size = New System.Drawing.Size(475, 1)
        Me.Panel101.TabIndex = 295
        '
        'Panel100
        '
        Me.Panel100.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel100.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel100.Location = New System.Drawing.Point(476, 0)
        Me.Panel100.Name = "Panel100"
        Me.Panel100.Size = New System.Drawing.Size(1, 224)
        Me.Panel100.TabIndex = 294
        '
        'Panel99
        '
        Me.Panel99.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel99.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel99.Location = New System.Drawing.Point(0, 0)
        Me.Panel99.Name = "Panel99"
        Me.Panel99.Size = New System.Drawing.Size(1, 224)
        Me.Panel99.TabIndex = 293
        '
        'ComboBoxBreakActive
        '
        Me.ComboBoxBreakActive.EditValue = ""
        Me.ComboBoxBreakActive.Location = New System.Drawing.Point(281, 89)
        Me.ComboBoxBreakActive.Name = "ComboBoxBreakActive"
        Me.ComboBoxBreakActive.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBreakActive.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxBreakActive.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxBreakActive.Properties.Appearance.Options.UseForeColor = True
        Me.ComboBoxBreakActive.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ComboBoxBreakActive.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxBreakActive.Properties.Items.AddRange(New Object() {"เปิด", "ปิด"})
        Me.ComboBoxBreakActive.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxBreakActive.Size = New System.Drawing.Size(187, 28)
        Me.ComboBoxBreakActive.TabIndex = 362
        '
        'IdStatus
        '
        Me.IdStatus.BackColor = System.Drawing.Color.White
        Me.IdStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IdStatus.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdStatus.ForeColor = System.Drawing.Color.Gray
        Me.IdStatus.Location = New System.Drawing.Point(486, 97)
        Me.IdStatus.Name = "IdStatus"
        Me.IdStatus.Size = New System.Drawing.Size(21, 24)
        Me.IdStatus.TabIndex = 364
        Me.IdStatus.Text = "1"
        Me.IdStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IdStatus.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(273, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "สถานะ"
        '
        'Id
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Id.DefaultCellStyle = DataGridViewCellStyle24
        Me.Id.HeaderText = "ลำดับ"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'เวลาพัก
        '
        Me.เวลาพัก.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.เวลาพัก.DefaultCellStyle = DataGridViewCellStyle25
        Me.เวลาพัก.HeaderText = "เวลาพัก"
        Me.เวลาพัก.Name = "เวลาพัก"
        Me.เวลาพัก.ReadOnly = True
        '
        'Frm_Break
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(539, 449)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdStatus)
        Me.Controls.Add(Me.ComboBoxBreakActive)
        Me.Controls.Add(Me.btnAddBreak)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtBreak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel41)
        Me.Controls.Add(Me.Panel68)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Break"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เวลาพัก"
        Me.Panel68.ResumeLayout(False)
        Me.Panel68.PerformLayout()
        Me.Panel41.ResumeLayout(False)
        CType(Me.DataGridView_Break, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxBreakActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents btnAddBreak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtBreak As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel41 As Panel
    Friend WithEvents DataGridView_Break As DataGridView
    Friend WithEvents Panel102 As Panel
    Friend WithEvents Panel101 As Panel
    Friend WithEvents Panel100 As Panel
    Friend WithEvents Panel99 As Panel
    Friend WithEvents ComboBoxBreakActive As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents IdStatus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents เวลาพัก As DataGridViewTextBoxColumn
End Class
