Public Class userInterface

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Object that uses the API interface
        Dim objekt As PrjAPIComponent.APIInterface

        'Temporary object to use API component
        objekt = New PrjAPIComponent.APIComponent

        'Prints data from API component to text box
        TextBox1.Text = objekt.GetDataFromEleringAPI
    End Sub
End Class
