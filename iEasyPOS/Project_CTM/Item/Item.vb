Imports System.IO
Imports System.IO.Path
Imports System.IO.File
Imports System.IO.IOException
Imports System.IO.StreamWriter
Imports System.IO.MemoryStream
Imports System.IO.StreamReader
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Serialization.StreamingContext
Imports System.Runtime.Serialization.SerializationInfo
'Imports RasterEdge.Imaging.Basic
'Imports RasterEdge.Imaging.Basic.Core
Imports System.Drawing.Image
Imports System.Drawing.Drawing2D
Imports System.Drawing.Bitmap
Imports System
Imports System.Text
Imports Microsoft.VisualBasic.Strings
Public Class Item
    Public Shared ImageBase64String As String
    Private Sub Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''ตำแหน่งปุ่ม
        ''ปิด
        'Close_item.Location = New System.Drawing.Point(
        '    Me.ClientRectangle.Width - Close_item.Width, 0)
        'Close_item.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        'Top_tap.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        'Top_tap.Width = Me.Width
        Panel1.Width = TabControl1.Width * 0.5
        ModuleItems.LoadDataItem()
        ModuleItems.LoadCategory()
        ModuleItems.LoadPrinter()
        ModuleItems.LoadUnit()
        ModuleItems.LoadPOUnit()
        ModuleItems.LoadPOUnit2()
        ModuleItems.LoadRadDropDownVat()
        'Cate Material 
        ModuleMaterailAddToItem.LoadRadDropDownListCateMaterial()
        'ModuleAddCategorySelectionToItem.LoadComboCateSelection()
        'Topping
        ModuleTopping.loadData()
        ModuleTopping.ShowItemTopping()
        'Promotion
        ModulePromotionToItem.loadData()
        'point
        ModulePointRate.loadDataPointToItem()
        ComboBoxCategorysearch.Text = "ทั้งหมด"
    End Sub
    Private Sub Close_item_Click(sender As Object, e As EventArgs) Handles Close_item.Click
        Me.Close()
        Main.Close()
        Main.Show()
        ItemIdSend = 0
    End Sub

    Private Sub DropDownCategory_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles DropDownCategory.SelectedIndexChanged
        Try
            'Select CateCode
            Dim CateName As String = DropDownCategory.Text
            Dim DataCateId As DataTable = executesql("SELECT CateCode,CategoryId,NumberItemCode FROM CategoryItem WHERE CategoryName='" & CateName & "'")
            Dim NumberItemsCode As Integer = DataCateId(0)("NumberItemCode")
            Dim ZeroIndex As Integer
            'Count Items WHERE Category 
            Dim DataItems As DataTable = executesql("SELECT ItemId FROM Item WHERE CategoryId='" & DataCateId(0)("CategoryId") & "'")
            Dim NumberRows As Integer = DataItems.Rows.Count
            TxtNumber.Text = DataCateId(0)("CateCode").ToString
            ZeroIndex = CDbl(NumberItemsCode) - CDbl(NumberRows.ToString.Length)
            For i As Integer = 0 To ZeroIndex - 1
                TxtNumber.Text = TxtNumber.Text + "0"
            Next
            Dim CheckItemCode As DataTable = executesql("SELECT ItemCode FROM Item WHERE ItemCode='" & TxtNumber.Text + (DataItems.Rows.Count + 1).ToString & "'")
            If IsNothing(CheckItemCode) Then
                TxtNumber.Text = TxtNumber.Text + (DataItems.Rows.Count + 1).ToString
            ElseIf CheckItemCode.Rows.Count = 0 Then
                TxtNumber.Text = TxtNumber.Text + (DataItems.Rows.Count + 1).ToString
            ElseIf CheckItemCode.Rows.Count > 0 Then
                TxtNumber.Text = TxtNumber.Text + (DataItems.Rows.Count + 2).ToString
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnSaveDetailProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveDetailProduct.Click
        'Save Item
        ModuleItems.AddItem()
        ModuleItems.SearchItems()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'Clear Item 
        ModuleItems.ClearDetailItems()

        'Select CateCode
        Dim CateName As String = DropDownCategory.Text
        Dim DataCateId As DataTable = executesql("SELECT CateCode,CategoryId,NumberItemCode FROM CategoryItem WHERE CategoryName='" & CateName & "'")
        Dim NumberItemsCode As Integer = 0
        If DataCateId.Rows.Count = 0 Then
            MsgBox("กรุณาเลือกหมวดสินค้า", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            NumberItemsCode = DataCateId(0)("NumberItemCode")
        End If

        Dim ZeroIndex As Integer
        'Count Items WHERE Category 
        Dim DataItems As DataTable = executesql("SELECT ItemId FROM Item WHERE CategoryId='" & DataCateId(0)("CategoryId") & "'")
        Dim NumberRows As Integer = DataItems.Rows.Count
        TxtNumber.Text = DataCateId(0)("CateCode").ToString
        ZeroIndex = CDbl(NumberItemsCode) - CDbl(NumberRows.ToString.Length)
        For i As Integer = 0 To ZeroIndex - 1
            TxtNumber.Text = TxtNumber.Text + "0"
        Next
        Dim CheckItemCode As DataTable = executesql("SELECT ItemCode FROM Item WHERE ItemCode='" & TxtNumber.Text + (DataItems.Rows.Count + 1).ToString & "'")
        If IsNothing(CheckItemCode) Then
            TxtNumber.Text = TxtNumber.Text + (DataItems.Rows.Count + 1).ToString
        ElseIf CheckItemCode.Rows.Count = 0 Then
            TxtNumber.Text = TxtNumber.Text + (DataItems.Rows.Count + 1).ToString
        ElseIf CheckItemCode.Rows.Count > 0 Then
            TxtNumber.Text = TxtNumber.Text + (DataItems.Rows.Count + 2).ToString
        End If
    End Sub

    Public Shared ItemIdSend As Integer
    Private Sub DGItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGItems.CellClick
        ItemIdSend = DGItems.CurrentRow.Cells(0).Value
        ModuleItems.LoaddataDetailItem()
        ModuleItems.LoadMaterialInReceipe()
        ModuleItems.CalCostMaterial()
        'Topping
        ModuleTopping.ShowItemTopping()
        'Promotion
        ModulePromotionToItem.showData()
        'point
        ModulePointRate.showDataItemPoint()
        ModulePointRate.PointToRedeem()
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'Save Item
        ModuleItems.SaveImageAndColorButtonItems()
    End Sub

    Private Sub RadBrowserImage_ValueChanged(sender As Object, e As EventArgs) Handles RadBrowserImage.ValueChanged
        'Resize Image
        Dim PathFName As String = "C:\ImageFilesPOS\ItemresizePOS.jpg"
        PictureBoxItemResize.Image = Image.FromFile(RadBrowserImage.Value)
        ResizeImage(PictureBoxItemResize.Image, New Size(190, 207), True)
        'Convert to Base64String 
        Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
        ImageBase64String = Convert.ToBase64String(Imageaaray)
    End Sub
    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        'Resize Image 
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = IIf(percentHeight < percentWidth, percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        PictureBoxItemShow.BackgroundImage = newImage
        PictureBoxItemShow.BackgroundImageLayout = ImageLayout.Stretch
        'Create Folder
        If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
        End If
        'Save Files
        Dim Newpath As String = "C:\ImageFilesPOS\"
        Dim NewFileName As String = "ItemresizePOS.jpg"
        PictureBoxItemShow.BackgroundImage.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return newImage
    End Function
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ModuleItems.SearchItems()
    End Sub
    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub
    Private Sub BtnSaveMaterialItem_Click(sender As Object, e As EventArgs) Handles BtnSaveMaterialItem.Click
        'Save Material Items
        ModuleItems.SaveMaterialItem()
    End Sub
    Private Sub BtnAddCateSelection_Click(sender As Object, e As EventArgs) Handles BtnAddCateSelection.Click
        If TxtNumber.Text = "" Then
            Frm_Critical.ShowDialog()
            Frm_Critical.head_Label.Text = "กรุณาเลือกสินค้าก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            FrmItemAddCategorySelection.Close()
            Exit Sub
        ElseIf TxtNumber.Text <> "" Then
            FrmItemAddCategorySelection.Close()
            FrmItemAddCategorySelection.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub DGItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGItems.CellContentClick

    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Try
            ItemIdSend = DGItems.CurrentRow.Cells(0).Value
            ModuleItems.Delete_Item()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnSrcmaterial_Click(sender As Object, e As EventArgs) Handles BtnSrcmaterial.Click
        'If TxtNumber.Text = "" Then
        '    Frm_Critical.ShowDialog()
        '    Frm_Critical.head_Label.Text = "กรุณาเลือกสินค้าก่อน"
        '    Frm_Critical.TableOkCancel.Visible = False
        '    Exit Sub
        'End If
        ModuleMaterailAddToItem.SearchCateMaterial()
    End Sub
    Public Shared MatId As Integer
    Private Sub DgMaterial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMaterial.CellClick
        Try
            MatId = DgMaterial.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnAddMaterial_Click(sender As Object, e As EventArgs) Handles BtnAddMaterial.Click
        ModuleMaterailAddToItem.FromAddMaterial()
        FrmAddMaterialToItem.TxtTakeAmount.Focus()
    End Sub
    Public Shared MatIdCancel As String
    Private Sub DataGridViewMaterial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMaterial.CellClick
        Try
            MatIdCancel = DataGridViewMaterial.CurrentRow.Cells(6).Value
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnDeleteOrdermaterial_Click(sender As Object, e As EventArgs) Handles BtnDeleteOrdermaterial.Click
        If MatIdCancel = 0 Then
            Exit Sub
        ElseIf MatIdCancel <> 0 Then
            ModuleMaterailAddToItem.DeleteOrderMaterial()
            ModuleMaterailAddToItem.CalculateCostMaterial()
            Exit Sub
        End If
    End Sub
    Private Sub DgMaterial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMaterial.CellDoubleClick
        Try
            MatId = DgMaterial.CurrentRow.Cells(0).Value
            ModuleMaterailAddToItem.FromAddMaterial()
            FrmAddMaterialToItem.TxtTakeAmount.Focus()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnManageSelection_Click(sender As Object, e As EventArgs) Handles BtnManageSelection.Click
        FrmAddCategorySelection.ShowDialog()
    End Sub

    Private Sub BtnEditTax_Click(sender As Object, e As EventArgs) Handles BtnEditTax.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditTax()
        'Dim FrTax As New FrmManageTax
        FrmManageTax.ControlBox = True
        FrmManageTax.StartPosition = FormStartPosition.CenterScreen
        FrmManageTax.ShowDialog()
    End Sub

    Private Sub BtnEditUnit_Click(sender As Object, e As EventArgs) Handles BtnEditUnit.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditUnit()
        'Dim Funit As New FrmUnit
        FrmUnit.ControlBox = True
        FrmUnit.StartPosition = FormStartPosition.CenterScreen
        FrmUnit.ShowDialog()
    End Sub

    Private Sub BtnEditPo1_Click(sender As Object, e As EventArgs) Handles BtnEditPo1.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditUnit()
        'Dim Funit As New FrmUnit
        FrmUnit.ControlBox = True
        FrmUnit.StartPosition = FormStartPosition.CenterScreen
        FrmUnit.ShowDialog()
    End Sub

    Private Sub BtnEditPO2_Click(sender As Object, e As EventArgs) Handles BtnEditPO2.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditUnit()
        'Dim Funit As New FrmUnit
        FrmUnit.ControlBox = True
        FrmUnit.StartPosition = FormStartPosition.CenterScreen
        FrmUnit.ShowDialog()
    End Sub

    Private Sub btnAddCateTopping_Click(sender As Object, e As EventArgs) Handles btnAddCateTopping.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmToppings.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmToppings.StartPosition = FormStartPosition.CenterParent
            FrmToppings.ShowDialog(plexi)
        End Using
        'FrmToppings.ShowDialog()
    End Sub

    Private Sub btnSearchTopping_Click(sender As Object, e As EventArgs)

    End Sub
    Public Shared toppingId As Integer = 0
    Private Sub DataGridViewShowToppingList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowToppingList.CellDoubleClick
        Try
            toppingId = DataGridViewShowToppingList.CurrentRow.Cells(2).Value
            ModuleTopping.AddItemTopping()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnToppingItemDel_Click(sender As Object, e As EventArgs) Handles btnToppingItemDel.Click
        Try
            toppingId = DataGridViewItemTopping.CurrentRow.Cells(2).Value
            ModuleTopping.delItemTopping()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnManagePromotion_Click(sender As Object, e As EventArgs) Handles btnManagePromotion.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Promotion.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            Promotion.StartPosition = FormStartPosition.CenterParent
            Promotion.ShowDialog(plexi)
        End Using
        'Promotion.ShowDialog()
    End Sub

    Private Sub btnAddPromotionToItem_Click(sender As Object, e As EventArgs) Handles btnAddPromotionToItem.Click
        ModulePromotionToItem.btnAddPromotionToItem()
    End Sub
    Public Shared ProId As Integer = 0
    Private Sub DataGridViewSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearch.CellClick
        Try
            ProId = DataGridViewSearch.CurrentRow.Cells("PromotionId2").Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSearchPromotion_Click(sender As Object, e As EventArgs) Handles btnSearchPromotion.Click
        ModulePromotionToItem.btnSearch()
    End Sub
    Public Shared PromotionItemId As Integer = 0
    Private Sub DataGridViewPromotionItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPromotionItem.CellClick
        Try
            PromotionItemId = DataGridViewPromotionItem.CurrentRow.Cells("PromotionId").Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelPromotionItem_Click(sender As Object, e As EventArgs) Handles btnDelPromotionItem.Click
        If PromotionItemId = 0 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการลบก่อน", MsgBoxStyle.Critical)
            Exit Sub
        Else
            ModulePromotionToItem.btnDel()
        End If

    End Sub
    Private Sub btnSavePointToItem_Click(sender As Object, e As EventArgs) Handles btnSavePointToItem.Click
        Try
            ModulePointRate.btnAddPointToDataGridView()
        Catch ex As Exception

        End Try

    End Sub
    Public Shared PointRate As Integer = 0
    Private Sub DataGridViewShowPointRateList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowPointRateList.CellClick
        Try
            PointRate = DataGridViewShowPointRateList.CurrentRow.Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub
    Public Shared PointRateItem As Integer = 0
    Private Sub DataGridViewItemPointRate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItemPointRate.CellClick
        Try
            PointRateItem = DataGridViewItemPointRate.CurrentRow.Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnDelItemPointRate_Click(sender As Object, e As EventArgs) Handles btnDelItemPointRate.Click
        ModulePointRate.btnDelItemPointRate()
    End Sub

    Private Sub btnSavePointToItem2_Click(sender As Object, e As EventArgs) Handles btnSavePointToItem2.Click
        ModulePointRate.btnSavePointToItem()
    End Sub
    Private Sub btnManagePointRate_Click(sender As Object, e As EventArgs) Handles btnManagePointRate.Click
        'Me.Close()
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmPointRate.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmPointRate.StartPosition = FormStartPosition.CenterParent
            FrmPointRate.ShowDialog(plexi)
        End Using
        'FrmPointRate.ShowDialog()
    End Sub

    Private Sub BtnImportExcel_Click(sender As Object, e As EventArgs) Handles BtnImportExcel.Click
        ImportItemExcel.ShowDialog()
    End Sub

    Private Sub ComboBoxCategorysearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorysearch.SelectedIndexChanged
        ModuleItems.SearchItems()
    End Sub
End Class