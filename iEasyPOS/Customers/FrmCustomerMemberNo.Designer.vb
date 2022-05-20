<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerMemberNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerMemberNo))
        Me.txtCustomerMemNo = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.Panel69 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel9.SuspendLayout
        Me.Panel68.SuspendLayout
        Me.SuspendLayout
        '
        'txtCustomerMemNo
        '
        Me.txtCustomerMemNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCustomerMemNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustomerMemNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerMemNo.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.txtCustomerMemNo.Location = New System.Drawing.Point(41, 94)
        Me.txtCustomerMemNo.Name = "txtCustomerMemNo"
        Me.txtCustomerMemNo.Size = New System.Drawing.Size(364, 29)
        Me.txtCustomerMemNo.TabIndex = 1
        Me.txtCustomerMemNo.TabStop = false
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.BtnDel)
        Me.Panel9.Controls.Add(Me.btn)
        Me.Panel9.Controls.Add(Me.Panel68)
        Me.Panel9.Controls.Add(Me.txtCustomerMemNo)
        Me.Panel9.Controls.Add(Me.Panel45)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(436, 199)
        Me.Panel9.TabIndex = 3
        '
        'BtnDel
        '
        Me.BtnDel.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnDel.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnDel.Appearance.Options.UseFont = true
        Me.BtnDel.Appearance.Options.UseForeColor = true
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.ImageOptions.Image = CType(resources.GetObject("BtnDel.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnDel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.BtnDel.Location = New System.Drawing.Point(193, 148)
        Me.BtnDel.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.BtnDel.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.BtnDel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(103, 33)
        Me.BtnDel.TabIndex = 157
        Me.BtnDel.Text = "ยกเลิก"
        '
        'btn
        '
        Me.btn.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn.Appearance.ForeColor = System.Drawing.Color.White
        Me.btn.Appearance.Options.UseFont = true
        Me.btn.Appearance.Options.UseForeColor = true
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn.Location = New System.Drawing.Point(302, 148)
        Me.btn.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(212,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.btn.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.btn.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.btn.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(103, 33)
        Me.btn.TabIndex = 156
        Me.btn.Text = "ตกลง"
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
        Me.Label34.Size = New System.Drawing.Size(67, 29)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "สมาชิก"
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
        Me.Label31.Size = New System.Drawing.Size(85, 24)
        Me.Label31.TabIndex = 147
        Me.Label31.Text = "รหัสสมาชิก"
        '
        'FrmCustomerMemberNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 198)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmCustomerMemberNo"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel9.ResumeLayout(false)
        Me.Panel9.PerformLayout
        Me.Panel68.ResumeLayout(false)
        Me.Panel68.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents txtCustomerMemNo As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Panel69 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents BtnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn As DevExpress.XtraEditors.SimpleButton
End Class
