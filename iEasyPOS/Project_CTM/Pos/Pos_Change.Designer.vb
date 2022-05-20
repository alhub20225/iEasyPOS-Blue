<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pos_Change
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.Label()
        Me.BtnChange = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        CType(Me.BtnChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(279, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เงินทอน"
        '
        'txtChange
        '
        Me.txtChange.AutoSize = True
        Me.txtChange.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtChange.Font = New System.Drawing.Font("Kanit", 48.0!, System.Drawing.FontStyle.Bold)
        Me.txtChange.ForeColor = System.Drawing.Color.DimGray
        Me.txtChange.Location = New System.Drawing.Point(289, 114)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(182, 95)
        Me.txtChange.TabIndex = 2
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnChange
        '
        Me.BtnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChange.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.BtnChange.Location = New System.Drawing.Point(291, 238)
        Me.BtnChange.Name = "BtnChange"
        '
        '
        '
        Me.BtnChange.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.BtnChange.Size = New System.Drawing.Size(160, 68)
        Me.BtnChange.TabIndex = 105
        Me.BtnChange.Text = "ตกลง"
        CType(Me.BtnChange.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ตกลง"
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).ClickMode = Telerik.WinControls.ClickMode.Hover
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Kanit Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnChange.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(742, 84)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Pos_Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(742, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pos_Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.BtnChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtChange As Label
    Friend WithEvents BtnChange As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
End Class
