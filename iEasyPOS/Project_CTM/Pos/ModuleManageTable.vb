Module ModuleManageTable
    Sub LoadZone()
        FrmTable_Manage.FlowLayoutPanelZone.Controls.Clear()
        Dim LoadDataZone As DataTable = executesql("SELECT ZoneId,ZoneName,BackgroundColor FROM Zones WHERE Active=1 ORDER BY ZoneName ASC")
        For i As Integer = 0 To LoadDataZone.Rows.Count - 1
            Dim zonename As New Button
            zonename.Name = LoadDataZone(i)(0) 'id
            zonename.Text = LoadDataZone(i)("ZoneName")
            zonename.Height = 80
            zonename.Width = 200
            zonename.BackColor = Color.FromArgb(LoadDataZone(i)("BackgroundColor"))
            zonename.FlatStyle = FlatStyle.Flat
            'zonename.Image = Global.Project_CTM.My.Resources.Resources.zone_s
            'zonename.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
            zonename.Font = New Font("Sukhumvit Set", 18, FontStyle.Bold)
            zonename.TextAlign = ContentAlignment.MiddleCenter
            zonename.ForeColor = Color.WhiteSmoke
            FrmTable_Manage.FlowLayoutPanelZone.Controls.Add(zonename)
            AddHandler zonename.Click, AddressOf getZone
        Next
    End Sub
    Dim ZoneId As Integer = 0
    Dim ZoneName As String = ""
    Sub getZone(sender As Object, e As EventArgs)
        ZoneId = sender.Name
        ZoneName = sender.Text
        LoadTable()
    End Sub
    Sub LoadTable()
        FrmTable_Manage.FlowLayoutPanelTable.Controls.Clear()
        Dim LoadDatatable As DataTable
        If POS.TableManageTypeId = 2 Then
            LoadDatatable = executesql("SELECT TableId,TableName,StateStatus FROM Tables WHERE ZoneId='" & ZoneId & "' and TableId <> '" & ModuleZoneTable.TableId & "' AND Active=1 And StateStatus=0 ORDER BY TableId ASC")
        ElseIf POS.TableManageTypeId = 1 Then
            LoadDatatable = executesql("SELECT TableId,TableName,StateStatus FROM Tables WHERE ZoneId='" & ZoneId & "' AND Active=1 ORDER BY TableId ASC")
        End If
        If IsNothing(LoadDatatable) Then
            Exit Sub
        ElseIf LoadDatatable.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New Button
            BtnTable.Name = LoadDatatable(i)("TableId")
            BtnTable.Text = LoadDatatable(i)("TableName")
            BtnTable.Height = 140
            BtnTable.Width = 150
            If LoadDatatable(i)("StateStatus") = 0 Then
                BtnTable.BackColor = Color.DodgerBlue
            Else
                BtnTable.BackColor = Color.Red
            End If
            BtnTable.FlatStyle = FlatStyle.Flat
            BtnTable.Image = Global.Project_CTM.My.Resources.Resources.Household_Table_icon
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.ForeColor = Color.WhiteSmoke
            FrmTable_Manage.FlowLayoutPanelTable.Controls.Add(BtnTable)
            AddHandler BtnTable.Click, AddressOf GetTable
            Dim selectSaleData As DataTable = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3")
            'For j As Integer = 0 To selectSaleData.Rows.Count - 1
            '    Dim txtTableTotal As New Label
            '    If selectSaleData(j)("Active") = 0 Then
            '        txtTableTotal.Visible = False
            '    Else
            '        txtTableTotal.Text = "฿ " + FormatNumber(selectSaleData(j)("SubTotal"), 2)
            '    End If
            '    txtTableTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            '    txtTableTotal.TextAlign = ContentAlignment.MiddleCenter
            '    txtTableTotal.ForeColor = Color.White
            '    'txtTableTotal.BackColor = Color.DodgerBlue
            '    txtTableTotal.AutoSize = False
            '    txtTableTotal.Width = 100
            '    txtTableTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            '    txtTableTotal.Location = New System.Drawing.Point(20, 2)
            '    BtnTable.Controls.Add(txtTableTotal)
            'Next
            'AddHandler BtnTable.Click, AddressOf GetTable
        Next
    End Sub
    Dim TableId As Integer = 0
    Dim TableName As String = ""
    Dim TableId2 As String = ""
    Dim SaleTabId As Integer = 0
    Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    Sub GetTable(sender As Object, e As EventArgs)
        TableId = sender.name
        TableName = sender.Text
        TableId2 = sender.name
        SaleTabId = ModulePosTable.SaleTableId
        If POS.TableManageTypeId = 1 Then
            'ย้ายโต๊ะ
            executesql("update SaleTabRef set TableId = '" & TableId & "' where SaleTabId = '" & SaleTabId & "'")
            executesql("update SaleTable set SaleName = '" & TableName & "',UpdateDate= '" & UpdateDate & "' where SaleTabId = '" & SaleTabId & "'")
            executesql("update Tables set StateStatus = 1 where TableId = '" & TableId & "'")
            executesql("update Tables set StateStatus = 0 where TableId = '" & ModuleZoneTable.TableId & "'")
            POS.TableManageTypeId = 0
            FrmTable_Manage.Close()
            POS.Close()
            Table.Close()
            Table.Show()
        ElseIf POS.TableManageTypeId = 2 Then
            'รวมโต๊ะ        
            TableName += "," & ModuleZoneTable.TableName
            TableId2 += "," & ModuleZoneTable.TableId
            FrmTable_Manage.txtTableName.Text = TableName
            AddHandler FrmTable_Manage.RadButton10.Click, AddressOf btnSave
        End If
    End Sub
    Sub btnSave()
        executesql("update Tables set StateStatus = 1, IsGroupTable = 1,IsSplitBill = 1,TableName2 = '" & TableName & "',TableId2='" & TableId2 & "' where TableId in (" & ModuleZoneTable.TableId & "," & TableId & ")")
        POS.TableManageTypeId = 0
        FrmTable_Manage.Close()
        POS.Close()
        Table.Close()
        Table.Show()
        'executesql("update SaleTable set SaleName = '" & TableName & "',UpdateDate= '" & UpdateDate & "' where SaleTabId = '" &  & "'")
    End Sub
    Sub LoadBill()
        FrmSplitBill.DataGridViewPOS.Rows.Clear()
        FrmSplitBill.DataGridViewPOS2.Rows.Clear()
        Dim selectSaleId As DataTable
        Dim selectTable As DataTable = executesql("select * from Tables where TableId ='" & ModuleZoneTable.TableId & "'")
        If IsDBNull(selectTable(0)("IsGroupTable")) Then
            selectSaleId = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId='" & ModuleZoneTable.TableId & "' AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
        Else
            If selectTable(0)("IsGroupTable") = 0 Then
                selectSaleId = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId='" & ModuleZoneTable.TableId & "' AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
            Else
                '                Clipboard.SetText("SELECT Sale.SaleId FROM Sale 
                'INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
                'INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
                'INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
                'INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
                'WHERE SaleTabRef.TableId in(" & selectTable(0)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 
                'GROUP BY Sale.SaleId")
                selectSaleId = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & selectTable(0)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
            End If
        End If
        If IsNothing(selectSaleId) Then
            Exit Sub
        End If
        If selectSaleId.Rows.Count > 0 Then
            FrmSplitBill.FlowLayoutPanelBillList.Controls.Clear()
            For i As Integer = 0 To selectSaleId.Rows.Count - 1
                Dim BillList As Button = New Button
                BillList.Name = selectSaleId(i)("SaleId")
                BillList.Text = "บิลที่ " & i + 1
                BillList.Height = 50
                BillList.Width = 60
                FrmSplitBill.FlowLayoutPanelBillList.Controls.Add(BillList)
                AddHandler BillList.Click, AddressOf LoadSaveSaleTable
            Next
        End If
    End Sub
    Dim SaleId As Integer = 0
    Sub LoadSaveSaleTable(sender As Object, e As EventArgs)
        FrmSplitBill.txtDiscount.Text = 0
        SaleId = sender.name
        Dim topping As Integer = Nothing
        Dim selection As Integer = Nothing
        Dim TableId2 As DataTable = executesql("select IsGroupTable,TableId2 From Tables where TableId = '" & ModuleZoneTable.TableId & "'")
        Dim selectSaleData As DataTable
        If IsDBNull(TableId2(0)("IsGroupTable")) Then
            selectSaleData = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
