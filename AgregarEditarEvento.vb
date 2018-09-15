Imports System.Threading

Public Class addorEditEvent
    Private uMod As Boolean = Nothing
    Private idEvent As Integer = Nothing
    Private defaultmask As String

    Public Sub New(ByVal uMod As Boolean)
        InitializeComponent()
        If uMod = False Then
            cbSlcEventToEdit.Visible = False
        Else
            FillCbEvents()
            cbSlcEventToEdit.Visible = True
            cbSlcEventToEdit.SelectedIndex = 0
            Me.Size = New Size(385, 275)
            layoutAddNewEvent.Location = New Point(-2, 21)
            CheckForIllegalCrossThreadCalls = False
            Me.Text = "Modificar evento"
            btnAddEvent.Text = "Modificar evento"
        End If

        defaultmask = mTBoxStartEventDate.Text
    End Sub

    Sub FillCbEvents()
        iDB.returnData("SELECT idEvents, name_events FROM Events", cbSlcEventToEdit)
    End Sub

    Private Sub addEvent()
        If iDB.Query($"INSERT INTO Events(name_events,city,direcc,datei,datef,stages,minimumAge,ticketsopen,priceEvent)
                     VALUES('{TBoxEventName.Text}', '{TBoxCityEvent.Text}', '{TBoxEventDirec.Text}', '{mTBoxStartEventDate.Text}', 
                     {mTBoxEndEventDate.Text}, {nudStagesNumbers.Value}, {nudMinimumAge.Value}, {nudCtnEntradas.Value}, {TBoxEventPrice.Text})") = True Then
            MessageBox.Show("Se ha agregado el evento.", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub editEvent()
        If iDB.Query($"UPDATE Events SET name_events='{TBoxEventName.Text}', city='{TBoxCityEvent.Text}', direcc='{TBoxEventDirec.Text}',
                     datei='{mTBoxStartEventDate.Text}', datef='{mTBoxEndEventDate.Text}', stages={nudStagesNumbers.Value}, minimumAge={nudMinimumAge.Value}, ticketsopen={nudCtnEntradas.Value}, priceEvent={TBoxEventPrice.Text}
                      WHERE idEvents={idEvent}") = True Then
            MessageBox.Show("Se ha editado el evento.", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SlcEventSIC(sender As Object, e As EventArgs) Handles cbSlcEventToEdit.SelectedIndexChanged
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
            idEvent = returnID(cbSlcEventToEdit.SelectedItem.ToString)
            TBoxEventName.Text = iDB.returnData($"SELECT name_events FROM Events WHERE idEvents={idEvent}")
            TBoxCityEvent.Text = iDB.returnData($"SELECT city FROM Events WHERE idEvents={idEvent}")
            TBoxEventDirec.Text = iDB.returnData($"SELECT direcc FROM Events WHERE idEvents={idEvent}")
            TBoxEventPrice.Text = iDB.returnData($"SELECT priceEvent FROM Events WHERE idEvents={idEvent}")
            mTBoxStartEventDate.Text = iDB.returnData($"SELECT datei FROM Events WHERE idEvents={idEvent}")
            mTBoxEndEventDate.Text = iDB.returnData($"SELECT datef FROM Events WHERE idEvents={idEvent}")
            nudCtnEntradas.Value = iDB.returnData($"SELECT ticketsopen FROM Events WHERE idEvents={idEvent}")
            nudMinimumAge.Value = iDB.returnData($"SELECT minimumAge FROM Events WHERE idEvents={idEvent}")
            nudStagesNumbers.Value = iDB.returnData($"SELECT stages FROM Events WHERE idEvents={idEvent}")
        End If
    End Sub
End Class