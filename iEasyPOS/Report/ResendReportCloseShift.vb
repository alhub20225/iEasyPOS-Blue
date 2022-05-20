Imports System.Drawing.Printing
Imports DevExpress.XtraReports.Parameters

Public Class ResendReportCloseShift
    Dim Change As Decimal = 0.00
    Dim OverShort As Decimal = 0.00
    Dim CashInDrawer As Decimal = 0.00
    Public DateTimeOpenShift As String = ""
    Public DateTimeCloseShift As String = ""
    Public shiftId As Integer = 0
    Dim TerminalName As String = Environment.MachineName
    Dim Ds As New DataSale

    Private Sub ResendReportCloseShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        Dim Datatable3 As DataTable = executesql("SELECT BranchName FROM Branch")
        If Datatable3.Rows.Count > 0 Then txtBranchName.Text = Datatable3(0)("BranchName")

        Dim Datatable4 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,CloseUserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = " & shiftId & " AND TerminalName='" & TerminalName & "' AND TypeShift='CLOSE' AND DateTimeOpen BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        Change = Datatable4(0)("MoneyCash")
        CashInDrawer += Datatable4(0)("B1000") * 1000
        CashInDrawer += Datatable4(0)("B500") * 500
        CashInDrawer += Datatable4(0)("B100") * 100
        CashInDrawer += Datatable4(0)("B50") * 50
        CashInDrawer += Datatable4(0)("B20") * 20
        CashInDrawer += Datatable4(0)("C10") * 10
        CashInDrawer += Datatable4(0)("C5") * 5
        CashInDrawer += Datatable4(0)("C2") * 2
        CashInDrawer += Datatable4(0)("C1") * 1
        CashInDrawer += Datatable4(0)("C05") * 0.5
        CashInDrawer += Datatable4(0)("C025") * 0.25

        Dim Datatable5 As DataTable = executesql("SELECT FirstName FROM Users WHERE UserId =" & Datatable4(0)("UserId") & "")
        LabelUserIn.Text = Datatable5(0)("FirstName")
        Dim dtUserOut As DataTable = executesql("SELECT FirstName FROM Users WHERE UserId =" & Datatable4(0)("CloseUserId") & "")
        LabelUserOut.Text = dtUserOut(0)("FirstName")


        Ds = CalculateSale(DateTimeOpenShift, DateTimeCloseShift)
        XrLabel8.Text = FormatNumber(Ds.Allsale, 2)
        LabelTotalOrder.Text = FormatNumber(Ds.Allsale, 2)
        LabelTotalDiscount.Text = FormatNumber(Ds.totalDiscount, 2)
        LabelTotalExcTax.Text = FormatNumber(Ds.Allsale - Ds.totalTax, 2)
        LabelTax.Text = FormatNumber(Ds.totalTax, 2)
        LabelRealSale.Text = FormatNumber(Ds.Allsale, 2)
        LabelTotalOfSale.Text = FormatNumber(Ds.Allsale, 2)
        OverShort = CashInDrawer - (Change + Ds.totalCash - Ds.totalPayout)
        LabelOverShort.Text = FormatNumber(OverShort, 2)
        LabelSaleCash.Text = FormatNumber(Ds.totalCash, 2)
        txtWithdraw.Text = FormatNumber(Ds.totalPayout, 2)
    End Sub

    Private Sub XrLabel12_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateCloseShift.BeforePrint
        LabelDateCloseShift.Text = Convert.ToDateTime(DateTimeCloseShift).ToString("dd MMMM yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub
    Private Sub LabelDateOpenShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateOpenShift.BeforePrint
        LabelDateOpenShift.Text = Convert.ToDateTime(DateTimeOpenShift).ToString("dd MMMM yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateSale.BeforePrint
        LabelDateSale.Text = Convert.ToDateTime(DateTimeOpenShift).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
    End Sub

    Private Sub LabelChange_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelChange.BeforePrint
        LabelChange.Text = FormatNumber(Change, 2)
    End Sub

End Class