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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNoData = New System.Windows.Forms.Label()
        CType(Me.dgvSSells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.TBoxCiClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBoxCiClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBoxCiClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TBoxCiClient.Location = New System.Drawing.Point(3, 6)
        Me.TBoxCiClient.MaxLength = 8
        Me.TBoxCiClient.Name = "TBoxCiClient"
        Me.TBoxCiClient.Size = New System.Drawing.Size(618, 16)
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
        Me.dgvSSells.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSSells.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSSells.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSEID, Me.dgvSENameEvent, Me.dgvSECityDir, Me.dgvSEDateStr, Me.dgvSEDateEnd, Me.dgvSSPrice, Me.dgvSEimgDelete})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSSells.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSSells.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Reembolsar entrada"
        Me.DataGridViewImageColumn1.Image = Global.ForUTU.My.Resources.Resources.baseline_delete_forever_black_18dp
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Haz clic para eliminar este evento"
        Me.DataGridViewImageColumn1.Width = 121
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TBoxCiClient)
        Me.Panel1.Location = New System.Drawing.Point(204, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 26)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 1)
        Me.Panel2.TabIndex = 28
        '
        'lblNoData
        '
        Me.lblNoData.AutoSize = True
        Me.lblNoData.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoData.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoData.Location = New System.Drawing.Point(314, 224)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(284, 25)
        Me.lblNoData.TabIndex = 28
        Me.lblNoData.Text = "No se han encontrado datos"
        Me.lblNoData.Visible = False
        '
        'reembolso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 450)
        Me.Controls.Add(Me.lblNoData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.dgvSSells)
        Me.Controls.Add(Me.cbSlcEvents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "reembolso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reembolsar entradas"
        CType(Me.dgvSSells, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNoData As Label
End Class
