<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sellTickets
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
        Me.layout = New System.Windows.Forms.Panel()
        Me.lblAvailableTickets = New System.Windows.Forms.Label()
        Me.nudTicketsNmbr = New System.Windows.Forms.NumericUpDown()
        Me.gbClientInfo = New System.Windows.Forms.GroupBox()
        Me.TBoxClientAge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBoxClientIdentification = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBoxClientSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBoxClientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCountTickets = New System.Windows.Forms.Label()
        Me.lblShowTotalPrice = New System.Windows.Forms.Label()
        Me.btnCcrtSell = New System.Windows.Forms.Button()
        Me.TBoxAditionalValue = New System.Windows.Forms.TextBox()
        Me.lblAditionalValue = New System.Windows.Forms.Label()
        Me.CBSlcTEntrada = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBSlcEvent = New System.Windows.Forms.ComboBox()
        Me.layout.SuspendLayout()
        CType(Me.nudTicketsNmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClientInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'layout
        '
        Me.layout.Controls.Add(Me.lblAvailableTickets)
        Me.layout.Controls.Add(Me.nudTicketsNmbr)
        Me.layout.Controls.Add(Me.gbClientInfo)
        Me.layout.Controls.Add(Me.lblCountTickets)
        Me.layout.Controls.Add(Me.lblShowTotalPrice)
        Me.layout.Controls.Add(Me.btnCcrtSell)
        Me.layout.Location = New System.Drawing.Point(-4, 68)
        Me.layout.Name = "layout"
        Me.layout.Size = New System.Drawing.Size(321, 229)
        Me.layout.TabIndex = 0
        '
        'lblAvailableTickets
        '
        Me.lblAvailableTickets.AutoSize = True
        Me.lblAvailableTickets.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblAvailableTickets.Location = New System.Drawing.Point(171, 14)
        Me.lblAvailableTickets.Name = "lblAvailableTickets"
        Me.lblAvailableTickets.Size = New System.Drawing.Size(110, 14)
        Me.lblAvailableTickets.TabIndex = 27
        Me.lblAvailableTickets.Text = "Entradas disponibles:"
        '
        'nudTicketsNmbr
        '
        Me.nudTicketsNmbr.Enabled = False
        Me.nudTicketsNmbr.Location = New System.Drawing.Point(129, 10)
        Me.nudTicketsNmbr.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTicketsNmbr.Name = "nudTicketsNmbr"
        Me.nudTicketsNmbr.Size = New System.Drawing.Size(36, 20)
        Me.nudTicketsNmbr.TabIndex = 26
        Me.nudTicketsNmbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'gbClientInfo
        '
        Me.gbClientInfo.Controls.Add(Me.TBoxClientAge)
        Me.gbClientInfo.Controls.Add(Me.Label6)
        Me.gbClientInfo.Controls.Add(Me.TBoxClientIdentification)
        Me.gbClientInfo.Controls.Add(Me.Label5)
        Me.gbClientInfo.Controls.Add(Me.TBoxClientSurname)
        Me.gbClientInfo.Controls.Add(Me.Label4)
        Me.gbClientInfo.Controls.Add(Me.TBoxClientName)
        Me.gbClientInfo.Controls.Add(Me.Label3)
        Me.gbClientInfo.Enabled = False
        Me.gbClientInfo.Location = New System.Drawing.Point(10, 43)
        Me.gbClientInfo.Name = "gbClientInfo"
        Me.gbClientInfo.Size = New System.Drawing.Size(303, 135)
        Me.gbClientInfo.TabIndex = 16
        Me.gbClientInfo.TabStop = False
        Me.gbClientInfo.Text = "Datos del Cliente"
        '
        'TBoxClientAge
        '
        Me.TBoxClientAge.Location = New System.Drawing.Point(64, 105)
        Me.TBoxClientAge.MaxLength = 2
        Me.TBoxClientAge.Name = "TBoxClientAge"
        Me.TBoxClientAge.Size = New System.Drawing.Size(233, 20)
        Me.TBoxClientAge.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Edad:"
        '
        'TBoxClientIdentification
        '
        Me.TBoxClientIdentification.Location = New System.Drawing.Point(64, 19)
        Me.TBoxClientIdentification.MaxLength = 8
        Me.TBoxClientIdentification.Name = "TBoxClientIdentification"
        Me.TBoxClientIdentification.Size = New System.Drawing.Size(233, 20)
        Me.TBoxClientIdentification.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "C.I :"
        '
        'TBoxClientSurname
        '
        Me.TBoxClientSurname.Location = New System.Drawing.Point(63, 76)
        Me.TBoxClientSurname.MaxLength = 300
        Me.TBoxClientSurname.Name = "TBoxClientSurname"
        Me.TBoxClientSurname.Size = New System.Drawing.Size(234, 20)
        Me.TBoxClientSurname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellido:"
        '
        'TBoxClientName
        '
        Me.TBoxClientName.Location = New System.Drawing.Point(63, 47)
        Me.TBoxClientName.MaxLength = 300
        Me.TBoxClientName.Name = "TBoxClientName"
        Me.TBoxClientName.Size = New System.Drawing.Size(234, 20)
        Me.TBoxClientName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'lblCountTickets
        '
        Me.lblCountTickets.AutoSize = True
        Me.lblCountTickets.Location = New System.Drawing.Point(10, 13)
        Me.lblCountTickets.Name = "lblCountTickets"
        Me.lblCountTickets.Size = New System.Drawing.Size(113, 14)
        Me.lblCountTickets.TabIndex = 20
        Me.lblCountTickets.Text = "Cantidad de entradas:"
        '
        'lblShowTotalPrice
        '
        Me.lblShowTotalPrice.AutoSize = True
        Me.lblShowTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblShowTotalPrice.Location = New System.Drawing.Point(14, 192)
        Me.lblShowTotalPrice.Name = "lblShowTotalPrice"
        Me.lblShowTotalPrice.Size = New System.Drawing.Size(37, 15)
        Me.lblShowTotalPrice.TabIndex = 23
        Me.lblShowTotalPrice.Text = "Total:"
        '
        'btnCcrtSell
        '
        Me.btnCcrtSell.Enabled = False
        Me.btnCcrtSell.Location = New System.Drawing.Point(104, 184)
        Me.btnCcrtSell.Name = "btnCcrtSell"
        Me.btnCcrtSell.Size = New System.Drawing.Size(126, 32)
        Me.btnCcrtSell.TabIndex = 24
        Me.btnCcrtSell.Text = "Concretar Venta"
        Me.btnCcrtSell.UseVisualStyleBackColor = True
        '
        'TBoxAditionalValue
        '
        Me.TBoxAditionalValue.Location = New System.Drawing.Point(119, 78)
        Me.TBoxAditionalValue.MaxLength = 4
        Me.TBoxAditionalValue.Name = "TBoxAditionalValue"
        Me.TBoxAditionalValue.Size = New System.Drawing.Size(184, 20)
        Me.TBoxAditionalValue.TabIndex = 29
        Me.TBoxAditionalValue.Visible = False
        '
        'lblAditionalValue
        '
        Me.lblAditionalValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblAditionalValue.AutoSize = True
        Me.lblAditionalValue.Location = New System.Drawing.Point(33, 81)
        Me.lblAditionalValue.Name = "lblAditionalValue"
        Me.lblAditionalValue.Size = New System.Drawing.Size(80, 14)
        Me.lblAditionalValue.TabIndex = 34
        Me.lblAditionalValue.Text = "Valor adicional:"
        Me.lblAditionalValue.Visible = False
        '
        'CBSlcTEntrada
        '
        Me.CBSlcTEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSlcTEntrada.Enabled = False
        Me.CBSlcTEntrada.FormattingEnabled = True
        Me.CBSlcTEntrada.Items.AddRange(New Object() {"---Seleccione un Tipo de Entrada---", "Normal", "VIP"})
        Me.CBSlcTEntrada.Location = New System.Drawing.Point(119, 44)
        Me.CBSlcTEntrada.Name = "CBSlcTEntrada"
        Me.CBSlcTEntrada.Size = New System.Drawing.Size(184, 22)
        Me.CBSlcTEntrada.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tipo de Entrada:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 14)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Seleccionar Evento:"
        '
        'CBSlcEvent
        '
        Me.CBSlcEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSlcEvent.FormattingEnabled = True
        Me.CBSlcEvent.Items.AddRange(New Object() {"---Seleccione un Evento---"})
        Me.CBSlcEvent.Location = New System.Drawing.Point(119, 12)
        Me.CBSlcEvent.Name = "CBSlcEvent"
        Me.CBSlcEvent.Size = New System.Drawing.Size(184, 22)
        Me.CBSlcEvent.TabIndex = 30
        '
        'sellTickets
        '
        Me.AcceptButton = Me.btnCcrtSell
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(315, 294)
        Me.Controls.Add(Me.TBoxAditionalValue)
        Me.Controls.Add(Me.lblAditionalValue)
        Me.Controls.Add(Me.CBSlcTEntrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBSlcEvent)
        Me.Controls.Add(Me.layout)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sellTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de entradas"
        Me.layout.ResumeLayout(False)
        Me.layout.PerformLayout()
        CType(Me.nudTicketsNmbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClientInfo.ResumeLayout(False)
        Me.gbClientInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents layout As Panel
    Friend WithEvents gbClientInfo As GroupBox
    Friend WithEvents TBoxClientAge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBoxClientIdentification As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBoxClientSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBoxClientName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCountTickets As Label
    Friend WithEvents lblShowTotalPrice As Label
    Friend WithEvents btnCcrtSell As Button
    Friend WithEvents nudTicketsNmbr As NumericUpDown
    Friend WithEvents lblAvailableTickets As Label
    Friend WithEvents TBoxAditionalValue As TextBox
    Friend WithEvents lblAditionalValue As Label
    Friend WithEvents CBSlcTEntrada As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBSlcEvent As ComboBox
End Class
