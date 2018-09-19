Public Class DeleteGroups
    Public Sub New()
        InitializeComponent()
        refreshData()
    End Sub

    Private Sub refreshData()
        iDB.returnData("SELECT * FROM Groups", dgvShowGroups, 5)
    End Sub

    Private Sub deleteGroupClic(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowGroups.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim dlg As DialogResult = MessageBox.Show($"¿Desea eliminar el grupo #{dgvShowGroups.Item(0, e.RowIndex).Value.ToString}. {dgvShowGroups.Item(1, e.RowIndex).Value.ToString}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlg = DialogResult.Yes Then
                If iDB.Query($"DELETE FROM Groups WHERE idGroups={dgvShowGroups.Item(0, e.RowIndex).Value.ToString}") = True And
                    iDB.Query($"DELETE FROM Participants WHERE idGroups={dgvShowGroups.Item(0, e.RowIndex).Value.ToString}") = True Then
                    MessageBox.Show("Se ha eliminado el grupo!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    refreshData()
                End If
            End If
        End If
    End Sub
End Class