<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Schedule_Page
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
        Me.Back = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.LoginOutput1 = New System.Windows.Forms.ListBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.CreateLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(23, 327)
        Me.Back.Margin = New System.Windows.Forms.Padding(2)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(64, 27)
        Me.Back.TabIndex = 21
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(148, 244)
        Me.Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(64, 27)
        Me.Delete.TabIndex = 20
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(217, 244)
        Me.Update.Margin = New System.Windows.Forms.Padding(2)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(64, 27)
        Me.Update.TabIndex = 19
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(386, 333)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(108, 21)
        Me.Refresh.TabIndex = 18
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'LoginOutput1
        '
        Me.LoginOutput1.FormattingEnabled = True
        Me.LoginOutput1.Location = New System.Drawing.Point(296, 12)
        Me.LoginOutput1.Name = "LoginOutput1"
        Me.LoginOutput1.Size = New System.Drawing.Size(293, 303)
        Me.LoginOutput1.TabIndex = 17
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(80, 244)
        Me.Search.Margin = New System.Windows.Forms.Padding(2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(64, 27)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'CreateLogin
        '
        Me.CreateLogin.Location = New System.Drawing.Point(12, 244)
        Me.CreateLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateLogin.Name = "CreateLogin"
        Me.CreateLogin.Size = New System.Drawing.Size(64, 27)
        Me.CreateLogin.TabIndex = 14
        Me.CreateLogin.Text = "Create"
        Me.CreateLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Guest Add or Delete"
        '
        'ComboBox3
        '
        Me.ComboBox3.DisplayMember = "Admin, User"
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox3.Location = New System.Drawing.Point(26, 166)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(61, 28)
        Me.ComboBox3.TabIndex = 24
        Me.ComboBox3.Text = "Hour"
        Me.ComboBox3.ValueMember = "Admin"
        '
        'ComboBox4
        '
        Me.ComboBox4.DisplayMember = "Admin, User"
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox4.Location = New System.Drawing.Point(93, 166)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(56, 28)
        Me.ComboBox4.TabIndex = 25
        Me.ComboBox4.Text = "Mins"
        Me.ComboBox4.ValueMember = "Admin"
        '
        'ComboBox6
        '
        Me.ComboBox6.DisplayMember = "Admin, User"
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox6.Location = New System.Drawing.Point(154, 133)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(117, 28)
        Me.ComboBox6.TabIndex = 27
        Me.ComboBox6.Text = "Movie"
        Me.ComboBox6.ValueMember = "Admin"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(26, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 26)
        Me.TextBox1.TabIndex = 28
        '
        'Change_Schedule_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.LoginOutput1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.CreateLogin)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Change_Schedule_Page"
        Me.Text = "Change_Schedule_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents LoginOutput1 As ListBox
    Friend WithEvents Search As Button
    Friend WithEvents CreateLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
