<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTestRegister
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMacaddress = New System.Windows.Forms.TextBox()
        Me.TxtHdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMacHdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtGenerate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MacAddress"
        '
        'TxtMacaddress
        '
        Me.TxtMacaddress.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.TxtMacaddress.Location = New System.Drawing.Point(112, 12)
        Me.TxtMacaddress.Name = "TxtMacaddress"
        Me.TxtMacaddress.Size = New System.Drawing.Size(302, 24)
        Me.TxtMacaddress.TabIndex = 1
        '
        'TxtHdd
        '
        Me.TxtHdd.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.TxtHdd.Location = New System.Drawing.Point(112, 38)
        Me.TxtHdd.Name = "TxtHdd"
        Me.TxtHdd.Size = New System.Drawing.Size(302, 24)
        Me.TxtHdd.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Serial HDD"
        '
        'TxtMacHdd
        '
        Me.TxtMacHdd.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.TxtMacHdd.Location = New System.Drawing.Point(112, 64)
        Me.TxtMacHdd.Name = "TxtMacHdd"
        Me.TxtMacHdd.Size = New System.Drawing.Size(302, 24)
        Me.TxtMacHdd.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mac+HDD"
        '
        'TxtGenerate
        '
        Me.TxtGenerate.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.TxtGenerate.Location = New System.Drawing.Point(112, 90)
        Me.TxtGenerate.Name = "TxtGenerate"
        Me.TxtGenerate.Size = New System.Drawing.Size(302, 24)
        Me.TxtGenerate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(19, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Generate"
        '
        'FrmTestRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 136)
        Me.Controls.Add(Me.TxtGenerate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMacHdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtHdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMacaddress)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTestRegister"
        Me.Text = "FrmTestRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMacaddress As TextBox
    Friend WithEvents TxtHdd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMacHdd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtGenerate As TextBox
    Friend WithEvents Label4 As Label
End Class
