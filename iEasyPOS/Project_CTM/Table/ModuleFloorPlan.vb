Imports System.Drawing
Module ModuleFloorPlan
    Public ZoneId_floor As Integer = 0
    Public ZoneName_floor As String = ""
    Public TableId_floor As Integer = 0
    Public TableName_floor As String = ""
    Dim rc As ResizeControl

    Sub LoadZone_floor()
        FloorPlan.FlowLayoutPanelZone.Controls.Clear()
        Table.FlowLayoutPanelZone.Controls.Clear()
        Dim LoadDataZone As DataTable = executesql("SELECT ZoneId,ZoneName,BackgroundColor FROM Zones WHERE Active=1 ORDER BY ZoneName ASC ")
        For i As Integer = 0 To LoadDataZone.Rows.Count - 1
            Dim zonename_floor As New Button
            zonename_floor.Name = LoadDataZone(i)(0) 'id
            zonename_floor.Text = LoadDataZone(i)("ZoneName")
            zonename_floor.Height = 50
            zonename_floor.Width = 150
            zonename_floor.BackColor = Color.FromArgb(LoadDataZone(i)("BackgroundColor"))
            zonename_floor.FlatStyle = FlatStyle.Flat
            zonename_floor.Font = New Font("Sukhumvit Set", 11, FontStyle.Bold)
            zonename_floor.TextAlign = ContentAlignment.MiddleCenter
            zonename_floor.ForeColor = Color.WhiteSmoke
            FloorPlan.FlowLayoutPanelZone.Controls.Add(zonename_floor)
            AddHandler zonename_floor.Click, AddressOf getZone
        Next
    End Sub
    Sub getZone(sender As Object, e As EventArgs)
        ZoneId_floor = sender.Name
        ZoneName = sender.Text
        load_table_floor()
        load_bg_floor()
    End Sub
    Public Sub load_table_floor()
        FloorPlan.Floor.Controls.Clear()
        Dim LoadDatatable As DataTable = executesql("SELECT TableId,TableName,x , y , w , h , StateStatus FROM Tables WHERE ZoneId='" & ZoneId_floor & "' AND Active=1 ORDER BY TableId ASC")
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New Button
            BtnTable.Name = LoadDatatable(i)("TableId")
            BtnTable.Text = LoadDatatable(i)("TableName")
            Dim lox As Integer = LoadDatatable(i)("x")
            Dim loy As Integer = LoadDatatable(i)("y")
            Dim btn_w As Integer = LoadDatatable(i)("w")
            Dim btn_h As Integer = LoadDatatable(i)("h")
            BtnTable.Location = New System.Drawing.Point(lox, loy)
            BtnTable.Height = btn_h
            BtnTable.Width = btn_w
            BtnTable.FlatStyle = FlatStyle.Flat
            BtnTable.FlatAppearance.BorderSize = 1
            BtnTable.BackColor = Color.Transparent
            BtnTable.UseVisualStyleBackColor = False
            BtnTable.Font = New Font("Tahoma", 12, FontStyle.Bold)
            BtnTable.TextAlign = ContentAlignment.MiddleCenter
            If LoadDatatable(i)("StateStatus") = 0 Then
                BtnTable.ForeColor = Color.Green
            ElseIf LoadDatatable(i)("StateStatus") = 1 Then
                BtnTable.ForeColor = Color.Red
            End If
            FloorPlan.Floor.Controls.Add(BtnTable)
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
                txtTableTotal.ForeColor = Color.Black
                'txtTableTotal.BackColor = Color.DodgerBlue
                txtTableTotal.AutoSize = False
                txtTableTotal.Width = 100
                txtTableTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                txtTableTotal.Location = New System.Drawing.Point(20, 2)
                BtnTable.Controls.Add(txtTableTotal)
            Next
            AddHandler BtnTable.Click, AddressOf GetTable
            rc = New ResizeControl(BtnTable)
        Next
    End Sub
    Sub load_bg_floor()
        Try
            FloorPlan.Floor.BackgroundImage = Nothing
            Dim dataimage As DataTable = executesql("SELECT ImageTextBase64 FROM Zones WHERE Zoneid= '" & ZoneId_floor & "' AND Active=1 ")
            Dim img As System.Drawing.Bitmap
            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b() As Byte
            'Converts the base64 encoded msg to image data
            b = Convert.FromBase64String(dataimage(0)("ImageTextBase64"))
            MS = New System.IO.MemoryStream(b)
            'creates image
            'img = System.Drawing.Image.FromStream(MS)
            img = System.Drawing.Bitmap.FromStream(MS)
            FloorPlan.Floor.BackgroundImage = img
            FloorPlan.Floor.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

    End Sub

    Sub GetTable(sender As Object, e As EventArgs)
        TableId = sender.Name
        TableName = sender.Text
        Table.Close()
        POS.Close()
        POS.Show()
        ModulePosTable.TableZoneName()
        LoadStatusTable()
        Dim SelectSaleID As DataTable = executesql("SELECT SaleTable.SaleId FROM SaleTabRef
INNER JOIN SaleTable ON (SaleTable.SaleTabId = SaleTabRef.SaleTabId) 
INNER JOIN Sale ON(Sale.SaleId = SaleTable.SaleId) 
WHERE SaleTabRef.TableId='" & TableId & "' AND Sale.Active = 3")
        If SelectSaleID.Rows.Count = 0 Then
            TB_GetSaleId = 0
        Else
            TB_GetSaleId = SelectSaleID(0)("SaleId")
            GetSaleId = TB_GetSaleId
        End If
    End Sub
End Module
