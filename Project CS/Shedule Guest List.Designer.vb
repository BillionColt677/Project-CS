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
        Me.ScheduleOutput = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(325, 465)
        Me.Refresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(144, 26)
        Me.Refresh.TabIndex = 34
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'ScheduleOutput
        '
        Me.ScheduleOutput.FormattingEnabled = True
        Me.ScheduleOutput.ItemHeight = 16
        Me.ScheduleOutput.Location = New System.Drawing.Point(171, 46)
        Me.ScheduleOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleOutput.Name = "ScheduleOutput"
        Me.ScheduleOutput.Size = New System.Drawing.Size(461, 404)
        Me.ScheduleOutput.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(277, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Schedule Guest List"
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(24, 465)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(144, 26)
        Me.backbtn.TabIndex = 35
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'Shedule_Guest_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 506)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.ScheduleOutput)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Shedule_Guest_List"
        Me.Text = "Shedule_Guest_List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Refresh As Button
    Friend WithEvents ScheduleOutput As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backbtn As Button
End Class
