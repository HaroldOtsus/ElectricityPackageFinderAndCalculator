Imports MySql.Data.MySqlClient
Public Class CDatabase
    Function connect() As Boolean
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
