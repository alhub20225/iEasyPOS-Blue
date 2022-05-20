<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Report_CustomerSale80
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_CustomerSale80))
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.table1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254!
        Me.TopMargin.HeightF = 19.27083!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254!
        Me.BottomMargin.HeightF = 23.7802!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.label1})
        Me.ReportHeader.Dpi = 254!
        Me.ReportHeader.HeightF = 222.123!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Branch].[BranchName]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(16!, 152.4!)
        Me.XrLabel4.Multiline = true
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(661.7574!, 58.42!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "สาขา"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel4.TextFormatString = "สาขา : {0}"
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254!
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(316!, 93.98!)
        Me.XrLabel3.Multiline = true
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(66.08563!, 58.42!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "ถึง"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(382.0856!, 93.98001!)
        Me.XrLabel2.Multiline = true
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(295.6719!, 58.42!)
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "D2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(16!, 93.98!)
        Me.XrLabel1.Multiline = true
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(300!, 58.42!)
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "D1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.Dpi = 254!
        Me.label1.Font = New System.Drawing.Font("Tahoma", 10!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(16!, 16!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(661.7574!, 61.45361!)
        Me.label1.StyleName = "Title"
        Me.label1.StylePriority.UseFont = false
        Me.label1.StylePriority.UseForeColor = false
        Me.label1.Text = "รายงานการขายแยกตามลูกค้า"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Dpi = 254!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SubTotal", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("SaleDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("UnitPrice", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Qty", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("ItemName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 44.44996!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.table2})
        Me.GroupHeader2.Dpi = 254!
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SaleNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 116.2051!
        Me.GroupHeader2.Level = 2
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrTable2
        '
        Me.XrTable2.Dpi = 254!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(65.90193!, 63.50001!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(611.8555!, 43.58002!)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Dpi = 254!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.68629948172982291R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell4.Dpi = 254!
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StyleName = "GroupData1"
        Me.XrTableCell4.StylePriority.UseBackColor = false
        Me.XrTableCell4.StylePriority.UseFont = false
        Me.XrTableCell4.StylePriority.UseForeColor = false
        Me.XrTableCell4.Text = "ชื่อสินค้า"
        Me.XrTableCell4.Weight = 0.3579574902486975R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell5.Dpi = 254!
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StyleName = "GroupData1"
        Me.XrTableCell5.StylePriority.UseBackColor = false
        Me.XrTableCell5.StylePriority.UseFont = false
        Me.XrTableCell5.StylePriority.UseForeColor = false
        Me.XrTableCell5.StylePriority.UseTextAlignment = false
        Me.XrTableCell5.Text = "ราคา"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 0.19872994765066462R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell6.Dpi = 254!
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StyleName = "GroupData1"
        Me.XrTableCell6.StylePriority.UseBackColor = false
        Me.XrTableCell6.StylePriority.UseFont = false
        Me.XrTableCell6.StylePriority.UseForeColor = false
        Me.XrTableCell6.StylePriority.UseTextAlignment = false
        Me.XrTableCell6.Text = "จำนวน"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 0.16186770103842979R
        '
        'table2
        '
        Me.table2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.table2.Dpi = 254!
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(40.90194!, 0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(636.8555!, 63.5!)
        Me.table2.StylePriority.UseBorders = false
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell12, Me.tableCell11, Me.tableCell10})
        Me.tableRow2.Dpi = 254!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 1R
        '
        'tableCell12
        '
        Me.tableCell12.BackColor = System.Drawing.Color.Transparent
        Me.tableCell12.BorderColor = System.Drawing.Color.Black
        Me.tableCell12.BorderWidth = 1!
        Me.tableCell12.Dpi = 254!
        Me.tableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaleDate]")})
        Me.tableCell12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.tableCell12.ForeColor = System.Drawing.Color.Black
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StyleName = "GroupData1"
        Me.tableCell12.StylePriority.UseBackColor = false
        Me.tableCell12.StylePriority.UseBorderColor = false
        Me.tableCell12.StylePriority.UseBorderWidth = false
        Me.tableCell12.StylePriority.UseFont = false
        Me.tableCell12.StylePriority.UseForeColor = false
        Me.tableCell12.Weight = 0.23784406125348973R
        '
        'tableCell11
        '
        Me.tableCell11.BackColor = System.Drawing.Color.Transparent
        Me.tableCell11.BorderColor = System.Drawing.Color.Black
        Me.tableCell11.BorderWidth = 1!
        Me.tableCell11.Dpi = 254!
        Me.tableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaleNo]")})
        Me.tableCell11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.tableCell11.ForeColor = System.Drawing.Color.Black
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StyleName = "GroupData1"
        Me.tableCell11.StylePriority.UseBackColor = false
        Me.tableCell11.StylePriority.UseBorderColor = false
        Me.tableCell11.StylePriority.UseBorderWidth = false
        Me.tableCell11.StylePriority.UseFont = false
        Me.tableCell11.StylePriority.UseForeColor = false
        Me.tableCell11.Weight = 0.29064538927033851R
        '
        'tableCell10
        '
        Me.tableCell10.BackColor = System.Drawing.Color.Transparent
        Me.tableCell10.BorderColor = System.Drawing.Color.Black
        Me.tableCell10.BorderWidth = 1!
        Me.tableCell10.Dpi = 254!
        Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubTotal]")})
        Me.tableCell10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.tableCell10.ForeColor = System.Drawing.Color.Black
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StyleName = "GroupData1"
        Me.tableCell10.StylePriority.UseBackColor = false
        Me.tableCell10.StylePriority.UseBorderColor = false
        Me.tableCell10.StylePriority.UseBorderWidth = false
        Me.tableCell10.StylePriority.UseFont = false
        Me.tableCell10.StylePriority.UseForeColor = false
        Me.tableCell10.StylePriority.UseTextAlignment = false
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell10.TextFormatString = "{0:C2}"
        Me.tableCell10.Weight = 0.1443619490368413R
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.table3})
        Me.GroupHeader3.Dpi = 254!
        Me.GroupHeader3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("FirstName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader3.HeightF = 158.7501!
        Me.GroupHeader3.Level = 3
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTable1.Dpi = 254!
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(40.90194!, 95.25011!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(636.8556!, 63.50001!)
        Me.XrTable1.StylePriority.UseBorders = false
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 254!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell1.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell1.BorderWidth = 1!
        Me.XrTableCell1.Dpi = 254!
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StyleName = "GroupData1"
        Me.XrTableCell1.StylePriority.UseBackColor = false
        Me.XrTableCell1.StylePriority.UseBorderColor = false
        Me.XrTableCell1.StylePriority.UseBorders = false
        Me.XrTableCell1.StylePriority.UseBorderWidth = false
        Me.XrTableCell1.StylePriority.UseFont = false
        Me.XrTableCell1.StylePriority.UseForeColor = false
        Me.XrTableCell1.Text = "วันที่ - เวลา"
        Me.XrTableCell1.Weight = 0.23784404902237194R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell2.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell2.BorderWidth = 1!
        Me.XrTableCell2.Dpi = 254!
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StyleName = "GroupData1"
        Me.XrTableCell2.StylePriority.UseBackColor = false
        Me.XrTableCell2.StylePriority.UseBorderColor = false
        Me.XrTableCell2.StylePriority.UseBorders = false
        Me.XrTableCell2.StylePriority.UseBorderWidth = false
        Me.XrTableCell2.StylePriority.UseFont = false
        Me.XrTableCell2.StylePriority.UseForeColor = false
        Me.XrTableCell2.Text = "เลขที่บิล"
        Me.XrTableCell2.Weight = 0.29064529125945221R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell3.BorderColor = System.Drawing.Color.Black
        Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell3.BorderWidth = 1!
        Me.XrTableCell3.Dpi = 254!
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StyleName = "GroupData1"
        Me.XrTableCell3.StylePriority.UseBackColor = false
        Me.XrTableCell3.StylePriority.UseBorderColor = false
        Me.XrTableCell3.StylePriority.UseBorders = false
        Me.XrTableCell3.StylePriority.UseBorderWidth = false
        Me.XrTableCell3.StylePriority.UseFont = false
        Me.XrTableCell3.StylePriority.UseForeColor = false
        Me.XrTableCell3.StylePriority.UseTextAlignment = false
        Me.XrTableCell3.Text = "ยอดขาย"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell3.Weight = 0.14436205927884538R
        '
        'table3
        '
        Me.table3.Dpi = 254!
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 27.30501!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(607.4255!, 63.5!)
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16, Me.tableCell15})
        Me.tableRow3.Dpi = 254!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 1R
        '
        'tableCell16
        '
        Me.tableCell16.BackColor = System.Drawing.Color.Transparent
        Me.tableCell16.BorderColor = System.Drawing.Color.Black
        Me.tableCell16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tableCell16.BorderWidth = 1!
        Me.tableCell16.Dpi = 254!
        Me.tableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FirstName]")})
        Me.tableCell16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.tableCell16.ForeColor = System.Drawing.Color.Black
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StyleName = "GroupData1"
        Me.tableCell16.StylePriority.UseBackColor = false
        Me.tableCell16.StylePriority.UseBorderColor = false
        Me.tableCell16.StylePriority.UseBorders = false
        Me.tableCell16.StylePriority.UseBorderWidth = false
        Me.tableCell16.StylePriority.UseFont = false
        Me.tableCell16.StylePriority.UseForeColor = false
        Me.tableCell16.Weight = 0.13726545605498566R
        '
        'tableCell15
        '
        Me.tableCell15.BackColor = System.Drawing.Color.Transparent
        Me.tableCell15.BorderColor = System.Drawing.Color.Black
        Me.tableCell15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tableCell15.BorderWidth = 1!
        Me.tableCell15.Dpi = 254!
        Me.tableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LastName]")})
        Me.tableCell15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Bold)
        Me.tableCell15.ForeColor = System.Drawing.Color.Black
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.StyleName = "GroupData1"
        Me.tableCell15.StylePriority.UseBackColor = false
        Me.tableCell15.StylePriority.UseBorderColor = false
        Me.tableCell15.StylePriority.UseBorders = false
        Me.tableCell15.StylePriority.UseBorderWidth = false
        Me.tableCell15.StylePriority.UseFont = false
        Me.tableCell15.StylePriority.UseForeColor = false
        Me.tableCell15.Weight = 0.20416467626834337R
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.Detail.Dpi = 254!
        Me.Detail.HeightF = 48.89492!
        Me.Detail.Name = "Detail"
        '
        'table1
        '
        Me.table1.Dpi = 254!
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(65.90193!, 0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(611.8556!, 43.58002!)
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6, Me.tableCell4, Me.tableCell5})
        Me.tableRow1.Dpi = 254!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 0.68629948172982291R
        '
        'tableCell6
        '
        Me.tableCell6.BackColor = System.Drawing.Color.Transparent
        Me.tableCell6.Dpi = 254!
        Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemName]")})
        Me.tableCell6.Font = New System.Drawing.Font("Arial", 8!)
        Me.tableCell6.ForeColor = System.Drawing.Color.Black
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StyleName = "GroupData1"
        Me.tableCell6.StylePriority.UseBackColor = false
        Me.tableCell6.StylePriority.UseFont = false
        Me.tableCell6.StylePriority.UseForeColor = false
        Me.tableCell6.Weight = 0.3579574902486975R
        '
        'tableCell4
        '
        Me.tableCell4.BackColor = System.Drawing.Color.Transparent
        Me.tableCell4.Dpi = 254!
        Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
        Me.tableCell4.Font = New System.Drawing.Font("Arial", 8!)
        Me.tableCell4.ForeColor = System.Drawing.Color.Black
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StyleName = "GroupData1"
        Me.tableCell4.StylePriority.UseBackColor = false
        Me.tableCell4.StylePriority.UseFont = false
        Me.tableCell4.StylePriority.UseForeColor = false
        Me.tableCell4.StylePriority.UseTextAlignment = false
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell4.TextFormatString = "{0:C2}"
        Me.tableCell4.Weight = 0.19872994765066462R
        '
        'tableCell5
        '
        Me.tableCell5.BackColor = System.Drawing.Color.Transparent
        Me.tableCell5.Dpi = 254!
        Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Qty]")})
        Me.tableCell5.Font = New System.Drawing.Font("Arial", 8!)
        Me.tableCell5.ForeColor = System.Drawing.Color.Black
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StyleName = "GroupData1"
        Me.tableCell5.StylePriority.UseBackColor = false
        Me.tableCell5.StylePriority.UseFont = false
        Me.tableCell5.StylePriority.UseForeColor = false
        Me.tableCell5.StylePriority.UseTextAlignment = false
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell5.TextFormatString = "{0:#,#}"
        Me.tableCell5.Weight = 0.16186770103842979R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Dpi = 254!
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 14.90861!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLine1, Me.XrSubreport1})
        Me.ReportFooter.Dpi = 254!
        Me.ReportFooter.HeightF = 200.8464!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 254!
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Underline)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 72.64338!)
        Me.XrLabel5.Multiline = true
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(162.5807!, 58.42001!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        Me.XrLabel5.Text = "สรุปยอด"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 47.64349!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(677.7576!, 24.99993!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.Dpi = 254!
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 131.7856!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Parameter1", Me.Parameter1))
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Parameter2", Me.Parameter2))
        Me.XrSubreport1.ReportSource = New iEasyPOS.SumCustomerSale()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(699!, 61.36011!)
        '
        'Parameter1
        '
        Me.Parameter1.Description = "Parameter1"
        Me.Parameter1.Name = "Parameter1"
        Me.Parameter1.Visible = false
        '
        'Parameter2
        '
        Me.Parameter2.Description = "Parameter2"
        Me.Parameter2.Name = "Parameter2"
        Me.Parameter2.Type = GetType(Integer)
        Me.Parameter2.ValueInfo = "0"
        Me.Parameter2.Visible = false
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "iEasyPOS.My.MySettings.ConnectionDB"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Customer"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?Parameter1", GetType(String))
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?Parameter2", GetType(String))
        CustomSqlQuery1.Parameters.Add(QueryParameter1)
        CustomSqlQuery1.Parameters.Add(QueryParameter2)
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        CustomSqlQuery2.Name = "Branch"
        CustomSqlQuery2.Sql = "select ""Branch"".""BranchName"""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  from ""dbo"".""Branch"" ""Branch"""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1, CustomSqlQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1!
        Me.Title.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.Title.Name = "Title"
        '
        'GroupCaption1
        '
        Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.GroupCaption1.BorderColor = System.Drawing.Color.White
        Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupCaption1.BorderWidth = 2!
        Me.GroupCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer))
        Me.GroupCaption1.Name = "GroupCaption1"
        Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254!)
        Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupData1
        '
        Me.GroupData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.GroupData1.BorderColor = System.Drawing.Color.White
        Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupData1.BorderWidth = 2!
        Me.GroupData1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupData1.ForeColor = System.Drawing.Color.White
        Me.GroupData1.Name = "GroupData1"
        Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254!)
        Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooterBackground3
        '
        Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131,Byte),Integer), CType(CType(131,Byte),Integer), CType(CType(131,Byte),Integer))
        Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
        Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupFooterBackground3.BorderWidth = 2!
        Me.GroupFooterBackground3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer), CType(CType(228,Byte),Integer))
        Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
        Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254!)
        Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        '
        'Report_CustomerSale80
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.Detail, Me.GroupFooter1, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "Customer"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 254!
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 19, 24)
        Me.PageHeight = 32758
        Me.PageWidth = 719
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "80(72.1) x 3276 mm"
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1, Me.Parameter2})
        Me.PrinterName = "XP-80C"
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ShowPrintMarginsWarning = false
        Me.SnapGridSize = 25!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.GroupFooterBackground3, Me.PageInfo})
        Me.Version = "18.2"
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.table1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Parameter2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
End Class
