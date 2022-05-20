Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class ReportCloseShift
    Dim Userin As String
    Dim Change As Decimal = 0.00
    Dim OverShort As Decimal = 0.00
    Dim CashInDrawer As Decimal = 0.00
    Public DateTimeOpenShift As String = ""
    Public DateTimeCloseShift As String = ""
    Dim Ds As New DataSale

    Private Sub ReportCloseShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        'Open shift 
        Dim TerminalName As String = Environment.MachineName
        Dim Dataset1 As New DataSet
        Dataset1.DataSetName = "DataSet1"
        Dim Datatable1 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025 FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE')")

        Change = Datatable1(0)("MoneyCash")

        Dim DateClose As String = Now.ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

        Dim Datatable2 As DataTable = executesql("SELECT Sale.SubTotal FROM Sale WHERE Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1")

        'Branch Name 
        Dim Datatable3 As DataTable = executesql("SELECT BranchName FROM Branch")
        'Close Shift
        Dim Datatable4 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE')")
        'Over Short
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

        Dim Datatable5 As DataTable = executesql("SELECT FirstName FROM Users WHERE UserId =" & Datatable1(0)("UserId") & "")
        Userin = Datatable5(0)("FirstName")


        Dataset1.Tables.Add(Datatable1)
        Dataset1.Tables.Add(Datatable2)
        Dataset1.Tables.Add(Datatable3)
        Dataset1.Tables.Add(Datatable4)
        Datatable1.TableName = "OpenCloseShift"
        Datatable2.TableName = "SumNetSale"
        Datatable3.TableName = "Branch"
        Datatable4.TableName = "DataCloseshift"
        DataSource = Dataset1

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
    Private Sub XrLabel13_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserIn.BeforePrint
        LabelUserIn.Text = Userin
    End Sub


    Private Sub LabelChange_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelChange.BeforePrint
        LabelChange.Text = FormatNumber(Change, 2)
    End Sub

End Class