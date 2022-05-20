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
        'category.RadColorBtnCate.Value = Nothing
        'category.RadColorFontCate.Value = Nothing
        'category.RadBrowseEditorImageCate.Value = Nothing
        category.PictureName = Nothing
        'category.PictureBoxResize.Image = Nothing
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
        category.ColorBtnICate.Color = Color.Silver
        category.ColorFontCate.Color = Color.Black
        ModulePOS.LoadCategory()
    End Sub
    Sub LoadDataCate()
        category.FlowLayoutPanelCatemenu.Controls.Clear()

        Dim DataCate As DataTable = executesql("SELECT CategoryId,CategoryName,BackGroundButton,ImageTextBase64,FontColor FROM CategoryItem WHERE Active=1 AND CateGroupId=1 ORDER BY CategoryId ASC")
        For i As Integer = 0 To DataCate.Rows.Count - 1
            'Create Button 
            Dim catename As New Button
            catename.Name = DataCate(i)("CategoryId") 'id
            catename.Text = DataCate(i)("CategoryName")
            catename.Height = 100
            catename.Width = 200
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
            'catename.Font = New Font("Sukhumvit Set", 14, FontStyle.Bold)
            catename.Font = New System.Drawing.Font("Kanit", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
            catename.TextAlign = ContentAlignment.BottomCenter
            catename.ForeColor = Color.FromArgb(DataCate(i)("FontColor"))
            catename.Cursor = Cursors.Hand
            category.FlowLayoutPanelCatemenu.Controls.Add(catename)
            AddHandler catename.Click, AddressOf GetCate
        Next
    End Sub
    Sub GetCate(sender As Object, e As EventArgs)
        category.PictureBoxCategory.Image = Nothing
        ButtonCateId = sender.Name
        ButtonCateName = sender.Text

        Dim GetButtonCate As DataTable = executesql("SELECT CategoryId,CategoryName,CategoryName2,CatePrinterName,PathImage,AllowPrint,ImageTextBase64,CateCode,NumberItemCode,ItemTypeId,CategoryGroupItemId,BackGroundButton,FontColor FROM CategoryItem WHERE CategoryId='" & ButtonCateId & "' AND  Active=1")
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
            Dim categroupName As String = "กลุ่ม"
            If CategoryGroupItemName.Rows.Count > 0 Then
                categroupName = CategoryGroupItemName(0)("CateGroupNameTH")
            End If
            category.CategoryGroupItem.Text = categroupName
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

        End If

        category.ColorBtnICate.Color = Color.FromArgb(GetButtonCate(0)("BackGroundButton"))
        category.ColorFontCate.Color = Color.FromArgb(GetButtonCate(0)("FontColor"))

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
            Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            Dim UserId As Integer = Frm_Login.UserId
            Dim UpdatePrinter As String = category.ComboBoxPrinter.Text
            Dim UpdateButtonBGColor As Integer = category.ColorBtnICate.Color.ToArgb
            Dim UpdateFontColor As Integer = category.ColorFontCate.Color.ToArgb
            Dim UpdateImage As String = category.Base64String
            Dim UpdateCateCode As String = category.TxtCatecode.Text
            Dim UpdateNumericItem As Integer = category.NumericItemCode.Value
            'Dim UpdateCheckAllowPrint As Boolean

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
            If UpdateImage <> "" Then

                executesql("UPDATE CategoryItem SET ImageTextBase64='" & UpdateImage & "' WHERE CategoryId='" & ButtonCateId & "'")
            End If
            'Update CateCode 
            If UpdateCateCode = "" Then
            ElseIf UpdateCateCode <> "" Then
                'Check CateCode

                Dim CheckUpdateCateCode As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CateCode='" & UpdateCateCode & "' AND NOT CategoryId='" & ButtonCateId & "' AND Active=1")
                If CheckUpdateCateCode.Rows.Count > 0 Then
                    Frm_Critical.Show()
                    Frm_Critical.head_Label.Text = "รหัสนี้มีการใช้งานแล้ว"
                    Frm_Critical.TableOkCancel.Visible = False
                    Exit Sub
                Else

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

            'Convert To Base64
            Dim Base64Textstring As String = category.Base64String
            'Insert5
            Dim TxtCateName As String = category.TxtCateName.Text
            Dim Base64Image As String = category.Base64String
            'Check Duplicate CateName

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
            Dim BtnColor As Integer = category.ColorBtnICate.Color.ToArgb
            Dim FontColor As Integer = category.ColorFontCate.Color.ToArgb
            Dim ItemTypeId As Integer  'Setting Itemtype
            Dim PathImage As String = category.PathCategoryImageOnApp & category.PictureName
            Dim Insdate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
            'Dim Image As String = category.RadBrowseEditorImageCate.Value
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

            Dim CheckCateCode As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CateCode='" & CateCode & "' AND Active=1")
            If CheckCateCode.Rows.Count > 0 Then
                Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "รหัสนี้มีการใช้งานแล้ว"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'Set Default Button Color 
            If Base64Textstring = "" Then

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
            Dim categroupId As Integer = 0
            Dim CategoryGroupItemId As DataTable = executesql("select CateGroupId from CategoryGroup where CateGroupNameTH = '" & CategoryGroupItemName & "'")
            If CategoryGroupItemId.Rows.Count > 0 Then
                categroupId = CategoryGroupItemId(0)("CateGroupId")
            End If
            executesql("INSERT INTO CategoryItem(CategoryName,CategoryName2,Active,InsertDate,UserId,ItemTypeId,CatePrinterName,BackGroundButton,PathImage,FontColor,ImageTextBase64,AllowPrint,CateCode,NumberItemCode,CateGroupId,CategoryGroupItemId) VALUES('" & CateName & "','" & CatenameEN & "','1','" & Insdate & "','" & UserId & "','" & ItemTypeId & "','" & Printer & "','" & BtnColor & "','" & PathImage & "','" & FontColor & "','" & Base64Textstring & "','" & AllowPrinterChecked & "','" & CateCode & "','" & NumerricItemId & "','" & CategoryGroup & "','" & categroupId & "')")

            Frm_Critical.Show()
                Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
                Frm_Critical.Panel1.BackColor = Color.ForestGreen
                Frm_Critical.TableOkCancel.Visible = False
                BtnAddCategory()
            LoadDataCate()

            ModulePOS.LoadCategory()
        End If
    End Sub
    'Sub ImageBrowse()
    '    category.PictureBoxCategory.ImageLocation = category.RadBrowseEditorImageCate.Value
    'End Sub
    Sub LoadPrinter()
        Dim i As Integer
        Dim CatePrinter As String
        For i = 0 To System.Drawing.Printing.PrinterSettings.
          InstalledPrinters.Count - 1
            CatePrinter = System.Drawing.Printing.PrinterSettings.
              InstalledPrinters.Item(i)
            category.ComboBoxPrinter.Properties.Items.Add(CatePrinter)
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
        category.ComboCateType.Properties.Items.Clear()
        Dim table As String = "ItemTypes"
        Dim field As String = "ItemTypeName"
        Dim DataTypeCate As DataTable = executesql("SELECT ItemTypeName FROM ItemTypes")
        For i As Integer = 0 To DataTypeCate.Rows.Count - 1
            category.ComboCateType.Properties.Items.Add(DataTypeCate(i)("ItemTypeName"))
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
        category.CategoryGroupItem.Properties.Items.Clear()
        For i As Integer = 0 To selectData.Rows.Count - 1
            category.CategoryGroupItem.Properties.Items.Add(selectData(i)("CateGroupNameTH"))
        Next
    End Sub
    Function AllowPrintOrderSetting(id As Integer) As Integer
        Dim AllowPrint As Integer
        Dim PrinterOrderSettiing As DataTable = executesql("select AllowPrint from PrintOrderSetting where TerminalName = '" & Environment.MachineName & "' AND CategoryId='" & id & "'")
        Dim CateAllowPrint As DataTable = executesql("select  AllowPrint from CategoryItem where CategoryId='" & id & "'")

        If PrinterOrderSettiing.Rows.Count = 0 Then
            AllowPrint = CateAllowPrint(0)("AllowPrint")
        Else
            AllowPrint = PrinterOrderSettiing(0)("AllowPrint")
        End If

        Return AllowPrint
    End Function
    Function printerOrderSetting(id As Integer) As String
        Dim printerName As String
        Dim PrinterOrderSettiing As DataTable = executesql("select PrinterName as CatePrinterName from PrintOrderSetting where TerminalName = '" & Environment.MachineName & "' AND CategoryId='" & id & "'")
        Dim CatePrinter As DataTable = executesql("select  CatePrinterName from CategoryItem where CategoryId='" & id & "'")

        If PrinterOrderSettiing.Rows.Count = 0 Then
            printerName = CatePrinter(0)("CatePrinterName")
        Else
            printerName = PrinterOrderSettiing(0)("CatePrinterName")
        End If

        Return printerName
    End Function
End Module
