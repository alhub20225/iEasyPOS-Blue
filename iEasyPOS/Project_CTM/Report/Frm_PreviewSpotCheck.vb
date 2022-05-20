Public Class Frm_PreviewSpotCheck
    Private Sub Frm_PreviewSpotCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Report As New SpotCheck
        Report.CreateDocument()
        DocumentViewer1.DocumentSource = Report
        Report.TotalNetSale = 0
    End Sub
End Class