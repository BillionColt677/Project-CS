Module DataStructure
    Public arrLogins As New List(Of Login) 'stores all the login records from he file
    'Login record structure
    Structure Login
        Dim username As String
        Dim password As String
        Dim role As String
    End Structure

    Public arrFilms As New List(Of Film) 'stores all the film records from he file
    'Film record structure
    Structure Film
        Dim film As String
    End Structure

    Public arrSchedules As New List(Of Schedule) 'stores all the film records from he file
    'Film record structure
    Structure Schedule
        Dim film As String
        Dim time As String
        Dim datte As String
        Dim reception As String
        Dim Operattor As String
    End Structure

    Public arrGuests As New List(Of Guest) 'stores all the film records from he file
    'Film record structure
    Structure Guest
        Dim name As String
        Dim time As String
        Dim film As String
    End Structure
End Module
