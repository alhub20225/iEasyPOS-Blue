Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Module PrintDOC
    Sub OpenShift()
        Try
            Dim DocOpenShift As New OpenShift
            Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
            DocOpenShift.PrinterName = GetPrinterName(0)("SettingValue")
            DocOpenShift.SqlDataSource1.Connection.ConnectionString = rptConStr
            DocOpenShift.Print
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
