Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting


<TestClass()> Public Class CDatabaseTest

    <TestMethod()> Public Sub TestMethod1()
        Dim getIn As New PrjDatabaseComponent.CDatabase
        Dim vastus As String = getIn.Connect()
        Assert.AreEqual("Kohvimasin", vastus)
    End Sub

End Class