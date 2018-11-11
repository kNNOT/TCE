<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventsHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvShowGroupsHE = New System.Windows.Forms.DataGridView()
        Me.dgvSHEventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbSlcGroup = New System.Windows.Forms.ComboBox()
        Me.tabHistoryEvents = New System.Windows.Forms.TabControl()
        Me.tabHistoryGroups = New System.Windows.Forms.TabPage()
        Me.lblNoDataHG = New System.Windows.Forms.Label()
        Me.tabHistoryDate = New System.Windows.Forms.TabPage()
        Me.lblNoDataHF = New System.Windows.Forms.Label()
        Me.btnSearchEventDate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mTBoxDateF = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvShowEventsPerDate = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mTBoxDateI = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabHistoryClient = New System.Windows.Forms.TabPage()
        Me.lblNoDataHCS = New System.Windows.Forms.Label()
        Me.dgvShowClientsGoE = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbSlcEvent = New System.Windows.Forms.ComboBox()
        Me.tabShowGroups = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TBoxGroupName = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblNoDataG = New System.Windows.Forms.Label()
        Me.dgvShowGroups = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabShowClients = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TBoxCiClient = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblNoDataC = New System.Windows.Forms.Label()
        Me.dgvShowaCli = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistoryEvents.SuspendLayout()
        Me.tabHistoryGroups.SuspendLayout()
        Me.tabHistoryDate.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvShowEventsPerDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabHistoryClient.SuspendLayout()
        CType(Me.dgvShowClientsGoE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShowGroups.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShowClients.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgvShowaCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShowGroupsHE
        '
        Me.dgvShowGroupsHE.AllowUserToAddRows = False
        Me.dgvShowGroupsHE.AllowUserToDeleteRows = False
        Me.dgvShowGroupsHE.AllowUserToResizeColumns = False
        Me.dgvShowGroupsHE.AllowUserToResizeRows = False
        Me.dgvShowGroupsHE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowGroupsHE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowGroupsHE.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowGroupsHE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowGroupsHE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShowGroupsHE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvShowGroupsHE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowGroupsHE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSHEventName})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShowGroupsHE.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvShowGroupsHE.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dgvShowGroupsHE.Location = New System.Drawing.Point(6, 34)
        Me.dgvShowGroupsHE.Name = "dgvShowGroupsHE"
        Me.dgvShowGroupsHE.ReadOnly = True
        Me.dgvShowGroupsHE.RowHeadersVisible = False
        Me.dgvShowGroupsHE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowGroupsHE.Size = New System.Drawing.Size(440, 411)
        Me.dgvShowGroupsHE.TabIndex = 24
        '
        'dgvSHEventName
        '
        Me.dgvSHEventName.HeaderText = "Nombre del evento"
        Me.dgvSHEventName.Name = "dgvSHEventName"
        Me.dgvSHEventName.ReadOnly = True
        '
        'cbSlcGroup
        '
        Me.cbSlcGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSlcGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSlcGroup.FormattingEnabled = True
        Me.cbSlcGroup.Items.AddRange(New Object() {"---Seleccione un grupo---"})
        Me.cbSlcGroup.Location = New System.Drawing.Point(6, 6)
        Me.cbSlcGroup.Name = "cbSlcGroup"
        Me.cbSlcGroup.Size = New System.Drawing.Size(440, 22)
        Me.cbSlcGroup.TabIndex = 25
        '
        'tabHistoryEvents
        '
        Me.tabHistoryEvents.Controls.Add(Me.tabHistoryGroups)
        Me.tabHistoryEvents.Controls.Add(Me.tabHistoryDate)
        Me.tabHistoryEvents.Controls.Add(Me.tabHistoryClient)
        Me.tabHistoryEvents.Controls.Add(Me.tabShowGroups)
        Me.tabHistoryEvents.Controls.Add(Me.tabShowClients)
        Me.tabHistoryEvents.Location = New System.Drawing.Point(6, 3)
        Me.tabHistoryEvents.Name = "tabHistoryEvents"
        Me.tabHistoryEvents.SelectedIndex = 0
        Me.tabHistoryEvents.Size = New System.Drawing.Size(460, 478)
        Me.tabHistoryEvents.TabIndex = 28
        '
        'tabHistoryGroups
        '
        Me.tabHistoryGroups.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabHistoryGroups.Controls.Add(Me.lblNoDataHG)
        Me.tabHistoryGroups.Controls.Add(Me.dgvShowGroupsHE)
        Me.tabHistoryGroups.Controls.Add(Me.cbSlcGroup)
        Me.tabHistoryGroups.Location = New System.Drawing.Point(4, 23)
        Me.tabHistoryGroups.Name = "tabHistoryGroups"
        Me.tabHistoryGroups.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistoryGroups.Size = New System.Drawing.Size(452, 451)
        Me.tabHistoryGroups.TabIndex = 0
        Me.tabHistoryGroups.Text = "Historial por grupo"
        '
        'lblNoDataHG
        '
        Me.lblNoDataHG.AutoSize = True
        Me.lblNoDataHG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoDataHG.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoDataHG.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoDataHG.Location = New System.Drawing.Point(86, 220)
        Me.lblNoDataHG.Name = "lblNoDataHG"
        Me.lblNoDataHG.Size = New System.Drawing.Size(284, 25)
        Me.lblNoDataHG.TabIndex = 28
        Me.lblNoDataHG.Text = "No se han encontrado datos"
        Me.lblNoDataHG.Visible = False
        '
        'tabHistoryDate
        '
        Me.tabHistoryDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabHistoryDate.Controls.Add(Me.lblNoDataHF)
        Me.tabHistoryDate.Controls.Add(Me.btnSearchEventDate)
        Me.tabHistoryDate.Controls.Add(Me.Label1)
        Me.tabHistoryDate.Controls.Add(Me.Panel3)
        Me.tabHistoryDate.Controls.Add(Me.dgvShowEventsPerDate)
        Me.tabHistoryDate.Controls.Add(Me.Panel1)
        Me.tabHistoryDate.Location = New System.Drawing.Point(4, 23)
        Me.tabHistoryDate.Name = "tabHistoryDate"
        Me.tabHistoryDate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistoryDate.Size = New System.Drawing.Size(452, 451)
        Me.tabHistoryDate.TabIndex = 1
        Me.tabHistoryDate.Text = "Historial por fecha"
        '
        'lblNoDataHF
        '
        Me.lblNoDataHF.AutoSize = True
        Me.lblNoDataHF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoDataHF.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoDataHF.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoDataHF.Location = New System.Drawing.Point(84, 235)
        Me.lblNoDataHF.Name = "lblNoDataHF"
        Me.lblNoDataHF.Size = New System.Drawing.Size(284, 25)
        Me.lblNoDataHF.TabIndex = 30
        Me.lblNoDataHF.Text = "No se han encontrado datos"
        Me.lblNoDataHF.Visible = False
        '
        'btnSearchEventDate
        '
        Me.btnSearchEventDate.Location = New System.Drawing.Point(354, 7)
        Me.btnSearchEventDate.Name = "btnSearchEventDate"
        Me.btnSearchEventDate.Size = New System.Drawing.Size(92, 23)
        Me.btnSearchEventDate.TabIndex = 27
        Me.btnSearchEventDate.Text = "Buscar"
        Me.btnSearchEventDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "-"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.mTBoxDateF)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(185, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(163, 24)
        Me.Panel3.TabIndex = 2
        '
        'mTBoxDateF
        '
        Me.mTBoxDateF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mTBoxDateF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mTBoxDateF.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxDateF.Location = New System.Drawing.Point(87, 4)
        Me.mTBoxDateF.Mask = "00/00/0000"
        Me.mTBoxDateF.Name = "mTBoxDateF"
        Me.mTBoxDateF.Size = New System.Drawing.Size(73, 16)
        Me.mTBoxDateF.TabIndex = 29
        Me.mTBoxDateF.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Segunda fecha:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(163, 1)
        Me.Panel4.TabIndex = 1
        '
        'dgvShowEventsPerDate
        '
        Me.dgvShowEventsPerDate.AllowUserToAddRows = False
        Me.dgvShowEventsPerDate.AllowUserToDeleteRows = False
        Me.dgvShowEventsPerDate.AllowUserToResizeColumns = False
        Me.dgvShowEventsPerDate.AllowUserToResizeRows = False
        Me.dgvShowEventsPerDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowEventsPerDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowEventsPerDate.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowEventsPerDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowEventsPerDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShowEventsPerDate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvShowEventsPerDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowEventsPerDate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShowEventsPerDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvShowEventsPerDate.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dgvShowEventsPerDate.Location = New System.Drawing.Point(3, 36)
        Me.dgvShowEventsPerDate.Name = "dgvShowEventsPerDate"
        Me.dgvShowEventsPerDate.ReadOnly = True
        Me.dgvShowEventsPerDate.RowHeadersVisible = False
        Me.dgvShowEventsPerDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowEventsPerDate.Size = New System.Drawing.Size(446, 415)
        Me.dgvShowEventsPerDate.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre del evento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.mTBoxDateI)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 24)
        Me.Panel1.TabIndex = 1
        '
        'mTBoxDateI
        '
        Me.mTBoxDateI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mTBoxDateI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mTBoxDateI.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxDateI.Location = New System.Drawing.Point(84, 4)
        Me.mTBoxDateI.Mask = "00/00/0000"
        Me.mTBoxDateI.Name = "mTBoxDateI"
        Me.mTBoxDateI.Size = New System.Drawing.Size(73, 16)
        Me.mTBoxDateI.TabIndex = 28
        Me.mTBoxDateI.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Primera fecha:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 1)
        Me.Panel2.TabIndex = 1
        '
        'tabHistoryClient
        '
        Me.tabHistoryClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabHistoryClient.Controls.Add(Me.lblNoDataHCS)
        Me.tabHistoryClient.Controls.Add(Me.dgvShowClientsGoE)
        Me.tabHistoryClient.Controls.Add(Me.cbSlcEvent)
        Me.tabHistoryClient.Location = New System.Drawing.Point(4, 23)
        Me.tabHistoryClient.Name = "tabHistoryClient"
        Me.tabHistoryClient.Size = New System.Drawing.Size(452, 451)
        Me.tabHistoryClient.TabIndex = 3
        Me.tabHistoryClient.Text = "Historial por clientes-show"
        '
        'lblNoDataHCS
        '
        Me.lblNoDataHCS.AutoSize = True
        Me.lblNoDataHCS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoDataHCS.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoDataHCS.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoDataHCS.Location = New System.Drawing.Point(87, 226)
        Me.lblNoDataHCS.Name = "lblNoDataHCS"
        Me.lblNoDataHCS.Size = New System.Drawing.Size(284, 25)
        Me.lblNoDataHCS.TabIndex = 30
        Me.lblNoDataHCS.Text = "No se han encontrado datos"
        Me.lblNoDataHCS.Visible = False
        '
        'dgvShowClientsGoE
        '
        Me.dgvShowClientsGoE.AllowUserToAddRows = False
        Me.dgvShowClientsGoE.AllowUserToDeleteRows = False
        Me.dgvShowClientsGoE.AllowUserToResizeColumns = False
        Me.dgvShowClientsGoE.AllowUserToResizeRows = False
        Me.dgvShowClientsGoE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowClientsGoE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowClientsGoE.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowClientsGoE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowClientsGoE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShowClientsGoE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvShowClientsGoE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowClientsGoE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Column2})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShowClientsGoE.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvShowClientsGoE.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dgvShowClientsGoE.Location = New System.Drawing.Point(6, 33)
        Me.dgvShowClientsGoE.Name = "dgvShowClientsGoE"
        Me.dgvShowClientsGoE.ReadOnly = True
        Me.dgvShowClientsGoE.RowHeadersVisible = False
        Me.dgvShowClientsGoE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowClientsGoE.Size = New System.Drawing.Size(440, 411)
        Me.dgvShowClientsGoE.TabIndex = 27
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Identificación del cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'cbSlcEvent
        '
        Me.cbSlcEvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSlcEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSlcEvent.FormattingEnabled = True
        Me.cbSlcEvent.Items.AddRange(New Object() {"---Seleccione un evento---"})
        Me.cbSlcEvent.Location = New System.Drawing.Point(6, 5)
        Me.cbSlcEvent.Name = "cbSlcEvent"
        Me.cbSlcEvent.Size = New System.Drawing.Size(440, 22)
        Me.cbSlcEvent.TabIndex = 26
        '
        'tabShowGroups
        '
        Me.tabShowGroups.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabShowGroups.Controls.Add(Me.Panel5)
        Me.tabShowGroups.Controls.Add(Me.lblNoDataG)
        Me.tabShowGroups.Controls.Add(Me.dgvShowGroups)
        Me.tabShowGroups.Location = New System.Drawing.Point(4, 23)
        Me.tabShowGroups.Name = "tabShowGroups"
        Me.tabShowGroups.Size = New System.Drawing.Size(452, 451)
        Me.tabShowGroups.TabIndex = 5
        Me.tabShowGroups.Text = "Grupos"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TBoxGroupName)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(443, 26)
        Me.Panel5.TabIndex = 32
        '
        'TBoxGroupName
        '
        Me.TBoxGroupName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBoxGroupName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBoxGroupName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TBoxGroupName.Location = New System.Drawing.Point(3, 4)
        Me.TBoxGroupName.Name = "TBoxGroupName"
        Me.TBoxGroupName.Size = New System.Drawing.Size(439, 16)
        Me.TBoxGroupName.TabIndex = 34
        Me.TBoxGroupName.Text = "Escriba el nombre del grupo"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(443, 1)
        Me.Panel6.TabIndex = 33
        '
        'lblNoDataG
        '
        Me.lblNoDataG.AutoSize = True
        Me.lblNoDataG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoDataG.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoDataG.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoDataG.Location = New System.Drawing.Point(84, 213)
        Me.lblNoDataG.Name = "lblNoDataG"
        Me.lblNoDataG.Size = New System.Drawing.Size(284, 25)
        Me.lblNoDataG.TabIndex = 31
        Me.lblNoDataG.Text = "No se han encontrado datos"
        Me.lblNoDataG.Visible = False
        '
        'dgvShowGroups
        '
        Me.dgvShowGroups.AllowUserToAddRows = False
        Me.dgvShowGroups.AllowUserToDeleteRows = False
        Me.dgvShowGroups.AllowUserToResizeColumns = False
        Me.dgvShowGroups.AllowUserToResizeRows = False
        Me.dgvShowGroups.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowGroups.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowGroups.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShowGroups.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvShowGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShowGroups.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvShowGroups.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dgvShowGroups.Location = New System.Drawing.Point(3, 35)
        Me.dgvShowGroups.Name = "dgvShowGroups"
        Me.dgvShowGroups.ReadOnly = True
        Me.dgvShowGroups.RowHeadersVisible = False
        Me.dgvShowGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowGroups.Size = New System.Drawing.Size(446, 412)
        Me.dgvShowGroups.TabIndex = 25
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre del grupo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'tabShowClients
        '
        Me.tabShowClients.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabShowClients.Controls.Add(Me.Panel7)
        Me.tabShowClients.Controls.Add(Me.lblNoDataC)
        Me.tabShowClients.Controls.Add(Me.dgvShowaCli)
        Me.tabShowClients.Location = New System.Drawing.Point(4, 23)
        Me.tabShowClients.Name = "tabShowClients"
        Me.tabShowClients.Size = New System.Drawing.Size(452, 451)
        Me.tabShowClients.TabIndex = 4
        Me.tabShowClients.Text = "Clientes"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TBoxCiClient)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(6, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(443, 26)
        Me.Panel7.TabIndex = 33
        '
        'TBoxCiClient
        '
        Me.TBoxCiClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBoxCiClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBoxCiClient.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TBoxCiClient.Location = New System.Drawing.Point(3, 4)
        Me.TBoxCiClient.Name = "TBoxCiClient"
        Me.TBoxCiClient.Size = New System.Drawing.Size(439, 16)
        Me.TBoxCiClient.TabIndex = 34
        Me.TBoxCiClient.Text = "Escriba la identificacion del cliente"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 25)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(443, 1)
        Me.Panel8.TabIndex = 33
        '
        'lblNoDataC
        '
        Me.lblNoDataC.AutoSize = True
        Me.lblNoDataC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoDataC.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoDataC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoDataC.Location = New System.Drawing.Point(84, 213)
        Me.lblNoDataC.Name = "lblNoDataC"
        Me.lblNoDataC.Size = New System.Drawing.Size(284, 25)
        Me.lblNoDataC.TabIndex = 31
        Me.lblNoDataC.Text = "No se han encontrado datos"
        Me.lblNoDataC.Visible = False
        '
        'dgvShowaCli
        '
        Me.dgvShowaCli.AllowUserToAddRows = False
        Me.dgvShowaCli.AllowUserToDeleteRows = False
        Me.dgvShowaCli.AllowUserToResizeColumns = False
        Me.dgvShowaCli.AllowUserToResizeRows = False
        Me.dgvShowaCli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowaCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowaCli.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowaCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowaCli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShowaCli.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvShowaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowaCli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn4, Me.Column4})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShowaCli.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvShowaCli.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dgvShowaCli.Location = New System.Drawing.Point(3, 35)
        Me.dgvShowaCli.Name = "dgvShowaCli"
        Me.dgvShowaCli.ReadOnly = True
        Me.dgvShowaCli.RowHeadersVisible = False
        Me.dgvShowaCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowaCli.Size = New System.Drawing.Size(446, 412)
        Me.dgvShowaCli.TabIndex = 26
        '
        'Column3
        '
        Me.Column3.HeaderText = "Identificación del cliente"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Apellido"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'EventsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(468, 485)
        Me.Controls.Add(Me.tabHistoryEvents)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EventsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrado de datos"
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistoryEvents.ResumeLayout(False)
        Me.tabHistoryGroups.ResumeLayout(False)
        Me.tabHistoryGroups.PerformLayout()
        Me.tabHistoryDate.ResumeLayout(False)
        Me.tabHistoryDate.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvShowEventsPerDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabHistoryClient.ResumeLayout(False)
        Me.tabHistoryClient.PerformLayout()
        CType(Me.dgvShowClientsGoE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShowGroups.ResumeLayout(False)
        Me.tabShowGroups.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShowClients.ResumeLayout(False)
        Me.tabShowClients.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dgvShowaCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowGroupsHE As DataGridView
    Friend WithEvents cbSlcGroup As ComboBox
    Friend WithEvents dgvSHEventName As DataGridViewTextBoxColumn
    Friend WithEvents tabHistoryEvents As TabControl
    Friend WithEvents tabHistoryGroups As TabPage
    Friend WithEvents tabHistoryDate As TabPage
    Friend WithEvents dgvShowEventsPerDate As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tabHistoryClient As TabPage
    Friend WithEvents tabShowGroups As TabPage
    Friend WithEvents tabShowClients As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvShowClientsGoE As DataGridView
    Friend WithEvents cbSlcEvent As ComboBox
    Friend WithEvents dgvShowGroups As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents dgvShowaCli As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearchEventDate As Button
    Friend WithEvents lblNoDataHG As Label
    Friend WithEvents lblNoDataHCS As Label
    Friend WithEvents lblNoDataG As Label
    Friend WithEvents lblNoDataC As Label
    Friend WithEvents lblNoDataHF As Label
    Friend WithEvents mTBoxDateF As MaskedTextBox
    Friend WithEvents mTBoxDateI As MaskedTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TBoxGroupName As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TBoxCiClient As TextBox
    Friend WithEvents Panel8 As Panel
End Class
