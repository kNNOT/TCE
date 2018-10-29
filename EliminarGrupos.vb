﻿Public Class DeleteGroups
    Private qry As String = "SELECT * FROM Groups" 'Se utiliza para que no se repita en la llamada del método refreshData (al momento de usarla como parametro).

    'El public sub new() es el constructor, se utiliza para llenar todo el datagrid al momento de inciiar la ventana.
    Public Sub New()
        InitializeComponent()
        FillDGV(qry, dgvShowGroups, 5) 'Llena el datagrid con datos.
        'MsgModal.SetToolTip(btnRestoreList, "Reestablece todos los valores de la lista")
    End Sub

    'Cuando se le hace clic al contenido de una X celda (la utlima en este caso) se borra un grupo y todo lo relacionado.
    Private Sub deleteGroupClic(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowGroups.CellContentClick
        If e.ColumnIndex = 5 Then 'Contenido de la ultima columna
            Dim dlg As DialogResult = MessageBox.Show($"¿Desea eliminar el grupo #{dgvShowGroups.Item(0, e.RowIndex).Value.ToString}. {dgvShowGroups.Item(1, e.RowIndex).Value.ToString}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlg = DialogResult.Yes Then 'Si le da al boton Si, ejecuta otro if.
                If iDB.Query($"DELETE FROM Groups WHERE idGroups={dgvShowGroups.Item(0, e.RowIndex).Value.ToString}; 
                                 DELETE FROM Participants WHERE idGroups={dgvShowGroups.Item(0, e.RowIndex).Value.ToString};") = True Then 'Si las dos consultas devuelven True muestra un mensaje.
                    MessageBox.Show("Se ha eliminado el grupo!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FillDGV(qry, dgvShowGroups, 5) 'Actualiza los datos del datagridview
                    ' btnSearchGroup.Enabled = True
                    'btnRestoreList.Enabled = False
                End If
            End If
        End If
    End Sub

    'Al momento de buscar un grupo, mostrará unicamente los resultados obtenidos.
    Private Sub btnSearchGroupClic(sender As Object, e As EventArgs)
        If TBoxgroupName.Text = "Escriba el nombre del grupo" Or TBoxgroupName.Text = String.Empty Then
            MessageBox.Show("Este no es un grupo válido.", "Grupo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        FillDGV($"SELECT * FROM Groups WHERE nameGroup='{TBoxgroupName.Text}'", dgvShowGroups, 5) 'Llena el datagrid con los valores devueltos segun el nombre del grupo
        If dgvShowGroups.Rows.Count = 0 Then 'Si no se ha llenado el datagrid, quiere decir que no se ha encontrado ningun grupo con ese nombre.
            MessageBox.Show($"No se ha encontrado el grupo: {TBoxgroupName.Text}", "Sin valor", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FillDGV(qry, dgvShowGroups, 5) 'Le da un rifresh de nuevo al dgv
            TBoxgroupName.Text = "Escriba el nombre del grupo"
            ' btnRestoreList.Enabled = False
            Return
        End If
        'btnSearchGroup.Enabled = False
        'btnRestoreList.Enabled = True
        TBoxgroupName.Text = "Escriba el nombre del grupo"
    End Sub

    Private Sub btnRestoreListClic(sender As Object, e As EventArgs)
        FillDGV(qry, dgvShowGroups, 5)
        'btnSearchGroup.Enabled = True
        'btnRestoreList.Enabled = False
    End Sub

    Private Sub btnRestoreListME(sender As Object, e As EventArgs)
        'btnRestoreList.BackColor = Color.FromArgb(186, 186, 186)
    End Sub

    Private Sub btnRestoreListML(sender As Object, e As EventArgs)
        ' btnRestoreList.BackColor = BackColor
    End Sub

    Private Sub TBoxGroupNameClic(sender As Object, e As EventArgs) Handles TBoxgroupName.Click
        If TBoxgroupName.Text = "Escriba el nombre del grupo" Then
            TBoxgroupName.Text = String.Empty
        End If
    End Sub

    Private Sub TBoxGroupNameLeave(sender As Object, e As EventArgs) Handles TBoxgroupName.Leave
        If TBoxgroupName.Text = String.Empty Then
            TBoxgroupName.Text = "Escriba el nombre del grupo"
        End If
    End Sub

    Private rowsCount As Integer

    Private Sub TBoxGroupNameTC(sender As Object, e As EventArgs) Handles TBoxgroupName.TextChanged
        If TBoxgroupName.Text = String.Empty Or TBoxgroupName.Text = "Escriba el nombre del grupo" Then
            FillDGV(qry, dgvShowGroups, 5)
            Return
        End If

        Dim indexesdgv(rowsCount) As Integer?
        For dgvArrayIndex = 0 To rowsCount - 1
            If dgvDatafilter(1, dgvArrayIndex).Contains(TBoxgroupName.Text) Then
                indexesdgv(dgvArrayIndex) = dgvArrayIndex
            Else
                indexesdgv(dgvArrayIndex) = Nothing
            End If
        Next

        dgvShowGroups.Rows.Clear()
        For i = 0 To rowsCount - 1
            If indexesdgv(i) IsNot Nothing Then
                dgvShowGroups.Rows.Add(dgvDatafilter(0, indexesdgv(i)), dgvDatafilter(1, indexesdgv(i)), dgvDatafilter(2, indexesdgv(i)), dgvDatafilter(3, indexesdgv(i)), dgvDatafilter(4, indexesdgv(i)))
            End If
        Next

        If dgvShowGroups.Rows.Count = 0 Then
            lblNoData.Visible = True
        Else
            lblNoData.Visible = False
        End If
    End Sub

    Private Sub DeleteGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDgvDataFilter(5, dgvShowGroups)
        rowsCount = dgvShowGroups.Rows.Count
    End Sub
End Class