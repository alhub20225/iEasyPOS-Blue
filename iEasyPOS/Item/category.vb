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
Public Class category
    'Path Copy File Image 
    Public Shared PictureName As String
    Public PathCategoryImageOnApp As String = Application.StartupPath & "\Image\Category\"
    Public Base64String As String
    'Private Sub Close_item_Click(sender As Object, e As EventArgs) Handles Close_item.Click
    '    Me.Close()
    'End Sub
    Private Sub BtnAddCate_Click(sender As Object, e As EventArgs) Handles BtnAddCate.Click
        ModuleCategory.BtnAddCategory()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Console.WriteLine(0)
        If TxtCateName.Text = "" Or TxtCateNameEN.Text = "" Then
            Frm_Critical.ShowDialog()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        Else
            ModuleCategory.BtnSaveCategory()
            ModuleItems.LoadCategory()
            Base64String = ""
            PictureBoxCategory.BackgroundImage = Nothing
            Exit Sub
        End If
    End Sub
    'Private Sub RadBrowseEditorImageCate_ValueChanged(sender As Object, e As EventArgs) Handles RadBrowseEditorImageCate.ValueChanged
    '    ModuleCategory.ImageBrowse()
    'End Sub
    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        NumericItemCode.Maximum = 100
        ModuleCategory.LoadTypeCategory()
        ModuleCategory.LoadPrinter()
        ModuleCategory.LoadDataCate()
        ModuleCategory.LoadCateItemType()
        ModuleCategory.loadCategoryGroupItem()

        'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\POS_CTM\POS", "HQ_Connect", Nothing) = True Then
        '    BtnAddCate.Enabled = False
        '    BtnDeleteCate.Enabled = False
        '    BtnSave.Enabled = False
        'End If

        ColorBtnICate.Color = Color.Silver
        ColorFontCate.Color = Color.Black

    End Sub
    Private Sub BtnClearImage_Click(sender As Object, e As EventArgs) Handles BtnClearImage.Click
        Dim ButtonCateId As Integer = ModuleCategory.ButtonCateId
        executesql("UPDATE CategoryItem SET ImageTextBase64='' WHERE CategoryId='" & ButtonCateId & "'")
        PictureBoxCategory.Image = Nothing
        Base64String = ""
        PictureBoxCategory.BackgroundImage = Nothing
        BtnAddCategory()
        LoadDataCate()
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
        PictureBoxCategory.BackgroundImage = newImage
        PictureBoxCategory.BackgroundImageLayout = ImageLayout.Stretch
        'Create Folder
        If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
        End If
        'Save Files
        Dim Newpath As String = "C:\ImageFilesPOS\"
        Dim NewFileName As String = "CateImageresize.jpg"
        PictureBoxCategory.BackgroundImage.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return newImage
    End Function
    Private Sub BtnDeleteCate_Click(sender As Object, e As EventArgs) Handles BtnDeleteCate.Click
        'Delete Active Cateory 
        Dim CateId As Integer = ModuleCategory.ButtonCateId
        Dim DelDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
        Dim UserId As Integer = Frm_Login.UserId

        executesql("UPDATE CategoryItem SET Active = 0,DeleteDate='" & DelDate & "',UserId='" & UserId & "' WHERE CategoryId='" & CateId & "'")
        ModuleCategory.BtnAddCategory()
        ModuleCategory.LoadDataCate()
        Base64String = ""
        PictureBoxCategory.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBoxCategory_Click(sender As Object, e As EventArgs) Handles PictureBoxCategory.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso Not String.IsNullOrEmpty(OpenFileDialog1.FileName) Then
            PictureBoxCategory.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            PictureBoxCategory.BackgroundImage = ResizeImage(Image.FromFile(OpenFileDialog1.FileName), New Size(250, 250), True)

            'Convert to Base64String 
            Dim PathFName As String = "C:\ImageFilesPOS\CateImageresize.jpg"
            Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
            Base64String = Convert.ToBase64String(Imageaaray)
        End If
    End Sub

    Sub change_to_th_text()
        PageManagementBrand.Text = My.Resources.category_th.categoryProduct
        Label1.Text = My.Resources.category_th.categoryProduct
        BtnAddCate.Text = My.Resources.category_th.clearText
        BtnDeleteCate.Text = My.Resources.category_th.delete
        Label2.Text = My.Resources.category_th.detail
        Label11.Text = My.Resources.category_th.image
        BtnClearImage.Text = My.Resources.category_th.delimage
        Label4.Text = My.Resources.category_th.categoryCode
        Label5.Text = My.Resources.category_th.numberic
        Label3.Text = My.Resources.category_th.categoryName
        Label6.Text = My.Resources.category_th.categoryNameEN
        Label7.Text = My.Resources.category_th.productType
        Label8.Text = My.Resources.category_th.groupType
        Label14.Text = My.Resources.category_th.more
        Label13.Text = My.Resources.category_th.discount
        Label12.Text = My.Resources.category_th.allowPrint
        Label10.Text = My.Resources.category_th.buttonColor
        Label23.Text = My.Resources.category_th.TextColor
        BtnSave.Text = My.Resources.category_th.Save
    End Sub

    Sub change_to_eng_text()
        PageManagementBrand.Text = My.Resources.category_en.categoryProduct
        Label1.Text = My.Resources.category_en.categoryProduct
        BtnAddCate.Text = My.Resources.category_en.clearText
        BtnDeleteCate.Text = My.Resources.category_en.delete
        Label2.Text = My.Resources.category_en.detail
        Label11.Text = My.Resources.category_en.image
        BtnClearImage.Text = My.Resources.category_en.delimage
        Label4.Text = My.Resources.category_en.categoryCode
        Label5.Text = My.Resources.category_en.numberic
        Label3.Text = My.Resources.category_en.categoryName
        Label6.Text = My.Resources.category_en.categoryNameEN
        Label7.Text = My.Resources.category_en.productType
        Label8.Text = My.Resources.category_en.groupType
        Label14.Text = My.Resources.category_en.more
        Label13.Text = My.Resources.category_en.discount
        Label12.Text = My.Resources.category_en.allowPrint
        Label10.Text = My.Resources.category_en.buttonColor
        Label23.Text = My.Resources.category_en.TextColor
        BtnSave.Text = My.Resources.category_en.Save
    End Sub
End Class