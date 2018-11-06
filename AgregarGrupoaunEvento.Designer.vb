<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addGroupsToEvent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAddGroups = New System.Windows.Forms.GroupBox()
        Me.nudStageNum = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddGroupToEvent = New System.Windows.Forms.Button()
        Me.mTBoxAtuationHour = New System.Windows.Forms.MaskedTextBox()
        Me.mTBoxActuationDate = New System.Windows.Forms.MaskedTextBox()
        Me.CBSlcGroups = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDlteGroups = New System.Windows.Forms.GroupBox()
        Me.dgvShowEventGroups = New System.Windows.Forms.DataGridView()
        Me.dgvSEGID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAGTEDateActuation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAGTEHourActiation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEGStage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBSlcEvents = New System.Windows.Forms.ComboBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.dgvSEGbtnDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gbAddGroups.SuspendLayout()
        CType(Me.nudStageNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDlteGroups.SuspendLayout()
        CType(Me.dgvShowEventGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar Evento:"
        '
        'gbAddGroups
        '
        Me.gbAddGroups.Controls.Add(Me.nudStageNum)
        Me.gbAddGroups.Controls.Add(Me.Label3)
        Me.gbAddGroups.Controls.Add(Me.btnAddGroupToEvent)
        Me.gbAddGroups.Controls.Add(Me.mTBoxAtuationHour)
        Me.gbAddGroups.Controls.Add(Me.mTBoxActuationDate)
        Me.gbAddGroups.Controls.Add(Me.CBSlcGroups)
        Me.gbAddGroups.Controls.Add(Me.Label8)
        Me.gbAddGroups.Controls.Add(Me.Label7)
        Me.gbAddGroups.Controls.Add(Me.Label2)
        Me.gbAddGroups.Enabled = False
        Me.gbAddGroups.Location = New System.Drawing.Point(12, 37)
        Me.gbAddGroups.Name = "gbAddGroups"
        Me.gbAddGroups.Size = New System.Drawing.Size(499, 83)
        Me.gbAddGroups.TabIndex = 0
        Me.gbAddGroups.TabStop = False
        Me.gbAddGroups.Text = "Agregar Grupos"
        '
        'nudStageNum
        '
        Me.nudStageNum.Location = New System.Drawing.Point(334, 53)
        Me.nudStageNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStageNum.Name = "nudStageNum"
        Me.nudStageNum.Size = New System.Drawing.Size(38, 20)
        Me.nudStageNum.TabIndex = 19
        Me.nudStageNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "N° Palco:"
        '
        'btnAddGroupToEvent
        '
        Me.btnAddGroupToEvent.Location = New System.Drawing.Point(378, 50)
        Me.btnAddGroupToEvent.Name = "btnAddGroupToEvent"
        Me.btnAddGroupToEvent.Size = New System.Drawing.Size(117, 25)
        Me.btnAddGroupToEvent.TabIndex = 17
        Me.btnAddGroupToEvent.Text = "Agregar grupo"
        Me.btnAddGroupToEvent.UseVisualStyleBackColor = True
        '
        'mTBoxAtuationHour
        '
        Me.mTBoxAtuationHour.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxAtuationHour.Location = New System.Drawing.Point(231, 50)
        Me.mTBoxAtuationHour.Mask = "00:00"
        Me.mTBoxAtuationHour.Name = "mTBoxAtuationHour"
        Me.mTBoxAtuationHour.Size = New System.Drawing.Size(40, 23)
        Me.mTBoxAtuationHour.TabIndex = 16
        Me.mTBoxAtuationHour.ValidatingType = GetType(Date)
        '
        'mTBoxActuationDate
        '
        Me.mTBoxActuationDate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxActuationDate.Location = New System.Drawing.Point(116, 50)
        Me.mTBoxActuationDate.Mask = "00/00/0000"
        Me.mTBoxActuationDate.Name = "mTBoxActuationDate"
        Me.mTBoxActuationDate.Size = New System.Drawing.Size(70, 23)
        Me.mTBoxActuationDate.TabIndex = 15
        Me.mTBoxActuationDate.ValidatingType = GetType(Date)
        '
        'CBSlcGroups
        '
        Me.CBSlcGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSlcGroups.FormattingEnabled = True
        Me.CBSlcGroups.Items.AddRange(New Object() {"---Seleccione un grupo---"})
        Me.CBSlcGroups.Location = New System.Drawing.Point(116, 22)
        Me.CBSlcGroups.Name = "CBSlcGroups"
        Me.CBSlcGroups.Size = New System.Drawing.Size(375, 22)
        Me.CBSlcGroups.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Hora:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha de actuación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Seleccionar Grupo:"
        '
        'gbDlteGroups
        '
        Me.gbDlteGroups.Controls.Add(Me.dgvShowEventGroups)
        Me.gbDlteGroups.Enabled = False
        Me.gbDlteGroups.Location = New System.Drawing.Point(12, 126)
        Me.gbDlteGroups.Name = "gbDlteGroups"
        Me.gbDlteGroups.Size = New System.Drawing.Size(499, 301)
        Me.gbDlteGroups.TabIndex = 0
        Me.gbDlteGroups.TabStop = False
        Me.gbDlteGroups.Text = "Eliminar Grupos"
        '
        'dgvShowEventGroups
        '
        Me.dgvShowEventGroups.AllowUserToAddRows = False
        Me.dgvShowEventGroups.AllowUserToDeleteRows = False
        Me.dgvShowEventGroups.AllowUserToResizeColumns = False
        Me.dgvShowEventGroups.AllowUserToResizeRows = False
        Me.dgvShowEventGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShowEventGroups.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShowEventGroups.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowEventGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowEventGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSEGID, Me.dgvAGTEDateActuation, Me.dgvAGTEHourActiation, Me.dgvSEGStage, Me.dgvSEGbtnDelete})
        Me.dgvShowEventGroups.Location = New System.Drawing.Point(6, 20)
        Me.dgvShowEventGroups.Name = "dgvShowEventGroups"
        Me.dgvShowEventGroups.ReadOnly = True
        Me.dgvShowEventGroups.RowHeadersVisible = False
        Me.dgvShowEventGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowEventGroups.Size = New System.Drawing.Size(485, 275)
        Me.dgvShowEventGroups.TabIndex = 0
        Me.dgvShowEventGroups.TabStop = False
        '
        'dgvSEGID
        '
        Me.dgvSEGID.HeaderText = "ID Grupo"
        Me.dgvSEGID.Name = "dgvSEGID"
        Me.dgvSEGID.ReadOnly = True
        '
        'dgvAGTEDateActuation
        '
        Me.dgvAGTEDateActuation.HeaderText = "Fecha"
        Me.dgvAGTEDateActuation.Name = "dgvAGTEDateActuation"
        Me.dgvAGTEDateActuation.ReadOnly = True
        '
        'dgvAGTEHourActiation
        '
        Me.dgvAGTEHourActiation.HeaderText = "Hora"
        Me.dgvAGTEHourActiation.Name = "dgvAGTEHourActiation"
        Me.dgvAGTEHourActiation.ReadOnly = True
        '
        'dgvSEGStage
        '
        Me.dgvSEGStage.HeaderText = "N° Palco"
        Me.dgvSEGStage.Name = "dgvSEGStage"
        Me.dgvSEGStage.ReadOnly = True
        '
        'CBSlcEvents
        '
        Me.CBSlcEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSlcEvents.FormattingEnabled = True
        Me.CBSlcEvents.Items.AddRange(New Object() {"---Seleccione un evento---"})
        Me.CBSlcEvents.Location = New System.Drawing.Point(113, 8)
        Me.CBSlcEvents.Name = "CBSlcEvents"
        Me.CBSlcEvents.Size = New System.Drawing.Size(366, 22)
        Me.CBSlcEvents.TabIndex = 5
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar grupo"
        Me.DataGridViewImageColumn1.Image = Global.ForUTU.My.Resources.Resources.baseline_clear_RED_18dp_24
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 97
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ForUTU.My.Resources.Resources.baseline_help_outline_black_18dp
        Me.btnHelp.Location = New System.Drawing.Point(486, 8)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(25, 25)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.TabStop = False
        '
        'dgvSEGbtnDelete
        '
        Me.dgvSEGbtnDelete.HeaderText = "Eliminar grupo"
        Me.dgvSEGbtnDelete.Image = Global.ForUTU.My.Resources.Resources.baseline_delete_forever_black_18dp
        Me.dgvSEGbtnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.dgvSEGbtnDelete.Name = "dgvSEGbtnDelete"
        Me.dgvSEGbtnDelete.ReadOnly = True
        Me.dgvSEGbtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSEGbtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'addGroupsToEvent
        '
        Me.AcceptButton = Me.btnAddGroupToEvent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(523, 439)
        Me.Controls.Add(Me.CBSlcEvents)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.gbDlteGroups)
        Me.Controls.Add(Me.gbAddGroups)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "addGroupsToEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de grupos de un evento"
        Me.gbAddGroups.ResumeLayout(False)
        Me.gbAddGroups.PerformLayout()
        CType(Me.nudStageNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDlteGroups.ResumeLayout(False)
        CType(Me.dgvShowEventGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbAddGroups As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbDlteGroups As GroupBox
    Friend WithEvents dgvShowEventGroups As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHelp As PictureBox
    Friend WithEvents CBSlcGroups As ComboBox
    Friend WithEvents CBSlcEvents As ComboBox
    Friend WithEvents btnAddGroupToEvent As Button
    Friend WithEvents mTBoxAtuationHour As MaskedTextBox
    Friend WithEvents mTBoxActuationDate As MaskedTextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents nudStageNum As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSEGID As DataGridViewTextBoxColumn
    Friend WithEvents dgvAGTEDateActuation As DataGridViewTextBoxColumn
    Friend WithEvents dgvAGTEHourActiation As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEGStage As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEGbtnDelete As DataGridViewImageColumn
End Class
