Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Data.DataTable
Imports System
Module ModuleGetDataAPI
    Function gett(Url As String)
        Dim requestUrl = Url
        Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
        Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        Dim result = responseFromServer
        'Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseFromServer)
        reader.Close()
        response.Close()
        'Return table
    End Function
    Function gettQRCode(Url As String)
        Dim requestUrl = Url
        Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
        Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        Dim result = responseFromServer
        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseFromServer)
        reader.Close()
        response.Close()
        Return table
    End Function
End Module
