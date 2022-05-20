Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Module ModulePrintPosSlip
    Sub PrintSlip(saleID As Integer)
        Try
            Dim Report As New PosSlip
            Report.rpSaleId = saleID
            If TableId > 0 Then Report.GroupFooter3.Visible = False
            Dim Printool As New ReportPrintTool(Report)
            Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
            Report.PrinterName = GetPrinterName(0)("SettingValue")
            Dim GetPrintOption As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=6")
            If GetPrintOption(0)("SettingValue") = 1 Then
                Printool.PrinterSettings.Copies = My.Settings.BillCopies
                Printool.Print()
                writeLog("User ID " + Frm_Login.UserId.ToString + " Print slip sale ID =" + GetSaleId.ToString)

                'GetSaleId = 0
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub PrintBillCheck()
        Dim Report As New BillCheck_savesale
        Report.Parameter1.Value = TB_GetSaleId
        Report.SqlDataSource1.Connection.ConnectionString = rptConStr
        Dim Printool As New ReportPrintTool(Report)
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
