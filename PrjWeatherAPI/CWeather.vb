Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json 'use it to parse Json added from under manage NuGet packages

Public Class CWeather
    Implements IWeather
    '"id" 588409,
    '   "name": "Tallinn",I
    '   "state": "",
    '   "country": "EE",
    '   "coord": {
    '       "lon": 24.753531,
    '       "lat": 59.436958
    '   }
    'openweathermap.org/current#one
    Public Function getWeatherfromAPI() As (Double, Integer, Double, Double) Implements IWeather.getWeatherfromAPI
        Dim apiKey As String = "7406f4e5f40f2d23b1c9575266065495" 'my personal key from registration
        Dim idOfTallinn As String = "588409"

        Dim url As String = $"https://api.openweathermap.org/data/2.5/weather?id={idOfTallinn}&appid={apiKey}&units=metric" 'ask for response
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Dim responseStream As Stream = response.GetResponseStream() 'response stream
        Dim reader As New StreamReader(responseStream)
        Dim responseString As String = reader.ReadToEnd() 'read stream to string

        Dim result As WeatherResult = JsonConvert.DeserializeObject(Of WeatherResult)(responseString) 'because the data is in json use jsonconverter to
        'read to class WeatherResult

        Return (result.Main.Temperature, result.Main.Humidity, result.Wind.Speed, result.Clouds.all)
    End Function



    Private Function GetDataFromEleringAPIAboutProduction() As (Double, Double, Long) Implements IWeather.GetDataFromEleringAPIAboutProduction

        Dim url As String = $"https://dashboard.elering.ee/api/balance/total/latest" 'ask for response
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Dim responseStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(responseStream)
        Dim responseString As String = reader.ReadToEnd()

        Dim energyDataResponse As EnergyDataResponse = JsonConvert.DeserializeObject(Of EnergyDataResponse)(responseString)

        Return (energyDataResponse.data(0).output_total, energyDataResponse.data(0).renewable_total, energyDataResponse.data(0).timestamp)

    End Function


    Public Class EnergyData

        <JsonProperty("output_total")>
        Public Property output_total As Double
        <JsonProperty("renewable_total")>
        Public Property renewable_total As Double
        <JsonProperty("timestamp")>
        Public Property timestamp As Long
    End Class

    Public Class EnergyDataResponse
        <JsonProperty("data")>
        Public Property data As List(Of EnergyData)
        <JsonProperty("success")>
        Public Property success As Boolean
    End Class


    'these classes are like this because this is how api gives them out
    Public Class WeatherResult
        <JsonProperty("weather")>
        Public Property Weather As Weather()

        <JsonProperty("main")>
        Public Property Main As Main

        <JsonProperty("wind")>
        Public Property Wind As Wind
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


