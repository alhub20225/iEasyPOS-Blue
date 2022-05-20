Imports DevExpress.DataAccess.ConnectionParameters

Public Class Report_Items
    Private Sub SupReportPaymentDetail_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Dim connectionParameters As New CustomStringConnectionParameters(rptConStr)
        SqlDataSource1.ConnectionParameters = connectionParameters
    End Sub
End Class