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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Schedule = New System.Windows.Forms.Button()
        Me.ScheduleOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LoginOutput
        '
        Me.LoginOutput.FormattingEnabled = True
        Me.LoginOutput.ItemHeight = 16
        Me.LoginOutput.Location = New System.Drawing.Point(12, 12)
        Me.LoginOutput.Name = "LoginOutput"
        Me.LoginOutput.Size = New System.Drawing.Size(236, 52)
        Me.LoginOutput.TabIndex = 0
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(254, 12)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 23)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Film
        '
        Me.Film.Location = New System.Drawing.Point(254, 70)
        Me.Film.Name = "Film"
        Me.Film.Size = New System.Drawing.Size(75, 23)
        Me.Film.TabIndex = 3
        Me.Film.Text = "Film"
        Me.Film.UseVisualStyleBackColor = True
        '
        'FilmOutput
        '
        Me.FilmOutput.FormattingEnabled = True
        Me.FilmOutput.ItemHeight = 16
        Me.FilmOutput.Location = New System.Drawing.Point(12, 70)
        Me.FilmOutput.Name = "FilmOutput"
        Me.FilmOutput.Size = New System.Drawing.Size(236, 52)
        Me.FilmOutput.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 186)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(236, 52)
        Me.ListBox1.TabIndex = 6
        '
        'Schedule
        '
        Me.Schedule.Location = New System.Drawing.Point(254, 128)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.Size = New System.Drawing.Size(75, 23)
        Me.Schedule.TabIndex = 5
        Me.Schedule.Text = "Schedule"
        Me.Schedule.UseVisualStyleBackColor = True
        '
        'ScheduleOutput
        '
        Me.ScheduleOutput.FormattingEnabled = True
        Me.ScheduleOutput.ItemHeight = 16
        Me.ScheduleOutput.Location = New System.Drawing.Point(12, 128)
        Me.ScheduleOutput.Name = "ScheduleOutput"
        Me.ScheduleOutput.Size = New System.Drawing.Size(236, 52)
        Me.ScheduleOutput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Schedule)
        Me.Controls.Add(Me.ScheduleOutput)
        Me.Controls.Add(Me.Film)
        Me.Controls.Add(Me.FilmOutput)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.LoginOutput)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Schedule As Button
    Friend WithEvents ScheduleOutput As ListBox
End Class
