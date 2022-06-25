Imports FontAwesome.Sharp
Public Class Principal

    Dim nodos As Integer, elementos As Integer

    Dim drawOptions As Integer = 0
    Dim pen1 As Pen

    'Campos
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Dim nodoId As Integer, _x As Double, _y As Double
    Dim elementoId As Integer, nodoInicio As Integer, nodoFinal As Integer, areaElem As Double, modElem As Double
    Dim vnodo() As Nodo, velemento() As Elemento, vcarga() As Carga, vrestriccion() As Restriccion

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

    Private Sub OpenChildForm(childForm As Form)
        'Abrir el Form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If
        currentChildForm = childForm
        Console.WriteLine(childForm.Text)
        'Fin
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
        OpenChildForm(FormDatos)

        pen1 = New Pen(Color.Black, 2.0)

        drawOptions = 1
        Invalidate()
    End Sub

    Private Sub btnNodos_Click(sender As Object, e As EventArgs) Handles btnNodos.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
        OpenChildForm(FormNodos)
    End Sub

    Private Sub btnElementos_Click(sender As Object, e As EventArgs) Handles btnElementos.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
        OpenChildForm(FormElementos)
    End Sub

    Private Sub btnFuerzas_Click(sender As Object, e As EventArgs) Handles btnFuerzas.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
        OpenChildForm(FormFuerzas)
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        ActivarBoton(sender, Color.FromArgb(27, 153, 139))
        OpenChildForm(FormResultados)
    End Sub

    Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Lectura de los datos de entrada
        nodos = FormDatos.nudNodos.Value
        elementos = FormDatos.nudElementos.Value

        'Lectura de Datos Nodos
        ReDim vnodo(nodos), vrestriccion(2 * nodos)
        For i = 1 To nodos
            nodoId = FormNodos.dgvJoints.Rows(i - 1).Cells(0).Value
            _x = FormNodos.dgvJoints.Rows(i - 1).Cells(1).Value
            _y = FormNodos.dgvJoints.Rows(i - 1).Cells(2).Value
            vnodo(i) = New Nodo(nodoId, _x, _y)
            If FormNodos.dgvJoints.Rows(i - 1).Cells(3).Value = True Then
                vrestriccion(2 * i - 1) = New Restriccion(2 * i - 1, nodoId, True)
            Else
                vrestriccion(2 * i - 1) = New Restriccion(2 * i - 1, nodoId, False)
            End If
            If FormNodos.dgvJoints.Rows(i - 1).Cells(4).Value = True Then
                vrestriccion(2 * i) = New Restriccion(2 * i, nodoId, True)
            Else
                vrestriccion(2 * i) = New Restriccion(2 * i, nodoId, False)
            End If
        Next

        'Lectura de Datos de Elementos
        ReDim velemento(elementos)
        For i = 1 To elementos
            elementoId = FormElementos.dgvElementos.Rows(i - 1).Cells(0).Value
            nodoInicio = FormElementos.dgvElementos.Rows(i - 1).Cells(1).Value
            nodoFinal = FormElementos.dgvElementos.Rows(i - 1).Cells(2).Value
            areaElem = FormElementos.dgvElementos.Rows(i - 1).Cells(3).Value
            modElem = FormElementos.dgvElementos.Rows(i - 1).Cells(4).Value
            velemento(i) = New Elemento(elementoId, vnodo(nodoInicio), vnodo(nodoFinal), areaElem, modElem)


        Next


        'Lectura de Datos de Cargas
        ReDim vcarga(nodos)
        Dim CargaX As Double, CargaY As Double
        For i = 1 To nodos
            nodoId = FormFuerzas.dgvCargas.Rows(i - 1).Cells(0).Value
            CargaX = FormFuerzas.dgvCargas.Rows(i - 1).Cells(1).Value
            CargaY = FormFuerzas.dgvCargas.Rows(i - 1).Cells(2).Value
            vcarga(i) = New Carga(nodoId, CargaX, CargaY)
        Next

        'Lectura de Restricciones en Grados de Libertad (Apoyos)



        'Crear estructura de cercha compuesta de objetos de elementos
        Dim estructura As Cercha = New Cercha(vnodo, velemento, vcarga, vrestriccion)

        'Solucion del sistema de ecuaciones




        'Crear dibujo de la cercha
        Dim W As Double, H As Double, maxCoordenada As Double
        Dim xInicial As Double, yInicial As Double
        W = FormResultados.picBoxDiagram.Size.Width
        H = FormResultados.picBoxDiagram.Size.Height
        xInicial = 0.1 * W
        yInicial = 0.9 * H
        maxCoordenada = FindMax(vnodo, nodos)
        Dim coordenadasDibujo(,) As Double = Extraer_coordenadas(velemento, elementos, xInicial, yInicial, maxCoordenada, W, H)
        'Establecer coordenadas del area del dibujo


        FormResultados.DrawImage(coordenadasDibujo)

    End Sub

    Private Function Extraer_coordenadas(ByVal vectorElem() As Elemento, cantElementos As Integer, xInicio As Double, yInicio As Double, maximo As Double, ancho As Double, altura As Double) As Double(,)
        Dim coordenadas(cantElementos, 4) As Double
        For i = 1 To cantElementos
            'X Inicial
            coordenadas(i, 1) = xInicio + vectorElem(i).Ni.x * 0.8 * ancho / maximo
            'Y Inicial
            coordenadas(i, 2) = yInicio - vectorElem(i).Ni.y * 0.8 * altura / maximo
            'X Final
            coordenadas(i, 3) = xInicio + vectorElem(i).Nj.x * 0.8 * ancho / maximo
            'Y Final
            coordenadas(i, 4) = yInicio - vectorElem(i).Nj.y * 0.8 * altura / maximo
        Next

        Return coordenadas
    End Function

    Private Function FindMax(ByVal vector() As Nodo, ByVal cantNodos As Integer) As Double
        Dim maxValue As Double, maxX As Double, maxY As Double

        'Valores Iniciales
        maxX = 0
        maxY = 0

        'Encontrar en maximo valor en el vector X
        For i = 1 To cantNodos
            maxX = Math.Max(maxX, vector(i).x)
        Next

        For i = 1 To cantNodos
            maxY = Math.Max(maxY, vector(i).y)
        Next

        maxValue = Math.Max(maxX, maxY)

        Return maxValue
    End Function
End Class
