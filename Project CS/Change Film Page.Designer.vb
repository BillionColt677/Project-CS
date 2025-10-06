<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Change_Film_Page
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
        Me.Back = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.FilmOutput = New System.Windows.Forms.ListBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.AddFilm = New System.Windows.Forms.Button()
        Me.FilmName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Delete.Location = New System.Drawing.Point(233, 250)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(85, 33)
        Me.Delete.TabIndex = 20
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
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
        'FilmOutput
        '
        Me.FilmOutput.FormattingEnabled = True
        Me.FilmOutput.ItemHeight = 16
        Me.FilmOutput.Location = New System.Drawing.Point(395, 15)
        Me.FilmOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.FilmOutput.Name = "FilmOutput"
        Me.FilmOutput.Size = New System.Drawing.Size(389, 372)
        Me.FilmOutput.TabIndex = 17
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(142, 250)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(85, 33)
        Me.Search.TabIndex = 15
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'AddFilm
        '
        Me.AddFilm.Location = New System.Drawing.Point(51, 250)
        Me.AddFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddFilm.Name = "AddFilm"
        Me.AddFilm.Size = New System.Drawing.Size(85, 33)
        Me.AddFilm.TabIndex = 14
        Me.AddFilm.Text = "Add"
        Me.AddFilm.UseVisualStyleBackColor = True
        '
        'FilmName
        '
        Me.FilmName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FilmName.Location = New System.Drawing.Point(42, 172)
        Me.FilmName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FilmName.Name = "FilmName"
        Me.FilmName.Size = New System.Drawing.Size(297, 30)
        Me.FilmName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User Creation Or Deletion"
        '
        'Change_Film_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.FilmOutput)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.AddFilm)
        Me.Controls.Add(Me.FilmName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Change_Film_Page"
        Me.Text = "Change_Film_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents FilmOutput As ListBox
    Friend WithEvents Search As Button
    Friend WithEvents AddFilm As Button
    Friend WithEvents FilmName As TextBox
    Friend WithEvents Label1 As Label
End Class
