Public Class Form1
    Private Sub From1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        readLoginData()
        readFilmData()
        readScheduleData()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        For i = 0 To arrLogins.Count - 1

            LoginOutput.Items.Add(arrLogins(i).username & " " & arrLogins(i).password & " " & arrLogins(i).role)
        Next
    End Sub

    Private Sub Film_Click(sender As Object, e As EventArgs) Handles Film.Click

        For i = 0 To arrFilms.Count - 1

            FilmOutput.Items.Add(arrFilms(i).film)

        Next

    End Sub

    Private Sub Schedule_Click(sender As Object, e As EventArgs) Handles Schedule.Click
        For i = 0 To arrSchedules.Count - 1

            ScheduleOutput.Items.Add(arrSchedules(i).name & " " & arrSchedules(i).time & " " & arrSchedules(i).datte & " " & arrSchedules(i).reception & " " & arrSchedules(i).Operattor)

        Next
    End Sub
End Class