Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class CDatabase
    Implements IDatabase
    Implements IDatabaseAPI
    Implements ISignup
    Implements ILogin
    Function hashPassword(ByVal password As String) As String
        Dim sha256 As SHA256 = SHA256.Create() 'use create method that returns best available implementation of SHA256
        'convert password to bytes
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        'we hash the byte array
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
        ''SHA256 explanation learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-7.0
    End Function


    Function login(ByVal username As String, ByVal password As String) As Boolean Implements ILogin.login
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim pass As String = ""
        Try
            conn.Open()
            Dim checkIfUsername As Boolean ' check is username exists
            checkIfUsername = checkIfUsernameExists(username)
            If checkIfUsername = False Then 'if it exists then

                Dim command As New MySqlCommand("SELECT password FROM user
            WHERE username = @username;", conn)
                command.Parameters.AddWithValue("@username", username)

                Dim reader As MySqlDataReader = command.ExecuteReader()
                Dim passW = hashPassword(password) 'hash password
                While reader.Read()
                    pass = reader.GetString(0) 'get password

                End While
                If String.Compare(pass, passW) = 0 Then 'check is hashes password is same as in the database
                    Return True
                Else
                    Return False
                End If
            End If
            conn.Close()
            Return False

        Catch ex As Exception
            Return False
        End Try

    End Function


    Function checkIfUsernameExists(ByVal username As String) As Boolean
        'we check is the username exists in database
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString) 'connect to database
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM user WHERE username  = @username", conn)
        cmd.Parameters.AddWithValue("@username", username)
        Try
            'search database
            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) 'find if username already exists
            If count > 0 Then
                Return False
            Else
                'if there isn't return true
                Return True
            End If

            conn.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function

    Function signup(ByVal username As String, ByVal password As String, ByVal name As String, ByVal email As String) As Boolean Implements ISignup.signup
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        ''call function that hashes password
        Try
            conn.Open()
            Dim cool As Boolean
            cool = checkIfUsernameExists(username)
            If cool = True Then
                'hash password
                Dim pass = hashPassword(password)
                'insert into database
                Dim command As New MySqlCommand("INSERT INTO user (name, password, username, email)
            VALUES (@name, @password, @username, @email);", conn)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", pass)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@email", email)
                command.ExecuteNonQuery()
                'if everything went well return true otherwise false
                Return True
            End If
            conn.Close()
            Return False

        Catch ex As Exception
            Return False

        End Try


    End Function





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
            'get what we want to from the database, right now get everything from table appliance where idPacket is what user inserted
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                consumptionPerHour = reader.GetString(2)
                usageTime = reader.GetString(3)
                Return (consumptionPerHour, usageTime)
                'return to GUI
            End While
            reader.Close()

            conn.Close()
        Catch ex As MySqlException ''code for troubleshooting will have to change it if want to use with GUI
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
        consumptionPerHour = "Error"
        usageTime = "Error"
        Return (consumptionPerHour, usageTime)
    End Function

    Function datesOfStockPrice() As String() 'get stockprice dates from database
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Dim dateToday
        dateToday = Date.Today 'get what date it is today
        Try

            conn.Open() 'try to connect to database
            Dim command As New MySqlCommand("SELECT date FROM webdata WHERE idPacket = 1;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                dateOfStockPrices = reader.GetString(0) 'get date from database
            End While
            conn.Close()
            Dim con As New MySqlConnection(connString)
            con.Open()
            Dim sPrices() As String = New String(25) {}
            sPrices(0) = ""
            If dateOfStockPrices = dateToday Then
                '        ''need to return all prices from database
                Dim cmd As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 2;", con)
                Dim read As MySqlDataReader = cmd.ExecuteReader()
                If read IsNot Nothing Then
                    While read.Read() 'get all dates from database
                        For i As Integer = 1 To 24
                            sPrices(i) = read.GetString(i)
                        Next
                    End While
                    read.Close()
                    con.Close()

                    'Dim stringOfDates As String()
                    'stringOfDates = insertDatesToDatabase()

                    Return sPrices
                End If
            End If
            conn.Close()
        Catch ex As Exception
            stringOfErrors = {"error", "error", "error"}
            Return stringOfErrors
        End Try

    End Function
    Function electricityPackagesInfo() As (String(), String(), Double(), Double(), Boolean(), Boolean()) Implements IDatabase.electricityPackagesInfo
        Dim count As Integer
        count = electricityPackagesCount()
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString) ' connection to database
        Try

            conn.Open()
            'get info about electricity packages from database
            Dim sqlCommand As New MySqlCommand("SELECT packageName,companyName, pricePerKWh, monthlyFeeForContract, usesMarketPRice, greenEnergy FROM electricityPackages;", conn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
            'create arrays to hold database info
            Dim stringOfPackageNames(count - 1) As String
            Dim stringOfCompanyNames(count - 1) As String
            Dim pricePerKWh(count - 1) As Double
            Dim monthlyFeeForContract(count - 1) As Double
            Dim usesMarketPrice(count - 1) As Boolean
            Dim greenEnergy(count - 1) As Boolean
            Dim rowcount As Integer = 0
            Dim i As Integer = 0
            While reader.Read() AndAlso i < count
                'insert data into arrays
                stringOfPackageNames(i) = reader.GetString(0)
                stringOfCompanyNames(i) = reader.GetString(1)
                pricePerKWh(i) = reader.GetString(2)
                monthlyFeeForContract(i) = reader.GetString(3)
                usesMarketPrice(i) = reader.GetString(4)
                greenEnergy(i) = reader.GetString(5)
                i += 1
            End While

            conn.Close()
            'return arrays
            Return (stringOfPackageNames, stringOfCompanyNames, pricePerKWh, monthlyFeeForContract, usesMarketPrice, greenEnergy)
        Catch ex As Exception
            'exception using database
            '   stringOfErrors = {"error", "error", "error"}
            '  Return stringOfErrors
        End Try
    End Function
    Function electricityPackagesCount() As Integer
        'find how many electricity packages there are in the database
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim stringOfErrors() As String = Nothing
        Try

            conn.Open() 'try to connect to database
            ' Create a SqlCommand to retrieve the distinct ID values from the table
            Dim sqlCommand As New MySqlCommand("SELECT DISTINCT id FROM electricityPackages", conn)

            ' get how many id values in database
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
            Dim count As Integer = 0
            While reader.Read()
                'loop through id-s and raise count
                count += 1
            End While

            conn.Close()
            Return count

        Catch ex As Exception
            'database error 
            '   stringOfErrors = {"error", "error", "error"}
            '  Return stringOfErrors
        End Try
    End Function

    Function stockPrice() As (prices As String(), dates As String()) Implements IDatabaseAPI.stockPrice
        Dim currentHour As Integer = DateTime.Now.Hour
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Dim dateToday
        dateToday = Date.Today 'get what date it is today
        Try

            conn.Open() 'try to connect to database
            Dim command As New MySqlCommand("SELECT twentyFour FROM webdata WHERE idPacket = 2;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                dateOfStockPrices = reader.GetString(0) 'get date from database
            End While
            conn.Close()
            Dim con As New MySqlConnection(connString)
            con.Open()
            Dim sPrices() As String = New String(24) {}
            sPrices(0) = ""
            Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(dateOfStockPrices) 'new datetimeoffset from sDate string
            Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date


            ' Get the UTC+2 time zone
            Dim timeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time")

            ' Convert DateTimeOffset object to UTC+3 timezone
            Dim convertedTime As DateTimeOffset = TimeZoneInfo.ConvertTime(dateTimeOffset, timeZone)

            Dim hour As Integer = convertedTime.Hour

            If hour = currentHour Then

                '        ''need to return all prices from database
                Dim cmd As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 1;", con)
                Dim read As MySqlDataReader = cmd.ExecuteReader()
                If read IsNot Nothing Then
                    While read.Read() 'get all dates from database
                        For i As Integer = 1 To 24
                            sPrices(i) = read.GetString(i)
                        Next
                    End While
                    read.Close()
                    con.Close()

                    Dim stringOfDates As String()
                    'stringOfDates = insertDatesToDatabase()
                    stringOfDates = datesOfStockPrice()
                    Return (sPrices, stringOfDates)
                End If
            Else
                Dim stringOfPrices As String()
                Dim stringOfDates As String()
                stringOfPrices = insertStockPriceToDatabase()
                stringOfDates = insertDatesToDatabase()
                Return (stringOfPrices, stringOfDates)
                '        ''we put the info to the database
            End If
            conn.Close()
        Catch ex As Exception
            '   stringOfErrors = {"error", "error", "error"}
            '  Return stringOfErrors
        End Try

    End Function

    Function insertStockPriceToDatabase() As String() ''get data from API and insert it into database
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        Dim stringOfErrors() As String = Nothing
        dateToday = Date.Today 'get what date it is today
        Dim api As PrjAPIComponent.APIInterface
        api = New PrjAPIComponent.APIComponent
        Dim sPrices As String()
        sPrices = api.GetDataFromEleringAPI().Item1
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
                ten = @colTen,
                eleven = @colEleven,
                twelve = @colTwelve, 
                thirteen = @colThirteen,
                fourteen = @colFourteen,
                fiveteen = @colFifteen, 
                sixteen = @colSixteen, 
                seventeen = @colSeventeen,
                eighteen = @colEighteen,
                nineteen = @col19, 
                twenty = @col20, 
                twentyOne = @col21, 
                twentyTwo = @col22, 
                twentyThree = @col23, 
                twentyFour = @col24, 
                Date = @colDate
            WHERE 
                idPacket = 1", conn)
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
            command.Parameters.AddWithValue("@colEleven", sPrices(11))
            command.Parameters.AddWithValue("@colTwelve", sPrices(12))
            command.Parameters.AddWithValue("@colThirteen", sPrices(13))
            command.Parameters.AddWithValue("@colFourteen", sPrices(14))
            command.Parameters.AddWithValue("@colFifteen", sPrices(15))
            command.Parameters.AddWithValue("@colSixteen", sPrices(16))
            command.Parameters.AddWithValue("@colSeventeen", sPrices(17))
            command.Parameters.AddWithValue("@colEighteen", sPrices(18))
            command.Parameters.AddWithValue("@col19", sPrices(19))
            command.Parameters.AddWithValue("@col20", sPrices(20))
            command.Parameters.AddWithValue("@col21", sPrices(21))
            command.Parameters.AddWithValue("@col22", sPrices(22))
            command.Parameters.AddWithValue("@col23", sPrices(23))
            command.Parameters.AddWithValue("@col24", sPrices(24))
            command.Parameters.AddWithValue("@colDate", dateToday)
            command.ExecuteNonQuery()

            '        Dim com As New MySqlCommand("
            'UPDATE webdata 
            'SET  
            '    eleven = @colEleven,
            '    twelve = @colTwelve, 
            '    thirteen = @colThirteen,
            '    fourteen = @colFourteen
            'WHERE 
            '    idPacket = 1", conn)
            '        com.Parameters.AddWithValue("@colEleven", sPrices(11))
            '        com.Parameters.AddWithValue("@colTwelve", sPrices(12))
            '        com.Parameters.AddWithValue("@colThirteen", sPrices(13))
            '        com.Parameters.AddWithValue("@colFourteen", sPrices(14))
            '        ' com.Parameters.AddWithValue("@colFifteen", sPrices(15))
            '        'com.Parameters.AddWithValue("@colSixteen", sPrices(16))
            '        'com.Parameters.AddWithValue("@colSeventeen", sPrices(17))
            '        'com.Parameters.AddWithValue("@colEighteen", sPrices(18))
            '        '        com.ExecuteNonQuery()
            '        Dim cmd As New MySqlCommand("
            'UPDATE webdata 
            'SET  
            '         fiveteen = @colFifteen, 
            '         sixteen = @colSixteen, 
            '        seventeen = @colSeventeen,
            '        eighteen = @colEighteen
            'WHERE 
            '    idPacket = 1", conn)

            '        cmd.Parameters.AddWithValue("@colFifteen", sPrices(15))
            '        cmd.Parameters.AddWithValue("@colSixteen", sPrices(16))
            '        cmd.Parameters.AddWithValue("@colSeventeen", sPrices(17))
            '        cmd.Parameters.AddWithValue("@colEighteen", sPrices(18))
            '        cmd.ExecuteNonQuery()


            '        Dim comm As New MySqlCommand("
            '        UPDATE webdata 
            '        SET 
            '           nineteen = @col19, 
            '            twenty = @col20, 
            '            twentyOne = @col21, 
            '            twentyTwo = @col22, 
            '            twentyThree = @col23, 
            '            twentyFour = @col24, 
            '            Date = @colDate
            '        WHERE 
            '            idPacket = 1", conn)

            '        comm.Parameters.AddWithValue("@col19", sPrices(19))
            '        comm.Parameters.AddWithValue("@col20", sPrices(20))
            '        comm.Parameters.AddWithValue("@col21", sPrices(21))
            '        comm.Parameters.AddWithValue("@col22", sPrices(22))
            '        comm.Parameters.AddWithValue("@col23", sPrices(23))
            '        comm.Parameters.AddWithValue("@col24", sPrices(24))
            '        comm.Parameters.AddWithValue("@colDate", dateToday)
            '        comm.ExecuteNonQuery()
            conn.Close()
            Return sPrices
        Catch ex As Exception
            stringOfErrors = {"error", "error", "error"}
            Return stringOfErrors
        End Try

    End Function


    Function insertDatesToDatabase() As String() ''get data from API and insert it into database
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        Dim stringOfErrors() As String = Nothing
        dateToday = Date.Today 'get what date it is today
        Dim api As PrjAPIComponent.APIInterface
        api = New PrjAPIComponent.APIComponent
        Dim sDates As String()
        sDates = api.GetDataFromEleringAPI().Item2
        'get info from API about dates
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
                ten = @colTen,
                eleven = @colEleven,
                twelve = @colTwelve, 
                thirteen = @colThirteen,
                fourteen = @colFourteen,
                fiveteen = @colFifteen, 
                sixteen = @colSixteen, 
                seventeen = @colSeventeen,
                eighteen = @colEighteen,
                nineteen = @col19, 
                twenty = @col20, 
                twentyOne = @col21, 
                twentyTwo = @col22, 
                twentyThree = @col23, 
                twentyFour = @col24, 
                Date = @colDate
            WHERE 
                idPacket = 2", conn)
            command.Parameters.AddWithValue("@colOne", sDates(1))
            command.Parameters.AddWithValue("@colTwo", sDates(2))
            command.Parameters.AddWithValue("@colThree", sDates(3))
            command.Parameters.AddWithValue("@colFour", sDates(4))
            command.Parameters.AddWithValue("@colFive", sDates(5))
            command.Parameters.AddWithValue("@colSix", sDates(6))
            command.Parameters.AddWithValue("@colSeven", sDates(7))
            command.Parameters.AddWithValue("@colEight", sDates(8))
            command.Parameters.AddWithValue("@colNine", sDates(9))
            command.Parameters.AddWithValue("@colTen", sDates(10))
            command.Parameters.AddWithValue("@colEleven", sDates(11))
            command.Parameters.AddWithValue("@colTwelve", sDates(12))
            command.Parameters.AddWithValue("@colThirteen", sDates(13))
            command.Parameters.AddWithValue("@colFourteen", sDates(14))
            command.Parameters.AddWithValue("@colFifteen", sDates(15))
            command.Parameters.AddWithValue("@colSixteen", sDates(16))
            command.Parameters.AddWithValue("@colSeventeen", sDates(17))
            command.Parameters.AddWithValue("@colEighteen", sDates(18))
            command.Parameters.AddWithValue("@col19", sDates(19))
            command.Parameters.AddWithValue("@col20", sDates(20))
            command.Parameters.AddWithValue("@col21", sDates(21))
            command.Parameters.AddWithValue("@col22", sDates(22))
            command.Parameters.AddWithValue("@col23", sDates(23))
            command.Parameters.AddWithValue("@col24", sDates(24))
            command.Parameters.AddWithValue("@colDate", dateToday)
            command.ExecuteNonQuery()

            '        Dim com As New MySqlCommand("
            'UPDATE webdata 
            'SET 
            '    eleven = @colEleven,
            '    twelve = @colTwelve, 
            '    thirteen = @colThirteen,
            '    fourteen = @colFourteen
            'WHERE 
            '    idPacket = 2", conn)
            '        com.Parameters.AddWithValue("@colEleven", sDates(11))
            '        com.Parameters.AddWithValue("@colTwelve", sDates(12))
            '        com.Parameters.AddWithValue("@colThirteen", sDates(13))
            '        com.Parameters.AddWithValue("@colFourteen", sDates(14))
            '        ' com.Parameters.AddWithValue("@colFifteen", sPrices(15))
            '        'com.Parameters.AddWithValue("@colSixteen", sPrices(16))
            '        'com.Parameters.AddWithValue("@colSeventeen", sPrices(17))
            '        'com.Parameters.AddWithValue("@colEighteen", sPrices(18))
            '        com.ExecuteNonQuery()
            '        Dim cmd As New MySqlCommand("
            'UPDATE webdata 
            'SET  
            '         fiveteen = @colFifteen, 
            '         sixteen = @colSixteen, 
            '        seventeen = @colSeventeen,
            '        eighteen = @colEighteen
            'WHERE 
            '    idPacket = 2", conn)

            '        cmd.Parameters.AddWithValue("@colFifteen", sDates(15))
            '        cmd.Parameters.AddWithValue("@colSixteen", sDates(16))
            '        cmd.Parameters.AddWithValue("@colSeventeen", sDates(17))
            '        cmd.Parameters.AddWithValue("@colEighteen", sDates(18))
            '        cmd.ExecuteNonQuery()


            '        Dim comm As New MySqlCommand("
            '        UPDATE webdata 
            '        SET 
            '           nineteen = @col19, 
            '            twenty = @col20, 
            '            twentyOne = @col21, 
            '            twentyTwo = @col22, 
            '            twentyThree = @col23, 
            '            twentyFour = @col24, 
            '            Date = @colDate
            '        WHERE 
            '            idPacket = 2", conn)

            '        comm.Parameters.AddWithValue("@col19", sDates(19))
            '        comm.Parameters.AddWithValue("@col20", sDates(20))
            '        comm.Parameters.AddWithValue("@col21", sDates(21))
            '        comm.Parameters.AddWithValue("@col22", sDates(22))
            '        comm.Parameters.AddWithValue("@col23", sDates(23))
            '        comm.Parameters.AddWithValue("@col24", sDates(24))
            '        comm.Parameters.AddWithValue("@colDate", dateToday)
            '        comm.ExecuteNonQuery()
            '        conn.Close()
            Return sDates
        Catch ex As Exception
            stringOfErrors = {"error", "error", "error"}
            Return stringOfErrors
        End Try

    End Function

    Function Connect() As Boolean ' use it to test if there is connection to database (look at PrjDatabaseTestid)
        Dim connString As String = "server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            conn.Close()
            'if there is connection return false
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
