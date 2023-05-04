﻿Public Interface IDatabase
    Function stringReturn(ByVal id As String) As (consumptionPerHour As String, usageTime As String)
    Function electricityPackagesInfo() As (String(), String(), Double(), Double(), Boolean(), Boolean(), Boolean(), Double())
    Function electricityPackagesCount() As Integer
    Function getStockPriceAndDatesFromDatabaseFuture(ByVal strStartDate As String, ByVal strEndDate As String) As (String(), String())
    Function onePackageInfo(ByVal packageName As String) As (String, String, Double, Double, Boolean, Boolean, Boolean, Double)
    Function weatherFromDatabase() As (Double, Integer, Double, Double)
    Function productionFromDatabase() As (Double, Double, Integer, Date)

End Interface
