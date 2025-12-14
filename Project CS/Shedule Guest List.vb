Public Class Shedule_Guest_List
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        ScheduleOutput.Items.Clear()

        ' Create a list of unique user entries before displaying
        Dim uniqueSchedule = arrSchedules.
        GroupBy(Function(l) l.film & " " & l.time & " " & l.datte & " " & l.reception & " " & l.Operattor).
        Select(Function(g) g.First()).
        ToList()

        ' Loop through only the unique ones
        For i = 0 To uniqueSchedule.Count - 1
            ScheduleOutput.Items.Add(uniqueSchedule(i).film & " " &
                               uniqueSchedule(i).time & " " &
                               uniqueSchedule(i).datte & " " &
                               uniqueSchedule(i).reception & " " &
                               uniqueSchedule(i).Operattor)
        Next
    End Sub
End Class