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

Module ResendMail
    Sub SendEmailExportPDF(ByVal DT1 As String, ByVal DT2 As String, id As Integer)
        Dim f As String = "C:\ExportReport"
        If Directory.Exists(f) Then
        Else
            My.Computer.FileSystem.CreateDirectory(f)
        End If

        'ModuleShift.DateOpen = DT1
        'ModuleShift.DateClose = DT2

        Dim TerminalName As String = Environment.MachineName

        Dim report_CloseShift As New ResendReportCloseShift
        report_CloseShift.Parameter1.Value = TerminalName
        report_CloseShift.Parameter2.Value = DT1
        report_CloseShift.Parameter3.Value = DT2
        report_CloseShift.DateTimeOpenShift = DT1
        report_CloseShift.DateTimeCloseShift = DT2
        report_CloseShift.shiftId = id
        report_CloseShift.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_CancleSale As New ReportCancleSale
        report_CancleSale.Parameter1.Value = DT1
        report_CancleSale.Parameter2.Value = DT2
        report_CancleSale.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_ReportDayGroupcate As New ReportDaysCategoryGroup
        report_ReportDayGroupcate.parameter1.Value = DT1
        report_ReportDayGroupcate.parameter2.Value = DT2
        report_ReportDayGroupcate.DateTimeOpenShift = DT1
        report_ReportDayGroupcate.DateTimeCloseShift = DT2
        report_ReportDayGroupcate.SqlDataSource1.Connection.ConnectionString = rptConStr


        Dim report_withdraw As New Report_WithdrawMoney
        report_withdraw.Parameter1.Value = DT1
        report_withdraw.Parameter2.Value = DT2
        report_withdraw.SqlDataSource1.Connection.ConnectionString = rptConStr

        'Dim ReportTopping As New Report_ToppingSale
        'ReportTopping.Parameter1.Value = DT1
        'ReportTopping.Parameter2.Value = DT2
        'ReportTopping.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_CustomerSale As New Report_CustomerSale
        report_CustomerSale.Parameter1.Value = DT1
        report_CustomerSale.Parameter2.Value = DT2
        report_CustomerSale.XrLabel1.Text = DT1
        report_CustomerSale.XrLabel2.Text = DT2
        report_CustomerSale.SqlDataSource1.Connection.ConnectionString = rptConStr
        Dim DtCustomerSale As DataTable = executesql("select Customer.FirstName, Customer.LastName,Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,SaleItem.ItemName, SaleItem.Qty, SaleItem.UnitPrice from Customer  inner join Sale on (Sale.CustomerId = Customer.CustomerId) inner join SaleItem on (SaleItem.SaleId = Sale.SaleId) where sale.saledate between '" & DT1 & "' and '" & DT2 & "'")
        Dim dtGiftCard As DataTable = executesql("SELECT  PaymentDetail.VoucherNumber, Sale.SaleNo, Sale.SaleDate, Sale.SubTotal, SaleItem.ItemCode, SaleItem.ItemName,SaleItem.Qty, PaymentDetail.PaymentTypeId FROM PaymentDetail INNER JOIN Sale ON PaymentDetail.SaleId = Sale.SaleId INNER JOIN SaleItem ON Sale.SaleId = SaleItem.SaleId where PaymentDetail.PaymentTypeId in (18,19) and Sale.SaleDate between '" & DT1 & "' and '" & DT2 & "'")

        Dim report_GiftCard As New Report_GiftCard
        report_GiftCard.Parameter1.Value = DT1
        report_GiftCard.Parameter2.Value = DT2
        report_GiftCard.LabelTimeStart.Text = Convert.ToDateTime(DT1).ToString("dd MMMM yyyy HH:mm", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DT2).ToString("dd MMMM yyyy HH:mm", New System.Globalization.CultureInfo("th-TH"))
        report_GiftCard.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim FileName_ResendCloseShift As String = "ResendCloseShiftReport" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportCancleSale As String = "CancleSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_withdraw As String = "Report_WithdrawMoney" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        'Dim FileName_report_ReportTopping As String = "Report_ReportTopping" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim File_report_CustomerSale As String = "Report_CustomerSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim File_report_GiftCard As String = "Report_GiftCard_GrabFood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        report_CloseShift.ExportToXls("C:\ExportReport\" & FileName_ResendCloseShift & ".xls")

        report_CancleSale.ExportToXls("C:\ExportReport\" & FileName_ReportCancleSale & ".xls")

        report_ReportDayGroupcate.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")

        report_withdraw.ExportToXlsx("C:\ExportReport\" & FileName_report_withdraw & ".xls")

        'ReportTopping.ExportToXlsx("C:\ExportReport\" & FileName_report_ReportTopping & ".xls")

        If DtCustomerSale.Rows.Count > 0 Then
            report_CustomerSale.ExportToXlsx("C:\ExportReport\" & File_report_CustomerSale & ".xls")
        End If

        If dtGiftCard.Rows.Count > 0 Then
            report_GiftCard.ExportToXlsx("C:\ExportReport\" & File_report_GiftCard & ".xls")
        End If



        Dim email As String = "prawit@ieasy.asia"
        Dim password As String = "qwa177a5"
        Dim emailmessage As New MailMessage()
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        Try
            emailmessage.From = New MailAddress(email)

            Dim SelectEmail As DataTable = executesql("SELECT Emails FROM Branch WHERE Active=1")
            If IsDBNull(SelectEmail(0)("Emails")) Then
                MsgBox("กรุณาตรวจสอบการตั้งค่า อีเมล์", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            If SelectEmail.Rows.Count = 0 Then
                MsgBox("กรุณาตรวจสอบการตั้งค่า อีเมล์", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            If SelectEmail.Rows.Count > 0 Then
                Dim Emails As String() = SelectEmail(0)("Emails").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                For i As Integer = 0 To Emails.Length - 1
                    emailmessage.To.Add(Emails(i))
                Next
            End If

            Dim DateOpen As String = Convert.ToDateTime(DT1).ToString("dd-MM-yyyy", New System.Globalization.CultureInfo("th-TH"))

            emailmessage.Subject = "รายงานการขาย(Resend) " + (Baranch_name(0)("BranchName")) + " " + DateOpen

            emailmessage.Body = "รายงานการขาย(Resend) " + (Baranch_name(0)("BranchName")) + " " + DateOpen

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ResendCloseShift & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportCancleSale & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_withdraw & ".xls"))

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

            MsgBox("Send Complete", MsgBoxStyle.Information, "Send Mail")

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Sub SendEmailMonth()

        Dim monthId As String = Frm_Report.MonthEdit.SelectedIndex
        Dim YearText As String = Frm_Report.NumericYear.Text
        Dim LastDayMonth As String = "0"
        Dim DateSelectStart As String = ""
        Dim DateSelectEnd As String = ""

        If monthId = "2" Then
            If YearText = 2563 Then
                LastDayMonth = "29"
            Else
                LastDayMonth = "28"
            End If

        ElseIf monthId = "4" Then
            LastDayMonth = "30"
        ElseIf monthId = "6" Then
            LastDayMonth = "30"
        ElseIf monthId = "9" Then
            LastDayMonth = "30"
        ElseIf monthId = "11" Then
            LastDayMonth = "30"
        Else
            LastDayMonth = "31"
        End If


        DateSelectStart = YearText + "-" + monthId + "-" + "01"
        DateSelectEnd = YearText + "-" + monthId + "-" + LastDayMonth


        DateSelectStart = Convert.ToDateTime(DateSelectStart).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        DateSelectEnd = Convert.ToDateTime(DateSelectEnd).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))



        Dim f As String = "C:\ExportReport"
        If Directory.Exists(f) Then

        Else
            My.Computer.FileSystem.CreateDirectory(f)
        End If


        Dim TerminalName As String = Environment.MachineName


        Dim report_ReportDayGroupcate As New ReportDaysCategoryGroup
        report_ReportDayGroupcate.parameter1.Value = DateSelectStart
        report_ReportDayGroupcate.parameter2.Value = DateSelectEnd
        report_ReportDayGroupcate.DateTimeOpenShift = DateSelectStart
        report_ReportDayGroupcate.DateTimeCloseShift = DateSelectEnd
        report_ReportDayGroupcate.SqlDataSource1.Connection.ConnectionString = rptConStr


        Dim report_withdraw As New Report_WithdrawMoney
        report_withdraw.Parameter1.Value = DateSelectStart
        report_withdraw.Parameter2.Value = DateSelectEnd
        report_withdraw.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_GiftCard As New Report_GiftCard
        report_GiftCard.Parameter1.Value = DateSelectStart
        report_GiftCard.Parameter2.Value = DateSelectEnd
        report_GiftCard.LabelTimeStart.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy HH:mm", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy HH:mm", New System.Globalization.CultureInfo("th-TH"))
        'report_GiftCard.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_lineman As New Report_Lineman
        report_lineman.Parameter1.Value = DateSelectStart
        report_lineman.Parameter2.Value = DateSelectEnd
        report_lineman.LabelTimeStart.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        ' report_lineman.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_Robinhood As New Report_Robinhood
        report_Robinhood.Parameter1.Value = DateSelectStart
        report_Robinhood.Parameter2.Value = DateSelectEnd
        report_Robinhood.LabelTimeStart.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        ' report_Robinhood.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim Report_FoodPanda As New Report_FoodPanda
        Report_FoodPanda.Parameter1.Value = DateSelectStart
        Report_FoodPanda.Parameter2.Value = DateSelectEnd
        Report_FoodPanda.LabelTimeStart.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        'Report_FoodPanda.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_ShopeeFood As New Report_ShopeeFood
        report_ShopeeFood.Parameter1.Value = DateSelectStart
        report_ShopeeFood.Parameter2.Value = DateSelectEnd
        report_ShopeeFood.LabelTimeStart.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        'report_ShopeeFood.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_ReportDaySale As New ReportDaySale_V2
        report_ReportDaySale.Parameter1.Value = DateSelectStart
        report_ReportDaySale.Parameter2.Value = DateSelectEnd
        report_ReportDaySale.SqlDataSource1.Connection.ConnectionString = rptConStr

        Dim report_topsale As New ReportTopSaleMail
        report_topsale.Parameter1.Value = DateSelectStart
        report_topsale.Parameter2.Value = DateSelectEnd


        Dim report_CustomerSale As New Report_CustomerSale
        report_CustomerSale.Parameter1.Value = DateSelectStart
        report_CustomerSale.Parameter2.Value = DateSelectEnd
        report_CustomerSale.XrLabel1.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy HHmmss", New System.Globalization.CultureInfo("th-TH"))
        report_CustomerSale.XrLabel2.Text = Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy HHmmss", New System.Globalization.CultureInfo("th-TH"))
        report_CustomerSale.SqlDataSource1.Connection.ConnectionString = rptConStr
        Dim DtCustomerSale As DataTable = executesql("SELECT CustomerId FROM sale where CustomerId > 0 and Active=1 and SaleDate between CONVERT(datetime, '" & DateSelectStart & "', 126) and CONVERT(datetime, '" & DateSelectEnd & "', 126)")

        Dim DateTax = Convert.ToDateTime(DateSelectStart).ToString("yyyy-MM", New System.Globalization.CultureInfo("en-US"))
        Dim reportTaxSale As New Report_TaxSale
        reportTaxSale.Parameter1.Value = "%" & DateTax & "%"
        reportTaxSale.SqlDataSource1.Connection.ConnectionString = rptConStr
        reportTaxSale.textDate.Text = "เดือนภาษี " & Convert.ToDateTime(DateSelectStart).ToString("MMMM", New System.Globalization.CultureInfo("th-TH")) + " ปีภาษี " + Convert.ToDateTime(DateSelectStart).ToString("yyyy", New System.Globalization.CultureInfo("th-TH"))

        Dim Report_Number_detail As New ReportSaleNumberDetail
        Report_Number_detail.Parameter1.Value = DateSelectStart
        Report_Number_detail.Parameter2.Value = DateSelectEnd
        Report_Number_detail.LabelTimeStart.Text = Convert.ToDateTime(DateSelectStart).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH")) & " - " & Convert.ToDateTime(DateSelectEnd).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_Number_detail.SqlDataSource1.Connection.ConnectionString = rptConStr

        'tax sale ----------------------------------
        Dim Terminal As String = Environment.MachineName
        Dim Date_start = Convert.ToDateTime(Now).ToString("yyyy-MM", New System.Globalization.CultureInfo("en-US"))
        Dim report_TaxSale As New Report_TaxSale
        report_TaxSale.Parameter1.Value = "%" & Date_start & "%"
        report_TaxSale.SqlDataSource1.Connection.ConnectionString = rptConStr
        report_TaxSale.textDate.Text = "เดือนภาษี " & Convert.ToDateTime(Now).ToString("MMMM", New System.Globalization.CultureInfo("th-TH")) + " ปีภาษี " + Convert.ToDateTime(Now).ToString("yyyy", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_ReportTaxSale As String = "ReportTaxSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        report_TaxSale.ExportToXlsx("C:\ExportReport\" & FileName_ReportTaxSale & ".xls")

        '-------------------------------------------

        Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_ReportDayGroupcate_PDF As String = "ReportDayGroupcate_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_withdraw As String = "Report_WithdrawMoney" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_withdraw_PDF As String = "Report_WithdrawMoney_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_lineman As String = "Report_Lineman" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_lineman_PDF As String = "Report_Lineman_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_Robinhood As String = "Report_Robinhood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_Robinhood_PDF As String = "Report_Robinhood_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_ShopeeFood As String = "Report_ShopeeFood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_ShopeeFood_PDF As String = "Report_ShopeeFood_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_Report_FoodPanda As String = "Report_FoodPanda" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_Report_FoodPanda_PDF As String = "Report_FoodPanda_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_grabfood As String = "Report_grabfood" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_grabfood_PDF As String = "Report_grabfood_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportDaySale As String = "Report_ReportDaySale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_ReportDaySale_pdf As String = "Report_ReportDaySale_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_topsale As String = "Report_topsale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim FileName_report_topsale_pdf As String = "Report_topsale_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim File_report_CustomerSale As String = "Report_CustomerSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim File_report_CustomerSale_pdf As String = "Report_CustomerSale_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim File_report_TaxSale_PDF As String = "Report_TaxSale_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim File_report_TaxSale_XLS As String = "Report_TaxSale_XLS" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim File_report_SaleNemberDetail As String = "ReportSaleNumberDetail" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))
        Dim File_report_SaleNemberDetail_pdf As String = "ReportSaleNumberDetail_PDF" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        report_ReportDayGroupcate.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")
        report_ReportDayGroupcate.ExportToPdf("C:\ExportReport\" & FileName_ReportDayGroupcate_PDF & ".pdf")

        report_withdraw.ExportToXlsx("C:\ExportReport\" & FileName_report_withdraw & ".xls")
        report_withdraw.ExportToPdf("C:\ExportReport\" & FileName_report_withdraw_PDF & ".pdf")

        report_lineman.ExportToXlsx("C:\ExportReport\" & FileName_report_lineman & ".xls")
        report_lineman.ExportToPdf("C:\ExportReport\" & FileName_report_lineman_PDF & ".pdf")

        report_Robinhood.ExportToXlsx("C:\ExportReport\" & FileName_report_Robinhood & ".xls")
        report_Robinhood.ExportToPdf("C:\ExportReport\" & FileName_report_Robinhood_PDF & ".pdf")

        report_ShopeeFood.ExportToXlsx("C:\ExportReport\" & FileName_report_ShopeeFood & ".xls")
        report_ShopeeFood.ExportToPdf("C:\ExportReport\" & FileName_report_ShopeeFood_PDF & ".pdf")

        Report_FoodPanda.ExportToXlsx("C:\ExportReport\" & FileName_Report_FoodPanda & ".xls")
        Report_FoodPanda.ExportToPdf("C:\ExportReport\" & FileName_Report_FoodPanda_PDF & ".pdf")

        report_GiftCard.ExportToXlsx("C:\ExportReport\" & FileName_report_grabfood & ".xls")
        report_GiftCard.ExportToPdf("C:\ExportReport\" & FileName_report_grabfood_PDF & ".pdf")

        report_ReportDaySale.ExportToXlsx("C:\ExportReport\" & FileName_ReportDaySale & ".xls")
        report_ReportDaySale.ExportToPdf("C:\ExportReport\" & FileName_ReportDaySale_pdf & ".pdf")

        report_topsale.ExportToXlsx("C:\ExportReport\" & FileName_report_topsale & ".xls")
        report_topsale.ExportToPdf("C:\ExportReport\" & FileName_report_topsale_pdf & ".pdf")

        If DtCustomerSale.Rows.Count > 0 Then
            report_CustomerSale.ExportToXlsx("C:\ExportReport\" & File_report_CustomerSale & ".xls")
            report_CustomerSale.ExportToPdf("C:\ExportReport\" & File_report_CustomerSale_pdf & ".pdf")
        End If
        reportTaxSale.ExportToPdf("C:\ExportReport\" & File_report_TaxSale_PDF & ".pdf")
        reportTaxSale.ExportToXlsx("C:\ExportReport\" & File_report_TaxSale_XLS & ".xls")

        Report_Number_detail.ExportToXlsx("C:\ExportReport\" & File_report_SaleNemberDetail & ".xls")
        Report_Number_detail.ExportToPdf("C:\ExportReport\" & File_report_SaleNemberDetail_pdf & ".pdf")

        Dim email As String = "prawit@ieasy.asia"
        Dim password As String = "Green/97"
        Dim emailmessage As New MailMessage()
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        Try
            emailmessage.From = New MailAddress(email)

            Dim SelectEmail As DataTable = executesql("SELECT Emails FROM Branch WHERE Active=1")
            If IsDBNull(SelectEmail(0)("Emails")) Then
                MsgBox("กรุณาตรวจสอบการตั้งค่า อีเมล์", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            If SelectEmail.Rows.Count = 0 Then
                MsgBox("กรุณาตรวจสอบการตั้งค่า อีเมล์", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            If SelectEmail.Rows.Count > 0 Then
                Dim Emails As String() = SelectEmail(0)("Emails").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                For i As Integer = 0 To Emails.Length - 1
                    emailmessage.To.Add(Emails(i))
                Next
            End If

            emailmessage.Subject = "รายงานการขาย เดือน " + Frm_Report.MonthEdit.Text + YearText + " สาขา" + (Baranch_name(0)("BranchName"))
            emailmessage.Body = "รายงานการขาย เดือน " + Frm_Report.MonthEdit.Text + YearText + " สาขา" + (Baranch_name(0)("BranchName"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDayGroupcate_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_withdraw & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_withdraw_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_lineman & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_lineman_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_Robinhood & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_Robinhood_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_ShopeeFood & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_ShopeeFood_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_Report_FoodPanda & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_Report_FoodPanda_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_grabfood & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_grabfood_PDF & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDaySale & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDaySale_pdf & ".pdf"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_topsale & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_topsale_pdf & ".pdf"))
            If DtCustomerSale.Rows.Count > 0 Then
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_CustomerSale & ".xls"))
                emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_CustomerSale_pdf & ".pdf"))
            End If
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_TaxSale_PDF & ".pdf"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_TaxSale_XLS & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_SaleNemberDetail & ".xls"))
            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & File_report_SaleNemberDetail_pdf & ".pdf"))
            'emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportTaxSale & ".xls"))

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(email, password)
            smtp.Send(emailmessage)

            MsgBox("Send Complete", MsgBoxStyle.Information, "Send Mail")

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Module
