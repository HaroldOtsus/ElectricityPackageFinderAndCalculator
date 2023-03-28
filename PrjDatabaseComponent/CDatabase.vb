Imports MySql.Data.MySqlClient

Public Class CDatabase
    Implements IDatabase
    Function stringReturn() As String Implements IDatabase.stringReturn
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim StrVar As String
        Try
            conn.Open()
            Dim rd As MySqlDataReader
            Dim command As New MySqlCommand
            command.CommandText = "SELECT * FROM appliance WHERE idPacket = 1;"
            rd = command.ExecuteReader
            If rd.Read Then

                StrVar = rd.GetString(1)
            Else
                StrVar = "viga"
            End If

            rd.Close()
            conn.Close()

        Catch ex As Exception
            Return 0
        End Try
        Return StrVar
    End Function

    Function Connect() As Boolean
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        ' Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            conn.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
