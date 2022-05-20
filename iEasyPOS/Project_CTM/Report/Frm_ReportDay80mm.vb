Public Class Frm_ReportDay80mm
    Public Shared SaleTerminalName As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim DTS As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim report As New ReportDays80mm
        report.Parameter1.Value = DTS
        report.txtSaleDate.Text = Convert.ToDateTime(DTP1.Value).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub
    Private Sub Frm_ReportDay80mm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class