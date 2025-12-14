Imports System.CodeDom.Compiler
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class fLogin
    Public entryrole As String
    Dim indexCurrent As Integer = -1
    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readLoginData()
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        Dim found As Boolean = False

        For i = 0 To arrLogins.Count - 1
            If arrLogins(i).username = UsernameLog.Text Then
                passwordLog.Text = arrLogins(i).password
                entryrole = arrLogins(i).role
                found = True
                indexCurrent = i
                UsernameLog.Clear()
                passwordLog.Clear()
            End If
        Next

        If Not found Then
            MessageBox.Show("Login not found. Please try again.")
        End If

        If found Then
            If entryrole = "Admin" Then
                Me.Hide()
                Admin_Panel.Show()
            ElseIf entryrole = "Supervisor" Then
                Me.Hide()
                Supervisor_Panel.Show()
            ElseIf entryrole = "Reception" Then
                Me.Hide()
                Reception_Panel.Show()
            ElseIf entryrole = "Operator" Then
                Me.Hide()
                Shedule_Guest_List.Show()
            End If
        End If
    End Sub
End Class