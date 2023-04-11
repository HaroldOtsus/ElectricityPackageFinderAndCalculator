Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CDatabaseTest



    <TestMethod()> Public Sub TestConnection()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim vastus As String = getIn.Connect()
        Assert.IsTrue(vastus)
    End Sub


    <TestMethod()> Public Sub TestStringReturn()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim id As String
        id = "1"
        Dim actualOutput = getIn.stringReturn(id)
        Assert.AreEqual("1000", actualOutput.consumptionPerHour)
        Assert.AreEqual("5", actualOutput.usageTime)
    End Sub

    <TestMethod()> Public Sub TestAPI()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim expected() As String = {"bar1", "bar2", "bar3"}
        Dim vastus() As String
        vastus = getIn.stockPrice
        'If vastus IsNot Nothing Then
        ' Assert.AreEqual(expected.Length, vastus.Length)
        Assert.AreEqual("6.00", vastus(4))
        ' End If

    End Sub

    <TestMethod()> Public Sub TestSignup()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim check As Boolean
        check = getIn.signup("karl", "karl", "Karl", "wafawfaw@gmail.com")
        Assert.IsTrue(check)
    End Sub
    <TestMethod()> Public Sub TestLogin()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim vastus As String = getIn.login("laura", "laura")
        Assert.IsTrue(vastus)
    End Sub

    <TestMethod()> Public Sub TestHash()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim password As String
        password = "laura"
        Dim vastus As String = getIn.hashPassword(password)
        Assert.AreEqual("XXAusHko7XuEYmt3fIbDm/TLQD1AJPAx1fl6SwZkQh8=", vastus)
    End Sub

    '<TestMethod()> Public Sub TestCheckIfUsernameExists()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim uname As String
    '    uname = "maasikas"
    '    Dim vastus As String = getIn.checkIfUsernameExists(uname)
    '    Assert.IsFalse(vastus)
    'End Sub

    '<TestMethod()> Public Sub TestDatabaseInsertAPI()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim first As String = "6,00"
    '    Dim second As String = "7,00"
    '    Dim third As String
    '    third = getIn.insertStockPriceToDatabase()
    '    Assert.AreEqual("cool", third)
    '    ''right now test doesn't show anything in visual studio but when running this data in databse changes so test is successful
    'End Sub


End Class