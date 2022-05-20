<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zone_img
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave_zone_img = New System.Windows.Forms.Button()
        Me.BtnClearImage = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.zone_img_brow = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxResize = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.zone_img_brow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxResize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 59)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(128, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ZONE img"
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnCancel.Location = New System.Drawing.Point(278, 152)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 33)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "ยกเลิก"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave_zone_img
        '
        Me.BtnSave_zone_img.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnSave_zone_img.Location = New System.Drawing.Point(186, 152)
        Me.BtnSave_zone_img.Name = "BtnSave_zone_img"
        Me.BtnSave_zone_img.Size = New System.Drawing.Size(75, 33)
        Me.BtnSave_zone_img.TabIndex = 3
        Me.BtnSave_zone_img.Text = "บันทึก"
        Me.BtnSave_zone_img.UseVisualStyleBackColor = True
        '
        'BtnClearImage
        '
        Me.BtnClearImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClearImage.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.BtnClearImage.Location = New System.Drawing.Point(16, 152)
        Me.BtnClearImage.Name = "BtnClearImage"
        Me.BtnClearImage.Size = New System.Drawing.Size(145, 33)
        Me.BtnClearImage.TabIndex = 50
        Me.BtnClearImage.Text = "Clear Image"
        Me.BtnClearImage.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.Label14.Location = New System.Drawing.Point(70, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 27)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Image"
        '
        'zone_img_brow
        '
        Me.zone_img_brow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zone_img_brow.Location = New System.Drawing.Point(163, 95)
        Me.zone_img_brow.Name = "zone_img_brow"
        Me.zone_img_brow.Size = New System.Drawing.Size(190, 28)
        Me.zone_img_brow.TabIndex = 48
        Me.zone_img_brow.Text = "RadBrowseEditor1"
        CType(Me.zone_img_brow.GetChildAt(0), Telerik.WinControls.UI.RadBrowseEditorElement).Text = "(none)"
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.BrowseEditorButton).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlDark
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.ControlDark
        CType(Me.zone_img_brow.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 21)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBoxResize
        '
        Me.PictureBoxResize.Location = New System.Drawing.Point(13, 66)
        Me.PictureBoxResize.Name = "PictureBoxResize"
        Me.PictureBoxResize.Size = New System.Drawing.Size(27, 29)
        Me.PictureBoxResize.TabIndex = 51
        Me.PictureBoxResize.TabStop = False
        Me.PictureBoxResize.Visible = False
        '
        'Zone_img
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBoxResize)
        Me.Controls.Add(Me.BtnClearImage)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.zone_img_brow)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSave_zone_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Zone_img"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.zone_img_brow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxResize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave_zone_img As Button
    Friend WithEvents BtnClearImage As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents zone_img_brow As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents PictureBoxResize As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
