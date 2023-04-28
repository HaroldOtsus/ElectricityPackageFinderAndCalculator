<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUIMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIMain))
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnPackageHourlyRate = New System.Windows.Forms.Button()
        Me.btnApplianceCalc = New System.Windows.Forms.Button()
        Me.btnExchangePriceComparison = New System.Windows.Forms.Button()
        Me.btnConsumptionHistory = New System.Windows.Forms.Button()
        Me.btnPackageComparison = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Main = New System.Windows.Forms.TabPage()
        Me.cbColor = New System.Windows.Forms.ComboBox()
        Me.chrtFrontPage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabPackageHourlyRate = New System.Windows.Forms.TabPage()
        Me.lblBestTime = New System.Windows.Forms.Label()
        Me.lblTableState = New System.Windows.Forms.Label()
        Me.lblSKwh4 = New System.Windows.Forms.Label()
        Me.lblSKwh3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTableDesc = New System.Windows.Forms.Button()
        Me.tbMarginalOfStock = New System.Windows.Forms.TextBox()
        Me.rdiobtnStockPlussMarginal = New System.Windows.Forms.RadioButton()
        Me.rdioBtnUniversalP = New System.Windows.Forms.RadioButton()
        Me.btnTableAsc = New System.Windows.Forms.Button()
        Me.chrtPackageHourlyRate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tblPriceTable = New System.Windows.Forms.DataGridView()
        Me.tBoxPackageHourlyRate = New System.Windows.Forms.TextBox()
        Me.lblPriceGraph = New System.Windows.Forms.Label()
        Me.lblPriceTable = New System.Windows.Forms.Label()
        Me.lblPackageHourlyRate = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConfirmInput = New System.Windows.Forms.Button()
        Me.tboxMonthlyCost = New System.Windows.Forms.TextBox()
        Me.lblMonthlyCost = New System.Windows.Forms.Label()
        Me.rdioFixedPrice = New System.Windows.Forms.RadioButton()
        Me.rdioExchange = New System.Windows.Forms.RadioButton()
        Me.lblPackageHourly = New System.Windows.Forms.Label()
        Me.btnBack0 = New System.Windows.Forms.Button()
        Me.tabApplianceCalc = New System.Windows.Forms.TabPage()
        Me.lblSKwh1 = New System.Windows.Forms.Label()
        Me.lblSKwh2 = New System.Windows.Forms.Label()
        Me.tBoxMarginal = New System.Windows.Forms.TextBox()
        Me.lblMore = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radioStockPlusMore = New System.Windows.Forms.RadioButton()
        Me.rdioUniversalPackage = New System.Windows.Forms.RadioButton()
        Me.rdioFixedPrice1 = New System.Windows.Forms.RadioButton()
        Me.rdioExchangePrice = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAproxYearlyPrice = New System.Windows.Forms.Label()
        Me.lblRoughPriceYearly = New System.Windows.Forms.Label()
        Me.tBoxApproxPriceYear = New System.Windows.Forms.TextBox()
        Me.btnTaasta = New System.Windows.Forms.Button()
        Me.btnSisesta = New System.Windows.Forms.Button()
        Me.lblCents = New System.Windows.Forms.Label()
        Me.lblKwh24h = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblWatt = New System.Windows.Forms.Label()
        Me.lblApplianceResult = New System.Windows.Forms.Label()
        Me.lblElectricityConsumptionRate = New System.Windows.Forms.Label()
        Me.tBoxUsageTime = New System.Windows.Forms.TextBox()
        Me.lblRoughPrice = New System.Windows.Forms.Label()
        Me.tBoxConsumptionPerHour = New System.Windows.Forms.TextBox()
        Me.tBoxElectricityConsumptionRate = New System.Windows.Forms.TextBox()
        Me.lblUsageTime = New System.Windows.Forms.Label()
        Me.tBoxApproxPrice = New System.Windows.Forms.TextBox()
        Me.lblConsumptionPerHour = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdioFridge = New System.Windows.Forms.RadioButton()
        Me.rdioCoffeeMaker = New System.Windows.Forms.RadioButton()
        Me.rdioToaster = New System.Windows.Forms.RadioButton()
        Me.rdioVacuum = New System.Windows.Forms.RadioButton()
        Me.rdioMixer = New System.Windows.Forms.RadioButton()
        Me.rdioMicrowave = New System.Windows.Forms.RadioButton()
        Me.rdioElecStove = New System.Windows.Forms.RadioButton()
        Me.rdioRouter = New System.Windows.Forms.RadioButton()
        Me.rdioFoodProcessor = New System.Windows.Forms.RadioButton()
        Me.rdioSewingMachine = New System.Windows.Forms.RadioButton()
        Me.rdioTV = New System.Windows.Forms.RadioButton()
        Me.rdioLED = New System.Windows.Forms.RadioButton()
        Me.rdioRadio = New System.Windows.Forms.RadioButton()
        Me.rdioPrinter = New System.Windows.Forms.RadioButton()
        Me.rdioEggCooker = New System.Windows.Forms.RadioButton()
        Me.rdioHairDryer = New System.Windows.Forms.RadioButton()
        Me.rdioComputer = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.tBoxPackagePrice = New System.Windows.Forms.TextBox()
        Me.lblCurrentPackagePrice = New System.Windows.Forms.Label()
        Me.lblOptional = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblApplianceChoice = New System.Windows.Forms.Label()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.tabExchangeComparison = New System.Windows.Forms.TabPage()
        Me.chrtCSV = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblExchangeComparisonResult = New System.Windows.Forms.Label()
        Me.tBoxCondition2 = New System.Windows.Forms.TextBox()
        Me.tBoxCondition1 = New System.Windows.Forms.TextBox()
        Me.tBoxEndTime = New System.Windows.Forms.TextBox()
        Me.tboxStartTime = New System.Windows.Forms.TextBox()
        Me.lblExchangeChoice = New System.Windows.Forms.Label()
        Me.lblCase2 = New System.Windows.Forms.Label()
        Me.lblCase1 = New System.Windows.Forms.Label()
        Me.lblEnterPrice = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblTimePeriodSelection = New System.Windows.Forms.Label()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.tabConsumptionHistory = New System.Windows.Forms.TabPage()
        Me.btnSimulateConsumptionHistory = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabBlank = New System.Windows.Forms.TabPage()
        Me.tabClientConsumptionHistory = New System.Windows.Forms.TabPage()
        Me.btnConfirmSimuCSV = New System.Windows.Forms.Button()
        Me.tbDebug = New System.Windows.Forms.TextBox()
        Me.lblToDateTime = New System.Windows.Forms.Label()
        Me.lblFromDateTime = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpBeginning = New System.Windows.Forms.DateTimePicker()
        Me.chrt = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImportCSVFileSimu = New System.Windows.Forms.Button()
        Me.lblSimulateClientConsumptionHistory = New System.Windows.Forms.Label()
        Me.lblConsumptionGraph = New System.Windows.Forms.Label()
        Me.lblClientConsumptionHistoryResult = New System.Windows.Forms.Label()
        Me.tabSimulateExchangeHistory = New System.Windows.Forms.TabPage()
        Me.lblExchangePackageHistory = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSeeHistory = New System.Windows.Forms.Button()
        Me.tBoxMonthlyCost2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClientConsumptionHistory = New System.Windows.Forms.Button()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.tabPackageComparison = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.priceOfCont2 = New System.Windows.Forms.TextBox()
        Me.compTwo = New System.Windows.Forms.TextBox()
        Me.priceOfCont = New System.Windows.Forms.TextBox()
        Me.compOne = New System.Windows.Forms.TextBox()
        Me.btnTwoPackets = New System.Windows.Forms.Button()
        Me.btnPackets = New System.Windows.Forms.Button()
        Me.chartPackages = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblComparisonResult = New System.Windows.Forms.Label()
        Me.cBoxPackage2 = New System.Windows.Forms.ComboBox()
        Me.cBoxPackage1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPackage1 = New System.Windows.Forms.Label()
        Me.lblChoosePackages = New System.Windows.Forms.Label()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.tabGreenEnergy = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbOpinion = New System.Windows.Forms.TextBox()
        Me.btnProduction = New System.Windows.Forms.Button()
        Me.tbProduction = New System.Windows.Forms.TextBox()
        Me.btnWeather = New System.Windows.Forms.Button()
        Me.tbWeather = New System.Windows.Forms.TextBox()
        Me.lblChangeFontSize = New System.Windows.Forms.Label()
        Me.btnFontIncrease = New System.Windows.Forms.Button()
        Me.btnFontDecrease = New System.Windows.Forms.Button()
        Me.btnRestoreFontSize = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.chrtFrontPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPackageHourlyRate.SuspendLayout()
        CType(Me.chrtPackageHourlyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPriceTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabApplianceCalc.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabExchangeComparison.SuspendLayout()
        CType(Me.chrtCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsumptionHistory.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabClientConsumptionHistory.SuspendLayout()
        CType(Me.chrt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSimulateExchangeHistory.SuspendLayout()
        Me.tabPackageComparison.SuspendLayout()
        CType(Me.chartPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGreenEnergy.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Location = New System.Drawing.Point(17, 16)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(58, 17)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "MENÜÜ"
        '
        'btnPackageHourlyRate
        '
        Me.btnPackageHourlyRate.Location = New System.Drawing.Point(23, 26)
        Me.btnPackageHourlyRate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPackageHourlyRate.Name = "btnPackageHourlyRate"
        Me.btnPackageHourlyRate.Size = New System.Drawing.Size(224, 113)
        Me.btnPackageHourlyRate.TabIndex = 1
        Me.btnPackageHourlyRate.Text = "Kuva paketijärgne tunnihind"
        Me.btnPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'btnApplianceCalc
        '
        Me.btnApplianceCalc.Location = New System.Drawing.Point(255, 26)
        Me.btnApplianceCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApplianceCalc.Name = "btnApplianceCalc"
        Me.btnApplianceCalc.Size = New System.Drawing.Size(224, 113)
        Me.btnApplianceCalc.TabIndex = 2
        Me.btnApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.btnApplianceCalc.UseVisualStyleBackColor = True
        '
        'btnExchangePriceComparison
        '
        Me.btnExchangePriceComparison.Location = New System.Drawing.Point(487, 26)
        Me.btnExchangePriceComparison.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExchangePriceComparison.Name = "btnExchangePriceComparison"
        Me.btnExchangePriceComparison.Size = New System.Drawing.Size(224, 113)
        Me.btnExchangePriceComparison.TabIndex = 3
        Me.btnExchangePriceComparison.Text = "Börsihinna võrdlus elektriteenuse pakkujatega"
        Me.btnExchangePriceComparison.UseVisualStyleBackColor = True
        '
        'btnConsumptionHistory
        '
        Me.btnConsumptionHistory.Location = New System.Drawing.Point(23, 146)
        Me.btnConsumptionHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsumptionHistory.Name = "btnConsumptionHistory"
        Me.btnConsumptionHistory.Size = New System.Drawing.Size(224, 113)
        Me.btnConsumptionHistory.TabIndex = 4
        Me.btnConsumptionHistory.Text = "Vaata oma tarbimise ajalugu"
        Me.btnConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnPackageComparison
        '
        Me.btnPackageComparison.Location = New System.Drawing.Point(255, 146)
        Me.btnPackageComparison.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPackageComparison.Name = "btnPackageComparison"
        Me.btnPackageComparison.Size = New System.Drawing.Size(224, 113)
        Me.btnPackageComparison.TabIndex = 5
        Me.btnPackageComparison.Text = "Võrdle elektripakette"
        Me.btnPackageComparison.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.Main)
        Me.TabControl1.Controls.Add(Me.tabPackageHourlyRate)
        Me.TabControl1.Controls.Add(Me.tabApplianceCalc)
        Me.TabControl1.Controls.Add(Me.tabExchangeComparison)
        Me.TabControl1.Controls.Add(Me.tabConsumptionHistory)
        Me.TabControl1.Controls.Add(Me.tabPackageComparison)
        Me.TabControl1.Controls.Add(Me.tabGreenEnergy)
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 22)
        Me.TabControl1.Location = New System.Drawing.Point(16, 46)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1276, 799)
        Me.TabControl1.TabIndex = 6
        '
        'Main
        '
        Me.Main.BackColor = System.Drawing.Color.Transparent
        Me.Main.Controls.Add(Me.cbColor)
        Me.Main.Controls.Add(Me.chrtFrontPage)
        Me.Main.Controls.Add(Me.btnPackageHourlyRate)
        Me.Main.Controls.Add(Me.btnPackageComparison)
        Me.Main.Controls.Add(Me.btnApplianceCalc)
        Me.Main.Controls.Add(Me.btnConsumptionHistory)
        Me.Main.Controls.Add(Me.btnExchangePriceComparison)
        Me.Main.Location = New System.Drawing.Point(4, 26)
        Me.Main.Margin = New System.Windows.Forms.Padding(4)
        Me.Main.Name = "Main"
        Me.Main.Padding = New System.Windows.Forms.Padding(4)
        Me.Main.Size = New System.Drawing.Size(1268, 769)
        Me.Main.TabIndex = 0
        Me.Main.Text = "Home"
        '
        'cbColor
        '
        Me.cbColor.AllowDrop = True
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Items.AddRange(New Object() {"Punane", "Sinine", "Roheline", "Roosa", "Valge", "Tumehall", "Helehall"})
        Me.cbColor.Location = New System.Drawing.Point(881, 57)
        Me.cbColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(160, 24)
        Me.cbColor.TabIndex = 9
        Me.cbColor.Text = "Vali värv"
        '
        'chrtFrontPage
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtFrontPage.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtFrontPage.Legends.Add(Legend1)
        Me.chrtFrontPage.Location = New System.Drawing.Point(23, 267)
        Me.chrtFrontPage.Margin = New System.Windows.Forms.Padding(4)
        Me.chrtFrontPage.Name = "chrtFrontPage"
        Me.chrtFrontPage.Size = New System.Drawing.Size(1051, 447)
        Me.chrtFrontPage.TabIndex = 8
        Me.chrtFrontPage.Text = "Chart2"
        '
        'tabPackageHourlyRate
        '
        Me.tabPackageHourlyRate.Controls.Add(Me.lblBestTime)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblTableState)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblSKwh4)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblSKwh3)
        Me.tabPackageHourlyRate.Controls.Add(Me.Label1)
        Me.tabPackageHourlyRate.Controls.Add(Me.btnTableDesc)
        Me.tabPackageHourlyRate.Controls.Add(Me.tbMarginalOfStock)
        Me.tabPackageHourlyRate.Controls.Add(Me.rdiobtnStockPlussMarginal)
        Me.tabPackageHourlyRate.Controls.Add(Me.rdioBtnUniversalP)
        Me.tabPackageHourlyRate.Controls.Add(Me.btnTableAsc)
        Me.tabPackageHourlyRate.Controls.Add(Me.chrtPackageHourlyRate)
        Me.tabPackageHourlyRate.Controls.Add(Me.tblPriceTable)
        Me.tabPackageHourlyRate.Controls.Add(Me.tBoxPackageHourlyRate)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPriceGraph)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPriceTable)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPackageHourlyRate)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblResult)
        Me.tabPackageHourlyRate.Controls.Add(Me.btnConfirmInput)
        Me.tabPackageHourlyRate.Controls.Add(Me.tboxMonthlyCost)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblMonthlyCost)
        Me.tabPackageHourlyRate.Controls.Add(Me.rdioFixedPrice)
        Me.tabPackageHourlyRate.Controls.Add(Me.rdioExchange)
        Me.tabPackageHourlyRate.Controls.Add(Me.lblPackageHourly)
        Me.tabPackageHourlyRate.Controls.Add(Me.btnBack0)
        Me.tabPackageHourlyRate.Location = New System.Drawing.Point(4, 26)
        Me.tabPackageHourlyRate.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPackageHourlyRate.Name = "tabPackageHourlyRate"
        Me.tabPackageHourlyRate.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPackageHourlyRate.Size = New System.Drawing.Size(1268, 769)
        Me.tabPackageHourlyRate.TabIndex = 1
        Me.tabPackageHourlyRate.Text = "Paketijärgne tunnihind"
        Me.tabPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'lblBestTime
        '
        Me.lblBestTime.AutoSize = True
        Me.lblBestTime.Location = New System.Drawing.Point(18, 748)
        Me.lblBestTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBestTime.Name = "lblBestTime"
        Me.lblBestTime.Size = New System.Drawing.Size(43, 17)
        Me.lblBestTime.TabIndex = 24
        Me.lblBestTime.Text = "nuffin"
        '
        'lblTableState
        '
        Me.lblTableState.AutoSize = True
        Me.lblTableState.Location = New System.Drawing.Point(18, 610)
        Me.lblTableState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTableState.Name = "lblTableState"
        Me.lblTableState.Size = New System.Drawing.Size(43, 17)
        Me.lblTableState.TabIndex = 23
        Me.lblTableState.Text = "nuffin"
        '
        'lblSKwh4
        '
        Me.lblSKwh4.AutoSize = True
        Me.lblSKwh4.Location = New System.Drawing.Point(308, 245)
        Me.lblSKwh4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSKwh4.Name = "lblSKwh4"
        Me.lblSKwh4.Size = New System.Drawing.Size(47, 17)
        Me.lblSKwh4.TabIndex = 22
        Me.lblSKwh4.Text = "s/kWh"
        '
        'lblSKwh3
        '
        Me.lblSKwh3.AutoSize = True
        Me.lblSKwh3.Location = New System.Drawing.Point(308, 207)
        Me.lblSKwh3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSKwh3.Name = "lblSKwh3"
        Me.lblSKwh3.Size = New System.Drawing.Size(47, 17)
        Me.lblSKwh3.TabIndex = 21
        Me.lblSKwh3.Text = "s/kWh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sisesta marginaal:"
        '
        'btnTableDesc
        '
        Me.btnTableDesc.Location = New System.Drawing.Point(40, 373)
        Me.btnTableDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableDesc.Name = "btnTableDesc"
        Me.btnTableDesc.Size = New System.Drawing.Size(195, 39)
        Me.btnTableDesc.TabIndex = 19
        Me.btnTableDesc.Text = "Järjesta tabel kahanevalt"
        Me.btnTableDesc.UseVisualStyleBackColor = True
        '
        'tbMarginalOfStock
        '
        Me.tbMarginalOfStock.Location = New System.Drawing.Point(167, 203)
        Me.tbMarginalOfStock.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMarginalOfStock.Name = "tbMarginalOfStock"
        Me.tbMarginalOfStock.Size = New System.Drawing.Size(132, 22)
        Me.tbMarginalOfStock.TabIndex = 18
        '
        'rdiobtnStockPlussMarginal
        '
        Me.rdiobtnStockPlussMarginal.AutoSize = True
        Me.rdiobtnStockPlussMarginal.Enabled = False
        Me.rdiobtnStockPlussMarginal.Location = New System.Drawing.Point(40, 114)
        Me.rdiobtnStockPlussMarginal.Margin = New System.Windows.Forms.Padding(4)
        Me.rdiobtnStockPlussMarginal.Name = "rdiobtnStockPlussMarginal"
        Me.rdiobtnStockPlussMarginal.Size = New System.Drawing.Size(166, 21)
        Me.rdiobtnStockPlussMarginal.TabIndex = 17
        Me.rdiobtnStockPlussMarginal.TabStop = True
        Me.rdiobtnStockPlussMarginal.Text = "Börsihind + marginaal"
        Me.rdiobtnStockPlussMarginal.UseVisualStyleBackColor = True
        '
        'rdioBtnUniversalP
        '
        Me.rdioBtnUniversalP.AutoSize = True
        Me.rdioBtnUniversalP.Location = New System.Drawing.Point(40, 171)
        Me.rdioBtnUniversalP.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioBtnUniversalP.Name = "rdioBtnUniversalP"
        Me.rdioBtnUniversalP.Size = New System.Drawing.Size(123, 21)
        Me.rdioBtnUniversalP.TabIndex = 16
        Me.rdioBtnUniversalP.TabStop = True
        Me.rdioBtnUniversalP.Text = "Universaalhind"
        Me.rdioBtnUniversalP.UseVisualStyleBackColor = True
        '
        'btnTableAsc
        '
        Me.btnTableAsc.Location = New System.Drawing.Point(40, 326)
        Me.btnTableAsc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableAsc.Name = "btnTableAsc"
        Me.btnTableAsc.Size = New System.Drawing.Size(195, 39)
        Me.btnTableAsc.TabIndex = 15
        Me.btnTableAsc.Text = "Järjesta tabel kasvavalt"
        Me.btnTableAsc.UseVisualStyleBackColor = True
        '
        'chrtPackageHourlyRate
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrtPackageHourlyRate.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrtPackageHourlyRate.Legends.Add(Legend2)
        Me.chrtPackageHourlyRate.Location = New System.Drawing.Point(488, 114)
        Me.chrtPackageHourlyRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chrtPackageHourlyRate.Name = "chrtPackageHourlyRate"
        Me.chrtPackageHourlyRate.Size = New System.Drawing.Size(629, 460)
        Me.chrtPackageHourlyRate.TabIndex = 14
        Me.chrtPackageHourlyRate.Text = "Chart1"
        '
        'tblPriceTable
        '
        Me.tblPriceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPriceTable.Location = New System.Drawing.Point(8, 644)
        Me.tblPriceTable.Margin = New System.Windows.Forms.Padding(4)
        Me.tblPriceTable.Name = "tblPriceTable"
        Me.tblPriceTable.ReadOnly = True
        Me.tblPriceTable.RowHeadersWidth = 51
        Me.tblPriceTable.Size = New System.Drawing.Size(1252, 100)
        Me.tblPriceTable.TabIndex = 13
        '
        'tBoxPackageHourlyRate
        '
        Me.tBoxPackageHourlyRate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxPackageHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxPackageHourlyRate.Cursor = System.Windows.Forms.Cursors.No
        Me.tBoxPackageHourlyRate.Enabled = False
        Me.tBoxPackageHourlyRate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.tBoxPackageHourlyRate.Location = New System.Drawing.Point(867, 57)
        Me.tBoxPackageHourlyRate.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxPackageHourlyRate.Name = "tBoxPackageHourlyRate"
        Me.tBoxPackageHourlyRate.ReadOnly = True
        Me.tBoxPackageHourlyRate.Size = New System.Drawing.Size(133, 22)
        Me.tBoxPackageHourlyRate.TabIndex = 11
        '
        'lblPriceGraph
        '
        Me.lblPriceGraph.AutoSize = True
        Me.lblPriceGraph.Location = New System.Drawing.Point(485, 39)
        Me.lblPriceGraph.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceGraph.Name = "lblPriceGraph"
        Me.lblPriceGraph.Size = New System.Drawing.Size(92, 17)
        Me.lblPriceGraph.TabIndex = 10
        Me.lblPriceGraph.Text = "Hinnagraafik:"
        '
        'lblPriceTable
        '
        Me.lblPriceTable.AutoSize = True
        Me.lblPriceTable.Location = New System.Drawing.Point(8, 568)
        Me.lblPriceTable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceTable.Name = "lblPriceTable"
        Me.lblPriceTable.Size = New System.Drawing.Size(80, 17)
        Me.lblPriceTable.TabIndex = 9
        Me.lblPriceTable.Text = "Hinnatabel:"
        '
        'lblPackageHourlyRate
        '
        Me.lblPackageHourlyRate.AutoSize = True
        Me.lblPackageHourlyRate.Location = New System.Drawing.Point(684, 57)
        Me.lblPackageHourlyRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPackageHourlyRate.Name = "lblPackageHourlyRate"
        Me.lblPackageHourlyRate.Size = New System.Drawing.Size(153, 17)
        Me.lblPackageHourlyRate.TabIndex = 8
        Me.lblPackageHourlyRate.Text = "Paketijärgne tunnihind:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(684, 15)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(66, 17)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Tulemus:"
        '
        'btnConfirmInput
        '
        Me.btnConfirmInput.Location = New System.Drawing.Point(40, 279)
        Me.btnConfirmInput.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmInput.Name = "btnConfirmInput"
        Me.btnConfirmInput.Size = New System.Drawing.Size(195, 39)
        Me.btnConfirmInput.TabIndex = 6
        Me.btnConfirmInput.Text = "Kinnita andmed"
        Me.btnConfirmInput.UseVisualStyleBackColor = True
        '
        'tboxMonthlyCost
        '
        Me.tboxMonthlyCost.Location = New System.Drawing.Point(167, 241)
        Me.tboxMonthlyCost.Margin = New System.Windows.Forms.Padding(4)
        Me.tboxMonthlyCost.Name = "tboxMonthlyCost"
        Me.tboxMonthlyCost.Size = New System.Drawing.Size(132, 22)
        Me.tboxMonthlyCost.TabIndex = 5
        '
        'lblMonthlyCost
        '
        Me.lblMonthlyCost.AutoSize = True
        Me.lblMonthlyCost.Location = New System.Drawing.Point(36, 245)
        Me.lblMonthlyCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthlyCost.Name = "lblMonthlyCost"
        Me.lblMonthlyCost.Size = New System.Drawing.Size(60, 17)
        Me.lblMonthlyCost.TabIndex = 4
        Me.lblMonthlyCost.Text = "Kuutasu"
        '
        'rdioFixedPrice
        '
        Me.rdioFixedPrice.AutoSize = True
        Me.rdioFixedPrice.Location = New System.Drawing.Point(40, 143)
        Me.rdioFixedPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioFixedPrice.Name = "rdioFixedPrice"
        Me.rdioFixedPrice.Size = New System.Drawing.Size(129, 21)
        Me.rdioFixedPrice.TabIndex = 3
        Me.rdioFixedPrice.TabStop = True
        Me.rdioFixedPrice.Text = "Fikseeritud hind"
        Me.rdioFixedPrice.UseVisualStyleBackColor = True
        '
        'rdioExchange
        '
        Me.rdioExchange.AutoSize = True
        Me.rdioExchange.Location = New System.Drawing.Point(40, 86)
        Me.rdioExchange.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioExchange.Name = "rdioExchange"
        Me.rdioExchange.Size = New System.Drawing.Size(88, 21)
        Me.rdioExchange.TabIndex = 2
        Me.rdioExchange.TabStop = True
        Me.rdioExchange.Text = "Börsihind"
        Me.rdioExchange.UseVisualStyleBackColor = True
        '
        'lblPackageHourly
        '
        Me.lblPackageHourly.AutoSize = True
        Me.lblPackageHourly.Location = New System.Drawing.Point(147, 27)
        Me.lblPackageHourly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPackageHourly.Name = "lblPackageHourly"
        Me.lblPackageHourly.Size = New System.Drawing.Size(215, 17)
        Me.lblPackageHourly.TabIndex = 1
        Me.lblPackageHourly.Text = "Kehtiva paketi andmete sisestus:"
        '
        'btnBack0
        '
        Me.btnBack0.Location = New System.Drawing.Point(21, 15)
        Me.btnBack0.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack0.Name = "btnBack0"
        Me.btnBack0.Size = New System.Drawing.Size(111, 41)
        Me.btnBack0.TabIndex = 0
        Me.btnBack0.Text = "Tagasi"
        Me.btnBack0.UseVisualStyleBackColor = True
        '
        'tabApplianceCalc
        '
        Me.tabApplianceCalc.Controls.Add(Me.lblSKwh1)
        Me.tabApplianceCalc.Controls.Add(Me.lblSKwh2)
        Me.tabApplianceCalc.Controls.Add(Me.tBoxMarginal)
        Me.tabApplianceCalc.Controls.Add(Me.lblMore)
        Me.tabApplianceCalc.Controls.Add(Me.Panel3)
        Me.tabApplianceCalc.Controls.Add(Me.Panel2)
        Me.tabApplianceCalc.Controls.Add(Me.Panel1)
        Me.tabApplianceCalc.Controls.Add(Me.btnConfirm)
        Me.tabApplianceCalc.Controls.Add(Me.tBoxPackagePrice)
        Me.tabApplianceCalc.Controls.Add(Me.lblCurrentPackagePrice)
        Me.tabApplianceCalc.Controls.Add(Me.lblOptional)
        Me.tabApplianceCalc.Controls.Add(Me.Label3)
        Me.tabApplianceCalc.Controls.Add(Me.lblApplianceChoice)
        Me.tabApplianceCalc.Controls.Add(Me.btnBack1)
        Me.tabApplianceCalc.Location = New System.Drawing.Point(4, 26)
        Me.tabApplianceCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.tabApplianceCalc.Name = "tabApplianceCalc"
        Me.tabApplianceCalc.Padding = New System.Windows.Forms.Padding(4)
        Me.tabApplianceCalc.Size = New System.Drawing.Size(1268, 769)
        Me.tabApplianceCalc.TabIndex = 2
        Me.tabApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.tabApplianceCalc.UseVisualStyleBackColor = True
        '
        'lblSKwh1
        '
        Me.lblSKwh1.AutoSize = True
        Me.lblSKwh1.Location = New System.Drawing.Point(415, 612)
        Me.lblSKwh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSKwh1.Name = "lblSKwh1"
        Me.lblSKwh1.Size = New System.Drawing.Size(47, 17)
        Me.lblSKwh1.TabIndex = 46
        Me.lblSKwh1.Text = "s/kWh"
        '
        'lblSKwh2
        '
        Me.lblSKwh2.AutoSize = True
        Me.lblSKwh2.Location = New System.Drawing.Point(415, 661)
        Me.lblSKwh2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSKwh2.Name = "lblSKwh2"
        Me.lblSKwh2.Size = New System.Drawing.Size(47, 17)
        Me.lblSKwh2.TabIndex = 45
        Me.lblSKwh2.Text = "s/kWh"
        '
        'tBoxMarginal
        '
        Me.tBoxMarginal.Location = New System.Drawing.Point(273, 656)
        Me.tBoxMarginal.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxMarginal.Name = "tBoxMarginal"
        Me.tBoxMarginal.Size = New System.Drawing.Size(132, 22)
        Me.tBoxMarginal.TabIndex = 43
        '
        'lblMore
        '
        Me.lblMore.AutoSize = True
        Me.lblMore.Location = New System.Drawing.Point(52, 656)
        Me.lblMore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMore.Name = "lblMore"
        Me.lblMore.Size = New System.Drawing.Size(124, 17)
        Me.lblMore.TabIndex = 42
        Me.lblMore.Text = "Sisesta marginaal:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radioStockPlusMore)
        Me.Panel3.Controls.Add(Me.rdioUniversalPackage)
        Me.Panel3.Controls.Add(Me.rdioFixedPrice1)
        Me.Panel3.Controls.Add(Me.rdioExchangePrice)
        Me.Panel3.Location = New System.Drawing.Point(48, 503)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 101)
        Me.Panel3.TabIndex = 41
        '
        'radioStockPlusMore
        '
        Me.radioStockPlusMore.AutoSize = True
        Me.radioStockPlusMore.Location = New System.Drawing.Point(212, 4)
        Me.radioStockPlusMore.Margin = New System.Windows.Forms.Padding(4)
        Me.radioStockPlusMore.Name = "radioStockPlusMore"
        Me.radioStockPlusMore.Size = New System.Drawing.Size(166, 21)
        Me.radioStockPlusMore.TabIndex = 43
        Me.radioStockPlusMore.TabStop = True
        Me.radioStockPlusMore.Text = "Börsihind + marginaal"
        Me.radioStockPlusMore.UseVisualStyleBackColor = True
        '
        'rdioUniversalPackage
        '
        Me.rdioUniversalPackage.AutoSize = True
        Me.rdioUniversalPackage.Location = New System.Drawing.Point(33, 60)
        Me.rdioUniversalPackage.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioUniversalPackage.Name = "rdioUniversalPackage"
        Me.rdioUniversalPackage.Size = New System.Drawing.Size(139, 21)
        Me.rdioUniversalPackage.TabIndex = 42
        Me.rdioUniversalPackage.TabStop = True
        Me.rdioUniversalPackage.Text = "Universaal pakett"
        Me.rdioUniversalPackage.UseVisualStyleBackColor = True
        '
        'rdioFixedPrice1
        '
        Me.rdioFixedPrice1.AutoSize = True
        Me.rdioFixedPrice1.Location = New System.Drawing.Point(33, 32)
        Me.rdioFixedPrice1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioFixedPrice1.Name = "rdioFixedPrice1"
        Me.rdioFixedPrice1.Size = New System.Drawing.Size(129, 21)
        Me.rdioFixedPrice1.TabIndex = 12
        Me.rdioFixedPrice1.TabStop = True
        Me.rdioFixedPrice1.Text = "Fikseeritud hind"
        Me.rdioFixedPrice1.UseVisualStyleBackColor = True
        '
        'rdioExchangePrice
        '
        Me.rdioExchangePrice.AutoSize = True
        Me.rdioExchangePrice.Location = New System.Drawing.Point(33, 4)
        Me.rdioExchangePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioExchangePrice.Name = "rdioExchangePrice"
        Me.rdioExchangePrice.Size = New System.Drawing.Size(88, 21)
        Me.rdioExchangePrice.TabIndex = 11
        Me.rdioExchangePrice.TabStop = True
        Me.rdioExchangePrice.Text = "Börsihind"
        Me.rdioExchangePrice.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblAproxYearlyPrice)
        Me.Panel2.Controls.Add(Me.lblRoughPriceYearly)
        Me.Panel2.Controls.Add(Me.tBoxApproxPriceYear)
        Me.Panel2.Controls.Add(Me.btnTaasta)
        Me.Panel2.Controls.Add(Me.btnSisesta)
        Me.Panel2.Controls.Add(Me.lblCents)
        Me.Panel2.Controls.Add(Me.lblKwh24h)
        Me.Panel2.Controls.Add(Me.lblMin)
        Me.Panel2.Controls.Add(Me.lblWatt)
        Me.Panel2.Controls.Add(Me.lblApplianceResult)
        Me.Panel2.Controls.Add(Me.lblElectricityConsumptionRate)
        Me.Panel2.Controls.Add(Me.tBoxUsageTime)
        Me.Panel2.Controls.Add(Me.lblRoughPrice)
        Me.Panel2.Controls.Add(Me.tBoxConsumptionPerHour)
        Me.Panel2.Controls.Add(Me.tBoxElectricityConsumptionRate)
        Me.Panel2.Controls.Add(Me.lblUsageTime)
        Me.Panel2.Controls.Add(Me.tBoxApproxPrice)
        Me.Panel2.Controls.Add(Me.lblConsumptionPerHour)
        Me.Panel2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Panel2.Location = New System.Drawing.Point(545, 69)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(697, 338)
        Me.Panel2.TabIndex = 40
        '
        'lblAproxYearlyPrice
        '
        Me.lblAproxYearlyPrice.AutoSize = True
        Me.lblAproxYearlyPrice.Location = New System.Drawing.Point(507, 258)
        Me.lblAproxYearlyPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAproxYearlyPrice.Name = "lblAproxYearlyPrice"
        Me.lblAproxYearlyPrice.Size = New System.Drawing.Size(42, 17)
        Me.lblAproxYearlyPrice.TabIndex = 47
        Me.lblAproxYearlyPrice.Text = "senti "
        '
        'lblRoughPriceYearly
        '
        Me.lblRoughPriceYearly.AutoSize = True
        Me.lblRoughPriceYearly.Location = New System.Drawing.Point(21, 257)
        Me.lblRoughPriceYearly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoughPriceYearly.Name = "lblRoughPriceYearly"
        Me.lblRoughPriceYearly.Size = New System.Drawing.Size(164, 17)
        Me.lblRoughPriceYearly.TabIndex = 45
        Me.lblRoughPriceYearly.Text = "Orienteeruv hind aastas:"
        '
        'tBoxApproxPriceYear
        '
        Me.tBoxApproxPriceYear.BackColor = System.Drawing.Color.White
        Me.tBoxApproxPriceYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxApproxPriceYear.Enabled = False
        Me.tBoxApproxPriceYear.ForeColor = System.Drawing.Color.Black
        Me.tBoxApproxPriceYear.Location = New System.Drawing.Point(365, 255)
        Me.tBoxApproxPriceYear.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxApproxPriceYear.Name = "tBoxApproxPriceYear"
        Me.tBoxApproxPriceYear.ReadOnly = True
        Me.tBoxApproxPriceYear.Size = New System.Drawing.Size(133, 22)
        Me.tBoxApproxPriceYear.TabIndex = 46
        '
        'btnTaasta
        '
        Me.btnTaasta.Location = New System.Drawing.Point(471, 14)
        Me.btnTaasta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTaasta.Name = "btnTaasta"
        Me.btnTaasta.Size = New System.Drawing.Size(89, 39)
        Me.btnTaasta.TabIndex = 44
        Me.btnTaasta.Text = "Taasta"
        Me.btnTaasta.UseVisualStyleBackColor = True
        '
        'btnSisesta
        '
        Me.btnSisesta.Location = New System.Drawing.Point(364, 14)
        Me.btnSisesta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSisesta.Name = "btnSisesta"
        Me.btnSisesta.Size = New System.Drawing.Size(89, 39)
        Me.btnSisesta.TabIndex = 43
        Me.btnSisesta.Text = "Sisesta"
        Me.btnSisesta.UseVisualStyleBackColor = True
        '
        'lblCents
        '
        Me.lblCents.AutoSize = True
        Me.lblCents.Location = New System.Drawing.Point(507, 210)
        Me.lblCents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCents.Name = "lblCents"
        Me.lblCents.Size = New System.Drawing.Size(42, 17)
        Me.lblCents.TabIndex = 42
        Me.lblCents.Text = "senti "
        '
        'lblKwh24h
        '
        Me.lblKwh24h.AutoSize = True
        Me.lblKwh24h.Location = New System.Drawing.Point(507, 171)
        Me.lblKwh24h.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKwh24h.Name = "lblKwh24h"
        Me.lblKwh24h.Size = New System.Drawing.Size(64, 17)
        Me.lblKwh24h.TabIndex = 41
        Me.lblKwh24h.Text = "kWh 24h"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(507, 105)
        Me.lblMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(30, 17)
        Me.lblMin.TabIndex = 40
        Me.lblMin.Text = "min"
        '
        'lblWatt
        '
        Me.lblWatt.AutoSize = True
        Me.lblWatt.Location = New System.Drawing.Point(507, 65)
        Me.lblWatt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWatt.Name = "lblWatt"
        Me.lblWatt.Size = New System.Drawing.Size(21, 17)
        Me.lblWatt.TabIndex = 39
        Me.lblWatt.Text = "W"
        '
        'lblApplianceResult
        '
        Me.lblApplianceResult.AutoSize = True
        Me.lblApplianceResult.Location = New System.Drawing.Point(23, 28)
        Me.lblApplianceResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApplianceResult.Name = "lblApplianceResult"
        Me.lblApplianceResult.Size = New System.Drawing.Size(66, 17)
        Me.lblApplianceResult.TabIndex = 5
        Me.lblApplianceResult.Text = "Tulemus:"
        '
        'lblElectricityConsumptionRate
        '
        Me.lblElectricityConsumptionRate.AutoSize = True
        Me.lblElectricityConsumptionRate.Location = New System.Drawing.Point(21, 170)
        Me.lblElectricityConsumptionRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElectricityConsumptionRate.Name = "lblElectricityConsumptionRate"
        Me.lblElectricityConsumptionRate.Size = New System.Drawing.Size(202, 17)
        Me.lblElectricityConsumptionRate.TabIndex = 7
        Me.lblElectricityConsumptionRate.Text = "Elektrienergia tarbimise kogus:"
        '
        'tBoxUsageTime
        '
        Me.tBoxUsageTime.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxUsageTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxUsageTime.HideSelection = False
        Me.tBoxUsageTime.Location = New System.Drawing.Point(365, 102)
        Me.tBoxUsageTime.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxUsageTime.Name = "tBoxUsageTime"
        Me.tBoxUsageTime.ReadOnly = True
        Me.tBoxUsageTime.Size = New System.Drawing.Size(133, 22)
        Me.tBoxUsageTime.TabIndex = 38
        '
        'lblRoughPrice
        '
        Me.lblRoughPrice.AutoSize = True
        Me.lblRoughPrice.Location = New System.Drawing.Point(21, 209)
        Me.lblRoughPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoughPrice.Name = "lblRoughPrice"
        Me.lblRoughPrice.Size = New System.Drawing.Size(118, 17)
        Me.lblRoughPrice.TabIndex = 8
        Me.lblRoughPrice.Text = "Orienteeruv hind:"
        '
        'tBoxConsumptionPerHour
        '
        Me.tBoxConsumptionPerHour.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxConsumptionPerHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxConsumptionPerHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tBoxConsumptionPerHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tBoxConsumptionPerHour.HideSelection = False
        Me.tBoxConsumptionPerHour.Location = New System.Drawing.Point(365, 63)
        Me.tBoxConsumptionPerHour.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxConsumptionPerHour.Name = "tBoxConsumptionPerHour"
        Me.tBoxConsumptionPerHour.ReadOnly = True
        Me.tBoxConsumptionPerHour.Size = New System.Drawing.Size(133, 22)
        Me.tBoxConsumptionPerHour.TabIndex = 37
        '
        'tBoxElectricityConsumptionRate
        '
        Me.tBoxElectricityConsumptionRate.BackColor = System.Drawing.Color.White
        Me.tBoxElectricityConsumptionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxElectricityConsumptionRate.Enabled = False
        Me.tBoxElectricityConsumptionRate.ForeColor = System.Drawing.Color.Black
        Me.tBoxElectricityConsumptionRate.Location = New System.Drawing.Point(365, 167)
        Me.tBoxElectricityConsumptionRate.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxElectricityConsumptionRate.Name = "tBoxElectricityConsumptionRate"
        Me.tBoxElectricityConsumptionRate.ReadOnly = True
        Me.tBoxElectricityConsumptionRate.Size = New System.Drawing.Size(133, 22)
        Me.tBoxElectricityConsumptionRate.TabIndex = 16
        '
        'lblUsageTime
        '
        Me.lblUsageTime.AutoSize = True
        Me.lblUsageTime.Location = New System.Drawing.Point(21, 110)
        Me.lblUsageTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsageTime.Name = "lblUsageTime"
        Me.lblUsageTime.Size = New System.Drawing.Size(83, 17)
        Me.lblUsageTime.TabIndex = 36
        Me.lblUsageTime.Text = "Kasutusaeg"
        '
        'tBoxApproxPrice
        '
        Me.tBoxApproxPrice.BackColor = System.Drawing.Color.White
        Me.tBoxApproxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxApproxPrice.Enabled = False
        Me.tBoxApproxPrice.ForeColor = System.Drawing.Color.Black
        Me.tBoxApproxPrice.Location = New System.Drawing.Point(365, 207)
        Me.tBoxApproxPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxApproxPrice.Name = "tBoxApproxPrice"
        Me.tBoxApproxPrice.ReadOnly = True
        Me.tBoxApproxPrice.Size = New System.Drawing.Size(133, 22)
        Me.tBoxApproxPrice.TabIndex = 17
        '
        'lblConsumptionPerHour
        '
        Me.lblConsumptionPerHour.AutoSize = True
        Me.lblConsumptionPerHour.Location = New System.Drawing.Point(23, 70)
        Me.lblConsumptionPerHour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsumptionPerHour.Name = "lblConsumptionPerHour"
        Me.lblConsumptionPerHour.Size = New System.Drawing.Size(133, 17)
        Me.lblConsumptionPerHour.TabIndex = 35
        Me.lblConsumptionPerHour.Text = "Energia kulu tunnis:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdioFridge)
        Me.Panel1.Controls.Add(Me.rdioCoffeeMaker)
        Me.Panel1.Controls.Add(Me.rdioToaster)
        Me.Panel1.Controls.Add(Me.rdioVacuum)
        Me.Panel1.Controls.Add(Me.rdioMixer)
        Me.Panel1.Controls.Add(Me.rdioMicrowave)
        Me.Panel1.Controls.Add(Me.rdioElecStove)
        Me.Panel1.Controls.Add(Me.rdioRouter)
        Me.Panel1.Controls.Add(Me.rdioFoodProcessor)
        Me.Panel1.Controls.Add(Me.rdioSewingMachine)
        Me.Panel1.Controls.Add(Me.rdioTV)
        Me.Panel1.Controls.Add(Me.rdioLED)
        Me.Panel1.Controls.Add(Me.rdioRadio)
        Me.Panel1.Controls.Add(Me.rdioPrinter)
        Me.Panel1.Controls.Add(Me.rdioEggCooker)
        Me.Panel1.Controls.Add(Me.rdioHairDryer)
        Me.Panel1.Controls.Add(Me.rdioComputer)
        Me.Panel1.Location = New System.Drawing.Point(48, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 338)
        Me.Panel1.TabIndex = 39
        '
        'rdioFridge
        '
        Me.rdioFridge.AutoSize = True
        Me.rdioFridge.Location = New System.Drawing.Point(244, 32)
        Me.rdioFridge.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioFridge.Name = "rdioFridge"
        Me.rdioFridge.Size = New System.Drawing.Size(91, 21)
        Me.rdioFridge.TabIndex = 27
        Me.rdioFridge.TabStop = True
        Me.rdioFridge.Text = "Külmkapp"
        Me.rdioFridge.UseVisualStyleBackColor = True
        '
        'rdioCoffeeMaker
        '
        Me.rdioCoffeeMaker.AutoSize = True
        Me.rdioCoffeeMaker.Location = New System.Drawing.Point(33, 32)
        Me.rdioCoffeeMaker.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioCoffeeMaker.Name = "rdioCoffeeMaker"
        Me.rdioCoffeeMaker.Size = New System.Drawing.Size(101, 21)
        Me.rdioCoffeeMaker.TabIndex = 18
        Me.rdioCoffeeMaker.TabStop = True
        Me.rdioCoffeeMaker.Text = "Kohvimasin"
        Me.rdioCoffeeMaker.UseVisualStyleBackColor = True
        '
        'rdioToaster
        '
        Me.rdioToaster.AutoSize = True
        Me.rdioToaster.Location = New System.Drawing.Point(33, 60)
        Me.rdioToaster.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioToaster.Name = "rdioToaster"
        Me.rdioToaster.Size = New System.Drawing.Size(71, 21)
        Me.rdioToaster.TabIndex = 19
        Me.rdioToaster.TabStop = True
        Me.rdioToaster.Text = "Röster"
        Me.rdioToaster.UseVisualStyleBackColor = True
        '
        'rdioVacuum
        '
        Me.rdioVacuum.AutoSize = True
        Me.rdioVacuum.Location = New System.Drawing.Point(33, 89)
        Me.rdioVacuum.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioVacuum.Name = "rdioVacuum"
        Me.rdioVacuum.Size = New System.Drawing.Size(101, 21)
        Me.rdioVacuum.TabIndex = 20
        Me.rdioVacuum.TabStop = True
        Me.rdioVacuum.Text = "Tolmuimeja"
        Me.rdioVacuum.UseVisualStyleBackColor = True
        '
        'rdioMixer
        '
        Me.rdioMixer.AutoSize = True
        Me.rdioMixer.Location = New System.Drawing.Point(33, 117)
        Me.rdioMixer.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioMixer.Name = "rdioMixer"
        Me.rdioMixer.Size = New System.Drawing.Size(70, 21)
        Me.rdioMixer.TabIndex = 21
        Me.rdioMixer.TabStop = True
        Me.rdioMixer.Text = "Mikser"
        Me.rdioMixer.UseVisualStyleBackColor = True
        '
        'rdioMicrowave
        '
        Me.rdioMicrowave.AutoSize = True
        Me.rdioMicrowave.Location = New System.Drawing.Point(244, 230)
        Me.rdioMicrowave.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioMicrowave.Name = "rdioMicrowave"
        Me.rdioMicrowave.Size = New System.Drawing.Size(112, 21)
        Me.rdioMicrowave.TabIndex = 34
        Me.rdioMicrowave.TabStop = True
        Me.rdioMicrowave.Text = "Mikrolaineahi"
        Me.rdioMicrowave.UseVisualStyleBackColor = True
        '
        'rdioElecStove
        '
        Me.rdioElecStove.AutoSize = True
        Me.rdioElecStove.Location = New System.Drawing.Point(33, 145)
        Me.rdioElecStove.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioElecStove.Name = "rdioElecStove"
        Me.rdioElecStove.Size = New System.Drawing.Size(89, 21)
        Me.rdioElecStove.TabIndex = 22
        Me.rdioElecStove.TabStop = True
        Me.rdioElecStove.Text = "Elektripliit"
        Me.rdioElecStove.UseVisualStyleBackColor = True
        '
        'rdioRouter
        '
        Me.rdioRouter.AutoSize = True
        Me.rdioRouter.Location = New System.Drawing.Point(244, 202)
        Me.rdioRouter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioRouter.Name = "rdioRouter"
        Me.rdioRouter.Size = New System.Drawing.Size(72, 21)
        Me.rdioRouter.TabIndex = 33
        Me.rdioRouter.TabStop = True
        Me.rdioRouter.Text = "Ruuter"
        Me.rdioRouter.UseVisualStyleBackColor = True
        '
        'rdioFoodProcessor
        '
        Me.rdioFoodProcessor.AutoSize = True
        Me.rdioFoodProcessor.Location = New System.Drawing.Point(33, 174)
        Me.rdioFoodProcessor.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioFoodProcessor.Name = "rdioFoodProcessor"
        Me.rdioFoodProcessor.Size = New System.Drawing.Size(118, 21)
        Me.rdioFoodProcessor.TabIndex = 23
        Me.rdioFoodProcessor.TabStop = True
        Me.rdioFoodProcessor.Text = "Köögikombain"
        Me.rdioFoodProcessor.UseVisualStyleBackColor = True
        '
        'rdioSewingMachine
        '
        Me.rdioSewingMachine.AutoSize = True
        Me.rdioSewingMachine.Location = New System.Drawing.Point(244, 174)
        Me.rdioSewingMachine.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioSewingMachine.Name = "rdioSewingMachine"
        Me.rdioSewingMachine.Size = New System.Drawing.Size(114, 21)
        Me.rdioSewingMachine.TabIndex = 32
        Me.rdioSewingMachine.TabStop = True
        Me.rdioSewingMachine.Text = "Õmblusmasin"
        Me.rdioSewingMachine.UseVisualStyleBackColor = True
        '
        'rdioTV
        '
        Me.rdioTV.AutoSize = True
        Me.rdioTV.Location = New System.Drawing.Point(33, 202)
        Me.rdioTV.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioTV.Name = "rdioTV"
        Me.rdioTV.Size = New System.Drawing.Size(47, 21)
        Me.rdioTV.TabIndex = 24
        Me.rdioTV.TabStop = True
        Me.rdioTV.Text = "TV"
        Me.rdioTV.UseVisualStyleBackColor = True
        '
        'rdioLED
        '
        Me.rdioLED.AutoSize = True
        Me.rdioLED.Location = New System.Drawing.Point(244, 145)
        Me.rdioLED.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioLED.Name = "rdioLED"
        Me.rdioLED.Size = New System.Drawing.Size(132, 21)
        Me.rdioLED.TabIndex = 31
        Me.rdioLED.TabStop = True
        Me.rdioLED.Text = "Lambipirn (LED)"
        Me.rdioLED.UseVisualStyleBackColor = True
        '
        'rdioRadio
        '
        Me.rdioRadio.AutoSize = True
        Me.rdioRadio.Location = New System.Drawing.Point(33, 230)
        Me.rdioRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioRadio.Name = "rdioRadio"
        Me.rdioRadio.Size = New System.Drawing.Size(74, 21)
        Me.rdioRadio.TabIndex = 25
        Me.rdioRadio.TabStop = True
        Me.rdioRadio.Text = "Raadio"
        Me.rdioRadio.UseVisualStyleBackColor = True
        '
        'rdioPrinter
        '
        Me.rdioPrinter.AutoSize = True
        Me.rdioPrinter.Location = New System.Drawing.Point(244, 117)
        Me.rdioPrinter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioPrinter.Name = "rdioPrinter"
        Me.rdioPrinter.Size = New System.Drawing.Size(71, 21)
        Me.rdioPrinter.TabIndex = 30
        Me.rdioPrinter.TabStop = True
        Me.rdioPrinter.Text = "Printer"
        Me.rdioPrinter.UseVisualStyleBackColor = True
        '
        'rdioEggCooker
        '
        Me.rdioEggCooker.AutoSize = True
        Me.rdioEggCooker.Location = New System.Drawing.Point(33, 258)
        Me.rdioEggCooker.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioEggCooker.Name = "rdioEggCooker"
        Me.rdioEggCooker.Size = New System.Drawing.Size(102, 21)
        Me.rdioEggCooker.TabIndex = 26
        Me.rdioEggCooker.TabStop = True
        Me.rdioEggCooker.Text = "Munakeetja"
        Me.rdioEggCooker.UseVisualStyleBackColor = True
        '
        'rdioHairDryer
        '
        Me.rdioHairDryer.AutoSize = True
        Me.rdioHairDryer.Location = New System.Drawing.Point(244, 89)
        Me.rdioHairDryer.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioHairDryer.Name = "rdioHairDryer"
        Me.rdioHairDryer.Size = New System.Drawing.Size(61, 21)
        Me.rdioHairDryer.TabIndex = 29
        Me.rdioHairDryer.TabStop = True
        Me.rdioHairDryer.Text = "Föön"
        Me.rdioHairDryer.UseVisualStyleBackColor = True
        '
        'rdioComputer
        '
        Me.rdioComputer.AutoSize = True
        Me.rdioComputer.Location = New System.Drawing.Point(244, 60)
        Me.rdioComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.rdioComputer.Name = "rdioComputer"
        Me.rdioComputer.Size = New System.Drawing.Size(65, 21)
        Me.rdioComputer.TabIndex = 28
        Me.rdioComputer.TabStop = True
        Me.rdioComputer.Text = "Arvuti"
        Me.rdioComputer.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(56, 688)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(443, 43)
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Kinnita andmed"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'tBoxPackagePrice
        '
        Me.tBoxPackagePrice.Location = New System.Drawing.Point(273, 612)
        Me.tBoxPackagePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxPackagePrice.Name = "tBoxPackagePrice"
        Me.tBoxPackagePrice.Size = New System.Drawing.Size(132, 22)
        Me.tBoxPackagePrice.TabIndex = 14
        '
        'lblCurrentPackagePrice
        '
        Me.lblCurrentPackagePrice.AutoSize = True
        Me.lblCurrentPackagePrice.Location = New System.Drawing.Point(52, 612)
        Me.lblCurrentPackagePrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentPackagePrice.Name = "lblCurrentPackagePrice"
        Me.lblCurrentPackagePrice.Size = New System.Drawing.Size(167, 17)
        Me.lblCurrentPackagePrice.TabIndex = 10
        Me.lblCurrentPackagePrice.Text = "Kehtiva paketi tunnihind: "
        '
        'lblOptional
        '
        Me.lblOptional.AutoSize = True
        Me.lblOptional.Location = New System.Drawing.Point(61, 473)
        Me.lblOptional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(72, 17)
        Me.lblOptional.TabIndex = 4
        Me.lblOptional.Text = "Valikuline:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 438)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tarvitav võimsus ühes minutis:"
        '
        'lblApplianceChoice
        '
        Me.lblApplianceChoice.AutoSize = True
        Me.lblApplianceChoice.Location = New System.Drawing.Point(149, 27)
        Me.lblApplianceChoice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApplianceChoice.Name = "lblApplianceChoice"
        Me.lblApplianceChoice.Size = New System.Drawing.Size(122, 17)
        Me.lblApplianceChoice.TabIndex = 2
        Me.lblApplianceChoice.Text = "Kodumasina valik:"
        '
        'btnBack1
        '
        Me.btnBack1.Location = New System.Drawing.Point(24, 15)
        Me.btnBack1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(111, 41)
        Me.btnBack1.TabIndex = 1
        Me.btnBack1.Text = "Tagasi"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'tabExchangeComparison
        '
        Me.tabExchangeComparison.Controls.Add(Me.chrtCSV)
        Me.tabExchangeComparison.Controls.Add(Me.btnExport)
        Me.tabExchangeComparison.Controls.Add(Me.btnImport)
        Me.tabExchangeComparison.Controls.Add(Me.lblExchangeComparisonResult)
        Me.tabExchangeComparison.Controls.Add(Me.tBoxCondition2)
        Me.tabExchangeComparison.Controls.Add(Me.tBoxCondition1)
        Me.tabExchangeComparison.Controls.Add(Me.tBoxEndTime)
        Me.tabExchangeComparison.Controls.Add(Me.tboxStartTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblExchangeChoice)
        Me.tabExchangeComparison.Controls.Add(Me.lblCase2)
        Me.tabExchangeComparison.Controls.Add(Me.lblCase1)
        Me.tabExchangeComparison.Controls.Add(Me.lblEnterPrice)
        Me.tabExchangeComparison.Controls.Add(Me.lblEndTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblStartTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblTimePeriodSelection)
        Me.tabExchangeComparison.Controls.Add(Me.btnBack2)
        Me.tabExchangeComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabExchangeComparison.Margin = New System.Windows.Forms.Padding(4)
        Me.tabExchangeComparison.Name = "tabExchangeComparison"
        Me.tabExchangeComparison.Padding = New System.Windows.Forms.Padding(4)
        Me.tabExchangeComparison.Size = New System.Drawing.Size(1268, 769)
        Me.tabExchangeComparison.TabIndex = 3
        Me.tabExchangeComparison.Text = "Börsihinna võrdlus"
        Me.tabExchangeComparison.UseVisualStyleBackColor = True
        '
        'chrtCSV
        '
        ChartArea3.Name = "ChartArea1"
        Me.chrtCSV.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chrtCSV.Legends.Add(Legend3)
        Me.chrtCSV.Location = New System.Drawing.Point(4, 350)
        Me.chrtCSV.Margin = New System.Windows.Forms.Padding(4)
        Me.chrtCSV.Name = "chrtCSV"
        Me.chrtCSV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chrtCSV.Size = New System.Drawing.Size(1253, 359)
        Me.chrtCSV.TabIndex = 20
        Me.chrtCSV.Text = "CSV"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(316, 295)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 42)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(171, 295)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(112, 42)
        Me.btnImport.TabIndex = 17
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lblExchangeComparisonResult
        '
        Me.lblExchangeComparisonResult.AutoSize = True
        Me.lblExchangeComparisonResult.Location = New System.Drawing.Point(548, 27)
        Me.lblExchangeComparisonResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExchangeComparisonResult.Name = "lblExchangeComparisonResult"
        Me.lblExchangeComparisonResult.Size = New System.Drawing.Size(66, 17)
        Me.lblExchangeComparisonResult.TabIndex = 15
        Me.lblExchangeComparisonResult.Text = "Tulemus:"
        '
        'tBoxCondition2
        '
        Me.tBoxCondition2.Location = New System.Drawing.Point(263, 194)
        Me.tBoxCondition2.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxCondition2.Name = "tBoxCondition2"
        Me.tBoxCondition2.Size = New System.Drawing.Size(132, 22)
        Me.tBoxCondition2.TabIndex = 14
        '
        'tBoxCondition1
        '
        Me.tBoxCondition1.Location = New System.Drawing.Point(263, 162)
        Me.tBoxCondition1.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxCondition1.Name = "tBoxCondition1"
        Me.tBoxCondition1.Size = New System.Drawing.Size(132, 22)
        Me.tBoxCondition1.TabIndex = 13
        '
        'tBoxEndTime
        '
        Me.tBoxEndTime.Location = New System.Drawing.Point(263, 96)
        Me.tBoxEndTime.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxEndTime.Name = "tBoxEndTime"
        Me.tBoxEndTime.Size = New System.Drawing.Size(132, 22)
        Me.tBoxEndTime.TabIndex = 12
        '
        'tboxStartTime
        '
        Me.tboxStartTime.Location = New System.Drawing.Point(263, 64)
        Me.tboxStartTime.Margin = New System.Windows.Forms.Padding(4)
        Me.tboxStartTime.Name = "tboxStartTime"
        Me.tboxStartTime.Size = New System.Drawing.Size(132, 22)
        Me.tboxStartTime.TabIndex = 11
        '
        'lblExchangeChoice
        '
        Me.lblExchangeChoice.AutoSize = True
        Me.lblExchangeChoice.Location = New System.Drawing.Point(143, 257)
        Me.lblExchangeChoice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExchangeChoice.Name = "lblExchangeChoice"
        Me.lblExchangeChoice.Size = New System.Drawing.Size(72, 17)
        Me.lblExchangeChoice.TabIndex = 8
        Me.lblExchangeChoice.Text = "Valikuline:"
        '
        'lblCase2
        '
        Me.lblCase2.AutoSize = True
        Me.lblCase2.Location = New System.Drawing.Point(143, 198)
        Me.lblCase2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCase2.Name = "lblCase2"
        Me.lblCase2.Size = New System.Drawing.Size(81, 17)
        Me.lblCase2.TabIndex = 7
        Me.lblCase2.Text = "Tingimus 2:"
        '
        'lblCase1
        '
        Me.lblCase1.AutoSize = True
        Me.lblCase1.Location = New System.Drawing.Point(143, 166)
        Me.lblCase1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCase1.Name = "lblCase1"
        Me.lblCase1.Size = New System.Drawing.Size(81, 17)
        Me.lblCase1.TabIndex = 6
        Me.lblCase1.Text = "Tingimus 1:"
        '
        'lblEnterPrice
        '
        Me.lblEnterPrice.AutoSize = True
        Me.lblEnterPrice.Location = New System.Drawing.Point(143, 137)
        Me.lblEnterPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnterPrice.Name = "lblEnterPrice"
        Me.lblEnterPrice.Size = New System.Drawing.Size(205, 17)
        Me.lblEnterPrice.TabIndex = 5
        Me.lblEnterPrice.Text = "Sisesta hinnastamistingimused:"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(143, 100)
        Me.lblEndTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(68, 17)
        Me.lblEndTime.TabIndex = 4
        Me.lblEndTime.Text = "Lõppaeg:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(143, 68)
        Me.lblStartTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(71, 17)
        Me.lblStartTime.TabIndex = 3
        Me.lblStartTime.Text = "Algusaeg:"
        '
        'lblTimePeriodSelection
        '
        Me.lblTimePeriodSelection.AutoSize = True
        Me.lblTimePeriodSelection.Location = New System.Drawing.Point(143, 27)
        Me.lblTimePeriodSelection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimePeriodSelection.Name = "lblTimePeriodSelection"
        Me.lblTimePeriodSelection.Size = New System.Drawing.Size(124, 17)
        Me.lblTimePeriodSelection.TabIndex = 2
        Me.lblTimePeriodSelection.Text = "Ajavahemiku valik:"
        '
        'btnBack2
        '
        Me.btnBack2.Location = New System.Drawing.Point(24, 15)
        Me.btnBack2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(111, 41)
        Me.btnBack2.TabIndex = 1
        Me.btnBack2.Text = "Tagasi"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'tabConsumptionHistory
        '
        Me.tabConsumptionHistory.Controls.Add(Me.btnSimulateConsumptionHistory)
        Me.tabConsumptionHistory.Controls.Add(Me.TabControl2)
        Me.tabConsumptionHistory.Controls.Add(Me.btnClientConsumptionHistory)
        Me.tabConsumptionHistory.Controls.Add(Me.btnBack3)
        Me.tabConsumptionHistory.Location = New System.Drawing.Point(4, 26)
        Me.tabConsumptionHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.tabConsumptionHistory.Name = "tabConsumptionHistory"
        Me.tabConsumptionHistory.Padding = New System.Windows.Forms.Padding(4)
        Me.tabConsumptionHistory.Size = New System.Drawing.Size(1268, 769)
        Me.tabConsumptionHistory.TabIndex = 4
        Me.tabConsumptionHistory.Text = "Tarbimise ajalugu"
        Me.tabConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnSimulateConsumptionHistory
        '
        Me.btnSimulateConsumptionHistory.Location = New System.Drawing.Point(359, 21)
        Me.btnSimulateConsumptionHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimulateConsumptionHistory.Name = "btnSimulateConsumptionHistory"
        Me.btnSimulateConsumptionHistory.Size = New System.Drawing.Size(173, 98)
        Me.btnSimulateConsumptionHistory.TabIndex = 1
        Me.btnSimulateConsumptionHistory.Text = "Elektripakettide börsihindade ajalugu"
        Me.btnSimulateConsumptionHistory.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabBlank)
        Me.TabControl2.Controls.Add(Me.tabClientConsumptionHistory)
        Me.TabControl2.Controls.Add(Me.tabSimulateExchangeHistory)
        Me.TabControl2.ItemSize = New System.Drawing.Size(42, 25)
        Me.TabControl2.Location = New System.Drawing.Point(0, 130)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1167, 608)
        Me.TabControl2.TabIndex = 2
        '
        'tabBlank
        '
        Me.tabBlank.Location = New System.Drawing.Point(4, 29)
        Me.tabBlank.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBlank.Name = "tabBlank"
        Me.tabBlank.Padding = New System.Windows.Forms.Padding(4)
        Me.tabBlank.Size = New System.Drawing.Size(1159, 575)
        Me.tabBlank.TabIndex = 0
        Me.tabBlank.Text = "Blank"
        Me.tabBlank.UseVisualStyleBackColor = True
        '
        'tabClientConsumptionHistory
        '
        Me.tabClientConsumptionHistory.Controls.Add(Me.btnConfirmSimuCSV)
        Me.tabClientConsumptionHistory.Controls.Add(Me.tbDebug)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblToDateTime)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblFromDateTime)
        Me.tabClientConsumptionHistory.Controls.Add(Me.dtpEnd)
        Me.tabClientConsumptionHistory.Controls.Add(Me.dtpBeginning)
        Me.tabClientConsumptionHistory.Controls.Add(Me.chrt)
        Me.tabClientConsumptionHistory.Controls.Add(Me.Label2)
        Me.tabClientConsumptionHistory.Controls.Add(Me.btnImportCSVFileSimu)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblSimulateClientConsumptionHistory)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblConsumptionGraph)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblClientConsumptionHistoryResult)
        Me.tabClientConsumptionHistory.Location = New System.Drawing.Point(4, 29)
        Me.tabClientConsumptionHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.tabClientConsumptionHistory.Name = "tabClientConsumptionHistory"
        Me.tabClientConsumptionHistory.Padding = New System.Windows.Forms.Padding(4)
        Me.tabClientConsumptionHistory.Size = New System.Drawing.Size(1159, 575)
        Me.tabClientConsumptionHistory.TabIndex = 1
        Me.tabClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        Me.tabClientConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnConfirmSimuCSV
        '
        Me.btnConfirmSimuCSV.Location = New System.Drawing.Point(68, 361)
        Me.btnConfirmSimuCSV.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmSimuCSV.Name = "btnConfirmSimuCSV"
        Me.btnConfirmSimuCSV.Size = New System.Drawing.Size(200, 42)
        Me.btnConfirmSimuCSV.TabIndex = 16
        Me.btnConfirmSimuCSV.Text = "Kinnita andmed"
        Me.btnConfirmSimuCSV.UseVisualStyleBackColor = True
        '
        'tbDebug
        '
        Me.tbDebug.Location = New System.Drawing.Point(463, 79)
        Me.tbDebug.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDebug.Multiline = True
        Me.tbDebug.Name = "tbDebug"
        Me.tbDebug.ReadOnly = True
        Me.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDebug.Size = New System.Drawing.Size(573, 427)
        Me.tbDebug.TabIndex = 15
        '
        'lblToDateTime
        '
        Me.lblToDateTime.AutoSize = True
        Me.lblToDateTime.Location = New System.Drawing.Point(64, 268)
        Me.lblToDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDateTime.Name = "lblToDateTime"
        Me.lblToDateTime.Size = New System.Drawing.Size(124, 17)
        Me.lblToDateTime.TabIndex = 14
        Me.lblToDateTime.Text = "Vali lõpp kuupäev:"
        '
        'lblFromDateTime
        '
        Me.lblFromDateTime.AutoSize = True
        Me.lblFromDateTime.Location = New System.Drawing.Point(64, 182)
        Me.lblFromDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromDateTime.Name = "lblFromDateTime"
        Me.lblFromDateTime.Size = New System.Drawing.Size(131, 17)
        Me.lblFromDateTime.TabIndex = 13
        Me.lblFromDateTime.Text = "Vali algus kuupäev:"
        '
        'dtpEnd
        '
        Me.dtpEnd.Enabled = False
        Me.dtpEnd.Location = New System.Drawing.Point(68, 304)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(265, 22)
        Me.dtpEnd.TabIndex = 12
        '
        'dtpBeginning
        '
        Me.dtpBeginning.Enabled = False
        Me.dtpBeginning.Location = New System.Drawing.Point(67, 214)
        Me.dtpBeginning.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBeginning.Name = "dtpBeginning"
        Me.dtpBeginning.Size = New System.Drawing.Size(265, 22)
        Me.dtpBeginning.TabIndex = 11
        '
        'chrt
        '
        ChartArea4.Name = "ChartArea1"
        Me.chrt.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chrt.Legends.Add(Legend4)
        Me.chrt.Location = New System.Drawing.Point(39, 431)
        Me.chrt.Margin = New System.Windows.Forms.Padding(4)
        Me.chrt.Name = "chrt"
        Me.chrt.Size = New System.Drawing.Size(325, 111)
        Me.chrt.TabIndex = 10
        Me.chrt.Text = "chrtSimuHistory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lae üles enda tarbimisajalugu(CSV):"
        '
        'btnImportCSVFileSimu
        '
        Me.btnImportCSVFileSimu.Location = New System.Drawing.Point(68, 90)
        Me.btnImportCSVFileSimu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportCSVFileSimu.Name = "btnImportCSVFileSimu"
        Me.btnImportCSVFileSimu.Size = New System.Drawing.Size(200, 42)
        Me.btnImportCSVFileSimu.TabIndex = 7
        Me.btnImportCSVFileSimu.Text = "Impordi CSV fail"
        Me.btnImportCSVFileSimu.UseVisualStyleBackColor = True
        '
        'lblSimulateClientConsumptionHistory
        '
        Me.lblSimulateClientConsumptionHistory.AutoSize = True
        Me.lblSimulateClientConsumptionHistory.Location = New System.Drawing.Point(64, 28)
        Me.lblSimulateClientConsumptionHistory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSimulateClientConsumptionHistory.Name = "lblSimulateClientConsumptionHistory"
        Me.lblSimulateClientConsumptionHistory.Size = New System.Drawing.Size(208, 17)
        Me.lblSimulateClientConsumptionHistory.TabIndex = 6
        Me.lblSimulateClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        '
        'lblConsumptionGraph
        '
        Me.lblConsumptionGraph.AutoSize = True
        Me.lblConsumptionGraph.Location = New System.Drawing.Point(452, 59)
        Me.lblConsumptionGraph.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsumptionGraph.Name = "lblConsumptionGraph"
        Me.lblConsumptionGraph.Size = New System.Drawing.Size(105, 17)
        Me.lblConsumptionGraph.TabIndex = 4
        Me.lblConsumptionGraph.Text = "Tarbimisgraafik"
        '
        'lblClientConsumptionHistoryResult
        '
        Me.lblClientConsumptionHistoryResult.AutoSize = True
        Me.lblClientConsumptionHistoryResult.Location = New System.Drawing.Point(451, 31)
        Me.lblClientConsumptionHistoryResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientConsumptionHistoryResult.Name = "lblClientConsumptionHistoryResult"
        Me.lblClientConsumptionHistoryResult.Size = New System.Drawing.Size(66, 17)
        Me.lblClientConsumptionHistoryResult.TabIndex = 3
        Me.lblClientConsumptionHistoryResult.Text = "Tulemus:"
        '
        'tabSimulateExchangeHistory
        '
        Me.tabSimulateExchangeHistory.Controls.Add(Me.lblExchangePackageHistory)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.Label8)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.btnSeeHistory)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.tBoxMonthlyCost2)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.Label9)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.RadioButton3)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.RadioButton4)
        Me.tabSimulateExchangeHistory.Controls.Add(Me.Label10)
        Me.tabSimulateExchangeHistory.Location = New System.Drawing.Point(4, 29)
        Me.tabSimulateExchangeHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSimulateExchangeHistory.Name = "tabSimulateExchangeHistory"
        Me.tabSimulateExchangeHistory.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSimulateExchangeHistory.Size = New System.Drawing.Size(1159, 575)
        Me.tabSimulateExchangeHistory.TabIndex = 2
        Me.tabSimulateExchangeHistory.Text = "Elektripakettide börsihindade ajalugu"
        Me.tabSimulateExchangeHistory.UseVisualStyleBackColor = True
        '
        'lblExchangePackageHistory
        '
        Me.lblExchangePackageHistory.AutoSize = True
        Me.lblExchangePackageHistory.Location = New System.Drawing.Point(64, 28)
        Me.lblExchangePackageHistory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExchangePackageHistory.Name = "lblExchangePackageHistory"
        Me.lblExchangePackageHistory.Size = New System.Drawing.Size(241, 17)
        Me.lblExchangePackageHistory.TabIndex = 20
        Me.lblExchangePackageHistory.Text = "Elektripakettide börsihindade ajalugu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(685, 178)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tulemus:"
        '
        'btnSeeHistory
        '
        Me.btnSeeHistory.Location = New System.Drawing.Point(267, 297)
        Me.btnSeeHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeeHistory.Name = "btnSeeHistory"
        Me.btnSeeHistory.Size = New System.Drawing.Size(100, 28)
        Me.btnSeeHistory.TabIndex = 18
        Me.btnSeeHistory.Text = "Kuva ajalugu"
        Me.btnSeeHistory.UseVisualStyleBackColor = True
        '
        'tBoxMonthlyCost2
        '
        Me.tBoxMonthlyCost2.Location = New System.Drawing.Point(233, 245)
        Me.tBoxMonthlyCost2.Margin = New System.Windows.Forms.Padding(4)
        Me.tBoxMonthlyCost2.Name = "tBoxMonthlyCost2"
        Me.tBoxMonthlyCost2.Size = New System.Drawing.Size(132, 22)
        Me.tBoxMonthlyCost2.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 249)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Kuutasu"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(235, 178)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(129, 21)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Fikseeritud hind"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(68, 178)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(88, 21)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Börsihind"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 94)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Kehtiva paketi andmete sisestus:"
        '
        'btnClientConsumptionHistory
        '
        Me.btnClientConsumptionHistory.Location = New System.Drawing.Point(177, 21)
        Me.btnClientConsumptionHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientConsumptionHistory.Name = "btnClientConsumptionHistory"
        Me.btnClientConsumptionHistory.Size = New System.Drawing.Size(173, 98)
        Me.btnClientConsumptionHistory.TabIndex = 0
        Me.btnClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        Me.btnClientConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnBack3
        '
        Me.btnBack3.Location = New System.Drawing.Point(24, 15)
        Me.btnBack3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(111, 41)
        Me.btnBack3.TabIndex = 1
        Me.btnBack3.Text = "Tagasi"
        Me.btnBack3.UseVisualStyleBackColor = True
        '
        'tabPackageComparison
        '
        Me.tabPackageComparison.Controls.Add(Me.Label11)
        Me.tabPackageComparison.Controls.Add(Me.Label7)
        Me.tabPackageComparison.Controls.Add(Me.Label5)
        Me.tabPackageComparison.Controls.Add(Me.Label4)
        Me.tabPackageComparison.Controls.Add(Me.priceOfCont2)
        Me.tabPackageComparison.Controls.Add(Me.compTwo)
        Me.tabPackageComparison.Controls.Add(Me.priceOfCont)
        Me.tabPackageComparison.Controls.Add(Me.compOne)
        Me.tabPackageComparison.Controls.Add(Me.btnTwoPackets)
        Me.tabPackageComparison.Controls.Add(Me.btnPackets)
        Me.tabPackageComparison.Controls.Add(Me.chartPackages)
        Me.tabPackageComparison.Controls.Add(Me.lblComparisonResult)
        Me.tabPackageComparison.Controls.Add(Me.cBoxPackage2)
        Me.tabPackageComparison.Controls.Add(Me.cBoxPackage1)
        Me.tabPackageComparison.Controls.Add(Me.Label6)
        Me.tabPackageComparison.Controls.Add(Me.lblPackage1)
        Me.tabPackageComparison.Controls.Add(Me.lblChoosePackages)
        Me.tabPackageComparison.Controls.Add(Me.btnBack4)
        Me.tabPackageComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabPackageComparison.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPackageComparison.Name = "tabPackageComparison"
        Me.tabPackageComparison.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPackageComparison.Size = New System.Drawing.Size(1268, 769)
        Me.tabPackageComparison.TabIndex = 5
        Me.tabPackageComparison.Text = "Elektripakettide võrdlus"
        Me.tabPackageComparison.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 431)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Lepingu kuutasu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 379)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Firma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 272)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Lepingu kuutasu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Firma"
        '
        'priceOfCont2
        '
        Me.priceOfCont2.Location = New System.Drawing.Point(295, 422)
        Me.priceOfCont2.Margin = New System.Windows.Forms.Padding(4)
        Me.priceOfCont2.Name = "priceOfCont2"
        Me.priceOfCont2.ReadOnly = True
        Me.priceOfCont2.Size = New System.Drawing.Size(132, 22)
        Me.priceOfCont2.TabIndex = 15
        '
        'compTwo
        '
        Me.compTwo.Location = New System.Drawing.Point(295, 370)
        Me.compTwo.Margin = New System.Windows.Forms.Padding(4)
        Me.compTwo.Name = "compTwo"
        Me.compTwo.ReadOnly = True
        Me.compTwo.Size = New System.Drawing.Size(132, 22)
        Me.compTwo.TabIndex = 14
        '
        'priceOfCont
        '
        Me.priceOfCont.Location = New System.Drawing.Point(295, 263)
        Me.priceOfCont.Margin = New System.Windows.Forms.Padding(4)
        Me.priceOfCont.Name = "priceOfCont"
        Me.priceOfCont.ReadOnly = True
        Me.priceOfCont.Size = New System.Drawing.Size(132, 22)
        Me.priceOfCont.TabIndex = 13
        '
        'compOne
        '
        Me.compOne.HideSelection = False
        Me.compOne.Location = New System.Drawing.Point(295, 218)
        Me.compOne.Margin = New System.Windows.Forms.Padding(4)
        Me.compOne.Name = "compOne"
        Me.compOne.ReadOnly = True
        Me.compOne.Size = New System.Drawing.Size(132, 22)
        Me.compOne.TabIndex = 12
        '
        'btnTwoPackets
        '
        Me.btnTwoPackets.Location = New System.Drawing.Point(237, 556)
        Me.btnTwoPackets.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTwoPackets.Name = "btnTwoPackets"
        Me.btnTwoPackets.Size = New System.Drawing.Size(203, 64)
        Me.btnTwoPackets.TabIndex = 11
        Me.btnTwoPackets.Text = "Võrdle kahte paketti"
        Me.btnTwoPackets.UseVisualStyleBackColor = True
        '
        'btnPackets
        '
        Me.btnPackets.Location = New System.Drawing.Point(24, 556)
        Me.btnPackets.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPackets.Name = "btnPackets"
        Me.btnPackets.Size = New System.Drawing.Size(203, 64)
        Me.btnPackets.TabIndex = 10
        Me.btnPackets.Text = "Võrdle kõiki pakette"
        Me.btnPackets.UseVisualStyleBackColor = True
        '
        'chartPackages
        '
        ChartArea5.Name = "ChartArea1"
        Me.chartPackages.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chartPackages.Legends.Add(Legend5)
        Me.chartPackages.Location = New System.Drawing.Point(459, 128)
        Me.chartPackages.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chartPackages.Name = "chartPackages"
        Me.chartPackages.Size = New System.Drawing.Size(800, 492)
        Me.chartPackages.TabIndex = 9
        '
        'lblComparisonResult
        '
        Me.lblComparisonResult.AutoSize = True
        Me.lblComparisonResult.Location = New System.Drawing.Point(455, 79)
        Me.lblComparisonResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComparisonResult.Name = "lblComparisonResult"
        Me.lblComparisonResult.Size = New System.Drawing.Size(66, 17)
        Me.lblComparisonResult.TabIndex = 7
        Me.lblComparisonResult.Text = "Tulemus:"
        '
        'cBoxPackage2
        '
        Me.cBoxPackage2.FormattingEnabled = True
        Me.cBoxPackage2.Items.AddRange(New Object() {"Kindel 6", "Kindel 36", "Kindel Pluss", "Muutuv", "Universaalteenus", "Pingevaba + Ühisarve", "Tähtajaline fikseeritud hind", "Kodupakett börsihinnaga", "Universaalteenus Alexela", "Universaalteenus Alexela + roheline", "Tähtajaline fikseeritud hind + roheline", "220 Börsihind", "220 Börsihind + Roheline", "220 Tähtajaline kindel hind", "220 Tähtajaline kindel hind + roheline", "220 Universaalteenus", "220 Universaalteenus + roheline", "Kindel pakett gaas", "Muutuvhinnaga pakett", "Universaalteenus Eesti gaas", "Universaalteenus VKG", "Not-fix", "Roheline Klõps", "Roheline Börsi Klõps", "Börsi Klõps", "Universaalteenus Elektrum", "Kaljukindel Klõps kindlustusega"})
        Me.cBoxPackage2.Location = New System.Drawing.Point(237, 324)
        Me.cBoxPackage2.Margin = New System.Windows.Forms.Padding(4)
        Me.cBoxPackage2.Name = "cBoxPackage2"
        Me.cBoxPackage2.Size = New System.Drawing.Size(189, 24)
        Me.cBoxPackage2.TabIndex = 6
        '
        'cBoxPackage1
        '
        Me.cBoxPackage1.FormattingEnabled = True
        Me.cBoxPackage1.Items.AddRange(New Object() {"Kindel 6", "Kindel 36", "Kindel Pluss", "Muutuv", "Universaalteenus", "Pingevaba + Ühisarve", "Tähtajaline fikseeritud hind", "Kodupakett börsihinnaga", "Universaalteenus Alexela", "Universaalteenus Alexela + roheline", "Tähtajaline fikseeritud hind + roheline", "220 Börsihind", "220 Börsihind + Roheline", "220 Tähtajaline kindel hind", "220 Tähtajaline kindel hind + roheline", "220 Universaalteenus", "220 Universaalteenus + roheline", "Kindel pakett gaas", "Muutuvhinnaga pakett", "Universaalteenus Eesti gaas", "Universaalteenus VKG", "Not-fix", "Roheline Klõps", "Roheline Börsi Klõps", "Börsi Klõps", "Universaalteenus Elektrum", "Kaljukindel Klõps kindlustusega"})
        Me.cBoxPackage1.Location = New System.Drawing.Point(237, 171)
        Me.cBoxPackage1.Margin = New System.Windows.Forms.Padding(4)
        Me.cBoxPackage1.Name = "cBoxPackage1"
        Me.cBoxPackage1.Size = New System.Drawing.Size(189, 24)
        Me.cBoxPackage1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 327)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Elektripakett 2:"
        '
        'lblPackage1
        '
        Me.lblPackage1.AutoSize = True
        Me.lblPackage1.Location = New System.Drawing.Point(71, 171)
        Me.lblPackage1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPackage1.Name = "lblPackage1"
        Me.lblPackage1.Size = New System.Drawing.Size(102, 17)
        Me.lblPackage1.TabIndex = 3
        Me.lblPackage1.Text = "Elektripakett 1:"
        '
        'lblChoosePackages
        '
        Me.lblChoosePackages.AutoSize = True
        Me.lblChoosePackages.Location = New System.Drawing.Point(71, 79)
        Me.lblChoosePackages.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChoosePackages.Name = "lblChoosePackages"
        Me.lblChoosePackages.Size = New System.Drawing.Size(123, 17)
        Me.lblChoosePackages.TabIndex = 2
        Me.lblChoosePackages.Text = "Vali elektripaketid:"
        '
        'btnBack4
        '
        Me.btnBack4.Location = New System.Drawing.Point(24, 15)
        Me.btnBack4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(111, 41)
        Me.btnBack4.TabIndex = 1
        Me.btnBack4.Text = "Tagasi"
        Me.btnBack4.UseVisualStyleBackColor = True
        '
        'tabGreenEnergy
        '
        Me.tabGreenEnergy.Controls.Add(Me.Label14)
        Me.tabGreenEnergy.Controls.Add(Me.Label13)
        Me.tabGreenEnergy.Controls.Add(Me.Label12)
        Me.tabGreenEnergy.Controls.Add(Me.tbOpinion)
        Me.tabGreenEnergy.Controls.Add(Me.btnProduction)
        Me.tabGreenEnergy.Controls.Add(Me.tbProduction)
        Me.tabGreenEnergy.Controls.Add(Me.btnWeather)
        Me.tabGreenEnergy.Controls.Add(Me.tbWeather)
        Me.tabGreenEnergy.Location = New System.Drawing.Point(4, 26)
        Me.tabGreenEnergy.Name = "tabGreenEnergy"
        Me.tabGreenEnergy.Size = New System.Drawing.Size(1268, 769)
        Me.tabGreenEnergy.TabIndex = 6
        Me.tabGreenEnergy.Text = "Ilm ja roheline energia"
        Me.tabGreenEnergy.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Tootmine"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 17)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Ilm"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(563, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Hinnang tootmisele"
        '
        'tbOpinion
        '
        Me.tbOpinion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbOpinion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOpinion.Location = New System.Drawing.Point(563, 142)
        Me.tbOpinion.Multiline = True
        Me.tbOpinion.Name = "tbOpinion"
        Me.tbOpinion.ReadOnly = True
        Me.tbOpinion.Size = New System.Drawing.Size(444, 222)
        Me.tbOpinion.TabIndex = 4
        '
        'btnProduction
        '
        Me.btnProduction.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnProduction.Location = New System.Drawing.Point(358, 344)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(113, 72)
        Me.btnProduction.TabIndex = 3
        Me.btnProduction.Text = "Tootmine"
        Me.btnProduction.UseVisualStyleBackColor = False
        '
        'tbProduction
        '
        Me.tbProduction.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProduction.Location = New System.Drawing.Point(43, 280)
        Me.tbProduction.Multiline = True
        Me.tbProduction.Name = "tbProduction"
        Me.tbProduction.ReadOnly = True
        Me.tbProduction.Size = New System.Drawing.Size(244, 136)
        Me.tbProduction.TabIndex = 2
        '
        'btnWeather
        '
        Me.btnWeather.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnWeather.Location = New System.Drawing.Point(367, 104)
        Me.btnWeather.Name = "btnWeather"
        Me.btnWeather.Size = New System.Drawing.Size(113, 72)
        Me.btnWeather.TabIndex = 1
        Me.btnWeather.Text = "Ilm Tallinnas Praegu"
        Me.btnWeather.UseVisualStyleBackColor = False
        '
        'tbWeather
        '
        Me.tbWeather.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWeather.Location = New System.Drawing.Point(43, 40)
        Me.tbWeather.Multiline = True
        Me.tbWeather.Name = "tbWeather"
        Me.tbWeather.ReadOnly = True
        Me.tbWeather.Size = New System.Drawing.Size(244, 136)
        Me.tbWeather.TabIndex = 0
        '
        'lblChangeFontSize
        '
        Me.lblChangeFontSize.AutoSize = True
        Me.lblChangeFontSize.Location = New System.Drawing.Point(171, 16)
        Me.lblChangeFontSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChangeFontSize.Name = "lblChangeFontSize"
        Me.lblChangeFontSize.Size = New System.Drawing.Size(179, 17)
        Me.lblChangeFontSize.TabIndex = 7
        Me.lblChangeFontSize.Text = "MUUDA FONDI SUURUST:"
        '
        'btnFontIncrease
        '
        Me.btnFontIncrease.Location = New System.Drawing.Point(431, 7)
        Me.btnFontIncrease.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFontIncrease.Name = "btnFontIncrease"
        Me.btnFontIncrease.Size = New System.Drawing.Size(31, 33)
        Me.btnFontIncrease.TabIndex = 8
        Me.btnFontIncrease.Text = "+"
        Me.btnFontIncrease.UseVisualStyleBackColor = True
        '
        'btnFontDecrease
        '
        Me.btnFontDecrease.Location = New System.Drawing.Point(469, 7)
        Me.btnFontDecrease.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFontDecrease.Name = "btnFontDecrease"
        Me.btnFontDecrease.Size = New System.Drawing.Size(31, 33)
        Me.btnFontDecrease.TabIndex = 9
        Me.btnFontDecrease.Text = "-"
        Me.btnFontDecrease.UseVisualStyleBackColor = True
        '
        'btnRestoreFontSize
        '
        Me.btnRestoreFontSize.Location = New System.Drawing.Point(508, 7)
        Me.btnRestoreFontSize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestoreFontSize.Name = "btnRestoreFontSize"
        Me.btnRestoreFontSize.Size = New System.Drawing.Size(224, 33)
        Me.btnRestoreFontSize.TabIndex = 10
        Me.btnRestoreFontSize.Text = "Taasta fondi suurus"
        Me.btnRestoreFontSize.UseVisualStyleBackColor = True
        '
        'GUIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 859)
        Me.Controls.Add(Me.btnRestoreFontSize)
        Me.Controls.Add(Me.btnFontDecrease)
        Me.Controls.Add(Me.btnFontIncrease)
        Me.Controls.Add(Me.lblChangeFontSize)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GUIMain"
        Me.Text = "Elektri paketi kalkulaator"
        Me.TabControl1.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        CType(Me.chrtFrontPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPackageHourlyRate.ResumeLayout(False)
        Me.tabPackageHourlyRate.PerformLayout()
        CType(Me.chrtPackageHourlyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPriceTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabApplianceCalc.ResumeLayout(False)
        Me.tabApplianceCalc.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabExchangeComparison.ResumeLayout(False)
        Me.tabExchangeComparison.PerformLayout()
        CType(Me.chrtCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsumptionHistory.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tabClientConsumptionHistory.ResumeLayout(False)
        Me.tabClientConsumptionHistory.PerformLayout()
        CType(Me.chrt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSimulateExchangeHistory.ResumeLayout(False)
        Me.tabSimulateExchangeHistory.PerformLayout()
        Me.tabPackageComparison.ResumeLayout(False)
        Me.tabPackageComparison.PerformLayout()
        CType(Me.chartPackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGreenEnergy.ResumeLayout(False)
        Me.tabGreenEnergy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnPackageHourlyRate As Button
    Friend WithEvents btnApplianceCalc As Button
    Friend WithEvents btnExchangePriceComparison As Button
    Friend WithEvents btnConsumptionHistory As Button
    Friend WithEvents btnPackageComparison As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Main As TabPage
    Friend WithEvents tabPackageHourlyRate As TabPage
    Friend WithEvents btnBack0 As Button
    Friend WithEvents tabApplianceCalc As TabPage
    Friend WithEvents tabExchangeComparison As TabPage
    Friend WithEvents tabConsumptionHistory As TabPage
    Friend WithEvents tabPackageComparison As TabPage
    Friend WithEvents btnBack1 As Button
    Friend WithEvents btnBack2 As Button
    Friend WithEvents btnBack3 As Button
    Friend WithEvents btnBack4 As Button
    Friend WithEvents lblPackageHourly As Label
    Friend WithEvents rdioExchange As RadioButton
    Friend WithEvents lblPriceGraph As Label
    Friend WithEvents lblPriceTable As Label
    Friend WithEvents lblPackageHourlyRate As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnConfirmInput As Button
    Friend WithEvents tboxMonthlyCost As TextBox
    Friend WithEvents lblMonthlyCost As Label
    Friend WithEvents rdioFixedPrice As RadioButton
    Friend WithEvents tBoxPackageHourlyRate As TextBox
    Friend WithEvents lblRoughPrice As Label
    Friend WithEvents lblElectricityConsumptionRate As Label
    Friend WithEvents lblOptional As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblApplianceChoice As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents tBoxPackagePrice As TextBox
    Friend WithEvents rdioFixedPrice1 As RadioButton
    Friend WithEvents rdioExchangePrice As RadioButton
    Friend WithEvents lblCurrentPackagePrice As Label
    Friend WithEvents lblApplianceResult As Label
    Friend WithEvents rdioEggCooker As RadioButton
    Friend WithEvents rdioRadio As RadioButton
    Friend WithEvents rdioTV As RadioButton
    Friend WithEvents rdioFoodProcessor As RadioButton
    Friend WithEvents rdioElecStove As RadioButton
    Friend WithEvents rdioMixer As RadioButton
    Friend WithEvents rdioVacuum As RadioButton
    Friend WithEvents rdioToaster As RadioButton
    Friend WithEvents rdioCoffeeMaker As RadioButton
    Friend WithEvents tBoxApproxPrice As TextBox
    Friend WithEvents tBoxElectricityConsumptionRate As TextBox
    Friend WithEvents rdioLED As RadioButton
    Friend WithEvents rdioPrinter As RadioButton
    Friend WithEvents rdioHairDryer As RadioButton
    Friend WithEvents rdioComputer As RadioButton
    Friend WithEvents rdioFridge As RadioButton
    Friend WithEvents rdioMicrowave As RadioButton
    Friend WithEvents rdioRouter As RadioButton
    Friend WithEvents rdioSewingMachine As RadioButton
    Friend WithEvents lblExchangeChoice As Label
    Friend WithEvents lblCase2 As Label
    Friend WithEvents lblCase1 As Label
    Friend WithEvents lblEnterPrice As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblTimePeriodSelection As Label
    Friend WithEvents tBoxCondition2 As TextBox
    Friend WithEvents tBoxCondition1 As TextBox
    Friend WithEvents tBoxEndTime As TextBox
    Friend WithEvents tboxStartTime As TextBox
    Friend WithEvents lblExchangeComparisonResult As Label
    Friend WithEvents btnSimulateConsumptionHistory As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tabBlank As TabPage
    Friend WithEvents tabClientConsumptionHistory As TabPage
    Friend WithEvents tabSimulateExchangeHistory As TabPage
    Friend WithEvents btnClientConsumptionHistory As Button
    Friend WithEvents lblConsumptionGraph As Label
    Friend WithEvents lblClientConsumptionHistoryResult As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSeeHistory As Button
    Friend WithEvents tBoxMonthlyCost2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSimulateClientConsumptionHistory As Label
    Friend WithEvents lblExchangePackageHistory As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPackage1 As Label
    Friend WithEvents lblChoosePackages As Label
    Friend WithEvents lblComparisonResult As Label
    Friend WithEvents cBoxPackage2 As ComboBox
    Friend WithEvents cBoxPackage1 As ComboBox
    Friend WithEvents tBoxUsageTime As TextBox
    Friend WithEvents lblUsageTime As Label
    Friend WithEvents lblConsumptionPerHour As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tBoxConsumptionPerHour As TextBox
    Friend WithEvents lblCents As Label
    Friend WithEvents lblKwh24h As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblWatt As Label
    Friend WithEvents tblPriceTable As DataGridView
    Friend WithEvents chrtPackageHourlyRate As DataVisualization.Charting.Chart
    Friend WithEvents chrtFrontPage As DataVisualization.Charting.Chart
    Friend WithEvents btnTableAsc As Button
    Friend WithEvents btnTaasta As Button
    Friend WithEvents btnSisesta As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rdioUniversalPackage As RadioButton
    Friend WithEvents cbColor As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents lblChangeFontSize As Label
    Friend WithEvents btnFontIncrease As Button
    Friend WithEvents btnFontDecrease As Button
    Friend WithEvents btnRestoreFontSize As Button
    Friend WithEvents radioStockPlusMore As RadioButton
    Friend WithEvents tBoxMarginal As TextBox
    Friend WithEvents lblMore As Label
    Friend WithEvents lblSKwh2 As Label
    Friend WithEvents lblSKwh1 As Label
    Friend WithEvents btnPackets As Button
    Friend WithEvents chartPackages As DataVisualization.Charting.Chart
    Friend WithEvents chrtCSV As DataVisualization.Charting.Chart
    Friend WithEvents tbMarginalOfStock As TextBox
    Friend WithEvents rdiobtnStockPlussMarginal As RadioButton
    Friend WithEvents rdioBtnUniversalP As RadioButton
    Friend WithEvents btnTableDesc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSKwh4 As Label
    Friend WithEvents lblSKwh3 As Label
    Friend WithEvents lblTableState As Label
    Friend WithEvents lblBestTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImportCSVFileSimu As Button
    Friend WithEvents chrt As DataVisualization.Charting.Chart
    Friend WithEvents lblToDateTime As Label
    Friend WithEvents lblFromDateTime As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpBeginning As DateTimePicker
    Friend WithEvents tbDebug As TextBox
    Friend WithEvents btnConfirmSimuCSV As Button
    Friend WithEvents btnTwoPackets As Button
    Friend WithEvents compOne As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents priceOfCont2 As TextBox
    Friend WithEvents compTwo As TextBox
    Friend WithEvents priceOfCont As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAproxYearlyPrice As Label
    Friend WithEvents lblRoughPriceYearly As Label
    Friend WithEvents tBoxApproxPriceYear As TextBox
    Friend WithEvents tabGreenEnergy As TabPage
    Friend WithEvents btnWeather As Button
    Friend WithEvents tbWeather As TextBox
    Friend WithEvents btnProduction As Button
    Friend WithEvents tbProduction As TextBox
    Friend WithEvents tbOpinion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
End Class
