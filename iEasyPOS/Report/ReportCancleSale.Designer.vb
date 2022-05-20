<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportCancleSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportCancleSale))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
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
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        resources.ApplyResources(Me.PageHeaderBand1, "PageHeaderBand1")
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrTable1
        '
        Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        resources.ApplyResources(Me.XrTable1, "XrTable1")
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable1.StylePriority.UseTextAlignment = false
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell21, Me.XrTableCell27, Me.XrTableCell33, Me.XrTableCell35})
        Me.XrTableRow7.Name = "XrTableRow7"
        resources.ApplyResources(Me.XrTableRow7, "XrTableRow7")
        '
        'XrTableCell19
        '
        Me.XrTableCell19.CanGrow = false
        resources.ApplyResources(Me.XrTableCell19, "XrTableCell19")
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StyleName = "FieldCaption"
        Me.XrTableCell19.StylePriority.UseFont = false
        Me.XrTableCell19.StylePriority.UseForeColor = false
        Me.XrTableCell19.StylePriority.UseTextAlignment = false
        '
        'XrTableCell21
        '
        Me.XrTableCell21.CanGrow = false
        resources.ApplyResources(Me.XrTableCell21, "XrTableCell21")
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StyleName = "FieldCaption"
        Me.XrTableCell21.StylePriority.UseFont = false
        Me.XrTableCell21.StylePriority.UseForeColor = false
        Me.XrTableCell21.StylePriority.UseTextAlignment = false
        '
        'XrTableCell27
        '
        Me.XrTableCell27.CanGrow = false
        resources.ApplyResources(Me.XrTableCell27, "XrTableCell27")
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StyleName = "FieldCaption"
        Me.XrTableCell27.StylePriority.UseFont = false
        Me.XrTableCell27.StylePriority.UseForeColor = false
        Me.XrTableCell27.StylePriority.UseTextAlignment = false
        '
        'XrTableCell33
        '
        Me.XrTableCell33.CanGrow = false
        resources.ApplyResources(Me.XrTableCell33, "XrTableCell33")
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StyleName = "FieldCaption"
        Me.XrTableCell33.StylePriority.UseFont = false
        Me.XrTableCell33.StylePriority.UseForeColor = false
        Me.XrTableCell33.StylePriority.UseTextAlignment = false
        '
        'XrTableCell35
        '
        Me.XrTableCell35.CanGrow = false
        resources.ApplyResources(Me.XrTableCell35, "XrTableCell35")
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StyleName = "FieldCaption"
        Me.XrTableCell35.StylePriority.UseFont = false
        Me.XrTableCell35.StylePriority.UseForeColor = false
        Me.XrTableCell35.StylePriority.UseTextAlignment = false
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        resources.ApplyResources(Me.PageFooterBand1, "PageFooterBand1")
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        resources.ApplyResources(Me.XrPageInfo1, "XrPageInfo1")
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'XrPageInfo2
        '
        resources.ApplyResources(Me.XrPageInfo2, "XrPageInfo2")
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.TxtStartDate, Me.XrLabel34, Me.TxtEndDate, Me.XrLabel1})
        resources.ApplyResources(Me.ReportHeaderBand1, "ReportHeaderBand1")
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.XrLabel11, "XrLabel11")
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel11.StyleName = "FieldCaption"
        Me.XrLabel11.StylePriority.UseBorders = false
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.StylePriority.UseForeColor = false
        '
        'TxtStartDate
        '
        resources.ApplyResources(Me.TxtStartDate, "TxtStartDate")
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.TxtStartDate.StylePriority.UseTextAlignment = false
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.XrLabel34, "XrLabel34")
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel34.StyleName = "FieldCaption"
        Me.XrLabel34.StylePriority.UseBorders = false
        Me.XrLabel34.StylePriority.UseFont = false
        Me.XrLabel34.StylePriority.UseForeColor = false
        '
        'TxtEndDate
        '
        resources.ApplyResources(Me.TxtEndDate, "TxtEndDate")
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.TxtEndDate.StylePriority.UseTextAlignment = false
        '
        'XrLabel1
        '
        resources.ApplyResources(Me.XrLabel1, "XrLabel1")
        Me.XrLabel1.Multiline = true
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        '
        'TopMarginBand1
        '
        resources.ApplyResources(Me.TopMarginBand1, "TopMarginBand1")
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        resources.ApplyResources(Me.BottomMarginBand1, "BottomMarginBand1")
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
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        resources.ApplyResources(Me.Detail1, "Detail1")
        Me.Detail1.Name = "Detail1"
        '
        'XrTable2
        '
        Me.XrTable2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom),DevExpress.XtraReports.UI.VerticalAnchorStyles)
        resources.ApplyResources(Me.XrTable2, "XrTable2")
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable2.StylePriority.UseTextAlignment = false
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell22, Me.XrTableCell24, Me.XrTableCell28, Me.XrTableCell30, Me.XrTableCell34, Me.XrTableCell36})
        Me.XrTableRow8.Name = "XrTableRow8"
        resources.ApplyResources(Me.XrTableRow8, "XrTableRow8")
        '
        'XrTableCell20
        '
        Me.XrTableCell20.CanGrow = false
        Me.XrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.SaleNo]")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StyleName = "DataField"
        Me.XrTableCell20.StylePriority.UseTextAlignment = false
        resources.ApplyResources(Me.XrTableCell20, "XrTableCell20")
        '
        'XrTableCell22
        '
        Me.XrTableCell22.CanGrow = false
        Me.XrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.SaleDate]")})
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StyleName = "DataField"
        resources.ApplyResources(Me.XrTableCell22, "XrTableCell22")
        '
        'XrTableCell24
        '
        Me.XrTableCell24.CanGrow = false
        Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.Total]")})
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StyleName = "DataField"
        resources.ApplyResources(Me.XrTableCell24, "XrTableCell24")
        '
        'XrTableCell28
        '
        Me.XrTableCell28.CanGrow = false
        Me.XrTableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.SubTotal]")})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StyleName = "DataField"
        resources.ApplyResources(Me.XrTableCell28, "XrTableCell28")
        '
        'XrTableCell30
        '
        Me.XrTableCell30.CanGrow = false
        Me.XrTableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.TaxAmt]")})
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StyleName = "DataField"
        resources.ApplyResources(Me.XrTableCell30, "XrTableCell30")
        '
        'XrTableCell34
        '
        Me.XrTableCell34.CanGrow = false
        Me.XrTableCell34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.TerminalName]")})
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StyleName = "DataField"
        resources.ApplyResources(Me.XrTableCell34, "XrTableCell34")
        '
        'XrTableCell36
        '
        Me.XrTableCell36.CanGrow = false
        Me.XrTableCell36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sale.FirstName]")})
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StyleName = "DataField"
        resources.ApplyResources(Me.XrTableCell36, "XrTableCell36")
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2, Me.XrLine1})
        resources.ApplyResources(Me.ReportFooter, "ReportFooter")
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([SubTotal])")})
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.StylePriority.UseBorders = false
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseForeColor = false
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel3.Summary = XrSummary1
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.StyleName = "FieldCaption"
        Me.XrLabel2.StylePriority.UseBorders = false
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseForeColor = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        '
        'XrLine1
        '
        resources.ApplyResources(Me.XrLine1, "XrLine1")
        Me.XrLine1.Name = "XrLine1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "iEasyPOS.My.MySettings.ConnectionDB"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Sale"
        QueryParameter1.Name = "Parameter1"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.Parameter1]", GetType(String))
        QueryParameter2.Name = "Parameter2"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.Parameter2]", GetType(String))
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
        'ReportCancleSale
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1, Me.DetailReport, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SumDC, Me.SumSubTotal, Me.SumTax})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "Sale"
        Me.DataSource = Me.SqlDataSource1
        resources.ApplyResources(Me, "$this")
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1, Me.Parameter2})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = false
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "18.2"
        CType(Me.XrTable1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrTable2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
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
End Class
