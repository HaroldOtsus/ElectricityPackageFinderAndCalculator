Public Interface IWeather
    Function getWeatherfromAPI() As (Double, Integer, Double, Double)

    Function GetDataFromEleringAPIAboutProduction() As (Boolean, Double, Double, Long)
End Interface
