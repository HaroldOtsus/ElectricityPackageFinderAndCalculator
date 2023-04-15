Imports System.IO
Imports System.Net

Public Class APIComponent
    Implements APIInterface
    Public Function GetDataFromEleringAPI() As (String(), String()) Implements APIInterface.GetDataFromEleringAPI

        'DateTime variables to get the 24 hour NordPool prices
        Dim endTime As DateTime = DateTime.Now
        Dim startTime As DateTime = endTime.AddDays(-1)
        Dim strStartTime As String = startTime.ToString("yyyy-MM-dd HH:mm:ss")
        Dim strEndTime As String = endTime.ToString("yyyy-MM-dd HH:mm:ss")

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance 

        'HttpWebRequest object sends a request to url specified
        Dim webRequest As HttpWebRequest = CType(webRequest.Create("https://dashboard.elering.ee/api/nps/price?start=" + strStartTime + "&end=" + strEndTime), HttpWebRequest)

#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance 

        'GET method means that we are retrieveing data from web server
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
        Dim endResultPrice(0) As String
        Dim endResultTimestamp(0) As String

        'Filters only strings that have the "price" and "timestamp" string and only Estonian prices
        For Each str As String In result
            'If there is "fi" in the string then that means that we have reached the end of Estonian prices
            If str.Contains("fi") Then
                Exit For
            ElseIf str.Contains("price") Then
                'Makes the array larger by 1 element
                ReDim Preserve endResultPrice(endResultPrice.Length)
                'Removes first 8 characters in string
                str = str.Substring(8)
                'Removes ] and } characters from the string
                str = str.Replace("]", "")
                str = str.Replace("}", "")
                'Checks that the string wouldn't be null or empty
                If Not String.IsNullOrEmpty(str) Then
                    'Adds string to the prices array
                    endResultPrice(endResultPrice.Length - 1) = str
                End If
            ElseIf str.Contains("timestamp") Then
                ReDim Preserve endResultTimestamp(endResultTimestamp.Length)
                str = str.Substring(13)
                If Not String.IsNullOrEmpty(str) Then
                    endResultTimestamp(endResultTimestamp.Length - 1) = str
                End If
            End If
        Next

        'Remove not needed characters from the string
        'For some reason the first element in the timestamp array still has "timestamp" in it after 
        'the for loop, so this line is needed to filter unnecessary characters from the first element
        endResultTimestamp(1) = endResultTimestamp(1).Substring(14)

        'Cycle that converts UNIX timestamp into a datetime string
        For Each str As String In endResultTimestamp
            'Checks if string is null or empty
            If Not String.IsNullOrEmpty(str) Then
                'Convert string into double
                Dim dstr As Double = Double.Parse(str)
                'Create a new DateTime object from the converted double
                Dim dateTimestr As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(dstr).ToLocalTime()
                'Convert the DateTime object into a string
                str = dateTimestr.ToString("yyyy-MM-dd HH:mm:ss")
            End If
        Next

        'endResultPrice = Item1
        'endResultTimestamp = Item2
        Return (endResultPrice, endResultTimestamp)
    End Function

    Public Function GetDataFromEleringAPIWithDates(ByVal strStartDate As String, ByVal strEndDate As String) As (String(), String()) _
        Implements APIInterface.GetDataFromEleringAPIWithDates

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

        'HttpWebRequest object sends a request to url specified
        Dim webRequest As HttpWebRequest = CType(webRequest.Create("https://dashboard.elering.ee/api/nps/price?start=" + strStartDate _
        + "&end=" + strEndDate), HttpWebRequest)

#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

        'GET method means that we are retrieveing data from web server
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
        Dim endResultPrice(0) As String
        Dim endResultTimestamp(0) As String

        'Filters only strings that have the "price" and "timestamp" string and only Estonian prices
        For Each str As String In result
            'If there is "fi" in the string then that means that we have reached the end of Estonian prices
            If str.Contains("fi") Then
                Exit For
            ElseIf str.Contains("price") Then
                'Makes the array larger by 1 element
                ReDim Preserve endResultPrice(endResultPrice.Length)
                'Removes first 8 characters in string
                str = str.Substring(8)
                'Removes ] and } characters from the string
                str = str.Replace("]", "")
                str = str.Replace("}", "")
                'Checks that the string wouldn't be null or empty
                If Not String.IsNullOrEmpty(str) Then
                    'Adds string to the prices array
                    endResultPrice(endResultPrice.Length - 1) = str
                End If
            ElseIf str.Contains("timestamp") Then
                ReDim Preserve endResultTimestamp(endResultTimestamp.Length)
                str = str.Substring(13)
                If Not String.IsNullOrEmpty(str) Then
                    endResultTimestamp(endResultTimestamp.Length - 1) = str
                End If
            End If
        Next

        'Remove not needed characters from the string
        'For some reason the first element in the timestamp array still has "timestamp" in it after 
        'the for loop, so this line is needed to filter unnecessary characters from the first element
        endResultTimestamp(1) = endResultTimestamp(1).Substring(14)

        'Cycle that converts UNIX timestamp into a datetime string
        For Each str As String In endResultTimestamp
            'Checks if string is null or empty
            If Not String.IsNullOrEmpty(str) Then
                'Convert string into double
                Dim dstr As Double = Double.Parse(str)
                'Create a new DateTime object from the converted double
                Dim dateTimestr As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(dstr).ToLocalTime()
                'Convert the DateTime object into a string
                str = dateTimestr.ToString("yyyy-MM-dd HH:mm:ss")
            End If
        Next

        'endResultPrice = Item1
        'endResultTimestamp = Item2
        Return (endResultPrice, endResultTimestamp)
    End Function
End Class
