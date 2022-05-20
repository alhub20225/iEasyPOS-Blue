Imports DevExpress.XtraReports.UI

Public Class Frm_Report
    Dim DateStart As String = ""
    Dim DateEnd As String = ""
    Private Sub Frm_Report_Load(sender As Object, e As EventArgs) Handles Me.Load
        writeLog("User ID " + Frm_Login.UserId.ToString + " Open Frm_Report")
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        DTP1.EditValue = Now
        ProgressPanel1.Hide()
        If ComboBox1.Text = "" Then
            BtnRePrint.Enabled = False
            Btn_SendMali.Enabled = False
        Else
            BtnRePrint.Enabled = True
            Btn_SendMali.Enabled = True
        End If

    End Sub
    'Private Sub Close_Report_Click(sender As Object, e As EventArgs) Handles Close_Report.Click
    '    Me.Close()
    '    Main.Close()
    '    Main.Show()
    'End Sub

    Private Sub RadBtnUser_Click(sender As Object, e As EventArgs) Handles RadBtnUser.Click
        'FrmReportDay.Show()
        Frm_ReportDaysCateGroup.Show()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        FrmReportDay_mat.Show()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        FrmReportSaleNumber.Show()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Frm_DateSale.Show()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Frm_WithdrawMoney.Show()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Frm_rtpUnitInStock.Show()
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        'Dim Report80 As New ReportDays80mm
        ''Dim Printool As New ReportPrintTool(Report80)
        'Report80.ShowPreviewDialog
        Frm_ReportDay80mm.Show()
    End Sub

    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        FrmReportSaleNumberDetail.Show()
    End Sub

    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click
        Frm_ReportTax.Show()
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        Frm_Payment.Show()
    End Sub

    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles RadButton9.Click
        FrmReportCancleSale.Show()
    End Sub

    Private Sub RadButton11_Click(sender As Object, e As EventArgs) Handles RadButton11.Click
        FrmReportSale_PayType.Show()
    End Sub

    Private Sub RadButton12_Click(sender As Object, e As EventArgs) Handles RadButton12.Click
        Frm_ReportSale_ByItem.Show()
    End Sub

    Private Sub RadButton13_Click(sender As Object, e As EventArgs) Handles RadButton13.Click
        Frm_ReportDay80mm_Terminal.Show()
    End Sub

    Private Sub Btn_SendMali_Click(sender As Object, e As EventArgs) Handles Btn_SendMali.Click
        Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId from OpenCloseShift where DateTimeOpen Between CONVERT(datetime, '" & DateStart & "', 126) and CONVERT(datetime, '" & DateEnd & "', 126) AND TypeShift='CLOSE'")
        Dim result() As DataRow = CheckShiftNum.Select("shiftNumber='" & ComboBox1.Text & "'")
        Dim ShiftId As Integer = result(0)("ShiftId")
        Console.WriteLine("ShiftId " & ShiftId.ToString)

        Dim CheckDataRows As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = " & ShiftId & " AND TypeShift='CLOSE'")

        If CheckDataRows.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim DT1 As String = Convert.ToDateTime(CheckDataRows(0)("DateTimeOpen")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim DT2 As String = Convert.ToDateTime(CheckDataRows(0)("DateTimeClose")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        ResendMail.SendEmailExportPDF(DT1, DT2, CheckDataRows(0)("ShiftId"))
        writeLog("User ID " + Frm_Login.UserId.ToString + " Re-send Report")
        ProgressPanel1.Hide()
    End Sub



    Private Sub RadButton14_Click(sender As Object, e As EventArgs) Handles RadButton14.Click
        FrmReportToppingSale.Show()
    End Sub


    'Private Sub DTP1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.ValueChanged
    '    DataGridShiftNumber.Rows.Clear()
    '    Dim DateStart As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
    '    Dim DateEnd As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    '    Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID  from OpenCloseShift where DateTimeOpen Between '" & DateStart & "' and '" & DateEnd & "' AND TypeShift='CLOSE'")
    '    For i As Integer = 0 To CheckShiftNum.Rows.Count - 1
    '        DataGridShiftNumber.Rows.Add(CheckShiftNum(i)("shiftNumber"), CheckShiftNum(i)("ShiftId"))
    '    Next


    '    If CheckShiftNum.Rows.Count > 0 Then
    '        BtnRePrint.Enabled = True
    '        Btn_SendMali.Enabled = True
    '    Else
    '        BtnRePrint.Enabled = False
    '        Btn_SendMali.Enabled = False
    '    End If
    'End Sub

    'Private Sub DTP1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.EditValueChanged
    '    'DataGridShiftNumber.Rows.Clear()
    '    'Dim DateStart As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
    '    'Dim DateEnd As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    '    DTP1.EditValue = Now
    '    Dim DateStart As String = Convert.ToDateTime(DTP1.Text).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
    '    Dim DateEnd As String = Convert.ToDateTime(DTP1.Text).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    '    Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID  from OpenCloseShift where DateTimeOpen Between '" & DateStart & "' and '" & DateEnd & "' AND TypeShift='CLOSE'")
    '    'For i As Integer = 0 To CheckShiftNum.Rows.Count - 1
    '    '    DataGridShiftNumber.Rows.Add(CheckShiftNum(i)("shiftNumber"), CheckShiftNum(i)("ShiftId"))
    '    'Next

    '    If DataGridShiftNumber.Text <> "กะที่" Then
    '        For i As Integer = 0 To CheckShiftNum.Rows.Count - 1
    '            DataGridShiftNumber.Properties.Items(i).Add("shiftNumber")
    '        Next
    '    End If


    '    If CheckShiftNum.Rows.Count > 0 Then
    '        BtnRePrint.Enabled = True
    '        Btn_SendMali.Enabled = True
    '    Else
    '        BtnRePrint.Enabled = False
    '        Btn_SendMali.Enabled = False
    '    End If
    'End Sub

    Private Sub BtnRePrint_Click(sender As Object, e As EventArgs) Handles BtnRePrint.Click
        Dim TerminalName As String = Environment.MachineName

        Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId from OpenCloseShift where DateTimeOpen Between CONVERT(datetime, '" & DateStart & "', 126) and CONVERT(datetime, '" & DateEnd & "', 126) AND TypeShift='CLOSE'")
        Dim result() As DataRow = CheckShiftNum.Select("shiftNumber='" & ComboBox1.Text & "'")
        Dim ShiftId As Integer = result(0)("ShiftId")
        Console.WriteLine("ShiftId " & ShiftId.ToString)

        Dim CheckDataRows As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = " & ShiftId & " AND TypeShift='CLOSE'")

        If CheckDataRows.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            Dim DT1 As String = Convert.ToDateTime(CheckDataRows(0)("DateTimeOpen")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            Dim DT2 As String = Convert.ToDateTime(CheckDataRows(0)("DateTimeClose")).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            ModuleShift.DateOpen = DT1
            ModuleShift.DateClose = DT2

            Dim Report As New ReportCloseShift_80mm
            Report.Parameter1.Value = DT1
            Report.Parameter2.Value = DT2
            Report.DateTimeOpenShift = DT1
            Report.DateTimeCloseShift = DT2
            Report.shiftId = ShiftId
            Dim Printool As New ReportPrintTool(Report)
            Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
            Report.PrinterName = GetPrinterName(0)("SettingValue")
            Report.LabelDateSale.Visible = False
            Report.XrLabel3.Visible = False
            Report.CreateDocument()
            Report.Print

            Dim ShiftClose As New CloseShiftPrint
            ShiftClose.Parameter1.Value = DT1
            ShiftClose.Parameter2.Value = DT2
            ShiftClose.PrinterName = GetPrinterName(0)("SettingValue")
            ShiftClose.CreateDocument()
            ShiftClose.Print

            Dim ReportDays80 As New ReportDays80mmCloseShift
            ReportDays80.Parameter1.Value = DT1
            ReportDays80.Parameter2.Value = DT2
            ReportDays80.DateTimeOpenShift = DT1
            ReportDays80.DateTimeCloseShift = DT2
            ReportDays80.PrinterName = GetPrinterName(0)("SettingValue")
            ReportDays80.SqlDataSource1.Connection.ConnectionString = rptConStr
            ReportDays80.CreateDocument()
            ReportDays80.Print

            'Dim ReportTopping As New Report_ToppingSale80mm
            'ReportTopping.parameter1.Value = DT1
            'ReportTopping.parameter2.Value = DT2
            'ReportTopping.PrinterName = GetPrinterName(0)("SettingValue")
            'ReportTopping.SqlDataSource1.Connection.ConnectionString = rptConStr

            'Dim DataTopping As DataTable = executesql("select count(UseTopping.ToppingId) as Count_ToppingId,
            '                                           UseTopping.ToppingName,
            '                                           sum(Topping.Pricing) as Sum_Pricing,
            '                                           Item.ItemName,
            '                                           CategoryItem.CategoryName
            '                                      from (((((dbo.UseTopping UseTopping
            '                                      inner join dbo.Topping Topping
            '                                           on (Topping.ToppingId = UseTopping.ToppingId))
            '                                      inner join dbo.SaleItem SaleItem
            '                                           on (SaleItem.SaleItemId = UseTopping.SaleItemId))
            '                                      inner join dbo.Sale Sale
            '                                           on (Sale.SaleId = SaleItem.SaleId))
            '                                      inner join dbo.Item Item
            '                                           on (Item.ItemId = SaleItem.ItemId))
            '                                      inner join dbo.CategoryItem CategoryItem
            '                                           on (CategoryItem.CategoryId = Item.CategoryId))
            '                                    where Sale.SaleDate BETWEEN '" & ReportTopping.parameter1.Value & "' 
            '                                            AND '" & ReportTopping.parameter2.Value & "' AND Sale.Active = 1

            '                                    group by CategoryItem.CategoryName,
            '                                           SaleItem.ItemName, Item.ItemName,
            '                                           UseTopping.ToppingName")
            'If DataTopping.Rows.Count > 0 Then
            '    ReportTopping.CreateDocument()
            '    ReportTopping.Print
            'End If


            'รายงานการขาย ลูกค้า
            Dim report_CustomerSale As New Report_CustomerSale80
            report_CustomerSale.Parameter1.Value = DT1
            report_CustomerSale.Parameter2.Value = DT2
            report_CustomerSale.XrLabel1.Text = DT1
            report_CustomerSale.XrLabel2.Text = DT2
            report_CustomerSale.PrinterName = GetPrinterName(0)("SettingValue")
            Dim DtCustomerSale As DataTable = executesql("select Customer.FirstName, Customer.LastName,Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,SaleItem.ItemName, SaleItem.Qty, SaleItem.UnitPrice from ((dbo.Customer Customer inner join dbo.Sale Sale on (Sale.CustomerId = Customer.CustomerId)) inner join dbo.SaleItem SaleItem on (SaleItem.SaleId = Sale.SaleId)) where sale.saledate between CONVERT(datetime, '" & DT1 & "', 126) and CONVERT(datetime, '" & DT2 & "', 126)")
            report_CustomerSale.SqlDataSource1.Connection.ConnectionString = rptConStr
            report_CustomerSale.CreateDocument()

            If DtCustomerSale.Rows.Count > 0 Then
                report_CustomerSale.Print
            End If

            writeLog("User ID " + Frm_Login.UserId.ToString + " Re-Print Report")


#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            Report.TotalNetSale = 0
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

        End If
    End Sub

    Private Sub Btn_SendMali_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_SendMali.MouseDown
        ProgressPanel1.Show()
        ProgressPanel1.BringToFront()
    End Sub

    Private Sub BtnMonthReport_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnMonthReport.MouseDown
        ProgressPanel1.Show()
        ProgressPanel1.BringToFront()
    End Sub

    Private Sub RadButton15_Click(sender As Object, e As EventArgs) Handles RadButton15.Click
        Frm_ReportTopSale.Show()
    End Sub

    Private Sub RadButton16_Click(sender As Object, e As EventArgs) Handles RadButton16.Click
        Frm_Report_CustomerSale.Show()
    End Sub

    Private Sub DTP1_DateTimeChanged(sender As Object, e As EventArgs) Handles DTP1.DateTimeChanged

        DateStart = Convert.ToDateTime(DTP1.DateTime).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        DateEnd = Convert.ToDateTime(DTP1.DateTime).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID  from OpenCloseShift where DateTimeOpen Between '" & DateStart & "' and '" & DateEnd & "' AND TypeShift='CLOSE'")
        ComboBox1.DataSource = Nothing

        If CheckShiftNum.Rows.Count > 0 Then
            ComboBox1.DataSource = CheckShiftNum
            ComboBox1.DisplayMember = "shiftNumber"
            'Dim result() As DataRow = CheckShiftNum.Select("shiftNumber=1")
            'Dim result() As DataRow = CheckShiftNum.Select("shiftNumber='" & ComboBox1.Text & "'")
            'ShiftId = result(0)("ShiftId")
            'Console.WriteLine("ShiftId " & ShiftId.ToString)

            BtnRePrint.Enabled = True
            Btn_SendMali.Enabled = True
        Else
            BtnRePrint.Enabled = False
            Btn_SendMali.Enabled = False
        End If
    End Sub

    Private Sub BtnMonthReport_Click(sender As Object, e As EventArgs) Handles BtnMonthReport.Click
        SendEmailMonth()
        writeLog("User ID " + Frm_Login.UserId.ToString + " send Report month")
        ProgressPanel1.Hide()
    End Sub

    Private Sub BtnCloseShiftReport_Click(sender As Object, e As EventArgs) Handles BtnCloseShiftReport.Click
        Frm_ReportCloseShift.Show()
    End Sub

    Private Sub BtnReportItem_Click(sender As Object, e As EventArgs) Handles BtnReportItem.Click
        Frm_ReportItems.Show()
    End Sub

    Private Sub BtnReportProfit_Click(sender As Object, e As EventArgs) Handles BtnReportProfit.Click
        Frm_ReportProfit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_reportLineman.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_reportRobinhood.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_reportShopeeFood.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_ReportGiftCard.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frm_reportFoodPanda.Show()
    End Sub

    Sub change_to_th_text()
        PageManagementBrand.Text = My.Resources.report_th.report
        Label12.Text = My.Resources.report_th.report
        Label34.Text = My.Resources.report_th.sendEmail
        Label31.Text = My.Resources.report_th.sendEmail
        Label32.Text = My.Resources.report_th.no
        Label2.Text = My.Resources.report_th.sendEmailMonth
        Label4.Text = My.Resources.report_th.month
        Label3.Text = My.Resources.report_th.year
        Btn_SendMali.Text = My.Resources.report_th.send
        BtnMonthReport.Text = My.Resources.report_th.send
        BtnRePrint.Text = My.Resources.report_th.print

        RadBtnUser.Text = My.Resources.report_th.reportDaliy
        RadButton2.Text = My.Resources.report_th.reportSaleNo
        RadButton3.Text = My.Resources.report_th.reportsaleDay
        RadButton12.Text = My.Resources.report_th.reportSaleCategory
        RadButton11.Text = My.Resources.report_th.reportPaymentDetail
        RadButton5.Text = My.Resources.report_th.reportStock
        RadButton1.Text = My.Resources.report_th.reportMaterial
        RadButton15.Text = My.Resources.report_th.reportTopSale
        RadButton8.Text = My.Resources.report_th.reportVat
        RadButton16.Text = My.Resources.report_th.reportSaleCustomer
        RadButton9.Text = My.Resources.report_th.reportCancelSale
        RadButton14.Text = My.Resources.report_th.reportTopping
        RadButton4.Text = My.Resources.report_th.reportExpenses
        RadButton10.Text = My.Resources.report_th.reportPaymentDetail
        RadButton6.Text = My.Resources.report_th.report80
        RadButton13.Text = My.Resources.report_th.report80Terminal
        RadButton7.Text = My.Resources.report_th.reportSaleNoDetail
        BtnCloseShiftReport.Text = My.Resources.report_th.reportCloseShift
        BtnReportItem.Text = My.Resources.report_th.reportProduct
        BtnReportProfit.Text = My.Resources.report_th.reportProfit
        Button1.Text = My.Resources.report_th.reportGrab
        Button2.Text = My.Resources.report_th.reportLine
        Button3.Text = My.Resources.report_th.reportRobin
        Button4.Text = My.Resources.report_th.reportShopee

    End Sub

    Sub change_to_eng_text()
        PageManagementBrand.Text = My.Resources.report_en.report
        Label12.Text = My.Resources.report_en.report
        Label34.Text = My.Resources.report_en.sendEmail
        Label31.Text = My.Resources.report_en.sendEmail
        Label32.Text = My.Resources.report_en.no
        Label2.Text = My.Resources.report_en.sendEmailMonth
        Label4.Text = My.Resources.report_en.month
        Label3.Text = My.Resources.report_en.year
        Btn_SendMali.Text = My.Resources.report_en.send
        BtnMonthReport.Text = My.Resources.report_en.send
        BtnRePrint.Text = My.Resources.report_en.print

        RadBtnUser.Text = My.Resources.report_en.reportDaliy
        RadButton2.Text = My.Resources.report_en.reportSaleNo
        RadButton3.Text = My.Resources.report_en.reportsaleDay
        RadButton12.Text = My.Resources.report_en.reportSaleCategory
        RadButton11.Text = My.Resources.report_en.reportPaymentDetail
        RadButton5.Text = My.Resources.report_en.reportStock
        RadButton1.Text = My.Resources.report_en.reportMaterial
        RadButton15.Text = My.Resources.report_en.reportTopSale
        RadButton8.Text = My.Resources.report_en.reportVat
        RadButton16.Text = My.Resources.report_en.reportSaleCustomer
        RadButton9.Text = My.Resources.report_en.reportCancelSale
        RadButton14.Text = My.Resources.report_en.reportTopping
        RadButton4.Text = My.Resources.report_en.reportExpenses
        RadButton10.Text = My.Resources.report_en.reportPaymentDetail
        RadButton6.Text = My.Resources.report_en.report80
        RadButton13.Text = My.Resources.report_en.report80Terminal
        RadButton7.Text = My.Resources.report_en.reportSaleNoDetail
        BtnCloseShiftReport.Text = My.Resources.report_en.reportCloseShift
        BtnReportItem.Text = My.Resources.report_en.reportProduct
        BtnReportProfit.Text = My.Resources.report_en.reportProfit
        Button1.Text = My.Resources.report_en.reportGrab
        Button2.Text = My.Resources.report_en.reportLine
        Button3.Text = My.Resources.report_en.reportRobin
        Button4.Text = My.Resources.report_en.reportShopee
    End Sub

End Class