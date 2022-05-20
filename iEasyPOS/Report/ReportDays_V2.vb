Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters

Public Class ReportDays_V2
    Private Sub ReportDays_V2_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

    End Sub

    Private Sub ReportDays_V2_ParametersRequestBeforeShow(sender As Object, e As ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Start_Date.Value = FrmReportDay.Date_start
        End_Date.Value = FrmReportDay.Date_End
    End Sub

    Private Sub ReportDays_V2_ParametersRequestValueChanged(sender As Object, e As ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
        Start_Date.Value = FrmReportDay.Date_start
        End_Date.Value = FrmReportDay.Date_End

    End Sub
End Class