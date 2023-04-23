Public Interface ILogin
    Function login(ByVal username As String, ByVal password As String) As Boolean
    Function userPrefernces(ByVal username, ByRef size, ByRef color)
    Function updateUserPrefernces(ByVal username, ByVal update)

End Interface
