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
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.btnMoreInformation = New System.Windows.Forms.Button()
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvShowGroupsHE.Location = New System.Drawing.Point(12, 48)
        Me.dgvShowGroupsHE.Name = "dgvShowGroupsHE"
        Me.dgvShowGroupsHE.ReadOnly = True
        Me.dgvShowGroupsHE.RowHeadersVisible = False
        Me.dgvShowGroupsHE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowGroupsHE.Size = New System.Drawing.Size(390, 403)
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
        Me.cbSlcGroup.Location = New System.Drawing.Point(13, 13)
        Me.cbSlcGroup.Name = "cbSlcGroup"
        Me.cbSlcGroup.Size = New System.Drawing.Size(359, 22)
        Me.cbSlcGroup.TabIndex = 25
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = Global.ForUTU.My.Resources.Resources.baseline_help_outline_black_18dp
        Me.btnHelp.Location = New System.Drawing.Point(377, 10)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(25, 25)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.TabIndex = 26
        Me.btnHelp.TabStop = False
        '
        'btnMoreInformation
        '
        Me.btnMoreInformation.Location = New System.Drawing.Point(13, 455)
        Me.btnMoreInformation.Name = "btnMoreInformation"
        Me.btnMoreInformation.Size = New System.Drawing.Size(119, 23)
        Me.btnMoreInformation.TabIndex = 27
        Me.btnMoreInformation.Text = "Más información"
        Me.btnMoreInformation.UseVisualStyleBackColor = True
        '
        'EventsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(414, 485)
        Me.Controls.Add(Me.btnMoreInformation)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.cbSlcGroup)
        Me.Controls.Add(Me.dgvShowGroupsHE)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EventsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de eventos"
        CType(Me.dgvShowGroupsHE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowGroupsHE As DataGridView
    Friend WithEvents cbSlcGroup As ComboBox
    Friend WithEvents btnHelp As PictureBox
    Friend WithEvents dgvSHEventName As DataGridViewTextBoxColumn
    Friend WithEvents btnMoreInformation As Button
End Class
