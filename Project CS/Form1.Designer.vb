<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LoginOutput = New System.Windows.Forms.ListBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.Film = New System.Windows.Forms.Button()
        Me.FilmOutput = New System.Windows.Forms.ListBox()
        Me.Guest = New System.Windows.Forms.Button()
        Me.GuestOutput = New System.Windows.Forms.ListBox()
        Me.Schedule = New System.Windows.Forms.Button()
        Me.ScheduleOutput = New System.Windows.Forms.ListBox()
        Me.CreateLogin = New System.Windows.Forms.Button()
        Me.ChangeFilm = New System.Windows.Forms.Button()
        Me.ChangeSchedule = New System.Windows.Forms.Button()
        Me.ChangeGuest = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoginOutput
        '
        Me.LoginOutput.FormattingEnabled = True
        Me.LoginOutput.Location = New System.Drawing.Point(9, 10)
        Me.LoginOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LoginOutput.Name = "LoginOutput"
        Me.LoginOutput.Size = New System.Drawing.Size(178, 43)
        Me.LoginOutput.TabIndex = 0
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(190, 10)
        Me.Login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(67, 19)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Film
        '
        Me.Film.Location = New System.Drawing.Point(190, 57)
        Me.Film.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Film.Name = "Film"
        Me.Film.Size = New System.Drawing.Size(67, 19)
        Me.Film.TabIndex = 3
        Me.Film.Text = "Film"
        Me.Film.UseVisualStyleBackColor = True
        '
        'FilmOutput
        '
        Me.FilmOutput.FormattingEnabled = True
        Me.FilmOutput.Location = New System.Drawing.Point(9, 57)
        Me.FilmOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FilmOutput.Name = "FilmOutput"
        Me.FilmOutput.Size = New System.Drawing.Size(178, 43)
        Me.FilmOutput.TabIndex = 2
        '
        'Guest
        '
        Me.Guest.Location = New System.Drawing.Point(190, 151)
        Me.Guest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guest.Name = "Guest"
        Me.Guest.Size = New System.Drawing.Size(67, 19)
        Me.Guest.TabIndex = 7
        Me.Guest.Text = "Guest"
        Me.Guest.UseVisualStyleBackColor = True
        '
        'GuestOutput
        '
        Me.GuestOutput.FormattingEnabled = True
        Me.GuestOutput.Location = New System.Drawing.Point(9, 151)
        Me.GuestOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GuestOutput.Name = "GuestOutput"
        Me.GuestOutput.Size = New System.Drawing.Size(178, 43)
        Me.GuestOutput.TabIndex = 6
        '
        'Schedule
        '
        Me.Schedule.Location = New System.Drawing.Point(190, 104)
        Me.Schedule.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.Size = New System.Drawing.Size(67, 19)
        Me.Schedule.TabIndex = 5
        Me.Schedule.Text = "Schedule"
        Me.Schedule.UseVisualStyleBackColor = True
        '
        'ScheduleOutput
        '
        Me.ScheduleOutput.FormattingEnabled = True
        Me.ScheduleOutput.Location = New System.Drawing.Point(9, 104)
        Me.ScheduleOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ScheduleOutput.Name = "ScheduleOutput"
        Me.ScheduleOutput.Size = New System.Drawing.Size(178, 43)
        Me.ScheduleOutput.TabIndex = 4
        '
        'CreateLogin
        '
        Me.CreateLogin.Location = New System.Drawing.Point(262, 10)
        Me.CreateLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CreateLogin.Name = "CreateLogin"
        Me.CreateLogin.Size = New System.Drawing.Size(126, 19)
        Me.CreateLogin.TabIndex = 8
        Me.CreateLogin.Text = "CreateLogin"
        Me.CreateLogin.UseVisualStyleBackColor = True
        '
        'ChangeFilm
        '
        Me.ChangeFilm.Location = New System.Drawing.Point(262, 57)
        Me.ChangeFilm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChangeFilm.Name = "ChangeFilm"
        Me.ChangeFilm.Size = New System.Drawing.Size(126, 19)
        Me.ChangeFilm.TabIndex = 9
        Me.ChangeFilm.Text = "ChangeFilm"
        Me.ChangeFilm.UseVisualStyleBackColor = True
        '
        'ChangeSchedule
        '
        Me.ChangeSchedule.Location = New System.Drawing.Point(262, 104)
        Me.ChangeSchedule.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChangeSchedule.Name = "ChangeSchedule"
        Me.ChangeSchedule.Size = New System.Drawing.Size(126, 19)
        Me.ChangeSchedule.TabIndex = 10
        Me.ChangeSchedule.Text = "ChangeSchedule"
        Me.ChangeSchedule.UseVisualStyleBackColor = True
        '
        'ChangeGuest
        '
        Me.ChangeGuest.Location = New System.Drawing.Point(262, 151)
        Me.ChangeGuest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChangeGuest.Name = "ChangeGuest"
        Me.ChangeGuest.Size = New System.Drawing.Size(126, 19)
        Me.ChangeGuest.TabIndex = 11
        Me.ChangeGuest.Text = "ChangeGuest"
        Me.ChangeGuest.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChangeGuest)
        Me.Controls.Add(Me.ChangeSchedule)
        Me.Controls.Add(Me.ChangeFilm)
        Me.Controls.Add(Me.CreateLogin)
        Me.Controls.Add(Me.Guest)
        Me.Controls.Add(Me.GuestOutput)
        Me.Controls.Add(Me.Schedule)
        Me.Controls.Add(Me.ScheduleOutput)
        Me.Controls.Add(Me.Film)
        Me.Controls.Add(Me.FilmOutput)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.LoginOutput)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginOutput As ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents Film As Button
    Friend WithEvents FilmOutput As ListBox
    Friend WithEvents Guest As Button
    Friend WithEvents GuestOutput As ListBox
    Friend WithEvents Schedule As Button
    Friend WithEvents ScheduleOutput As ListBox
    Friend WithEvents CreateLogin As Button
    Friend WithEvents ChangeFilm As Button
    Friend WithEvents ChangeSchedule As Button
    Friend WithEvents ChangeGuest As Button
    Friend WithEvents Button1 As Button
End Class
