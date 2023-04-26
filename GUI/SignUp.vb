Public Class SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        GUIMain.Visible = False
        Dim returnString As PrjDatabaseComponent.ISignup
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sumtin As Boolean
        sumtin = returnString.signup(tBoxUsername.Text, tBoxPassword.Text, tBoxName.Text, tBoxEmail.Text)
        If sumtin = True Then
            GUIMain.Show()
            GUIMain.chartFrontPage()
            Me.Visible = False
        Else
            MsgBox("signupfailed")
        End If

    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class