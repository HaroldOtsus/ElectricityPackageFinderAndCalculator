Public Class SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        GUIMain.Visible = False
        Dim returnString As PrjDatabaseComponent.ISignup
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sumtin As Boolean
        sumtin = returnString.signup(tBoxUsername.Text, tBoxPassword.Text, tBoxName.Text, tBoxEmail.Text)


        GUIMain.Show()
        GUIMain.chartFrontPage()
        Me.Visible = False


    End Sub
End Class