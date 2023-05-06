' FAILINIMI: CCalculating.vb
' AUTOR: Karro Endel Kütt
' LOODUD: 25.03.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Arvutab paketijärgse tunni ja aasta hinna
' Eeldused: Kasutaja sisestab korrektselt kodumasina tarbimise, kasutusaja ja tunnihinna.
' Sisendid: kodumasina tarbimine, kasutusaeg ja tunnihind
' Tulem: Tarbimine(kWh), tunnihind ja aastahind
Public Class CCalculating
    Implements ICalculating

    'Dim tunnihind As Double
    'Dim kodumasina_tarbmimine As Double 'consumption per hour
    'Dim universaalhind As Double
    'Dim kasutusaeg As Integer ' usage time


    'See class/komponent idk, arvutab paketijargse tuniihinna
    'kasutus aeg tuleb jagada 60, et minutid tundideks muuta
    'eeldan et andmebaasis on tarbimine lic Wattides
    'et saada MWh -> kWh, tuleb tarbiminie korrutada kasutusajaga, tulemus jagada 1000'ga

    Public Function applianceConsumption(kodumasina_tarbmimine As String, kasutusaeg As String, tunnihind As Double) As (consumption As String, aproxPrice As String, yearlyAproxPrice As String) Implements ICalculating.applianceConsumption

        If String.IsNullOrEmpty(kodumasina_tarbmimine) Or String.IsNullOrEmpty(kasutusaeg) Or String.IsNullOrEmpty(tunnihind) Then
            Return ("Nan", "Nan", "Nan")
        Else
            kasutusaeg = kasutusaeg / 60
            Dim consumption = (kodumasina_tarbmimine * kasutusaeg) / 1000
            Dim aproxPrice = ((kodumasina_tarbmimine * kasutusaeg) / 1000) * tunnihind
            'aproxPrice = (aproxPrice / 10) / 100 ''MWH to kwh '' ajutine fix, et saada sama mis kalkulaatoris
            Dim yearlyAproxPrice = aproxPrice * 365.242199 ' aastase hinna arvutamine
            'If yearlyAproxPrice > 100 Then
            '    yearlyAproxPrice = yearlyAproxPrice / 100 ' kuna tulemus on sentides, siis kui sente on liiga palju, jagan 100'ga, et eurod saada
            'End If

            Return (consumption, aproxPrice, yearlyAproxPrice)
        End If

    End Function
End Class
