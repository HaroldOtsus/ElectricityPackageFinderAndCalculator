

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
        'Dim timeNowHours As Integer = DateTime.Now.ToString("HH")



        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        Dim sPrices As String()
        Dim sDates As String()
        Dim dDates As Double() = New Double(24) {}

        Dim dPrices As Double()
        'Dim priceDateStruct As New PriceDateStruct() if the code works then this can be deleted


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

        Dim dgv As New DataGridView()

        For i As Integer = 0 To 23
            'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
            dgv.Columns.Add(0, records(i).sDate & ":00")
        Next




        If rdioFixedPrice.Checked Then
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & "€" ' or any other number you want to insert
            Next
        Else
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = records(i).price & "€" ' or any other number you want to insert
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




    End Sub
    Public Function chart(records)

        Dim seriesName As String = "Börsihind"
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
    End Function
    Private Sub rdioExchange_CheckedChanged(sender As Object, e As EventArgs) Handles rdioExchange.CheckedChanged
        tboxMonthlyCost.Enabled = False

        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice().prices


        'Dim sPricesOut As String = sPrices(1)
        'Double.TryParse(sPrices(1), sPricesOut)
        sPrices(24) = sPrices(24).Replace(".", ",")
        Dim calculateKWH As Double = Double.Parse(sPrices(24))
        calculateKWH = (calculateKWH / 10) / 100

        tBoxPackageHourlyRate.Text = calculateKWH
    End Sub

    Private Sub rdioFixedPrice_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFixedPrice.CheckedChanged
        tboxMonthlyCost.Enabled = True
        tBoxPackageHourlyRate.Clear()
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
        calculateKWH = (calculateKWH / 10) / 100

        tBoxPackagePrice.Text = calculateKWH
    End Sub



    Private Sub tabPackageHourlyRate_Enter(sender As Object, e As EventArgs) Handles tabPackageHourlyRate.Enter
        rdioExchange.Checked = True
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
        Dim timeNowHours As Integer = DateTime.Now.ToString("HH")



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
                dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & "€" ' or any other number you want to insert
            Next
        Else
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = records(i).price & "€" ' or any other number you want to insert
            Next
        End If


        tblPriceTable.Controls.Add(dgv)

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

                    'tblCSVfile.Controls.Add(table)
                    'Dim myArray(tblCSVfile.Rows.Count - 1) As String
                    'Dim check As String = (tblCSVfile.Rows.Count - 1).ToString
                    'tbControl11.Text = check

                    'For i As Integer = 0 To tblCSVfile.Rows.Count - 1
                    '    ' Get the value of the cell in the desired column for this row
                    '    myArray(i) = tblCSVfile.Rows(i).Cells("Algus").Value.ToString()
                    '    ' tbControl11.Text = myArray(i)
                    '    tbControl11.Text = "check"
                    'Next



                    'GRAPH
                    'Dim seriesName As String = "CSV hind"
                    'chrtCSV.Series.Add(seriesName)

                    'chrtCSV.ChartAreas(0).AxisX.Interval = 1 'more lines X axis
                    'chrtCSV.ChartAreas(0).AxisY.Interval = 5 'more lines Y axis
                    'chrtCSV.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
                    'chrtCSV.Series(0).Color = Color.Red
                    'chrtCSV.Series(0).BorderWidth = 3


                    'For Each row As DataGridViewRow In tblCSVfile.Rows
                    '    TextBox1 += row
                    '    chrtCSV.Series(seriesName).Points.AddXY(row)
                    'Next

                    ' Dim j As Integer = 0
                    'For Each row As DataGridViewRow In tblCSVfile.Rows
                    '    ' Cast the row to a DataGridViewRow object to access its properties
                    '    Dim dgvRow As DataGridViewRow = CType(row, DataGridViewRow)

                    '    ' Access the values of the cells in the row using the cell indices
                    '    Dim cell1Value As String = dgvRow.Cells(0).Value.ToString()
                    '    Dim cell3Value As Double = Convert.ToDouble(dgvRow.Cells(3).Value)
                    '    chrtCSV.Series(seriesName).Points.AddXY(j, cell3Value)
                    '    j += 1
                    '    ' ...
                    'Next



                    'tblCSVfile.DefaultCellStyle.WrapMode = DataGridViewTriState.True 'set word wrap to true
                    'tblCSVfile.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells 'adjust row height based on content

                    'tblCSVfile.Columns(1).Width = 100 'set the width of the first column
                    'tblCSVfile.Columns(2).Width = 150 'set the width of the second column
                    'tblCSVfile.Columns(3).Width = 200 'set the width of the third column
                    'tblCSVfile.Columns(4).Width = 200 'set the width of the third column
                Else
                    MessageBox.Show("VALE FORMAAT!")
                End If
            End Using





            'Using streamReader As New StreamReader(openFileDialog.FileName)
            '    'Reads until the end of the file
            '    While Not streamReader.EndOfStream
            '        'Variable "line" contains 1 line from the CSV file
            '        Dim line As String = streamReader.ReadLine()

            '        'Data processing code goes here

            '        'Currently just using console print for debugging
            '        'Console.WriteLine(line)
            '        tBoxCSVout.Text += line
            '    End While
            'End Using
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


        Select Case selectedItem 'change color based on the item the user choosed
            Case "Punane"
                Main.BackColor = Color.White
                Me.BackColor = Color.Crimson
                chrtFrontPage.Series(0).Color = Color.Red
                Dim myColorLightRed As Color = Color.FromArgb(247, 176, 156)
                myColor = myColorLightRed
            Case "Sinine"
                Main.BackColor = Color.White
                Me.BackColor = Color.LightSkyBlue
                chrtFrontPage.Series(0).Color = Color.Blue
                Dim myColorLightBlue As Color = Color.FromArgb(190, 234, 252)
                myColor = myColorLightBlue
            Case "Roheline"
                Main.BackColor = Color.White
                Dim myColorDarkGreen As Color = Color.FromArgb(169, 213, 130)
                chrtFrontPage.Series(0).Color = Color.Green
                Me.BackColor = myColorDarkGreen
                Dim myColorLightGreen As Color = Color.FromArgb(219, 246, 195)
                myColor = myColorLightGreen
            Case "Roosa"
                Main.BackColor = Color.White
                Me.BackColor = Color.Pink
                Dim myColorDarkPink As Color = Color.FromArgb(252, 10, 167) 'creating dark pink color bc it does not exist
                chrtFrontPage.Series(0).Color = myColorDarkPink 'change chart line color
                Dim myColorLightPink As Color = Color.FromArgb(254, 210, 238)
                myColor = myColorLightPink
            Case "Tumehall"
                Main.BackColor = Color.White
                Me.BackColor = Color.LightSlateGray
                chrtFrontPage.Series(0).Color = Color.Black
                myColor = Color.White
            Case "Valge"
                Main.BackColor = Color.White
                Me.BackColor = Color.White
                chrtFrontPage.Series(0).Color = Color.Black
                myColor = Color.White
            Case Else
                Me.BackColor = SystemColors.Control ' everything else is light grey
                chrtFrontPage.Series(0).Color = Color.Red
                myColor = Color.White
                Main.BackColor = SystemColors.Control
        End Select
        btnPackageHourlyRate.BackColor = myColor
        btnApplianceCalc.BackColor = myColor
        btnExchangePriceComparison.BackColor = myColor
        btnConsumptionHistory.BackColor = myColor
        btnPackageComparison.BackColor = myColor

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


            lblSKwh1.Location = New Point(lblSKwh1.Location.X + 10, lblSKwh1.Location.Y)
            lblSKwh2.Location = New Point(lblSKwh2.Location.X + 10, lblSKwh2.Location.Y)
            lblWatt.Location = New Point(lblWatt.Location.X + 10, lblWatt.Location.Y)
            lblMin.Location = New Point(lblMin.Location.X + 10, lblMin.Location.Y)
            lblKwh24h.Location = New Point(lblKwh24h.Location.X + 10, lblKwh24h.Location.Y)
            lblCents.Location = New Point(lblCents.Location.X + 10, lblCents.Location.Y)
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
        End If

    End Sub

    Private Sub btnRestoreFontSize_Click(sender As Object, e As EventArgs) Handles btnRestoreFontSize.Click
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

        tboxMonthlyCost.Width -= 60
        tBoxPackageHourlyRate.Width -= 60
        tBoxPackagePrice.Width -= 60
        tBoxMarginal.Width -= 60
        tBoxConsumptionPerHour.Width -= 60
        tBoxUsageTime.Width -= 60
        tBoxElectricityConsumptionRate.Width -= 60
        tBoxApproxPrice.Width -= 60
        tboxStartTime.Width -= 60
        tBoxEndTime.Width -= 60
        tBoxCondition1.Width -= 60
        tBoxCondition2.Width -= 60
        tBoxMonthlyCost2.Width -= 60
        cBoxPackage1.Width -= 60
        cBoxPackage2.Width -= 60
    End Sub

    Private Sub rdioUniversalPackage_CheckedChanged(sender As Object, e As EventArgs) Handles rdioUniversalPackage.CheckedChanged
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim universalPrice As Double = returnString.universalServicePrice
        tBoxPackagePrice.Text = universalPrice
        tBoxPackagePrice.Enabled = False
    End Sub

    Private Sub tBoxPackagePrice_TextChanged(sender As Object, e As EventArgs) Handles tBoxPackagePrice.TextChanged

    End Sub

    Private Sub rdioStockPlusMore_CheckedChanged(sender As Object, e As EventArgs) Handles radioStockPlusMore.CheckedChanged
        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice().prices

        sPrices(24) = sPrices(24).Replace(".", ",")
        Dim calculateKWH As Double = Double.Parse(sPrices(24))
        calculateKWH = (calculateKWH / 10) / 100
        If checkIfTextBoxContainsLetters(tBoxMarginal) = True Then
            Dim sum As Integer = calculateKWH + Double.Parse(tBoxMarginal.Text)

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

                sPrices(24) = sPrices(24).Replace(".", ",")
                Dim calculateKWH As Double = Double.Parse(sPrices(24))
                calculateKWH = (calculateKWH / 10) / 100
                If checkIfTextBoxContainsLetters(tBoxMarginal) = True Then
                    Dim sum As Integer = calculateKWH + Double.Parse(tBoxMarginal.Text)

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
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblKwh24h.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSKwh2.Click

    End Sub

    Private Sub btnPackets_Click(sender As Object, e As EventArgs) Handles btnPackets.Click


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
            chartPackages.ChartAreas(0).AxisX.Interval = 1 'more lines X axis
            chartPackages.ChartAreas(0).AxisY.Interval = 5 'more lines Y axis
            series.ChartType = DataVisualization.Charting.SeriesChartType.StepLine
            Dim r As Integer = rand.Next(0, 256)
            Dim g As Integer = rand.Next(0, 256)
            Dim b As Integer = rand.Next(0, 256)

            ' Create a new color object using the random RGB values
            Dim colorofLine As Color = Color.FromArgb(r, g, b)
            series.Color = colorofLine
            series.BorderWidth = 3
            'all the packages are right except Muutuv 
            If Not packages.Item5(j) Then
                'get local time
                ' Dim currentHour As Integer = DateTime.Now.Hour
                For i As Integer = 0 To 23

                    series.Points.AddXY(i, packages.Item3(j))


                Next 'the packet does not have fixed price
            Else
                Dim returnString2 As PrjDatabaseComponent.IDatabaseAPI
                returnString2 = New PrjDatabaseComponent.CDatabase
                Dim data = returnString2.stockPrice
                For i As Integer = 1 To 24
                    Dim dateTimeOffset As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(data.dates(i)) 'new datetimeoffset from sDate string
                    Dim dateValue As Date = dateTimeOffset.LocalDateTime 'convert to date


                    ' Get the UTC+2 time zone
                    Dim timeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time")

                    ' Convert DateTimeOffset object to UTC+3 timezone
                    Dim convertedTime As DateTimeOffset = TimeZoneInfo.ConvertTime(dateTimeOffset, timeZone)

                    Dim hour As Integer = convertedTime.Hour
                    Dim price As Integer
                    price = data.prices(i) + packages.Item3(j)

                    series.Points.AddXY(hour, price)

                Next
            End If
        Next
    End Sub

    Private Sub btnTableDesc_Click(sender As Object, e As EventArgs) Handles btnTableDesc.Click
        tblPriceTable.Controls.Clear()

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

        'Array.Sort(dPrices) 'dPricesToBeSorted is now sorted ascending:-)
        records.Sort(Function(x, y) y.price.CompareTo(x.price))

        Dim dgv As New DataGridView()

        For i As Integer = 0 To 23
            'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
            dgv.Columns.Add(0, records(i).sDate & ":00")
        Next


        If rdioFixedPrice.Checked Then
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & "€" ' or any other number you want to insert
            Next
        Else
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = records(i).price & "€" ' or any other number you want to insert
            Next
        End If


        tblPriceTable.Controls.Add(dgv)
    End Sub

    Private Sub rdiobtnStockPlussMarginal_CheckedChanged(sender As Object, e As EventArgs) Handles rdiobtnStockPlussMarginal.CheckedChanged

    End Sub

    Private Sub rdioBtnUniversalP_CheckedChanged(sender As Object, e As EventArgs) Handles rdioBtnUniversalP.CheckedChanged

    End Sub
End Class