Tables.TableName,SaleTable.SaleTabId
FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE Sale.SaleId='" & ModuleManageTable.SaleId & "' AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101),
Tables.TableName,SaleTable.SaleTabId")
        Else
            If TableId2(0)("IsGroupTable") = 0 Then
                selectSaleData = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
Tables.TableName,SaleTable.SaleTabId
FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE Sale.SaleId='" & ModuleManageTable.SaleId & "' AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101),
Tables.TableName,SaleTable.SaleTabId")
            Else
                selectSaleData = executesql("SELECT Sale.SaleId,Sale.SubTotal,Sale.Total,SaleItem.SaleItemId,SaleItem.ItemId,SaleItem.ItemName,
SUM(SaleItem.Qty) as Qty,SUM(SaleItem.SubTotal) as SaleItem_SubTotal,SaleItem.Total as SaleItem_Total,
SaleItem.BahtDC,SaleItem.PercentDC,Sale.AmountDC,SaleItem.AmtDC,
SaleItem.UnitPrice,SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),
CONVERT(date,SaleItem.UpdateDate ,101) ,SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101) as SaleTable_InsertDate,
CONVERT(date,SaleTable.UpdateDate ,101)  as SaleTable_UpdateDate,
Tables.TableName,SaleTable.SaleTabId
FROM Sale 
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE Sale.SaleId in(" & ModuleManageTable.SaleId & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId,Sale.SubTotal,
Sale.Total,SaleItem.SaleItemId,
SaleItem.ItemId,SaleItem.ItemName,
SaleItem.Total,SaleItem.BahtDC,
SaleItem.PercentDC,SaleItem.AmtDC,SaleItem.UnitPrice,Sale.AmountDC,
SaleItem.InitPrice,CONVERT(date,SaleItem.InsertDate,101),CONVERT(date,SaleItem.UpdateDate ,101),SaleTable.SaleName,
CONVERT(date,SaleTable.InsertDate ,101),
CONVERT(date,SaleTable.UpdateDate ,101),
Tables.TableName,SaleTable.SaleTabId")
            End If

        End If
            If selectSaleData.Rows.Count = 0 Then
            TB_GetSaleId = 0
        Else
            TB_GetSaleId = selectSaleData(0)("SaleId")
        End If
        FrmSplitBill.DataGridViewPOS.Rows.Clear()
        Dim BahtDC As Decimal
        SaleTableId = selectSaleData(0)("SaleTabId")
        FrmSplitBill.DataGridViewPOS.Rows.Clear()
        FrmSplitBill.DataGridViewPOS2.Rows.Clear()
        For i As Integer = 0 To selectSaleData.Rows.Count - 1
            If selectSaleData(i)("BahtDC") <> 0 Then
                POS.DiscountByItem2 = 1
                BahtDC = selectSaleData(i)("BahtDC")
                TB_DisCount = BahtDC
            ElseIf selectSaleData(i)("PercentDC") <> 0 Then
                POS.DiscountByItem2 = 1
                BahtDC = selectSaleData(i)("PercentDC")
                TB_DisCount = BahtDC
            End If
            FrmSplitBill.DataGridViewPOS.Rows.Add(selectSaleData(i)("ItemName"), FormatNumber(selectSaleData(i)("Qty"), 0), FormatNumber(selectSaleData(i)("UnitPrice"), 2), FormatNumber(selectSaleData(i)("SaleItem_SubTotal"), 2), selectSaleData(i)("ItemId"), FormatNumber(BahtDC, 2), selectSaleData(i)("SaleItemId"))
            If selectSaleData(i)("AmountDC") <> 0 Then
                POS.DiscountByItem2 = 2
                TB_DisCount = selectSaleData(i)("AmountDC")
                FrmSplitBill.DataGridViewPOS.Rows(i).Cells("AllowDC").Value = 1
                Type = 1
            End If
            Dim SelectUseTopping As DataTable = executesql("select 
UseTopping.ToppingId,UseTopping.SaleItemId,UseTopping.ToppingName,UseTopping.InsertDate,
SaleItem.ItemId
from UseTopping
inner join SaleItem on(SaleItem.SaleItemId = UseTopping.SaleItemId) 
where SaleItem.SaleItemId='" & selectSaleData(i)("SaleItemId") & "'")
            If SelectUseTopping.Rows.Count > 0 Then
                topping = 1
                For a As Integer = 0 To SelectUseTopping.Rows.Count - 1
                    If SelectUseTopping(a)("ItemId") = selectSaleData(i)("ItemId") Then
                        FrmSplitBill.DataGridViewPOS.Rows(i).Cells("Topping").Value = topping
                    End If
                Next
            End If
            Dim SelectUseSelect As DataTable = executesql("select 
SaleItem.ItemId
from UseSelection
inner join SaleItem on(SaleItem.SaleItemId = UseSelection.SaleItemId) 
where SaleItem.SaleItemId='" & selectSaleData(i)("SaleItemId") & "'")
            If SelectUseSelect.Rows.Count > 0 Then
                selection = 1
                For a As Integer = 0 To SelectUseTopping.Rows.Count - 1
                    If SelectUseSelect(a)("ItemId") = selectSaleData(i)("ItemId") Then
                        FrmSplitBill.DataGridViewPOS.Rows(i).Cells("Selection").Value = selection
                    End If
                Next
            End If
            'POS.DataGridViewPOS.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon
            'POS.DataGridViewPOS.RowsDefaultCellStyle.BackColor = Color.Salmon
        Next
        FrmSplitBill.DataGridViewPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        FrmSplitBill.DataGridViewPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        FrmSplitBill.DataGridViewPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        FrmSplitBill.DataGridViewPOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ModuleManageTable.calculatePrice()
        'totalDiscount += FormatNumber(BahtDC, 2)
        'SubTotal = FormatNumber(selectSaleData(0)("SubTotal"), 2)
        'POS.txtDiscount.Text = totalDiscount
        'POS.txtTotal.Text = SubTotal - totalDiscount
        'POS.txtSubTotal.Text = SubTotal
    End Sub
    Dim totalDiscount As Decimal
    Dim Type As Integer
    Sub calculatePrice()
        TB_Total = 0
        totalDiscount = 0
        FrmSplitBill.txtDiscount.Text = FormatNumber(0, 2)
        For j As Integer = 0 To FrmSplitBill.DataGridViewPOS.RowCount - 1
            TB_Total += FrmSplitBill.DataGridViewPOS.Rows(j).Cells(3).Value
            totalDiscount += FrmSplitBill.DataGridViewPOS.Rows(j).Cells(5).Value
        Next
        'DisCount = 0
        If Type = 0 Then
            FrmSplitBill.txtDiscount.Text = FormatNumber(totalDiscount, 2)
        Else
            FrmSplitBill.txtDiscount.Text = FormatNumber(TB_DisCount, 2)
        End If
        TB_SubTotal = TB_Total - TB_DisCount
        FrmSplitBill.txtTotal.Text = FormatNumber(TB_Total, 2)
        FrmSplitBill.txtSubTotal.Text = FormatNumber(TB_SubTotal, 2)
    End Sub
    Sub calculatePrice2()
        TB_Total = 0
        totalDiscount = 0
        FrmSplitBill.txtDiscount2.Text = FormatNumber(0, 2)
        For j As Integer = 0 To FrmSplitBill.DataGridViewPOS2.RowCount - 1
            TB_Total += FrmSplitBill.DataGridViewPOS2.Rows(j).Cells(3).Value
            totalDiscount += FrmSplitBill.DataGridViewPOS2.Rows(j).Cells(5).Value
        Next
        'DisCount = 0
        If Type = 0 Then
            FrmSplitBill.txtDiscount2.Text = FormatNumber(totalDiscount, 2)
        Else
            FrmSplitBill.txtDiscount2.Text = FormatNumber(TB_DisCount, 2)
        End If
        TB_SubTotal = TB_Total - TB_DisCount
        FrmSplitBill.txtTotal2.Text = FormatNumber(TB_Total, 2)
        FrmSplitBill.txtSubTotal2.Text = FormatNumber(TB_SubTotal, 2)
    End Sub
    Sub MoveRight()
        Dim checked As Boolean = False
        Dim rows As New List(Of String)()
        For i As Integer = 0 To FrmSplitBill.DataGridViewPOS.Rows.Count - 1
            If FrmSplitBill.DataGridViewPOS.Rows(i).Cells("Column5").Value = True Then
                checked = True
                rows.Add(i)
            End If
        Next
        If checked = False Then
            MsgBox("กรุณาเลือกรายการ", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checked = True Then
            Dim myArray As String() = rows.ToArray()
            For i As Integer = 0 To myArray.Length - 1
                'MsgBox(rows(i))
                FrmSplitBill.DataGridViewPOS2.Rows.Add(FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(0).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(1).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(2).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(3).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(4).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(5).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(6).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(7).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(8).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(9).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(10).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(11).Value, FrmSplitBill.DataGridViewPOS.Rows(rows(i)).Cells(12).Value)
            Next
            'FrmSplitBill.DataGridViewPOS.Rows.RemoveAt(11)

            For a As Integer = 0 To myArray.Length - 1
                FrmSplitBill.DataGridViewPOS.Rows.RemoveAt(FrmSplitBill.DataGridViewPOS.CurrentCell.RowIndex)
            Next
            'Dim chk As Boolean = False
            'Dim d As Integer = 0
            'For Each selectedItem As DataGridViewRow In FrmSplitBill.DataGridViewPOS.Rows
            '    'show ids of multiple selected rows
            '    'MsgBox(selectedItem.Cells("Column5").Value)
            '    If selectedItem.Cells("Column5").Value = True Then
            '        FrmSplitBill.DataGridViewPOS.Rows.RemoveAt(d)
            '    End If
            '    d += 1
            'Next selectedItem
            'For Each row As DataGridViewRow In FrmSplitBill.DataGridViewPOS.SelectedRows
            '    FrmSplitBill.DataGridViewPOS.Rows.Remove(row)
            'Next
            ModuleManageTable.calculatePrice()
            ModuleManageTable.calculatePrice2()
        End If
    End Sub
    Sub MoveLeft()
        Dim checked As Boolean = False
        Dim rows As New List(Of String)()
        For i As Integer = 0 To FrmSplitBill.DataGridViewPOS2.Rows.Count - 1
            If FrmSplitBill.DataGridViewPOS2.Rows(i).Cells("Column4").Value = True Then
                checked = True
                rows.Add(i)
            End If
        Next
        If checked = False Then
            MsgBox("กรุณาเลือกรายการ", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checked = True Then
            Dim myArray As String() = rows.ToArray()
            For i As Integer = 0 To myArray.Length - 1
                FrmSplitBill.DataGridViewPOS.Rows.Add(FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(0).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(1).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(2).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(3).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(4).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(5).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(6).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(7).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(8).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(9).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(10).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(11).Value, FrmSplitBill.DataGridViewPOS2.Rows(rows(i)).Cells(12).Value)
                'FrmSplitBill.DataGridViewPOS2.Rows.RemoveAt(i)
            Next
            'For a As Integer = 0 To myArray.Length - 1
            '    If FrmSplitBill.DataGridViewPOS2.Rows(a).Cells("Column4").Value = True Then
            '        FrmSplitBill.DataGridViewPOS2.Rows.RemoveAt(a)
            '    End If
            'Next
            'For j As Integer = 0 To FrmSplitBill.DataGridViewPOS2.Rows.Count - 1
            '    FrmSplitBill.DataGridViewPOS2.Rows(j).Cells("Column4").Value = False
            'Next
            For a As Integer = 0 To myArray.Length - 1
                FrmSplitBill.DataGridViewPOS2.Rows.RemoveAt(FrmSplitBill.DataGridViewPOS2.CurrentCell.RowIndex)
            Next
            ModuleManageTable.calculatePrice2()
            ModuleManageTable.calculatePrice()
        End If
    End Sub
    Sub btnSaveSplitBill()
        If FrmSplitBill.DataGridViewPOS2.RowCount = 0 Then
            Exit Sub
        End If
        Dim TB_saleName As String = POS.txtTableName.Text
        Dim TB_InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim TB_subtotal As Decimal = FrmSplitBill.txtSubTotal2.Text
        Dim TB_total As Decimal = FrmSplitBill.txtTotal2.Text
        Dim TB_IsCloseBill As Integer = 0
        Dim TB_CustomerId As Integer = 0
        Dim TB_Active As Integer = 1
        Dim TB_openUserId As Integer = Frm_Login.UserId
        'Dim TB_Qty As Decimal
        'Dim TB_InitPrice As Decimal
        'Dim TB_UnitPrice As Decimal
        'Dim TB_SubTotalItem As Decimal
        'Dim TB_TotalItem As Decimal
        'Dim TB_TaxItem As Decimal
        'Dim TB_BahtDC As Decimal
        Dim SaleDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim StartTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim EndTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim CloseBillUserId As Integer = Frm_Login.UserId
        Dim OpenUserId As Integer = Frm_Login.UserId
        Dim CurrentUser As Integer = Frm_Login.UserId
        Dim Active As Integer = 3
        Dim IsPrintFullTax As Integer = 1
        Dim IsCloseBill As Integer = 0
        Dim SaveBillCount As Integer = 0
        Dim SubTotal As Decimal = FrmSplitBill.txtSubTotal2.Text
        Dim Total As Decimal = FrmSplitBill.txtTotal2.Text
        Dim Terminalid As Integer = 0
        Dim CustomerId As Integer = FrmCustomerMemberNo.CustomerId
        Dim NumOfCust As Integer = 0
        Dim TaxAmt As Decimal = 0
        Dim SaleName As String = POS.txtTableName.Text
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
        Dim SaleNo As String
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
        For a As Integer = 0 To FrmSplitBill.DataGridViewPOS2.RowCount - 1
            If FrmSplitBill.DataGridViewPOS2.Rows(a).Cells(11).Value Is Nothing Then 'PromotionType
            Else
                aleardyPromotion = True
                PromotionId = FrmSplitBill.DataGridViewPOS2.Rows(a).Cells(11).Value
                ItemPromotionId = FrmSplitBill.DataGridViewPOS2.Rows(a).Cells(12).Value 'ItemIdPromotionId
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
            AmountDC = FrmSplitBill.txtDiscount2.Text
        End If
        'If GetSaleId = 0 Then
        'executesql("INSERT INTO Sale(Subtotal,Total,InsertDate,IsCloseBill,Active,CustomerId,StartTime) VALUES('" & TB_subtotal & "','" & TB_total & "','" & TB_InsertDate & "'," & TB_IsCloseBill & "," & TB_Active & ",'" & TB_CustomerId & "','" & TB_StartTime & "')")
        ''Print_()


        'Dim selectSaleId As DataTable = executesql("SELECT Max(saleId) AS SaleId FROM Sale")
        'Dim GetSaleItemID As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE TerminalName='" & Environment.MachineName & "' AND UserId='" & Frm_Login.UserId & "' AND ItemId='" & TB_ItemId & "'")
        ''Update SaleId
        'For i As Integer = 0 To POS.DataGridViewPOS.RowCount - 1
        '    executesql("UPDATE SaleItem SET SaleId='" & selectSaleId(0)("SaleId") & "',Active=1 WHERE ItemId='" & POS.DataGridViewPOS.Rows(i).Cells("ItemId").Value & "' AND SaleId=0 AND Active=3")
        'Next
        executesql("INSERT INTO Sale(SaleDate,SubTotal,TaxAmt,Total,ABBNo,FullTaxNo,IsPrintFullTax,InsertDate,CloseBillUserId,IsCloseBill,Active,SaveBillCount,CustomerId,NumOfCust,StartTime,TerminalId,TerminalName,AmountDC,SaleNo) VALUES('" & SaleDate & "','" & SubTotal & "','" & TaxAmt & "','" & Total & "','" & ABBNo & "','" & FullTaxNo & "','" & IsPrintFullTax & "','" & InsertDate & "','" & CloseBillUserId & "','" & IsCloseBill & "','" & Active & "','" & SaveBillCount & "','" & CustomerId & "','" & NumOfCust & "','" & StartTime & "','" & Terminalid & "','" & TerminalName & "','" & AmountDC & "','" & SaleNo & "')")

        Dim selectSaleId As DataTable = executesql("SELECT Max(SaleId) As SaleId FROM Sale")
            GetSaleId = selectSaleId(0)("SaleId")
        executesql("INSERT INTO SaleTabRef(TableId) VALUES('" & ModuleZoneTable.TableId & "')")
        Dim selectSaleTabId As DataTable = executesql("SELECT Max(SaleTabId) AS SaleTabId FROM SaleTabRef")
        executesql("INSERT INTO SaleTable(SaleTabId,SaleId,SaleName,InsertDate,OpenUserId,Active,CurrentUserUsed) VALUES('" & selectSaleTabId(0)("SaleTabId") & "','" & selectSaleId(0)("SaleId") & "','" & TB_saleName & "','" & TB_InsertDate & "','" & TB_openUserId & "','" & TB_Active & "','" & Frm_Login.UserId & "')")
        'executesql("UPDATE Tables SET StateStatus=1 WHERE TableId='" & TableId & "'")
        'Insert SaleItem
        For i As Integer = 0 To FrmSplitBill.DataGridViewPOS2.RowCount - 1
            ItemId = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(4).Value 'ItemId
            Qty = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(1).Value
            Dim SelectDataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.CategoryId,Item.IsTrackStock,Tax.Multiply,Item.ItemPrice FROM Item INNER JOIN Tax ON (Tax.TaxId = Item.TaxId) WHERE Item.ItemId='" & ItemId & "'")
            Dim Printer_cate As DataTable = executesql("SELECT CatePrinterName,AllowPrint FROM CategoryItem WHERE CategoryId='" & SelectDataItem(0)("CategoryId") & "'")

            If FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(7).Value = 0 Then 'discountType
                BahtDC = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(5).Value
                PercentDC = 0
            ElseIf FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(7).Value = 1 Then
                PercentDC = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(5).Value
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
            TotalItem = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(2).Value * Qty
            SubTotalItem = (((FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(2).Value * Qty)) - PercentDC) - BahtDC  'FormatNumber(InitPrice * Qty, 2)
            'TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) - ((((SelectDataItem(0)("ItemPrice") * Qty) - PercentDC) - BahtDC) * 100 / (SelectDataItem(0)("Multiply") + 100)))
            TaxAmount = ((((SelectDataItem(0)("ItemPrice") * Qty))) - ((((SelectDataItem(0)("ItemPrice") * Qty))) * 100 / (SelectDataItem(0)("Multiply") + 100)))
            TaxAmt += TaxAmount

            'MsgBox(TotalItem)

            If FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(11).Value Is Nothing Or FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(5).Value <> 0 Then
                executesql("INSERT INTO SaleItem(SaleId,ItemId,CategoryId,ItemCode,ItemName,InitPrice,UnitPrice,Qty,SubTotal,Tax,Total,InsertDate,PercentDC,BahtDC,AmtDC,TerminalName,Active,StatusPrint,PrinterName,UserId) VALUES('" & selectSaleId(0)("SaleId") & "','" & ItemId & "','" & SelectDataItem(0)("CategoryId") & "','" & SelectDataItem(0)("ItemCode") & "','" & FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(0).Value & "','" & InitPrice & "','" & UnitPrice & "','" & Qty & "','" & SubTotalItem & "','" & TaxAmount & "','" & TotalItem & "','" & InsertDate & "','" & PercentDC & "','" & BahtDC & "','" & AmtDC & "','" & TerminalName & "',3," & AllowPrint & ",'" & Printer_cate(0)("CatePrinterName") & "','" & Frm_Login.UserId & "')")
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

                If FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(8).Value = 1 Then
                    Dim ToppingName As String() = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(0).Value.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
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
                If FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(9).Value IsNot Nothing Then 'selection
                    'Insert Selection 
                    Dim Selection As String() = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(0).Value.Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    For g As Integer = 1 To Selection.Length - 1
                        Dim selectSelection As DataTable = executesql("SELECT * FROM Selection WHERE SelectionName='" & Selection(g).Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)(0) & "'")
                        Dim selectionId2 As Integer = FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(9).Value
                        If selectSelection.Rows.Count = 0 Then
                            selectionId2 = 0
                        Else
                            selectionId2 = selectSelection(0)("SelectionId")
                            executesql("INSERT INTO UseSelection(SelectionId,SaleItemId,SelectionName) VALUES('" & selectionId2 & "','" & SaleItemId & "','" & selectSelection(0)("SelectionName") & "')")
                        End If
                    Next
                End If
                executesql("update SaleItem set Active = 0 where SaleItemId = '" & FrmSplitBill.DataGridViewPOS2.Rows(i).Cells(6).Value & "'")
            End If
        Next

        executesql("update Sale set SubTotal -= '" & SubTotal & "',TaxAmt -= '" & TaxAmt & "', Total -= '" & Total & "' where SaleId = '" & TB_GetSaleId & "'") 'บิลเก่า
        executesql("update Sale set TaxAmt = '" & TaxAmt & "' where SaleId = '" & selectSaleId(0)("SaleId") & "'") 'บิลใหม่
        FrmSplitBill.txtSubTotal.Clear()
        FrmSplitBill.txtSubTotal2.Clear()
        FrmSplitBill.txtDiscount.Clear()
        FrmSplitBill.txtDiscount2.Clear()
        FrmSplitBill.txtTotal.Clear()
        FrmSplitBill.txtTotal2.Clear()
        LoadBill()
        'End If
    End Sub
End Module
