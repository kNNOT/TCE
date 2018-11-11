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
    Public Sub FillDGV(qry As String, dgv As DataGridView, columnsCount As Integer, fresh As Boolean)
        iDB.ExSelect(qry, dgv, columnsCount, fresh)
    End Sub

    Sub ShortViewEvents(cb As ComboBox)
        Dim id As Integer
        Dim datei As Date
        Dim listEvents As List(Of String) = New List(Of String)

        For y = 1 To cb.Items.Count - 1
            listEvents.Add(cb.Items.Item(y).ToString)
        Next

        cb.Items.Clear()
        cb.Items.Add("---Seleccione un Evento---")
        For Each idnevent As String In listEvents
            id = returnID(idnevent)
            datei = Convert.ToDateTime(iDB.ExSelect($"SELECT datei FROM Events WHERE idEvents={id}"))

            If datei > Date.Now.ToString("dd/MM/yyyy") Then
                cb.Items.Add(idnevent)
            End If
        Next
    End Sub
End Module
