' FAILINIMI: ILogin.vb
' AUTOR: Laura Kõrgmaa
' LOODUD: 15.04.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Interface CDatabase komponendi jaoks
' Eeldused:on olemas Database component, mis realiseerib Interface'i
' Tulem: Info andmebaasist. Kui andmeid ei saadud kätte või info on vale tagastatakse false või nothing

Public Interface ILogin
    Function login(ByVal username As String, ByVal password As String) As Boolean
    Function userPrefernces(ByVal username, ByRef size, ByRef color)
    Function updateUserPrefernces(ByVal username, ByVal update)

End Interface
