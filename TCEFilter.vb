Public Class TCEFilter
    Private dgvData(0, 0) As String 'Array columna-fila
    Private dgv As DataGridView 'datagridview para filtar datos
    Private clmnCount As Integer 'Cantidad de columnas de datos
    Private rowsCount As Integer 'Cantidad de filas del datagridview

    'Contructor que inicia los valores de las variales globales.
    Public Sub New(dgv As DataGridView, clmnCount As Integer)
        Me.dgv = dgv
        Me.clmnCount = clmnCount
        rowsCount = dgv.Rows.Count
    End Sub

    'Método que establece todos los datos del datagrid en memoria
    Public Sub setArrayData()
        ReDim dgvData(clmnCount, dgv.Rows.Count)
        For i = 0 To dgv.Rows.Count - 1
            For c = 0 To clmnCount - 1
                dgvData(c, i) = dgv.Item(c, i).Value
            Next
        Next
    End Sub

    'Método para filtrar los datos, segun el parametro t.
    Public Sub Filter(t As String)
        Dim indexesdgv(rowsCount) As Integer? 'Array con la cantidad total de filas que acepta enteros y valores nulos.
        For dgvArrayIndex = 0 To rowsCount - 1
            If dgvData(1, dgvArrayIndex).Contains(t) Then
                indexesdgv(dgvArrayIndex) = dgvArrayIndex
            Else
                indexesdgv(dgvArrayIndex) = Nothing
            End If
        Next

        'Deja limpio el datagrid y agrega los datos filtrados
        dgv.Rows.Clear()
        For i = 0 To rowsCount - 1
            If indexesdgv(i) IsNot Nothing Then
                dgv.Rows.Add(dgvData(0, indexesdgv(i)), dgvData(1, indexesdgv(i)), dgvData(2, indexesdgv(i)), dgvData(3, indexesdgv(i)), dgvData(4, indexesdgv(i)))
            End If
        Next
    End Sub
End Class
