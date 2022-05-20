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
    Public CreditCard As Decimal = 0.00
    Public totalcash As Decimal = 0.00
    Function LoadUserName(userid As Integer)
        Dim DataUserName As Data.DataTable = executesql("SELECT FristName FROM Users WHERE UserId='" & userid & "'")
        If IsNothing(DataUserName) Then
            Exit Function
        ElseIf DataUserName.Rows.Count = 0
            Exit Function
        End If
        Frm_OpenShift.LbUserName.Text = DataUserName(0)("FristName")
        Frm_CloseShift.LbUserName.Text = DataUserName(0)("FristName")
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
        Dim DataUserName As Data.DataTable = executesql("SELECT FristName FROM Users WHERE UserId=" & DataOpenShift(0)("UserId") & "")
        Dim Username As String
        'Dim DateTimeOpen As DateTime
        'Dim DateUse As String
        Dim MoneyCashChange As Decimal = 0.00
        If IsNothing(DataUserName) Then
            Username = ""
            DateOpen = ""
        ElseIf DataUserName.Rows.Count = 0Then
            Username = ""
            DateOpen = ""
        ElseIf DataUserName.Rows.Count > 0Then
            Username = DataUserName(0)("FristName")
            DateOpen = Convert.ToDateTime(DataOpenShift(0)("DateTimeOpen")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            MoneyCashChange = DataOpenShift(0)("MoneyCash")
        End If
        Frm_CloseShift.LabelUseropenshift.Text = Username
        Frm_CloseShift.labeldatetimeopen.Text = Convert.ToDateTime(DataOpenShift(0)("DateTimeOpen")).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Frm_CloseShift.TxtChangeMoney.Text = FormatNumber(MoneyCashChange, 2)
    End Sub
    Sub LoadNetSale()
        'Dim DateUse As String
        'Dim DateOpen As DateTime = Frm_CloseShift.labeldatetimeopen.Text
        'DateUse = DateOpen.ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'MsgBox(DateOpen)
        Dim UserNameOpenShift As String = Frm_CloseShift.LabelUseropenshift.Text
        DateClose = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim SumTotalNetSale As Decimal = 0.00
        'Dim DataNetSale As DataTable = executesql("select sum(Sale.SubTotal) as  SubTotal
        '                                              from ((PaymentDetail PaymentDetail
        '                                              inner join Sale Sale
        '                                                   on (Sale.SaleId = PaymentDetail.SaleId))
        '                                              inner join PaymentType PaymentType
        '                                                   on (PaymentType.PaymentId = PaymentDetail.PaymentTypeId))
        '                                                where Sale.Active = 1 
        '                                                and PaymentType.PaymentId = 9
        '                                                   and Sale.SaleDate
        '                                        BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        '        Dim DataNetSale As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'),0)-
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'),0)-
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'),0)-
        'ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'),0)
        ') As SubTotal
        ' from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        'Where Sale.Active = 1  And PaymentType.PaymentId = 9 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")



        '-----------------------
        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        Dim Datatable12 As DataTable = executesql("Select  sum(SubTotal) As SubTotal from sale   Where sale.Active = 1 And SaleDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")

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
        If Datatable12.Rows.Count > 0 Then
            If IsDBNull(Datatable12(0)("SubTotal")) Then
                totalcash = 0
                Frm_CloseShift.TxtSumSale.Text = 0
            Else
                totalcash = Datatable12(0)("SubTotal")
                SumTotalNetSale = totalcash - CreditCard - QrWechat - QrAlipay - QrThai
                Frm_CloseShift.TxtSumSale.Text = FormatNumber(SumTotalNetSale, 2)
            End If
        End If

        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & DateOpen & "' AND '" & DateClose & "'")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            Frm_CloseShift.txtWithdraw.Text = "0.00"
        Else
            Frm_CloseShift.txtWithdraw.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
        End If


        '------------------------------
        'If IsNothing(DataNetSale) Then
        '    Frm_CloseShift.TxtSumSale.Text = SumTotalNetSale
        'ElseIf DataNetSale.Rows.Count = 0
        '    Frm_CloseShift.TxtSumSale.Text = SumTotalNetSale
        'ElseIf DataNetSale.Rows.Count > 0 Then

        '    'For i As Integer = 0 To DataNetSale.Rows.Count - 1
        '    '    SumTotalNetSale += DataNetSale(i)("SubTotal")
        '    'Next
        '    If IsDBNull(DataNetSale(0)("SubTotal")) Then
        '        SumTotalNetSale = 0
        '    Else
        '        SumTotalNetSale = DataNetSale(0)("SubTotal")
        '    End If

        '    Frm_CloseShift.TxtSumSale.Text = FormatNumber(SumTotalNetSale, 2)
        'End If
    End Sub
    Function OpenShift(userid As Integer, money As Decimal, TypeSale As String)
        If userid = 0 Then
            Exit Function
        End If
        Dim TypeShift As String = "OPEN"
        Dim StatusShift As Integer = 1
        Dim DateOpenShift As String = Now.ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim Terminal As String = Environment.MachineName
        executesql("INSERT INTO OpenCloseShift(MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName) VALUES(" & money & ",'" & userid & "','" & TypeShift & "','" & DateOpenShift & "','" & StatusShift & "','" & Terminal & "')")
        If TypeSale = "POS" Then
            POS.Close()
            POS.Show()
        ElseIf TypeSale = "Table"
            Table.Close()
            Table.Show()
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
        Dim datecloseshift As String = Now.ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-th"))
        DateClose = datecloseshift
        DateOpen = DataTypeShift(0)("datetimeopen")
        DateOpen = Convert.ToDateTime(DataTypeShift(0)("datetimeopen")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim terminal As String = Environment.MachineName
        If Frm_CloseShift.TxtNetSale.Text = "" Then
        ElseIf Frm_CloseShift.TxtNetSale.Text <> "" Then
            SumTotalNetSale = Frm_CloseShift.TxtNetSale.Text
        End If
        'executesql("INSERT INTO opencloseshift(moneycash,userid,typeshift,datetimeopen,statusshift,terminalname,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025,TotalNetSale) 
        'VALUES(" & money & ",'" & userid & "','" & typeshift & "','" & datecloseshift & "','" & statusshift & "','" & terminal & "'
        '," & b1000 & "," & b500 & "," & b100 & "," & b50 & "," & b20 & "," & c10 & "," & c5 & "," & c2 & "," & c1 & "," & c050 & "," & c025 & "," & SumTotalNetSale & ")")

        executesql("UPDATE opencloseshift SET CloseUserID='" & userid & "',typeshift='CLOSE',DateTimeClose='" & datecloseshift & "',statusshift=0,B1000=" & b1000 & ",B500=" & b500 & ",B100=" & b100 & ",B50=" & b50 & ",B20=" & b20 & ",C10=" & c10 & ",C5=" & c5 & ",C2=" & c2 & ",C1=" & c1 & ",C05=" & c050 & ",C025=" & c025 & ",TotalNetSale=" & SumTotalNetSale & " WHERE terminalname='" & terminal & "' AND typeshift='OPEN' ")
        Main.BtnCloseShift.Visible = False
        'Show Report
        Dim Report As New ReportDays80mmCloseShift
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Printool.PrinterSettings.Copies = 2
        Report.Print
        Dim ReportClose80 As New ReportCloseShift_80mm
        ReportClose80.PrinterName = GetPrinterName(0)("SettingValue")
        ReportClose80.Print
        Dim PrintClose As New CloseShiftPrint
        PrintClose.PrinterName = GetPrinterName(0)("SettingValue")
        PrintClose.Print
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

        Dim report_CancleSale As New ReportCancleSale
        report_CancleSale.Parameter1.Value = ModuleShift.DateOpen
        report_CancleSale.Parameter2.Value = ModuleShift.DateClose

        Dim report_ReportDayGroupcate As New ReportDaysCategoryGroup
        report_ReportDayGroupcate.parameter1.Value = DateOpen
        report_ReportDayGroupcate.parameter2.Value = DateClose

        Dim report_withdraw As New Report_WithdrawMoney
        report_withdraw.Parameter1.Value = ModuleShift.DateOpen
        report_withdraw.Parameter2.Value = ModuleShift.DateClose

        Dim FileName_CloseShift As String = "CloseShiftReport" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportCancleSale As String = "CancleSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportMainPOS As String = "ReportMainPOS" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportKiosk As String = "ReportKiosk" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_withdraw As String = "Report_WithdrawMoney" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        report_ReportDayGroupcate.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")

        report_CloseShift.ExportToXls("C:\ExportReport\" & FileName_CloseShift & ".xls")

        report_CancleSale.ExportToXls("C:\ExportReport\" & FileName_ReportCancleSale & ".xls")

        report_withdraw.ExportToXlsx("C:\ExportReport\" & FileName_report_withdraw & ".xls")

        Dim email As String = "prawit@ieasy.asia"
        Dim password As String = "qwa177a5"
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

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(email, password)
            smtp.Send(emailmessage)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        ElseIf Frm_CloseShift.TxtCash1000.Text <> ""
            Cash1000 = CDbl(Frm_CloseShift.TxtCash1000.Text)
        End If
        'cash500
        If Frm_CloseShift.TxtCash500.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash500.Text <> ""
            Cash500 = CDbl(Frm_CloseShift.TxtCash500.Text)
        End If
        'cash 100
        If Frm_CloseShift.TxtCash100.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash100.Text <> ""
            Cash100 = Frm_CloseShift.TxtCash100.Text
        End If
        'Cash 50 
        If Frm_CloseShift.TxtCash50.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash50.Text <> ""
            Cash50 = CDbl(Frm_CloseShift.TxtCash50.Text)
        End If
        'Cash 20
        If Frm_CloseShift.TxtCash20.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash20.Text <> ""
            Cash20 = Frm_CloseShift.TxtCash20.Text
        End If
        'Cash 10 
        If Frm_CloseShift.TxtCash10.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash10.Text <> ""
            Cash10 = CDbl(Frm_CloseShift.TxtCash10.Text)
        End If
        'Cash 5 
        If Frm_CloseShift.TxtCash5.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash5.Text <> ""
            Cash5 = CDbl(Frm_CloseShift.TxtCash5.Text)
        End If
        'Cash2 
        If Frm_CloseShift.TxtCash2.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash2.Text <> ""
            Cash2 = CDbl(Frm_CloseShift.TxtCash2.Text)
        End If
        'Cash1 
        If Frm_CloseShift.TxtCash1.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash1.Text <> ""
            Cash1 = CDbl(Frm_CloseShift.TxtCash1.Text)
        End If
        'Cash 0.50 
        If Frm_CloseShift.TxtCash050.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash050.Text <> ""
            Cash050 = CDbl(Frm_CloseShift.TxtCash050.Text)
        End If
        'Cash 0.25 
        If Frm_CloseShift.TxtCash025.Text = "" Then
        ElseIf Frm_CloseShift.TxtCash025.Text <> ""
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
