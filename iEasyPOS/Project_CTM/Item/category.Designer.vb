<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class category
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanelCatemenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoryGroupItem = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericItemCode = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCatecode = New System.Windows.Forms.TextBox()
        Me.PictureBoxResize = New System.Windows.Forms.PictureBox()
        Me.BtnClearImage = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCateNameEN = New System.Windows.Forms.TextBox()
        Me.PictureBoxCategory = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RadBrowseEditorImageCate = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadColorFontCate = New Telerik.WinControls.UI.RadColorBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadColorBtnCate = New Telerik.WinControls.UI.RadColorBox()
        Me.ComboCateType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBoxAllowPrint = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxCateDiscount = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCateName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDeleteCate = New System.Windows.Forms.Button()
        Me.BtnAddCate = New System.Windows.Forms.Button()
        Me.Close_item = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NumericItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxResize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBrowseEditorImageCate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadColorFontCate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadColorBtnCate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "หมวดหมู่สินค้า"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanelCatemenu)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 671)
        Me.SplitContainer1.SplitterDistance = 383
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 9
        '
        'FlowLayoutPanelCatemenu
        '
        Me.FlowLayoutPanelCatemenu.AutoScroll = True
        Me.FlowLayoutPanelCatemenu.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelCatemenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelCatemenu.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FlowLayoutPanelCatemenu.Location = New System.Drawing.Point(3, 0)
        Me.FlowLayoutPanelCatemenu.Name = "FlowLayoutPanelCatemenu"
        Me.FlowLayoutPanelCatemenu.Size = New System.Drawing.Size(380, 671)
        Me.FlowLayoutPanelCatemenu.TabIndex = 4
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 671)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 50)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(871, 671)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CategoryGroupItem)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.NumericItemCode)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TxtCatecode)
        Me.TabPage1.Controls.Add(Me.PictureBoxResize)
        Me.TabPage1.Controls.Add(Me.BtnClearImage)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtCateNameEN)
        Me.TabPage1.Controls.Add(Me.PictureBoxCategory)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.RadBrowseEditorImageCate)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.RadColorFontCate)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.RadColorBtnCate)
        Me.TabPage1.Controls.Add(Me.ComboCateType)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.CheckBoxAllowPrint)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ComboBoxPrinter)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.CheckBoxCateDiscount)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtCateName)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Controls.Add(Me.BtnDeleteCate)
        Me.TabPage1.Controls.Add(Me.BtnAddCate)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(863, 613)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ตั้งค่าหมวดหมู่"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(209, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "กลุ่ม"
        '
        'CategoryGroupItem
        '
        Me.CategoryGroupItem.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.CategoryGroupItem.FormattingEnabled = True
        Me.CategoryGroupItem.Location = New System.Drawing.Point(262, 267)
        Me.CategoryGroupItem.Name = "CategoryGroupItem"
        Me.CategoryGroupItem.Size = New System.Drawing.Size(246, 32)
        Me.CategoryGroupItem.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(123, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 24)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "จำนวนหลักเลขรหัส"
        '
        'NumericItemCode
        '
        Me.NumericItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NumericItemCode.Location = New System.Drawing.Point(262, 69)
        Me.NumericItemCode.Name = "NumericItemCode"
        Me.NumericItemCode.Size = New System.Drawing.Size(65, 29)
        Me.NumericItemCode.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(144, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 24)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "รหัสหมวดสินค้า"
        '
        'TxtCatecode
        '
        Me.TxtCatecode.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.TxtCatecode.Location = New System.Drawing.Point(262, 27)
        Me.TxtCatecode.Name = "TxtCatecode"
        Me.TxtCatecode.Size = New System.Drawing.Size(148, 36)
        Me.TxtCatecode.TabIndex = 49
        '
        'PictureBoxResize
        '
        Me.PictureBoxResize.Location = New System.Drawing.Point(381, 362)
        Me.PictureBoxResize.Name = "PictureBoxResize"
        Me.PictureBoxResize.Size = New System.Drawing.Size(195, 108)
        Me.PictureBoxResize.TabIndex = 48
        Me.PictureBoxResize.TabStop = False
        Me.PictureBoxResize.Visible = False
        '
        'BtnClearImage
        '
        Me.BtnClearImage.Font = New System.Drawing.Font("Kanit", 9.75!)
        Me.BtnClearImage.Location = New System.Drawing.Point(763, 188)
        Me.BtnClearImage.Name = "BtnClearImage"
        Me.BtnClearImage.Size = New System.Drawing.Size(112, 37)
        Me.BtnClearImage.TabIndex = 47
        Me.BtnClearImage.Text = "Clear Image"
        Me.BtnClearImage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(125, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "ชื่อหมวดสินค้า EN"
        '
        'TxtCateNameEN
        '
        Me.TxtCateNameEN.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.TxtCateNameEN.Location = New System.Drawing.Point(262, 165)
        Me.TxtCateNameEN.Name = "TxtCateNameEN"
        Me.TxtCateNameEN.Size = New System.Drawing.Size(246, 36)
        Me.TxtCateNameEN.TabIndex = 45
        '
        'PictureBoxCategory
        '
        Me.PictureBoxCategory.Location = New System.Drawing.Point(582, 267)
        Me.PictureBoxCategory.Name = "PictureBoxCategory"
        Me.PictureBoxCategory.Size = New System.Drawing.Size(315, 203)
        Me.PictureBoxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCategory.TabIndex = 44
        Me.PictureBoxCategory.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(580, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 24)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Image"
        '
        'RadBrowseEditorImageCate
        '
        Me.RadBrowseEditorImageCate.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.RadBrowseEditorImageCate.Location = New System.Drawing.Point(685, 152)
        Me.RadBrowseEditorImageCate.Name = "RadBrowseEditorImageCate"
        Me.RadBrowseEditorImageCate.Size = New System.Drawing.Size(190, 30)
        Me.RadBrowseEditorImageCate.TabIndex = 42
        Me.RadBrowseEditorImageCate.Text = "RadBrowseEditor1"
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0), Telerik.WinControls.UI.RadBrowseEditorElement).Text = "(none)"
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.BrowseEditorButton).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadBrowseEditorImageCate.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(554, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Font color"
        '
        'RadColorFontCate
        '
        Me.RadColorFontCate.BackColor = System.Drawing.Color.Black
        Me.RadColorFontCate.EnableTheming = False
        Me.RadColorFontCate.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadColorFontCate.Location = New System.Drawing.Point(685, 88)
        Me.RadColorFontCate.Name = "RadColorFontCate"
        Me.RadColorFontCate.Size = New System.Drawing.Size(190, 35)
        Me.RadColorFontCate.TabIndex = 18
        Me.RadColorFontCate.Text = "RadColorBox2"
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderColor = System.Drawing.SystemColors.ActiveBorder
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderLeftColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderRightColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderBottomColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorFontCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(577, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Button"
        '
        'RadColorBtnCate
        '
        Me.RadColorBtnCate.BackColor = System.Drawing.Color.Black
        Me.RadColorBtnCate.EnableTheming = False
        Me.RadColorBtnCate.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadColorBtnCate.Location = New System.Drawing.Point(685, 22)
        Me.RadColorBtnCate.Name = "RadColorBtnCate"
        Me.RadColorBtnCate.Size = New System.Drawing.Size(190, 35)
        Me.RadColorBtnCate.TabIndex = 16
        Me.RadColorBtnCate.Text = "RadColorBox1"
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderColor = System.Drawing.SystemColors.ActiveBorder
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderLeftColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderRightColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.ColorEditorColorBox).BorderBottomColor = System.Drawing.SystemColors.AppWorkspace
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        CType(Me.RadColorBtnCate.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).ForeColor = System.Drawing.SystemColors.ControlDark
        '
        'ComboCateType
        '
        Me.ComboCateType.CausesValidation = False
        Me.ComboCateType.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.ComboCateType.FormattingEnabled = True
        Me.ComboCateType.Location = New System.Drawing.Point(262, 219)
        Me.ComboCateType.Name = "ComboCateType"
        Me.ComboCateType.Size = New System.Drawing.Size(246, 32)
        Me.ComboCateType.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(176, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ชนิดสินค้า"
        '
        'CheckBoxAllowPrint
        '
        Me.CheckBoxAllowPrint.Location = New System.Drawing.Point(262, 431)
        Me.CheckBoxAllowPrint.Name = "CheckBoxAllowPrint"
        Me.CheckBoxAllowPrint.Size = New System.Drawing.Size(30, 30)
        Me.CheckBoxAllowPrint.TabIndex = 13
        Me.CheckBoxAllowPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxAllowPrint.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(164, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Allow print"
        '
        'ComboBoxPrinter
        '
        Me.ComboBoxPrinter.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.ComboBoxPrinter.FormattingEnabled = True
        Me.ComboBoxPrinter.Location = New System.Drawing.Point(262, 316)
        Me.ComboBoxPrinter.Name = "ComboBoxPrinter"
        Me.ComboBoxPrinter.Size = New System.Drawing.Size(246, 32)
        Me.ComboBoxPrinter.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(190, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Printer"
        '
        'CheckBoxCateDiscount
        '
        Me.CheckBoxCateDiscount.Location = New System.Drawing.Point(262, 376)
        Me.CheckBoxCateDiscount.Name = "CheckBoxCateDiscount"
        Me.CheckBoxCateDiscount.Size = New System.Drawing.Size(30, 30)
        Me.CheckBoxCateDiscount.TabIndex = 9
        Me.CheckBoxCateDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxCateDiscount.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(173, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(151, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ชื่อหมวดสินค้า"
        '
        'TxtCateName
        '
        Me.TxtCateName.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.TxtCateName.Location = New System.Drawing.Point(262, 112)
        Me.TxtCateName.Name = "TxtCateName"
        Me.TxtCateName.Size = New System.Drawing.Size(246, 36)
        Me.TxtCateName.TabIndex = 5
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnSave.Location = New System.Drawing.Point(326, 562)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 45)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDeleteCate
        '
        Me.BtnDeleteCate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteCate.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnDeleteCate.Location = New System.Drawing.Point(146, 562)
        Me.BtnDeleteCate.Name = "BtnDeleteCate"
        Me.BtnDeleteCate.Size = New System.Drawing.Size(133, 45)
        Me.BtnDeleteCate.TabIndex = 1
        Me.BtnDeleteCate.Text = "ลบ"
        Me.BtnDeleteCate.UseVisualStyleBackColor = True
        '
        'BtnAddCate
        '
        Me.BtnAddCate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddCate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddCate.Font = New System.Drawing.Font("Kanit", 12.0!)
        Me.BtnAddCate.Location = New System.Drawing.Point(7, 562)
        Me.BtnAddCate.Name = "BtnAddCate"
        Me.BtnAddCate.Size = New System.Drawing.Size(133, 45)
        Me.BtnAddCate.TabIndex = 0
        Me.BtnAddCate.Text = "เพิ่ม"
        Me.BtnAddCate.UseVisualStyleBackColor = True
        '
        'Close_item
        '
        Me.Close_item.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_item.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Close_item.FlatAppearance.BorderSize = 0
        Me.Close_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_item.Image = Global.Project_CTM.My.Resources.Resources.times_circle_o1
        Me.Close_item.Location = New System.Drawing.Point(1205, 0)
        Me.Close_item.Name = "Close_item"
        Me.Close_item.Size = New System.Drawing.Size(59, 56)
        Me.Close_item.TabIndex = 8
        Me.Close_item.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(1264, 58)
        Me.Top_tap.TabIndex = 6
        Me.Top_tap.TabStop = False
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Close_item)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "category"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.NumericItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxResize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBrowseEditorImageCate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadColorFontCate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadColorBtnCate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_item As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents FlowLayoutPanelCatemenu As FlowLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDeleteCate As Button
    Friend WithEvents BtnAddCate As Button
    Friend WithEvents CheckBoxCateDiscount As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCateName As TextBox
    Friend WithEvents ComboCateType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBoxAllowPrint As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxPrinter As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RadColorBtnCate As Telerik.WinControls.UI.RadColorBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RadColorFontCate As Telerik.WinControls.UI.RadColorBox
    Friend WithEvents Label14 As Label
    Friend WithEvents RadBrowseEditorImageCate As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents PictureBoxCategory As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCateNameEN As TextBox
    Friend WithEvents BtnClearImage As Button
    Friend WithEvents PictureBoxResize As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCatecode As TextBox
    Friend WithEvents NumericItemCode As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CategoryGroupItem As ComboBox
End Class
