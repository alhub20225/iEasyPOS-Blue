Module ModuleSaveSale
    Dim field As String
    Dim Table As String
    Dim where As String
    Dim value As String
    Dim join As String
    Public GetSaleId As Integer = 0
    Sub loadData()
        Type = 0
        POS.DiscountByItem2 = 0
        Dim selectSaleTabId As DataTable = executesql("SELECT SaleTable.InsertDate,SaleTable.SaleName,SaleTable.SaleId FROM SaleTable INNER JOIN Sale ON(Sale.SaleId=SaleTable.SaleId)INNER JOIN SaleTabRef ON(SaleTabRef.SaleTabId = SaleTable.SaleTabId) WHERE Sale.IsCloseBill=0 AND SaleTabRef.TableId=0 AND Sale.Active=1")
        'Clipboard.SetText("SELECT SaleTable.InsertDate,SaleTable.SaleName,SaleTable.SaleId FROM SaleTable INNER JOIN Sale ON(Sale.SaleId=SaleTable.SaleId)INNER JOIN SaleTabRef ON(SaleTabRef.SaleTabId = SaleTable.SaleTabId) WHERE Sale.IsCloseBill=0 AND SaleTabRef.TableId=0 AND Sale.Active=1")
        If selectSaleTabId.Rows.Count = 0 Then
            Exit Sub
        End If
        Pos_SaveSale.DataGridViewSaveSale.Rows.Clear()
        Dim InsertDate As String
        Dim DateNow As String = Convert.ToDateTime(Now).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        Dim DateNow2 As String = Convert.ToDateTime(Now).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        For i As Integer = 0 To selectSaleTabId.Rows.Count - 1
            InsertDate = Convert.ToDateTime(selectSaleTabId(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
            If InsertDate < DateNow Then
                executesql("UPDATE Sale SET Active=0,UpdateDate='" & DateNow2 & "' WHERE SaleId='" & selectSaleTabId(i)("SaleId") & "'")
                executesql("UPDATE SaleTable SET Active=0,UpdateDate='" & DateNow2 & "' WHERE SaleId='" & selectSaleTabId(i)("SaleId") & "'")
                executesql("UPDATE SaleItem SET Active=0,UpdateDate='" & DateNow2 & "' WHERE SaleId='" & selectSaleTabId(i)("SaleId") & "'")
            Else
                Pos_SaveSale.DataGridViewSaveSale.Rows.Add(Convert.ToDateTime(selectSaleTabId(i)("InsertDate")).ToString("dd/MM/yyyy HH:mm", New System.Globalization.CultureInfo("en-US")), selectSaleTabId(i)("SaleName"), selectSaleTabId(i)("SaleId"))
            End If
        Next
    End Sub
    Sub showData()
        Try
            If Pos_SaveSale.DataGridViewSaveSale.SelectedRows Is Nothing Then
                GetSaleId = 0
                Exit Sub
            Else
                Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("en-US"))
                Dim TimeNows As String = Convert.ToDateTime(Now).ToString("HH:mm", New System.Globalization.CultureInfo("en-US"))
                Dim saleId As Integer = Pos_SaveSale.DataGridViewSaveSale.CurrentRow.Cells("saleId").Value
                GetSaleId = saleId
                Clipboard.SetText("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate
FROM Sale 
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
WHERE Sale.SaleId='" & saleId & "' and SaleItem.Active=3
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),
SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101)")
                Dim selectSaleData As DataTable = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate
