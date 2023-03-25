Public Class userInterface

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objekt As PrjAPIComponent.APIInterface

        objekt = New PrjAPIComponent.APIComponent

        TextBox1.Text = objekt.GetDataFromEleringAPI
    End Sub
End Class
