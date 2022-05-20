Module ModuleZoneTable
    Public ZoneId As Integer = 0
    Public ZoneName As String = ""
    Public TableId As Integer = 0
    Public TableName As String = ""
    Sub LoadZone()
        Table.FlowLayoutPanelZone.Controls.Clear()
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
            Table.FlowLayoutPanelZone.Controls.Add(zonename)
            AddHandler zonename.Click, AddressOf getZone
        Next
    End Sub
    Sub getZone(sender As Object, e As EventArgs)
        ZoneId = sender.Name
        ZoneName = sender.Text
        Table.LbZoneSelect.Text = sender.Text
        LoadTable()
    End Sub
    Sub DeleteZone()
        Dim Answer As Integer = MsgBox("แน่ใจว่าต้องการลบ :" + ZoneName, vbOKCancel)
        Dim DeleteDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        If Answer = vbOK Then
            'Active Zone = 0
            executesql("UPDATE Zones SET Active=0,DeleteDate='" & DeleteDate & "' WHERE ZoneId='" & ZoneId & "'")
            'Delete Tables 
            executesql("UPDATE Tables SET Active=0,DeleteDate='" & DeleteDate & "' WHERE ZoneId='" & ZoneId & "'")
            'Delete Chairs
            Dim DataTableDelete As DataTable = executesql("SELECT TableId FROM Tables WHERE ZoneId='" & ZoneId & "'")
            For i As Integer = 0 To DataTableDelete.Rows.Count - 1
                Dim TableId As Integer = DataTableDelete(i)("TableId")
            Next
            LoadZone()
            MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        ElseIf Answer = vbCancel Then
            Exit Sub
        End If
    End Sub
    Sub LoadTable()
        Table.FlowLayoutPanelTable.Controls.Clear()
        'Clipboard.SetText("SELECT * FROM Tables WHERE ZoneId='" & ZoneId & "' AND Active=1 ORDER BY TableId ASC")
        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE ZoneId='" & ZoneId & "' AND Active=1 ORDER BY TableId ASC")
        If IsNothing(LoadDatatable) Then
            Exit Sub
        ElseIf LoadDatatable.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim checkSplitBill As DataTable
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New Button
            BtnTable.Name = LoadDatatable(i)("TableId")
            If IsDBNull(LoadDatatable(i)("IsGroupTable")) Then
                BtnTable.Text = LoadDatatable(i)("TableName")
                BtnTable.Height = 140
                BtnTable.Width = 150
                If LoadDatatable(i)("StateStatus") = 0 Then
                    BtnTable.BackColor = Color.DodgerBlue
                Else
                    BtnTable.BackColor = Color.Red
                End If
                checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
            Else
                If LoadDatatable(i)("IsGroupTable") = 0 Then
                    BtnTable.Text = LoadDatatable(i)("TableName")
                    BtnTable.Height = 140
                    BtnTable.Width = 150
                    If LoadDatatable(i)("StateStatus") = 0 Then
                        BtnTable.BackColor = Color.DodgerBlue
                    Else
                        BtnTable.BackColor = Color.Red
                    End If
                    checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
                Else
                    BtnTable.Text = LoadDatatable(i)("TableName2")
                    BtnTable.Height = 140
                    BtnTable.Width = 150
                    BtnTable.BackColor = Color.Purple
                    checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
                End If
            End If
            BtnTable.FlatStyle = FlatStyle.Flat
            BtnTable.Image = Global.Project_CTM.My.Resources.Resources.Household_Table_icon
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.ForeColor = Color.WhiteSmoke
            Table.FlowLayoutPanelTable.Controls.Add(BtnTable)
            Dim selectSaleData As DataTable
            Dim Subtotal As Decimal = 0
            If checkSplitBill.Rows.Count > 1 Then
                If IsDBNull(LoadDatatable(i)("IsGroupTable")) Then
                    selectSaleData = executesql("SELECT Sale.SaleId,Sale.Active  FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3 group by Sale.SaleId,Sale.Active")
                    For j As Integer = 0 To selectSaleData.Rows.Count - 1
                        Dim subTotals As DataTable = executesql("select SubTotal from Sale where SaleId='" & selectSaleData(j)("SaleId") & "'")
                        For a As Integer = 0 To subTotals.Rows.Count - 1
                            Subtotal += subTotals(a)("SubTotal")
                        Next
                    Next
                Else
                    If LoadDatatable(i)("IsGroupTable") = 0 Then
                        selectSaleData = executesql("SELECT Sale.SaleId,Sale.Active  FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3 group by Sale.SaleId,Sale.Active")
                        For j As Integer = 0 To selectSaleData.Rows.Count - 1
                            Dim subTotals As DataTable = executesql("select SubTotal from Sale where SaleId='" & selectSaleData(j)("SaleId") & "'")
                            For a As Integer = 0 To subTotals.Rows.Count - 1
                                Subtotal += subTotals(a)("SubTotal")
                            Next
                        Next
                    Else
                        selectSaleData = executesql("SELECT Sale.SaleId,Sale.Active  FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId2") & ") and Sale.Active = 3 and SaleItem.Active=3 group by Sale.SaleId,Sale.Active")
                        For j As Integer = 0 To selectSaleData.Rows.Count - 1
                            Dim subTotals As DataTable = executesql("select SubTotal from Sale where SaleId='" & selectSaleData(j)("SaleId") & "'")
                            For a As Integer = 0 To subTotals.Rows.Count - 1
                                Subtotal += subTotals(a)("SubTotal")
                            Next
                        Next
                    End If
                End If
            Else
                If IsDBNull(LoadDatatable(i)("IsGroupTable")) Then
                    selectSaleData = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3")
                    If selectSaleData.Rows.Count > 0 Then
                        Subtotal = selectSaleData(0)("SubTotal")
                    End If
                Else
                    If LoadDatatable(i)("IsGroupTable") = 0 Then
                        selectSaleData = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3")
                        If selectSaleData.Rows.Count > 0 Then
                            Subtotal = selectSaleData(0)("SubTotal")
                        End If
                    Else
                        selectSaleData = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId2") & ") and Sale.Active = 3 and SaleItem.Active=3")
                        For j As Integer = 0 To selectSaleData.Rows.Count - 1
                            Dim subTotals As DataTable = executesql("select SubTotal from Sale where SaleId='" & selectSaleData(j)("SaleId") & "'")
                            For a As Integer = 0 To subTotals.Rows.Count - 1
                                Subtotal += subTotals(a)("SubTotal")
                            Next
                        Next
                    End If
                End If
            End If
            For j As Integer = 0 To selectSaleData.Rows.Count - 1
                Dim txtTableTotal As New Label
                If selectSaleData(j)("Active") = 0 Then
                    txtTableTotal.Visible = False
                Else

                    txtTableTotal.Text = "฿ " + FormatNumber(Subtotal, 2)
                    Subtotal = 0
                End If
                txtTableTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
                txtTableTotal.TextAlign = ContentAlignment.MiddleCenter
                txtTableTotal.ForeColor = Color.White
                'txtTableTotal.BackColor = Color.DodgerBlue
                txtTableTotal.AutoSize = False
                txtTableTotal.Width = 100
                txtTableTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                txtTableTotal.Location = New System.Drawing.Point(20, 2)
                BtnTable.Controls.Add(txtTableTotal)
            Next
            AddHandler BtnTable.Click, AddressOf GetTable
        Next
    End Sub
    Sub First_LoadTable()
        Table.FlowLayoutPanelTable.Controls.Clear()
        Dim LoadDatatable As DataTable = executesql("Select TableId, TableName,StateStatus,ZoneId FROM Tables WHERE ZoneId=(Select min(ZoneID) FROM Tables) And Active= 1 ORDER BY TableId ASC")
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
            Else BtnTable.BackColor = Color.Red
            End If
            BtnTable.FlatStyle = FlatStyle.Flat
            BtnTable.Image = Global.Project_CTM.My.Resources.Resources.Household_Table_icon
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.ForeColor = Color.WhiteSmoke
            Table.FlowLayoutPanelTable.Controls.Add(BtnTable)
            Dim selectSaleData As DataTable = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3")
            For j As Integer = 0 To selectSaleData.Rows.Count - 1
                Dim txtTableTotal As New Label
                If selectSaleData(j)("Active") = 0 Then
                    txtTableTotal.Visible = False
                Else
                    txtTableTotal.Text = "฿ " + FormatNumber(selectSaleData(j)("SubTotal"), 2)
                End If
                txtTableTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
                txtTableTotal.TextAlign = ContentAlignment.MiddleCenter
                txtTableTotal.ForeColor = Color.White
                'txtTableTotal.BackColor = Color.DodgerBlue
                txtTableTotal.AutoSize = False
                txtTableTotal.Width = 100
                txtTableTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                txtTableTotal.Location = New System.Drawing.Point(20, 2)
                BtnTable.Controls.Add(txtTableTotal)
            Next
            AddHandler BtnTable.Click, AddressOf GetTable
        Next
        ZoneId = LoadDatatable(0)("ZoneId")
    End Sub
    Sub Add_Qtable()
        Table.FlowLayoutPanelTable.Controls.Clear()
        Table.FlowLayoutPanelZone.Visible = False
        Table.Panel1.Visible = False
        Table.Panel4.Visible = False
        Dim LoadDatatable As DataTable = executesql("Select TableId,TableName FROM Tables WHERE TableTypeId='" & SelectQ.TableTypeId_send & "' AND Active=1 AND StateStatus=0")
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New Button
            BtnTable.Name = LoadDatatable(i)("TableId")
            BtnTable.Text = LoadDatatable(i)("TableName")
            BtnTable.Height = 140
            BtnTable.Width = 150
            BtnTable.BackColor = Color.DodgerBlue
            BtnTable.Image = Global.Project_CTM.My.Resources.Resources.Household_Table_icon
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.FlatStyle = FlatStyle.Flat
            BtnTable.ForeColor = Color.WhiteSmoke
            Table.FlowLayoutPanelTable.Controls.Add(BtnTable)
            AddHandler BtnTable.Click, AddressOf GetTable
        Next
    End Sub
    Sub ResetQ()
        executesql("TRUNCATE TABLE Queue")

    End Sub
    Public TB_GetSaleId As Integer
    Dim Frm_selectBill As Object = New Form
    Sub GetTable(sender As Object, e As EventArgs)
        TableId = sender.Name
        TableName = sender.Text
        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE TableId='" & TableId & "'")
        Dim SelectSaleID As DataTable
        Dim checkSplitBill As DataTable
        If IsDBNull(LoadDatatable(0)("IsGroupTable")) Then

            SelectSaleID = executesql("SELECT SaleTable.SaleId FROM SaleTabRef
        INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) 
        INNER JOIN Sale ON(Sale.SaleId = SaleTable.SaleId) 
        WHERE SaleTabRef.TableId='" & TableId & "' AND Sale.Active = 3")
            checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & LoadDatatable(0)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
        Else
            If LoadDatatable(0)("IsGroupTable") = 0 Then
                SelectSaleID = executesql("SELECT SaleTable.SaleId FROM SaleTabRef
        INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) 
        INNER JOIN Sale ON(Sale.SaleId = SaleTable.SaleId) 
        WHERE SaleTabRef.TableId='" & TableId & "' AND Sale.Active = 3")
                checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & LoadDatatable(0)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
            Else
                SelectSaleID = executesql("SELECT SaleTable.SaleId FROM SaleTabRef
        INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) 
        INNER JOIN Sale ON(Sale.SaleId = SaleTable.SaleId) 
        WHERE SaleTabRef.TableId in(" & LoadDatatable(0)("TableId2") & ") AND Sale.Active = 3")
                checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale 
INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)
INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)
INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)
INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) 
WHERE SaleTabRef.TableId in(" & LoadDatatable(0)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 
GROUP BY Sale.SaleId")
            End If

        End If
            If checkSplitBill.Rows.Count > 1 Then
            'เลือก Bill
            Frm_selectBill.Text = "เลือกบิลที่จะทำรายการ"
            Frm_selectBill.controls.clear
            Dim FLayoutBills As Object = New FlowLayoutPanel
            Frm_selectBill.Controls.Add(FLayoutBills)
            FLayoutBills.dock = System.Windows.Forms.DockStyle.Fill
            FLayoutBills.controls.clear
            For i As Integer = 0 To checkSplitBill.Rows.Count - 1
                Dim BillButton As Button = New Button
                If SelectSaleID.Rows.Count = 0 Then
                    TB_GetSaleId = 0
                Else
                    TB_GetSaleId = SelectSaleID(0)("SaleId")
                    GetSaleId = TB_GetSaleId
                End If
                BillButton.Name = checkSplitBill(i)("SaleId")
                BillButton.Text = "บิลที่ " & i + 1
                BillButton.Height = 50
                BillButton.Width = 60
                FLayoutBills.Controls.Add(BillButton)
                AddHandler BillButton.Click, AddressOf OpenBills
            Next
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Frm_selectBill.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                Frm_selectBill.StartPosition = FormStartPosition.CenterParent
                Frm_selectBill.ShowDialog(plexi)
            End Using
        Else
            If SelectSaleID.Rows.Count = 0 Then
                TB_GetSaleId = 0
            Else
                TB_GetSaleId = SelectSaleID(0)("SaleId")
                GetSaleId = TB_GetSaleId
            End If
            Table.Close()
            POS.Close()
            POS.Show()
            ModulePosTable.TableZoneName()
            LoadStatusTable()
        End If
    End Sub
    Sub LoadStatusTable()
        Dim LoadDatatable As DataTable = executesql("SELECT StateStatus FROM Tables WHERE TableId='" & TableId & "' AND Active=1")
        If LoadDatatable(0)("StateStatus") = 1 Then
            ModulePosTable.LoadSaveSaleTable()
        End If
    End Sub

    Sub LoadTableType()
        Dim DataTableType As DataTable = executesql("SELECT TableTypeId,TableTypeName FROM TableType")
        FrmAddTable.ComboBoxTableType.DataSource = DataTableType
        FrmAddTable.ComboBoxTableType.DisplayMember = "TableTypeName"
        FrmAddTable.ComboBoxTableType.ValueMember = "TableTypeId"
    End Sub
    Sub OpenBills(sender As Object, e As EventArgs)
        TB_GetSaleId = sender.name
        Table.Close()
        POS.Close()
        POS.Show()
        ModulePosTable.TableZoneName()
        LoadStatusTable()
        Frm_selectBill.close()
    End Sub
End Module
