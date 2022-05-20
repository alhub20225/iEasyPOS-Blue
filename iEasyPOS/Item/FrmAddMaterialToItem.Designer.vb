<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddMaterialToItem
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxUnitUseMaterial = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTakeAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtInitCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsUnit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtmaterialName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCanCel = New System.Windows.Forms.Button()
        Me.TxtMatid = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxUnitUseMaterial)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtTakeAmount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtBalance)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtUnitCost)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtInitCost)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtUsUnit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtmaterialName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBoxUnitUseMaterial
        '
        Me.ComboBoxUnitUseMaterial.FormattingEnabled = True
        Me.ComboBoxUnitUseMaterial.Location = New System.Drawing.Point(382, 139)
        Me.ComboBoxUnitUseMaterial.Name = "ComboBoxUnitUseMaterial"
        Me.ComboBoxUnitUseMaterial.Size = New System.Drawing.Size(158, 32)
        Me.ComboBoxUnitUseMaterial.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "เลือกหน่วยใช้ :"
        '
        'TxtTakeAmount
        '
        Me.TxtTakeAmount.Location = New System.Drawing.Point(119, 136)
        Me.TxtTakeAmount.Name = "TxtTakeAmount"
        Me.TxtTakeAmount.Size = New System.Drawing.Size(157, 31)
        Me.TxtTakeAmount.TabIndex = 11
        Me.TxtTakeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "เบิกจำนวน:"
        '
        'TxtBalance
        '
        Me.TxtBalance.Location = New System.Drawing.Point(118, 100)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.Size = New System.Drawing.Size(158, 31)
        Me.TxtBalance.TabIndex = 9
        Me.TxtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "จำนวนคงเหลือ:"
        '
        'TxtUnitCost
        '
        Me.TxtUnitCost.Location = New System.Drawing.Point(386, 57)
        Me.TxtUnitCost.Name = "TxtUnitCost"
        Me.TxtUnitCost.ReadOnly = True
        Me.TxtUnitCost.Size = New System.Drawing.Size(154, 31)
        Me.TxtUnitCost.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ต้นทุน Vat :"
        '
        'TxtInitCost
        '
        Me.TxtInitCost.Location = New System.Drawing.Point(118, 57)
        Me.TxtInitCost.Name = "TxtInitCost"
        Me.TxtInitCost.ReadOnly = True
        Me.TxtInitCost.Size = New System.Drawing.Size(158, 31)
        Me.TxtInitCost.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ต้นทุนรวม:"
        '
        'TxtUsUnit
        '
        Me.TxtUsUnit.Location = New System.Drawing.Point(386, 100)
        Me.TxtUsUnit.Name = "TxtUsUnit"
        Me.TxtUsUnit.ReadOnly = True
        Me.TxtUsUnit.Size = New System.Drawing.Size(154, 31)
        Me.TxtUsUnit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "หน่วยตัดสูตร :"
        '
        'TxtmaterialName
        '
        Me.TxtmaterialName.Location = New System.Drawing.Point(118, 16)
        Me.TxtmaterialName.Name = "TxtmaterialName"
        Me.TxtmaterialName.ReadOnly = True
        Me.TxtmaterialName.Size = New System.Drawing.Size(368, 31)
        Me.TxtmaterialName.TabIndex = 1
        Me.TxtmaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "วัตุดิบ :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnAdd.Location = New System.Drawing.Point(253, 203)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(135, 47)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "ตกลง"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCanCel
        '
        Me.BtnCanCel.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnCanCel.Location = New System.Drawing.Point(413, 203)
        Me.BtnCanCel.Name = "BtnCanCel"
        Me.BtnCanCel.Size = New System.Drawing.Size(101, 47)
        Me.BtnCanCel.TabIndex = 2
        Me.BtnCanCel.Text = "ยกเลิก"
        Me.BtnCanCel.UseVisualStyleBackColor = True
        '
        'TxtMatid
        '
        Me.TxtMatid.Location = New System.Drawing.Point(22, 218)
        Me.TxtMatid.Name = "TxtMatid"
        Me.TxtMatid.ReadOnly = True
        Me.TxtMatid.Size = New System.Drawing.Size(100, 20)
        Me.TxtMatid.TabIndex = 10
        '
        'FrmAddMaterialToItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtMatid)
        Me.Controls.Add(Me.BtnCanCel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddMaterialToItem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnCanCel As Button
    Friend WithEvents TxtTakeAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBalance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUnitCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtInitCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUsUnit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtmaterialName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMatid As TextBox
    Friend WithEvents ComboBoxUnitUseMaterial As ComboBox
    Friend WithEvents Label7 As Label
End Class
