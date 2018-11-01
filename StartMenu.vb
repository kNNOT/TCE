Public Class StartMenu
    Private filter As TCEFilter

    Public Sub New()
        InitializeComponent()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
        filter = New TCEFilter(dgvShowEvents, 8)
        filter.setArrayData()

        If My.Settings.empresaName = "{nombre de la empresa}" And My.Settings.firstSession = True Then
            Dim emName As String = InputBox("Introduce el nombre de tu empresa", "Nombre de la empresa")
            My.Settings.empresaName = emName
            If emName = String.Empty Then
                My.Settings.empresaName = "{nombre de la empresa}"
            End If
            My.Settings.Save()
        End If

        Me.Text = $"Inicio - {My.Settings.empresaName} [V&R]"

        Dim countpass As Integer = 1
        If My.Settings.password IsNot String.Empty Then
            While countpass < 5
                Dim pass As String = InputBox("Introduce la contraseña para iniciar sessión", "Introducir contraseña")
                If My.Settings.password = pass Then
                    Exit While
                Else
                    countpass = countpass + 1
                End If

                If countpass = 5 Then
                    Dim mpass = InputBox("Introduce la contraseña maestra para recuperar la sessión.\nLa contraseña maestra se encuentra en el manual del usuario.", "introduce la contraseña maestra")
                    If My.Settings.masterPassword = mpass Then
                        Exit While
                    End If
                End If
            End While
        End If
    End Sub

    'estos metodos llaman a las ventanas, con un valor en los parametros del constructor de las clases que los requieran: addorEditEvent y addorEditGroup
    Private Sub btnAddEventClic(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addEvent As addorEditEvent = New addorEditEvent(False) 'se puso el parametro en falso por que no es para editar
        addEvent.ShowDialog()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
        filter.Filas = dgvShowEvents.Rows.Count
        filter.setArrayData()
    End Sub

    Private Sub btnEditEventsClic(sender As Object, e As EventArgs) Handles btnEditEvents.Click
        Dim editEvent As addorEditEvent = New addorEditEvent(True)
        editEvent.ShowDialog()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
        filter.Filas = dgvShowEvents.Rows.Count
        filter.setArrayData()
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
                    filter.Filas = dgvShowEvents.Rows.Count
                    filter.setArrayData()
                    TBoxEventName.Text = "Escriba el nombre del evento"
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
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
    End Sub

    Private Sub btnSettingsClic(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim settings As configuraciones = New configuraciones
        settings.ShowDialog()
    End Sub

    Private Sub TBoxEventNameTC(sender As Object, e As EventArgs) Handles TBoxEventName.TextChanged
        If TBoxEventName.Text = String.Empty Or TBoxEventName.Text = "Escriba el nombre del evento" Then
            FillDGV("SELECT * FROM Events", dgvShowEvents, 10)
            lblNoData.Visible = False
            Return
        End If

        filter.Filter(TBoxEventName.Text)

        If dgvShowEvents.Rows.Count = 0 Then
            lblNoData.Visible = True
        Else
            lblNoData.Visible = False
        End If
    End Sub

    Private Sub TBoxEventNameClic(sender As Object, e As EventArgs) Handles TBoxEventName.Click
        If TBoxEventName.Text = "Escriba el nombre del evento" Then
            TBoxEventName.Text = String.Empty
        End If
    End Sub

    Private Sub TBoxEventNameLeave(sender As Object, e As EventArgs) Handles TBoxEventName.Leave
        If TBoxEventName.Text = String.Empty Then
            TBoxEventName.Text = "Escriba el nombre del evento"
        End If
    End Sub

    Private Sub btnSettingsME(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
        btnSettings.BackColor = Color.FromArgb(210, 210, 210)
    End Sub

    Private Sub btnSettingsML(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.BackColor = BackColor
    End Sub
End Class