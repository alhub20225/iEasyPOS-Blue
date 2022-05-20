Imports System.Drawing.Printing

Public Class CloseShiftPrint
    Public Shared TotalNetSale As Decimal = 0.00
    Public Shared PercentDc As Decimal = 0.00
    Public Shared BathDC As Decimal = 0.00
    Public Shared Tax As Decimal = 0.00
    Public Shared _cultureEnInfo As New Globalization.CultureInfo("th-TH")
    Public Shared dateFromDBCloseShift As DateTime
    Public Shared dateFromDBOpenShift As DateTime
    Public Shared Userin As String
    Public Shared UserOut As String
    Public Shared Change As Decimal = 0.00
    Public Shared OverShort As Decimal = 0.00
    Public Shared CashInDrawer As Decimal = 0.00
    Public Shadows QrThai As Decimal = 0.00
    Public Shadows QrAlipay As Decimal = 0.00
    Public Shadows QrWechat As Decimal = 0.00
    Public Shadows CreditCard As Decimal = 0.00
    Public Shared totalcash As Decimal = 0.00
    Dim TerminalName As String = Environment.MachineName
    Dim DateTimeOpenShift As String = ModuleShift.DateOpen
    Dim DateTimeCloseShift As String = ModuleShift.DateClose
    'Dim DateTimeOpenShift As String = "2561-10-31 07:54:00"
    'Dim DateTimeCloseShift As String = "2561-10-31 21:56:35"
    Private Sub CloseShiftPrint_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        Dim Datatable1 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025 FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE')")
        Dim Datatable2 As DataTable = executesql("SELECT SubTotal FROM Sale WHERE SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Active=1")
        If IsNothing(Datatable2) Then
        ElseIf Datatable2.Rows.Count < 0 Then
        ElseIf Datatable2.Rows.Count > 0 Then

            For i As Integer = 0 To Datatable2.Rows.Count - 1
                TotalNetSale += Datatable2(i)("SubTotal")
            Next
        End If
        Dim Datatable4 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE')")
        'MsgBox(CashInDrawer)
        dateFromDBCloseShift = Convert.ToDateTime(Datatable4(0)("DateTimeOpen"), _cultureEnInfo)
        'UserName IN
        Dim Datatable5 As DataTable = executesql("SELECT FristName FROM Users WHERE UserId =" & Datatable1(0)("UserId") & "")
        Userin = Datatable5(0)("FristName")
        'UserName OUT
        Dim Datatable6 As DataTable = executesql("SELECT FristName FROM Users WHERE UserId =" & Datatable4(0)("UserId") & "")


        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId=16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalCash
        Dim Datatable12 As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)
) As SubTotal
  from  Sale 
