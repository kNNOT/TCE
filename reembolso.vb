Public Class reembolso
    Private idEvent As Integer

    Public Sub New()
        InitializeComponent()
        iDB.returnData("SELECT idEvents, name_events FROM Events", cbSlcEvents)
        cbSlcEvents.SelectedIndex = 0
    End Sub

    Private Sub SlcEventSIC(sender As Object, e As EventArgs) Handles cbSlcEvents.SelectedIndexChanged
        If cbSlcEvents.SelectedIndex = 0 Then
            dgvSSells.Rows.Clear()
        Else
            idEvent = returnID(cbSlcEvents.SelectedItem.ToString)
            refreshData($"SELECT * FROM Tickets WHERE idEvent={idEvent}", dgvSSells, 6)
        End If
    End Sub

    Private Sub DeleteTicket(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSSells.CellContentClick
        If e.ColumnIndex = 6 Then
            Dim clientName As String = iDB.returnData($"SELECT name FROM Clients WHERE CI={dgvSSells.Item(2, e.RowIndex).Value}")
            Dim surname As String = iDB.returnData($"SELECT surname FROM Clients WHERE CI={dgvSSells.Item(2, e.RowIndex).Value}")
            Dim dlg As DialogResult = MessageBox.Show($"¿Desea eliminar el ticket #{dgvSSells.Item(0, e.RowIndex).Value}?.{vbLf}Cliente: {clientName} {surname}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlg = DialogResult.Yes Then
                If iDB.Query($"DELETE FROM Tickets WHERE idTickets={dgvSSells.Item(0, e.RowIndex).Value}") = True Then
                    MessageBox.Show("Se ha reembolsado la entrada", "Reembolso completado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbSlcEvents.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub CIClientTC(sender As Object, e As EventArgs) Handles TBoxCiClient.TextChanged
        If TBoxCiClient.Text.Length = 8 And cbSlcEvents.SelectedIndex <> 0 Then
            refreshData($"SELECT * FROM Tickets WHERE CI={TBoxCiClient.Text} AND idEvent={idEvent}", dgvSSells, 6)
        ElseIf TBoxCiClient.Text.Length < 8 And cbSlcEvents.SelectedIndex <> 0 Then
            refreshData($"SELECT * FROM Tickets WHERE idEvent={idEvent}", dgvSSells, 6)
        End If
    End Sub

    Private Sub TBoxCIClientClic(sender As Object, e As EventArgs) Handles TBoxCiClient.Click
        If TBoxCiClient.Text = "Introduzca la cédula del cliente" Then
            TBoxCiClient.Text = String.Empty
        End If
    End Sub

    Private Sub CiClientLeave(sender As Object, e As EventArgs) Handles TBoxCiClient.Leave
        If TBoxCiClient.Text = String.Empty Then
            TBoxCiClient.Text = "Introduzca la cédula del cliente"
        End If
    End Sub
End Class