Imports System.IO
Imports System.IO.Path
Imports System.IO.File
Imports System.IO.IOException
Imports System.IO.StreamWriter
Imports System.IO.MemoryStream
Imports System.IO.StreamReader
Imports System.Drawing.Imaging
Imports System.Drawing.Image
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.Strings
Module ModuleMaterial
    Dim materialId As Integer

    Sub LoadComboboxVat()
        Material.ComboBoxVat.Properties.Items.Clear()

        Dim DataVat As DataTable = executesql("SELECT TaxName FROM Tax WHERE Active=1")
        If IsDBNull(DataVat) Then
            Exit Sub
        End If
        Dim RowsDataVat As Integer = DataVat.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataVat - 1
            Material.ComboBoxVat.Properties.Items.Add(DataVat(i)("TaxName"))
        Next
    End Sub
    Sub loadCombobox()
        Dim selectCategory As DataTable = executesql("SELECT CategoryId,CategoryName FROM CategoryItem WHERE CateGroupId = 2 AND Active=1")
        If IsNothing(selectCategory) Then
            Exit Sub
        ElseIf selectCategory.Rows.Count = 0 Then
            Exit Sub
        End If
        Material.ComboBoxMaterialCategory.Controls.Clear()
        For i As Integer = 0 To selectCategory.Rows.Count - 1
            Material.ComboBoxMaterialCategory.Properties.Items.Add(selectCategory(i)("CategoryName"))
        Next

        Dim selectUint As DataTable = executesql("SELECT ItemUnitId,ItemUnitName FROM ItemUnit WHERE Active=1")
        If IsNothing(selectUint) Then
            Exit Sub
        ElseIf selectUint.Rows.Count = 0 Then
            Exit Sub
        End If
        Material.ComboBoxPOUnit.Controls.Clear()
        Material.ComboBoxUseUnit.Controls.Clear()
        For a As Integer = 0 To selectUint.Rows.Count - 1
            Material.ComboBoxPOUnit.Properties.Items.Add(selectUint(a)("ItemUnitName"))
            Material.ComboBoxUseUnit.Properties.Items.Add(selectUint(a)("ItemUnitName"))
            Material.ComboBoxPOUnit2.Properties.Items.Add(selectUint(a)("ItemUnitName"))
        Next
        Material.ComboBoxStatus.Controls.Clear()
        Dim statusData() As String = {"พร้อมขาย", "ไม่พร้อมขาย"}
        For r As Integer = 0 To 1
            Material.ComboBoxStatus.Properties.Items.Add(statusData(r))
        Next
    End Sub
    Sub loadData()
        clear()
        materialId = 0
        loadCombobox()
        Material.CheckBoxCanStock.Checked = True

        Dim selectCategory As DataTable = executesql("SELECT CategoryId,CategoryName FROM CategoryItem WHERE CateGroupId =2 AND Active=1")
        If IsNothing(selectCategory) Then
            Exit Sub
        ElseIf selectCategory.Rows.Count = 0 Then
            Exit Sub
        End If
        Material.ComboBoxCateSearch.Properties.Items.Clear()
        For i As Integer = 0 To selectCategory.Rows.Count - 1
            Material.ComboBoxCateSearch.Properties.Items.Add(selectCategory(i)("CategoryName"))
        Next

        loadDataGrid()
        LoadComboboxVat()
    End Sub
    Sub loadDataGrid()
        Material.DataGridViewMaterial.Rows.Clear()
        Dim Qty As Decimal

        Dim showData As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,CategoryItem.CategoryName,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active=1 AND CategoryItem.CateGroupId=2")
        If IsNothing(showData) Then
            Exit Sub
        ElseIf showData.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To showData.Rows.Count - 1

            Dim selectQty As DataTable = executesql("Select Qty From UnitInStock Where ItemId='" & showData(i)("ItemId") & "'")
            Dim RowsSelectQty As Integer = selectQty.Rows.Count
            If RowsSelectQty = 0 Then
                Qty = 0
            Else
                If selectQty.Rows.Count = 0 Then
                    Qty = 0
                Else
                    Qty = selectQty(0)("Qty")
                End If
            End If
            Material.DataGridViewMaterial.Rows.Add(showData(i)("ItemId"), showData(i)("CategoryName"), showData(i)("ItemCode"), showData(i)("ItemName"), FormatNumber(Qty, 2))
        Next
    End Sub
    Sub btnSearch()
        Material.DataGridViewMaterial.Rows.Clear()
        If Material.ComboBoxCateSearch.Text = "" And Material.txtSearch.Text = "" Then

            Dim showData As DataTable = executesql("Select Item.ItemId,Item.ItemCode,Item.ItemName,CategoryItem.CategoryName From Item Where INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId Where Item.Active=1 AND CategoryItem.CateGroupId=2")
            If IsNothing(showData) Then
                Exit Sub
            End If
            If showData.Rows.Count = 0 Then
                Exit Sub
            End If
            For i As Integer = 0 To showData.Rows.Count - 1
                Dim Qty As Decimal
                Dim selectQty As DataTable = executesql("Select Qty From UnitInStock Where ItemId='" & showData(i)("ItemId") & "'")
                If selectQty.Rows.Count = 0 Then
                    Qty = 0
                Else
                    Qty = selectQty(0)("Qty")
                End If
                Material.DataGridViewMaterial.Rows.Add(showData(i)("ItemId"), showData(i)("CategoryName"), showData(i)("ItemCode"), showData(i)("ItemName"), FormatNumber(Qty, 2))
            Next
            Exit Sub
        ElseIf Material.ComboBoxCateSearch.Text = "" And Material.txtSearch.Text <> "" Then
            'Dim getId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & Material.ComboBoxCateSearch.Text & "'")

            Dim showData As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,CategoryItem.CategoryName,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active=1  AND Item.ItemName LIKE '%" & Material.txtSearch.Text & "%' AND CategoryItem.CateGroupId=2")
            If IsNothing(showData) Then
                Exit Sub
            End If
            If showData.Rows.Count = 0 Then
                Exit Sub
            End If
            For i As Integer = 0 To showData.Rows.Count - 1
                Dim Qty As Decimal

                Dim selectQty As DataTable = executesql("Select Qty From UnitInStock Where ItemId='" & showData(i)("ItemId") & "'")
                If selectQty.Rows.Count = 0 Then
                    Qty = 0
                Else
                    Qty = selectQty(0)("Qty")
                End If
                Material.DataGridViewMaterial.Rows.Add(showData(i)("ItemId"), showData(i)("CategoryName"), showData(i)("ItemCode"), showData(i)("ItemName"), FormatNumber(Qty, 2))
            Next
            Exit Sub
        ElseIf Material.ComboBoxCateSearch.Text <> "" And Material.txtSearch.Text = "" Then

            Dim getId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & Material.ComboBoxCateSearch.Text & "'")

            Dim showData As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,CategoryItem.CategoryName,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active=1 AND CategoryItem.CategoryId='" & getId(0)("CategoryId") & "' AND CategoryItem.CateGroupId=2")
            If IsNothing(showData) Then
                Exit Sub
            End If
            If showData.Rows.Count = 0 Then
                Exit Sub
            End If
            For i As Integer = 0 To showData.Rows.Count - 1
                Dim Qty As Decimal

                Dim selectQty As DataTable = executesql("Select Qty From UnitInStock Where ItemId='" & showData(i)("ItemId") & "'")
                If selectQty.Rows.Count = 0 Then
                    Qty = 0
                Else
                    Qty = selectQty(0)("Qty")
                End If
                Material.DataGridViewMaterial.Rows.Add(showData(i)("ItemId"), showData(i)("CategoryName"), showData(i)("ItemCode"), showData(i)("ItemName"), FormatNumber(Qty, 2))
            Next
            Exit Sub
        Else

            Dim getId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & Material.ComboBoxCateSearch.Text & "'")

            Dim showData As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,CategoryItem.CategoryName,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active=1 AND CategoryItem.CategoryId='" & getId(0)("CategoryId") & "'  AND Item.ItemName LIKE '%" & Material.txtSearch.Text & "%'  AND CategoryItem.CateGroupId=2")
            If IsNothing(showData) Then
                Exit Sub
            End If
            If showData.Rows.Count = 0 Then
                Exit Sub
            End If
            For i As Integer = 0 To showData.Rows.Count - 1
                Dim Qty As Decimal

                Dim selectQty As DataTable = executesql("Select Qty From UnitInStock Where ItemId='" & showData(i)("ItemId") & "'")
                If selectQty.Rows.Count = 0 Then
                    Qty = 0
                Else
                    Qty = selectQty(0)("Qty")
                End If
                Material.DataGridViewMaterial.Rows.Add(showData(i)("ItemId"), showData(i)("CategoryName"), showData(i)("ItemCode"), showData(i)("ItemName"), FormatNumber(Qty, 2))
            Next
            Exit Sub
        End If
    End Sub
    Sub showData()

        Dim selectItem As DataTable = executesql("SELECT Item.ItemId,CategoryItem.CategoryName,Item.ItemCode,Item.ItemName,Item.ItemName2,Item.Notes,Item.Notes2,Item.USUnitId,Item.POUnitId,Item.IsTrackStock,Item.ImageText,Item.ItemStatusId,Item.POUnitId2,Tax.TaxName  FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId= Item.CategoryId INNER JOIN Tax ON Tax.TaxId = Item.TaxId WHERE Item.ItemCode='" & Material.DataGridViewMaterial.CurrentRow.Cells(2).Value & "' AND Item.Active=1")
        materialId = selectItem(0)("ItemId")
        Material.ComboBoxMaterialCategory.Text = selectItem(0)("CategoryName")
        Material.ComboBoxVat.Text = selectItem(0)("TaxName")
        Material.txtMaterialCode.Text = selectItem(0)("ItemCode")
        Material.txtMaterialNameTH.Text = selectItem(0)("ItemName")
        Material.txtMaterialNameEN.Text = selectItem(0)("ItemName2")
        Material.txtNoteTH.Text = selectItem(0)("Notes")
        Material.txtNoteEN.Text = selectItem(0)("Notes2")

        Dim selectUseUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & selectItem(0)("USUnitId") & "'")
        Material.ComboBoxUseUnit.Text = selectUseUnitName(0)("ItemUnitName")

        Dim selectPOUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & selectItem(0)("POUnitId") & "'")
        Material.ComboBoxPOUnit.Text = selectPOUnitName(0)("ItemUnitName")

        Dim selectPOUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & selectItem(0)("POUnitId2") & "'")
        Material.ComboBoxPOUnit2.Text = selectPOUnitName2(0)("ItemUnitName")
        Select Case selectItem(0)("ItemStatusId")
            Case 0
                Material.ComboBoxStatus.Text = "ไม่พร้อมขาย"
            Case 1
                Material.ComboBoxStatus.Text = "พร้อมขาย"
        End Select
        If selectItem(0)("ImageText") = Nothing Then
            'Material.PictureBoxResize.BackgroundImage = Nothing
            Exit Sub
        Else
            'Material.PictureBoxResize.BackgroundImage = Nothing
            Material.ImageBase64String = selectItem(0)("ImageText")
            'Convert Base64String To Image 
            Dim img As System.Drawing.Image
            Dim Ms As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b() As Byte
            'Convert Base64 encoded msg To Image Data 
            b = Convert.FromBase64String(selectItem(0)("ImageText"))
            Ms = New System.IO.MemoryStream(b)
            'Create Image 
            img = System.Drawing.Image.FromStream(Ms)
            'Material.PictureBoxResize.BackgroundImage = img
            'Material.PictureBoxResize.BackgroundImageLayout = ImageLayout.Stretch

            If selectItem(0)("IsTrackStock") = True Then
                Material.CheckBoxCanStock.Checked = True
            Else
                Material.CheckBoxCanStock.Checked = False
            End If
        End If
        'clear()
        'materialId = 0
    End Sub
    Sub getMaterialCode()

        Dim getId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & Material.ComboBoxMaterialCategory.Text & "'")

        Dim selecCateCode As DataTable = executesql("SELECT CateCode,NumberItemCode FROM CategoryItem WHERE CateGroupId='2' AND CategoryId ='" & getId(0)("CategoryId") & "' AND Active='1'")

        Dim selectCountItemCode As DataTable = executesql("SELECT COUNT(ItemId) AS CountItem FROM Item WHERE CategoryId='" & getId(0)("CategoryId") & "'")
        Dim numItemCount As Integer = selectCountItemCode(0)("CountItem") + 1
        Material.txtMaterialCode.Text = selecCateCode(0)("CateCode") & numItemCount.ToString("D" & selecCateCode(0)("NumberItemCode"))
    End Sub
    Sub clear()
        Material.txtMaterialCode.Clear()
        Material.txtMaterialNameTH.Clear()
        Material.txtMaterialNameEN.Clear()
        Material.txtNoteTH.Clear()
        Material.txtNoteEN.Clear()
        materialId = 0
        'Material.BrowsImageMaterial.Controls.Clear()
        'Material.PictureBoxResize.BackgroundImage = Nothing
        Material.ComboBoxMaterialCategory.Properties.Items.Clear()
        Material.ComboBoxMaterialCategory.Text = Nothing
        Material.ComboBoxUseUnit.Text = Nothing
        Material.ComboBoxPOUnit.Text = Nothing
        Material.ComboBoxPOUnit2.Text = Nothing
        Material.ComboBoxVat.Text = Nothing
        Material.ComboBoxVat.Properties.Items.Clear()
        Material.ComboBoxUseUnit.Properties.Items.Clear()
        Material.ComboBoxPOUnit.Properties.Items.Clear()
        Material.ComboBoxPOUnit2.Properties.Items.Clear()
        Material.ComboBoxStatus.Text = Nothing
        Material.ComboBoxStatus.Properties.Items.Clear()
        'Material.PictureBoxResize.BackgroundImage = Nothing
        'LoadComboboxVat()
        'loadCombobox()
    End Sub
    Sub btnSave()
        Dim canStock As Integer

        If Material.CheckBoxCanStock.Checked = True Then
            canStock = 1
        Else
            canStock = 0
        End If
        If Material.ComboBoxMaterialCategory.Text = "" Then

            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกหมวดหมู่วัตถุดิบ"
            Frm_Critical.TableOkCancel.Visible = False

            Material.ComboBoxMaterialCategory.Focus()
            Exit Sub
        End If
        If Material.txtMaterialCode.Text = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกชื่อ"
            Frm_Critical.TableOkCancel.Visible = False

            Material.txtMaterialCode.Focus()
            Exit Sub
        End If
        'If Material.ComboBoxPOUnit.SelectedItem = Nothing Then
        '    MsgBox("กรุณาเลือกหน่วยซื้อ", MsgBoxStyle.Critical)
        '    Material.ComboBoxPOUnit.Focus()
        '    Exit Sub
        'End If
        If Material.ComboBoxUseUnit.SelectedItem = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกหน่วยใช่"
            Frm_Critical.TableOkCancel.Visible = False

            Material.ComboBoxUseUnit.Focus()
            Exit Sub
        End If
        Dim imageItem As String

        'If Material.ComboBoxPOUnit2.Text = "" Then
        '    MsgBox("กรุณาเลือก หน่วยซื้อ 2", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        Dim VatName As String
        Dim VatId
        If Material.ComboBoxVat.Text = Nothing Then
            VatName = "0"
            Exit Sub
        Else

            Dim DataMatId As DataTable = executesql("SELECT TaxId FROM Tax WHERE TaxName='" & Material.ComboBoxVat.Text & "' AND Active=1")
            VatId = DataMatId(0)(0)
        End If

        Dim getCateId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & Material.ComboBoxMaterialCategory.Text & "'")
        Dim userId As Integer = Frm_Login.UserId

        Dim USUnit As DataTable = executesql("SELECT ItemUnitId FROM ItemUnit WHERE ItemUnitName='" & Material.ComboBoxUseUnit.Text & "' AND Active=1")

        Dim POUnit As DataTable = executesql("SELECT ItemUnitId FROM ItemUnit WHERE ItemUnitName='" & Material.ComboBoxPOUnit.Text & "' AND Active=1")

        Dim POUnit2 As DataTable = executesql("SELECT ItemUnitId FROM ItemUnit WHERE ItemUnitName='" & Material.ComboBoxPOUnit2.Text & "' AND Active=1")

        Dim TaxId As DataTable = executesql("SELECT TaxId FROM Tax WHERE TaxName='" & Material.ComboBoxVat.Text & "' AND Active=1")
        Dim statusId As Integer
        Select Case Material.ComboBoxStatus.Text
            Case "พร้อมขาย"
                statusId = 1
            Case "ไม่พร้อมขาย"
                statusId = 0
        End Select
        If materialId = 0 Then

            executesql("INSERT INTO Item(ItemCode,ItemName,ItemName2,Notes,Notes2,CategoryId,ImageText,Active,InsertDate,UserId,IsTrackStock,USUnitId,POUnitId,ItemStatusId,ButtonColor,FontColor,POUnitId2,TaxId) VALUES('" & Material.txtMaterialCode.Text & "','" & Material.txtMaterialNameTH.Text & "','" & Material.txtMaterialNameEN.Text & "','" & Material.txtNoteTH.Text & "','" & Material.txtNoteEN.Text & "','" & getCateId(0)("CategoryId") & "','" & imageItem & "','1','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & userId & "',1,'" & USUnit(0)("ItemUnitId") & "','" & POUnit(0)("ItemUnitId") & "','" & statusId & "','-1608576','-1','" & POUnit2(0)("ItemUnitId") & "','" & TaxId(0)("TaxId") & "')")
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False

            clear()
            loadData()
        Else
            If materialId = 0 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "กรุณาเลือกรายการที่ต้องการแก้ไข"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'If Material.PictureBoxResize.BackgroundImage Is Nothing Then
            '    imageItem = ""
            'ElseIf Material.PictureBoxResize.BackgroundImage IsNot Nothing Then
            '    imageItem = Material.ImageBase64String
            '    executesql("Update Item Set ImageText='" & imageItem & "' WHERE ItemId='" & materialId & "'")
            'End If

            executesql("UPDATE Item SET ItemCode='" & Material.txtMaterialCode.Text & "',ItemName='" & Material.txtMaterialNameTH.Text & "',ItemName2='" & Material.txtMaterialNameEN.Text & "',Notes='" & Material.txtNoteTH.Text & "',Notes2='" & Material.txtNoteEN.Text & "',CategoryId='" & getCateId(0)("CategoryId") & "',UpdateDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',IsTrackStock='" & canStock & "',USUnitId='" & USUnit(0)("ItemUnitId") & "',POUnitId='" & POUnit(0)("ItemUnitId") & "',ItemStatusId='" & statusId & "',POUnitId2='" & POUnit2(0)("ItemUnitId") & "',TaxId='" & TaxId(0)("TaxId") & "' WHERE ItemId='" & materialId & "'")
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
            clear()
            loadData()
        End If
    End Sub
    Sub btnDelete()
        Dim userId As Integer = Frm_Login.UserId
        If materialId = 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกรายการที่ต้องการลบ"
            Frm_Critical.TableOkCancel.Visible = False
        End If
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "ต้องการลบข้อมูลหรือไม่"
        Frm_Critical.TableOkCancel.Visible = True
        Frm_Critical.Accep_Button.Visible = False
        If Frm_Critical.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK Then
            executesql("UPDATE Item SET Active='0',DeleteDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',DeleteUserId='" & userId & "' WHERE ItemId='" & materialId & "'")
            clear()
            loadData()
        End If
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
        'Material.PictureBoxResize.BackgroundImage = newImage
        'Material.PictureBoxResize.BackgroundImageLayout = ImageLayout.Stretch
        'Create Folder
        If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
        End If
        'Save Files
        Dim Newpath As String = "C:\ImageFilesPOS\"
        Dim NewFileName As String = "ItemresizePOS.jpg"
        'Material.PictureBoxResize.BackgroundImage.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return newImage
    End Function

    'Sub LoadUnitDefault 
    Sub AutoCompeleteSearchLoadUnitDefault()
        'Material.TxtUnitUseDefault.AutoCompleteMode = AutoCompleteMode.Suggest
        'Material.TxtUnitUseDefault.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollectionName As New AutoCompleteStringCollection()
        getDataItemName(DataCollectionName)
        'Material.TxtUnitUseDefault.AutoCompleteCustomSource = DataCollectionName
    End Sub
    Private Sub getDataItemName(ByVal dataCollectionName As AutoCompleteStringCollection)
        'Create the list to use as the custom source
        Dim MySource As New AutoCompleteStringCollection()
        Dim field As String = "UnitUseId,UnitUseName"
        Dim table As String = "ItemUseUnitDefault"
        ' Dim Where As String = ""
        Dim DataItemSearchName As DataTable = executesql("SELECT UnitUseId,UnitUseName FROM ItemUseUnitDefault WHERE Active=1")
        Dim RowsDataItemSearch As Integer = DataItemSearchName.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataItemSearch - 1
            Dim ItemCode As String = DataItemSearchName(i)("UnitUseId")
            Dim Itemname As String = DataItemSearchName(i)("UnitUseName")
            dataCollectionName.Add(Itemname)
        Next
    End Sub

    Sub AddUnitUseMaterial()
        'Btn Selected Material
        'Dim MatId As Integer = Material.MatId
        'Dim UnitName As String = Material.TxtNameUnit.Text
        'If UnitName = "" Then
        '    Frm_Critical.Show()
        '    Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
        '    Frm_Critical.TableOkCancel.Visible = False

        '    Exit Sub
        'End If
        'If MatId = 0 Then
        '    Exit Sub
        'ElseIf MatId <> 0 Then
        '    'Check Data In Table ItemUnit

        '    Dim CheckDataUnitItem As DataTable = executesql("Select ItemUnitId From ItemUnit Where ItemUnitName ='" & UnitName & "'")

        '    Dim RowsCheckDataUnitItem As Integer = CheckDataUnitItem.Rows.Count
        '    If RowsCheckDataUnitItem > 0 Then
        '        Frm_Critical.Show()
        '        Frm_Critical.head_Label.Text = "หน่วยซ้ำ"
        '        Frm_Critical.TableOkCancel.Visible = False

        '        Exit Sub
        '    Else
        '        'Insert Into ItemUnit
        '        Dim ItemUnitName As String = Material.TxtNameUnit.Text
        '        Dim Multiply As Decimal = FormatNumber(Material.TxtMultiply.Text, 2)
        '        Dim ItemUnitDetail As String = Material.TxtUnitUseDefault.Text

        '        Dim DataUnitUseId As DataTable = executesql("Select UnitUseId From ItemUseUnitDefault Where UnitUsename='" & ItemUnitDetail & "'")
        '        Dim UseUnitId As Integer
        '        If DataUnitUseId.Rows.Count = 0 Then
        '            UseUnitId = 0
        '        Else
        '            UseUnitId = DataUnitUseId(0)("UnitUseId")
        '        End If

        '        executesql("INSERT INTO ItemUnit (MatId,ItemUnitName,Multiply,UnitUseId,ItemUnitDetail) VALUES('" & MatId & "','" & ItemUnitName & "'," & Multiply & ",'" & UseUnitId & "','" & ItemUnitDetail & "')")
        '    End If
        'End If
    End Sub

    Sub AddUseItemUnit()
        '    Dim MatUseName As String = Material.TxtUnitUseDefault.Text
        '    Dim Multiply As String = Material.TxtMultiply.Text
        '    Dim NameUnit As String = Material.TxtNameUnit.Text
        '    Dim MatId As Integer = Material.MatId
        '    Dim CheckDataItemUseUnitDefault As DataTable
        '    Dim UnitUseId As Integer
        '    If MatId = 0 Then
        '        Frm_Critical.Show()
        '        Frm_Critical.head_Label.Text = "กรุณาเลือกวัตถุดิบก่อน"
        '        Frm_Critical.TableOkCancel.Visible = False

        '        Exit Sub
        '    End If
        '    If MatUseName = "" Or Multiply = "" Or NameUnit = "" Then
        '        Frm_Critical.Show()
        '        Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
        '        Frm_Critical.TableOkCancel.Visible = False

        '        Exit Sub
        '    End If
        '    'Check MatUseName 

        '    CheckDataItemUseUnitDefault = executesql("Select UnitUseId From ItemUseUnitDefault Where UnitUsename='" & MatUseName & "'")
        '    If CheckDataItemUseUnitDefault.Rows.Count = 0 Then
        '        Frm_Critical.Show()
        '        Frm_Critical.head_Label.Text = "หน่วยใช้ไม่ถูกต้อง"
        '        Frm_Critical.TableOkCancel.Visible = False

        '        Exit Sub
        '    End If
        '    UnitUseId = CheckDataItemUseUnitDefault(0)("UnitUseId")
        '    'Insert ItemUnit
        '    executesql("INSERT INTO ItemUnit (MatId,ItemUnitName,Multiply,UnitUseId,UnitUseName,Active) VALUSE('" & MatId & "','" & NameUnit & "','" & Multiply & "','" & UnitUseId & "','" & MatUseName & "',1)")
        '    LoadDgUnitUse()
        '    ClearTxtDataUnit()
        'End Sub
        'Sub LoadDgUnitUse()
        '    'Select Unit From ItemUnit
        '    Material.DgUnitUse.Rows.Clear()
        '    Dim MatId As Integer = Material.MatId
        '    Dim DataItemUnit As DataTable
        '    Dim UnitName As String
        '    Dim Multiply As Decimal
        '    Dim UnitDefault As String
        '    If MatId = 0 Then
        '        Exit Sub
        '    End If

        '    DataItemUnit = executesql("Select ItemUnitName,Multiply,UnitUseName From ItemUnit Where MatId='" & MatId & "' AND Active=1")
        '    If DataItemUnit.Rows.Count = 0 Then
        '        Exit Sub
        '    End If
        '    'For i As Integer = 0 To DataItemUnit.Rows.Count - 1
        '    '    UnitName = DataItemUnit(i)("ItemUnitName")
        '    '    Multiply = FormatNumber(DataItemUnit(i)("Multiply"), 3)
        '    '    'If Not IsDBNull(DataItemUnit(i)("UnitUseName")) Then
        '    '    UnitDefault = DataItemUnit(i)("UnitUseName")
        '    '        'End If
        '    '        Material.DgUnitUse.Rows.Add(UnitName, Multiply, UnitDefault)
        '    'Next
    End Sub
    Sub ClearTxtDataUnit()
        'Material.TxtNameUnit.Clear()
        'Material.TxtMultiply.Clear()
        'Material.TxtUnitUseDefault.Clear()
    End Sub
End Module
