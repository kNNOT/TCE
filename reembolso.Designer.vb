<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reembolso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbSlcEvents = New System.Windows.Forms.ComboBox()
        Me.TBoxCiClient = New System.Windows.Forms.TextBox()
        Me.dgvSSells = New System.Windows.Forms.DataGridView()
        Me.dgvSEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSENameEvent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSECityDir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSSPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEimgDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        CType(Me.dgvSSells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSlcEvents
        '
        Me.cbSlcEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSlcEvents.FormattingEnabled = True
        Me.cbSlcEvents.Items.AddRange(New Object() {"---Seleccione un evento---"})
        Me.cbSlcEvents.Location = New System.Drawing.Point(12, 12)
        Me.cbSlcEvents.Name = "cbSlcEvents"
        Me.cbSlcEvents.Size = New System.Drawing.Size(186, 21)
        Me.cbSlcEvents.TabIndex = 0
        '
        'TBoxCiClient
        '
        Me.TBoxCiClient.Location = New System.Drawing.Point(205, 12)
        Me.TBoxCiClient.Name = "TBoxCiClient"
        Me.TBoxCiClient.Size = New System.Drawing.Size(154, 20)
        Me.TBoxCiClient.TabIndex = 1
        Me.TBoxCiClient.Text = "Introduzca la cédula del cliente"
        '
        'dgvSSells
        '
        Me.dgvSSells.AllowUserToAddRows = False
        Me.dgvSSells.AllowUserToDeleteRows = False
        Me.dgvSSells.AllowUserToResizeColumns = False
        Me.dgvSSells.AllowUserToResizeRows = False
        Me.dgvSSells.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSSells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSSells.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSSells.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSSells.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSEID, Me.dgvSENameEvent, Me.dgvSECityDir, Me.dgvSEDateStr, Me.dgvSEDateEnd, Me.dgvSSPrice, Me.dgvSEimgDelete})
        Me.dgvSSells.Location = New System.Drawing.Point(12, 39)
        Me.dgvSSells.Name = "dgvSSells"
        Me.dgvSSells.ReadOnly = True
        Me.dgvSSells.RowHeadersVisible = False
        Me.dgvSSells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSSells.Size = New System.Drawing.Size(847, 399)
        Me.dgvSSells.TabIndex = 24
        '
        'dgvSEID
        '
        Me.dgvSEID.HeaderText = "Id. Ticket"
        Me.dgvSEID.Name = "dgvSEID"
        Me.dgvSEID.ReadOnly = True
        '
        'dgvSENameEvent
        '
        Me.dgvSENameEvent.HeaderText = "Id. Evento"
        Me.dgvSENameEvent.Name = "dgvSENameEvent"
        Me.dgvSENameEvent.ReadOnly = True
        '
        'dgvSECityDir
        '
        Me.dgvSECityDir.HeaderText = "CI del Cliente"
        Me.dgvSECityDir.Name = "dgvSECityDir"
        Me.dgvSECityDir.ReadOnly = True
        '
        'dgvSEDateStr
        '
        Me.dgvSEDateStr.HeaderText = "Entradas vendidas"
        Me.dgvSEDateStr.Name = "dgvSEDateStr"
        Me.dgvSEDateStr.ReadOnly = True
        '
        'dgvSEDateEnd
        '
        Me.dgvSEDateEnd.HeaderText = "Tipo de entrada"
        Me.dgvSEDateEnd.Name = "dgvSEDateEnd"
        Me.dgvSEDateEnd.ReadOnly = True
        '
        'dgvSSPrice
        '
        Me.dgvSSPrice.HeaderText = "Precio total"
        Me.dgvSSPrice.Name = "dgvSSPrice"
        Me.dgvSSPrice.ReadOnly = True
        '
        'dgvSEimgDelete
        '
        Me.dgvSEimgDelete.HeaderText = "Reembolsar entrada"
        Me.dgvSEimgDelete.Image = Global.ForUTU.My.Resources.Resources.baseline_delete_forever_black_18dp
        Me.dgvSEimgDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.dgvSEimgDelete.Name = "dgvSEimgDelete"
        Me.dgvSEimgDelete.ReadOnly = True
        Me.dgvSEimgDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSEimgDelete.ToolTipText = "Haz clic para eliminar este evento"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ForUTU.My.Resources.Resources.baseline_help_outline_black_18dp
        Me.btnHelp.Location = New System.Drawing.Point(834, 7)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(25, 25)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.TabIndex = 26
        Me.btnHelp.TabStop = False
        '
        'reembolso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 450)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.dgvSSells)
        Me.Controls.Add(Me.TBoxCiClient)
        Me.Controls.Add(Me.cbSlcEvents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "reembolso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reembolsar entradas"
        CType(Me.dgvSSells, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSlcEvents As ComboBox
    Friend WithEvents TBoxCiClient As TextBox
    Friend WithEvents dgvSSells As DataGridView
    Friend WithEvents dgvSEID As DataGridViewTextBoxColumn
    Friend WithEvents dgvSENameEvent As DataGridViewTextBoxColumn
    Friend WithEvents dgvSECityDir As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateStr As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateEnd As DataGridViewTextBoxColumn
    Friend WithEvents dgvSSPrice As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEimgDelete As DataGridViewImageColumn
    Friend WithEvents btnHelp As PictureBox
End Class
