<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addorEditEvent
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
        Me.layoutAddNewEvent = New System.Windows.Forms.Panel()
        Me.nudCtnEntradas = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddEvent = New System.Windows.Forms.Button()
        Me.TBoxEventPrice = New System.Windows.Forms.TextBox()
        Me.nudMinimumAge = New System.Windows.Forms.NumericUpDown()
        Me.nudStagesNumbers = New System.Windows.Forms.NumericUpDown()
        Me.mTBoxEndEventDate = New System.Windows.Forms.MaskedTextBox()
        Me.mTBoxStartEventDate = New System.Windows.Forms.MaskedTextBox()
        Me.TBoxEventDirec = New System.Windows.Forms.TextBox()
        Me.TBoxCityEvent = New System.Windows.Forms.TextBox()
        Me.TBoxEventName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.cbSlcEventToEdit = New System.Windows.Forms.ComboBox()
        Me.layoutAddNewEvent.SuspendLayout()
        CType(Me.nudCtnEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimumAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStagesNumbers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'layoutAddNewEvent
        '
        Me.layoutAddNewEvent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.layoutAddNewEvent.Controls.Add(Me.nudCtnEntradas)
        Me.layoutAddNewEvent.Controls.Add(Me.Label4)
        Me.layoutAddNewEvent.Controls.Add(Me.btnAddEvent)
        Me.layoutAddNewEvent.Controls.Add(Me.TBoxEventPrice)
        Me.layoutAddNewEvent.Controls.Add(Me.nudMinimumAge)
        Me.layoutAddNewEvent.Controls.Add(Me.nudStagesNumbers)
        Me.layoutAddNewEvent.Controls.Add(Me.mTBoxEndEventDate)
        Me.layoutAddNewEvent.Controls.Add(Me.mTBoxStartEventDate)
        Me.layoutAddNewEvent.Controls.Add(Me.TBoxEventDirec)
        Me.layoutAddNewEvent.Controls.Add(Me.TBoxCityEvent)
        Me.layoutAddNewEvent.Controls.Add(Me.TBoxEventName)
        Me.layoutAddNewEvent.Controls.Add(Me.Label3)
        Me.layoutAddNewEvent.Controls.Add(Me.Label10)
        Me.layoutAddNewEvent.Controls.Add(Me.Label9)
        Me.layoutAddNewEvent.Controls.Add(Me.Label8)
        Me.layoutAddNewEvent.Controls.Add(Me.Label7)
        Me.layoutAddNewEvent.Controls.Add(Me.Label6)
        Me.layoutAddNewEvent.Controls.Add(Me.Label2)
        Me.layoutAddNewEvent.Controls.Add(Me.Label1)
        Me.layoutAddNewEvent.Controls.Add(Me.btnHelp)
        Me.layoutAddNewEvent.Location = New System.Drawing.Point(-2, -1)
        Me.layoutAddNewEvent.Name = "layoutAddNewEvent"
        Me.layoutAddNewEvent.Size = New System.Drawing.Size(374, 223)
        Me.layoutAddNewEvent.TabIndex = 0
        '
        'nudCtnEntradas
        '
        Me.nudCtnEntradas.Location = New System.Drawing.Point(213, 94)
        Me.nudCtnEntradas.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudCtnEntradas.Name = "nudCtnEntradas"
        Me.nudCtnEntradas.Size = New System.Drawing.Size(82, 20)
        Me.nudCtnEntradas.TabIndex = 64
        Me.nudCtnEntradas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "N° Entradas:"
        '
        'btnAddEvent
        '
        Me.btnAddEvent.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAddEvent.Location = New System.Drawing.Point(138, 177)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(108, 30)
        Me.btnAddEvent.TabIndex = 62
        Me.btnAddEvent.Text = "Agregar evento"
        Me.btnAddEvent.UseVisualStyleBackColor = True
        '
        'TBoxEventPrice
        '
        Me.TBoxEventPrice.Location = New System.Drawing.Point(101, 141)
        Me.TBoxEventPrice.MaxLength = 7
        Me.TBoxEventPrice.Name = "TBoxEventPrice"
        Me.TBoxEventPrice.Size = New System.Drawing.Size(60, 20)
        Me.TBoxEventPrice.TabIndex = 61
        '
        'nudMinimumAge
        '
        Me.nudMinimumAge.Location = New System.Drawing.Point(101, 117)
        Me.nudMinimumAge.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMinimumAge.Name = "nudMinimumAge"
        Me.nudMinimumAge.Size = New System.Drawing.Size(33, 20)
        Me.nudMinimumAge.TabIndex = 60
        '
        'nudStagesNumbers
        '
        Me.nudStagesNumbers.Location = New System.Drawing.Point(101, 93)
        Me.nudStagesNumbers.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudStagesNumbers.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStagesNumbers.Name = "nudStagesNumbers"
        Me.nudStagesNumbers.Size = New System.Drawing.Size(33, 20)
        Me.nudStagesNumbers.TabIndex = 59
        Me.nudStagesNumbers.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'mTBoxEndEventDate
        '
        Me.mTBoxEndEventDate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxEndEventDate.Location = New System.Drawing.Point(250, 64)
        Me.mTBoxEndEventDate.Mask = "00/00/0000"
        Me.mTBoxEndEventDate.Name = "mTBoxEndEventDate"
        Me.mTBoxEndEventDate.Size = New System.Drawing.Size(70, 23)
        Me.mTBoxEndEventDate.TabIndex = 58
        Me.mTBoxEndEventDate.ValidatingType = GetType(Date)
        '
        'mTBoxStartEventDate
        '
        Me.mTBoxStartEventDate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mTBoxStartEventDate.Location = New System.Drawing.Point(101, 64)
        Me.mTBoxStartEventDate.Mask = "00/00/0000"
        Me.mTBoxStartEventDate.Name = "mTBoxStartEventDate"
        Me.mTBoxStartEventDate.Size = New System.Drawing.Size(70, 23)
        Me.mTBoxStartEventDate.TabIndex = 57
        Me.mTBoxStartEventDate.ValidatingType = GetType(Date)
        '
        'TBoxEventDirec
        '
        Me.TBoxEventDirec.Location = New System.Drawing.Point(238, 37)
        Me.TBoxEventDirec.MaxLength = 250
        Me.TBoxEventDirec.Name = "TBoxEventDirec"
        Me.TBoxEventDirec.Size = New System.Drawing.Size(124, 20)
        Me.TBoxEventDirec.TabIndex = 56
        '
        'TBoxCityEvent
        '
        Me.TBoxCityEvent.Location = New System.Drawing.Point(58, 37)
        Me.TBoxCityEvent.MaxLength = 100
        Me.TBoxCityEvent.Name = "TBoxCityEvent"
        Me.TBoxCityEvent.Size = New System.Drawing.Size(124, 20)
        Me.TBoxCityEvent.TabIndex = 55
        '
        'TBoxEventName
        '
        Me.TBoxEventName.Location = New System.Drawing.Point(58, 11)
        Me.TBoxEventName.MaxLength = 512
        Me.TBoxEventName.Name = "TBoxEventName"
        Me.TBoxEventName.Size = New System.Drawing.Size(304, 20)
        Me.TBoxEventName.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Precio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 14)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "N° Palcos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 14)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Ciudad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 14)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Fecha Final:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 14)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Fecha de Inicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Edad mínima:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nombre:"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ForUTU.My.Resources.Resources.baseline_help_outline_black_18dp
        Me.btnHelp.Location = New System.Drawing.Point(337, 182)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(25, 25)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.TabIndex = 45
        Me.btnHelp.TabStop = False
        '
        'cbSlcEventToEdit
        '
        Me.cbSlcEventToEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cbSlcEventToEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSlcEventToEdit.FormattingEnabled = True
        Me.cbSlcEventToEdit.Items.AddRange(New Object() {"---Seleccione un evento---"})
        Me.cbSlcEventToEdit.Location = New System.Drawing.Point(12, 6)
        Me.cbSlcEventToEdit.Name = "cbSlcEventToEdit"
        Me.cbSlcEventToEdit.Size = New System.Drawing.Size(348, 22)
        Me.cbSlcEventToEdit.TabIndex = 1
        Me.cbSlcEventToEdit.Visible = False
        '
        'addorEditEvent
        '
        Me.AcceptButton = Me.btnAddEvent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(369, 216)
        Me.Controls.Add(Me.cbSlcEventToEdit)
        Me.Controls.Add(Me.layoutAddNewEvent)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "addorEditEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo evento"
        Me.layoutAddNewEvent.ResumeLayout(False)
        Me.layoutAddNewEvent.PerformLayout()
        CType(Me.nudCtnEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimumAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStagesNumbers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutAddNewEvent As Panel
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents TBoxEventPrice As TextBox
    Friend WithEvents nudMinimumAge As NumericUpDown
    Friend WithEvents nudStagesNumbers As NumericUpDown
    Friend WithEvents mTBoxEndEventDate As MaskedTextBox
    Friend WithEvents mTBoxStartEventDate As MaskedTextBox
    Friend WithEvents TBoxEventDirec As TextBox
    Friend WithEvents TBoxCityEvent As TextBox
    Friend WithEvents TBoxEventName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHelp As PictureBox
    Friend WithEvents cbSlcEventToEdit As ComboBox
    Friend WithEvents nudCtnEntradas As NumericUpDown
    Friend WithEvents Label4 As Label
End Class
