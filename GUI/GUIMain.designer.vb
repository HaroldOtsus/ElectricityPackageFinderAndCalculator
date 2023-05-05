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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
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
        Me.lblMarginaal = New System.Windows.Forms.Label()
        Me.lblDontuse = New System.Windows.Forms.Label()
        Me.btnKinnitaAndmed = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbBorsiPakettid = New System.Windows.Forms.ComboBox()
        Me.llNaidisCSV = New System.Windows.Forms.LinkLabel()
        Me.lblFailiPath = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbUusCSVFail = New System.Windows.Forms.RadioButton()
        Me.rbValiCSVFail = New System.Windows.Forms.RadioButton()
        Me.gbFailid = New System.Windows.Forms.GroupBox()
        Me.rbFailiUlekirjutamine = New System.Windows.Forms.RadioButton()
        Me.rbLisaFailiLoppu = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtboxTekstiKvalifikaator = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtboxValjadeEraldaja = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbKaibemaks = New System.Windows.Forms.GroupBox()
        Me.rbKaibemaksuga = New System.Windows.Forms.RadioButton()
        Me.rbKaibemaksuta = New System.Windows.Forms.RadioButton()
        Me.gpOoPaevaHind = New System.Windows.Forms.GroupBox()
        Me.rbOoPaevSamaHind = New System.Windows.Forms.RadioButton()
        Me.rbOoPaevErinevHind = New System.Windows.Forms.RadioButton()
        Me.dtpBorsihinnaVordlusEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpBorsihinnaVordlusStart = New System.Windows.Forms.DateTimePicker()
        Me.chrtBorsihinnaVordlus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblExchangeComparisonResult = New System.Windows.Forms.Label()
        Me.lblExchangeChoice = New System.Windows.Forms.Label()
        Me.lblEnterPrice = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblTimePeriodSelection = New System.Windows.Forms.Label()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.tabConsumptionHistory = New System.Windows.Forms.TabPage()
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
        Me.tabClientConsumptionHistory = New System.Windows.Forms.TabPage()
        Me.lblClientConsumptionHistoryResult = New System.Windows.Forms.Label()
        Me.lblConsumptionGraph = New System.Windows.Forms.Label()
        Me.lblSimulateClientConsumptionHistory = New System.Windows.Forms.Label()
        Me.btnImportCSVFileSimu = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpBeginning = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDateTime = New System.Windows.Forms.Label()
        Me.lblToDateTime = New System.Windows.Forms.Label()
        Me.tbDebug = New System.Windows.Forms.TextBox()
        Me.btnConfirmSimuCSV = New System.Windows.Forms.Button()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.cbNighPrice = New System.Windows.Forms.CheckBox()
        Me.cbMarginal = New System.Windows.Forms.CheckBox()
        Me.tbNightOrMarginal = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbStock = New System.Windows.Forms.RadioButton()
        Me.rbFix = New System.Windows.Forms.RadioButton()
        Me.chrtHistory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tbDayPrice1 = New System.Windows.Forms.TextBox()
        Me.tbDayPrice2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFixed = New System.Windows.Forms.Label()
        Me.lblMarg = New System.Windows.Forms.Label()
        Me.cbChoosePackage = New System.Windows.Forms.ComboBox()
        Me.lblChoosePackage = New System.Windows.Forms.Label()
        Me.lblPriceTotalFromImport = New System.Windows.Forms.Label()
        Me.lblPriceTotalFromPackage = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
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
        Me.GroupBox1.SuspendLayout()
        Me.gbFailid.SuspendLayout()
        Me.gbKaibemaks.SuspendLayout()
        Me.gpOoPaevaHind.SuspendLayout()
        CType(Me.chrtBorsihinnaVordlus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsumptionHistory.SuspendLayout()
        Me.tabPackageComparison.SuspendLayout()
        CType(Me.chartPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGreenEnergy.SuspendLayout()
        Me.tabClientConsumptionHistory.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.chrtHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Location = New System.Drawing.Point(13, 13)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(47, 13)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "MENÜÜ"
        '
        'btnPackageHourlyRate
        '
        Me.btnPackageHourlyRate.Location = New System.Drawing.Point(17, 21)
        Me.btnPackageHourlyRate.Name = "btnPackageHourlyRate"
        Me.btnPackageHourlyRate.Size = New System.Drawing.Size(168, 92)
        Me.btnPackageHourlyRate.TabIndex = 1
        Me.btnPackageHourlyRate.Text = "Kuva paketijärgne tunnihind"
        Me.btnPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'btnApplianceCalc
        '
        Me.btnApplianceCalc.Location = New System.Drawing.Point(191, 21)
        Me.btnApplianceCalc.Name = "btnApplianceCalc"
        Me.btnApplianceCalc.Size = New System.Drawing.Size(168, 92)
        Me.btnApplianceCalc.TabIndex = 2
        Me.btnApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.btnApplianceCalc.UseVisualStyleBackColor = True
        '
        'btnExchangePriceComparison
        '
        Me.btnExchangePriceComparison.Location = New System.Drawing.Point(365, 21)
        Me.btnExchangePriceComparison.Name = "btnExchangePriceComparison"
        Me.btnExchangePriceComparison.Size = New System.Drawing.Size(168, 92)
        Me.btnExchangePriceComparison.TabIndex = 3
        Me.btnExchangePriceComparison.Text = "Börsihinna võrdlus elektriteenuse pakkujatega"
        Me.btnExchangePriceComparison.UseVisualStyleBackColor = True
        '
        'btnConsumptionHistory
        '
        Me.btnConsumptionHistory.Location = New System.Drawing.Point(17, 119)
        Me.btnConsumptionHistory.Name = "btnConsumptionHistory"
        Me.btnConsumptionHistory.Size = New System.Drawing.Size(168, 92)
        Me.btnConsumptionHistory.TabIndex = 4
        Me.btnConsumptionHistory.Text = "Vaata oma tarbimise ajalugu"
        Me.btnConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnPackageComparison
        '
        Me.btnPackageComparison.Location = New System.Drawing.Point(191, 119)
        Me.btnPackageComparison.Name = "btnPackageComparison"
        Me.btnPackageComparison.Size = New System.Drawing.Size(168, 92)
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(983, 672)
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
        Me.Main.Name = "Main"
        Me.Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Main.Size = New System.Drawing.Size(975, 642)
        Me.Main.TabIndex = 0
        Me.Main.Text = "Home"
        '
        'cbColor
        '
        Me.cbColor.AllowDrop = True
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Items.AddRange(New Object() {"Punane", "Sinine", "Roheline", "Roosa", "Valge", "Tumehall", "Helehall"})
        Me.cbColor.Location = New System.Drawing.Point(828, 34)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(121, 21)
        Me.cbColor.TabIndex = 9
        Me.cbColor.Text = "Vali värv"
        '
        'chrtFrontPage
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtFrontPage.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtFrontPage.Legends.Add(Legend1)
        Me.chrtFrontPage.Location = New System.Drawing.Point(17, 217)
        Me.chrtFrontPage.Name = "chrtFrontPage"
        Me.chrtFrontPage.Size = New System.Drawing.Size(932, 403)
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
        Me.tabPackageHourlyRate.Name = "tabPackageHourlyRate"
        Me.tabPackageHourlyRate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPackageHourlyRate.Size = New System.Drawing.Size(975, 642)
        Me.tabPackageHourlyRate.TabIndex = 1
        Me.tabPackageHourlyRate.Text = "Paketijärgne tunnihind"
        Me.tabPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'lblBestTime
        '
        Me.lblBestTime.AutoSize = True
        Me.lblBestTime.Location = New System.Drawing.Point(14, 608)
        Me.lblBestTime.Name = "lblBestTime"
        Me.lblBestTime.Size = New System.Drawing.Size(33, 13)
        Me.lblBestTime.TabIndex = 24
        Me.lblBestTime.Text = "nuffin"
        '
        'lblTableState
        '
        Me.lblTableState.AutoSize = True
        Me.lblTableState.Location = New System.Drawing.Point(14, 496)
        Me.lblTableState.Name = "lblTableState"
        Me.lblTableState.Size = New System.Drawing.Size(33, 13)
        Me.lblTableState.TabIndex = 23
        Me.lblTableState.Text = "nuffin"
        '
        'lblSKwh4
        '
        Me.lblSKwh4.AutoSize = True
        Me.lblSKwh4.Location = New System.Drawing.Point(231, 199)
        Me.lblSKwh4.Name = "lblSKwh4"
        Me.lblSKwh4.Size = New System.Drawing.Size(40, 13)
        Me.lblSKwh4.TabIndex = 22
        Me.lblSKwh4.Text = "s/kWh"
        '
        'lblSKwh3
        '
        Me.lblSKwh3.AutoSize = True
        Me.lblSKwh3.Location = New System.Drawing.Point(231, 168)
        Me.lblSKwh3.Name = "lblSKwh3"
        Me.lblSKwh3.Size = New System.Drawing.Size(40, 13)
        Me.lblSKwh3.TabIndex = 21
        Me.lblSKwh3.Text = "s/kWh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sisesta marginaal:"
        '
        'btnTableDesc
        '
        Me.btnTableDesc.Location = New System.Drawing.Point(30, 303)
        Me.btnTableDesc.Name = "btnTableDesc"
        Me.btnTableDesc.Size = New System.Drawing.Size(146, 32)
        Me.btnTableDesc.TabIndex = 19
        Me.btnTableDesc.Text = "Järjesta tabel kahanevalt"
        Me.btnTableDesc.UseVisualStyleBackColor = True
        '
        'tbMarginalOfStock
        '
        Me.tbMarginalOfStock.Location = New System.Drawing.Point(125, 165)
        Me.tbMarginalOfStock.Name = "tbMarginalOfStock"
        Me.tbMarginalOfStock.Size = New System.Drawing.Size(100, 20)
        Me.tbMarginalOfStock.TabIndex = 18
        '
        'rdiobtnStockPlussMarginal
        '
        Me.rdiobtnStockPlussMarginal.AutoSize = True
        Me.rdiobtnStockPlussMarginal.Enabled = False
        Me.rdiobtnStockPlussMarginal.Location = New System.Drawing.Point(30, 93)
        Me.rdiobtnStockPlussMarginal.Name = "rdiobtnStockPlussMarginal"
        Me.rdiobtnStockPlussMarginal.Size = New System.Drawing.Size(125, 17)
        Me.rdiobtnStockPlussMarginal.TabIndex = 17
        Me.rdiobtnStockPlussMarginal.TabStop = True
        Me.rdiobtnStockPlussMarginal.Text = "Börsihind + marginaal"
        Me.rdiobtnStockPlussMarginal.UseVisualStyleBackColor = True
        '
        'rdioBtnUniversalP
        '
        Me.rdioBtnUniversalP.AutoSize = True
        Me.rdioBtnUniversalP.Location = New System.Drawing.Point(30, 139)
        Me.rdioBtnUniversalP.Name = "rdioBtnUniversalP"
        Me.rdioBtnUniversalP.Size = New System.Drawing.Size(95, 17)
        Me.rdioBtnUniversalP.TabIndex = 16
        Me.rdioBtnUniversalP.TabStop = True
        Me.rdioBtnUniversalP.Text = "Universaalhind"
        Me.rdioBtnUniversalP.UseVisualStyleBackColor = True
        '
        'btnTableAsc
        '
        Me.btnTableAsc.Location = New System.Drawing.Point(30, 265)
        Me.btnTableAsc.Name = "btnTableAsc"
        Me.btnTableAsc.Size = New System.Drawing.Size(146, 32)
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
        Me.chrtPackageHourlyRate.Location = New System.Drawing.Point(365, 93)
        Me.chrtPackageHourlyRate.Margin = New System.Windows.Forms.Padding(2)
        Me.chrtPackageHourlyRate.Name = "chrtPackageHourlyRate"
        Me.chrtPackageHourlyRate.Size = New System.Drawing.Size(472, 374)
        Me.chrtPackageHourlyRate.TabIndex = 14
        Me.chrtPackageHourlyRate.Text = "Chart1"
        '
        'tblPriceTable
        '
        Me.tblPriceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPriceTable.Location = New System.Drawing.Point(6, 523)
        Me.tblPriceTable.Name = "tblPriceTable"
        Me.tblPriceTable.ReadOnly = True
        Me.tblPriceTable.RowHeadersWidth = 51
        Me.tblPriceTable.Size = New System.Drawing.Size(939, 81)
        Me.tblPriceTable.TabIndex = 13
        '
        'tBoxPackageHourlyRate
        '
        Me.tBoxPackageHourlyRate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxPackageHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxPackageHourlyRate.Cursor = System.Windows.Forms.Cursors.No
        Me.tBoxPackageHourlyRate.Enabled = False
        Me.tBoxPackageHourlyRate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.tBoxPackageHourlyRate.Location = New System.Drawing.Point(484, 30)
        Me.tBoxPackageHourlyRate.Name = "tBoxPackageHourlyRate"
        Me.tBoxPackageHourlyRate.ReadOnly = True
        Me.tBoxPackageHourlyRate.Size = New System.Drawing.Size(100, 20)
        Me.tBoxPackageHourlyRate.TabIndex = 11
        '
        'lblPriceGraph
        '
        Me.lblPriceGraph.AutoSize = True
        Me.lblPriceGraph.Location = New System.Drawing.Point(362, 70)
        Me.lblPriceGraph.Name = "lblPriceGraph"
        Me.lblPriceGraph.Size = New System.Drawing.Size(70, 13)
        Me.lblPriceGraph.TabIndex = 10
        Me.lblPriceGraph.Text = "Hinnagraafik:"
        '
        'lblPriceTable
        '
        Me.lblPriceTable.AutoSize = True
        Me.lblPriceTable.Location = New System.Drawing.Point(6, 462)
        Me.lblPriceTable.Name = "lblPriceTable"
        Me.lblPriceTable.Size = New System.Drawing.Size(61, 13)
        Me.lblPriceTable.TabIndex = 9
        Me.lblPriceTable.Text = "Hinnatabel:"
        '
        'lblPackageHourlyRate
        '
        Me.lblPackageHourlyRate.AutoSize = True
        Me.lblPackageHourlyRate.Location = New System.Drawing.Point(363, 32)
        Me.lblPackageHourlyRate.Name = "lblPackageHourlyRate"
        Me.lblPackageHourlyRate.Size = New System.Drawing.Size(115, 13)
        Me.lblPackageHourlyRate.TabIndex = 8
        Me.lblPackageHourlyRate.Text = "Paketijärgne tunnihind:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(363, 12)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(50, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Tulemus:"
        '
        'btnConfirmInput
        '
        Me.btnConfirmInput.Location = New System.Drawing.Point(30, 227)
        Me.btnConfirmInput.Name = "btnConfirmInput"
        Me.btnConfirmInput.Size = New System.Drawing.Size(146, 32)
        Me.btnConfirmInput.TabIndex = 6
        Me.btnConfirmInput.Text = "Kinnita andmed"
        Me.btnConfirmInput.UseVisualStyleBackColor = True
        '
        'tboxMonthlyCost
        '
        Me.tboxMonthlyCost.Location = New System.Drawing.Point(125, 196)
        Me.tboxMonthlyCost.Name = "tboxMonthlyCost"
        Me.tboxMonthlyCost.Size = New System.Drawing.Size(100, 20)
        Me.tboxMonthlyCost.TabIndex = 5
        '
        'lblMonthlyCost
        '
        Me.lblMonthlyCost.AutoSize = True
        Me.lblMonthlyCost.Location = New System.Drawing.Point(27, 199)
        Me.lblMonthlyCost.Name = "lblMonthlyCost"
        Me.lblMonthlyCost.Size = New System.Drawing.Size(46, 13)
        Me.lblMonthlyCost.TabIndex = 4
        Me.lblMonthlyCost.Text = "Kuutasu"
        '
        'rdioFixedPrice
        '
        Me.rdioFixedPrice.AutoSize = True
        Me.rdioFixedPrice.Location = New System.Drawing.Point(30, 116)
        Me.rdioFixedPrice.Name = "rdioFixedPrice"
        Me.rdioFixedPrice.Size = New System.Drawing.Size(99, 17)
        Me.rdioFixedPrice.TabIndex = 3
        Me.rdioFixedPrice.TabStop = True
        Me.rdioFixedPrice.Text = "Fikseeritud hind"
        Me.rdioFixedPrice.UseVisualStyleBackColor = True
        '
        'rdioExchange
        '
        Me.rdioExchange.AutoSize = True
        Me.rdioExchange.Location = New System.Drawing.Point(30, 70)
        Me.rdioExchange.Name = "rdioExchange"
        Me.rdioExchange.Size = New System.Drawing.Size(68, 17)
        Me.rdioExchange.TabIndex = 2
        Me.rdioExchange.TabStop = True
        Me.rdioExchange.Text = "Börsihind"
        Me.rdioExchange.UseVisualStyleBackColor = True
        '
        'lblPackageHourly
        '
        Me.lblPackageHourly.AutoSize = True
        Me.lblPackageHourly.Location = New System.Drawing.Point(110, 22)
        Me.lblPackageHourly.Name = "lblPackageHourly"
        Me.lblPackageHourly.Size = New System.Drawing.Size(162, 13)
        Me.lblPackageHourly.TabIndex = 1
        Me.lblPackageHourly.Text = "Kehtiva paketi andmete sisestus:"
        '
        'btnBack0
        '
        Me.btnBack0.Location = New System.Drawing.Point(16, 12)
        Me.btnBack0.Name = "btnBack0"
        Me.btnBack0.Size = New System.Drawing.Size(83, 33)
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
        Me.tabApplianceCalc.Name = "tabApplianceCalc"
        Me.tabApplianceCalc.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApplianceCalc.Size = New System.Drawing.Size(975, 642)
        Me.tabApplianceCalc.TabIndex = 2
        Me.tabApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.tabApplianceCalc.UseVisualStyleBackColor = True
        '
        'lblSKwh1
        '
        Me.lblSKwh1.AutoSize = True
        Me.lblSKwh1.Location = New System.Drawing.Point(311, 497)
        Me.lblSKwh1.Name = "lblSKwh1"
        Me.lblSKwh1.Size = New System.Drawing.Size(40, 13)
        Me.lblSKwh1.TabIndex = 46
        Me.lblSKwh1.Text = "s/kWh"
        '
        'lblSKwh2
        '
        Me.lblSKwh2.AutoSize = True
        Me.lblSKwh2.Location = New System.Drawing.Point(311, 537)
        Me.lblSKwh2.Name = "lblSKwh2"
        Me.lblSKwh2.Size = New System.Drawing.Size(40, 13)
        Me.lblSKwh2.TabIndex = 45
        Me.lblSKwh2.Text = "s/kWh"
        '
        'tBoxMarginal
        '
        Me.tBoxMarginal.Location = New System.Drawing.Point(205, 533)
        Me.tBoxMarginal.Name = "tBoxMarginal"
        Me.tBoxMarginal.Size = New System.Drawing.Size(100, 20)
        Me.tBoxMarginal.TabIndex = 43
        '
        'lblMore
        '
        Me.lblMore.AutoSize = True
        Me.lblMore.Location = New System.Drawing.Point(39, 533)
        Me.lblMore.Name = "lblMore"
        Me.lblMore.Size = New System.Drawing.Size(92, 13)
        Me.lblMore.TabIndex = 42
        Me.lblMore.Text = "Sisesta marginaal:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radioStockPlusMore)
        Me.Panel3.Controls.Add(Me.rdioUniversalPackage)
        Me.Panel3.Controls.Add(Me.rdioFixedPrice1)
        Me.Panel3.Controls.Add(Me.rdioExchangePrice)
        Me.Panel3.Location = New System.Drawing.Point(36, 409)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 82)
        Me.Panel3.TabIndex = 41
        '
        'radioStockPlusMore
        '
        Me.radioStockPlusMore.AutoSize = True
        Me.radioStockPlusMore.Location = New System.Drawing.Point(159, 3)
        Me.radioStockPlusMore.Name = "radioStockPlusMore"
        Me.radioStockPlusMore.Size = New System.Drawing.Size(125, 17)
        Me.radioStockPlusMore.TabIndex = 43
        Me.radioStockPlusMore.TabStop = True
        Me.radioStockPlusMore.Text = "Börsihind + marginaal"
        Me.radioStockPlusMore.UseVisualStyleBackColor = True
        '
        'rdioUniversalPackage
        '
        Me.rdioUniversalPackage.AutoSize = True
        Me.rdioUniversalPackage.Location = New System.Drawing.Point(25, 49)
        Me.rdioUniversalPackage.Name = "rdioUniversalPackage"
        Me.rdioUniversalPackage.Size = New System.Drawing.Size(108, 17)
        Me.rdioUniversalPackage.TabIndex = 42
        Me.rdioUniversalPackage.TabStop = True
        Me.rdioUniversalPackage.Text = "Universaal pakett"
        Me.rdioUniversalPackage.UseVisualStyleBackColor = True
        '
        'rdioFixedPrice1
        '
        Me.rdioFixedPrice1.AutoSize = True
        Me.rdioFixedPrice1.Location = New System.Drawing.Point(25, 26)
        Me.rdioFixedPrice1.Name = "rdioFixedPrice1"
        Me.rdioFixedPrice1.Size = New System.Drawing.Size(99, 17)
        Me.rdioFixedPrice1.TabIndex = 12
        Me.rdioFixedPrice1.TabStop = True
        Me.rdioFixedPrice1.Text = "Fikseeritud hind"
        Me.rdioFixedPrice1.UseVisualStyleBackColor = True
        '
        'rdioExchangePrice
        '
        Me.rdioExchangePrice.AutoSize = True
        Me.rdioExchangePrice.Location = New System.Drawing.Point(25, 3)
        Me.rdioExchangePrice.Name = "rdioExchangePrice"
        Me.rdioExchangePrice.Size = New System.Drawing.Size(68, 17)
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
        Me.Panel2.Location = New System.Drawing.Point(409, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 275)
        Me.Panel2.TabIndex = 40
        '
        'lblAproxYearlyPrice
        '
        Me.lblAproxYearlyPrice.AutoSize = True
        Me.lblAproxYearlyPrice.Location = New System.Drawing.Point(380, 210)
        Me.lblAproxYearlyPrice.Name = "lblAproxYearlyPrice"
        Me.lblAproxYearlyPrice.Size = New System.Drawing.Size(32, 13)
        Me.lblAproxYearlyPrice.TabIndex = 47
        Me.lblAproxYearlyPrice.Text = "senti "
        '
        'lblRoughPriceYearly
        '
        Me.lblRoughPriceYearly.AutoSize = True
        Me.lblRoughPriceYearly.Location = New System.Drawing.Point(16, 209)
        Me.lblRoughPriceYearly.Name = "lblRoughPriceYearly"
        Me.lblRoughPriceYearly.Size = New System.Drawing.Size(122, 13)
        Me.lblRoughPriceYearly.TabIndex = 45
        Me.lblRoughPriceYearly.Text = "Orienteeruv hind aastas:"
        '
        'tBoxApproxPriceYear
        '
        Me.tBoxApproxPriceYear.BackColor = System.Drawing.Color.White
        Me.tBoxApproxPriceYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxApproxPriceYear.Enabled = False
        Me.tBoxApproxPriceYear.ForeColor = System.Drawing.Color.Black
        Me.tBoxApproxPriceYear.Location = New System.Drawing.Point(274, 207)
        Me.tBoxApproxPriceYear.Name = "tBoxApproxPriceYear"
        Me.tBoxApproxPriceYear.ReadOnly = True
        Me.tBoxApproxPriceYear.Size = New System.Drawing.Size(100, 20)
        Me.tBoxApproxPriceYear.TabIndex = 46
        '
        'btnTaasta
        '
        Me.btnTaasta.Location = New System.Drawing.Point(353, 11)
        Me.btnTaasta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTaasta.Name = "btnTaasta"
        Me.btnTaasta.Size = New System.Drawing.Size(67, 32)
        Me.btnTaasta.TabIndex = 44
        Me.btnTaasta.Text = "Taasta"
        Me.btnTaasta.UseVisualStyleBackColor = True
        '
        'btnSisesta
        '
        Me.btnSisesta.Location = New System.Drawing.Point(273, 11)
        Me.btnSisesta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSisesta.Name = "btnSisesta"
        Me.btnSisesta.Size = New System.Drawing.Size(67, 32)
        Me.btnSisesta.TabIndex = 43
        Me.btnSisesta.Text = "Sisesta"
        Me.btnSisesta.UseVisualStyleBackColor = True
        '
        'lblCents
        '
        Me.lblCents.AutoSize = True
        Me.lblCents.Location = New System.Drawing.Point(380, 171)
        Me.lblCents.Name = "lblCents"
        Me.lblCents.Size = New System.Drawing.Size(32, 13)
        Me.lblCents.TabIndex = 42
        Me.lblCents.Text = "senti "
        '
        'lblKwh24h
        '
        Me.lblKwh24h.AutoSize = True
        Me.lblKwh24h.Location = New System.Drawing.Point(380, 139)
        Me.lblKwh24h.Name = "lblKwh24h"
        Me.lblKwh24h.Size = New System.Drawing.Size(51, 13)
        Me.lblKwh24h.TabIndex = 41
        Me.lblKwh24h.Text = "kWh 24h"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(380, 85)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(23, 13)
        Me.lblMin.TabIndex = 40
        Me.lblMin.Text = "min"
        '
        'lblWatt
        '
        Me.lblWatt.AutoSize = True
        Me.lblWatt.Location = New System.Drawing.Point(380, 53)
        Me.lblWatt.Name = "lblWatt"
        Me.lblWatt.Size = New System.Drawing.Size(18, 13)
        Me.lblWatt.TabIndex = 39
        Me.lblWatt.Text = "W"
        '
        'lblApplianceResult
        '
        Me.lblApplianceResult.AutoSize = True
        Me.lblApplianceResult.Location = New System.Drawing.Point(17, 23)
        Me.lblApplianceResult.Name = "lblApplianceResult"
        Me.lblApplianceResult.Size = New System.Drawing.Size(50, 13)
        Me.lblApplianceResult.TabIndex = 5
        Me.lblApplianceResult.Text = "Tulemus:"
        '
        'lblElectricityConsumptionRate
        '
        Me.lblElectricityConsumptionRate.AutoSize = True
        Me.lblElectricityConsumptionRate.Location = New System.Drawing.Point(16, 138)
        Me.lblElectricityConsumptionRate.Name = "lblElectricityConsumptionRate"
        Me.lblElectricityConsumptionRate.Size = New System.Drawing.Size(150, 13)
        Me.lblElectricityConsumptionRate.TabIndex = 7
        Me.lblElectricityConsumptionRate.Text = "Elektrienergia tarbimise kogus:"
        '
        'tBoxUsageTime
        '
        Me.tBoxUsageTime.BackColor = System.Drawing.SystemColors.HighlightText
        Me.tBoxUsageTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxUsageTime.HideSelection = False
        Me.tBoxUsageTime.Location = New System.Drawing.Point(274, 83)
        Me.tBoxUsageTime.Name = "tBoxUsageTime"
        Me.tBoxUsageTime.ReadOnly = True
        Me.tBoxUsageTime.Size = New System.Drawing.Size(100, 20)
        Me.tBoxUsageTime.TabIndex = 38
        '
        'lblRoughPrice
        '
        Me.lblRoughPrice.AutoSize = True
        Me.lblRoughPrice.Location = New System.Drawing.Point(16, 170)
        Me.lblRoughPrice.Name = "lblRoughPrice"
        Me.lblRoughPrice.Size = New System.Drawing.Size(88, 13)
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
        Me.tBoxConsumptionPerHour.Location = New System.Drawing.Point(274, 51)
        Me.tBoxConsumptionPerHour.Name = "tBoxConsumptionPerHour"
        Me.tBoxConsumptionPerHour.ReadOnly = True
        Me.tBoxConsumptionPerHour.Size = New System.Drawing.Size(100, 20)
        Me.tBoxConsumptionPerHour.TabIndex = 37
        '
        'tBoxElectricityConsumptionRate
        '
        Me.tBoxElectricityConsumptionRate.BackColor = System.Drawing.Color.White
        Me.tBoxElectricityConsumptionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxElectricityConsumptionRate.Enabled = False
        Me.tBoxElectricityConsumptionRate.ForeColor = System.Drawing.Color.Black
        Me.tBoxElectricityConsumptionRate.Location = New System.Drawing.Point(274, 136)
        Me.tBoxElectricityConsumptionRate.Name = "tBoxElectricityConsumptionRate"
        Me.tBoxElectricityConsumptionRate.ReadOnly = True
        Me.tBoxElectricityConsumptionRate.Size = New System.Drawing.Size(100, 20)
        Me.tBoxElectricityConsumptionRate.TabIndex = 16
        '
        'lblUsageTime
        '
        Me.lblUsageTime.AutoSize = True
        Me.lblUsageTime.Location = New System.Drawing.Point(16, 89)
        Me.lblUsageTime.Name = "lblUsageTime"
        Me.lblUsageTime.Size = New System.Drawing.Size(63, 13)
        Me.lblUsageTime.TabIndex = 36
        Me.lblUsageTime.Text = "Kasutusaeg"
        '
        'tBoxApproxPrice
        '
        Me.tBoxApproxPrice.BackColor = System.Drawing.Color.White
        Me.tBoxApproxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tBoxApproxPrice.Enabled = False
        Me.tBoxApproxPrice.ForeColor = System.Drawing.Color.Black
        Me.tBoxApproxPrice.Location = New System.Drawing.Point(274, 168)
        Me.tBoxApproxPrice.Name = "tBoxApproxPrice"
        Me.tBoxApproxPrice.ReadOnly = True
        Me.tBoxApproxPrice.Size = New System.Drawing.Size(100, 20)
        Me.tBoxApproxPrice.TabIndex = 17
        '
        'lblConsumptionPerHour
        '
        Me.lblConsumptionPerHour.AutoSize = True
        Me.lblConsumptionPerHour.Location = New System.Drawing.Point(17, 57)
        Me.lblConsumptionPerHour.Name = "lblConsumptionPerHour"
        Me.lblConsumptionPerHour.Size = New System.Drawing.Size(100, 13)
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
        Me.Panel1.Location = New System.Drawing.Point(36, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 275)
        Me.Panel1.TabIndex = 39
        '
        'rdioFridge
        '
        Me.rdioFridge.AutoSize = True
        Me.rdioFridge.Location = New System.Drawing.Point(183, 26)
        Me.rdioFridge.Name = "rdioFridge"
        Me.rdioFridge.Size = New System.Drawing.Size(72, 17)
        Me.rdioFridge.TabIndex = 27
        Me.rdioFridge.TabStop = True
        Me.rdioFridge.Text = "Külmkapp"
        Me.rdioFridge.UseVisualStyleBackColor = True
        '
        'rdioCoffeeMaker
        '
        Me.rdioCoffeeMaker.AutoSize = True
        Me.rdioCoffeeMaker.Location = New System.Drawing.Point(25, 26)
        Me.rdioCoffeeMaker.Name = "rdioCoffeeMaker"
        Me.rdioCoffeeMaker.Size = New System.Drawing.Size(79, 17)
        Me.rdioCoffeeMaker.TabIndex = 18
        Me.rdioCoffeeMaker.TabStop = True
        Me.rdioCoffeeMaker.Text = "Kohvimasin"
        Me.rdioCoffeeMaker.UseVisualStyleBackColor = True
        '
        'rdioToaster
        '
        Me.rdioToaster.AutoSize = True
        Me.rdioToaster.Location = New System.Drawing.Point(25, 49)
        Me.rdioToaster.Name = "rdioToaster"
        Me.rdioToaster.Size = New System.Drawing.Size(56, 17)
        Me.rdioToaster.TabIndex = 19
        Me.rdioToaster.TabStop = True
        Me.rdioToaster.Text = "Röster"
        Me.rdioToaster.UseVisualStyleBackColor = True
        '
        'rdioVacuum
        '
        Me.rdioVacuum.AutoSize = True
        Me.rdioVacuum.Location = New System.Drawing.Point(25, 72)
        Me.rdioVacuum.Name = "rdioVacuum"
        Me.rdioVacuum.Size = New System.Drawing.Size(78, 17)
        Me.rdioVacuum.TabIndex = 20
        Me.rdioVacuum.TabStop = True
        Me.rdioVacuum.Text = "Tolmuimeja"
        Me.rdioVacuum.UseVisualStyleBackColor = True
        '
        'rdioMixer
        '
        Me.rdioMixer.AutoSize = True
        Me.rdioMixer.Location = New System.Drawing.Point(25, 95)
        Me.rdioMixer.Name = "rdioMixer"
        Me.rdioMixer.Size = New System.Drawing.Size(56, 17)
        Me.rdioMixer.TabIndex = 21
        Me.rdioMixer.TabStop = True
        Me.rdioMixer.Text = "Mikser"
        Me.rdioMixer.UseVisualStyleBackColor = True
        '
        'rdioMicrowave
        '
        Me.rdioMicrowave.AutoSize = True
        Me.rdioMicrowave.Location = New System.Drawing.Point(183, 187)
        Me.rdioMicrowave.Name = "rdioMicrowave"
        Me.rdioMicrowave.Size = New System.Drawing.Size(87, 17)
        Me.rdioMicrowave.TabIndex = 34
        Me.rdioMicrowave.TabStop = True
        Me.rdioMicrowave.Text = "Mikrolaineahi"
        Me.rdioMicrowave.UseVisualStyleBackColor = True
        '
        'rdioElecStove
        '
        Me.rdioElecStove.AutoSize = True
        Me.rdioElecStove.Location = New System.Drawing.Point(25, 118)
        Me.rdioElecStove.Name = "rdioElecStove"
        Me.rdioElecStove.Size = New System.Drawing.Size(69, 17)
        Me.rdioElecStove.TabIndex = 22
        Me.rdioElecStove.TabStop = True
        Me.rdioElecStove.Text = "Elektripliit"
        Me.rdioElecStove.UseVisualStyleBackColor = True
        '
        'rdioRouter
        '
        Me.rdioRouter.AutoSize = True
        Me.rdioRouter.Location = New System.Drawing.Point(183, 164)
        Me.rdioRouter.Name = "rdioRouter"
        Me.rdioRouter.Size = New System.Drawing.Size(57, 17)
        Me.rdioRouter.TabIndex = 33
        Me.rdioRouter.TabStop = True
        Me.rdioRouter.Text = "Ruuter"
        Me.rdioRouter.UseVisualStyleBackColor = True
        '
        'rdioFoodProcessor
        '
        Me.rdioFoodProcessor.AutoSize = True
        Me.rdioFoodProcessor.Location = New System.Drawing.Point(25, 141)
        Me.rdioFoodProcessor.Name = "rdioFoodProcessor"
        Me.rdioFoodProcessor.Size = New System.Drawing.Size(92, 17)
        Me.rdioFoodProcessor.TabIndex = 23
        Me.rdioFoodProcessor.TabStop = True
        Me.rdioFoodProcessor.Text = "Köögikombain"
        Me.rdioFoodProcessor.UseVisualStyleBackColor = True
        '
        'rdioSewingMachine
        '
        Me.rdioSewingMachine.AutoSize = True
        Me.rdioSewingMachine.Location = New System.Drawing.Point(183, 141)
        Me.rdioSewingMachine.Name = "rdioSewingMachine"
        Me.rdioSewingMachine.Size = New System.Drawing.Size(87, 17)
        Me.rdioSewingMachine.TabIndex = 32
        Me.rdioSewingMachine.TabStop = True
        Me.rdioSewingMachine.Text = "Õmblusmasin"
        Me.rdioSewingMachine.UseVisualStyleBackColor = True
        '
        'rdioTV
        '
        Me.rdioTV.AutoSize = True
        Me.rdioTV.Location = New System.Drawing.Point(25, 164)
        Me.rdioTV.Name = "rdioTV"
        Me.rdioTV.Size = New System.Drawing.Size(39, 17)
        Me.rdioTV.TabIndex = 24
        Me.rdioTV.TabStop = True
        Me.rdioTV.Text = "TV"
        Me.rdioTV.UseVisualStyleBackColor = True
        '
        'rdioLED
        '
        Me.rdioLED.AutoSize = True
        Me.rdioLED.Location = New System.Drawing.Point(183, 118)
        Me.rdioLED.Name = "rdioLED"
        Me.rdioLED.Size = New System.Drawing.Size(100, 17)
        Me.rdioLED.TabIndex = 31
        Me.rdioLED.TabStop = True
        Me.rdioLED.Text = "Lambipirn (LED)"
        Me.rdioLED.UseVisualStyleBackColor = True
        '
        'rdioRadio
        '
        Me.rdioRadio.AutoSize = True
        Me.rdioRadio.Location = New System.Drawing.Point(25, 187)
        Me.rdioRadio.Name = "rdioRadio"
        Me.rdioRadio.Size = New System.Drawing.Size(59, 17)
        Me.rdioRadio.TabIndex = 25
        Me.rdioRadio.TabStop = True
        Me.rdioRadio.Text = "Raadio"
        Me.rdioRadio.UseVisualStyleBackColor = True
        '
        'rdioPrinter
        '
        Me.rdioPrinter.AutoSize = True
        Me.rdioPrinter.Location = New System.Drawing.Point(183, 95)
        Me.rdioPrinter.Name = "rdioPrinter"
        Me.rdioPrinter.Size = New System.Drawing.Size(55, 17)
        Me.rdioPrinter.TabIndex = 30
        Me.rdioPrinter.TabStop = True
        Me.rdioPrinter.Text = "Printer"
        Me.rdioPrinter.UseVisualStyleBackColor = True
        '
        'rdioEggCooker
        '
        Me.rdioEggCooker.AutoSize = True
        Me.rdioEggCooker.Location = New System.Drawing.Point(25, 210)
        Me.rdioEggCooker.Name = "rdioEggCooker"
        Me.rdioEggCooker.Size = New System.Drawing.Size(81, 17)
        Me.rdioEggCooker.TabIndex = 26
        Me.rdioEggCooker.TabStop = True
        Me.rdioEggCooker.Text = "Munakeetja"
        Me.rdioEggCooker.UseVisualStyleBackColor = True
        '
        'rdioHairDryer
        '
        Me.rdioHairDryer.AutoSize = True
        Me.rdioHairDryer.Location = New System.Drawing.Point(183, 72)
        Me.rdioHairDryer.Name = "rdioHairDryer"
        Me.rdioHairDryer.Size = New System.Drawing.Size(49, 17)
        Me.rdioHairDryer.TabIndex = 29
        Me.rdioHairDryer.TabStop = True
        Me.rdioHairDryer.Text = "Föön"
        Me.rdioHairDryer.UseVisualStyleBackColor = True
        '
        'rdioComputer
        '
        Me.rdioComputer.AutoSize = True
        Me.rdioComputer.Location = New System.Drawing.Point(183, 49)
        Me.rdioComputer.Name = "rdioComputer"
        Me.rdioComputer.Size = New System.Drawing.Size(52, 17)
        Me.rdioComputer.TabIndex = 28
        Me.rdioComputer.TabStop = True
        Me.rdioComputer.Text = "Arvuti"
        Me.rdioComputer.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(42, 559)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(332, 35)
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Kinnita andmed"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'tBoxPackagePrice
        '
        Me.tBoxPackagePrice.Location = New System.Drawing.Point(205, 497)
        Me.tBoxPackagePrice.Name = "tBoxPackagePrice"
        Me.tBoxPackagePrice.Size = New System.Drawing.Size(100, 20)
        Me.tBoxPackagePrice.TabIndex = 14
        '
        'lblCurrentPackagePrice
        '
        Me.lblCurrentPackagePrice.AutoSize = True
        Me.lblCurrentPackagePrice.Location = New System.Drawing.Point(39, 497)
        Me.lblCurrentPackagePrice.Name = "lblCurrentPackagePrice"
        Me.lblCurrentPackagePrice.Size = New System.Drawing.Size(127, 13)
        Me.lblCurrentPackagePrice.TabIndex = 10
        Me.lblCurrentPackagePrice.Text = "Kehtiva paketi tunnihind: "
        '
        'lblOptional
        '
        Me.lblOptional.AutoSize = True
        Me.lblOptional.Location = New System.Drawing.Point(46, 384)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(55, 13)
        Me.lblOptional.TabIndex = 4
        Me.lblOptional.Text = "Valikuline:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tarvitav võimsus ühes minutis:"
        '
        'lblApplianceChoice
        '
        Me.lblApplianceChoice.AutoSize = True
        Me.lblApplianceChoice.Location = New System.Drawing.Point(112, 22)
        Me.lblApplianceChoice.Name = "lblApplianceChoice"
        Me.lblApplianceChoice.Size = New System.Drawing.Size(93, 13)
        Me.lblApplianceChoice.TabIndex = 2
        Me.lblApplianceChoice.Text = "Kodumasina valik:"
        '
        'btnBack1
        '
        Me.btnBack1.Location = New System.Drawing.Point(18, 12)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(83, 33)
        Me.btnBack1.TabIndex = 1
        Me.btnBack1.Text = "Tagasi"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'tabExchangeComparison
        '
        Me.tabExchangeComparison.Controls.Add(Me.lblMarginaal)
        Me.tabExchangeComparison.Controls.Add(Me.lblDontuse)
        Me.tabExchangeComparison.Controls.Add(Me.btnKinnitaAndmed)
        Me.tabExchangeComparison.Controls.Add(Me.Label18)
        Me.tabExchangeComparison.Controls.Add(Me.cbBorsiPakettid)
        Me.tabExchangeComparison.Controls.Add(Me.llNaidisCSV)
        Me.tabExchangeComparison.Controls.Add(Me.lblFailiPath)
        Me.tabExchangeComparison.Controls.Add(Me.GroupBox1)
        Me.tabExchangeComparison.Controls.Add(Me.gbFailid)
        Me.tabExchangeComparison.Controls.Add(Me.Label17)
        Me.tabExchangeComparison.Controls.Add(Me.txtboxTekstiKvalifikaator)
        Me.tabExchangeComparison.Controls.Add(Me.Label16)
        Me.tabExchangeComparison.Controls.Add(Me.txtboxValjadeEraldaja)
        Me.tabExchangeComparison.Controls.Add(Me.Label15)
        Me.tabExchangeComparison.Controls.Add(Me.gbKaibemaks)
        Me.tabExchangeComparison.Controls.Add(Me.gpOoPaevaHind)
        Me.tabExchangeComparison.Controls.Add(Me.dtpBorsihinnaVordlusEnd)
        Me.tabExchangeComparison.Controls.Add(Me.dtpBorsihinnaVordlusStart)
        Me.tabExchangeComparison.Controls.Add(Me.chrtBorsihinnaVordlus)
        Me.tabExchangeComparison.Controls.Add(Me.btnExport)
        Me.tabExchangeComparison.Controls.Add(Me.btnImport)
        Me.tabExchangeComparison.Controls.Add(Me.lblExchangeComparisonResult)
        Me.tabExchangeComparison.Controls.Add(Me.lblExchangeChoice)
        Me.tabExchangeComparison.Controls.Add(Me.lblEnterPrice)
        Me.tabExchangeComparison.Controls.Add(Me.lblEndTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblStartTime)
        Me.tabExchangeComparison.Controls.Add(Me.lblTimePeriodSelection)
        Me.tabExchangeComparison.Controls.Add(Me.btnBack2)
        Me.tabExchangeComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabExchangeComparison.Name = "tabExchangeComparison"
        Me.tabExchangeComparison.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExchangeComparison.Size = New System.Drawing.Size(975, 642)
        Me.tabExchangeComparison.TabIndex = 3
        Me.tabExchangeComparison.Text = "Börsihinna võrdlus"
        Me.tabExchangeComparison.UseVisualStyleBackColor = True
        '
        'lblMarginaal
        '
        Me.lblMarginaal.AutoSize = True
        Me.lblMarginaal.Location = New System.Drawing.Point(774, 82)
        Me.lblMarginaal.Name = "lblMarginaal"
        Me.lblMarginaal.Size = New System.Drawing.Size(0, 13)
        Me.lblMarginaal.TabIndex = 41
        '
        'lblDontuse
        '
        Me.lblDontuse.AutoSize = True
        Me.lblDontuse.Location = New System.Drawing.Point(723, 111)
        Me.lblDontuse.Name = "lblDontuse"
        Me.lblDontuse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDontuse.Size = New System.Drawing.Size(56, 13)
        Me.lblDontuse.TabIndex = 40
        Me.lblDontuse.Text = "Marginaal:"
        '
        'btnKinnitaAndmed
        '
        Me.btnKinnitaAndmed.Location = New System.Drawing.Point(726, 248)
        Me.btnKinnitaAndmed.Name = "btnKinnitaAndmed"
        Me.btnKinnitaAndmed.Size = New System.Drawing.Size(91, 34)
        Me.btnKinnitaAndmed.TabIndex = 39
        Me.btnKinnitaAndmed.Text = "Kinnita andmed"
        Me.btnKinnitaAndmed.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(723, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Elektripakett:"
        '
        'cbBorsiPakettid
        '
        Me.cbBorsiPakettid.FormattingEnabled = True
        Me.cbBorsiPakettid.Items.AddRange(New Object() {"Kindel 6", "Kindel 36", "Kindel Pluss", "Muutuv", "Universaalteenus", "Pingevaba + Ühisarve", "Tähtajaline fikseeritud hind", "Kodupakett börsihinnaga", "Universaalteenus Alexela", "Universaalteenus Alexela + roheline", "Tähtajaline fikseeritud hind + roheline", "220 Börsihind", "220 Börsihind + Roheline", "220 Tähtajaline kindel hind", "220 Tähtajaline kindel hind + roheline", "220 Universaalteenus", "220 Universaalteenus + roheline", "Kindel pakett gaas", "Muutuvhinnaga pakett", "Universaalteenus Eesti gaas", "Universaalteenus VKG", "Not-fix", "Roheline Klõps", "Roheline Börsi Klõps", "Börsi Klõps", "Universaalteenus Elektrum", "Kaljukindel Klõps kindlustusega"})
        Me.cbBorsiPakettid.Location = New System.Drawing.Point(726, 78)
        Me.cbBorsiPakettid.Name = "cbBorsiPakettid"
        Me.cbBorsiPakettid.Size = New System.Drawing.Size(121, 21)
        Me.cbBorsiPakettid.TabIndex = 37
        '
        'llNaidisCSV
        '
        Me.llNaidisCSV.AutoSize = True
        Me.llNaidisCSV.Location = New System.Drawing.Point(200, 259)
        Me.llNaidisCSV.Name = "llNaidisCSV"
        Me.llNaidisCSV.Size = New System.Drawing.Size(114, 13)
        Me.llNaidisCSV.TabIndex = 36
        Me.llNaidisCSV.TabStop = True
        Me.llNaidisCSV.Text = "Lae alla näidis CSV fail"
        '
        'lblFailiPath
        '
        Me.lblFailiPath.AutoSize = True
        Me.lblFailiPath.Location = New System.Drawing.Point(529, 259)
        Me.lblFailiPath.Name = "lblFailiPath"
        Me.lblFailiPath.Size = New System.Drawing.Size(78, 13)
        Me.lblFailiPath.TabIndex = 35
        Me.lblFailiPath.Text = "<Faili asukoht>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbUusCSVFail)
        Me.GroupBox1.Controls.Add(Me.rbValiCSVFail)
        Me.GroupBox1.Location = New System.Drawing.Point(439, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 32)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'rbUusCSVFail
        '
        Me.rbUusCSVFail.AutoSize = True
        Me.rbUusCSVFail.Location = New System.Drawing.Point(157, 9)
        Me.rbUusCSVFail.Name = "rbUusCSVFail"
        Me.rbUusCSVFail.Size = New System.Drawing.Size(103, 17)
        Me.rbUusCSVFail.TabIndex = 25
        Me.rbUusCSVFail.TabStop = True
        Me.rbUusCSVFail.Text = "Loo uus CSV fail"
        Me.rbUusCSVFail.UseVisualStyleBackColor = True
        '
        'rbValiCSVFail
        '
        Me.rbValiCSVFail.AutoSize = True
        Me.rbValiCSVFail.Location = New System.Drawing.Point(11, 9)
        Me.rbValiCSVFail.Name = "rbValiCSVFail"
        Me.rbValiCSVFail.Size = New System.Drawing.Size(98, 17)
        Me.rbValiCSVFail.TabIndex = 24
        Me.rbValiCSVFail.TabStop = True
        Me.rbValiCSVFail.Text = "Vali ise CSV fail"
        Me.rbValiCSVFail.UseVisualStyleBackColor = True
        '
        'gbFailid
        '
        Me.gbFailid.Controls.Add(Me.rbFailiUlekirjutamine)
        Me.gbFailid.Controls.Add(Me.rbLisaFailiLoppu)
        Me.gbFailid.Location = New System.Drawing.Point(439, 98)
        Me.gbFailid.Name = "gbFailid"
        Me.gbFailid.Size = New System.Drawing.Size(260, 55)
        Me.gbFailid.TabIndex = 29
        Me.gbFailid.TabStop = False
        '
        'rbFailiUlekirjutamine
        '
        Me.rbFailiUlekirjutamine.AutoSize = True
        Me.rbFailiUlekirjutamine.Location = New System.Drawing.Point(11, 9)
        Me.rbFailiUlekirjutamine.Name = "rbFailiUlekirjutamine"
        Me.rbFailiUlekirjutamine.Size = New System.Drawing.Size(110, 17)
        Me.rbFailiUlekirjutamine.TabIndex = 24
        Me.rbFailiUlekirjutamine.TabStop = True
        Me.rbFailiUlekirjutamine.Text = "Faili ülekirjutamine"
        Me.rbFailiUlekirjutamine.UseVisualStyleBackColor = True
        '
        'rbLisaFailiLoppu
        '
        Me.rbLisaFailiLoppu.AutoSize = True
        Me.rbLisaFailiLoppu.Location = New System.Drawing.Point(11, 32)
        Me.rbLisaFailiLoppu.Name = "rbLisaFailiLoppu"
        Me.rbLisaFailiLoppu.Size = New System.Drawing.Size(91, 17)
        Me.rbLisaFailiLoppu.TabIndex = 26
        Me.rbLisaFailiLoppu.TabStop = True
        Me.rbLisaFailiLoppu.Text = "Lisa faili lõppu"
        Me.rbLisaFailiLoppu.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(437, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Teksti kvalifikaator:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtboxTekstiKvalifikaator
        '
        Me.txtboxTekstiKvalifikaator.Location = New System.Drawing.Point(542, 72)
        Me.txtboxTekstiKvalifikaator.Name = "txtboxTekstiKvalifikaator"
        Me.txtboxTekstiKvalifikaator.Size = New System.Drawing.Size(19, 20)
        Me.txtboxTekstiKvalifikaator.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(436, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Väljade eraldaja:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtboxValjadeEraldaja
        '
        Me.txtboxValjadeEraldaja.Location = New System.Drawing.Point(542, 41)
        Me.txtboxValjadeEraldaja.Name = "txtboxValjadeEraldaja"
        Me.txtboxValjadeEraldaja.Size = New System.Drawing.Size(19, 20)
        Me.txtboxValjadeEraldaja.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(109, 221)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Impordi hinnastamistingimused:"
        '
        'gbKaibemaks
        '
        Me.gbKaibemaks.Controls.Add(Me.rbKaibemaksuga)
        Me.gbKaibemaks.Controls.Add(Me.rbKaibemaksuta)
        Me.gbKaibemaks.Location = New System.Drawing.Point(110, 186)
        Me.gbKaibemaks.Name = "gbKaibemaks"
        Me.gbKaibemaks.Size = New System.Drawing.Size(307, 32)
        Me.gbKaibemaks.TabIndex = 28
        Me.gbKaibemaks.TabStop = False
        '
        'rbKaibemaksuga
        '
        Me.rbKaibemaksuga.AutoSize = True
        Me.rbKaibemaksuga.Location = New System.Drawing.Point(11, 9)
        Me.rbKaibemaksuga.Name = "rbKaibemaksuga"
        Me.rbKaibemaksuga.Size = New System.Drawing.Size(95, 17)
        Me.rbKaibemaksuga.TabIndex = 24
        Me.rbKaibemaksuga.TabStop = True
        Me.rbKaibemaksuga.Text = "Käibemaksuga"
        Me.rbKaibemaksuga.UseVisualStyleBackColor = True
        '
        'rbKaibemaksuta
        '
        Me.rbKaibemaksuta.AutoSize = True
        Me.rbKaibemaksuta.Location = New System.Drawing.Point(157, 9)
        Me.rbKaibemaksuta.Name = "rbKaibemaksuta"
        Me.rbKaibemaksuta.Size = New System.Drawing.Size(92, 17)
        Me.rbKaibemaksuta.TabIndex = 26
        Me.rbKaibemaksuta.TabStop = True
        Me.rbKaibemaksuta.Text = "Käibemaksuta"
        Me.rbKaibemaksuta.UseVisualStyleBackColor = True
        '
        'gpOoPaevaHind
        '
        Me.gpOoPaevaHind.Controls.Add(Me.rbOoPaevSamaHind)
        Me.gpOoPaevaHind.Controls.Add(Me.rbOoPaevErinevHind)
        Me.gpOoPaevaHind.Location = New System.Drawing.Point(110, 127)
        Me.gpOoPaevaHind.Name = "gpOoPaevaHind"
        Me.gpOoPaevaHind.Size = New System.Drawing.Size(307, 58)
        Me.gpOoPaevaHind.TabIndex = 27
        Me.gpOoPaevaHind.TabStop = False
        '
        'rbOoPaevSamaHind
        '
        Me.rbOoPaevSamaHind.AutoSize = True
        Me.rbOoPaevSamaHind.Location = New System.Drawing.Point(11, 9)
        Me.rbOoPaevSamaHind.Name = "rbOoPaevSamaHind"
        Me.rbOoPaevSamaHind.Size = New System.Drawing.Size(140, 17)
        Me.rbOoPaevSamaHind.TabIndex = 23
        Me.rbOoPaevSamaHind.TabStop = True
        Me.rbOoPaevSamaHind.Text = "Öösel/päeval sama hind"
        Me.rbOoPaevSamaHind.UseVisualStyleBackColor = True
        '
        'rbOoPaevErinevHind
        '
        Me.rbOoPaevErinevHind.AutoSize = True
        Me.rbOoPaevErinevHind.Location = New System.Drawing.Point(11, 32)
        Me.rbOoPaevErinevHind.Name = "rbOoPaevErinevHind"
        Me.rbOoPaevErinevHind.Size = New System.Drawing.Size(144, 17)
        Me.rbOoPaevErinevHind.TabIndex = 25
        Me.rbOoPaevErinevHind.TabStop = True
        Me.rbOoPaevErinevHind.Text = "Öösel/päeval erinev hind"
        Me.rbOoPaevErinevHind.UseVisualStyleBackColor = True
        '
        'dtpBorsihinnaVordlusEnd
        '
        Me.dtpBorsihinnaVordlusEnd.Location = New System.Drawing.Point(197, 75)
        Me.dtpBorsihinnaVordlusEnd.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtpBorsihinnaVordlusEnd.Name = "dtpBorsihinnaVordlusEnd"
        Me.dtpBorsihinnaVordlusEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpBorsihinnaVordlusEnd.TabIndex = 22
        '
        'dtpBorsihinnaVordlusStart
        '
        Me.dtpBorsihinnaVordlusStart.Location = New System.Drawing.Point(197, 49)
        Me.dtpBorsihinnaVordlusStart.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtpBorsihinnaVordlusStart.Name = "dtpBorsihinnaVordlusStart"
        Me.dtpBorsihinnaVordlusStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpBorsihinnaVordlusStart.TabIndex = 21
        Me.dtpBorsihinnaVordlusStart.Value = New Date(2023, 4, 29, 14, 29, 0, 0)
        '
        'chrtBorsihinnaVordlus
        '
        ChartArea3.Name = "ChartArea1"
        Me.chrtBorsihinnaVordlus.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chrtBorsihinnaVordlus.Legends.Add(Legend3)
        Me.chrtBorsihinnaVordlus.Location = New System.Drawing.Point(3, 288)
        Me.chrtBorsihinnaVordlus.Name = "chrtBorsihinnaVordlus"
        Me.chrtBorsihinnaVordlus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chrtBorsihinnaVordlus.Size = New System.Drawing.Size(940, 318)
        Me.chrtBorsihinnaVordlus.TabIndex = 20
        Me.chrtBorsihinnaVordlus.Text = "CSV"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(440, 248)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(84, 34)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "Eksport"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(110, 248)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(84, 34)
        Me.btnImport.TabIndex = 17
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lblExchangeComparisonResult
        '
        Me.lblExchangeComparisonResult.AutoSize = True
        Me.lblExchangeComparisonResult.Location = New System.Drawing.Point(723, 22)
        Me.lblExchangeComparisonResult.Name = "lblExchangeComparisonResult"
        Me.lblExchangeComparisonResult.Size = New System.Drawing.Size(197, 13)
        Me.lblExchangeComparisonResult.TabIndex = 15
        Me.lblExchangeComparisonResult.Text = "Võrdle börsihinda erinevate pakkujatega"
        '
        'lblExchangeChoice
        '
        Me.lblExchangeChoice.AutoSize = True
        Me.lblExchangeChoice.Location = New System.Drawing.Point(436, 22)
        Me.lblExchangeChoice.Name = "lblExchangeChoice"
        Me.lblExchangeChoice.Size = New System.Drawing.Size(155, 13)
        Me.lblExchangeChoice.TabIndex = 8
        Me.lblExchangeChoice.Text = "Lae alla hinnastamistingimused:"
        '
        'lblEnterPrice
        '
        Me.lblEnterPrice.AutoSize = True
        Me.lblEnterPrice.Location = New System.Drawing.Point(107, 111)
        Me.lblEnterPrice.Name = "lblEnterPrice"
        Me.lblEnterPrice.Size = New System.Drawing.Size(152, 13)
        Me.lblEnterPrice.TabIndex = 5
        Me.lblEnterPrice.Text = "Sisesta hinnastamistingimused:"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(107, 81)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.TabIndex = 4
        Me.lblEndTime.Text = "Lõppaeg:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(107, 55)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(54, 13)
        Me.lblStartTime.TabIndex = 3
        Me.lblStartTime.Text = "Algusaeg:"
        '
        'lblTimePeriodSelection
        '
        Me.lblTimePeriodSelection.AutoSize = True
        Me.lblTimePeriodSelection.Location = New System.Drawing.Point(107, 22)
        Me.lblTimePeriodSelection.Name = "lblTimePeriodSelection"
        Me.lblTimePeriodSelection.Size = New System.Drawing.Size(96, 13)
        Me.lblTimePeriodSelection.TabIndex = 2
        Me.lblTimePeriodSelection.Text = "Ajavahemiku valik:"
        '
        'btnBack2
        '
        Me.btnBack2.Location = New System.Drawing.Point(18, 12)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(83, 33)
        Me.btnBack2.TabIndex = 1
        Me.btnBack2.Text = "Tagasi"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'tabConsumptionHistory
        '
        Me.tabConsumptionHistory.Controls.Add(Me.TabControl2)
        Me.tabConsumptionHistory.Controls.Add(Me.btnBack3)
        Me.tabConsumptionHistory.Location = New System.Drawing.Point(4, 26)
        Me.tabConsumptionHistory.Name = "tabConsumptionHistory"
        Me.tabConsumptionHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsumptionHistory.Size = New System.Drawing.Size(975, 642)
        Me.tabConsumptionHistory.TabIndex = 4
        Me.tabConsumptionHistory.Text = "Tarbimise ajalugu"
        Me.tabConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnBack3
        '
        Me.btnBack3.Location = New System.Drawing.Point(18, 3)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(83, 33)
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
        Me.tabPackageComparison.Name = "tabPackageComparison"
        Me.tabPackageComparison.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPackageComparison.Size = New System.Drawing.Size(975, 642)
        Me.tabPackageComparison.TabIndex = 5
        Me.tabPackageComparison.Text = "Elektripakettide võrdlus"
        Me.tabPackageComparison.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Lepingu kuutasu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Firma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Lepingu kuutasu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Firma"
        '
        'priceOfCont2
        '
        Me.priceOfCont2.Location = New System.Drawing.Point(194, 343)
        Me.priceOfCont2.Name = "priceOfCont2"
        Me.priceOfCont2.ReadOnly = True
        Me.priceOfCont2.Size = New System.Drawing.Size(100, 20)
        Me.priceOfCont2.TabIndex = 15
        '
        'compTwo
        '
        Me.compTwo.Location = New System.Drawing.Point(194, 301)
        Me.compTwo.Name = "compTwo"
        Me.compTwo.ReadOnly = True
        Me.compTwo.Size = New System.Drawing.Size(100, 20)
        Me.compTwo.TabIndex = 14
        '
        'priceOfCont
        '
        Me.priceOfCont.Location = New System.Drawing.Point(194, 214)
        Me.priceOfCont.Name = "priceOfCont"
        Me.priceOfCont.ReadOnly = True
        Me.priceOfCont.Size = New System.Drawing.Size(100, 20)
        Me.priceOfCont.TabIndex = 13
        '
        'compOne
        '
        Me.compOne.HideSelection = False
        Me.compOne.Location = New System.Drawing.Point(194, 177)
        Me.compOne.Name = "compOne"
        Me.compOne.ReadOnly = True
        Me.compOne.Size = New System.Drawing.Size(100, 20)
        Me.compOne.TabIndex = 12
        '
        'btnTwoPackets
        '
        Me.btnTwoPackets.Location = New System.Drawing.Point(178, 452)
        Me.btnTwoPackets.Name = "btnTwoPackets"
        Me.btnTwoPackets.Size = New System.Drawing.Size(152, 52)
        Me.btnTwoPackets.TabIndex = 11
        Me.btnTwoPackets.Text = "Võrdle kahte paketti"
        Me.btnTwoPackets.UseVisualStyleBackColor = True
        '
        'btnPackets
        '
        Me.btnPackets.Location = New System.Drawing.Point(18, 452)
        Me.btnPackets.Name = "btnPackets"
        Me.btnPackets.Size = New System.Drawing.Size(152, 52)
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
        Me.chartPackages.Location = New System.Drawing.Point(365, 104)
        Me.chartPackages.Margin = New System.Windows.Forms.Padding(2)
        Me.chartPackages.Name = "chartPackages"
        Me.chartPackages.Size = New System.Drawing.Size(600, 400)
        Me.chartPackages.TabIndex = 9
        '
        'lblComparisonResult
        '
        Me.lblComparisonResult.AutoSize = True
        Me.lblComparisonResult.Location = New System.Drawing.Point(362, 64)
        Me.lblComparisonResult.Name = "lblComparisonResult"
        Me.lblComparisonResult.Size = New System.Drawing.Size(50, 13)
        Me.lblComparisonResult.TabIndex = 7
        Me.lblComparisonResult.Text = "Tulemus:"
        '
        'cBoxPackage2
        '
        Me.cBoxPackage2.FormattingEnabled = True
        Me.cBoxPackage2.Items.AddRange(New Object() {"Kindel 6", "Kindel 36", "Kindel Pluss", "Muutuv", "Universaalteenus", "Pingevaba + Ühisarve", "Tähtajaline fikseeritud hind", "Kodupakett börsihinnaga", "Universaalteenus Alexela", "Universaalteenus Alexela + roheline", "Tähtajaline fikseeritud hind + roheline", "220 Börsihind", "220 Börsihind + Roheline", "220 Tähtajaline kindel hind", "220 Tähtajaline kindel hind + roheline", "220 Universaalteenus", "220 Universaalteenus + roheline", "Kindel pakett gaas", "Muutuvhinnaga pakett", "Universaalteenus Eesti gaas", "Universaalteenus VKG", "Not-fix", "Roheline Klõps", "Roheline Börsi Klõps", "Börsi Klõps", "Universaalteenus Elektrum", "Kaljukindel Klõps kindlustusega"})
        Me.cBoxPackage2.Location = New System.Drawing.Point(151, 263)
        Me.cBoxPackage2.Name = "cBoxPackage2"
        Me.cBoxPackage2.Size = New System.Drawing.Size(143, 21)
        Me.cBoxPackage2.TabIndex = 6
        '
        'cBoxPackage1
        '
        Me.cBoxPackage1.FormattingEnabled = True
        Me.cBoxPackage1.Items.AddRange(New Object() {"Kindel 6", "Kindel 36", "Kindel Pluss", "Muutuv", "Universaalteenus", "Pingevaba + Ühisarve", "Tähtajaline fikseeritud hind", "Kodupakett börsihinnaga", "Universaalteenus Alexela", "Universaalteenus Alexela + roheline", "Tähtajaline fikseeritud hind + roheline", "220 Börsihind", "220 Börsihind + Roheline", "220 Tähtajaline kindel hind", "220 Tähtajaline kindel hind + roheline", "220 Universaalteenus", "220 Universaalteenus + roheline", "Kindel pakett gaas", "Muutuvhinnaga pakett", "Universaalteenus Eesti gaas", "Universaalteenus VKG", "Not-fix", "Roheline Klõps", "Roheline Börsi Klõps", "Börsi Klõps", "Universaalteenus Elektrum", "Kaljukindel Klõps kindlustusega"})
        Me.cBoxPackage1.Location = New System.Drawing.Point(151, 139)
        Me.cBoxPackage1.Name = "cBoxPackage1"
        Me.cBoxPackage1.Size = New System.Drawing.Size(143, 21)
        Me.cBoxPackage1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Elektripakett 2:"
        '
        'lblPackage1
        '
        Me.lblPackage1.AutoSize = True
        Me.lblPackage1.Location = New System.Drawing.Point(26, 139)
        Me.lblPackage1.Name = "lblPackage1"
        Me.lblPackage1.Size = New System.Drawing.Size(78, 13)
        Me.lblPackage1.TabIndex = 3
        Me.lblPackage1.Text = "Elektripakett 1:"
        '
        'lblChoosePackages
        '
        Me.lblChoosePackages.AutoSize = True
        Me.lblChoosePackages.Location = New System.Drawing.Point(26, 64)
        Me.lblChoosePackages.Name = "lblChoosePackages"
        Me.lblChoosePackages.Size = New System.Drawing.Size(93, 13)
        Me.lblChoosePackages.TabIndex = 2
        Me.lblChoosePackages.Text = "Vali elektripaketid:"
        '
        'btnBack4
        '
        Me.btnBack4.Location = New System.Drawing.Point(18, 12)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(83, 33)
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
        Me.tabGreenEnergy.Margin = New System.Windows.Forms.Padding(2)
        Me.tabGreenEnergy.Name = "tabGreenEnergy"
        Me.tabGreenEnergy.Size = New System.Drawing.Size(975, 642)
        Me.tabGreenEnergy.TabIndex = 6
        Me.tabGreenEnergy.Text = "Ilm ja roheline energia"
        Me.tabGreenEnergy.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 211)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Tootmine"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 16)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Ilm"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(422, 84)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Hinnang tootmisele"
        '
        'tbOpinion
        '
        Me.tbOpinion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbOpinion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOpinion.Location = New System.Drawing.Point(422, 115)
        Me.tbOpinion.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOpinion.Multiline = True
        Me.tbOpinion.Name = "tbOpinion"
        Me.tbOpinion.ReadOnly = True
        Me.tbOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOpinion.Size = New System.Drawing.Size(334, 181)
        Me.tbOpinion.TabIndex = 4
        '
        'btnProduction
        '
        Me.btnProduction.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnProduction.Location = New System.Drawing.Point(275, 277)
        Me.btnProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(103, 62)
        Me.btnProduction.TabIndex = 3
        Me.btnProduction.Text = "Tootmine"
        Me.btnProduction.UseVisualStyleBackColor = False
        '
        'tbProduction
        '
        Me.tbProduction.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProduction.Location = New System.Drawing.Point(32, 240)
        Me.tbProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.tbProduction.Multiline = True
        Me.tbProduction.Name = "tbProduction"
        Me.tbProduction.ReadOnly = True
        Me.tbProduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbProduction.Size = New System.Drawing.Size(184, 111)
        Me.tbProduction.TabIndex = 2
        '
        'btnWeather
        '
        Me.btnWeather.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnWeather.Location = New System.Drawing.Point(275, 84)
        Me.btnWeather.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWeather.Name = "btnWeather"
        Me.btnWeather.Size = New System.Drawing.Size(103, 58)
        Me.btnWeather.TabIndex = 1
        Me.btnWeather.Text = "Ilm Tallinnas Praegu"
        Me.btnWeather.UseVisualStyleBackColor = False
        '
        'tbWeather
        '
        Me.tbWeather.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWeather.Location = New System.Drawing.Point(32, 41)
        Me.tbWeather.Margin = New System.Windows.Forms.Padding(2)
        Me.tbWeather.Multiline = True
        Me.tbWeather.Name = "tbWeather"
        Me.tbWeather.ReadOnly = True
        Me.tbWeather.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbWeather.Size = New System.Drawing.Size(184, 111)
        Me.tbWeather.TabIndex = 0
        '
        'lblChangeFontSize
        '
        Me.lblChangeFontSize.AutoSize = True
        Me.lblChangeFontSize.Location = New System.Drawing.Point(128, 13)
        Me.lblChangeFontSize.Name = "lblChangeFontSize"
        Me.lblChangeFontSize.Size = New System.Drawing.Size(142, 13)
        Me.lblChangeFontSize.TabIndex = 7
        Me.lblChangeFontSize.Text = "MUUDA FONDI SUURUST:"
        '
        'btnFontIncrease
        '
        Me.btnFontIncrease.Location = New System.Drawing.Point(323, 6)
        Me.btnFontIncrease.Name = "btnFontIncrease"
        Me.btnFontIncrease.Size = New System.Drawing.Size(23, 27)
        Me.btnFontIncrease.TabIndex = 8
        Me.btnFontIncrease.Text = "+"
        Me.btnFontIncrease.UseVisualStyleBackColor = True
        '
        'btnFontDecrease
        '
        Me.btnFontDecrease.Location = New System.Drawing.Point(352, 6)
        Me.btnFontDecrease.Name = "btnFontDecrease"
        Me.btnFontDecrease.Size = New System.Drawing.Size(23, 27)
        Me.btnFontDecrease.TabIndex = 9
        Me.btnFontDecrease.Text = "-"
        Me.btnFontDecrease.UseVisualStyleBackColor = True
        '
        'btnRestoreFontSize
        '
        Me.btnRestoreFontSize.Location = New System.Drawing.Point(381, 6)
        Me.btnRestoreFontSize.Name = "btnRestoreFontSize"
        Me.btnRestoreFontSize.Size = New System.Drawing.Size(168, 27)
        Me.btnRestoreFontSize.TabIndex = 10
        Me.btnRestoreFontSize.Text = "Taasta fondi suurus"
        Me.btnRestoreFontSize.UseVisualStyleBackColor = True
        '
        'tabClientConsumptionHistory
        '
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblPriceTotalFromPackage)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblPriceTotalFromImport)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblChoosePackage)
        Me.tabClientConsumptionHistory.Controls.Add(Me.cbChoosePackage)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblMarg)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblFixed)
        Me.tabClientConsumptionHistory.Controls.Add(Me.Label2)
        Me.tabClientConsumptionHistory.Controls.Add(Me.Label19)
        Me.tabClientConsumptionHistory.Controls.Add(Me.tbDayPrice2)
        Me.tabClientConsumptionHistory.Controls.Add(Me.tbDayPrice1)
        Me.tabClientConsumptionHistory.Controls.Add(Me.tbNightOrMarginal)
        Me.tabClientConsumptionHistory.Controls.Add(Me.tbPrice)
        Me.tabClientConsumptionHistory.Controls.Add(Me.tbDebug)
        Me.tabClientConsumptionHistory.Controls.Add(Me.chrtHistory)
        Me.tabClientConsumptionHistory.Controls.Add(Me.Panel4)
        Me.tabClientConsumptionHistory.Controls.Add(Me.cbMarginal)
        Me.tabClientConsumptionHistory.Controls.Add(Me.cbNighPrice)
        Me.tabClientConsumptionHistory.Controls.Add(Me.btnConfirmSimuCSV)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblToDateTime)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblFromDateTime)
        Me.tabClientConsumptionHistory.Controls.Add(Me.dtpEnd)
        Me.tabClientConsumptionHistory.Controls.Add(Me.dtpBeginning)
        Me.tabClientConsumptionHistory.Controls.Add(Me.Label20)
        Me.tabClientConsumptionHistory.Controls.Add(Me.btnImportCSVFileSimu)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblSimulateClientConsumptionHistory)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblConsumptionGraph)
        Me.tabClientConsumptionHistory.Controls.Add(Me.lblClientConsumptionHistoryResult)
        Me.tabClientConsumptionHistory.Location = New System.Drawing.Point(4, 29)
        Me.tabClientConsumptionHistory.Name = "tabClientConsumptionHistory"
        Me.tabClientConsumptionHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClientConsumptionHistory.Size = New System.Drawing.Size(941, 561)
        Me.tabClientConsumptionHistory.TabIndex = 1
        Me.tabClientConsumptionHistory.Text = "Simuleeri oma tarbimise ajalugu"
        Me.tabClientConsumptionHistory.UseVisualStyleBackColor = True
        '
        'lblClientConsumptionHistoryResult
        '
        Me.lblClientConsumptionHistoryResult.AutoSize = True
        Me.lblClientConsumptionHistoryResult.Location = New System.Drawing.Point(380, 31)
        Me.lblClientConsumptionHistoryResult.Name = "lblClientConsumptionHistoryResult"
        Me.lblClientConsumptionHistoryResult.Size = New System.Drawing.Size(50, 13)
        Me.lblClientConsumptionHistoryResult.TabIndex = 35
        Me.lblClientConsumptionHistoryResult.Text = "Tulemus:"
        '
        'lblConsumptionGraph
        '
        Me.lblConsumptionGraph.AutoSize = True
        Me.lblConsumptionGraph.Location = New System.Drawing.Point(380, 85)
        Me.lblConsumptionGraph.Name = "lblConsumptionGraph"
        Me.lblConsumptionGraph.Size = New System.Drawing.Size(78, 13)
        Me.lblConsumptionGraph.TabIndex = 36
        Me.lblConsumptionGraph.Text = "Tarbimisgraafik"
        '
        'lblSimulateClientConsumptionHistory
        '
        Me.lblSimulateClientConsumptionHistory.AutoSize = True
        Me.lblSimulateClientConsumptionHistory.Location = New System.Drawing.Point(15, 9)
        Me.lblSimulateClientConsumptionHistory.Name = "lblSimulateClientConsumptionHistory"
        Me.lblSimulateClientConsumptionHistory.Size = New System.Drawing.Size(225, 13)
        Me.lblSimulateClientConsumptionHistory.TabIndex = 37
        Me.lblSimulateClientConsumptionHistory.Text = "Vali oma paketi tüüp     Kõik hinnad sent/kWh"
        '
        'btnImportCSVFileSimu
        '
        Me.btnImportCSVFileSimu.Location = New System.Drawing.Point(62, 234)
        Me.btnImportCSVFileSimu.Name = "btnImportCSVFileSimu"
        Me.btnImportCSVFileSimu.Size = New System.Drawing.Size(150, 34)
        Me.btnImportCSVFileSimu.TabIndex = 38
        Me.btnImportCSVFileSimu.Text = "Impordi CSV fail"
        Me.btnImportCSVFileSimu.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(60, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(176, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Lae üles enda tarbimisajalugu(CSV):"
        '
        'dtpBeginning
        '
        Me.dtpBeginning.Enabled = False
        Me.dtpBeginning.Location = New System.Drawing.Point(62, 306)
        Me.dtpBeginning.Name = "dtpBeginning"
        Me.dtpBeginning.Size = New System.Drawing.Size(200, 20)
        Me.dtpBeginning.TabIndex = 40
        '
        'dtpEnd
        '
        Me.dtpEnd.Enabled = False
        Me.dtpEnd.Location = New System.Drawing.Point(63, 363)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 41
        '
        'lblFromDateTime
        '
        Me.lblFromDateTime.AutoSize = True
        Me.lblFromDateTime.Location = New System.Drawing.Point(61, 281)
        Me.lblFromDateTime.Name = "lblFromDateTime"
        Me.lblFromDateTime.Size = New System.Drawing.Size(100, 13)
        Me.lblFromDateTime.TabIndex = 42
        Me.lblFromDateTime.Text = "Vali algus kuupäev:"
        '
        'lblToDateTime
        '
        Me.lblToDateTime.AutoSize = True
        Me.lblToDateTime.Location = New System.Drawing.Point(61, 338)
        Me.lblToDateTime.Name = "lblToDateTime"
        Me.lblToDateTime.Size = New System.Drawing.Size(95, 13)
        Me.lblToDateTime.TabIndex = 43
        Me.lblToDateTime.Text = "Vali lõpp kuupäev:"
        '
        'tbDebug
        '
        Me.tbDebug.Location = New System.Drawing.Point(383, 505)
        Me.tbDebug.Multiline = True
        Me.tbDebug.Name = "tbDebug"
        Me.tbDebug.ReadOnly = True
        Me.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDebug.Size = New System.Drawing.Size(515, 21)
        Me.tbDebug.TabIndex = 44
        '
        'btnConfirmSimuCSV
        '
        Me.btnConfirmSimuCSV.Location = New System.Drawing.Point(63, 464)
        Me.btnConfirmSimuCSV.Name = "btnConfirmSimuCSV"
        Me.btnConfirmSimuCSV.Size = New System.Drawing.Size(150, 34)
        Me.btnConfirmSimuCSV.TabIndex = 45
        Me.btnConfirmSimuCSV.Text = "Kinnita andmed"
        Me.btnConfirmSimuCSV.UseVisualStyleBackColor = True
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(116, 118)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(99, 20)
        Me.tbPrice.TabIndex = 48
        Me.tbPrice.Visible = False
        '
        'cbNighPrice
        '
        Me.cbNighPrice.AutoSize = True
        Me.cbNighPrice.Location = New System.Drawing.Point(23, 95)
        Me.cbNighPrice.Name = "cbNighPrice"
        Me.cbNighPrice.Size = New System.Drawing.Size(110, 17)
        Me.cbNighPrice.TabIndex = 46
        Me.cbNighPrice.Text = "Öö hind on erinev"
        Me.cbNighPrice.UseVisualStyleBackColor = True
        Me.cbNighPrice.Visible = False
        '
        'cbMarginal
        '
        Me.cbMarginal.AutoSize = True
        Me.cbMarginal.Location = New System.Drawing.Point(136, 95)
        Me.cbMarginal.Name = "cbMarginal"
        Me.cbMarginal.Size = New System.Drawing.Size(117, 17)
        Me.cbMarginal.TabIndex = 47
        Me.cbMarginal.Text = "Lisandub marginaal"
        Me.cbMarginal.UseVisualStyleBackColor = True
        Me.cbMarginal.Visible = False
        '
        'tbNightOrMarginal
        '
        Me.tbNightOrMarginal.Location = New System.Drawing.Point(116, 149)
        Me.tbNightOrMarginal.Name = "tbNightOrMarginal"
        Me.tbNightOrMarginal.Size = New System.Drawing.Size(99, 20)
        Me.tbNightOrMarginal.TabIndex = 49
        Me.tbNightOrMarginal.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbFix)
        Me.Panel4.Controls.Add(Me.rbStock)
        Me.Panel4.Location = New System.Drawing.Point(18, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(251, 53)
        Me.Panel4.TabIndex = 50
        '
        'rbStock
        '
        Me.rbStock.AutoSize = True
        Me.rbStock.Location = New System.Drawing.Point(3, 33)
        Me.rbStock.Name = "rbStock"
        Me.rbStock.Size = New System.Drawing.Size(113, 17)
        Me.rbStock.TabIndex = 18
        Me.rbStock.TabStop = True
        Me.rbStock.Text = "Börsihinnast sõltuv"
        Me.rbStock.UseVisualStyleBackColor = True
        '
        'rbFix
        '
        Me.rbFix.AutoSize = True
        Me.rbFix.Location = New System.Drawing.Point(3, 6)
        Me.rbFix.Name = "rbFix"
        Me.rbFix.Size = New System.Drawing.Size(76, 17)
        Me.rbFix.TabIndex = 17
        Me.rbFix.TabStop = True
        Me.rbFix.Text = "Fikseeritud"
        Me.rbFix.UseVisualStyleBackColor = True
        '
        'chrtHistory
        '
        ChartArea4.Name = "ChartArea1"
        Me.chrtHistory.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chrtHistory.Legends.Add(Legend4)
        Me.chrtHistory.Location = New System.Drawing.Point(383, 100)
        Me.chrtHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.chrtHistory.Name = "chrtHistory"
        Me.chrtHistory.Size = New System.Drawing.Size(515, 400)
        Me.chrtHistory.TabIndex = 51
        Me.chrtHistory.Text = "Chart1"
        '
        'tbDayPrice1
        '
        Me.tbDayPrice1.Location = New System.Drawing.Point(90, 176)
        Me.tbDayPrice1.Name = "tbDayPrice1"
        Me.tbDayPrice1.Size = New System.Drawing.Size(43, 20)
        Me.tbDayPrice1.TabIndex = 52
        Me.tbDayPrice1.Visible = False
        '
        'tbDayPrice2
        '
        Me.tbDayPrice2.Location = New System.Drawing.Point(172, 175)
        Me.tbDayPrice2.Name = "tbDayPrice2"
        Me.tbDayPrice2.Size = New System.Drawing.Size(43, 20)
        Me.tbDayPrice2.TabIndex = 53
        Me.tbDayPrice2.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(26, 178)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Päevahind"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "kuni"
        '
        'lblFixed
        '
        Me.lblFixed.AutoSize = True
        Me.lblFixed.Location = New System.Drawing.Point(9, 121)
        Me.lblFixed.Name = "lblFixed"
        Me.lblFixed.Size = New System.Drawing.Size(101, 13)
        Me.lblFixed.TabIndex = 56
        Me.lblFixed.Text = "Fiktsioneeritud hind:"
        '
        'lblMarg
        '
        Me.lblMarg.AutoSize = True
        Me.lblMarg.Location = New System.Drawing.Point(54, 152)
        Me.lblMarg.Name = "lblMarg"
        Me.lblMarg.Size = New System.Drawing.Size(56, 13)
        Me.lblMarg.TabIndex = 57
        Me.lblMarg.Text = "Marginaal:"
        '
        'cbChoosePackage
        '
        Me.cbChoosePackage.FormattingEnabled = True
        Me.cbChoosePackage.Items.AddRange(New Object() {"Kindel 6", "Kindel 36", "Kindel Pluss", "Muutuv", "Universaalteenus", "Pingevaba + Ühisarve", "Tähtajaline fikseeritud hind", "Kodupakett börsihinnaga", "Universaalteenus Alexela", "Universaalteenus Alexela + roheline", "Tähtajaline fikseeritud hind + roheline", "220 Börsihind", "220 Börsihind + Roheline", "220 Tähtajaline kindel hind", "220 Tähtajaline kindel hind + roheline", "220 Universaalteenus", "220 Universaalteenus + roheline", "Kindel pakett gaas", "Muutuvhinnaga pakett", "Universaalteenus Eesti gaas", "Universaalteenus VKG", "Not-fix", "Roheline Klõps", "Roheline Börsi Klõps", "Börsi Klõps", "Universaalteenus Elektrum", "Kaljukindel Klõps kindlustusega"})
        Me.cbChoosePackage.Location = New System.Drawing.Point(64, 423)
        Me.cbChoosePackage.Name = "cbChoosePackage"
        Me.cbChoosePackage.Size = New System.Drawing.Size(198, 21)
        Me.cbChoosePackage.TabIndex = 58
        '
        'lblChoosePackage
        '
        Me.lblChoosePackage.AutoSize = True
        Me.lblChoosePackage.Location = New System.Drawing.Point(64, 397)
        Me.lblChoosePackage.Name = "lblChoosePackage"
        Me.lblChoosePackage.Size = New System.Drawing.Size(60, 13)
        Me.lblChoosePackage.TabIndex = 59
        Me.lblChoosePackage.Text = "Vali pakett:"
        '
        'lblPriceTotalFromImport
        '
        Me.lblPriceTotalFromImport.AutoSize = True
        Me.lblPriceTotalFromImport.Location = New System.Drawing.Point(9, 513)
        Me.lblPriceTotalFromImport.Name = "lblPriceTotalFromImport"
        Me.lblPriceTotalFromImport.Size = New System.Drawing.Size(246, 13)
        Me.lblPriceTotalFromImport.TabIndex = 60
        Me.lblPriceTotalFromImport.Text = "Kogu vahemiku elektri hind vastavalt sinu paketile:"
        '
        'lblPriceTotalFromPackage
        '
        Me.lblPriceTotalFromPackage.AutoSize = True
        Me.lblPriceTotalFromPackage.Location = New System.Drawing.Point(9, 531)
        Me.lblPriceTotalFromPackage.Name = "lblPriceTotalFromPackage"
        Me.lblPriceTotalFromPackage.Size = New System.Drawing.Size(258, 13)
        Me.lblPriceTotalFromPackage.TabIndex = 61
        Me.lblPriceTotalFromPackage.Text = "Kogu vahemiku elektri hind vastavalt valitud paketile:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabClientConsumptionHistory)
        Me.TabControl2.ItemSize = New System.Drawing.Size(42, 25)
        Me.TabControl2.Location = New System.Drawing.Point(0, 42)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(949, 594)
        Me.TabControl2.TabIndex = 2
        '
        'GUIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 721)
        Me.Controls.Add(Me.btnRestoreFontSize)
        Me.Controls.Add(Me.btnFontDecrease)
        Me.Controls.Add(Me.btnFontIncrease)
        Me.Controls.Add(Me.lblChangeFontSize)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFailid.ResumeLayout(False)
        Me.gbFailid.PerformLayout()
        Me.gbKaibemaks.ResumeLayout(False)
        Me.gbKaibemaks.PerformLayout()
        Me.gpOoPaevaHind.ResumeLayout(False)
        Me.gpOoPaevaHind.PerformLayout()
        CType(Me.chrtBorsihinnaVordlus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsumptionHistory.ResumeLayout(False)
        Me.tabPackageComparison.ResumeLayout(False)
        Me.tabPackageComparison.PerformLayout()
        CType(Me.chartPackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGreenEnergy.ResumeLayout(False)
        Me.tabGreenEnergy.PerformLayout()
        Me.tabClientConsumptionHistory.ResumeLayout(False)
        Me.tabClientConsumptionHistory.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.chrtHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
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
    Friend WithEvents lblEnterPrice As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblTimePeriodSelection As Label
    Friend WithEvents lblExchangeComparisonResult As Label
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
    Friend WithEvents chrtBorsihinnaVordlus As DataVisualization.Charting.Chart
    Friend WithEvents tbMarginalOfStock As TextBox
    Friend WithEvents rdiobtnStockPlussMarginal As RadioButton
    Friend WithEvents rdioBtnUniversalP As RadioButton
    Friend WithEvents btnTableDesc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSKwh4 As Label
    Friend WithEvents lblSKwh3 As Label
    Friend WithEvents lblTableState As Label
    Friend WithEvents lblBestTime As Label
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
    Friend WithEvents dtpBorsihinnaVordlusEnd As DateTimePicker
    Friend WithEvents dtpBorsihinnaVordlusStart As DateTimePicker
    Friend WithEvents rbKaibemaksuta As RadioButton
    Friend WithEvents rbOoPaevErinevHind As RadioButton
    Friend WithEvents rbKaibemaksuga As RadioButton
    Friend WithEvents rbOoPaevSamaHind As RadioButton
    Friend WithEvents gpOoPaevaHind As GroupBox
    Friend WithEvents gbKaibemaks As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtboxValjadeEraldaja As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtboxTekstiKvalifikaator As TextBox
    Friend WithEvents gbFailid As GroupBox
    Friend WithEvents rbFailiUlekirjutamine As RadioButton
    Friend WithEvents rbLisaFailiLoppu As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbValiCSVFail As RadioButton
    Friend WithEvents rbUusCSVFail As RadioButton
    Friend WithEvents lblFailiPath As Label
    Friend WithEvents llNaidisCSV As LinkLabel
    Friend WithEvents cbBorsiPakettid As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnKinnitaAndmed As Button
    Friend WithEvents lblDontuse As Label
    Friend WithEvents lblMarginaal As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tabClientConsumptionHistory As TabPage
    Friend WithEvents lblPriceTotalFromPackage As Label
    Friend WithEvents lblPriceTotalFromImport As Label
    Friend WithEvents lblChoosePackage As Label
    Friend WithEvents cbChoosePackage As ComboBox
    Friend WithEvents lblMarg As Label
    Friend WithEvents lblFixed As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tbDayPrice2 As TextBox
    Friend WithEvents tbDayPrice1 As TextBox
    Friend WithEvents tbNightOrMarginal As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbDebug As TextBox
    Friend WithEvents chrtHistory As DataVisualization.Charting.Chart
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rbFix As RadioButton
    Friend WithEvents rbStock As RadioButton
    Friend WithEvents cbMarginal As CheckBox
    Friend WithEvents cbNighPrice As CheckBox
    Friend WithEvents btnConfirmSimuCSV As Button
    Friend WithEvents lblToDateTime As Label
    Friend WithEvents lblFromDateTime As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpBeginning As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents btnImportCSVFileSimu As Button
    Friend WithEvents lblSimulateClientConsumptionHistory As Label
    Friend WithEvents lblConsumptionGraph As Label
    Friend WithEvents lblClientConsumptionHistoryResult As Label
End Class
