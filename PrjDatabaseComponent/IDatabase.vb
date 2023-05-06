' FAILINIMI: IDatabase.vb
' AUTOR: Laura Kõrgmaa
' LOODUD: 22.03.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Interface CDatabase komponendi jaoks
' Eeldused:on olemas Database component, mis realiseerib Interface'i
' Sisendid: Sisendparameetrite eesmärk..
' Tulem: Info andmebaasist või info APIlt. Kui andmeid ei saadud kätte tagastatakse -1 või Nothing või 0.

Public Interface IDatabase
    Function stringReturn(ByVal id As String) As (consumptionPerHour As String, usageTime As String)
    Function electricityPackagesInfo() As (String(), String(), Double(), Double(), Boolean(), Boolean(), Boolean(), Double())
    Function electricityPackagesCount() As Integer
    Function getStockPriceAndDatesFromDatabaseFuture(ByVal strStartDate As String, ByVal strEndDate As String) As (String(), String())
    Function onePackageInfo(ByVal packageName As String) As (String, String, Double, Double, Boolean, Boolean, Boolean, Double)
    Function weatherFromDatabase() As (Double, Integer, Double, Double)
    Function productionFromDatabase() As (Double, Double, Integer, Date)

End Interface