FROM Sale 
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
WHERE Sale.SaleId='" & saleId & "' and SaleItem.Active=3
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),
SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101)")
                'Dim selectUsePromotion As DataTable = executesql("SELECT Promotion.ProId,Item.ItemName,Item.ItemId FROM UsePromotion INNER JOIN Promotion ON(Promotion.ProId = UsePromotion.PromotionId) INNER JOIN PromotionItem ON(Promotion.ProId = PromotionItem .PromotionId) INNER JOIN Item ON(Item.ItemId=PromotionItem.ItemId) WHERE Promotion.Active = '1' AND UsePromotion.SaleId='" & saleId & "'")
                Dim selectUsePromotion As DataTable = executesql("Select  Promotion.ProId,Promotion.ProName,ConditionPromotion.ConPrice,ConditionPromotion.ConAmount,
        ConditionPromotion.AlertAmount,ConditionPromotion.AlertPrice,ConditionPromotion.ConTimeEnd,
        ConditionPromotion.ConDateEnd,GiftValue.GiftId,GiftValue.DiscountPer,GiftValue.DiscountB,
        Item.ItemName,Item.ItemId
        FROM UsePromotion 
		INNER JOIN Promotion ON(Promotion.ProId = UsePromotion.PromotionId)
        INNER JOIN ConditionPromotion On(ConditionPromotion.ConId = Promotion.ConditionId) 
        INNER JOIN GiftValue ON (GiftValue.GiftId = ConditionPromotion.GiftId)
        INNER JOIN PromotionItem ON (Promotion.ProId = PromotionItem.PromotionId)
        INNER JOIN Item ON(Item.ItemId=PromotionItem.ItemId) 
		WHERE PromotionItem.Active='1' AND  Promotion.Active = '1' AND UsePromotion.SaleId='" & saleId & "'")
                If selectSaleData.Rows.Count = 0 Then
                    Exit Sub
                End If
                Dim TotalDiscount As Decimal = 0
                Dim SubTotal As Decimal = 0
                Dim Item As Boolean = False

                Dim PercentDC As Decimal = 0
                Dim BahtDC As Decimal = 0
                Dim AmtDC As Decimal = 0
                POS.DataGridViewPOS.Rows.Clear()
                Dim AllowDCS As Boolean = False
                If selectSaleData(0)("AmountDC") > 0 Then
                    POS.DiscountByItem2 = 2
                    'MsgBox(selectSaleData(0)("AmountDC"))
                    AllowDCS = True
                Else
                    POS.DiscountByItem2 = 1
                    AllowDCS = False
                    'MsgBox(2)
                End If
                For i As Integer = 0 To selectSaleData.Rows.Count - 1
                    If selectUsePromotion.Rows.Count > 0 Then
                        For j As Integer = 0 To selectUsePromotion.Rows.Count - 1
                            If selectSaleData(i)("ItemId") = selectUsePromotion(j)("ItemId") Then
                                Item = True
                                Exit For
                            End If
                        Next
                    End If
                Next

                For i As Integer = 0 To selectSaleData.Rows.Count - 1
                    If selectSaleData(i)("BahtDC") > 0 Then
                        AmtDC = selectSaleData(i)("BahtDC")
                    ElseIf selectSaleData(i)("PercentDC") > 0 Then
                        AmtDC = selectSaleData(i)("PercentDC")
                    End If
                    POS.DataGridViewPOS.Rows.Add(selectSaleData(i)("ItemName"), FormatNumber(selectSaleData(i)("Qty"), 0), FormatNumber(selectSaleData(i)("UnitPrice"), 2), FormatNumber(selectSaleData(i)("SaleItem_Total"), 2), selectSaleData(i)("ItemId"))
                    TotalDiscount += AmtDC
                    SubTotal += selectSaleData(i)("Total")
                Next

                For a As Integer = 0 To selectSaleData.Rows.Count - 1
                    If selectUsePromotion.Rows.Count > 0 Then
                        For j As Integer = 0 To selectUsePromotion.Rows.Count - 1
                            If Not IsDBNull(selectUsePromotion(j)("ConPrice")) Then 'Price
                                If selectUsePromotion(j)("DiscountPer") = 0 And selectUsePromotion(j)("DiscountB") = 0 Then

                                    Dim Getfree As DataTable = executesql("SELECT Item.ItemId,Item.ItemName 
                                    FROM UsePromotion 
                                    INNER JOIN Promotion ON(Promotion.ProId = UsePromotion.PromotionId) 
                                    INNER JOIN Item ON(Item.ItemId = UsePromotion.ItemPromotionId) 
                                    WHERE UsePromotion.SaleId='" & GetSaleId & "'")

                                    POS.DataGridViewPOS.Rows.Add(Getfree(0)("ItemName") & " *ฟรี ", 1, 0.00, 0.00, Getfree(0)("ItemId"), 0, 0, 0, 0, 0, 0, selectUsePromotion(j)("ProId"), Getfree(0)("ItemId"))
                                    POS.DataGridViewPOS.Rows(POS.DataGridViewPOS.RowCount - 1).DefaultCellStyle.ForeColor = Color.Green

                                ElseIf selectUsePromotion(j)("DiscountPer") <> 0 And selectUsePromotion(j)("DiscountB") = 0 Then
                                    If Item = True Then
                                        DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * FormatNumber(selectUsePromotion(j)("DiscountPer"), 2)) / 100
                                        POS.DataGridViewPOS.Rows(j).Cells(5).Value = DisCount
                                        Pos_DiscountByItem.DiscountByItem_value = DisCount
                                        POS.DataGridViewPOS.Rows(j).Cells("discountType").Value = 1
                                        POS.DataGridViewPOS.Rows(j).Cells("AllowDC").Value = 1
                                        Pos_DiscountByItem.per = 1
                                        POS.DataGridViewPOS.Rows(j).Cells("PromotionType").Value = selectUsePromotion(j)("ProId")
                                    End If
                                ElseIf selectUsePromotion(j)("DiscountPer") = 0 And selectUsePromotion(j)("DiscountB") <> 0 Then
                                    If Item = True Then
                                        DisCount = FormatNumber(selectUsePromotion(j)("DiscountB"), 2)
                                        POS.DataGridViewPOS.Rows(j).Cells(5).Value = DisCount
                                        POS.DataGridViewPOS.Rows(j).Cells("discountType").Value = 0
                                        POS.DataGridViewPOS.Rows(j).Cells("AllowDC").Value = 1
                                        Pos_DiscountByItem.per = 0
                                        POS.DataGridViewPOS.Rows(j).Cells("PromotionType").Value = selectUsePromotion(j)("ProId")
                                    End If
                                End If
                            ElseIf Not IsDBNull(selectUsePromotion(j)("ConAmount")) Then 'Amount
                                If selectUsePromotion(j)("DiscountPer") = 0 And selectUsePromotion(j)("DiscountB") = 0 Then
                                    Dim Getfree As DataTable = executesql("SELECT Item.ItemId,Item.ItemName 
                                    FROM UsePromotion 
                                    INNER JOIN Promotion ON(Promotion.ProId = UsePromotion.PromotionId) 
                                    INNER JOIN Item ON(Item.ItemId = UsePromotion.ItemPromotionId) 
                                    WHERE UsePromotion.SaleId='" & GetSaleId & "'")
                                    POS.DataGridViewPOS.Rows.Add(Getfree(0)("ItemName") & " *ฟรี ", 1, 0.00, 0.00, Getfree(0)("ItemId"), 0, 0, 0, 0, 0, 0, selectUsePromotion(j)("ProId"), Getfree(0)("ItemId"))

                                ElseIf selectUsePromotion(j)("DiscountPer") <> 0 And selectUsePromotion(j)("DiscountB") = 0 Then
                                    If Item = True Then
                                        DisCount = (POS.DataGridViewPOS.CurrentRow.Cells(3).Value * FormatNumber(selectUsePromotion(j)("DiscountPer"), 2)) / 100
                                        POS.DataGridViewPOS.Rows(j).Cells(5).Value = DisCount
                                        Pos_DiscountByItem.DiscountByItem_value = DisCount
                                        POS.DataGridViewPOS.Rows(j).Cells("discountType").Value = 1
                                        POS.DataGridViewPOS.Rows(j).Cells("AllowDC").Value = 1
                                        Pos_DiscountByItem.per = 1
                                        POS.DataGridViewPOS.Rows(j).Cells("PromotionType").Value = selectUsePromotion(j)("ProId")
                                    End If
                                ElseIf selectUsePromotion(j)("DiscountPer") = 0 And selectUsePromotion(j)("DiscountB") <> 0 Then
                                    DisCount = FormatNumber(selectUsePromotion(j)("DiscountB"), 2)
                                    If Item = True Then
                                        POS.DataGridViewPOS.Rows(j).Cells(5).Value = DisCount
                                        POS.DataGridViewPOS.Rows(j).Cells("discountType").Value = 0
                                        POS.DataGridViewPOS.Rows(j).Cells("AllowDC").Value = 1
                                        Pos_DiscountByItem.per = 0
                                        POS.DataGridViewPOS.Rows(j).Cells("PromotionType").Value = selectUsePromotion(j)("ProId")
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next
                Dim Topping As Integer
                Dim selection As Integer
                For a As Integer = 0 To selectSaleData.Rows.Count - 1
                    If AllowDCS = False Then
                        POS.DataGridViewPOS.Rows(a).Cells("AllowDC").Value = 1
                    End If
                    If selectSaleData(a)("BahtDC") = 0 And selectSaleData(a)("PercentDC") = 0 Then
                        POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value = FormatNumber(0, 3)
                        If selectSaleData(0)("AmountDC") > 0 Then
                            POS.DiscountByItem2 = 2
                            Type = 1
                            POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value = FormatNumber(0, 3)
                        End If
                    ElseIf selectSaleData(a)("BahtDC") > 0 And selectSaleData(a)("PercentDC") = 0 Then
                        POS.DiscountByItem2 = 1
                        Type = 0
                        POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 0
                        'MsgBox(selectSaleData(a)("BahtDC"))
                        POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value = selectSaleData(a)("BahtDC")
                        POS.DataGridViewPOS.Rows(a).Cells("AllowDC").Value = 1
                    ElseIf selectSaleData(a)("BahtDC") = 0 And selectSaleData(a)("PercentDC") > 0 Then
                        POS.DiscountByItem2 = 1
                        Type = 0
                        POS.DataGridViewPOS.Rows(a).Cells("discountType").Value = 1
                        POS.DataGridViewPOS.Rows(a).Cells("ส่วนลด").Value = selectSaleData(a)("PercentDC")
                        POS.DataGridViewPOS.Rows(a).Cells("AllowDC").Value = 1
                    End If
                    Dim SelectUseTopping As DataTable = executesql("select 
UseTopping.ToppingId,UseTopping.SaleItemId,UseTopping.ToppingName,UseTopping.InsertDate,
SaleItem.ItemId
from UseTopping
inner join SaleItem on(SaleItem.SaleItemId = UseTopping.SaleItemId) 
where SaleItem.SaleItemId='" & selectSaleData(a)("SaleItemId") & "'")
                    If SelectUseTopping.Rows.Count > 0 Then
                        topping = 1
                        For i As Integer = 0 To SelectUseTopping.Rows.Count - 1
                            If SelectUseTopping(i)("ItemId") = selectSaleData(a)("ItemId") Then
                                POS.DataGridViewPOS.Rows(a).Cells("Topping").Value = Topping
                            End If
                        Next
                    End If
                    Dim SelectUseSelect As DataTable = executesql("select 
SaleItem.ItemId
from UseSelection
inner join SaleItem on(SaleItem.SaleItemId = UseSelection.SaleItemId) 
where SaleItem.SaleItemId='" & selectSaleData(a)("SaleItemId") & "'")
                    If SelectUseSelect.Rows.Count > 0 Then
                        selection = 1
                        For i As Integer = 0 To SelectUseTopping.Rows.Count - 1
                            If SelectUseSelect(i)("ItemId") = selectSaleData(a)("ItemId") Then
                                POS.DataGridViewPOS.Rows(a).Cells("Selection").Value = selection
                            End If
                        Next
                    End If
                Next

                ModulePOS.calculatePrice()
                'POS.txtDiscount.Text = TotalDiscount
                'POS.txtTotal.Text = FormatNumber(SubTotal - TotalDiscount, 2)
                'POS.txtSubTotal.Text = FormatNumber(POS.txtTotal.Text - POS.txtDiscount.Text, 2)
                Pos_SaveSale.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub btnSave()

        Dim TB_saleName As String = Pos_SaveSaleName.SaleName
        Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_subtotal As Decimal = POS.txtSubTotal.Text
        Dim TB_total As Decimal = POS.txtTotal.Text
        Dim TB_IsCloseBill As Integer = 0
        Dim TB_CustomerId As Integer = 0
        Dim TB_Active As Integer = 1
        Dim TB_openUserId As Integer = Frm_Login.UserId
        Dim SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim EndTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim CloseBillUserId As Integer = Frm_Login.UserId
        Dim OpenUserId As Integer = Frm_Login.UserId
        Dim CurrentUser As Integer = Frm_Login.UserId
        Dim Active As Integer = 1
        Dim IsPrintFullTax As Integer = 1
        Dim IsCloseBill As Integer = 0
        Dim SaveBillCount As Integer = 0
        Dim SubTotal As Decimal = POS.txtSubTotal.Text
        Dim Total As Decimal = POS.txtTotal.Text
        Dim Terminalid As Integer = 0
        Dim CustomerId As Integer = FrmCustomerMemberNo.CustomerId
        Dim NumOfCust As Integer = 0
        Dim TaxAmt As Decimal = 0
        Dim SaleName As String
        Dim AllowPrint As Integer = 0

        Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate LIKE '%" & Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) & "%'")
        'Dim checkSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleDate='" & InsertDate & "'")
        Dim No As Integer = 0
        If checkSaleNo.Rows.Count = 0 Then
            No = 1
        Else
            No = checkSaleNo.Rows.Count + 1
        End If
        NumQ = No
        Dim SaleNo As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH")) & No.ToString("0000")
        Dim ABBNo As String
        Dim FullTaxNo As String
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
        If POS.DiscountByItem2 = 1 Then
            AmountDC = 0
        Else POS.DiscountByItem2 = 2
            AmountDC = POS.txtDiscount.Text
        End If
        If GetSaleId = 0 Then
            'executesql("INSERT INTO Sale(Subtotal,Total,InsertDate,IsCloseBill,Active,CustomerId,StartTime) VALUES('" & TB_subtotal & "','" & TB_total & "','" & TB_InsertDate & "'," & TB_IsCloseBill & "," & TB_Active & ",'" & TB_CustomerId & "','" & TB_StartTime & "')")
            ''Print_()


            'Dim selectSaleId As DataTable = executesql("SELECT Max(saleId) AS SaleId FROM Sale")
            'Dim GetSaleItemID As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")
            ''Update SaleId
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            '    executesql("UPDATE SaleItem SET SaleId='" & selectSaleId(0)("SaleId") & "',Active=1 WHERE ItemId='" & POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value & "' AND SaleId=0 AND Active=3")
            'Next
            executesql("INSERT INTO Sale(SaleNo,SaleDate,SubTotal,TaxAmt,Total,ABBNo,FullTaxNo,IsPrintFullTax,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,StartTime,TerminalId,TerminalName,AmountDC) VALUES('" & SaleNo & "','" & SaleDate & "','" & SubTotal & "','" & TaxAmt & "','" & Total & "','" & ABBNo & "','" & FullTaxNo & "','" & IsPrintFullTax & "','" & InsertDate & "','" & CloseBillUserId & "','" & IsCloseBill & "','" & Active & "','" & SaveBillCount & "','" & CustomerId & "','" & NumOfCust & "','" & StartTime & "','" & Terminalid & "','" & TerminalName & "','" & AmountDC & "')")
            Dim selectSaleId As DataTable = executesql("SELECT Max(SaleId) As SaleId FROM Sale")
            GetSaleId = selectSaleId(0)("SaleId")
            executesql("INSERT INTO SaleTabRef(TableId) VALUES('')")
            Dim selectSaleTabId As DataTable = executesql("SELECT Max(SaleTabId) AS SaleTabId FROM SaleTabRef")
            executesql("INSERT INTO SaleTable(SaleTabId,SaleId,SaleName,InsertDate,OpenUserId,Active,CurrentUserUsed) VALUES('" & selectSaleTabId(0)("SaleTabId") & "','" & selectSaleId(0)("SaleId") & "','" & TB_saleName & "','" & TB_InsertDate & "','" & TB_openUserId & "','" & TB_Active & "','" & Frm_Login.UserId & "')")
            executesql("UPDATE Tables SET StateStatus=1 WHERE TableId='" & TableId & "'")
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

                'MsgBox(TotalItem)

                If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                    executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName,UserId) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',3," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "','" & Frm_Login.UserId & "')")
                    'Insert UseReceipeItem
                    Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                    Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                    Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                    Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                    If IsNothing(SelectReceipe) Then
                        'DisStock
                        If SelectDataItem(0)("IsTrackStock") = 1 Then
                            MatAmount = Qty
                            'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                            MatAmount = Qty
                            ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        End If
                    ElseIf SelectReceipe.Rows.Count = 0 Then
                        'DisStock
                        If SelectDataItem(0)("IsTrackStock") = 1 Then
                            MatAmount = Qty
                            'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                            MatAmount = Qty
                            ''MsgBox(SelectDataItem(i)("ItemCode"))
                            ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                        End If
                    Else
                        For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                            MatAmount2 = SelectReceipe(j)("Qty")
                            MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                            MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                            TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                            TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                            executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                            'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & SelectReceipe(j)("MatId") & "'")
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
                                    'executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")
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

                End If
            Next
            executesql("update Sale set TaxAmt = '" & TaxAmt & "' where SaleId = '" & selectSaleId(0)("SaleId") & "'")
            'Insert To Sale Item Order
            'Clipboard.SetText("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND ItemId='" & TB_ItemId & "' group by Qty,InsertDate,ItemId,CategoryId")
            'Dim GetSaleItemID As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId,Qty,InsertDate,ItemId,CategoryId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "' group by Qty,InsertDate,ItemId,CategoryId")
            'Dim GetPrinterName As DataTable = executesql("SELECT CatePrinterName FROM CategoryItem WHERE CategoryId='" & GetSaleItemID(0)("CategoryId") & "'")
            'executesql("INSERT INTO SaleItemOrder(SaleItemId,Qty,UserId,OrderTime,PrinterName,TerminalName,StatusPrint,ItemName,Active) VALUES('" & GetSaleItemID(0)("SaleItemId") & "',1,'" & Frm_Login.UserId & "','" & Convert.ToDateTime(GetSaleItemID(0)("InsertDate")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & GetPrinterName(0)("CatePrinterName") & "','" & Environment.MachineName & "',0,'" & ItemName & "','1')")
        Else
            Dim checkTax As Boolean = False
            Dim checkDisc As Boolean = False
            'update
            If POS.DiscountByItem2 = 1 Then
                AmountDC = 0
            Else POS.DiscountByItem2 = 2
                AmountDC = POS.txtDiscount.Text
            End If
            executesql("UPDATE SaleTable SET UpdateDate='" & TB_UpdateDate & "' WHERE SaleId='" & GetSaleId & "'")
            executesql("UPDATE Sale SET Subtotal='" & POS.txtSubTotal.Text & "',Total='" & POS.txtTotal.Text & "',UpdateDate='" & TB_UpdateDate & "',AmountDC='" & AmountDC & "' WHERE SaleId='" & GetSaleId & "'")
            ''Update SaleId
            'Dim GetSaleItemID As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND
            'ModulePrinrOrder.PrinteOrder() UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")
            'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
            '    executesql("UPDATE SaleItem SET SaleId='" & GetSaleId & "',Active=1 WHERE ItemId='" & POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value & "' AND SaleId=0 AND Active=3")
            'Next
            ''executesql("UPDATE SaleItem SET SaleId='" & GetSaleId & "',Active=1 WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND SaleId=0 AND Active=3")
            'Print_()
            Dim checkExists As Boolean = False
            Dim checkExists2 As Boolean = False
            Dim checkItem As DataTable = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
                                                        SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
                                                        SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
                                                        SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
                                                        CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
                                                        CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
                                                        CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate
                                                        FROM Sale 
                                                        INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
                                                        INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
                                                        INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
                                                        WHERE Sale.SaleId='" & GetSaleId & "' and SaleItem.Active = 3
                                                        GROUP BY Sale.SaleId,Sale.SubTotal,
                                                        Sale.Total,SaleItem.SaleItemId,
                                                        SaleItem.ItemId,SaleItem.ItemName,
                                                        SaleItem.Total,SaleItem.BahtDC,
                                                        SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
                                                        SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),
                                                        SaleTable.SaleName,
                                                        CONVERT(date,SaleTable.InsertDate ,101),
                                                        CONVERT(date,SaleTable.UpdateDate ,101)")
            Dim rowscheckItem As Integer = checkItem.Rows.Count

            For i As Integer = 0 To POS.DataGridViewPOS.Rows.Count - 1
                ItemId = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value
                Qty = POS.DataGridViewPOS.Rows(i).Cells(1).Value
                Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")

                TaxItem = SelectDataItem(0)("ItemPrice") - (SelectDataItem(0)("ItemPrice") * 100 / (SelectDataItem(0)("Multiply") + 100))
                InitPrice = FormatNumber((SelectDataItem(0)("ItemPrice") - TaxItem), 2)
                UnitPrice = FormatNumber(SelectDataItem(0)("ItemPrice"), 2)
                TotalItem = POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty
                SubTotalItem = (((POS.DataGridViewPOS.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
                'TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
                TaxAmt += TaxAmount

                Dim SelectDataItem2 As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
                Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName,AllowPrint FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")

                Dim checkSaleItem As DataTable = executesql("SELECT ItemId FROM SaleItem WHERE SaleId=" & GetSaleId & " AND ItemId='" & ItemId & "'")

                If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                    If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                        BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                        PercentDC = 0
                    ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                        PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                        BahtDC = 0
                    End If
                    If checkSaleItem.Rows.Count = 0 Then
                        'executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,Active,PercentDC,BahtDC,AmtDC,TerminalName) VALUES('" & GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & SelectDataItem(0)("ItemName") & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxItem * Qty & "','" & TotalItem & "','" & InsertDate & "','1','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "')")
                    Else
                        'executesql("UPDATE SaleItem SET Active='1',InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxItem * Qty & "',Total='" & TotalItem & "',UpdateDate='" & UpdateDate & "',BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',AmtDC='" & AmtDC & "' WHERE SaleId='" & GetSaleId & "'")
                    End If
                    'CheckItem
                    'MsgBox(i)
                    'MsgBox(rowscheckItem)
                    If i <= rowscheckItem - 1 Then
                        checkTax = False
                        If checkItem(i)("ItemId") = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value Is Nothing And checkItem(i)("Qty") = POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            checkExists = True
                        Else
                            checkExists = False
                        End If
                        If checkItem(i)("ItemId") = POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value And POS.DataGridViewPOS.Rows(i).Cells("Topping").Value = 1 And checkItem(i)("Qty") = POS.DataGridViewPOS.Rows(i).Cells(1).Value Then
                            checkExists2 = True
                        Else
                            checkExists2 = False
                        End If

                        If checkExists2 = True Then
                            If checkExists = True Then
                                'checktopping_Table = 0
                                'ModulePosTable.checkItem()
                                'MsgBox(1)
                            ElseIf checkExists = False Then
                                'เหมือนเดิม
                                'MsgBox(2)
                                If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                                    PercentDC = 0
                                ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                                    PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                    BahtDC = 0
                                    BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                End If
                                checkDisc = True
                                If i < rowscheckItem - 1 Then
                                    executesql("UPDATE SaleItem SET BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',UpdateDate='" & UpdateDate & "' WHERE SaleId='" & GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "'")
                                Else

                                End If
                            End If
                        ElseIf checkExists2 = False Then
                            If checkExists = True Then
                                'เหมือนเดิม
                                'MsgBox(3)
                                If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                                    BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                    PercentDC = 0
                                ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                                    PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                    BahtDC = 0
                                End If
                                checkDisc = True

                                If i < rowscheckItem - 1 Then
                                    executesql("UPDATE SaleItem SET BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',UpdateDate='" & UpdateDate & "' WHERE SaleId='" & GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "'")
                                Else

                                End If
                            ElseIf checkExists = False Then
                                'เพิ่มจำนวน
                                'MsgBox(4)
                                If POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 0 Then
                                    BahtDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                    PercentDC = 0
                                ElseIf POS.DataGridViewPOS.Rows(i).Cells("discountType").Value = 1 Then
                                    PercentDC = POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value
                                    BahtDC = 0
                                End If
                                If i <= rowscheckItem - 1 Then
                                    'MsgBox(6)
                                    executesql("UPDATE SaleItem SET InitPrice='" & InitPrice & "',UnitPrice='" & UnitPrice & "',Qty='" & Qty & "',SubTotal='" & SubTotalItem & "',Tax='" & TaxAmount & "',Total='" & TotalItem & "',UpdateDate='" & UpdateDate & "',BahtDC='" & BahtDC & "',PercentDC='" & PercentDC & "',AmtDC='" & AmtDC & "' WHERE SaleId='" & GetSaleId & "' And SaleItemId='" & checkItem(i)("SaleItemId") & "' and ItemId='" & ItemId & "'")
                                Else
                                    'insert
                                    'MsgBox(7)
                                    checkTax = True
                                    If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                                        executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName,UserId) VALUES('" & GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',3," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "','" & Frm_Login.UserId & "')")
                                        'Insert UseReceipeItem
                                        Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                                        Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                                        Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                                        Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                                        If IsNothing(SelectReceipe) Then
                                            'DisStock
                                            If SelectDataItem(0)("IsTrackStock") = 1 Then
                                                MatAmount = Qty
                                                'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                            ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                                MatAmount = Qty
                                                ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                            End If
                                        ElseIf SelectReceipe.Rows.Count = 0 Then
                                            'DisStock
                                            If SelectDataItem(0)("IsTrackStock") = 1 Then
                                                MatAmount = Qty
                                                'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                            ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                                MatAmount = Qty
                                                ''MsgBox(SelectDataItem(i)("ItemCode"))
                                                ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                            End If
                                        Else
                                            For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                                                MatAmount2 = SelectReceipe(j)("Qty")
                                                MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                                                MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                                                TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                                                TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                                                executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                                                'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & SelectReceipe(j)("MatId") & "'")
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
                                                        'executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")
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
                                    End If

                                End If
                            End If
                        End If

                    Else
                        'Add New
                        ' MsgBox(5)
                        checkTax = True
                        If POS.DataGridViewPOS.Rows(i).Cells("PromotionType").Value Is Nothing Or POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value <> 0 Then
                            executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName,UserId) VALUES('" & GetSaleId & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & POS.DataGridViewPOS.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',3," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "','" & Frm_Login.UserId & "')")
                            'Insert UseReceipeItem
                            Dim selectSaleItem As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                            Dim SaleItemId As Integer = selectSaleItem(0)("SaleItemId")
                            Dim SelectReceipe As DataTable = executesql("SELECT Receipe.MatId,Receipe.MatInitCost,Receipe.MatUnitCost,Receipe.TotalInitCost,Receipe.TotalCost,Receipe.Qty,Item.ItemCode FROM Receipe INNER JOIN Item ON(Item.ItemId = Receipe.MatId) WHERE Receipe.ItemId='" & ItemId & "'")
                            Dim selectSaleItemId As DataTable = executesql("SELECT Max(SaleItemId) As SaleItemId FROM SaleItem")
                            If IsNothing(SelectReceipe) Then
                                'DisStock
                                If SelectDataItem(0)("IsTrackStock") = 1 Then
                                    MatAmount = Qty
                                    'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                    MatAmount = Qty
                                    ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                End If
                            ElseIf SelectReceipe.Rows.Count = 0 Then
                                'DisStock
                                If SelectDataItem(0)("IsTrackStock") = 1 Then
                                    MatAmount = Qty
                                    'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                ElseIf SelectDataItem(0)("IsTrackStock") = 0 Then
                                    MatAmount = Qty
                                    ''MsgBox(SelectDataItem(i)("ItemCode"))
                                    ''executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount & "' WHERE ItemId='" & ItemId & "'")
                                End If
                            Else
                                For j As Integer = 0 To SelectReceipe.Rows.Count - 1
                                    MatAmount2 = SelectReceipe(j)("Qty")
                                    MatInitCostUseReceipe = SelectReceipe(j)("MatInitCost")
                                    MatUnitCostUseReceipe = SelectReceipe(j)("MatUnitCost")
                                    TotalInitCostUseReceip = SelectReceipe(j)("TotalInitCost")
                                    TotalCostUseReceipe = SelectReceipe(j)("TotalCost")
                                    executesql("INSERT INTO UseReceipeItem(SaleItemId,ItemId,MatId,Qty,MatInitCostUseReceipe,MatUnitCostUseReceipe,TotalInitCostUseReceipe,TotalCostUseReceipe,InsertDate) VALUES('" & SaleItemId & "','" & ItemId & "','" & SelectReceipe(j)("MatId") & "','" & SelectReceipe(j)("Qty") * Qty & "','" & MatInitCostUseReceipe & "','" & MatUnitCostUseReceipe & "','" & TotalInitCostUseReceip & "','" & TotalCostUseReceipe & "','" & InsertDate & "')")
                                    'executesql("UPDATE UnitInStock SET Qty = Qty -'" & MatAmount2 * Qty & "' WHERE ItemId='" & SelectReceipe(j)("MatId") & "'")
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
                                            'executesql("UPDATE UnitInStock SET Qty = Qty - '" & q & "' WHERE ItemId='" & tItemid & "'")
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
                        End If
                    End If
                End If
                If POS.DataGridViewPOS.Rows(i).Cells("ส่วนลด").Value = 0 Then
                    AmountDC = POS.txtDiscount.Text
                End If
            Next
            If checkTax = True Then
                executesql("update Sale set TaxAmt = '" & TaxAmt & "' where SaleId = '" & GetSaleId & "'")
            ElseIf checkDisc = False Then
                executesql("update Sale set AmountDC='" & AmountDC & "' where SaleId = '" & GetSaleId & "'")
            End If
            'CheckItem
        End If
        ClearPos()
        Pos_SaveSaleName.Close()
        'Pos_SaveSale.Show()
        loadData()
    End Sub
End Module
