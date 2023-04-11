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
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(350, 183)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Logi sisse"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(264, 115)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(69, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Kasutajanimi:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(279, 145)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(54, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Salasõna:"
        '
        'tBoxUsername
        '
        Me.tBoxUsername.Location = New System.Drawing.Point(339, 112)
        Me.tBoxUsername.Name = "tBoxUsername"
        Me.tBoxUsername.Size = New System.Drawing.Size(100, 20)
        Me.tBoxUsername.TabIndex = 3
        '
        'tBoxPassword
        '
        Me.tBoxPassword.Location = New System.Drawing.Point(339, 142)
        Me.tBoxPassword.Name = "tBoxPassword"
        Me.tBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.tBoxPassword.TabIndex = 4
        '
        'LoginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tBoxPassword)
        Me.Controls.Add(Me.tBoxUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogin)
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
End Class
