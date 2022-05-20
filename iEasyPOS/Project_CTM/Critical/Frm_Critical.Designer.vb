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
        Me.TableOkCancel = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.head_Label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Accep_Button = New System.Windows.Forms.Button()
        Me.TableOkCancel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableOkCancel
        '
        Me.TableOkCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableOkCancel.ColumnCount = 2
        Me.TableOkCancel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableOkCancel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableOkCancel.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableOkCancel.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableOkCancel.Location = New System.Drawing.Point(51, 104)
        Me.TableOkCancel.Name = "TableOkCancel"
        Me.TableOkCancel.RowCount = 1
        Me.TableOkCancel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableOkCancel.Size = New System.Drawing.Size(320, 87)
        Me.TableOkCancel.TabIndex = 2
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.OK_Button.Location = New System.Drawing.Point(23, 16)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(113, 55)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Cancel_Button.Location = New System.Drawing.Point(185, 16)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(110, 55)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'head_Label
        '
        Me.head_Label.AutoSize = True
        Me.head_Label.Font = New System.Drawing.Font("Kanit", 24.0!, System.Drawing.FontStyle.Bold)
        Me.head_Label.ForeColor = System.Drawing.Color.White
        Me.head_Label.Location = New System.Drawing.Point(44, 22)
        Me.head_Label.Name = "head_Label"
        Me.head_Label.Size = New System.Drawing.Size(80, 48)
        Me.head_Label.TabIndex = 0
        Me.head_Label.Text = "text"
        Me.head_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.head_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 82)
        Me.Panel1.TabIndex = 3
        '
        'Accep_Button
        '
        Me.Accep_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Accep_Button.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Accep_Button.Location = New System.Drawing.Point(156, 120)
        Me.Accep_Button.Name = "Accep_Button"
        Me.Accep_Button.Size = New System.Drawing.Size(113, 55)
        Me.Accep_Button.TabIndex = 4
        Me.Accep_Button.Text = "OK"
        '
        'Frm_Critical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.Accep_Button)
        Me.Controls.Add(Me.TableOkCancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Critical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TableOkCancel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableOkCancel As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents head_Label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Accep_Button As Button
End Class
