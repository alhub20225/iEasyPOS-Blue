<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RecallBill
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridView_Sale = New System.Windows.Forms.DataGridView()
        Me.SaleNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paytype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridView_SaleDetail = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnRePrint = New Telerik.WinControls.UI.RadButton()
        Me.BackBtn = New Telerik.WinControls.UI.RadButton()
        Me.txtDateTime = New System.Windows.Forms.DateTimePicker()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.Label()
        Me.txt_Discount = New System.Windows.Forms.Label()
        Me.txt_Subtotal = New System.Windows.Forms.Label()
        Me.btnVoidQrThai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnVoidQrAlipay = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDelSale = New Telerik.WinControls.UI.RadButton()
        Me.BtnVoidEDC = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Sale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_SaleDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRePrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1209, 57)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(442, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ค้นหาการขาย"
        '
        'GridView_Sale
        '
        Me.GridView_Sale.AllowUserToAddRows = False
        Me.GridView_Sale.AllowUserToDeleteRows = False
        Me.GridView_Sale.AllowUserToResizeRows = False
        Me.GridView_Sale.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kanit", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView_Sale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridView_Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView_Sale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaleNum, Me.SaleDate, Me.Total, Me.SaleId, Me.paytype})
        Me.GridView_Sale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridView_Sale.Location = New System.Drawing.Point(639, 129)
        Me.GridView_Sale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridView_Sale.Name = "GridView_Sale"
        Me.GridView_Sale.ReadOnly = True
        Me.GridView_Sale.RowHeadersVisible = False
        Me.GridView_Sale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView_Sale.Size = New System.Drawing.Size(559, 593)
        Me.GridView_Sale.TabIndex = 6
        '
        'SaleNum
        '
        Me.SaleNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SaleNum.HeaderText = "เลขที่การขาย"
        Me.SaleNum.Name = "SaleNum"
        Me.SaleNum.ReadOnly = True
        '
        'SaleDate
        '
        Me.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SaleDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaleDate.HeaderText = "วันที่"
        Me.SaleDate.Name = "SaleDate"
        Me.SaleDate.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total.HeaderText = "ยอดรวม"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'SaleId
        '
        Me.SaleId.HeaderText = "SaleId"
        Me.SaleId.Name = "SaleId"
        Me.SaleId.ReadOnly = True
        Me.SaleId.Visible = False
        '
        'paytype
        '
        Me.paytype.HeaderText = "จ่ายโดย"
        Me.paytype.Name = "paytype"
        Me.paytype.ReadOnly = True
        '
        'GridView_SaleDetail
        '
        Me.GridView_SaleDetail.AllowUserToAddRows = False
        Me.GridView_SaleDetail.AllowUserToDeleteRows = False
        Me.GridView_SaleDetail.AllowUserToResizeColumns = False
        Me.GridView_SaleDetail.AllowUserToResizeRows = False
        Me.GridView_SaleDetail.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Kanit", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView_SaleDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridView_SaleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView_SaleDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.ItemPrice, Me.ItemQty, Me.TotalPrice})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Kanit", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridView_SaleDetail.DefaultCellStyle = DataGridViewCellStyle5
        Me.GridView_SaleDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridView_SaleDetail.Enabled = False
        Me.GridView_SaleDetail.GridColor = System.Drawing.Color.White
        Me.GridView_SaleDetail.Location = New System.Drawing.Point(22, 84)
        Me.GridView_SaleDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridView_SaleDetail.Name = "GridView_SaleDetail"
        Me.GridView_SaleDetail.ReadOnly = True
        Me.GridView_SaleDetail.RowHeadersVisible = False
        Me.GridView_SaleDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView_SaleDetail.Size = New System.Drawing.Size(597, 553)
        Me.GridView_SaleDetail.TabIndex = 7
        '
        'ItemCode
        '
        Me.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCode.FillWeight = 80.58376!
        Me.ItemCode.HeaderText = "รหัสสินค้า"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemName.FillWeight = 80.58376!
        Me.ItemName.HeaderText = "รายการสินค้า"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ItemPrice
        '
        Me.ItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ItemPrice.FillWeight = 80.58376!
        Me.ItemPrice.HeaderText = "ราคาสินค้า"
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.ReadOnly = True
        Me.ItemPrice.Width = 82
        '
        'ItemQty
        '
        Me.ItemQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ItemQty.FillWeight = 177.665!
        Me.ItemQty.HeaderText = "จำนวน"
        Me.ItemQty.Name = "ItemQty"
        Me.ItemQty.ReadOnly = True
        Me.ItemQty.Width = 63
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TotalPrice.FillWeight = 80.58376!
        Me.TotalPrice.HeaderText = "ราคารวม"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 74
        '
        'BtnRePrint
        '
        Me.BtnRePrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRePrint.Location = New System.Drawing.Point(934, 737)
        Me.BtnRePrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRePrint.Name = "BtnRePrint"
        Me.BtnRePrint.Size = New System.Drawing.Size(135, 52)
        Me.BtnRePrint.TabIndex = 107
        Me.BtnRePrint.Text = "พิมพ์ใบเสร็จ"
        CType(Me.BtnRePrint.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "พิมพ์ใบเสร็จ"
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(74, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Kanit Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnRePrint.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackBtn
        '
        Me.BackBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackBtn.Location = New System.Drawing.Point(1075, 737)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(123, 52)
        Me.BackBtn.TabIndex = 108
        Me.BackBtn.Text = "กลับ"
        Me.BackBtn.Visible = False
        CType(Me.BackBtn.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "กลับ"
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Kanit Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BackBtn.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).GradientAngle = 300.0!
        '
        'txtDateTime
        '
        Me.txtDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTime.Location = New System.Drawing.Point(643, 84)
        Me.txtDateTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(200, 21)
        Me.txtDateTime.TabIndex = 109
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(864, 84)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 21)
        Me.txtSearch.TabIndex = 110
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(1094, 75)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(99, 39)
        Me.BtnSearch.TabIndex = 111
        Me.BtnSearch.Text = "ค้นหา"
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ค้นหา"
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(74, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(17, 650)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 22)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "รวม :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(17, 683)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "ส่วนลด :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 706)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 29)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "รวมทั้งหมด :"
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.BackColor = System.Drawing.Color.White
        Me.txt_total.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.txt_total.Location = New System.Drawing.Point(128, 650)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(43, 22)
        Me.txt_total.TabIndex = 115
        Me.txt_total.Text = "0.00"
        '
        'txt_Discount
        '
        Me.txt_Discount.AutoSize = True
        Me.txt_Discount.BackColor = System.Drawing.Color.White
        Me.txt_Discount.Font = New System.Drawing.Font("Kanit", 11.25!)
        Me.txt_Discount.Location = New System.Drawing.Point(128, 683)
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(43, 22)
        Me.txt_Discount.TabIndex = 116
        Me.txt_Discount.Text = "0.00"
        '
        'txt_Subtotal
        '
        Me.txt_Subtotal.AutoSize = True
        Me.txt_Subtotal.BackColor = System.Drawing.Color.White
        Me.txt_Subtotal.Font = New System.Drawing.Font("Kanit", 14.25!)
        Me.txt_Subtotal.Location = New System.Drawing.Point(129, 706)
        Me.txt_Subtotal.Name = "txt_Subtotal"
        Me.txt_Subtotal.Size = New System.Drawing.Size(52, 29)
        Me.txt_Subtotal.TabIndex = 117
        Me.txt_Subtotal.Text = "0.00"
        '
        'btnVoidQrThai
        '
        Me.btnVoidQrThai.BackColor = System.Drawing.Color.ForestGreen
        Me.btnVoidQrThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoidQrThai.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.btnVoidQrThai.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVoidQrThai.Location = New System.Drawing.Point(253, 739)
        Me.btnVoidQrThai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVoidQrThai.Name = "btnVoidQrThai"
        Me.btnVoidQrThai.Size = New System.Drawing.Size(135, 46)
        Me.btnVoidQrThai.TabIndex = 118
        Me.btnVoidQrThai.Text = "Void Thai QR"
        Me.btnVoidQrThai.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(250, 789)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "กรณีที่ลูกค้าชำระผ่าน KPLUS เท่านั้น"
        '
        'BtnVoidQrAlipay
        '
        Me.BtnVoidQrAlipay.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnVoidQrAlipay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoidQrAlipay.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnVoidQrAlipay.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVoidQrAlipay.Location = New System.Drawing.Point(12, 739)
        Me.BtnVoidQrAlipay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVoidQrAlipay.Name = "BtnVoidQrAlipay"
        Me.BtnVoidQrAlipay.Size = New System.Drawing.Size(215, 46)
        Me.BtnVoidQrAlipay.TabIndex = 120
        Me.BtnVoidQrAlipay.Text = "Void Alipay And WeChat QR"
        Me.BtnVoidQrAlipay.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(14, 789)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 16)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "กรณีที่ลูกค้าชำระผ่าน Alipay และ Wechat"
        '
        'BtnDelSale
        '
        Me.BtnDelSale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDelSale.Location = New System.Drawing.Point(823, 737)
        Me.BtnDelSale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDelSale.Name = "BtnDelSale"
        Me.BtnDelSale.Size = New System.Drawing.Size(102, 52)
        Me.BtnDelSale.TabIndex = 122
        Me.BtnDelSale.Text = "ยกเลิกบิล"
        CType(Me.BtnDelSale.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ยกเลิกบิล"
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Kanit Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnDelSale.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).GradientAngle = 300.0!
        '
        'BtnVoidEDC
        '
        Me.BtnVoidEDC.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnVoidEDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoidEDC.Font = New System.Drawing.Font("Kanit", 10.0!)
        Me.BtnVoidEDC.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVoidEDC.Location = New System.Drawing.Point(513, 739)
        Me.BtnVoidEDC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVoidEDC.Name = "BtnVoidEDC"
        Me.BtnVoidEDC.Size = New System.Drawing.Size(135, 46)
        Me.BtnVoidEDC.TabIndex = 123
        Me.BtnVoidEDC.Text = "Void EDC"
        Me.BtnVoidEDC.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(510, 789)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 18)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "ยกเลิกรายการที่ชำระผ่านเครื่อง EDC เท่านั้น"
        '
        'Frm_RecallBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1209, 819)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnVoidEDC)
        Me.Controls.Add(Me.BtnDelSale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnVoidQrAlipay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnVoidQrThai)
        Me.Controls.Add(Me.txt_Subtotal)
        Me.Controls.Add(Me.txt_Discount)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.BtnRePrint)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.GridView_SaleDetail)
        Me.Controls.Add(Me.GridView_Sale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Kanit", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_RecallBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Sale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_SaleDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRePrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GridView_Sale As DataGridView
    Friend WithEvents GridView_SaleDetail As DataGridView
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemPrice As DataGridViewTextBoxColumn
    Friend WithEvents ItemQty As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents BtnRePrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents BackBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDateTime As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_total As Label
    Friend WithEvents txt_Discount As Label
    Friend WithEvents txt_Subtotal As Label
    Friend WithEvents btnVoidQrThai As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnVoidQrAlipay As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnDelSale As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnVoidEDC As Button
    Friend WithEvents SaleNum As DataGridViewTextBoxColumn
    Friend WithEvents SaleDate As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents SaleId As DataGridViewTextBoxColumn
    Friend WithEvents paytype As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
