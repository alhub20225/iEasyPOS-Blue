<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Break
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddBreak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBreak = New System.Windows.Forms.TextBox()
        Me.DataGridView_Break = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เวลาพัก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBoxBreakActive = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView_Break, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddBreak
        '
        Me.btnAddBreak.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnAddBreak.Location = New System.Drawing.Point(428, 45)
        Me.btnAddBreak.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBreak.Name = "btnAddBreak"
        Me.btnAddBreak.Size = New System.Drawing.Size(100, 30)
        Me.btnAddBreak.TabIndex = 0
        Me.btnAddBreak.Text = "บันทึกข้อมูล"
        Me.btnAddBreak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เวลาพัก"
        '
        'txtBreak
        '
        Me.txtBreak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBreak.Location = New System.Drawing.Point(16, 48)
        Me.txtBreak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBreak.Name = "txtBreak"
        Me.txtBreak.Size = New System.Drawing.Size(299, 24)
        Me.txtBreak.TabIndex = 2
        '
        'DataGridView_Break
        '
        Me.DataGridView_Break.AllowUserToAddRows = False
        Me.DataGridView_Break.AllowUserToDeleteRows = False
        Me.DataGridView_Break.AllowUserToResizeRows = False
        Me.DataGridView_Break.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Break.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Break.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.เวลาพัก})
        Me.DataGridView_Break.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Break.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Break.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Break.MultiSelect = False
        Me.DataGridView_Break.Name = "DataGridView_Break"
        Me.DataGridView_Break.ReadOnly = True
        Me.DataGridView_Break.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_Break.RowHeadersVisible = False
        Me.DataGridView_Break.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView_Break.Size = New System.Drawing.Size(511, 271)
        Me.DataGridView_Break.TabIndex = 3
        '
        'Id
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Id.DefaultCellStyle = DataGridViewCellStyle1
        Me.Id.HeaderText = ""
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 60
        '
        'เวลาพัก
        '
        Me.เวลาพัก.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.เวลาพัก.DefaultCellStyle = DataGridViewCellStyle2
        Me.เวลาพัก.HeaderText = "เวลาพัก"
        Me.เวลาพัก.Name = "เวลาพัก"
        Me.เวลาพัก.ReadOnly = True
        '
        'ComboBoxBreakActive
        '
        Me.ComboBoxBreakActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxBreakActive.FormattingEnabled = True
        Me.ComboBoxBreakActive.Location = New System.Drawing.Point(324, 48)
        Me.ComboBoxBreakActive.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxBreakActive.Name = "ComboBoxBreakActive"
        Me.ComboBoxBreakActive.Size = New System.Drawing.Size(95, 24)
        Me.ComboBoxBreakActive.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView_Break)
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(17, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 271)
        Me.Panel1.TabIndex = 5
        '
        'Frm_Break
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 384)
        Me.Controls.Add(Me.ComboBoxBreakActive)
        Me.Controls.Add(Me.txtBreak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddBreak)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Break"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เวลาพัก"
        CType(Me.DataGridView_Break, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddBreak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBreak As TextBox
    Friend WithEvents DataGridView_Break As DataGridView
    Friend WithEvents ComboBoxBreakActive As ComboBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents เวลาพัก As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
