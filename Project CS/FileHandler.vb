Module FileHandler
    Sub readLoginData()

        FileOpen(1, "Login.txt", OpenMode.Input)

        While Not EOF(1)

            'creates temp structure
            Dim tempLogin As New Login

            'reads each comma seperated block
            Input(1, tempLogin.username)
            Input(1, tempLogin.password)
            Input(1, tempLogin.role)

            'adds the temp structure to the list
            arrLogins.Add(tempLogin)
        End While
        FileClose(1) ' closes the file
    End Sub

    'writes data to the file
    Sub writeLoginData()
        FileOpen(1, "Login.txt", OpenMode.Output)

        'loops through all records in the student list
        For Each tempLogin In arrLogins
            'writes each record to a line in the file
            WriteLine(1, tempLogin.username, tempLogin.password, tempLogin.role)
        Next

        FileClose(1) 'saves to file
    End Sub

    Sub readFilmData()

        FileOpen(1, "Film.txt", OpenMode.Input)

        While Not EOF(1)

            'creates temp structure
            Dim tempFilm As New Film

            'reads each comma seperated block
            Input(1, tempFilm.film)

            'adds the temp structure to the list
            arrFilms.Add(tempFilm)
        End While
        FileClose(1) ' closes the file
    End Sub

    Sub writeFilmData()
        FileOpen(1, "Film.txt", OpenMode.Output)

        'loops through all records in the student list
        For Each tempFilm In arrFilms
            'writes each record to a line in the file
            WriteLine(1, tempFilm.film)
        Next

        FileClose(1) 'saves to file
    End Sub

    Sub readScheduleData()

        FileOpen(1, "schedule.txt", OpenMode.Input)

        While Not EOF(1)

            'creates temp structure
            Dim tempSchedule As New Schedule

            'reads each comma seperated block
            Input(1, tempSchedule.name)
            Input(1, tempSchedule.time)
            Input(1, tempSchedule.datte)
            Input(1, tempSchedule.reception)
            Input(1, tempSchedule.Operattor)

            'adds the temp structure to the list
            arrSchedules.Add(tempSchedule)
        End While
        FileClose(1) ' closes the file
    End Sub

    Sub writeScheduleData()
        FileOpen(1, "Schedule.txt", OpenMode.Output)

        'loops through all records in the student list
        For Each tempSchedule In arrSchedules
            'writes each record to a line in the file
            WriteLine(1, tempSchedule.name)
            WriteLine(1, tempSchedule.time)
            WriteLine(1, tempSchedule.datte)
            WriteLine(1, tempSchedule.reception)
            WriteLine(1, tempSchedule.Operattor)
        Next

        FileClose(1) 'saves to file
    End Sub

End Module
