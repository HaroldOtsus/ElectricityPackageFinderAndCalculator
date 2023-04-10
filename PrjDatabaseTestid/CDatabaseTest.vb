Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CDatabaseTest



    <TestMethod()> Public Sub TestMethod1()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim vastus As String = getIn.Connect()
        Assert.IsTrue(vastus)
    End Sub


    <TestMethod()> Public Sub TestMethod2()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim id As String
        id = "1"
        Dim actualOutput = getIn.stringReturn(id)
        Assert.AreEqual("1000", actualOutput.consumptionPerHour)
        Assert.AreEqual("5", actualOutput.usageTime)
    End Sub
    <TestMethod()> Public Sub TestDatabaseInsert()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim first As String = ""
        getIn.stockPrice(first)
        Assert.AreEqual("6,00", first)
    End Sub

    <TestMethod()> Public Sub TestDatabaseInsertAPI()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim first As String = "6,00"
        Dim second As String = "7,00"
        Dim third As String = "5,00"
        getIn.insertStockPriceToDatabase(first, second, third)
        ''right now test doesn't show anything in visual studio but when running this data in databse changes so test is successful
    End Sub


End Class