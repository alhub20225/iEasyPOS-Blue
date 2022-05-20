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
    Sub SendEmailExportPDF()
        Dim f As String = "C:\ExportReport"
        If Directory.Exists(f) Then
            'MsgBox("has file")
        Else
            ' MsgBox("Don't has file")
            My.Computer.FileSystem.CreateDirectory(f)
        End If


        Dim TerminalName As String = Environment.MachineName

        'ModuleShift.DateOpen = Convert.ToDateTime(Frm_Report.DateSendMail.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))

        'ModuleShift.DateClose = Convert.ToDateTime(Frm_Report.DateSendMail.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

        Dim report_CloseShift As New ResendReportCloseShift
        report_CloseShift.Parameter1.Value = TerminalName
        report_CloseShift.Parameter2.Value = ModuleShift.DateOpen
        report_CloseShift.Parameter3.Value = ModuleShift.DateClose

        Dim report_CancleSale As New ReportCancleSale
        report_CancleSale.Parameter1.Value = ModuleShift.DateOpen
        report_CancleSale.Parameter2.Value = ModuleShift.DateClose

        Dim report_ReportDayGroupcate As New ReportDaysCategoryGroup
        report_ReportDayGroupcate.parameter1.Value = ModuleShift.DateOpen
        report_ReportDayGroupcate.parameter2.Value = ModuleShift.DateClose

        Dim report_withdraw As New Report_WithdrawMoney
        report_withdraw.Parameter1.Value = ModuleShift.DateOpen
        report_withdraw.Parameter2.Value = ModuleShift.DateClose




        Dim FileName_ResendCloseShift As String = "ResendCloseShiftReport" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportCancleSale As String = "CancleSale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_withdraw As String = "Report_WithdrawMoney" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))



        report_CloseShift.ExportToXls("C:\ExportReport\" & FileName_ResendCloseShift & ".xls")

        report_CancleSale.ExportToXls("C:\ExportReport\" & FileName_ReportCancleSale & ".xls")

        report_ReportDayGroupcate.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")

        report_withdraw.ExportToXlsx("C:\ExportReport\" & FileName_report_withdraw & ".xls")




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

            Dim DateOpen As String = Convert.ToDateTime(ModuleShift.DateOpen).ToString("dd-MM-yyyy", New System.Globalization.CultureInfo("th-TH"))

            emailmessage.Subject = "รายงานการขาย(Resend)" + (Baranch_name(0)("BranchName")) + " " + DateOpen

            emailmessage.Body = "รายงานการขาย(Resend)" + (Baranch_name(0)("BranchName")) + " " + DateOpen

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ResendCloseShift & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportCancleSale & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_withdraw & ".xls"))



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
        'MsgBox(Frm_Report.MonthList.Value)
        Dim monthId As String = Frm_Report.MonthEdit.SelectedIndex
        Dim YearText As String = Frm_Report.NumericYear.Text
        Dim LastDayMonth As String = "0"
        Dim DateSelectStart As String = ""
        Dim DateSelectEnd As String = ""

        If monthId = "2" Then
            LastDayMonth = "28"
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

        'MsgBox(Frm_Report.MonthList.Text)
        DateSelectStart = YearText + "-" + monthId + "-" + "01"
        DateSelectEnd = YearText + "-" + monthId + "-" + LastDayMonth


        DateSelectStart = Convert.ToDateTime(DateSelectStart).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        DateSelectEnd = Convert.ToDateTime(DateSelectEnd).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))



        ModuleShift.DateOpen = DateSelectStart
        ModuleShift.DateClose = DateSelectEnd



        Dim f As String = "C:\ExportReport"
        If Directory.Exists(f) Then
            'MsgBox("has file")
        Else
            ' MsgBox("Don't has file")
            My.Computer.FileSystem.CreateDirectory(f)
        End If


        Dim TerminalName As String = Environment.MachineName


        Dim report_ReportDayGroupcate As New ReportDaysCategoryGroup
        report_ReportDayGroupcate.parameter1.Value = DateSelectStart
        report_ReportDayGroupcate.parameter2.Value = DateSelectEnd

        Dim report_withdraw As New Report_WithdrawMoney
        report_withdraw.Parameter1.Value = DateSelectStart
        report_withdraw.Parameter2.Value = DateSelectEnd

        Dim report_ReportDaySale As New ReportDaySale_V2
        report_ReportDaySale.Parameter1.Value = DateSelectStart
        report_ReportDaySale.Parameter2.Value = DateSelectEnd

        Dim report_topsale As New ReportTopSaleMail


        Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_withdraw As String = "Report_WithdrawMoney" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_ReportDaySale As String = "Report_ReportDaySale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

        Dim FileName_report_topsale As String = "Report_topsale" + (Now).ToString("ddMMyyyyHHmmss", New System.Globalization.CultureInfo("th-TH"))



        report_ReportDayGroupcate.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")

        report_withdraw.ExportToXlsx("C:\ExportReport\" & FileName_report_withdraw & ".xls")

        report_ReportDaySale.ExportToXlsx("C:\ExportReport\" & FileName_ReportDaySale & ".xls")

        report_topsale.ExportToXlsx("C:\ExportReport\" & FileName_report_topsale & ".xls")

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

            emailmessage.Subject = "รายงานการขาย เดือน " + Frm_Report.MonthEdit.Text + YearText + " สาขา" + (Baranch_name(0)("BranchName"))

            emailmessage.Body = "รายงานการขาย เดือน " + Frm_Report.MonthEdit.Text + YearText + " สาขา" + (Baranch_name(0)("BranchName"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_withdraw & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_ReportDaySale & ".xls"))

            emailmessage.Attachments.Add(New Attachment("C:\ExportReport\" & FileName_report_topsale & ".xls"))

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
