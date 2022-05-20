Module ModuleQrPayment
    Function ThaiQr(totalPrice As Decimal)
        'If Pos_payment.DataGridViewSale.Rows.Count = 0 Then
        '    MsgBox("กรุณากรอกจำนวนเงิน", MsgBoxStyle.Critical, "คำเตือน")
        '    Pos_payment.txtPayTotal.Focus()
        '    Exit Function
        'End If

        'Dim amoutp As Decimal = Pos_payment.txtPayTotal.Text
        'Dim totalp As Decimal = Pos_payment.Label3.Text
        'If amoutp < totalp Then
        '    MsgBox("จำนวนวนเงินไม่พอชำระ", MsgBoxStyle.Critical, "คำเตือน")
        '    Exit Function
        'End If
        'Dim M1 As Decimal = Pos_payment.txtPayTotal.Text
        'Dim M2 As Decimal = POS.txtSubTotal.Text
        'If M1 < M2 Then
        '    MsgBox("จำนวนเงินไม่เพียงพอต่อราคาสินค้า", MsgBoxStyle.Critical)
        '    Pos_payment.txtPayTotal.Focus()
        '    Exit Sub
        'End If
        FrmQRPayment.PictureBoxQR.BackgroundImage = Nothing
        Dim partnerTxnUid As String = ""
        Dim partnerId As String = "PTR0000030" '"CRP0000011" ' "CTM001" '  '"PTR0000030"
        Dim partnerName As String = "Cha Tra Mue"
        Dim partnerSecret As String = "Qxdl5KZfISQFqC1JNzsxzhGDZmecmU9oa4sgfN6oVipR3oX6t2w97UvCQPEh8PDo" ' "WJ4V6SXA8tk3Kpj0XXY9l8iNBkRtGfCCWr5UE7hy0Y66Pz5SSUSb5vsUSrBCYIr9" '"Qxdl5KZfISQFqC1JNzsxzhGDZmecmU9oa4sgfN6oVipR3oX6t2w97UvCQPEh8PDo" 
        Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim merchantId As String = "EXT01000250227" '"KB000001518278" '"CTM002""EXT01000250227"  
        Dim terminalId2 As String = Environment.MachineName
        Dim qrType As String = "3"
        Dim txnAmount As String = POS.txtSubTotal.Text
        Dim txnCureencyCode As String = "THB"
        Dim reference1 As String = ""
        Dim reference2 As String = "null"
        Dim reference3 As String = "null"
        Dim reference4 As String = "null"
        Dim metadata As String = "Not Show"
        Dim MaxRows As Integer = 0
        Dim DateOnSaleNo As String

        'Create partnerTxnUid (SaleNo)
        Dim RowSaleNo As DataTable = executesql("SELECT MAX(SaleId) AS SaleId FROM Sale")
        If IsDBNull(RowSaleNo(0)("SaleId")) Then
            MaxRows = 1
        Else
            MaxRows = RowSaleNo(0)("SaleId")
            MaxRows = MaxRows + 1
        End If

        partnerTxnUid = "HQCTM" + Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH")) + MaxRows.ToString
        reference1 = "QR" + MaxRows.ToString

        'Insert Sale
        Dim SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

        Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate LIKE '%" & Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) & "%'")

        Dim No As Integer = 0
        If checkSaleNo.Rows.Count = 0 Then
            No = 1
        Else
            No = checkSaleNo.Rows.Count + 1
        End If
        Dim SaleNo As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH")) & No.ToString("0000")

        Dim ABBNO As String = SaleNo
        Dim FullTaxNO As String = SaleNo
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim Active As String = 0
        'Dim CustomerId As String = 0
        Dim TerminalName As String = Environment.MachineName
        Dim StartTime As String = SaleDate
        Dim TaxAmt As Decimal = 0.00
        Dim UsersId As Integer = 2
        Dim AmountDC As Decimal = 0


        'Dim SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        'Dim StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim EndTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim CloseBillUserId As Integer = Frm_Login.UserId
        Dim OpenUserId As Integer = Frm_Login.UserId
        Dim CurrentUser As Integer = Frm_Login.UserId
        'Dim Active As Integer = 0
        Dim IsPrintFullTax As Integer = 1
        Dim IsCloseBill As Integer = 1
        Dim SaveBillCount As Integer = 1
        Dim SubTotal As Decimal = POS.txtSubTotal.Text
        Dim Total As Decimal = POS.txtTotal.Text
        Dim Terminalid As Integer = 0
        Dim CustomerId As Integer = FrmCustomerMemberNo.CustomerId
        Dim NumOfCust As Integer = 0
        'Dim TaxAmt As Decimal = 0
        Dim SaleName As String
        Dim TableId As Integer = ModuleZoneTable.TableId
        Dim AllowPrint As Integer = 0
        If TableId = 0 Then
            SaleName = "ลูกค้าเงินสดทั่วไป"
        Else
            SaleName = TableId
        End If

        'Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate LIKE '%" & Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) & "%'")
        'Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate='" & InsertDate & "'")
        'Dim No As Integer = 0
        If checkSaleNo.Rows.Count = 0 Then
            No = 1
        Else
            No = checkSaleNo.Rows.Count + 1
        End If
        NumQ = No
        'Dim SaleNo As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH")) & No.ToString("0000")
        'Dim ABBNo As String = SaleNo
        'Dim FullTaxNo As String = SaleNo
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

        'Dim AmountDC As Decimal = 0
        'Dim TerminalName As String = Environment.MachineName
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
        If POS.DiscountByItem2 = 1 Then
            AmountDC = 0
        Else POS.DiscountByItem2 = 2
            AmountDC = POS.txtDiscount.Text
        End If
        'MsgBox(GetSaleId)
        'Exit Sub
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
                InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                'TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmt += TaxAmount
                'If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                'If POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',0," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "')")
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

                'End If
                'Point Promotion
                If FrmCustomerMemberNo.customerMemNo <> 0 Then
                    '                    Clipboard.SetText("Select GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.GetFree,GiftValue.Point From PromotionItem 
                    'inner join Promotion on(Promotion.ProId = PromotionItem.PromotionId)
                    'inner join ConditionPromotion on(ConditionPromotion.ConId = Promotion.ConditionId)
                    'inner join GiftValue on(GiftValue.GiftId = ConditionPromotion.GiftId)
                    'Where PromotionItem.ItemId='" & ItemId & "' And PromotionItem.Active ='1'")
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

                    Dim selectPointRate As DataTable = executesql("Select PointRate.PointRate From PointRate 
inner join ItemPoint on(PointRate.PointRateId = ItemPoint.PointRateId)
Where ItemPoint.ItemId = '" & ItemId & "' And PointRate.DateStart <= '" & DatePointEnd & "' And PointRate.DateEnd >= '" & DatePointEnd & "' And ItemPoint.Active='1'")
                    If Not IsNothing(selectPointRate) And selectPointRate.Rows.Count > 0 Then
                        executesql("UPDATE Customer Set Point +='" & selectPointRate(0)("PointRate") * Qty & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
                    End If
                End If
            Next
            executesql("UPDATE Sale SET TaxAmt='" & TaxAmt & "' WHERE SaleId='" & selectSaleId(0)("SaleId") & "'")
            'Clipboard.SetText("UPDATE Sale SET TaxAmt='" & TaxAmt & "' WHERE SaleId='" & selectSaleId(0)("SaleId") & "'")
            executesql("INSERT INTO SaleTable(SaleId,SaleName,InsertDate,OpenUserId,Active,IsUsing,CurrentUserUsed) VALUES('" & selectSaleId(0)("SaleId") & "','" & SaleName & "','" & InsertDate & "','" & OpenUserId & "','" & Active & "','" & IsUsing & "','" & CurrentUser & "')")


        Else
            executesql("UPDATE Sale SET Active='" & Active & "' WHERE SaleId=" & GetSaleId & "")

            Dim checkSaleNo2 As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate LIKE '%" & Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) & "%' And Active = 1")
            'Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate='" & InsertDate & "'")
            No = 0
            If checkSaleNo2.Rows.Count = 0 Then
                No = 1
            Else
                No = checkSaleNo2.Rows.Count + 1
            End If

            SaleNo = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH")) & No.ToString("0000")
            ABBNo = SaleNo
            FullTaxNo = SaleNo
            executesql("UPDATE Sale SET SaleDate='" & SaleDate & "',SaleNo='" & SaleNo & "',ABBNo='" & ABBNo & "',FullTaxNo='" & FullTaxNo & "',IsPrintFullTax='" & IsPrintFullTax & "',CloseBillUserId='" & CloseBillUserId & "',IsCloseBill='" & IsCloseBill & "',SaveBillCount='" & SaveBillCount & "',NumOfCust='" & NumOfCust & "',EndTime='" & EndTime & "',TerminalId='" & Terminalid & "',TerminalName='" & TerminalName & "',AmountDC='" & AmountDC & "',Active='" & Active & "' WHERE SaleId=" & GetSaleId & "")

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
                        InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                        UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                        TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                        SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                        TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                        TaxAmt += TaxAmount
                        executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName) VALUES('" & GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',0," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "')")
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
                        ''Insert Topping
                        ''Dim ToppingName As String =
                        'If POS.DataGridViewPOS.Rows(i).Cells("Topping").Value IsNot Nothing Then
                        '    Dim ToppingName As String() = POS.DataGridViewPOS.CurrentRow.Cells(0).Value.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        '    For a As Integer = 1 To ToppingName.Length - 1
                        '        Dim selectTopping As DataTable = executesql("SELECT Topping.ToppingId,Topping.ToppingName,ToppingReceipe.* FROM Topping INNER JOIN ToppingReceipe ON(Topping.ToppingId = ToppingReceipe.ToppingId) WHERE Topping.ToppingName='" & ToppingName(a) & "'")
                        '        If selectTopping.Rows.Count > 0 Then
                        '            'UseTopping
                        '            executesql("INSERT INTO UseTopping(ToppingId,SaleItemId,ToppingName,InsertDate) VALUES('" & selectTopping(0)("ToppingId") & "','" & SaleItemId & "','" & selectTopping(0)("ToppingName") & "','" & InsertDate & "')")
                        '            'UseReceipeTopping
                        '            executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & selectTopping(0)("MatIdTopping") & "','" & selectTopping(0)("Qty") & "','" & selectTopping(0)("MatinitCost") & "','" & selectTopping(0)("MatUnitCost") & "','" & selectTopping(0)("TotalInitCost") & "','" & selectTopping(0)("TotalCost") & "','" & InsertDate & "')")
                        '        End If
                        '    Next
                        'End If
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
                                    executesql("update SaleItem set Total+='" & (ToppingData(0)("Pricing") * Qty) & "',SubTotal+='" & (ToppingData(0)("Pricing") * Qty) & "' where SaleItemId='" & SaleItemId & "'")
                                    Dim selectSubTotal As DataTable = executesql("select SaleId,SubTotal from SaleItem where SaleItemId='" & SaleItemId & "'")
                                    Dim TaxTopping As Decimal = ((ToppingData(0)("Pricing") * Qty) - ((ToppingData(0)("Pricing") * Qty) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                    Dim UpdateSubTotal As Decimal = (selectSubTotal(0)("SubTotal") - (selectSubTotal(0)("SubTotal") * 100 / (SelectDataItem(0)("Multiply") + 100)))
                                    executesql("update SaleItem set Tax='" & UpdateSubTotal & "' where SaleItemId='" & SaleItemId & "'")
                                    TaxAmt += TaxTopping
                                End If
                            Next
                        End If
                        'If POS.DataGridViewPOS.Rows(i).Cells("Selection").Value IsNot Nothing Then
                        '    'Insert Selection 
                        '    Dim Selection As String() = POS.DataGridViewPOS.CurrentRow.Cells(0).Value.Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        '    For g As Integer = 1 To Selection.Length - 1
                        '        Dim selectSelection As DataTable = executesql("SELECT * FROM Selection WHERE SelectionName='" & Selection(g) & "'")
                        '        Dim selectionId2 As Integer = POS.DataGridViewPOS.CurrentRow.Cells(9).Value
                        '        If selectSelection.Rows.Count = 0 Then
                        '            selectionId2 = 0
                        '        Else
                        '            selectionId2 = selectSelection(0)("SelectionId")
                        '        End If
                        '        executesql("INSERT INTO UseSelection(SelectionId,SaleItemId,SelectionName) VALUES('" & selectionId2 & "','" & SaleItemId & "','" & Selection(g) & "')")
                        '    Next
                        'End If
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
                        Dim selectPointRate As DataTable = executesql("Select PointRate.PointRate From PointRate 
inner join ItemPoint on(PointRate.PointRateId = ItemPoint.PointRateId)
Where ItemPoint.ItemId = '" & ItemId & "' And PointRate.DateStart <= '" & DatePointEnd & "' And PointRate.DateEnd >= '" & DatePointEnd & "' And ItemPoint.Active='1'")
                        If Not IsNothing(selectPointRate) And selectPointRate.Rows.Count > 0 Then
                            executesql("UPDATE Customer Set Point +='" & selectPointRate(0)("PointRate") * Qty & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
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
                        InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                        UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                        TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                        SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                        TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                        TaxAmt += TaxAmount

                        executesql("UPDATE SaleItem SET InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxAmount & "',Total='" & TotalItem & "',PercentDC='" & PercentDC & "',BahtDC='" & BahtDC & "',AmtDC='" & AmtDC & "',TerminalName='" & TerminalName & "',Active='" & Active & "' WHERE saleId=" & GetSaleId & " and ItemId = '" & ItemId & "'")
                    End If

                End If
            Next
            executesql("UPDATE Sale SET TaxAmt='" & TaxAmt & "',SubTotal='" & SubTotal & "',Total='" & Total & "' WHERE SaleId='" & GetSaleId & "'")
        End If
        Clipboard.SetText("http://qrpay.ieasy.asia/vbapi_demo.php?dataVB=true&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & Terminalid & "&qrType=" & qrType & "&txnAmount=" & txnAmount & "&txnCurrencyCode=" & txnCureencyCode & "&reference1=" & reference1 & "&reference2=" & reference2 & "&reference3=" & reference3 & "&reference4=" & reference4 & "&metadata=" & metadata & "")
        ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/vbapi_demo.php?dataVB=true&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & Terminalid & "&qrType=" & qrType & "&txnAmount=" & txnAmount & "&txnCurrencyCode=" & txnCureencyCode & "&reference1=" & reference1 & "&reference2=" & reference2 & "&reference3=" & reference3 & "&reference4=" & reference4 & "&metadata=" & metadata & "")
        Dim QrCodeData As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/vbapi2.php?action=SELECT&table=QRPayment_demo&field=QRcode,partnerTxnUid,statusCode,errorCode,errorDesc&where=partnerTxnuid='" & partnerTxnUid & "'")
        If QrCodeData.Rows.Count > 0 Then
            If QrCodeData(0)("statusCode") = "10" Then
                executesql("update Sale set Active=0 where SaleId='" & MaxRows & "'")
                'Clipboard.SetText("UPDATE SaleItem SET Active=0 WHERE SaleId='" & RowSaleNo(0)("SaleId") & "'")
                executesql("UPDATE SaleItem SET Active=0 WHERE SaleId='" & MaxRows & "'")
                MsgBox(QrCodeData(0)("errorDesc"), MsgBoxStyle.Critical, "Warning")
                Exit Function
            Else QrCodeData(0)("statusCode") = "00"
                'FrmHome.TxtpartnerTxnUid.Text = QrCodeData(0)("partnerTxnUid")
                Return QrCodeData
            End If
        Else
            MsgBox("Request failed.", MsgBoxStyle.Critical)
            Exit Function
        End If
        'Frm_QRScan.Close()
        'Frm_QRScan.Show()
        'Frm_QRScan.TxtStringQR.Text = QrCodeData(0)("QRcode")
        'Frm_QRScan.LabelTotalPrice.Text = FormatNumber(txnAmount, 2)
        'LoadDisplayPayment(partnerTxnUid)
    End Function
End Module
