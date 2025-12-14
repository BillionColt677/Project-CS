Public Class Reception_Panel
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        fLogin.Show()
    End Sub

    Private Sub maintinancebtn_Click(sender As Object, e As EventArgs) Handles maintinancebtn.Click
        Me.Hide()
        Change_Guest_Page.Show()
    End Sub

    Private Sub usermanagementbtn_Click(sender As Object, e As EventArgs) Handles usermanagementbtn.Click
        Me.Hide()
        Shedule_Guest_List.Show()
    End Sub
End Class