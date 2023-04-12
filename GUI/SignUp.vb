Public Class SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        GUIMain.Visible = False
        Dim returnString As PrjDatabaseComponent.ISignup
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sumtin As Boolean
        sumtin = returnString.signup(tBoxUsername.Text, tBoxPassword.Text, tBoxName.Text, tBoxEmail.Text)

        If sumtin = True Then

            TextBox1.Text = "beans"
            GUIMain.Show()
            Me.Visible = False
        Else
            TextBox1.Text = "no beans"
        End If
    End Sub
End Class