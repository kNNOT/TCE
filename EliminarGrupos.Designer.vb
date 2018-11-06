<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteGroups
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvShowGroups = New System.Windows.Forms.DataGridView()
        Me.dgvSEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSENameEvent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSECityDir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEimgDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TBoxgroupName = New System.Windows.Forms.TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.MsgModal = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvShowGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShowGroups.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvShowGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSEID, Me.dgvSENameEvent, Me.dgvSECityDir, Me.dgvSEDateStr, Me.dgvSEDateEnd, Me.dgvSEimgDelete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShowGroups.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvShowGroups.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dgvShowGroups.Location = New System.Drawing.Point(12, 46)
        Me.dgvShowGroups.Name = "dgvShowGroups"
        Me.dgvShowGroups.ReadOnly = True
        Me.dgvShowGroups.RowHeadersVisible = False
        Me.dgvShowGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowGroups.Size = New System.Drawing.Size(813, 425)
        Me.dgvShowGroups.TabIndex = 23
        '
        'dgvSEID
        '
        Me.dgvSEID.HeaderText = "Identificación"
        Me.dgvSEID.Name = "dgvSEID"
        Me.dgvSEID.ReadOnly = True
        '
        'dgvSENameEvent
        '
        Me.dgvSENameEvent.HeaderText = "Nombre del grupo"
        Me.dgvSENameEvent.Name = "dgvSENameEvent"
        Me.dgvSENameEvent.ReadOnly = True
        '
        'dgvSECityDir
        '
        Me.dgvSECityDir.HeaderText = "Fecha de creación"
        Me.dgvSECityDir.Name = "dgvSECityDir"
        Me.dgvSECityDir.ReadOnly = True
        '
        'dgvSEDateStr
        '
        Me.dgvSEDateStr.HeaderText = "Género musical"
        Me.dgvSEDateStr.Name = "dgvSEDateStr"
        Me.dgvSEDateStr.ReadOnly = True
        '
        'dgvSEDateEnd
        '
        Me.dgvSEDateEnd.HeaderText = "Cantidad de miembros"
        Me.dgvSEDateEnd.Name = "dgvSEDateEnd"
        Me.dgvSEDateEnd.ReadOnly = True
        '
        'dgvSEimgDelete
        '
        Me.dgvSEimgDelete.HeaderText = "Eliminar grupo"
        Me.dgvSEimgDelete.Image = Global.ForUTU.My.Resources.Resources.baseline_delete_forever_black_18dp
        Me.dgvSEimgDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.dgvSEimgDelete.Name = "dgvSEimgDelete"
        Me.dgvSEimgDelete.ReadOnly = True
        Me.dgvSEimgDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSEimgDelete.ToolTipText = "Haz clic para eliminar este evento"
        '
        'TBoxgroupName
        '
        Me.TBoxgroupName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBoxgroupName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBoxgroupName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TBoxgroupName.Location = New System.Drawing.Point(3, 8)
        Me.TBoxgroupName.Name = "TBoxgroupName"
        Me.TBoxgroupName.Size = New System.Drawing.Size(776, 16)
        Me.TBoxgroupName.TabIndex = 24
        Me.TBoxgroupName.Text = "Escriba el nombre del grupo"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar grupo"
        Me.DataGridViewImageColumn1.Image = Global.ForUTU.My.Resources.Resources.baseline_clear_RED_18dp_24
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Haz clic para eliminar este grupo"
        Me.DataGridViewImageColumn1.Width = 135
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = Global.ForUTU.My.Resources.Resources.baseline_help_outline_black_18dp
        Me.btnHelp.Location = New System.Drawing.Point(800, 13)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(25, 25)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.TabIndex = 22
        Me.btnHelp.TabStop = False
        '
        'lblNoData
        '
        Me.lblNoData.AutoSize = True
        Me.lblNoData.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblNoData.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNoData.Location = New System.Drawing.Point(284, 245)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(284, 25)
        Me.lblNoData.TabIndex = 27
        Me.lblNoData.Text = "No se han encontrado datos"
        Me.lblNoData.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TBoxgroupName)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 28)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 1)
        Me.Panel2.TabIndex = 29
        '
        'DeleteGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(837, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblNoData)
        Me.Controls.Add(Me.dgvShowGroups)
        Me.Controls.Add(Me.btnHelp)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DeleteGroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar grupos"
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHelp As PictureBox
    Friend WithEvents dgvShowGroups As DataGridView
    Friend WithEvents TBoxgroupName As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents dgvSEID As DataGridViewTextBoxColumn
    Friend WithEvents dgvSENameEvent As DataGridViewTextBoxColumn
    Friend WithEvents dgvSECityDir As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateStr As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateEnd As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEimgDelete As DataGridViewImageColumn
    Friend WithEvents MsgModal As ToolTip
    Friend WithEvents lblNoData As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
