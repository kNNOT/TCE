Public Class StartMenu
    Public Sub New()
        InitializeComponent()
        refreshData()
    End Sub

    Private Sub refreshData()
        iDB.returnData("SELECT * FROM Events", dgvShowEvents, 10)
    End Sub

    Private Sub btnAddEventClic(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addEvent As addorEditEvent = New addorEditEvent(False)
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
                    refreshData()
                End If
            End If
        End If
    End Sub
End Class