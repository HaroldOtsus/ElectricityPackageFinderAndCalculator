Imports MySql.Data.MySqlClient

Public Class CDatabase
    Implements IDatabase
    Function Connect() As String Implements IDatabase.Connect
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;"
        Dim conn As New MySqlConnection(connString)
        Dim StrVar As String
        Try
            conn.Open()
            Dim rd As MySqlDataReader
            Dim command As New MySqlCommand
            command.CommandText = "select name from  appliance where idPacket = 1"
            rd = command.ExecuteReader
            If rd.Read Then

                StrVar = rd.GetString(1)

            End If
            rd.Close()
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
