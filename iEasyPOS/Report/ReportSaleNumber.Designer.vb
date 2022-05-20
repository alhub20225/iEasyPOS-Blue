<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class ReportSaleNumber
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSaleNumber))
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TxtStartDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TxtEndDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.SumDC = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SumSubTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SumTax = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SqlDataSource2 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XrTable3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.HeightF = 10.50002!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeaderBand1.HeightF = 42.00001!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrTable1
        '
        Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6.000002!, 6.00001!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1046!, 36!)
        Me.XrTable1.StylePriority.UseTextAlignment = false
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell21, Me.XrTableCell23, Me.XrTableCell25, Me.XrTableCell27, Me.XrTableCell31, Me.XrTableCell33, Me.XrTableCell35, Me.XrTableCell29})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.CanGrow = false
        Me.XrTableCell19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell19.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StyleName = "FieldCaption"
        Me.XrTableCell19.StylePriority.UseFont = false
        Me.XrTableCell19.StylePriority.UseForeColor = false
        Me.XrTableCell19.StylePriority.UseTextAlignment = false
        Me.XrTableCell19.Text = "เลที่การขาย"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell19.Weight = 36.4516961690929R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.CanGrow = false
        Me.XrTableCell21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell21.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StyleName = "FieldCaption"
        Me.XrTableCell21.StylePriority.UseFont = false
        Me.XrTableCell21.StylePriority.UseForeColor = false
        Me.XrTableCell21.StylePriority.UseTextAlignment = false
        Me.XrTableCell21.Text = "วันที่ขาย"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 30.873633631776656R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.CanGrow = false
        Me.XrTableCell23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell23.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StyleName = "FieldCaption"
        Me.XrTableCell23.StylePriority.UseFont = false
        Me.XrTableCell23.StylePriority.UseForeColor = false
        Me.XrTableCell23.StylePriority.UseTextAlignment = false
        Me.XrTableCell23.Text = "รวม"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell23.Weight = 17.996053545287015R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.CanGrow = false
        Me.XrTableCell25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell25.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StyleName = "FieldCaption"
        Me.XrTableCell25.StylePriority.UseFont = false
        Me.XrTableCell25.StylePriority.UseForeColor = false
        Me.XrTableCell25.StylePriority.UseTextAlignment = false
        Me.XrTableCell25.Text = "ส่วนลด"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell25.Weight = 14.8031465770333R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.CanGrow = false
        Me.XrTableCell27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell27.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StyleName = "FieldCaption"
        Me.XrTableCell27.StylePriority.UseFont = false
        Me.XrTableCell27.StylePriority.UseForeColor = false
        Me.XrTableCell27.StylePriority.UseTextAlignment = false
        Me.XrTableCell27.Text = "รวมทั้งหมด"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell27.Weight = 17.719888377277783R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.CanGrow = false
        Me.XrTableCell31.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell31.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StyleName = "FieldCaption"
        Me.XrTableCell31.StylePriority.UseFont = false
        Me.XrTableCell31.StylePriority.UseForeColor = false
        Me.XrTableCell31.StylePriority.UseTextAlignment = false
        Me.XrTableCell31.Text = "การชำระ"
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell31.Weight = 16.886798932880971R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.CanGrow = false
        Me.XrTableCell33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell33.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StyleName = "FieldCaption"
        Me.XrTableCell33.StylePriority.UseFont = false
        Me.XrTableCell33.StylePriority.UseForeColor = false
        Me.XrTableCell33.StylePriority.UseTextAlignment = false
        Me.XrTableCell33.Text = "ชื่อเครื่อง"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell33.Weight = 21.432149087621305R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.CanGrow = false
        Me.XrTableCell35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell35.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StyleName = "FieldCaption"
        Me.XrTableCell35.StylePriority.UseFont = false
        Me.XrTableCell35.StylePriority.UseForeColor = false
        Me.XrTableCell35.StylePriority.UseTextAlignment = false
        Me.XrTableCell35.Text = "พนักงาน"
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell35.Weight = 18.307428680151396R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.CanGrow = false
        Me.XrTableCell29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell29.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell29.Multiline = true
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StyleName = "FieldCaption"
        Me.XrTableCell29.StylePriority.UseFont = false
        Me.XrTableCell29.StylePriority.UseForeColor = false
        Me.XrTableCell29.StylePriority.UseTextAlignment = false
        Me.XrTableCell29.Text = "Payment code / หมายเหตุ"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell29.Weight = 24.279210482573255R
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.HeightF = 29!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6!, 6!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(394!, 23!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        Me.XrPageInfo1.StylePriority.UseFont = false
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(412!, 6!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(394!, 23!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.StylePriority.UseFont = false
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrPageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.TxtStartDate, Me.XrLabel34, Me.TxtEndDate, Me.XrLabel1})
        Me.ReportHeaderBand1.HeightF = 80.16666!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(315.1663!, 52.16666!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(50.64474!, 18!)
        Me.XrLabel11.StyleName = "FieldCaption"
        Me.XrLabel11.StylePriority.UseBorders = false
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.StylePriority.UseForeColor = false
        Me.XrLabel11.Text = "วันที่ :"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.TxtStartDate.LocationFloat = New DevExpress.Utils.PointFloat(365.8111!, 52.16666!)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.TxtStartDate.SizeF = New System.Drawing.SizeF(156.9677!, 18!)
        Me.TxtStartDate.StylePriority.UseFont = false
        Me.TxtStartDate.StylePriority.UseTextAlignment = false
        Me.TxtStartDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.ForeColor = System.Drawing.Color.Black
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(539.2212!, 52.16666!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(50.64474!, 18!)
        Me.XrLabel34.StyleName = "FieldCaption"
        Me.XrLabel34.StylePriority.UseBorders = false
        Me.XrLabel34.StylePriority.UseFont = false
        Me.XrLabel34.StylePriority.UseForeColor = false
        Me.XrLabel34.Text = "ถึง :"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.TxtEndDate.LocationFloat = New DevExpress.Utils.PointFloat(589.866!, 52.16666!)
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.TxtEndDate.SizeF = New System.Drawing.SizeF(156.9677!, 18!)
        Me.TxtEndDate.StylePriority.UseFont = false
        Me.TxtEndDate.StylePriority.UseTextAlignment = false
        Me.TxtEndDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 20!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(198.658!, 0!)
        Me.XrLabel1.Multiline = true
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(651.342!, 41!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "รายงานการขาย(เลขที่การขาย)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 40!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 40!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrTable2})
        Me.Detail1.HeightF = 23!
        Me.Detail1.Name = "Detail1"
        Me.Detail1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Sale.SaleNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Sale.SaleDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale].[PaymentCode]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(924.2211!, 0!)
        Me.XrLabel2.Multiline = true
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(127.7787!, 23!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTable2
        '
        Me.XrTable2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom),DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(7.000025!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(917.2211!, 23!)
        Me.XrTable2.StylePriority.UseTextAlignment = false
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell22, Me.XrTableCell24, Me.XrTableCell26, Me.XrTableCell28, Me.XrTableCell32, Me.XrTableCell34, Me.XrTableCell36})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.CanGrow = false
        Me.XrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.SaleNo]")})
        Me.XrTableCell20.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StyleName = "DataField"
        Me.XrTableCell20.StylePriority.UseFont = false
        Me.XrTableCell20.StylePriority.UseTextAlignment = false
        Me.XrTableCell20.Text = "XrTableCell20"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell20.Weight = 36.4516961690929R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.CanGrow = false
        Me.XrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.SaleDate]")})
        Me.XrTableCell22.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StyleName = "DataField"
        Me.XrTableCell22.StylePriority.UseFont = false
        Me.XrTableCell22.Text = "XrTableCell22"
        Me.XrTableCell22.Weight = 30.873633631776656R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.CanGrow = false
        Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.Total]")})
        Me.XrTableCell24.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StyleName = "DataField"
        Me.XrTableCell24.StylePriority.UseFont = false
        Me.XrTableCell24.Text = "XrTableCell24"
        Me.XrTableCell24.TextFormatString = "{0:n2}"
        Me.XrTableCell24.Weight = 17.996061136486833R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.CanGrow = false
        Me.XrTableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.AmountDC]")})
        Me.XrTableCell26.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StyleName = "DataField"
        Me.XrTableCell26.StylePriority.UseFont = false
        Me.XrTableCell26.Text = "XrTableCell26"
        Me.XrTableCell26.TextFormatString = "{0:n2}"
        Me.XrTableCell26.Weight = 14.708762033141454R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.CanGrow = false
        Me.XrTableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.SubTotal]")})
        Me.XrTableCell28.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StyleName = "DataField"
        Me.XrTableCell28.StylePriority.UseFont = false
        Me.XrTableCell28.Text = "XrTableCell28"
        Me.XrTableCell28.TextFormatString = "{0:n2}"
        Me.XrTableCell28.Weight = 17.736820106842615R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.CanGrow = false
        Me.XrTableCell32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.PaymentName]")})
        Me.XrTableCell32.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StyleName = "DataField"
        Me.XrTableCell32.StylePriority.UseFont = false
        Me.XrTableCell32.Text = "XrTableCell32"
        Me.XrTableCell32.Weight = 16.902982284810875R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.CanGrow = false
        Me.XrTableCell34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.TerminalName]")})
        Me.XrTableCell34.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StyleName = "DataField"
        Me.XrTableCell34.StylePriority.UseFont = false
        Me.XrTableCell34.Text = "XrTableCell34"
        Me.XrTableCell34.Weight = 21.452669909013892R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.CanGrow = false
        Me.XrTableCell36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.FirstName]")})
        Me.XrTableCell36.Font = New System.Drawing.Font("Tahoma", 10!)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StyleName = "DataField"
        Me.XrTableCell36.StylePriority.UseFont = false
        Me.XrTableCell36.Text = "XrTableCell36"
        Me.XrTableCell36.Weight = 18.324933170764673R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrTable3})
        Me.ReportFooter.HeightF = 90.74999!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(7.000009!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1045!, 11.45833!)
        '
        'XrTable3
        '
        Me.XrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(360.9873!, 18.74998!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10, Me.XrTableRow9})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(381.224!, 72!)
        Me.XrTable3.StylePriority.UseBorders = false
        Me.XrTable3.StylePriority.UseTextAlignment = false
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell43, Me.XrTableCell44})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell37.CanGrow = false
        Me.XrTableCell37.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell37.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBorders = false
        Me.XrTableCell37.StylePriority.UseFont = false
        Me.XrTableCell37.StylePriority.UseForeColor = false
        Me.XrTableCell37.StylePriority.UseTextAlignment = false
        Me.XrTableCell37.Text = "จำนวนการขาย"
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell37.Weight = 17.996053545287015R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell38.CanGrow = false
        Me.XrTableCell38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell38.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBorders = false
        Me.XrTableCell38.StylePriority.UseFont = false
        Me.XrTableCell38.StylePriority.UseForeColor = false
        Me.XrTableCell38.StylePriority.UseTextAlignment = false
        Me.XrTableCell38.Text = "รวมส่วนลด"
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell38.Weight = 20.345077256834102R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell43.CanGrow = false
        Me.XrTableCell43.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell43.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBorders = false
        Me.XrTableCell43.StylePriority.UseFont = false
        Me.XrTableCell43.StylePriority.UseForeColor = false
        Me.XrTableCell43.StylePriority.UseTextAlignment = false
        Me.XrTableCell43.Text = "รวมทั้งหมด"
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell43.Weight = 20.490881985508011R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell44.CanGrow = false
        Me.XrTableCell44.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell44.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBorders = false
        Me.XrTableCell44.StylePriority.UseFont = false
        Me.XrTableCell44.StylePriority.UseForeColor = false
        Me.XrTableCell44.StylePriority.UseTextAlignment = false
        Me.XrTableCell44.Text = "รวมภาษี"
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell44.Weight = 13.60418768012628R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell39.CanGrow = false
        Me.XrTableCell39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([SaleNo])")})
        Me.XrTableCell39.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell39.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StyleName = "FieldCaption"
        Me.XrTableCell39.StylePriority.UseBorders = false
        Me.XrTableCell39.StylePriority.UseFont = false
        Me.XrTableCell39.StylePriority.UseForeColor = false
        Me.XrTableCell39.StylePriority.UseTextAlignment = false
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell39.Summary = XrSummary1
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell39.TextFormatString = "{0:#,#}"
        Me.XrTableCell39.Weight = 17.996053545287015R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell40.CanGrow = false
        Me.XrTableCell40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumDC]")})
        Me.XrTableCell40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell40.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StyleName = "FieldCaption"
        Me.XrTableCell40.StylePriority.UseBorders = false
        Me.XrTableCell40.StylePriority.UseFont = false
        Me.XrTableCell40.StylePriority.UseForeColor = false
        Me.XrTableCell40.StylePriority.UseTextAlignment = false
        Me.XrTableCell40.Text = "ส่วนลด"
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell40.TextFormatString = "{0:n2}"
        Me.XrTableCell40.Weight = 20.345077256834102R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell41.CanGrow = false
        Me.XrTableCell41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumSubTotal]")})
        Me.XrTableCell41.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell41.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StyleName = "FieldCaption"
        Me.XrTableCell41.StylePriority.UseBorders = false
        Me.XrTableCell41.StylePriority.UseFont = false
        Me.XrTableCell41.StylePriority.UseForeColor = false
        Me.XrTableCell41.StylePriority.UseTextAlignment = false
        Me.XrTableCell41.Text = "รวมทั้งหมด"
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell41.TextFormatString = "{0:n2}"
        Me.XrTableCell41.Weight = 20.490881985508011R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell42.CanGrow = false
        Me.XrTableCell42.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumTax]")})
        Me.XrTableCell42.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell42.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StyleName = "FieldCaption"
        Me.XrTableCell42.StylePriority.UseBorders = false
        Me.XrTableCell42.StylePriority.UseFont = false
        Me.XrTableCell42.StylePriority.UseForeColor = false
        Me.XrTableCell42.StylePriority.UseTextAlignment = false
        Me.XrTableCell42.Text = "ภาษี"
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell42.TextFormatString = "{0:n2}"
        Me.XrTableCell42.Weight = 13.60418768012628R
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "iEasyPOS.My.MySettings.ConnectionDB"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Sale"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?Parameter1", GetType(String))
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?Parameter2", GetType(String))
        CustomSqlQuery1.Parameters.Add(QueryParameter1)
        CustomSqlQuery1.Parameters.Add(QueryParameter2)
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        '
        'SumDC
        '
        Me.SumDC.DataMember = "Sale"
        Me.SumDC.Expression = "[].Sum([AmountDC])"
        Me.SumDC.Name = "SumDC"
        '
        'SumSubTotal
        '
        Me.SumSubTotal.DataMember = "Sale"
        Me.SumSubTotal.Expression = "[].Sum([SubTotal])"
        Me.SumSubTotal.Name = "SumSubTotal"
        '
        'SumTax
        '
        Me.SumTax.DataMember = "Sale"
        Me.SumTax.Expression = "[].Sum([TaxAmt])"
        Me.SumTax.Name = "SumTax"
        '
        'Parameter1
        '
        Me.Parameter1.Name = "Parameter1"
        Me.Parameter1.Visible = false
        '
        'Parameter2
        '
        Me.Parameter2.Name = "Parameter2"
        Me.Parameter2.Visible = false
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionName = "iEasyPOS.My.MySettings.ConnectionDB"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        CustomSqlQuery2.Name = "PaymentDetail"
        CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
        Me.SqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery2})
        Me.SqlDataSource2.ResultSchemaSerializable = resources.GetString("SqlDataSource2.ResultSchemaSerializable")
        '
        'ReportSaleNumber
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1, Me.DetailReport, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SumDC, Me.SumSubTotal, Me.SumTax})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1, Me.SqlDataSource2})
        Me.DataMember = "Sale"
        Me.DataSource = Me.SqlDataSource1
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Landscape = true
        Me.Margins = New System.Drawing.Printing.Margins(19, 19, 40, 40)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1, Me.Parameter2})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "18.2"
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrTable3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TxtStartDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TxtEndDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents SumDC As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SumSubTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SumTax As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Parameter2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource2 As DevExpress.DataAccess.Sql.SqlDataSource
End Class
