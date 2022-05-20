<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BillCheck_savesale
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.txtItemname = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtQty = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.TableDetail = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtSubtotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.RowAmtDC = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtAmcDC = New DevExpress.XtraReports.UI.XRTableCell()
        Me.RowPercentDC = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtPercentDC = New DevExpress.XtraReports.UI.XRTableCell()
        Me.RowBathDC = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtBathDC = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        CType(Me.TableDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtItemname, Me.txtQty, Me.txtUnitPrice})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 58.42!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtItemname
        '
        Me.txtItemname.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.ItemName")})
        Me.txtItemname.Dpi = 254.0!
        Me.txtItemname.LocationFloat = New DevExpress.Utils.PointFloat(0.3315341!, 0!)
        Me.txtItemname.Name = "txtItemname"
        Me.txtItemname.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.txtItemname.SizeF = New System.Drawing.SizeF(315.0644!, 58.42!)
        Me.txtItemname.Text = "txtItemname"
        '
        'txtQty
        '
        Me.txtQty.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.Qty")})
        Me.txtQty.Dpi = 254.0!
        Me.txtQty.LocationFloat = New DevExpress.Utils.PointFloat(315.3959!, 0!)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.txtQty.SizeF = New System.Drawing.SizeF(122.2713!, 58.41999!)
        Me.txtQty.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#}"
        Me.txtQty.Summary = XrSummary1
        Me.txtQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.UnitPrice")})
        Me.txtUnitPrice.Dpi = 254.0!
        Me.txtUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(437.6672!, 0!)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.txtUnitPrice.SizeF = New System.Drawing.SizeF(220.0017!, 58.41999!)
        Me.txtUnitPrice.StylePriority.UseTextAlignment = False
        Me.txtUnitPrice.Text = "txtUnitPrice"
        Me.txtUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 48.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 46.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 108.6827!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.3315375!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(657.3374!, 58.41999!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "ใบเเจ้งรายการ"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaleTable.SaleName")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.3315375!, 58.41998!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(660.6685!, 50.26269!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 51.75441!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaleTable.InsertDate")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.3315375!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(657.3374!, 47.02039!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:d MMMM yyyy}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel2.Summary = XrSummary2
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel7, Me.XrLabel8})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.HeightF = 51.91046!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel3
        '
        Me.XrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.3315454!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(315.0644!, 51.91046!)
        Me.XrLabel3.StylePriority.UseBorderDashStyle = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "รายการสินค้า"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(315.3959!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(122.2713!, 51.91046!)
        Me.XrLabel7.StylePriority.UseBorderDashStyle = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "จำนวน"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(437.6672!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(220.0018!, 51.91046!)
        Me.XrLabel8.StylePriority.UseBorderDashStyle = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "ราคา"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.TableDetail})
        Me.GroupFooter1.Dpi = 254.0!
        Me.GroupFooter1.HeightF = 227.4009!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLine1
        '
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.3315375!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(660.6685!, 17.56385!)
        Me.XrLine1.StylePriority.UseBorderDashStyle = False
        '
        'TableDetail
        '
        Me.TableDetail.Dpi = 254.0!
        Me.TableDetail.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TableDetail.LocationFloat = New DevExpress.Utils.PointFloat(0!, 17.56386!)
        Me.TableDetail.Name = "TableDetail"
        Me.TableDetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.RowAmtDC, Me.RowPercentDC, Me.RowBathDC, Me.XrTableRow6})
        Me.TableDetail.SizeF = New System.Drawing.SizeF(661.0!, 209.8371!)
        Me.TableDetail.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.txtSubtotal})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "รวม"
        Me.XrTableCell4.Weight = 0.66666669744586793R
        '
        'txtSubtotal
        '
        Me.txtSubtotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.Sale.Subtotal", "{0:n2}")})
        Me.txtSubtotal.Dpi = 254.0!
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        Me.txtSubtotal.Summary = XrSummary3
        Me.txtSubtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtSubtotal.Weight = 1.3333333025541321R
        '
        'RowAmtDC
        '
        Me.RowAmtDC.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.txtAmcDC})
        Me.RowAmtDC.Dpi = 254.0!
        Me.RowAmtDC.Name = "RowAmtDC"
        Me.RowAmtDC.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "ส่วนลด"
        Me.XrTableCell6.Weight = 0.66666669744586793R
        '
        'txtAmcDC
        '
        Me.txtAmcDC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.SaleItem.AmtDC")})
        Me.txtAmcDC.Dpi = 254.0!
        Me.txtAmcDC.Name = "txtAmcDC"
        Me.txtAmcDC.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.RunningSum
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.txtAmcDC.Summary = XrSummary4
        Me.txtAmcDC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtAmcDC.Weight = 1.3333333025541321R
        '
        'RowPercentDC
        '
        Me.RowPercentDC.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.txtPercentDC})
        Me.RowPercentDC.Dpi = 254.0!
        Me.RowPercentDC.Name = "RowPercentDC"
        Me.RowPercentDC.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "ส่วนลด%"
        Me.XrTableCell8.Weight = 0.66666660510826392R
        '
        'txtPercentDC
        '
        Me.txtPercentDC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.SaleItem.PercentDC")})
        Me.txtPercentDC.Dpi = 254.0!
        Me.txtPercentDC.Name = "txtPercentDC"
        Me.txtPercentDC.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.RunningSum
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.txtPercentDC.Summary = XrSummary5
        Me.txtPercentDC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtPercentDC.Weight = 1.3333333948917361R
        '
        'RowBathDC
        '
        Me.RowBathDC.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.txtBathDC})
        Me.RowBathDC.Dpi = 254.0!
        Me.RowBathDC.Name = "RowBathDC"
        Me.RowBathDC.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "ส่วนลด"
        Me.XrTableCell10.Weight = 0.66666660510826392R
        '
        'txtBathDC
        '
        Me.txtBathDC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.SaleItem.BahtDC")})
        Me.txtBathDC.Dpi = 254.0!
        Me.txtBathDC.Name = "txtBathDC"
        Me.txtBathDC.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.RunningSum
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.txtBathDC.Summary = XrSummary6
        Me.txtBathDC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtBathDC.Weight = 1.3333333948917361R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.txtTotal})
        Me.XrTableRow6.Dpi = 254.0!
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "รวมทั้งหมด" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrTableCell12.Weight = 0.66666660510826392R
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sale.Total", "{0:n2}")})
        Me.txtTotal.Dpi = 254.0!
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.StylePriority.UseFont = False
        Me.txtTotal.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:฿#,##0.00}"
        Me.txtTotal.Summary = XrSummary7
        Me.txtTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.txtTotal.Weight = 1.3333333948917361R
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn7, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn1})
        Me.DataTable1.TableName = "Sale"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Total"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ItemId"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ItemName"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Qty"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "UnitPrice"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "SaleItem.PercentDC"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "SaleItem.AmtDC"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "SaleItem.Tax"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "SaleItem.InitPrice"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Sale.Subtotal"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "SaleItem.BahtDC"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.DataTable2.TableName = "SaleTable"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "InsertDate"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "SaleName"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "SaleId"
        '
        'BillCheck_savesale
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataSource = Me.DataSet1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(31, 25, 48, 46)
        Me.PageHeight = 32758
        Me.PageWidth = 719
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "80(72.1) x 3276 mm"
        Me.PrinterName = "XP-80C"
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me.TableDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataTable2 As DataTable
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents TableDetail As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtSubtotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents RowAmtDC As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtAmcDC As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents RowPercentDC As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtPercentDC As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents RowBathDC As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtBathDC As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents txtUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtQty As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtItemname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn1 As DataColumn
End Class
