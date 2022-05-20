Imports System.Drawing.Printing
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraReports.Parameters

Public Class SumCustomerSale

    Private Sub SumCustomerSale_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        Dim connectionParameters As New CustomStringConnectionParameters(rptConStr)
        SqlDataSource1.ConnectionParameters = connectionParameters
    End Sub

End Class