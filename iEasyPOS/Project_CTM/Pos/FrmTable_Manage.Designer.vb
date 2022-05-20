<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTable_Manage
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
        Me.FlowLayoutPanelTable = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanelZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.RadButton10 = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTableName = New System.Windows.Forms.Label()
        CType(Me.RadButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelTable
        '
        Me.FlowLayoutPanelTable.Location = New System.Drawing.Point(303, 125)
        Me.FlowLayoutPanelTable.Name = "FlowLayoutPanelTable"
        Me.FlowLayoutPanelTable.Size = New System.Drawing.Size(808, 505)
        Me.FlowLayoutPanelTable.TabIndex = 13
        '
        'FlowLayoutPanelZone
        '
        Me.FlowLayoutPanelZone.Location = New System.Drawing.Point(8, 125)
        Me.FlowLayoutPanelZone.Name = "FlowLayoutPanelZone"
        Me.FlowLayoutPanelZone.Size = New System.Drawing.Size(289, 505)
        Me.FlowLayoutPanelZone.TabIndex = 12
        '
        'RadButton10
        '
        Me.RadButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadButton10.Location = New System.Drawing.Point(893, 645)
        Me.RadButton10.Name = "RadButton10"
        Me.RadButton10.Size = New System.Drawing.Size(218, 52)
        Me.RadButton10.TabIndex = 120
        Me.RadButton10.Text = "บันทึก"
        CType(Me.RadButton10.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "บันทึก"
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(74, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Kanit", 11.25!)
        CType(Me.RadButton10.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 16)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "โต๊ะ"
        '
        'txtTableName
        '
        Me.txtTableName.AutoSize = True
        Me.txtTableName.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.txtTableName.Location = New System.Drawing.Point(12, 51)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(69, 29)
        Me.txtTableName.TabIndex = 122
        Me.txtTableName.Text = "Label2"
        '
        'FrmTable_Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 709)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadButton10)
        Me.Controls.Add(Me.FlowLayoutPanelTable)
        Me.Controls.Add(Me.FlowLayoutPanelZone)
        Me.Name = "FrmTable_Manage"
        Me.Text = "FrmTable_Manage"
        CType(Me.RadButton10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanelTable As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelZone As FlowLayoutPanel
    Friend WithEvents RadButton10 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTableName As Label
End Class
