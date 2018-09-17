Public Class addorEditGroup
    Private idGrupo As Integer
    Private defaultmask As String
    Private uMod As Boolean

    Public Sub New(uMod As Boolean)
        InitializeComponent()
        Me.uMod = uMod
        cbMusicalGenre.SelectedIndex = 0
        If uMod = True Then
            cbSlcGroup.Visible = True
            cbSlcGroup.SelectedIndex = 0
            iDB.returnData("SELECT idGroups, nameGroup FROM Groups", cbSlcGroup)
            Me.Size = New Size(263, 255)
            layoutNewGroup.Location = New Point(-2, 20)
            Me.Text = "Modificar grupo"
            btnAddGroup.Text = "Modificar grupo"
        Else
            cbSlcGroup.Visible = False
        End If

        defaultmask = mTBoxCreationData.Text
    End Sub

    Private Sub addGroup()
        If iDB.Query($"INSERT INTO Groups(nameGroup,dataCreation,genre,memberCount) VALUES
                             ('{TBoxGroupName.Text}', '{mTBoxCreationData.Text}', '{cbMusicalGenre.SelectedItem.ToString}', {TBoxMembersCnt.Text})") = True Then
            MessageBox.Show("Se ha agregado el grupo", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub editGroup()
        If iDB.Query($"UPDATE Groups SET nameGroup='{TBoxGroupName.Text}', dataCreation='{mTBoxCreationData.Text}', 
                            genre='{cbMusicalGenre.SelectedItem.ToString}', memberCount={TBoxMembersCnt.Text} WHERE idGroups={idGrupo}") = True Then
            MessageBox.Show("Se ha editado el grupo", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAddEGroupsClic(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        If TBoxGroupName.Text = "Escriba el nombre del grupo" Or TBoxGroupName.Text = String.Empty Then
            MessageBox.Show("Este no es un nombre correcto", "Campo vacío o valor por defecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If mTBoxCreationData.Text = defaultmask Then
            MessageBox.Show("No haz insertado una fecha válida", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim fechadeCreacion As Date = mTBoxCreationData.Text

        If fechadeCreacion > DateTime.Now.ToString("dd/MM/yyyy") Then
            MessageBox.Show("No se puede agregar un grupo que aún no existe.", "El grupo no existe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbMusicalGenre.SelectedIndex = 0 Then
            MessageBox.Show("El género musical seleccionado no es un genero musical válido.", "Género musical incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TBoxMembersCnt.Text = String.Empty Or TBoxMembersCnt.Text = "Escribe el número de integrantes" Or CType(TBoxMembersCnt.Text, Integer) = 0 Then
            MessageBox.Show("Cantidad de integrante no válida.", "Campo vacío(0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If uMod = False Then
            addGroup()
        ElseIf uMod = True Then
            editGroup()
        End If
    End Sub

    Private Sub DataCreationTVC(sender As Object, e As TypeValidationEventArgs) Handles mTBoxCreationData.TypeValidationCompleted
        If Not e.IsValidInput Then
            MessageBox.Show("La fecha ingresada no es correcta", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxCreationData.Select()
            Return
        End If
    End Sub

    Private Sub SelectGroupSIC(sender As Object, e As EventArgs) Handles cbSlcGroup.SelectedIndexChanged
        If cbSlcGroup.SelectedIndex = 0 Then
            layoutNewGroup.Enabled = False
            TBoxGroupName.Text = "Escriba el nombre del grupo"
            TBoxMembersCnt.Text = "Escribe el número de integrantes"
            cbMusicalGenre.SelectedIndex = 0
            mTBoxCreationData.Text = defaultmask
        Else
            layoutNewGroup.Enabled = True
            idGrupo = returnID(cbSlcGroup.SelectedItem.ToString)
            TBoxGroupName.Text = iDB.returnData($"SELECT nameGroup FROM Groups WHERE idGroups={idGrupo}")
            mTBoxCreationData.Text = iDB.returnData($"SELECT dataCreation FROM Groups WHERE idGroups={idGrupo}")
            Dim generom As String = iDB.returnData($"SELECT genre FROM Groups WHERE idGroups={idGrupo}")
            For i = 0 To cbMusicalGenre.Items.Count - 1
                If cbMusicalGenre.Items(i).ToString = generom Then
                    cbMusicalGenre.SelectedIndex = i
                    Exit For
                End If
            Next
            TBoxMembersCnt.Text = iDB.returnData($"SELECT memberCount FROM Groups WHERE idGroups={idGrupo}")
        End If
    End Sub

    Private Sub TBoxGroupNameClic(sender As Object, e As EventArgs) Handles TBoxGroupName.Click
        If TBoxGroupName.Text = "Escriba el nombre del grupo" Then
            TBoxGroupName.Text = String.Empty
        End If
    End Sub

    Private Sub TBoxGroupNameLeaveFocus(sender As Object, e As EventArgs) Handles TBoxGroupName.Leave
        If TBoxGroupName.Text = String.Empty Then
            TBoxGroupName.Text = "Escriba el nombre del grupo"
        End If
    End Sub

    Private Sub TBoxMemberCountClic(sender As Object, e As EventArgs) Handles TBoxMembersCnt.Click
        If TBoxMembersCnt.Text = "Escribe el número de integrantes" Then
            TBoxMembersCnt.Text = String.Empty
        End If
    End Sub

    Private Sub TBoxMemberCountLeaveFocus(sender As Object, e As EventArgs) Handles TBoxMembersCnt.Leave
        If TBoxMembersCnt.Text = String.Empty Then
            TBoxMembersCnt.Text = "Escribe el número de integrantes"
        End If
    End Sub

    Private Sub TboxsKP(sender As Object, e As KeyPressEventArgs) Handles TBoxGroupName.KeyPress, TBoxMembersCnt.KeyPress
        If sender.Equals(TBoxGroupName) Then
            If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf sender.Equals(TBoxMembersCnt) Then
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class