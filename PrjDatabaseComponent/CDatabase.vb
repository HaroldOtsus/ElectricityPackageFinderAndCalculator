Imports MySql.Data.MySqlClient

Public Class CDatabase
    Implements IDatabase
    Function stringReturn() As String Implements IDatabase.stringReturn
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim strVar As String
        Try
            conn.Open()
            Dim command As New MySqlCommand("SELECT * FROM appliance WHERE idPacket = 1;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Return reader.GetString(1)
            End While
            reader.Close()

            conn.Close()
        Catch ex As MySqlException
            ' Handle MySqlException here
            strVar = "MySqlException:"
            strVar &= ex.Message
            Return strVar
        Catch ex As InvalidOperationException
            ' Handle InvalidOperationException here
            Console.WriteLine("InvalidOperationException: " & ex.Message)
            strVar = "Invalidoperationexception:"
            strVar &= ex.Message
            Return strVar
        Catch ex As Exception
            ' Handle all other exceptions here
            ' Console.WriteLine("Exception: " & ex.Message)

            'StrVar = "excemption occured"
            Return ex.Message
        End Try
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
