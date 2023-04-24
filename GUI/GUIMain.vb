

Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic.FileIO.TextFieldParser

Public Class GUIMain
    Public Structure PriceDateStruct

        Dim price As Double
        Dim sDate As String
    End Structure
    Public Structure DateWattageStruct

        Dim dateAndTime As String
        Dim wattage As Double
    End Structure

    Dim sisend As String 'might be a leftover obsolete relic that could potentially be deleted
    Dim applianceID As String
    Dim myColor As Color
    Dim fontSize As Double = 8.25

    Public answer As String
    Public usernameOfUser As String
    Private Sub btnPackageHourlyRate_Click(sender As Object, e As EventArgs) Handles btnPackageHourlyRate.Click
        TabControl1.SelectedTab = tabPackageHourlyRate
    End Sub

    Private Sub btnApplianceCalc_Click(sender As Object, e As EventArgs) Handles btnApplianceCalc.Click
        TabControl1.SelectedTab = tabApplianceCalc
    End Sub

    Private Sub btnExchangePriceComparison_Click(sender As Object, e As EventArgs) Handles btnExchangePriceComparison.Click
        TabControl1.SelectedTab = tabExchangeComparison
    End Sub

    Private Sub btnConsumptionHistory_Click(sender As Object, e As EventArgs) Handles btnConsumptionHistory.Click
        TabControl1.SelectedTab = tabConsumptionHistory
    End Sub

    Private Sub btnComparePackages_Click(sender As Object, e As EventArgs) Handles btnPackageComparison.Click
        TabControl1.SelectedTab = tabPackageComparison
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack0.Click, btnBack1.Click, btnBack2.Click, btnBack3.Click, btnBack4.Click
        TabControl1.SelectedTab = Main
    End Sub

    Private Sub btnClientConsumptionHistory_Click(sender As Object, e As EventArgs) Handles btnClientConsumptionHistory.Click
        TabControl2.SelectedTab = tabClientConsumptionHistory

    End Sub

    Private Sub btnSimulateConsumptionHistory_Click(sender As Object, e As EventArgs) Handles btnSimulateConsumptionHistory.Click
        TabControl2.SelectedTab = tabSimulateExchangeHistory
    End Sub


    'If you change TabControl1 tab then TabControl2 reverts to a blank tab, looks cleaner this way IMO.
    Private Sub tabConsumptionHistory_Leave(sender As Object, e As EventArgs) Handles tabConsumptionHistory.Leave
        TabControl2.SelectedTab = tabBlank
    End Sub

    Private Sub rdioCoffeeMaker_CheckedChanged(sender As Object, e As EventArgs) Handles rdioCoffeeMaker.CheckedChanged
        applianceID = "1"
    End Sub

    Private Function checkIfTextBoxContainsLetters(textbox As TextBox) As Boolean
        For Each i As Char In textbox.Text
            If Not (Char.IsDigit(i) Or i = "." Or i = ",") Then
                Return False
            End If
        Next

        Return True


    End Function
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim noneSelected As Boolean = True
        Dim noneSelected2 As Boolean = True
        ' Loop through all the radio buttons on the panel
        For Each radioButton As RadioButton In Panel1.Controls.OfType(Of RadioButton)()
            If radioButton.Checked Then
                noneSelected = False
                Exit For
            End If
        Next
        For Each radioButton As RadioButton In Panel3.Controls.OfType(Of RadioButton)()
            If radioButton.Checked Then
                noneSelected2 = False
                Exit For
            End If
        Next
        If Not noneSelected And Not noneSelected2 Then 'do not proceed if nothing is checked
            If tBoxPackagePrice.TextLength > 0 Or tBoxMarginal.TextLength > 0 Then 'do not proceed if text boxes are empty
                Dim tb1Letters As Boolean = checkIfTextBoxContainsLetters(tBoxPackagePrice)
                Dim tb2Letters As Boolean = checkIfTextBoxContainsLetters(tBoxMarginal)
                If tb1Letters = True Then
                    Dim returnString As PrjDatabaseComponent.IDatabase
                    returnString = New PrjDatabaseComponent.CDatabase
                    Dim actualOutput = returnString.stringReturn(applianceID)


                    tBoxConsumptionPerHour.Text = actualOutput.consumptionPerHour
                    tBoxUsageTime.Text = actualOutput.usageTime

                    Dim incoming As Computing_Component.ICalculating
                    incoming = New Computing_Component.CCalculating
                    Dim actualOutput2 = incoming.applianceConsumption(tBoxConsumptionPerHour.Text, tBoxUsageTime.Text, tBoxPackagePrice.Text)

                    'Shows only 3 decimal spaces
                    Dim cons As Decimal = actualOutput2.consumption

                    Dim consOut As String = cons.ToString("N3")

                    Dim aprox As Decimal = actualOutput2.aproxPrice
                    Dim aproxOut As String = aprox.ToString("N3")

                    tBoxElectricityConsumptionRate.Text = consOut
                    tBoxApproxPrice.Text = aproxOut
                End If
            End If
        End If

    End Sub

    Private Sub rdioToaster_CheckedChanged(sender As Object, e As EventArgs) Handles rdioToaster.CheckedChanged
        applianceID = "2"
    End Sub

    Private Sub rdioVacuum_CheckedChanged(sender As Object, e As EventArgs) Handles rdioVacuum.CheckedChanged
        applianceID = "3"
    End Sub

    Private Sub rdioMixer_CheckedChanged(sender As Object, e As EventArgs) Handles rdioMixer.CheckedChanged
        applianceID = "4"
    End Sub

    Private Sub rdioElecStove_CheckedChanged(sender As Object, e As EventArgs) Handles rdioElecStove.CheckedChanged
        applianceID = "5"
    End Sub

    Private Sub rdioFoodProcessor_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFoodProcessor.CheckedChanged
        applianceID = "6"
    End Sub

    Private Sub rdioTV_CheckedChanged(sender As Object, e As EventArgs) Handles rdioTV.CheckedChanged
        applianceID = "7"
    End Sub

    Private Sub rdioRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdioRadio.CheckedChanged
        applianceID = "8"
    End Sub

    Private Sub rdioEggCooker_CheckedChanged(sender As Object, e As EventArgs) Handles rdioEggCooker.CheckedChanged
        applianceID = "9"
    End Sub

    Private Sub rdioFridge_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFridge.CheckedChanged
        applianceID = "10"
    End Sub

    Private Sub rdioComputer_CheckedChanged(sender As Object, e As EventArgs) Handles rdioComputer.CheckedChanged
        applianceID = "11"
    End Sub

    Private Sub rdioHairDryer_CheckedChanged(sender As Object, e As EventArgs) Handles rdioHairDryer.CheckedChanged
        applianceID = "12"
    End Sub

    Private Sub rdioPrinter_CheckedChanged(sender As Object, e As EventArgs) Handles rdioPrinter.CheckedChanged
        applianceID = "13"
    End Sub

    Private Sub rdioLED_CheckedChanged(sender As Object, e As EventArgs) Handles rdioLED.CheckedChanged
        applianceID = "14"
    End Sub

    Private Sub rdioSewingMachine_CheckedChanged(sender As Object, e As EventArgs) Handles rdioSewingMachine.CheckedChanged
        applianceID = "16"
    End Sub

    Private Sub rdioRouter_CheckedChanged(sender As Object, e As EventArgs) Handles rdioRouter.CheckedChanged
        applianceID = "17"
    End Sub

    Private Sub rdioMicrowave_CheckedChanged(sender As Object, e As EventArgs) Handles rdioMicrowave.CheckedChanged
        applianceID = "18"
    End Sub



    Private Sub btnConfirmInput_Click(sender As Object, e As EventArgs) Handles btnConfirmInput.Click
        tblPriceTable.Controls.Clear()
        chrtPackageHourlyRate.Series.Clear()
        lblBestTime.Visible = False

        Dim tbMarginalOfStockLetters As Boolean = checkIfTextBoxContainsLetters(tbMarginalOfStock)
        Dim tboxMonthlyCostLetters As Boolean = checkIfTextBoxContainsLetters(tboxMonthlyCost)

        If tbMarginalOfStockLetters = False Or tboxMonthlyCostLetters = False Then

        Else




            Dim returnString As PrjDatabaseComponent.IDatabase
            Dim sPrices As String()
            Dim sDates As String()
            Dim dDates As Double() = New Double(24) {}

            Dim dPrices As Double()
            'Dim priceDateStruct As New PriceDateStruct() if the code works then this can be deleted


            returnString = New PrjDatabaseComponent.CDatabase
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim futureDate As DateTime = DateTime.Now.AddHours(24)
            Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")
            sPrices = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item1
            sDates = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item2

            Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
            Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
            If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then 'do not do this if language is english
                For i As Integer = 1 To 24
                    sPrices(i) = sPrices(i).Replace(".", ",")
                Next
            End If
            dPrices = New Double(sPrices.Length) {}


            For i As Integer = 1 To sPrices.Length - 1
                dPrices(i) = Double.Parse(sPrices(i))



            Next

            'UNIX NEEDS TO BE CONVERTED TO CONVENTIONAL TIMESTAMP DO BE USABLE
            'dDates = New Double(sDates.Length - 1) {}
            For i As Integer = 1 To 24 'sDates.Length - 1
                ' dDates(i) = Double.Parse(sDates(i))

                'in textbox get one time as string
                Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sDates(i)) 'new datetimeoffset from sDate string
                Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date
                dDates(i) = CDbl(dateValue.Hour) 'convert to integer
                'TextBox1.Text = dDates(i) 'put hour to textbox for testing

            Next
            If rdioFixedPrice.Checked Then 'universal price t odraw chart
                If tboxMonthlyCost.Text = "" Then
                    tboxMonthlyCost.Text = "0"
                End If
                For i As Integer = 1 To 24
                    dPrices(i) = tboxMonthlyCost.Text
                Next
            End If

            If rdioBtnUniversalP.Checked Then
                Dim universalPrice As Double
                universalPrice = returnString.universalServicePrice()
                For i As Integer = 1 To 24
                    dPrices(i) = universalPrice
                Next
            End If

            If rdiobtnStockPlussMarginal.Checked Then
                Dim mar As Double
                mar = Double.Parse(tbMarginalOfStock.Text)
                For i As Integer = 1 To 24

                    dPrices(i) = dPrices(i) + mar * 10 ' the *10 turns marginal from €/MWh to cents/kWh
                Next
            End If

            'Dim priceAndDate As PriceDateStruct
            Dim records As List(Of PriceDateStruct)
            records = New List(Of PriceDateStruct)

            Dim p As PriceDateStruct

            For i As Integer = 1 To 24 'has to be 1 to 24 because the first bit in both dPrices and dDates is zero(infobit)

                p.price = dPrices(i)
                p.sDate = dDates(i)
                records.Add(p)
                'records(i) = p
            Next

            Dim dgv As New DataGridView()

            For i As Integer = 0 To 23
                'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
                dgv.Columns.Add(0, records(i).sDate & ":00")
            Next




            If rdioFixedPrice.Checked Then
                For i As Integer = 0 To 23
                    dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & " s/kWh" ' or any other number you want to insert
                Next
            Else
                For i As Integer = 0 To 23
                    dgv.Rows(0).Cells(i).Value = (records(i).price / 1000) * 100 & " s/kWh" ' or any other number you want to insert
                Next
            End If

            tblPriceTable.AllowUserToDeleteRows = False 'Allows user to delete rows
            tblPriceTable.ReadOnly = True 'Allows user to edit cells within the data grid
            tblPriceTable.Controls.Add(dgv)

            chart(records)
            'OLD CODE THAT DIDNT USE A LIST OR STRUCT, NOW OBSOLETE LEFT HERE INCASE NEEDED WHEN CREATING DOCUMENTATION

            'Dim timeNowHours As Integer = DateTime.Now.ToString("HH")



            'Dim returnString As PrjDatabaseComponent.IDatabaseAPI
            'returnString = New PrjDatabaseComponent.CDatabase
            'Dim sPrices As String()
            'sPrices = returnString.stockPrice().prices

            'For i As Integer = 1 To 24
            '    sPrices(i) = sPrices(i).Replace(".", ",")
            'Next



            'Dim dgv As New DataGridView()

            'For i As Integer = 0 To 23
            '    'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
            '    If timeNowHours >= 24 Then
            '        timeNowHours = timeNowHours - 24
            '        dgv.Columns.Add(0, timeNowHours & ":00")

            '    Else
            '        dgv.Columns.Add(0, timeNowHours & ":00")

            '    End If
            '    timeNowHours = timeNowHours + 1

            'Next


            'If rdioFixedPrice.Checked Then
            '    For i As Integer = 0 To 23
            '        dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & "€" ' or any other number you want to insert
            '    Next
            'Else
            '    For i As Integer = 0 To 23
            '        dgv.Rows(0).Cells(i).Value = sPrices(i + 1) & "€" ' or any other number you want to insert
            '    Next
            'End If


            'tblPriceTable.Controls.Add(dgv)


            lblTableState.Visible = False
            lblTableState.Text = "Börsihind"


        End If
    End Sub
    Public Function chart(records)
        Dim seriesName As String
        If rdioExchange.Checked = True Then
            seriesName = "Börsihind"
        ElseIf rdiobtnStockPlussMarginal.Checked = True Then
            seriesName = "Börsihind + marginaal"
        ElseIf rdioFixedPrice.Checked = True Then
            seriesName = "Fikseeritud hind"
        ElseIf rdioBtnUniversalP.Checked = True Then
            seriesName = "Universaalhind"
        End If

        chrtPackageHourlyRate.Series.Add(seriesName)
        'chrtFrontPage.ChartAreas(0).AxisY.MajorGrid.Enabled = False 'remove liesn from Y axis
        chrtPackageHourlyRate.ChartAreas(0).AxisX.Interval = 1 'more lines X axis
        chrtPackageHourlyRate.ChartAreas(0).AxisY.Interval = 5 'more lines Y axis
        chrtPackageHourlyRate.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        chrtPackageHourlyRate.Series(0).Color = Color.Red
        chrtPackageHourlyRate.Series(0).BorderWidth = 3


        For i As Integer = 0 To 23

            chrtPackageHourlyRate.Series(seriesName).Points.AddXY(records(i).sDate, records(i).price)

        Next

    End Function

    Public Function userPrefernces(username As String) 'get user prefences from database
        Dim userInfo As PrjDatabaseComponent.ILogin
        userInfo = New PrjDatabaseComponent.CDatabase
        Dim colorOfInterface As String = ""
        Dim sizeofText As Double
        userInfo.userPrefernces(username, sizeofText, colorOfInterface) 'get color and sizeOfText from database
        usernameOfUser = username
        cbColor.Text = colorOfInterface ' right now only set color
    End Function
    Public Function chartFrontPage()

        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        Dim sPrices As String()
        Dim sDates As String()
        Dim dDates As Double() = New Double(24) {}

        Dim dPrices As Double()
        Dim priceDateStruct As New PriceDateStruct()


        returnString = New PrjDatabaseComponent.CDatabase

        sPrices = returnString.stockPrice().prices
        sDates = returnString.stockPrice().dates

        For i As Integer = 1 To 24
            sPrices(i) = sPrices(i).Replace(".", ",")
        Next
        dPrices = New Double(sPrices.Length) {}


        For i As Integer = 1 To sPrices.Length - 1
            dPrices(i) = Double.Parse(sPrices(i))

        Next

        'UNIX NEEDS TO BE CONVERTED TO CONVENTIONAL TIMESTAMP DO BE USABLE
        'dDates = New Double(sDates.Length - 1) {}
        For i As Integer = 1 To 24 'sDates.Length - 1
            ' dDates(i) = Double.Parse(sDates(i))

            'in textbox get one time as string
            Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sDates(i)) 'new datetimeoffset from sDate string
            Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date
            dDates(i) = CDbl(dateValue.Hour) 'convert to integer
            'TextBox1.Text = dDates(i) 'put hour to textbox for testing

        Next

        'Dim priceAndDate As PriceDateStruct
        Dim records As List(Of PriceDateStruct)
        records = New List(Of PriceDateStruct)

        Dim p As PriceDateStruct

        For i As Integer = 1 To 24 'has to be 1 to 24 because the first bit in both dPrices and dDates is zero(infobit)

            p.price = dPrices(i)
            p.sDate = dDates(i)
            records.Add(p)
            'records(i) = p
        Next
        Dim seriesName As String = "Börsihind"
        chrtFrontPage.Series.Add(seriesName)
        'chrtFrontPage.ChartAreas(0).AxisY.MajorGrid.Enabled = False 'remove liesn from Y axis
        chrtFrontPage.ChartAreas(0).AxisX.Interval = 1 'more lines X axis
        chrtFrontPage.ChartAreas(0).AxisY.Interval = 5 'more lines Y axis
        chrtFrontPage.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        chrtFrontPage.Series(0).Color = Color.Red
        chrtFrontPage.Series(0).BorderWidth = 3


        For i As Integer = 0 To 23

            chrtFrontPage.Series(seriesName).Points.AddXY(records(i).sDate, records(i).price)

        Next


        'Dim seriesName As String = "Börsihind"
        'chrtFrontPage.Series.Add(seriesName)
        ''chrtFrontPage.ChartAreas(0).AxisY.MajorGrid.Enabled = False 'remove liesn from Y axis
        'chrtFrontPage.ChartAreas(0).AxisX.Interval = 1 'more lines X axis
        'chrtFrontPage.ChartAreas(0).AxisY.Interval = 5 'more lines Y axis
        'chrtFrontPage.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        'chrtFrontPage.Series(0).Color = Color.Red
        'chrtFrontPage.Series(0).BorderWidth = 3
        'Dim returnString1 As PrjDatabaseComponent.IDatabaseAPI
        'returnString1 = New PrjDatabaseComponent.CDatabase
        'Dim sPrices1 As String()
        'sPrices1 = returnString1.stockPrice().prices
        'Dim dblValues(sPrices1.Length - 1) As Double
        'For i As Integer = 1 To sPrices1.Length - 1
        '    Double.TryParse(sPrices1(i), dblValues(i))
        'Next

        '' Add some data points to the series
        ''Dim values() As Double = {10, 20, 30, 40, 50}
        'For i As Integer = 0 To dblValues.Length - 1
        '    If i <> 0 Then 'there is no info from -1 to 0
        '        chrtFrontPage.Series(seriesName).Points.AddXY(i - 1, sPrices1(i))
        '    End If
        'Next
        'Dim hour23 As Integer = dblValues.Length
        'chrtFrontPage.Series(seriesName).Points.AddXY(hour23 - 1, sPrices1(hour23 - 1)) ' so 23 value would last entire hour
        Dim selectedItem As String = cbColor.SelectedItem


        Select Case selectedItem 'change color based on the item the user choosed
            Case "Punane"
                chrtFrontPage.Series(0).Color = Color.Red

            Case "Sinine"

                chrtFrontPage.Series(0).Color = Color.Blue

            Case "Roheline"

                chrtFrontPage.Series(0).Color = Color.Green

            Case "Roosa"
                Dim myColorDarkPink As Color = Color.FromArgb(252, 10, 167) 'creating dark pink color bc it does not exist
                chrtFrontPage.Series(0).Color = myColorDarkPink 'change chart line color

            Case "Tumehall"

                chrtFrontPage.Series(0).Color = Color.Black

            Case "Valge"

                chrtFrontPage.Series(0).Color = Color.Black

            Case Else

                chrtFrontPage.Series(0).Color = Color.Red

        End Select
    End Function
    Private Sub rdioExchange_CheckedChanged(sender As Object, e As EventArgs) Handles rdioExchange.CheckedChanged
        tboxMonthlyCost.Enabled = False
        tboxMonthlyCost.Clear()
        btnTableAsc.Enabled = True
        btnTableDesc.Enabled = True

        ' Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        'returnString = New PrjDatabaseComponent.CDatabase
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim futureDate As DateTime = DateTime.Now.AddHours(24)
        Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")


        sPrices = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item1
        ' GetDataFromEleringAPIWithDates(ByVal strStartDate As String, ByVal strEndDate As String) As (String(), String())
        ' sPrices = returnString.stockPrice().prices


        'Dim sPricesOut As String = sPrices(1)
        'Double.TryParse(sPrices(1), sPricesOut)
        Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
        Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
        If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then 'do not do this if language is english
            sPrices(1) = sPrices(1).Replace(".", ",")
        End If
        Dim calculateKWH As Double = Double.Parse(sPrices(1))
        'calculateKWH = (calculateKWH / 10) / 100
        calculateKWH = (calculateKWH / 1000) * 100

        tBoxPackageHourlyRate.Text = calculateKWH & " [s/kWh]"

    End Sub

    Private Sub rdioFixedPrice_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFixedPrice.CheckedChanged
        tboxMonthlyCost.Enabled = True
        tBoxPackageHourlyRate.Clear()
        tboxMonthlyCost.Clear()
        btnTableAsc.Enabled = False
        btnTableDesc.Enabled = False
    End Sub

    Private Sub rdioFixedPrice1_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFixedPrice1.CheckedChanged
        tBoxPackagePrice.Enabled = True
        tBoxPackagePrice.Clear()
    End Sub

    Private Sub rdioExchangePrice_CheckedChanged(sender As Object, e As EventArgs) Handles rdioExchangePrice.CheckedChanged
        tBoxPackagePrice.Enabled = False

        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice().prices

        sPrices(24) = sPrices(24).Replace(".", ",")
        Dim calculateKWH As Double = Double.Parse(sPrices(24))
        'calculateKWH = (calculateKWH / 10) / 100
        calculateKWH = (calculateKWH / 1000) * 100

        tBoxPackagePrice.Text = calculateKWH
    End Sub



    Private Sub tabPackageHourlyRate_Enter(sender As Object, e As EventArgs) Handles tabPackageHourlyRate.Enter
        rdioExchange.Checked = True
        lblTableState.Visible = False
        lblBestTime.Visible = False
    End Sub



    Private Sub Main_Enter(sender As Object, e As EventArgs) Handles Main.Enter
        'Dim seriesName As String = "Börsihind"
        'chrFrontPageChart.Series.Add(seriesName)
        'Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        'returnString = New PrjDatabaseComponent.CDatabase
        'Dim sPrices As String()
        'sPrices = returnString.stockPrice()
        'Dim dblValues(sPrices.Length - 1) As Double
        'For i As Integer = 1 To sPrices.Length - 1
        '    Double.TryParse(sPrices(i), dblValues(i))
        'Next

        '' Add some data points to the series
        ''Dim values() As Double = {10, 20, 30, 40, 50}
        'For i As Integer = 0 To dblValues.Length - 1
        '    chrFrontPageChart.Series(seriesName).Points.AddXY(i + 1, sPrices(i))
        'Next
    End Sub





    Private Sub btnChartAsc_Click(sender As Object, e As EventArgs) Handles btnTableAsc.Click
        tblPriceTable.Controls.Clear()
        Dim tbMarginalOfStockLetters As Boolean = checkIfTextBoxContainsLetters(tbMarginalOfStock)
        Dim tboxMonthlyCostLetters As Boolean = checkIfTextBoxContainsLetters(tboxMonthlyCost)

        If tbMarginalOfStockLetters = False Or tboxMonthlyCostLetters = False Then

        Else



            Dim returnString As PrjDatabaseComponent.IDatabase
            Dim sPrices As String()
            Dim sDates As String()
            Dim dDates As Double() = New Double(24) {}

            Dim dPrices As Double()
            Dim priceDateStruct As New PriceDateStruct()


            returnString = New PrjDatabaseComponent.CDatabase

            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim futureDate As DateTime = DateTime.Now.AddHours(24)
            Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")

            sPrices = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item1
            sDates = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item2
            Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
            Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
            If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then 'do not do this if language is english

                For i As Integer = 1 To 24
                    sPrices(i) = sPrices(i).Replace(".", ",")
                Next
            End If

            dPrices = New Double(sPrices.Length) {}

            If rdiobtnStockPlussMarginal.Checked Then
                Dim mar As Double
                mar = Double.Parse(tbMarginalOfStock.Text)
                For i As Integer = 1 To 24
                    dPrices(i) = Double.Parse(sPrices(i)) + mar * 10 ' the *10 turns marginal from €/MWh to cents/kWh
                Next
            Else
                For i As Integer = 1 To sPrices.Length - 1
                    dPrices(i) = Double.Parse(sPrices(i))

                Next
            End If


            'UNIX NEEDS TO BE CONVERTED TO CONVENTIONAL TIMESTAMP DO BE USABLE
            'dDates = New Double(sDates.Length - 1) {}
            For i As Integer = 1 To 24 'sDates.Length - 1
                ' dDates(i) = Double.Parse(sDates(i))

                'in textbox get one time as string
                Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sDates(i)) 'new datetimeoffset from sDate string
                Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date
                dDates(i) = CDbl(dateValue.Hour) 'convert to integer
                'TextBox1.Text = dDates(i) 'put hour to textbox for testing

            Next

            'Dim priceAndDate As PriceDateStruct
            Dim records As List(Of PriceDateStruct)
            records = New List(Of PriceDateStruct)

            Dim p As PriceDateStruct

            For i As Integer = 1 To 24 'has to be 1 to 24 because the first bit in both dPrices and dDates is zero(infobit)

                p.price = dPrices(i)
                p.sDate = dDates(i)
                records.Add(p)
                'records(i) = p
            Next

            'Array.Sort(dPrices) 'dPricesToBeSorted is now sorted :-)
            records.Sort(Function(x, y) x.price.CompareTo(y.price))

            Dim dgv As New DataGridView()

            For i As Integer = 0 To 23
                'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
                dgv.Columns.Add(0, records(i).sDate & ":00")
            Next

            'For i As Integer = 0 To 23
            '    'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
            '    If timeNowHours >= 24 Then
            '        timeNowHours = timeNowHours - 24
            '        dgv.Columns.Add(0, timeNowHours & ":00")

            '    Else
            '        dgv.Columns.Add(0, timeNowHours & ":00")

            '    End If
            '    timeNowHours = timeNowHours + 1

            'Next


            If rdioFixedPrice.Checked Then
                For i As Integer = 0 To 23
                    dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & " s/kWh" ' or any other number you want to insert
                Next
            Else
                For i As Integer = 0 To 23
                    dgv.Rows(0).Cells(i).Value = (records(i).price / 1000) * 100 & " s/kWh" ' or any other number you want to insert
                Next
            End If


            tblPriceTable.Controls.Add(dgv)

            lblTableState.Visible = True
            lblTableState.Text = "Börsihind kasvavalt järjestatud (odavaim -> kalleim)"

            lblBestTime.Visible = True

            lblBestTime.Text = "Kõige odavam tarbimisaeg on " & records(0).sDate & ":00."

        End If

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        'tblCSVfile.Controls.Clear()
        chrtCSV.Series.Clear()

        Dim records As List(Of DateWattageStruct)
        records = New List(Of DateWattageStruct)

        Dim p As DateWattageStruct



        Dim openFileDialog As New OpenFileDialog()
        'Filter to only show CSV files and all files
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"


        'If the user selects a file and presses OK
        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedFileName As String = openFileDialog.FileName

            'TABLE
            Dim table As New DataTable()

            Using parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFileName)
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                parser.SetDelimiters(";")

                Dim headerLinesToSkip As Integer = 9
                For i As Integer = 1 To headerLinesToSkip
                    parser.ReadLine()
                Next


                'Filling ze table
                ' Read the header row and add the columns to the table
                Dim column As Integer = 0
                Dim headerRow As String() = parser.ReadFields()
                For Each header As String In headerRow
                    table.Columns.Add(header)
                    column += 1
                Next
                If column > 2 Then



                    ' Read the data rows and add them to the table
                    While Not parser.EndOfData
                        Dim fields As String() = parser.ReadFields()
                        table.Rows.Add(fields)
                        'p.dateAndTime = fields(0)
                        'p.wattage = fields(2)

                    End While
                    'chrtCSV.Titles.Add("My Chart")

                    'Add a new series to the chart
                    Dim series As New Series()
                    series.Name = "Aeg/Võimsus"
                    series.ChartType = SeriesChartType.Line
                    chrtCSV.Series.Add(series)

                    'Loop through the rows of the DataTable and add data points to the chart series
                    'For Each row As DataRow In table.Rows
                    '    Dim xValue As String = row("Algus").ToString()
                    '    Dim yValue As String = row("Kogus (kWh)").ToString()
                    '    series.Points.AddXY(xValue, yValue)
                    'Next
                    Dim rowCount As Integer = table.Rows.Count
                    Dim rowCountInForEach As Integer = 0

                    If table.Columns(0).ColumnName = "Algus" And table.Columns(2).ColumnName = "Kogus (kWh)" Then

                        'For i As Integer = 0 To 9
                        For Each row As DataRow In table.Rows
                            rowCountInForEach += 1
                            If rowCountInForEach = 24 * 3 Then
                                Exit For
                            End If
                            'Dim row As DataRow = table.Rows(i)

                            Dim xValue As String = row("Algus").ToString()
                            Dim yValue As String = row("Kogus (kWh)").ToString()
                            series.Points.AddXY(xValue, yValue)
                            Dim xAxis As Axis = chrtCSV.ChartAreas(0).AxisX

                            'Set the width of the axis labels

                            chrtCSV.ChartAreas(0).AxisX.Interval = 1


                            'xAxis.LabelStyle.Font = New Font(xAxis.LabelStyle.Font.Name, 8.25)
                            xAxis.LabelStyle.Angle = 90
                        Next

                    Else
                        MessageBox.Show("VALE FORMAAT LOHH!")
                    End If


                Else
                    MessageBox.Show("VALE FORMAAT!")
                End If
            End Using
        End If



    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFileDialog As New SaveFileDialog()

        'Filter to only take CSV files
        saveFileDialog.Filter = "CSV files (*.csv)|*.csv"

        'Initial directory and the name of the file
        saveFileDialog.InitialDirectory = "C:\"
        saveFileDialog.FileName = "exported_data.csv"

        'If the user presses OK
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            'Get the selected file name
            Dim fileName As String = saveFileDialog.FileName

            'Write the CSV data to the selected file
            Using writer As New StreamWriter(fileName)
                writer.WriteLine("Column1,Column2,Column3")
                writer.WriteLine("Value1,Value2,Value3")
                writer.WriteLine("Value4,Value5,Value6")
            End Using

            'Shows a message that the export was successful
            MessageBox.Show("File exported successfully to " & fileName)
        End If
    End Sub

    Private Sub cbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColor.SelectedIndexChanged

        Dim selectedItem As String = cbColor.SelectedItem
        If selectedItem.Length > 0 Then ' if someone who hasnt chosen a color logs in do not change color
            Dim returnString As PrjDatabaseComponent.ILogin
            returnString = New PrjDatabaseComponent.CDatabase
            returnString.updateUserPrefernces(usernameOfUser, selectedItem)
            Select Case selectedItem 'change color based on the item the user choosed
                Case "Punane"
                    Main.BackColor = Color.White
                    Me.BackColor = Color.Crimson
                    'chrtFrontPage.Series(0).Color = Color.Red
                    Dim myColorLightRed As Color = Color.FromArgb(247, 176, 156)
                    myColor = myColorLightRed
                Case "Sinine"
                    Main.BackColor = Color.White
                    Me.BackColor = Color.LightSkyBlue
                    'chrtFrontPage.Series(0).Color = Color.Blue
                    Dim myColorLightBlue As Color = Color.FromArgb(190, 234, 252)
                    myColor = myColorLightBlue
                Case "Roheline"
                    Main.BackColor = Color.White
                    Dim myColorDarkGreen As Color = Color.FromArgb(169, 213, 130)
                    'chrtFrontPage.Series(0).Color = Color.Green
                    Me.BackColor = myColorDarkGreen
                    Dim myColorLightGreen As Color = Color.FromArgb(219, 246, 195)
                    myColor = myColorLightGreen
                Case "Roosa"
                    Main.BackColor = Color.White
                    Me.BackColor = Color.Pink
                    Dim myColorDarkPink As Color = Color.FromArgb(252, 10, 167) 'creating dark pink color bc it does not exist
                    'chrtFrontPage.Series(0).Color = myColorDarkPink 'change chart line color
                    Dim myColorLightPink As Color = Color.FromArgb(254, 210, 238)
                    myColor = myColorLightPink
                Case "Tumehall"
                    Main.BackColor = Color.White
                    Me.BackColor = Color.LightSlateGray
                    'chrtFrontPage.Series(0).Color = Color.Black
                    myColor = Color.White
                Case "Valge"
                    Main.BackColor = Color.White
                    Me.BackColor = Color.White
                    'chrtFrontPage.Series(0).Color = Color.Black
                    myColor = Color.White
                Case Else
                    Me.BackColor = SystemColors.Control ' everything else is light grey
                    'chrtFrontPage.Series(0).Color = Color.Red
                    myColor = Color.White
                    Main.BackColor = SystemColors.Control
            End Select
            btnPackageHourlyRate.BackColor = myColor
            btnApplianceCalc.BackColor = myColor
            btnExchangePriceComparison.BackColor = myColor
            btnConsumptionHistory.BackColor = myColor
            btnPackageComparison.BackColor = myColor
        End If
    End Sub


    Private Sub btnFontIncrease_Click(sender As Object, e As EventArgs) Handles btnFontIncrease.Click
        If fontSize < 11.25 Then
            fontSize = fontSize + 0.5
            'tboxFontSizeTest.Text = fontSize 'REMOVED THIS 
            lblMenu.Font = New Font("Microsoft Sans Serif", fontSize)
            Main.Font = New Font("Microsoft Sans Serif", fontSize)
            tabPackageHourlyRate.Font = New Font("Microsoft Sans Serif", fontSize)
            tabApplianceCalc.Font = New Font("Microsoft Sans Serif", fontSize)
            tabExchangeComparison.Font = New Font("Microsoft Sans Serif", fontSize)
            tabConsumptionHistory.Font = New Font("Microsoft Sans Serif", fontSize)
            tabPackageComparison.Font = New Font("Microsoft Sans Serif", fontSize)
            lblChangeFontSize.Font = New Font("Microsoft Sans Serif", fontSize)
            btnFontIncrease.Font = New Font("Microsoft Sans Serif", fontSize)
            btnFontDecrease.Font = New Font("Microsoft Sans Serif", fontSize)
            btnRestoreFontSize.Font = New Font("Microsoft Sans Serif", fontSize)

            tboxMonthlyCost.Width += 10
            tbMarginalOfStock.Width += 10
            tBoxPackageHourlyRate.Width += 10
            tBoxPackagePrice.Width += 10
            tBoxMarginal.Width += 10
            tBoxConsumptionPerHour.Width += 10
            tBoxUsageTime.Width += 10
            tBoxElectricityConsumptionRate.Width += 10
            tBoxApproxPrice.Width += 10
            tboxStartTime.Width += 10
            tBoxEndTime.Width += 10
            tBoxCondition1.Width += 10
            tBoxCondition2.Width += 10
            tBoxMonthlyCost2.Width += 10
            cBoxPackage1.Width += 10
            cBoxPackage2.Width += 10
            rdioFixedPrice.Width += 10
            rdioBtnUniversalP.Width += 10
            lblSKwh3.Width += 10
            lblSKwh4.Width += 10

            lblSKwh1.Location = New Point(lblSKwh1.Location.X + 10, lblSKwh1.Location.Y)
            lblSKwh2.Location = New Point(lblSKwh2.Location.X + 10, lblSKwh2.Location.Y)
            lblWatt.Location = New Point(lblWatt.Location.X + 10, lblWatt.Location.Y)
            lblMin.Location = New Point(lblMin.Location.X + 10, lblMin.Location.Y)
            lblKwh24h.Location = New Point(lblKwh24h.Location.X + 10, lblKwh24h.Location.Y)
            lblCents.Location = New Point(lblCents.Location.X + 10, lblCents.Location.Y)
            'rdioFixedPrice.Location = New Point(rdioFixedPrice.Location.X + 10, rdioFixedPrice.Location.Y)
            'rdioBtnUniversalP.Location = New Point(rdioBtnUniversalP.Location.X + 14, rdioBtnUniversalP.Location.Y)
            lblSKwh3.Location = New Point(lblSKwh3.Location.X + 20, lblSKwh3.Location.Y)
            lblSKwh4.Location = New Point(lblSKwh4.Location.X + 20, lblSKwh4.Location.Y)
            lblPriceGraph.Location = New Point(lblPriceGraph.Location.X + 13, lblPriceGraph.Location.Y)
            chrtPackageHourlyRate.Location = New Point(chrtPackageHourlyRate.Location.X + 10, chrtPackageHourlyRate.Location.Y)
            tbMarginalOfStock.Location = New Point(tbMarginalOfStock.Location.X + 11, tbMarginalOfStock.Location.Y)
            tboxMonthlyCost.Location = New Point(tboxMonthlyCost.Location.X + 11, tboxMonthlyCost.Location.Y)
        End If



    End Sub

    Private Sub btnFontDecrease_Click(sender As Object, e As EventArgs) Handles btnFontDecrease.Click
        If fontSize > 8.5 Then
            fontSize = fontSize - 0.5
            'tboxFontSizeTest.Text = fontSize 'REMOVED THIS 
            lblMenu.Font = New Font("Microsoft Sans Serif", fontSize)
            Main.Font = New Font("Microsoft Sans Serif", fontSize)
            tabPackageHourlyRate.Font = New Font("Microsoft Sans Serif", fontSize)
            tabApplianceCalc.Font = New Font("Microsoft Sans Serif", fontSize)
            tabExchangeComparison.Font = New Font("Microsoft Sans Serif", fontSize)
            tabConsumptionHistory.Font = New Font("Microsoft Sans Serif", fontSize)
            tabPackageComparison.Font = New Font("Microsoft Sans Serif", fontSize)
            lblChangeFontSize.Font = New Font("Microsoft Sans Serif", fontSize)
            btnFontIncrease.Font = New Font("Microsoft Sans Serif", fontSize)
            btnFontDecrease.Font = New Font("Microsoft Sans Serif", fontSize)
            btnRestoreFontSize.Font = New Font("Microsoft Sans Serif", fontSize)

            tboxMonthlyCost.Width -= 10
            tbMarginalOfStock.Width -= 10
            tBoxPackageHourlyRate.Width -= 10
            tBoxPackagePrice.Width -= 10
            tBoxMarginal.Width -= 10
            tBoxConsumptionPerHour.Width -= 10
            tBoxUsageTime.Width -= 10
            tBoxElectricityConsumptionRate.Width -= 10
            tBoxApproxPrice.Width -= 10
            tboxStartTime.Width -= 10
            tBoxEndTime.Width -= 10
            tBoxCondition1.Width -= 10
            tBoxCondition2.Width -= 10
            tBoxMonthlyCost2.Width -= 10
            cBoxPackage1.Width -= 10
            cBoxPackage2.Width -= 10
            rdioFixedPrice.Width -= 10
            rdioBtnUniversalP.Width -= 10
            lblSKwh3.Width -= 10
            lblSKwh4.Width -= 10

            lblSKwh1.Location = New Point(lblSKwh1.Location.X - 10, lblSKwh1.Location.Y)
            lblSKwh2.Location = New Point(lblSKwh2.Location.X - 10, lblSKwh2.Location.Y)
            lblWatt.Location = New Point(lblWatt.Location.X - 10, lblWatt.Location.Y)
            lblMin.Location = New Point(lblMin.Location.X - 10, lblMin.Location.Y)
            lblKwh24h.Location = New Point(lblKwh24h.Location.X - 10, lblKwh24h.Location.Y)
            lblCents.Location = New Point(lblCents.Location.X - 10, lblCents.Location.Y)
            'rdioFixedPrice.Location = New Point(rdioFixedPrice.Location.X - 10, rdioFixedPrice.Location.Y)
            'rdioBtnUniversalP.Location = New Point(rdioBtnUniversalP.Location.X - 10, rdioBtnUniversalP.Location.Y)
            lblSKwh3.Location = New Point(lblSKwh3.Location.X - 20, lblSKwh3.Location.Y)
            lblSKwh4.Location = New Point(lblSKwh4.Location.X - 20, lblSKwh4.Location.Y)
            lblPriceGraph.Location = New Point(lblPriceGraph.Location.X - 13, lblPriceGraph.Location.Y)
            chrtPackageHourlyRate.Location = New Point(chrtPackageHourlyRate.Location.X - 10, chrtPackageHourlyRate.Location.Y)
            tbMarginalOfStock.Location = New Point(tbMarginalOfStock.Location.X - 11, tbMarginalOfStock.Location.Y)
            tboxMonthlyCost.Location = New Point(tboxMonthlyCost.Location.X - 11, tboxMonthlyCost.Location.Y)
        End If

    End Sub

    Private Sub btnRestoreFontSize_Click(sender As Object, e As EventArgs) Handles btnRestoreFontSize.Click
        If fontSize > 8.25 Then

            Dim fontSizeDiff As Double = fontSize
            fontSizeDiff -= 8.25
            fontSizeDiff = fontSizeDiff * 10 '=30
            'max 6 increments
            Dim coef As Double = (fontSizeDiff / 5)


            fontSize = 8.25
            'tboxFontSizeTest.Text = fontSize 'REMOVED THIS 
            lblMenu.Font = New Font("Microsoft Sans Serif", fontSize)
            Main.Font = New Font("Microsoft Sans Serif", fontSize)
            tabPackageHourlyRate.Font = New Font("Microsoft Sans Serif", fontSize)
            tabApplianceCalc.Font = New Font("Microsoft Sans Serif", fontSize)
            tabExchangeComparison.Font = New Font("Microsoft Sans Serif", fontSize)
            tabConsumptionHistory.Font = New Font("Microsoft Sans Serif", fontSize)
            tabPackageComparison.Font = New Font("Microsoft Sans Serif", fontSize)
            lblChangeFontSize.Font = New Font("Microsoft Sans Serif", fontSize)
            btnFontIncrease.Font = New Font("Microsoft Sans Serif", fontSize)
            btnFontDecrease.Font = New Font("Microsoft Sans Serif", fontSize)
            btnRestoreFontSize.Font = New Font("Microsoft Sans Serif", fontSize)

            tboxMonthlyCost.Width -= 10 * coef
            tbMarginalOfStock.Width -= 10 * coef
            tBoxPackageHourlyRate.Width -= 10 * coef
            tBoxPackagePrice.Width -= 10 * coef
            tBoxMarginal.Width -= 10 * coef
            tBoxConsumptionPerHour.Width -= 10 * coef
            tBoxUsageTime.Width -= 10 * coef
            tBoxElectricityConsumptionRate.Width -= 10 * coef
            tBoxApproxPrice.Width -= 10 * coef
            tboxStartTime.Width -= 10 * coef
            tBoxEndTime.Width -= 10 * coef
            tBoxCondition1.Width -= 10 * coef
            tBoxCondition2.Width -= 10 * coef
            tBoxMonthlyCost2.Width -= 10 * coef
            cBoxPackage1.Width -= 10 * coef
            cBoxPackage2.Width -= 10 * coef
            rdioFixedPrice.Width -= 10 * coef
            rdioBtnUniversalP.Width -= 10 * coef
            lblSKwh3.Width -= 10 * coef
            lblSKwh4.Width -= 10 * coef

            lblSKwh1.Location = New Point(lblSKwh1.Location.X - 10 * coef, lblSKwh1.Location.Y)
            lblSKwh2.Location = New Point(lblSKwh2.Location.X - 10 * coef, lblSKwh2.Location.Y)
            lblWatt.Location = New Point(lblWatt.Location.X - 10 * coef, lblWatt.Location.Y)
            lblMin.Location = New Point(lblMin.Location.X - 10 * coef, lblMin.Location.Y)
            lblKwh24h.Location = New Point(lblKwh24h.Location.X - 10 * coef, lblKwh24h.Location.Y)
            lblCents.Location = New Point(lblCents.Location.X - 10 * coef, lblCents.Location.Y)
            'rdioFixedPrice.Location = New Point(rdioFixedPrice.Location.X - 10 * coef, rdioFixedPrice.Location.Y)
            'rdioBtnUniversalP.Location = New Point(rdioBtnUniversalP.Location.X - 10 * coef, rdioBtnUniversalP.Location.Y)
            lblSKwh3.Location = New Point(lblSKwh3.Location.X - 20 * coef, lblSKwh3.Location.Y)
            lblSKwh4.Location = New Point(lblSKwh4.Location.X - 20 * coef, lblSKwh4.Location.Y)
            lblPriceGraph.Location = New Point(lblPriceGraph.Location.X - 13 * coef, lblPriceGraph.Location.Y)
            chrtPackageHourlyRate.Location = New Point(chrtPackageHourlyRate.Location.X - 10 * coef, chrtPackageHourlyRate.Location.Y)
            tbMarginalOfStock.Location = New Point(tbMarginalOfStock.Location.X - 11 * coef, tbMarginalOfStock.Location.Y)
            tboxMonthlyCost.Location = New Point(tboxMonthlyCost.Location.X - 11 * coef, tboxMonthlyCost.Location.Y)

        End If
    End Sub

    Private Sub rdioUniversalPackage_CheckedChanged(sender As Object, e As EventArgs) Handles rdioUniversalPackage.CheckedChanged
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim universalPrice As Double = returnString.universalServicePrice
        tBoxPackagePrice.Text = universalPrice
        tBoxPackagePrice.Enabled = False
    End Sub



    Private Sub rdioStockPlusMore_CheckedChanged(sender As Object, e As EventArgs) Handles radioStockPlusMore.CheckedChanged
        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice().prices

        sPrices(24) = sPrices(24).Replace(".", ",")
        Dim calculateKWH As Double = Double.Parse(sPrices(24))
        'calculateKWH = (calculateKWH / 10) / 100 'Old one by laura
        calculateKWH = (calculateKWH / 1000) * 100 'takes the MWh/€ value from the database
        'divides by a 1000 to get kWh and multiplies by a 100 to get cents
        If checkIfTextBoxContainsLetters(tBoxMarginal) = True Then
            Dim sum As Double = calculateKWH + Double.Parse(tBoxMarginal.Text)

            ' Convert sum to a string and display the result
            ' Dim result As String = sum.ToString()

            tBoxPackagePrice.Text = sum
        End If
    End Sub

    Private Sub tBoxMarginal_TextChanged(sender As Object, e As EventArgs) Handles tBoxMarginal.TextChanged
        If tBoxMarginal.TextLength > 0 Then
            If radioStockPlusMore.Enabled = True Then
                Dim returnString As PrjDatabaseComponent.IDatabaseAPI
                returnString = New PrjDatabaseComponent.CDatabase
                Dim sPrices As String()
                sPrices = returnString.stockPrice().prices

                Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
                Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
                If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then
                    sPrices(24) = sPrices(24).Replace(".", ",")
                End If

                Dim calculateKWH As Double = Double.Parse(sPrices(24))
                'calculateKWH = (calculateKWH / 10) / 100
                calculateKWH = (calculateKWH / 1000) * 100
                If checkIfTextBoxContainsLetters(tBoxMarginal) = True Then
                    Dim sum As Double = calculateKWH + Double.Parse(tBoxMarginal.Text)

                    ' Convert sum to a string and display the result
                    ' Dim result As String = sum.ToString()

                    tBoxPackagePrice.Text = sum
                End If
            End If
            radioStockPlusMore.Enabled = True
        End If

    End Sub

    Private Sub GUIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioStockPlusMore.Enabled = False
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-EN")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblKwh24h.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSKwh2.Click

    End Sub

    Private Sub btnPackets_Click(sender As Object, e As EventArgs) Handles btnPackets.Click

        chartPackages.Series.Clear()
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim count As Integer
        count = returnString.electricityPackagesCount 'find out how many packages there are
        Dim packages = returnString.electricityPackagesInfo
        'chrtFrontPage.ChartAreas(0).AxisY.MajorGrid.Enabled = False 'remove liesn from Y axis
        Dim rand As New Random()
        For j As Integer = 0 To (count - 1)

            Dim series As New Series(packages.Item1(j)) ' create a new series with the package name
            chartPackages.Series.Add(series)
            Dim currentHour As Integer = DateTime.Now.Hour
            chartPackages.ChartAreas(0).AxisX.Interval = 1 'more lines X axis
            chartPackages.ChartAreas(0).AxisY.Interval = 5 'more lines Y axis
            series.ChartType = DataVisualization.Charting.SeriesChartType.StepLine
            Dim r As Integer = rand.Next(0, 256)
            Dim g As Integer = rand.Next(0, 256)
            Dim b As Integer = rand.Next(0, 256)
            chartPackages.ChartAreas(0).AxisX.LabelStyle.Format = "t"
            'Chart1.ChartAreas("ChartArea1").AxisX.Interval = interval
            'Chart1.ChartAreas("ChartArea1").AxisX.Minimum = startDate
            'Chart1.ChartAreas("ChartArea1").AxisX.Maximum = endDate

            ' Create a new color object using the random RGB values
            Dim colorofLine As Color = Color.FromArgb(r, g, b)
            series.Color = colorofLine
            series.BorderWidth = 3
            'all the packages are right except Muutuv 
            Dim returnString2 As PrjDatabaseComponent.IDatabaseAPI
            returnString2 = New PrjDatabaseComponent.CDatabase
            Dim data = returnString2.stockPrice
            If Not packages.Item5(j) Then
                Dim hour2(24) As Integer

                For k As Integer = 1 To 24
                    Dim unixTimestamp As Long = Long.Parse(data.dates(k))

                    Dim dateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimestamp)

                Next
                For i As Integer = 1 To 24

                    series.Points.AddXY(data.dates(i), packages.Item3(j))


                Next 'the packet does not have fixed price
            Else


                'Dim hour2(24) As Integer

                'For k As Integer = 1 To 24
                '    Dim unixTimestamp As Long = Long.Parse(data.dates(k))

                '    Dim dateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimestamp)
                '    hour2(k) = dateTime.Hour
                'Next
                For i As Integer = 1 To 24
                    Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(data.dates(i)) 'new datetimeoffset from sDate string
                    Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date


                    ' Get the UTC+2 time zone
                    '  Dim timeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time")

                    ' Convert DateTimeOffset object to UTC+3 timezone
                    ' Dim convertedTime As DateTimeOffset = TimeZoneInfo.ConvertTime(dateTimeOffset, timeZone)

                    Dim hour As Integer = dateValue.Hour
                    Dim price As Double
                    Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
                    Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
                    If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then
                        data.prices(i) = data.prices(i).Replace(".", ",")
                        'packages.Item3(j) = packages.Item3(j).Replace(".-", ",")
                    End If
                    Dim pricesD As Double = Double.Parse(data.prices(i))
                    price = pricesD + packages.Item3(j)

                    ' series.Points.AddXY(hour, price)
                    chartPackages.Series(j).Points.AddXY(data.dates(i), price)

                Next
            End If
        Next
    End Sub

    Private Sub btnTableDesc_Click(sender As Object, e As EventArgs) Handles btnTableDesc.Click
        tblPriceTable.Controls.Clear()

        Dim tbMarginalOfStockLetters As Boolean = checkIfTextBoxContainsLetters(tbMarginalOfStock)
        Dim tboxMonthlyCostLetters As Boolean = checkIfTextBoxContainsLetters(tboxMonthlyCost)

        If tbMarginalOfStockLetters = False Or tboxMonthlyCostLetters = False Then

        Else

            Dim returnString As PrjDatabaseComponent.IDatabase
            Dim sPrices As String()
            Dim sDates As String()
            Dim dDates As Double() = New Double(24) {}

            Dim dPrices As Double()
            Dim priceDateStruct As New PriceDateStruct()


            returnString = New PrjDatabaseComponent.CDatabase

            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim futureDate As DateTime = DateTime.Now.AddHours(24)
            Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")

            sPrices = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item1
            sDates = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item2
            Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
            Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
            If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then 'do not do this if language is english
                For i As Integer = 1 To 24
                    sPrices(i) = sPrices(i).Replace(".", ",")
                Next
            End If
            dPrices = New Double(sPrices.Length) {}


            If rdiobtnStockPlussMarginal.Checked Then
                Dim mar As Double
                mar = Double.Parse(tbMarginalOfStock.Text)
                For i As Integer = 1 To 24
                    dPrices(i) = Double.Parse(sPrices(i)) + mar * 10 ' the *10 turns marginal from €/MWh to cents/kWh
                Next
            Else
                For i As Integer = 1 To sPrices.Length - 1
                    dPrices(i) = Double.Parse(sPrices(i))

                Next
            End If

            'UNIX NEEDS TO BE CONVERTED TO CONVENTIONAL TIMESTAMP DO BE USABLE
            'dDates = New Double(sDates.Length - 1) {}
            For i As Integer = 1 To 24 'sDates.Length - 1
                ' dDates(i) = Double.Parse(sDates(i))

                'in textbox get one time as string
                Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sDates(i)) 'new datetimeoffset from sDate string
                Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date
                dDates(i) = CDbl(dateValue.Hour) 'convert to integer
                'TextBox1.Text = dDates(i) 'put hour to textbox for testing

            Next

            'Dim priceAndDate As PriceDateStruct
            Dim records As List(Of PriceDateStruct)
            records = New List(Of PriceDateStruct)

            Dim p As PriceDateStruct

            For i As Integer = 1 To 24 'has to be 1 to 24 because the first bit in both dPrices and dDates is zero(infobit)

                p.price = dPrices(i)
                p.sDate = dDates(i)
                records.Add(p)
                'records(i) = p
            Next

            'Array.Sort(dPrices) 'dPricesToBeSorted is now sorted ascending:-)
            records.Sort(Function(x, y) y.price.CompareTo(x.price))

            Dim dgv As New DataGridView()

            For i As Integer = 0 To 23
                'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
                dgv.Columns.Add(0, records(i).sDate & ":00")
            Next


            If rdioFixedPrice.Checked Then
                For i As Integer = 0 To 23
                    dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & " s/kWh" ' or any other number you want to insert
                Next
            Else
                For i As Integer = 0 To 23
                    dgv.Rows(0).Cells(i).Value = (records(i).price / 1000) * 100 & " s/kWh" ' or any other number you want to insert
                Next
            End If


            tblPriceTable.Controls.Add(dgv)

            lblTableState.Visible = True
            lblTableState.Text = "Börsihind kahanevalt järjestatud (kalleim -> odavaim)"

            lblBestTime.Visible = True

            lblBestTime.Text = "Kõige kalleim tarbimisaeg on " & records(0).sDate & ":00."

        End If
    End Sub

    Private Sub rdiobtnStockPlussMarginal_CheckedChanged(sender As Object, e As EventArgs) Handles rdiobtnStockPlussMarginal.CheckedChanged
        btnTableAsc.Enabled = True
        btnTableDesc.Enabled = True
        tboxMonthlyCost.Clear()
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Dim strStartTime As String = startTime.ToString("yyyy-MM-dd HH:mm:ss")
        ' Dim strEndTime As String = endTime.ToString("yyyy-MM-dd HH:mm:ss")
        Dim futureDate As DateTime = DateTime.Now.AddHours(24)
        Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")


        sPrices = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item1

        Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
        Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op
        If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then 'do not do this if language is english
            sPrices(1) = sPrices(1).Replace(".", ",")
        End If
        Dim calculateKWH As Double = Double.Parse(sPrices(1))

        calculateKWH = (calculateKWH / 1000) * 100 'takes the MWh/€ value from the database
        'divides by a 1000 to get kWh and multiplies by a 100 to get cents
        If checkIfTextBoxContainsLetters(tbMarginalOfStock) = True Then

            If tbMarginalOfStock.Text = "" Then
                Dim sum1 As String = calculateKWH + 0 & " [s/kWh]"
                tBoxPackageHourlyRate.Text = sum1

            Else
                Dim sum2 As String = calculateKWH + Double.Parse(tbMarginalOfStock.Text) & " [s/kWh]"
                tBoxPackageHourlyRate.Text = sum2

            End If


            ' Convert sum to a string and display the result
            ' Dim result As String = sum.ToString()



        End If
    End Sub

    Private Sub rdioBtnUniversalP_CheckedChanged(sender As Object, e As EventArgs) Handles rdioBtnUniversalP.CheckedChanged
        tboxMonthlyCost.Clear()
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim universalPrice As Double = returnString.universalServicePrice
        'tboxMonthlyCost.Text = universalPrice & " [s/kWh]"
        tboxMonthlyCost.Enabled = False
    End Sub

    Private Sub tbMarginalOfStock_TextChanged(sender As Object, e As EventArgs) Handles tbMarginalOfStock.TextChanged
        If tbMarginalOfStock.TextLength > 0 Then
            rdiobtnStockPlussMarginal.Enabled = True
            If rdiobtnStockPlussMarginal.Checked = True Then
                Dim returnString As PrjDatabaseComponent.IDatabase
                returnString = New PrjDatabaseComponent.CDatabase
                Dim sPrices As String()

                Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim futureDate As DateTime = DateTime.Now.AddHours(24)
                Dim futureDateString As String = futureDate.ToString("yyyy-MM-dd HH:mm:ss")

                sPrices = returnString.getStockPriceAndDatesFromDatabaseFuture(currentDate, futureDateString).Item1
                Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
                Dim language As String = culture.TwoLetterISOLanguageName ' find out language of windows op

                If String.Equals(language, "et", StringComparison.OrdinalIgnoreCase) Then
                    sPrices(1) = sPrices(1).Replace(".", ",")
                End If
                Dim sPrice1 As Double = Double.Parse(sPrices(1))
                Dim calculateKWH As Double = sPrice1

                calculateKWH = (calculateKWH / 1000) * 100
                If checkIfTextBoxContainsLetters(tBoxMarginal) = True Then
                    'Dim sum As Double = calculateKWH + Double.Parse(tbMarginalOfStock.Text)

                    ' Convert sum to a string and display the result
                    ' Dim result As String = sum.ToString()

                    If tbMarginalOfStock.Text = "" Then
                        Dim sum1 As String = calculateKWH + 0 & " [s/kWh]"
                        tBoxPackageHourlyRate.Text = sum1
                    Else
                        Dim sum2 As String = calculateKWH + Double.Parse(tbMarginalOfStock.Text) & " [s/kWh]"
                        tBoxPackageHourlyRate.Text = sum2
                    End If
                End If
            End If

        Else
            rdiobtnStockPlussMarginal.Enabled = False
        End If
    End Sub

    Private Sub tabPackageHourlyRate_Click(sender As Object, e As EventArgs) Handles tabPackageHourlyRate.Click

    End Sub

    Private Sub btnImportCSVFileSimu_Click(sender As Object, e As EventArgs) Handles btnImportCSVFileSimu.Click
        'tblCSVfile.Controls.Clear()
        chrtCSV.Series.Clear()





        Dim openFileDialog As New OpenFileDialog()

        'Filter to only show CSV files and all files
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"


        'If the user selects a file and presses OK
        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedFileName As String = openFileDialog.FileName

            If btnConfirmSimuCSV.Focused = True Then
                Dim table As New DataTable()

                Using parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFileName)
                    parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                    parser.SetDelimiters(";")

                    Dim headerLinesToSkip As Integer = 9
                    For i As Integer = 1 To headerLinesToSkip
                        parser.ReadLine()
                    Next


                    'Filling ze table
                    ' Read the header row and add the columns to the table
                    Dim column As Integer = 0
                    Dim headerRow As String() = parser.ReadFields()
                    For Each header As String In headerRow
                        table.Columns.Add(header)
                        column += 1
                    Next
                    If column > 2 Then



                        ' Read the data rows and add them to the table
                        While Not parser.EndOfData
                            Dim fields As String() = parser.ReadFields()
                            table.Rows.Add(fields)
                            'p.dateAndTime = fields(0)
                            'p.wattage = fields(2)

                        End While


                        dtpBeginning.Enabled = True
                        dtpEnd.Enabled = True


                        Dim rowCount As Integer = table.Rows.Count
                        Dim rowCountInForEach As Integer = 0

                        If table.Columns(0).ColumnName = "Algus" And table.Columns(2).ColumnName = "Kogus (kWh)" _
                        And table.Columns(1).ColumnName = "Lõpp" And table.Columns(3).ColumnName = "Börsihind (EUR / MWh)" Then

                            'For i As Integer = 0 To 9
                            For Each row As DataRow In table.Rows

                                If rowCountInForEach = (24 * 3) + 1 Then
                                    Exit For
                                End If
                                'Dim row As DataRow = table.Rows(i)

                                'if current row is the first row then set minDate for  dtpBeginning
                                If rowCountInForEach = 0 Then
                                    dtpBeginning.MinDate = DateTime.Parse(row("Algus"))
                                    dtpBeginning.Value = DateTime.Parse(row("Algus"))
                                    'MsgBox("minDate for  dtpBeginning" & row("Algus"))
                                End If
                                'if current row is the second row in the table then set minDate for  dtpEnd
                                If rowCountInForEach = 1 Then
                                    dtpEnd.MinDate = DateTime.Parse(row("Lõpp"))
                                    dtpEnd.Value = DateTime.Parse(row("Lõpp"))
                                    'MsgBox("minDate for  dtpEnd" & row("Lõpp"))
                                End If
                                'if current row count is the row BEFORE the last row then set maxDate for dtpBeginning

                                If rowCountInForEach = rowCount - 2 Then 'has to be -2 because rowCountInForEach starts off as 0
                                    dtpBeginning.MaxDate = DateTime.Parse(row("Algus"))
                                    'MsgBox("maxDate for dtpBeginning" & row("Algus"))
                                End If
                                'if current row is the last row in the table then set maxDate for dtpEnd
                                If row Is table.Rows(rowCount - 1) Then
                                    dtpEnd.MaxDate = DateTime.Parse(row("Lõpp"))
                                    'MsgBox("maxDate for dtpEnd" & row("Lõpp"))
                                End If


                                '
                                rowCountInForEach += 1
                            Next
                            dtpBeginning.Value = dtpBeginning.MinDate
                            dtpEnd.Value = dtpEnd.MaxDate

                            Dim sumKWh As Double
                            Dim sumPrice As Double
                            Dim divider As Integer = 0
                            'MOCK CALCULATOR BECAUSE PAIN :'(
                            For Each row As DataRow In table.Rows
                                'ADD UP ALL THE QUANTITY(kWh)
                                sumKWh += Double.Parse(row("Kogus (kWh)"))


                                'ADD UP ALL THE PRICES
                                sumPrice += Double.Parse(row("Börsihind (EUR / MWh)"))
                                tbDebug.AppendText(Environment.NewLine & sumKWh & sumPrice)
                                'tbDebug.Text = sumKWh & sumPrice
                                divider += 1
                            Next
                            'While row("Algus").ToString() = 
                            'Median price of kWh for the WHOLE CSV FILE!!!!! WORK IN PROGRESS
                            sumPrice = sumPrice / divider
                            'sumPrice now in cents per kWh
                            sumPrice = (sumPrice / 1000) * 100
                            tbDebug.AppendText(Environment.NewLine & "Kokku: " & sumKWh & " kWh ja keskmine kWh hind " & sumPrice & " senti/kWh.")




                        Else
                            MessageBox.Show("VALE FORMAAT LOHH!")
                        End If


                    Else
                        MessageBox.Show("VALE FORMAAT!")

                    End If
                End Using
            End If
            'TABLE

        End If







    End Sub


End Class
