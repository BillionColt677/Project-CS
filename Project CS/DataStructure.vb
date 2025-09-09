Module DataStructure
    Public arrLogins As New List(Of Login) 'stores all the student records from he file

    'student record structure

    Structure Login
        Dim username As String
        Dim password As String
        Dim role As String
    End Structure
End Module
