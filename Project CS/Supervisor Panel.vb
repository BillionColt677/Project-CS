Public Class Supervisor_Panel
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Changemediabtn_Click(sender As Object, e As EventArgs) Handles Changemediabtn.Click
        Me.Hide()
        Change_Film_Page.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        fLogin.Show()
    End Sub

    Private Sub manageschedulebtn_Click(sender As Object, e As EventArgs) Handles manageschedulebtn.Click
        Change_Guest_Page.Show()
    End Sub
End Class