Public Class Admin_Panel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles usermanagementbtn.Click
        Me.Hide()
        LoginCreation.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles maintinancebtn.Click
        Me.Hide()
        Maintinance.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        fLogin.Show()
    End Sub
End Class