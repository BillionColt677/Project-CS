<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginCreation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.CreateLogin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.roleBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(182, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Creation Or Deletion"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Username.Location = New System.Drawing.Point(186, 93)
        Me.Username.Margin = New System.Windows.Forms.Padding(2)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(224, 26)
        Me.Username.TabIndex = 1
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Password.Location = New System.Drawing.Point(186, 122)
        Me.Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(224, 26)
        Me.Password.TabIndex = 2
        '
        'CreateLogin
        '
        Me.CreateLogin.Location = New System.Drawing.Point(215, 199)
        Me.CreateLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateLogin.Name = "CreateLogin"
        Me.CreateLogin.Size = New System.Drawing.Size(64, 27)
        Me.CreateLogin.TabIndex = 3
        Me.CreateLogin.Text = "Create"
        Me.CreateLogin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 199)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'roleBox
        '
        Me.roleBox.DisplayMember = "Admin, User"
        Me.roleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.roleBox.FormattingEnabled = True
        Me.roleBox.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.roleBox.Location = New System.Drawing.Point(187, 153)
        Me.roleBox.Name = "roleBox"
        Me.roleBox.Size = New System.Drawing.Size(223, 28)
        Me.roleBox.TabIndex = 5
        Me.roleBox.Text = "Admin"
        Me.roleBox.ValueMember = "Admin"
        '
        'LoginCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.roleBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CreateLogin)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LoginCreation"
        Me.Text = "LoginCreation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents CreateLogin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents roleBox As ComboBox
End Class
