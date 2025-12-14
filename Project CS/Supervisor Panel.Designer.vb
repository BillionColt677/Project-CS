<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supervisor_Panel
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
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Changemediabtn = New System.Windows.Forms.Button()
        Me.manageschedulebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logoutbtn
        '
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.logoutbtn.Location = New System.Drawing.Point(271, 304)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(252, 64)
        Me.logoutbtn.TabIndex = 7
        Me.logoutbtn.Text = "Log out"
        Me.logoutbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(279, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Supervisor Panel"
        '
        'Changemediabtn
        '
        Me.Changemediabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Changemediabtn.Location = New System.Drawing.Point(271, 164)
        Me.Changemediabtn.Name = "Changemediabtn"
        Me.Changemediabtn.Size = New System.Drawing.Size(252, 64)
        Me.Changemediabtn.TabIndex = 5
        Me.Changemediabtn.Text = "Change Media"
        Me.Changemediabtn.UseVisualStyleBackColor = True
        '
        'manageschedulebtn
        '
        Me.manageschedulebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.manageschedulebtn.Location = New System.Drawing.Point(271, 234)
        Me.manageschedulebtn.Name = "manageschedulebtn"
        Me.manageschedulebtn.Size = New System.Drawing.Size(252, 64)
        Me.manageschedulebtn.TabIndex = 4
        Me.manageschedulebtn.Text = "Manage Schedule"
        Me.manageschedulebtn.UseVisualStyleBackColor = True
        '
        'Supervisor_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.logoutbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Changemediabtn)
        Me.Controls.Add(Me.manageschedulebtn)
        Me.Name = "Supervisor_Panel"
        Me.Text = "Supervisor_Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoutbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Changemediabtn As Button
    Friend WithEvents manageschedulebtn As Button
End Class
