Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mail.SmtpException
Imports System.Net.NetworkCredential
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO.Directory
Imports System.Globalization
Imports System
Imports System.IO
Imports System.Collections
Imports DevExpress.Pdf.Drawing
Imports DevExpress.Docs
Imports DevExpress.Pdf
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Module ModuleShift
    Public DateOpen As String
    Public DateClose As String
    Public QrThai As Decimal = 0.00
    Public QrAlipay As Decimal = 0.00
    Public QrWechat As Decimal = 0.00

    Public grabfood As Decimal = 0.00
    Public lineman As Decimal = 0.00
    Public shopee As Decimal = 0.00
    Public foodpanda As Decimal = 0.00
    Public robinhood As Decimal = 0.00
    Public AirPay As Decimal = 0.00

    Public CreditCard As Decimal = 0.00
    Public totalcash As Decimal = 0.00
    Function LoadUserName(userid As Integer)
        Dim DataUserName As Data.DataTable = executesql("SELECT FirstName FROM Users WHERE UserId='" & userid & "'")
        If IsNothing(DataUserName) Then
            Exit Function
        ElseIf DataUserName.Rows.Count = 0 Then
            Exit Function
        End If
        Frm_OpenShift.LbUserName.Text = DataUserName(0)("FirstName")
        Frm_CloseShift.LbUserName.Text = DataUserName(0)("FirstName")
    End Function
    Sub LoadDataOpenShift()
        Dim Terminal As String = Environment.MachineName
        Dim DataOpenShift As Data.DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "')")
        If IsNothing(DataOpenShift) Then
            MsgBox("ปิดการขายไม่ถูกต้อง", MsgBoxStyle.Critical, "")
            Exit Sub
        ElseIf DataOpenShift.Rows.Count = 0 Then
            MsgBox("ปิดการขายไม่ถูกต้อง", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim DataUserName As Data.DataTable = executesql("SELECT FirstName FROM Users WHERE UserId=" & DataOpenShift(0)("UserId") & "")
        Dim Username As String
        'Dim DateTimeOpen As DateTime
        'Dim DateUse As String
        Dim MoneyCashChange As Decimal = 0.00
        If IsNothing(DataUserName) Then
            Username = ""
            DateOpen = ""
        ElseIf DataUserName.Rows.Count = 0 Then
            Username = ""
            DateOpen = ""
        ElseIf DataUserName.Rows.Count > 0 Then
            Username = DataUserName(0)("FirstName")
            DateOpen = Convert.ToDateTime(DataOpenShift(0)("DateTimeOpen")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            MoneyCashChange = DataOpenShift(0)("MoneyCash")
        End If
        Frm_CloseShift.LabelUseropenshift.Text = Username
        Frm_CloseShift.labeldatetimeopen.Text = Convert.ToDateTime(DataOpenShift(0)("DateTimeOpen")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        Frm_CloseShift.LabelTime1.Text = Convert.ToDateTime(DataOpenShift(0)("DateTimeOpen")).ToString("HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Frm_CloseShift.TxtChangeMoney.Text = FormatNumber(MoneyCashChange, 2)
    End Sub
    Sub LoadNetSale()

        Dim UserNameOpenShift As String = Frm_CloseShift.LabelUseropenshift.Text
        DateClose = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim SumTotalNetSale As Decimal = 0.00

        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")
        Dim Datatable12 As DataTable = executesql("Select  sum(SubTotal) As SubTotal from sale   Where sale.Active = 1 And SaleDate BETWEEN CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")


        'GiftCard
        Dim DataGiftCard As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 18 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")

        'GrabFood
        Dim DataGrabFood As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 19 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        'GrabFood
        Dim DataAirPay As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 20 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")

        'Lineman
        Dim DataLineman As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 21 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")

        'Robinhood
        Dim DataRobinhood As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 22 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        'DataShopee
        Dim DataShopee As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 23 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        'DataShopee
        Dim DataFoodPanda As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 24 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")


        If Datatable8.Rows.Count > 0 Then
            If IsDBNull(Datatable8(0)("SubTotal")) Then
                QrThai = 0
            Else
                QrThai = Datatable8(0)("SubTotal")
            End If
        End If
        If Datatable9.Rows.Count > 0 Then
            If IsDBNull(Datatable9(0)("SubTotal")) Then
                QrAlipay = 0
            Else
                QrAlipay = Datatable9(0)("SubTotal")
            End If
        End If
        If Datatable10.Rows.Count > 0 Then
            If IsDBNull(Datatable10(0)("SubTotal")) Then
                QrWechat = 0
            Else
                QrWechat = Datatable10(0)("SubTotal")
            End If
        End If
        If Datatable11.Rows.Count > 0 Then
            If IsDBNull(Datatable11(0)("SubTotal")) Then
                CreditCard = 0
            Else
                CreditCard = Datatable11(0)("SubTotal")
            End If
        End If
        If DataGrabFood.Rows.Count > 0 Then
            If IsDBNull(DataGrabFood(0)("SubTotal")) Then
                grabfood = 0

            Else
                grabfood = DataGrabFood(0)("SubTotal")
            End If
        End If
        If DataAirPay.Rows.Count > 0 Then
            If IsDBNull(DataAirPay(0)("SubTotal")) Then
                AirPay = 0

            Else
                AirPay = DataAirPay(0)("SubTotal")
            End If
        End If
        If DataLineman.Rows.Count > 0 Then
            If IsDBNull(DataLineman(0)("SubTotal")) Then
                lineman = 0

            Else
                lineman = DataLineman(0)("SubTotal")
            End If
        End If
        If DataRobinhood.Rows.Count > 0 Then
            If IsDBNull(DataRobinhood(0)("SubTotal")) Then
                robinhood = 0

            Else
                robinhood = DataRobinhood(0)("SubTotal")
            End If
        End If
        If DataShopee.Rows.Count > 0 Then
            If IsDBNull(DataShopee(0)("SubTotal")) Then
                shopee = 0

            Else
                shopee = DataShopee(0)("SubTotal")
            End If
        End If
        If DataFoodPanda.Rows.Count > 0 Then
            If IsDBNull(DataFoodPanda(0)("SubTotal")) Then
                foodpanda = 0

            Else
                foodpanda = DataFoodPanda(0)("SubTotal")
            End If
        End If
        If Datatable12.Rows.Count > 0 Then
            If IsDBNull(Datatable12(0)("SubTotal")) Then
                totalcash = 0
                Frm_CloseShift.TxtSumSale.Text = 0
            Else
                totalcash = Datatable12(0)("SubTotal")
                SumTotalNetSale = totalcash - (CreditCard + QrWechat + QrAlipay + QrThai + CreditCard + grabfood + AirPay + lineman + robinhood + shopee + foodpanda)
                Frm_CloseShift.TxtSumSale.Text = FormatNumber(SumTotalNetSale, 2)
            End If
        End If
        'Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126) AND Active = 1")
        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where convert(date,InsertDate,101) BETWEEN convert(date,'" & DateOpen & "',101)  AND  convert(date,'" & DateClose & "',101)")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            Frm_CloseShift.txtWithdraw.Text = "0.00"
        Else
            Frm_CloseShift.txtWithdraw.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
        End If


    End Sub
    Function OpenShift(userid As Integer, money As Decimal, TypeSale As String)
        If userid = 0 Then
            Exit Function
        End If
        Dim TypeShift As String = "OPEN"
        Dim StatusShift As Integer = 1
        Dim DateOpenShift As String = Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim Terminal As String = Environment.MachineName
        executesql("INSERT INTO OpenCloseShift(MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName) VALUES(" & money & ",'" & userid & "','" & TypeShift & "',CONVERT(datetime, '" & DateOpenShift & "', 126),'" & StatusShift & "','" & Terminal & "')")
        If TypeSale = "POS" Then
            POS.Close()
            POS.Show()
        ElseIf TypeSale = "Table"
            FrmTable.Close()
            FrmTable.Show()
        End If
        Frm_OpenShift.Close()
    End Function
    Function CloseShift(userid As String, money As Decimal)
        If userid = 0 Then
            Exit Function
        End If
        Dim terminalname As String = Environment.MachineName
        Dim DataShiftId As Data.DataTable = executesql("SELECT MAX(ShiftId) AS ShiftId FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & terminalname & "')")
        If IsNothing(DataShiftId) Then
            MsgBox("ทำการปิดกะไม่ถูกต้อง", MsgBoxStyle.Critical, "ปิดกะ")
            Return "Not pass"
            Exit Function
        ElseIf DataShiftId.Rows.Count = 0 Then
            MsgBox("ทำการปิดกะไม่ถูกต้อง", MsgBoxStyle.Critical, "ปิดกะ")
            Return "Not pass"
            Exit Function
        End If

        Dim DataTypeShift As Data.DataTable = executesql("SELECT TypeShift,DateTimeOpen FROM OpenCloseShift WHERE ShiftId='" & DataShiftId(0)("ShiftId") & "'")
        If IsNothing(DataTypeShift) Then
            MsgBox("ทำการปิดกะไม่ถูกต้อง", MsgBoxStyle.Critical, "ปิดกะ")
            Return "Not pass"
            Exit Function
        ElseIf DataTypeShift.Rows.Count = 0 Then
            MsgBox("ทำการปิดกะไม่ถูกต้อง", MsgBoxStyle.Critical, "ปิดกะ")
            Return "Not pass"
            Exit Function
        ElseIf DataTypeShift(0)("TypeShift") <> "OPEN" Then
            MsgBox("กรุณาทำการเปิดกะการขายก่อน", MsgBoxStyle.Critical, "ปิดกะ")
            Return "Not pass"
            Exit Function
        End If
        'Data Cash 
        Dim b1000 As Integer = 0
        Dim b500 As Integer = 0
        Dim b100 As Integer = 0
        Dim b50 As Integer = 0
        Dim b20 As Integer = 0
        Dim c10 As Integer = 0
        Dim c5 As Integer = 0
        Dim c2 As Integer = 0
        Dim c1 As Integer = 0
        Dim c050 As Integer = 0
        Dim c025 As Integer = 0
        Dim SumTotalNetSale As Decimal = 0.00
        'b1000
        If Frm_CloseShift.TxtAmount1000.Text = "" Then
        Else
            b1000 = Frm_CloseShift.TxtAmount1000.Text
        End If
        'b500
        If Frm_CloseShift.TxtAmount500.Text = "" Then
        Else
            b500 = Frm_CloseShift.TxtAmount500.Text
        End If
        'b100
        If Frm_CloseShift.TxtAmount100.Text = "" Then
        Else
            b100 = Frm_CloseShift.TxtAmount100.Text
        End If
        'b50 
        If Frm_CloseShift.TxtAmount50.Text = "" Then
        Else
            b50 = Frm_CloseShift.TxtAmount50.Text
        End If
        'b20 
        If Frm_CloseShift.TxtAmount20.Text = "" Then
        Else
            b20 = Frm_CloseShift.TxtAmount20.Text
        End If
        'c10 
        If Frm_CloseShift.TxtAmount10.Text = "" Then
        Else
            c10 = Frm_CloseShift.TxtAmount10.Text
        End If
        'c5
        If Frm_CloseShift.TxtAmount5.Text = "" Then
        Else
            c5 = Frm_CloseShift.TxtAmount5.Text
        End If
        'c2 
        If Frm_CloseShift.TxtAmount2.Text = "" Then
        Else
            c2 = Frm_CloseShift.TxtAmount2.Text
        End If
        'c1 
        If Frm_CloseShift.TxtAmount1.Text = "" Then
        Else
            c1 = Frm_CloseShift.TxtAmount1.Text
        End If
        'c050
        If Frm_CloseShift.TxtAmount050.Text = "" Then
        Else
            c050 = Frm_CloseShift.TxtAmount050.Text
        End If
        'c025 
        If Frm_CloseShift.TxtAmount025.Text = "" Then
        Else
            c025 = Frm_CloseShift.TxtAmount025.Text
        End If
        'Insert Data To CloseShift 
        Dim typeshift As String = "CLOSE"
        Dim statusshift As Integer = 0
        Dim datecloseshift As String = Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        DateClose = datecloseshift
        DateOpen = DataTypeShift(0)("datetimeopen")
        DateOpen = Convert.ToDateTime(DataTypeShift(0)("datetimeopen")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim terminal As String = Environment.MachineName
        If Frm_CloseShift.TxtNetSale.Text = "" Then
        ElseIf Frm_CloseShift.TxtNetSale.Text <> "" Then
            SumTotalNetSale = Frm_CloseShift.TxtNetSale.Text
        End If
        'executesql("INSERT INTO opencloseshift(moneycash,userid,typeshift,datetimeopen,statusshift,terminalname,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025,TotalNetSale) 
        'VALUES(" & money & ",'" & userid & "','" & typeshift & "','" & datecloseshift & "','" & statusshift & "','" & terminal & "'
        '," & b1000 & "," & b500 & "," & b100 & "," & b50 & "," & b20 & "," & c10 & "," & c5 & "," & c2 & "," & c1 & "," & c050 & "," & c025 & "," & SumTotalNetSale & ")")

        executesql("UPDATE opencloseshift SET CloseUserID='" & userid & "',typeshift='CLOSE',DateTimeClose='" & datecloseshift & "',statusshift=0,B1000=" & b1000 & ",B500=" & b500 & ",B100=" & b100 & ",B50=" & b50 & ",B20=" & b20 & ",C10=" & c10 & ",C5=" & c5 & ",C2=" & c2 & ",C1=" & c1 & ",C05=" & c050 & ",C025=" & c025 & ",TotalNetSale=" & SumTotalNetSale & " WHERE terminalname='" & terminal & "' AND typeshift='OPEN' ")
        Dim MxSift As DataTable = executesql("SELECT MAX(ShiftId) As ShiftId FROM OpenCloseShift WHERE TerminalName='" & terminalname & "'")
        Main.BtnCloseShift.Visible = False
        'SaleReport
        Dim Report As New ReportDays80mmCloseShift
        Report.Parameter1.Value = DateOpen
        Report.Parameter2.Value = DateClose
        Report.DateTimeOpenShift = DateOpen
        Report.DateTimeCloseShift = DateClose
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Printool.PrinterSettings.Copies = My.Settings.ReportCopies
        Report.SqlDataSource1.Connection.ConnectionString = rptConStr
        Report.Print

        'รายงานการปิดการขาย
        Dim ReportClose80 As New ReportCloseShift_80mm
        ReportClose80.Parameter1.Value = DateOpen
        ReportClose80.Parameter2.Value = DateClose
        ReportClose80.DateTimeOpenShift = DateOpen
        ReportClose80.DateTimeCloseShift = DateClose
        ReportClose80.shiftId = MxSift(0)("ShiftId")
        Dim Printool_ReportClose80 As New ReportPrintTool(ReportClose80)
        ReportClose80.PrinterName = GetPrinterName(0)("SettingValue")
        Printool_ReportClose80.PrinterSettings.Copies = My.Settings.ReportCloseShift_copies
        ReportClose80.Print

        'ใบปิดกะ
        Dim PrintClose As New CloseShiftPrint
        PrintClose.Parameter1.Value = DateOpen
        PrintClose.Parameter2.Value = DateClose
        Dim Printool_PrintClose As New ReportPrintTool(PrintClose)
        PrintClose.PrinterName = GetPrinterName(0)("SettingValue")
        Printool_PrintClose.PrinterSettings.Copies = My.Settings.CloseShiftPrint_copies
        PrintClose.Print

        'Dim ReportTopping As New Report_ToppingSale80mm
        'ReportTopping.parameter1.Value = DateOpen
        'ReportTopping.parameter2.Value = DateClose
        'ReportTopping.PrinterName = GetPrinterName(0)("SettingValue")
        'ReportTopping.SqlDataSource1.Connection.ConnectionString = rptConStr
        'Dim DataTopping As DataTable = executesql("select count(UseTopping.ToppingId) as Count_ToppingId,
        '                                               UseTopping.ToppingName,
        '                                               sum(Topping.Pricing) as Sum_Pricing,
        '                                               Item.ItemName,
        '                                               CategoryItem.CategoryName
        '                                          from (((((dbo.UseTopping UseTopping
        '                                          inner join dbo.Topping Topping
        '                                               on (Topping.ToppingId = UseTopping.ToppingId))
        '                                          inner join dbo.SaleItem SaleItem
        '                                               on (SaleItem.SaleItemId = UseTopping.SaleItemId))
        '                                          inner join dbo.Sale Sale
        '                                               on (Sale.SaleId = SaleItem.SaleId))
        '                                          inner join dbo.Item Item
        '                                               on (Item.ItemId = SaleItem.ItemId))
        '                                          inner join dbo.CategoryItem CategoryItem
        '                                               on (CategoryItem.CategoryId = Item.CategoryId))
        '                                        where Sale.SaleDate BETWEEN '" & ReportTopping.parameter1.Value & "' 
        '                                                AND '" & ReportTopping.parameter2.Value & "' AND Sale.Active = 1

        '                                        group by CategoryItem.CategoryName,
        '                                               SaleItem.ItemName, Item.ItemName,
        '                                               UseTopping.ToppingName")
        'If DataTopping.Rows.Count > 0 Then
        '    ReportTopping.Print
        'End If

        'รายงานการขาย ลูกค้า
        Dim report_CustomerSale As New Report_CustomerSale80
        report_CustomerSale.Parameter1.Value = DateOpen
        report_CustomerSale.Parameter2.Value = DateClose
        report_CustomerSale.XrLabel1.Text = DateOpen
        report_CustomerSale.XrLabel2.Text = DateClose
        report_CustomerSale.PrinterName = GetPrinterName(0)("SettingValue")
        report_CustomerSale.SqlDataSource1.Connection.ConnectionString = rptConStr
        Dim DtCustomerSale As DataTable = executesql("select Customer.FirstName, Customer.LastName,Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,SaleItem.ItemName, SaleItem.Qty, SaleItem.UnitPrice from ((dbo.Customer Customer inner join dbo.Sale Sale on (Sale.CustomerId = Customer.CustomerId)) inner join dbo.SaleItem SaleItem on (SaleItem.SaleId = Sale.SaleId)) where sale.saledate between '" & DateOpen & "' and '" & DateClose & "'")

        If DtCustomerSale.Rows.Count > 0 Then
            report_CustomerSale.Print
        End If


    End Function

    Sub SendEmailExportPDF()
        Dim f As String = "C:\ExportReport"
        If Directory.Exists(f) Then
            'MsgBox("has file")
        Else
            ' MsgBox("Don't has file")
            My.Computer.FileSystem.CreateDirectory(f)
        End If
        '' Delete File in \ExportReport
        'For Each files In Directory.GetFiles("c:\ExportReport\")
        '    File.Delete(files)
        'Next
        Dim report_CloseShift As New ReportCloseShift
        report_CloseShift.Parameter1.Value = ModuleShift.DateOpen
        report_CloseShift.Parameter2.Value = ModuleShift.DateClose
        report_CloseShift.DateTimeOpenShift = ModuleShift.DateOpen
        report_CloseShift.DateTimeCloseShift = ModuleShift.DateClose

        Dim report_CancleSale As New ReportCancleSale
        report_CancleSale.Parameter1.Value = ModuleShift.DateOpen
        report_CancleSale.Parameter2.Value = ModuleShift.DateClose
        report_CancleSale.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_ReportDayGroupcate As New ReportDaysCategoryGroup
        report_ReportDayGroupcate.parameter1.Value = DateOpen
        report_ReportDayGroupcate.parameter2.Value = DateClose
        report_ReportDayGroupcate.DateTimeOpenShift = DateOpen
        report_ReportDayGroupcate.DateTimeCloseShift = DateClose
        report_ReportDayGroupcate.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_withdraw As New Report_WithdrawMoney
        report_withdraw.Parameter1.Value = ModuleShift.DateOpen
        report_withdraw.Parameter2.Value = ModuleShift.DateClose
        report_withdraw.SqlDataSource1.Connection.ConnectionString = rptConStr

        'Dim ReportTopping As New Report_ToppingSale
        'ReportTopping.Parameter1.Value = ModuleShift.DateOpen
        'ReportTopping.Parameter2.Value = ModuleShift.DateClose
        'ReportTopping.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_CustomerSale As New Report_CustomerSale
        report_CustomerSale.Parameter1.Value = ModuleShift.DateOpen
        report_CustomerSale.Parameter2.Value = ModuleShift.DateClose
        report_CustomerSale.XrLabel1.Text = ModuleShift.DateOpen
        report_CustomerSale.XrLabel2.Text = ModuleShift.DateClose
        report_CustomerSale.SqlDataSource1.Connection.ConnectionString = rptConStr

        'report lineman
        Dim report_lineman As New Report_Lineman
        report_lineman.Parameter1.Value = ModuleShift.DateOpen
        report_lineman.Parameter2.Value = ModuleShift.DateClose
        report_lineman.LabelTimeStart.Text = Convert.ToDateTime(ModuleShift.DateOpen).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(ModuleShift.DateClose).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        'report_lineman.SqlDataSource1.Connection.ConnectionString = rptConStr

        'report lineman
        Dim report_robinhood As New Report_Robinhood
        report_robinhood.Parameter1.Value = ModuleShift.DateOpen
        report_robinhood.Parameter2.Value = ModuleShift.DateClose
        report_robinhood.LabelTimeStart.Text = Convert.ToDateTime(ModuleShift.DateOpen).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(ModuleShift.DateClose).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        'report_robinhood.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_ShopeeFood As New Report_ShopeeFood
        report_ShopeeFood.Parameter1.Value = ModuleShift.DateOpen
        report_ShopeeFood.Parameter2.Value = ModuleShift.DateClose
        report_ShopeeFood.LabelTimeStart.Text = Convert.ToDateTime(ModuleShift.DateOpen).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(ModuleShift.DateClose).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        'report_ShopeeFood.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim Report_FoodPanda As New Report_FoodPanda
        Report_FoodPanda.Parameter1.Value = ModuleShift.DateOpen
        Report_FoodPanda.Parameter2.Value = ModuleShift.DateClose
        Report_FoodPanda.LabelTimeStart.Text = Convert.ToDateTime(ModuleShift.DateOpen).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(ModuleShift.DateClose).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        ' Report_FoodPanda.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_GiftCard As New Report_GiftCard
        report_GiftCard.Parameter1.Value = ModuleShift.DateOpen
        report_GiftCard.Parameter2.Value = ModuleShift.DateClose
        report_GiftCard.LabelTimeStart.Text = Convert.ToDateTime(ModuleShift.DateOpen).ToString("dd MMMM yyyy HH:mm", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(ModuleShift.DateClose).ToString("dd MMMM yyyy HH:mm", New System.Globalization.CultureInfo("th-TH"))
        'report_GiftCard.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim dtGiftCard As DataTable = executesql("SELECT  PaymentDetail.VoucherNumber, Sale.SaleNo, Sale.SaleDate, Sale.SubTotal, SaleItem.ItemCode, SaleItem.ItemName,SaleItem.Qty, PaymentDetail.PaymentTypeId FROM PaymentDetail INNER JOIN Sale ON PaymentDetail.SaleId = Sale.SaleId INNER JOIN SaleItem ON Sale.SaleId = SaleItem.SaleId where PaymentDetail.PaymentTypeId in (18,19) and Sale.SaleDate between CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")

        Dim DtCustomerSale As DataTable = executesql("select Customer.FirstName, Customer.LastName,Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,SaleItem.ItemName, SaleItem.Qty, SaleItem.UnitPrice from ((dbo.Customer Customer inner join dbo.Sale Sale on (Sale.CustomerId = Customer.CustomerId)) inner join dbo.SaleItem SaleItem on (SaleItem.SaleId = Sale.SaleId)) where sale.saledate between CONVERT(datetime, '" & DateOpen & "', 126) AND CONVERT(datetime, '" & DateClose & "', 126)")

        Dim FileName_CloseShift As String = "CloseShiftReport" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportCancleSale As String = "CancleSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        'Dim FileName_ReportMainPOS As String = "ReportMainPOS" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        'Dim FileName_ReportKiosk As String = "ReportKiosk" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_withdraw As String = "Report_WithdrawMoney" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        'Dim FileName_report_ReportTopping As String = "Report_ReportTopping" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim File_report_CustomerSale As String = "Report_CustomerSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        report_ReportDayGroupcate.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")

        report_CloseShift.ExportToXls("C:\ExportReport\" & FileName_CloseShift & ".xls")

        report_CancleSale.ExportToXls("C:\ExportReport\" & FileName_ReportCancleSale & ".xls")

        report_withdraw.ExportToXlsx("C:\ExportReport\" & FileName_report_withdraw & ".xls")


        Dim FileName_report_Lineman As String = "Report_Lineman" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_Robinhood As String = "Report_Robinhood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_ShopeeFood As String = "Report_ShopeeFood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_Report_FoodPanda As String = "Report_FoodPanda" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim File_report_GiftCard As String = "Report_GiftCard_GrabFood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        report_lineman.ExportToXlsx("C:\ExportReport\" & FileName_report_Lineman & ".xls")
        report_robinhood.ExportToXlsx("C:\ExportReport\" & FileName_report_Robinhood & ".xls")
        report_ShopeeFood.ExportToXlsx("C:\ExportReport\" & FileName_report_ShopeeFood & ".xls")
        report_ShopeeFood.ExportToXlsx("C:\ExportReport\" & FileName_Report_FoodPanda & ".xls")
        'ReportTopping.ExportToXlsx("C:\ExportReport\" & FileName_report_ReportTopping & ".xls")

        If DtCustomerSale.Rows.Count > 0 Then
            report_CustomerSale.ExportToXlsx("C:\ExportReport\" & File_report_CustomerSale & ".xls")
        End If

        If dtGiftCard.Rows.Count > 0 Then
            report_GiftCard.ExportToXlsx("C:\ExportReport\" & File_report_GiftCard & ".xls")
        End If

        Dim email As String = "prawit@ieasy.asia"
        Dim password As String = "Green/97"
        Dim emailmessage As New MailMessage()
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        Try
            emailmessage.From = New MailAddress(email)
            'emailmessage.To.Add(My.Settings.email)
            Dim SelectEmail As DataTable = executesql("SELECT Emails FROM Branch WHERE Active=1")
            If IsDBNull(SelectEmail(0)("Emails")) Then
                Frm_CloseShift.Close()

                Main2.Close()

                Frm_Login.Show()
                Frm_Login.panel_number.Visible = False
                Frm_Login.PanelUsers.Visible = True
                Frm_Login.txt_password.Text = ""
                Frm_Login.LabelUser.Text = ""
                Frm_Login.UserId = 0
            End If
            If SelectEmail.Rows.Count = 0 Then
                Frm_CloseShift.Close()

                Main2.Close()

                Frm_Login.Show()
                Frm_Login.panel_number.Visible = False
                Frm_Login.PanelUsers.Visible = True
                Frm_Login.txt_password.Text = ""
                Frm_Login.LabelUser.Text = ""
                Frm_Login.UserId = 0
            End If
            If SelectEmail.Rows.Count > 0 Then
                Dim Emails As String() = SelectEmail(0)("Emails").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                For i As Integer = 0 To Emails.Length - 1
                    emailmessage.To.Add(Emails(i))
                Next
            End If

            emailmessage.Subject = "รายงานการขาย" + (Baranch_name(0)("BranchName")) + " " + (Now.ToString("dd-MM-yyyy"))

            emailmessage.Body = "รายงานการขาย" + (Baranch_name(0)("BranchName")) + " " + (Now.ToString("dd-MM-yyyy"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_CloseShift & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportCancleSale & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_withdraw & ".xls"))

            If My.Settings.isDelivery = True Then
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_Lineman & ".xls"))
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_Robinhood & ".xls"))
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_ShopeeFood & ".xls"))
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_Report_FoodPanda & ".xls"))

            End If


            'emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_ReportTopping & ".xls"))

            If DtCustomerSale.Rows.Count > 0 Then
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_CustomerSale & ".xls"))
            End If
            If dtGiftCard.Rows.Count > 0 Then
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_GiftCard & ".xls"))
            End If

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(email, password)
            smtp.Send(emailmessage)
        Catch ex As Exception
            MsgBox(ex.Message)
            writeLog(ex.Message + " send mail error")
        End Try
        Frm_CloseShift.ProgressPanel1.Hide()
        writeLog("User ID " + Frm_Login.UserId.ToString + " Send mail complete")
        MsgBox("Send Complete", MsgBoxStyle.Information, "Send Mail")

        Frm_CloseShift.Close()

        Main2.Close()

        Frm_Login.Show()
        Frm_Login.panel_number.Visible = False
        Frm_Login.PanelUsers.Visible = True
        Frm_Login.txt_password.Text = ""
        Frm_Login.LabelUser.Text = ""
        Frm_Login.UserId = 0

    End Sub
    Function CalculateCash(Amount As String, Cash As Decimal)
        Dim SumCash As Decimal = 0.00
        If Amount = "" Then
            Return SumCash
        Else
            SumCash = CDbl(Amount) * Cash
            Return SumCash
        End If
    End Function
    Function SumTotalCash()
        Dim Cash1000 As Decimal = 0.00
        Dim Cash500 As Decimal = 0.00
        Dim Cash100 As Decimal = 0.00
        Dim Cash50 As Decimal = 0.00
        Dim Cash20 As Decimal = 0.00
        Dim Cash10 As Decimal = 0.00
        Dim Cash5 As Decimal = 0.00
        Dim Cash2 As Decimal = 0.00
        Dim Cash1 As Decimal = 0.00
        Dim Cash050 As Decimal = 0.00
        Dim Cash025 As Decimal = 0.00
        Dim SumTotal As Decimal = 0.00
        'Cash1000
        If Frm_CloseShift.TxtCash1000.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash1000.Text <> "" Then
            Cash1000 = CDbl(Frm_CloseShift.TxtCash1000.Text)
        End If
        'cash500
        If Frm_CloseShift.TxtCash500.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash500.Text <> "" Then
            Cash500 = CDbl(Frm_CloseShift.TxtCash500.Text)
        End If
        'cash 100
        If Frm_CloseShift.TxtCash100.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash100.Text <> "" Then
            Cash100 = Frm_CloseShift.TxtCash100.Text
        End If
        'Cash 50 
        If Frm_CloseShift.TxtCash50.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash50.Text <> "" Then
            Cash50 = CDbl(Frm_CloseShift.TxtCash50.Text)
        End If
        'Cash 20
        If Frm_CloseShift.TxtCash20.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash20.Text <> "" Then
            Cash20 = Frm_CloseShift.TxtCash20.Text
        End If
        'Cash 10 
        If Frm_CloseShift.TxtCash10.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash10.Text <> "" Then
            Cash10 = CDbl(Frm_CloseShift.TxtCash10.Text)
        End If
        'Cash 5 
        If Frm_CloseShift.TxtCash5.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash5.Text <> "" Then
            Cash5 = CDbl(Frm_CloseShift.TxtCash5.Text)
        End If
        'Cash2 
        If Frm_CloseShift.TxtCash2.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash2.Text <> "" Then
            Cash2 = CDbl(Frm_CloseShift.TxtCash2.Text)
        End If
        'Cash1 
        If Frm_CloseShift.TxtCash1.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash1.Text <> "" Then
            Cash1 = CDbl(Frm_CloseShift.TxtCash1.Text)
        End If
        'Cash 0.50 
        If Frm_CloseShift.TxtCash050.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash050.Text <> "" Then
            Cash050 = CDbl(Frm_CloseShift.TxtCash050.Text)
        End If
        'Cash 0.25 
        If Frm_CloseShift.TxtCash025.Text = ""  Then
        ElseIf Frm_CloseShift.TxtCash025.Text <> "" Then
            Cash025 = CDbl(Frm_CloseShift.TxtCash025.Text)
        End If
        SumTotal = Cash1000 + Cash500 + Cash100 + Cash50 + Cash20 + Cash10 + Cash5 + Cash2 + Cash1 + Cash050 + Cash025
        Return SumTotal
    End Function
    Function BtnDel(TxtAmountName As String)
        Dim textbox1 As New TextBox
        textbox1.Name = "TxtAmount1000"
        Dim count_txt As Integer = textbox1.TextLength
        Dim newtxt As String = ""
        Dim i As Integer = 0
        'Dim txt_arr As Array
        For i = 1 To (count_txt - 1) Step 1
            newtxt = textbox1.Text.Substring(0, i)
        Next
        textbox1.Clear()
        textbox1.Text = newtxt
    End Function
    Function CalculateNetSale(Money As Decimal, Change As Decimal)
        Dim MoneyCashInDrawer As Decimal = 0.00
        Dim MoneyChange As Decimal = Change
        Dim SumTotal As Decimal = 0.00
        If Money = 0.00 Then
        ElseIf Money > 0.00
            MoneyCashInDrawer = Money
            SumTotal = MoneyCashInDrawer - MoneyChange

        End If
    End Function
End Module
