Public Class addGroupsToEvent
    Private idEvent As Integer
    Private idGroup As Integer
    Private datei As Date
    Private datef As Date
    Private hourac As String

    Public Sub New()
        InitializeComponent()
        iDB.ExSelect($"SELECT idEvents, name_events FROM Events", CBSlcEvents)
        iDB.ExSelect($"SELECT idGroups, nameGroup FROM Groups", CBSlcGroups)
        ShortViewEvents(CBSlcEvents)
        CBSlcEvents.SelectedIndex = 0
        CBSlcGroups.SelectedIndex = 0
        hourac = mTBoxAtuationHour.Text
    End Sub

    Private Sub cbSlcEventsSIC(sender As Object, e As EventArgs) Handles CBSlcEvents.SelectedIndexChanged
        If CBSlcEvents.SelectedIndex = 0 Then
            gbAddGroups.Enabled = False
            gbDlteGroups.Enabled = False
            CBSlcGroups.SelectedIndex = 0
            mTBoxActuationDate.Text = "  /  /    "
            mTBoxAtuationHour.Text = "  :  "
            nudStageNum.Value = 1
            dgvShowEventGroups.Rows.Clear()
        Else
            gbAddGroups.Enabled = True
            gbDlteGroups.Enabled = True
            idEvent = returnID(CBSlcEvents.SelectedItem.ToString)

            datei = iDB.ExSelect($"SELECT datei FROM Events WHERE idEvents={idEvent}")
            datef = iDB.ExSelect($"SELECT datef FROM Events WHERE idEvents={idEvent}")

            If datei < Date.Now.ToString("dd/MM/yyyy") Then
                MessageBox.Show("El evento ya finalizo y no se puede agregar grupos", "Error al agregar un participante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CBSlcEvents.SelectedIndex = 0
                Return
            End If

            If datei <= Date.Now.ToString("dd/MM/yyyy") And datef >= Date.Now.ToString("dd/MM/yyyy") Then
                MessageBox.Show("El evento ya comenzó y no se puede agregar grupos", "Error al agregar un participante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CBSlcEvents.SelectedIndex = 0
                Return
            End If

            nudStageNum.Maximum = iDB.ExSelect($"SELECT stages FROM Events WHERE idEvents={idEvent}")
            iDB.ExSelect($"SELECT idGroups,dateShow,timeShow,stageNum FROM Participants WHERE idEvents={idEvent}", dgvShowEventGroups, 4, True)
        End If

    End Sub

    Private Sub addGroupEvent()
        If iDB.Query($"INSERT INTO Participants(idEvents,idGroups,dateShow,timeShow,stageNum) VALUES({idEvent},{idGroup},'{mTBoxActuationDate.Text}','
						{mTBoxAtuationHour.Text}','{nudStageNum.Value}')") = True Then
            MessageBox.Show("Se ha agregado el grupo al evento", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CBSlcEvents.SelectedIndex = 0
        End If
    End Sub

    Private Function VerifyDuplicatedGroup() As Boolean
        For i = 0 To dgvShowEventGroups.Rows.Count - 1
            If dgvShowEventGroups.Item(0, i).Value = idGroup Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub btnAddGroupToEventClic(sender As Object, e As EventArgs) Handles btnAddGroupToEvent.Click
        If idGroup = -1 Then
            MessageBox.Show("No hay ningun grupo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If VerifyDuplicatedGroup() = True Then
            MessageBox.Show("No se puede agregar el mismo grupo a este evento", "Grupo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim actuationdate As Date = mTBoxActuationDate.Text

        If actuationdate < datei Then
            MessageBox.Show("La fecha de actuación es menor a la del evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If actuationdate > datef Then
            MessageBox.Show("La fecha de actuación es mayor a la del evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If mTBoxAtuationHour.Text = hourac Then
            MessageBox.Show("Es necesario introducir la hora de la participación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        addGroupEvent()
    End Sub

    Private Sub dgvShowEventGroups_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowEventGroups.CellContentClick
        If e.ColumnIndex = 4 Then 'Contenido de la ultima columna
            Dim groupName As String = iDB.ExSelect($"SELECT nameGroup FROM Groups WHERE idGroups={dgvShowEventGroups.Item(0, e.RowIndex).Value.ToString}")
            Dim dlg As DialogResult = MessageBox.Show($"¿Desea eliminar el grupo #{dgvShowEventGroups.Item(0, e.RowIndex).Value.ToString}. {groupName}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlg = DialogResult.Yes Then 'Si le da al boton Si, ejecuta otro if.
                If iDB.Query($"DELETE FROM Participants WHERE idGroups={dgvShowEventGroups.Item(0, e.RowIndex).Value.ToString} AND idEvents={idEvent};") = True Then 'Si las dos consultas devuelven True muestra un mensaje.
                    MessageBox.Show("Se ha eliminado el grupo del evento!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FillDGV($"SELECT idGroups,dateShow,timeShow,stageNum FROM Participants WHERE idEvents={idEvent}", dgvShowEventGroups, 4, True) 'Actualiza los datos del datagridview
                End If
            End If
        End If
    End Sub

    Private Sub CBSlcGroups_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSlcGroups.SelectedIndexChanged
        If CBSlcGroups.SelectedIndex <> 0 Then
            idGroup = returnID(CBSlcGroups.SelectedItem.ToString)
        Else
            idGroup = -1
        End If
    End Sub

    Private Sub mTBoxActuationDateTVC(sender As Object, e As TypeValidationEventArgs) Handles mTBoxActuationDate.TypeValidationCompleted
        If Not e.IsValidInput Then
            MessageBox.Show("La fecha no es válida", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxActuationDate.Select()
            Return
        End If
    End Sub
End Class