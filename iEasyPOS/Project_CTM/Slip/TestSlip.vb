Imports DevExpress.XtraReports.UI

Public Class TestSlip

    Private Sub TestSlip_Load(sender As Object, e As EventArgs) Handles Me.Load
        ModuleShift.DateOpen = "2562-02-08 00:00:00"
        ModuleShift.DateClose = "2562-02-08 23:59:59"
        Dim Report As New ReportDaySale_V2
        Report.Parameter1.Value = "2562-02-01 00:00:00"
        Report.Parameter2.Value = "2562-02-28 23:59:00"
        'Dim Printool As New ReportPrintTool(Report)
        'Dim FileName_ReportDayGroupcate As String = "ReportDayGroupcate" + (Now).ToString("dd-MM-yyyy", New System.Globalization.CultureInfo("th-TH"))
        'Report.ExportToXlsx("C:\ExportReport\" & FileName_ReportDayGroupcate & ".xls")
        Report.ShowPreviewDialog
        'ModuleShift.SendEmailExportPDF()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Report.Parameter2.Value = "2561-12-01 00:00:00"
        'Report.Parameter3.Value = "2561-12-01 23:59:00"
        'Report.Parameter1.Value = "ASUS-K401"

        'Report.CreateDocument()
    End Sub
End Class