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

    'metodo para añadir grupo, INSERT, no se ejecutara hasta llamarlo en un evento
    Private Sub addGroup()
        If iDB.Query($"INSERT INTO Groups(nameGroup,dataCreation,genre,memberCount) VALUES
                             ('{TBoxGroupName.Text}', '{mTBoxCreationData.Text}', '{cbMusicalGenre.SelectedItem.ToString}', {TBoxMembersCnt.Text})") = True Then
            MessageBox.Show("Se ha agregado el grupo", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'metodo para editar grupo, UPDATE, no se ejecutara hasta llamarlo en un evento
    Private Sub editGroup()
        If iDB.Query($"UPDATE Groups SET nameGroup='{TBoxGroupName.Text}', dataCreation='{mTBoxCreationData.Text}', 
                            genre='{cbMusicalGenre.SelectedItem.ToString}', memberCount={TBoxMembersCnt.Text} WHERE idGroups={idGrupo}") = True Then
            MessageBox.Show("Se ha editado el grupo", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Evento click del btnAddGroup, debajo hay varios if´s, son exepciones o filtros de datos que el usuario va a ingresar
    Private Sub btnAddEGroupsClic(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        'si el usuario se olvido de cambiar el campo nombre, el programa mostrara un mensaje de error, y despues con el Return dejara 
        'de ejecutar las demas lineas del metodo
        If TBoxGroupName.Text = "Escriba el nombre del grupo" Or TBoxGroupName.Text = String.Empty Then
            MessageBox.Show("Este no es un nombre correcto", "Campo vacío o valor por defecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'si el usuario no modifico el campo fecha, pasara lo mismo
        If mTBoxCreationData.Text = defaultmask Then
            MessageBox.Show("No haz insertado una fecha válida", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'creamos una variable y le asignamos el valor del masked tbox fecha de creacion para poder trabajar con la fecha 
        Dim fechadeCreacion As Date = mTBoxCreationData.Text

        'si la fecha de creacion es superior a la actual, ...
        If fechadeCreacion > DateTime.Now.ToString("dd/MM/yyyy") Then
            MessageBox.Show("No se puede agregar un grupo el cual su fecha de creacion es mayor a la actual", "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'si el comboboxgenero tiene seleccionado el index 0, ...
        If cbMusicalGenre.SelectedIndex = 0 Then
            MessageBox.Show("El género musical seleccionado no es un genero musical válido.", "Género musical incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'si el usuario no modifico el campo textboxcantmiembros, ...
        If TBoxMembersCnt.Text = String.Empty Or TBoxMembersCnt.Text = "Escribe el número de integrantes" Then
            MessageBox.Show("Cantidad de integrante no válida.", "Campo vacío(0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If CType(TBoxMembersCnt.Text, Integer) = 0 Then
            MessageBox.Show("Cantidad de integrantes no puede ser 0.", "Valor incorrecto(0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'este if lee el valor de la variable uMod, si uMod es falso utiliza el metodo addgroup(), si es true utiliza editgroup()
        If uMod = False Then
            addGroup()
        ElseIf uMod = True Then
            editGroup()
        End If
    End Sub

    'comprueba si el formato de la fecha es dd/MM/yyyy(dia > 31, mes > 12 o año invalido -> 9999), si no es válido, muestra un mensaje de error, y deja el campo fecha com FOCUS
    Private Sub DataCreationTVC(sender As Object, e As TypeValidationEventArgs) Handles mTBoxCreationData.TypeValidationCompleted
        If Not e.IsValidInput Then
            MessageBox.Show("La fecha ingresada no es correcta", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mTBoxCreationData.Select()
            Return
        End If
    End Sub

    'si el index del combobox es el 0 (seleccionar un grupo), deshabilitara todos los items de la ventana, y los dejara con sus valores de inicio
    Private Sub SelectGroupSIC(sender As Object, e As EventArgs) Handles cbSlcGroup.SelectedIndexChanged
        If cbSlcGroup.SelectedIndex = 0 Then
            layoutNewGroup.Enabled = False
            TBoxGroupName.Text = "Escriba el nombre del grupo"
            TBoxMembersCnt.Text = "Escribe el número de integrantes"
            cbMusicalGenre.SelectedIndex = 0
            mTBoxCreationData.Text = defaultmask
        Else
            'si no es el index 0, importara los datos (CON SELECT) de la BD segun el IDGRUPO que agarro el metodo returnID
            layoutNewGroup.Enabled = True
            idGrupo = returnID(cbSlcGroup.SelectedItem.ToString)
            TBoxGroupName.Text = iDB.returnData($"SELECT nameGroup FROM Groups WHERE idGroups={idGrupo}")
            mTBoxCreationData.Text = iDB.returnData($"SELECT dataCreation FROM Groups WHERE idGroups={idGrupo}")
            'creamos una variable con el genero de la banda importado de la BD, para poder hacer una comparacion en el FOR de abajo
            Dim generom As String = iDB.returnData($"SELECT genre FROM Groups WHERE idGroups={idGrupo}")
            'creamos un for para recorrer todos los generos almacenados en el combobox (cbMusicalGenre)
            For i = 0 To cbMusicalGenre.Items.Count - 1
                'cuando el genero del combobox sea igual al de la banda, tomara la posicion(index) para que el item seleccionado
                'en cbMusicalGenre sea el de la posicion i
                If cbMusicalGenre.Items(i).ToString = generom Then
                    cbMusicalGenre.SelectedIndex = i
                    Exit For
                End If
            Next
            TBoxMembersCnt.Text = iDB.returnData($"SELECT memberCount FROM Groups WHERE idGroups={idGrupo}")
        End If
    End Sub

    'DETALLES VISUALES:
    'si el usuario hace click en el textboxnombre y este contiene "Escriba el nombre del grupo", se limpiara
    Private Sub TBoxGroupNameClic(sender As Object, e As EventArgs) Handles TBoxGroupName.Click
        If TBoxGroupName.Text = "Escriba el nombre del grupo" Then
            TBoxGroupName.Text = String.Empty
        End If
    End Sub

    'si el usuario deja el focus en el textboxnombre y este esta vacio, se llenara con "Escriba el nombre del grupo"
    Private Sub TBoxGroupNameLeaveFocus(sender As Object, e As EventArgs) Handles TBoxGroupName.Leave
        If TBoxGroupName.Text = String.Empty Then
            TBoxGroupName.Text = "Escriba el nombre del grupo"
        End If
    End Sub

    'si el usuario hace click en el textboxcantmiembros y este contiene "Escribe el número de integrantes", se limpiara
    Private Sub TBoxMemberCountClic(sender As Object, e As EventArgs) Handles TBoxMembersCnt.Click
        If TBoxMembersCnt.Text = "Escribe el número de integrantes" Then
            TBoxMembersCnt.Text = String.Empty
        End If
    End Sub

    'si el usuario deja el focus en el textboxcantmiembros y este esta vacio, se llenara con "Escribe el número de integrantes"
    Private Sub TBoxMemberCountLeaveFocus(sender As Object, e As EventArgs) Handles TBoxMembersCnt.Leave
        If TBoxMembersCnt.Text = String.Empty Then
            TBoxMembersCnt.Text = "Escribe el número de integrantes"
        End If
    End Sub

    'filtro del teclado, si esta parado en el textboxnombre dejara insertar SOLO NUMEROS, LETRAS Y ESPACIOS, ademas de BORRAR
    'si esta parado en el textboxcantmiembros dejara insertar SOLO NUMEROS, ademas de BORRAR
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