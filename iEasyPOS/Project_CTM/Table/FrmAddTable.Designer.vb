<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddTable
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddTable = New System.Windows.Forms.Button()
        Me.TxtZoneName = New System.Windows.Forms.TextBox()
        Me.TxtTableName = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxTableType = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ Zone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อ Table :"
        '
        'BtnAddTable
        '
        Me.BtnAddTable.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAddTable.Location = New System.Drawing.Point(138, 207)
        Me.BtnAddTable.Name = "BtnAddTable"
        Me.BtnAddTable.Size = New System.Drawing.Size(75, 33)
        Me.BtnAddTable.TabIndex = 2
        Me.BtnAddTable.Text = "บันทึก"
        Me.BtnAddTable.UseVisualStyleBackColor = True
        '
        'TxtZoneName
        '
        Me.TxtZoneName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtZoneName.Location = New System.Drawing.Point(135, 65)
        Me.TxtZoneName.Name = "TxtZoneName"
        Me.TxtZoneName.ReadOnly = True
        Me.TxtZoneName.Size = New System.Drawing.Size(206, 29)
        Me.TxtZoneName.TabIndex = 3
        '
        'TxtTableName
        '
        Me.TxtTableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtTableName.Location = New System.Drawing.Point(135, 109)
        Me.TxtTableName.Name = "TxtTableName"
        Me.TxtTableName.Size = New System.Drawing.Size(206, 29)
        Me.TxtTableName.TabIndex = 4
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.Location = New System.Drawing.Point(241, 207)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 33)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "ยกเลิก"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(128, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ADD TABLE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 59)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ประเภทโต๊ะ :"
        Me.Label4.Visible = False
        '
        'ComboBoxTableType
        '
        Me.ComboBoxTableType.FormattingEnabled = True
        Me.ComboBoxTableType.Location = New System.Drawing.Point(135, 158)
        Me.ComboBoxTableType.Name = "ComboBoxTableType"
        Me.ComboBoxTableType.Size = New System.Drawing.Size(206, 21)
        Me.ComboBoxTableType.TabIndex = 8
        Me.ComboBoxTableType.Visible = False
        '
        'FrmAddTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxTableType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtTableName)
        Me.Controls.Add(Me.TxtZoneName)
        Me.Controls.Add(Me.BtnAddTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddTable As Button
    Friend WithEvents TxtZoneName As TextBox
    Friend WithEvents TxtTableName As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxTableType As ComboBox
End Class
