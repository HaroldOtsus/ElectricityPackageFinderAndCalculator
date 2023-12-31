﻿' FAILINIMI: CDatabase.vb
' AUTOR: Laura Kõrgmaa
' LOODUD: 22.03.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Loob ühenduse andmebaasiga. Saab andmeid kätte andmebaasist. Saab muuta andmeid andmebaasis.
' Eeldused: Tingimused, mis peavad edukaks käivituseks täidetud olema, peab olema ühendus internettiga. 
'Peab olema config.ini fail, kust loetakse andmed andmebaasi kohta ja see fail peab olema paigaldatud GUI debugis.
'Peab olema refrencite all MySql.Data ehk MySql connector for NET https://dev.mysql.com/downloads/connector/net/
' Sisendid: Sisendparameetrite eesmärk..
' Komponendid: Kasutab infot PrjAPIComponendilt ja PrjWeatherAPI-lt
' Tulem: Info andmebaasist või info APIlt. Kui andmeid ei saadud kätte tagastatakse -1 või Nothing või 0.



Imports MySql.Data.MySqlClient 'for using mysql db https://dev.mysql.com/doc/connector-net/en/connector-net-programming.html
Imports System.Security.Cryptography 'for hashing passwords
Imports Microsoft.Extensions.Configuration.Ini 'for reading .ini files
Imports Microsoft.Extensions.Configuration

