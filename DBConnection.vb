Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private datos As MySqlConnectionStringBuilder 'variable de datos de la conexion
    Private con As MySqlConnection 'variable para iniciar y parar la conexion
    Private cmd As MySqlCommand 'variable para ejecutar comandos
    Private reader As MySqlDataReader 'variable para leer datos retornados por la base de datos

    'Método que devuelve los datos de la conexion
    Private Function dConexion() As MySqlConnectionStringBuilder
        datos = New MySqlConnectionStringBuilder
        datos.Server = My.Settings.server 'IP: thecodeeye.sytes.net
        datos.Port = My.Settings.port
        datos.UserID = My.Settings.userid
        datos.Password = My.Settings.dbpassword
        datos.Database = My.Settings.db
        Return datos
    End Function

    'Método que devuelve la conexion ya abierta.
    Private Function Conexion() As MySqlConnection
        con = New MySqlConnection(dConexion().ToString)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch e As MySqlException
            MessageBox.Show("Error al conectar con la base de datos", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return con
    End Function

    'Método que ejecuta los comandos: INSERT, UPDATE y DELETE.
    Public Function Query(qry As String) As Boolean
		Try
			cmd = New MySqlCommand(qry, Conexion())
			cmd.ExecuteNonQuery()
			Return True
		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
			Return False
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

    'Método que ejecuta y retorna SOLO un valor de la base de datos.
    'Es necesario utilizar solo una columna y un WHERE, o sino; devolverá solo el elemento de la primera columna y fila (0, 0).
    Public Function ExSelect(qry As String) As String
        Try
            cmd = New MySqlCommand(qry, Conexion())
            reader = cmd.ExecuteReader()
            reader.Read()
            Return reader.GetString(0)
        Catch ex As MySqlException
            Return Nothing
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

	Public Sub ExSelect(qry As String, ByVal values As List(Of Object))
		Try
			cmd = New MySqlCommand(qry, Conexion())
			reader = cmd.ExecuteReader()
			While reader.Read()
				values.Add(reader.GetString(0))
			End While
		Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
			If con.State = ConnectionState.Open Then
				con.Close()
			End If
		End Try
	End Sub

	'Método que llena todo un combobox con elementos, estos elementos son el ID (la llave primaria de las tablas de la base de datos)
	'y el nombre correspondiendo (evento o grupo).
	Public Sub ExSelect(qry As String, cb As ComboBox)
        Try
            cmd = New MySqlCommand(qry, Conexion())
            reader = cmd.ExecuteReader()
            While reader.Read() 'si hay alguna fila para leer, devuelve True (entra al código del While); si no hay, devuelve False y no entra al código del While.
                cb.Items.Add(reader.GetString(0) & ". " & reader.GetString(1))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error en consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    'Método que llena todo un datagridview con elemntos, estos elementos comunmente son todas las columnas y filas de la tabla necesaria.
    Public Async Sub ExSelect(qry As String, dgv As DataGridView, clmnCount As Integer, fresh As Boolean)
        Try
            cmd = New MySqlCommand(qry, Conexion())
            reader = cmd.ExecuteReader()
            If fresh = True Then
                dgv.Rows.Clear() 'Limpia todas las filas que hay en el datagridview
            End If

            While Await reader.ReadAsync() 'si hay alguna fila para leer, devuelve True (entra al código del While); si no hay, devuelve False y no entra al código del While.
                If clmnCount = 10 Then 'Numero de columnas de la ventana StartMenu
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), $"{reader.GetString(2)}, {reader.GetString(3)}", $"{reader.GetString(4)} - {reader.GetString(5)}",
                                            reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9))
                ElseIf clmnCount = 4 Then 'Numero de columnas de la ventana AgregarGrupoaunEvento
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3))
                ElseIf clmnCount = 5 Then 'Numero de columnas de la ventana EliminarGrupos
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4))
                ElseIf clmnCount = 1 Then 'Numero de columnas de la ventana HistorialdeEventos
                    dgv.Rows.Add(reader.GetString(0))
                ElseIf clmnCount = 6 Then 'Numero de columnas de la ventana reembolso
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5))
                ElseIf clmnCount = 3 Then
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2))
                End If
            End While
        Catch ex As MySqlException
            MessageBox.Show("Error al llenar de datos el datagrid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class