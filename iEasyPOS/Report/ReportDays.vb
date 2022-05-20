Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class ReportDays
    Private Sub ReportDays_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        'Dim DateTimeOpenShift As String
        'Dim DateTimeCloseShift As String
        'Select Datetime Open Shift 
        Dim Terminal As String = Environment.MachineName
        Dim DataOpenShift As Data.DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "' AND TypeShift='OPEN')")
        'DateTimeOpenShift = getdate(DataOpenShift(0)("DateTimeOpen"))
        'MsgBox(DateTimeOpenShift)
        'DateTimeCloseShift = getdate(DataCloseShift(0)("DateTimeOpen"))
        'Select Datetime Close Shift 
        Dim DataCloseShift As Data.DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "' AND TypeShift='CLOSE')")
        'MsgBox(DateTimeCloseShift)
        Dim DataSet1 As New DataSet
        DataSet1.DataSetName = "Dataset1"
        FrmReportDay.Date_start = Convert.ToDateTime(FrmReportDay.Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        FrmReportDay.Date_End = Convert.ToDateTime(FrmReportDay.Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

        Dim DataItemSale As DataTable = executesql("SELECT SaleItem.ItemId,SaleItem.CategoryId,Item.ItemCode,Item.ItemName,SaleItem.InitPrice,SaleItem.UnitPrice,
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
                                                   BETWEEN '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "' AND Sale.Active= 1 and        SaleItem.Active = 1
                                                   GROUP BY SaleItem.ItemId,
                                                   SaleItem.CategoryId,
                                                   Item.ItemCode,
                                                   Item.ItemName,
                                                   CategoryItem.CategoryName,
	                                               SaleItem.InitPrice,
	                                               SaleItem.UnitPrice")

        Dim DataBranch As DataTable = executesql("SELECT BranchName FROM Branch")

        'If IsNothing(DataBranch) Then
        '    Exit Sub
        'ElseIf DataBranch.Rows.Count = 0
        '    Exit Sub
        'End If
        If IsNothing(DataItemSale) Then
            Exit Sub
        ElseIf DataItemSale.Rows.Count = 0 Then
            Exit Sub
        End If
        DataSet1.Tables.Add(DataItemSale)
        DataSource = DataSet1
        TxtStartDate.Text = Convert.ToDateTime(FrmReportDay.Date_start).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        TxtEndDate.Text = Convert.ToDateTime(FrmReportDay.Date_End).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        'TxtBranchName.Text = DataBranch(0)("BranchName")
    End Sub
    Dim costss As Decimal = 0
    Dim AmtDC As Decimal = 0
    Dim Total As Decimal = 0

    Private Sub XrLabel30_BeforePrint(sender As Object, e As PrintEventArgs) Handles sum_spe_dc.BeforePrint
        Dim AmountDC As DataTable = executesql("Select Sum(Sale.AmountDC) As AmountDC FROM SALE WHERE Sale.SaleDate  BETWEEN '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "' AND Sale.Active= 1")
        If IsDBNull(AmountDC(0)("AmountDC")) Then
            AmtDC = 0
            Exit Sub
        Else
            Dim SelectDC As DataTable = executesql("select SUM(SaleItem.PercentDC + SaleItem.BahtDC) AS DC from SaleItem inner join Sale on(Sale.SaleId = SaleItem.SaleId) inner join PaymentDetail on (SaleItem.Saleid = PaymentDetail.SaleId) WHERE SaleItem.InsertDate BETWEEN  '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "' AND Sale.Active= 1")
            If IsDBNull(SelectDC(0)("DC")) Then
                sum_spe_dc.Text = FormatNumber(AmountDC(0)("AmountDC"), 2)
                AmtDC = FormatNumber(AmountDC(0)("AmountDC"), 2)
            Else
                sum_spe_dc.Text = FormatNumber(AmountDC(0)("AmountDC") + SelectDC(0)("DC"), 2)
                AmtDC = FormatNumber(AmountDC(0)("AmountDC") + SelectDC(0)("DC"), 2)
            End If
        End If
    End Sub
    Private Sub txtwithDraw_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtwithDraw.BeforePrint
        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "' AND Active = 1")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            txtwithDraw.Text = FormatNumber(0, 2)
        Else
            txtwithDraw.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
        End If
    End Sub
    Private Sub txt_gloss_sale_BeforePrint(sender As Object, e As PrintEventArgs) Handles txt_gloss_sale.BeforePrint
        Dim Stt As DataTable = executesql("select SUM(sale.Total) AS Total from Sale  WHERE Sale.SaleDate BETWEEN '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "' AND Sale.Active=1")
        If IsDBNull(Stt(0)("Total")) Then
            Total = 0
        Else
            Total = Stt(0)("Total")
        End If
        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & FrmReportDay.Date_start & "' AND '" & FrmReportDay.Date_End & "'")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            costss = FormatNumber(0, 2)
        Else
            costss = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
        End If
        txt_gloss_sale.Text = FormatNumber((Total - AmtDC) - costss, 2)
    End Sub
End Class