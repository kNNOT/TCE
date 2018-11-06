Imports System.Threading

Public Class addorEditEvent
    Private uMod As Boolean = Nothing
    Private idEvent As Integer = Nothing
    Private defaultmask As String

    Public Sub New(ByVal uMod As Boolean)
        InitializeComponent()
        Me.uMod = uMod
        If uMod = False Then
            cbSlcEventToEdit.Visible = False
        Else
            FillCbEvents()
            cbSlcEventToEdit.Visible = True
            cbSlcEventToEdit.SelectedIndex = 0
            Me.Size = New Size(385, 275) 'se agrandara el alto de la ventana
            layoutAddNewEvent.Location = New Point(-2, 21) 'se movera todos los componentes excluyendo al combobox hacia abajo
            Me.Text = "Modificar evento"
            btnAddEvent.Text = "Modificar evento"
        End If

        defaultmask = mTBoxStartEventDate.Text
    End Sub

    Sub FillCbEvents()
        cbSlcEventToEdit.Enabled = False
        iDB.ExSelect("SELECT idEvents, name_events FROM Events", cbSlcEventToEdit)
        cbSlcEventToEdit.Enabled = True
    End Sub

    'Validacion de exepciones "sentencias IF´s"
    Private Sub addoreditEvent(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        If TBoxEventName.Text = String.Empty Then
            MessageBox.Show("Falta el nombre del evento", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxCityEvent.Text = String.Empty Then
            MessageBox.Show("Falta la ciudad donde se hará evento", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxEventDirec.Text = String.Empty Then
            MessageBox.Show("Falta la dirección del evento", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If mTBoxStartEventDate.Text = defaultmask Then 'si no se modifico el campo de fecha inicial (vacio), muestra un msg de error
            MessageBox.Show("Falta la fecha de inicio del evento", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If mTBoxEndEventDate.Text = defaultmask Then 'si no se modifico el campo de fecha final (vacio), muestra un msg de error
            MessageBox.Show("Falta la fecha final del evento", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxEventPrice.Text = String.Empty Then
            MessageBox.Show("Falta el precio del evento", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim fechaInicial As Date = mTBoxStartEventDate.Text 'guarda la fecha inicial en formato DATE
        Dim fechaFinal As Date = mTBoxEndEventDate.Text 'guarda la fecha final en formato DATE

        If fechaInicial > fechaFinal Then 'si la fecha inicial esta ubicada en un futuro, muestra un msg de error
            MessageBox.Show("La fecha inicial del evento no puede ser mayor a la fecha final.", "Orden de fechas incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxStartEventDate.Select()
            Return
        End If
        If fechaInicial < Date.Now.ToString("dd/MM/yyyy") Then
            MessageBox.Show("La fecha inicial del evento no puede ser menor a la fecha actual.", "Fecha Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxStartEventDate.Select()
            Return
        End If

        If uMod = False Then
            addEvent()
        Else
            editEvent()
        End If

        TBoxEventName.Text = String.Empty
        TBoxEventDirec.Text = String.Empty
        TBoxCityEvent.Text = String.Empty
        TBoxEventPrice.Text = String.Empty
        mTBoxEndEventDate.Text = String.Empty
        mTBoxStartEventDate.Text = String.Empty
        nudMinimumAge.Value = 0
        nudStagesNumbers.Value = 1
        nudCtnEntradas.Value = 1
    End Sub

    'creamos un metodo para añadir un evento (INSERT), para usarlo despues
    Private Sub addEvent()
        If iDB.Query($"INSERT INTO Events(name_events,city,direcc,datei,datef,stages,minimumAge,ticketsopen,priceEvent)
                     VALUES('{TBoxEventName.Text}', '{TBoxCityEvent.Text}', '{TBoxEventDirec.Text}', '{mTBoxStartEventDate.Text}', 
                     '{mTBoxEndEventDate.Text}', {nudStagesNumbers.Value}, {nudMinimumAge.Value}, {nudCtnEntradas.Value}, {TBoxEventPrice.Text})") = True Then
            MessageBox.Show("Se ha agregado el evento.", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'creamos un metodo para editar un evento (UPDATE), para usarlo despues
    Private Sub editEvent()
        If iDB.Query($"UPDATE Events SET name_events='{TBoxEventName.Text}', city='{TBoxCityEvent.Text}', direcc='{TBoxEventDirec.Text}',
                     datei='{mTBoxStartEventDate.Text}', datef='{mTBoxEndEventDate.Text}', stages={nudStagesNumbers.Value}, minimumAge={nudMinimumAge.Value}, ticketsopen={nudCtnEntradas.Value}, priceEvent={TBoxEventPrice.Text}
                      WHERE idEvents={idEvent}") = True Then
            MessageBox.Show("Se ha editado el evento.", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbSlcEventToEdit.SelectedIndex = 0
        End If
    End Sub

    Private Sub SlcEventSIC(sender As Object, e As EventArgs) Handles cbSlcEventToEdit.SelectedIndexChanged
        'Deja todos los campos con valores por defecto.
        If cbSlcEventToEdit.SelectedIndex = 0 Then
            layoutAddNewEvent.Enabled = False
            TBoxEventName.Text = String.Empty
            TBoxCityEvent.Text = String.Empty
            TBoxEventDirec.Text = String.Empty
            TBoxEventPrice.Text = String.Empty
            mTBoxStartEventDate.Text = defaultmask
            mTBoxEndEventDate.Text = defaultmask
            nudCtnEntradas.Value = 1
            nudMinimumAge.Value = 0
            nudStagesNumbers.Value = 1
        Else
            layoutAddNewEvent.Enabled = True
            idEvent = returnID(cbSlcEventToEdit.SelectedItem.ToString) 'Obtiene el ID del item seleccionado en el combobox
            'Llenar cada TextBox, NumericUpDown y MaskedTextBox con valores de la base de datos segun el evento seleccionado.
            TBoxEventName.Text = iDB.ExSelect($"SELECT name_events FROM Events WHERE idEvents={idEvent}") 'Nombre del evento
            TBoxCityEvent.Text = iDB.ExSelect($"SELECT city FROM Events WHERE idEvents={idEvent}") 'Ciudad del evento
            TBoxEventDirec.Text = iDB.ExSelect($"SELECT direcc FROM Events WHERE idEvents={idEvent}") 'Direccion del evento
            TBoxEventPrice.Text = iDB.ExSelect($"SELECT priceEvent FROM Events WHERE idEvents={idEvent}") 'Precio del evento
            mTBoxStartEventDate.Text = iDB.ExSelect($"SELECT datei FROM Events WHERE idEvents={idEvent}") 'Fecha de inicio del evento
            mTBoxEndEventDate.Text = iDB.ExSelect($"SELECT datef FROM Events WHERE idEvents={idEvent}") 'Fecha final del evento
            nudCtnEntradas.Value = iDB.ExSelect($"SELECT ticketsopen FROM Events WHERE idEvents={idEvent}") 'Cantidad de entradas disponibles
            nudMinimumAge.Value = iDB.ExSelect($"SELECT minimumAge FROM Events WHERE idEvents={idEvent}") 'Edad minima para asistir al evento
            nudStagesNumbers.Value = iDB.ExSelect($"SELECT stages FROM Events WHERE idEvents={idEvent}") 'Cantidad de palcos.
        End If
    End Sub

    'Validacion de la fecha
    Private Sub StartEndEventDateTVC(sender As Object, e As TypeValidationEventArgs) Handles mTBoxStartEventDate.TypeValidationCompleted, mTBoxEndEventDate.TypeValidationCompleted
        If sender.Equals(mTBoxStartEventDate) And Not e.IsValidInput Then
            MessageBox.Show("La fecha no es válida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxStartEventDate.Select()
            Return
        ElseIf sender.Equals(mTBoxEndEventDate) And Not e.IsValidInput Then
            MessageBox.Show("La fecha no es válida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxEndEventDate.Select()
            Return
        End If
    End Sub

    Private Sub btnHelpClic(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show($"Llene todos los campos vacíos para agregar un nuevo evento. {vbLf}Seleccione un elemento en la lista (si ésta aparece) para modificar un evento.", "Mensaje de ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnHelpME(sender As Object, e As EventArgs) Handles btnHelp.MouseEnter
        btnHelp.BackColor = Color.FromArgb(160, 160, 160)
    End Sub

    Private Sub btnHelpML(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        btnHelp.BackColor = Me.BackColor
    End Sub
End Class