Public Class CCalculating
    Implements ICalculating

    'Dim tunnihind As Double
    'Dim kodumasina_tarbmimine As Double 'consumption per hour
    'Dim universaalhind As Double
    'Dim kasutusaeg As Integer ' usage time


    'See class/komponent idk, arvutab paketijargse tuniihinna
    'kasutus aeg tuleb jagada 60, et minutid tundideks muuta
    'eeldan et andmebaasis on tarbimine lic Wattides
    'et saada kWh, tuleb tarbiminie korrutada kasutusajaga, tulemus jagada 1000'ga

    Public Function applianceConsumption(kodumasina_tarbmimine As String, kasutusaeg As String, tunnihind As String) As (consumption As String, aproxPrice As String) Implements ICalculating.applianceConsumption
        kasutusaeg = kasutusaeg / 60
        Dim consumption = (kodumasina_tarbmimine * kasutusaeg) / 1000
        Dim aproxPrice = ((kodumasina_tarbmimine * kasutusaeg) / 1000) * tunnihind
        If kodumasina_tarbmimine = " " Or kasutusaeg = " " Or tunnihind = " " Then
            Return ("Nan", "Nan")
        Else
            Return (consumption, aproxPrice)
        End If
    End Function



End Class
