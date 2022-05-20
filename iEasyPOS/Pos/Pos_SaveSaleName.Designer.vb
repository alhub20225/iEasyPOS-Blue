<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_SaveSaleName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_SaveSaleName))
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaveSale = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel68.SuspendLayout
        Me.SuspendLayout
        '
        'Panel68
        '
        Me.Panel68.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel68.Controls.Add(Me.Panel69)
        Me.Panel68.Controls.Add(Me.Label34)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(434, 43)
        Me.Panel68.TabIndex = 161
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(434, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(20, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(145, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "บันทึกพักการขาย"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Appearance.Options.UseFont = true
        Me.btnCancel.Appearance.Options.UseForeColor = true
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(193, 148)
        Me.btnCancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.btnCancel.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 33)
        Me.btnCancel.TabIndex = 166
        Me.btnCancel.Text = "ยกเลิก"
        '
        'btnSaveSale
        '
        Me.btnSaveSale.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSaveSale.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSaveSale.Appearance.Options.UseFont = true
        Me.btnSaveSale.Appearance.Options.UseForeColor = true
        Me.btnSaveSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSale.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.btnSaveSale.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSaveSale.Location = New System.Drawing.Point(302, 148)
        Me.btnSaveSale.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.btnSaveSale.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.btnSaveSale.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btnSaveSale.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnSaveSale.Name = "btnSaveSale"
        Me.btnSaveSale.Size = New System.Drawing.Size(103, 33)
        Me.btnSaveSale.TabIndex = 165
        Me.btnSaveSale.Text = "ตกลง"
        '
        'txtSaleName
        '
        Me.txtSaleName.BackColor = System.Drawing.Color.White
        Me.txtSaleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaleName.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.txtSaleName.Location = New System.Drawing.Point(41, 94)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(364, 29)
        Me.txtSaleName.TabIndex = 162
        Me.txtSaleName.TabStop = false
        Me.txtSaleName.Text = "ลูกค้าเงินสด"
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel45.Location = New System.Drawing.Point(36, 127)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(369, 1)
        Me.Panel45.TabIndex = 164
        '
        'Label31
        '
        Me.Label31.AutoSize = true
        Me.Label31.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label31.Location = New System.Drawing.Point(23, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 24)
        Me.Label31.TabIndex = 163
        Me.Label31.Text = "ชื่อรายการ"
        '
        'Pos_SaveSaleName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 197)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveSale)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.Panel45)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Panel68)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pos_SaveSaleName"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveSale As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSaleName As TextBox
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Label31 As Label
End Class
