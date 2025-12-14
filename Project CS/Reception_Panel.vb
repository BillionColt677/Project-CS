Public Class Reception_Panel
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        fLogin.Show()
    End Sub

    Private Sub maintinancebtn_Click(sender As Object, e As EventArgs) Handles Guestlistbtn.Click
        Me.Hide()
        Change_Guest_Page.Show()
    End Sub

    Private Sub usermanagementbtn_Click(sender As Object, e As EventArgs) Handles guestcheckinbtn.Click
        Me.Hide()
        Guest_Check_in.Show()
    End Sub
End Class