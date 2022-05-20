Module ModulePayMent
    Dim field As String = ""
    Dim table As String = ""
    Dim Where As String = ""
    Dim join As String = ""
    Dim value As String = ""
    Dim Balance As Decimal
    Public change As Decimal
    Public voucher As String
    Public coupon As String
    Public BankId2 As Integer
    Public EdcBankId2 As Integer
    Public BankCardTypeId2 As Integer
    Public CardTypeId2 As Integer
    Public BankNumber2 As String = 0
    Public NumQ As Integer = 0
    Sub BtnAddSale()

        If Pos_payment.DataGridViewSale.Rows.Count = 0 Then
            MsgBox("กรุณากรอกจำนวนเงิน", MsgBoxStyle.Critical, "คำเตือน")
            Pos_payment.txtPayTotal.Focus()
            Exit Sub
        End If

        Dim amoutp As Decimal = Pos_payment.txtPayTotal.Text
        Dim totalp As Decimal = Pos_payment.Label3.Text
        If amoutp < totalp Then
            MsgBox("จำนวนวนเงินไม่พอชำระ", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        'Dim M1 As Decimal = Pos_payment.txtPayTotal.Text
        'Dim M2 As Decimal = POS.txtSubTotal.Text
        'If M1 < M2 Then
        '    MsgBox("จำนวนเงินไม่เพียงพอต่อราคาสินค้า", MsgBoxStyle.Critical)
        '    Pos_payment.txtPayTotal.Focus()
        '    Exit Sub
        'End If
        Dim SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim EndTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim CloseBillUserId As Integer = Frm_Login.UserId
        Dim OpenUserId As Integer = Frm_Login.UserId
        Dim CurrentUser As Integer = Frm_Login.UserId
        Dim Active As Integer = 1
        Dim IsPrintFullTax As Integer = 1
        Dim IsCloseBill As Integer = 1
        Dim SaveBillCount As Integer = 1
        Dim SubTotal As Decimal = POS.txtSubTotal.Text
        Dim Total As Decimal = POS.txtTotal.Text
        Dim Terminalid As Integer = 0
        Dim CustomerId As Integer = FrmCustomerMemberNo.CustomerId
        Dim NumOfCust As Integer = 0
        Dim TaxAmt As Decimal = 0
        Dim SaleName As String
        Dim TableId As Integer = ModuleZoneTable.TableId
        Dim AllowPrint As Integer = 0
        If TableId = 0 Then
            SaleName = "ลูกค้าเงินสดทั่วไป"
        Else
            SaleName = TableId2
        End If

        Dim checkSaleNo As DataTable = executesql("select * from sale WHERE SaleDate between CONVERT(datetime, '" & Now.ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US", True)) & "', 126)  and CONVERT(datetime, '" & Now.ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US", True)) & "', 126)")
        'Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate='" & InsertDate & "'")
        Dim No As Integer = 0
        If checkSaleNo.Rows.Count = 0 Then
            No = 1
        Else
            No = checkSaleNo.Rows.Count + 1
        End If
        NumQ = No
        Dim SaleNo As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("en-US")) & No.ToString("0000")
        Dim ABBNo As String = SaleNo
        Dim FullTaxNo As String = SaleNo
        Dim IsUsing As Integer = 1

        Dim ItemId As Integer
        Dim Qty As Decimal
        Dim InitPrice As Decimal
        Dim UnitPrice As Decimal
        Dim SubTotalItem As Decimal
        Dim TotalItem As Decimal
        Dim TaxItem As Decimal
        Dim MatAmount As Decimal

        Dim MatInitCostUseReceipe As Decimal
        Dim MatUnitCostUseReceipe As Decimal
        Dim TotalInitCostUseReceip As Decimal
        Dim TotalCostUseReceipe As Decimal
        Dim MatAmount2 As Decimal
        Dim TaxAmount As Decimal = 0
        Dim PercentDC As Decimal = 0
        Dim BahtDC As Decimal = 0
        Dim AmtDC As Decimal = 0
        Dim TotalCash As Decimal = 0
        Dim TotalCretdit As Decimal = 0
        'If Pos_DiscountPercent.DiscPer IsNot "" Then
        '    PercentDC = Pos_DiscountPercent.DiscPer
        'End If
        'If Pos_Discount.Discount_value IsNot "" Then
        '    BahtDC = Pos_Discount.Discount_value
        'End If

        Dim AmountDC As Decimal = 0
        Dim TerminalName As String = Environment.MachineName
        Dim aleardyPromotion As Boolean = False
        Dim PromotionId As Integer
        Dim ItemPromotionId As Integer
        Dim IsGetPoint As Boolean = True
        For a As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            If POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value Is Nothing Then
            Else
                aleardyPromotion = True
                PromotionId = POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value
                ItemPromotionId = POS.DataGridViewPOS.Rows(a).Cells("ItemIdPromotionId").Value
                Exit For
            End If
        Next
        'Dim checkDiscount As Boolean = False
        'For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
        '    If POS.DataGridViewPOS.Rows(i).Cells("AllowDC").Value = 1 Then
        '        checkDiscount = True
        '        Exit For
        '    End If
        'Next
        Dim checkpoint As Boolean = False
        If POS.DiscountByItem2 = 1 Then
            AmountDC = 0
        Else POS.DiscountByItem2 = 2
            AmountDC = POS.txtDiscount.Text
        End If

        'Exit Sub
        '''''''''''''''' * New sale * '''''''''''''''''
        If GetSaleId = 0 Then
            executesql("INSERT INTO Sale(SaleDate,SaleNo,SubTotal,TaxAmt,Total,ABBNo,FullTaxNo,IsPrintFullTax,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,StartTime,EndTime,TerminalId,TerminalName,AmountDC) VALUES('" & SaleDate & "','" & SaleNo & "','" & SubTotal & "','" & TaxAmt & "','" & Total & "','" & ABBNo & "','" & FullTaxNo & "','" & IsPrintFullTax & "','" & InsertDate & "','" & CloseBillUserId & "','" & IsCloseBill & "','" & Active & "','" & SaveBillCount & "','" & CustomerId & "','" & NumOfCust & "','" & StartTime & "','" & EndTime & "','" & Terminalid & "','" & TerminalName & "','" & AmountDC & "')")

            Dim selectSaleId As DataTable = executesql("SELECT Max(SaleId) As SaleId FROM Sale")
            'Insert SaleItem
            For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
                ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
                Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value

                Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
                Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName,AllowPrint FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")

                If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                    BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                    PercentDC = 0
                ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                    PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                    BahtDC = 0
                End If
                If Printer_cate(0)("AllowPrint") = 0 Then
                    AllowPrint = 2
                ElseIf Printer_cate(0)("AllowPrint") = 1 Then
                    AllowPrint = 0
                End If
                TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
                'InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                'UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                InitPrice = FormatNumber((POS.DataGridViewPOS.Rows(i).Cells(2).Value - TaxItem), 2)
                UnitPrice = FormatNumber(POS.DataGridViewPOS.Rows(i).Cells(2).Value, 2)
                TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                'TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmt += TaxAmount
                'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                'If POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',1,0,'" & Printer_cate(0)("CatePrinterName") & "')")
                'Insert UseReceipeItem
                Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                If IsNothing(SelectReceipe) Then
                    'DisStock
                    If SelectDataItem(0)("IsTrackStock") = 1 Then
                        MatAmount = Qty
                        executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                    ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                        MatAmount = Qty
                        'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                    End If
                ElseIf SelectReceipe.Rows.Count = 0 Then
                    'DisStock
                    If SelectDataItem(0)("IsTrackStock") = 1 Then
                        MatAmount = Qty
                        executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                    ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                        MatAmount = Qty
                        'MsgBox(SelectDataItem(i)("ItemCode"))
                        'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                    End If
                Else
                    For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                        MatAmount2 = SelectReceipe(j)("Qty")
                        MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                        MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                        TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                        TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                        executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                        executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & SelectReceipe(j)("MatId") & "'")
                    Next
                End If
                'Insert Topping
                'Dim ToppingName As String =

                If POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 Then
                    Dim ToppingName As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split("*".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    For a As Integer = 0 To ToppingName.Length - 1
                        Dim selectTopping As DataTable = executesql("SELECT Topping.ToppingId,Topping.Pricing,Topping.ToppingName,ToppingReceipe.* FROM Topping INNER JOIN ToppingReceipe ON(Topping.ToppingId = ToppingReceipe.ToppingId) WHERE Topping.ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                        Dim ToppingData As DataTable = executesql("SELECT ToppingId,ToppingName,Pricing FROM Topping WHERE ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                        If selectTopping.Rows.Count > 0 Then
                            For r As Integer = 0 To selectTopping.Rows.Count - 1

                                'UseTopping
                                'UseReceipeTopping
                                'executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & selectTopping(0)("MatIdTopping") & "','" & selectTopping(0)("Qty") & "','" & selectTopping(0)("MatinitCost") & "','" & selectTopping(0)("MatUnitCost") & "','" & selectTopping(0)("TotalInitCost") & "','" & selectTopping(0)("TotalCost") & "','" & InsertDate & "')")

                                executesql("INSERT INTO UseReceipeTopping(ToppingReceipeId,ToppingId,MatIdTopping,MatName,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost) VALUES('" & selectTopping(r)("ToppingReceipeId") & "','" & selectTopping(r)("ToppingId") & "','" & selectTopping(r)("MatIdTopping") & "','" & selectTopping(r)("MatName") & "','" & selectTopping(r)("Qty") & "','" & selectTopping(r)("MatInitCost") & "','" & selectTopping(r)("MatUnitCost") & "','" & selectTopping(r)("TotalInitCost") & "','" & selectTopping(r)("TotalCost") & "')")

                                Dim selectItemCode As DataTable = executesql("SELECT Item.ItemCode From ToppingReceipe INNER JOIN Item ON(Item.ItemName = ToppingReceipe.MatName) WHERE ToppingReceipe.MatName = '" & selectTopping(r)("MatName") & "'")
                                Dim q As Decimal = selectTopping(r)("Qty")
                                Dim tItemid As Integer = selectTopping(r)("MatIdTopping")
                                executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")


                            Next

                        End If
                        If ToppingData.Rows.Count > 0 Then
                            executesql("INSERT INTO UseTopping(ToppingId,SaleItemId,ToppingName,InsertDate) VALUES('" & ToppingData(0)("ToppingId") & "','" & SaleItemId & "','" & ToppingData(0)("ToppingName") & "','" & InsertDate & "')")
                        End If
                        If ToppingData.Rows.Count > 0 Then
                            'Clipboard.SetText("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                            executesql("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                            Dim selectSubTotal As DataTable = executesql("select SaleId,SubTotal from SaleItem where SaleItemId='" & SaleItemId & "'")
                            Dim TaxTopping As Decimal = ((ToppingData(0)("Pricing") * Qty) - ((ToppingData(0)("Pricing") * Qty) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                            Dim UpdateSubTotal As Decimal = (selectSubTotal(0)("SubTotal") - (selectSubTotal(0)("SubTotal") * 100 / (SelectDataItem(0)("Multiply") + 100)))
                            executesql("update SaleItem set Tax='" & UpdateSubTotal & "' where SaleItemId='" & SaleItemId & "'")
                            TaxAmt += TaxTopping
                        End If
                    Next
                End If
                If POS.DataGridViewPOS.Rows(i).Cells("Selection").Value IsNot Nothing Then
                    'Insert Selection 
                    Dim Selection As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split("#".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    For g As Integer = 1 To Selection.Length - 1
                        Dim selectSelection As DataTable = executesql("SELECT * FROM Selection WHERE SelectionName='" & Selection(g).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                        Dim selectionId2 As Integer = POS.DataGridViewPOS.Rows(i).Cells(9).Value
                        If selectSelection.Rows.Count = 0 Then
                            selectionId2 = 0
                        Else
                            selectionId2 = selectSelection(0)("SelectionId")
                            executesql("INSERT INTO UseSelection(SelectionId,SaleItemId,SelectionName) VALUES('" & selectionId2 & "','" & SaleItemId & "','" & selectSelection(0)("SelectionName") & "')")
                        End If
                    Next
                End If

                'End If
                'Point Promotion
                If FrmCustomerMemberNo.customerMemNo <> 0 Then

                    '                    Clipboard.SetText("Select GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.GetFree,GiftValue.Point From PromotionItem 
                    'inner join Promotion on(Promotion.ProId = PromotionItem.PromotionId)
                    'inner join ConditionPromotion on(ConditionPromotion.ConId = Promotion.ConditionId)
                    'inner join GiftValue on(GiftValue.GiftId = ConditionPromotion.GiftId)
                    'Where PromotionItem.ItemId='" & ItemId & "' And PromotionItem.Active ='1'")
                    Dim selectcheckPoint As DataTable = executesql("Select GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.GetFree,GiftValue.Point From PromotionItem inner join Promotion on(Promotion.ProId = PromotionItem.PromotionId) inner join ConditionPromotion on(ConditionPromotion.ConId = Promotion.ConditionId) inner join GiftValue on(GiftValue.GiftId = ConditionPromotion.GiftId) Where PromotionItem.ItemId='" & ItemId & "' And PromotionItem.Active ='1'")

                    Dim selectPointCustomer As DataTable = executesql("SELECT Point FROM Customer WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                    If IsDBNull(selectPointCustomer(0)("Point")) Then
                        executesql("UPDATE Customer Set Point='0' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                    End If
                    If Not IsNothing(selectcheckPoint) And selectcheckPoint.Rows.Count > 0 Then
                        If selectcheckPoint(0)("DiscountPer") = 0 And selectcheckPoint(0)("DiscountB") = 0 Then
                            If Not IsDBNull(selectcheckPoint(0)("Point")) Then
                                If IsGetPoint = True Then
                                    executesql("UPDATE Customer Set Point +='" & selectcheckPoint(0)("Point") & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                                    IsGetPoint = False
                                End If
                            End If
                        End If
                    End If
                    Dim DatePointEnd As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
                    Dim selectPointRate As DataTable = executesql("Select PointRate.* From PointRate inner join ItemPoint on(PointRate.PointRateId = ItemPoint.PointRateId) Where ItemPoint.ItemId = '" & ItemId & "' And ItemPoint.Active='1'")
                    If Not IsNothing(selectPointRate) And selectPointRate.Rows.Count > 0 Then
                        Dim dates As DateTime = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
                        Dim dateStart As DateTime = Convert.ToDateTime(selectPointRate(0)("DateStart") & " " & selectPointRate(0)("TimeStart")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
                        Dim dateEnd As DateTime = Convert.ToDateTime(selectPointRate(0)("DateEnd") & " " & selectPointRate(0)("TimeEnd")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
                        If dateEnd >= dates Then
                            If selectPointRate(0)("TotalAmount") <> 0 Then
                                If selectPointRate(0)("TotalAmount") >= Qty Then

                                    executesql("UPDATE Customer Set Point +='" & selectPointRate(0)("PointRate") & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                                End If
                            ElseIf selectPointRate(0)("TotalPrice") <> 0 Then
                                If selectPointRate(0)("TotalPrice") >= SubTotal Then
                                    executesql("UPDATE Customer Set Point +='" & selectPointRate(0)("PointRate") & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            executesql("UPDATE Sale SET TaxAmt='" & TaxAmt & "' WHERE SaleId='" & selectSaleId(0)("SaleId") & "'")

            Dim PaidAmount As Decimal = Pos_payment.Label3.Text
            Dim Rate As Decimal = 0
            Dim CC_Type As String = ""
            Dim CC_Number As String = ""
            Dim RefNumber As String = ""
            Dim paymentTypeCode As String = ""



            executesql("INSERT INTO SalePayment(SaleId,PaymentCode,PaidAmount,Rate,InsertDate,RefNumber,CC_Type,CC_Number) VALUES('" & selectSaleId(0)("SaleId") & "','" & paymentTypeCode & "','" & PaidAmount & "','" & Rate & "','" & InsertDate & "','" & RefNumber & "','" & CC_Type & "','" & CC_Number & "')")

            Dim BankId As Integer
            Dim EdcBankId As Integer = 0
            Dim BankCardTypeId As Integer
            Dim CardTypeId As Integer
            Dim PaidAmount2 As Decimal = 0
            Dim CouponNumber As String
            Dim VoucherNumber As String
            Dim BankNumber As String

            Dim selectSalePaymentId As DataTable = executesql("SELECT SalePaymentId FROM SalePayment WHERE SaleId=" & selectSaleId(0)("SaleId") & "")

            For i As Integer = 0 To Pos_payment.DataGridViewSale.RowCount - 1
                Dim selectPayMentType As DataTable = executesql("SELECT PaymentId FROM PaymentType WHERE PaymentName='" & Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value & "'")
                If Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "เงินสด" Then
                    BankId = 0
                    EdcBankId = 0
                    BankCardTypeId = 0
                    CardTypeId = 0
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    TotalCash = PaidAmount2
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = 0
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")

                    open_cash.OpenCashdrawer()


                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "บัตรเครดิต" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    TotalCretdit += Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "บัตรเงินสด" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "คูปอง" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "Voucher" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                Else
                    BankId = 0
                    EdcBankId = 0
                    BankCardTypeId = 0
                    CardTypeId = 0
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    TotalCash = PaidAmount2
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = 0
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                End If
            Next
            Dim selectPaidAmount As DataTable = executesql("SELECT Sum(PaidAmount) AS PaidAmount FROM PaymentDetail WHERE SaleId=" & selectSaleId(0)("SaleId") & "")
            Balance = selectPaidAmount(0)("PaidAmount")

            'Promotion
            If aleardyPromotion = True Then
                executesql("INSERT INTO UsePromotion(SaleId,SaleNo,PromotionId,ItemPromotionId,InsertDate) VALUES('" & selectSaleId(0)("SaleId") & "','" & SaleNo & "','" & PromotionId & "','" & ItemPromotionId & "','" & InsertDate & "')")
            End If


            change = TotalCash - (POS.txtSubTotal.Text - TotalCretdit)
            GetSaleId = selectSaleId(0)("SaleId")
            executesql("UPDATE VoucherHistory SET SaleId='" & GetSaleId & "' WHERE VoucherHistoryId=(SELECT MAX(VoucherHistoryId) FROM VoucherHistory)")
            Pos_payment.Close()

        Else '''''''''''''''' * Old sale * '''''''''''''''''

            executesql("UPDATE Sale SET Active='" & Active & "' WHERE SaleId=" & GetSaleId & "")

            Dim checkSaleNo2 As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleId=" & GetSaleId & "")

            SaleNo = checkSaleNo2(0)("SaleNo")

            executesql("UPDATE Sale SET SaleDate='" & SaleDate & "',IsPrintFullTax='" & IsPrintFullTax & "',CloseBillUserId='" & CloseBillUserId & "',IsCloseBill='" & IsCloseBill & "',SaveBillCount='" & SaveBillCount & "',NumOfCust='" & NumOfCust & "',EndTime='" & EndTime & "',TerminalId='" & Terminalid & "',TerminalName='" & TerminalName & "',AmountDC='" & AmountDC & "',Active=" & Active & ",ABBNo='" & SaleNo & "',FullTaxNo='" & SaleNo & "' WHERE SaleId=" & GetSaleId & "")

            For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
                ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
                Dim SaleItemId2 = POS.DataGridViewPOS.Rows(i).Cells("SaleItemId").Value
                Dim checkSaleItem As DataTable = executesql("SELECT ItemId FROM SaleItem WHERE SaleId=" & GetSaleId & " AND ItemId='" & ItemId & "' AND SaleItemId = '" & SaleItemId2 & "'")

                Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value
                Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
                Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName,AllowPrint FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")
                If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                    If checkSaleItem.Rows.Count = 0 Then
                        If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                            BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            PercentDC = 0
                        ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                            PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            BahtDC = 0
                        End If
                        If Printer_cate(0)("AllowPrint") = 0 Then
                            AllowPrint = 2
                        ElseIf Printer_cate(0)("AllowPrint") = 1 Then
                            AllowPrint = 0
                        End If
                        TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
                        'InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                        'UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                        InitPrice = FormatNumber((POS.DataGridViewPOS.Rows(i).Cells(2).Value - TaxItem), 2)
                        UnitPrice = FormatNumber(POS.DataGridViewPOS.Rows(i).Cells(2).Value, 2)
                        TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                        SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                        TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                        TaxAmt += TaxAmount
                        executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName) VALUES('" & GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',1," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "')")
                        'Insert UseReceipeItem
                        Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                        Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                        Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                        If IsNothing(SelectReceipe) Then
                            'DisStock
                            If SelectDataItem(0)("IsTrackStock") = 1 Then
                                MatAmount = Qty
                                executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                            ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                MatAmount = Qty
                                'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                            End If
                        ElseIf SelectReceipe.Rows.Count = 0 Then
                            'DisStock
                            If SelectDataItem(0)("IsTrackStock") = 1 Then
                                MatAmount = Qty
                                executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                            ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                MatAmount = Qty
                                'MsgBox(SelectDataItem(i)("ItemCode"))
                                'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemCode='" & SelectDataItem(i)("ItemCode") & "'")
                            End If
                        Else
                            For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                                MatAmount2 = SelectReceipe(j)("Qty")
                                MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                                MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                                TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                                TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                                executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                                executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & ItemId & "'")
                            Next
                        End If

                        If POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 Then
                            Dim ToppingName As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            For a As Integer = 0 To ToppingName.Length - 1
                                Dim selectTopping As DataTable = executesql("SELECT Topping.ToppingId,Topping.Pricing,Topping.ToppingName,ToppingReceipe.* FROM Topping INNER JOIN ToppingReceipe ON(Topping.ToppingId = ToppingReceipe.ToppingId) WHERE Topping.ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                                Dim ToppingData As DataTable = executesql("SELECT ToppingId,ToppingName,Pricing FROM Topping WHERE ToppingName='" & ToppingName(a).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                                If selectTopping.Rows.Count > 0 Then
                                    For r As Integer = 0 To selectTopping.Rows.Count - 1

                                        'UseTopping
                                        'UseReceipeTopping
                                        'executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & selectTopping(0)("MatIdTopping") & "','" & selectTopping(0)("Qty") & "','" & selectTopping(0)("MatinitCost") & "','" & selectTopping(0)("MatUnitCost") & "','" & selectTopping(0)("TotalInitCost") & "','" & selectTopping(0)("TotalCost") & "','" & InsertDate & "')")

                                        executesql("INSERT INTO UseReceipeTopping(ToppingReceipeId,ToppingId,MatIdTopping,MatName,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost) VALUES('" & selectTopping(r)("ToppingReceipeId") & "','" & selectTopping(r)("ToppingId") & "','" & selectTopping(r)("MatIdTopping") & "','" & selectTopping(r)("MatName") & "','" & selectTopping(r)("Qty") & "','" & selectTopping(r)("MatInitCost") & "','" & selectTopping(r)("MatUnitCost") & "','" & selectTopping(r)("TotalInitCost") & "','" & selectTopping(r)("TotalCost") & "')")

                                        Dim selectItemCode As DataTable = executesql("SELECT Item.ItemCode From ToppingReceipe INNER JOIN Item ON(Item.ItemName = ToppingReceipe.MatName) WHERE ToppingReceipe.MatName = '" & selectTopping(r)("MatName") & "'")
                                        Dim q As Decimal = selectTopping(r)("Qty")
                                        Dim tItemid As Integer = selectTopping(r)("MatIdTopping")
                                        executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")


                                    Next

                                End If
                                If ToppingData.Rows.Count > 0 Then
                                    executesql("INSERT INTO UseTopping(ToppingId,SaleItemId,ToppingName,InsertDate) VALUES('" & ToppingData(0)("ToppingId") & "','" & SaleItemId & "','" & ToppingData(0)("ToppingName") & "','" & InsertDate & "')")
                                End If
                                If ToppingData.Rows.Count > 0 Then
                                    executesql("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                                    Dim selectSubTotal As DataTable = executesql("select SaleId,SubTotal from SaleItem where SaleItemId='" & SaleItemId & "'")
                                    Dim TaxTopping As Decimal = ((ToppingData(0)("Pricing") * Qty) - ((ToppingData(0)("Pricing") * Qty) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                    Dim UpdateSubTotal As Decimal = (selectSubTotal(0)("SubTotal") - (selectSubTotal(0)("SubTotal") * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                    executesql("update SaleItem set Tax='" & UpdateSubTotal & "' where SaleItemId='" & SaleItemId & "'")
                                    TaxAmt += TaxTopping
                                End If
                            Next
                        End If

                        If POS.DataGridViewPOS.Rows(i).Cells("Selection").Value IsNot Nothing Then
                            'Insert Selection 
                            Dim Selection As String() = POS.DataGridViewPOS.Rows(i).Cells(0).Value.Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            For g As Integer = 1 To Selection.Length - 1
                                Dim selectSelection As DataTable = executesql("SELECT * FROM Selection WHERE SelectionName='" & Selection(g).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                                Dim selectionId2 As Integer = POS.DataGridViewPOS.Rows(i).Cells(9).Value
                                If selectSelection.Rows.Count = 0 Then
                                    selectionId2 = 0
                                Else
                                    selectionId2 = selectSelection(0)("SelectionId")
                                    executesql("INSERT INTO UseSelection(SelectionId,SaleItemId,SelectionName) VALUES('" & selectionId2 & "','" & SaleItemId & "','" & selectSelection(0)("SelectionName") & "')")
                                End If
                            Next
                        End If
                    End If
                    'Point Promotion
                    If FrmCustomerMemberNo.customerMemNo <> 0 Then
                        Dim selectcheckPoint As DataTable = executesql("Select GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.GetFree,GiftValue.Point From PromotionItem 
                    inner join Promotion on(Promotion.ProId = PromotionItem.PromotionId)
                    inner join ConditionPromotion on(ConditionPromotion.ConId = Promotion.ConditionId)
                    inner join GiftValue on(GiftValue.GiftId = ConditionPromotion.GiftId)
                    Where PromotionItem.ItemId='" & ItemId & "' And PromotionItem.Active ='1'")
                        Dim selectPointCustomer As DataTable = executesql("SELECT Point FROM Customer WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                        If IsDBNull(selectPointCustomer(0)("Point")) Then
                            executesql("UPDATE Customer Set Point='0' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                        End If
                        If Not IsNothing(selectcheckPoint) And selectcheckPoint.Rows.Count > 0 Then
                            If selectcheckPoint(0)("DiscountPer") = 0 And selectcheckPoint(0)("DiscountB") = 0 Then
                                If Not IsDBNull(selectcheckPoint(0)("Point")) Then
                                    If IsGetPoint = True Then
                                        executesql("UPDATE Customer Set Point +='" & selectcheckPoint(0)("Point") & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                                        IsGetPoint = False
                                    End If
                                End If
                            End If
                        End If
                        Dim DatePointEnd As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-EN"))
                        Dim selectPointRate As DataTable = executesql("Select PointRate.* From PointRate inner join ItemPoint on(PointRate.PointRateId = ItemPoint.PointRateId) Where ItemPoint.ItemId = '" & ItemId & "' And ItemPoint.Active='1'")
                        If Not IsNothing(selectPointRate) And selectPointRate.Rows.Count > 0 Then
                            Dim dates As DateTime = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
                            Dim dateStart As DateTime = Convert.ToDateTime(selectPointRate(0)("DateStart") & " " & selectPointRate(0)("TimeStart")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
                            Dim dateEnd As DateTime = Convert.ToDateTime(selectPointRate(0)("DateEnd") & " " & selectPointRate(0)("TimeEnd")).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
                            If dateEnd >= dates Then
                                If selectPointRate(0)("TotalAmount") <> 0 Then
                                    If selectPointRate(0)("TotalAmount") >= Qty Then

                                        executesql("UPDATE Customer Set Point +='" & selectPointRate(0)("PointRate") & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                                    End If
                                ElseIf selectPointRate(0)("TotalPrice") <> 0 Then
                                    If selectPointRate(0)("TotalPrice") >= SubTotal Then
                                        executesql("UPDATE Customer Set Point +='" & selectPointRate(0)("PointRate") & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                                    End If
                                End If
                            End If
                        End If
                    Else

                        If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                            BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            PercentDC = 0
                        ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                            PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                            BahtDC = 0
                        End If

                        TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
                        'InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                        'UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                        InitPrice = FormatNumber((POS.DataGridViewPOS.Rows(i).Cells(2).Value - TaxItem), 2)
                        UnitPrice = FormatNumber(POS.DataGridViewPOS.Rows(i).Cells(2).Value, 2)
                        TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                        SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                        TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                        TaxAmt += TaxAmount
                        Dim SaleItemId As Integer = POS.DataGridViewPOS.Rows(i).Cells(6).Value
                        executesql("UPDATE SaleItem SET InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxAmount & "',Total='" & TotalItem & "',PercentDC='" & PercentDC & "',BahtDC='" & BahtDC & "',AmtDC='" & AmtDC & "',TerminalName='" & TerminalName & "',Active='" & Active & "' WHERE saleId=" & GetSaleId & " and ItemId = '" & ItemId & "' and SaleItemId=" & SaleItemId & "")
                    End If

                End If
            Next

            executesql("UPDATE Sale SET TaxAmt='" & TaxAmt & "',SubTotal='" & SubTotal & "',Total='" & Total & "' WHERE SaleId='" & GetSaleId & "'")

            Dim PaidAmount As Decimal = Pos_payment.Label3.Text
            Dim Rate As Decimal = 0
            Dim CC_Type As String = ""
            Dim CC_Number As String = ""
            Dim RefNumber As String = ""
            Dim paymentTypeCode As String = ""


            executesql("INSERT INTO SalePayment(SaleId,PaymentCode,PaidAmount,Rate,InsertDate,RefNumber,CC_Type,CC_Number) VALUES('" & GetSaleId & "','" & paymentTypeCode & "','" & PaidAmount & "','" & Rate & "','" & InsertDate & "','" & RefNumber & "','" & CC_Type & "','" & CC_Number & "')")

            Dim BankId As Integer
            Dim EdcBankId As Integer = 0
            Dim BankCardTypeId As Integer
            Dim CardTypeId As Integer
            Dim PaidAmount2 As Decimal = 0
            Dim CouponNumber As String
            Dim VoucherNumber As String
            Dim BankNumber As String

            Dim selectSalePaymentId As DataTable = executesql("SELECT SalePaymentId FROM SalePayment WHERE SaleId=" & GetSaleId & "")

            For i As Integer = 0 To Pos_payment.DataGridViewSale.RowCount - 1
                Dim selectPayMentType As DataTable = executesql("SELECT PaymentId FROM PaymentType WHERE PaymentName='" & Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value & "'")
                If Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "เงินสด" Then
                    BankId = 0
                    EdcBankId = 0
                    BankCardTypeId = 0
                    CardTypeId = 0
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    TotalCash = PaidAmount2
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = 0
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & GetSaleId & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")

                    open_cash.OpenCashdrawer()


                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "บัตรเครดิต" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    TotalCash += Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & GetSaleId & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "บัตรเงินสด" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & GetSaleId & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "คูปอง" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & GetSaleId & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                ElseIf Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "Voucher" Then
                    BankId = BankId2
                    EdcBankId = 0
                    BankCardTypeId = BankCardTypeId2
                    CardTypeId = CardTypeId2
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = BankNumber2
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & GetSaleId & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                Else
                    BankId = 0
                    EdcBankId = 0
                    BankCardTypeId = 0
                    CardTypeId = 0
                    PaidAmount2 = Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value
                    TotalCash = PaidAmount2
                    CouponNumber = coupon
                    VoucherNumber = voucher
                    BankNumber = 0
                    executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & GetSaleId & "','" & selectPayMentType(0)("PaymentId") & "','" & BankId & "','" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & PaidAmount2 & "','" & CouponNumber & "','" & VoucherNumber & "','" & BankNumber & "')")
                End If
            Next

            'Promotion
            If aleardyPromotion = True Then
                executesql("UPDATE UsePromotion SET SaleNo = '" & SaleNo & "' WHERE SaleId=" & GetSaleId & "")
            End If
            Dim selectPaidAmount As DataTable = executesql("SELECT Sum(PaidAmount) AS PaidAmount FROM PaymentDetail WHERE SaleId=" & GetSaleId & "")
            Balance = selectPaidAmount(0)("PaidAmount")
            change = TotalCash - (POS.txtSubTotal.Text - TotalCretdit)

            'If TableId <> 0 Then

            '    Dim checkSplitBill As DataTable = executesql("SELECT Sale.SaleId FROM Sale 
            '            INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
            '            INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
            '            INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
            '            INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
            '            WHERE SaleTabRef.TableId in(" & TableId & ") AND Sale.Active=3 AND SaleItem.Active=3 
            '            GROUP BY Sale.SaleId")
            '    If checkSplitBill.Rows.Count > 0 Then

            '        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE TableId='" & ModuleZoneTable.TableId & "'")
            '        If IsDBNull(LoadDatatable(0)("IsGroupTable")) Then
            '            executesql("update Tables set StateStatus= 0 where TableId='" & ModuleZoneTable.TableId & "'")
            '        Else
            '            If LoadDatatable(0)("IsGroupTable") = 0 Then
            '                executesql("update Tables set StateStatus= 0 where TableId='" & ModuleZoneTable.TableId & "'")
            '            Else
            '                executesql("update Tables set StateStatus= 0,IsGroupTable = 0, IsSplitBill = 0 ,TableName2= NULL, TableId2 = NULL where TableId in(" & LoadDatatable(0)("TableId2") & ")")
            '            End If
            '        End If
            '    Else
            '        executesql("update Tables set StateStatus= 0 where TableId='" & ModuleZoneTable.TableId & "'")
            '    End If
            '    Main2.TabControlMain.SelectedTabPageIndex = 1
            '    ModuleZoneTable.LoadZone()
            '    ModuleZoneTable.First_LoadTable()

            'Else
            '    Main2.TabControlMain.SelectedTabPageIndex = 0

            'End If
            'Pos_payment.Close()
        End If

        If TableId = 0 Then
            'INSERT QUE
            executesql("INSERT INTO Que(SaleNo,DatetimeSale,Status) VALUES('" & SaleNo & "','" & InsertDate & "','0')")
            Pos_payment.Close()
            writeLog("User ID " + Frm_Login.UserId.ToString + " Add saleNo :" + SaleNo.ToString)

            ModulePrintPosSlip.PrintSlip(GetSaleId)

            If My.Settings.PrintOrder Then
                ModulePrinrOrder.PrinteOrder(GetSaleId)
            End If

            Pos_payment.DataGridViewSale.Rows.Clear()
            ClearDataPayMent()
            calBalance()
            TB_GetSaleId = 0
            GetSaleId = 0
            TableName = ""
            'customer
            FrmCustomerMemberNo.CustomerId = 0
            POS.BtnPoint.Enabled = False
            POS.PanelMember.Visible = False
            POS.LabelMemberName.Text = ""
            FrmCustomerMemberNo.customerMemNo = 0
        Else
            Console.WriteLine("' ปิดโต๊ะ " & "GetSaleId =" & GetSaleId & "TableId =" & TableId)
            If POS.DataGridViewPOS.RowCount = 0 Then
                'INSERT QUE
                executesql("INSERT INTO Que(SaleNo,DatetimeSale,Status) VALUES('" & SaleNo & "','" & InsertDate & "','0')")
                Pos_payment.Close()
                writeLog("User ID " + Frm_Login.UserId.ToString + " Add saleNo :" + SaleNo.ToString)

                ModulePrintPosSlip.PrintSlip(GetSaleId)

                Pos_payment.DataGridViewSale.Rows.Clear()
                ClearDataPayMent()
                calBalance()

                'customer
                FrmCustomerMemberNo.CustomerId = 0
                POS.BtnPoint.Enabled = False
                POS.PanelMember.Visible = False
                POS.LabelMemberName.Text = ""
                FrmCustomerMemberNo.customerMemNo = 0

                ModulePosTable.CancelBill()
                TB_GetSaleId = 0
                GetSaleId = 0
                TableName = ""
            Else
                'INSERT QUE
                executesql("INSERT INTO Que(SaleNo,DatetimeSale,Status) VALUES('" & SaleNo & "','" & InsertDate & "','0')")
                Pos_payment.Close()
                writeLog("User ID " + Frm_Login.UserId.ToString + " Add saleNo :" + SaleNo.ToString)
                ModulePrintPosSlip.PrintSlip(GetSaleId)
                ModulePrinrOrder.PrinteOrder(GetSaleId)

                Pos_payment.DataGridViewSale.Rows.Clear()
                ClearDataPayMent()
                calBalance()

                'customer
                FrmCustomerMemberNo.CustomerId = 0
                POS.BtnPoint.Enabled = False
                POS.PanelMember.Visible = False
                POS.LabelMemberName.Text = ""
                FrmCustomerMemberNo.customerMemNo = 0

                Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE TableId='" & TableId & "'")

                If LoadDatatable.Rows.Count = 0 Then
                    ModulePosTable.CancelBill()
                    executesql("UPDATE Tables SET StateStatus= 0,IsGroupTable = 0, IsSplitBill = 0 ,TableName2= '', TableId2 = 0 WHERE TableId='" & TableId & "'")
                Else
                    ModulePosTable.CancelBill()
                    executesql("UPDATE Tables SET StateStatus= 0,IsGroupTable = 0, IsSplitBill = 0 ,TableName2= '', TableId2 = 0 WHERE TableId2='" & TableId & "'")
                End If
                TB_GetSaleId = 0
                GetSaleId = 0
                TableName = ""
                ModuleZoneTable.LoadZone()
                Dim MinZone As DataTable = executesql("select min(ZoneId) as ZoneId ,ZoneName from Zones where Active=1 GROUP BY ZoneName")
                If MinZone.Rows.Count = 0 Then Exit Sub
                ModuleZoneTable.LoadTable(MinZone(0)("ZoneId"))
                FrmTable.LbZoneSelect.Text = MinZone(0)("ZoneName")
                FrmTable.LbTableSelect.Text = ""
                ZoneId = MinZone(0)("ZoneId")
            End If
        End If


        ''INSERT QUE
        'executesql("INSERT INTO Que(SaleNo,DatetimeSale,Status) VALUES('" & SaleNo & "','" & InsertDate & "','0')")
        'Pos_payment.Close()

        'writeLog("User ID " + Frm_Login.UserId.ToString + " Add saleNo :" + SaleNo.ToString)

        ''CamLog.CamCapture(SaleNo)

        'ModulePrintPosSlip.PrintSlip(GetSaleId)

        'ModulePrinrOrder.PrinteOrder(GetSaleId)

        'Pos_payment.DataGridViewSale.Rows.Clear()
        'ClearDataPayMent()
        'calBalance()

        'TB_GetSaleId = 0
        'GetSaleId = 0
        'TableName = ""
        ''customer
        'FrmCustomerMemberNo.CustomerId = 0
        'POS.BtnPoint.Enabled = False
        'POS.PanelMember.Visible = False
        'POS.LabelMemberName.Text = ""
        'FrmCustomerMemberNo.customerMemNo = 0
        If change <> 0 Then

            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Pos_Change.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.9
                plexi.Show()
                Pos_Change.StartPosition = FormStartPosition.CenterParent
                Pos_Change.ShowDialog(plexi)
            End Using
            Exit Sub
        End If
        'cam.Dispose()
    End Sub
    Sub calBalance()
        Dim amount As Decimal = Pos_payment.Label3.Text - Balance
        Pos_payment.Label3.Text = FormatNumber(amount, 2)
    End Sub
    Sub ClearDataPayMent()
        Pos_payment.txtPayTotal.Text = "0.00"
        FrmCustomerMemberNo.customerMemNo = 0
        POS.DataGridViewPOS.Rows.Clear()
        POS.txtDiscount.Text = "0.00"
        POS.txtTotal.Text = "0.00"
        POS.txtSubTotal.Text = "0.00"
        'GetSaleId = 0
        'TableId = 0
        'customer
        FrmCustomerMemberNo.CustomerId = 0
        POS.BtnPoint.Enabled = False
        POS.PanelMember.Visible = False
    End Sub
    Sub saveDataToDataGridView()
        'Pos_payment.DataGridViewSale.Rows.Clear()
        Dim selectsale As DataTable = executesql("SELECT PaymentDetail.SaleId,PaymentDetail.PaidAmount,PaymentType.PaymentName FROM PaymentDetail INNER JOIN PaymentType ON (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) WHERE PaymentDetail.SaleId=" & GetSaleId & "")
        If selectsale.Rows.Count > 0 Then
            For i As Integer = 0 To selectsale.Rows.Count - 1
                Pos_payment.DataGridViewSale.Rows.Add(selectsale(i)("PaymentName"), FormatNumber(selectsale(i)("PaidAmount"), 2), selectsale(i)("SaleId"))
            Next
        End If
    End Sub
    Sub AddPaymentToDG()
        'Pos_payment.PaymentType = "เงินสด"
        'Pos_payment.DataGridViewSale.Rows.Clear()
        Dim checkExists As Boolean = False
        Dim a As Integer
        For i As Integer = 0 To Pos_payment.DataGridViewSale.RowCount - 1
            If Pos_payment.PaymentType = Pos_payment.DataGridViewSale.Rows(i).Cells("Pay_detail").Value Then
                checkExists = True
                a = i
                Exit For
            End If
        Next
        If checkExists = True Then
            Pos_payment.DataGridViewSale.Rows(a).Cells(1).Value += Pos_payment.AmountPaid
        Else
            Pos_payment.DataGridViewSale.Rows.Add("เงินสด", FormatNumber(Pos_payment.AmountPaid, 2))
        End If
    End Sub
    Sub AddPaymentToDGCreditCard()
        'Pos_payment.DataGridViewSale.Rows.Clear()
        If Pos_Payment_CreditCard.RadDropDownBankType.Text = "ธนาคาร" Then
            BankId2 = 0
        Else
            Dim BankCardType As DataTable = executesql("SELECT * FROM BankCardType WHERE BankCardTypeName ='" & Pos_Payment_CreditCard.RadDropDownCardType.Text & "'")
            BankCardTypeId2 = BankCardType(0)("BankCardTypeId")
            Dim Bank As DataTable = executesql("SELECT * FROM Bank WHERE BankName ='" & Pos_Payment_CreditCard.RadDropDownBankType.Text & "'")
            BankId2 = Bank(0)("BankId")
        End If
        BankNumber2 = Pos_Payment_CreditCard.txtCardNumber.Text
        Pos_payment.DataGridViewSale.Rows.Add("บัตรเครดิต", FormatNumber(Pos_payment.AmountPaid, 2))

    End Sub
    Sub checkVoucher()
        Dim checkVoucher As DataTable = executesql("SELECT VoucherId,VoucherPrice,VoucherBalance,ExpDate FROM Voucher WHERE VoucherNumber='" & Pos_Payment_Voucher.txtVoucherNumber.Text & "' AND StatusId = 1")
        If checkVoucher.Rows.Count = 0 Then
            MsgBox("เลข Voucher ไม่ถูกต้อง !", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Dim dateNow As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm", New System.Globalization.CultureInfo("en-US"))
            'MsgBox(checkVoucher(0)("ExpDate"))
            If checkVoucher(0)("VoucherBalance") <= 0 Then
                MsgBox("ยอดเงินคงเหลือไม่เพียงพอ คงเหลือ : " & checkVoucher(0)("VoucherBalance") & " บาท")
                Exit Sub
            End If
            If dateNow > checkVoucher(0)("ExpDate") Then
                MsgBox("หมดอายุ")
                Exit Sub
            Else
                Dim totalPrice As Decimal = Pos_payment.Label3.Text
                Dim disPrice As Decimal
                If totalPrice > checkVoucher(0)("VoucherBalance") Then
                    disPrice = "0.00"
                Else
                    disPrice = checkVoucher(0)("VoucherBalance") - totalPrice
                End If
                executesql("UPDATE Voucher SET VoucherBalance= '" & disPrice & "',UseVoucherDate='" & dateNow & "' WHERE VoucherId=" & checkVoucher(0)("VoucherId") & "")
                executesql("INSERT INTO VoucherHistory(VoucherId,PaidAmount,InsertDate,SaleId) VALUES('" & checkVoucher(0)("VoucherId") & "','" & totalPrice & "','" & dateNow & "','" & GetSaleId & "')")
                Pos_payment.txtPayTotal.Text = FormatNumber(checkVoucher(0)("VoucherBalance"), 2)
                Pos_payment.DataGridViewSale.Rows.Add("Voucher", FormatNumber(checkVoucher(0)("VoucherBalance"), 2))
                voucher = Pos_Payment_Voucher.txtVoucherNumber.Text
                Exit Sub
            End If
        End If
    End Sub
    Sub checkCoupon()
        Dim checkCoupon As DataTable = executesql("SELECT CouponId,CouponPrice,CouponBalance,ExpDate FROM Coupon WHERE CouponNumber='" & Pos_Payment_Coupon.txtCouponNumber.Text & "' AND StatusId=1")
        If checkCoupon.Rows.Count = 0 Then
            MsgBox("เลข คูปอง ไม่ถูกต้อง !", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        Dim dateNow As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm", New System.Globalization.CultureInfo("en-US"))
        If dateNow > checkCoupon(0)("ExpDate") Then
            MsgBox("หมดอายุ", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        Else
            executesql("UPDATE Coupon SET StatusId=0 WHERE CouponId=" & checkCoupon(0)("CouponId") & "")
            Pos_payment.txtPayTotal.Text = FormatNumber(checkCoupon(0)("CouponBalance"), 2)
            Pos_payment.DataGridViewSale.Rows.Add("คูปอง", FormatNumber(checkCoupon(0)("CouponBalance"), 2))
            coupon = Pos_Payment_Coupon.txtCouponNumber.Text
            Exit Sub
        End If
    End Sub
    Sub UpdatePaymentDG()
        'For i As Integer = 0 To Pos_payment.DataGridViewSale.Rows.Count - 1
        '    If Pos_payment.DataGridViewSale.Rows(i).Cells(0).Value = "เงินสด" Then
        '        Pos_payment.DataGridViewSale.Rows(i).Cells(1).Value = Pos_payment.txtPayTotal.Text
        '    ElseIf Pos_payment.DataGridViewSale.Rows.Count = 0 Then
        '        Pos_payment.DataGridViewSale.Rows.Add("เงินสด", Pos_payment.txtPayTotal.Text)
        '    End If
        'Next
        Pos_payment.PaymentType = "เงินสด"
        Pos_payment.DataGridViewSale.Rows.Add(Pos_payment.PaymentType, Pos_payment.txtPayTotal.Text)
        'Pos_payment.Button1.Enabled = False
    End Sub
    Sub loadBankType()
        Pos_Payment_CreditCard.RadDropDownCardType.Properties.Items.Clear()
        Dim BankCardType As DataTable = executesql("SELECT BankCardTypeName FROM BankCardType WHERE Active=1")
        'Dim DataTax As DataTable = executesql("SELECT TaxName FROM Tax")
        If IsDBNull(BankCardType) Then
            Exit Sub
        End If
        For i = 0 To BankCardType.Rows.Count - 1
            Pos_Payment_CreditCard.RadDropDownCardType.Properties.Items.Add(BankCardType(i)("BankCardTypeName"))
        Next
    End Sub
    Sub loadBank()
        Pos_Payment_CreditCard.RadDropDownBankType.Properties.Items.Clear()
        Dim BankName As DataTable = executesql("SELECT BankName FROM Bank WHERE Active=1")
        'Dim DataTax As DataTable = executesql("SELECT TaxName FROM Tax")
        If IsDBNull(BankName) Then
            'MsgBox(1)
            Exit Sub
        End If
        For i = 0 To BankName.Rows.Count - 1
            Pos_Payment_CreditCard.RadDropDownBankType.Properties.Items.Add(BankName(i)("BankName"))
        Next
    End Sub
End Module
