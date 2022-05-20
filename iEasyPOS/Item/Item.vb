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
Imports Newtonsoft.Json
Imports System.Globalization
Imports System.ComponentModel
Imports System.Threading

Public Class Item
    Public Shared ImageBase64String As String
    Private Sub Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''ตำแหน่งปุ่ม
        ''ปิด
        'DropDownPrinter.Visible = True
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        DGItems.RowTemplate.Height = 35
        DataGridViewItemTopping.RowTemplate.Height = 35
        DataGridView2.RowTemplate.Height = 35
        DataGridView3.RowTemplate.Height = 35

        ModuleItems.LoadDataItem()
        ModuleItems.LoadCategory()
        ModuleItems.LoadPrinter()
        ModuleItems.LoadUnit()
        ModuleItems.LoadPOUnit()
        ModuleItems.LoadPOUnit2()
        ModuleItems.LoadRadDropDownVat()
        'Cate Material 
        'ModuleMaterailAddToItem.LoadRadDropDownListCateMaterial()
        'ModuleAddCategorySelectionToItem.LoadComboCateSelection()
        ModuleMaterailAddToItem.AutoCompeleteSearchMatName()

        'Topping
        ModuleTopping.loadData()
        ModuleTopping.ShowItemTopping()
        ModuleCategorySelection.LoadDataCateSelection()
        'Promotion
        'ModulePromotionToItem.loadData()
        'point
        'ModulePointRate.loadDataPointToItem()
        ComboBoxCategorysearch.Text = "ทั้งหมด"

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_BLUE\POS", "HQ_Connect", Nothing) = True Then
            BtnAdd.Enabled = False
            BtnDel.Enabled = False
            BtnSaveDetailProduct.Enabled = False
        Else
            btnDownloadItem.Visible = False
        End If

        ColorFontItem.Color = Color.Black
        ColorBtnItem.Color = Color.Silver

        '// เช็คใช้งานวัตถุดิบ
        Console.WriteLine("dataExt.ext_mat " & dataExt.ext_mat)
        If dataExt.ext_mat = 0 Then
            PanelMatControl.Visible = False
        Else
            PanelMatControl.Visible = True
        End If

        Dim DataCategory As DataTable = executesql("SELECT CategoryId,CategoryName FROM CategoryItem WHERE Active=1 AND CateGroupId = 1 Order By CategoryId")
        DropDownCategory.Text = DataCategory(0)("CategoryName")

        Panel23.AutoScroll = True
        Panel23.VerticalScroll.Visible = False
        Panel23.HorizontalScroll.Visible = True
    End Sub
    Private Sub Close_item_Click(sender As Object, e As EventArgs)
        Me.Close()
        Main.Close()
        Main.Show()
        ItemIdSend = 0
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
        '
        ItemIdSend = DGItems.CurrentRow.Cells(0).Value
        ModuleItems.LoaddataDetailItem()
        'ModuleItems.LoadMaterialInReceipe()
        'ModuleItems.CalCostMaterial()
        'Topping
        ModuleTopping.ShowItemTopping()
        ModuleCategorySelection.ShowItemSelection(ItemIdSend)
        'ModuleCategorySelection.LoadDataCateSelection()
        'Promotion
        'ModulePromotionToItem.showData()
        'point
        'ModulePointRate.showDataItemPoint()
        'ModulePointRate.PointToRedeem()
    End Sub
    'Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
    '    'Save Item
    '    ModuleItems.SaveImageAndColorButtonItems()
    'End Sub

    'Private Sub RadBrowserImage_ValueChanged(sender As Object, e As EventArgs) Handles RadBrowserImage.ValueChanged
    '    'Resize Image
    '    Dim PathFName As String = "C:\ImageFilesPOS\ItemresizePOS.jpg"
    '    PictureBoxItemResize.Image = Image.FromFile(RadBrowserImage.Value)
    '    ResizeImage(PictureBoxItemResize.Image, New Size(190, 207), True)
    '    'Convert to Base64String 
    '    Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
    '    ImageBase64String = Convert.ToBase64String(Imageaaray)
    'End Sub
    'Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
    '    'Resize Image 
    '    Dim newWidth As Integer
    '    Dim newHeight As Integer
    '    If preserveAspectRatio Then
    '        Dim originalWidth As Integer = image.Width
    '        Dim originalHeight As Integer = image.Height
    '        Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
    '        Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
    '        Dim percent As Single = IIf(percentHeight < percentWidth, percentHeight, percentWidth)
    '        newWidth = CInt(originalWidth * percent)
    '        newHeight = CInt(originalHeight * percent)
    '    Else
    '        newWidth = size.Width
    '        newHeight = size.Height
    '    End If
    '    Dim newImage As Image = New Bitmap(newWidth, newHeight)
    '    Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
    '        graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
    '        graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
    '    End Using
    '    PictureBoxItemShow.BackgroundImage = newImage
    '    PictureBoxItemShow.BackgroundImageLayout = ImageLayout.Stretch
    '    'Create Folder
    '    If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
    '        System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
    '    End If
    '    'Save Files
    '    Dim Newpath As String = "C:\ImageFilesPOS\"
    '    Dim NewFileName As String = "ItemresizePOS.jpg"
    '    PictureBoxItemShow.BackgroundImage.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
    '    Return newImage
    'End Function
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ModuleItems.SearchItems()
    End Sub

    'Private Sub BtnSaveMaterialItem_Click(sender As Object, e As EventArgs) Handles BtnSaveMaterialItem.Click
    '    'Save Material Items
    '    ModuleItems.SaveMaterialItem()
    'End Sub
    'Private Sub BtnAddCateSelection_Click(sender As Object, e As EventArgs) Handles BtnAddCateSelection.Click
    '    If TxtNumber.Text = "" Then
    '        Frm_Critical.ShowDialog()
    '        Frm_Critical.head_Label.Text = "กรุณาเลือกสินค้าก่อน"
    '        Frm_Critical.TableOkCancel.Visible = False
    '        FrmItemAddCategorySelection.Close()
    '        Exit Sub
    '    ElseIf TxtNumber.Text <> "" Then
    '        FrmItemAddCategorySelection.Close()
    '        FrmItemAddCategorySelection.ShowDialog()
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub BtnDel2_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Try
            ItemIdSend = DGItems.CurrentRow.Cells(0).Value
            ModuleItems.Delete_Item()
            ModuleItems.SearchItems()
        Catch ex As Exception

        End Try

    End Sub
    'Private Sub BtnSrcmaterial_Click(sender As Object, e As EventArgs) Handles BtnSrcmaterial.Click
    '    'If TxtNumber.Text = "" Then
    '    '    Frm_Critical.ShowDialog()
    '    '    Frm_Critical.head_Label.Text = "กรุณาเลือกสินค้าก่อน"
    '    '    Frm_Critical.TableOkCancel.Visible = False
    '    '    Exit Sub
    '    'End If
    '    ModuleMaterailAddToItem.SearchCateMaterial()
    'End Sub
    Public Shared MatId As Integer
    'Private Sub DgMaterial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMaterial.CellClick
    '    Try
    '        MatId = DgMaterial.CurrentRow.Cells(0).Value
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub BtnAddMaterial_Click(sender As Object, e As EventArgs) Handles BtnAddMaterial.Click
    '    ModuleMaterailAddToItem.FromAddMaterial()
    '    FrmAddMaterialToItem.TxtTakeAmount.Focus()
    'End Sub
    Public Shared MatIdCancel As String
    'Private Sub DataGridViewMaterial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMaterial.CellClick
    '    Try
    '        MatIdCancel = DataGridViewMaterial.CurrentRow.Cells(6).Value
    '    Catch ex As Exception

    '    End Try

    'End Sub
    'Private Sub BtnDeleteOrdermaterial_Click(sender As Object, e As EventArgs) Handles BtnDeleteOrdermaterial.Click
    '    If MatIdCancel = 0 Then
    '        Exit Sub
    '    ElseIf MatIdCancel <> 0 Then
    '        ModuleMaterailAddToItem.DeleteOrderMaterial()
    '        ModuleMaterailAddToItem.CalculateCostMaterial()
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub DgMaterial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMaterial.CellDoubleClick
    '    Try
    '        MatId = DgMaterial.CurrentRow.Cells(0).Value
    '        ModuleMaterailAddToItem.FromAddMaterial()
    '        FrmAddMaterialToItem.TxtTakeAmount.Focus()
    '    Catch ex As Exception
    '    End Try

    'End Sub

    'Private Sub BtnManageSelection_Click(sender As Object, e As EventArgs) Handles BtnManageSelection.Click
    '    FrmAddCategorySelection.ShowDialog()
    'End Sub

    Private Sub BtnEditTax_Click(sender As Object, e As EventArgs) Handles BtnEditTax.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditTax()
        'Dim FrTax As New FrmManageTax

        'FrmManageTax.ControlBox = True
        'FrmManageTax.StartPosition = FormStartPosition.CenterScreen
        'FrmManageTax.ShowDialog()
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmManageTaxV2.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            'FrmManageTax.ControlBox = True
            FrmManageTaxV2.StartPosition = FormStartPosition.CenterParent
            FrmManageTaxV2.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnEditUnit_Click(sender As Object, e As EventArgs) Handles BtnEditUnit.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditUnit()
        'Dim Funit As New FrmUnit

        'FrmUnit.ControlBox = True
        'FrmUnit.StartPosition = FormStartPosition.CenterScreen
        'FrmUnit.ShowDialog()

        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmUnitV2.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            'FrmManageTax.ControlBox = True
            FrmUnitV2.StartPosition = FormStartPosition.CenterParent
            FrmUnitV2.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnEditPo1_Click(sender As Object, e As EventArgs) Handles BtnEditPo1.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditUnit()
        'Dim Funit As New FrmUnit

        'FrmUnit.ControlBox = True
        'FrmUnit.StartPosition = FormStartPosition.CenterScreen
        'FrmUnit.ShowDialog()

        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmUnitV2.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            'FrmManageTax.ControlBox = True
            FrmUnitV2.StartPosition = FormStartPosition.CenterParent
            FrmUnitV2.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnEditPO2_Click(sender As Object, e As EventArgs) Handles BtnEditPO2.Click
        'EditFrmItem.ShowDialog()
        'EditFrmItem.BtnEditUnit()
        'Dim Funit As New FrmUnit

        'FrmUnit.ControlBox = True
        'FrmUnit.StartPosition = FormStartPosition.CenterScreen
        'FrmUnit.ShowDialog()

        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmUnitV2.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            'FrmManageTax.ControlBox = True
            FrmUnitV2.StartPosition = FormStartPosition.CenterParent
            FrmUnitV2.ShowDialog(plexi)
        End Using
    End Sub

    'Private Sub btnAddCateTopping_Click(sender As Object, e As EventArgs) Handles btnAddCateTopping.Click
    '    Using plexi = New Form()
    '        plexi.FormBorderStyle = FormBorderStyle.None
    '        plexi.Bounds = Screen.FromPoint(FrmToppings.Location).Bounds
    '        plexi.StartPosition = FormStartPosition.Manual
    '        plexi.AutoScaleMode = AutoScaleMode.None
    '        plexi.ShowInTaskbar = False
    '        plexi.BackColor = Color.Black
    '        plexi.Opacity = 0.7
    '        plexi.Show()
    '        FrmToppings.StartPosition = FormStartPosition.CenterParent
    '        FrmToppings.ShowDialog(plexi)
    '    End Using
    '    'FrmToppings.ShowDialog()
    'End Sub

    Private Sub btnSearchTopping_Click(sender As Object, e As EventArgs)

    End Sub
    Public Shared toppingId As Integer = 0
    'Private Sub DataGridViewShowToppingList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowToppingList.CellDoubleClick
    '    Try
    '        toppingId = DataGridViewShowToppingList.CurrentRow.Cells(2).Value
    '        ModuleTopping.AddItemTopping()
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub btnToppingItemDel_Click(sender As Object, e As EventArgs) Handles btnToppingItemDel.Click
    '    Try
    '        toppingId = DataGridViewItemTopping.CurrentRow.Cells(2).Value
    '        ModuleTopping.delItemTopping()
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub btnManagePromotion_Click(sender As Object, e As EventArgs) Handles btnManagePromotion.Click
    '    Using plexi = New Form()
    '        plexi.FormBorderStyle = FormBorderStyle.None
    '        plexi.Bounds = Screen.FromPoint(Promotion.Location).Bounds
    '        plexi.StartPosition = FormStartPosition.Manual
    '        plexi.AutoScaleMode = AutoScaleMode.None
    '        plexi.ShowInTaskbar = False
    '        plexi.BackColor = Color.Black
    '        plexi.Opacity = 0.7
    '        plexi.Show()
    '        Promotion.StartPosition = FormStartPosition.CenterParent
    '        Promotion.ShowDialog(plexi)
    '    End Using
    '    'Promotion.ShowDialog()
    'End Sub

    'Private Sub btnAddPromotionToItem_Click(sender As Object, e As EventArgs) Handles btnAddPromotionToItem.Click
    '    ModulePromotionToItem.btnAddPromotionToItem()
    'End Sub
    'Public Shared ProId As Integer = 0
    'Private Sub DataGridViewSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearch.CellClick
    '    Try
    '        ProId = DataGridViewSearch.CurrentRow.Cells("PromotionId2").Value
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub btnSearchPromotion_Click(sender As Object, e As EventArgs) Handles btnSearchPromotion.Click
    '    ModulePromotionToItem.btnSearch()
    'End Sub
    'Public Shared PromotionItemId As Integer = 0
    'Private Sub DataGridViewPromotionItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPromotionItem.CellClick
    '    Try
    '        PromotionItemId = DataGridViewPromotionItem.CurrentRow.Cells("PromotionId").Value
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub btnDelPromotionItem_Click(sender As Object, e As EventArgs) Handles btnDelPromotionItem.Click
    '    If PromotionItemId = 0 Then
    '        MsgBox("กรุณาเลือกรายการที่ต้องการลบก่อน", MsgBoxStyle.Critical)
    '        Exit Sub
    '    Else
    '        ModulePromotionToItem.btnDel()
    '    End If

    'End Sub
    'Private Sub btnSavePointToItem_Click(sender As Object, e As EventArgs) Handles btnSavePointToItem.Click
    '    Try
    '        ModulePointRate.btnAddPointToDataGridView()
    '    Catch ex As Exception

    '    End Try

    'End Sub
    Public Shared PointRate As Integer = 0
    'Private Sub DataGridViewShowPointRateList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowPointRateList.CellClick
    '    Try
    '        PointRate = DataGridViewShowPointRateList.CurrentRow.Cells(2).Value
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Public Shared PointRateItem As Integer = 0
    'Private Sub DataGridViewItemPointRate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItemPointRate.CellClick
    '    Try
    '        PointRateItem = DataGridViewItemPointRate.CurrentRow.Cells(2).Value
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub btnDelItemPointRate_Click(sender As Object, e As EventArgs) Handles btnDelItemPointRate.Click
    '    ModulePointRate.btnDelItemPointRate()
    'End Sub

    'Private Sub btnSavePointToItem2_Click(sender As Object, e As EventArgs) Handles btnSavePointToItem2.Click
    '    ModulePointRate.btnSavePointToItem()
    'End Sub
    'Private Sub btnManagePointRate_Click(sender As Object, e As EventArgs) Handles btnManagePointRate.Click
    '    'Me.Close()
    '    Using plexi = New Form()
    '        plexi.FormBorderStyle = FormBorderStyle.None
    '        plexi.Bounds = Screen.FromPoint(FrmPointRate.Location).Bounds
    '        plexi.StartPosition = FormStartPosition.Manual
    '        plexi.AutoScaleMode = AutoScaleMode.None
    '        plexi.ShowInTaskbar = False
    '        plexi.BackColor = Color.Black
    '        plexi.Opacity = 0.7
    '        plexi.Show()
    '        FrmPointRate.StartPosition = FormStartPosition.CenterParent
    '        FrmPointRate.ShowDialog(plexi)
    '    End Using
    '    'FrmPointRate.ShowDialog()
    'End Sub

    Private Sub BtnImportExcel_Click(sender As Object, e As EventArgs) Handles BtnImportExcel.Click
        ImportItemExcel.ShowDialog()
    End Sub

    Private Sub ComboBoxCategorysearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorysearch.SelectedIndexChanged
        ModuleItems.SearchItems()
        DropDownCategory.Text = ComboBoxCategorysearch.Text
    End Sub

    Private Sub DGItems_KeyDown(sender As Object, e As KeyEventArgs) Handles DGItems.KeyDown
        Dim CrRowIndex As Integer = DGItems.CurrentRow.Index
        DGItems.Rows(CrRowIndex).Selected = False
        If e.KeyCode = Keys.Down Then
            CrRowIndex += 1
        ElseIf e.KeyCode = Keys.Up Then
            CrRowIndex -= 1
        End If

        DGItems.Rows(CrRowIndex).Selected = True
        ItemIdSend = DGItems.Rows(CrRowIndex).Cells(0).Value


        ModuleItems.LoaddataDetailItem()
        'ModuleItems.LoadMaterialInReceipe()
        'ModuleItems.CalCostMaterial()
        'Topping
        'ModuleTopping.ShowItemTopping()
        'Promotion
        'ModulePromotionToItem.showData()
        'point
        'ModulePointRate.showDataItemPoint()
        'ModulePointRate.PointToRedeem()
    End Sub

    Private Sub btnUploadItem_Click(sender As Object, e As EventArgs)
        ModuleHQItem.upload()
    End Sub

    'Private Sub BtnDownloadItem_Click(sender As Object, e As EventArgs) Handles btnDownloadItem.Click
    '    SyncItem()

    '    ModuleItems.LoadDataItem()
    '    ModuleItems.LoadCategory()
    '    ModuleItems.LoadPrinter()
    '    ModuleItems.LoadUnit()
    '    ModuleItems.LoadPOUnit()
    '    ModuleItems.LoadPOUnit2()
    '    ModuleItems.LoadRadDropDownVat()
    'End Sub

    'Private Sub BtnClearImage_Click(sender As Object, e As EventArgs) Handles BtnClearImage.Click
    '    executesql("update Item set ImageText=NULL  where ItemId=" & ItemIdSend & "")
    '    PictureBoxItemShow.Image = Nothing
    '    PictureBoxItemShow.BackgroundImage = Nothing
    'End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim folderDlg As New OpenFileDialog
        folderDlg.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        If folderDlg.ShowDialog = DialogResult.OK AndAlso Not String.IsNullOrEmpty(folderDlg.FileName) Then
            'Resize Image
            Dim PathFName As String = "C:\ImageFilesPOS\ItemresizePOS.jpg"
            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox2.BackgroundImage = Image.FromFile(folderDlg.FileName)
            ResizeImage(PictureBox2.BackgroundImage, New Size(150, 150), True)
            'Convert to Base64String 
            Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(folderDlg.FileName)
            ImageBase64String = Convert.ToBase64String(Imageaaray)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBoxToppingList.Text = "หมวดท็อปปิ้ง" Or ComboBoxToppingList.Text = "" Then
            Exit Sub
        End If
        Dim selecToppingCategoryId As DataTable = executesql("SELECT CategoryToppingId,CategoryToppingName,CateToppingCode FROM CategoryTopping WHERE CategoryToppingName='" & ComboBoxToppingList.Text & "'")

        Dim getTopping As New iTopping
        For Each dt As DataRow In selecToppingCategoryId.Rows
            getTopping.name = dt("CategoryToppingName")
            getTopping.id = dt("CategoryToppingId")
            getTopping.code = dt("CateToppingCode")
        Next

        ModuleTopping.addToppingToDatagrid(getTopping)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub DropDownCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownCategory.SelectedIndexChanged
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

    Private Sub btnToppingCate_Click(sender As Object, e As EventArgs) Handles btnToppingCate.Click
        'Using plexi = New Form()
        '    plexi.FormBorderStyle = FormBorderStyle.None
        '    plexi.Bounds = Screen.FromPoint(FrmToppings.Location).Bounds
        '    plexi.StartPosition = FormStartPosition.Manual
        '    plexi.AutoScaleMode = AutoScaleMode.None
        '    plexi.ShowInTaskbar = False
        '    plexi.BackColor = Color.Black
        '    plexi.Opacity = 0.7
        '    plexi.Show()
        '    FrmToppings.StartPosition = FormStartPosition.CenterParent
        '    FrmToppings.ShowDialog(plexi)
        'End Using
        FrmToppings.Show()
    End Sub

    Private Sub BtnManageSelection_Click(sender As Object, e As EventArgs) Handles BtnManageSelection.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmAddCategorySelection.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmAddCategorySelection.StartPosition = FormStartPosition.CenterParent
            FrmAddCategorySelection.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnAddCateSelection_Click(sender As Object, e As EventArgs) Handles BtnAddCateSelection.Click
        Dim dtSelect As DataTable = executesql("select CategorySelectionId from CategorySelection where CategorySelectionName='" & ComboBoxSelection.Text & "'")
        AddItemSelection(ItemIdSend, dtSelect(0)("CategorySelectionId"))
    End Sub

    Private Sub TextBoxSearchMat_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSearchMat.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchMatName(TextBoxSearchMat.Text)
            TextBoxMatQty.Select()
        End If
    End Sub

    Private Sub BtnAddMatItem_Click(sender As Object, e As EventArgs) Handles BtnAddMatItem.Click
        If TextBoxMatQty.Text = "" Then
            Exit Sub
        ElseIf TextBoxMatQty.Text <> "" Then
            'Insert Into Receipe
            ModuleItems.SaveMaterialItem(MatId_add, TextMatUnit.Text, TextBoxMatQty.Text)
            LoadMaterialInReceipe()

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Frm_Barcode80mm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub DataGridViewItemTopping_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItemTopping.CellClick
        If DataGridViewItemTopping.CurrentRow.Cells(3).ColumnIndex = 3 Then
            executesql("update itemtopping set active = 0 where itemid='" & ItemIdSend & "' and categorytoppingId = '" & DataGridViewItemTopping.CurrentRow.Cells(0).Value & "'")
            ModuleTopping.ShowItemTopping()
        End If
    End Sub

    Private Sub DgCateSelection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCateSelection.CellClick
        If DgCateSelection.CurrentRow.Cells(3).ColumnIndex = 3 Then
            executesql("update ItemSelection set active = 0 where itemid='" & ItemIdSend & "' and cateselectionId = '" & DgCateSelection.CurrentRow.Cells(0).Value & "'")
            ModuleCategorySelection.ShowItemSelection(ItemIdSend)
        End If
    End Sub

    Sub change_to_th_text()
        PageManagementBrand.Text = My.Resources.item_th.product
        Label34.Text = My.Resources.item_th.search
        Label31.Text = My.Resources.item_th.search
        Label32.Text = My.Resources.item_th.categoryProduct
        BtnAdd.Text = My.Resources.item_th.addProduct
        BtnDel.Text = My.Resources.item_th.del
        Label1.Text = My.Resources.item_th.productDetail
        Label33.Text = My.Resources.item_th.Image
        Label2.Text = My.Resources.item_th.categoryProduct
        Label3.Text = My.Resources.item_th.productCode
        Label4.Text = My.Resources.item_th.productName
        Label5.Text = My.Resources.item_th.productName2
        Label6.Text = My.Resources.item_th.price
        Label7.Text = My.Resources.item_th.pointRedeem
        Label10.Text = My.Resources.item_th.unit
        Label12.Text = My.Resources.item_th.unitPO
        Label11.Text = My.Resources.item_th.unitPO2
        Label8.Text = My.Resources.item_th.vat
        Label25.Text = My.Resources.item_th.buttonColor
        Label9.Text = My.Resources.item_th.textColor
        Label14.Text = My.Resources.item_th.more
        Label21.Text = My.Resources.item_th.allowDiscount
        Label16.Text = My.Resources.item_th.allowStock
        Label19.Text = My.Resources.item_th.allowPoint
        Label17.Text = My.Resources.item_th.allowpromotion
        Label20.Text = My.Resources.item_th.onPos
        Label18.Text = My.Resources.item_th.onKiosk
        CheckBoxPriceMod.Text = My.Resources.item_th.customPrice
        btnToppingCate.Text = My.Resources.item_th.categoryTopping
        BtnManageSelection.Text = My.Resources.item_th.categorySelection
        Label15.Text = My.Resources.item_th.material
        Label22.Text = My.Resources.item_th.qty
        Label26.Text = My.Resources.item_th.unit
        BtnSaveDetailProduct.Text = My.Resources.item_th.save

        DGItems.Columns(1).HeaderText = My.Resources.item_th.productCode
        DGItems.Columns(2).HeaderText = My.Resources.item_th.productName
        DGItems.Columns(3).HeaderText = My.Resources.item_th.price
        DGItems.Columns(4).HeaderText = My.Resources.item_th.qty

        DataGridViewItemTopping.Columns(1).HeaderText = My.Resources.item_th.code
        DataGridViewItemTopping.Columns(2).HeaderText = My.Resources.item_th.categoryTopping
        DataGridViewItemTopping.Columns(3).HeaderText = My.Resources.item_th.del

        DgCateSelection.Columns(1).HeaderText = My.Resources.item_th.code
        DgCateSelection.Columns(2).HeaderText = My.Resources.item_th.categorySelection
        DgCateSelection.Columns(3).HeaderText = My.Resources.item_th.del

        DataGridViewMat.Columns(1).HeaderText = My.Resources.item_th.code
        DataGridViewMat.Columns(2).HeaderText = My.Resources.item_th.material
        DataGridViewMat.Columns(3).HeaderText = My.Resources.item_th.qty
        DataGridViewMat.Columns(3).HeaderText = My.Resources.item_th.unit
        DataGridViewMat.Columns(3).HeaderText = My.Resources.item_th.del

    End Sub

    Sub change_to_eng_text()
        PageManagementBrand.Text = My.Resources.item_en.product
        Label34.Text = My.Resources.item_en.search
        Label31.Text = My.Resources.item_en.search
        Label32.Text = My.Resources.item_en.categoryProduct
        BtnAdd.Text = My.Resources.item_en.addProduct
        BtnDel.Text = My.Resources.item_en.del
        Label1.Text = My.Resources.item_en.productDetail
        Label33.Text = My.Resources.item_en.Image
        Label2.Text = My.Resources.item_en.categoryProduct
        Label3.Text = My.Resources.item_en.productCode
        Label4.Text = My.Resources.item_en.productName
        Label5.Text = My.Resources.item_en.productName2
        Label6.Text = My.Resources.item_en.price
        Label7.Text = My.Resources.item_en.pointRedeem
        Label10.Text = My.Resources.item_en.unit
        Label12.Text = My.Resources.item_en.unitPO
        Label11.Text = My.Resources.item_en.unitPO2
        Label8.Text = My.Resources.item_en.vat
        Label25.Text = My.Resources.item_en.buttonColor
        Label9.Text = My.Resources.item_en.textColor
        Label14.Text = My.Resources.item_en.more
        Label21.Text = My.Resources.item_en.allowDiscount
        Label16.Text = My.Resources.item_en.allowStock
        Label19.Text = My.Resources.item_en.allowPoint
        Label17.Text = My.Resources.item_en.allowpromotion
        Label20.Text = My.Resources.item_en.onPos
        Label18.Text = My.Resources.item_en.onKiosk
        CheckBoxPriceMod.Text = My.Resources.item_en.customPrice
        btnToppingCate.Text = My.Resources.item_en.categoryTopping
        BtnManageSelection.Text = My.Resources.item_en.categorySelection
        Label15.Text = My.Resources.item_en.material
        Label22.Text = My.Resources.item_en.qty
        Label26.Text = My.Resources.item_en.unit
        BtnSaveDetailProduct.Text = My.Resources.item_en.save

        DGItems.Columns(1).HeaderText = My.Resources.item_en.productCode
        DGItems.Columns(2).HeaderText = My.Resources.item_en.productName
        DGItems.Columns(3).HeaderText = My.Resources.item_en.price
        DGItems.Columns(4).HeaderText = My.Resources.item_en.qty

        DataGridViewItemTopping.Columns(1).HeaderText = My.Resources.item_en.code
        DataGridViewItemTopping.Columns(2).HeaderText = My.Resources.item_en.categoryTopping
        DataGridViewItemTopping.Columns(3).HeaderText = My.Resources.item_en.del

        DgCateSelection.Columns(1).HeaderText = My.Resources.item_en.code
        DgCateSelection.Columns(2).HeaderText = My.Resources.item_en.categorySelection
        DgCateSelection.Columns(3).HeaderText = My.Resources.item_en.del

        DataGridViewMat.Columns(1).HeaderText = My.Resources.item_en.code
        DataGridViewMat.Columns(2).HeaderText = My.Resources.item_en.material
        DataGridViewMat.Columns(3).HeaderText = My.Resources.item_en.qty
        DataGridViewMat.Columns(3).HeaderText = My.Resources.item_en.unit
        DataGridViewMat.Columns(3).HeaderText = My.Resources.item_en.del
    End Sub

    Private Sub btnDownloadItem_Click(sender As Object, e As EventArgs) Handles btnDownloadItem.Click
        SyncItem()
    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(frm_barCode.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            frm_barCode.StartPosition = FormStartPosition.CenterParent
            frm_barCode.ShowDialog(plexi)
        End Using
    End Sub
End Class