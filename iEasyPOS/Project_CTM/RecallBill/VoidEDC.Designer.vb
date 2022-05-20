<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoidEDC
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnVoidEDC = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.textBoxMerchant = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBoxTraceNo = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.textBoxCom = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnVoidEDC
        '
        Me.BtnVoidEDC.Appearance.Font = New System.Drawing.Font("Kanit SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoidEDC.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnVoidEDC.Appearance.Options.UseFont = True
        Me.BtnVoidEDC.Appearance.Options.UseForeColor = True
        Me.BtnVoidEDC.Location = New System.Drawing.Point(126, 354)
        Me.BtnVoidEDC.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVoidEDC.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.BtnVoidEDC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BtnVoidEDC.Name = "BtnVoidEDC"
        Me.BtnVoidEDC.Size = New System.Drawing.Size(117, 50)
        Me.BtnVoidEDC.TabIndex = 0
        Me.BtnVoidEDC.Text = "ตกลง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(122, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "กรอกเลขที่ใบเสร็จ "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(22, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label13.Location = New System.Drawing.Point(31, 15)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(87, 16)
        Me.label13.TabIndex = 120
        Me.label13.Text = "Select Merchant"
        Me.label13.Visible = False
        '
        'textBoxMerchant
        '
        Me.textBoxMerchant.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxMerchant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxMerchant.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.textBoxMerchant.Location = New System.Drawing.Point(33, 31)
        Me.textBoxMerchant.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.textBoxMerchant.Name = "textBoxMerchant"
        Me.textBoxMerchant.Size = New System.Drawing.Size(45, 20)
        Me.textBoxMerchant.TabIndex = 117
        Me.textBoxMerchant.Text = "1"
        Me.textBoxMerchant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textBoxMerchant.Visible = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label2.Location = New System.Drawing.Point(307, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 16)
        Me.label2.TabIndex = 125
        Me.label2.Text = "Trace No."
        '
        'textBoxTraceNo
        '
        Me.textBoxTraceNo.BackColor = System.Drawing.Color.White
        Me.textBoxTraceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxTraceNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.textBoxTraceNo.Location = New System.Drawing.Point(303, 31)
        Me.textBoxTraceNo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.textBoxTraceNo.Name = "textBoxTraceNo"
        Me.textBoxTraceNo.Size = New System.Drawing.Size(54, 21)
        Me.textBoxTraceNo.TabIndex = 124
        Me.textBoxTraceNo.Text = "1"
        Me.textBoxTraceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton2)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton3)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton4)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton5)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton6)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton7)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton8)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton9)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton10)
        Me.FlowLayoutPanel1.Controls.Add(Me.SimpleButton11)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Kanit", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(19, 90)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(345, 258)
        Me.FlowLayoutPanel1.TabIndex = 126
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(89, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "2"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(175, 3)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "3"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(261, 3)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton4.TabIndex = 3
        Me.SimpleButton4.Text = "4"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Location = New System.Drawing.Point(3, 89)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton5.TabIndex = 4
        Me.SimpleButton5.Text = "5"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Location = New System.Drawing.Point(89, 89)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton6.TabIndex = 5
        Me.SimpleButton6.Text = "6"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Location = New System.Drawing.Point(175, 89)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton7.TabIndex = 6
        Me.SimpleButton7.Text = "7"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton8.Appearance.Options.UseFont = True
        Me.SimpleButton8.Location = New System.Drawing.Point(261, 89)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton8.TabIndex = 7
        Me.SimpleButton8.Text = "8"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton9.Appearance.Options.UseFont = True
        Me.SimpleButton9.Location = New System.Drawing.Point(3, 175)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton9.TabIndex = 8
        Me.SimpleButton9.Text = "9"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Appearance.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton10.Appearance.Options.UseFont = True
        Me.SimpleButton10.Location = New System.Drawing.Point(89, 175)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(80, 80)
        Me.SimpleButton10.TabIndex = 9
        Me.SimpleButton10.Text = "0"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Appearance.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.SimpleButton11.Appearance.Options.UseFont = True
        Me.SimpleButton11.Location = New System.Drawing.Point(175, 175)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(166, 80)
        Me.SimpleButton11.TabIndex = 10
        Me.SimpleButton11.Text = "Clear"
        '
        'textBoxCom
        '
        Me.textBoxCom.BackColor = System.Drawing.Color.White
        Me.textBoxCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxCom.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.textBoxCom.Location = New System.Drawing.Point(290, 370)
        Me.textBoxCom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.textBoxCom.Name = "textBoxCom"
        Me.textBoxCom.Size = New System.Drawing.Size(51, 20)
        Me.textBoxCom.TabIndex = 118
        Me.textBoxCom.Text = "3"
        Me.textBoxCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.textBoxCom.Visible = False
        '
        'VoidEDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 409)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBoxTraceNo)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.textBoxMerchant)
        Me.Controls.Add(Me.textBoxCom)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVoidEDC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VoidEDC"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ยกเลิกการขายที่ทำรายการจาก EDC"
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVoidEDC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents label13 As Label
    Private WithEvents textBoxMerchant As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBoxTraceNo As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents textBoxCom As TextBox
End Class
