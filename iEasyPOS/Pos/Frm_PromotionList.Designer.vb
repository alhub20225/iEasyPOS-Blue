<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PromotionList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewPromotionList = New System.Windows.Forms.DataGridView()
        Me.PromotionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewPromotionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridViewPromotionList)
        Me.Panel1.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(8, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 428)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(160, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "โปรโมชั่น"
        '
        'DataGridViewPromotionList
        '
        Me.DataGridViewPromotionList.AllowUserToAddRows = False
        Me.DataGridViewPromotionList.AllowUserToDeleteRows = False
        Me.DataGridViewPromotionList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewPromotionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPromotionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionId, Me.PromotionCode, Me.PromotionName})
        Me.DataGridViewPromotionList.Location = New System.Drawing.Point(0, 61)
        Me.DataGridViewPromotionList.Name = "DataGridViewPromotionList"
        Me.DataGridViewPromotionList.ReadOnly = True
        Me.DataGridViewPromotionList.RowHeadersVisible = False
        Me.DataGridViewPromotionList.Size = New System.Drawing.Size(416, 367)
        Me.DataGridViewPromotionList.TabIndex = 0
        '
        'PromotionId
        '
        Me.PromotionId.HeaderText = "PromotionId"
        Me.PromotionId.Name = "PromotionId"
        Me.PromotionId.ReadOnly = True
        Me.PromotionId.Visible = False
        '
        'PromotionCode
        '
        Me.PromotionCode.HeaderText = "รหัส"
        Me.PromotionCode.Name = "PromotionCode"
        Me.PromotionCode.ReadOnly = True
        Me.PromotionCode.Width = 150
        '
        'PromotionName
        '
        Me.PromotionName.HeaderText = "โปรโมชั่น"
        Me.PromotionName.Name = "PromotionName"
        Me.PromotionName.ReadOnly = True
        Me.PromotionName.Width = 250
        '
        'Frm_PromotionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_PromotionList"
        Me.Text = "Frm_PromotionList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewPromotionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewPromotionList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PromotionId As DataGridViewTextBoxColumn
    Friend WithEvents PromotionCode As DataGridViewTextBoxColumn
    Friend WithEvents PromotionName As DataGridViewTextBoxColumn
End Class
