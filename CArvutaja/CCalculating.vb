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
        'checks whether either of input string is empty
        If String.IsNullOrEmpty(kodumasina_tarbmimine) Or String.IsNullOrEmpty(kasutusaeg) Or String.IsNullOrEmpty(tunnihind) Then
            Return ("Nan", "Nan")
        Else
            kasutusaeg = kasutusaeg / 60
            Dim consumption = (kodumasina_tarbmimine * kasutusaeg) / 1000
            Dim aproxPrice = ((kodumasina_tarbmimine * kasutusaeg) / 1000) * tunnihind
            Return (consumption, aproxPrice)
        End If
    End Function

    Public Function add20Percent(ByRef kuuTasu As String) As Object Implements ICalculating.add20Percent

        kuuTasu = kuuTasu * 1.2 / 730.484398

    End Function
End Class
