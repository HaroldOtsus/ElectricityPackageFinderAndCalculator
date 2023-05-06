' FAILINIMI: ICalculating.vb
' AUTOR: Karro Endel Kütt
' LOODUD: 25.03.2023
' MUUDETUD: 06.05.2023
' KIRJELDUS: Arvutab paketijärgse tunni ja aasta hinna
' Eeldused: Kasutaja sisestab korrektselt kodumasina tarbimise, kasutusaja ja tunnihinna.
' Sisendid: kodumasina tarbimine, kasutusaeg ja tunnihind
' Tulem: Tarbimine(kWh), tunnihind ja aastahind
Public Interface ICalculating
    Function applianceConsumption(ByVal kodumasina_tarbmimine As String, ByVal kasutusaeg As String, ByVal tunnihind As Double) As (consumption As String, aproxPrice As String, yearlyAproxPrice As String)

End Interface
