Public Interface IDatabase
    Function stringReturn(ByVal id As String) As (consumptionPerHour As String, usageTime As String)

    Function electricityPackagesInfo() As (String(), String(), Double(), Double(), Boolean(), Boolean())
    Function universalServicePrice() As Double
    Function electricityPackagesCount() As Integer
End Interface
