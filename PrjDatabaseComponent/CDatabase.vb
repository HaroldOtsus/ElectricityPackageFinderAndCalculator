Imports MySql.Data.MySqlClient

Public Class CDatabase
    Implements IDatabase
    Implements IDatabaseAPI
    Function stringReturn(ByVal id As String) As (consumptionPerHour As String, usageTime As String) Implements IDatabase.stringReturn
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;" 'string to access database
        Dim conn As New MySqlConnection(connString)
        Dim strVar As String
        Dim consumptionPerHour As String = ""
        Dim usageTime As String = ""
        'Dim id As String
        'id = "1"
        Try
            conn.Open() 'try to gain access to database
            Dim command As New MySqlCommand("SELECT * FROM appliance WHERE idPacket = ?;", conn)
            command.Parameters.AddWithValue("@id", id)
            'get what we want to from the database, right now get everything from table appliance where idPacket is what user inserter
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                consumptionPerHour = reader.GetString(2)
                usageTime = reader.GetString(3)
                Return (consumptionPerHour, usageTime)
                'actually this goes to calculator component but right now for testing purposes it is just returned
            End While
            reader.Close()

            conn.Close()
        Catch ex As MySqlException
            ' Handle MySqlException here
            strVar = "MySqlException:"
            strVar &= ex.Message
            ' Return strVar
        Catch ex As InvalidOperationException
            ' Handle InvalidOperationException here
            Console.WriteLine("InvalidOperationException: " & ex.Message)
            strVar = "Invalidoperationexception:"
            strVar &= ex.Message
            ' Return strVar
        Catch ex As Exception
            ' Handle all other exceptions here
            ' Console.WriteLine("Exception: " & ex.Message)

            'StrVar = "excemption occured"
            'Return ex.Message
        End Try
    End Function


    Function stockPrice(ByRef one) As String
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim dateToday
        dateToday = Date.Today 'get what date it is today

        Try

            conn.Open() 'try to connect to database

            Dim command As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 1;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                one = reader.GetString(1)
                dateOfStockPrices = reader.GetString(26) 'get date from database
            End While
            If dateOfStockPrices = dateToday Then
                Return dateOfStockPrices
            Else
                ''we ask prices from the API
                ''we put the info to the database
                one = ""
                Return "sad"
            End If
            conn.Close()
        Catch ex As Exception
        End Try

    End Function

    Function insertStockPriceToDatabase(ByRef one As String, ByRef two As String, ByRef three As String) As String
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        dateToday = Date.Today 'get what date it is today

        Try

            conn.Open() 'try to connect to database

            Dim command As New MySqlCommand("UPDATE webdata SET one = @colOne, two = @colTwo, three = @colThree, date = @colDate ", conn)
            command.Parameters.AddWithValue("@colOne", one)
            command.Parameters.AddWithValue("@colTwo", two)
            command.Parameters.AddWithValue("@colThree", three)
            command.Parameters.AddWithValue("@colDate", dateToday)
            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
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
