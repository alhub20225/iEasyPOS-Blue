Imports System.Drawing.Printing
Imports System.Text
Imports DevExpress.BarCodes
Imports Newtonsoft.Json

Public Class frm_barCode
    Dim PPD As New PrintPreviewDialog
    Private Sub frm_barCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCategoryItem(cbbCategory)
    End Sub
    Sub loadCategoryItem(lookups As DevExpress.XtraEditors.LookUpEdit)
        lookups.Properties.DataSource = Nothing
        Dim categoryList As List(Of CategoryItemList) = JsonConvert.DeserializeObject(Of List(Of CategoryItemList))(getDataToClassList("select categoryId as id,categoryName as name from categoryItem where active=1", True))
        'categoryList.Insert(0, productNothing)
        lookups.Properties.DataSource = categoryList
        lookups.Properties.DisplayMember = "name"
        lookups.Properties.ValueMember = "id"
        lookups.Properties.PopupWidth = 500
        lookups.Properties.AutoHeight = True
    End Sub
    Sub ItemAutoCompleteByCode(lookups As DevExpress.XtraEditors.LookUpEdit, categoryId As Integer)
        lookups.Properties.DataSource = Nothing
        Dim productList As List(Of ItemAutoComplete) = New List(Of ItemAutoComplete)
        Dim productNothing As ItemAutoComplete = New ItemAutoComplete With
        {
            .id = 0,
            .name = "",
            .code = ""
        }
        productList = JsonConvert.DeserializeObject(Of List(Of ItemAutoComplete))(getDataToClassList("select itemCode As code,itemName as name,itemId as id from Item where active=1 and categoryId=" & categoryId, True))
        productList.Insert(0, productNothing)
        lookups.Properties.DataSource = productList
        lookups.Properties.DisplayMember = "code"
        lookups.Properties.ValueMember = "id"
        lookups.Properties.PopupWidth = 500
        lookups.Properties.AutoHeight = True
        'AddHandler lookups.Properties.GetNotInListValue, AddressOf Properties_GetNotInListValue
    End Sub

    Sub ItemAutoCompleteByName(lookups As DevExpress.XtraEditors.LookUpEdit, categoryId As Integer)
        lookups.Properties.DataSource = Nothing
        Dim productList As List(Of ItemAutoComplete) = New List(Of ItemAutoComplete)
        Dim productNothing As ItemAutoComplete = New ItemAutoComplete With
        {
            .id = 0,
            .name = "",
            .code = ""
        }
        productList = JsonConvert.DeserializeObject(Of List(Of ItemAutoComplete))(getDataToClassList("select itemCode As code,itemName as name,itemId as id from Item where active=1 and categoryId=" & categoryId, True))
        productList.Insert(0, productNothing)
        lookups.Properties.DataSource = productList
        lookups.Properties.DisplayMember = "name"
        lookups.Properties.ValueMember = "id"
        lookups.Properties.PopupWidth = 500
        lookups.Properties.AutoHeight = True
        'AddHandler lookups.Properties.GetNotInListValue, AddressOf Properties_GetNotInListValue
    End Sub

    Private Sub chkAllItem_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllItem.CheckedChanged
        If chkAllItem.Checked = False Then
            GroupBoxItem.Enabled = True
        Else
            GroupBoxItem.Enabled = False
        End If
    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cbbCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cbbCategory.EditValueChanged
        ItemAutoCompleteByCode(Me.txtItemCode, cbbCategory.EditValue)
        ItemAutoCompleteByName(Me.txtItemName, cbbCategory.EditValue)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllItemByCategory.CheckedChanged
        If chkAllItemByCategory.Checked = False Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub btnAddTo_CheckedChanged(sender As Object, e As EventArgs) Handles btnAddTo.Click
        DataGridItem.Rows.Clear()

        If chkAllItem.Checked = True Then
            Dim allItemByCategory = JsonConvert.DeserializeObject(Of List(Of ItemData))(getDataToClassList("select * from item where active=1", True))
            If allItemByCategory.Count > 0 Then
                For Each itemData As ItemData In allItemByCategory
                    Dim barcode As Image = genBarcodeToImage(itemData.ItemCode)
                    DataGridItem.Rows.Add(barcode, itemData.ItemCode, itemData.ItemName, itemData.ItemId)
                    DataGridItem.Rows(DataGridItem.Rows.Count - 1).Height = 100
                Next
            End If
        Else
            If IsNothing(cbbCategory.EditValue) Then
                MsgBox("กรุณาเลือกหมวดหมู่", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If chkAllItemByCategory.Checked = True Then
                Dim allItemByCategory = JsonConvert.DeserializeObject(Of List(Of ItemData))(getDataToClassList("select * from item where active = 1 and categoryId=" & cbbCategory.EditValue, True))
                If allItemByCategory.Count > 0 Then
                    For Each itemData As ItemData In allItemByCategory
                        Dim barcode As Image = genBarcodeToImage(itemData.ItemCode)
                        DataGridItem.Rows.Add(barcode, itemData.ItemCode, itemData.ItemName, itemData.ItemId)
                        DataGridItem.Rows(DataGridItem.Rows.Count - 1).Height = 100
                    Next
                End If
            Else
                If IsNothing(txtItemName.EditValue) Then
                    MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                Dim allItemByCategory = JsonConvert.DeserializeObject(Of List(Of ItemData))(getDataToClassList("select * from item where active = 1 and itemId=" & txtItemName.EditValue, True))
                If allItemByCategory.Count > 0 Then
                    For Each itemData As ItemData In allItemByCategory
                        Dim barcode As Image = genBarcodeToImage(itemData.ItemCode)
                        DataGridItem.Rows.Add(barcode, itemData.ItemCode, itemData.ItemName, itemData.ItemId)
                        DataGridItem.Rows(DataGridItem.Rows.Count - 1).Height = 100
                    Next
                End If
            End If
        End If
    End Sub

    Function genBarcodeToImage(itemCode As String)
        Dim barCode As New BarCode()
        barCode.Symbology = Symbology.Codabar
        barCode.CodeText = itemCode
        barCode.BackColor = Color.White
        barCode.ForeColor = Color.Black
        barCode.RotationAngle = 0
        barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText)
        barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte
        barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q
        barCode.Options.QRCode.ShowCodeText = False
        barCode.DpiX = 72
        barCode.DpiY = 72
        barCode.Module = 2.0F

        Return barCode.BarCodeImage
    End Function

    Private Sub btnSave_CheckedChanged(sender As Object, e As EventArgs) Handles btnSave.CheckedChanged
        PPD.Document = PrintDocument1
        PrintDocument1.defaultPageSettings.paperSize = New PaperSize("Legal", 850, 1100)
        PPD.WindowState = FormWindowState.Maximized
        PPD.ShowDialog()
    End Sub
    Dim m_CurrentPage As Integer
    Dim m_PageCount As Integer = 0
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x = 40
        Dim y = 10
        Dim w = 223
        Dim h = 74
        Dim i = 3
        Dim r = 30
        If DataGridItem.Rows.Count > 0 Then
            m_PageCount = DataGridItem.Rows.Count
            For j As Integer = m_PageCount To DataGridItem.Rows.Count - 1
                'For i As Integer = 1 To 3

                e.Graphics.DrawImage(genBarcodeToImage(DataGridItem.Rows(j).Cells(1).Value), x, y, w, h)
                x = x + w + 40

                'Next
                Dim yyy = i / (j + 1)
                If (yyy = 1) Then
                    x = 40
                    y = y + h + 40
                    i += 3
                End If
                If (j + 1) / r = 1 Then
                    m_CurrentPage += 1
                    e.HasMorePages = (m_CurrentPage < m_PageCount)
                    r += 30
                End If


            Next
        End If

    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        m_CurrentPage = 0
    End Sub
End Class

Public Class ItemAutoComplete
    'Public productCode As String
    Public Property code As String
    Public Property name As String
    Public Property id As Integer?
End Class

Public Class CategoryItemList
    'Public productCode As String
    Public Property name As String
    Public Property id As Integer?
End Class