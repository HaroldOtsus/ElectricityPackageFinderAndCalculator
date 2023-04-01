Public Class GUIMain
    Public sisend As String
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


    Private Sub rdioCoffeeMaker_CheckedChanged(sender As Object, e As EventArgs) Handles rdioCoffeeMaker.CheckedChanged

    End Sub

    Private Sub tboxMonthlyCost_TextChanged(sender As Object, e As EventArgs) Handles tboxMonthlyCost.TextChanged

    End Sub
End Class
