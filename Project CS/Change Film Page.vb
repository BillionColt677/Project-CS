Public Class Change_Film_Page
    Dim indexCurrent As Integer = -1

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        For i = 0 To arrFilms.Count - 1
            If arrFilms(i).film = FilmName.Text Then
                FilmName.Text = arrFilms(i).film
                indexCurrent = i
            End If
        Next
    End Sub

    Private Sub AddFilm_Click(sender As Object, e As EventArgs) Handles AddFilm.Click
        Dim tempFilm As New Film

        tempFilm.film = FilmName.Text

        arrFilms.Add(tempFilm)
        writeFilmData()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        FilmOutput.Items.Clear()
        arrFilms = arrFilms _
        .GroupBy(Function(f) f.film) _
        .Select(Function(g) g.First()) _
        .ToList()
        For i = 0 To arrFilms.Count - 1

            FilmOutput.Items.Add(arrFilms(i).film)

        Next
    End Sub

    Private Sub Change_Film_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readFilmData()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        arrFilms.RemoveAt(indexCurrent)
        writeFilmData()
    End Sub
End Class