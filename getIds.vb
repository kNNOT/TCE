Module getIds
    Public Function returnID(ByVal t As String) As Integer
        Dim id As Integer
        For i = 0 To t.Length
            If t.Chars(i) = "." Then
                id = CType()
            End If
        Next
    End Function
End Module
