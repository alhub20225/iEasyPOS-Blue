<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pos_PaymentGift
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_PaymentGift))
        Me.BtnGiftCancle = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGiftPay = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtGiftNumber = New System.Windows.Forms.TextBox()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel9.SuspendLayout
        Me.Panel68.SuspendLayout
        Me.SuspendLayout
        '
        'BtnGiftCancle
        '
        Me.BtnGiftCancle.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnGiftCancle.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnGiftCancle.Appearance.Options.UseFont = true
        Me.BtnGiftCancle.Appearance.Options.UseForeColor = true
        Me.BtnGiftCancle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGiftCancle.ImageOptions.Image = CType(resources.GetObject("BtnGiftCancle.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnGiftCancle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnGiftCancle.Location = New System.Drawing.Point(193, 148)
        Me.BtnGiftCancle.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnGiftCancle.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnGiftCancle.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnGiftCancle.Name = "BtnGiftCancle"
        Me.BtnGiftCancle.Size = New System.Drawing.Size(103, 33)
        Me.BtnGiftCancle.TabIndex = 157
        Me.BtnGiftCancle.Text = "ยกเลิก"
        '
        'BtnGiftPay
        '
        Me.BtnGiftPay.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnGiftPay.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnGiftPay.Appearance.Options.UseFont = true
        Me.BtnGiftPay.Appearance.Options.UseForeColor = true
        Me.BtnGiftPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGiftPay.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.BtnGiftPay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnGiftPay.Location = New System.Drawing.Point(302, 148)
        Me.BtnGiftPay.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BtnGiftPay.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.BtnGiftPay.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnGiftPay.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnGiftPay.Name = "BtnGiftPay"
        Me.BtnGiftPay.Size = New System.Drawing.Size(103, 33)
        Me.BtnGiftPay.TabIndex = 156
        Me.BtnGiftPay.Text = "ตกลง"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel68)
        Me.Panel9.Controls.Add(Me.txtGiftNumber)
        Me.Panel9.Controls.Add(Me.Panel45)
        Me.Panel9.Controls.Add(Me.BtnGiftCancle)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.BtnGiftPay)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(436, 199)
        Me.Panel9.TabIndex = 354
        '
        'Panel68
        '
        Me.Panel68.BackColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Panel68.Controls.Add(Me.Panel69)
        Me.Panel68.Controls.Add(Me.Label34)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(436, 43)
        Me.Panel68.TabIndex = 160
        '
        'Panel69
        '
        Me.Panel69.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel69.Location = New System.Drawing.Point(0, 42)
        Me.Panel69.Name = "Panel69"
        Me.Panel69.Size = New System.Drawing.Size(436, 1)
        Me.Panel69.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(20, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Gift Card"
        '
        'txtGiftNumber
        '
        Me.txtGiftNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtGiftNumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtGiftNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGiftNumber.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.txtGiftNumber.Location = New System.Drawing.Point(41, 94)
        Me.txtGiftNumber.Name = "txtGiftNumber"
        Me.txtGiftNumber.Size = New System.Drawing.Size(364, 29)
        Me.txtGiftNumber.TabIndex = 1
        Me.txtGiftNumber.TabStop = false
        '
        'Panel45
        '
        Me.Panel45.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel45.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel45.Location = New System.Drawing.Point(36, 127)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(369, 1)
        Me.Panel45.TabIndex = 154
        '
        'Label31
        '
        Me.Label31.AutoSize = true
        Me.Label31.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Label31.Location = New System.Drawing.Point(23, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(142, 24)
        Me.Label31.TabIndex = 147
        Me.Label31.Text = "Gift Card Number"
        '
        'Pos_PaymentGift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 199)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pos_PaymentGift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pos_PaymentGift"
        Me.Panel9.ResumeLayout(false)
        Me.Panel9.PerformLayout
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BtnGiftCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGiftPay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents txtGiftNumber As TextBox
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Label31 As Label
End Class
