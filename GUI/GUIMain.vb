﻿

Public Class GUIMain

    Dim applianceID As String

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
        btnConfirm.Enabled = True
    End Sub


    Private Sub btnSisesta_Click(sender As Object, e As EventArgs) Handles btnSisesta.Click
        tBoxConsumptionPerHour.ReadOnly = False
        tBoxUsageTime.ReadOnly = False
        tBoxConsumptionPerHour.Text = ""
        tBoxUsageTime.Text = ""
        btnTaasta.Enabled = True
        btnSisesta.Enabled = False
    End Sub
    Private Sub btnTaasta_Click(sender As Object, e As EventArgs) Handles btnTaasta.Click
        tBoxConsumptionPerHour.ReadOnly = True
        tBoxUsageTime.ReadOnly = True
        btnTaasta.Enabled = False
        btnSisesta.Enabled = True
        tBoxConsumptionPerHour.Text = ""
        tBoxUsageTime.Text = ""
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        'Dim noneSelectedAppliance As Boolean = True ' we check if one radiobutton on Kodumasina valik panel is checked
        'For Each radioButton As RadioButton In Panel1.Controls.OfType(Of RadioButton)() 'loop through all radio buttons on panel1
        '    If radioButton.Checked Then ' if button is checked
        '        noneSelectedAppliance = False 'variable is false
        '        Exit For
        '    End If
        'Next

        Dim noneSelectedPower As Boolean = True ' we check if one radiobutton on Tarvitav võimsus valik panel is checked
        For Each radioButton As RadioButton In Panel3.Controls.OfType(Of RadioButton)() 'loop through all radio buttons on panel2
            If radioButton.Checked Then ' if button is checked
                noneSelectedPower = False 'variable is false
                Exit For
            End If
        Next
        If noneSelectedPower = False Then 'if radio button is checked on panel 2

            If tBoxConsumptionPerHour.ReadOnly = True And tBoxUsageTime.ReadOnly = True Then
                Dim returnString As PrjDatabaseComponent.IDatabase
                returnString = New PrjDatabaseComponent.CDatabase
                Dim actualOutput = returnString.stringReturn(applianceID)
                tBoxConsumptionPerHour.Text = actualOutput.consumptionPerHour
                tBoxUsageTime.Text = actualOutput.usageTime
            Else


            End If
            tBoxPackagePrice.Text = tBoxPackagePrice.Text.Replace("€", "")
            Dim incoming As Computing_Component.ICalculating
            incoming = New Computing_Component.CCalculating
            Dim actualOutput2 = incoming.applianceConsumption(tBoxConsumptionPerHour.Text, tBoxUsageTime.Text, tBoxPackagePrice.Text)

            'Shows only 3 decimal spaces
            Dim cons As Decimal = actualOutput2.consumption

            Dim consOut As String = cons.ToString("N3")

            Dim aprox As Decimal = actualOutput2.aproxPrice
            Dim aproxOut As String = aprox.ToString '("N3")
            tBoxElectricityConsumptionRate.Text = consOut
            tBoxApproxPrice.Text = aproxOut
        End If

    End Sub

    Private Sub rdioToaster_CheckedChanged(sender As Object, e As EventArgs) Handles rdioToaster.CheckedChanged
        applianceID = "2"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioVacuum_CheckedChanged(sender As Object, e As EventArgs) Handles rdioVacuum.CheckedChanged
        applianceID = "3"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioMixer_CheckedChanged(sender As Object, e As EventArgs) Handles rdioMixer.CheckedChanged
        applianceID = "4"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioElecStove_CheckedChanged(sender As Object, e As EventArgs) Handles rdioElecStove.CheckedChanged
        applianceID = "5"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioFoodProcessor_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFoodProcessor.CheckedChanged
        applianceID = "6"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioTV_CheckedChanged(sender As Object, e As EventArgs) Handles rdioTV.CheckedChanged
        applianceID = "7"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdioRadio.CheckedChanged
        applianceID = "8"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioEggCooker_CheckedChanged(sender As Object, e As EventArgs) Handles rdioEggCooker.CheckedChanged
        applianceID = "9"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioFridge_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFridge.CheckedChanged
        applianceID = "10"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioComputer_CheckedChanged(sender As Object, e As EventArgs) Handles rdioComputer.CheckedChanged
        applianceID = "11"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioHairDryer_CheckedChanged(sender As Object, e As EventArgs) Handles rdioHairDryer.CheckedChanged
        applianceID = "12"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioPrinter_CheckedChanged(sender As Object, e As EventArgs) Handles rdioPrinter.CheckedChanged
        applianceID = "13"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioLED_CheckedChanged(sender As Object, e As EventArgs) Handles rdioLED.CheckedChanged
        applianceID = "14"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioSewingMachine_CheckedChanged(sender As Object, e As EventArgs) Handles rdioSewingMachine.CheckedChanged
        applianceID = "16"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioRouter_CheckedChanged(sender As Object, e As EventArgs) Handles rdioRouter.CheckedChanged
        applianceID = "17"
        btnConfirm.Enabled = True
    End Sub

    Private Sub rdioMicrowave_CheckedChanged(sender As Object, e As EventArgs) Handles rdioMicrowave.CheckedChanged
        applianceID = "18"
        btnConfirm.Enabled = True
    End Sub



    Private Sub btnConfirmInput_Click(sender As Object, e As EventArgs) Handles btnConfirmInput.Click
        tblPriceTable.Controls.Clear()
        chrtPackageHourlyRate.Series.Clear()
        Dim timeNowHours As Integer = DateTime.Now.ToString("HH")


        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice()

        For i As Integer = 1 To 24
            sPrices(i) = sPrices(i).Replace(".", ",")
        Next



        Dim dgv As New DataGridView()

        For i As Integer = 0 To 23
            'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
            If timeNowHours >= 24 Then
                timeNowHours = timeNowHours - 24
                dgv.Columns.Add(0, timeNowHours & ":00")

            Else
                dgv.Columns.Add(0, timeNowHours & ":00")

            End If
            timeNowHours = timeNowHours + 1

        Next


        If rdioFixedPrice.Checked Then
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & "€" ' or any other number you want to insert
            Next
        Else
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = sPrices(i + 1) & "€" ' or any other number you want to insert
            Next
        End If


        tblPriceTable.Controls.Add(dgv)

        chart()


    End Sub
    Public Function chartFrontPage()

        Dim seriesName As String = "Börsihind"
        chrtFrontPage.Series.Add(seriesName)

        chrtFrontPage.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        chrtFrontPage.Series(0).Color = Color.Red
        chrtFrontPage.Series(0).BorderWidth = 3
        Dim returnString1 As PrjDatabaseComponent.IDatabaseAPI
        returnString1 = New PrjDatabaseComponent.CDatabase
        Dim sPrices1 As String()
        sPrices1 = returnString1.stockPrice()
        Dim dblValues(sPrices1.Length - 1) As Double
        For i As Integer = 1 To sPrices1.Length - 1
            Double.TryParse(sPrices1(i), dblValues(i))
        Next

        ' Add some data points to the series
        'Dim values() As Double = {10, 20, 30, 40, 50}
        For i As Integer = 1 To dblValues.Length - 1
            chrtFrontPage.Series(seriesName).Points.AddXY(i, sPrices1(i))
        Next

    End Function
    Public Function chart()
        Dim seriesName As String = "Börsihind"
        chrtPackageHourlyRate.Series.Add(seriesName)
        chrtPackageHourlyRate.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.StepLine
        chrtPackageHourlyRate.Series(0).Color = Color.Red
        chrtPackageHourlyRate.Series(0).BorderWidth = 3

        Dim returnString1 As PrjDatabaseComponent.IDatabaseAPI
        returnString1 = New PrjDatabaseComponent.CDatabase
        Dim sPrices1 As String()
        sPrices1 = returnString1.stockPrice()
        Dim dblValues(sPrices1.Length - 1) As Double
        For i As Integer = 1 To sPrices1.Length - 1
            Double.TryParse(sPrices1(i), dblValues(i))
        Next

        ' Add some data points to the series
        'Dim values() As Double = {10, 20, 30, 40, 50}
        For i As Integer = 1 To dblValues.Length - 1
            chrtPackageHourlyRate.Series(seriesName).Points.AddXY(i, sPrices1(i))
        Next
    End Function
    Private Sub rdioExchange_CheckedChanged(sender As Object, e As EventArgs) Handles rdioExchange.CheckedChanged
        tboxMonthlyCost.Enabled = False

        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice()
        sPrices(1) = sPrices(1).Replace(".", ",")


        'Dim sPricesOut As String = sPrices(1)
        Dim sPricesOut As Double
        Double.TryParse(sPrices(1), sPricesOut)

        tBoxPackageHourlyRate.Text = sPricesOut & "€"
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
        sPrices = returnString.stockPrice()

        sPrices(1) = sPrices(1).Replace(".", ",")
        tBoxPackagePrice.Text = sPrices(1) & "€"
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

    'Private Sub GUIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim seriesName As String = "Börsihind"
    '    chrFrontPageChart.Series.Add(seriesName)
    '    Dim returnString As PrjDatabaseComponent.IDatabaseAPI
    '    returnString = New PrjDatabaseComponent.CDatabase
    '    Dim sPrices As String()
    '    sPrices = returnString.stockPrice()
    '    Dim dblValues(sPrices.Length - 1) As Double


    '    ' Add some data points to the series
    '    'Dim values() As Double = {10, 20, 30, 40, 50}
    '    For i As Integer = 0 To dblValues.Length - 1
    '        chrFrontPageChart.Series(seriesName).Points.AddXY(i + 1, sPrices(i))
    '    Next
    'End Sub



    Private Sub btnChartAsc_Click(sender As Object, e As EventArgs) Handles btnChartAsc.Click
        tblPriceTable.Controls.Clear()
        Dim timeNowHours As Integer = DateTime.Now.ToString("HH")


        Dim returnString As PrjDatabaseComponent.IDatabaseAPI
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sPrices As String()
        sPrices = returnString.stockPrice()

        For i As Integer = 1 To 24
            sPrices(i) = sPrices(i).Replace(".", ",")
        Next

        Dim dPrices As Double() = New Double(sPrices.Length - 1) {}

        For i As Integer = 1 To sPrices.Length - 1
            dPrices(i) = Double.Parse(sPrices(i))
        Next

        Array.Sort(dPrices)

        Dim dgv As New DataGridView()

        For i As Integer = 0 To 23
            'dgv.Columns.Add("Column" & i.ToString(), "Column" & i.ToString())
            If timeNowHours >= 24 Then
                timeNowHours = timeNowHours - 24
                dgv.Columns.Add(0, timeNowHours & ":00")

            Else
                dgv.Columns.Add(0, timeNowHours & ":00")

            End If
            timeNowHours = timeNowHours + 1

        Next


        If rdioFixedPrice.Checked Then
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = tboxMonthlyCost.Text & "€" ' or any other number you want to insert
            Next
        Else
            For i As Integer = 0 To 23
                dgv.Rows(0).Cells(i).Value = dPrices(i + 1) & "€" ' or any other number you want to insert
            Next
        End If


        tblPriceTable.Controls.Add(dgv)

    End Sub

    Private Sub GUIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTaasta.Enabled = False
    End Sub

    Private Sub tabApplianceCalc_Click(sender As Object, e As EventArgs) Handles tabApplianceCalc.Click

    End Sub

    Private Sub tabApplianceCalc_Enter(sender As Object, e As EventArgs) Handles tabApplianceCalc.Enter
        If IsNothing(applianceID) Then
            btnConfirm.Enabled = False

        End If
    End Sub

    Private Sub cbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColor.SelectedIndexChanged

        Dim selectedItem As String = cbColor.SelectedItem

        Select Case selectedItem 'change color based on the item the user choosed
            Case "Punane"
                Me.BackColor = Color.Crimson
            Case "Sinine"
                Me.BackColor = Color.LightSkyBlue
            Case "Roheline"
                Me.BackColor = Color.OliveDrab
            Case "Roosa"
                Me.BackColor = Color.Pink
                chrtFrontPage.Series(0).Color = Color.Pink
            Case "Tumehall"
                Me.BackColor = Color.LightSlateGray
            Case "Valge"
                Me.BackColor = Color.White
            Case Else
                Me.BackColor = SystemColors.Control ' everything else is light grey
        End Select
    End Sub





    'Private Sub GUIMain_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
    '    Dim seriesName As String = "Börsihind"
    '    chrFrontPageChart.Series.Add(seriesName)
    '    Dim returnString As PrjDatabaseComponent.IDatabaseAPI
    '    returnString = New PrjDatabaseComponent.CDatabase
    '    Dim sPrices As String()
    '    sPrices = returnString.stockPrice()
    '    Dim dblValues(sPrices.Length - 1) As Double
    '    For i As Integer = 1 To sPrices.Length - 1
    '        Double.TryParse(sPrices(i), dblValues(i))
    '    Next

    '    ' Add some data points to the series
    '    'Dim values() As Double = {10, 20, 30, 40, 50}
    '    For i As Integer = 0 To dblValues.Length - 1
    '        chrFrontPageChart.Series(seriesName).Points.AddXY(i + 1, sPrices(i))
    '    Next
    'End Sub
End Class
