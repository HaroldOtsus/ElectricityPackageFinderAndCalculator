' FAILINIMI: IWeather.vb
' AUTOR: Laura Kõrgmaa
' LOODUD: 20.04.2023
' MUUDETUD: 06.05.2023
' KIRJELDUS: Saab andmeid Eleringi või OpenWeatherMap APIlt
' Eeldused: Tingimused, mis peavad edukaks käivituseks täidetud olema, peab olema ühendus internettiga. 
' Tulem: TAgastab kätte saadud info APIlt, kui infot ei saa tagastab -1 või false


Public Interface IWeather
    Function getWeatherfromAPI() As (Double, Integer, Double, Double)

    Function GetDataFromEleringAPIAboutProduction() As (Boolean, Double, Double, String)
End Interface
