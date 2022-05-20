<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosPromotion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PosPromotion))
        Me.PromotionGiftItem = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelProName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PromotionGiftItem
        '
        resources.ApplyResources(Me.PromotionGiftItem, "PromotionGiftItem")
        Me.PromotionGiftItem.Name = "PromotionGiftItem"
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'LabelProName
        '
        resources.ApplyResources(Me.LabelProName, "LabelProName")
        Me.LabelProName.Name = "LabelProName"
        '
        'PosPromotion
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Controls.Add(Me.LabelProName)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PromotionGiftItem)
        Me.MinimizeBox = False
        Me.Name = "PosPromotion"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PromotionGiftItem As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LabelProName As Label
End Class
