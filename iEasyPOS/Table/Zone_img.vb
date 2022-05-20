Imports System.Drawing.Image
Imports System.Drawing.Drawing2D
Imports System.Drawing.Bitmap
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
Imports RasterEdge.Imaging.Basic
Imports RasterEdge.Imaging.Basic.Core
Imports System
Imports System.Text
Imports Microsoft.VisualBasic.Strings
Public Class Zone_img
    Private Sub BtnSave_zone_img_Click(sender As Object, e As EventArgs) Handles BtnSave_zone_img.Click
        'Resize Image
        Dim PathFName As String = "C:\ImageFilesHiveUp\ImageresizeHiveUp.MemoryBmp"

        If zone_img_brow.Value = "" Then
            MsgBox("กรุณาเลือกรูปภาพ")
            Exit Sub
        End If
        PictureBox1.Image = Image.FromFile(zone_img_brow.Value)
        ResizeImage(PictureBox1.Image, New Size(1000, 500), True)

        'ConvertTo Base64 
        Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
        Dim base64image = Convert.ToBase64String(Imageaaray)
        Dim Value As String = "ImageTextBase64 = '" & base64image & "' where Zoneid = '" & ZoneId_floor & "' AND Active=1"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Zones&value=" & Value & "")
        executesql("update  Zones set ImageTextBase64 = '" & base64image & "' where Zoneid = '" & ZoneId_floor & "' AND Active=1")

        Me.Close()

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
        If (Not System.IO.Directory.Exists("C:\ImageFilesHiveUp")) Then
            System.IO.Directory.CreateDirectory("C:\ImageFilesHiveUp")
        End If
        'Save Files
        Dim Newpath As String = "C:\ImageFilesHiveUp\"
        Dim NewFileName As String = "ImageresizeHiveUp.MemoryBmp"
        PictureBoxResize.Image.Save(Newpath + NewFileName, System.Drawing.Imaging.ImageFormat.MemoryBmp)
        Return newImage
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnClearImage_Click(sender As Object, e As EventArgs) Handles BtnClearImage.Click
        Dim Value As String = "ImageTextBase64 = ' ' where Zoneid = '" & ZoneId_floor & "' AND Active=1"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=Zones&value=" & Value & "")
        executesql("update  Zones set ImageTextBase64 = ' ' where Zoneid = '" & ZoneId_floor & "' AND Active=1")
        Me.Close()
    End Sub
End Class