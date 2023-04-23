﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CDatabaseTest

    <TestMethod()> Public Sub TestAPIReturn()
        Dim getIn As New PrjAPIComponent.APIComponent
        Dim actualData As (String(), String()) = getIn.GetDataFromEleringAPI()
        'If vastus IsNot Nothing Then
        ' Assert.AreEqual(expected.Length, vastus.Length)
        ' Assert.AreEqual("6.00", actualData.Item1(1))
        Assert.AreEqual("6.00", actualData.Item2(24))
        ' End If

    End Sub

    <TestMethod()> Public Sub TestConnection()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim vastus As String = getIn.Connect()
        Assert.IsTrue(vastus)
    End Sub

    ''<TestMethod()> Public Sub TestDateReturnFromAPIToDatabase()
    ''    Dim getIn As New PrjDatabaseComponent.CDatabase
    ''    Dim actualOutput = getIn.insertDatesToDatabase
    ''    Assert.AreEqual("1123123123", actualOutput(1))
    ''End Sub

    ''<TestMethod()> Public Sub TestDateReturnFromDatabase()
    ''    Dim getIn As New PrjDatabaseComponent.CDatabase
    ''    Dim actualOutput = getIn.datesOfStockPrice
    ''    Assert.AreEqual("1123123123", actualOutput(1))
    ''End Sub


    <TestMethod()> Public Sub TestpackageReturn()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        '  Dim actualData As (String(), String()) = getIn.electricityPackages
        '  Assert.AreEqual("Kindel 6", actualData.Item1(0))
        ' Assert.AreEqual("Eesti Energia", actualData.Item2(0))
        Dim count As Integer = getIn.electricityPackagesCount
        Assert.AreEqual(5, count)
    End Sub

    <TestMethod()> Public Sub TestUniversalServicePrice()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim count As Double = getIn.universalServicePrice
        Assert.AreEqual(5, count)
    End Sub

    <TestMethod()> Public Sub TestGetAPIInfoGivingDatesDirectly()
        Dim getIn As New PrjAPIComponent.APIComponent
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        ' Dim futureDate As DateTime = DateTime.ParseExact(currentDate, "yyyy-MM-dd HH:mm:ss", Nothing)
        'Assert.AreEqual(currentDate, modifiedDateString)
        Dim futureDate As DateTime = DateTime.Now.AddHours(24)
        Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim count123 = getIn.GetDataFromEleringAPIWithDates(currentDate, futureDateString)
        Assert.AreEqual("19", count123.Item1(1))
    End Sub
    <TestMethod()> Public Sub TestInsertAPIFutureToDatabase()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        ' Dim futureDate As DateTime = DateTime.ParseExact(currentDate, "yyyy-MM-dd HH:mm:ss", Nothing)
        'Assert.AreEqual(currentDate, modifiedDateString)
        Dim futureDate As DateTime = DateTime.Now.AddHours(24)
        Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim count123 = getIn.insertStockPriceToDatabaseFuture(currentDate, futureDateString)
        Assert.AreEqual("19", count123(1))
    End Sub

    <TestMethod()> Public Sub TestInsertAPIFutureToDatabaseDates()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        ' Dim futureDate As DateTime = DateTime.ParseExact(currentDate, "yyyy-MM-dd HH:mm:ss", Nothing)
        'Assert.AreEqual(currentDate, modifiedDateString)
        Dim futureDate As DateTime = DateTime.Now.AddHours(24)
        Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim count123 = getIn.insertDatesToDatabaseFuture(currentDate, futureDateString)
        Assert.AreEqual("19", count123(1))
    End Sub

    <TestMethod()> Public Sub getDateandPriceFuture()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        ' Dim futureDate As DateTime = DateTime.ParseExact(currentDate, "yyyy-MM-dd HH:mm:ss", Nothing)
        'Assert.AreEqual(currentDate, modifiedDateString)
        Dim futureDate As DateTime = DateTime.Now.AddHours(24)
        Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim count123 = getIn.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString)
        Assert.AreEqual("19", count123.Item1(1))
    End Sub
    '<TestMethod()> Public Sub TestStringReturn()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim id As String
    '    id = "1"
    '    Dim actualOutput = getIn.stringReturn(id)
    '    Assert.AreEqual("1000", actualOutput.consumptionPerHour)
    '    Assert.AreEqual("5", actualOutput.usageTime)
    'End Sub

    '<TestMethod()> Public Sub TestAPI()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim expected() As String = {"bar1", "bar2", "bar3"}
    '    Dim vastus() As String
    '    vastus = getIn.stockPrice
    '    'If vastus IsNot Nothing Then
    '    ' Assert.AreEqual(expected.Length, vastus.Length)
    '    Assert.AreEqual("6.00", vastus(4))
    '    ' End If

    'End Sub

    '<TestMethod()> Public Sub TestSignup()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim check As Boolean
    '    check = getIn.signup("karl", "karl", "Karl", "wafawfaw@gmail.com")
    '    Assert.IsTrue(check)
    'End Sub
    '<TestMethod()> Public Sub TestLogin()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim vastus As String = getIn.login("laura", "laura")
    '    Assert.IsTrue(vastus)
    'End Sub

    '<TestMethod()> Public Sub TestHash()
    '    Dim getIn As New PrjDatabaseComponent.CDatabase
    '    Dim password As String
    '    password = "laura"
    '    Dim vastus As String = getIn.hashPassword(password)
    '    Assert.AreEqual("XXAusHko7XuEYmt3fIbDm/TLQD1AJPAx1fl6SwZkQh8=", vastus)
    'End Sub

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