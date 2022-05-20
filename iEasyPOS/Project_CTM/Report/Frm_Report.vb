Imports DevExpress.XtraReports.UI

Public Class Frm_Report
    Private Sub Close_Report_Click(sender As Object, e As EventArgs) Handles Close_Report.Click
        Me.Close()
        Main.Close()
        Main.Show()
    End Sub

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

        Dim CheckDataRows As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = " & DataGridShiftNumber.CurrentRow.Cells(1).Value & " AND TypeShift='CLOSE'")

        If CheckDataRows.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        ModuleShift.DateOpen = Convert.ToDateTime(CheckDataRows(0)("DateTimeOpen")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        ModuleShift.DateClose = Convert.ToDateTime(CheckDataRows(0)("DateTimeClose")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        ResendMail.SendEmailExportPDF()
    End Sub



    Private Sub RadButton14_Click(sender As Object, e As EventArgs) Handles RadButton14.Click
        FrmReportToppingSale.Show()
    End Sub


    Private Sub DTP1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.ValueChanged
        DataGridShiftNumber.Rows.Clear()
        Dim DateStart As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim DateEnd As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID  from OpenCloseShift where DateTimeOpen Between '" & DateStart & "' and '" & DateEnd & "' AND TypeShift='CLOSE'")
        For i As Integer = 0 To CheckShiftNum.Rows.Count - 1
            DataGridShiftNumber.Rows.Add(CheckShiftNum(i)("shiftNumber"), CheckShiftNum(i)("ShiftId"))
        Next


        If CheckShiftNum.Rows.Count > 0 Then
            BtnRePrint.Enabled = True
            Btn_SendMali.Enabled = True
        Else
            BtnRePrint.Enabled = False
            Btn_SendMali.Enabled = False
        End If
    End Sub

    Private Sub Frm_Report_Load(sender As Object, e As EventArgs) Handles Me.Load

        If DataGridShiftNumber.Text = "" Then
            BtnRePrint.Enabled = False
            Btn_SendMali.Enabled = False
        Else
            BtnRePrint.Enabled = True
            Btn_SendMali.Enabled = True
        End If

    End Sub

    Private Sub BtnRePrint_Click(sender As Object, e As EventArgs) Handles BtnRePrint.Click
        'ModuleShift.DateOpen = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        'ModuleShift.DateClose = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim TerminalName As String = Environment.MachineName

        'Dim CheckDataRows As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE' AND DateTimeOpen BETWEEN '" & ModuleShift.DateOpen & "' AND '" & ModuleShift.DateClose & "')")

        Dim CheckDataRows As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = " & DataGridShiftNumber.CurrentRow.Cells(1).Value & " AND TypeShift='CLOSE'")

        If CheckDataRows.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        ModuleShift.DateOpen = Convert.ToDateTime(CheckDataRows(0)("DateTimeOpen")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        ModuleShift.DateClose = Convert.ToDateTime(CheckDataRows(0)("DateTimeClose")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))

        Dim Report As New ReportCloseShift_80mm
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Report.LabelDateSale.Visible = False
        Report.XrLabel3.Visible = False
        Report.CreateDocument()
        Report.Print

        Dim ShiftClose As New CloseShiftPrint
        ShiftClose.PrinterName = GetPrinterName(0)("SettingValue")
        ShiftClose.CreateDocument()
        ShiftClose.Print

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Report.TotalNetSale = 0
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub BtnMonthReport_Click(sender As Object, e As EventArgs) Handles BtnMonthReport.Click
        SendEmailMonth()
    End Sub
End Class