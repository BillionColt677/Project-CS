Imports System.Security.Cryptography.X509Certificates

Public Class Change_Guest_Page
    Public Property entryrole As String
    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click

    End Sub

    Private Sub Change_Guest_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        If entryrole = "Supervisor" Then
            Me.Hide()
            Supervisor_Panel.Show()
        Else
            Me.Hide()
            Reception_Panel.Show()
        End If
    End Sub
End Class