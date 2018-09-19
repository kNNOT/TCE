﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteGroups
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
        Me.dgvShowGroups = New System.Windows.Forms.DataGridView()
        Me.dgvSEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSENameEvent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSECityDir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEDateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSEimgDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TBoxgroupName = New System.Windows.Forms.TextBox()
        Me.btnSearchGroup = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnRestoreList = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestoreList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvShowGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvSEID, Me.dgvSENameEvent, Me.dgvSECityDir, Me.dgvSEDateStr, Me.dgvSEDateEnd, Me.dgvSEimgDelete})
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
        Me.TBoxgroupName.Location = New System.Drawing.Point(13, 13)
        Me.TBoxgroupName.Name = "TBoxgroupName"
        Me.TBoxgroupName.Size = New System.Drawing.Size(237, 20)
        Me.TBoxgroupName.TabIndex = 24
        Me.TBoxgroupName.Text = "Escriba el nombre del grupo"
        '
        'btnSearchGroup
        '
        Me.btnSearchGroup.Location = New System.Drawing.Point(257, 12)
        Me.btnSearchGroup.Name = "btnSearchGroup"
        Me.btnSearchGroup.Size = New System.Drawing.Size(75, 25)
        Me.btnSearchGroup.TabIndex = 25
        Me.btnSearchGroup.Text = "Buscar"
        Me.btnSearchGroup.UseVisualStyleBackColor = True
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
        'btnRestoreList
        '
        Me.btnRestoreList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestoreList.Image = Global.ForUTU.My.Resources.Resources.baseline_history_black_18dp
        Me.btnRestoreList.Location = New System.Drawing.Point(338, 12)
        Me.btnRestoreList.Name = "btnRestoreList"
        Me.btnRestoreList.Size = New System.Drawing.Size(25, 25)
        Me.btnRestoreList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRestoreList.TabIndex = 26
        Me.btnRestoreList.TabStop = False
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
        'DeleteGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(837, 485)
        Me.Controls.Add(Me.btnRestoreList)
        Me.Controls.Add(Me.btnSearchGroup)
        Me.Controls.Add(Me.TBoxgroupName)
        Me.Controls.Add(Me.dgvShowGroups)
        Me.Controls.Add(Me.btnHelp)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DeleteGroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar grupos"
        CType(Me.dgvShowGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestoreList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHelp As PictureBox
    Friend WithEvents dgvShowGroups As DataGridView
    Friend WithEvents TBoxgroupName As TextBox
    Friend WithEvents btnSearchGroup As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnRestoreList As PictureBox
    Friend WithEvents dgvSEID As DataGridViewTextBoxColumn
    Friend WithEvents dgvSENameEvent As DataGridViewTextBoxColumn
    Friend WithEvents dgvSECityDir As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateStr As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEDateEnd As DataGridViewTextBoxColumn
    Friend WithEvents dgvSEimgDelete As DataGridViewImageColumn
End Class
