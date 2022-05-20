Imports System.Drawing.Printing

Public Class ReportCloseShift_80mm
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
    Public Shared AcmountDC As Decimal = 0.00
    Public Shared Withdraw As Decimal = 0.00
    Public DateTimeOpenShift As String
    Public DateTimeCloseShift As String
    Public shiftId As Integer = 0

    Private Sub ReportCloseShift_80mm_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        'Open shift 
        Dim TerminalName As String = Environment.MachineName
        Dim Dataset1 As New DataSet
        Dataset1.DataSetName = "DataSet1"
        Dim Datatable1 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025 FROM OpenCloseShift WHERE ShiftId =" & shiftId & " AND TerminalName='" & TerminalName & "' AND TypeShift='CLOSE'")
        If Datatable1.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        dateFromDBOpenShift = Convert.ToDateTime(Datatable1(0)("DateTimeOpen"), _cultureEnInfo)
        Change = Datatable1(0)("MoneyCash")

        Dim UserNameOpenShift As String = Frm_CloseShift.LabelUseropenshift.Text
        Dim DateClose As String = Now.ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim SumTotalNetSale As Decimal = 0.00
        Dim Datatable2 As DataTable = executesql("SELECT SubTotal FROM Sale WHERE SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Active=1")
        If IsNothing(Datatable2) Then
        ElseIf Datatable2.Rows.Count < 0 Then
        ElseIf Datatable2.Rows.Count > 0 Then

            For i As Integer = 0 To Datatable2.Rows.Count - 1
                TotalNetSale += Datatable2(i)("SubTotal")
            Next
        End If
        'Branch Name 
        Dim Datatable3 As DataTable = executesql("SELECT BranchName FROM Branch")
        'Close Shift
        Dim Datatable4 As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & TerminalName & "' AND TypeShift='CLOSE' AND DateTimeOpen BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "')")
        If Datatable4.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
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
        'MsgBox(CashInDrawer)
        dateFromDBCloseShift = Convert.ToDateTime(Datatable4(0)("DateTimeOpen"), _cultureEnInfo)
        'UserName IN
        Dim Datatable5 As DataTable = executesql("SELECT FirstName FROM Users WHERE UserId =" & Datatable1(0)("UserId") & "")
        Userin = Datatable5(0)("FirstName")
        'UserName OUT
        Dim Datatable6 As DataTable = executesql("SELECT FirstName FROM Users WHERE UserId =" & Datatable4(0)("UserId") & "")
        'DisCount Percent and BathDC and Tax
        Dim Datatable7 As DataTable = executesql("SELECT Sum(SaleItem.PercentDC) As PercentDc,Sum(SaleItem.BahtDC) As BahtDC,(Select Sum(Sale.AmountDC) from Sale where Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1) As AmountDC,(Select Sum(Sale.TaxAmt) from Sale where Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1) As Tax FROM SaleItem inner join sale on(Sale.SaleId = SaleItem.SaleId) WHERE SaleItem.insertDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active=1")
        If Datatable7.Rows.Count > 0 Then
            If IsDBNull(Datatable7(0)("AmountDC")) Then
                AcmountDC = 0
                PercentDc = 0
                Tax = 0
            Else
                AcmountDC = Datatable7(0)("AmountDC")
                PercentDc = Datatable7(0)("PercentDC")
                BathDC = Datatable7(0)("BahtDC")
                Tax = Datatable7(0)("Tax")
            End If
        End If

        'TotalQrThai
        Dim Datatable8 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrAlipay
        Dim Datatable9 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalQrWechat
        Dim Datatable10 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        'TotalCreditCrad
        Dim Datatable11 As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")

        '        'GiftCard
        '        Dim DataGiftCard As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        'Where Sale.Active = 1  And PaymentType.PaymentId= 18 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")

        '        'GrabFood
        '        Dim DataGrabFood As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) 
        'Where Sale.Active = 1  And PaymentType.PaymentId= 19 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")

        Dim Datatable12 As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 18 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 19 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 20 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 21 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 22 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 23 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)-
            ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 24 And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'),0)
            ) As SubTotal from  Sale Where Sale.Active = 1  And Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
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
        Dim CountSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale where SaleDate BETWEEN  '" & DateTimeOpenShift & "' AND  '" & DateTimeCloseShift & "'")
        If IsDBNull(MinMaxSaleNo(0)("MinSaleNo")) Then
            txtStartNumSale.Text = ""
            txtEndNumSale.Text = ""
        Else
            txtStartNumSale.Text = MinMaxSaleNo(0)("MinSaleNo")
            txtEndNumSale.Text = MinMaxSaleNo(0)("MaxSaleNo")
        End If

        If CountSaleNo.Rows.Count = 0 Then
            XrLabel44.Text = 0
            XrLabel46.Text = 0
        Else
            XrLabel44.Text = CountSaleNo.Rows.Count
            XrLabel46.Text = CountSaleNo.Rows.Count
        End If


        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Active = 1")
        If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
            txtWithdraw.Text = FormatNumber("0", 2)
            Withdraw = 0.00
        Else
            txtWithdraw.Text = FormatNumber(sum_withDraw(0)("WithdrawAmount"), 2)
            Withdraw = sum_withDraw(0)("WithdrawAmount")
        End If

        UserOut = Datatable6(0)("FirstName")
        Dataset1.Tables.Add(Datatable1)
        Dataset1.Tables.Add(Datatable2)
        Dataset1.Tables.Add(Datatable3)
        Dataset1.Tables.Add(Datatable4)
        Datatable1.TableName = "OpenCloseShift"
        Datatable2.TableName = "SumNetSale"
        Datatable3.TableName = "Branch"
        Datatable4.TableName = "DataCloseshift"
        DataSource = Dataset1
    End Sub
    Private Sub XrLabel8_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel8.BeforePrint
        XrLabel8.Text = FormatNumber(TotalNetSale, 2)
    End Sub

    Private Sub XrLabel12_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateCloseShift.BeforePrint
        LabelDateCloseShift.Text = DateTimeCloseShift
    End Sub
    Private Sub LabelDateOpenShift_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateOpenShift.BeforePrint
        LabelDateOpenShift.Text = DateTimeOpenShift
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelDateSale.BeforePrint
        LabelDateSale.Text = getdate(dateFromDBOpenShift)
    End Sub
    Private Sub XrLabel13_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserIn.BeforePrint
        LabelUserIn.Text = Userin
    End Sub
    Private Sub LabelUserOut_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelUserOut.BeforePrint
        LabelUserOut.Text = UserOut
    End Sub



    Private Sub LabelTotalOrder_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalOrder.BeforePrint

        Dim Datatable2 As DataTable = executesql("SELECT SUM(SubTotal) As SubTotal FROM Sale WHERE SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Active=1")
        If IsDBNull(Datatable2(0)("SubTotal")) Then
            LabelTotalOrder.Text = "0"
        Else
            LabelTotalOrder.Text = FormatNumber(Datatable2(0)("SubTotal"), 2)
        End If

    End Sub

    Private Sub LabelTotalDiscount_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalDiscount.BeforePrint
        LabelTotalDiscount.Text = FormatNumber(AcmountDC + PercentDc + BathDC, 2)
    End Sub

    Private Sub LabelTotalExcTax_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalExcTax.BeforePrint
        LabelTotalExcTax.Text = FormatNumber(TotalNetSale - Tax, 2)
    End Sub
    Private Sub LabelTax_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTax.BeforePrint
        'LabelTax.Text = FormatNumber(Tax, 2)
        LabelTax.Text = FormatNumber(((TotalNetSale * 7) / 107), 2)
    End Sub

    Private Sub LabelRealSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelRealSale.BeforePrint
        LabelRealSale.Text = FormatNumber(TotalNetSale, 2)
    End Sub
    Private Sub LabelTotalOfSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalOfSale.BeforePrint
        LabelTotalOfSale.Text = FormatNumber(TotalNetSale, 2)
    End Sub
    Private Sub LabelChange_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelChange.BeforePrint
        LabelChange.Text = FormatNumber(Change, 2)
    End Sub

    Private Sub XrLabel51_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelOverShort.BeforePrint
        OverShort = CashInDrawer - (Change + totalcash - Withdraw)
        'MsgBox(TotalNetSale.ToString + "-" + Change.ToString + "-" + CashInDrawer.ToString)
        LabelOverShort.Text = FormatNumber(OverShort, 2)
    End Sub
    Private Sub LabelSaleCash_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelSaleCash.BeforePrint
        LabelSaleCash.Text = FormatNumber(totalcash, 2)
    End Sub


    Private Sub LabelTotalDeleteSale_BeforePrint(sender As Object, e As PrintEventArgs) Handles LabelTotalDeleteSale.BeforePrint
        Dim DT As DataTable = executesql("select sum(Sale.SubTotal) as SubTotal  from Sale WHERE Sale.SaleDate BETWEEN '" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "' AND Sale.Active = 2")
        If IsDBNull(DT(0)("SubTotal")) Then
            LabelTotalDeleteSale.Text = 0.00
        Else
            LabelTotalDeleteSale.Text = FormatNumber(DT(0)("SubTotal"), 2)
        End If
    End Sub

    Private Sub XrLabel50_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtWithdraw.BeforePrint
        Dim DT As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN'" & DateTimeOpenShift & "' AND '" & DateTimeCloseShift & "'")
        If IsDBNull(DT(0)("WithdrawAmount")) Then
            txtWithdraw.Text = 0.00
        Else
            txtWithdraw.Text = FormatNumber(DT(0)("WithdrawAmount"), 2)
        End If
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

    Private Sub ReportCloseShift_80mm_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint
        TotalNetSale = 0.00
        PercentDc = 0.00
        BathDC = 0.00
        Tax = 0.00
        Change = 0.00
        OverShort = 0.00
        CashInDrawer = 0.00
        QrThai = 0.00
        QrAlipay = 0.00
        QrWechat = 0.00
        CreditCard = 0.00
        totalcash = 0.00
        AcmountDC = 0.00
        Withdraw = 0.00
    End Sub
End Class