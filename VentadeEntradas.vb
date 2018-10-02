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
        iDB.returnData("SELECT idEvents, name_events FROM Events", CBSlcEvent)
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
            lblShowTotalPrice.Text = "Total: "
        Else
            gbClientInfo.Enabled = True
            btnCcrtSell.Enabled = True
            TBoxAditionalValue.Enabled = True
            CBSlcTEntrada.Enabled = True

            idEvent = returnID(CBSlcEvent.SelectedItem.ToString)
            entradasDisponibles = iDB.returnData($"SELECT ticketsopen FROM Events WHERE idEvents={idEvent}")
            nudTicketsNmbr.Maximum = entradasDisponibles
            Dim cprice As Integer = iDB.returnData($"SELECT priceEvent FROM Events WHERE idEvents={idEvent}")
            lblShowTotalPrice.Text = $"Total: ${cprice}"
            lblAvailableTickets.Text = $"Entradas disponibles: {entradasDisponibles - nudTicketsNmbr.Value}"
        End If
    End Sub

    Private Sub addTicket()
        If iDB.Query($"INSERT INTO Clients(CI, name, surname, age) VALUES({TBoxClientIdentification.Text},'{TBoxClientName.Text}','{TBoxClientSurname.Text}',
            {TBoxClientAge.Text})") = True Or iDB.Query($"INSERT INTO Tickets(idEvent, CI, countTicketBuy, ticketType, price) VALUES({idEvent},{TBoxClientIdentification.Text},
                    {nudTicketsNmbr.Value},'{CBSlcTEntrada.SelectedItem.ToString}',{totalPrice});") = True Then
            iDB.Query($"UPDATE Events SET ticketsopen=ticketsopen - {nudTicketsNmbr.Value} WHERE idEvents={idEvent}")
            MessageBox.Show("Compra Finalizada", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CBSlcEntradaSIC(sender As Object, e As EventArgs) Handles CBSlcTEntrada.SelectedIndexChanged
        totalPrice = iDB.returnData($"SELECT priceEvent FROM Events WHERE idEvents={idEvent}")
        lblShowTotalPrice.Text = $"Total: ${totalPrice}"

        If CBSlcTEntrada.SelectedIndex = 2 Then
            btnCcrtSell.Enabled = True
            Me.Size = New Size(331, 373)
            TBoxAditionalValue.Visible = True
            lblAditionalValue.Visible = True
            layout.Location = New Point(-4, 93)
            nudTicketsNmbr.Enabled = False
        ElseIf CBSlcTEntrada.SelectedIndex = 1 Then
            btnCcrtSell.Enabled = True
            Me.Size = New Size(331, 333)
            layout.Location = New Point(-4, 68)
            TBoxAditionalValue.Visible = False
            lblAditionalValue.Visible = False
            nudTicketsNmbr.Enabled = True
        Else
            nudTicketsNmbr.Enabled = False
        End If
    End Sub

    Private Sub nudTicketsNmbrVC(sender As Object, e As EventArgs) Handles nudTicketsNmbr.ValueChanged
        Dim price As Integer = totalPrice
        If CBSlcTEntrada.SelectedIndex <> 2 Then
            price = totalPrice * nudTicketsNmbr.Value
        Else
            price = (totalPrice + CType(TBoxAditionalValue.Text, Integer)) * nudTicketsNmbr.Value
        End If
        lblAvailableTickets.Text = $"Entradas disponibles: {entradasDisponibles - nudTicketsNmbr.Value}"
        lblShowTotalPrice.Text = $"Total: ${price}"

        If lblAvailableTickets.Text = "Entradas disponibles: -1" Then
            lblAvailableTickets.Text = "Entradas disponibles: "
        End If
    End Sub

    Private Sub TBoxAdditionalValueTC(sender As Object, e As EventArgs) Handles TBoxAditionalValue.TextChanged
        If TBoxAditionalValue.Text = String.Empty Then
            lblShowTotalPrice.Text = $"Total: ${totalPrice}"
            nudTicketsNmbr.Enabled = False
        Else
            nudTicketsNmbr.Enabled = True
            lblShowTotalPrice.Text = $"Total: ${totalPrice + CType(TBoxAditionalValue.Text, Integer)}"
        End If
    End Sub

    Private Sub TBoxSoloNumerosKP(sender As Object, e As KeyPressEventArgs) Handles TBoxAditionalValue.KeyPress, TBoxClientIdentification.KeyPress, TBoxClientAge.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBoxSoloLetrasKP(sender As Object, e As KeyPressEventArgs) Handles TBoxClientName.KeyPress, TBoxClientSurname.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCcrtSellClic(sender As Object, e As EventArgs) Handles btnCcrtSell.Click
        If CBSlcTEntrada.SelectedIndex = 0 Then
            MessageBox.Show("Tipo de entrada no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxClientName.Text = String.Empty Then
            MessageBox.Show("No se ha introducido el nombre del cliente", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxClientSurname.Text = String.Empty Then
            MessageBox.Show("No se ha introducido el apellido del cliente", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxClientIdentification.Text = String.Empty Then
            MessageBox.Show("No se ha introducido la Cedula del cliente", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxClientAge.Text = String.Empty Then
            MessageBox.Show("No se ha introducido la edad del cliente", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim edadRequerida As Integer = iDB.returnData($"SELECT minimumAge FROM Events WHERE idEvents={idEvent}")
        If CType(TBoxClientAge.Text, Integer) < edadRequerida Then
            MessageBox.Show("La edad del cliente es menor a la requerida", "Edad insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        addTicket()
        CBSlcEvent.SelectedIndex = 0
    End Sub
End Class