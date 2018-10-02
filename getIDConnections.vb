Module getIDConnections
    Public iDB As DBConnection = New DBConnection 'Variable GLOBAL para el proyecto que contiene métodos para usar la Base de Datos.

    'Método que retorna el ID (llave primaria) de una base de datos.
    Public Function returnID(ByVal t As String) As Integer
        Dim id As Integer
        For i = 0 To t.Length - 1 'Recorre todos los caracteres del parametro t.
            If t.Chars(i) = "." Then
                id = CType(t.Substring(0, i), Integer) 'Le asigna a la variable ID, el numero recorrido.
                Exit For
            End If
        Next
        Return id 'Retorna el ID que se le ha asignado.
    End Function

    'Se puede llamar en todo el proyecto, cuando se necesite hacer un refresh de los datos del datagridview.
    Public Sub FillDGV(qry As String, dgv As DataGridView, columnsCount As Integer)
        iDB.returnData(qry, dgv, columnsCount)
    End Sub
End Module
