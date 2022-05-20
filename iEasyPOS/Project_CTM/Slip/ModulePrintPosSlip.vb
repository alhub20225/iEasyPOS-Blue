Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Module ModulePrintPosSlip
    Sub PrintSlip()
        Dim Report As New PosSlip
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Dim GetPrintOption As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=6")
        If GetPrintOption(0)("SettingValue") = 1 Then
            Printool.PrinterSettings.Copies = My.Settings.BillCopies
            Printool.Print()
            'GetSaleId = 0
        Else
            Exit Sub
        End If
    End Sub
    Sub PrintBillCheck()
        Dim Report As New BillCheck_savesale
        Dim Printool As New ReportPrintTool(Report)
        'Dim table As String = "Setting"
        'Dim field As String = "SettingValue"
        'Dim where As String = "SettingId=1"
        'Dim GetPrinterName As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & where & "")
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        'Report.ShowPreviewDialog
        Printool.Print()
    End Sub
    Sub Reportcloseshift()
        Dim Report As New ReportCloseShift
        Dim Printool As New ReportPrintTool(Report)
        Report.ShowPreviewDialog
    End Sub
End Module
