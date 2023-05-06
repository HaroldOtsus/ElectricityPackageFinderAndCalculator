' FAILINIMI: ISignup.vb
' AUTOR: Laura Kõrgmaa
' LOODUD: 15.04.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Interface CDatabase komponendi jaoks
' Eeldused:on olemas Database component, mis realiseerib Interface'i
' Tulem: Info andmebaasist. Kui andmeid ei saadud kätte või info on vale tagastatakse false või nothing

Public Interface ISignup
    Function signup(ByVal username As String, ByVal password As String, ByVal name As String, ByVal email As String) As Boolean

End Interface
