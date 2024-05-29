Imports System.IO
Imports System.Net
Imports System.Web.Script.Services
Imports System.Web.Services
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class JiraData
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetDataProduct() As List(Of result)

        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim url As String = "https://cantas-support.atlassian.net/rest/api/2/field/customfield_10047/context/10150/option"
        Dim RequestUrl As New Uri(url)

        Dim username As String = "OperationTelmark@telmark.co.id"
        Dim password As String = "ATATT3xFfGF0f-FbZ8H2PHgLYx-AHr7pjQN9Atk6ekW4C4XwT7wAjCrW9nTqj55n5x4N1faM3rKOADVS8Rh4XcVwV8eKDSjzIgr34ksq_cylyyu2O9ozhWhGiEhagvYo7BG77_jfZw62rMXcgmtWIDcviRF7niFUygYYlobXZofr64DgkzHW-N4=88E67ED8"
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password))

        ' Buat objek WebClient
        Dim request As WebRequest = WebRequest.CreateDefault(RequestUrl)
        request.Method = "GET"

        Dim response As WebResponse = Nothing
        Try
            request.Headers(HttpRequestHeader.Authorization) = "Basic T3BlcmF0aW9uVGVsbWFya0B0ZWxtYXJrLmNvLmlkOkFUQVRUM3hGZkdGMGYtRmJaOEgyUEhnTFl4LUFIcjdwalFOOUF0azZla1c0QzRYd1Q3d0FqQ3JXOW5UcWo1NW41eDROMWZhTTNyS09BRFZTOFJoNFhjVndWOGVLRFNqeklncjM0a3NxX2N5bHl5dTJPOW96aFdoR2lFaGFndllvN0JHNzdfamZadzYyck1YY2dtdFdJRGN2aVJGN25pRlV5Z1lZbG9iWFpvZnI2NERna3pIVy1OND04OEU2N0VEOA=="
            response = request.GetResponse()
        Catch exc As WebException
            response = exc.Response
        End Try

        If response Is Nothing Then
            Throw New HttpException(CInt(HttpStatusCode.NotFound), "The requested url could not be found.")
        End If

        Using reader As New StreamReader(response.GetResponseStream())
            Dim requestedText As String = reader.ReadToEnd()

            'GetIdAndValueFromJson(requestedText)

            Return GetIdAndValueFromJson(requestedText)

        End Using


    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetDataFlatform() As List(Of result)

        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim url As String = "https://cantas-support.atlassian.net/rest/api/2/field/customfield_10049/context/10152/option"
        Dim RequestUrl As New Uri(url)

        Dim username As String = "OperationTelmark@telmark.co.id"
        Dim password As String = "ATATT3xFfGF0f-FbZ8H2PHgLYx-AHr7pjQN9Atk6ekW4C4XwT7wAjCrW9nTqj55n5x4N1faM3rKOADVS8Rh4XcVwV8eKDSjzIgr34ksq_cylyyu2O9ozhWhGiEhagvYo7BG77_jfZw62rMXcgmtWIDcviRF7niFUygYYlobXZofr64DgkzHW-N4=88E67ED8"
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password))

        ' Buat objek WebClient
        Dim request As WebRequest = WebRequest.CreateDefault(RequestUrl)
        request.Method = "GET"

        Dim response As WebResponse = Nothing
        Try
            request.Headers(HttpRequestHeader.Authorization) = "Basic T3BlcmF0aW9uVGVsbWFya0B0ZWxtYXJrLmNvLmlkOkFUQVRUM3hGZkdGMGYtRmJaOEgyUEhnTFl4LUFIcjdwalFOOUF0azZla1c0QzRYd1Q3d0FqQ3JXOW5UcWo1NW41eDROMWZhTTNyS09BRFZTOFJoNFhjVndWOGVLRFNqeklncjM0a3NxX2N5bHl5dTJPOW96aFdoR2lFaGFndllvN0JHNzdfamZadzYyck1YY2dtdFdJRGN2aVJGN25pRlV5Z1lZbG9iWFpvZnI2NERna3pIVy1OND04OEU2N0VEOA=="
            response = request.GetResponse()
        Catch exc As WebException
            response = exc.Response
        End Try

        If response Is Nothing Then
            Throw New HttpException(CInt(HttpStatusCode.NotFound), "The requested url could not be found.")
        End If

        Using reader As New StreamReader(response.GetResponseStream())
            Dim requestedText As String = reader.ReadToEnd()

            'GetIdAndValueFromJson(requestedText)

            Return GetIdAndValueFromJson(requestedText)

        End Using


    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GetDataBrowser() As List(Of result)

        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim url As String = "https://cantas-support.atlassian.net/rest/api/2/field/customfield_10050/context/10153/option				"
        Dim RequestUrl As New Uri(url)

        Dim username As String = "OperationTelmark@telmark.co.id"
        Dim password As String = "ATATT3xFfGF0f-FbZ8H2PHgLYx-AHr7pjQN9Atk6ekW4C4XwT7wAjCrW9nTqj55n5x4N1faM3rKOADVS8Rh4XcVwV8eKDSjzIgr34ksq_cylyyu2O9ozhWhGiEhagvYo7BG77_jfZw62rMXcgmtWIDcviRF7niFUygYYlobXZofr64DgkzHW-N4=88E67ED8"
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password))

        ' Buat objek WebClient
        Dim request As WebRequest = WebRequest.CreateDefault(RequestUrl)
        request.Method = "GET"

        Dim response As WebResponse = Nothing
        Try
            request.Headers(HttpRequestHeader.Authorization) = "Basic T3BlcmF0aW9uVGVsbWFya0B0ZWxtYXJrLmNvLmlkOkFUQVRUM3hGZkdGMGYtRmJaOEgyUEhnTFl4LUFIcjdwalFOOUF0azZla1c0QzRYd1Q3d0FqQ3JXOW5UcWo1NW41eDROMWZhTTNyS09BRFZTOFJoNFhjVndWOGVLRFNqeklncjM0a3NxX2N5bHl5dTJPOW96aFdoR2lFaGFndllvN0JHNzdfamZadzYyck1YY2dtdFdJRGN2aVJGN25pRlV5Z1lZbG9iWFpvZnI2NERna3pIVy1OND04OEU2N0VEOA=="
            response = request.GetResponse()
        Catch exc As WebException
            response = exc.Response
        End Try

        If response Is Nothing Then
            Throw New HttpException(CInt(HttpStatusCode.NotFound), "The requested url could not be found.")
        End If

        Using reader As New StreamReader(response.GetResponseStream())
            Dim requestedText As String = reader.ReadToEnd()

            'GetIdAndValueFromJson(requestedText)

            Return GetIdAndValueFromJson(requestedText)

        End Using


    End Function
    Public Shared Function GetIdAndValueFromJson(jsonString As String) As List(Of result)
        Dim listData As New List(Of result)()

        ' Mengurai string JSON menjadi objek JObject
        Dim jsonObject As JObject = JObject.Parse(jsonString)

        ' Dapatkan array dari properti "values"
        Dim valuesArray As JArray = jsonObject("values")

        ' Iterasi melalui setiap objek dalam array
        For Each valueObj As JObject In valuesArray
            ' Buat objek result baru
            Dim objectData As New result()

            ' Set nilai dari properti "id" dan "value"
            objectData.id = valueObj("id").ToString()
            objectData.value = valueObj("value").ToString()

            ' Tambahkan objek result ke dalam listData
            listData.Add(objectData)
        Next

        ' Kembalikan daftar listData
        Return listData
    End Function

    Public Class result
        Public Property id As String
        Public Property value As String


    End Class
End Class

