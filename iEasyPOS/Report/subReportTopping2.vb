Imports DevExpress.DataAccess.ConnectionParameters

Public Class subReportTopping2
    Private Sub subReportTopping2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

        Dim chkData As DataTable = executesql("SELECT  COUNT(UseTopping.ToppingId) AS Count_ToppingId, UseTopping.ToppingName, SUM(Topping.Pricing) AS Sum_Pricing FROM  UseTopping AS UseTopping INNER JOIN Topping AS Topping ON Topping.ToppingId = UseTopping.ToppingId INNER JOIN SaleItem AS SaleItem ON SaleItem.SaleItemId = UseTopping.SaleItemId INNER JOIN Sale AS Sale ON Sale.SaleId = SaleItem.SaleId where Sale.SaleDate BETWEEN '" & Parameter1.Value & "' AND '" & Parameter2.Value & "' AND Sale.Active = 1 GROUP BY UseTopping.ToppingName")
        If chkData.Rows.Count = 0 Then ReportHeader.Visible = False
    End Sub

    Private Sub subReportTopping2_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Dim connectionParameters As New CustomStringConnectionParameters(rptConStr)
        SqlDataSource1.ConnectionParameters = connectionParameters
    End Sub
End Class