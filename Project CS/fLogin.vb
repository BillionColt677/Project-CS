Imports System.CodeDom.Compiler
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class fLogin

    Dim indexCurrent As Integer = -1
    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readLoginData()
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        Dim found As Boolean = False

        For i = 0 To arrLogins.Count - 1
            If arrLogins(i).username = UsernameLog.Text Then
                found = True
                passwordLog.Text = arrLogins(i).password
                indexCurrent = i
                Form1.Show()
                Me.Hide()
            End If
        Next

        If Not found Then
            MessageBox.Show("Login not found. Please try again.")
        End If
    End Sub
End Class