Imports System.Drawing.Printing
Imports DevExpress.DataAccess.ConnectionParameters

Public Class subReportPaymentDetail
    Private Sub SupReportPaymentDetail_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Dim connectionParameters As New CustomStringConnectionParameters(rptConStr)
        SqlDataSource1.ConnectionParameters = connectionParameters
    End Sub

    Private Sub supReportPaymentDetail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        Dim Ds As New DataSale
        Ds = CalculateSale(Param1.Value, Param2.Value)
        TotalQrThai.Text = FormatNumber(Ds.totalQrthai, 2)
        TotalAlipay.Text = FormatNumber(Ds.totalAlipay, 2)
        TotalQrWechat.Text = FormatNumber(Ds.totalWechat, 2)
        TotalCreditCard.Text = FormatNumber(Ds.totalCreditcard, 2)
        TotalGift.Text = FormatNumber(Ds.totalGiftcard, 2)
        TotalGrab.Text = FormatNumber(Ds.totalGrabfood, 2)
        TotalAirPay.Text = FormatNumber(Ds.totalAirPay, 2)
        TotalLineMan.Text = FormatNumber(Ds.totalLineman, 2)
        TotalRobinhood.Text = FormatNumber(Ds.totalRobinhood, 2)
        TotalShopee.Text = FormatNumber(Ds.TotalShopee, 2)
        TotalFoodPanda.Text = FormatNumber(Ds.TotalFoodPanda, 2)
        LabelTableTotal.Text = FormatNumber(Ds.totalCash, 2)
        TotalPaymentDetail.Text = FormatNumber(Ds.Allsale, 2)
    End Sub

    Private Sub XrTable2_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrTable2.BeforePrint
        If TotalQrThai.Text = "0.00" Then
            XrTableRow16.Visible = False
        End If
        If TotalAlipay.Text = "0.00" Then
            XrTableRow17.Visible = False
        End If
        If TotalQrWechat.Text = "0.00" Then
            XrTableRow18.Visible = False
        End If
        If TotalCreditCard.Text = "0.00" Then
            XrTableRow19.Visible = False
        End If
        If TotalGift.Text = "0.00" Then
            XrTableRow2.Visible = False
        End If
        If TotalGrab.Text = "0.00" Then
            XrTableRow3.Visible = False
        End If
        If TotalAirPay.Text = "0.00" Then
            XrTableRow4.Visible = False
        End If
        If LabelTableTotal.Text = "0.00" Then
            XrTableRow15.Visible = False
        End If
        If TotalShopee.Text = "0.00" Then
            XrTableRow7.Visible = False
        End If
        If TotalFoodPanda.Text = "0.00" Then
            XrTableRow7.Visible = False
        End If
    End Sub
End Class