Imports System.Configuration

Public Class LoginCreation
    Private Sub LoginCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        writeLoginData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreateLogin.Click
        Dim tempLogin As New Login

        tempLogin.username = Username.Text
        tempLogin.password = Password.Text
        tempLogin.role = roleBox.SelectedItem.ToString()

        arrLogins.Add(tempLogin)
        writeLoginData()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class