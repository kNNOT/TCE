Public Class EventsHistory
    Private idEvent As Integer?
    Private idGroup As Integer?
    Private defaultmask As String

    Public Sub New()
        InitializeComponent()
        cbSlcGroup.SelectedIndex = 0
        cbSlcEvent.SelectedIndex = 0
        iDB.ExSelect("SELECT idGroups, nameGroup FROM Groups", cbSlcGroup)
        iDB.ExSelect("SELECT idEvents, name_events FROM Events", cbSlcEvent)
        iDB.ExSelect("SELECT nameGroup FROM Groups", dgvShowGroups, 1, True)
        iDB.ExSelect("SELECT CI, name, surname FROM Clients", dgvShowClients, 3, True)
        defaultmask = mTBoxDateF.Text
        CheckForIllegalCrossThreadCalls = False

        If dgvShowGroups.Rows.Count = 0 Then
            lblNoDataG.Visible = True
        Else
            lblNoDataG.Visible = False
        End If

        If dgvShowClients.Rows.Count = 0 Then
            lblNoDataC.Visible = True
        Else
            lblNoDataC.Visible = False
        End If
    End Sub

	Private Sub cbSlcEventSIC(sender As Object, e As EventArgs) Handles cbSlcEvent.SelectedIndexChanged
		If cbSlcEvent.SelectedIndex = 0 Then
			dgvShowClientsGoE.Rows.Clear()
            idEvent = Nothing
            lblNoDataHCS.Visible = False
        Else
			idEvent = returnID(cbSlcEvent.SelectedItem.ToString)
            iDB.ExSelect($"SELECT c.CI, name, surname FROM Clients c, Tickets t, Events e WHERE c.CI=t.CI AND e.idEvents=t.idEvent AND e.idEvents={idEvent}", dgvShowClientsGoE, 3, True)

            If dgvShowClientsGoE.Rows.Count = 0 Then
                lblNoDataHCS.Visible = True
            Else
                lblNoDataHCS.Visible = False
            End If
        End If
	End Sub

	Private Sub cbSlcGroupSIC(sender As Object, e As EventArgs) Handles cbSlcGroup.SelectedIndexChanged
		If cbSlcGroup.SelectedIndex = 0 Then
			dgvShowGroupsHE.Rows.Clear()
            idGroup = Nothing
            lblNoDataHG.Visible = False
        Else
			idGroup = returnID(cbSlcGroup.SelectedItem.ToString)
            iDB.ExSelect($"SELECT name_events FROM Events e, Groups g, Participants p WHERE e.idEvents= p.idEvents AND g.idGroups=p.idGroups AND g.idGroups={idGroup}", dgvShowGroupsHE, 1, True)

            If dgvShowGroupsHE.Rows.Count = 0 Then
                lblNoDataHG.Visible = True
            Else
                lblNoDataHG.Visible = False
            End If
        End If
	End Sub

    Private Sub btnSearchEventDateClic(sender As Object, e As EventArgs) Handles btnSearchEventDate.Click
        If mTBoxDateI.Text = defaultmask Or mTBoxDateF.Text = defaultmask Then
            MessageBox.Show("Debes introducir las fechas para hacer la búsqueda", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvShowEventsPerDate.Rows.Clear()
            Return
        End If

        Dim firstDate As Date = mTBoxDateI.Text
        Dim secondDate As Date = mTBoxDateF.Text
        If firstDate > secondDate Then
            Dim dlg As DialogResult = MessageBox.Show($"La primera fecha es mayor a la segunda fecha.{vbLf}Orden de fechas inválidas para la filtración de los eventos.{vbLf}", "Fechas en orden incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'If dlg = DialogResult.Yes Then
            'mTBoxDateI.Text = secondDate
            'mTBoxDateF.Text = firstDate
            'lseIf dlg = DialogResult.No Then
            '   Return
            'End If
            Return
        End If

        If dgvShowEventsPerDate.Rows.Count > 0 Then
            dgvShowEventsPerDate.Rows.Clear()
        End If

        Dim tEventdata As Threading.Thread = New Threading.Thread(AddressOf setDataRespons)
        tEventdata.Start()

        If dgvShowEventsPerDate.Rows.Count = 0 Then
            lblNoDataHF.Visible = True
        Else
            lblNoDataHF.Visible = False
        End If
    End Sub

    Private Function getIDDateDB() As List(Of Object)
        Dim listIdEvents As List(Of Object) = New List(Of Object)
        iDB.ExSelect("SELECT idEvents FROM Events", listIdEvents)
        Return listIdEvents
    End Function

    Private Function IdateMatch(datei As Date) As Boolean
        If datei >= Convert.ToDateTime(mTBoxDateI.Text) And datei <= Convert.ToDateTime(mTBoxDateF.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub setDataRespons()
        For Each id As Object In getIDDateDB()
            Dim datei As Date = iDB.ExSelect($"SELECT datei FROM Events WHERE idEvents={id}")
            If IdateMatch(datei) = True Then
                iDB.ExSelect($"SELECT name_events FROM Events WHERE idEvents={id}", dgvShowEventsPerDate, 1, False)
            End If
        Next
    End Sub

    Private Sub dgvShowEventsPerDateRE(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowEventsPerDate.RowEnter
        lblNoDataHF.Visible = False
    End Sub

    Private Sub mTboxsValidation(sender As Object, e As TypeValidationEventArgs) Handles mTBoxDateI.TypeValidationCompleted, mTBoxDateF.TypeValidationCompleted
        If sender.Equals(mTBoxDateI) And mTBoxDateI.Text = defaultmask Then
            Return
        ElseIf sender.Equals(mTBoxDateF) And mTBoxDateF.Text = defaultmask Then
            Return
        End If

        If sender.Equals(mTBoxDateI) And Not e.IsValidInput Then
            MessageBox.Show("La fecha inicial no es válida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxDateI.Select()
            Return
        ElseIf sender.Equals(mTBoxDateF) And Not e.IsValidInput Then
            MessageBox.Show("La fecha final no es válida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxDateF.Select()
            Return
        End If
    End Sub
End Class