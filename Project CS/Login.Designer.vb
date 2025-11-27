<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameLog = New System.Windows.Forms.TextBox()
        Me.passwordLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Refresh
        '
        Me.Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Refresh.Location = New System.Drawing.Point(248, 316)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(146, 42)
        Me.Refresh.TabIndex = 34
        Me.Refresh.Text = "LOG IN"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(283, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Login"
        '
        'UsernameLog
        '
        Me.UsernameLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.UsernameLog.Location = New System.Drawing.Point(213, 141)
        Me.UsernameLog.Name = "UsernameLog"
        Me.UsernameLog.Size = New System.Drawing.Size(217, 30)
        Me.UsernameLog.TabIndex = 35
        '
        'passwordLog
        '
        Me.passwordLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.passwordLog.Location = New System.Drawing.Point(213, 176)
        Me.passwordLog.Name = "passwordLog"
        Me.passwordLog.Size = New System.Drawing.Size(217, 30)
        Me.passwordLog.TabIndex = 36
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 370)
        Me.Controls.Add(Me.passwordLog)
        Me.Controls.Add(Me.UsernameLog)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Refresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameLog As TextBox
    Friend WithEvents passwordLog As TextBox
End Class
