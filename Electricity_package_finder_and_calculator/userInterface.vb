Public Class userInterface

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Object that uses the API interface
        Dim objekt As PrjAPIComponent.APIInterface

        'Temporary object to use API component
        objekt = New PrjAPIComponent.APIComponent

        'Prints data from API component to text box
        Dim result() As String = objekt.GetDataFromEleringAPI

        'Filters to display only the price of string
        For Each str As String In result
            If Not String.IsNullOrEmpty(str) Then
                TextBox1.AppendText(str.Substring(8, 7) & vbNewLine)
            End If
        Next
    End Sub
End Class
