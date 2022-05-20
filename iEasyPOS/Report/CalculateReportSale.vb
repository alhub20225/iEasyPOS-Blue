Module CalculateReportSale
    Public Function CalculateSale(dt1 As String, dt2 As String) As DataSale
        'QrThai
        Dim dtQrThai As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")
        'TotalQrAlipay
        Dim dtQrAlipay As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId=16 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")
        'TotalQrWechat
        Dim dtQrWechat As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 17 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")
        'TotalCreditCrad
        Dim dtCreditCrad As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")

        'GiftCard
        Dim DataGiftCard As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 18 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")

        'GrabFood
        Dim DataGrabFood As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 19 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")
        'GrabFood
        Dim DataAirPay As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 20 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")

        'Lineman
        Dim DataLineman As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 21 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")

        'Robinhood
        Dim DataRobinhood As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 22 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")
        'DataShopee
        Dim DataShopee As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 23 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")
        'DataShopee
        Dim DataFoodPanda As DataTable = executesql("Select ISNULL(sum(PaymentDetail.PaidAmount),0) As SubTotal from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId= 24 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'")

        'TotalCash
        Dim dtCash As DataTable = executesql("Select  (sum(Sale.SubTotal) - 
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 11 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 15 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 16 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 17 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 18 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 19 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 20 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 21 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 22 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 23 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)-
ISNULL((Select sum(PaymentDetail.PaidAmount) from PaymentDetail inner Join Sale On(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType  On (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) Where Sale.Active = 1  And PaymentType.PaymentId = 24 And Sale.SaleDate BETWEEN '" & dt1 & "' AND '" & dt2 & "'),0)
) As SubTotal from  Sale Where Sale.Active = 1  And Sale.SaleDate BETWEEN'" & dt1 & "' AND '" & dt2 & "'")

        Dim sum_withDraw As DataTable = executesql("select sum(WithdrawAmount) as WithdrawAmount from WithdrawMoney where InsertDate BETWEEN '" & dt1 & "' AND '" & dt2 & "' AND Active = 1")
        Dim dtDisccount As DataTable = executesql("select sum(AmountDC) as Sum_AmountDC from Sale  where SaleDate BETWEEN  '" & dt1 & "' AND '" & dt2 & "' AND Active = 1")

        Dim Ds As New DataSale
        If dtQrThai.Rows.Count > 0 Then
            If IsDBNull(dtQrThai(0)("SubTotal")) Then
                Ds.totalQrthai = 0
            Else
                Ds.totalQrthai = dtQrThai(0)("SubTotal")
            End If
        End If
        If dtQrAlipay.Rows.Count > 0 Then
            If IsDBNull(dtQrAlipay(0)("SubTotal")) Then
                Ds.totalAlipay = 0
            Else
                Ds.totalAlipay = dtQrAlipay(0)("SubTotal")
            End If
        End If
        If dtQrWechat.Rows.Count > 0 Then
            If IsDBNull(dtQrWechat(0)("SubTotal")) Then
                Ds.totalWechat = 0
            Else
                Ds.totalWechat = dtQrWechat(0)("SubTotal")
            End If
        End If
        If dtCreditCrad.Rows.Count > 0 Then
            If IsDBNull(dtCreditCrad(0)("SubTotal")) Then
                Ds.totalCreditcard = 0
            Else
                Ds.totalCreditcard = dtCreditCrad(0)("SubTotal")
            End If
        End If

        If DataGiftCard.Rows.Count > 0 Then
            If IsDBNull(DataGiftCard(0)("SubTotal")) Then
                Ds.totalGiftcard = 0

            Else
                Ds.totalGiftcard = DataGiftCard(0)("SubTotal")
            End If
        End If
        If DataGrabFood.Rows.Count > 0 Then
            If IsDBNull(DataGrabFood(0)("SubTotal")) Then
                Ds.totalGrabfood = 0

            Else
                Ds.totalGrabfood = DataGrabFood(0)("SubTotal")
            End If
        End If
        If DataAirPay.Rows.Count > 0 Then
            If IsDBNull(DataAirPay(0)("SubTotal")) Then
                Ds.totalAirPay = 0

            Else
                Ds.totalAirPay = DataAirPay(0)("SubTotal")
            End If
        End If
        If DataLineman.Rows.Count > 0 Then
            If IsDBNull(DataLineman(0)("SubTotal")) Then
                Ds.totalLineman = 0

            Else
                Ds.totalLineman = DataLineman(0)("SubTotal")
            End If
        End If
        If DataRobinhood.Rows.Count > 0 Then
            If IsDBNull(DataRobinhood(0)("SubTotal")) Then
                Ds.totalRobinhood = 0

            Else
                Ds.totalRobinhood = DataRobinhood(0)("SubTotal")
            End If
        End If
        If DataShopee.Rows.Count > 0 Then
            If IsDBNull(DataShopee(0)("SubTotal")) Then
                Ds.TotalShopee = 0

            Else
                Ds.TotalShopee = DataShopee(0)("SubTotal")
            End If
        End If
        If DataFoodPanda.Rows.Count > 0 Then
            If IsDBNull(DataFoodPanda(0)("SubTotal")) Then
                Ds.TotalFoodPanda = 0

            Else
                Ds.TotalFoodPanda = DataFoodPanda(0)("SubTotal")
            End If
        End If
        If dtCash.Rows.Count > 0 Then
            If IsDBNull(dtCash(0)("SubTotal")) Then
                Ds.totalCash = 0
            Else
                Ds.totalCash = dtCash(0)("SubTotal")
            End If
        End If
        If sum_withDraw.Rows.Count > 0 Then
            If IsDBNull(sum_withDraw(0)("WithdrawAmount")) Then
                Ds.totalPayout = 0
            Else
                Ds.totalPayout = sum_withDraw(0)("WithdrawAmount")
            End If
        End If
        If dtDisccount.Rows.Count > 0 Then
            If IsDBNull(dtDisccount(0)("Sum_AmountDC")) Then
                Ds.totalDiscount = 0
            Else
                Ds.totalDiscount = dtDisccount(0)("Sum_AmountDC")
            End If
        End If

        Ds.Allsale = (Ds.totalAlipay + Ds.totalCash + Ds.totalCreditcard + Ds.totalGiftcard + Ds.totalGrabfood + Ds.totalQrthai + Ds.totalWechat + Ds.totalAirPay + Ds.totalLineman + Ds.totalRobinhood + Ds.TotalShopee + Ds.TotalFoodPanda)
        Ds.totalNonCash = Ds.totalAlipay + Ds.totalCreditcard + Ds.totalGiftcard + Ds.totalGrabfood + Ds.totalQrthai + Ds.totalWechat + Ds.totalAirPay + Ds.totalLineman + Ds.totalRobinhood + Ds.TotalShopee + Ds.TotalFoodPanda
        Ds.totalTax = (Ds.Allsale * 7) / 107
        Ds.finalCash = Ds.totalCash - Ds.totalPayout

        Return Ds

    End Function


End Module

Public Class DataSale
    Public Allsale As Decimal = 0
    Public totalCash As Decimal = 0
    Public totalQrthai As Decimal = 0
    Public totalAlipay As Decimal = 0
    Public totalWechat As Decimal = 0
    Public totalCreditcard As Decimal = 0
    Public totalGiftcard As Decimal = 0
    Public totalGrabfood As Decimal = 0
    Public totalDiscount As Decimal = 0
    Public totalPayout As Decimal = 0
    Public totalTax As Decimal = 0
    Public finalCash As Decimal = 0
    Public totalNonCash As Decimal = 0
    Public totalAirPay As Decimal = 0
    Public totalLineman As Decimal = 0
    Public totalRobinhood As Decimal = 0
    Public TotalShopee As Decimal = 0
    Public TotalFoodPanda As Decimal = 0
End Class
