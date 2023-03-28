﻿Imports System.IO
Imports System.Net

Public Class APIComponent
    Implements APIInterface
    Public Function GetDataFromEleringAPI() As String() Implements APIInterface.GetDataFromEleringAPI
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

        'HttpWebRequest object sends a request to url specified
        Dim webRequest As HttpWebRequest = CType(webRequest.Create("https://dashboard.elering.ee/api/nps/price?start=2023-03-25T20%3A59%3A59.999Z&end=2023-03-26T20%3A59%3A59.999Z
"), HttpWebRequest)

#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

        'GET method means that we are retrieveing datar from web server
        webRequest.Method = "GET"
        'Data received is in JSON format
        webRequest.ContentType = "application/json"

        'webRequest.GetResponse() recieves a response from web server and CType changes it to HttpWebResponse object
        'This allows us to access properties and methods to get information about the response from the server
        Dim webResponse As HttpWebResponse = CType(webRequest.GetResponse(), HttpWebResponse)
        'responseStream contains the data stream sent by the server
        Dim responseStream As System.IO.Stream = webResponse.GetResponseStream()
        'Allows us to read the data sent by the server as a string of characters
        Dim stringStreamReader As System.IO.StreamReader = New StreamReader(responseStream)
        'Reads all the characters from stringStreamReader and stores them in a string and
        'the variable responseString contains that string
        Dim responseString As String = stringStreamReader.ReadToEnd.ToString
        'Frees the resources used by HttpWebRequest object
        webResponse.Close()
        'Splits the web response string into multiple strings separated by commas
        Dim result() As String = responseString.Split(","c)
        Dim endResult(0) As String

        For Each str As String In result
            If str.Contains("price") Then
                ReDim Preserve endResult(endResult.Length)
                endResult(endResult.Length - 1) = str
            End If
        Next

        Return endResult
    End Function

End Class
