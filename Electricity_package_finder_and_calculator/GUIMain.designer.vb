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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPackageHourlyRate = New System.Windows.Forms.Button()
        Me.btnApplianceCalc = New System.Windows.Forms.Button()
        Me.btnExchangePriceComparison = New System.Windows.Forms.Button()
        Me.btnConsumptionHistory = New System.Windows.Forms.Button()
        Me.btnPackageComparison = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Main = New System.Windows.Forms.TabPage()
        Me.tabPackageHourlyRate = New System.Windows.Forms.TabPage()
        Me.btnBack0 = New System.Windows.Forms.Button()
        Me.tabApplianceCalc = New System.Windows.Forms.TabPage()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.tabExchangeComparison = New System.Windows.Forms.TabPage()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.tabConsumptionHistory = New System.Windows.Forms.TabPage()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.tabPackageComparison = New System.Windows.Forms.TabPage()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Main.SuspendLayout()
        Me.tabPackageHourlyRate.SuspendLayout()
        Me.tabApplianceCalc.SuspendLayout()
        Me.tabExchangeComparison.SuspendLayout()
        Me.tabConsumptionHistory.SuspendLayout()
        Me.tabPackageComparison.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENÜÜ"
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
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 22)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(839, 613)
        Me.TabControl1.TabIndex = 6
        '
        'Main
        '
        Me.Main.BackColor = System.Drawing.Color.Transparent
        Me.Main.Controls.Add(Me.btnPackageHourlyRate)
        Me.Main.Controls.Add(Me.btnPackageComparison)
        Me.Main.Controls.Add(Me.btnApplianceCalc)
        Me.Main.Controls.Add(Me.btnConsumptionHistory)
        Me.Main.Controls.Add(Me.btnExchangePriceComparison)
        Me.Main.Location = New System.Drawing.Point(4, 26)
        Me.Main.Name = "Main"
        Me.Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Main.Size = New System.Drawing.Size(831, 583)
        Me.Main.TabIndex = 0
        Me.Main.Text = "Home"
        '
        'tabPackageHourlyRate
        '
        Me.tabPackageHourlyRate.Controls.Add(Me.btnBack0)
        Me.tabPackageHourlyRate.Location = New System.Drawing.Point(4, 26)
        Me.tabPackageHourlyRate.Name = "tabPackageHourlyRate"
        Me.tabPackageHourlyRate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPackageHourlyRate.Size = New System.Drawing.Size(831, 583)
        Me.tabPackageHourlyRate.TabIndex = 1
        Me.tabPackageHourlyRate.Text = "Paketijärgne tunnihind"
        Me.tabPackageHourlyRate.UseVisualStyleBackColor = True
        '
        'btnBack0
        '
        Me.btnBack0.Location = New System.Drawing.Point(17, 17)
        Me.btnBack0.Name = "btnBack0"
        Me.btnBack0.Size = New System.Drawing.Size(75, 23)
        Me.btnBack0.TabIndex = 0
        Me.btnBack0.Text = "Tagasi"
        Me.btnBack0.UseVisualStyleBackColor = True
        '
        'tabApplianceCalc
        '
        Me.tabApplianceCalc.Controls.Add(Me.btnBack1)
        Me.tabApplianceCalc.Location = New System.Drawing.Point(4, 26)
        Me.tabApplianceCalc.Name = "tabApplianceCalc"
        Me.tabApplianceCalc.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApplianceCalc.Size = New System.Drawing.Size(831, 583)
        Me.tabApplianceCalc.TabIndex = 2
        Me.tabApplianceCalc.Text = "Kodumasina tarbimise hinna kalkulaator"
        Me.tabApplianceCalc.UseVisualStyleBackColor = True
        '
        'btnBack1
        '
        Me.btnBack1.Location = New System.Drawing.Point(17, 17)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(75, 23)
        Me.btnBack1.TabIndex = 1
        Me.btnBack1.Text = "Tagasi"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'tabExchangeComparison
        '
        Me.tabExchangeComparison.Controls.Add(Me.btnBack2)
        Me.tabExchangeComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabExchangeComparison.Name = "tabExchangeComparison"
        Me.tabExchangeComparison.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExchangeComparison.Size = New System.Drawing.Size(831, 583)
        Me.tabExchangeComparison.TabIndex = 3
        Me.tabExchangeComparison.Text = "Börsihinna võrdlus"
        Me.tabExchangeComparison.UseVisualStyleBackColor = True
        '
        'btnBack2
        '
        Me.btnBack2.Location = New System.Drawing.Point(17, 17)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(75, 23)
        Me.btnBack2.TabIndex = 1
        Me.btnBack2.Text = "Tagasi"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'tabConsumptionHistory
        '
        Me.tabConsumptionHistory.Controls.Add(Me.btnBack3)
        Me.tabConsumptionHistory.Location = New System.Drawing.Point(4, 26)
        Me.tabConsumptionHistory.Name = "tabConsumptionHistory"
        Me.tabConsumptionHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsumptionHistory.Size = New System.Drawing.Size(831, 583)
        Me.tabConsumptionHistory.TabIndex = 4
        Me.tabConsumptionHistory.Text = "Tarbimise ajalugu"
        Me.tabConsumptionHistory.UseVisualStyleBackColor = True
        '
        'btnBack3
        '
        Me.btnBack3.Location = New System.Drawing.Point(17, 17)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(75, 23)
        Me.btnBack3.TabIndex = 1
        Me.btnBack3.Text = "Tagasi"
        Me.btnBack3.UseVisualStyleBackColor = True
        '
        'tabPackageComparison
        '
        Me.tabPackageComparison.Controls.Add(Me.btnBack4)
        Me.tabPackageComparison.Location = New System.Drawing.Point(4, 26)
        Me.tabPackageComparison.Name = "tabPackageComparison"
        Me.tabPackageComparison.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPackageComparison.Size = New System.Drawing.Size(831, 583)
        Me.tabPackageComparison.TabIndex = 5
        Me.tabPackageComparison.Text = "Elektripakettide võrdlus"
        Me.tabPackageComparison.UseVisualStyleBackColor = True
        '
        'btnBack4
        '
        Me.btnBack4.Location = New System.Drawing.Point(17, 17)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(75, 23)
        Me.btnBack4.TabIndex = 1
        Me.btnBack4.Text = "Tagasi"
        Me.btnBack4.UseVisualStyleBackColor = True
        '
        'GUIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 662)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUIMain"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        Me.tabPackageHourlyRate.ResumeLayout(False)
        Me.tabApplianceCalc.ResumeLayout(False)
        Me.tabExchangeComparison.ResumeLayout(False)
        Me.tabConsumptionHistory.ResumeLayout(False)
        Me.tabPackageComparison.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
End Class