Public Class CDatabase
    Implements IDatabase
    Implements IDatabaseAPI
    Implements ISignup
    Implements ILogin
    Private Shared connString As String

    'GetConnectioreturns connection string to database from config file
    Private Function GetConnectionString() As String
        If String.IsNullOrEmpty(connString) Then 'if connstring is empty then
            Try 'try to read config file
                Dim config As IConfigurationRoot = New ConfigurationBuilder().
                            SetBasePath(AppDomain.CurrentDomain.BaseDirectory).
                            AddIniFile("config.ini", optional:=False, reloadOnChange:=True).
                            Build()

                Dim server As String = config.GetSection("database")("Server")
                Dim user As String = config.GetSection("database")("user")
                Dim password As String = config.GetSection("database")("password")
                Dim database As String = config.GetSection("database")("database")

                connString = $"server={server};user id={user};password={password};database={database};Pooling=true;"  'return connString
                Return connString
            Catch ex As Exception
                Return Nothing
            End Try

        End If

        Return connString
    End Function


    'Private Shared conna As MySqlConnection

    ''Private Shared conn As MySqlConnection
    Private ReadOnly conn As New MySqlConnection(connString)
    'used https://stackoverflow.com/questions/5777549/mysql-database-connection-vb-net for example how to create connection
    Public Sub New() 'connection to database
        Dim connString As String = GetConnectionString() '"server=84.50.131.222;user id=root;password=Koertelemeeldibjalutada!1;database=mydb;"
        conn = New MySqlConnection(connString)
    End Sub
    'userPrefernces gets user's resolution and color from database and changes them byref
    'userPrefernces gets user's resolution and color from database and changes them byref
    Private Function userPrefernces(ByVal username, ByRef size, ByRef color) Implements ILogin.userPrefernces
        'get user prefences from database
        Dim conn As New MySqlConnection(connString)

        Try
            conn.Open()
            Dim command As New MySqlCommand("select color from user where username = @username", conn)
            command.Parameters.AddWithValue("@username", username)
            'right now only using color
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                color = reader.GetString(0)
            End While

        Catch ex As Exception
            'Does not return anything
        End Try


    End Function
    'updateUserPrefernces updates data in database
    Private Function updateUserPrefernces(ByVal username, ByVal update) Implements ILogin.updateUserPrefernces
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        'if user changes color update database
        Try
            conn.Open()
            Dim command As New MySqlCommand("UPDATE user SET color = @update  WHERE username = @username;", conn)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@update", update)
            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            'Does not return anything
        End Try


    End Function
    'hashPassword hashes a password using SHA256
    'based on https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm.computehash?view=net-8.0
    Private Function hashPassword(ByVal password As String) As String
        Dim sha256 As SHA256 = SHA256.Create() 'use create method that returns best available implementation of SHA256
        'convert password to bytes
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        'we hash the byte array
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
        ''SHA256 explanation learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-7.0
    End Function



    'login returns true if login was successful and false if it was not for whatever reason
    Private Function login(ByVal username As String, ByVal password As String) As Boolean Implements ILogin.login
        Dim connString = GetConnectionString()
        If connString = Nothing Then 'if there is no config file

            MsgBox("Missing config.ini file!")
            Return False
        End If
        '  Dim conn As New MySqlConnection(connString)
        Dim pass As String = ""
        Try
            conn.Open()
            Dim checkIfUsername As Boolean ' check is username exists
            checkIfUsername = checkIfUsernameExists(username)
            If checkIfUsername = True Then 'if it exists then

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
            '  conn.Close()
            Return False

        Catch ex As Exception
            Return False
        End Try

    End Function

    'checkIfUsernameExists checks if suer inserted username exists in database
    Private Function checkIfUsernameExists(ByVal username As String) As Boolean
        'we check is the username exists in database
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM user WHERE username  = @username", conn)
        cmd.Parameters.AddWithValue("@username", username)
        Try
            'search database
            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) 'find if username already exists
            If count > 0 Then
                Return True 'username exists
            Else
                'if there isn't return true
                Return False
            End If

            conn.Close()

        Catch ex As Exception
            Return False
        End Try

    End Function
    'creates new user in table user in database
    Private Function signup(ByVal username As String, ByVal password As String, ByVal name As String, ByVal email As String) As Boolean Implements ISignup.signup
        ''call function that hashes password
        Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            'Dim cool As Boolean
            'cool = checkIfUsernameExists(username)
            If checkIfUsernameExists(username) = True Then
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
            Else
                MsgBox("Sisestatud kasutajanimi on juba kasutusel.")
            End If
            conn.Close()
            Return False

        Catch ex As Exception
            Return False

        End Try


    End Function




    'stringReturns returns info about appliance from database
    Private Function stringReturn(ByVal id As String) As (consumptionPerHour As String, usageTime As String) Implements IDatabase.stringReturn
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim consumptionPerHour As String = ""
        Dim usageTime As String = ""

        Try
            conn.Open() 'try to gain access to database
            Dim command As New MySqlCommand("SELECT * FROM appliance WHERE idPacket = ?;", conn)
            command.Parameters.AddWithValue("@id", id)
            'get what we want to from the database, right now get everything from table appliance where idPacket is what user inserted
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                consumptionPerHour = reader.GetString(2)
                usageTime = reader.GetString(3)

                'return to GUI
            End While
            reader.Close()
            Return (consumptionPerHour, usageTime)
            conn.Close()

        Catch ex As Exception 'exception
            consumptionPerHour = Nothing
            usageTime = Nothing
            Return (consumptionPerHour, usageTime)
        End Try

    End Function
    ' datesOfStockPrice returns dates from database table webdata row 2
    Private Function datesOfStockPrice() As String() 'get stockprice dates from database
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Dim dateToday
        dateToday = Date.Today 'get what date it is today
        Try

            conn.Open() 'try to connect to database
            Dim sPrices() As String = New String(24) {}
            sPrices(0) = ""
            '        ''need to return all prices from database
            Dim cmd As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 2;", conn)
            Dim read As MySqlDataReader = cmd.ExecuteReader()
            If read IsNot Nothing Then
                While read.Read() 'get all dates from database
                    For i As Integer = 1 To 24
                        sPrices(i) = read.GetString(i)
                    Next
                End While
                read.Close()

                'Dim stringOfDates As String()
                'stringOfDates = insertDatesToDatabase()

                Return sPrices
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    ' stringsOfStockPrice returns prices from database table webdata row 1
    Private Function stringsOfStockPrice() As String() 'get stockprice strings from database
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Try

            conn.Open() 'try to connect to database
            Dim sPrices() As String = New String(24) {}
            sPrices(0) = ""
            '        ''need to return all prices from database
            Dim cmd As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 1;", conn)
            Dim read As MySqlDataReader = cmd.ExecuteReader()
            If read IsNot Nothing Then
                While read.Read() 'get strings
                    For i As Integer = 1 To 24
                        sPrices(i) = read.GetString(i)
                    Next
                End While
                read.Close()

                'Dim stringOfDates As String()
                'stringOfDates = insertDatesToDatabase()

                Return sPrices
            End If
            Return Nothing
        Catch ex As Exception 'if there is expception return error
            Return Nothing
        End Try

    End Function

    Private Function stringsOfStockPriceFuture() As String() 'get stockprice strings from database
        'Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Try

            conn.Open() 'try to connect to database
            Dim sPrices() As String = New String(24) {}
            sPrices(0) = ""
            '        ''need to return all prices from database
            Dim cmd As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 3;", conn)
            Dim read As MySqlDataReader = cmd.ExecuteReader()
            If read IsNot Nothing Then
                While read.Read() 'get all strings from database
                    For i As Integer = 1 To 24
                        sPrices(i) = read.GetString(i)
                    Next
                End While
                read.Close()

                'Dim stringOfDates As String()
                'stringOfDates = insertDatesToDatabase()

                Return sPrices
            End If
            Return Nothing
        Catch ex As Exception

            Return Nothing 'error
        End Try

    End Function
    Private Function datesOfStockPriceFuture() As String() 'get stockprice dates from database
        '  Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Dim dateToday
        dateToday = Date.Today 'get what date it is today
        Try

            conn.Open() 'try to connect to database
            Dim sPrices() As String = New String(25) {}
            sPrices(0) = ""
            Dim cmd As New MySqlCommand("SELECT * FROM webdata WHERE idPacket = 4;", conn)
            Dim read As MySqlDataReader = cmd.ExecuteReader()
            If read IsNot Nothing Then
                While read.Read() 'get all dates from database
                    For i As Integer = 1 To 24
                        sPrices(i) = read.GetString(i)
                    Next
                End While
                read.Close()
                conn.Close()

                Return sPrices 'return prices
            End If

            Return Nothing

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Function electricityPackagesInfo() As (String(), String(), Double(), Double(), Boolean(), Boolean(), Boolean(), Double()) Implements IDatabase.electricityPackagesInfo
        Dim count As Integer
        count = electricityPackagesCount()
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString) ' connection to database
        Try

            conn.Open()
            'get info about electricity packages from database
            Dim sqlCommand As New MySqlCommand("SELECT packageName, companyName, pricePerKWh, monthlyFeeForContract, usesMarketPrice, greenEnergy, isNightPriceDifferent, nightPrice FROM electricityPackages;", conn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
            'create arrays to hold database info
            Dim stringOfPackageNames(count - 1) As String
            Dim stringOfCompanyNames(count - 1) As String
            Dim pricePerKWh(count - 1) As Double
            Dim monthlyFeeForContract(count - 1) As Double
            Dim usesMarketPrice(count - 1) As Boolean
            Dim greenEnergy(count - 1) As Boolean
            Dim isNightPriceDifferent(count - 1) As Boolean
            Dim nightPrice(count - 1) As Double
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
                isNightPriceDifferent(i) = reader.GetString(6)
                nightPrice(i) = reader.GetString(7)
                i += 1
            End While

            conn.Close()
            'return arrays
            Return (stringOfPackageNames, stringOfCompanyNames, pricePerKWh, monthlyFeeForContract, usesMarketPrice, greenEnergy, isNightPriceDifferent, nightPrice)
        Catch ex As Exception
            'exception using database
            Return (Nothing, Nothing, {0.0}, {0.0}, {False}, {False}, {False}, {0.0}) 'error getting info
        End Try
    End Function

    Private Function hourofDatabasestockPrices() As Integer
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Try


            conn.Open() 'try to connect to database
            Dim command As New MySqlCommand("SELECT twentyFour FROM webdata WHERE idPacket = 2;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                dateOfStockPrices = reader.GetString(0) 'get date from database
            End While
            conn.Close()
            'insert check if string is null
            Dim format As String = "yyyy-MM-dd HH:mm:ss"
            Dim oDate As DateTime = Convert.ToDateTime(dateOfStockPrices)
            Dim hour As Integer = oDate.Hour 'get hour from database string
            Return hour
        Catch ex As Exception 'there has been an exeption
            Return -1
        End Try
    End Function


    'stockPrice gets info from database table webdata rows 1 and 2 or API if the info there is old
    Private Function stockPrice() As (prices As String(), dates As String()) Implements IDatabaseAPI.stockPrice
        Dim currentHour As Integer = DateTime.Now.Hour 'get hour right now
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Dim databaseHour As Integer = hourofDatabasestockPrices()
        Dim stringOfDates As String()
        Dim sPrices As String()
        'will need to check if the date is same
        If databaseHour = -1 Then
            Return (Nothing, Nothing)
        Else
            If databaseHour = currentHour Then 'if hour in database is same as hour right now
                sPrices = stringsOfStockPrice() 'get info from database
                stringOfDates = datesOfStockPrice()
                Return (sPrices, stringOfDates)
            Else 'ask it from API and update info in database
                sPrices = insertStockPriceToDatabase()
                stringOfDates = insertDatesToDatabase()
                Return (sPrices, stringOfDates) 'return strings
            End If
        End If


    End Function
    'hoursofDatabasestocPricesFuture get what is the first hour in database and return it
    Private Function hourofDatabasestockPricesFuture() As Integer
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateOfStockPrices As String = ""
        Dim stringOfErrors() As String = Nothing
        Try


            conn.Open() 'try to connect to database
            Dim command As New MySqlCommand("SELECT one FROM webdata WHERE idPacket = 4;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                dateOfStockPrices = reader.GetString(0) 'get date from database in column one
            End While
            conn.Close()
            Dim format As String = "yyyy-MM-dd HH:mm:ss"
            Dim oDate As DateTime = Convert.ToDateTime(dateOfStockPrices)
            Dim hour As Integer = oDate.Hour
            Return hour 'return hour
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ' get info from database table webdata rows 3 and 4 and API
    Private Function getStockPriceAndDatesFromDatabaseFuture(ByVal strStartDate As String, ByVal strEndDate As String) As (String(), String()) _
        Implements IDatabase.getStockPriceAndDatesFromDatabaseFuture
        Dim currentHour As Integer = DateTime.Now.Hour
        Dim hour As Integer
        hour = hourofDatabasestockPricesFuture() 'get hour from database string

        If hour = currentHour + 1 Then 'if it is same as hour now get info from database
            Dim sPrices As String()
            Dim stringOfDates As String()
            sPrices = stringsOfStockPriceFuture()
            stringOfDates = datesOfStockPriceFuture()
            Return (sPrices, stringOfDates)
        Else 'else ask from API and insert new info to database
            Dim stringOfPrices As String()
            Dim stringOfDates As String()
            stringOfPrices = insertStockPriceToDatabaseFuture(strStartDate, strEndDate)
            stringOfDates = insertDatesToDatabaseFuture(strStartDate, strEndDate)
            If stringOfPrices IsNot Nothing And stringOfDates IsNot Nothing Then

                Return (stringOfPrices, stringOfDates)
            Else
                Dim oldsPrices = stringsOfStockPriceFuture()
                Dim oldstringOfDates = datesOfStockPriceFuture()
                Return (oldsPrices, oldstringOfDates)
            End If
        End If



    End Function

    Private Function insertStockPriceToDatabase() As String() ''get data from API and insert it into database
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        Dim stringOfErrors() As String = Nothing
        dateToday = Date.Today 'get what date it is today
        Dim api As PrjAPIComponent.APIInterface
        api = New PrjAPIComponent.APIComponent
        Dim sPrices(24) As String
        sPrices = api.GetDataFromEleringAPI().Item1 'get prices from API
        Try
            'insert into database
            conn.Open() 'try to connect to database
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
            conn.Close()
            Return sPrices
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Function insertStockPriceToDatabaseFuture(ByVal strStartDate As String, ByVal strEndDate As String) As String() ''get data from API and insert it into database
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        Dim stringOfErrors() As String = Nothing
        dateToday = Date.Today 'get what date it is today
        Dim api As PrjAPIComponent.APIInterface
        api = New PrjAPIComponent.APIComponent
        Dim sPrices As String()
        sPrices = api.GetDataFromEleringAPIWithDates(strStartDate, strEndDate).Item1 'get prices from API
        If sPrices.Length = 25 Then
            Try

                conn.Open() 'try to connect to database

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
                idPacket = 3", conn)
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
                conn.Close()

            Catch ex As Exception
                Return Nothing
            End Try
        End If
        Return sPrices
    End Function

    Private Function insertDatesToDatabaseFuture(ByVal strStartDate As String, ByVal strEndDate As String) As String() ''get data from API and insert it into database
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim dateToday
        Dim stringOfErrors() As String = Nothing
        dateToday = Date.Today 'get what date it is today
        Dim api As PrjAPIComponent.APIInterface
        api = New PrjAPIComponent.APIComponent
        Dim sDates As String()
        sDates = api.GetDataFromEleringAPIWithDates(strStartDate, strEndDate).Item2 'get dates from API
        'get info from API about dates
        If sDates.Length = 25 Then
            Try

                conn.Open() 'try to connect to database
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
                idPacket = 4", conn)
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

            Catch ex As Exception

                Return Nothing
            End Try
        End If
        Return sDates

    End Function

    Private Function insertDatesToDatabase() As String() ''get data from API and insert it into database
        '  Dim connString = GetConnectionString()
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

            Return sDates
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Function Connect() As Boolean ' use it to test if there is connection to database (look at PrjDatabaseTestid)
        ' Dim connString = GetConnectionString()
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
    Private Function onePackageInfo(ByVal packageName As String) As (String, String, Double, Double, Boolean, Boolean, Boolean, Double) Implements IDatabase.onePackageInfo
        'get one electricity package info from database
        '  Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)

        Try

            conn.Open()
            'get info about electricity package from database
            Dim sqlCommand As New MySqlCommand("SELECT packageName, companyName, pricePerKWh, monthlyFeeForContract, usesMarketPrice, greenEnergy, isNightPriceDifferent, nightPrice FROM electricityPackages where packageName = @packageName;", conn)
            sqlCommand.Parameters.AddWithValue("@packageName", packageName)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
            'create arrays to hold database info
            Dim stringOfPackageNames As String = ""
            Dim stringOfCompanyNames As String = ""
            Dim pricePerKWh As Double
            Dim monthlyFeeForContract As Double
            Dim usesMarketPrice As Boolean
            Dim greenEnergy As Boolean
            Dim isNightPriceDifferent As Boolean
            Dim nightPrice As Double
            Dim rowcount As Integer = 0
            Dim i As Integer = 0
            While reader.Read()
                'insert data into arrays
                stringOfPackageNames = reader.GetString(0)
                stringOfCompanyNames = reader.GetString(1)
                pricePerKWh = reader.GetString(2)
                monthlyFeeForContract = reader.GetString(3)
                usesMarketPrice = reader.GetString(4)
                greenEnergy = reader.GetString(5)
                isNightPriceDifferent = reader.GetString(6)
                nightPrice = reader.GetString(7)
                i += 1
            End While


            'return arrays
            Return (stringOfPackageNames, stringOfCompanyNames, pricePerKWh, monthlyFeeForContract, usesMarketPrice, greenEnergy, isNightPriceDifferent, nightPrice)
        Catch ex As Exception
            Return (Nothing, Nothing, 0.0, 0.0, False, False, False, 0.0) 'error getting info
            conn.Close()
        End Try
    End Function
    Private Function electricityPackagesCount() As Integer Implements IDatabase.electricityPackagesCount
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
            Return -1
        End Try
    End Function
    'get weatherinfo from database or API and return it
    Private Function weatherFromDatabase() As (Double, Integer, Double, Double) Implements IDatabase.weatherFromDatabase
        Dim conn As New MySqlConnection(connString) 'connection to database

        Try

            conn.Open()
            'get info from database
            Dim sqlCommand As New MySqlCommand("SELECT temperature, humidity, windspeed, clouds, time, date FROM weather where idweather = 1;", conn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
            'create variables to hold database info
            Dim timeOf As String = ""
            Dim dateOf As String = ""
            Dim temperature As Double
            Dim windspeed As Double
            Dim humidity As Integer
            Dim clouds As Double
            While reader.Read()
                'insert data into variables
                temperature = reader.GetString(0)
                humidity = reader.GetString(1)
                windspeed = reader.GetString(2)
                clouds = reader.GetString(3)
                timeOf = reader.GetString(4)
                dateOf = reader.GetString(5)
            End While
            conn.Close()
            Dim today As DateTime = DateTime.Today
            Dim currentHour As Integer = DateTime.Now.Hour
            If timeOf = currentHour And today = dateOf Then 'if hour in database is same as now
                'return variables
                Return (temperature, humidity, windspeed, clouds)
            Else 'updateinfo
                Dim allWeatherInfo = insertWeatherToDatabase()
                If allWeatherInfo.Item3 <> -1 Then 'if there has not been an error
                    temperature = allWeatherInfo.Item1
                    humidity = allWeatherInfo.Item2
                    windspeed = allWeatherInfo.Item3
                    clouds = allWeatherInfo.Item4
                    Return (temperature, humidity, windspeed, clouds) 'return new info
                End If
                Return (temperature, humidity, windspeed, clouds) 'return old info
            End If

        Catch ex As Exception
            'exception using database
            Return (-1, -1, -1, -1) 'there has been an error
        End Try
    End Function
    'insert weather info from API to database
    Private Function insertWeatherToDatabase() As (Double, Integer, Double, Double)

        Dim currentHour As Integer = DateTime.Now.Hour
        Dim today As DateTime = DateTime.Today
        Dim api As PrjWeatherAPI.IWeather
        api = New PrjWeatherAPI.CWeather
        Dim weather = api.getWeatherfromAPI()
        Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        If weather.Item3 = -1 Then 'error has occures
            Return (-1, -1, -1, -1)
        Else

            Try
                'insert into database
                conn.Open() 'try to connect to database
                Dim command As New MySqlCommand("
            UPDATE weather 
            SET 
                temperature = @colOne, 
                humidity = @colTwo, 
                windspeed = @colThree, 
                clouds = @colFour, 
                time = @colFive,
                date = @colSix
            WHERE 
                idweather = 1", conn)
                command.Parameters.AddWithValue("@colOne", weather.Item1)
                command.Parameters.AddWithValue("@colTwo", weather.Item2)
                command.Parameters.AddWithValue("@colThree", weather.Item3)
                command.Parameters.AddWithValue("@colFour", weather.Item4)
                command.Parameters.AddWithValue("@colFive", currentHour)
                command.Parameters.AddWithValue("@colSix", today)

                command.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                Return (-1, -1, -1, -1) 'error has occures
            End Try

            Return (weather.Item1, weather.Item2, weather.Item3, weather.Item4) 'return items
        End If
    End Function

    'get info about production from database or API and return it
    Private Function productionFromDatabase() As (Double, Double, Integer, Date) Implements IDatabase.productionFromDatabase
        ' Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)

        Try

            conn.Open()
            'get info about electricity package from database
            Dim sqlCommand As New MySqlCommand("SELECT productionOfAllEnergy, productionOfGreenEnergy,timestamp, date FROM productionOfEnergy where idproduction = 1;", conn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
            'create variables to hold database info
            Dim timeOf As Integer
            Dim dateOf As Date
            Dim allEnergy As Double
            Dim greenEnergy As Double
            While reader.Read()
                'insert data into variables
                allEnergy = reader.GetString(0)
                greenEnergy = reader.GetString(1)
                timeOf = reader.GetString(2)
                dateOf = reader.GetString(3)
            End While
            conn.Close()
            Dim currentHour As Integer = DateTime.Now.Hour
            Dim today As Date = DateTime.Today
            If timeOf = currentHour And today = dateOf Then 'if hour in database is hour now WILL NEED TO CHECK IF DATE IS ALSO CORRECT
                'return arrays
                Return (allEnergy, greenEnergy, currentHour, today) 'return info
            Else 'update info
                Dim allProdcution = insertProductionToDatabase()
                ' If allProdcution.Item1 <> -1 And allProdcution.Item2 <> -1 Then 'if there has not been an error
                allEnergy = allProdcution.Item1
                greenEnergy = allProdcution.Item2
                Return (allEnergy, greenEnergy, allProdcution.Item3, allProdcution.Item4)
            End If
            Return (allEnergy, greenEnergy, currentHour, today)
            'End I
        Catch ex As Exception
            'exception using database
            '   stringOfErrors = {"error", "error", "error"}
            Return (-1, -1, -1, Today) 'cannot access database
        End Try
    End Function
    'insert info about production from API to database
    Private Function insertProductionToDatabase() As (Double, Double, Integer, Date)
        '  Dim today As DateTime = DateTime.Today
        ' Dim currentHour As Integer = DateTime.Now.Hour
        Dim api As PrjWeatherAPI.IWeather
        api = New PrjWeatherAPI.CWeather
        Dim production = api.GetDataFromEleringAPIAboutProduction()
        Dim connString = GetConnectionString()
        Dim conn As New MySqlConnection(connString)
        Dim unixTimestamp As Long = Long.Parse(production.Item4)
        Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp)
        Dim currenthour As Integer = dateTimeOffset.Hour
        Dim today As Date = dateTimeOffset.Date
        If production.Item1 = True Then 'check if API gave info
            Try
                'insert into database
                conn.Open() 'try to connect to database
                Dim command As New MySqlCommand("
            UPDATE productionofenergy
            SET 
                productionOfAllEnergy = @colOne, 
                productionOfGreenEnergy = @colTwo, 
                timestamp= @colThree,
                date = @colFour
            WHERE 
                idproduction = 1", conn)
                command.Parameters.AddWithValue("@colOne", production.Item2)
                command.Parameters.AddWithValue("@colTwo", production.Item3)
                command.Parameters.AddWithValue("@colThree", currenthour)
                command.Parameters.AddWithValue("@colFour", today)
                command.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                'if we could not update info do nothing
            End Try

            Return (production.Item2, production.Item3, currenthour, today) 'return info
        Else
            Return (-1, -1, -1, today) 'could not give info from API
        End If

    End Function

End Class
