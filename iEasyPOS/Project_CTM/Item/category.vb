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
    'Public PathCategoryImageOnDebug As String = "D:\Project_hiveup\Project_Hiveup\Project_Hiveup\Image\Category\"
    Public Base64String As String
    Private Sub Close_item_Click(sender As Object, e As EventArgs) Handles Close_item.Click
        Me.Close()
    End Sub
    Private Sub BtnAddCate_Click(sender As Object, e As EventArgs) Handles BtnAddCate.Click
        ModuleCategory.BtnAddCategory()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If RadBrowseEditorImageCate.Value = Nothing Then
            'MsgBox("no image")
            PictureName = ""
            'PathCategoryImageOnDebug = ""
            ModuleCategory.BtnSaveCategory()
            Exit Sub
        Else
            'Check TextBox 
            If TxtCateName.Text = "" Or TxtCateNameEN.Text = "" Then
                Frm_Critical.ShowDialog()
                Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
                Frm_Critical.TableOkCancel.Visible = False
                Exit Sub
            End If
            'Resize Image
            Dim PathFName As String = "C:\ImageFilesPOS\ImageresizePOS.jpg"
            PictureBoxCategory.Image = Image.FromFile(RadBrowseEditorImageCate.Value)
            ResizeImage(PictureBoxCategory.Image, New Size(200, 200), True)
            'ConvertTo Base64 
            Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
                Base64String = Convert.ToBase64String(Imageaaray)
                ModuleCategory.BtnSaveCategory()
            Exit Sub
        End If
    End Sub
    Private Sub RadBrowseEditorImageCate_ValueChanged(sender As Object, e As EventArgs) Handles RadBrowseEditorImageCate.ValueChanged
        ModuleCategory.ImageBrowse()
    End Sub
    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericItemCode.Maximum = 100
        ModuleCategory.LoadTypeCategory()
        ModuleCategory.LoadPrinter()
        ModuleCategory.LoadDataCate()
        ModuleCategory.LoadCateItemType()
        ModuleCategory.loadCategoryGroupItem()
    End Sub
    Private Sub BtnClearImage_Click(sender As Object, e As EventArgs) Handles BtnClearImage.Click
        'Update ImageTextBase64 = Null
        Dim ButtonCateId As Integer = ModuleCategory.ButtonCateId
        Dim table As String = "CategoryItem"
        Dim value As String = "ImageTextBase64=''"
        Dim where As String = "CategoryId='" & ButtonCateId & "'"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
        executesql("UPDATE CategoryItem SET ImageTextBase64='' WHERE CategoryId='" & ButtonCateId & "'")
        PictureBoxCategory.Image = Nothing
        RadBrowseEditorImageCate.Controls.Clear()
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
        PictureBoxResize.Image = newImage
        'Create Folder
        If (Not System.IO.Directory.Exists("C:\ImageFilesPOS")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesPOS")
        End If
        'Save Files
        Dim Newpath As String = "C:\ImageFilesPOS\"
        Dim NewFileName As String = "ImageresizePOS.jpg"
        PictureBoxResize.Image.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return newImage
    End Function
    Private Sub BtnDeleteCate_Click(sender As Object, e As EventArgs) Handles BtnDeleteCate.Click
        'Delete Active Cateory 
        Dim CateId As Integer = ModuleCategory.ButtonCateId
        Dim DelDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim table As String = "CategoryItem"
        Dim value As String = "Active = 0,DeleteDate='" & DelDate & "',UserId='" & UserId & "'"
        Dim where As String = "CategoryId='" & CateId & "'"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
        executesql("UPDATE CategoryItem SET Active = 0,DeleteDate='" & DelDate & "',UserId='" & UserId & "' WHERE CategoryId='" & CateId & "'")
        ModuleCategory.BtnAddCategory()
        ModuleCategory.LoadDataCate()
    End Sub

    Private Sub Top_tap_Click(sender As Object, e As EventArgs) Handles Top_tap.Click

    End Sub
End Class