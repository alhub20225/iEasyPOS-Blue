<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Critical
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Critical))
        Me.TableOkCancel = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.OK_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.head_Label = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Accep_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.TableOkCancel.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableOkCancel
        '
        Me.TableOkCancel.ColumnCount = 2
        Me.TableOkCancel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableOkCancel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableOkCancel.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableOkCancel.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableOkCancel.Location = New System.Drawing.Point(65, 80)
        Me.TableOkCancel.Name = "TableOkCancel"
        Me.TableOkCancel.RowCount = 1
        Me.TableOkCancel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableOkCancel.Size = New System.Drawing.Size(219, 44)
        Me.TableOkCancel.TabIndex = 2
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.Appearance.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Cancel_Button.Appearance.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.Appearance.Options.UseFont = true
        Me.Cancel_Button.Appearance.Options.UseForeColor = true
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.ImageOptions.Image = CType(resources.GetObject("Cancel_Button.ImageOptions.Image"),System.Drawing.Image)
        Me.Cancel_Button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red
        Me.Cancel_Button.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.Cancel_Button.LookAndFeel.UseDefaultLookAndFeel = false
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(103, 33)
        Me.Cancel_Button.TabIndex = 340
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Appearance.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Appearance.Options.UseFont = True
        Me.OK_Button.Appearance.Options.UseForeColor = True
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.OK_Button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.OK_Button.Location = New System.Drawing.Point(113, 3)
        Me.OK_Button.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.OK_Button.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.OK_Button.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.OK_Button.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(103, 33)
        Me.OK_Button.TabIndex = 339
        Me.OK_Button.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.head_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 43)
        Me.Panel1.TabIndex = 335
        '
        'head_Label
        '
        Me.head_Label.AutoSize = True
        Me.head_Label.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.head_Label.ForeColor = System.Drawing.Color.White
        Me.head_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.head_Label.Location = New System.Drawing.Point(20, 7)
        Me.head_Label.Name = "head_Label"
        Me.head_Label.Size = New System.Drawing.Size(38, 29)
        Me.head_Label.TabIndex = 12
        Me.head_Label.Text = "txt"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(348, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 114)
        Me.Panel4.TabIndex = 336
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 114)
        Me.Panel5.TabIndex = 337
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(1, 156)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(347, 1)
        Me.Panel6.TabIndex = 338
        '
        'Accep_Button
        '
        Me.Accep_Button.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accep_Button.Appearance.ForeColor = System.Drawing.Color.White
        Me.Accep_Button.Appearance.Options.UseFont = True
        Me.Accep_Button.Appearance.Options.UseForeColor = True
        Me.Accep_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Accep_Button.ImageOptions.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Ok2White
        Me.Accep_Button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Accep_Button.Location = New System.Drawing.Point(125, 83)
        Me.Accep_Button.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Accep_Button.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.Accep_Button.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.Accep_Button.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Accep_Button.Name = "Accep_Button"
        Me.Accep_Button.Size = New System.Drawing.Size(103, 33)
        Me.Accep_Button.TabIndex = 341
        Me.Accep_Button.Text = "OK"
        '
        'Frm_Critical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(349, 157)
        Me.ControlBox = false
        Me.Controls.Add(Me.Accep_Button)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableOkCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Critical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        Me.TableOkCancel.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableOkCancel As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents head_Label As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Cancel_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OK_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Accep_Button As DevExpress.XtraEditors.SimpleButton
End Class
