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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 478)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvShowGroupsHE)
        Me.TabPage1.Controls.Add(Me.cbSlcGroup)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HJistorial por grupo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial por fecha"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EventsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(468, 485)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EventsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrado de eventos"
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowGroupsHE As DataGridView
    Friend WithEvents cbSlcGroup As ComboBox
    Friend WithEvents dgvSHEventName As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
