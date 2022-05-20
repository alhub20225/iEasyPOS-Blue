Imports DevExpress.XtraReports.UI

Public Class FrmReportDay
    Public Shared Date_start As String
    Public Shared Date_End As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim DataOpenShift As Data.DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "' AND TypeShift='OPEN')")
        'DateTimeOpenShift = getdate(DataOpenShift(0)("DateTimeOpen"))

        Dim DataCloseShift As Data.DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "' AND TypeShift='CLOSE')")
        'DateTimeCloseShift = getdate(DataCloseShift(0)("DateTimeOpen"))
        Dim report As New ReportDays
        Dim Datatable1 As DataTable = executesql("SELECT SaleItem.ItemId,SaleItem.CategoryId,Item.ItemCode,Item.ItemName,SaleItem.InitPrice,SaleItem.UnitPrice,
                                                   SUM(SaleItem.PercentDC) AS PercentDC,
	                                               SUM(SaleItem.BahtDC) As BahtDC,
                                                   SUM(SaleItem.Qty) AS Qty,
                                                   SUM(SaleItem.SubTotal) As SubTotal, 
	                                               SUM(SaleItem.Tax) AS Tax,
                                                   SUM(SaleItem.Total) AS Total,
												   CategoryItem.CategoryName
                                                   FROM SaleItem
													inner join Item
													on (Item.ItemId = SaleItem.ItemId)
													inner join CategoryItem
													on (CategoryItem.CategoryId = SaleItem.CategoryId)
													inner join Sale
													on (Sale.Saleid = SaleItem.SaleId)
                                                   WHERE SaleItem.InsertDate 
                                                   BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND Sale.Active = 1
                                                   GROUP BY SaleItem.ItemId,
                                                   SaleItem.CategoryId,
                                                   Item.ItemCode,
                                                   Item.ItemName,
                                                   CategoryItem.CategoryName,
	                                               SaleItem.InitPrice,
	                                               SaleItem.UnitPrice")
        Dim AmountDC As DataTable = executesql("SELECT Sum(AmountDC) AS AmountDC FROM SALE WHERE SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND Active=1")
        Dim Stt As DataTable = executesql("select SUM(SaleItem.Total) AS Total from saleitem inner join Sale on (Sale.Saleid = SaleItem.SaleId)
                                            WHERE SaleItem.InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' AND Sale.Active = 1")
        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'")

        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            report.txtwithDraw.Text = 0
        Else
            report.txtwithDraw.Text = sum_withDraw(0)("WithdrawAmount")
        End If
        Dim St As Double = 0
        Dim Adc As Double = 0
        If IsDBNull(Stt(0)("Total")) Then
            St = 0
        Else
            St = Stt(0)("Total")
        End If

        If IsDBNull(AmountDC(0)("AmountDC")) Then
            report.sum_spe_dc.Text = 0.00
            Adc = 0
        Else
            report.sum_spe_dc.Text = FormatNumber(AmountDC(0)("AmountDC"), 2)
            Adc = AmountDC(0)("AmountDC")
        End If

        'MsgBox(Stt(0)("Total"))
        'MsgBox(AmountDC(0)("AmountDC").ToString)
        'report.txt_gloss_sale.Text = FormatNumber(St - Adc - report.txtwithDraw.Text, 2)
        report.DataSource = Datatable1
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report

    End Sub

    Private Sub FrmReportDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class