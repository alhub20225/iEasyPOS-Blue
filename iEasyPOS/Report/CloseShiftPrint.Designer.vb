﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CloseShiftPrint
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
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalC10 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB1000 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC025 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalC05 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.CalC2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalB20 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.LabelUserIn = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelDateCloseShift = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalC1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtStartNumSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtEndNumSale = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelUserOut = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.LabelDateOpenShift = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SumTotalCash = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB50 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB500 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CalC5 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalB100 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.TableBranchAddress = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtCompaName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtBranchAdd = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtBranchAdd2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtProvinces = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtTelephone = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.txtTaxId = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        CType(Me.TableBranchAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'XrLabel12
        '
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(108.9583!, 68.79237!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(140.8016!, 23.0!)
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 91.79238!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(108.9583!, 23.0!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "User In :"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CalC10
        '
        Me.CalC10.DataMember = "DataCloseshift"
        Me.CalC10.Expression = "[C10]*10"
        Me.CalC10.Name = "CalC10"
        '
        'CalB1000
        '
        Me.CalB1000.DataMember = "DataCloseshift"
        Me.CalB1000.Expression = "[B1000]*1000"
        Me.CalB1000.Name = "CalB1000"
        '
        'CalC025
        '
        Me.CalC025.DataMember = "DataCloseshift"
        Me.CalC025.Expression = "[C025]*0.25"
        Me.CalC025.Name = "CalC025"
        '
        'CalC05
        '
        Me.CalC05.DataMember = "DataCloseshift"
        Me.CalC05.Expression = "[C05]*0.5"
        Me.CalC05.Name = "CalC05"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(1.156919!, 203.9948!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(251.0064!, 12.08334!)
        '
        'CalC2
        '
        Me.CalC2.DataMember = "DataCloseshift"
        Me.CalC2.Expression = "[C2]*2"
        Me.CalC2.Name = "CalC2"
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 33.00001!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(75.62501!, 23.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Shift end : "
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(0!, 548.6256!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(107.2916!, 23.0!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Total Of Sale"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CalB20
        '
        Me.CalB20.DataMember = "DataCloseshift"
        Me.CalB20.Expression = "[B20]*20"
        Me.CalB20.Name = "CalB20"
        '
        'LabelUserIn
        '
        Me.LabelUserIn.LocationFloat = New DevExpress.Utils.PointFloat(108.9583!, 91.79234!)
        Me.LabelUserIn.Name = "LabelUserIn"
        Me.LabelUserIn.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LabelUserIn.SizeF = New System.Drawing.SizeF(140.8016!, 23.0!)
        Me.LabelUserIn.StylePriority.UseTextAlignment = False
        Me.LabelUserIn.Text = "UserIn"
        Me.LabelUserIn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelDateCloseShift
        '
        Me.LabelDateCloseShift.LocationFloat = New DevExpress.Utils.PointFloat(103.0897!, 33.00003!)
        Me.LabelDateCloseShift.Name = "LabelDateCloseShift"
        Me.LabelDateCloseShift.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LabelDateCloseShift.SizeF = New System.Drawing.SizeF(149.9103!, 23.0!)
        Me.LabelDateCloseShift.StylePriority.UseTextAlignment = False
        Me.LabelDateCloseShift.Text = "datetime closeshift"
        Me.LabelDateCloseShift.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CalC1
        '
        Me.CalC1.DataMember = "DataCloseshift"
        Me.CalC1.Expression = "[C1]*1"
        Me.CalC1.Name = "CalC1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrLabel18, Me.XrLabel35, Me.txtStartNumSale, Me.txtEndNumSale, Me.XrLabel25, Me.XrLine2, Me.LabelUserOut, Me.XrLabel15, Me.XrLabel2, Me.XrLabel11, Me.XrLabel12, Me.LabelUserIn, Me.LabelDateCloseShift, Me.LabelDateOpenShift, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8})
        Me.Detail.HeightF = 576.924!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 216.0781!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Param1", Me.Parameter1))
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("Param2", Me.Parameter2))
        Me.XrSubreport1.ReportSource = New iEasyPOS.subReportPaymentDetail()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(249.7598!, 311.7142!)
        '
        'Parameter1
        '
        Me.Parameter1.Description = "Parameter1"
        Me.Parameter1.Name = "Parameter1"
        Me.Parameter1.Visible = False
        '
        'Parameter2
        '
        Me.Parameter2.Description = "Parameter2"
        Me.Parameter2.Name = "Parameter2"
        Me.Parameter2.Visible = False
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.00001402462!, 137.7924!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(125.7133!, 23.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "เลขที่การขายเริ่มต้น :"
        '
        'XrLabel35
        '
        Me.XrLabel35.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(0.00001402462!, 160.7924!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(125.7133!, 22.99998!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.Text = "เลขที่การขายสิ้นสุด :"
        '
        'txtStartNumSale
        '
        Me.txtStartNumSale.LocationFloat = New DevExpress.Utils.PointFloat(125.7133!, 137.7924!)
        Me.txtStartNumSale.Name = "txtStartNumSale"
        Me.txtStartNumSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtStartNumSale.SizeF = New System.Drawing.SizeF(124.0465!, 23.0!)
        Me.txtStartNumSale.StylePriority.UseTextAlignment = False
        Me.txtStartNumSale.Text = "txtStartNumSale"
        Me.txtStartNumSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtEndNumSale
        '
        Me.txtEndNumSale.LocationFloat = New DevExpress.Utils.PointFloat(125.7133!, 160.7924!)
        Me.txtEndNumSale.Name = "txtEndNumSale"
        Me.txtEndNumSale.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtEndNumSale.SizeF = New System.Drawing.SizeF(124.0465!, 22.99998!)
        Me.txtEndNumSale.StylePriority.UseTextAlignment = False
        Me.txtEndNumSale.Text = "txtEndNumSale"
        Me.txtEndNumSale.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'LabelUserOut
        '
        Me.LabelUserOut.LocationFloat = New DevExpress.Utils.PointFloat(108.9583!, 114.7924!)
        Me.LabelUserOut.Name = "LabelUserOut"
        Me.LabelUserOut.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LabelUserOut.SizeF = New System.Drawing.SizeF(140.8016!, 23.0!)
        Me.LabelUserOut.StylePriority.UseTextAlignment = False
        Me.LabelUserOut.Text = "UserOut"
        Me.LabelUserOut.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 114.7924!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(108.9583!, 23.0!)
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "User Out :"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 68.79237!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(108.9583!, 23.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "TerminalName :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'LabelDateOpenShift
        '
        Me.LabelDateOpenShift.LocationFloat = New DevExpress.Utils.PointFloat(103.0897!, 10.00003!)
        Me.LabelDateOpenShift.Name = "LabelDateOpenShift"
        Me.LabelDateOpenShift.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LabelDateOpenShift.SizeF = New System.Drawing.SizeF(149.9103!, 23.0!)
        Me.LabelDateOpenShift.StylePriority.UseTextAlignment = False
        Me.LabelDateOpenShift.Text = "datetime openshift"
        Me.LabelDateOpenShift.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(75.625!, 23.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Shift Start :"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(107.7117!, 548.6256!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(142.0481!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "0.00"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SumTotalCash
        '
        Me.SumTotalCash.DataMember = "DataCloseshift"
        Me.SumTotalCash.Expression = "[CalB1000]+[CalB500]+[CalB100]+[CalB50]+[CalB20]+[CalC10]+[CalC5]+[CalC2]+[CalC1]" &
    "+[CalC05]+[CalC025]"
        Me.SumTotalCash.Name = "SumTotalCash"
        '
        'CalB50
        '
        Me.CalB50.DataMember = "DataCloseshift"
        Me.CalB50.Expression = "[B50]*50"
        Me.CalB50.Name = "CalB50"
        '
        'CalB500
        '
        Me.CalB500.DataMember = "DataCloseshift"
        Me.CalB500.Expression = "[B500]*500"
        Me.CalB500.Name = "CalB500"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 34.95395!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CalC5
        '
        Me.CalC5.DataMember = "DataCloseshift"
        Me.CalC5.Expression = "[C5]*5"
        Me.CalC5.Name = "CalC5"
        '
        'CalB100
        '
        Me.CalB100.DataMember = "DataCloseshift"
        Me.CalB100.Expression = "[B100]*100"
        Me.CalB100.Name = "CalB100"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 31.19926!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TableBranchAddress
        '
        Me.TableBranchAddress.LocationFloat = New DevExpress.Utils.PointFloat(1.756389!, 0!)
        Me.TableBranchAddress.Name = "TableBranchAddress"
        Me.TableBranchAddress.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow26, Me.XrTableRow21, Me.XrTableRow22, Me.XrTableRow23, Me.XrTableRow24, Me.XrTableRow25})
        Me.TableBranchAddress.SizeF = New System.Drawing.SizeF(249.25!, 150.0!)
        '
        'XrTableRow26
        '
        Me.XrTableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtCompaName})
        Me.XrTableRow26.Name = "XrTableRow26"
        Me.XrTableRow26.Weight = 0.61538448536891743R
        '
        'txtCompaName
        '
        Me.txtCompaName.Name = "txtCompaName"
        Me.txtCompaName.StylePriority.UseTextAlignment = False
        Me.txtCompaName.Text = "txtCompaName"
        Me.txtCompaName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtCompaName.Weight = 0.99795879329622039R
        '
        'XrTableRow21
        '
        Me.XrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtBranchAdd})
        Me.XrTableRow21.Name = "XrTableRow21"
        Me.XrTableRow21.Weight = 0.61538448536891743R
        '
        'txtBranchAdd
        '
        Me.txtBranchAdd.Name = "txtBranchAdd"
        Me.txtBranchAdd.StylePriority.UseTextAlignment = False
        Me.txtBranchAdd.Text = "txtBranchAdd"
        Me.txtBranchAdd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtBranchAdd.Weight = 0.99795879329622039R
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtBranchAdd2})
        Me.XrTableRow22.Name = "XrTableRow22"
        Me.XrTableRow22.Weight = 0.61538448536891743R
        '
        'txtBranchAdd2
        '
        Me.txtBranchAdd2.Name = "txtBranchAdd2"
        Me.txtBranchAdd2.StylePriority.UseTextAlignment = False
        Me.txtBranchAdd2.Text = "txtBranchAdd2"
        Me.txtBranchAdd2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtBranchAdd2.Weight = 0.99795879329622039R
        '
        'XrTableRow23
        '
        Me.XrTableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtProvinces})
        Me.XrTableRow23.Name = "XrTableRow23"
        Me.XrTableRow23.Weight = 0.61538448536891743R
        '
        'txtProvinces
        '
        Me.txtProvinces.Name = "txtProvinces"
        Me.txtProvinces.StylePriority.UseTextAlignment = False
        Me.txtProvinces.Text = "txtProvinces"
        Me.txtProvinces.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtProvinces.Weight = 0.99795879329622039R
        '
        'XrTableRow24
        '
        Me.XrTableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtTelephone})
        Me.XrTableRow24.Name = "XrTableRow24"
        Me.XrTableRow24.Weight = 0.61538448536891721R
        '
        'txtTelephone
        '
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.StylePriority.UseTextAlignment = False
        Me.txtTelephone.Text = "txtTelephone"
        Me.txtTelephone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtTelephone.Weight = 0.99795879329622039R
        '
        'XrTableRow25
        '
        Me.XrTableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.txtTaxId})
        Me.XrTableRow25.Name = "XrTableRow25"
        Me.XrTableRow25.Weight = 0.61538448536891743R
        '
        'txtTaxId
        '
        Me.txtTaxId.Name = "txtTaxId"
        Me.txtTaxId.StylePriority.UseTextAlignment = False
        Me.txtTaxId.Text = "txtTaxId"
        Me.txtTaxId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtTaxId.Weight = 0.99795879329622039R
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(2.403417!, 0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(249.7599!, 23.00001!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "ใบปิดกะ"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(2.403417!, 23.00001!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(248.0932!, 36.80436!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "BranchName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TableBranchAddress})
        Me.ReportHeader.HeightF = 153.6547!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel1})
        Me.PageHeader.HeightF = 63.45341!
        Me.PageHeader.Name = "PageHeader"
        '
        'CloseShiftPrint
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalB1000, Me.CalB500, Me.CalB100, Me.CalB50, Me.CalB20, Me.CalC10, Me.CalC5, Me.CalC2, Me.CalC1, Me.CalC05, Me.CalC025, Me.SumTotalCash})
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(13, 17, 31, 35)
        Me.PageHeight = 12897
        Me.PageWidth = 283
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "80(72.1) x 3276 mm"
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1, Me.Parameter2})
        Me.PrinterName = "XP-80C"
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = False
        Me.Version = "18.2"
        CType(Me.TableBranchAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalC10 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB1000 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC025 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalC05 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents CalC2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalB20 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents LabelUserIn As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelDateCloseShift As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalC1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents LabelUserOut As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LabelDateOpenShift As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SumTotalCash As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalB50 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB500 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents CalC5 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalB100 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TableBranchAddress As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow26 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtCompaName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow21 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtBranchAdd As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow22 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtBranchAdd2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow23 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtProvinces As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow24 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtTelephone As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow25 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents txtTaxId As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtStartNumSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtEndNumSale As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Parameter2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
End Class
