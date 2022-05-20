<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SystemSetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckUseTable = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnSaveReceipText = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DropDownPrinterName = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSavePrinterSetting = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFooter2 = New System.Windows.Forms.TextBox()
        Me.txtHeader1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHeader2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFooter1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBoxPrintOption = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DropDownPrinterName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(383, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 740)
        Me.Panel2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckUseTable)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(60, 20, 10, 10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(388, 740)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kanit", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(63, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 29)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "ตั้งค่าระบบ"
        '
        'CheckUseTable
        '
        Me.CheckUseTable.AutoSize = True
        Me.CheckUseTable.Checked = True
        Me.CheckUseTable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckUseTable.Font = New System.Drawing.Font("Kanit", 14.0!)
        Me.CheckUseTable.Location = New System.Drawing.Point(63, 52)
        Me.CheckUseTable.Name = "CheckUseTable"
        Me.CheckUseTable.Size = New System.Drawing.Size(113, 33)
        Me.CheckUseTable.TabIndex = 58
        Me.CheckUseTable.Text = "ใช้ระบบโต๊ะ"
        Me.CheckUseTable.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Kanit", 14.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(63, 91)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(41, 33)
        Me.CheckBox3.TabIndex = 59
        Me.CheckBox3.Text = "..."
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Kanit", 14.0!)
        Me.CheckBox4.Location = New System.Drawing.Point(63, 130)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(41, 33)
        Me.CheckBox4.TabIndex = 60
        Me.CheckBox4.Text = "..."
        Me.CheckBox4.UseVisualStyleBackColor = True
        Me.CheckBox4.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(771, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(348, 740)
        Me.Panel3.TabIndex = 2
        '
        'BtnSaveReceipText
        '
        Me.BtnSaveReceipText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveReceipText.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.BtnSaveReceipText.Location = New System.Drawing.Point(3, 698)
        Me.BtnSaveReceipText.Name = "BtnSaveReceipText"
        Me.BtnSaveReceipText.Size = New System.Drawing.Size(110, 39)
        Me.BtnSaveReceipText.TabIndex = 63
        Me.BtnSaveReceipText.Text = "บันทึก"
        Me.BtnSaveReceipText.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(9, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Printer"
        '
        'DropDownPrinterName
        '
        Me.DropDownPrinterName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.DropDownPrinterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropDownPrinterName.Location = New System.Drawing.Point(80, 73)
        Me.DropDownPrinterName.Name = "DropDownPrinterName"
        Me.DropDownPrinterName.Size = New System.Drawing.Size(290, 27)
        Me.DropDownPrinterName.TabIndex = 52
        Me.DropDownPrinterName.UseCompatibleTextRendering = False
        CType(Me.DropDownPrinterName.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        CType(Me.DropDownPrinterName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDarkDark
        CType(Me.DropDownPrinterName.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ButtonShadow
        CType(Me.DropDownPrinterName.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.AppWorkspace
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 29)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "ตั้งค่าปริ้นเตอร์ ใบเสร็จ"
        '
        'BtnSavePrinterSetting
        '
        Me.BtnSavePrinterSetting.Font = New System.Drawing.Font("Kanit", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePrinterSetting.Location = New System.Drawing.Point(302, 125)
        Me.BtnSavePrinterSetting.Name = "BtnSavePrinterSetting"
        Me.BtnSavePrinterSetting.Size = New System.Drawing.Size(68, 35)
        Me.BtnSavePrinterSetting.TabIndex = 54
        Me.BtnSavePrinterSetting.Text = "Save"
        Me.BtnSavePrinterSetting.UseVisualStyleBackColor = True
        Me.BtnSavePrinterSetting.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSaveReceipText)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 740)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtFooter2)
        Me.Panel5.Controls.Add(Me.txtHeader1)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtHeader2)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtFooter1)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 217)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(383, 297)
        Me.Panel5.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 29)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "ตั้งค่าใบเสร็จ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(10, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 29)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "หัวใบเสร็จ 2"
        '
        'txtFooter2
        '
        Me.txtFooter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFooter2.Location = New System.Drawing.Point(137, 171)
        Me.txtFooter2.Name = "txtFooter2"
        Me.txtFooter2.Size = New System.Drawing.Size(234, 29)
        Me.txtFooter2.TabIndex = 62
        '
        'txtHeader1
        '
        Me.txtHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeader1.Location = New System.Drawing.Point(137, 66)
        Me.txtHeader1.Name = "txtHeader1"
        Me.txtHeader1.Size = New System.Drawing.Size(234, 29)
        Me.txtHeader1.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(10, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 29)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "ท้ายใบเสร็จ 2"
        '
        'txtHeader2
        '
        Me.txtHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeader2.Location = New System.Drawing.Point(137, 101)
        Me.txtHeader2.Name = "txtHeader2"
        Me.txtHeader2.Size = New System.Drawing.Size(234, 29)
        Me.txtHeader2.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(10, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 29)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "หัวใบเสร็จ 1"
        '
        'txtFooter1
        '
        Me.txtFooter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFooter1.Location = New System.Drawing.Point(137, 136)
        Me.txtFooter1.Name = "txtFooter1"
        Me.txtFooter1.Size = New System.Drawing.Size(234, 29)
        Me.txtFooter1.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(10, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 29)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "ท้ายใบเสร็จ 1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnSavePrinterSetting)
        Me.Panel4.Controls.Add(Me.CheckBoxPrintOption)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.DropDownPrinterName)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(383, 217)
        Me.Panel4.TabIndex = 56
        '
        'CheckBoxPrintOption
        '
        Me.CheckBoxPrintOption.AutoSize = True
        Me.CheckBoxPrintOption.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.CheckBoxPrintOption.Location = New System.Drawing.Point(80, 125)
        Me.CheckBoxPrintOption.Name = "CheckBoxPrintOption"
        Me.CheckBoxPrintOption.Size = New System.Drawing.Size(157, 28)
        Me.CheckBoxPrintOption.TabIndex = 55
        Me.CheckBoxPrintOption.Text = "พิมพ์ใบเสร็จทุกครั้ง"
        Me.CheckBoxPrintOption.UseVisualStyleBackColor = True
        '
        'SystemSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1189, 740)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SystemSetting"
        Me.Text = "SystemSetting"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.DropDownPrinterName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DropDownPrinterName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSavePrinterSetting As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFooter2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFooter1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHeader2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHeader1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBoxPrintOption As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnSaveReceipText As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckUseTable As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
End Class
