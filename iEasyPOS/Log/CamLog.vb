Imports System.IO

Module CamLog
    Public WithEvents cam As New DSCamCapture
    Sub CamCapture(ByVal SaleNo As String)
        Try
            cam.ConnectToDevice(0, 1, New System.Drawing.Size(612, 424), DSCamCapture.FrameSizes.s640x480, Pos_payment.PictureBox1.Handle)
            cam.Start()

            Dim filepart As String = String.Empty
            If Not Directory.Exists("C:\Temp\PicLog") Then
                Directory.CreateDirectory("C:\Temp\PicLog")
            End If

            filepart = "C:\Temp\PicLog"

            Dim DatetimeNow As String = Now.ToString("ddMMyyHHmmss", New System.Globalization.CultureInfo("th-TH"))

            Dim fName As String = SaleNo + ".jpg"
            Dim SaveAs As String = IO.Path.Combine(filepart, fName)
            cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)

        Catch ex As Exception
            writeLog(ex.Message)
        End Try

    End Sub

End Module
