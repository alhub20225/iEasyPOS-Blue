<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regis_LC
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
        Me.txt_serailnumber = New System.Windows.Forms.TextBox()
        Me.key_output = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_status = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cdkey = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_serailnumber
        '
        Me.txt_serailnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serailnumber.Location = New System.Drawing.Point(43, 38)
        Me.txt_serailnumber.Name = "txt_serailnumber"
        Me.txt_serailnumber.Size = New System.Drawing.Size(354, 26)
        Me.txt_serailnumber.TabIndex = 0
        '
        'key_output
        '
        Me.key_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.key_output.Location = New System.Drawing.Point(43, 65)
        Me.key_output.Name = "key_output"
        Me.key_output.Size = New System.Drawing.Size(68, 26)
        Me.key_output.TabIndex = 1
        Me.key_output.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(177, 161)
        Me.SimpleButton1.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight
        Me.SimpleButton1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.SimpleButton1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 37)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "OK"
        '
        'txt_status
        '
        Me.txt_status.Appearance.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.txt_status.Location = New System.Drawing.Point(177, 12)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(61, 19)
        Me.txt_status.TabIndex = 3
        Me.txt_status.Text = "txt_status"
        '
        'txt_cdkey
        '
        Me.txt_cdkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdkey.Location = New System.Drawing.Point(43, 100)
        Me.txt_cdkey.Name = "txt_cdkey"
        Me.txt_cdkey.Size = New System.Drawing.Size(354, 26)
        Me.txt_cdkey.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(311, 161)
        Me.SimpleButton2.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton2.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(86, 37)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(173, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LC CODE"
        '
        'Regis_LC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.txt_cdkey)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.key_output)
        Me.Controls.Add(Me.txt_serailnumber)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Regis_LC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_serailnumber As TextBox
    Friend WithEvents key_output As TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cdkey As TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
End Class
