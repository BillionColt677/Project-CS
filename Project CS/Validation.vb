Module Validation
    Function rangeCheck(input As Integer, min As Integer, max As Integer)
        If input < min And input > max Then
            Return False
        End If
        Return True
    End Function

    Function limitCheck(input As String, limit As Integer)
        If input.Length > limit Then
            Return False
        End If
        Return True
    End Function

    Private Sub txtValidate_Click(sender As Object, e As EventArgs)
        '  If typeCheck(txtInput.Text) = True Then
        'actualTask()
        ' Else
        'MessageBox.Show("Invalid Input")
        'End If
    End Sub
End Module
