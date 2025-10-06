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
        Me.Search = New System.Windows.Forms.Button()
        Me.roleBox = New System.Windows.Forms.ComboBox()
        Me.LoginOutput1 = New System.Windows.Forms.ListBox()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Creation Or Deletion"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Username.Location = New System.Drawing.Point(40, 172)
        Me.Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(297, 30)
        Me.Username.TabIndex = 1
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Password.Location = New System.Drawing.Point(40, 208)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(297, 30)
        Me.Password.TabIndex = 2
        '
        'CreateLogin
        '
        Me.CreateLogin.Location = New System.Drawing.Point(14, 300)
        Me.CreateLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateLogin.Name = "CreateLogin"
        Me.CreateLogin.Size = New System.Drawing.Size(85, 33)
        Me.CreateLogin.TabIndex = 3
        Me.CreateLogin.Text = "Create"
        Me.CreateLogin.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(105, 300)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(85, 33)
        Me.Search.TabIndex = 4
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'roleBox
        '
        Me.roleBox.DisplayMember = "Admin, User"
        Me.roleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.roleBox.FormattingEnabled = True
        Me.roleBox.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.roleBox.Location = New System.Drawing.Point(41, 246)
        Me.roleBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.roleBox.Name = "roleBox"
        Me.roleBox.Size = New System.Drawing.Size(296, 33)
        Me.roleBox.TabIndex = 5
        Me.roleBox.Text = "Admin"
        Me.roleBox.ValueMember = "Admin"
        '
        'LoginOutput1
        '
        Me.LoginOutput1.FormattingEnabled = True
        Me.LoginOutput1.ItemHeight = 16
        Me.LoginOutput1.Location = New System.Drawing.Point(393, 15)
        Me.LoginOutput1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoginOutput1.Name = "LoginOutput1"
        Me.LoginOutput1.Size = New System.Drawing.Size(389, 372)
        Me.LoginOutput1.TabIndex = 6
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(513, 410)
        Me.Refresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(144, 26)
        Me.Refresh.TabIndex = 7
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(287, 300)
        Me.Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(85, 33)
        Me.Update.TabIndex = 8
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(196, 300)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(85, 33)
        Me.Delete.TabIndex = 9
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(29, 403)
        Me.Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(85, 33)
        Me.Back.TabIndex = 10
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'LoginCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.LoginOutput1)
        Me.Controls.Add(Me.roleBox)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.CreateLogin)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LoginCreation"
        Me.Text = "LoginCreation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents CreateLogin As Button
    Friend WithEvents Search As Button
    Friend WithEvents roleBox As ComboBox
    Friend WithEvents LoginOutput1 As ListBox
    Friend WithEvents Refresh As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Back As Button
End Class
