Public Class EventsHistory
    Private idEvent As Integer?
    Private idGroup As Integer?

    Public Sub New()
        InitializeComponent()
        cbSlcGroup.SelectedIndex = 0
        cbSlcEvent.SelectedIndex = 0
        iDB.ExSelect("SELECT idGroups, nameGroup FROM Groups", cbSlcGroup)
        iDB.ExSelect("SELECT idEvents, name_events FROM Events", cbSlcEvent)
        iDB.ExSelect("SELECT nameGroup FROM Groups", dgvShowGroups, 1)
        iDB.ExSelect("SELECT CI, name, surname FROM Clients", dgvShowClients, 3)
    End Sub

    Private Sub cbSlcEventSIC(sender As Object, e As EventArgs) Handles cbSlcEvent.SelectedIndexChanged
        If cbSlcEvent.SelectedIndex = 0 Then
            dgvShowClientsGoE.Rows.Clear()
            idEvent = Nothing
        Else
            idEvent = returnID(cbSlcEvent.SelectedItem.ToString)
            iDB.ExSelect($"SELECT c.CI, name, surname FROM Clients c, Tickets t, Events e WHERE c.CI=t.CI AND e.idEvents=t.idEvent AND e.idEvents={idEvent}", dgvShowClientsGoE, 3)
        End If
    End Sub
End Class