Where Sale.Active = 1 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")


        If Datatable8.Rows.Count > 0 Then
            If IsDBNull(Datatable8(0)("SubTotal")) Then
                QrThai = 0
            Else
                QrThai = Datatable8(0)("SubTotal")
            End If
        End If
        If Datatable9.Rows.Count > 0 Then
            If IsDBNull(Datatable9(0)("SubTotal")) Then
                QrAlipay = 0
            Else
                QrAlipay = Datatable9(0)("SubTotal")
            End If
        End If
        If Datatable10.Rows.Count > 0 Then
            If IsDBNull(Datatable10(0)("SubTotal")) Then
                QrWechat = 0
            Else
                QrWechat = Datatable10(0)("SubTotal")
            End If
        End If
        If Datatable11.Rows.Count > 0 Then
            If IsDBNull(Datatable11(0)("SubTotal")) Then
                CreditCard = 0
            Else
                CreditCard = Datatable11(0)("SubTotal")
            End If
        End If
        If Datatable12.Rows.Count > 0 Then
            If IsDBNull(Datatable12(0)("SubTotal")) Then
                totalcash = 0
            Else
                totalcash = Datatable12(0)("SubTotal")
            End If
        End If
        Dim MinMaxSaleNo As DataTable = executesql("select min(SaleNo) AS MinSaleNo,max(SaleNo) AS MaxSaleNo from sale where SaleDate BETWEEN  '" & DateTimeOpenShift & "' AND  '" & DateTimeCloseShift & "'")

        If IsDBNull(MinMaxSaleNo(0)("MinSaleNo")) Then
            txtStartNumSale.Text = ""
            txtEndNumSale.Text = ""
        Else
            txtStartNumSale.Text = MinMaxSaleNo(0)("MinSaleNo")
            txtEndNumSale.Text = MinMaxSaleNo(0)("MaxSaleNo")
        End If

        UserOut = Datatable6(0)("FristName")
    End Sub
    Private Sub XrLabel8_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel8.BeforePrint
        XrLabel8.Text = FormatNumber(totalcash + QrThai + QrAlipay + QrWechat + CreditCard, 2)
    End Sub

    Private Sub XrLabel12_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateCloseShift.BeforePrint
        LabelDateCloseShift.Text = DateTimeCloseShift
    End Sub
    Private Sub LabelDateOpenShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateOpenShift.BeforePrint
        LabelDateOpenShift.Text = DateTimeOpenShift
    End Sub

    Private Sub XrLabel13_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserIn.BeforePrint
        LabelUserIn.Text = Userin
    End Sub
    Private Sub LabelUserOut_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserOut.BeforePrint
        LabelUserOut.Text = UserOut
    End Sub

    Private Sub LabelTableTotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTableTotal.BeforePrint
        LabelTableTotal.Text = FormatNumber(totalcash, 2)
    End Sub



    Private Sub TotalQrThai_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalQrThai.BeforePrint
        TotalQrThai.Text = FormatNumber(QrThai, 2)
    End Sub

    Private Sub TotalAlipay_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalAlipay.BeforePrint
        TotalAlipay.Text = FormatNumber(QrAlipay, 2)
    End Sub

    Private Sub TotalQrWechat_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalQrWechat.BeforePrint
        TotalQrWechat.Text = FormatNumber(QrWechat, 2)
    End Sub

    Private Sub TotalCreditCard_BeforePrint(sender As Object, e As PrintEventArgs) Handles TotalCreditCard.BeforePrint
        TotalCreditCard.Text = FormatNumber(CreditCard, 2)
    End Sub

    Private Sub XrLabel1_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel1.BeforePrint
        Dim Datatable As DataTable = executesql("SELECT BranchName FROM Branch")
        If IsDBNull(Datatable(0)("BranchName")) Then
            XrLabel1.Text = ""
        Else
            XrLabel1.Text = Datatable(0)("BranchName")
        End If
    End Sub

    Private Sub XrLabel12_BeforePrint_1(sender As Object, e As PrintEventArgs) Handles XrLabel12.BeforePrint
        XrLabel12.Text = TerminalName
    End Sub
    Private Sub TableBranchAddress_BeforePrint(sender As Object, e As PrintEventArgs) Handles TableBranchAddress.BeforePrint
        Dim DataBranch As DataTable = executesql("select BranchName,CompanyName,Address,Address2,Provinces,ZipCode,TaxId,Telephone from branch")
        If DataBranch(0)("CompanyName") = "" Then
            XrTableRow26.Visible = False
        Else
            txtCompaName.Text = DataBranch(0)("CompanyName")
        End If

        If DataBranch(0)("Address") = "" Then
            XrTableRow21.Visible = False
        Else
            txtBranchAdd.Text = DataBranch(0)("Address")
        End If

        If DataBranch(0)("Address2") = "" Then
            XrTableRow22.Visible = False
        Else
            txtBranchAdd2.Text = DataBranch(0)("Address2")
        End If

        If DataBranch(0)("Provinces") = "" Then
            XrTableRow23.Visible = False
        Else
            txtProvinces.Text = DataBranch(0)("Provinces") + " " + DataBranch(0)("ZipCode")
        End If

        If DataBranch(0)("Telephone") = "" Then
            XrTableRow24.Visible = False
        Else
            txtTelephone.Text = DataBranch(0)("Telephone")
        End If

        If DataBranch(0)("TaxId") = "" Then
            txtTaxId.Visible = False
        Else
            txtTaxId.Text = "เลขประจำตัวผู้เสียภาษี :" + DataBranch(0)("TaxId")
        End If

    End Sub
End Class