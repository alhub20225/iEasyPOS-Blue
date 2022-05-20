<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SpotCheck
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
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
        Me.XrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalPaymentDetail = New DevExpress.XtraReports.UI.XRTableCell()
        Me.LabelTotalOfSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelRealSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelTax = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelTotalExcTax = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelTotalDeleteSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelCancelSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelTotalDiscount = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelTotalOrder = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelDateSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CalB1000 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB500 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB100 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB50 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB20 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC10 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC05 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC025 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SumTotalCash = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrTable2, Me.LabelTotalOfSale, Me.LabelRealSale, Me.LabelTax, Me.LabelTotalExcTax, Me.LabelTotalDeleteSale, Me.LabelCancelSale, Me.LabelTotalDiscount, Me.LabelTotalOrder, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel17})
        Me.Detail.HeightF = 481.4972!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(1.666718!, 207.5984!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Param1", Me.Parameter1))
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Param2", Me.Parameter2))
        Me.XrSubreport1.ReportSource = New iEasyPOS.subReportPaymentDetail()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(246.5736!, 249.5932!)
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
        Me.Parameter2.Visible = false
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(246.5736!, 247.9972!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14, Me.XrTableRow15, Me.XrTableRow16, Me.XrTableRow17, Me.XrTableRow18, Me.XrTableRow19, Me.XrTableRow20})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(248.0931!, 175!)
        Me.XrTable2.StylePriority.UseBorders = false
        Me.XrTable2.StylePriority.UseFont = false
        Me.XrTable2.Visible = false
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell50})
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 1R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = false
        Me.XrTableCell8.StylePriority.UseFont = false
        Me.XrTableCell8.StylePriority.UseTextAlignment = false
        Me.XrTableCell8.Text = "PaymentName"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 1R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseFont = false
        Me.XrTableCell50.StylePriority.UseTextAlignment = false
        Me.XrTableCell50.Text = "Total"
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell50.Weight = 1R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell52, Me.LabelTableTotal})
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 1R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell52.Multiline = true
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseFont = false
        Me.XrTableCell52.StylePriority.UseTextAlignment = false
        Me.XrTableCell52.Text = "เงินสด"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell52.Weight = 1R
        '
        'LabelTableTotal
        '
        Me.LabelTableTotal.Name = "LabelTableTotal"
        Me.LabelTableTotal.StylePriority.UseTextAlignment = false
        Me.LabelTableTotal.Text = "LabelTableTotal"
        Me.LabelTableTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.LabelTableTotal.Weight = 1R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell53, Me.TotalQrThai})
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 1R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StylePriority.UseFont = false
        Me.XrTableCell53.StylePriority.UseTextAlignment = false
        Me.XrTableCell53.Text = "QR Code (Thai)"
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell53.Weight = 1R
        '
        'TotalQrThai
        '
        Me.TotalQrThai.Name = "TotalQrThai"
        Me.TotalQrThai.StylePriority.UseTextAlignment = false
        Me.TotalQrThai.Text = "TotalQrThai"
        Me.TotalQrThai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TotalQrThai.Weight = 1R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell55, Me.TotalAlipay})
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Weight = 1R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StylePriority.UseFont = false
        Me.XrTableCell55.StylePriority.UseTextAlignment = false
        Me.XrTableCell55.Text = "QR Code (Alipay)"
        Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell55.Weight = 1R
        '
        'TotalAlipay
        '
        Me.TotalAlipay.Name = "TotalAlipay"
        Me.TotalAlipay.StylePriority.UseTextAlignment = false
        Me.TotalAlipay.Text = "TotalAlipay"
        Me.TotalAlipay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TotalAlipay.Weight = 1R
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell54, Me.TotalQrWechat})
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 1R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseFont = false
        Me.XrTableCell54.StylePriority.UseTextAlignment = false
        Me.XrTableCell54.Text = "QR Code (Wechat)"
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell54.Weight = 1R
        '
        'TotalQrWechat
        '
        Me.TotalQrWechat.Name = "TotalQrWechat"
        Me.TotalQrWechat.StylePriority.UseTextAlignment = false
        Me.TotalQrWechat.Text = "TotalQrWechat"
        Me.TotalQrWechat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TotalQrWechat.Weight = 1R
        '
        'XrTableRow19
        '
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell56, Me.TotalCreditCard})
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.Weight = 1R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StylePriority.UseFont = false
        Me.XrTableCell56.StylePriority.UseTextAlignment = false
        Me.XrTableCell56.Text = "Credit Card"
        Me.XrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell56.Weight = 1R
        '
        'TotalCreditCard
        '
        Me.TotalCreditCard.Name = "TotalCreditCard"
        Me.TotalCreditCard.StylePriority.UseTextAlignment = false
        Me.TotalCreditCard.Text = "TotalCreditCard"
        Me.TotalCreditCard.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TotalCreditCard.Weight = 1R
        '
        'XrTableRow20
        '
        Me.XrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell57, Me.TotalPaymentDetail})
        Me.XrTableRow20.Name = "XrTableRow20"
        Me.XrTableRow20.Weight = 1R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.StylePriority.UseFont = false
        Me.XrTableCell57.StylePriority.UseTextAlignment = false
        Me.XrTableCell57.Text = "Total"
        Me.XrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell57.Weight = 1R
        '
        'TotalPaymentDetail
        '
        Me.TotalPaymentDetail.Name = "TotalPaymentDetail"
        Me.TotalPaymentDetail.StylePriority.UseTextAlignment = false
        Me.TotalPaymentDetail.Text = "TotalPaymentDetail"
        Me.TotalPaymentDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.TotalPaymentDetail.Weight = 1R
        '
        'LabelTotalOfSale
        '
        Me.LabelTotalOfSale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelTotalOfSale.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 171.0002!)
        Me.LabelTotalOfSale.Multiline = true
        Me.LabelTotalOfSale.Name = "LabelTotalOfSale"
        Me.LabelTotalOfSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelTotalOfSale.SizeF = New System.Drawing.SizeF(110.2048!, 23!)
        Me.LabelTotalOfSale.StylePriority.UseFont = false
        Me.LabelTotalOfSale.StylePriority.UseTextAlignment = false
        Me.LabelTotalOfSale.Text = "0.00"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelTotalOfSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelRealSale
        '
        Me.LabelRealSale.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 148!)
        Me.LabelRealSale.Multiline = true
        Me.LabelRealSale.Name = "LabelRealSale"
        Me.LabelRealSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelRealSale.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelRealSale.StylePriority.UseTextAlignment = false
        Me.LabelRealSale.Text = "0.00"
        Me.LabelRealSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelTax
        '
        Me.LabelTax.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 125!)
        Me.LabelTax.Multiline = true
        Me.LabelTax.Name = "LabelTax"
        Me.LabelTax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelTax.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelTax.StylePriority.UseTextAlignment = false
        Me.LabelTax.Text = "0.00"
        Me.LabelTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelTotalExcTax
        '
        Me.LabelTotalExcTax.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 102!)
        Me.LabelTotalExcTax.Multiline = true
        Me.LabelTotalExcTax.Name = "LabelTotalExcTax"
        Me.LabelTotalExcTax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelTotalExcTax.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelTotalExcTax.StylePriority.UseTextAlignment = false
        Me.LabelTotalExcTax.Text = "0.00"
        Me.LabelTotalExcTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelTotalDeleteSale
        '
        Me.LabelTotalDeleteSale.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 78.99998!)
        Me.LabelTotalDeleteSale.Multiline = true
        Me.LabelTotalDeleteSale.Name = "LabelTotalDeleteSale"
        Me.LabelTotalDeleteSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelTotalDeleteSale.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelTotalDeleteSale.StylePriority.UseTextAlignment = false
        Me.LabelTotalDeleteSale.Text = "0.00"
        Me.LabelTotalDeleteSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelCancelSale
        '
        Me.LabelCancelSale.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 56.00018!)
        Me.LabelCancelSale.Multiline = true
        Me.LabelCancelSale.Name = "LabelCancelSale"
        Me.LabelCancelSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelCancelSale.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelCancelSale.StylePriority.UseTextAlignment = false
        Me.LabelCancelSale.Text = "0.00"
        Me.LabelCancelSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.LabelCancelSale.Visible = false
        '
        'LabelTotalDiscount
        '
        Me.LabelTotalDiscount.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 33.00011!)
        Me.LabelTotalDiscount.Multiline = true
        Me.LabelTotalDiscount.Name = "LabelTotalDiscount"
        Me.LabelTotalDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelTotalDiscount.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelTotalDiscount.StylePriority.UseTextAlignment = false
        Me.LabelTotalDiscount.Text = "0.00"
        Me.LabelTotalDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelTotalOrder
        '
        Me.LabelTotalOrder.LocationFloat = New DevExpress.Utils.PointFloat(140.8016!, 10!)
        Me.LabelTotalOrder.Multiline = true
        Me.LabelTotalOrder.Name = "LabelTotalOrder"
        Me.LabelTotalOrder.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelTotalOrder.SizeF = New System.Drawing.SizeF(108.9583!, 23!)
        Me.LabelTotalOrder.StylePriority.UseTextAlignment = false
        Me.LabelTotalOrder.Text = "0.00"
        Me.LabelTotalOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(1.666821!, 171.0002!)
        Me.XrLabel25.Multiline = true
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(139.1348!, 23!)
        Me.XrLabel25.StylePriority.UseFont = false
        Me.XrLabel25.StylePriority.UseTextAlignment = false
        Me.XrLabel25.Text = "Total Of Sale"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 148!)
        Me.XrLabel24.Multiline = true
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(139.1349!, 23!)
        Me.XrLabel24.StylePriority.UseTextAlignment = false
        Me.XrLabel24.Text = "Real Sale :"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 125.0002!)
        Me.XrLabel23.Multiline = true
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(139.1349!, 23!)
        Me.XrLabel23.StylePriority.UseTextAlignment = false
        Me.XrLabel23.Text = "Tax :"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 102.0002!)
        Me.XrLabel22.Multiline = true
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(139.1349!, 22.99994!)
        Me.XrLabel22.StylePriority.UseTextAlignment = false
        Me.XrLabel22.Text = "Total (Exc, Tax) :"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 79.00018!)
        Me.XrLabel21.Multiline = true
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(139.1349!, 23!)
        Me.XrLabel21.StylePriority.UseTextAlignment = false
        Me.XrLabel21.Text = "Total Delete Sale :"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 56.00018!)
        Me.XrLabel20.Multiline = true
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(139.1349!, 23!)
        Me.XrLabel20.StylePriority.UseTextAlignment = false
        Me.XrLabel20.Text = "Total Cancel Sale :"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel20.Visible = false
        '
        'XrLabel19
        '
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 33.00011!)
        Me.XrLabel19.Multiline = true
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(139.1349!, 23!)
        Me.XrLabel19.StylePriority.UseTextAlignment = false
        Me.XrLabel19.Text = "Total Discount :"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 10!)
        Me.XrLabel17.Multiline = true
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(139.1349!, 23!)
        Me.XrLabel17.StylePriority.UseTextAlignment = false
        Me.XrLabel17.Text = "Total Order :"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.LabelDateSale, Me.XrLabel1})
        Me.TopMargin.HeightF = 179!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 166.9167!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(249.7599!, 12.08334!)
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(103.0897!, 92.8045!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(147.9167!, 23!)
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "XrLabel1"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 92.8045!)
        Me.XrLabel7.Multiline = true
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(103.0897!, 23.00001!)
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "Total Real Sale :"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.80436!)
        Me.XrLabel6.Multiline = true
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(249.7599!, 23.00001!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "ยอดขายระหว่างวัน"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(103.0897!, 120.9167!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(147.9167!, 23.00001!)
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 120.9167!)
        Me.XrLabel4.Multiline = true
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(103.0897!, 22.99999!)
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "Sale by Terminal :"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 8!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 69.8045!)
        Me.XrLabel3.Multiline = true
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(103.0897!, 23!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "Sale of the Date :"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'LabelDateSale
        '
        Me.LabelDateSale.LocationFloat = New DevExpress.Utils.PointFloat(103.0897!, 69.80437!)
        Me.LabelDateSale.Name = "LabelDateSale"
        Me.LabelDateSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.LabelDateSale.SizeF = New System.Drawing.SizeF(147.9167!, 23!)
        Me.LabelDateSale.StylePriority.UseTextAlignment = false
        Me.LabelDateSale.Text = "saledate"
        Me.LabelDateSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1.666716!, 10!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(248.0932!, 36.80436!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 53.83612!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CalB1000
        '
        Me.CalB1000.DataMember = "DataCloseshift"
        Me.CalB1000.Expression = "[B1000]*1000"
        Me.CalB1000.Name = "CalB1000"
        '
        'CalB500
        '
        Me.CalB500.DataMember = "DataCloseshift"
        Me.CalB500.Expression = "[B500]*500"
        Me.CalB500.Name = "CalB500"
        '
        'CalB100
        '
        Me.CalB100.DataMember = "DataCloseshift"
        Me.CalB100.Expression = "[B100]*100"
        Me.CalB100.Name = "CalB100"
        '
        'CalB50
        '
        Me.CalB50.DataMember = "DataCloseshift"
        Me.CalB50.Expression = "[B50]*50"
        Me.CalB50.Name = "CalB50"
        '
        'CalB20
        '
        Me.CalB20.DataMember = "DataCloseshift"
        Me.CalB20.Expression = "[B20]*20"
        Me.CalB20.Name = "CalB20"
        '
        'CalC10
        '
        Me.CalC10.DataMember = "DataCloseshift"
        Me.CalC10.Expression = "[C10]*10"
        Me.CalC10.Name = "CalC10"
        '
        'CalC5
        '
        Me.CalC5.DataMember = "DataCloseshift"
        Me.CalC5.Expression = "[C5]*5"
        Me.CalC5.Name = "CalC5"
        '
        'CalC2
        '
        Me.CalC2.DataMember = "DataCloseshift"
        Me.CalC2.Expression = "[C2]*2"
        Me.CalC2.Name = "CalC2"
        '
        'CalC1
        '
        Me.CalC1.DataMember = "DataCloseshift"
        Me.CalC1.Expression = "[C1]*1"
        Me.CalC1.Name = "CalC1"
        '
        'CalC05
        '
        Me.CalC05.DataMember = "DataCloseshift"
        Me.CalC05.Expression = "[C05]*0.5"
        Me.CalC05.Name = "CalC05"
        '
        'CalC025
        '
        Me.CalC025.DataMember = "DataCloseshift"
        Me.CalC025.Expression = "[C025]*0.25"
        Me.CalC025.Name = "CalC025"
        '
        'SumTotalCash
        '
        Me.SumTotalCash.DataMember = "DataCloseshift"
        Me.SumTotalCash.Expression = "[CalB1000]+[CalB500]+[CalB100]+[CalB50]+[CalB20]+[CalC10]+[CalC5]+[CalC2]+[CalC1]"& _ 
    "+[CalC05]+[CalC025]"
        Me.SumTotalCash.Name = "SumTotalCash"
        '
        'SpotCheck
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalB1000, Me.CalB500, Me.CalB100, Me.CalB50, Me.CalB20, Me.CalC10, Me.CalC5, Me.CalC2, Me.CalC1, Me.CalC05, Me.CalC025, Me.SumTotalCash})
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margins = New System.Drawing.Printing.Margins(13, 17, 179, 54)
        Me.PageHeight = 12897
        Me.PageWidth = 283
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "80(72.1) x 3276 mm"
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1, Me.Parameter2})
        Me.PrinterName = "XP-80C"
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = false
        Me.Version = "18.2"
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Parameter2 As DevExpress.XtraReports.Parameters.Parameter
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
    Friend WithEvents XrTableRow20 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalPaymentDetail As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LabelTotalOfSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelRealSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelTax As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelTotalExcTax As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelTotalDeleteSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelCancelSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelTotalDiscount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelTotalOrder As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelDateSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents CalB1000 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB500 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB100 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB50 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB20 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC10 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC05 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC025 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SumTotalCash As DevExpress.XtraReports.UI.CalculatedField
End Class
