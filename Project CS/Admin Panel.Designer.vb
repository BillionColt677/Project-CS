<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Panel
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
        Me.usermanagementbtn = New System.Windows.Forms.Button()
        Me.maintinancebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usermanagementbtn
        '
        Me.usermanagementbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.usermanagementbtn.Location = New System.Drawing.Point(255, 201)
        Me.usermanagementbtn.Name = "usermanagementbtn"
        Me.usermanagementbtn.Size = New System.Drawing.Size(252, 64)
        Me.usermanagementbtn.TabIndex = 0
        Me.usermanagementbtn.Text = "User management"
        Me.usermanagementbtn.UseVisualStyleBackColor = True
        '
        'maintinancebtn
        '
        Me.maintinancebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.maintinancebtn.Location = New System.Drawing.Point(255, 131)
        Me.maintinancebtn.Name = "maintinancebtn"
        Me.maintinancebtn.Size = New System.Drawing.Size(252, 64)
        Me.maintinancebtn.TabIndex = 1
        Me.maintinancebtn.Text = "Maintinance"
        Me.maintinancebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(287, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Admin Panel"
        '
        'logoutbtn
        '
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.logoutbtn.Location = New System.Drawing.Point(255, 271)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(252, 64)
        Me.logoutbtn.TabIndex = 3
        Me.logoutbtn.Text = "Log out"
        Me.logoutbtn.UseVisualStyleBackColor = True
        '
        'Admin_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.logoutbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maintinancebtn)
        Me.Controls.Add(Me.usermanagementbtn)
        Me.Name = "Admin_Panel"
        Me.Text = "Admin_Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usermanagementbtn As Button
    Friend WithEvents maintinancebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents logoutbtn As Button
End Class
