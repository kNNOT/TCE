Public Class configuraciones
    Public Sub New()
        InitializeComponent()
        layoutServers.Parent = Me
        layoutGeneral.Parent = Me
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles btnGeneral.MouseEnter, imgBtnGeneral.MouseEnter, lblBtnGeneral.MouseEnter, btnServers.MouseEnter, btnTheme.MouseEnter, imgBtnServers.MouseEnter,
                                                                            imgBtnTheme.MouseEnter, lblBtnServers.MouseEnter, lblBtnTheme.MouseEnter, btnCloseOpc.MouseEnter, lblBtnCloseOpc.MouseEnter, imgBtnCloseOpc.MouseEnter,
                                                                            styleBtnCloseOpc.MouseEnter, btnApply.MouseEnter, imgBtnApply.MouseEnter, lblBtnApply.MouseEnter, btnApplyS.MouseEnter, lblBtnApplyS.MouseEnter, imgBtnApplyS.MouseEnter
        If sender.Equals(btnGeneral) Or sender.Equals(imgBtnGeneral) Or sender.Equals(lblBtnGeneral) Then
            btnGeneral.BackColor = styleBtnGeneral.BackColor
        ElseIf sender.Equals(btnServers) Or sender.Equals(imgBtnServers) Or sender.Equals(lblBtnServers) Then
            btnServers.BackColor = styleBtnServers.BackColor
        ElseIf sender.Equals(btnTheme) Or sender.Equals(imgBtnTheme) Or sender.Equals(lblBtnTheme) Then
            btnTheme.BackColor = styleBtnTheme.BackColor
        ElseIf sender.Equals(btnCloseOpc) Or sender.Equals(imgBtnCloseOpc) Or sender.Equals(lblBtnCloseOpc) Then
            btnCloseOpc.BackColor = Color.FromArgb(210, 210, 210)
        ElseIf sender.Equals(btnApply) Or sender.Equals(imgBtnApply) Or sender.Equals(lblBtnApply) Then
            btnApply.BackColor = Color.FromArgb(210, 210, 210)
        ElseIf sender.Equals(btnApplyS) Or sender.Equals(imgBtnApplyS) Or sender.Equals(lblBtnApplyS) Then
            btnApplyS.BackColor = Color.FromArgb(210, 210, 210)
        End If
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles btnGeneral.MouseLeave, btnServers.MouseLeave, btnTheme.MouseLeave, btnCloseOpc.MouseLeave, btnApply.MouseLeave, btnApplyS.MouseLeave
        If sender.Equals(btnGeneral) Then
            btnGeneral.BackColor = layoutMC.BackColor
        ElseIf sender.Equals(btnServers) Then
            btnServers.BackColor = layoutMC.BackColor
        ElseIf sender.Equals(btnTheme) Then
            btnTheme.BackColor = layoutMC.BackColor
        ElseIf sender.Equals(btnCloseOpc) Then
            btnCloseOpc.BackColor = layoutMC.BackColor
        ElseIf sender.Equals(btnApply) Then
            btnApply.BackColor = layoutServers.BackColor
        ElseIf sender.Equals(btnApplyS) Then
            btnApplyS.BackColor = layoutGeneral.BackColor
        End If
    End Sub

    Private Sub btnCloseClic(sender As Object, e As EventArgs) Handles imgTopScreen.Click
        Close()
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles imgTopScreen.MouseEnter
        imgTopScreen.BackColor = Color.FromArgb(210, 210, 210)
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles imgTopScreen.MouseLeave
        imgTopScreen.BackColor = layouTopScreen.BackColor
    End Sub

    Private Sub btnServersClic(sender As Object, e As EventArgs) Handles btnServers.Click, styleBtnServers.Click, imgBtnServers.Click, lblBtnServers.Click
        layoutServers.Visible = True
        layoutGeneral.Visible = False
        layoutThemes.Visible = False
        btnCloseOpc.Visible = True
    End Sub

    Private Sub btnGeneralClic(sender As Object, e As EventArgs) Handles btnGeneral.Click, styleBtnGeneral.Click, imgBtnGeneral.Click, lblBtnGeneral.Click
        layoutGeneral.Visible = True
        layoutServers.Visible = False
        layoutThemes.Visible = False
        btnCloseOpc.Visible = True
    End Sub

    Private Sub btnCloseOpcClic(sender As Object, e As EventArgs) Handles btnCloseOpc.Click, styleBtnCloseOpc.Click, imgBtnCloseOpc.Click, lblBtnCloseOpc.Click
        layoutGeneral.Visible = False
        layoutServers.Visible = False
        layoutThemes.Visible = False
        btnCloseOpc.Visible = False
    End Sub

    Private Sub HScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar1.ValueChanged
        TextBox7.Text = HScrollBar1.Value
        PictureBox5.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
    End Sub

    Private Sub btnThemeClic(sender As Object, e As EventArgs) Handles btnTheme.Click, imgBtnTheme.Click, styleBtnTheme.Click, lblBtnTheme.Click
        layoutGeneral.Visible = False
        layoutServers.Visible = False
        layoutThemes.Visible = True
        btnCloseOpc.Visible = True
    End Sub

    Private Sub configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Size = New Size(167, 522)
    End Sub
End Class