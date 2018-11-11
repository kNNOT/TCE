Public Class reembolso
    Private idEvent As Integer
    Private filter As TCEFilter

    'rellena el combobox de eventos, y deja el index seleccionado en 0
    Public Sub New()
        InitializeComponent()
        iDB.ExSelect("SELECT idEvents, name_events FROM Events", cbSlcEvents)
        ShortViewEvents(cbSlcEvents)
        cbSlcEvents.SelectedIndex = 0
    End Sub

    'si el index seleccionado en el CB no es 0, va a capturar el ID del evento y rellenar el datagridview
    Private Sub SlcEventSIC(sender As Object, e As EventArgs) Handles cbSlcEvents.SelectedIndexChanged
        If cbSlcEvents.SelectedIndex = 0 Then
            dgvSSells.Rows.Clear()
            TBoxCiClient.Enabled = False
        Else
            idEvent = returnID(cbSlcEvents.SelectedItem.ToString)
            FillDGV($"SELECT * FROM Tickets WHERE idEvent={idEvent}", dgvSSells, 6, True)
            filter = New TCEFilter(dgvSSells, 6)
            filter.setArrayData()
            TBoxCiClient.Enabled = True
        End If
    End Sub

    'si le da click a una celda de la ultima columna, 
    Private Sub DeleteTicket(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSSells.CellContentClick
        If e.ColumnIndex = 6 Then

            'segun la cedula de la fila, va a guardar en variables separadas el nombre y apellido del cliente para usarlas en el mensaje de confirmacion
            Dim clientName As String = iDB.ExSelect($"SELECT name FROM Clients WHERE CI={dgvSSells.Item(2, e.RowIndex).Value}")
            Dim surname As String = iDB.ExSelect($"SELECT surname FROM Clients WHERE CI={dgvSSells.Item(2, e.RowIndex).Value}")

            'va a mostrar un mensaje para confirmar la accion borrar
            Dim dlg As DialogResult = MessageBox.Show($"¿Desea eliminar el ticket #{dgvSSells.Item(0, e.RowIndex).Value}?.{vbLf}Cliente: {clientName} {surname}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'si le da a si, procede a borrar de la base de datos
            If dlg = DialogResult.Yes Then
                If iDB.Query($"DELETE FROM Tickets WHERE idTickets={dgvSSells.Item(0, e.RowIndex).Value}") = True Then
                    MessageBox.Show("Se ha reembolsado la entrada", "Reembolso completado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbSlcEvents.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub CIClientTC(sender As Object, e As EventArgs) Handles TBoxCiClient.TextChanged
        If TBoxCiClient.Text = String.Empty Or TBoxCiClient.Text = "Introduzca la cédula del cliente" Then
            FillDGV($"SELECT * FROM Tickets WHERE idEvent={idEvent}", dgvSSells, 6, True)
            lblNoData.Visible = False
            Return
        End If

        filter.FilterColumn = 2
        filter.Filter(TBoxCiClient.Text)

        If dgvSSells.Rows.Count = 0 Then
            lblNoData.Visible = True
        Else
            lblNoData.Visible = False
        End If

        'si la longitud de la cedula es 8 y el index del combobox no es 0, rellena el DGV con los resultados
        ' If TBoxCiClient.Text.Length = 8 And cbSlcEvents.SelectedIndex <> 0 Then
        'FillDGV($"SELECT * FROM Tickets WHERE CI={TBoxCiClient.Text} AND idEvent={idEvent}", dgvSSells, 6, True)
        'si la longitud es menor a 8, y el index del CB no es 0, va a mostrar todos los tickets
        'ElseIf TBoxCiClient.Text.Length < 8 And cbSlcEvents.SelectedIndex <> 0 Then
        'FillDGV($"SELECT * FROM Tickets WHERE idEvent={idEvent}", dgvSSells, 6, True)
        'End If
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