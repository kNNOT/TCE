Public Class StartMenu
    Public Sub New()
        InitializeComponent()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
    End Sub

    'estos metodos llaman a las ventanas, con un valor en los parametros del constructor de las clases que los requieran: addorEditEvent y addorEditGroup
    Private Sub btnAddEventClic(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addEvent As addorEditEvent = New addorEditEvent(False) 'se puso el parametro en falso por que no es para editar
        addEvent.ShowDialog()
    End Sub

    Private Sub btnEditEventsClic(sender As Object, e As EventArgs) Handles btnEditEvents.Click
        Dim editEvent As addorEditEvent = New addorEditEvent(True)
        editEvent.ShowDialog()
    End Sub

    Private Sub btnDeleteGroupClic(sender As Object, e As EventArgs) Handles btnDeleteGroup.Click
        Dim deleteGroup As DeleteGroups = New DeleteGroups
        deleteGroup.ShowDialog()
    End Sub

    Private Sub btnGroupClic(sender As Object, e As EventArgs) Handles btnNewGroup.Click
        Dim addGroup As addorEditGroup = New addorEditGroup(False)
        addGroup.ShowDialog()
    End Sub

    Private Sub btnEditClic(sender As Object, e As EventArgs) Handles btnEditGroups.Click
        Dim editGroup As addorEditGroup = New addorEditGroup(True)
        editGroup.ShowDialog()
    End Sub

    Private Sub DeleteEventClic(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowEvents.CellContentClick
        If e.ColumnIndex = 8 Then 'Solo si le damos clic a la papelera, se borrará el evento.
            Dim dlg As DialogResult = MessageBox.Show($"¿Desea borrar el evento #{dgvShowEvents.Item(0, e.RowIndex).Value.ToString}. {dgvShowEvents.Item(1, e.RowIndex).Value.ToString}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlg = DialogResult.Yes Then 'Si le da clic al boton Si, se borra el evento
                If iDB.Query($"DELETE FROM Events WHERE idEvents={dgvShowEvents.Item(0, e.RowIndex).Value.ToString};
                                        DELETE FROM Participants WHERE idEvents={dgvShowEvents.Item(0, e.RowIndex).Value.ToString};") = True Then
                    MessageBox.Show("Se ha eliminado el evento!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
                End If
            End If
        End If
    End Sub

    Private Sub btnReembolsoClic(sender As Object, e As EventArgs) Handles btnReembolso.Click
        Dim r As reembolso = New reembolso
        r.ShowDialog()
    End Sub

    Private Sub btnSellTicketsClic(sender As Object, e As EventArgs) Handles btnSellTickets.Click
        Dim sellTickets As sellTickets = New sellTickets()
        sellTickets.ShowDialog()
    End Sub
End Class