Public Class FrmReportCancleSale
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Report_CancleSale As New ReportCancleSale

        Report_CancleSale.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Report_CancleSale.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

        'Dim Date_start = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        'Dim Date_End = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        'Dim DT1 As DataTable = executesql("select Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,Sale.TaxAmt, Sale.Total,  Sale.InsertDate,
        '                                    Sale.TerminalName, Sale.AmountDC,
        '                                    Users.FristName
        '                                    from (((dbo.Sale Sale
        '                                    inner join dbo.PaymentDetail PaymentDetail
        '                                    on (PaymentDetail.SaleId = Sale.SaleId))
        '                                    inner join dbo.PaymentType PaymentType
        '                                    on (PaymentType.PaymentId = PaymentDetail.PaymentTypeId))
        '                                    inner join dbo.Users Users
        '                                    on (Users.UserId = Sale.VoidUserId))
        '                                   WHERE Sale.SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'
        '                                    AND Sale.Active = 2
        '                                    Group by Sale.SaleDate, Sale.SaleNo, Sale.SubTotal,Sale.TaxAmt, Sale.Total,Sale.InsertDate,
        '                                    Sale.TerminalName, Sale.AmountDC,
        '                                    PaymentDetail.PaidAmount, 
        '                                    Users.FristName")
        'If IsNothing(DT1) Then
        '    MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Critical, "คำเตือน")
        '    Exit Sub
        'End If
        'If DT1.Rows.Count = 0 Then
        '    MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Critical, "คำเตือน")
        '    Exit Sub
        'End If
        'Report_CancleSale.DataSource = DT1
        Report_CancleSale.TxtStartDate.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_CancleSale.TxtEndDate.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report_CancleSale.CreateDocument()
        DocumentViewer1.DocumentSource = Report_CancleSale
    End Sub

    Private Sub FrmReportCancleSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class