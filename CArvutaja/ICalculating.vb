' FAILINIMI: ICalculating.vb
' AUTOR: Karro Endel Kütt
' LOODUD: 
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: 
' Eeldused: 
' Sisendid: 
' Komponendid:
' Tulem: 
Public Interface ICalculating
    Function applianceConsumption(ByVal kodumasina_tarbmimine As String, ByVal kasutusaeg As String, ByVal tunnihind As Double) As (consumption As String, aproxPrice As String, yearlyAproxPrice As String)

End Interface
