<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSellTickets = New System.Windows.Forms.Button()
        Me.msUser = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionDeParticipantesgruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgregarGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HistorialDeEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvShowEvents = New System.Windows.Forms.DataGridView()
        Me.dgvSEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSENameEvent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSECityDir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEStages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEMinimumAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSECtnTickets = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEPriceEvent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEimgDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gbEventMenu = New System.Windows.Forms.GroupBox()
        Me.btnEditEvents = New System.Windows.Forms.Button()
        Me.btnAddDltGroupToEvent = New System.Windows.Forms.Button()
        Me.btnAddEvent = New System.Windows.Forms.Button()
        Me.gcGroupMenu = New System.Windows.Forms.GroupBox()
        Me.btnEditGroups = New System.Windows.Forms.Button()
        Me.btnDeleteGroup = New System.Windows.Forms.Button()
        Me.btnNewGroup = New System.Windows.Forms.Button()
        Me.btnReembolso = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        Me.btnEventsHistorys = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TBoxEventName = New System.Windows.Forms.TextBox()
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.msUser.SuspendLayout()
        CType(Me.dgvShowEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEventMenu.SuspendLayout()
        Me.gcGroupMenu.SuspendLayout()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSellTickets
        '
        Me.btnSellTickets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSellTickets.BackColor = System.Drawing.SystemColors.Control
        Me.btnSellTickets.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSellTickets.Location = New System.Drawing.Point(23, 510)
        Me.btnSellTickets.Name = "btnSellTickets"
        Me.btnSellTickets.Size = New System.Drawing.Size(142, 34)
        Me.btnSellTickets.TabIndex = 20
        Me.btnSellTickets.Text = "Venta de Entradas"
        Me.btnSellTickets.UseVisualStyleBackColor = True
        '
        'msUser
        '
        Me.msUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.msUser.Dock = System.Windows.Forms.DockStyle.None
        Me.msUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.msUser.Location = New System.Drawing.Point(0, 0)
        Me.msUser.Name = "msUser"
        Me.msUser.Size = New System.Drawing.Size(109, 24)
        Me.msUser.TabIndex = 16
        Me.msUser.Text = "msUser"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEventosToolStripMenuItem, Me.ModificarEventosToolStripMenuItem, Me.AdministracionDeParticipantesgruposToolStripMenuItem, Me.ToolStripSeparator1, Me.AgregarGruposToolStripMenuItem, Me.ModificarGruposToolStripMenuItem, Me.EliminarGruposToolStripMenuItem, Me.ToolStripSeparator2, Me.HistorialDeEventosToolStripMenuItem, Me.VentaDeEntradasToolStripMenuItem, Me.ToolStripSeparator3, Me.ConfiguraciónToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'AgregarEventosToolStripMenuItem
        '
        Me.AgregarEventosToolStripMenuItem.Name = "AgregarEventosToolStripMenuItem"
        Me.AgregarEventosToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.AgregarEventosToolStripMenuItem.Text = "Agregar eventos"
        '
        'ModificarEventosToolStripMenuItem
        '
        Me.ModificarEventosToolStripMenuItem.Name = "ModificarEventosToolStripMenuItem"
        Me.ModificarEventosToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.ModificarEventosToolStripMenuItem.Text = "Modificar eventos"
        '
        'AdministracionDeParticipantesgruposToolStripMenuItem
        '
        Me.AdministracionDeParticipantesgruposToolStripMenuItem.Name = "AdministracionDeParticipantesgruposToolStripMenuItem"
        Me.AdministracionDeParticipantesgruposToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.AdministracionDeParticipantesgruposToolStripMenuItem.Text = "Administracion de participantes (grupos)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(287, 6)
        '
        'AgregarGruposToolStripMenuItem
        '
        Me.AgregarGruposToolStripMenuItem.Name = "AgregarGruposToolStripMenuItem"
        Me.AgregarGruposToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.AgregarGruposToolStripMenuItem.Text = "Agregar grupos"
        '
        'ModificarGruposToolStripMenuItem
        '
        Me.ModificarGruposToolStripMenuItem.Name = "ModificarGruposToolStripMenuItem"
        Me.ModificarGruposToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.ModificarGruposToolStripMenuItem.Text = "Modificar grupos"
        '
        'EliminarGruposToolStripMenuItem
        '
        Me.EliminarGruposToolStripMenuItem.Name = "EliminarGruposToolStripMenuItem"
        Me.EliminarGruposToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.EliminarGruposToolStripMenuItem.Text = "Eliminar grupos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(287, 6)
        '
        'HistorialDeEventosToolStripMenuItem
        '
        Me.HistorialDeEventosToolStripMenuItem.Name = "HistorialDeEventosToolStripMenuItem"
        Me.HistorialDeEventosToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.HistorialDeEventosToolStripMenuItem.Text = "Historial de eventos"
        '
        'VentaDeEntradasToolStripMenuItem
        '
        Me.VentaDeEntradasToolStripMenuItem.Name = "VentaDeEntradasToolStripMenuItem"
        Me.VentaDeEntradasToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.VentaDeEntradasToolStripMenuItem.Text = "Venta de entradas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(287, 6)
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'dgvShowEvents
        '
        Me.dgvShowEvents.AllowUserToAddRows = False
        Me.dgvShowEvents.AllowUserToDeleteRows = False
        Me.dgvShowEvents.AllowUserToResizeColumns = False
        Me.dgvShowEvents.AllowUserToResizeRows = False
        Me.dgvShowEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowEvents.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowEvents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSEID, Me.dgvSENameEvent, Me.dgvSECityDir, Me.dgvSEDateStr, Me.dgvSEStages, Me.dgvSEMinimumAge, Me.dgvSECtnTickets, Me.dgvSEPriceEvent, Me.dgvSEimgDelete})
        Me.dgvShowEvents.Location = New System.Drawing.Point(185, 42)
        Me.dgvShowEvents.Name = "dgvShowEvents"
        Me.dgvShowEvents.ReadOnly = True
        Me.dgvShowEvents.RowHeadersVisible = False
        Me.dgvShowEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowEvents.Size = New System.Drawing.Size(1040, 500)
        Me.dgvShowEvents.TabIndex = 17
        '
        'dgvSEID
        '
        Me.dgvSEID.HeaderText = "Identificación"
        Me.dgvSEID.Name = "dgvSEID"
        Me.dgvSEID.ReadOnly = True
        '
        'dgvSENameEvent
        '
        Me.dgvSENameEvent.HeaderText = "Nombre del evento"
        Me.dgvSENameEvent.Name = "dgvSENameEvent"
        Me.dgvSENameEvent.ReadOnly = True
        '
        'dgvSECityDir
        '
        Me.dgvSECityDir.HeaderText = "Ciudad y dirección"
        Me.dgvSECityDir.Name = "dgvSECityDir"
        Me.dgvSECityDir.ReadOnly = True
        '
        'dgvSEDateStr
        '
        Me.dgvSEDateStr.HeaderText = "Fecha inicial-final"
        Me.dgvSEDateStr.Name = "dgvSEDateStr"
        Me.dgvSEDateStr.ReadOnly = True
        '
        'dgvSEStages
        '
        Me.dgvSEStages.HeaderText = "N° de Palcos"
        Me.dgvSEStages.Name = "dgvSEStages"
        Me.dgvSEStages.ReadOnly = True
        '
        'dgvSEMinimumAge
        '
        Me.dgvSEMinimumAge.HeaderText = "Edad mínima"
        Me.dgvSEMinimumAge.Name = "dgvSEMinimumAge"
        Me.dgvSEMinimumAge.ReadOnly = True
        '
        'dgvSECtnTickets
        '
        Me.dgvSECtnTickets.HeaderText = "Entradas disponibles"
        Me.dgvSECtnTickets.Name = "dgvSECtnTickets"
        Me.dgvSECtnTickets.ReadOnly = True
        '
        'dgvSEPriceEvent
        '
        Me.dgvSEPriceEvent.HeaderText = "Precio"
        Me.dgvSEPriceEvent.Name = "dgvSEPriceEvent"
        Me.dgvSEPriceEvent.ReadOnly = True
        '
        'dgvSEimgDelete
        '
        Me.dgvSEimgDelete.HeaderText = "Eliminar evento"
        Me.dgvSEimgDelete.Image = Global.ForUTU.My.Resources.Resources.baseline_delete_forever_black_18dp
        Me.dgvSEimgDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.dgvSEimgDelete.Name = "dgvSEimgDelete"
        Me.dgvSEimgDelete.ReadOnly = True
        Me.dgvSEimgDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSEimgDelete.ToolTipText = "Haz clic para eliminar este evento"
        '
        'gbEventMenu
        '
        Me.gbEventMenu.Controls.Add(Me.btnEditEvents)
        Me.gbEventMenu.Controls.Add(Me.btnAddDltGroupToEvent)
        Me.gbEventMenu.Controls.Add(Me.btnAddEvent)
        Me.gbEventMenu.Location = New System.Drawing.Point(12, 42)
        Me.gbEventMenu.Name = "gbEventMenu"
        Me.gbEventMenu.Size = New System.Drawing.Size(167, 148)
        Me.gbEventMenu.TabIndex = 18
        Me.gbEventMenu.TabStop = False
        Me.gbEventMenu.Text = "Eventos"
        '
        'btnEditEvents
        '
        Me.btnEditEvents.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditEvents.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnEditEvents.Location = New System.Drawing.Point(11, 58)
        Me.btnEditEvents.Name = "btnEditEvents"
        Me.btnEditEvents.Size = New System.Drawing.Size(142, 34)
        Me.btnEditEvents.TabIndex = 18
        Me.btnEditEvents.Text = "Modificar eventos"
        Me.btnEditEvents.UseVisualStyleBackColor = True
        '
        'btnAddDltGroupToEvent
        '
        Me.btnAddDltGroupToEvent.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddDltGroupToEvent.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnAddDltGroupToEvent.Location = New System.Drawing.Point(11, 98)
        Me.btnAddDltGroupToEvent.Name = "btnAddDltGroupToEvent"
        Me.btnAddDltGroupToEvent.Size = New System.Drawing.Size(142, 34)
        Me.btnAddDltGroupToEvent.TabIndex = 16
        Me.btnAddDltGroupToEvent.Text = "Administración de participantes (grupos)"
        Me.btnAddDltGroupToEvent.UseVisualStyleBackColor = True
        '
        'btnAddEvent
        '
        Me.btnAddEvent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddEvent.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAddEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEvent.Location = New System.Drawing.Point(11, 21)
        Me.btnAddEvent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(142, 34)
        Me.btnAddEvent.TabIndex = 15
        Me.btnAddEvent.Text = "Agregar eventos"
        Me.btnAddEvent.UseVisualStyleBackColor = True
        '
        'gcGroupMenu
        '
        Me.gcGroupMenu.Controls.Add(Me.btnEditGroups)
        Me.gcGroupMenu.Controls.Add(Me.btnDeleteGroup)
        Me.gcGroupMenu.Controls.Add(Me.btnNewGroup)
        Me.gcGroupMenu.Location = New System.Drawing.Point(12, 196)
        Me.gcGroupMenu.Name = "gcGroupMenu"
        Me.gcGroupMenu.Size = New System.Drawing.Size(167, 150)
        Me.gcGroupMenu.TabIndex = 19
        Me.gcGroupMenu.TabStop = False
        Me.gcGroupMenu.Text = "Grupos"
        '
        'btnEditGroups
        '
        Me.btnEditGroups.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditGroups.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnEditGroups.Location = New System.Drawing.Point(11, 61)
        Me.btnEditGroups.Name = "btnEditGroups"
        Me.btnEditGroups.Size = New System.Drawing.Size(142, 34)
        Me.btnEditGroups.TabIndex = 20
        Me.btnEditGroups.Text = "Modificar grupos"
        Me.btnEditGroups.UseVisualStyleBackColor = True
        '
        'btnDeleteGroup
        '
        Me.btnDeleteGroup.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeleteGroup.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnDeleteGroup.Location = New System.Drawing.Point(11, 101)
        Me.btnDeleteGroup.Name = "btnDeleteGroup"
        Me.btnDeleteGroup.Size = New System.Drawing.Size(142, 34)
        Me.btnDeleteGroup.TabIndex = 19
        Me.btnDeleteGroup.Text = "Eliminar grupos"
        Me.btnDeleteGroup.UseVisualStyleBackColor = True
        '
        'btnNewGroup
        '
        Me.btnNewGroup.BackColor = System.Drawing.SystemColors.Control
        Me.btnNewGroup.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnNewGroup.Location = New System.Drawing.Point(11, 21)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(142, 34)
        Me.btnNewGroup.TabIndex = 18
        Me.btnNewGroup.Text = "Agregar grupos"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'btnReembolso
        '
        Me.btnReembolso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReembolso.BackColor = System.Drawing.SystemColors.Control
        Me.btnReembolso.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnReembolso.Location = New System.Drawing.Point(23, 470)
        Me.btnReembolso.Name = "btnReembolso"
        Me.btnReembolso.Size = New System.Drawing.Size(142, 34)
        Me.btnReembolso.TabIndex = 22
        Me.btnReembolso.Text = "Reembolso"
        Me.btnReembolso.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Acciones"
        Me.DataGridViewImageColumn1.Image = Global.ForUTU.My.Resources.Resources.baseline_clear_black_18dp
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Haz clic para eliminar este evento"
        Me.DataGridViewImageColumn1.Width = 106
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = Global.ForUTU.My.Resources.Resources.baseline_help_outline_black_18dp
        Me.btnHelp.Location = New System.Drawing.Point(1200, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(25, 25)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.TabIndex = 21
        Me.btnHelp.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Image = Global.ForUTU.My.Resources.Resources.baseline_settings_black_18dp
        Me.btnSettings.Location = New System.Drawing.Point(1169, 11)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(25, 25)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSettings.TabIndex = 20
        Me.btnSettings.TabStop = False
        '
        'btnEventsHistorys
        '
        Me.btnEventsHistorys.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEventsHistorys.BackColor = System.Drawing.SystemColors.Control
        Me.btnEventsHistorys.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnEventsHistorys.Location = New System.Drawing.Point(23, 430)
        Me.btnEventsHistorys.Name = "btnEventsHistorys"
        Me.btnEventsHistorys.Size = New System.Drawing.Size(142, 34)
        Me.btnEventsHistorys.TabIndex = 23
        Me.btnEventsHistorys.Text = "Filtrar eventos"
        Me.btnEventsHistorys.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TBoxEventName)
        Me.Panel1.Location = New System.Drawing.Point(185, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 28)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 1)
        Me.Panel2.TabIndex = 29
        '
        'TBoxEventName
        '
        Me.TBoxEventName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBoxEventName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBoxEventName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TBoxEventName.Location = New System.Drawing.Point(3, 8)
        Me.TBoxEventName.Name = "TBoxEventName"
        Me.TBoxEventName.Size = New System.Drawing.Size(972, 16)
        Me.TBoxEventName.TabIndex = 24
        Me.TBoxEventName.Text = "Escriba el nombre del evento"
        '
        'lblNoData
        '
        Me.lblNoData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblNoData.AutoSize = True
        Me.lblNoData.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoData.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoData.Location = New System.Drawing.Point(563, 300)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(284, 25)
        Me.lblNoData.TabIndex = 30
        Me.lblNoData.Text = "No se han encontrado datos"
        Me.lblNoData.Visible = False
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1237, 555)
        Me.Controls.Add(Me.lblNoData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEventsHistorys)
        Me.Controls.Add(Me.btnReembolso)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.gcGroupMenu)
        Me.Controls.Add(Me.gbEventMenu)
        Me.Controls.Add(Me.dgvShowEvents)
        Me.Controls.Add(Me.btnSellTickets)
        Me.Controls.Add(Me.msUser)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msUser
        Me.Name = "StartMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio - {nombre de la empresa} [V&R]"
        Me.msUser.ResumeLayout(False)
        Me.msUser.PerformLayout()
        CType(Me.dgvShowEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEventMenu.ResumeLayout(False)
        Me.gcGroupMenu.ResumeLayout(False)
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSellTickets As Button
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents msUser As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvShowEvents As DataGridView
    Friend WithEvents gbEventMenu As GroupBox
    Friend WithEvents btnAddDltGroupToEvent As Button
    Friend WithEvents gcGroupMenu As GroupBox
    Friend WithEvents btnDeleteGroup As Button
    Friend WithEvents btnNewGroup As Button
    Friend WithEvents btnSettings As PictureBox
    Friend WithEvents btnHelp As PictureBox
    Friend WithEvents btnEditEvents As Button
    Friend WithEvents btnEditGroups As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents AgregarEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionDeParticipantesgruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AgregarGruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarGruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarGruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HistorialDeEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaDeEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvSEID As DataGridViewTextBoxColumn
    Friend WithEvents dgvSENameEvent As DataGridViewTextBoxColumn
    Friend WithEvents dgvSECityDir As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateStr As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEStages As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEMinimumAge As DataGridViewTextBoxColumn
    Friend WithEvents dgvSECtnTickets As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEPriceEvent As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEimgDelete As DataGridViewImageColumn
    Friend WithEvents btnReembolso As Button
    Friend WithEvents btnEventsHistorys As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TBoxEventName As TextBox
    Friend WithEvents lblNoData As Label
End Class
