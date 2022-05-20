Module ModuleZoneTable
    Public ZoneId As Integer = 0
    Public ZoneName As String = ""
    Public TableId As Integer = 0
    Public TableName As String = ""
    Public TableId2 As String = ""
    Public TableName2 As String = ""

    Sub LoadZone()
        FrmTable.FlowLayoutPanelZone.Controls.Clear()
        Dim LoadDataZone As DataTable = executesql("SELECT ZoneId,ZoneName,BackgroundColor FROM Zones WHERE Active=1 ORDER BY ZoneName ASC")
        If LoadDataZone.Rows.Count = 0 Then Exit Sub
        For i As Integer = 0 To LoadDataZone.Rows.Count - 1
            Dim zonename As New DevExpress.XtraEditors.SimpleButton
            zonename.Name = LoadDataZone(i)(0) 'id
            zonename.Text = LoadDataZone(i)("ZoneName")
            zonename.Size = New System.Drawing.Size(194, 77)
            zonename.Font = New Font("Kanit", 14, FontStyle.Bold)
            zonename.ForeColor = Color.White
            zonename.LookAndFeel.SkinName = "Office 2019 Colorful"
            zonename.LookAndFeel.UseDefaultLookAndFeel = False
            zonename.LookAndFeel.SkinMaskColor = Color.FromArgb(LoadDataZone(i)("BackgroundColor"))
            zonename.ImageOptions.Image = iEasyPOS.My.Resources.Resources.Icon_ZoneWhite
            zonename.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
            zonename.Cursor = Cursors.Hand
            FrmTable.FlowLayoutPanelZone.Controls.Add(zonename)
            AddHandler zonename.Click, AddressOf getZone


            'Dim zonename As New Button
            'zonename.Name = LoadDataZone(i)(0) 'id
            'zonename.Text = LoadDataZone(i)("ZoneName")
            ''zonename.Height = 80
            ''zonename.Width = 200
            'zonename.Size = New System.Drawing.Size(200, 80)
            'zonename.BackColor = Color.FromArgb(LoadDataZone(i)("BackgroundColor"))
            'zonename.FlatStyle = FlatStyle.Flat
            ''zonename.Image = Global.iEasyPOS.My.Resources.Resources.zone_s
            ''zonename.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
            'zonename.Font = New Font("Kanit", 14, FontStyle.Bold)
            'zonename.TextAlign = ContentAlignment.MiddleCenter
            'zonename.ForeColor = Color.WhiteSmoke
            'zonename.Cursor = Cursors.Hand
            'FrmTable.FlowLayoutPanelZone.Controls.Add(zonename)
            'AddHandler zonename.Click, AddressOf getZone
        Next
    End Sub
    Sub getZone(sender As Object, e As EventArgs)
        FrmTable.LbTableSelect.Text = ""
        ZoneId = sender.Name
        ZoneName = sender.Text
        FrmTable.LbZoneSelect.Text = sender.Text
        LoadTable(ZoneId)
    End Sub
    Sub DeleteZone()
        Dim Answer As Integer = MsgBox("แน่ใจว่าต้องการลบ :" + ZoneName, vbOKCancel)
        Dim DeleteDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
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
            ModuleZoneTable.LoadZone()
            Dim MinZone As DataTable = executesql("select min(ZoneId) as ZoneId ,ZoneName from Zones where Active=1 GROUP BY ZoneName")
            If MinZone.Rows.Count = 0 Then Exit Sub
            ModuleZoneTable.LoadTable(MinZone(0)("ZoneId"))
            FrmTable.LbZoneSelect.Text = MinZone(0)("ZoneName")
            'clear
            'DisCount = 0
            Type = Nothing
            TB_DisCount = 0
            POS.DiscountByItem2 = Nothing
            Exit Sub
        ElseIf Answer = vbCancel Then
            Exit Sub
        End If
    End Sub
    Sub LoadTable(ByVal zoneid As Integer)
        FrmTable.FlowLayoutPanelTable.Controls.Clear()
        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE ZoneId='" & zoneid & "' AND Active=1 ORDER BY TableId ASC")
        If IsNothing(LoadDatatable) Then
            Exit Sub
        ElseIf LoadDatatable.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim checkSplitBill As DataTable
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New Button
            BtnTable.Name = LoadDatatable(i)("TableId")
            Try
                BtnTable.AccessibleName = LoadDatatable(i)("TableId2")
                BtnTable.AccessibleDescription = LoadDatatable(i)("TableName2")
            Catch ex As Exception
            End Try
            If IsDBNull(LoadDatatable(i)("IsGroupTable")) Then
                BtnTable.Text = LoadDatatable(i)("TableName")
                'BtnTable.Height = 140
                'BtnTable.Width = 150
                BtnTable.Size = New System.Drawing.Size(150, 140)
                If LoadDatatable(i)("StateStatus") = 0 Then
                    BtnTable.BackColor = Color.FromArgb(45, 149, 239)
                    BtnTable.FlatAppearance.BorderColor = Color.FromArgb(45, 149, 239)
                    BtnTable.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 149, 239)
                    BtnTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 149, 239)
                    BtnTable.Tag = "blue"
                Else
                    BtnTable.BackColor = Color.Red
                    BtnTable.FlatAppearance.BorderColor = Color.Red
                    BtnTable.FlatAppearance.MouseDownBackColor = Color.Red
                    BtnTable.FlatAppearance.MouseOverBackColor = Color.Red
                    BtnTable.Tag = "red"
                End If
                checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 GROUP BY Sale.SaleId")
            Else
                If LoadDatatable(i)("IsGroupTable") = 0 Then
                    BtnTable.Text = LoadDatatable(i)("TableName")
                    BtnTable.Height = 140
                    BtnTable.Width = 150
                    If LoadDatatable(i)("StateStatus") = 0 Then
                        BtnTable.BackColor = Color.FromArgb(45, 149, 239)
                        BtnTable.FlatAppearance.BorderColor = Color.FromArgb(45, 149, 239)
                        BtnTable.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 149, 239)
                        BtnTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 149, 239)
                        BtnTable.Tag = "blue"
                    Else
                        BtnTable.BackColor = Color.Red
                        BtnTable.FlatAppearance.BorderColor = Color.Red
                        BtnTable.FlatAppearance.MouseDownBackColor = Color.Red
                        BtnTable.FlatAppearance.MouseOverBackColor = Color.Red
                        BtnTable.Tag = "red"
                    End If
                    checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 GROUP BY Sale.SaleId")
                Else
                    BtnTable.Text = LoadDatatable(i)("TableName2")
                    BtnTable.Height = 140
                    BtnTable.Width = 150
                    BtnTable.BackColor = Color.BlueViolet
                    BtnTable.FlatAppearance.BorderColor = Color.BlueViolet
                    BtnTable.FlatAppearance.MouseDownBackColor = Color.BlueViolet
                    BtnTable.FlatAppearance.MouseOverBackColor = Color.BlueViolet
                    BtnTable.Tag = "violet"
                    checkSplitBill = executesql("SELECT Sale.SaleId FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 GROUP BY Sale.SaleId")
                End If
            End If
            BtnTable.Cursor = Cursors.Hand
            BtnTable.FlatStyle = FlatStyle.Flat
            'BtnTable.Image = Global.iEasyPOS.My.Resources.Resources.Household_Table_icon
            BtnTable.Image = iEasyPOS.My.Resources.Resources.test3
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Kanit", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.ForeColor = Color.WhiteSmoke
            FrmTable.FlowLayoutPanelTable.Controls.Add(BtnTable)
            Dim selectSaleData As DataTable
            Dim Subtotal As Decimal = 0
            If checkSplitBill.Rows.Count > 1 Then
                If IsDBNull(LoadDatatable(i)("IsGroupTable")) Then
                    selectSaleData = executesql("SELECT Sale.SaleId,Sale.Active  FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3 group by Sale.SaleId,Sale.Active")
                    For j As Integer = 0 To selectSaleData.Rows.Count - 1
                        Dim subTotals As DataTable = executesql("select SubTotal from Sale where SaleId='" & selectSaleData(j)("SaleId") & "'")
                        For a As Integer = 0 To subTotals.Rows.Count - 1
                            Subtotal += subTotals(a)("SubTotal")
                        Next
                    Next
                Else
                    If LoadDatatable(i)("IsGroupTable") = 0 Then
                        selectSaleData = executesql("SELECT Sale.SaleId,Sale.Active  FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3 group by Sale.SaleId,Sale.Active")
                        For j As Integer = 0 To selectSaleData.Rows.Count - 1
                            Dim subTotals As DataTable = executesql("select SubTotal from Sale where SaleId='" & selectSaleData(j)("SaleId") & "'")
                            For a As Integer = 0 To subTotals.Rows.Count - 1
                                Subtotal += subTotals(a)("SubTotal")
                            Next
                        Next
                    Else
                        selectSaleData = executesql("SELECT Sale.SaleId,Sale.Active  FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(i)("TableId2") & ") and Sale.Active = 3 and SaleItem.Active=3 group by Sale.SaleId,Sale.Active")
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
                txtTableTotal.Font = New System.Drawing.Font("Kanit", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
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
        FrmTable.FlowLayoutPanelTable.Controls.Clear()
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

            Try
                BtnTable.AccessibleName = LoadDatatable(i)("TableId2")
                BtnTable.AccessibleDescription = LoadDatatable(i)("TableName2")
            Catch ex As Exception
            End Try

            BtnTable.Height = 140
            BtnTable.Width = 150
            If LoadDatatable(i)("StateStatus") = 0 Then
                BtnTable.BackColor = Color.FromArgb(45, 149, 239)
                BtnTable.FlatAppearance.BorderColor = Color.FromArgb(45, 149, 239)
                BtnTable.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 149, 239)
                BtnTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 149, 239)
            Else
                BtnTable.BackColor = Color.Red
                BtnTable.FlatAppearance.BorderColor = Color.Red
                BtnTable.FlatAppearance.MouseDownBackColor = Color.Red
                BtnTable.FlatAppearance.MouseOverBackColor = Color.Red
            End If
            BtnTable.FlatStyle = FlatStyle.Flat
            'BtnTable.Image = Global.iEasyPOS.My.Resources.Resources.Household_Table_icon
            BtnTable.Image = iEasyPOS.My.Resources.Resources.test3
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Kanit", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.ForeColor = Color.WhiteSmoke
            BtnTable.Cursor = Cursors.Hand
            FrmTable.FlowLayoutPanelTable.Controls.Add(BtnTable)
            'Dim selectSaleData As DataTable = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3")

            Dim selectSaleData As DataTable = executesql("SELECT  Sale.Active, Sale.SaleId, Sale.SubTotal FROM Sale INNER JOIN SaleTable ON SaleTable.SaleId = Sale.SaleId INNER JOIN SaleTabRef ON SaleTabRef.SaleTabId = SaleTable.SaleTabId INNER JOIN Tables ON Tables.TableId = SaleTabRef.TableId WHERE (SaleTabRef.TableId = " & BtnTable.Name & ") and Sale.Active=3")

            Dim txtTableTotal As New Label
            If selectSaleData.Rows.Count = 0 Then
                txtTableTotal.Visible = False
            ElseIf selectSaleData(0)("Active") = 0 Then
                txtTableTotal.Text = "฿ " + FormatNumber(0, 2)
            Else
                txtTableTotal.Text = "฿ " + FormatNumber(selectSaleData(0)("SubTotal"), 2)
            End If
            txtTableTotal.Font = New System.Drawing.Font("Kanit", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            txtTableTotal.TextAlign = ContentAlignment.MiddleCenter
            txtTableTotal.ForeColor = Color.White
            'txtTableTotal.BackColor = Color.DodgerBlue
            txtTableTotal.AutoSize = False
            txtTableTotal.Width = 100
            txtTableTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            txtTableTotal.Location = New System.Drawing.Point(20, 2)
            BtnTable.Controls.Add(txtTableTotal)

            AddHandler BtnTable.Click, AddressOf GetTable
        Next
        ZoneId = LoadDatatable(0)("ZoneId")
    End Sub
    Sub Add_Qtable()
        FrmTable.FlowLayoutPanelTable.Controls.Clear()
        FrmTable.FlowLayoutPanelZone.Visible = False
        FrmTable.Panel1.Visible = False
        FrmTable.Panel4.Visible = False
        Dim LoadDatatable As DataTable = executesql("Select TableId,TableName FROM Tables WHERE TableTypeId='" & SelectQ.TableTypeId_send & "' AND Active=1 AND StateStatus=0")
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New Button
            BtnTable.Name = LoadDatatable(i)("TableId")
            BtnTable.Text = LoadDatatable(i)("TableName")
            BtnTable.Height = 140
            BtnTable.Width = 150
            BtnTable.BackColor = Color.DodgerBlue
            BtnTable.Image = Global.iEasyPOS.My.Resources.Resources.Household_Table_icon
            BtnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            BtnTable.Font = New Font("Kanit", 14, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.BottomCenter
            BtnTable.FlatStyle = FlatStyle.Flat
            BtnTable.ForeColor = Color.WhiteSmoke
            FrmTable.FlowLayoutPanelTable.Controls.Add(BtnTable)
            AddHandler BtnTable.Click, AddressOf GetTable
        Next
    End Sub
    Sub ResetQ()
        executesql("TRUNCATE TABLE Queue")
    End Sub
    Public TB_GetSaleId As Integer = 0
    Public BackColorTable As String = ""
    'Dim Frm_selectBill As Object = New Form
    Sub GetTable(sender As Object, e As EventArgs)
        If ModuleZoneTable.ZoneId = 0 Then
            MsgBox("กรุณาเลือกโซนก่อน", MsgBoxStyle.Information, "เลือกโซน")
            Exit Sub
        End If
        If FrmTable.LbZoneSelect.Text = Nothing Then
            MsgBox("กรุณาเลือกโซนก่อน", MsgBoxStyle.Information, "เลือกโซน")
            Exit Sub
        End If
        TableId = sender.Name
        TableName = sender.Text
        TableId2 = sender.AccessibleName
        TableName2 = sender.AccessibleDescription
        FrmTable.LbTableSelect.Text = sender.Text
        BackColorTable = sender.Tag
        'customer
        FrmCustomerMemberNo.CustomerId = 0
        POS.BtnPoint.Enabled = False
        POS.PanelMember.Visible = False
        POS.LabelMemberName.Text = ""
        FrmCustomerMemberNo.customerMemNo = 0
        ModuleZoneTable.OpenTable()
    End Sub
    Sub LoadStatusTable()
        Dim LoadDatatable As DataTable = executesql("SELECT StateStatus FROM Tables WHERE TableId='" & TableId & "' AND Active=1")
        If LoadDatatable(0)("StateStatus") = 1 Then
            ModulePosTable.LoadSaveSaleTable()
        End If
    End Sub

    Sub LoadTableType()
        Dim DataTableType As DataTable = executesql("SELECT TableTypeId,TableTypeName FROM TableType")
        'FrmAddTable.ComboBoxTableType.DataSource = DataTableType
        'FrmAddTable.ComboBoxTableType.DisplayMember = "TableTypeName"
        'FrmAddTable.ComboBoxTableType.ValueMember = "TableTypeId"
        For i As Integer = 0 To DataTableType.Rows.Count - 1
            FrmAddTable.ComboBoxTableType.Properties.Items.Add(DataTableType(i)("TableTypeName"))
        Next
    End Sub
    Sub OpenTable()
        'เปิดโต๊ะ
        'executesql("UPDATE Tables SET StateStatus=1 WHERE TableId='" & TableId & "'")
        'MsgBox("TableId = " & TableId)
        'MsgBox("TableName = " & TableName)
        'MsgBox("TableId2 = " & TableId2)
        'MsgBox("TableName2 = " & TableName2)

        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE TableId='" & TableId & "'")
        Dim SelectSaleID As DataTable
        Dim checkSplitBill As DataTable
        If IsDBNull(LoadDatatable(0)("IsGroupTable")) Then
            SelectSaleID = executesql("SELECT SaleTable.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name FROM SaleTabRef INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) INNER JOIN Sale ON(Sale.SaleId = SaleTable.SaleId) WHERE SaleTabRef.TableId='" & TableId & "' AND Sale.Active = 3")

            checkSplitBill = executesql("SELECT Sale.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(0)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 GROUP BY Sale.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name")
        Else
            If LoadDatatable(0)("IsGroupTable") = 0 Then
                SelectSaleID = executesql("SELECT SaleTable.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name FROM SaleTabRef INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) INNER JOIN Sale ON(Sale.SaleId = SaleTable.SaleId) WHERE SaleTabRef.TableId='" & TableId & "' AND Sale.Active = 3")

                checkSplitBill = executesql("SELECT Sale.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in(" & LoadDatatable(0)("TableId") & ") AND Sale.Active=3 AND SaleItem.Active=3 GROUP BY Sale.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name")
            Else
                SelectSaleID = executesql("SELECT SaleTable.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name FROM SaleTabRef INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) INNER JOIN Sale ON (Sale.SaleId = SaleTable.SaleId) WHERE SaleTabRef.TableId in (" & LoadDatatable(0)("TableId2") & ") AND Sale.Active = 3")

                checkSplitBill = executesql("SELECT Sale.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name FROM Sale INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId) INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId) INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId) INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId in (" & LoadDatatable(0)("TableId2") & ") AND Sale.Active=3 AND SaleItem.Active=3 GROUP BY Sale.SaleId,SaleTabRef.BillSplit_Id,SaleTabRef.BillSplit_Name")
            End If
        End If

        If checkSplitBill.Rows.Count > 1 Then
            'เลือก Bill
            'Frm_selectBill.Text = "เลือกบิลที่จะทำรายการ"
            'Frm_selectBill.controls.clear
            'Dim FLayoutBills As Object = New FlowLayoutPanel
            'Frm_selectBill.Controls.Add(FLayoutBills)
            'FLayoutBills.dock = System.Windows.Forms.DockStyle.Fill
            'FLayoutBills.controls.clear

            FrmSelectBill.FlowLayoutPanel1.Controls.Clear()
            For i As Integer = 0 To checkSplitBill.Rows.Count - 1
                Dim BillButton As New DevExpress.XtraEditors.SimpleButton
                'BillButton.Name = "BILLNAME " & SelectSaleID(i)("BillSplit_Id")
                If SelectSaleID.Rows.Count = 0 Then
                    TB_GetSaleId = 0
                Else
                    TB_GetSaleId = SelectSaleID(0)("SaleId")
                    GetSaleId = TB_GetSaleId
                End If
                BillButton.Name = SelectSaleID(i)("SaleId")
                'BillButton.Text = SelectSaleID(i)("SaleId")
                BillButton.Text = "บิลที่ " & SelectSaleID(i)("BillSplit_Id")
                BillButton.Size = New System.Drawing.Size(138, 55)
                BillButton.Font = New Font("Kanit", 12, FontStyle.Bold)
                BillButton.ForeColor = Color.White
                BillButton.LookAndFeel.SkinName = "Office 2019 Colorful"
                BillButton.LookAndFeel.UseDefaultLookAndFeel = False
                BillButton.LookAndFeel.SkinMaskColor = Color.FromArgb(45, 149, 239)
                'BillButton.ImageOptions.Image = iEasyPOS.My.Resources.Resources.Icon_ZoneWhite
                'BillButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
                BillButton.Cursor = Cursors.Hand
                FrmSelectBill.FlowLayoutPanel1.Controls.Add(BillButton)
                AddHandler BillButton.Click, AddressOf OpenBills
            Next
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(FrmSelectBill.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.6
                plexi.Show()
                FrmSelectBill.StartPosition = FormStartPosition.CenterParent
                FrmSelectBill.ShowDialog(plexi)
            End Using
        Else
            If SelectSaleID.Rows.Count = 0 Then
                TB_GetSaleId = 0

                If dtRolesUser.cancleSale = True Then
                    POS.DataGridViewPOS.Columns(13).Visible = True
                Else
                    POS.DataGridViewPOS.Columns(13).Visible = False
                End If

            Else
                TB_GetSaleId = SelectSaleID(0)("SaleId")
                GetSaleId = TB_GetSaleId
                If dtRolesUser.cancleSale = True Then
                    POS.DataGridViewPOS.Columns(13).Visible = True
                Else
                    POS.DataGridViewPOS.Columns(13).Visible = False
                End If
            End If

            Main2.TabControlMain.SelectedTabPageIndex = 0
            Main2.LabelPageName.Text = TableName
            'POS.BtnGroupTable.Visible = True
            'POS.BtnSplitBill.Visible = True
            'POS.BtnMoveTable.Visible = True

            POS.TopLevel = False
            POS.FormBorderStyle = FormBorderStyle.None
            POS.WindowState = FormWindowState.Maximized
            POS.Dock = DockStyle.Fill
            POS.TextBox3.Focus()
            POS.DataGridViewPOS.Rows.Clear()

            POS.Panel28.Visible = True
            POS.Refresh()

            POS.BtnOpenSaveSale.Enabled = False

            Dim NameBill As DataTable = executesql("select BillSplit_Id,BillSplit_Name from Sale where SaleId = '" & GetSaleId & "'")
            If GetSaleId = 0 Then
                POS.LabelPageName.Text = "โซน : " & FrmTable.LbZoneSelect.Text & " , " & "โต๊ะ : " & FrmTable.LbTableSelect.Text & " , " & "บิล : " & "บิลที่ 1"
            Else
                POS.LabelPageName.Text = "โซน : " & FrmTable.LbZoneSelect.Text & " , " & "โต๊ะ : " & FrmTable.LbTableSelect.Text & " , " & "บิล : " & NameBill(0)("BillSplit_Name")
            End If

            Main2.XtraTabPage1.Controls.Add(POS)
            POS.BtnOpenSaveSale.Enabled = True
            POS.Show()

            'ModulePosTable.TableZoneName()
            LoadStatusTable()
            LoadZone()
            First_LoadTable()
        End If
        POS.BtnOpenSaveSale.Enabled = False
        If TableId = 0 Then
            POS.BtnDelSale.Text = "ยกเลิกการขาย"
        Else
            POS.BtnDelSale.Text = "ยกเลิกโต๊ะ"
        End If
    End Sub
    Sub OpenBills(sender As Object, e As EventArgs)
        TB_GetSaleId = sender.name
        MsgBox("1 =" & TB_GetSaleId)
        'Dim LoadDatatable As DataTable = executesql("SELECT TableId,TableName,TableId2,TableName2 FROM Tables WHERE TableId2='" & TableId2 & "'")
        'If LoadDatatable.Rows.Count = 0 Then
        '    TB_GetSaleId = sender.name
        '    MsgBox("1 =" & TB_GetSaleId)
        'Else
        '    Dim CheckBillId As DataTable = executesql("select SaleId,TableId,BillSplit_Id,BillSplit_Name from SaleTable where TableId in (" & TableId2 & ") and BillSplit_Name = '" & sender.text & "' and Active = 1")
        '    TB_GetSaleId = CheckBillId(0)("SaleId")
        '    MsgBox("2 =" & TB_GetSaleId)
        'End If

        Main2.TabControlMain.SelectedTabPageIndex = 0
        Main2.LabelPageName.Text = TableName

        POS.BtnGroupTable.Visible = True
        POS.BtnSplitBill.Visible = True
        POS.BtnMoveTable.Visible = True

        POS.TopLevel = False
        POS.FormBorderStyle = FormBorderStyle.None
        POS.WindowState = FormWindowState.Maximized
        POS.Dock = DockStyle.Fill
        POS.TextBox3.Focus()
        POS.DataGridViewPOS.Rows.Clear()
        POS.LabelPageName.Text = "โซน : " & FrmTable.LbZoneSelect.Text & " , " & "โต๊ะ : " & FrmTable.LbTableSelect.Text & " , " & "บิล : " & sender.text
        POS.BtnOpenSaveSale.Enabled = False
        POS.Panel28.Visible = True

        Main2.XtraTabPage1.Controls.Add(POS)
        POS.BtnOpenSaveSale.Enabled = True
        POS.Show()

        ModulePosTable.TableZoneName()
        LoadStatusTable()
        MsgBox("TB_GetSaleId = " & TB_GetSaleId)
        FrmSelectBill.Close()
    End Sub
End Module
