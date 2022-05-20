<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Promotion
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
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.PageManagementBrand = New System.Windows.Forms.Label()
        Me.XtraTabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Label()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Button1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        CType(Me.XtraTabMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabMain.SuspendLayout
        Me.Panel4.SuspendLayout
        CType(Me.SeparatorControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.PageManagementBrand)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 42)
        Me.Panel1.TabIndex = 11
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Location = New System.Drawing.Point(0, 41)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1265, 1)
        Me.Panel16.TabIndex = 18
        '
        'PageManagementBrand
        '
        Me.PageManagementBrand.AutoSize = true
        Me.PageManagementBrand.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.PageManagementBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.PageManagementBrand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PageManagementBrand.Location = New System.Drawing.Point(9, 5)
        Me.PageManagementBrand.Name = "PageManagementBrand"
        Me.PageManagementBrand.Size = New System.Drawing.Size(90, 31)
        Me.PageManagementBrand.TabIndex = 11
        Me.PageManagementBrand.Text = "โปรโมชั่น"
        '
        'XtraTabMain
        '
        Me.XtraTabMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XtraTabMain.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XtraTabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabMain.Location = New System.Drawing.Point(0, 78)
        Me.XtraTabMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.XtraTabMain.LookAndFeel.UseDefaultLookAndFeel = false
        Me.XtraTabMain.Name = "XtraTabMain"
        Me.XtraTabMain.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabMain.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabMain.Size = New System.Drawing.Size(1265, 689)
        Me.XtraTabMain.TabIndex = 359
        Me.XtraTabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = true
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1265, 667)
        Me.XtraTabPage1.Text = "จัดการโปรโมชั่น"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = true
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1265, 667)
        Me.XtraTabPage2.Text = "จัดการแต้มสะสม"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.SeparatorControl1)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1265, 36)
        Me.Panel4.TabIndex = 358
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button6.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.Button6.Image = Global.iEasyPOS.My.Resources.Resources.Icon_PiontGray
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(172, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(148, 36)
        Me.Button6.TabIndex = 368
        Me.Button6.Text = "จัดการแต้มสะสม"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SeparatorControl1.LineColor = System.Drawing.Color.FromArgb(CType(CType(65,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(86,Byte),Integer))
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.LineThickness = 1
        Me.SeparatorControl1.Location = New System.Drawing.Point(155, 0)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.SeparatorControl1.Size = New System.Drawing.Size(17, 36)
        Me.SeparatorControl1.TabIndex = 367
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(149,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.Button1.Image = Global.iEasyPOS.My.Resources.Resources.Icon_Pomotion2Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 36)
        Me.Button1.TabIndex = 366
        Me.Button1.Text = "จัดการโปรโมชั่น"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 36)
        Me.Label1.TabIndex = 349
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Promotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1265, 767)
        Me.Controls.Add(Me.XtraTabMain)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Promotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Promotion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.XtraTabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabMain.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        CType(Me.SeparatorControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents PageManagementBrand As Label
    Friend WithEvents XtraTabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Label
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents Button1 As Label
End Class
