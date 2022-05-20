<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQRPayment
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PictureBoxQR = New System.Windows.Forms.PictureBox()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PictureBoxQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(816, 683)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.XtraTabPage1.Controls.Add(Me.PictureBoxQR)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage1.Size = New System.Drawing.Size(810, 655)
        Me.XtraTabPage1.Text = "PanelTabQrType"
        '
        'PictureBoxQR
        '
        Me.PictureBoxQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxQR.Location = New System.Drawing.Point(230, 152)
        Me.PictureBoxQR.Name = "PictureBoxQR"
        Me.PictureBoxQR.Size = New System.Drawing.Size(350, 350)
        Me.PictureBoxQR.TabIndex = 0
        Me.PictureBoxQR.TabStop = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PictureBox2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(810, 655)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(213, 149)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(350, 277)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(810, 655)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'FrmQRPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 683)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "FrmQRPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmQRPayment"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PictureBoxQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureBoxQR As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
End Class
