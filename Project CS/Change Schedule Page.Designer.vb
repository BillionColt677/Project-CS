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
        Me.roleBox = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.CreateLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(31, 403)
        Me.Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(85, 33)
        Me.Back.TabIndex = 21
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(198, 300)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(85, 33)
        Me.Delete.TabIndex = 20
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(289, 300)
        Me.Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(85, 33)
        Me.Update.TabIndex = 19
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(515, 410)
        Me.Refresh.Margin = New System.Windows.Forms.Padding(4)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(144, 26)
        Me.Refresh.TabIndex = 18
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'LoginOutput1
        '
        Me.LoginOutput1.FormattingEnabled = True
        Me.LoginOutput1.ItemHeight = 16
        Me.LoginOutput1.Location = New System.Drawing.Point(395, 15)
        Me.LoginOutput1.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginOutput1.Name = "LoginOutput1"
        Me.LoginOutput1.Size = New System.Drawing.Size(389, 372)
        Me.LoginOutput1.TabIndex = 17
        '
        'roleBox
        '
        Me.roleBox.DisplayMember = "Admin, User"
        Me.roleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.roleBox.FormattingEnabled = True
        Me.roleBox.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.roleBox.Location = New System.Drawing.Point(43, 246)
        Me.roleBox.Margin = New System.Windows.Forms.Padding(4)
        Me.roleBox.Name = "roleBox"
        Me.roleBox.Size = New System.Drawing.Size(73, 33)
        Me.roleBox.TabIndex = 16
        Me.roleBox.Text = "Admin"
        Me.roleBox.ValueMember = "Admin"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(107, 300)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(85, 33)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'CreateLogin
        '
        Me.CreateLogin.Location = New System.Drawing.Point(16, 300)
        Me.CreateLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateLogin.Name = "CreateLogin"
        Me.CreateLogin.Size = New System.Drawing.Size(85, 33)
        Me.CreateLogin.TabIndex = 14
        Me.CreateLogin.Text = "Create"
        Me.CreateLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(132, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Schedule"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Admin, User"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox1.Location = New System.Drawing.Point(124, 246)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(73, 33)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.Text = "Admin"
        Me.ComboBox1.ValueMember = "Admin"
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "Admin, User"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox2.Location = New System.Drawing.Point(205, 246)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(73, 33)
        Me.ComboBox2.TabIndex = 23
        Me.ComboBox2.Text = "Admin"
        Me.ComboBox2.ValueMember = "Admin"
        '
        'ComboBox3
        '
        Me.ComboBox3.DisplayMember = "Admin, User"
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox3.Location = New System.Drawing.Point(43, 205)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(73, 33)
        Me.ComboBox3.TabIndex = 24
        Me.ComboBox3.Text = "Admin"
        Me.ComboBox3.ValueMember = "Admin"
        '
        'ComboBox4
        '
        Me.ComboBox4.DisplayMember = "Admin, User"
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox4.Location = New System.Drawing.Point(124, 205)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(73, 33)
        Me.ComboBox4.TabIndex = 25
        Me.ComboBox4.Text = "Admin"
        Me.ComboBox4.ValueMember = "Admin"
        '
        'ComboBox5
        '
        Me.ComboBox5.DisplayMember = "Admin, User"
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox5.Location = New System.Drawing.Point(205, 205)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(155, 33)
        Me.ComboBox5.TabIndex = 26
        Me.ComboBox5.Text = "Admin"
        Me.ComboBox5.ValueMember = "Admin"
        '
        'ComboBox6
        '
        Me.ComboBox6.DisplayMember = "Admin, User"
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox6.Location = New System.Drawing.Point(205, 164)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(155, 33)
        Me.ComboBox6.TabIndex = 27
        Me.ComboBox6.Text = "Admin"
        Me.ComboBox6.ValueMember = "Admin"
        '
        'ComboBox7
        '
        Me.ComboBox7.DisplayMember = "Admin, User"
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Admin", "Supervisor", "Recption", "Operator"})
        Me.ComboBox7.Location = New System.Drawing.Point(43, 164)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(154, 33)
        Me.ComboBox7.TabIndex = 28
        Me.ComboBox7.Text = "Admin"
        Me.ComboBox7.ValueMember = "Admin"
        '
        'Change_Schedule_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.LoginOutput1)
        Me.Controls.Add(Me.roleBox)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.CreateLogin)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents roleBox As ComboBox
    Friend WithEvents Search As Button
    Friend WithEvents CreateLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
End Class
