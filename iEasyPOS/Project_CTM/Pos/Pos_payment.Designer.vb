<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pos_payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_payment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPayTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelPayCash = New System.Windows.Forms.Panel()
        Me.ToggleSwitch = New Telerik.WinControls.UI.RadToggleSwitch()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelCashNumPad = New System.Windows.Forms.Panel()
        Me.btnNumPadEnter = New System.Windows.Forms.Button()
        Me.btnClearNumPad = New System.Windows.Forms.Button()
        Me.txtNumpad = New System.Windows.Forms.TextBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewSale = New System.Windows.Forms.DataGridView()
        Me.Pay_detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pay_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.BtnPayOrther = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelPayCash.SuspendLayout()
        CType(Me.ToggleSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelCashNumPad.SuspendLayout()
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPayTotal
        '
        Me.txtPayTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPayTotal.BackColor = System.Drawing.Color.White
        Me.txtPayTotal.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayTotal.Location = New System.Drawing.Point(64, 193)
        Me.txtPayTotal.Name = "txtPayTotal"
        Me.txtPayTotal.ReadOnly = True
        Me.txtPayTotal.Size = New System.Drawing.Size(233, 50)
        Me.txtPayTotal.TabIndex = 0
        Me.txtPayTotal.TabStop = False
        Me.txtPayTotal.Text = "0.00"
        Me.txtPayTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(410, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ชำระเงิน"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 100)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Kanit Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label3.Location = New System.Drawing.Point(141, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(625, 56)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "0.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(361, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 41)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ยอดที่ต้องชำระ"
        '
        'PanelPayCash
        '
        Me.PanelPayCash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelPayCash.BackColor = System.Drawing.Color.White
        Me.PanelPayCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPayCash.Controls.Add(Me.ToggleSwitch)
        Me.PanelPayCash.Controls.Add(Me.Panel3)
        Me.PanelPayCash.Controls.Add(Me.PanelCashNumPad)
        Me.PanelPayCash.Location = New System.Drawing.Point(389, 258)
        Me.PanelPayCash.Name = "PanelPayCash"
        Me.PanelPayCash.Size = New System.Drawing.Size(505, 342)
        Me.PanelPayCash.TabIndex = 6
        '
        'ToggleSwitch
        '
        Me.ToggleSwitch.Font = New System.Drawing.Font("Kanit Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleSwitch.ForeColor = System.Drawing.Color.White
        Me.ToggleSwitch.Location = New System.Drawing.Point(377, 3)
        Me.ToggleSwitch.Name = "ToggleSwitch"
        Me.ToggleSwitch.OffText = "ปุ่มด่วน"
        Me.ToggleSwitch.OnText = "ตัวเลข"
        Me.ToggleSwitch.Size = New System.Drawing.Size(122, 40)
        Me.ToggleSwitch.TabIndex = 51
        Me.ToggleSwitch.Text = "RadToggleSwitch1"
        CType(Me.ToggleSwitch.GetChildAt(0), Telerik.WinControls.UI.RadToggleSwitchElement).ThumbOffset = 102
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ToggleSwitchPartElement).Text = "ตัวเลข"
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ToggleSwitchPartElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BorderInnerColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BorderInnerColor2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BorderInnerColor3 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BorderInnerColor4 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).Text = "ปุ่มด่วน"
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.ToggleSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(107, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 317)
        Me.Panel3.TabIndex = 31
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Kanit Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button9.Location = New System.Drawing.Point(109, 246)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(84, 65)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "1000฿"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button10.Location = New System.Drawing.Point(6, 246)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(84, 65)
        Me.Button10.TabIndex = 25
        Me.Button10.Text = "500฿"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button7.Location = New System.Drawing.Point(109, 166)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 65)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "100฿"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button8.Location = New System.Drawing.Point(6, 166)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 65)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "50฿"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.Location = New System.Drawing.Point(109, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 65)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "20฿"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button6.Location = New System.Drawing.Point(6, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 65)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "10฿"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Location = New System.Drawing.Point(109, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 65)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "5฿"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(6, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 65)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "1฿"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PanelCashNumPad
        '
        Me.PanelCashNumPad.Controls.Add(Me.btnNumPadEnter)
        Me.PanelCashNumPad.Controls.Add(Me.btnClearNumPad)
        Me.PanelCashNumPad.Controls.Add(Me.txtNumpad)
        Me.PanelCashNumPad.Controls.Add(Me.Button20)
        Me.PanelCashNumPad.Controls.Add(Me.Button21)
        Me.PanelCashNumPad.Controls.Add(Me.Button17)
        Me.PanelCashNumPad.Controls.Add(Me.Button18)
        Me.PanelCashNumPad.Controls.Add(Me.Button19)
        Me.PanelCashNumPad.Controls.Add(Me.Button14)
        Me.PanelCashNumPad.Controls.Add(Me.Button15)
        Me.PanelCashNumPad.Controls.Add(Me.Button16)
        Me.PanelCashNumPad.Controls.Add(Me.Button13)
        Me.PanelCashNumPad.Controls.Add(Me.Button12)
        Me.PanelCashNumPad.Controls.Add(Me.Button11)
        Me.PanelCashNumPad.Location = New System.Drawing.Point(31, 0)
        Me.PanelCashNumPad.Name = "PanelCashNumPad"
        Me.PanelCashNumPad.Size = New System.Drawing.Size(340, 334)
        Me.PanelCashNumPad.TabIndex = 32
        Me.PanelCashNumPad.Visible = False
        '
        'btnNumPadEnter
        '
        Me.btnNumPadEnter.BackgroundImage = CType(resources.GetObject("btnNumPadEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnNumPadEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNumPadEnter.FlatAppearance.BorderSize = 0
        Me.btnNumPadEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNumPadEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumPadEnter.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNumPadEnter.Location = New System.Drawing.Point(177, 261)
        Me.btnNumPadEnter.Name = "btnNumPadEnter"
        Me.btnNumPadEnter.Size = New System.Drawing.Size(65, 65)
        Me.btnNumPadEnter.TabIndex = 45
        Me.btnNumPadEnter.Text = "ตกลง"
        Me.btnNumPadEnter.UseMnemonic = False
        Me.btnNumPadEnter.UseVisualStyleBackColor = True
        '
        'btnClearNumPad
        '
        Me.btnClearNumPad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearNumPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearNumPad.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClearNumPad.Location = New System.Drawing.Point(189, 3)
        Me.btnClearNumPad.Name = "btnClearNumPad"
        Me.btnClearNumPad.Size = New System.Drawing.Size(40, 40)
        Me.btnClearNumPad.TabIndex = 44
        Me.btnClearNumPad.Text = "X"
        Me.btnClearNumPad.UseVisualStyleBackColor = True
        '
        'txtNumpad
        '
        Me.txtNumpad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumpad.BackColor = System.Drawing.Color.White
        Me.txtNumpad.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumpad.Location = New System.Drawing.Point(16, 3)
        Me.txtNumpad.Name = "txtNumpad"
        Me.txtNumpad.Size = New System.Drawing.Size(167, 40)
        Me.txtNumpad.TabIndex = 43
        Me.txtNumpad.TabStop = False
        Me.txtNumpad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button20
        '
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button20.Location = New System.Drawing.Point(97, 261)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(65, 65)
        Me.Button20.TabIndex = 42
        Me.Button20.Text = "."
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.FlatAppearance.BorderSize = 0
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button21.Location = New System.Drawing.Point(16, 261)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(65, 65)
        Me.Button21.TabIndex = 41
        Me.Button21.Text = "0"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button17.Location = New System.Drawing.Point(177, 190)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(65, 65)
        Me.Button17.TabIndex = 39
        Me.Button17.Text = "9"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.BackgroundImage = CType(resources.GetObject("Button18.BackgroundImage"), System.Drawing.Image)
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button18.Location = New System.Drawing.Point(97, 190)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(65, 65)
        Me.Button18.TabIndex = 38
        Me.Button18.Text = "8"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button19.Location = New System.Drawing.Point(16, 190)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(65, 65)
        Me.Button19.TabIndex = 37
        Me.Button19.Text = "7"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button14.Location = New System.Drawing.Point(177, 119)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(65, 65)
        Me.Button14.TabIndex = 36
        Me.Button14.Text = "6"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button15.Location = New System.Drawing.Point(97, 119)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(65, 65)
        Me.Button15.TabIndex = 35
        Me.Button15.Text = "5"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.BackgroundImage = CType(resources.GetObject("Button16.BackgroundImage"), System.Drawing.Image)
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button16.Location = New System.Drawing.Point(16, 119)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(65, 65)
        Me.Button16.TabIndex = 34
        Me.Button16.Text = "4"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button13.Location = New System.Drawing.Point(177, 49)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(65, 65)
        Me.Button13.TabIndex = 33
        Me.Button13.Text = "3"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button12.Location = New System.Drawing.Point(97, 49)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(65, 65)
        Me.Button12.TabIndex = 32
        Me.Button12.Text = "2"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button11.Location = New System.Drawing.Point(16, 49)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(65, 65)
        Me.Button11.TabIndex = 31
        Me.Button11.Text = "1"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.White
        Me.Button26.Location = New System.Drawing.Point(547, 613)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(116, 65)
        Me.Button26.TabIndex = 36
        Me.Button26.Text = "ยกเลิก"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button25.Enabled = False
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button25.Location = New System.Drawing.Point(818, 185)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(88, 65)
        Me.Button25.TabIndex = 35
        Me.Button25.Text = "บัตรเงินสด"
        Me.Button25.UseVisualStyleBackColor = True
        Me.Button25.Visible = False
        '
        'Button24
        '
        Me.Button24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button24.Location = New System.Drawing.Point(486, 185)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(84, 65)
        Me.Button24.TabIndex = 34
        Me.Button24.Text = "บัตรเครดิต"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Button23.FlatAppearance.BorderSize = 0
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.White
        Me.Button23.Location = New System.Drawing.Point(405, 185)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(75, 65)
        Me.Button23.TabIndex = 33
        Me.Button23.Text = "เงินสด"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(13, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(308, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 65)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "จ่ายพอดี"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(117, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 41)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ยอดรับชำระ"
        '
        'DataGridViewSale
        '
        Me.DataGridViewSale.AllowUserToAddRows = False
        Me.DataGridViewSale.AllowUserToDeleteRows = False
        Me.DataGridViewSale.AllowUserToResizeRows = False
        Me.DataGridViewSale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridViewSale.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pay_detail, Me.Pay_amount, Me.SaleId})
        Me.DataGridViewSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewSale.Location = New System.Drawing.Point(1, 0)
        Me.DataGridViewSale.Name = "DataGridViewSale"
        Me.DataGridViewSale.ReadOnly = True
        Me.DataGridViewSale.RowHeadersVisible = False
        Me.DataGridViewSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSale.Size = New System.Drawing.Size(368, 340)
        Me.DataGridViewSale.TabIndex = 37
        '
        'Pay_detail
        '
        Me.Pay_detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Pay_detail.HeaderText = "ประเภทการชำระเงิน"
        Me.Pay_detail.Name = "Pay_detail"
        Me.Pay_detail.ReadOnly = True
        '
        'Pay_amount
        '
        Me.Pay_amount.HeaderText = "จำนวนเงิน"
        Me.Pay_amount.Name = "Pay_amount"
        Me.Pay_amount.ReadOnly = True
        Me.Pay_amount.Width = 110
        '
        'SaleId
        '
        Me.SaleId.HeaderText = "SaleId"
        Me.SaleId.Name = "SaleId"
        Me.SaleId.ReadOnly = True
        Me.SaleId.Visible = False
        '
        'Button27
        '
        Me.Button27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Button27.FlatAppearance.BorderSize = 0
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.White
        Me.Button27.Location = New System.Drawing.Point(337, 613)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(188, 65)
        Me.Button27.TabIndex = 38
        Me.Button27.Text = "ยืนยันการชำระเงิน"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button28.Location = New System.Drawing.Point(738, 185)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(75, 65)
        Me.Button28.TabIndex = 39
        Me.Button28.Text = "คูปอง"
        Me.Button28.UseVisualStyleBackColor = True
        Me.Button28.Visible = False
        '
        'Button29
        '
        Me.Button29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button29.Enabled = False
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button29.Location = New System.Drawing.Point(657, 185)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(75, 65)
        Me.Button29.TabIndex = 40
        Me.Button29.Text = "QR"
        Me.Button29.UseVisualStyleBackColor = True
        Me.Button29.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(571, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "เลือกการรับชำระ"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridViewSale)
        Me.Panel2.Location = New System.Drawing.Point(13, 258)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(370, 342)
        Me.Panel2.TabIndex = 43
        '
        'Button22
        '
        Me.Button22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Button22.FlatAppearance.BorderSize = 0
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.White
        Me.Button22.Location = New System.Drawing.Point(14, 613)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(132, 41)
        Me.Button22.TabIndex = 44
        Me.Button22.Text = "ลบการชำระเงิน"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(906, 42)
        Me.Top_tap.TabIndex = 3
        Me.Top_tap.TabStop = False
        '
        'BtnPayOrther
        '
        Me.BtnPayOrther.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPayOrther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPayOrther.Font = New System.Drawing.Font("Kanit Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayOrther.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnPayOrther.Location = New System.Drawing.Point(576, 185)
        Me.BtnPayOrther.Name = "BtnPayOrther"
        Me.BtnPayOrther.Size = New System.Drawing.Size(75, 65)
        Me.BtnPayOrther.TabIndex = 45
        Me.BtnPayOrther.Text = "อื่นๆ"
        Me.BtnPayOrther.UseVisualStyleBackColor = True
        '
        'Pos_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(906, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPayTotal)
        Me.Controls.Add(Me.BtnPayOrther)
        Me.Controls.Add(Me.PanelPayCash)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pos_payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelPayCash.ResumeLayout(False)
        CType(Me.ToggleSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelCashNumPad.ResumeLayout(False)
        Me.PanelCashNumPad.PerformLayout()
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelPayCash As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelCashNumPad As Panel
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents DataGridViewSale As DataGridView
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPayTotal As TextBox
    Friend WithEvents btnNumPadEnter As Button
    Friend WithEvents btnClearNumPad As Button
    Friend WithEvents txtNumpad As TextBox
    Friend WithEvents Button22 As Button
    Friend WithEvents ToggleSwitch As Telerik.WinControls.UI.RadToggleSwitch
    Friend WithEvents BtnPayOrther As Button
    Friend WithEvents Pay_detail As DataGridViewTextBoxColumn
    Friend WithEvents Pay_amount As DataGridViewTextBoxColumn
    Friend WithEvents SaleId As DataGridViewTextBoxColumn
End Class
