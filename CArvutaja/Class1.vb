Public Class Class1
    Dim tunnihind As Double
    Dim kodumasina_tarbmimine As Double
    Dim universaalhind As Double
    Dim kasutusaeg As Integer

    'See class/komponent idk, arvutab paketijargse tuniihinna
    'kasutus aeg tuleb jagada 60, et minutid tundideks muuta
    'eeldan et andmebaasis on tarbimine lic Wattides
    'et saada kWh, tuleb tarbiminie korrutada kasutusajaga, tulemus jagada 1000'ga

    Public Function kodumasinaKulu()
        kasutusaeg = kasutusaeg / 60
        Return ((kodumasina_tarbmimine * kasutusaeg) / 1000) * tunnihind
    End Function

End Class
