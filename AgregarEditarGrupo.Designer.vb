<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addorEditGroup
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
        Me.layoutNewGroup = New System.Windows.Forms.Panel()
        Me.btnAddGroup = New System.Windows.Forms.Button()
        Me.TBoxMembersCnt = New System.Windows.Forms.TextBox()
        Me.cbMusicalGenre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mTBoxCreationData = New System.Windows.Forms.MaskedTextBox()
        Me.TBoxGroupName = New System.Windows.Forms.TextBox()
        Me.cbSlcGroup = New System.Windows.Forms.ComboBox()
        Me.layoutNewGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutNewGroup
        '
        Me.layoutNewGroup.Controls.Add(Me.btnAddGroup)
        Me.layoutNewGroup.Controls.Add(Me.TBoxMembersCnt)
        Me.layoutNewGroup.Controls.Add(Me.cbMusicalGenre)
        Me.layoutNewGroup.Controls.Add(Me.Label1)
        Me.layoutNewGroup.Controls.Add(Me.mTBoxCreationData)
        Me.layoutNewGroup.Controls.Add(Me.TBoxGroupName)
        Me.layoutNewGroup.Location = New System.Drawing.Point(-2, -3)
        Me.layoutNewGroup.Name = "layoutNewGroup"
        Me.layoutNewGroup.Size = New System.Drawing.Size(251, 198)
        Me.layoutNewGroup.TabIndex = 0
        '
        'btnAddGroup
        '
        Me.btnAddGroup.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAddGroup.Location = New System.Drawing.Point(72, 135)
        Me.btnAddGroup.Name = "btnAddGroup"
        Me.btnAddGroup.Size = New System.Drawing.Size(109, 30)
        Me.btnAddGroup.TabIndex = 18
        Me.btnAddGroup.Text = "Agregar grupo"
        Me.btnAddGroup.UseVisualStyleBackColor = True
        '
        'TBoxMembersCnt
        '
        Me.TBoxMembersCnt.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TBoxMembersCnt.Location = New System.Drawing.Point(24, 95)
        Me.TBoxMembersCnt.MaxLength = 2
        Me.TBoxMembersCnt.Name = "TBoxMembersCnt"
        Me.TBoxMembersCnt.Size = New System.Drawing.Size(202, 21)
        Me.TBoxMembersCnt.TabIndex = 17
        Me.TBoxMembersCnt.Text = "Escribe el número de integrantes"
        Me.TBoxMembersCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbMusicalGenre
        '
        Me.cbMusicalGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMusicalGenre.FormattingEnabled = True
        Me.cbMusicalGenre.Items.AddRange(New Object() {"---Seleccione el genero musical---", "Cumbia", "Danza", "Electronica", "Folklore", "Funk", "Hip-Hop", "Metal", "Murga", "New Age", "Trap", "Pagode", "Rap", "Reggaeton", "Rock", "Pop", "Samba"})
        Me.cbMusicalGenre.Location = New System.Drawing.Point(24, 67)
        Me.cbMusicalGenre.Name = "cbMusicalGenre"
        Me.cbMusicalGenre.Size = New System.Drawing.Size(202, 22)
        Me.cbMusicalGenre.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha de creación:"
        '
        'mTBoxCreationData
        '
        Me.mTBoxCreationData.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxCreationData.Location = New System.Drawing.Point(127, 38)
        Me.mTBoxCreationData.Mask = "00/00/0000"
        Me.mTBoxCreationData.Name = "mTBoxCreationData"
        Me.mTBoxCreationData.Size = New System.Drawing.Size(70, 23)
        Me.mTBoxCreationData.TabIndex = 14
        Me.mTBoxCreationData.ValidatingType = GetType(Date)
        '
        'TBoxGroupName
        '
        Me.TBoxGroupName.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TBoxGroupName.Location = New System.Drawing.Point(24, 12)
        Me.TBoxGroupName.MaxLength = 300
        Me.TBoxGroupName.Name = "TBoxGroupName"
        Me.TBoxGroupName.Size = New System.Drawing.Size(202, 21)
        Me.TBoxGroupName.TabIndex = 13
        Me.TBoxGroupName.Text = "Escriba el nombre del grupo"
        Me.TBoxGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbSlcGroup
        '
        Me.cbSlcGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSlcGroup.FormattingEnabled = True
        Me.cbSlcGroup.Items.AddRange(New Object() {"---Seleccione un grupo---"})
        Me.cbSlcGroup.Location = New System.Drawing.Point(22, 4)
        Me.cbSlcGroup.Name = "cbSlcGroup"
        Me.cbSlcGroup.Size = New System.Drawing.Size(202, 22)
        Me.cbSlcGroup.TabIndex = 19
        Me.cbSlcGroup.Visible = False
        '
        'addorEditGroup
        '
        Me.AcceptButton = Me.btnAddGroup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 191)
        Me.Controls.Add(Me.cbSlcGroup)
        Me.Controls.Add(Me.layoutNewGroup)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addorEditGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar grupo"
        Me.layoutNewGroup.ResumeLayout(False)
        Me.layoutNewGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutNewGroup As Panel
    Friend WithEvents btnAddGroup As Button
    Friend WithEvents TBoxMembersCnt As TextBox
    Friend WithEvents cbMusicalGenre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mTBoxCreationData As MaskedTextBox
    Friend WithEvents TBoxGroupName As TextBox
    Friend WithEvents cbSlcGroup As ComboBox
End Class
