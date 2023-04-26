Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class CWeather

    '"id" 588409,
    '   "name": "Tallinn",
    '   "state": "",
    '   "country": "EE",
    '   "coord": {
    '       "lon": 24.753531,
    '       "lat": 59.436958
    '   }
    'openweathermap.org/current#one
    Public Function getWeatherfromAPI() As string
        Dim apiKey As String = "7406f4e5f40f2d23b1c9575266065495"
        Dim location As String = "Tallinn,EE" ' location
        Dim idOfTallinn As String = "588409"

        Dim url As String = $"https://api.openweathermap.org/data/2.5/weather?id={idOfTallinn}&appid={apiKey}&units=metric" 'ask for response
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Dim responseStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(responseStream)
        Dim responseString As String = reader.ReadToEnd()

        Dim result As WeatherResult = JsonConvert.DeserializeObject(Of WeatherResult)(responseString) 'because the data is in json use jsonconverter
        Dim res As String = result.Weather(0).Description
        Dim temp As Double = result.Main.Temperature
        Dim temp2 As String = temp.ToString()
        Return temp2
    End Function

    'these classes are like this because this is how api gives them out
    Public Class WeatherResult
        <JsonProperty("weather")>
        Public Property Weather As Weather()

        <JsonProperty("main")>
        Public Property Main As Main

        <JsonProperty("wind")>
        Public Property Wind As Wind()
        <JsonProperty("clouds")>
        Public Property Clouds As Clouds
    End Class
    Public Class Weather
        <JsonProperty("main")>
        Public Property main As String 'word for example rain
        <JsonProperty("description")>
        Public Property Description As String 'word for example moderate rain
    End Class

    Public Class Main
        <JsonProperty("temp")>
        Public Property Temperature As Double 'double like 298.48
        <JsonProperty("humidity")>
        Public Property Humidity As Integer 'integer like 64
    End Class

    Public Class Wind
        <JsonProperty("speed")>
        Public Property Speed As Double 'double for example 0.62
    End Class

    Public Class Clouds
        <JsonProperty("all")>
        Public Property all As Double 'double for example 0.62
    End Class
End Class


