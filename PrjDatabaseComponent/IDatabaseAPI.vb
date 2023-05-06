' FAILINIMI: IDatabaseAPI.vb
' AUTOR: Laura Kõrgmaa
' LOODUD: 26.03.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Interface CDatabase komponendi jaoks
' Eeldused:on olemas Database component, mis realiseerib Interface'i
' Tulem: Info andmebaasist või info APIlt. Kui andmeid ei saadud kätte tagastatakse -1 või Nothing või 0.

Public Interface IDatabaseAPI
    Function stockPrice() As (prices As String(), dates As String())
End Interface
