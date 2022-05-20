Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Data.DataTable
Imports System
Imports System.Text
Imports Newtonsoft.Json.Linq

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
    Function posttoken(url As String)
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create(url)
        enc = New System.Text.UTF8Encoding()
        postdata = "grant_type=client_credentials&client_id=2&client_secret=SlKhxlTAvtcGydVCWDEEoCzTU1ctnitHI34ejmgK"
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim datastream As Stream = result.GetResponseStream()
        Dim reader As New StreamReader(datastream)
        Dim responsefromserver As String = reader.ReadToEnd()
        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)("[" & responsefromserver & "]")
        Return table
    End Function
    Function postt(Url As String, token As String, postData As String)
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create(Url)
        enc = New System.Text.UTF8Encoding()
        postdatabytes = enc.GetBytes(postData)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.Accept = "application/x-www-form-urlencoded"
        s.Headers.Add("Authorization", token)
        s.ContentLength = postdatabytes.Length
        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim datastream As Stream = result.GetResponseStream()
        Dim reader As New StreamReader(datastream)
        Dim responsefromserver As String = reader.ReadToEnd()
        'Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)("[" & responsefromserver & "]")
        'Return table
        Dim dataObject As JObject = JObject.Parse(responsefromserver)
        Return dataObject
    End Function
End Module
