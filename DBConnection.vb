Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private datos As MySqlConnectionStringBuilder
    Private con As MySqlConnection
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader

    Private Function dConexion() As MySqlConnectionStringBuilder
        datos = New MySqlConnectionStringBuilder
        datos.Server = "thecodeeye.sytes.net"
        datos.Port = 3306
        datos.UserID = "alexuy"
        datos.Password = "416C65785F31113A"
        datos.Database = "TCodeERVShows"
        Return datos
    End Function

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

    Public Function Query(ByVal qry As String) As Boolean
        Try
            cmd = New MySqlCommand(qry, Conexion())
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            Return False
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

    Public Function returnData(ByVal qry As String) As String
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

    Public Sub returnData(ByVal qry As String, ByVal cb As ComboBox)
        Try
            cmd = New MySqlCommand(qry, Conexion())
            reader = cmd.ExecuteReader()
            While reader.Read()
                cb.Items.Add(reader.GetString(0) & ". " & reader.GetString(1))
            End While
        Catch ex As MySqlException
            MessageBox.Show("Error al ejecutar el comando", "Error en consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class