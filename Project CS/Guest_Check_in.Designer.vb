<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest_Check_in
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
        Me.GuestOutput = New System.Windows.Forms.ListBox()
        Me.Minbox = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Guestname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hourbox = New System.Windows.Forms.ComboBox()
        Me.Moviebox = New System.Windows.Forms.ComboBox()
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
        'GuestOutput
        '
        Me.GuestOutput.FormattingEnabled = True
        Me.GuestOutput.ItemHeight = 16
        Me.GuestOutput.Location = New System.Drawing.Point(395, 15)
        Me.GuestOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestOutput.Name = "GuestOutput"
        Me.GuestOutput.Size = New System.Drawing.Size(389, 372)
        Me.GuestOutput.TabIndex = 17
        '
        'Minbox
        '
        Me.Minbox.DisplayMember = "Admin, User"
        Me.Minbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Minbox.FormattingEnabled = True
        Me.Minbox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.Minbox.Location = New System.Drawing.Point(124, 208)
        Me.Minbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Minbox.Name = "Minbox"
        Me.Minbox.Size = New System.Drawing.Size(68, 33)
        Me.Minbox.TabIndex = 16
        Me.Minbox.Text = "Mins"
        Me.Minbox.ValueMember = "Admin"
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
        'Addbtn
        '
        Me.Addbtn.Location = New System.Drawing.Point(16, 300)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(85, 33)
        Me.Addbtn.TabIndex = 14
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'Guestname
        '
        Me.Guestname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Guestname.Location = New System.Drawing.Point(42, 172)
        Me.Guestname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guestname.Name = "Guestname"
        Me.Guestname.Size = New System.Drawing.Size(150, 30)
        Me.Guestname.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(102, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Guest Check in"
        '
        'Hourbox
        '
        Me.Hourbox.DisplayMember = "Admin, User"
        Me.Hourbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Hourbox.FormattingEnabled = True
        Me.Hourbox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.Hourbox.Location = New System.Drawing.Point(43, 208)
        Me.Hourbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Hourbox.Name = "Hourbox"
        Me.Hourbox.Size = New System.Drawing.Size(73, 33)
        Me.Hourbox.TabIndex = 22
        Me.Hourbox.Text = "Hour"
        Me.Hourbox.ValueMember = "Admin"
        '
        'Moviebox
        '
        Me.Moviebox.DisplayMember = "Admin, User"
        Me.Moviebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Moviebox.FormattingEnabled = True
        Me.Moviebox.Items.AddRange(New Object() {"Movie"})
        Me.Moviebox.Location = New System.Drawing.Point(199, 169)
        Me.Moviebox.Margin = New System.Windows.Forms.Padding(4)
        Me.Moviebox.Name = "Moviebox"
        Me.Moviebox.Size = New System.Drawing.Size(175, 33)
        Me.Moviebox.TabIndex = 23
        Me.Moviebox.Text = "Movies"
        Me.Moviebox.ValueMember = "Admin"
        '
        'Guest_Check_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Moviebox)
        Me.Controls.Add(Me.Hourbox)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.GuestOutput)
        Me.Controls.Add(Me.Minbox)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Guestname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Guest_Check_in"
        Me.Text = "Guest_Check_in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents GuestOutput As ListBox
    Friend WithEvents Minbox As ComboBox
    Friend WithEvents Search As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents Guestname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Hourbox As ComboBox
    Friend WithEvents Moviebox As ComboBox
End Class
