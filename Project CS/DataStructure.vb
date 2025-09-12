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
End Module
