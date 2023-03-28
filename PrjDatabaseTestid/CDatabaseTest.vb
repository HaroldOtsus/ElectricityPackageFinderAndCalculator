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
        Dim vastus As String = getIn.stringReturn
        Assert.AreEqual("Kohvimasin", vastus)
    End Sub

End Class