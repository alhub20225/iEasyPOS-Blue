<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCloseShift = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.date_show = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Label()
        Me.LbUserName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnShowFrmPos = New System.Windows.Forms.Button()
        Me.BtnShowFrmTable = New System.Windows.Forms.Button()
        Me.BtnFrmRePrintBill = New System.Windows.Forms.Button()
        Me.BtnShowFrmItem = New System.Windows.Forms.Button()
        Me.BtnFrmCategoryShow = New System.Windows.Forms.Button()
        Me.BtnShowFrmInventory = New System.Windows.Forms.Button()
        Me.BtnFrmMaterialShow = New System.Windows.Forms.Button()
        Me.BtnShowFrmReport = New System.Windows.Forms.Button()
        Me.BtnFrmManageCustomerShow = New System.Windows.Forms.Button()
        Me.BtnTimeCard = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSettigProgram = New System.Windows.Forms.Button()
        Me.Close_main = New System.Windows.Forms.Button()
        Me.Top_tap = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnCloseShift)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 570)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 66)
        Me.Panel1.TabIndex = 13
        '
        'BtnCloseShift
        '
        Me.BtnCloseShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseShift.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCloseShift.Location = New System.Drawing.Point(99, 15)
        Me.BtnCloseShift.Name = "BtnCloseShift"
        Me.BtnCloseShift.Size = New System.Drawing.Size(127, 39)
        Me.BtnCloseShift.TabIndex = 7
        Me.BtnCloseShift.Text = "ปิดกะการขาย"
        Me.BtnCloseShift.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.BackgroundImage = Global.Project_CTM.My.Resources.Resources._exit
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(828, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(60, 58)
        Me.Button10.TabIndex = 6
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(463, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "กะการขายที่ :"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(322, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "การขายวันที่ :"
        Me.Label4.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.date_show)
        Me.Panel2.Controls.Add(Me.timer)
        Me.Panel2.Controls.Add(Me.LbUserName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(896, 46)
        Me.Panel2.TabIndex = 14
        '
        'date_show
        '
        Me.date_show.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.date_show.AutoSize = True
        Me.date_show.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.date_show.Location = New System.Drawing.Point(622, 12)
        Me.date_show.Name = "date_show"
        Me.date_show.Size = New System.Drawing.Size(49, 27)
        Me.date_show.TabIndex = 30
        Me.date_show.Text = "date"
        '
        'timer
        '
        Me.timer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timer.AutoSize = True
        Me.timer.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.timer.Location = New System.Drawing.Point(771, 12)
        Me.timer.Name = "timer"
        Me.timer.Size = New System.Drawing.Size(50, 27)
        Me.timer.TabIndex = 29
        Me.timer.Text = "time"
        '
        'LbUserName
        '
        Me.LbUserName.AutoSize = True
        Me.LbUserName.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.LbUserName.Location = New System.Drawing.Point(139, 12)
        Me.LbUserName.Name = "LbUserName"
        Me.LbUserName.Size = New System.Drawing.Size(66, 27)
        Me.LbUserName.TabIndex = 1
        Me.LbUserName.Text = "Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(51, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 447)
        Me.Panel3.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(834, 123)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(62, 447)
        Me.Panel4.TabIndex = 16
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(55, 123)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(779, 447)
        Me.Panel5.TabIndex = 17
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnShowFrmPos)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnShowFrmTable)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnFrmRePrintBill)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnShowFrmItem)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnFrmCategoryShow)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnShowFrmInventory)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnFrmMaterialShow)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnShowFrmReport)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnFrmManageCustomerShow)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnTimeCard)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20, 30, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(779, 447)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'BtnShowFrmPos
        '
        Me.BtnShowFrmPos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnShowFrmPos.BackColor = System.Drawing.Color.White
        Me.BtnShowFrmPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShowFrmPos.FlatAppearance.BorderSize = 0
        Me.BtnShowFrmPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowFrmPos.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnShowFrmPos.ForeColor = System.Drawing.Color.Black
        Me.BtnShowFrmPos.Image = CType(resources.GetObject("BtnShowFrmPos.Image"), System.Drawing.Image)
        Me.BtnShowFrmPos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShowFrmPos.Location = New System.Drawing.Point(23, 33)
        Me.BtnShowFrmPos.Name = "BtnShowFrmPos"
        Me.BtnShowFrmPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnShowFrmPos.Size = New System.Drawing.Size(135, 140)
        Me.BtnShowFrmPos.TabIndex = 1
        Me.BtnShowFrmPos.Text = "ขายสินค้า"
        Me.BtnShowFrmPos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnShowFrmPos.UseVisualStyleBackColor = False
        Me.BtnShowFrmPos.Visible = False
        '
        'BtnShowFrmTable
        '
        Me.BtnShowFrmTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnShowFrmTable.BackColor = System.Drawing.Color.White
        Me.BtnShowFrmTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShowFrmTable.FlatAppearance.BorderSize = 0
        Me.BtnShowFrmTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowFrmTable.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnShowFrmTable.ForeColor = System.Drawing.Color.Black
        Me.BtnShowFrmTable.Image = Global.Project_CTM.My.Resources.Resources.list_1
        Me.BtnShowFrmTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShowFrmTable.Location = New System.Drawing.Point(164, 33)
        Me.BtnShowFrmTable.Name = "BtnShowFrmTable"
        Me.BtnShowFrmTable.Size = New System.Drawing.Size(135, 140)
        Me.BtnShowFrmTable.TabIndex = 2
        Me.BtnShowFrmTable.Text = "ระบบโต๊ะ"
        Me.BtnShowFrmTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnShowFrmTable.UseVisualStyleBackColor = False
        '
        'BtnFrmRePrintBill
        '
        Me.BtnFrmRePrintBill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFrmRePrintBill.BackColor = System.Drawing.Color.White
        Me.BtnFrmRePrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFrmRePrintBill.FlatAppearance.BorderSize = 0
        Me.BtnFrmRePrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFrmRePrintBill.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnFrmRePrintBill.ForeColor = System.Drawing.Color.Black
        Me.BtnFrmRePrintBill.Image = Global.Project_CTM.My.Resources.Resources.search_1
        Me.BtnFrmRePrintBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFrmRePrintBill.Location = New System.Drawing.Point(305, 33)
        Me.BtnFrmRePrintBill.Name = "BtnFrmRePrintBill"
        Me.BtnFrmRePrintBill.Size = New System.Drawing.Size(135, 140)
        Me.BtnFrmRePrintBill.TabIndex = 3
        Me.BtnFrmRePrintBill.Text = "ค้นบิล"
        Me.BtnFrmRePrintBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFrmRePrintBill.UseVisualStyleBackColor = False
        Me.BtnFrmRePrintBill.Visible = False
        '
        'BtnShowFrmItem
        '
        Me.BtnShowFrmItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnShowFrmItem.BackColor = System.Drawing.Color.White
        Me.BtnShowFrmItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShowFrmItem.FlatAppearance.BorderSize = 0
        Me.BtnShowFrmItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowFrmItem.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnShowFrmItem.ForeColor = System.Drawing.Color.Black
        Me.BtnShowFrmItem.Image = Global.Project_CTM.My.Resources.Resources.archive1
        Me.BtnShowFrmItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShowFrmItem.Location = New System.Drawing.Point(446, 33)
        Me.BtnShowFrmItem.Name = "BtnShowFrmItem"
        Me.BtnShowFrmItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnShowFrmItem.Size = New System.Drawing.Size(135, 140)
        Me.BtnShowFrmItem.TabIndex = 6
        Me.BtnShowFrmItem.Text = "สินค้า"
        Me.BtnShowFrmItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnShowFrmItem.UseVisualStyleBackColor = False
        Me.BtnShowFrmItem.Visible = False
        '
        'BtnFrmCategoryShow
        '
        Me.BtnFrmCategoryShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFrmCategoryShow.BackColor = System.Drawing.Color.White
        Me.BtnFrmCategoryShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFrmCategoryShow.FlatAppearance.BorderSize = 0
        Me.BtnFrmCategoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFrmCategoryShow.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnFrmCategoryShow.ForeColor = System.Drawing.Color.Black
        Me.BtnFrmCategoryShow.Image = Global.Project_CTM.My.Resources.Resources.archive_1
        Me.BtnFrmCategoryShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFrmCategoryShow.Location = New System.Drawing.Point(587, 33)
        Me.BtnFrmCategoryShow.Name = "BtnFrmCategoryShow"
        Me.BtnFrmCategoryShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnFrmCategoryShow.Size = New System.Drawing.Size(135, 140)
        Me.BtnFrmCategoryShow.TabIndex = 7
        Me.BtnFrmCategoryShow.Text = "กลุ่มสินค้า"
        Me.BtnFrmCategoryShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFrmCategoryShow.UseVisualStyleBackColor = False
        Me.BtnFrmCategoryShow.Visible = False
        '
        'BtnShowFrmInventory
        '
        Me.BtnShowFrmInventory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnShowFrmInventory.BackColor = System.Drawing.Color.White
        Me.BtnShowFrmInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShowFrmInventory.FlatAppearance.BorderSize = 0
        Me.BtnShowFrmInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowFrmInventory.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnShowFrmInventory.ForeColor = System.Drawing.Color.Black
        Me.BtnShowFrmInventory.Image = Global.Project_CTM.My.Resources.Resources.archive_2
        Me.BtnShowFrmInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShowFrmInventory.Location = New System.Drawing.Point(23, 179)
        Me.BtnShowFrmInventory.Name = "BtnShowFrmInventory"
        Me.BtnShowFrmInventory.Size = New System.Drawing.Size(135, 140)
        Me.BtnShowFrmInventory.TabIndex = 8
        Me.BtnShowFrmInventory.Text = "คลังสินค้า"
        Me.BtnShowFrmInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnShowFrmInventory.UseVisualStyleBackColor = False
        Me.BtnShowFrmInventory.Visible = False
        '
        'BtnFrmMaterialShow
        '
        Me.BtnFrmMaterialShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFrmMaterialShow.BackColor = System.Drawing.Color.White
        Me.BtnFrmMaterialShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFrmMaterialShow.FlatAppearance.BorderSize = 0
        Me.BtnFrmMaterialShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFrmMaterialShow.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnFrmMaterialShow.ForeColor = System.Drawing.Color.Black
        Me.BtnFrmMaterialShow.Image = Global.Project_CTM.My.Resources.Resources.archive_3
        Me.BtnFrmMaterialShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFrmMaterialShow.Location = New System.Drawing.Point(164, 179)
        Me.BtnFrmMaterialShow.Name = "BtnFrmMaterialShow"
        Me.BtnFrmMaterialShow.Size = New System.Drawing.Size(135, 140)
        Me.BtnFrmMaterialShow.TabIndex = 9
        Me.BtnFrmMaterialShow.Text = "วัตถุดิบ"
        Me.BtnFrmMaterialShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFrmMaterialShow.UseVisualStyleBackColor = False
        Me.BtnFrmMaterialShow.Visible = False
        '
        'BtnShowFrmReport
        '
        Me.BtnShowFrmReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnShowFrmReport.BackColor = System.Drawing.Color.White
        Me.BtnShowFrmReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShowFrmReport.FlatAppearance.BorderSize = 0
        Me.BtnShowFrmReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowFrmReport.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnShowFrmReport.ForeColor = System.Drawing.Color.Black
        Me.BtnShowFrmReport.Image = Global.Project_CTM.My.Resources.Resources.folder_9
        Me.BtnShowFrmReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShowFrmReport.Location = New System.Drawing.Point(305, 179)
        Me.BtnShowFrmReport.Name = "BtnShowFrmReport"
        Me.BtnShowFrmReport.Size = New System.Drawing.Size(135, 140)
        Me.BtnShowFrmReport.TabIndex = 4
        Me.BtnShowFrmReport.Text = "รายงาน"
        Me.BtnShowFrmReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnShowFrmReport.UseVisualStyleBackColor = False
        Me.BtnShowFrmReport.Visible = False
        '
        'BtnFrmManageCustomerShow
        '
        Me.BtnFrmManageCustomerShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFrmManageCustomerShow.BackColor = System.Drawing.Color.White
        Me.BtnFrmManageCustomerShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFrmManageCustomerShow.FlatAppearance.BorderSize = 0
        Me.BtnFrmManageCustomerShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFrmManageCustomerShow.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnFrmManageCustomerShow.ForeColor = System.Drawing.Color.Black
        Me.BtnFrmManageCustomerShow.Image = Global.Project_CTM.My.Resources.Resources.users1
        Me.BtnFrmManageCustomerShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFrmManageCustomerShow.Location = New System.Drawing.Point(446, 179)
        Me.BtnFrmManageCustomerShow.Name = "BtnFrmManageCustomerShow"
        Me.BtnFrmManageCustomerShow.Size = New System.Drawing.Size(135, 140)
        Me.BtnFrmManageCustomerShow.TabIndex = 5
        Me.BtnFrmManageCustomerShow.Text = "ข้อมูลลูกค้า"
        Me.BtnFrmManageCustomerShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFrmManageCustomerShow.UseVisualStyleBackColor = False
        Me.BtnFrmManageCustomerShow.Visible = False
        '
        'BtnTimeCard
        '
        Me.BtnTimeCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTimeCard.BackColor = System.Drawing.Color.White
        Me.BtnTimeCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTimeCard.FlatAppearance.BorderSize = 0
        Me.BtnTimeCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTimeCard.Font = New System.Drawing.Font("Kanit", 15.75!)
        Me.BtnTimeCard.ForeColor = System.Drawing.Color.Black
        Me.BtnTimeCard.Image = Global.Project_CTM.My.Resources.Resources.clock1
        Me.BtnTimeCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTimeCard.Location = New System.Drawing.Point(587, 179)
        Me.BtnTimeCard.Name = "BtnTimeCard"
        Me.BtnTimeCard.Size = New System.Drawing.Size(135, 140)
        Me.BtnTimeCard.TabIndex = 10
        Me.BtnTimeCard.Text = "บันทึกเข้างาน"
        Me.BtnTimeCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTimeCard.UseVisualStyleBackColor = False
        Me.BtnTimeCard.Visible = False
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.Image = Global.Project_CTM.My.Resources.Resources.LOGO_ChaTra_Mue__AII_
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BtnSettigProgram
        '
        Me.BtnSettigProgram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSettigProgram.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSettigProgram.FlatAppearance.BorderSize = 0
        Me.BtnSettigProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettigProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnSettigProgram.ForeColor = System.Drawing.Color.White
        Me.BtnSettigProgram.Image = Global.Project_CTM.My.Resources.Resources.cogs1
        Me.BtnSettigProgram.Location = New System.Drawing.Point(738, 8)
        Me.BtnSettigProgram.Name = "BtnSettigProgram"
        Me.BtnSettigProgram.Size = New System.Drawing.Size(71, 63)
        Me.BtnSettigProgram.TabIndex = 5
        Me.BtnSettigProgram.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSettigProgram.UseVisualStyleBackColor = False
        Me.BtnSettigProgram.Visible = False
        '
        'Close_main
        '
        Me.Close_main.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_main.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Close_main.BackgroundImage = Global.Project_CTM.My.Resources.Resources.times_circle_o2
        Me.Close_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_main.FlatAppearance.BorderSize = 0
        Me.Close_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_main.ForeColor = System.Drawing.Color.White
        Me.Close_main.Location = New System.Drawing.Point(828, 8)
        Me.Close_main.Name = "Close_main"
        Me.Close_main.Size = New System.Drawing.Size(57, 57)
        Me.Close_main.TabIndex = 0
        Me.Close_main.UseVisualStyleBackColor = False
        '
        'Top_tap
        '
        Me.Top_tap.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Top_tap.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_tap.Location = New System.Drawing.Point(0, 0)
        Me.Top_tap.Name = "Top_tap"
        Me.Top_tap.Size = New System.Drawing.Size(896, 77)
        Me.Top_tap.TabIndex = 12
        Me.Top_tap.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(896, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSettigProgram)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Close_main)
        Me.Controls.Add(Me.Top_tap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top_tap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Close_main As Button
    Friend WithEvents Top_tap As PictureBox
    Friend WithEvents BtnSettigProgram As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnFrmMaterialShow As Button
    Friend WithEvents BtnShowFrmItem As Button
    Friend WithEvents BtnFrmRePrintBill As Button
    Friend WithEvents BtnShowFrmInventory As Button
    Friend WithEvents BtnShowFrmTable As Button
    Friend WithEvents BtnShowFrmPos As Button
    Friend WithEvents BtnShowFrmReport As Button
    Friend WithEvents LbUserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFrmCategoryShow As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents BtnFrmManageCustomerShow As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents date_show As Label
    Friend WithEvents timer As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnTimeCard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCloseShift As Button
End Class
