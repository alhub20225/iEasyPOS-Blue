<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditLayOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLoadTemplate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Print Order"
        Me.NotifyIcon1.BalloonTipTitle = "Print Order"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Print Order"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLoadTemplate, Me.ToolStripEditLayOut, Me.ToolStripMenuExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(209, 110)
        '
        'ToolStripMenuExit
        '
        Me.ToolStripMenuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuExit.Image = Global.PrintOrder.My.Resources.Resources.exit_2
        Me.ToolStripMenuExit.Name = "ToolStripMenuExit"
        Me.ToolStripMenuExit.Size = New System.Drawing.Size(208, 28)
        Me.ToolStripMenuExit.Text = "Exit Print Order"
        '
        'ToolStripEditLayOut
        '
        Me.ToolStripEditLayOut.Name = "ToolStripEditLayOut"
        Me.ToolStripEditLayOut.Size = New System.Drawing.Size(208, 28)
        Me.ToolStripEditLayOut.Text = "Edit Template"
        '
        'ToolStripLoadTemplate
        '
        Me.ToolStripLoadTemplate.Name = "ToolStripLoadTemplate"
        Me.ToolStripLoadTemplate.Size = New System.Drawing.Size(208, 28)
        Me.ToolStripLoadTemplate.Text = "Load Template"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 179)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuExit As ToolStripMenuItem
    Friend WithEvents ToolStripEditLayOut As ToolStripMenuItem
    Friend WithEvents ToolStripLoadTemplate As ToolStripMenuItem
End Class
