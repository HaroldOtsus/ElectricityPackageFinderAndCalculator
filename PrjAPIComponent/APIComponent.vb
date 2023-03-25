Imports System.IO
Imports System.Net

Public Class APIComponent
    Implements APIInterface
    Public Function GetDataFromEleringAPI() As String Implements APIInterface.GetDataFromEleringAPI
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Dim webRequest As HttpWebRequest = CType(webRequest.Create("https://dashboard.elering.ee/umm/gas/rss"), HttpWebRequest)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        webRequest.Method = "GET"
        webRequest.ContentType = "application/json"
        ' Add any necessary headers here
        Dim webResponse As HttpWebResponse = CType(webRequest.GetResponse(), HttpWebResponse)
        Dim responseStream As System.IO.Stream = webResponse.GetResponseStream()
        Dim stringStreamReader As System.IO.StreamReader = New StreamReader(responseStream)
        Dim responseString As String = stringStreamReader.ReadToEnd.ToString
        webResponse.Close()
        Return responseString
    End Function

End Class
