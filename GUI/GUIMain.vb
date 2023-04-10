

Public Class GUIMain
    Dim sisend As String
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
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim returnString As PrjDatabaseComponent.IDatabase
        returnString = New PrjDatabaseComponent.CDatabase
        Dim actualOutput = returnString.stringReturn(applianceID)
        textBoxConsumptionPerHour.Text = actualOutput.consumptionPerHour
        textBoxUsageTime.Text = actualOutput.usageTime

        Dim incoming As Computing_Component.ICalculating
        incoming = New Computing_Component.CCalculating
        Dim actualOutput2 = incoming.applianceConsumption(textBoxConsumptionPerHour.Text, textBoxUsageTime.Text, textBoxPackagePrice.Text)
        textBoxElectricityConsumptionRate.Text = actualOutput2.consumption
        textBoxApproxPrice.Text = actualOutput2.aproxPrice

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
