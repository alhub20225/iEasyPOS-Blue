Module ModuleManageTable2
    Public ZoneId_Zone As Integer = 0
    Public ZoneName_Zone As String = ""
    Public TableId_Zone As Integer = 0
    Public TableName_Zone As String = ""
    Public TableId2_Zone As String = ""
    Public UpdateDate_Zone As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
    Sub LoadZone()
        FrmManageTable.FlowLayoutPanelZone.Controls.Clear()
        Dim LoadDataZone As DataTable = executesql("SELECT ZoneId,ZoneName,BackgroundColor FROM Zones WHERE Active=1 ORDER BY ZoneName ASC")
        For i As Integer = 0 To LoadDataZone.Rows.Count - 1
            Dim zonename As New DevExpress.XtraEditors.SimpleButton
            zonename.Name = LoadDataZone(i)(0) 'id
            zonename.Text = LoadDataZone(i)("ZoneName")
            zonename.Size = New System.Drawing.Size(135, 53)
            zonename.Font = New Font("Kanit", 12, FontStyle.Bold)
            zonename.ForeColor = Color.White
            zonename.LookAndFeel.SkinName = "Office 2019 Colorful"
            zonename.LookAndFeel.UseDefaultLookAndFeel = False
            zonename.LookAndFeel.SkinMaskColor = Color.FromArgb(40, 179, 81)
            zonename.Cursor = Cursors.Hand
            FrmManageTable.FlowLayoutPanelZone.Controls.Add(zonename)
            AddHandler zonename.Click, AddressOf getZone
        Next
    End Sub
    Sub getZone(sender As Object, e As EventArgs)
        ZoneId_Zone = sender.Name
        ZoneName_Zone = sender.Text
        FrmManageTable.txtZoneName.Text = sender.Text
        LoadTable(ZoneId_Zone)
    End Sub
    Sub LoadTable(ByVal ZoneId_Zone As Integer)
        FrmManageTable.FlowLayoutPanelTable.Controls.Clear()
        'Dim LoadDatatable As DataTable
        Dim LoadDatatable As DataTable = executesql("SELECT * FROM Tables WHERE ZoneId='" & ZoneId_Zone & "' AND Active=1 ORDER BY TableId ASC")
        If IsNothing(LoadDatatable) Then
            Exit Sub
        ElseIf LoadDatatable.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To LoadDatatable.Rows.Count - 1
            Dim BtnTable As New DevExpress.XtraEditors.SimpleButton
            BtnTable.Name = LoadDatatable(i)("TableId")

            Try
                BtnTable.AccessibleName = LoadDatatable(i)("TableId2")
            Catch ex As Exception
            End Try

            If IsDBNull(LoadDatatable(i)("IsGroupTable")) Then
                BtnTable.Text = LoadDatatable(i)("TableName")
                If LoadDatatable(i)("StateStatus") = 0 Then
                    BtnTable.LookAndFeel.SkinMaskColor = Color.FromArgb(45, 149, 239)
                Else
                    BtnTable.LookAndFeel.SkinMaskColor = Color.Red
                End If
            Else
                If LoadDatatable(i)("IsGroupTable") = 0 Then
                    BtnTable.Text = LoadDatatable(i)("TableName")
                    If LoadDatatable(i)("StateStatus") = 0 Then
                        BtnTable.LookAndFeel.SkinMaskColor = Color.FromArgb(45, 149, 239)
                    Else
                        BtnTable.LookAndFeel.SkinMaskColor = Color.Red
                    End If
                Else
                    BtnTable.Text = LoadDatatable(i)("TableName2")
                    BtnTable.LookAndFeel.SkinMaskColor = Color.BlueViolet
                End If
            End If
            BtnTable.Size = New System.Drawing.Size(135, 53)
            BtnTable.Font = New Font("Kanit", 12, FontStyle.Bold)
            BtnTable.ForeColor = Color.White
            BtnTable.LookAndFeel.SkinName = "Office 2019 Colorful"
            BtnTable.LookAndFeel.UseDefaultLookAndFeel = False
            BtnTable.Cursor = Cursors.Hand
            FrmManageTable.FlowLayoutPanelTable.Controls.Add(BtnTable)
            AddHandler BtnTable.Click, AddressOf GetTable
            Dim selectSaleData As DataTable = executesql("SELECT Sale.Active,Sale.SaleId,Sale.SubTotal,Sale.Total FROM Sale INNER JOIN SaleItem on (SaleItem.SaleId = Sale.SaleId)INNER JOIN SaleTable on (SaleTable.SaleId = Sale.SaleId)INNER JOIN SaleTabRef on (SaleTabRef.SaleTabId = SaleTable.SaleTabId)INNER JOIN Tables on (Tables.TableId = SaleTabRef.TableId) WHERE SaleTabRef.TableId='" & BtnTable.Name & "' and Sale.Active = 3 and SaleItem.Active=3")
        Next
    End Sub

    Sub GetTable(sender As Object, e As EventArgs)
        TableId_Zone = sender.name
        TableId2_Zone = sender.AccessibleName
        TableName_Zone = sender.Text
        FrmManageTable.txtTableName.Text = sender.Text
    End Sub
End Module
