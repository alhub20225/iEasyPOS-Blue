Public Class Frm_ReportDay80mm_Terminal
    Public Shared SaleTerminalName As String
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If ComboBox1.Text = "" Then
            MsgBox("กรุณาเลือก Terminal Name", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        Dim DTS As String = Convert.ToDateTime(DTP1.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim TerminalName As String = ComboBox1.Text
        SaleTerminalName = ComboBox1.Text
        Dim report As New ReportDay80mm_Terminal
        report.txtSaleDate.Text = Convert.ToDateTime(DTP1.Value).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        report.Parameter1.Value = DTS
        report.Parameter2.Value = SaleTerminalName
        report.SqlDataSource1.Connection.ConnectionString = rptConStr
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub

    Private Sub Frm_ReportDay80mm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TerminalName As DataTable = executesql("select TerminalName from Sale group by TerminalName")
        ComboBox1.Controls.Clear()
        If TerminalName.Rows.Count > 0 Then
            For i As Integer = 0 To TerminalName.Rows.Count - 1
                ComboBox1.Items.Add(TerminalName(i)("TerminalName"))
            Next
        End If
    End Sub
End Class