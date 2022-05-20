Public Class FrmReportSale_PayType_V2

    Private Sub FrmReportSale_PayType_V2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim PayName As DataTable = executesql("SELECT Paymentname FROM PaymentType")
        For i As Integer = 0 To PayName.Rows.Count - 1
            ComboPayment.Items.Add(PayName(i)("Paymentname"))
        Next
    End Sub
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim DTS As String = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim DTE As String = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim Report As New ReportSaleNum_PayType_V2
        Report.Parameter1.Value = DTS
        Report.Parameter2.Value = DTE
        Report.Parameter3.Value = ComboPayment.Text
        Report.SqlDataSource1.Connection.ConnectionString = rptConStr
        Report.CreateDocument()
        DocumentViewer1.DocumentSource = Report
    End Sub

End Class