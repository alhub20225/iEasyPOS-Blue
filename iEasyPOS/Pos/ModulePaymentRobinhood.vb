Imports Newtonsoft.Json

Module ModulePaymentRobinhood
    Dim Balance As Decimal
    Dim NewSaleId As Integer = 0
    Sub RobinhoodAddSale(ByVal PaymentType As Integer, ByVal Subtotal As Decimal, GrabNo As String)

        Dim SaleDate As String = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US", True))
        Dim InsertDate As String = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US", True))
        Dim UpdateDate As String = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US", True))
        Dim StartTime As String = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US", True))
        Dim EndTime As String = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US", True))
        Dim UserId As Integer = Frm_Login.UserId
        Dim CloseBillUserId As Integer = Frm_Login.UserId
        Dim OpenUserId As Integer = Frm_Login.UserId
        Dim CurrentUser As Integer = Frm_Login.UserId
        Dim Active As Integer = 1
        Dim IsPrintFullTax As Integer = 1
        Dim IsCloseBill As Integer = 1
        Dim SaveBillCount As Integer = 1
        'Dim SubTotal As Decimal = POS.txtSubTotal.Text
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
            SaleName = TableId
        End If

        Dim checkSaleNo As DataTable = executesql("select * from sale WHERE SaleDate between CONVERT(datetime, '" & Now.ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US", True)) & "', 126)  and CONVERT(datetime, '" & Now.ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US", True)) & "', 126)")
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
            If POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value IsNot Nothing Then

                aleardyPromotion = True
                PromotionId = POS.DataGridViewPOS.Rows(a).Cells("PromotionType").Value
                ItemPromotionId = POS.DataGridViewPOS.Rows(a).Cells("ItemIdPromotionId").Value
                '********
                POS.DataGridViewPOS.Rows(a).Cells(5).Value = 0
                ModulePOS.calculatePrice()
                Subtotal = POS.txtSubTotal.Text
                '********
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
        'If GetSaleId = 0 Then
        executesql("INSERT INTO Sale(SaleDate,SaleNo,SubTotal,TaxAmt,Total,ABBNo,FullTaxNo,IsPrintFullTax,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,StartTime,EndTime,TerminalId,TerminalName,AmountDC) VALUES('" & SaleDate & "','" & SaleNo & "','" & Subtotal & "','" & TaxAmt & "','" & Total & "','" & ABBNo & "','" & FullTaxNo & "','" & IsPrintFullTax & "','" & InsertDate & "','" & CloseBillUserId & "','" & IsCloseBill & "','" & Active & "','" & SaveBillCount & "','" & CustomerId & "','" & NumOfCust & "','" & StartTime & "','" & EndTime & "','" & Terminalid & "','" & TerminalName & "','" & AmountDC & "')")

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
            executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',1," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "')")
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
                            If selectPointRate(0)("TotalPrice") >= Subtotal Then
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
        Dim paymentCode As String = ""
        'Dim paymentCode As String = Pos_payment.txtPaymentCode.Text



        executesql("INSERT INTO SalePayment(SaleId,PaymentCode,PaidAmount,Rate,InsertDate,RefNumber,CC_Type,CC_Number) VALUES('" & selectSaleId(0)("SaleId") & "','" & paymentCode & "','" & Subtotal & "','" & Rate & "',CONVERT(datetime, '" & InsertDate & "', 126),'" & RefNumber & "','" & CC_Type & "','" & CC_Number & "')")

        Dim BankId As Integer = 0
        Dim EdcBankId As Integer = 0
        Dim BankCardTypeId As Integer = 0
        Dim CardTypeId As Integer = 0
        Dim CouponNumber As String = ""
        Dim GrabNumber As String = GrabNo
        Dim BankNumber As String = 0

        TotalCash = Subtotal

        executesql("INSERT INTO PaymentDetail(SaleId,PaymentTypeId,BankId,EdcBankId,BankCardTypeId,CardTypeId,PaidAmount,CouponNumber,VoucherNumber,BankNumber) VALUES('" & selectSaleId(0)("SaleId") & "','" & PaymentType & "'," & BankId & ",'" & EdcBankId & "','" & BankCardTypeId & "','" & CardTypeId & "','" & Subtotal & "','" & CouponNumber & "','" & GrabNumber & "','" & BankNumber & "')")


        Dim selectPaidAmount As DataTable = executesql("SELECT Sum(PaidAmount) AS PaidAmount FROM PaymentDetail WHERE SaleId=" & selectSaleId(0)("SaleId") & "")
        Balance = selectPaidAmount(0)("PaidAmount")

        'Promotion
        If aleardyPromotion = True Then
            executesql("INSERT INTO UsePromotion(SaleId,SaleNo,PromotionId,ItemPromotionId,InsertDate) VALUES('" & selectSaleId(0)("SaleId") & "','" & SaleNo & "','" & PromotionId & "','" & ItemPromotionId & "',CONVERT(datetime, '" & InsertDate & "', 126))")
        End If


        change = TotalCash - (POS.txtSubTotal.Text - TotalCretdit)
        NewSaleId = selectSaleId(0)("SaleId")
        executesql("UPDATE VoucherHistory SET SaleId='" & NewSaleId & "' WHERE VoucherHistoryId=(SELECT MAX(VoucherHistoryId) FROM VoucherHistory)")
        Pos_payment.Close()


        'INSERT QUE
        executesql("INSERT INTO Que(SaleNo,DatetimeSale,Status) VALUES('" & SaleNo & "',CONVERT(datetime, '" & InsertDate & "', 126),'0')")
        Pos_payment.Close()

        writeLog("User ID " + Frm_Login.UserId.ToString + " Add saleNo :" + SaleNo.ToString)

        'POS.FlowLayoutPanelItems.Controls.Clear()

        ModulePrintPosSlip.PrintSlip(NewSaleId)

        ModulePrinrOrder.PrinteOrder(NewSaleId)

        writeLog("------------------------------Close Sale----------------------------------")

        Pos_payment.DataGridViewSale.Rows.Clear()
        ClearDataPayMent()
        calBalance()
        ModulePayMent.NumQ = 0
        '****************************
        'TB_GetSaleId = 0
        'GetSaleId = 0
        '****************************
        If ModuleZoneTable.TableId <> 0 Then
            ModulePosTable.ShowDialogTable()

        End If


    End Sub
End Module
