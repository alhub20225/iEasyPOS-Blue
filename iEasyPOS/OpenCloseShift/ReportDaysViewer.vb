Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class ReportDaysViewer
    Private Sub ReportDaysViewer_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'Dim DataSet1 As New DataSet
        'DataSet1.DataSetName = "Dataset1"
        'Select Branch Name 
        'DataSet1.Tables.Add(DataBranchName)
        'DataSource = DataSet1
    End Sub
    Private Sub LabelSaleOfDate_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles LabelSaleOfDate.BeforePrint
        Dim DateopenShift As Date = ModuleShift.DateOpen
        LabelSaleOfDate.Text = (DateopenShift).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("us-US"))
    End Sub

    Private Sub TxtBranchName_BeforePrint(sender As Object, e As PrintEventArgs) Handles TxtBranchName.BeforePrint
        Dim DataBranchName As DataTable = executesql("SELECT BranchName FROM Branch")
        TxtBranchName.Text = DataBranchName(0)("BranchName").ToString
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel2.BeforePrint
        Dim DataBranchName As DataTable = executesql("SELECT BranchName FROM Branch")
        XrLabel2.Text = DataBranchName(0)("BranchName").ToString
    End Sub
End Class