Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CDatabaseTest

    <TestMethod()> Public Sub TestMethod1()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim vastus = getIn.Connect()
        Assert.IsTrue(vastus)
    End Sub

End Class