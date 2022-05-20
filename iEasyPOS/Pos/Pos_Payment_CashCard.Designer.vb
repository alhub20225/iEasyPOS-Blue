<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pos_Payment_CashCard
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
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Top_tap,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(149,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(546, 42)
        Me.Top_tap.TabIndex = 5
        Me.Top_tap.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(149,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(215, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "บัตรเงินสด"
        '
        'Pos_Payment_CashCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 405)
        Me.ControlBox = false
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pos_Payment_CashCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Top_tap,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents Label1 As Label
End Class
