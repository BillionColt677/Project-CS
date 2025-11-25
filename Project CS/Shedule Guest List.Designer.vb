<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shedule_Guest_List
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
        Me.Refresh = New System.Windows.Forms.Button()
        Me.LoginOutput1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(244, 378)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(108, 21)
        Me.Refresh.TabIndex = 34
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'LoginOutput1
        '
        Me.LoginOutput1.FormattingEnabled = True
        Me.LoginOutput1.Location = New System.Drawing.Point(128, 37)
        Me.LoginOutput1.Name = "LoginOutput1"
        Me.LoginOutput1.Size = New System.Drawing.Size(347, 329)
        Me.LoginOutput1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(208, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Schedule Guest List"
        '
        'Shedule_Guest_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 411)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.LoginOutput1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Shedule_Guest_List"
        Me.Text = "Shedule_Guest_List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Refresh As Button
    Friend WithEvents LoginOutput1 As ListBox
    Friend WithEvents Label1 As Label
End Class
