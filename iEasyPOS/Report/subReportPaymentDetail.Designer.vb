<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class subReportPaymentDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subReportPaymentDetail))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.LabelTableTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalQrThai = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalAlipay = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalQrWechat = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalCreditCard = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalGift = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalGrab = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalAirPay = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalLineMan = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.Robinhood = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalRobinhood = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalShopee = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalPaymentDetail = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Param1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Param2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalFoodPanda = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 8.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 30.8124!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrLabel23})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 971.0208!
        Me.Detail.Name = "Detail"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(1.058533!, 82.02081!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14, Me.XrTableRow15, Me.XrTableRow16, Me.XrTableRow17, Me.XrTableRow18, Me.XrTableRow19, Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow1})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(578.9308!, 889.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell50})
        Me.XrTableRow14.Dpi = 254.0!
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "PaymentName"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 1.0R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Dpi = 254.0!
        Me.XrTableCell50.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        Me.XrTableCell50.Text = "Total"
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell50.Weight = 1.0R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell52, Me.LabelTableTotal})
        Me.XrTableRow15.Dpi = 254.0!
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 1.0R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.Dpi = 254.0!
        Me.XrTableCell52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell52.Multiline = True
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseFont = False
        Me.XrTableCell52.StylePriority.UseTextAlignment = False
        Me.XrTableCell52.Text = "เงินสด" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell52.Weight = 1.0R
        '
        'LabelTableTotal
        '
        Me.LabelTableTotal.Dpi = 254.0!
        Me.LabelTableTotal.Name = "LabelTableTotal"
        Me.LabelTableTotal.StylePriority.UseTextAlignment = False
        Me.LabelTableTotal.Text = "LabelTableTotal"
        Me.LabelTableTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.LabelTableTotal.Weight = 1.0R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell53, Me.TotalQrThai})
        Me.XrTableRow16.Dpi = 254.0!
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 1.0R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.Dpi = 254.0!
        Me.XrTableCell53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StylePriority.UseFont = False
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        Me.XrTableCell53.Text = "QR Code (Thai)"
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell53.Weight = 1.0R
        '
        'TotalQrThai
        '
        Me.TotalQrThai.Dpi = 254.0!
        Me.TotalQrThai.Name = "TotalQrThai"
        Me.TotalQrThai.StylePriority.UseTextAlignment = False
        Me.TotalQrThai.Text = "TotalQrThai"
        Me.TotalQrThai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalQrThai.Weight = 1.0R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell55, Me.TotalAlipay})
        Me.XrTableRow17.Dpi = 254.0!
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Weight = 1.0R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Dpi = 254.0!
        Me.XrTableCell55.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StylePriority.UseFont = False
        Me.XrTableCell55.StylePriority.UseTextAlignment = False
        Me.XrTableCell55.Text = "QR Code (Alipay)"
        Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell55.Weight = 1.0R
        '
        'TotalAlipay
        '
        Me.TotalAlipay.Dpi = 254.0!
        Me.TotalAlipay.Name = "TotalAlipay"
        Me.TotalAlipay.StylePriority.UseTextAlignment = False
        Me.TotalAlipay.Text = "TotalAlipay"
        Me.TotalAlipay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalAlipay.Weight = 1.0R
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell54, Me.TotalQrWechat})
        Me.XrTableRow18.Dpi = 254.0!
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 1.0R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.Dpi = 254.0!
        Me.XrTableCell54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.StylePriority.UseTextAlignment = False
        Me.XrTableCell54.Text = "QR Code (Wechat)"
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell54.Weight = 1.0R
        '
        'TotalQrWechat
        '
        Me.TotalQrWechat.Dpi = 254.0!
        Me.TotalQrWechat.Name = "TotalQrWechat"
        Me.TotalQrWechat.StylePriority.UseTextAlignment = False
        Me.TotalQrWechat.Text = "TotalQrWechat"
        Me.TotalQrWechat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalQrWechat.Weight = 1.0R
        '
        'XrTableRow19
        '
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell56, Me.TotalCreditCard})
        Me.XrTableRow19.Dpi = 254.0!
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.Weight = 1.0R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.Dpi = 254.0!
        Me.XrTableCell56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StylePriority.UseFont = False
        Me.XrTableCell56.StylePriority.UseTextAlignment = False
        Me.XrTableCell56.Text = "Credit Card"
        Me.XrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell56.Weight = 1.0R
        '
        'TotalCreditCard
        '
        Me.TotalCreditCard.Dpi = 254.0!
        Me.TotalCreditCard.Name = "TotalCreditCard"
        Me.TotalCreditCard.StylePriority.UseTextAlignment = False
        Me.TotalCreditCard.Text = "TotalCreditCard"
        Me.TotalCreditCard.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalCreditCard.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.TotalGift})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Gift Card"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 1.0R
        '
        'TotalGift
        '
        Me.TotalGift.Dpi = 254.0!
        Me.TotalGift.Multiline = True
        Me.TotalGift.Name = "TotalGift"
        Me.TotalGift.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalGift.StylePriority.UseTextAlignment = False
        Me.TotalGift.Text = "TotalGift"
        Me.TotalGift.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalGift.Weight = 1.0R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.TotalGrab})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "GrabFood"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 1.0R
        '
        'TotalGrab
        '
        Me.TotalGrab.Dpi = 254.0!
        Me.TotalGrab.Multiline = True
        Me.TotalGrab.Name = "TotalGrab"
        Me.TotalGrab.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalGrab.StylePriority.UseTextAlignment = False
        Me.TotalGrab.Text = "TotalGrab"
        Me.TotalGrab.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalGrab.Weight = 1.0R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.TotalAirPay})
        Me.XrTableRow4.Dpi = 254.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "AirPay"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 1.0R
        '
        'TotalAirPay
        '
        Me.TotalAirPay.Dpi = 254.0!
        Me.TotalAirPay.Multiline = True
        Me.TotalAirPay.Name = "TotalAirPay"
        Me.TotalAirPay.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalAirPay.StylePriority.UseTextAlignment = False
        Me.TotalAirPay.Text = "TotalAirPay"
        Me.TotalAirPay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalAirPay.Weight = 1.0R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.TotalLineMan})
        Me.XrTableRow5.Dpi = 254.0!
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "LINEMAN"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 1.0R
        '
        'TotalLineMan
        '
        Me.TotalLineMan.Dpi = 254.0!
        Me.TotalLineMan.Multiline = True
        Me.TotalLineMan.Name = "TotalLineMan"
        Me.TotalLineMan.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalLineMan.StylePriority.UseTextAlignment = False
        Me.TotalLineMan.Text = "TotalLineMan"
        Me.TotalLineMan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalLineMan.Weight = 1.0R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Robinhood, Me.TotalRobinhood})
        Me.XrTableRow6.Dpi = 254.0!
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'Robinhood
        '
        Me.Robinhood.Dpi = 254.0!
        Me.Robinhood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Robinhood.Multiline = True
        Me.Robinhood.Name = "Robinhood"
        Me.Robinhood.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.Robinhood.StylePriority.UseFont = False
        Me.Robinhood.StylePriority.UseTextAlignment = False
        Me.Robinhood.Text = "Robinhood"
        Me.Robinhood.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Robinhood.Weight = 1.0R
        '
        'TotalRobinhood
        '
        Me.TotalRobinhood.Dpi = 254.0!
        Me.TotalRobinhood.Multiline = True
        Me.TotalRobinhood.Name = "TotalRobinhood"
        Me.TotalRobinhood.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalRobinhood.StylePriority.UseTextAlignment = False
        Me.TotalRobinhood.Text = "TotalRobinhood"
        Me.TotalRobinhood.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalRobinhood.Weight = 1.0R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.TotalShopee})
        Me.XrTableRow7.Dpi = 254.0!
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Shopee"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 1.0R
        '
        'TotalShopee
        '
        Me.TotalShopee.Dpi = 254.0!
        Me.TotalShopee.Multiline = True
        Me.TotalShopee.Name = "TotalShopee"
        Me.TotalShopee.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalShopee.StylePriority.UseTextAlignment = False
        Me.TotalShopee.Text = "TotalShopee"
        Me.TotalShopee.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalShopee.Weight = 1.0R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.TotalPaymentDetail})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Total"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 1.0R
        '
        'TotalPaymentDetail
        '
        Me.TotalPaymentDetail.Dpi = 254.0!
        Me.TotalPaymentDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TotalPaymentDetail.Name = "TotalPaymentDetail"
        Me.TotalPaymentDetail.StylePriority.UseFont = False
        Me.TotalPaymentDetail.StylePriority.UseTextAlignment = False
        Me.TotalPaymentDetail.Text = "TotalPaymentDetail"
        Me.TotalPaymentDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalPaymentDetail.Weight = 1.0R
        '
        'XrLabel23
        '
        Me.XrLabel23.Dpi = 254.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(579.9893!, 58.41999!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Payment รายละเอียดการชำระเงิน"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Project_CTM.My.MySettings.ConnectionDB"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?Param1", GetType(String))
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?Param2", GetType(String))
        CustomSqlQuery1.Parameters.Add(QueryParameter1)
        CustomSqlQuery1.Parameters.Add(QueryParameter2)
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iU3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" &
    "T0iUGF5bWVudE5hbWUiIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZT0iU3ViVG90YWwiIFR5cGU9I" &
    "kRlY2ltYWwiIC8+PC9WaWV3PjwvRGF0YVNldD4="
        '
        'Param1
        '
        Me.Param1.Name = "Param1"
        Me.Param1.Visible = False
        '
        'Param2
        '
        Me.Param2.Name = "Param2"
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.TotalFoodPanda})
        Me.XrTableRow8.Dpi = 254.0!
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Food Panda"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 1.0R
        '
        'TotalFoodPanda
        '
        Me.TotalFoodPanda.Dpi = 254.0!
        Me.TotalFoodPanda.Multiline = True
        Me.TotalFoodPanda.Name = "TotalFoodPanda"
        Me.TotalFoodPanda.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.TotalFoodPanda.StylePriority.UseTextAlignment = False
        Me.TotalFoodPanda.Text = "TotalFoodPanda"
        Me.TotalFoodPanda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalFoodPanda.Weight = 1.0R
        '
        'subReportPaymentDetail
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(5, 4, 8, 31)
        Me.PageHeight = 2794
        Me.PageWidth = 600
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Param1, Me.Param2})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.Version = "18.2"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Param1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Param2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LabelTableTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalQrThai As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalAlipay As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalQrWechat As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow19 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalCreditCard As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalGift As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalGrab As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalAirPay As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalLineMan As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents Robinhood As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalRobinhood As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalShopee As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalPaymentDetail As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalFoodPanda As DevExpress.XtraReports.UI.XRTableCell
End Class
