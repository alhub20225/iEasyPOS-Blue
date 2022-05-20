Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Module PrintDOC
    Sub OpenShift()
        Dim DocOpenShift As New OpenShift
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        DocOpenShift.PrinterName = GetPrinterName(0)("SettingValue")
        DocOpenShift.Print
    End Sub
End Module
