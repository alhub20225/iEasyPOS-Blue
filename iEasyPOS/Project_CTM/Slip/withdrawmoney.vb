Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters
Public Class withdrawmoney
    Public Shadows QrThai As Decimal = 0.00
    Public Shadows QrAlipay As Decimal = 0.00
    Public Shadows QrWechat As Decimal = 0.00
    Public Shadows CreditCard As Decimal = 0.00
    Public Shared totalcash As Decimal = 0.00
    Dim DateNow As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
    'Dim Date_End As String = Convert.ToDateTime(Frm_ReportDay80mm_Terminal.DTP1.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))

    Private Sub TxtBranchName_BeforePrint(sender As Object, e As PrintEventArgs) Handles TxtBranchName.BeforePrint
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        If Baranch_name.Rows.Count = 0 Then
            TxtBranchName.Text = ""
        Else
            TxtBranchName.Text = Baranch_name(0)("BranchName")
        End If
    End Sub

    Private Sub txtSaleDate_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtSaleDate.BeforePrint
        txtSaleDate.Text = DateNow
    End Sub

    Private Sub withdrawmoney_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE Active='1' AND InsertDate LIKE '%" & DateNows & "%'")
        For i As Integer = 0 To selectData.Rows.Count - 1
            XrLabel2.Text = i + 1
            XrLabel1.Text = selectData(i)("WithdrawName")
            XrLabel4.Text = FormatNumber(selectData(i)("WithdrawAmount"), 2)
        Next
    End Sub
End Class