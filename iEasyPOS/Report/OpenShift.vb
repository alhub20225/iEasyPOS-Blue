Public Class OpenShift
    Private Sub txtBranch_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtBranch.BeforePrint
        Dim Baranch_name As DataTable = executesql("SELECT BranchName FROM Branch WHERE Active=1")
        If Baranch_name.Rows.Count = 0 Then
            txtBranch.Text = ""
        Else
            txtBranch.Text = Baranch_name(0)("BranchName")
        End If
    End Sub

    Private Sub XrLabel3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = Convert.ToDateTime(XrLabel3.Text).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    End Sub
End Class