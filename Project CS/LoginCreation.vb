Imports System.Configuration

Public Class LoginCreation
    Dim indexCurrent As Integer = -1
    Private Sub LoginCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        writeLoginData()
        readLoginData()
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

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        LoginOutput1.Items.Clear()

        ' Create a list of unique user entries before displaying
        Dim uniqueLogins = arrLogins.
        GroupBy(Function(l) l.username & " " & l.password & " " & l.role).
        Select(Function(g) g.First()).
        ToList()

        ' Loop through only the unique ones
        For i = 0 To uniqueLogins.Count - 1
            LoginOutput1.Items.Add(uniqueLogins(i).username & " " &
                               uniqueLogins(i).password & " " &
                               uniqueLogins(i).role)
        Next
    End Sub


    Private Sub LoginOutput1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LoginOutput1.SelectedIndexChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        For i = 0 To arrLogins.Count - 1
            If arrLogins(i).username = Username.Text Then
                Password.Text = arrLogins(i).password
                roleBox.SelectedItem = arrLogins(i).role

                indexCurrent = i
            End If
        Next
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        arrLogins.RemoveAt(indexCurrent)
        writeLoginData()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim tempLogin As New Login

        tempLogin.username = Username.Text
        tempLogin.password = Password.Text
        tempLogin.role = roleBox.SelectedItem.ToString()

        arrLogins(indexCurrent) = tempLogin
        writeLoginData()
    End Sub
End Class