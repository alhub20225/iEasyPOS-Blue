Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters

Public Class Order
    Private Sub Order_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        XrLabel11.Text = ModulePayMent.NumQ
    End Sub

    'Private Sub Order_ParametersRequestBeforeShow(sender As Object, e As ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
    '    Parameter1.Value = GetSaleId
    'End Sub
End Class