Public Class StartMenu
    Private Sub btnAddEventClic(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addEvent As addorEditEvent = New addorEditEvent(False)
        addEvent.ShowDialog()
    End Sub

    Private Sub btnEditEventsClic(sender As Object, e As EventArgs) Handles btnEditEvents.Click
        Dim editEvent As addorEditEvent = New addorEditEvent(True)
        editEvent.ShowDialog()
    End Sub

    Private Sub btnGroupClic(sender As Object, e As EventArgs) Handles btnNewGroup.Click
        Dim addGroup As addorEditGroup = New addorEditGroup(False)
        addGroup.ShowDialog()
    End Sub

    Private Sub btnEditClic(sender As Object, e As EventArgs) Handles btnEditGroups.Click
        Dim editGroup As addorEditGroup = New addorEditGroup(True)
        editGroup.ShowDialog()
    End Sub
End Class