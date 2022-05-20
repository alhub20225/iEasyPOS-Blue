Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters

Public Class Order

    Private Sub Order_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate LIKE '%" & Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) & "%'")
        'Dim NumQ As Integer = 0
        'If checkSaleNo.Rows.Count = 0 Then
        '    NumQ = 1
        'Else
        '    NumQ = checkSaleNo.Rows.Count + 1
        'End If

        XrLabel11.Text = checkSaleNo.Rows.Count
    End Sub

    'Private Sub Order_ParametersRequestBeforeShow(sender As Object, e As ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
    '    Parameter1.Value = GetSaleId
    'End Sub
End Class