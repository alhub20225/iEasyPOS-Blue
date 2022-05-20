<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoryTopping
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownMaxNumber = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadDropDownPrinter = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanelCateTopping = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.NumericUpDownMaxNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RadDropDownPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(191, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(173, 31)
        Me.txtName.TabIndex = 0
        '
        'txtName2
        '
        Me.txtName2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtName2.Location = New System.Drawing.Point(191, 77)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(173, 31)
        Me.txtName2.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.txtCode.Location = New System.Drawing.Point(191, 122)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(173, 31)
        Me.txtCode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(79, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ชื่อ (ภาษาไทย) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(56, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อ (ภาษาอังกฤษ) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "รหัสหมวดหมู Topping  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(117, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Max Id  :"
        '
        'NumericUpDownMaxNumber
        '
        Me.NumericUpDownMaxNumber.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.NumericUpDownMaxNumber.Location = New System.Drawing.Point(191, 163)
        Me.NumericUpDownMaxNumber.Name = "NumericUpDownMaxNumber"
        Me.NumericUpDownMaxNumber.Size = New System.Drawing.Size(173, 31)
        Me.NumericUpDownMaxNumber.TabIndex = 7
        Me.NumericUpDownMaxNumber.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(117, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Printer  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadDropDownPrinter)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName2)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownMaxNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(428, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 303)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลหมวดหมู่ Topping"
        '
        'RadDropDownPrinter
        '
        Me.RadDropDownPrinter.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.RadDropDownPrinter.Location = New System.Drawing.Point(190, 198)
        Me.RadDropDownPrinter.Name = "RadDropDownPrinter"
        Me.RadDropDownPrinter.Size = New System.Drawing.Size(174, 29)
        Me.RadDropDownPrinter.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(268, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 34)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.btnDel.Location = New System.Drawing.Point(40, 253)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(96, 34)
        Me.btnDel.TabIndex = 11
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.btnClear.Location = New System.Drawing.Point(156, 253)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 34)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "เพิ่ม"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanelCateTopping)
        Me.GroupBox2.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 303)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "หมวดหมู่ Topping"
        '
        'FlowLayoutPanelCateTopping
        '
        Me.FlowLayoutPanelCateTopping.Location = New System.Drawing.Point(6, 19)
        Me.FlowLayoutPanelCateTopping.Name = "FlowLayoutPanelCateTopping"
        Me.FlowLayoutPanelCateTopping.Size = New System.Drawing.Size(396, 278)
        Me.FlowLayoutPanelCateTopping.TabIndex = 0
        '
        'FrmCategoryTopping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 338)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCategoryTopping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.NumericUpDownMaxNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RadDropDownPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownMaxNumber As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlowLayoutPanelCateTopping As FlowLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents RadDropDownPrinter As Telerik.WinControls.UI.RadDropDownList
End Class
