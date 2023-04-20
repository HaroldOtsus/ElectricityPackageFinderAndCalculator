<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.tBoxUsername = New System.Windows.Forms.TextBox()
        Me.tBoxPassword = New System.Windows.Forms.TextBox()
        Me.lblEnterUsername = New System.Windows.Forms.Label()
        Me.lblEnterPassword = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tBoxEmail = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tBoxName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tBoxUsername
        '
        Me.tBoxUsername.Location = New System.Drawing.Point(366, 103)
        Me.tBoxUsername.Name = "tBoxUsername"
        Me.tBoxUsername.Size = New System.Drawing.Size(100, 20)
        Me.tBoxUsername.TabIndex = 0
        '
        'tBoxPassword
        '
        Me.tBoxPassword.Location = New System.Drawing.Point(366, 218)
        Me.tBoxPassword.Name = "tBoxPassword"
        Me.tBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.tBoxPassword.TabIndex = 1
        '
        'lblEnterUsername
        '
        Me.lblEnterUsername.AutoSize = True
        Me.lblEnterUsername.Location = New System.Drawing.Point(242, 106)
        Me.lblEnterUsername.Name = "lblEnterUsername"
        Me.lblEnterUsername.Size = New System.Drawing.Size(105, 13)
        Me.lblEnterUsername.TabIndex = 2
        Me.lblEnterUsername.Text = "Sisesta kasutajanimi:"
        '
        'lblEnterPassword
        '
        Me.lblEnterPassword.AutoSize = True
        Me.lblEnterPassword.Location = New System.Drawing.Point(271, 221)
        Me.lblEnterPassword.Name = "lblEnterPassword"
        Me.lblEnterPassword.Size = New System.Drawing.Size(76, 13)
        Me.lblEnterPassword.TabIndex = 3
        Me.lblEnterPassword.Text = "Sisesta parool:"
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(363, 264)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(103, 36)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Registreeri"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(240, 143)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(107, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Sisesta meili aadress:"
        '
        'tBoxEmail
        '
        Me.tBoxEmail.Location = New System.Drawing.Point(366, 140)
        Me.tBoxEmail.Name = "tBoxEmail"
        Me.tBoxEmail.Size = New System.Drawing.Size(100, 20)
        Me.tBoxEmail.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(197, 182)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(150, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Sisesta ees- ja perekonnanimi:"
        '
        'tBoxName
        '
        Me.tBoxName.Location = New System.Drawing.Point(366, 179)
        Me.tBoxName.Name = "tBoxName"
        Me.tBoxName.Size = New System.Drawing.Size(100, 20)
        Me.tBoxName.TabIndex = 7
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tBoxName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.tBoxEmail)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblEnterPassword)
        Me.Controls.Add(Me.lblEnterUsername)
        Me.Controls.Add(Me.tBoxPassword)
        Me.Controls.Add(Me.tBoxUsername)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tBoxUsername As TextBox
    Friend WithEvents tBoxPassword As TextBox
    Friend WithEvents lblEnterUsername As Label
    Friend WithEvents lblEnterPassword As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents tBoxEmail As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents tBoxName As TextBox
End Class
