Imports System.IO

Module SystemLog
    Sub writeLog(ByVal message As String)
        Try
            Dim filepart As String = String.Empty
            If Not Directory.Exists("C:\Temp") Then
                Directory.CreateDirectory("C:\Temp")
            End If
            Dim filename As String = $"{DateTime.Today:ddMMyyyy}.txt"
            filepart = "C:\Temp\" & filename
            Dim streamWriter As StreamWriter = If(Not File.Exists(filepart), File.CreateText(filepart), File.AppendText(filepart))
            Dim DatetimeNow As String = Now.ToString("yyyy-MM-ddTHH:mm", New System.Globalization.CultureInfo("en-US"))
            streamWriter.WriteLine(message + " :" + DatetimeNow)
            streamWriter.Close()
        Catch ex As Exception
            Console.Out.WriteLine("Error in writing log :" & ex.Message)
        End Try
    End Sub

End Module
