Imports DevExpress.XtraReports.UI
Public Class Frm_WithdrawMoney
    Public Shared Date_start As String
    Public Shared Date_End As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Btn_Search_Click_1(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(DTP2.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim report As New Report_WithdrawMoney
        'Dim Datatable1 As DataTable = executesql("select WithdrawMoney.WithdrawName, WithdrawMoney.InsertDate, WithdrawMoney.WithdrawAmount, WithdrawMoney.UserId,WithdrawMoney.Active, Users.FristName from (dbo.WithdrawMoney WithdrawMoney inner join dbo.Users Users on (Users.UserId = WithdrawMoney.UserId)) where WithdrawMoney.InsertDate BETWEEN'" & Date_start & "' AND '" & Date_End & "'")
        'report.DataSource = Datatable1
        report.Parameter1.Value = Date_start
        report.Parameter2.Value = Date_End
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report

    End Sub

    Private Sub Frm_WithdrawMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP1.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        DTP2.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub

End Class