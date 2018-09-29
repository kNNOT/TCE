Public Class sellTickets
    Private idEvent As Integer
    Private entradasDisponibles As Integer
    Private totalPrice As Integer

    Public Sub New()
        InitializeComponent()
        FillCBEvents()
        CBSlcEvent.SelectedIndex = 0
        CBSlcTEntrada.SelectedIndex = 0
    End Sub

    Sub FillCBEvents()
        iDB.ExSelect("SELECT idEvents, name_events FROM Events", CBSlcEvent)
    End Sub

    Private Sub cbSlcEventSIC(sender As Object, e As EventArgs) Handles CBSlcEvent.SelectedIndexChanged
        If CBSlcEvent.SelectedIndex = 0 Then
            gbClientInfo.Enabled = False
            btnCcrtSell.Enabled = False
            nudTicketsNmbr.Enabled = False
            TBoxAditionalValue.Enabled = False
            CBSlcTEntrada.Enabled = False
            CBSlcTEntrada.SelectedIndex = 0
            TBoxAditionalValue.Text = String.Empty
            TBoxClientAge.Text = String.Empty
            TBoxClientName.Text = String.Empty
            TBoxClientIdentification.Text = String.Empty
            TBoxClientSurname.Text = String.Empty
            nudTicketsNmbr.Value = 1
        Else
            gbClientInfo.Enabled = True
            btnCcrtSell.Enabled = True
            nudTicketsNmbr.Enabled = True
            TBoxAditionalValue.Enabled = True
            CBSlcTEntrada.Enabled = True

            idEvent = returnID(CBSlcEvent.SelectedItem.ToString)
            entradasDisponibles = iDB.ExSelect($"SELECT ticketsopen FROM Events WHERE idEvents={idEvent}")
            nudTicketsNmbr.Maximum = entradasDisponibles
            lblAvailableTickets.Text = $"Entradas disponibles: {entradasDisponibles}"
        End If
    End Sub

    Private Sub addTicket()
        If iDB.Query($"INSERT INTO Tickets(idEvent, CI, countTicketBuy, ticketType, price) VALUES({idEvent}, {TBoxClientIdentification.Text}, 
                     {nudTicketsNmbr.Value}, {CBSlcTEntrada.SelectedItem.ToString}, {totalPrice})") = True Then
            MessageBox.Show("Compra Finalizada", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CBSlcEntradaSIC(sender As Object, e As EventArgs) Handles CBSlcTEntrada.SelectedIndexChanged
        totalPrice = iDB.ExSelect($"SELECT priceEvent FROM Events WHERE idEvents={idEvent}")
        lblShowTotalPrice.Text = $"Total: ${totalPrice}"

        If CBSlcTEntrada.SelectedIndex = 2 Then
            btnCcrtSell.Enabled = True
            Me.Size = New Size(331, 373)
            TBoxAditionalValue.Visible = True
            lblAditionalValue.Visible = True
            layout.Location = New Point(-4, 93)
        Else
            btnCcrtSell.Enabled = True
            Me.Size = New Size(331, 333)
            layout.Location = New Point(-4, 68)
            TBoxAditionalValue.Visible = False
            lblAditionalValue.Visible = False
        End If
    End Sub

    Private Sub nudTicketsNmbrVC(sender As Object, e As EventArgs) Handles nudTicketsNmbr.ValueChanged

    End Sub
End Class