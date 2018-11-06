Imports System.Threading

Public Enum TypeResourceFire
    addevent = 0
    editevent
    deleteevent
    addgroup
    editgroup
    deletegroup
    participants
    history
    refund
    tickets
End Enum

Public Class StartMenu
    Private filter As TCEFilter
    Private Typeresource As Integer

    Public Sub New()
        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10, True)
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

        Dim TgetEventsFinished As Thread = New Thread(AddressOf getEventsFinished)
        TgetEventsFinished.Start()
    End Sub

    'Agregar los de participants a participated
    Private Sub getEventsFinished()

        If My.Settings.eventsFinishedDate < Date.Now.ToString("dd/MM/yyyy") Then
            My.Settings.eventsfinished = True
            My.Settings.eventsFinishedDate = Date.Now.ToString("dd/MM/yyyy")
        Else
            My.Settings.eventsfinished = False
        End If

        My.Settings.Save()

        Dim listIdEvents As List(Of Object) = New List(Of Object)
        iDB.ExSelect("SELECT idEvents FROM Participants", listIdEvents)
        Dim eventsFinished As Integer = 0
        For Each id As Object In listIdEvents
            Dim datefEvent As Date = iDB.ExSelect($"SELECT datef FROM Events WHERE idEvents={id}")
            If datefEvent < Date.Now.ToString("dd/MM/yyyy") Then
                eventsFinished = eventsFinished + 1
                Dim listIdGroupsParticipated As List(Of Object) = New List(Of Object)
                iDB.ExSelect($"SELECT idGroups FROM Participants WHERE idEvents={id}", listIdGroupsParticipated)

                For Each idGroup As Object In listIdGroupsParticipated
                    Dim nameGroup As String = iDB.ExSelect($"SELECT nameGroup FROM Groups WHERE idGroups={idGroup}")
                    Dim nameEvent As String = iDB.ExSelect($"SELECT name_events FROM Events WHERE idEvents={id}")
                    Dim dateShow As String = iDB.ExSelect($"SELECT dateShow FROM Participants WHERE idEvents={id} AND idGroups={idGroup}")
                    iDB.Query($"INSERT INTO Participated(idEvents,idGroups,nameEvent,nameGroup,dateShow) VALUES({id},{idGroup},'{nameEvent}','{nameGroup}','{dateShow}')")
                Next
            End If
        Next

            'Hacer que muestre la notificacion una vez por dia...

            If My.Settings.eventsfinished = True Then
                notfIc.BalloonTipIcon = ToolTipIcon.Info
                notfIc.BalloonTipText = $"Hoy: {Date.Now.ToString("dd/MM/yyyy")} han finalizado {eventsFinished} eventos."
                notfIc.BalloonTipTitle = "Eventos finalizados"
                notfIc.ShowBalloonTip(5000)
            End If

    End Sub

    Private Sub BallonTipClickedClic(sender As Object, e As EventArgs) Handles notfIc.BalloonTipClicked
        Dim LastRowCount As Integer = dgvShowEvents.Rows.Count - 1
        If Typeresource = 0 Then
            MessageBox.Show($"Nombre del evento: {dgvShowEvents.Item(1, LastRowCount).Value}{vbLf}Ciudad y Dirección: {dgvShowEvents.Item(2, LastRowCount).Value}{vbLf}Fecha inicial y final: {dgvShowEvents.Item(3, LastRowCount).Value}{vbLf}Número de placos: {dgvShowEvents.Item(4, LastRowCount).Value}{vbLf}Número de entradas: {dgvShowEvents.Item(5, LastRowCount).Value}{vbLf}Edad mínima requerida para entrar: {dgvShowEvents.Item(6, LastRowCount).Value}{vbLf}Precio: {dgvShowEvents.Item(7, LastRowCount).Value}{vbLf}", "Información nueva agregada al sistema, dale un vistazo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Select()
        End If
    End Sub

    'estos metodos llaman a las ventanas, con un valor en los parametros del constructor de las clases que los requieran: addorEditEvent y addorEditGroup
    Private Sub btnAddEventClic(sender As Object, e As EventArgs) Handles btnAddEvent.Click, ctxtMSAddEventos.Click
        Dim addEvent As addorEditEvent = New addorEditEvent(False) 'se puso el parametro en falso por que no es para editar
        addEvent.ShowDialog()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10, True)
        filter.Filas = dgvShowEvents.Rows.Count
        filter.setArrayData()
        notfIc.BalloonTipIcon = ToolTipIcon.Info
        notfIc.BalloonTipTitle = "Nuevo evento agregado"
        notfIc.BalloonTipText = "Se ha agregado un nuevo evento. Haz clic para más información"
        notfIc.ShowBalloonTip(5000)
        Typeresource = TypeResourceFire.addevent
    End Sub

    Private Sub btnEditEventsClic(sender As Object, e As EventArgs) Handles btnEditEvents.Click, ctxtMSModEventos.Click
        Dim editEvent As addorEditEvent = New addorEditEvent(True)
        editEvent.ShowDialog()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10, True)
        filter.Filas = dgvShowEvents.Rows.Count
        filter.setArrayData()
    End Sub

    Private Sub btnDeleteGroupClic(sender As Object, e As EventArgs) Handles btnDeleteGroup.Click, ctxtMSDelGroups.Click
        Dim deleteGroup As DeleteGroups = New DeleteGroups
        deleteGroup.ShowDialog()
    End Sub

    Private Sub btnGroupClic(sender As Object, e As EventArgs) Handles btnNewGroup.Click, ctxtMSAddGroups.Click
        Dim addGroup As addorEditGroup = New addorEditGroup(False)
        addGroup.ShowDialog()
    End Sub

    Private Sub btnEditClic(sender As Object, e As EventArgs) Handles btnEditGroups.Click, ctxtMSModGroups.Click
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
                    FillDGV("SELECT * FROM Events", dgvShowEvents, 10, True)
                    filter.Filas = dgvShowEvents.Rows.Count
                    Dim filterSAD As Thread = New Thread(AddressOf filter.setArrayData)
                    filterSAD.Start()
                    TBoxEventName.Text = "Escriba el nombre del evento"
                End If
            End If
        End If
    End Sub

    Private Sub btnReembolsoClic(sender As Object, e As EventArgs) Handles btnReembolso.Click, ctxtMSReembolso.Click
        Dim r As reembolso = New reembolso
        r.ShowDialog()
    End Sub

    Private Sub btnSellTicketsClic(sender As Object, e As EventArgs) Handles btnSellTickets.Click, ctxtMSSellTickets.Click
        Dim sellTickets As sellTickets = New sellTickets()
        sellTickets.ShowDialog()
        FillDGV("SELECT * FROM Events", dgvShowEvents, 10, True)
    End Sub

    Private Sub btnSettingsClic(sender As Object, e As EventArgs) Handles btnSettings.Click, ctxtMSConfiguration.Click
        Dim settings As configuraciones = New configuraciones
        settings.ShowDialog()
    End Sub

    Private Sub TBoxEventNameTC(sender As Object, e As EventArgs) Handles TBoxEventName.TextChanged
        If TBoxEventName.Text = String.Empty Or TBoxEventName.Text = "Escriba el nombre del evento" Then
            FillDGV("SELECT * FROM Events", dgvShowEvents, 10, True)
            lblNoData.Visible = False
            Return
        End If

        filter.FilterColumn = 1
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

    Private Sub btnEventsHistoryClic(sender As Object, e As EventArgs) Handles btnEventsHistorys.Click, ctxtMSFilterDatas.Click
        Dim filtradodedatos As EventsHistory = New EventsHistory
        filtradodedatos.ShowDialog()
    End Sub

    Private Sub ctxtClose(sender As Object, e As EventArgs) Handles ctxtMSClose.Click
        Close()
    End Sub

    Private Sub ctxtMSHideClic(sender As Object, e As EventArgs) Handles ctxtMSHide.Click
        If Visible = True Then
            Visible = False
            ctxtMSHide.Text = "Mostrar"
        Else
            Visible = True
            ctxtMSHide.Text = "Ocultar"
        End If
    End Sub

    Private Sub btnAddDltGroupToEventClic(sender As Object, e As EventArgs) Handles btnAddDltGroupToEvent.Click, ctxtMSParticipantsAdmin.Click
        Dim participants As addGroupsToEvent = New addGroupsToEvent
        participants.ShowDialog()
    End Sub
End Class