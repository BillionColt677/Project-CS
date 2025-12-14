<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintinance
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
        Me.backbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resetuserbtn = New System.Windows.Forms.Button()
        Me.resetmoviesbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'backbtn
        '
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.backbtn.Location = New System.Drawing.Point(253, 295)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(252, 64)
        Me.backbtn.TabIndex = 7
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(285, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Maintinance"
        '
        'resetuserbtn
        '
        Me.resetuserbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.resetuserbtn.Location = New System.Drawing.Point(253, 155)
        Me.resetuserbtn.Name = "resetuserbtn"
        Me.resetuserbtn.Size = New System.Drawing.Size(252, 64)
        Me.resetuserbtn.TabIndex = 5
        Me.resetuserbtn.Text = "Reset users"
        Me.resetuserbtn.UseVisualStyleBackColor = True
        '
        'resetmoviesbtn
        '
        Me.resetmoviesbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.resetmoviesbtn.Location = New System.Drawing.Point(253, 225)
        Me.resetmoviesbtn.Name = "resetmoviesbtn"
        Me.resetmoviesbtn.Size = New System.Drawing.Size(252, 64)
        Me.resetmoviesbtn.TabIndex = 4
        Me.resetmoviesbtn.Text = "Reset Movies"
        Me.resetmoviesbtn.UseVisualStyleBackColor = True
        '
        'Maintinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resetuserbtn)
        Me.Controls.Add(Me.resetmoviesbtn)
        Me.Name = "Maintinance"
        Me.Text = "Maintinance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resetuserbtn As Button
    Friend WithEvents resetmoviesbtn As Button
End Class
