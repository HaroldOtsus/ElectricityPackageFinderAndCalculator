Imports MySql.Data.MySqlClient

Public Class CDatabase
    Implements IDatabase
    Implements IDatabaseAPI

    ''Function test() As String()
    ''Dim api As APIComponent.APIInterface
    ''  api = New APIComponent.APIComponent
    ''Return api.GetDataFromEleringAPI

    ''End Function

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


    Function stockPrice() As String()
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String
        Dim dateToday
        dateToday = Date.Today 'get what date it is today
        Try

            conn.Open() 'try to connect to database

            Dim command As New MySqlCommand("SELECT date FROM webdata WHERE idPacket = 1;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                dateOfStockPrices = reader.GetString(0) 'get date from database
            End While
            If dateOfStockPrices = dateToday Then
                ''need to return all prices from database
                ''Return dateOfStockPrices
            Else
                ''we ask prices from the API
                ''we put the info to the database
            End If
            conn.Close()
        Catch ex As Exception
        End Try

    End Function

    Function insertStockPriceToDatabase() As String ''get data from API and insert it into database
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        dateToday = Date.Today 'get what date it is today
        Dim api As PrjAPIComponent.APIInterface
        api = New PrjAPIComponent.APIComponent
        Dim sPrices As String()
        sPrices = api.GetDataFromEleringAPI()
        '' sPrices()
        Try

            conn.Open() 'try to connect to database

            '' Dim command As New MySqlCommand("UPDATE webdata SET one = @colOne, two = @colTwo, three = @colThree WHERE idPacket = 1 ", conn)
            '' broke command into several commands because it didn't update database and thougth there was a bug
            '' actually didn't update because one column name was written wrongly
            Dim command As New MySqlCommand("
            UPDATE webdata 
            SET 
                one = @colOne, 
                two = @colTwo, 
                three = @colThree, 
                four = @colFour, 
                five = @colFive, 
                six = @colSix, 
                seven = @colSeven, 
                eight = @colEight, 
                nine = @colNine, 
                ten = @colTen
            WHERE 
                idPacket = 1", conn) ''four = @colFour, five = @colFive, six = @colSix, seven = @colSeven, eight = @colEight, nine = @colNine, ten = @colTen, eleven = @colEleven, twelve = @col12, thirteen = @col13, fourteen = @col14, fifteen = @col15, sixteen = @col16, seventeen = @col17, eighteen = @col18, nineteen = @col19, twenty = @col20, twentyOne = @col21, twentyTwo = @col22, twentyThree = @col23, twentyFour = @col24, date = @colDate
            command.Parameters.AddWithValue("@colOne", sPrices(1))
            command.Parameters.AddWithValue("@colTwo", sPrices(2))
            command.Parameters.AddWithValue("@colThree", sPrices(3))
            command.Parameters.AddWithValue("@colFour", sPrices(4))
            command.Parameters.AddWithValue("@colFive", sPrices(5))
            command.Parameters.AddWithValue("@colSix", sPrices(6))
            command.Parameters.AddWithValue("@colSeven", sPrices(7))
            command.Parameters.AddWithValue("@colEight", sPrices(8))
            command.Parameters.AddWithValue("@colNine", sPrices(9))
            command.Parameters.AddWithValue("@colTen", sPrices(10))
            command.ExecuteNonQuery()
            'eleven = @colEleven,
            'fourteen = @colFourteen, 
            ' fifteen = @colfifteen, 
            'sixteen = @colSixteen, 
            'seventeen = @colSeventeen, 
            'eighteen = @colEighteen
            Dim com As New MySqlCommand("
    UPDATE webdata 
    SET  
        twelve = @colTwelve, 
        thirteen = @colThirteen,
        fourteen = @colFourteen
    WHERE 
        idPacket = 1", conn)

            com.Parameters.AddWithValue("@colTwelve", sPrices(12))
            com.Parameters.AddWithValue("@colThirteen", sPrices(13))
            com.Parameters.AddWithValue("@colFourteen", sPrices(14))
            ' com.Parameters.AddWithValue("@colFifteen", sPrices(15))
            'com.Parameters.AddWithValue("@colSixteen", sPrices(16))
            'com.Parameters.AddWithValue("@colSeventeen", sPrices(17))
            'com.Parameters.AddWithValue("@colEighteen", sPrices(18))
            com.ExecuteNonQuery()
            Dim cmd As New MySqlCommand("
    UPDATE webdata 
    SET  
             fiveteen = @colFifteen, 
             sixteen = @colSixteen, 
            seventeen = @colSeventeen,
            eighteen = @colEighteen
    WHERE 
        idPacket = 1", conn)

            cmd.Parameters.AddWithValue("@colFifteen", sPrices(15))
            cmd.Parameters.AddWithValue("@colSixteen", sPrices(16))
            cmd.Parameters.AddWithValue("@colSeventeen", sPrices(17))
            cmd.Parameters.AddWithValue("@colEighteen", sPrices(18))
            cmd.ExecuteNonQuery()


            Dim comm As New MySqlCommand("
            UPDATE webdata 
            SET 
               nineteen = @col19, 
                twenty = @col20, 
                twentyOne = @col21, 
                twentyTwo = @col22, 
                twentyThree = @col23, 
                twentyFour = @col24, 
                Date = @colDate
            WHERE 
                idPacket = 1", conn)

            comm.Parameters.AddWithValue("@col19", sPrices(19))
            comm.Parameters.AddWithValue("@col20", sPrices(20))
            comm.Parameters.AddWithValue("@col21", sPrices(21))
            comm.Parameters.AddWithValue("@col22", sPrices(22))
            comm.Parameters.AddWithValue("@col23", sPrices(23))
            comm.Parameters.AddWithValue("@col24", sPrices(24))
            comm.Parameters.AddWithValue("@colDate", dateToday)
            comm.ExecuteNonQuery()
            conn.Close()
            Return "cool"
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
