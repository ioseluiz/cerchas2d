Imports FontAwesome.Sharp
Public Class Principal

    'Campos
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    'Metodos de la Clase
    Private Sub ActivarBoton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DesactivarBoton()
            'Boton
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(101, 97, 118)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'Cambiar el icono de la barra superior al icono del IconButton actual
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DesactivarBoton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(101, 97, 118)
            currentBtn.ForeColor = Color.FromArgb(248, 251, 255)
            currentBtn.IconColor = Color.FromArgb(248, 251, 255)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If

    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
    End Sub

    Private Sub btnNodos_Click(sender As Object, e As EventArgs) Handles btnNodos.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
    End Sub

    Private Sub btnElementos_Click(sender As Object, e As EventArgs) Handles btnElementos.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
    End Sub

    Private Sub btnFuerzas_Click(sender As Object, e As EventArgs) Handles btnFuerzas.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
    End Sub
End Class
