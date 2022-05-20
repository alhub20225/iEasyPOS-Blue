Imports DevExpress.XtraReports.UI
Public Class Frm_rtpUnitInStock

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        Dim report As New Report_UnitInStock
        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.Parameter1.Value = txt_search.Text
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
        clear()
    End Sub
    Sub clear()
        txt_search.Text = ""
    End Sub

    Private Sub Frm_rtpUnitInStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim report As New Report_UnitInStock
        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.Parameter1.Value = txt_search.Text
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
        clear()
    End Sub
End Class