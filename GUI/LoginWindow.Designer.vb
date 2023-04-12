<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tBoxUsername = New System.Windows.Forms.TextBox()
        Me.tBoxPassword = New System.Windows.Forms.TextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(467, 225)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 28)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Logi sisse"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(352, 142)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(92, 17)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Kasutajanimi:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(372, 178)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 17)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Salasõna:"
        '
        'tBoxUsername
        '
        Me.tBoxUsername.Location = New System.Drawing.Point(452, 138)
        Me.tBoxUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tBoxUsername.Name = "tBoxUsername"
        Me.tBoxUsername.Size = New System.Drawing.Size(132, 22)
        Me.tBoxUsername.TabIndex = 3
        '
        'tBoxPassword
        '
        Me.tBoxPassword.Location = New System.Drawing.Point(452, 175)
        Me.tBoxPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tBoxPassword.Name = "tBoxPassword"
        Me.tBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tBoxPassword.Size = New System.Drawing.Size(132, 22)
        Me.tBoxPassword.TabIndex = 4
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(467, 277)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(100, 28)
        Me.btnSignUp.TabIndex = 5
        Me.btnSignUp.Text = "Registreeri"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'LoginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.tBoxPassword)
        Me.Controls.Add(Me.tBoxUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LoginWindow"
        Me.Text = "LoginWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tBoxUsername As TextBox
    Friend WithEvents tBoxPassword As TextBox
    Friend WithEvents btnSignUp As Button
End Class
