﻿Imports System.IO
Imports System.Net
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
    Public Function getWeatherfromAPI() As String Implements IWeather.getWeatherfromAPI
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
        'Dim res As String = result.Weather(0).Description
        'Dim temp As Double = result.Main.Temperature
        'Dim temp2 As String = temp.ToString()
        'Return temp2
        Dim weatherInfo As String =
                                 $"Condition: {result.Weather(0).Description}." & vbCrLf &
                                 $"Temperature: {result.Main.Temperature}°C. " & vbCrLf &
                                 $"Humidity: {result.Main.Humidity}%." & vbCrLf &
                                 $"Wind speed: {result.Wind.Speed} m/s." & vbCrLf &
                                 $"Cloudiness: {result.Clouds.all}%."

        Return weatherInfo
    End Function



    Private Function GetDataFromEleringAPIAboutProduction() As String Implements IWeather.GetDataFromEleringAPIAboutProduction

        Dim url As String = $"https://dashboard.elering.ee/api/nps/total/latest?start=" 'ask for response
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Dim responseStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(responseStream)
        Dim responseString As String = reader.ReadToEnd()

        Dim energyDataResponse As EnergyDataResponse = JsonConvert.DeserializeObject(Of EnergyDataResponse)(responseString)

        Dim energyInfo As String =
                                $"Output Total: {energyDataResponse.data(0).output_total}." & vbCrLf &
                                 $"Renewable Total: {energyDataResponse.data(0).renewable_total}." & vbCrLf &
                                $"Timestamp: {energyDataResponse.data(0).timestamp}."

        Return energyInfo

    End Function


    Public Class EnergyData
        'Public Property consumption_local_total As Double
        ' Public Property export_total As Double
        'Public Property import_total As Double
        'Public Property input_local As Double
        'Public Property input_total As Double
        'Public Property nonrenewable_total As Double
        <JsonProperty("output_total")>
        Public Property output_total As Double
        'Public Property renewable_bio As Double
        'Public Property renewable_hydro As Double
        'Public Property renewable_solar As Double
        <JsonProperty("renevable_total")>
        Public Property renewable_total As Double
        'Public Property renewable_wind As Double
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


