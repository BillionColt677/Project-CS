Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Guest_Check_in
    Dim indexCurrent As Integer = -1
    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        GuestOutput.Items.Clear()

        ' Create a list of unique user entries before displaying
        Dim uniqueGuest = arrGuests.
        GroupBy(Function(l) l.name & " " & l.time & " " & l.film).
        Select(Function(g) g.First()).
        ToList()

        ' Loop through only the unique ones
        For i = 0 To uniqueGuest.Count - 1
            GuestOutput.Items.Add(uniqueGuest(i).name & " " &
                               uniqueGuest(i).time & " " &
                               uniqueGuest(i).film)
        Next
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim tempGuest As New Guest

        tempGuest.name = Guestname.Text
        tempGuest.time = Hourbox.SelectedItem.ToString() & ":" & Minbox.SelectedItem.ToString()
        tempGuest.film = Moviebox.SelectedItem.ToString()

        arrGuests.Add(tempGuest)
        writeGuestData()
    End Sub

    Private Sub Guest_Check_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readGuestData()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Reception_Panel.Show()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        For i = 0 To arrLogins.Count - 1
            If arrGuests(i).name = Guestname.Text Then
                Guestname.Text = arrGuests(i).name
                Moviebox.SelectedItem = arrGuests(i).film

                Dim parts() As String = arrGuests(i).time.Split(":"c)
                Hourbox.SelectedItem = parts(0)
                Minbox.SelectedItem = parts(1)
            Else
                MessageBox.Show("Guest not found. Please try again.")
            End If
        Next
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        arrLogins.RemoveAt(indexCurrent)
        writeLoginData()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim tempGuest As New Guest

        tempGuest.name = Guestname.Text
        tempGuest.time = Hourbox.SelectedItem.ToString() & ":" & Minbox.SelectedItem.ToString()
        tempGuest.film = Moviebox.SelectedItem.ToString()

        arrGuests(indexCurrent) = tempGuest
        writeGuestData()
    End Sub

    Private Sub Moviebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Moviebox.SelectedIndexChanged
        Moviebox.Items.Clear()

        readFilmData()

        For i = 0 To arrFilms.Count - 1
            Moviebox.Items.Add(arrFilms(i))
        Next
    End Sub
    Private Sub Moviebox_DropDown(sender As Object, e As EventArgs) Handles Moviebox.DropDown
        readFilmData()

        For i = 0 To arrFilms.Count - 1
            If Not Moviebox.Items.Contains(arrFilms(i).film) Then
                Moviebox.Items.Add(arrFilms(i).film)
            End If
        Next
    End Sub



End Class