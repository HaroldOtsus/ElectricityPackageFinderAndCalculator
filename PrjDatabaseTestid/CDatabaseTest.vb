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
    <TestMethod()> Public Sub TestDatabaseAPI()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim first As String = ""
        getIn.stockPrice(first)
        Assert.AreEqual("6,28", first)
    End Sub


End Class