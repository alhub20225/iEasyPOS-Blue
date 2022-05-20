Public Class Frm_PreviewSpotCheck
    Private Sub Frm_PreviewSpotCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DT1 As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Dim DT2 As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        Dim Report As New SpotCheck
        Report.Parameter1.Value = DT1
        Report.Parameter2.Value = DT2
        Report.CreateDocument()
        DocumentViewer1.DocumentSource = Report
        Report.TotalNetSale = 0
    End Sub
End Class