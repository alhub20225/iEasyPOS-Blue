<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form27
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form27))
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TxtZoneName = New System.Windows.Forms.Label()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddTable = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtTableName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel67.SuspendLayout
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
        Me.Label36.Size = New System.Drawing.Size(76, 29)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "แก้ไขโต๊ะ"
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
        'TxtZoneName
        '
        Me.TxtZoneName.AutoSize = true
        Me.TxtZoneName.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold)
        Me.TxtZoneName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.TxtZoneName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtZoneName.Location = New System.Drawing.Point(59, 59)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.Size = New System.Drawing.Size(0, 24)
        Me.TxtZoneName.TabIndex = 343
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
        Me.BtnCancel.TabIndex = 342
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
        Me.BtnAddTable.TabIndex = 341
        Me.BtnAddTable.Text = "ตกลง"
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
        Me.TxtTableName.TabIndex = 338
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
        Me.Label5.TabIndex = 339
        Me.Label5.Text = "ชื่อโต๊ะ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel1.Location = New System.Drawing.Point(32, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 1)
        Me.Panel1.TabIndex = 340
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
        Me.Label3.TabIndex = 337
        Me.Label3.Text = " :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form27
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 236)
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.Panel67)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAddTable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTableName)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form27"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form27"
        Me.Panel67.ResumeLayout(false)
        Me.Panel67.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel67 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents TxtZoneName As Label
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtTableName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
