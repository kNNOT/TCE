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
        Me.dgvShowGroupsHE = New System.Windows.Forms.DataGridView()
        Me.dgvSHEventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbSlcGroup = New System.Windows.Forms.ComboBox()
        Me.tabHistoryEvents = New System.Windows.Forms.TabControl()
        Me.tabHistoryGroups = New System.Windows.Forms.TabPage()
        Me.tabHistoryDate = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.tabHistoryClient = New System.Windows.Forms.TabPage()
        Me.dgvShowClientsGoE = New System.Windows.Forms.DataGridView()
        Me.cbSlcEvent = New System.Windows.Forms.ComboBox()
        Me.tabShowGroups = New System.Windows.Forms.TabPage()
        Me.dgvShowGroups = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabShowClients = New System.Windows.Forms.TabPage()
        Me.dgvShowClients = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistoryEvents.SuspendLayout()
        Me.tabHistoryGroups.SuspendLayout()
        Me.tabHistoryDate.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabHistoryClient.SuspendLayout()
        CType(Me.dgvShowClientsGoE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShowGroups.SuspendLayout()
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShowClients.SuspendLayout()
        CType(Me.dgvShowClients, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvShowGroupsHE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowGroupsHE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSHEventName})
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
        Me.tabHistoryGroups.Controls.Add(Me.dgvShowGroupsHE)
        Me.tabHistoryGroups.Controls.Add(Me.cbSlcGroup)
        Me.tabHistoryGroups.Location = New System.Drawing.Point(4, 23)
        Me.tabHistoryGroups.Name = "tabHistoryGroups"
        Me.tabHistoryGroups.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistoryGroups.Size = New System.Drawing.Size(452, 451)
        Me.tabHistoryGroups.TabIndex = 0
        Me.tabHistoryGroups.Text = "Historial por grupo"
        Me.tabHistoryGroups.UseVisualStyleBackColor = True
        '
        'tabHistoryDate
        '
        Me.tabHistoryDate.Controls.Add(Me.Label1)
        Me.tabHistoryDate.Controls.Add(Me.Panel3)
        Me.tabHistoryDate.Controls.Add(Me.DataGridView1)
        Me.tabHistoryDate.Controls.Add(Me.Panel1)
        Me.tabHistoryDate.Location = New System.Drawing.Point(4, 23)
        Me.tabHistoryDate.Name = "tabHistoryDate"
        Me.tabHistoryDate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistoryDate.Size = New System.Drawing.Size(452, 451)
        Me.tabHistoryDate.TabIndex = 1
        Me.tabHistoryDate.Text = "Historial por fecha"
        Me.tabHistoryDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "-"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.MaskedTextBox2)
        Me.Panel3.Location = New System.Drawing.Point(240, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(206, 24)
        Me.Panel3.TabIndex = 2
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
        Me.Panel4.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(206, 1)
        Me.Panel4.TabIndex = 1
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaskedTextBox2.Location = New System.Drawing.Point(93, 3)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(60, 16)
        Me.MaskedTextBox2.TabIndex = 0
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(446, 415)
        Me.DataGridView1.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre del evento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 24)
        Me.Panel1.TabIndex = 1
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
        Me.Panel2.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 1)
        Me.Panel2.TabIndex = 1
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(86, 3)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(70, 16)
        Me.MaskedTextBox1.TabIndex = 0
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'tabHistoryClient
        '
        Me.tabHistoryClient.Controls.Add(Me.dgvShowClientsGoE)
        Me.tabHistoryClient.Controls.Add(Me.cbSlcEvent)
        Me.tabHistoryClient.Location = New System.Drawing.Point(4, 23)
        Me.tabHistoryClient.Name = "tabHistoryClient"
        Me.tabHistoryClient.Size = New System.Drawing.Size(452, 451)
        Me.tabHistoryClient.TabIndex = 3
        Me.tabHistoryClient.Text = "Historial por clientes-show"
        Me.tabHistoryClient.UseVisualStyleBackColor = True
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
        Me.dgvShowClientsGoE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowClientsGoE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Column2})
        Me.dgvShowClientsGoE.Location = New System.Drawing.Point(6, 33)
        Me.dgvShowClientsGoE.Name = "dgvShowClientsGoE"
        Me.dgvShowClientsGoE.ReadOnly = True
        Me.dgvShowClientsGoE.RowHeadersVisible = False
        Me.dgvShowClientsGoE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowClientsGoE.Size = New System.Drawing.Size(440, 411)
        Me.dgvShowClientsGoE.TabIndex = 27
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
        Me.tabShowGroups.Controls.Add(Me.dgvShowGroups)
        Me.tabShowGroups.Location = New System.Drawing.Point(4, 23)
        Me.tabShowGroups.Name = "tabShowGroups"
        Me.tabShowGroups.Size = New System.Drawing.Size(452, 451)
        Me.tabShowGroups.TabIndex = 5
        Me.tabShowGroups.Text = "Grupos"
        Me.tabShowGroups.UseVisualStyleBackColor = True
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
        Me.dgvShowGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.dgvShowGroups.Location = New System.Drawing.Point(3, 3)
        Me.dgvShowGroups.Name = "dgvShowGroups"
        Me.dgvShowGroups.ReadOnly = True
        Me.dgvShowGroups.RowHeadersVisible = False
        Me.dgvShowGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowGroups.Size = New System.Drawing.Size(446, 444)
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
        Me.tabShowClients.Controls.Add(Me.dgvShowClients)
        Me.tabShowClients.Location = New System.Drawing.Point(4, 23)
        Me.tabShowClients.Name = "tabShowClients"
        Me.tabShowClients.Size = New System.Drawing.Size(452, 451)
        Me.tabShowClients.TabIndex = 4
        Me.tabShowClients.Text = "Clientes"
        Me.tabShowClients.UseVisualStyleBackColor = True
        '
        'dgvShowClients
        '
        Me.dgvShowClients.AllowUserToAddRows = False
        Me.dgvShowClients.AllowUserToDeleteRows = False
        Me.dgvShowClients.AllowUserToResizeColumns = False
        Me.dgvShowClients.AllowUserToResizeRows = False
        Me.dgvShowClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShowClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowClients.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn4, Me.Column4})
        Me.dgvShowClients.Location = New System.Drawing.Point(3, 3)
        Me.dgvShowClients.Name = "dgvShowClients"
        Me.dgvShowClients.ReadOnly = True
        Me.dgvShowClients.RowHeadersVisible = False
        Me.dgvShowClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowClients.Size = New System.Drawing.Size(446, 444)
        Me.dgvShowClients.TabIndex = 26
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
        Me.tabHistoryDate.ResumeLayout(False)
        Me.tabHistoryDate.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabHistoryClient.ResumeLayout(False)
        CType(Me.dgvShowClientsGoE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShowGroups.ResumeLayout(False)
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShowClients.ResumeLayout(False)
        CType(Me.dgvShowClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowGroupsHE As DataGridView
    Friend WithEvents cbSlcGroup As ComboBox
    Friend WithEvents dgvSHEventName As DataGridViewTextBoxColumn
    Friend WithEvents tabHistoryEvents As TabControl
    Friend WithEvents tabHistoryGroups As TabPage
    Friend WithEvents tabHistoryDate As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
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
    Friend WithEvents dgvShowClients As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
