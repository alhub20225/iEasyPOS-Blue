Imports System.IO
Imports System.IO.Path
Imports System.IO.File
Imports System.IO.IOException
Imports System.Drawing.Imaging
Imports System.Data.OleDb
Module ModuleCategory
    Public FilePath As String
    Public NewPicName() As String
    Public ButtonCateId As Integer
    Public ButtonCateName As String
    Sub BtnAddCategory()
        category.TxtCateName.Clear()
        category.TxtCateNameEN.Clear()
        category.CheckBoxCateDiscount.Checked = False
        category.CheckBoxAllowPrint.Checked = False
        category.PictureBoxCategory.Image = Nothing
        category.RadColorBtnCate.Value = Nothing
        category.RadColorFontCate.Value = Nothing
        category.RadBrowseEditorImageCate.Value = Nothing
        category.PictureName = Nothing
        category.PictureBoxResize.Image = Nothing
        category.PictureBoxCategory.Image = Nothing
        category.TxtCateNameEN.Text = Nothing
        FilePath = Nothing
        ButtonCateId = Nothing
        ButtonCateName = Nothing
        category.TxtCatecode.Text = Nothing
        category.NumericItemCode.Value = 0
        category.ComboCateType.Text = Nothing
        category.ComboBoxPrinter.Text = Nothing
        category.CategoryGroupItem.Text = Nothing
    End Sub
    Sub LoadDataCate()
        category.FlowLayoutPanelCatemenu.Controls.Clear()
        Dim table As String = "CategoryItem"
        Dim field As String = "CategoryId,CategoryName,BackGroundButton,ImageTextBase64,FontColor"
        Dim where As String = "Active=1 AND CateGroupId=1 BY CategoryId ASC"
        'Dim DataCate As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataCate As DataTable = executesql("SELECT CategoryId,CategoryName,BackGroundButton,ImageTextBase64,FontColor FROM CategoryItem WHERE Active=1 AND CateGroupId=1 ORDER BY CategoryId ASC")
        For i As Integer = 0 To DataCate.Rows.Count - 1
            'Create Button 
            Dim catename As New Button
            catename.Name = DataCate(i)("CategoryId") 'id
            catename.Text = DataCate(i)("CategoryName")
            catename.Height = 120
            catename.Width = 220
            If DataCate(i)("ImageTextBase64") = "" Then
                catename.BackColor = Color.FromArgb(DataCate(i)("BackGroundButton"))
            Else
                If DataCate(i)("ImageTextBase64") <> "" Then
                    'Setup image and get data stream together
                    Dim img As System.Drawing.Image
                    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    Dim b() As Byte
                    'Converts the base64 encoded msg to image data
                    b = Convert.FromBase64String(DataCate(i)("ImageTextBase64"))
                    MS = New System.IO.MemoryStream(b)
                    'creates image
                    img = System.Drawing.Image.FromStream(MS)
                    catename.BackgroundImage = img
                    catename.BackgroundImageLayout = ImageLayout.Stretch
                End If
            End If
            'If DataCate(i)("ImageTextBase64") = "" Then
            '    catename.BackColor = Color.FromArgb(DataCate(i)("BackGroundButton"))
            'End If

            catename.FlatStyle = FlatStyle.Flat
            catename.FlatAppearance.BorderColor = Color.DarkGray
            catename.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
            catename.TextAlign = ContentAlignment.BottomCenter
            catename.ForeColor = Color.FromArgb(DataCate(i)("FontColor"))
            category.FlowLayoutPanelCatemenu.Controls.Add(catename)
            AddHandler catename.Click, AddressOf GetCate
        Next
    End Sub
    Sub GetCate(sender As Object, e As EventArgs)
        category.PictureBoxCategory.Image = Nothing
        ButtonCateId = sender.Name
        ButtonCateName = sender.Text
        Dim table As String = "CategoryItem"
        Dim field As String = "CategoryId,CategoryName,CategoryName2,CatePrinterName,PathImage,AllowPrint,ImageTextBase64,CateCode,NumberItemCode"
        Dim where As String = "CategoryId='" & ButtonCateId & "' AND  Active=1"
        'Dim GetButtonCate As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim GetButtonCate As DataTable = executesql("SELECT CategoryId,CategoryName,CategoryName2,CatePrinterName,PathImage,AllowPrint,ImageTextBase64,CateCode,NumberItemCode,ItemTypeId,CategoryGroupItemId FROM CategoryItem WHERE CategoryId='" & ButtonCateId & "' AND  Active=1")
        category.TxtCateName.Text = ButtonCateName
        If GetButtonCate.Rows.Count = 0 Then
            category.TxtCateNameEN.Text = ""
        Else
            category.TxtCateNameEN.Text = GetButtonCate(0)("CategoryName2")
        End If
        If IsDBNull(GetButtonCate(0)("CategoryGroupItemId")) Then
            category.CategoryGroupItem.Text = ""
        Else
            Dim CategoryGroupItemName As DataTable = executesql("select CateGroupNameTH from CategoryGroup where CateGroupId='" & GetButtonCate(0)("CategoryGroupItemId") & "'")
            category.CategoryGroupItem.Text = CategoryGroupItemName(0)("CateGroupNameTH")
        End If

        If GetButtonCate.Rows.Count = 0 Then
            category.ComboBoxPrinter.Text = ""
        Else
            category.ComboBoxPrinter.Text = GetButtonCate(0)("CatePrinterName")
        End If
        If GetButtonCate.Rows.Count = 0 Then
            category.TxtCatecode.Text = ""
        Else
            category.TxtCatecode.Text = GetButtonCate(0)("CateCode")
        End If

        If GetButtonCate.Rows.Count = 0 Then
            category.NumericItemCode.Value = 0
        Else
            category.NumericItemCode.Value = GetButtonCate(0)("NumberItemCode")
        End If
        If GetButtonCate.Rows.Count = 0 Then
            category.PictureBoxCategory.Image = Nothing
            Exit Sub
        ElseIf GetButtonCate(0)("ImageTextBase64") <> "" Then
            'Setup image and get data stream together
            Dim img As System.Drawing.Image
            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b() As Byte
            'Converts the base64 encoded msg to image data
            b = Convert.FromBase64String(GetButtonCate(0)("ImageTextBase64"))
            MS = New System.IO.MemoryStream(b)
            'creates image
            img = System.Drawing.Image.FromStream(MS)
            category.PictureBoxCategory.Image = img
            Exit Sub
        End If
        Dim selectItemTypes As DataTable = executesql("SELECT * FROM ItemTypes WHERE ItemTypeId = '" & GetButtonCate(0)("ItemTypeId") & "'")
        category.ComboCateType.Text = selectItemTypes(0)("ItemTypeName")
        'Check CheckBox Allow Printer
        If GetButtonCate(0)("AllowPrint") = 1 Then
            category.CheckBoxAllowPrint.Checked = True
        ElseIf GetButtonCate(0)("AllowPrint") = 0 Then
            category.CheckBoxAllowPrint.Checked = False
        End If
    End Sub
    Sub BtnSaveCategory()
        'Update
        If category.ComboCateType.Text = "" Then
            MsgBox("กรุณาเลือกชนิดสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ButtonCateId > 0 Then
            Dim UpdateCateName As String = category.TxtCateName.Text
            Dim UpdateCateNameEN As String = category.TxtCateNameEN.Text
            Dim UpdateTypeCate As Integer = 1 'Setting Itemtype
            Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            Dim UserId As Integer = Frm_Login.UserId
            Dim UpdatePrinter As String = category.ComboBoxPrinter.Text
            Dim UpdateButtonBGColor As Integer = category.RadColorBtnCate.Value.ToArgb
            Dim UpdateFontColor As Integer = category.RadColorFontCate.Value.ToArgb
            Dim UpdateImage As String = category.Base64String
            Dim UpdateCateCode As String = category.TxtCatecode.Text
            Dim UpdateNumericItem As Integer = category.NumericItemCode.Value
            'Dim UpdateCheckAllowPrint As Boolean
            Dim table As String
            Dim value As String
            Dim where As String
            'Check CheckBox AllowPrint And UPdate 
            If category.CheckBoxAllowPrint.Checked = True Then

                executesql("UPDATE CategoryItem SET AllowPrint=1 WHERE Active =1  AND CategoryId='" & ButtonCateId & "'")
            ElseIf category.CheckBoxAllowPrint.Checked = False Then

                executesql("UPDATE CategoryItem SET AllowPrint=0 WHERE Active =1 AND CategoryId='" & ButtonCateId & "'")
            End If
            'Update CateName & Properties

            executesql("UPDATE CategoryItem SET CategoryName='" & UpdateCateName & "',CategoryName2='" & UpdateCateNameEN & "',CatePrinterName='" & UpdatePrinter & "',Updatedate='" & UpdateDate & "',UserId='" & UserId & "' WHERE CategoryId='" & ButtonCateId & "'")
            'Update button color
            If UpdateButtonBGColor = 0 Then
            ElseIf UpdateButtonBGColor <> 0 Then

                executesql("UPDATE CategoryItem SET BackGroundButton='" & UpdateButtonBGColor & "' WHERE CategoryId='" & ButtonCateId & "'")
            End If
            'Update Font Color 
            If UpdateFontColor = 0 Then
            ElseIf UpdateFontColor <> 0 Then

                executesql("UPDATE CategoryItem SET FontColor='" & UpdateFontColor & "' WHERE CategoryId='" & ButtonCateId & "'")
            End If
            'Update Image 
            If category.RadBrowseEditorImageCate.Value = "" Then
            ElseIf UpdateImage <> "" Then

                executesql("UPDATE CategoryItem SET ImageTextBase64='" & UpdateImage & "' WHERE CategoryId='" & ButtonCateId & "'")
            End If
            'Update CateCode 
            If UpdateCateCode = "" Then
            ElseIf UpdateCateCode <> ""
                'Check CateCode
                table = "CategoryItem"
                value = "CategoryId"
                where = " CateCode='" & UpdateCateCode & "' AND NOT CategoryId='" & ButtonCateId & "'"
                'Dim CheckUpdateCateCode As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&value=" & value & "&where=" & where & "")
                Dim CheckUpdateCateCode As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CateCode='" & UpdateCateCode & "' AND NOT CategoryId='" & ButtonCateId & "' AND Active=1")
                If CheckUpdateCateCode.Rows.Count > 0 Then
                    Frm_Critical.Show()
                    Frm_Critical.head_Label.Text = "รหัสนี้มีการใช้งานแล้ว"
                    Frm_Critical.TableOkCancel.Visible = False
                    Exit Sub
                Else
                    table = "CategoryItem"
                    value = "CateCode='" & UpdateCateCode & "'"
                    where = "CategoryId='" & ButtonCateId & "'"
                    'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
                    executesql("UPDATE CategoryItem SET CateCode='" & UpdateCateCode & "'WHERE CategoryId='" & ButtonCateId & "'")
                End If
            End If
            'Update Numeric 
            If UpdateCateCode = "" Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "กรุณากรอกความยาวของ Code Item"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            Else
                table = "CategoryItem"
                value = "NumberItemCode='" & UpdateNumericItem & "'"
                where = "CategoryId='" & ButtonCateId & "'"
                'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
                executesql("UPDATE CategoryItem SET NumberItemCode='" & UpdateNumericItem & "'WHERE CategoryId='" & ButtonCateId & "'")
            End If
            Dim CategoryGroupItemName As String = category.CategoryGroupItem.Text
            If CategoryGroupItemName = "" Then
                MsgBox("กรุณาเลือกกลุ่มหมวดหมู่", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Dim CategoryGroupItemId As DataTable = executesql("select CateGroupId from CategoryGroup where CateGroupNameTH = '" & CategoryGroupItemName & "'")
                executesql("UPDATE CategoryItem SET CategoryGroupItemId='" & CategoryGroupItemId(0)("CateGroupId") & "'WHERE CategoryId='" & ButtonCateId & "'")
            End If


            LoadDataCate()
            BtnAddCategory()
        ElseIf ButtonCateId = 0 Then
            'API param
            Dim table As String
            Dim field As String
            Dim where As String
            Dim value As String
            'Convert To Base64
            Dim Base64Textstring As String
            'Insert5
            Dim TxtCateName As String = category.TxtCateName.Text
            Dim Base64Image As String = category.Base64String
            'Check Duplicate CateName
            table = "CategoryItem"
            field = "CategoryName"
            where = "CategoryName='" & TxtCateName & "'  AND Active = 1"
            'Dim CheckName As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
            Dim CheckName As DataTable = executesql("Select CategoryName FROM CategoryItem WHERE CategoryName='" & TxtCateName & "'  AND Active = 1 ")
            'If CheckName.Rows.Count > 0 Then
            '    Frm_Critical.Show()
            '    Frm_Critical.head_Label.Text = "มีชื่อหมวดหมู่นี้อยู่เเล้ว"
            '    Frm_Critical.TableOkCancel.Visible = False
            '    Exit Sub
            'End If
            Dim CatenameEN As String = category.TxtCateNameEN.Text
            Dim UserId As Integer = Frm_Login.UserId
            Dim CateName As String = category.TxtCateName.Text
            Dim CateType As String = category.ComboCateType.Text
            Dim Printer As String = category.ComboBoxPrinter.Text
            Dim BtnColor As Integer = category.RadColorBtnCate.Value.ToArgb
            Dim FontColor As Integer = category.RadColorFontCate.Value.ToArgb
            Dim ItemTypeId As Integer  'Setting Itemtype
            Dim PathImage As String = category.PathCategoryImageOnApp & category.PictureName
            Dim Insdate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            Dim Image As String = category.RadBrowseEditorImageCate.Value
            Dim CategoryType As String = category.ComboCateType.Text
            Dim CateCode As String = category.TxtCatecode.Text
            Dim NumerricItemId As Integer = category.NumericItemCode.Value
            Dim AllowPrinterChecked As Integer
            Dim CategoryGroup As Integer = 1
            Select Case (CategoryType)
                Case "อาหาร"
                    ItemTypeId = 1
                Case "เครื่องดื่ม"
                    ItemTypeId = 2
                Case "อื่นๆ"
                    ItemTypeId = 3
            End Select
            'Cheak CateName
            If CateName = "" Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "กรุณาใส่ชื่อหมวดสินค้า"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'Cheak CateCode And Duplicate CateCode
            If CateCode = "" Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "กรุณาใส่รหัสของหมวดหมู่สินค้า"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            table = "CategoryItem"
            field = "CategoryId"
            where = "CateCode='" & CateCode & "'"
            'Dim CheckCateCode As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
            Dim CheckCateCode As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CateCode='" & CateCode & "' AND Active=1")
            If CheckCateCode.Rows.Count > 0 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "รหัสนี้มีการใช้งานแล้ว"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'Set Default Button Color 
            If category.RadBrowseEditorImageCate.Value = Nothing Then
                Base64Textstring = ""
                If BtnColor = 0 Then 'White Cokor Btn
                    BtnColor = -4473925
                End If
                If FontColor = 0 Then 'black font
                    FontColor = -16777216
                End If
            End If
            'Allow Printer 
            If category.CheckBoxAllowPrint.Checked = True Then
                AllowPrinterChecked = 1
            ElseIf category.CheckBoxAllowPrint.Checked = False Then
                AllowPrinterChecked = 0
            End If
            'Check NumericItemId
            If NumerricItemId = 0 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "กรุณาใส่จำนวนของรหัสสินค้า"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            Dim CategoryGroupItemName As String = category.CategoryGroupItem.Text
            If CategoryGroupItemName = "" Then
                MsgBox("กรุณาเลือกกลุ่มหมวดหมู่", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim CategoryGroupItemId As DataTable = executesql("select CateGroupId from CategoryGroup where CateGroupNameTH = '" & CategoryGroupItemName & "'")
            'Insert Into CategoryItem   
            'table = "CategoryItem"
            'field = "CategoryName,CategoryName2,Active,InsertDate,UserId,ItemTypeId,CatePrinterName,BackGroundButton,PathImage,FontColor,ImageTextBase64,AllowPrint,CateCode,NumberItemCode,CateGroupId"
            'value = "'" & CateName & "','" & CatenameEN & "','1','" & Insdate & "','" & UserId & "','" & ItemTypeId & "','" & Printer & "','" & BtnColor & "','" & PathImage & "','" & FontColor & "','" & Base64Textstring & "','" & AllowPrinterChecked & "','" & CateCode & "','" & NumerricItemId & "','" & CategoryGroup & "'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&table=" & table & "&field=" & field & "&value=" & value & "")
            executesql("INSERT INTO CategoryItem(CategoryName,CategoryName2,Active,InsertDate,UserId,ItemTypeId,CatePrinterName,BackGroundButton,PathImage,FontColor,ImageTextBase64,AllowPrint,CateCode,NumberItemCode,CateGroupId,CategoryGroupItemId) VALUES('" & CateName & "','" & CatenameEN & "','1','" & Insdate & "','" & UserId & "','" & ItemTypeId & "','" & Printer & "','" & BtnColor & "','" & PathImage & "','" & FontColor & "','" & Base64Textstring & "','" & AllowPrinterChecked & "','" & CateCode & "','" & NumerricItemId & "','" & CategoryGroup & "','" & CategoryGroupItemId(0)("CateGroupId") & "')")
            'Clipboard.SetText("INSERT INTO CategoryItem(CategoryName,CategoryName2,Active,InsertDate,UserId,ItemTypeId,CatePrinterName,BackGroundButton,PathImage,FontColor,ImageTextBase64,AllowPrint,CateCode,NumberItemCode,CateGroupId) VALUES('" & CateName & "','" & CatenameEN & "','1','" & Insdate & "','" & UserId & "','" & ItemTypeId & "','" & Printer & "','" & BtnColor & "','" & PathImage & "','" & FontColor & "','" & Base64Textstring & "','" & AllowPrinterChecked & "','" & CateCode & "','" & NumerricItemId & "','" & CategoryGroup & "')")
            Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
                Frm_Critical.Panel1.BackColor = Color.ForestGreen
                Frm_Critical.TableOkCancel.Visible = False
                BtnAddCategory()
                LoadDataCate()
            End If
    End Sub
    Sub ImageBrowse()
        category.PictureBoxCategory.ImageLocation = category.RadBrowseEditorImageCate.Value
    End Sub
    Sub LoadPrinter()
        Dim i As Integer
        Dim CatePrinter As String
        For i = 0 To System.Drawing.Printing.PrinterSettings.
          InstalledPrinters.Count - 1
            CatePrinter = System.Drawing.Printing.PrinterSettings.
              InstalledPrinters.Item(i)
            category.ComboBoxPrinter.Items.Add(CatePrinter)
        Next
    End Sub
    Public Function Base64Text() As String
        'Create Folder
        If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
        End If
        Dim imagearray() As Byte = System.IO.File.ReadAllBytes("C:\ImageFilesPOS\ImageresizePOS.jpg")
        Dim base64image As String = Convert.ToBase64String(imagearray)
        Return base64image
    End Function
    Sub LoadTypeCategory()
        'load Type category 
        category.ComboCateType.Items.Clear()
        Dim table As String = "ItemTypes"
        Dim field As String = "ItemTypeName"
        'Dim DataTypeCate As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&fiele=ItemTypeName&table=ItemTypes")
        Dim DataTypeCate As DataTable = executesql("SELECT ItemTypeName FROM ItemTypes")
        For i As Integer = 0 To DataTypeCate.Rows.Count - 1
            category.ComboCateType.Items.Add(DataTypeCate(i)("ItemTypeName"))
        Next
    End Sub
    Sub LoadCateItemType()
        'category.ComboCateType.Items.Add("อาหาร")
        'category.ComboCateType.Items.Add("เครื่องดื่ม")
        'category.ComboCateType.Items.Add("อื่นๆ")
    End Sub
    Sub loadCategoryGroupItem()
        Dim selectData As DataTable = executesql("select * from CategoryGroup where Active='1'")
        If IsNothing(selectData) Then
            Exit Sub
        End If
        If selectData.rows.count = 0 Then
            Exit Sub
        End If
        category.CategoryGroupItem.Items.Clear()
        For i As Integer = 0 To selectData.Rows.Count - 1
            category.CategoryGroupItem.Items.Add(selectData(i)("CateGroupNameTH"))
        Next
    End Sub
End Module
