Imports DevExpress.DataAccess.ConnectionParameters

Public Class Report_FoodPanda
    Private Sub Report_FoodPanda_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Dim connectionParameters As New CustomStringConnectionParameters(rptConStr)
        SqlDataSource1.ConnectionParameters = connectionParameters
    End Sub

    Private Sub tableCell10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tableCell10.BeforePrint
        'Try
        '    tableCell10.Text = Convert.ToDateTime(tableCell10.Text).ToString("dd-MM-yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub XrTableCell4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell4.BeforePrint
        If XrTableCell4.Text = "FoodPanda" Then
            XrTableCell4.ForeColor = Color.DeepPink
            tableCell12.ForeColor = Color.DeepPink
        End If
    End Sub

    Private Sub Report_Robinhood_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

    End Sub
End Class