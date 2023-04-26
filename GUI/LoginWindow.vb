Public Class LoginWindow
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        GUIMain.Visible = False
        Dim returnString As PrjDatabaseComponent.ILogin
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sumtin As Boolean
        sumtin = returnString.login(tBoxUsername.Text, tBoxPassword.Text)

        If sumtin = True Then


            Dim username As String = tBoxUsername.Text
            GUIMain.Show()
            GUIMain.userPrefernces(username)
            Me.Visible = False
            GUIMain.chartFrontPage()
        Else
            MsgBox("fail")
        End If

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUp.Show()
    End Sub


End Class