<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reception_Panel
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
        Me.Guestlistbtn = New System.Windows.Forms.Button()
        Me.guestcheckinbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logoutbtn
        '
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.logoutbtn.Location = New System.Drawing.Point(274, 307)
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
        Me.Label1.Location = New System.Drawing.Point(280, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Reception Panel"
        '
        'Guestlistbtn
        '
        Me.Guestlistbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Guestlistbtn.Location = New System.Drawing.Point(274, 167)
        Me.Guestlistbtn.Name = "Guestlistbtn"
        Me.Guestlistbtn.Size = New System.Drawing.Size(252, 64)
        Me.Guestlistbtn.TabIndex = 5
        Me.Guestlistbtn.Text = "Guest list"
        Me.Guestlistbtn.UseVisualStyleBackColor = True
        '
        'guestcheckinbtn
        '
        Me.guestcheckinbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.guestcheckinbtn.Location = New System.Drawing.Point(274, 237)
        Me.guestcheckinbtn.Name = "guestcheckinbtn"
        Me.guestcheckinbtn.Size = New System.Drawing.Size(252, 64)
        Me.guestcheckinbtn.TabIndex = 4
        Me.guestcheckinbtn.Text = "Guest Check in"
        Me.guestcheckinbtn.UseVisualStyleBackColor = True
        '
        'Reception_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.logoutbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guestlistbtn)
        Me.Controls.Add(Me.guestcheckinbtn)
        Me.Name = "Reception_Panel"
        Me.Text = "Reception_Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoutbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guestlistbtn As Button
    Friend WithEvents guestcheckinbtn As Button
End Class
