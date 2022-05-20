<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddTable))
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtTableName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.ComboBoxTableType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtZoneName = New System.Windows.Forms.Label()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddTable = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel67.SuspendLayout
        CType(Me.ComboBoxTableType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel67
        '
        Me.Panel67.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel67.Controls.Add(Me.Button14)
        Me.Panel67.Controls.Add(Me.Panel69)
        Me.Panel67.Controls.Add(Me.Label36)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel67.Location = New System.Drawing.Point(0, 0)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(387, 43)
        Me.Panel67.TabIndex = 313
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"),System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(349, 5)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(32, 32)
        Me.Button14.TabIndex = 19
        Me.Button14.UseVisualStyleBackColor = false
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(387, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(20, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(68, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "เพิ่มโต๊ะ"
        '
        'TxtTableName
        '
        Me.TxtTableName.BackColor = System.Drawing.Color.White
        Me.TxtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTableName.Font = New System.Drawing.Font("Kanit", 12!)
        Me.TxtTableName.ForeColor = System.Drawing.Color.Black
        Me.TxtTableName.Location = New System.Drawing.Point(37, 128)
        Me.TxtTableName.Name = "TxtTableName"
        Me.TxtTableName.Size = New System.Drawing.Size(318, 24)
        Me.TxtTableName.TabIndex = 325
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(23, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 24)
        Me.Label5.TabIndex = 326
        Me.Label5.Text = "ชื่อโต๊ะ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel1.Location = New System.Drawing.Point(32, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 1)
        Me.Panel1.TabIndex = 327
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel45.Location = New System.Drawing.Point(33, 293)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(322, 1)
        Me.Panel45.TabIndex = 335
        Me.Panel45.Visible = false
        '
        'ComboBoxTableType
        '
        Me.ComboBoxTableType.EditValue = ""
        Me.ComboBoxTableType.Location = New System.Drawing.Point(33, 262)
        Me.ComboBoxTableType.Name = "ComboBoxTableType"
        Me.ComboBoxTableType.Properties.Appearance.Font = New System.Drawing.Font("Kanit", 12!)
        Me.ComboBoxTableType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxTableType.Properties.Appearance.Options.UseFont = true
        Me.ComboBoxTableType.Properties.Appearance.Options.UseForeColor = true
        Me.ComboBoxTableType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ComboBoxTableType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxTableType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxTableType.Size = New System.Drawing.Size(318, 28)
        Me.ComboBoxTableType.TabIndex = 334
        Me.ComboBoxTableType.Visible = false
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(23, 236)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 24)
        Me.Label32.TabIndex = 333
        Me.Label32.Text = "ประเภทโต๊ะ"
        Me.Label32.Visible = false
        '
        'TxtZoneName
        '
        Me.TxtZoneName.AutoSize = true
        Me.TxtZoneName.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.TxtZoneName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.TxtZoneName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtZoneName.Location = New System.Drawing.Point(59, 59)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.Size = New System.Drawing.Size(0, 24)
        Me.TxtZoneName.TabIndex = 336
        '
        'BtnCancel
        '
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Appearance.Options.UseFont = true
        Me.BtnCancel.Appearance.Options.UseForeColor = true
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ImageOptions.Image = CType(resources.GetObject("BtnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnCancel.Location = New System.Drawing.Point(143, 180)
        Me.BtnCancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnCancel.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnCancel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(103, 33)
        Me.BtnCancel.TabIndex = 329
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'BtnAddTable
        '
        Me.BtnAddTable.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnAddTable.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnAddTable.Appearance.Options.UseFont = true
        Me.BtnAddTable.Appearance.Options.UseForeColor = true
        Me.BtnAddTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddTable.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.BtnAddTable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnAddTable.Location = New System.Drawing.Point(252, 180)
        Me.BtnAddTable.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BtnAddTable.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnAddTable.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnAddTable.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnAddTable.Name = "BtnAddTable"
        Me.BtnAddTable.Size = New System.Drawing.Size(103, 33)
        Me.BtnAddTable.TabIndex = 328
        Me.BtnAddTable.Text = "ตกลง"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label3.Image = Global.iEasyPOS.My.Resources.Resources.Icon_ZoneGray
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 24)
        Me.Label3.TabIndex = 323
        Me.Label3.Text = " :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAddTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 236)
        Me.ControlBox = false
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.Panel45)
        Me.Controls.Add(Me.ComboBoxTableType)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAddTable)
        Me.Controls.Add(Me.TxtTableName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel67)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        CType(Me.ComboBoxTableType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel67 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTableName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddTable As DevExpress.XtraEditors.SimpleButton

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) 

    End Sub

    Friend WithEvents Panel45 As Panel
    Friend WithEvents ComboBoxTableType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label32 As Label
    Friend WithEvents TxtZoneName As Label
End Class
